using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Accesos.AccesosUsuarios;
using ACS.Classes;
using JAGUAR_PRO.LogisticaJaguar;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;

namespace JAGUAR_PRO.TransaccionesPT
{
    public partial class frmMainTrasladoPT : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();

        public frmMainTrasladoPT(UserLogin userLogin)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
            dtDesde.DateTime = dp.Now().AddDays(-30);
            dtHasta.DateTime = dp.Now().AddDays(1);
            LoadDatos();
        }

        private void btnTraslado_Click(object sender, EventArgs e)
        {
            frmNewTrasladoPT frm = new frmNewTrasladoPT(UsuarioLogeado, frmNewTrasladoPT.TipoOperacion.TrasladoFinal);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDatos();
            }
        }
        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                //SqlCommand cmd = new SqlCommand("codesahn.sp_get_detalle_facturas_recibidas", con);
                SqlCommand cmd = new SqlCommand("dbo.[sp_pt_traslados_almacenes_by_dates]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@ver_todas", toggleSwitchVerTodas.IsOn);
                cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                dsPT1.traslados_h.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPT1.traslados_h);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            LoadDatos();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reposReport_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsPT.traslados_hRow)gridview.GetFocusedDataRow();


            if (row != null) 
            {
                xrptTraslado report = new xrptTraslado(row.id_traslado);
                report.ShowPrintMarginsWarning = false;
                report.ShowPreview();
            }
        }
    }
}