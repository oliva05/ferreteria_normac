using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Facturacion.Reportes;
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

namespace JAGUAR_PRO.Facturacion.CoreFacturas
{
    public partial class HomeEstadoCuenta : DevExpress.XtraEditors.XtraForm
    {
        public HomeEstadoCuenta(int id_clienteP)
        {
            InitializeComponent();
            //LoadData(20);
        }

        int id_cliente_selected=0;
        private void LoadData(int id_cliente)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.uspCargarEstadoCuentaByCliente", cnx);

                    dsContabilidad.EstadoCuenta.Clear();

                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int).Value = id_cliente;
                    da.Fill(dsContabilidad.EstadoCuenta);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadData(int id_cliente, DateTime pDesde, DateTime pHasta)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.[uspCargarEstadoCuentaByClienteV2]", cnx);

                    dsContabilidad.EstadoCuenta.Clear();

                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int).Value = id_cliente;
                    da.SelectCommand.Parameters.AddWithValue("@desde", pDesde);
                    da.SelectCommand.Parameters.AddWithValue("@hasta", pHasta);
                    da.Fill(dsContabilidad.EstadoCuenta);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            rptEstadoCuenta  report = new rptEstadoCuenta(id_cliente_selected);

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                // Send the report to the default printer.
                printTool.ShowPreviewDialog();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            id_cliente_selected = 0;

            xfrmSelectCliente frm = new xfrmSelectCliente();
            Cliente cliente = new Cliente();

            if (frm.ShowDialog()==DialogResult.OK)
            {
                if (cliente.RecuperarRegistro(frm.id_cliente))
                {
                    txtCliente.Text = cliente.Nombre;
                    txtCodigo.Text = cliente.Codigo;
                    txtCorreo.Text = cliente.Correo;
                    txtTelefono.Text = cliente.Telefono;
                    txtDireccion.Text = cliente.Direccion;
                    id_cliente_selected = frm.id_cliente;
                    lblSaldo.Text = string.Format("{0: ###,##0.00}", cliente.SaldoActual);

                    LoadData(frm.id_cliente);
                }
            }
        }

        private void cmdExportExcel_Click(object sender, EventArgs e)
        {
            //Nueva version

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

        private void tggUsarRangoFechas_Toggled(object sender, EventArgs e)
        {
            DataOperations dp1 = new DataOperations();
            if(tggUsarRangoFechas.IsOn)
            {
                simpleButton2.Enabled = dtHasta.Enabled = dtDesde.Enabled = true;
                dtHasta.DateTime = dp1.NowSetDateTime();
                dtDesde.DateTime = dtHasta.DateTime.AddDays(-15);
                LoadData(id_cliente_selected, dtDesde.DateTime, dtHasta.DateTime);
            }
            else
            {
                simpleButton2.Enabled = dtHasta.Enabled = dtDesde.Enabled = false;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            LoadData(id_cliente_selected, dtDesde.DateTime, dtHasta.DateTime);
        }
    }
}