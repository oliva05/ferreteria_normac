using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_PRO.Facturacion.CoreFacturas;
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

namespace JAGUAR_PRO.Despachos.Pedidos
{
    public partial class frmCopiarPedidoDesde : DevExpress.XtraEditors.XtraForm
    {
        public int IdPedido;
        public frmCopiarPedidoDesde()
        {
            InitializeComponent();
            txtCodigoCot.Focus();
        }

        private void cmdAbrirCotizacion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsPedidosBusquedas.cotizacionesRow)gridView.GetFocusedDataRow();

            IdPedido = row.id_pedido;
            this.DialogResult = DialogResult.OK;
            this.Close  ();
        }

        private void txtCodigoCot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("[dbo].[sp_get_buscar_codigo_cotizacion_h]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    int NumCoti = Convert.ToInt32(txtCodigoCot.Text);

                    if(NumCoti < 99)
                        cmd.Parameters.AddWithValue("@numDocCotizacion", "COT0" + txtCodigoCot.Text);
                    else
                        cmd.Parameters.AddWithValue("@numDocCotizacion", "COT" + txtCodigoCot.Text);
                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    dsPedidosBusquedas1.cotizaciones.Clear();
                    adat.Fill(dsPedidosBusquedas1.cotizaciones);

                    if(dsPedidosBusquedas1.cotizaciones.Rows.Count <= 0)
                    {
                        dxErrorProvider1.SetError(txtCodigoCot, "No se encontro ninguna cotización!");
                    }
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsPedidosBusquedas.cotizacionesRow)gridView.GetFocusedDataRow();
            IdPedido = row.id_pedido;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmCopiarPedidoDesde_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((Action)(() => txtCodigoCot.Focus()));
        }
    }
}