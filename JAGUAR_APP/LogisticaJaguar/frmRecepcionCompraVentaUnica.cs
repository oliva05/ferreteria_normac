using ACS.Classes;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Commands;
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

namespace JAGUAR_PRO.LogisticaJaguar
{
    public partial class frmRecepcionCompraVentaUnica : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public frmRecepcionCompraVentaUnica(UserLogin pUserLog)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLog;
            dtDesde.DateTime = dp.Now().AddDays(-30);
            dtHasta.DateTime = dp.Now().AddDays(1);
            LoadaData();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAddRecepcionCompraVentaUnica frm = new frmAddRecepcionCompraVentaUnica(UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadaData();
            }
        }

        private void LoadaData()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_pt_load_ingresos_venta_unica", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsProductoTerminado1.ingreso_pt_venta_unica.Clear();
                adat.Fill(dsProductoTerminado1.ingreso_pt_venta_unica);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void frmRecepcionCompraVentaUnica_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            LoadaData();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd.ExportToXlsx(dialog.FileName);
            }
        }

        private void cmdPrintFromGrid_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}