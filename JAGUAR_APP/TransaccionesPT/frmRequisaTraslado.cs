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

namespace JAGUAR_PRO.TransaccionesPT
{
    public partial class frmRequisaTraslado : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();


        public frmRequisaTraslado(UserLogin userLogin)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
            dtDesde.DateTime = dp.Now().AddDays(-30);
            dtHasta.DateTime = dp.Now().AddDays(1);
            LoadDatos();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                //SqlCommand cmd = new SqlCommand("codesahn.sp_get_detalle_facturas_recibidas", con);
                SqlCommand cmd = new SqlCommand("dbo.[sp_get_solicitudes_traslados_by_date]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@ver_todas", toggleSwitchVerTodas.IsOn);
                cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                dsPT1.solcitudes_h.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPT1.solcitudes_h);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnTraslado_Click(object sender, EventArgs e)
        {
            frmNewTrasladoPT frm = new frmNewTrasladoPT(UsuarioLogeado, frmNewTrasladoPT.TipoOperacion.SolicitudTraslado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDatos();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}