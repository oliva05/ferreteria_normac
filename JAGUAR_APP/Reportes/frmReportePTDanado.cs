using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO.Reportes
{
    public partial class frmReportePTDanado : DevExpress.XtraEditors.XtraForm
    {
        public frmReportePTDanado()
        {
            InitializeComponent();
        }

      private void  load_data()
        {
            try
            {

                if (string.IsNullOrEmpty(dtDesde.Text))
                {
                    CajaDialogo.Error("DEBE DE SELECCIONAR UNA FECHA DE INICIO");
                    return;
                }

                if (string.IsNullOrEmpty(dtHasta.Text))
                {
                    CajaDialogo.Error("DEBE DE SELECCIONAR UNA FECHA FINAL");
                    return;
                }

                DataOperations dp = new DataOperations();

            SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

            using (SqlDataAdapter da = new SqlDataAdapter("usp_rpt_PT_danado", cnx))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@fecha_inicio", dtDesde.EditValue);
                da.SelectCommand.Parameters.Add("@fecha_fin", dtHasta.EditValue);

                cnx.Open();
                dsReportes.rptPTDanado.Clear();
                da.Fill(dsReportes.rptPTDanado);
                cnx.Close();
            }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

     
   
        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            load_data();

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReporteConsumoMPPorDia_Load(object sender, EventArgs e)
        {
            dtDesde.EditValue = DateTime.Now;
            dtHasta.EditValue = DateTime.Now;
        }

        private void cmdExportToExcel_Click(object sender, EventArgs e)
        {
            
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;
                string path = "Saldo de Cuenta";




                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                    
                        gridView2.OptionsPrint.AutoWidth = true;
   

                    XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                    advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;

                    advOptions.ExportType = DevExpress.Export.ExportType.DataAware;
                    advOptions.TextExportMode = TextExportMode.Value;
                    advOptions.BandedLayoutMode = DevExpress.Export.BandedLayoutMode.LinearColumns;


                    advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.SheetName = "Exported from Ovejita";
                    advOptions.ExportType = DevExpress.Export.ExportType.WYSIWYG;

                    gcReportePTDanado.ExportToXlsx(path, advOptions);
                   
                    // Open the created XLSX file with the default application.
                    Process.Start(path);

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

       

    }
}