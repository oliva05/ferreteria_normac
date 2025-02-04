using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Facturacion.CoreFacturas;
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

namespace JAGUAR_APP.Facturacion.Reportes
{
    public partial class frmReporteCambiosDePrecios : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        PDV puntoVentaActual = new PDV();
        DataOperations dp;
        DateTime fechaDesde;
        DateTime fechaHasta;
        public frmReporteCambiosDePrecios(UserLogin pUsuario, PDV pPuntoVentaActual)
        {
            InitializeComponent(); 
            UsuarioLogeado = pUsuario;
            puntoVentaActual = pPuntoVentaActual;
            dp = new DataOperations();
            DateTime fechaActual = dp.NowSetDateTime();
            fechaDesde = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day - 1, 0, 0, 0);
            fechaHasta = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, 23, 59, 59);
            dtDesde.DateTime = fechaDesde;
            dtHasta.DateTime = fechaHasta;
            LoadDatos();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Nueva version
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;
                string path = "Reporte Precios Ovejita";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                    //Customize export options
                    (gridControl1.MainView as GridView).OptionsPrint.PrintHeader = true;
                    XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                    advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.SheetName = "Exported from Ovejita";

                    gridControl1.ExportToXlsx(path, advOptions);
                    // Open the created XLSX file with the default application.
                    Process.Start(path);
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnRefreshPage1_Click(object sender, EventArgs e)
        {
            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_auditoria_precios_de_venta_facturacion]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_punto_venta", this.PuntoVentaActual.ID);
                cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReportesFacturacion1.cambios_de_precio.Clear();
                adat.Fill(dsReportesFacturacion1.cambios_de_precio);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}