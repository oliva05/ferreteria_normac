using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.LogisticaJaguar;
using JAGUAR_PRO.Mantenimientos.Modelos;
using JAGUAR_PRO.Mantenimientos.ProductoTerminado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO.Facturacion.Entrega
{
    public partial class frmEntregaGestion : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        int IdBodega;
        int IdH;

        PDV PuntoVentaActual;
        public frmEntregaGestion(UserLogin userLogin, int idH, int idBodega, PDV puntoventa)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
            PuntoVentaActual = puntoventa;
            IdBodega = idBodega;
            IdH = idH;

            Bodega bodegas = new Bodega();
            if (bodegas.RecuperarRegistro(IdBodega))
            {
                txtBodega.Text = bodegas.Descripcion;
            }
            else
            {
                txtBodega.Text = "Bodega no encontrada";
            }

            PedidoCliente pedidoCliente = new PedidoCliente();
            if (pedidoCliente.RecuperarRegistro(IdH))
            {
                txtNumDocumento.Text = pedidoCliente.NumeroDocumento;
                txtClienteNombre.Text = pedidoCliente.ClienteNombre;
                txtDireccion.Text = pedidoCliente.direccion_cliente;
                if (pedidoCliente.IdFactura > 0)
                {
                    Factura factura = new Factura();
                    factura.RecuperarRegistro(pedidoCliente.IdFactura);
                    txtNumFactura.Text = factura.NumeroDocumento;
                }

                LoadDataDetalle();

            }

            
        }

        private void LoadDataDetalle()
        {
            try
            {
                string query = @"[sp_get_rows_from_pedido_entrega]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", IdH);
                cmd.Parameters.AddWithValue("@IdBodega", IdBodega);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsEntregaPedidos1.detalle_entrega_gestion.Clear();
                adat.Fill(dsEntregaPedidos1.detalle_entrega_gestion);
                conn.Close();
            }
            catch (Exception esd)
            {
                CajaDialogo.Error(esd.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (IdH > 0) //Con esto valido si es un Pedido Valido
            {
                bool Error = false;
                string Mensaje = string.Empty;
                bool Permitir = false;
                foreach (dsEntregaPedidos.detalle_entrega_gestionRow item in dsEntregaPedidos1.detalle_entrega_gestion)
                {
                    if (item.cant_a_entregar > item.cant_pendiente)
                    {
                        Error = true;
                        Mensaje = "No puede entregar mas de lo relacionado en el Pedido!";
                        break;
                    }


                    if (item.cant_a_entregar > 0) //Por lo menos un productos mayor que 0;
                    {
                        Permitir = true;
                    }
                }

                if (Error)
                {
                    CajaDialogo.Error(Mensaje);
                    return;
                }

                if (Permitir)
                {
                    try
                    {
                        DataTable DetalleEntregado = dsEntregaPedidos1.detalle_entrega_gestion.Clone();

                        DataOperations dp = new DataOperations();
                        using (SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                        {
                            conn.Open();
                            SqlTransaction transaction = conn.BeginTransaction();
                            try
                            {
                                foreach (dsEntregaPedidos.detalle_entrega_gestionRow row in dsEntregaPedidos1.detalle_entrega_gestion)
                                {
                                    if (row.cant_a_entregar > 0)
                                    {
                                        DetalleEntregado.ImportRow(row);

                                        using (SqlCommand cmd = new SqlCommand("sp_insert_entrega_pedido", conn, transaction))
                                        {
                                            cmd.CommandType = CommandType.StoredProcedure;

                                            cmd.Parameters.AddWithValue("@id_h", IdH);
                                            cmd.Parameters.AddWithValue("@id_detalle", row.id);
                                            cmd.Parameters.AddWithValue("@cant_a_entregar", row.cant_a_entregar);
                                            cmd.Parameters.AddWithValue("@id_pt", row.id_pt);
                                            cmd.Parameters.AddWithValue("@fecha", dp.Now());
                                            cmd.Parameters.AddWithValue("@entrego_todo", row.entregar_todo);
                                            cmd.ExecuteNonQuery();
                                        }
                                    }
                                    
                                }
                                transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                CajaDialogo.Error(ex.Message);
                            }

                            conn.Close();

                            //CajaDialogo.Information("Entregado con Exito!");
                            //LoadDataDetalle();

                            xrptEntrega rpt = new xrptEntrega(IdH, IdBodega, UsuarioLogeado, DetalleEntregado , PuntoVentaActual);
                            ReportPrintTool printTool = new ReportPrintTool(rpt);
                            printTool.Print();

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                    
                }
                else
                {
                    CajaDialogo.Error("La Cantidad a Entregar debe ser mayor que 0");
                    return;
                }
            }

        }


        private void frmEntregaGestion_Shown(object sender, EventArgs e)
        {
            txtCodigBarra.Focus();
        }

        private void txtCodigBarra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string scannedCode = txtCodigBarra.Text.Trim();

                if (!string.IsNullOrEmpty(scannedCode))
                {
                    ProductoTerminado pt = new ProductoTerminado();
                    if (pt.Recuperar_productoByBarCode(scannedCode))
                    {
                        foreach (dsEntregaPedidos.detalle_entrega_gestionRow item in dsEntregaPedidos1.detalle_entrega_gestion.Rows)
                        {
                            if (pt.Code == item.code)
                            {
                                if (item.cant_a_entregar < item.cant_pendiente)
                                {
                                    item.cant_a_entregar = item.cant_a_entregar + 1;
                                }
                                if (item.cant_a_entregar == item.cant_pendiente)
                                {
                                    item.entregar_todo = true;
                                } 
                                else
                                    item.entregar_todo = false;

                            }
                        }
                        txtCodigBarra.Clear();
                        txtCodigBarra.Focus();
                    }

                }
            }

        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string columnName = e.Column.FieldName;

            var row = (dsEntregaPedidos.detalle_entrega_gestionRow)gridView2.GetFocusedDataRow();

            if (columnName == "cant_a_entregar")
            {

            }

           

        }

        private void gridView2_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string columnName = e.Column.FieldName;

            var row = (dsEntregaPedidos.detalle_entrega_gestionRow)gridView2.GetFocusedDataRow();

            if (columnName == "entregar_todo")
            {
                bool Estado = Convert.ToBoolean(e.Value);
                if (Estado)
                {
                    row.cant_a_entregar = row.cant_pendiente;
                }
                else
                {
                    row.cant_a_entregar = 0;
                }
            }

        }

        private void gridView2_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.RowHandle > 0)
            {
                int IdEstado = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "id_estado"));

                switch (IdEstado)
                {
                    case 3:
                        e.Appearance.BackColor = Color.LightGreen;
                        break;

                    case 7:
                        e.Appearance.BackColor = Color.LightYellow;
                        break;

                    case 1: 
                        e.Appearance.BackColor = Color.LightCoral;
                            break;
                    default:
                        break;
                }
            }
        }

        private void chkEntregarTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEntregarTodo.Checked)
            {
                foreach (dsEntregaPedidos.detalle_entrega_gestionRow fila in dsEntregaPedidos1.detalle_entrega_gestion)
                {
                    if (fila.cant_pendiente > 0)
                    {
                        fila.entregar_todo = true;
                        fila.cant_a_entregar = fila.cant_pendiente;
                    }
                }
            }
            else 
            {
                foreach (dsEntregaPedidos.detalle_entrega_gestionRow fila in dsEntregaPedidos1.detalle_entrega_gestion)
                {
                    if (fila.cant_pendiente > 0)
                    {
                        fila.entregar_todo = false;
                        fila.cant_a_entregar = 0;
                    }
                }
            }
        }
    }
}