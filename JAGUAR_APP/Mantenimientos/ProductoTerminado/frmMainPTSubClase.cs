using ACS.Classes;
using DevExpress.XtraEditors;
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
                dsProductoTerminado1.clase.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProductoTerminado1.clase);

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
    }
}