using ACS.Classes;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Model;
using DocumentFormat.OpenXml.Wordprocessing;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Clases.Colaborador;
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

namespace JAGUAR_PRO.RRHH_Planilla.Mantenimientos.MaestrosEmpleado
{
    public partial class frmEmployeeSchedule : DevExpress.XtraEditors.XtraForm
    {
        int IdEmpleado = 0;
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();
        public frmEmployeeSchedule(UserLogin userLogin, int pIdEmp)
        {
            InitializeComponent();

            UsuarioLogueado = userLogin;    
            // 🚫 No permitir agregar o eliminar filas desde el grid
            gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;

            // 🚫 No permitir mover columnas
            gridView1.OptionsCustomization.AllowColumnMoving = false;

            // 🚫 No permitir cambiar el orden de las columnas
            gridView1.OptionsCustomization.AllowSort = false;

            // 🚫 No permitir que el usuario oculte o muestre columnas
            gridView1.OptionsCustomization.AllowQuickHideColumns = false;

            // 🚫 No permitir agrupar columnas
            gridView1.OptionsCustomization.AllowGroup = false;

            // 🎨 Mejorar apariencia
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            //// 🕒 Formato para las columnas TIME (TimeSpan)
            //gridView1.Columns["hora_entrada"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            //gridView1.Columns["hora_entrada"].DisplayFormat.FormatString = "HH:mm";
            //gridView1.Columns["hora_salida_lunch"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            //gridView1.Columns["hora_salida_lunch"].DisplayFormat.FormatString = "HH:mm";
            //gridView1.Columns["hora_entrada_lunch"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            //gridView1.Columns["hora_entrada_lunch"].DisplayFormat.FormatString = "HH:mm";
            //gridView1.Columns["hora_salida"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            //gridView1.Columns["hora_salida"].DisplayFormat.FormatString = "HH:mm";

            HrEmployee EmpleadoActual = new HrEmployee();
            if (EmpleadoActual.RecuperarDatosPorId(pIdEmp))
            {
                lblCodigo.Text = EmpleadoActual.Barcode;
                lblNombreEmpleado.Text = EmpleadoActual.Name;
                IdEmpleado = pIdEmp;
                tggMarcAlmuerzo.IsOn = EmpleadoActual.MarcAlmuerzo;
                
            }
            LoadData();

        }

        private void LoadData()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_schedule_by_employee", conn); 
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", IdEmpleado);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsMaestroEmpleados1.horario.Clear();
                da.Fill(dsMaestroEmpleados1.horario);
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            SqlTransaction transaction = null;

            SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            bool Guardar = false;

            try
            {
                conn.Open();
                transaction = conn.BeginTransaction("Transaction Order");

                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "[sp_update_disable_old_scheduleV2]";
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", IdEmpleado);
                cmd.Parameters.AddWithValue("@MarcaAlmuerzo", tggMarcAlmuerzo.IsOn);
                cmd.ExecuteNonQuery();

                foreach (dsMaestroEmpleados.horarioRow item in dsMaestroEmpleados1.horario.Rows)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "sp_insert_schedule_employee";
                    cmd.Connection = conn;
                    cmd.Transaction = transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idEmpleado", item.id_employee);
                    cmd.Parameters.AddWithValue("@dia", item.dia);
                    cmd.Parameters.AddWithValue("@hora_entrada", item.hora_entrada);
                    if (item.IsNull("hora_salida_lunch"))
                        cmd.Parameters.AddWithValue("@hora_salida_lunch", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@hora_salida_lunch", item.hora_salida_lunch);
                    if (item.IsNull("hora_entrada_lunch"))
                        cmd.Parameters.AddWithValue("@hora_entrada_lunch", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@hora_entrada_lunch", item.hora_entrada_lunch);
                    cmd.Parameters.AddWithValue("@hora_salida", item.hora_salida);
                    cmd.Parameters.AddWithValue("@id_user_create", item.id_user_create);
                    
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
        }

        private void tggMarcAlmuerzo_Toggled(object sender, EventArgs e)
        {
            bool isChecked = tggMarcAlmuerzo.IsOn; // true = encendido, false = apagado

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (isChecked)
                {
                    // ✅ Toggle en true → asignar valores por defecto
                    gridView1.SetRowCellValue(i, "hora_salida_lunch", new TimeSpan(12, 0, 0));
                    gridView1.SetRowCellValue(i, "hora_entrada_lunch", new TimeSpan(13, 0, 0));
                }
                else
                {
                    // ❌ Toggle en false → limpiar valores
                    gridView1.SetRowCellValue(i, "hora_salida_lunch", null);
                    gridView1.SetRowCellValue(i, "hora_entrada_lunch", null);
                }
            }
        }
    }
}