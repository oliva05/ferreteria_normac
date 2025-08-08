using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Mantenimientos;
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

namespace JAGUAR_PRO.Contabilidad.Proveedores
{
    public partial class frmCRUDAnticipo : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;

        public frmCRUDAnticipo(UserLogin userLogin)
        {
            InitializeComponent();
            ObtenerProveedores();
        }

        private void lueProveedor_EditValueChanged(object sender, EventArgs e)
        {
            if ((int)lueProveedor.EditValue > 0)
            {
                txtMonto.Focus();
            }
        }

        private void ObtenerProveedores()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    dsMantenimiento1.JAGUAR_Proveedor.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_GetProveedores", cnx);
                    da.Fill(dsMantenimiento1.JAGUAR_Proveedor);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void txtMonto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSelecOC_Click(sender, e);
            }
        }

        private void btnSelecOC_Click(object sender, EventArgs e)
        {

        }
    }
}