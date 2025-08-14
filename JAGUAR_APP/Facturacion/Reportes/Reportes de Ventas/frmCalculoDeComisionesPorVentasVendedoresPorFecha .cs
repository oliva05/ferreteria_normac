using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Facturacion.CoreFacturas;
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
    public partial class frmCalculoDeComisionesPorVentasVendedoresPorFecha : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp;
        UserLogin UsuarioLogeado;
        public frmCalculoDeComisionesPorVentasVendedoresPorFecha(UserLogin pUsuario)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuario;
            dp = new DataOperations();

            DateTime fechaActual = dp.NowSetDateTime();
            DateTime FechaInicial = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, 0, 0, 0);
            DateTime FechaFinal = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, 23, 59, 0);

            dtDesde.EditValue = FechaInicial;
            dtHasta.EditValue = FechaFinal;

            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_calculo_comisiones_ventas_vendedores_by_rango_fechas]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);
                cmd.Parameters.AddWithValue("@fecha_desde", dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@fecha_hasta", dtHasta.DateTime);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReportesDeVenta1.calculo_comisiones_vendedores.Clear();
                adat.Fill(dsReportesDeVenta1.calculo_comisiones_vendedores);

                con.Close();
                gridView1.ExpandAllGroups();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            LoadDatos();
        }

        private void cmdVerDetalle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gv = (GridView)gridControl1.FocusedView;
            var row = (dsReportesDeVenta.resumen_ventas_vendedoersRow)gv.GetDataRow(gv.FocusedRowHandle);
            frmDetalleFacturasVentas_vendedor frm = new frmDetalleFacturasVentas_vendedor(this.UsuarioLogeado,
                                                                                          dtDesde.DateTime,
                                                                                          dtHasta.DateTime,
                                                                                          row.id,
                                                                                          row.codigo_vendedor,
                                                                                          row.nombre);
            frm.ShowDialog();
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
    }
}