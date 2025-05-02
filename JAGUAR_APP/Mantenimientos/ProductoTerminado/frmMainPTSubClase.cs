using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.LogisticaJaguar;
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

namespace JAGUAR_PRO.Mantenimientos.ProductoTerminado
{
    public partial class frmMainPTSubClase : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmMainPTSubClase(UserLogin userLogin)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
            tggViewFilter.IsOn = false;
            loaddate();
        }

        private void loaddate()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_pt_get_sub_clases", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ver_todos", tggViewFilter.IsOn);
                dsProductoTerminado1.subClase.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProductoTerminado1.subClase);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNuevoPT_Click(object sender, EventArgs e)
        {
            frmCRUD_PTSubClase frm = new frmCRUD_PTSubClase(frmCRUD_PTSubClase.Operacion.Insert, 0, 0, string.Empty, string.Empty, true);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                loaddate();
            }
        }

        private void tggViewFilter_Toggled(object sender, EventArgs e)
        {
            loaddate();
        }

        private void cmdEditar2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridDetalleProductosCRUD.FocusedView;
            var row = (dsProductoTerminado.subClaseRow)gridview.GetFocusedDataRow();

            if (row.id_subClase > 0)
            {
                frmCRUD_PTSubClase frm = new frmCRUD_PTSubClase(frmCRUD_PTSubClase.Operacion.Update, row.id_subClase, row.id_clase, row.nombre, row.codigo, row.enable);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    loaddate();
                }
            }
        }

        private void cmdExportToExcel_Click(object sender, EventArgs e)
        {
            //Nueva version
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;
                string path = "Inventario PT Ovejita";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                    //Customize export options
                    (gridDetalleProductosCRUD.MainView as GridView).OptionsPrint.PrintHeader = true;
                    XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                    advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.SheetName = "Exported from Ovejita";

                    gridDetalleProductosCRUD.ExportToXlsx(path, advOptions);
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