using ACS.Classes;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace JAGUAR_PRO.Calidad.LoteConfConsumo
{
    public partial class frmSearchItems : DevExpress.XtraEditors.XtraForm
    {
  
        public ItemBusqueda ItemSeleccionado;
        public frmSearchItems()
        {
            InitializeComponent();
        }

        private void txtParametroBusqueda_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtParametroBusqueda.Text.Trim();

            string query = @"sp_get_items_by_filtro";
            DataOperations dp = new DataOperations();
            using (SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@filtro", "%" + filtro+"%");
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsConfigLoteConsumo1.search_pt.Clear();
                adat.Fill(dsConfigLoteConsumo1.search_pt);
                conn.Close();
            }
            
        }

        private void cmdAplicar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControlDetalleMP.FocusedView;
            var row = (dsConfigLoteConsumo.search_ptRow)gridView.GetFocusedDataRow();

            ItemSeleccionado.id = row.id;
            ItemSeleccionado.ItemCode = row.code;
            ItemSeleccionado.ItemName = row.descripcion;
            row.Seleccionado = true;
            cmdAplicar_Click(new object(), new EventArgs());

            foreach (dsConfigLoteConsumo.search_ptRow row1 in dsConfigLoteConsumo1.search_pt)
            {
                if (row1.id != ItemSeleccionado.id)
                    row1.Seleccionado = false;
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var gridView = (GridView)gridControlDetalleMP.FocusedView;
                var row = (dsConfigLoteConsumo.search_ptRow)gridView.GetFocusedDataRow();

                //row.Seleccionado = true;
                ItemSeleccionado.id = row.id;
                ItemSeleccionado.ItemCode = row.code;
                ItemSeleccionado.ItemName = row.descripcion;
                //row.Seleccionado = true;
                cmdAplicar_Click(sender, new EventArgs());
            }
        }
    }
}