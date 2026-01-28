using ACS.Classes;
using DevExpress.CodeParser;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Accesos.AutorizacionSingle;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Facturacion.CoreFacturas;
using JAGUAR_PRO.Facturacion.Cotizaciones;
using JAGUAR_PRO.Facturacion.Mantenimientos.Models;
using JAGUAR_PRO.Facturacion.Numeracion_Fiscal;
using JAGUAR_PRO.Facturacion.Reportes;
using JAGUAR_PRO.Mantenimientos;
using JAGUAR_PRO.Mantenimientos.Modelos;
using JAGUAR_PRO.RecuentoInventario;
using JAGUAR_PRO.Utileria;
using LOSA.Calidad.LoteConfConsumo;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Data.Filtering.Helpers.SubExprHelper.ThreadHoppingFiltering;
using static DevExpress.DataProcessing.InMemoryDataProcessor.AddSurrogateOperationAlgorithm;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;
using static JAGUAR_PRO.Clases.BinGranel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace Eatery.Ventas
{
    public partial class frmFacturaView : Form
    {
        DataOperations dp = new DataOperations();
        PDV PuntoDeVentaActual;
        FacturacionEquipo EquipoActual;
        int ProIdCliente;
        ClienteFacturacion ClienteFactura;
        int IdTerminoPago;
        int IdPedido = 0;
        PedidoCliente PedidoRecuperado;
        Vendedor VendedorActual;

        public enum TipoFacturacionStock
        {
            VentaNormal = 1,
            VentaUsados = 2
        }

        UserLogin UsuarioLogeado;
        public enum Busqueda
        {
            LoMasVendido = 1,
            Todos = 2
        }
        Factura FacturaActual;

        public frmFacturaView(UserLogin pUser, PDV pPuntoDeVentaActual, FacturacionEquipo pEquipoActual, Int64 pIdFactura)
        {
            InitializeComponent();
            ClienteFactura = new ClienteFacturacion();

            PuntoDeVentaActual = pPuntoDeVentaActual;
            EquipoActual = pEquipoActual;
            txtVendedor.ReadOnly = true;
            UsuarioLogeado = pUser;

            if (pIdFactura > 0)
            {
                FacturaActual = new Factura();
                if (FacturaActual.RecuperarRegistro(pIdFactura))
                {
                    lblfecha.Text = Convert.ToString(FacturaActual.FechaDocumento);
                    string.Format("{0:dd/MM/yyyy}", lblfecha.Text);

                    txtNombreCliente.Text = FacturaActual.ClienteNombre;
                    txtRTN.Text = FacturaActual.RTN;
                    txtDireccion.Text = FacturaActual.direccion_cliente;

                    string HostName = Dns.GetHostName();
                    PedidoCliente pedido = new PedidoCliente();
                    
                    IdTerminoPago = FacturaActual.IdTerminoPago;

                    if (IdTerminoPago == 1)//Contado
                    {
                        rdContado.CheckedChanged -= new EventHandler(rdContado_CheckedChanged);
                        rdCredito.CheckedChanged -= new EventHandler(rdCredito_CheckedChanged);
                        rdPorCobrar.CheckedChanged -= new EventHandler(rdPorCobrar_CheckedChanged);
                        rdContado.Checked = true;
                        rdCredito.Checked = false;
                        rdPorCobrar.Checked = false;
                        rdCredito.CheckedChanged += new EventHandler(rdCredito_CheckedChanged);
                        rdContado.CheckedChanged += new EventHandler(rdContado_CheckedChanged);
                        rdPorCobrar.CheckedChanged += new EventHandler(rdPorCobrar_CheckedChanged);
                    }

                    if (IdTerminoPago == 2)//Credito
                    {
                        rdContado.CheckedChanged -= new EventHandler(rdContado_CheckedChanged);
                        rdContado.CheckedChanged -= new EventHandler(rdContado_CheckedChanged);
                        rdCredito.CheckedChanged -= new EventHandler(rdCredito_CheckedChanged);
                        rdContado.Checked = false;
                        rdCredito.Checked = true;
                        rdPorCobrar.Checked = false;
                        rdCredito.CheckedChanged += new EventHandler(rdCredito_CheckedChanged);
                        rdContado.CheckedChanged += new EventHandler(rdContado_CheckedChanged);
                        rdContado.CheckedChanged += new EventHandler(rdContado_CheckedChanged);
                    }

                    if (IdTerminoPago == 3)//Por Cobrar
                    {
                        rdContado.CheckedChanged -= new EventHandler(rdContado_CheckedChanged);
                        rdContado.CheckedChanged -= new EventHandler(rdContado_CheckedChanged);
                        rdCredito.CheckedChanged -= new EventHandler(rdCredito_CheckedChanged);
                        rdContado.Checked = false;
                        rdCredito.Checked = false;
                        rdPorCobrar.Checked = true;
                        rdCredito.CheckedChanged += new EventHandler(rdCredito_CheckedChanged);
                        rdContado.CheckedChanged += new EventHandler(rdContado_CheckedChanged);
                        rdContado.CheckedChanged += new EventHandler(rdContado_CheckedChanged);
                    }

                    VendedorActual = new Vendedor();
                    if (VendedorActual.RecuperarRegistro(FacturaActual.IdVendedor))
                    {
                        txtVendedor.Text = VendedorActual.CodigoVendedor + " - " + VendedorActual.Nombre;
                    }

                    CargarDetalleFactura(FacturaActual.Id);

                    //Poner todas las columnas como ReadOnly = true
                    foreach (GridColumn column in gridView1.Columns)
                    {
                        column.OptionsColumn.ReadOnly = true;
                    }
                    gridView1.OptionsMenu.EnableColumnMenu = false;
                }
            }

        }

        private void CargarDetalleFactura(Int64 pdiFactura)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_get_factura_detalle_view]", conn);
                cmd.CommandType = CommandType.StoredProcedure; ;
                cmd.Parameters.AddWithValue("@id_h", pdiFactura);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsVentas1.detalle_factura_transaction.Clear();
                adat.Fill(dsVentas1.detalle_factura_transaction);
                conn.Close();
                //CalcularTotal();
                CalcularTotalFactura();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void CalcularTotal()
        {
            decimal total = 0;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);

                if (Convert.ToBoolean(row["apply_subsidio"]))
                {
                    row["total_fila"] = (Convert.ToDecimal(row["cantidad"]) * Convert.ToDecimal(row["precio"]) - Math.Abs(Convert.ToDecimal(row["subsidio"]))  );
                }
                else
                {
                    row["total_fila"] = ((Convert.ToDecimal(row["cantidad"]) * Convert.ToDecimal(row["precio"])) - Convert.ToDecimal(row["descuento"]) + Convert.ToDecimal(row["isv1"]));
                }
                
                //decimal Totfila = 
                total += Convert.ToDecimal(row["total_fila"]); ;
            }
            txtTotal.Text = string.Format("{0:#,##0.00}", Math.Round(total,2));
        }

        private void timerLimpiarMensaje_Tick(object sender, EventArgs e)
        {
            timerLimpiarMensaje.Stop();
            timerLimpiarMensaje.Enabled = false;
            panelNotificacion.BackColor = Color.White;
            lblMensaje.Text = "";
            
            //cmdNew_Click(sender, e);
        }

        private void frmFacturaView_Activated(object sender, EventArgs e)
        {
            //txtScanProducto.Focus();
        }

        private void frmFacturaView_FormClosing(object sender, FormClosingEventArgs e){ }


        private void navigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsVentas.detalle_factura_transactionRow)gridView.GetFocusedDataRow();
            switch (e.Column.FieldName)
            {
                case "cantidad":
                    
                    if (row.cantidad > 0)
                    {
                        //No permitiremos facturar mas que lo que hay en inventario
                        if(row.cantidad > row.inventario)
                        {
                            //row.cantidad = dp.ValidateNumberDecimal(e.OldValue);
                            row.SetColumnError("cantidad", "No se puede facturar una cantidad mayor al inventario actual!");
                        }
                        else
                        {
                            row.ClearErrors();
                        }
                    }
                    break;
                case "descuento":
                    decimal vDescuento = dp.ValidateNumberDecimal(e.Value);

                    if (vDescuento < 0)
                    {
                        CajaDialogo.Error("No se permite valores menores a cero (0)!");
                        return;
                    }

                    if (vDescuento > 100)
                    {
                        CajaDialogo.Error("No se permite valores mayores a cien (100)!");
                        return;
                    }


                    decimal vPorcentajeDescuento = PuntoDeVentaActual.RecuperarMaximoDescuentoItem(row.id_pt, PuntoDeVentaActual.ID, this.ClienteFactura.Id);

                    if (vDescuento > vPorcentajeDescuento)
                    {
                        CajaDialogo.Error("No se permite un descuento mayor al permitido!");
                        row.descuento = 0;
                        return;
                    }

                    decimal vDescuentoLinea = ((row.cantidad * row.precio) * (vDescuento / 100));
                    row.descuento = vDescuentoLinea;

                    //recalculamos 
                    break;
            }
            CalcularTotalFactura();
        }

        decimal CalcularTotalFactura()
        {
            decimal total = 0;  
            foreach(dsVentas.detalle_factura_transactionRow row in dsVentas1.detalle_factura_transaction)
            {
                //row.total_linea = row.cantidad * (row.precio - row.descuento);
               // row.total_linea = (row.cantidad * (row.precio - row.descuento)) + (row.cantidad * row.isv1) + (row.cantidad * row.isv2) + (row.cantidad * row.isv3);
                total += row.total_linea;    
            }

            txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(total,2));
            return total;
        }


        private void rdContado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdContado.Checked)
            {
                rdContado.CheckedChanged -= new EventHandler(rdContado_CheckedChanged);
                rdCredito.CheckedChanged -= new EventHandler(rdCredito_CheckedChanged); 
                rdPorCobrar.CheckedChanged -= new EventHandler(rdPorCobrar_CheckedChanged);
                rdCredito.Checked = false;
                rdPorCobrar.Checked = false;
                IdTerminoPago = 1;
                rdPorCobrar.CheckedChanged += new EventHandler(rdPorCobrar_CheckedChanged);
                rdCredito.CheckedChanged += new EventHandler(rdCredito_CheckedChanged);
                rdContado.CheckedChanged += new EventHandler(rdContado_CheckedChanged);
            }
        }

        private void rdCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCredito.Checked)
            {
                rdCredito.CheckedChanged -= new EventHandler(rdPorCobrar_CheckedChanged);
                rdPorCobrar.CheckedChanged -= new EventHandler(rdPorCobrar_CheckedChanged);
                rdContado.CheckedChanged -= new EventHandler(rdContado_CheckedChanged);
                rdContado.Checked = false;
                rdPorCobrar.Checked = false;
                IdTerminoPago = 2;
                rdContado.CheckedChanged += new EventHandler(rdContado_CheckedChanged);
                rdPorCobrar.CheckedChanged += new EventHandler(rdPorCobrar_CheckedChanged);
                rdCredito.CheckedChanged += new EventHandler(rdPorCobrar_CheckedChanged);
            }
        }

        private void txtVendedor_DoubleClick(object sender, EventArgs e)
        {
            frmLoginVendedores frmLogin1 = new frmLoginVendedores();
            if (frmLogin1.ShowDialog() == DialogResult.OK)
            {
                txtVendedor.Text = frmLogin1.CodigoVendedor + " - " + frmLogin1.NombreVendedor;
                VendedorActual = frmLogin1.Vendedor_;
                this.UsuarioLogeado = new UserLogin();
                if (UsuarioLogeado.RecuperarRegistro(VendedorActual.Id))
                {

                }
            }
        }

        private void rdPorCobrar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPorCobrar.Checked)
            {
                rdPorCobrar.CheckedChanged -= new EventHandler(rdPorCobrar_CheckedChanged);
                rdCredito.CheckedChanged -= new EventHandler(rdCredito_CheckedChanged);
                rdContado.CheckedChanged -= new EventHandler(rdContado_CheckedChanged);
                rdContado.Checked = false;
                rdCredito.Checked = false;
                IdTerminoPago = 3;
                rdPorCobrar.CheckedChanged += new EventHandler(rdPorCobrar_CheckedChanged);
                rdContado.CheckedChanged += new EventHandler(rdContado_CheckedChanged);
                rdCredito.CheckedChanged += new EventHandler(rdCredito_CheckedChanged);
            }
        }

    }
}