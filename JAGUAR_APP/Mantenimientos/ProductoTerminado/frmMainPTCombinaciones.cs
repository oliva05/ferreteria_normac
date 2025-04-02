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
using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_PRO.Clases;

namespace JAGUAR_PRO.Mantenimientos.ProductoTerminado
{
    public partial class frmMainPTCombinaciones : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmMainPTCombinaciones(UserLogin userLogin)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
            loaddate();
        }

        private void loaddate()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_pt_get_combinacion_codigos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                
                dsProductoTerminado1.pt_combinaciones_generadas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProductoTerminado1.pt_combinaciones_generadas);

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
    }
}