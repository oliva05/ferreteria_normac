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

namespace JAGUAR_APP.Reportes
{
    public partial class frmReporteConsumoMPPorDia : DevExpress.XtraEditors.XtraForm
    {
        public frmReporteConsumoMPPorDia()
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

            using (SqlDataAdapter da = new SqlDataAdapter("dbo.usp_getReporteConsumoMPPorFechas", cnx))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@fecha_inicio", dtDesde.EditValue);
                da.SelectCommand.Parameters.Add("@fecha_fin", dtHasta.EditValue);

                cnx.Open();
                dsReportes.ReporteConsumoMPPorFecha.Clear();
                da.Fill(dsReportes.ReporteConsumoMPPorFecha);
                cnx.Close();
            }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void load_data_detalle()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.usp_getReporteConsumoMPPorFechas_detalle", cnx))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@fecha_inicio", dtDesde.EditValue);
                    da.SelectCommand.Parameters.Add("@fecha_fin", dtHasta.EditValue);

                    cnx.Open();
                    dsReportes.ReporteConsumoMPPorFecha_detalle.Clear();
                    da.Fill(dsReportes.ReporteConsumoMPPorFecha_detalle);
                    cnx.Close();
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void load_data_mensual()
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

                using (SqlDataAdapter da = new SqlDataAdapter("[dbo].[usp_GetConsumoMensualMP]", cnx))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@fecha_inicio", dtDesde.EditValue);
                    da.SelectCommand.Parameters.Add("@fecha_fin", dtDesde.EditValue);

                    cnx.Open();
                    dsReportes.ReporteConsumoMPMensual.Clear();
                    da.Fill(dsReportes.ReporteConsumoMPMensual);
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
            load_data_detalle();
            load_data_mensual();
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
            //Nueva version
            //SaveFileDialog dialog1 = new SaveFileDialog();
            //dialog1.Filter = "Excel File (.xlsx)|*.xlsx";
            //dialog1.FilterIndex = 0;

            //if (dialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    gcReporteDiario.ExportToXlsx(dialog1.FileName);

            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;
                string path = "Saldo de Cuenta";




                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                    //Customize export options
                    if (xtraTabControl1.SelectedTabPage == tpDiario)
                    {
                        gridView1.OptionsPrint.AutoWidth = true;
                        //(gcReporteDiario.MainView as GridView).OptionsPrint.PrintHeader = true;

                    }
                    else
                    {
                        gridView2.OptionsPrint.AutoWidth = true;
                        //(gcReporteMensual.MainView as GridView).OptionsPrint.PrintHeader = true;
                    }

                    XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                    //DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.WYSIWYG;
                    advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;

                    advOptions.ExportType = DevExpress.Export.ExportType.DataAware;
                    advOptions.TextExportMode = TextExportMode.Value;
                    advOptions.BandedLayoutMode = DevExpress.Export.BandedLayoutMode.LinearColumns;


                    advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.SheetName = "Exported from Ovejita";
                    advOptions.ExportType = DevExpress.Export.ExportType.WYSIWYG;

                    if (xtraTabControl1.SelectedTabPage == tpDiario)
                    {
                        gcReporteDiario.ExportToXlsx(path, advOptions);
                    }
                    else
                    {
                        gcReporteMensual.ExportToXlsx(path, advOptions);
                    }
                    // Open the created XLSX file with the default application.
                    Process.Start(path);

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gridView1_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            GridView dView = gridView1.GetDetailView(e.RowHandle, 0) as GridView;

            dView.Columns["llave"].Visible = false;
        }

        private void gridView1_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e)
        {
            var view = sender as GridView;
            var detailView = view.GetDetailView(e.RowHandle, e.RelationIndex);
            e.RelationName =   "Detalle";
        }
    }
}