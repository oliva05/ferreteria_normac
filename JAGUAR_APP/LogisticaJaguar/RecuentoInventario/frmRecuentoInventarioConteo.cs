using ACS.Classes;
using DevExpress.DashboardWin.Commands;
using DevExpress.XtraEditors;
using JAGUAR_PRO.Clases;
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

            //switch (Accion)
            //{
            //    case AccionesRecuento.Conteo:
            //        gridView1.OptionsMenu.EnableColumnMenu = true;
            //        //Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna, para elegir columnas, ordenar, etc


            //        gridView1.Columns["costo"].Visible = true;
            //        //Permite mostrar o ocultar una columna, se utiliza colocando el string de FieldName que se define desde el datasets

            //        break;
            //    case AccionesRecuento.RevisionAprobacion:
            //        gridView1.OptionsMenu.EnableColumnMenu = true;
            //        //Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna, para elegir columnas, ordenar, etc


            //        gridView1.Columns["costo"].Visible = true;
            //        //Permite mostrar o ocultar una columna, se utiliza colocando el string de FieldName que se define desde el datasets

            //        break;
            //    default:
            //        break;
            //}


            //Aqui debo pensar si, bloqueo por equipo, si es de mega bodegon solo pueda seleccionar eso.

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
                cmd.Parameters.AddWithValue("@idRecuento", id_bodega);
                cmd.Parameters.AddWithValue("@idBodega", IdRecuento);
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

            SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
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
            DialogResult r = CajaDialogo.Pregunta("Desea completar el conteo?\nUna vez completado no se podra modificar.");
            if (r == DialogResult.Yes)
            {
                try
                {
                    DataOperations dp = new DataOperations();
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

        }
    }
}