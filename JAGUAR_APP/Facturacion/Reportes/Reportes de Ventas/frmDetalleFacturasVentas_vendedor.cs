using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using JAGUAR_PRO.Clases;
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

namespace JAGUAR_PRO.Facturacion.Reportes.Reportes_de_Ventas
{
    public partial class frmDetalleFacturasVentas_vendedor : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        int IdVendedor;
        DateTime Desde, Hasta;

        public frmDetalleFacturasVentas_vendedor(UserLogin pUsuario, DateTime pDesde, DateTime pHasta, 
                                                 int pIdVendedor, string pVendedorCode, string pVendedorName)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuario;
            Desde = pDesde;
            Hasta = pHasta;
            IdVendedor = pIdVendedor;
            lblVendedor.Text = string.Concat(pVendedorCode, " - ", pVendedorName);
            lblRangoFechas.Text = string.Concat("Desde: ", string.Format("{0:d/MM/yyyy}", pDesde), " hasta: ", string.Format("{0:d/MM/yyyy}", pHasta));

            LoadDatos();
        }

        private void cmdExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;
                string path = "Ventas NORMAC System";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                    //Customize export options
                    (gridControl1.MainView as GridView).OptionsPrint.PrintHeader = true;
                    XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                    advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.SheetName = "Exported from NORMAC";

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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void LoadDatos()
        {

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_resumen_ventas_vendedores_by_rango_fechas_detalle_factura]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_vendedor", IdVendedor);
                cmd.Parameters.AddWithValue("@fecha_desde", Desde);
                cmd.Parameters.AddWithValue("@fecha_hasta", Hasta);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReportesDeVenta1.detalle_facturas.Clear();
                adat.Fill(dsReportesDeVenta1.detalle_facturas);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}