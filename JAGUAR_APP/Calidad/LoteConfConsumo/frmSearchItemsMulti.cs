using ACS.Classes;
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
    public partial class frmSearchItemsMulti : DevExpress.XtraEditors.XtraForm
    {
        enum TipoBusqueda
        {
            Ninguna = 0,
            PorCodigoPT = 1,
            PorDescripcion = 2,
            PorCodReferencia = 3,
            PorCodCombinado = 4,
            PorMarca = 5
        }

        TipoBusqueda tipoBusquedaActual;
        
        public DataTable ListProductosSeleccionados = new DataTable();

        public ItemBusqueda ItemSeleccionado = new ItemBusqueda();
        public frmSearchItemsMulti()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (gridView2.RowCount != 0)
            {
                

                foreach (dsConfigLoteConsumo.search_ptRow item in dsConfigLoteConsumo1.search_pt.Rows)
                {
                    if (item.Seleccionado)
                    {
                        bool yaExiste = dsConfigLoteConsumo1.items_confirmados.AsEnumerable()
                                        .Any(r => r.code_pt.ToString() == item.code);

                        if (!yaExiste)
                        {
                            DataRow dr = dsConfigLoteConsumo1.items_confirmados.NewRow();
                            dr[0] = item.id;
                            dr[1] = item.code;
                            dr[2] = item.code_referencia;
                            dr[3] = item.descripcion;
                            dsConfigLoteConsumo1.items_confirmados.Rows.Add(dr);
                            dsConfigLoteConsumo1.items_confirmados.AcceptChanges();
                        }
                        
                    }
                }
            }
            else
            {
                CajaDialogo.Error("Debe seleccionar por lo menos 1 Item");
                return;
            }
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscare_Click(new object(), new EventArgs());
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
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
                CajaDialogo.Error(ex.Message);
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            tipoBusquedaActual = TipoBusqueda.PorCodigoPT;
            txtDesc.Text = txtCodRefe.Text = txtCodComb.Text = txtMarca.Text = string.Empty;
        }

        private void txtDesc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscare_Click(new object(), new EventArgs());
            }
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            tipoBusquedaActual = TipoBusqueda.PorDescripcion;
            txtCode.Text = txtCodComb.Text = txtCodRefe.Text = txtMarca.Text = string.Empty;
        }

        private void txtCodRefe_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnBuscare_Click(new object(), new EventArgs());
            }
        }

        private void txtCodRefe_TextChanged(object sender, EventArgs e)
        {
            tipoBusquedaActual = TipoBusqueda.PorCodReferencia;
            txtCode.Text = txtDesc.Text = txtCodComb.Text = txtMarca.Text = string.Empty;
        }

        private void txtCodComb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscare_Click(new object(), new EventArgs());
            }
        }

        private void txtCodComb_TextChanged(object sender, EventArgs e)
        {
            tipoBusquedaActual = TipoBusqueda.PorCodCombinado;
            txtCode.Text = txtDesc.Text = txtCodRefe.Text = txtMarca.Text = string.Empty;
        }

        private void txtMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscare_Click(new object(), new EventArgs());
            }
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            tipoBusquedaActual = TipoBusqueda.PorMarca;
            txtCode.Text = txtDesc.Text = txtCodRefe.Text = txtCodComb.Text = string.Empty;
        }

        private void btnBuscare_Click(object sender, EventArgs e)
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
                case TipoBusqueda.PorMarca:
                    BusquedaProductos(txtMarca.Text.Trim());
                    break;
                default:
                    break;
            }
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            if (grdvConfirmados.RowCount == 0)
            {
                CajaDialogo.Error("No existe registros para obtener.");
                return;
            }

            ListProductosSeleccionados.Columns.Add("id", typeof(int));
            ListProductosSeleccionados.Columns.Add("code", typeof(string));
            ListProductosSeleccionados.Columns.Add("code_referencia", typeof(string));
            ListProductosSeleccionados.Columns.Add("descripcion", typeof(string));

            foreach (dsConfigLoteConsumo.items_confirmadosRow item in dsConfigLoteConsumo1.items_confirmados.Rows)
            {
                ListProductosSeleccionados.Rows.Add(item.id, item.code_pt, item.code_referencia, item.descripcion);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void reposDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            var gridView1 = (GridView)gridControl1.FocusedView;
            var row = (dsConfigLoteConsumo.items_confirmadosRow)gridView1.GetFocusedDataRow();

            try
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                dsConfigLoteConsumo1.AcceptChanges();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}