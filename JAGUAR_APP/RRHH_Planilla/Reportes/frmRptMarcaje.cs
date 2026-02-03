using ACS.Classes;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.RRHH_Planilla.Mantenimientos.MaestrosEmpleado;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace JAGUAR_PRO.RRHH_Planilla.Reportes
{
    public partial class frmRptMarcaje : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogueado;
        public frmRptMarcaje(UserLogin userLogin)
        {
            InitializeComponent();
            UsuarioLogueado = userLogin;

            DateTime Desde = dp.dNow();
            Desde = new DateTime(Desde.Year, Desde.Month, Desde.Day, 0, 0, 0);
            dtDesde.DateTime = Desde;
            deFechaInicial.DateTime = Desde;

            DateTime Hasta = Desde;
            Hasta = new DateTime(Hasta.Year, Hasta.Month, Hasta.Day, 23, 59, 0);

            dtHasta.DateTime = Hasta; // hoy, 23:59:59
            deFechaFinal.DateTime = Hasta; // hoy, 23:59:59
            LoadDataGeneral();
        }

        private void LoadDataGeneral()
        {
            try
            {
                string query = @"[sp_get_cantidad_horas_laboras_extras]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@IdEmpleado",);
                cmd.Parameters.AddWithValue("@desde",dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@hasta",dtHasta.DateTime);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReporte1.get_marcas_by_dates.Clear();
                adat.Fill(dsReporte1.get_marcas_by_dates);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void LoadData()
        {
            try
            {
                string query = @"sp_get_marcas_by_employee";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEmpleado",Convert.ToInt32(grdEmployee.EditValue));
                cmd.Parameters.AddWithValue("@desde", deFechaInicial.DateTime);
                cmd.Parameters.AddWithValue("@hasta", deFechaFinal.DateTime);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReporte1.get_marcas_by_empleado.Clear();
                adat.Fill(dsReporte1.get_marcas_by_empleado);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void btnCambiarImagen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(grdEmployee.Text))
            {
                CajaDialogo.Error("Debe seleccionar un empleado!");
                return;
            }

            frnEmployeeBrandManual frm = new frnEmployeeBrandManual(UsuarioLogueado, Convert.ToInt32(grdEmployee.EditValue));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnCargarDatosAcumulados_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(grdEmployee.Text))
            {
                CajaDialogo.Error("Debe seleccionar un empleado!");
                return;
            }
            LoadData();
        }

        private void CargarDatos_Click(object sender, EventArgs e)
        {
            LoadDataGeneral();
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == TabGeneral)
            {
                LoadDataGeneral();
            }
            else if (e.Page == TabByEmpleado) 
            {
                LoadEmployee();            
            }
        }

        private void LoadEmployee()
        {
            try
            {
                string query = @"sp_get_employee_active";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@IdEmpleado", Convert.ToInt32(grdEmployee.EditValue));
                //cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                //cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReporte1.get_employee_active.Clear();
                adat.Fill(dsReporte1.get_employee_active);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnExportarAcumulados_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gcAcumulados.ExportToXlsx(dialog.FileName);
            }
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gcBreak.ExportToXlsx(dialog.FileName);
            }
        }
    }
}