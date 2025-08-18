using ACS.Classes;
using DevExpress.DashboardWin.Commands;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Commands.Internal;
using DevExpress.XtraSplashScreen;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Compras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO.LogisticaJaguar.RecuentoInventario
{
    public partial class frmRecuentoInventarioConteo : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        PDV PuntoVentaActual;
        int IdRecuento = 0;

        public enum AccionesRecuento
        {
            Conteo = 1,
            RevisionAprobacion = 2
        }

        AccionesRecuento Accion;
        public frmRecuentoInventarioConteo(UserLogin userLogin, PDV pDV, int pIdRecuento, string pDocNum,  DateTime fecha_contabilizacion, frmRecuentoInventarioConteo.AccionesRecuento frmAccion)
        {
            InitializeComponent();
            LoadAlmacenes();
            UsuarioLogeado = userLogin;
            PuntoVentaActual = pDV;
            IdRecuento = pIdRecuento;
            txtUsuario.Text = UsuarioLogeado.Nombre;
            txtRecuento.Text = pDocNum;  
            dtFechaConta.DateTime = fecha_contabilizacion;
            Accion = frmAccion;
            Clases.RecuentoInventario recuento = new Clases.RecuentoInventario();
            recuento.RecuperarRegistros(IdRecuento);
            gleAlmacen.EditValue = recuento.IdBodega; // Cargar el almacen del recuento

            grdvConteo.OptionsMenu.EnableColumnMenu = false;
            switch (Accion)
            {
                case AccionesRecuento.Conteo:
                    cmdGuardar.Visible = true;
                    grdvConteo.Columns["tipo_ajuste"].Visible = false;
                    grdvConteo.Columns["cantidad_ajuste"].Visible = false; // Oculto el costo, ya que no se debe modificar en conteo

                    switch (recuento.EstadoId)
                    {
                        case 6://pendiente de aprobacion

                            grdvConteo.OptionsBehavior.Editable = false;
                            grdvConteo.OptionsBehavior.ReadOnly = true;

                            break;


                        default:
                            break;
                    }

                    break;
                case AccionesRecuento.RevisionAprobacion:
                    cmdGuardar.Enabled = false;
                    

                    LoadConteoByIdRecuento();

                    //gridView1.Columns["costo"].Visible = true;

                    break;
                default:
                    break;
            }


            //Aqui debo pensar si, bloqueo por equipo, si es de mega bodegon solo pueda seleccionar eso.

        }

        private void LoadConteoByIdRecuento()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_recuento_get_recuento_by_conteo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idRecuento", IdRecuento);
                cmd.Parameters.AddWithValue("@idBodega", 0);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsRecuento1.conteo_recuento.Clear();
                da.Fill(dsRecuento1.conteo_recuento);
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
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

                dsRecepcionMP.bodegas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMP.bodegas);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void gleAlmacen_EditValueChanged(object sender, EventArgs e)
        {
            int id_bodega = Convert.ToInt32(gleAlmacen.EditValue);
            if (id_bodega != 0)
            {
                LoadRecuento(id_bodega);
            }
        }

        private void LoadRecuento(int id_bodega)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_recuento_get_recuento_by_conteo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idRecuento", IdRecuento);
                cmd.Parameters.AddWithValue("@idBodega", id_bodega);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsRecuento1.conteo_recuento.Clear();
                da.Fill(dsRecuento1.conteo_recuento);
                conn.Close();

                grdvConteo.FocusedRowHandle = 0; // Mover el foco a la primera fila después de cargar los datos
                grdvConteo.FocusedColumn = grdvConteo.Columns["conteo_fisico"]; // Enfocar la columna de conteo_fisico
                grdvConteo.ShowEditor(); // Mostrar el editor para que el usuario pueda ingresar datos directamente

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gleAlmacen.Text))
            {
                CajaDialogo.Error("Debe seleccionar un Almacen");
                return;
            }

            if (grdvConteo.RowCount == 0)
            {
                CajaDialogo.Error("No existe registros para guardar!");
                return;
            }

            SplashScreenManager.ShowDefaultWaitForm("Guardando", "Por favor espere....");

            bool Guardar = false;

            await Task.Run(() =>
            {
                Guardar = GuardarConteo();
            });

            SplashScreenManager.CloseDefaultWaitForm();

            if (Guardar)
            {
                CajaDialogo.Information("Avance guardado con éxito!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            


            #region Codigo normal funcional 

            //SqlTransaction transaction = null;
            //DataOperations dp = new DataOperations();
            //SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            //bool Guardar = false;

            //SplashScreenManager.ShowDefaultWaitForm("Guardando","Por favor espere....");
            //try
            //{
            //    conn.Open();
            //    transaction = conn.BeginTransaction("Transaction Order");

            //    foreach (dsRecuento.conteo_recuentoRow row in dsRecuento1.conteo_recuento.Rows)
            //    {
            //        using (SqlCommand cmd = conn.CreateCommand())
            //        {
            //            cmd.Connection = conn;
            //            cmd.Transaction = transaction;
            //            cmd.CommandType = CommandType.StoredProcedure;

            //            cmd.CommandText = "sp_recuento_insert_update_conteo";
            //            cmd.Parameters.AddWithValue("@id_recuento", IdRecuento);
            //            cmd.Parameters.AddWithValue("@id_detalle", row.id_detalle_recuento);
            //            cmd.Parameters.AddWithValue("@cantidad_contada", Convert.ToDecimal(row.conteo_fisico));
            //            cmd.Parameters.AddWithValue("@usuario", UsuarioLogeado.Id);
            //            cmd.Parameters.AddWithValue("@fecha_contabilizacion", dtFechaConta.DateTime);

            //            cmd.ExecuteNonQuery();   

            //        }
            //    }
            //    transaction.Commit();
            //    Guardar = true;
            //}
            //catch (Exception ex)
            //{
            //    if (transaction != null)
            //        transaction.Rollback();

            //    CajaDialogo.Error(ex.Message);
            //    Guardar = false;
            //}
            //finally
            //{
            //    conn.Close();
            //    SplashScreenManager.CloseDefaultWaitForm();
            //}

            //if (Guardar)
            //{
            //    CajaDialogo.Information("Avance guardado con exito!");
            //    this.DialogResult = DialogResult.OK;
            //    this.Close();
            //}

            #endregion
        }

        private bool GuardarConteo()
        {
            DataOperations dp = new DataOperations();
            using (SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("id_recuento", typeof(int));
                    dt.Columns.Add("id_detalle", typeof(int));
                    dt.Columns.Add("cantidad_contada", typeof(decimal));
                    dt.Columns.Add("usuario", typeof(int));
                    dt.Columns.Add("fecha_contabilizacion", typeof(DateTime));

                    foreach (dsRecuento.conteo_recuentoRow row in dsRecuento1.conteo_recuento.Rows) 
                    {
                        dt.Rows.Add(
                            IdRecuento,
                            row.id_detalle_recuento,
                            Convert.ToDecimal(row.conteo_fisico),
                            UsuarioLogeado.Id,
                            dtFechaConta.DateTime
                            );
                    }

                    //using (SqlBulkCopy bulk = new SqlBulkCopy(conn, SqlBulkCopyOptions.Default, transaction))
                    //{
                    //    bulk.DestinationTableName = "dbo.Tmp_Recuento";
                    //    bulk.WriteToServer(dt);
                    //}

                    using (SqlCommand cmd = new SqlCommand("sp_recuento_insert_update_conteo_bulk", conn, transaction))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter tvpParam = cmd.Parameters.AddWithValue("@RecuentoData", dt);
                        tvpParam.SqlDbType = SqlDbType.Structured;
                        tvpParam.TypeName = "dbo.RecuentoTableType"; // nombre del tipo definido en SQL

                        cmd.CommandTimeout = 300;
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    CajaDialogo.Error(ex.Message);
                    return false;
                }
            }
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            bool Guardar = false;
            DataOperations dp = new DataOperations();
            switch (Accion)
            {
                case AccionesRecuento.Conteo:

                    DialogResult r = CajaDialogo.Pregunta("Desea completar el conteo?\nUna vez completado no se podra modificar.");
                    if (r == DialogResult.Yes)
                    {
                        try
                        {
                            
                            SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("sp_recuento_completar_conteo", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_recuento", IdRecuento);
                            cmd.Parameters.AddWithValue("@usuario", UsuarioLogeado.Id);
                            cmd.Parameters.AddWithValue("@id_bodega", Convert.ToInt32(gleAlmacen.EditValue));
                            cmd.ExecuteNonQuery();
                            Guardar = true;
                        }
                        catch (Exception ex)
                        {
                            CajaDialogo.Error(ex.Message);
                            Guardar = false;
                        }

                        if (Guardar)
                        {
                            CajaDialogo.Information("Conteo Completado!\nEnviado a Aprobacion");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }

                    }

                    break;
                case AccionesRecuento.RevisionAprobacion:
                    //Esto afectara el KARDEX CUIDADOOOOOOOOO!

                    frmOCompraAutorizacion frm = new frmOCompraAutorizacion();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        SqlTransaction transaction = null;

                        SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

                        try
                        {
                            conn.Open();
                            transaction = conn.BeginTransaction("Transaction Order");

                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandText = "sp_aprobacion_recuento_inventario";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_recuento", IdRecuento);
                            cmd.Parameters.AddWithValue("@Respuesta", frm.Respuesta);
                            cmd.Parameters.AddWithValue("@id_usuario",UsuarioLogeado.Id);
                            cmd.Parameters.AddWithValue("@fecha_contabilizacion", dtFechaConta.DateTime);
                            cmd.Parameters.AddWithValue("@id_bodega", Convert.ToInt32(gleAlmacen.EditValue));
                            cmd.Parameters.AddWithValue("@doc_num", txtRecuento.Text.ToString());
                            cmd.ExecuteNonQuery();

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
                            switch (frm.Respuesta)
                            {
                                case 1:
                                    CajaDialogo.Information("Recuento Aprobado!\nSe han realizado los ajustes en el inventario.");
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                    break;
                                case 2:
                                    CajaDialogo.Information("Recuento Rechazado!");
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                    break;
                                default:
                                    break;
                            }
                        }
                    }


                        break;
                default:
                    break;
            }

           

        }

        private void grdvConteo_KeyDown(object sender, KeyEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; //Evitamos Comportamiento por defecto

                int rowHandle = view.FocusedRowHandle;
                var col = view.FocusedColumn;

                // mueve el foco a la fila siguiente, misma columna
                if (rowHandle < view.RowCount - 1)
                {
                    view.FocusedRowHandle = rowHandle + 1;
                    view.FocusedColumn = col;
                    view.ShowEditor();
                }
            }
        }
    }
}