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
  
         enum TipoBusqueda
        {
            Ninguna = 0,
            PorCodigoPT = 1,
            PorDescripcion = 2,
            PorCodReferencia = 3,
            PorCodCombinado = 4
        }

        TipoBusqueda tipoBusquedaActual;

        public ItemBusqueda ItemSeleccionado = new ItemBusqueda();
        public frmSearchItems()
        {
            InitializeComponent();
            txtDesc.Focus();
            tipoBusquedaActual = TipoBusqueda.Ninguna;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            switch (tipoBusquedaActual)
            {
                case TipoBusqueda.Ninguna:

                    CajaDialogo.Error("Debe escribir en los Filtros.");

                    break;
                case TipoBusqueda.PorCodigoPT:
                    BusquedaProductos(txtCode.Text.Trim());
                    break;
                case TipoBusqueda.PorDescripcion:
                    BusquedaProductos(txtDesc.Text.Trim());
                    break;
                case TipoBusqueda.PorCodReferencia:
                    BusquedaProductos(txtCodRefe.Text.Trim());
                    break;
                case TipoBusqueda.PorCodCombinado:
                    BusquedaProductos(txtCodComb.Text.Trim());
                    break;
                default:
                    break;
            }
        }

        private void BusquedaProductos(string filtro)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_items_by_filtro_v2", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@filtro", filtro);
                cmd.Parameters.AddWithValue("@TipoBusqueda", Convert.ToInt32(tipoBusquedaActual));
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsConfigLoteConsumo1.search_pt.Clear(); 
                adat.Fill(dsConfigLoteConsumo1.search_pt);
                conn.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            tipoBusquedaActual = TipoBusqueda.PorCodigoPT;
            txtDesc.Text = txtCodRefe.Text = txtCodComb.Text = string.Empty;
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            tipoBusquedaActual = TipoBusqueda.PorDescripcion;
            txtCode.Text = txtCodComb.Text = txtCodRefe.Text = string.Empty;
        }

        private void txtCodRefe_TextChanged(object sender, EventArgs e)
        {
            tipoBusquedaActual = TipoBusqueda.PorCodReferencia;
            txtCode.Text = txtDesc.Text = txtCodComb.Text = string.Empty;
        }

        private void txtCodComb_TextChanged(object sender, EventArgs e)
        {
            tipoBusquedaActual = TipoBusqueda.PorCodCombinado;
            txtCode.Text = txtDesc.Text = txtCodRefe.Text = string.Empty;
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsConfigLoteConsumo.search_ptRow)gridView.GetFocusedDataRow();

            ItemSeleccionado.id = Convert.ToInt32(row.id);
            ItemSeleccionado.ItemCode = row.code;
            ItemSeleccionado.ItemName = row.descripcion;
            row.Seleccionado = true;

            this.DialogResult = DialogResult.OK;
            this.Close();
            //cmdAplicar_Click(new object(), new EventArgs());

            //foreach (dsConfigLoteConsumo.search_ptRow row1 in dsConfigLoteConsumo1.search_pt)
            //{
            //    if (row1.id != ItemSeleccionado.id)
            //        row1.Seleccionado = false;
            //}
        }

        private void txtDesc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton2_Click(new object(), new EventArgs());
            }
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton2_Click(new object(), new EventArgs());
            }
        }

        private void txtCodRefe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton2_Click(new object(), new EventArgs());
            }
        }

        private void txtCodComb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton2_Click(new object(), new EventArgs());
            }
        }

        private void frmSearchItems_Shown(object sender, EventArgs e)
        {
            txtDesc.Focus();
        }
    }
}