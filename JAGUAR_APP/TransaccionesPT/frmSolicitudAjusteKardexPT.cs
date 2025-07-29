using ACS.Classes;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.WinExplorer.ViewInfo;
using JAGUAR_PRO.Calidad.LoteConfConsumo;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.LogisticaJaguar;
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

namespace JAGUAR_PRO.TransaccionesPT
{
    public partial class frmSolicitudAjusteKardexPT : DevExpress.XtraEditors.XtraForm
    {
        public enum TipoOperacion
        {
            Solicitud =1,
            Aprobacion =2,
            CreacionDirecta = 3
        }
        int IdSOlicitud = 0;
        UserLogin UsuarioLogueado;
        TipoOperacion Operacion;

        public frmSolicitudAjusteKardexPT(frmSolicitudAjusteKardexPT.TipoOperacion pTipo, UserLogin userLogin, int idSolicitud)
        {
            InitializeComponent();
            UsuarioLogueado = userLogin;
            Operacion = pTipo;

            IdSOlicitud = idSolicitud;
            txtUsuario.Text = UsuarioLogueado.Nombre;
            LoadBodegaList();
            switch (Operacion)
            {
                case TipoOperacion.Solicitud:
                    lblTitulo.Text = "Solicitud de Ajuste de Inventario";
                    txtNumSolicitud.Visible = false;
                    labelControl1.Visible = false;
                    break;
                case TipoOperacion.Aprobacion:
                    lblTitulo.Text = "Solicitud de Ajuste de Inventario: Aprobacion";
                    SolicitudAjustes solicitud = new SolicitudAjustes();
                    solicitud.RecuperarRegistros(idSolicitud);
                    IdSOlicitud = solicitud.Id;
                    txtDescr.Text = solicitud.Comentario;
                    txtDescr.Enabled = false;
                    txtNumSolicitud.Text = solicitud.DocNum;
                    txtUsuario.Text = solicitud.nameUsuarioSolicitante;
                    lblUsuario.Text = "Solicitado por___________";
                    cmdGuardar.Text = "Aprobar";
                    cmdAgregarItems.Visible = false;
                    btnRechazar.Visible = true;
                    gridView2.OptionsBehavior.Editable = false;
                    CargarDetalle();

                    break;
                case TipoOperacion.CreacionDirecta:
                    lblTitulo.Text = "Creacion Ajuste de Inventario";
                    cmdGuardar.Text = "Crear";
                    btnRechazar.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void CargarDetalle()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_detalle_solicitud_ajuste_inventario",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdSOlicitud", IdSOlicitud);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPT1.ajuste_inventario_detalle.Clear();
                adat.Fill(dsPT1.ajuste_inventario_detalle);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadBodegaList()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[sp_get_bodegas_id_descripcion]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_proveedor", pIdProveedor);
                dsLogisticaJaguar1.bodegas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLogisticaJaguar1.bodegas);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (gridView2.RowCount == 0)
            {
                CajaDialogo.Error("Debe agregar por lo menos un Producto!");
                return;
            }
            bool Guardar = false;

            foreach (dsPT.ajuste_inventario_detalleRow item in dsPT1.ajuste_inventario_detalle)
            {
                if(item.id_almacen == 0)
                {
                    CajaDialogo.Error("Debe seleccionar un Almacen!");
                    return;
                }

                if (item.cantidad == 0)
                {
                    CajaDialogo.Error("El Producto debe ser mayor que 0");
                    return;
                }


                if (item.tipo_op == "Salida")
                {
                    if (item.cantidad > item.inventario)
                    {
                        CajaDialogo.Error("Operación inválida: esta acción dejaría el inventario por debajo de cero.\n" + item.ItemCode+"-"+item.descripcion+" .\nCantidad Salida: "+item.cantidad+"\nInventario Actual: "+item.inventario);
                        return;
                    }
                }
            }



            DataOperations dp = new DataOperations();
            SqlTransaction transaction = null;
            SqlConnection conn = null;
            SqlCommand cmd = null;
            switch (Operacion)
            {
                case TipoOperacion.Solicitud:

                    conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    
                    try
                    {
                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        cmd = conn.CreateCommand();
                        cmd.CommandText = "sp_Insert_Kardex_Solicitud_Ajuste_h";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@comentario",txtDescr.Text.Trim());
                        cmd.Parameters.AddWithValue("@usuario_solicitante",UsuarioLogueado.Id);

                        int id_header = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (dsPT.ajuste_inventario_detalleRow row in dsPT1.ajuste_inventario_detalle.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "sp_Insert_Solicitud_Ajuste_Con_Detalle";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_solicitud_h", id_header);
                            if (row.tipo_op == "Entrada")
                                cmd.Parameters.AddWithValue("@tipo_op", 1);
                            else
                                cmd.Parameters.AddWithValue("@tipo_op", 0);

                            cmd.Parameters.AddWithValue("@id_tipo_transaccion", DBNull.Value);
                            cmd.Parameters.AddWithValue("@id_pt", row.id_pt);
                            cmd.Parameters.AddWithValue("@ItemCode", row.ItemCode);
                            switch (row.tipo_op)
                            {
                                case "Entrada":
                                    cmd.Parameters.AddWithValue("@entrada", row.cantidad);
                                    cmd.Parameters.AddWithValue("@salida", 0);
                                    break;

                                case "Salida":
                                    cmd.Parameters.AddWithValue("@entrada", 0);
                                    cmd.Parameters.AddWithValue("@salida", row.cantidad);
                                    break;
                                default:
                                    break;
                            }
                            cmd.Parameters.AddWithValue("@lote", DBNull.Value);
                            cmd.Parameters.AddWithValue("@id_almacen", row.id_almacen);
                            cmd.Parameters.AddWithValue("@id_presentacion", 1);
                            cmd.Parameters.AddWithValue("@id_referencia_transaccion", DBNull.Value);
                            cmd.ExecuteNonQuery();
                        }


                        transaction.Commit();
                        Guardar = true;

                        CajaDialogo.Information("Soliciutd Creada con Exito!\nSolicite a su Gerente la Aprobacion");

                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    catch (Exception ec)
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ec.Message);
                        Guardar = false;
                    }


                    break;
                case TipoOperacion.Aprobacion:

                    RespuestaGestionSolicitud("Aprobado");
                    
                    break;
                case TipoOperacion.CreacionDirecta:

                    conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

                    try
                    {
                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        cmd = conn.CreateCommand();
                        cmd.CommandText = "[sp_Insert_Kardex_Solicitud_Ajuste_h_creacion]";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@comentario", txtDescr.Text.Trim());
                        cmd.Parameters.AddWithValue("@usuario_solicitante", UsuarioLogueado.Id);

                        int id_header = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (dsPT.ajuste_inventario_detalleRow row in dsPT1.ajuste_inventario_detalle.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "[sp_Insert_Solicitud_Ajuste_Con_Detalle_Y_CargaInventario]";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_solicitud_h", id_header);
                            if (row.tipo_op == "Entrada")
                                cmd.Parameters.AddWithValue("@tipo_op", 1);
                            else
                                cmd.Parameters.AddWithValue("@tipo_op", 0);

                            cmd.Parameters.AddWithValue("@id_tipo_transaccion", DBNull.Value);
                            cmd.Parameters.AddWithValue("@id_pt", row.id_pt);
                            cmd.Parameters.AddWithValue("@ItemCode", row.ItemCode);
                            switch (row.tipo_op)
                            {
                                case "Entrada":
                                    cmd.Parameters.AddWithValue("@entrada", row.cantidad);
                                    cmd.Parameters.AddWithValue("@salida", 0);
                                    break;

                                case "Salida":
                                    cmd.Parameters.AddWithValue("@entrada", 0);
                                    cmd.Parameters.AddWithValue("@salida", row.cantidad);
                                    break;
                                default:
                                    break;
                            }
                            cmd.Parameters.AddWithValue("@lote", DBNull.Value);
                            cmd.Parameters.AddWithValue("@id_almacen", row.id_almacen);
                            cmd.Parameters.AddWithValue("@id_presentacion", 1);
                            cmd.Parameters.AddWithValue("@id_referencia_transaccion", DBNull.Value);
                            cmd.ExecuteNonQuery();
                        }

                        cmd.Parameters.Clear();
                        cmd.CommandText = "sp_Insert_Solicitud_Ajuste_Inventario";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_solicitud_h", id_header);
                        cmd.Parameters.AddWithValue("@user_id",UsuarioLogueado.Id);
                        cmd.ExecuteNonQuery();


                        transaction.Commit();
                        Guardar = true;

                        CajaDialogo.Information("Ajuste creada con Exito!");

                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    catch (Exception ec)
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ec.Message);
                        Guardar = false;
                    }

                    break;
                default:
                    break;
            }
        }

        private void RespuestaGestionSolicitud(string Respuesta)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ajuste_gestion_solicitud", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idSolicitud", IdSOlicitud);
                cmd.Parameters.AddWithValue("@Respuesta", Respuesta);
                cmd.Parameters.AddWithValue("@user", UsuarioLogueado.Id);
                cmd.ExecuteNonQuery();

                switch (Respuesta)
                {
                    case "Aprobado":
                        CajaDialogo.Information("Ajuste realizado en Inventario!");
                        break;

                    case "Rechazar":
                        CajaDialogo.Information("Ajuste Rechazado!");
                        break;
                    default:
                        break;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdAgregarItems_Click(object sender, EventArgs e)
        {
            DataTable tablaPT = new DataTable();
            frmSearchItemsMulti frm = new frmSearchItemsMulti();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                tablaPT = frm.ListProductosSeleccionados;
            }

            int count_lines = dsPT1.ajuste_inventario_detalle.Rows.Count;
            ProductoTerminado pt = new ProductoTerminado();
            foreach (DataRow item in tablaPT.Rows)
            {
                //bool yaExiste = dsPT1.ajuste_inventario_detalle.AsEnumerable()
                //                .Any(p => p.id_pt == (int)item["id"]);

            //if (!yaExiste)
            //{
                dsPT.ajuste_inventario_detalleRow row1 = dsPT1.ajuste_inventario_detalle.Newajuste_inventario_detalleRow();
                row1.id_solicitud_h = 0;
                row1.tipo_op = "Entrada";
                row1.id_tipo_transaccion = 0;
                row1.id_pt = Convert.ToInt32(item["id"]);
                row1.ItemCode = item["code"].ToString();
                row1.cantidad = 0;
                row1.lote = string.Empty;
                row1.id_almacen = pt.GetAlmacenDefault(Convert.ToInt32(item["id"]));
                row1.id_referencia_transaccion = 0;
                row1.num_linea = count_lines + 1;
                row1.descripcion = item["descripcion"].ToString();
                row1.id_presentacion = 1;
                pt.Recuperar_producto(Convert.ToInt32(item["id"]));
                row1.code_referencia = pt.Codig_Referencia;
                row1.marca = pt.MarcaName;
                row1.inventario = pt.CantInventarioKardex;
                dsPT1.ajuste_inventario_detalle.Addajuste_inventario_detalleRow(row1);
                dsPT1.AcceptChanges();
                //}
            }

            if (dsPT1.ajuste_inventario_detalle.Count > 1)
            {
                int filai = 1;
                foreach (dsPT.ajuste_inventario_detalleRow row in dsPT1.ajuste_inventario_detalle.Rows)
                {
                    row.num_linea = filai;
                    filai++;
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rpsBtnAlmacenes_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsPT.ajuste_inventario_detalleRow)gridview.GetFocusedDataRow();

            if (row != null) 
            {
                frmSelectAlmacen frm = new frmSelectAlmacen(row.id_pt);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    row.id_almacen = frm.IdAlmacen;
                }
            }
        }

        private void txtDescr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmdAgregarItems_Click(sender, e);
            }
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Desea rechazar esta solicitud?");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            switch (Operacion)
            {
                case TipoOperacion.Solicitud:
                    break;
                case TipoOperacion.Aprobacion:
                    RespuestaGestionSolicitud("Rechazar");

                    break;
                case TipoOperacion.CreacionDirecta:
                    break;
                default:
                    break;
            }
        }

        private void rpsBtnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Desea eliminar este producto de la orden.");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            var gridView2 = (GridView)gridControl1.FocusedView;
            var row = (dsPT.ajuste_inventario_detalleRow)gridView2.GetFocusedDataRow();

            switch (Operacion)
            {
                case TipoOperacion.Solicitud:

                    try
                    {
                        gridView2.DeleteRow(gridView2.FocusedRowHandle);
                        dsPT1.AcceptChanges();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    break;
                case TipoOperacion.Aprobacion:

                    try
                    {
                        gridView2.DeleteRow(gridView2.FocusedRowHandle);
                        dsPT1.AcceptChanges();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    break;
                case TipoOperacion.CreacionDirecta:

                    try
                    {
                        gridView2.DeleteRow(gridView2.FocusedRowHandle);
                        dsPT1.AcceptChanges();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}