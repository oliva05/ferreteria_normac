using ACS.Classes;
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

namespace JAGUAR_PRO.Contabilidad.Reportes
{
    public partial class frmReporteVentasXMes : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmReporteVentasXMes(UserLogin puserLogin)
        {
            InitializeComponent();

            //MES Año
            dtMes.Properties.CalendarView =
             DevExpress.XtraEditors.Repository.CalendarView.Vista;

            // 🔴 Vista de MESES

            dtMes.Properties.VistaCalendarViewStyle =
                DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;

            // Formato Mes / Año
            dtMes.Properties.Mask.EditMask = "MMMM yyyy";
            dtMes.Properties.Mask.UseMaskAsDisplayFormat = true;

            // Bloquear escritura manual
            dtMes.Properties.TextEditStyle =
                DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

            // Opcional (limpieza)
            dtMes.Properties.ShowToday = false;
            dtMes.Properties.ShowClear = false;
            //dtMes.Properties.CalendarTimeEditing = false;

            dtMes.DateTime = dp.dNow();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void LoadDatos()
        {
            try
            {
                dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();
                //asdf

                SqlCommand cmd = new SqlCommand("dbo.sp_conta_get_ventas_x_mes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@anio", dtMes.DateTime.Year);
                cmd.Parameters.AddWithValue("@mes", dtMes.DateTime.Month);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReportesBasicosConta1.resumen_ventas_x_mes.Clear();
                adat.Fill(dsReportesBasicosConta1.resumen_ventas_x_mes);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDatos();
        }

        private void cmdExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdRpt.ExportToXlsx(dialog.FileName);
            }
        }

        private void dtAnio_EditValueChanged(object sender, EventArgs e)
        {
            var editor = sender as DevExpress.XtraEditors.DateEdit;
            editor?.ClosePopup();
        }

        private void dtMes_EditValueChanged(object sender, EventArgs e)
        {
            var editor = sender as DevExpress.XtraEditors.DateEdit;
            editor?.ClosePopup();
        }
    }
}