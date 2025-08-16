using ACS.Classes;
using DevExpress.DashboardWin.Commands;
using DevExpress.XtraEditors;
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

                    break;
                case AccionesRecuento.RevisionAprobacion:
                    cmdGuardar.Visible = false;
                    gleAlmacen.Visible = false;

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

        private void cmdGuardar_Click(object sender, EventArgs e)
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

            SqlTransaction transaction = null;
            DataOperations dp = new DataOperations();
            SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            bool Guardar = false;

            try
            {
                conn.Open();
                transaction = conn.BeginTransaction("Transaction Order");

                foreach (dsRecuento.conteo_recuentoRow row in dsRecuento1.conteo_recuento.Rows)
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.CommandText = "sp_recuento_insert_update_conteo";
                        cmd.Parameters.AddWithValue("@id_recuento", IdRecuento);
                        cmd.Parameters.AddWithValue("@id_detalle", row.id_detalle_recuento);
                        cmd.Parameters.AddWithValue("@cantidad_contada", Convert.ToDecimal(row.conteo_fisico));
                        cmd.Parameters.AddWithValue("@usuario", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@fecha_contabilizacion", dtFechaConta.DateTime);

                        cmd.ExecuteNonQuery();   

                    }
                }
                transaction.Commit();
                Guardar = true;
            }
            catch (Exception ex)
            {
                if (transaction != null)
                    transaction.Rollback();

                CajaDialogo.Error(ex.Message);
                Guardar = false;
            }
            finally
            {
                conn.Close();
            }

            if (Guardar)
            {
                CajaDialogo.Information("Avance guardado con exito!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
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
                        }
                        catch (Exception ex)
                        {
                            CajaDialogo.Error(ex.Message);
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
                        bool Guardar = false;

                        try
                        {
                            conn.Open();
                            transaction = conn.BeginTransaction("Transaction Order");

                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandText = "";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("", IdRecuento);
                            cmd.Parameters.AddWithValue("", frm.Respuesta);
                            cmd.Parameters.AddWithValue("", frm.Respuesta);
                            cmd.ExecuteNonQuery();

                            //foreach (dsRecuento.conteo_recuentoRow row in dsRecuento1.conteo_recuento.Rows)
                            //{
                            //    cmd.Parameters.Clear();
                            //    cmd.CommandText = "";
                            //    cmd.Connection = conn;
                            //    cmd.Transaction = transaction;
                            //    cmd.CommandType = CommandType.StoredProcedure;
                            //    cmd.Parameters.AddWithValue("",);
                            //    cmd.ExecuteNonQuery();
                            //}

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