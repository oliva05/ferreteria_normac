using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_PRO.Accesos.AutorizacionSingle;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Facturacion.Mantenimientos.Models;
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

namespace JAGUAR_PRO.Facturacion.CoreFacturas
{
    public partial class frmDatosExoneracion_factura : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        long IdPedido = 0;
        PedidoCliente PedidoRecuperado;

        public frmDatosExoneracion_factura(UserLogin pUser, long pIdPedido)
        {
            InitializeComponent();

            UsuarioLogeado = pUser;
            string HostName = Dns.GetHostName();

            PedidoCliente Pedido1 = new PedidoCliente();
            if (Pedido1.RecuperarRegistro(pIdPedido))
            {
                IdPedido = pIdPedido;

                PedidoRecuperado = Pedido1;

                if (!string.IsNullOrEmpty(Pedido1.ClienteNombre))
                    txtNombreCliente.Text = Pedido1.ClienteNombre;

                if (!string.IsNullOrEmpty(Pedido1.direccion_cliente))
                    txtDireccion.Text = Pedido1.direccion_cliente;

                if (!string.IsNullOrEmpty(Pedido1.RTN))
                    txtRTN.Text = Pedido1.RTN;
                else
                    txtRTN.Text = "";

                CargarDetalleCotizacion(pIdPedido);
                CalcularTotalFactura();
                //Poner todas las columnas como ReadOnly = true
                foreach (GridColumn column in gridView1.Columns)
                {
                    column.OptionsColumn.ReadOnly = true;
                }
                gridView1.OptionsMenu.EnableColumnMenu = false;
            }
        }

        private void CargarDetalleCotizacion(long pIdCotizacion)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_get_pedido_detalle_for_factura_final_with_inv]", conn);
                cmd.CommandType = CommandType.StoredProcedure; ;
                cmd.Parameters.AddWithValue("@id_h", pIdCotizacion);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsVentas1.detalle_factura_transaction.Clear();
                adat.Fill(dsVentas1.detalle_factura_transaction);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        decimal CalcularTotalFactura()
        {
            decimal total = 0;
            foreach (dsVentas.detalle_factura_transactionRow row in dsVentas1.detalle_factura_transaction)
            {
                row.total_linea = (row.cantidad * row.precio) - row.descuento;
                row.total_linea = ((row.cantidad * row.precio) - row.descuento) + (row.cantidad * row.isv1) + (row.cantidad * row.isv2) + (row.cantidad * row.isv3);
                total += row.total_linea;
            }

            //txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(total, 2));
            return total;
        }

        private void cmdAplicarExoneracion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gv = (GridView)gridControl1.FocusedView;
            var row = (dsVentas.detalle_factura_transactionRow)gv.GetDataRow(gv.FocusedRowHandle);

            row.isv1 = 0;
            row.isv2 = 0;
            row.isv3 = 0;

            row.total_linea = row.cantidad * (row.precio - row.descuento);
        }

        private void cmdAplicarExoneracionTodaLaFactura_Click(object sender, EventArgs e)
        {
            foreach(dsVentas.detalle_factura_transactionRow row in dsVentas1.detalle_factura_transaction)
            {
                row.isv1 = 0;
                row.isv2 = 0;
                row.isv3 = 0;

                row.total_linea = row.cantidad * (row.precio - row.descuento);
            }
        }

        private void btnConfirmarAutorizacionDirecta_Click(object sender, EventArgs e)
        {
            int contador = 0;
            if (!string.IsNullOrEmpty(txtOrdenCompra.Text))
            {
                contador++;
            }

            if (!string.IsNullOrEmpty(txtConstancia.Text))
            {
                contador++;
            }

            if (!string.IsNullOrEmpty(txtRegistroSAG.Text))
            {
                contador++;
            }

            if(contador == 0)
            {
                CajaDialogo.Error("Es necesario ingresar al menos un dato para exonerar, Orden de compra, constancia o registro de exonerado!");
                txtOrdenCompra.Focus();
                return;
            }

            bool accesoprevio = false;
            bool AccesoAdmin = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = AccesoAdmin = true;
                    //Update Pedido
                    UpdatePedido();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                frmAutorizacionSingle frm = new frmAutorizacionSingle();
                if (frm.ShowDialog() == DialogResult.OK) 
                {
                    //Update Pedido
                    UpdatePedido();
                }
            }
        }

        private void UpdatePedido()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelarAutorizacionDirecta_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}