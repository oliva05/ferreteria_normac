using ACS.Classes;
using DevExpress.DashboardCommon.DataBinding;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_PRO.LogisticaJaguar;
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
    public partial class frmSelectAlmacen : DevExpress.XtraEditors.XtraForm
    {
        int IdPT;
        public int IdAlmacen;
        public frmSelectAlmacen(int pidPT)
        {
            InitializeComponent();
            IdPT = pidPT;
            LoadAlmacenesByIdPT();
        }

        private void LoadAlmacenesByIdPT()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_get_config_bodegas_by_pt]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt",IdPT);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPT1.select_almacen.Clear();
                adat.Fill(dsPT1.select_almacen);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsPT.select_almacenRow)gridview.GetFocusedDataRow();

            if (row != null) {

                IdAlmacen = row.id;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}