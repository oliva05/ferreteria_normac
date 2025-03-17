using ACS.Classes;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using JAGUAR_PRO.Mantenimientos.Modelos;
using JAGUAR_PRO.Requisiciones.Reportes;
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
    public partial class frmVerDetalleKardexTransactions : DevExpress.XtraEditors.XtraForm
    {
        int IdPT;
        string NamePT;
        decimal InvActual;
        int IdAlmacen;

        public frmVerDetalleKardexTransactions(int pIdPT, string pName, decimal pInv)
        {
            InitializeComponent();
            NamePT = pName;
            InvActual = pInv;
            IdPT = pIdPT;
            
            lblItemName.Text = pName;
            lblInventario.Text = string.Format("{0:###,##0}", pInv);

            LoadDatos(pIdPT);
        }

        public frmVerDetalleKardexTransactions(int pIdPT, string pName, decimal pInv, int pIdAlmacen)
        {
            InitializeComponent();
            NamePT = pName;
            InvActual = pInv;
            IdPT = pIdPT;
            IdAlmacen = pIdAlmacen;

            lblItemName.Text = pName;
            lblInventario.Text = string.Format("{0:###,##0}", pInv);

            Bodega bod1 = new Bodega();
            if (bod1.RecuperarRegistro(IdAlmacen))
            {
                lblAlmacen.Text = bod1.CodigoBodega + " - " + bod1.Descripcion;
            }

            LoadDatos(pIdPT);
        }

        private void LoadDatos(int pIdPT)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[sp_get_detalle_transacciones_kardex_pt_from_idpt_v2]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", pIdPT);
                cmd.Parameters.AddWithValue("@id_almacen", IdAlmacen);
                
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsKardexReportes1.detalle_transacciones_kardex.Clear();
                adat.Fill(dsKardexReportes1.detalle_transacciones_kardex);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;
                string path = "Detalle Transacciones Kardex PT Ovejita";

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

        private void cmdRecargar_Click(object sender, EventArgs e)
        {

        }
    }
}