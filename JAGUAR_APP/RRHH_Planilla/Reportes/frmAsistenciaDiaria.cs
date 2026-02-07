using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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

namespace JAGUAR_PRO.RRHH_Planilla.Reportes
{
    public partial class frmAsistenciaDiaria : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmAsistenciaDiaria()
        {
            InitializeComponent();

            dtFecha.DateTime = dp.Now().Date;
        }

        private void btnCargarDatosAcumulados_Click(object sender, EventArgs e)
        {
            LoadDataGeneral();
        }

        private void LoadDataGeneral()
        {
            try
            {
                string query = @"[sp_get_asistencia_diaria]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@IdEmpleado",);
                cmd.Parameters.AddWithValue("@desde", dtFecha.DateTime);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReporte1.asistencia_diaria.Clear();
                adat.Fill(dsReporte1.asistencia_diaria);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            rptAsistenciaDiaria report = new rptAsistenciaDiaria(dtFecha.DateTime.Date) 
            { 
                DataSource = dsReporte1,
                DataMember = "asistencia_diaria",
                ShowPrintMarginsWarning = false 
            };
            report.CreateDocument();
            report.PrintingSystem.ContinuousPageNumbering = true;
            new ReportPrintTool(report).ShowPreview();

        }
    }
}