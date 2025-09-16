using ACS.Classes;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_PRO.Accesos.AccesosUsuarios;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.LogisticaJaguar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO.Contabilidad.CuentasContables
{
    public partial class frmCuentasContablesHome : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        public frmCuentasContablesHome(UserLogin userLogin)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_list_account", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@enable", toggleSwitch1.IsOn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCuentasC1.get_list_account.Clear();
                da.Fill(dsCuentasC1.get_list_account);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCuentasContablesCRUD frm = new frmCuentasContablesCRUD(frmCuentasContablesCRUD.Operacion.Nuevo, UsuarioLogeado, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void cmdVer_Editar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdCuentasContables.FocusedView;
            var row = (dsCuentasC.get_list_accountRow)gridview.GetFocusedDataRow();

            if (row != null)
            {
                frmCuentasContablesCRUD frmCuentasContablesCRUD = new frmCuentasContablesCRUD(frmCuentasContablesCRUD.Operacion.Modificar, UsuarioLogeado, row.CuentaID);
                if (frmCuentasContablesCRUD.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdCuentasContables.ExportToXlsx(dialog.FileName);
            }
        }
    }
}