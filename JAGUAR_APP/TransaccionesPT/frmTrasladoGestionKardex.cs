using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
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

namespace JAGUAR_PRO.TransaccionesPT
{
    public partial class frmTrasladoGestionKardex : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();

        public frmTrasladoGestionKardex(UserLogin userLogin)
        {
            InitializeComponent();

            UsuarioLogeado = userLogin;
            dtDesde.DateTime = dp.Now().AddDays(-15);
            dtHasta.DateTime = dp.Now().AddDays(1);

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
                SqlCommand cmd = new SqlCommand("dbo.[sp_pt_gestion_traslados_almacenes_by_dates]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@ver_todas", toggleSwitchVerTodas.IsOn);
                cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                cmd.Parameters.AddWithValue("@cerrados", tggIncluirDocCerrados.IsOn);
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

        private void tggIncluirDocCerrados_Toggled(object sender, EventArgs e)
        {
            LoadDatos();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridControl1.ExportToXlsx(dialog.FileName);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void reposImprimir_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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

        private void reposGestionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsPT.traslados_hRow)gridview.GetFocusedDataRow();

            bool Permitir = false;
            if(row != null)
            {
                switch (row.id_estado)
                {
                    case 1:
                        break;

                    case 2:
                        Permitir = true;
                        break;
                    case 5:
                        break;

                    default:
                        break;
                }

                if (Permitir)
                {
                    frmTrasladoGestionKardexOP frm = new frmTrasladoGestionKardexOP(UsuarioLogeado, row.id_traslado);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadDatos();
                    }
                }
                else
                {
                    CajaDialogo.Error("Traslado: "+row.num_traslado +" ya fue Completado!");
                    return;
                }
                
            }

        }
    }
}