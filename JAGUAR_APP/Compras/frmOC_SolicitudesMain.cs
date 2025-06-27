using ACS.Classes;
using JAGUAR_PRO.Clases;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Calidad.LoteConfConsumo;
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
using JAGUAR_PRO.Compras;
using DevExpress.XtraRichEdit.Internal;
using DevExpress.XtraGauges.Core.Primitive;

namespace JAGUAR_PRO.Compras
{
    public partial class frmOC_SolicitudesMain : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();
        PDV PuntoDeVentaActual;
        TipoOperacion tipooperacion;
        int IdSolicitud = 0;
        string direccion;
        int PuntoVentaID;
        int IdEstado;
        public enum TipoOperacion
        {
            New = 1,
            Update = 2
        }

        public frmOC_SolicitudesMain(UserLogin pUserLog, PDV pPuntoDeVentaActual)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLog;
            PuntoDeVentaActual = pPuntoDeVentaActual;
            txtUsuarioCreador.Text = UsuarioLogueado.Nombre;
            LoadSucursales();
            grdSucursales.EditValue = PuntoDeVentaActual.ID;
            txtEstado.Text = "Creado";
            tipooperacion = TipoOperacion.New;
            labelControl7.Visible = false;
            txtDocNum.Visible = false;
            LoadPresentacion();
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            //ValidarAccesosSegunUsuario();
        }

        private void LoadPresentacion()
        {
            try
            {
                string query = @"[sp_get_unidad_medida]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.unidad_medida.Clear();
                adat.Fill(dsCompras1.unidad_medida);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadSucursales()
        {
            try
            {
                string query = @"[sp_get_lista_puntos_de_venta]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.sucursales.Clear();
                adat.Fill(dsCompras1.sucursales);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LimpiarControles()
        {
            tipooperacion = TipoOperacion.New;
            dtFechaContabilizacion.Value = dp.Now();
            dtFechaRegistro.Value = dp.Now();
            txtEstado.Text = "Creada";
            IdSolicitud = 0;
            txtComentarios.Clear();
            txtComentarios.Enabled = true;
            grDetalle.Enabled = true;
            dtFechaContabilizacion.Enabled = true;
            cmdGuardar.Enabled = true;
            cmdAddDetalle.Enabled = true;
            txtUsuarioCreador.Text = UsuarioLogueado.Nombre;
            dsCompras1.solicitud_compras_detalle.Clear();
            txtDocNum.Clear();
            btnPrint.Enabled = false;
            labelControl7.Visible = false;
            txtDocNum.Visible = false;
            //GetSigID();

        }

        private void cmdAddDetalle_Click(object sender, EventArgs e)
        {
            frmSearchDefault frm = new frmSearchDefault(frmSearchDefault.TipoBusqueda.ProductoTerminado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                switch (tipooperacion)
                {
                    case TipoOperacion.New:
                        bool Agregar = true;

                        foreach (dsCompras.solicitud_compras_detalleRow item in dsCompras1.solicitud_compras_detalle)
                        {

                            if (item.itemcode == frm.ItemSeleccionado.ItemCode)
                            {
                                item.cantidad = item.cantidad + 1;
                                Agregar = false;

                            }
                        }

                        if (Agregar)
                        {
                            DataRow dr = dsCompras1.solicitud_compras_detalle.NewRow();
                            dr[0] = frm.ItemSeleccionado.ItemCode;
                            dr[1] = frm.ItemSeleccionado.ItemName;
                            dr[2] = 1;
                            dr[3] = 1;
                            dr[4] = 0;
                            //dr[6] = 0;
                            dsCompras1.solicitud_compras_detalle.Rows.Add(dr);
                        }
                        break;
                    case TipoOperacion.Update:

                        break;
                    default:
                        break;
                }

            }
        }

        private void ButtonDeleteRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //DialogResult r = CajaDialogo.Pregunta("Confirma que desea elminar este registro?");
            //if (r != DialogResult.Yes)
            //{
            //    return;
            //}

            var grdvDetalle = (GridView)grDetalle.FocusedView;
            var row = (dsCompras.solicitud_compras_detalleRow)grdvDetalle.GetFocusedDataRow();


            if (row.id_detalle > 0)
            {
                try
                {
                    string a = @"[sp_compras_solicitud_oc_delete_detalle]";
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(a, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_detalle", row.id_detalle);
                    cmd.ExecuteNonQuery();

                    CargarDetalleOrdenCompra(IdSolicitud);
                    CalcularTotal();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            else
            {
                try
                {
                    grdvDetalle.DeleteRow(grdvDetalle.FocusedRowHandle);
                    dsCompras1.AcceptChanges();
                    CalcularTotal();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }

        }

        private void CalcularTotal()
        {
            

        }

        private void CargarDetalleOrdenCompra(int idSolicitudSeleccionado)
        {

            try
            {
                string query = @"[sp_get_oc_solicitudes_detalle]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_solicitud", idSolicitudSeleccionado);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.solicitud_compras_detalle.Clear();
                adat.Fill(dsCompras1.solicitud_compras_detalle);
                conn.Close();

                CalcularTotal();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmSearchOrdenesC frm = new frmSearchOrdenesC(frmSearchOrdenesC.FiltroOrdenesCompra.Todas, PuntoDeVentaActual, UsuarioLogueado, frmSearchOrdenesC.TipoDoc.SolicitudCompra);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarInfoOrden(frm.IdOrdenesSeleccionado);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtComentarios.Text))
            {
                CajaDialogo.Error("Debe agregar un comentario!");
                return;
            }

            if (grdvDetalle.RowCount == 0)
            {
                CajaDialogo.Error("Debe seleccionar 1 Producto!");
                return;
            }

            foreach (dsCompras.solicitud_compras_detalleRow item in dsCompras1.solicitud_compras_detalle.Rows)
            {
                if (item.cantidad <= 0)
                {
                    CajaDialogo.Error("Cantidad debe ser Mayor que (0)!");
                    return;
                }
            }

            switch (tipooperacion)
            {
                case TipoOperacion.New:
                    bool Guardar = false;
                    SqlTransaction transaction = null;

                    SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

                    try
                    {
                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "[sp_compras_solicitud_insert]";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@comentario",txtComentarios.Text);
                        cmd.Parameters.AddWithValue("@fecha_registro",dtFechaRegistro.Value);
                        cmd.Parameters.AddWithValue("@id_estado", 1);//Creada
                        cmd.Parameters.AddWithValue("@id_user_cre",UsuarioLogueado.Id);
                        cmd.Parameters.AddWithValue("@fecha_contabilizacion",dtFechaContabilizacion.Value);
                        cmd.Parameters.AddWithValue("@id_punto_venta",grdSucursales.EditValue);

                        int id_header = Convert.ToInt32(cmd.ExecuteScalar());

                        //cmd.Parameters.Clear();
                        //cmd.CommandText = "sp_compras_insert_log_autorizacion";
                        //cmd.Connection = conn;
                        //cmd.Transaction = transaction;
                        //cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@id_orden_compra", id_header);
                        //cmd.Parameters.AddWithValue("@user_id", UsuarioLogueado.Id);
                        //cmd.Parameters.AddWithValue("@fecha", dp.Now());
                        //cmd.ExecuteNonQuery();

                        foreach (dsCompras.solicitud_compras_detalleRow row in dsCompras1.solicitud_compras_detalle.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "[sp_compras_solicitud_detalle_insert]";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_header_orden", id_header);
                            //cmd.Parameters.AddWithValue("@id_pt", row.);
                            cmd.Parameters.AddWithValue("@itemcode", row.itemcode);
                            cmd.Parameters.AddWithValue("@descripcion", row.descripcion);
                            cmd.Parameters.AddWithValue("@cantidad", row.cantidad);
                            cmd.Parameters.AddWithValue("@id_unidad_medida",row.id_unidad_medida);
                            cmd.Parameters.AddWithValue("@fecha_creacion", dp.Now());
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        Guardar = true;



                    }
                    catch (Exception ec)
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ec.Message);
                        Guardar = false;
                    }

                    if (Guardar)
                    {
                        CajaDialogo.Information("Orden de Compra Creada!");
                        LimpiarControles();
                    }

                    break;
                case TipoOperacion.Update:
                    break;
                default:
                    break;
            }
        }
        private void CargarInfoOrden(int pidOrdenesSeleccionado)
        {
            SolicitudOC oc = new SolicitudOC();
            if (oc.RecuperarRegistros(pidOrdenesSeleccionado))
            {
                txtUsuarioCreador.Text = oc.UsuarioCreacion;
                txtDocNum.Text = oc.DocNum;
                IdSolicitud = oc.Id;
                txtEstado.Text = oc.Estado;
                dtFechaRegistro.Value = oc.FechaCreacion;
                dtFechaContabilizacion.Value = oc.FechaSolicitud;
                txtComentarios.Text = oc.Comentario;
                IdEstado = oc.IdEstado;
                //grdSucursales.EditValue = oc.Id_PuntoVenta;
                grdSucursales.Enabled = false;
                CargarDetalleOrdenCompra(oc.Id);
                tipooperacion = TipoOperacion.Update;
                labelControl7.Visible = true;
                txtDocNum.Visible = true;

                switch (IdEstado)
                {
                    case 1://Nueva
                        cmdNuevo.Enabled = true;
                        cmdAddDetalle.Enabled = true;
                        txtComentarios.Enabled = true;
                        grDetalle.Enabled = true;
                        dtFechaContabilizacion.Enabled = true;
                        btnPrint.Enabled = false;
                        btnCancelar.Enabled = true;
                        break;

                    case 2://Abierta
                        cmdNuevo.Enabled = true;
                        cmdAddDetalle.Enabled = true;
                        txtComentarios.Enabled = true;
                        grDetalle.Enabled = true;
                        dtFechaContabilizacion.Enabled = true;
                        btnPrint.Enabled = true;
                        btnCancelar.Enabled = true;
                        break;

                    case 3://Cerrada
                        cmdNuevo.Enabled = false;
                        cmdAddDetalle.Enabled = false;
                        txtComentarios.Enabled = false;
                        grDetalle.Enabled = false;
                        dtFechaContabilizacion.Enabled = false;
                        cmdGuardar.Enabled = false;
                        btnPrint.Enabled = true;
                        btnCancelar.Enabled = false;
                        break;

                    case 4://Cancelada
                        cmdNuevo.Enabled = false;
                        cmdAddDetalle.Enabled = false;
                        txtComentarios.Enabled = false;
                        grDetalle.Enabled = false;
                        dtFechaContabilizacion.Enabled = false;
                        cmdGuardar.Enabled = false;
                        btnCancelar.Enabled = false;
                        break;

                    default:
                        break;
                }

            }
        }

        private void cmdAnterior_Click(object sender, EventArgs e)
        {
            tipooperacion = TipoOperacion.Update;
            if (IdSolicitud == 0)//vamos a mostrar el ultimo
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("[sp_get_last_or_first_solicitud_and_oc]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@case", 1);//Ordenes de Compra
                    cmd.Parameters.AddWithValue("@PuntoVentaActual", PuntoDeVentaActual.ID);
                    IdSolicitud = Convert.ToInt32(cmd.ExecuteScalar());
                    CargarInfoOrden(IdSolicitud);
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
            else//vamos a mostrar el anteior al actual
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("[sp_get_navigation_solicitud_compra]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@case", 3);
                    cmd.Parameters.AddWithValue("@idactual", IdSolicitud);
                    cmd.Parameters.AddWithValue("@PuntoVentaActual", PuntoDeVentaActual.ID);
                    IdSolicitud = Convert.ToInt32(cmd.ExecuteScalar());

                    if (IdSolicitud == 0)
                    {
                        //Si es cero debemos cargar el primero
                        cmd = new SqlCommand("[sp_get_navigation_solicitud_compra]", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@case", 4);
                        cmd.Parameters.AddWithValue("@idactual", IdSolicitud);
                        cmd.Parameters.AddWithValue("@PuntoVentaActual", PuntoDeVentaActual.ID);
                        IdSolicitud = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    CargarInfoOrden(IdSolicitud);
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            tipooperacion = TipoOperacion.Update;
            if (IdSolicitud == 0)//vamos a mostrar el primero
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("[sp_get_last_or_first_solicitud_and_oc]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@case", 2);
                    cmd.Parameters.AddWithValue("@PuntoVentaActual", PuntoDeVentaActual.ID);
                    IdSolicitud = Convert.ToInt32(cmd.ExecuteScalar());
                    CargarInfoOrden(IdSolicitud);
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
            else//vamos a mostrar el posterior al actual
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_get_navigation_solicitud_compra", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@case", 3);
                    cmd.Parameters.AddWithValue("@idactual", IdSolicitud);
                    cmd.Parameters.AddWithValue("@PuntoVentaActual", PuntoDeVentaActual.ID);
                    IdSolicitud = Convert.ToInt32(cmd.ExecuteScalar());

                    if (IdSolicitud == 0)
                    {
                        //Si es cero debemos cargar el primero
                        cmd = new SqlCommand("sp_get_navigation_solicitud_compra", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@case", 4);
                        cmd.Parameters.AddWithValue("@idactual", IdSolicitud);
                        cmd.Parameters.AddWithValue("@PuntoVentaActual", PuntoDeVentaActual.ID);
                        IdSolicitud = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    CargarInfoOrden(IdSolicitud);
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bool Completado = false;

            try
            {
                string query = @"sp_compras_cancelar_solicitud";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idSolicitud", IdSolicitud);
                cmd.ExecuteNonQuery();
                Completado = true;

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            if (Completado)
            {
                CajaDialogo.Information("Solicitud Cancelada!");
                cmdGuardar.Enabled = false;
                grDetalle.Enabled = false;
                txtComentarios.Enabled = false;
            }
        }
    }
}