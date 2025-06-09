using ACS.Classes;
using DevExpress.Data.Helpers;
using DevExpress.Pdf.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.LogisticaJaguar;
using JAGUAR_PRO.Mantenimientos.Modelos;
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
    public partial class frmNewTrasladoPT : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;

        DataOperations dp = new DataOperations();
        int IdTrasladoH;
        int IdSoliciudTrasladoH;

        public enum TipoOperacion
        {
            SolicitudTraslado = 1,
            TrasladoFinal = 2,
            SoloVista = 3
        }
        TipoOperacion operacion;

        
        public frmNewTrasladoPT(UserLogin userLogin, frmNewTrasladoPT.TipoOperacion pOperacion, int pIdTraslado)
        {
            InitializeComponent();
            operacion = pOperacion;
            UsuarioLogeado = userLogin;
            IdSoliciudTrasladoH = pIdTraslado;
            dtFechaDocumento.DateTime = dp.Now();
            LoadAlmacenes();
            RequisaTraslado requisa = new RequisaTraslado();
            switch (operacion)
            {
                case TipoOperacion.SolicitudTraslado:
                    lbltipo.Text = "Requisa #:";
                    lblNumTraslado.Text = GetNumSolicitudTrasladoSig(1);//Punto Venta
                    break;
                case TipoOperacion.TrasladoFinal:
                    lbltipo.Text = "Traslado #:";
                    lblNumTraslado.Text = GetNumTrasladoSig(1);//Punto Venta

                    if (IdSoliciudTrasladoH > 0)
                    {
                        btnRight.Visible = false;
                        grdAlmacenOrigen.Enabled = false;
                        gleAlmacen.Enabled = false;
                        gleAlmacenDestino.Enabled = false;
                        gridView2.Columns["cantidad_trasladar"].OptionsColumn.AllowEdit = true;
                        requisa.RecuperarRegistros(IdSoliciudTrasladoH);
                        //lblNumTraslado.Text = requisa.NumRequisa;
                        //dtFechaDocumento.EditValue = requisa.Fecha;
                        gleAlmacen.EditValue = requisa.BodegaOrigen;
                        gleAlmacenDestino.EditValue = requisa.BodegaDestino;

                        LoadDetalleDestino(IdSoliciudTrasladoH);
                    }

                    break;
                case TipoOperacion.SoloVista:

                    gridView2.OptionsMenu.EnableColumnMenu = false;
                    gridView2.Columns["eliminar"].Visible = false;
                    cmdRecargar.Visible = false;
                    grdAlmacenOrigen.Enabled = false;
                    btnRight.Visible = false;
                    btnLeft.Visible = false;
                    memoDescr.Enabled = false;
                    dtFechaDocumento.Enabled = false;
                    gleAlmacen.Enabled = false;
                    gleAlmacenDestino.Enabled = false;

                    lbltipo.Text = "Requisa #:";
                  
                    requisa.RecuperarRegistros(IdSoliciudTrasladoH);
                    lblNumTraslado.Text = requisa.NumRequisa;
                    dtFechaDocumento.EditValue = requisa.Fecha;
                    gleAlmacen.EditValue = requisa.BodegaOrigen;
                    gleAlmacenDestino.EditValue = requisa.BodegaDestino;

                    LoadDetalleDestino(IdSoliciudTrasladoH);

                    break;
                default:
                    break;
            }
        }

        private void LoadDetalleDestino(int pIdSoliciudTrasladoH)
        {
            try
            {
                string query = @"sp_get_requisa_traslado_detalle";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTraslado",pIdSoliciudTrasladoH);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPT1.almacen_destino.Clear();
                adat.Fill(dsPT1.almacen_destino);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private string GetNumSolicitudTrasladoSig(int PuntoVenta)
        {
            string NumReqTrasladoSiguiente = string.Empty;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_pt_get_num_solicitud_traslado_sig]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PuntoVentaId", PuntoVenta);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    NumReqTrasladoSiguiente = dr.GetString(0);
                    dr.Close();
                }
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            return NumReqTrasladoSiguiente;
        }

        private string GetNumTrasladoSig(int PuntoVenta)
        {
            string NumTrasladoSiguiente = string.Empty;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_pt_get_num_traslado_sig]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PuntoVentaId", PuntoVenta);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) 
                {
                    NumTrasladoSiguiente = dr.GetString(0);
                    dr.Close();
                }
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            return NumTrasladoSiguiente;
        }

        private void LoadAlmacenes()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[spObtenerBodegasActivas]", con);
                cmd.CommandType = CommandType.StoredProcedure;
      
                dsRecepcionMP1.bodegas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMP1.bodegas);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridLookUpEdit1View_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }

        private void gleAlmacen_EditValueChanged(object sender, EventArgs e)
        {
            int id_bodega = Convert.ToInt32(gleAlmacen.EditValue);
            if (id_bodega != 0)
            {
                LoadInvAlmacenes(id_bodega);

                dsPT1.almacen_destino.Clear();
            }
        }

        private void LoadInvAlmacenes(int id_bodega)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_pt_inventario_by_almacen", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_almacen", id_bodega);
                dsPT1.almacen_origen.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPT1.almacen_origen);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private bool PTConfiguradoAAlmacen(int PIdPT)
        {
            bool Permitir = false;

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_pt_validacion_permiso_almacen", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPt", PIdPT);
                cmd.Parameters.AddWithValue("@idAlmacen", Convert.ToInt32(gleAlmacenDestino.EditValue));
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Permitir = dr.GetBoolean(0);
                    dr.Close();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            return Permitir;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            bool Error = false;
            string mensaje = "";

            int id_bodeg_origen = Convert.ToInt32(gleAlmacen.EditValue);

            int id_bodega_destino = Convert.ToInt32(gleAlmacenDestino.EditValue);

            if (id_bodega_destino <= 0)
            {
                CajaDialogo.Error("Debe Seleccionar el Almacen Destino!");
                return;
            }

            if (id_bodeg_origen == id_bodega_destino)
            {
                CajaDialogo.Error("No puede trasladar Producto al mismo Almacen");
                return;
            }

            foreach (dsPT.almacen_origenRow row in dsPT1.almacen_origen.Rows)
            {
                if (row.seleccion)
                {
                    if (row.cantidad_trasladar <= 0)
                    {
                        Error = true;
                        mensaje = "Producto seleccionado debe ser mayor a 0!";
                        break;
                    }

                    if (row.cantidad_trasladar > row.existencia)
                    {
                        Error = true;
                        mensaje = "Producto seleccionado es mayor que la existencia en Almacen!";
                        break;
                    }

                    if (!PTConfiguradoAAlmacen(row.id_pt))
                    {
                        Error = true;
                        mensaje = "Producto:"+row.itemcode+"-"+row.PT+"\nNo esta Configurado para uso del Almacen:"+gleAlmacenDestino.Text;
                        break;
                    }
                }
            }

            if (Error)
            {
                CajaDialogo.Error(mensaje);
                return;
            }
            else
            {
                if (Convert.ToInt32(gleAlmacen.EditValue) > 0)
                {
                    
                    foreach (dsPT.almacen_origenRow row in dsPT1.almacen_origen.Rows)
                    {
                        if (row.seleccion)
                        {
                            //DataRow[] encontrados = dsPT1.almacen_destino.Select($"itemcode = '{row.itemcode}'");

                            //if (encontrados.Length > 0)
                            bool Duplicado = false;
                            foreach (dsPT.almacen_destinoRow item in dsPT1.almacen_destino.Rows)
                            {
                                if (row.itemcode == item.itemcode)
                                {
                                    item.cantidad_trasladar = item.cantidad_trasladar + row.cantidad_trasladar;
                                    Duplicado = true;
                                }
                            }

                            if(Duplicado == false) 
                            {
                                try
                                {
                                    DataRow dr = dsPT1.almacen_destino.NewRow();
                                    dr[0] = row.id_pt;
                                    dr[1] = row.itemcode;
                                    dr[2] = row.PT;
                                    dr[3] = 0;
                                    dr[4] = row.cantidad_trasladar;
                                    dsPT1.almacen_destino.Rows.Add(dr);
                                    dsPT1.almacen_destino.AcceptChanges();
                                }
                                catch (Exception ex)
                                {
                                    CajaDialogo.Error(ex.Message);
                                }
                            }

                               
                        }
                        

                        if (row.seleccion)
                        {
                            row.existencia = row.existencia - row.cantidad_trasladar;
                            row.cantidad_trasladar = 0;
                            row.seleccion = false;
                        }
                    }
                }
            }

            
        }

        private void cmdRecargar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(memoDescr.Text))
            {
                CajaDialogo.Error("Debe agregar un Comentario!");
                return;
            }

            if (!string.IsNullOrEmpty(dtFechaDocumento.Text))
            {
                if (dtFechaDocumento.DateTime.Year <= 2020)
                {
                    CajaDialogo.Error("Es necesario ingresar una fecha de documento valida!");
                    return;
                }
            }

            int id_bodega = 0;
            if (!string.IsNullOrEmpty(gleAlmacen.Text))
            {
                id_bodega = dp.ValidateNumberInt32(gleAlmacen.EditValue);
                if (id_bodega <= 0)
                {
                    CajaDialogo.Error("Es necesario indicar el almacen donde se aplicara el ajuste!");
                    return;
                }

            }

            int id_bodega_destino = 0;
            if (!string.IsNullOrEmpty(gleAlmacenDestino.Text))
            {
                id_bodega_destino = dp.ValidateNumberInt32(gleAlmacenDestino.EditValue);
                if (id_bodega_destino <= 0)
                {
                    CajaDialogo.Error("Es necesario indicar el almacen donde se aplicara el ajuste!");
                    return;
                }

            }

            if (id_bodega == id_bodega_destino)
            {
                CajaDialogo.Error("No puede trasladar Producto al mismo Almacen");
                return;
            }

            foreach (dsPT.almacen_destinoRow item in dsPT1.almacen_destino)
            {
                if (item.cantidad_trasladar <= 0)
                {
                    CajaDialogo.Error("PT:"+item.itemcode+" debe ser Mayor a 0!");
                    return;
                }

                

            }

            bool Guardar = false;

            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

            conn.Open();
            transaction = conn.BeginTransaction("Transaction Order");

            SqlCommand cmd = conn.CreateCommand();

            switch (operacion)
            {
                case TipoOperacion.SolicitudTraslado:

                    try
                    {
                        cmd.CommandText = "sp_pt_insert_solicitud_traslado_header";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@descripcion", memoDescr.Text);
                        cmd.Parameters.AddWithValue("@fecha", dtFechaDocumento.DateTime);
                        cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@bodega_origen", gleAlmacen.EditValue);
                        cmd.Parameters.AddWithValue("@bodega_destino", gleAlmacenDestino.EditValue);
                        int IdEstado = 1; //Pendiente Aprobacion
                        if (UsuarioLogeado.GrupoUsuario.GrupoUsuarioActivo == GrupoUser.GrupoUsuario.Administradores)
                            IdEstado = 2; //Aprobado
                        cmd.Parameters.AddWithValue("@id_estado", IdEstado);
                        cmd.Parameters.AddWithValue("@num_requisa", lblNumTraslado.Text.Trim());
                        IdSoliciudTrasladoH = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (dsPT.almacen_destinoRow row in dsPT1.almacen_destino.Rows)
                        {
                            cmd.Parameters.Clear();

                            cmd.CommandText = "sp_pt_insert_solicitud_tralsado_detalle";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_solicitud_h", IdSoliciudTrasladoH);
                            cmd.Parameters.AddWithValue("@id_pt", row.id_pt);
                            cmd.Parameters.AddWithValue("@item_code", row.itemcode);
                            cmd.Parameters.AddWithValue("@cantidad", row.cantidad_trasladar);

                            //if (id_bodega == 0)
                            //    cmd.Parameters.AddWithValue("@id_almacen_origen", DBNull.Value);
                            //else
                            //    cmd.Parameters.AddWithValue("@id_almacen_origen", id_bodega);

                            //if (id_bodega_destino == 0)
                            //    cmd.Parameters.AddWithValue("@id_almacen_destino", DBNull.Value);
                            //else
                            //    cmd.Parameters.AddWithValue("@id_almacen_destino", id_bodega_destino);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        Guardar = true;
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                        Guardar = false;
                    }

                    break;

                case TipoOperacion.TrasladoFinal:
                    
                    try
                    {
                        cmd.CommandText = "sp_pt_insert_traslado_header";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@num_traslado", lblNumTraslado.Text);
                        cmd.Parameters.AddWithValue("@descripcion", memoDescr.Text);
                        cmd.Parameters.AddWithValue("@fecha", dtFechaDocumento.DateTime);
                        cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@bodega_origen", gleAlmacen.EditValue);
                        cmd.Parameters.AddWithValue("@bodega_destino", gleAlmacenDestino.EditValue);
                        cmd.Parameters.AddWithValue("@idSolicitudTraslado", IdSoliciudTrasladoH);
                        IdTrasladoH = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (dsPT.almacen_destinoRow row in dsPT1.almacen_destino.Rows)
                        {
                            cmd.Parameters.Clear();

                            cmd.CommandText = "[usp_Traslado_Kardex_PT]";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@idTraslado", IdTrasladoH);
                            cmd.Parameters.AddWithValue("@id_pt", row.id_pt);
                            cmd.Parameters.AddWithValue("@id_Usuario", UsuarioLogeado.Id);
                            cmd.Parameters.AddWithValue("@fecha_doc", dtFechaDocumento.EditValue);
                            cmd.Parameters.AddWithValue("@fecha_reg", dtFechaDocumento.EditValue);
                            cmd.Parameters.AddWithValue("@code", row.itemcode);
                            cmd.Parameters.AddWithValue("@unidades", row.cantidad_trasladar);
                            cmd.Parameters.AddWithValue("@lote", DBNull.Value);
                            cmd.Parameters.AddWithValue("@id_tipo_lote", DBNull.Value);
                            cmd.Parameters.AddWithValue("@costo_unitario", DBNull.Value);

                            if (id_bodega == 0)
                                cmd.Parameters.AddWithValue("@id_almacen_origen", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@id_almacen_origen", id_bodega);

                            if (id_bodega_destino == 0)
                                cmd.Parameters.AddWithValue("@id_almacen_destino", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@id_almacen_destino", id_bodega_destino);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        Guardar = true;

                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                        Guardar = false;
                    }


                    break;
                default:
                    break;
            }



            

            if (Guardar)
            {
                //ActualizarCorrelativo();
                /*ajaDialogo.Information("Traslado Completado con Exito!");*/

                switch (operacion)
                {
                    case TipoOperacion.SolicitudTraslado:
                        CajaDialogo.Information("Requisa de Traslado Generada");
                        break;
                    case TipoOperacion.TrasladoFinal:

                        DialogResult r = CajaDialogo.Pregunta("Traslado Completado con Exito!\nDesea imprimir el traslado?");
                        if (r == DialogResult.Yes)
                        {
                            xrptTraslado report = new xrptTraslado(IdTrasladoH);
                            report.ShowPrintMarginsWarning = false;
                            report.ShowPreview();
                        }

                        break;
                    default:
                        break;
                }

                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void reposDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdAlmacenDestino.FocusedView;
            var row = (dsPT.almacen_destinoRow)gridview.GetFocusedDataRow();

            foreach (dsPT.almacen_origenRow item in dsPT1.almacen_origen)
            {
                if (row.itemcode == item.itemcode)
                {
                    item.existencia = item.existencia + row.cantidad_trasladar;

                }
            }

            try
            {
                gridView2.DeleteRow(gridView2.FocusedRowHandle);
                dsPT1.AcceptChanges();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)grdAlmacenOrigen.FocusedView;
            var row = (dsPT.almacen_origenRow)gridView.GetFocusedDataRow();
            if (e.Column.Name == @"colcantidad_trasladar")
            {
                if (row.cantidad_trasladar > 0)
                {
                    row.seleccion = true;
                }
                else
                {
                    row.seleccion = false;
                }
            }
        }
    }
}