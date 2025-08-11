using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.UI;
using DocumentFormat.OpenXml.Wordprocessing;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.LogisticaJaguar;
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

namespace JAGUAR_PRO.Facturacion.Deposito
{
    public partial class frmDepositoBancoMain : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        PDV PuntoVenta;
        FacturacionEquipo Equipo;
        DataOperations dp;
        public frmDepositoBancoMain(UserLogin puserlog, PDV p1, FacturacionEquipo equipo)
        {
            InitializeComponent();
            UsuarioLogeado = puserlog;
            PuntoVenta = p1;
            Equipo = equipo;        
            
            dp = new DataOperations();
            dtDesde.EditValue = dp.Now().AddDays(-1);
            dtHasta.EditValue = dp.Now().AddDays(1);

            LoaData();

            

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    accesoprevio = false;
                    gridView1.Columns["editar"].Visible = false;
                    gridView1.OptionsMenu.EnableColumnMenu = false;
                    break;
                case 2://Basic No Autorization
                    gridView1.Columns["editar"].Visible = false;
                    gridView1.OptionsMenu.EnableColumnMenu = false;
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    gridView1.Columns["editar"].Visible = false;
                    gridView1.OptionsMenu.EnableColumnMenu = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    gridView1.OptionsMenu.EnableColumnMenu = true;
                    lblEnable.Visible = tggEnable.Visible = true;
                    break;
                default:
                    gridView1.Columns["editar"].Visible = false;
                    gridView1.OptionsMenu.EnableColumnMenu = false;
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(32))
                {
                    //gridView1.Columns["editar"].Visible = true;
                }
                else
                {
                    gridView1.Columns["editar"].Visible = false;
                    gridView1.OptionsMenu.EnableColumnMenu = false;
                }
            }
        }

        private void LoaData()
        {
            string query = @"sp_get_listad_depositos";

            if(tggEnable.Visible)
                query = @"[sp_get_listad_depositos_v2]";

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                cmd.Parameters.AddWithValue("@puntoVentaId", PuntoVenta.ID);
                cmd.Parameters.AddWithValue("@completado", 1);

                if (tggEnable.Visible)
                    cmd.Parameters.AddWithValue("@enable", tggEnable.IsOn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsDepositos1.lista_depositos.Clear();
                da.Fill(dsDepositos1.lista_depositos);
                conn.Close();
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

        private void cmdExportToExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            LoaData();
        }

        private void cmdPagar_Click(object sender, EventArgs e)
        {
            frmDepositoBancoOP frm = new frmDepositoBancoOP(frmDepositoBancoOP.TipoOperacion.Nuevo, UsuarioLogeado, PuntoVenta,0);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void reposPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsDepositos.lista_depositosRow)gridview.GetFocusedDataRow();

            if (row != null)
            {
                rptDepositoBancario report = new rptDepositoBancario(row.id, PuntoVenta) { ShowPrintMarginsWarning = false };
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(report);
                //printReport.ShowPreviewDialog();
                printReport.ShowPreviewDialog();
            }

        }

        private void cmdEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gv = (GridView)gridControl1.FocusedView;
            var row = (dsDepositos.lista_depositosRow)gv.GetDataRow(gv.FocusedRowHandle);

            frmDepositoBancoOP frm = new frmDepositoBancoOP(frmDepositoBancoOP.TipoOperacion.Editar, UsuarioLogeado, PuntoVenta,row.id);
            frm.MdiParent = this.MdiParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoaData();
            }
        }
    }
}