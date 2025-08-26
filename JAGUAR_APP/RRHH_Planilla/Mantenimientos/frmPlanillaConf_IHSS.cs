using ACS.Classes;
using DevExpress.Office.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using JAGUAR_PRO.Accesos.AccesosUsuarios;
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

namespace JAGUAR_PRO.RRHH_Planilla.Mantenimientos
{
    public partial class frmPlanillaConf_IHSS : DevExpress.XtraEditors.XtraForm
    {
        public enum TipoTransaccionPlanilla
        {
            Nuevo = 1,
            Modificar = 2,
            Vista = 3,
        }

        TipoTransaccionPlanilla tipoTransaccion;
        UserLogin UserLogin;
        int IdHeader;
        DataOperations dp = new DataOperations();
        public frmPlanillaConf_IHSS(TipoTransaccionPlanilla tipoTransaccion, UserLogin userLogin, int pid, int pyear)
        {
            InitializeComponent();
            UserLogin = userLogin;
            this.tipoTransaccion = tipoTransaccion;
            IdHeader = pid;

            switch (tipoTransaccion)
            {
                case TipoTransaccionPlanilla.Nuevo:
                    txtAnio.EditValue = Convert.ToInt32(dp.dNow().Year);

                    GetRegistros();

                    break;
                case TipoTransaccionPlanilla.Modificar:
                    txtAnio.EditValue = pyear;
                    GetRegistros();
                    break;

                case TipoTransaccionPlanilla.Vista:
                    break;

                default:
                    break;
            }
            reposComboTipo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        private void GetRegistros()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_conf_ihss_detalle_new", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@year", Convert.ToInt32(txtAnio.EditValue));
                cmd.Parameters.AddWithValue("@IdHeader", Convert.ToInt32(IdHeader));
                dsMantenimientoPlanilla1.hr_ihss_detalle.Clear();
                adat.Fill(dsMantenimientoPlanilla1.hr_ihss_detalle);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAnio.Text))
            {
                CajaDialogo.Error("Debe ingresar un Año!");
                return;
            }


            int Patrono = 0;
            int Trabajador = 0;

            foreach (dsMantenimientoPlanilla.hr_ihss_detalleRow row in dsMantenimientoPlanilla1.hr_ihss_detalle.Rows)
            {
                if (row.tipo == "Trabajadores")
                    Trabajador += 1;
                else
                    Patrono += 1;
            }

            if (Trabajador > 1 || Patrono > 1)
            {
                MessageBox.Show("Solo puede existir un registro con 'Trabajadores' y uno con 'Patrono'.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // o lanzar una excepción, o bloquear el guardado
            }

            SqlTransaction transaction = null;

            SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            bool Guardar = false;

            switch (tipoTransaccion)
            {
                case TipoTransaccionPlanilla.Nuevo:

                    try
                    {
                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "sp_insert_ihss_h";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@anio", Convert.ToInt32(txtAnio.EditValue));
                        cmd.Parameters.AddWithValue("@user_id", UserLogin.Id);

                        int id_header = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (dsMantenimientoPlanilla.hr_ihss_detalleRow row in dsMantenimientoPlanilla1.hr_ihss_detalle.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "sp_insert_ihss_d";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@year", Convert.ToInt32(txtAnio.EditValue));
                            cmd.Parameters.AddWithValue("@techo_ivm",row.techo_ivm);
                            cmd.Parameters.AddWithValue("@techo_em", row.techo_em);
                            if (row.tipo == "Trabajadores")
                                cmd.Parameters.AddWithValue("@tipo", 1);
                            else
                                cmd.Parameters.AddWithValue("@tipo", 2);
                            cmd.Parameters.AddWithValue("@techo_rp",row.techo_rp);
                            cmd.Parameters.AddWithValue("@porcentaje_ivm",row.porcentaje_ivm);
                            cmd.Parameters.AddWithValue("@porcentaje_em", row.porcentaje_em);
                            cmd.Parameters.AddWithValue("@porcentaje_rp",row.porcentaje_rp);
                            cmd.Parameters.AddWithValue("@porcentaje_afp", row.porcentaje_afp);
                            cmd.Parameters.AddWithValue("@id_h", id_header);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        Guardar = true;

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
                case TipoTransaccionPlanilla.Modificar:

                    try
                    {
                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "sp_insert_ihss_h";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@anio", Convert.ToInt32(txtAnio.EditValue));
                        cmd.Parameters.AddWithValue("@idRecuento", IdHeader);
                        cmd.ExecuteNonQuery();

                        foreach (dsMantenimientoPlanilla.hr_ihss_detalleRow row in dsMantenimientoPlanilla1.hr_ihss_detalle.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "[sp_update_ihss_d]";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@year", Convert.ToInt32(txtAnio.EditValue));
                            cmd.Parameters.AddWithValue("@techo_ivm", row.techo_ivm);
                            cmd.Parameters.AddWithValue("@techo_em", row.techo_em);
                            if (row.tipo == "Trabajadores")
                                cmd.Parameters.AddWithValue("@tipo", 1);
                            else
                                cmd.Parameters.AddWithValue("@tipo", 2);
                            cmd.Parameters.AddWithValue("@techo_rp", row.techo_rp);
                            cmd.Parameters.AddWithValue("@porcentaje_ivm", row.porcentaje_ivm);
                            cmd.Parameters.AddWithValue("@porcentaje_em", row.porcentaje_em);
                            cmd.Parameters.AddWithValue("@porcentaje_rp", row.porcentaje_rp);
                            cmd.Parameters.AddWithValue("@porcentaje_afp", row.porcentaje_afp);
                            cmd.Parameters.AddWithValue("@id_h", IdHeader);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        Guardar = true;

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
    }
}