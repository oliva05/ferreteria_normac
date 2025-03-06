using ACS.Classes;
using DevExpress.DashboardCommon.Native;
using DevExpress.XtraEditors;
using JAGUAR_PRO.Clases;
using LOSA.Calidad.LoteConfConsumo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO.LogisticaJaguar
{
    public partial class frmAddRecepcionCompraVentaUnica : DevExpress.XtraEditors.XtraForm
    {
        public frmAddRecepcionCompraVentaUnica()
        {
            InitializeComponent();
        }

        private void btnSelecItemCode_Click(object sender, EventArgs e)
        {
            frmSearchDefault frm = new frmSearchDefault(frmSearchDefault.TipoBusqueda.ProductoTerminadoVentaUnica);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtCodigoPT.Text = frm.ItemSeleccionado.ItemCode;
                txtItemName.Text = frm.ItemSeleccionado.ItemName;
                txtDescripcion.Text = frm.ItemSeleccionado.ItemName;

            }
        }

        private void btnAddLote_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                CajaDialogo.Error("Debe indicar una descripcion!");
                txtDescripcion.Focus();
                return;
            }

            if ((decimal)txtCosto.EditValue == 0)
            {
                CajaDialogo.Error("El Valor del Costo debe ser mayor a 0");
                txtCosto.Focus();
                return;
            }

            if ((decimal)txtPrecioVenta.EditValue == 0)
            {
                CajaDialogo.Error("Debe inidcar el Precio de Venta!");
                txtPrecioVenta.Focus();
                return;
            }

            if ((int)spinUd.EditValue <= 0)
            {
                CajaDialogo.Error("Debe indicar cantidad mayor a 0!");
                txtPrecioVenta.Focus();
                return;
            }

            try
            {
                ProductoTerminado pt = new ProductoTerminado();
                pt.GenerarCodigoPTVentaUnica(txtCodigoPT.Text.Trim());
                int Contador = (int)spinUd.EditValue;
                int correlativo = pt.IdSiguiente;
                
                while (Contador > 0)
                {
                    DataRow dr = dsProductoTerminado1.pt_venta_unica.NewRow();
                    dr[0] = 0;
                    dr[1] = txtDescripcion.Text;
                    dr[2] = txtCodigoPT.Text.Trim();
                    dr[3] = txtCosto.EditValue;
                    dr[4] = txtMargGanancia.EditValue;
                    dr[5] = txtPrecioVenta.EditValue;
                    dr[6] = txtCodigoPT + "00" + correlativo.ToString();
                    dr[7] = correlativo.ToString();
                    dsProductoTerminado1.pt_venta_unica.Rows.Add(dr);
                    dsProductoTerminado1.pt_venta_unica.AcceptChanges();

                    Contador--;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}