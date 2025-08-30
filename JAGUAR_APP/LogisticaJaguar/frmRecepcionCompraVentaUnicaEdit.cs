using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_PRO.Clases;
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
    public partial class frmRecepcionCompraVentaUnicaEdit : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public ProductoUsado ProductoUsado;
        bool isUpdating = false;
        public frmRecepcionCompraVentaUnicaEdit(UserLogin userLogin, ProductoUsado productoUsado)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin; 
            
            ProductoUsado = productoUsado;

            if (ProductoUsado != null)
            {
                txtDescripcion.Text = ProductoUsado.Descripcion;
                txtCosto.EditValue = ProductoUsado.Costo;
                txtMargGanancia.EditValue = ProductoUsado.Margen;
                txtCosto.EditValue = ProductoUsado.Costo;
                txtPrecioVenta.EditValue = ProductoUsado.PrecioVenta;

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()))
            {
                CajaDialogo.Error("No puede dejar en vacio las descripciones!");
                return;
            }

            if (string.IsNullOrEmpty(txtCosto.Text) || Convert.ToDecimal(txtCosto.EditValue) < 0)
            {
                CajaDialogo.Error("El Costo debe ser un numero valido!");
                return;
            }

            if (string.IsNullOrEmpty(txtPrecioVenta.Text) || Convert.ToDecimal(txtPrecioVenta.EditValue) < 0)
            {
                CajaDialogo.Error("El Precio de Venta debe ser un numero valido!");
                return;
            }

            try
            {
                ProductoUsado.Descripcion = txtDescripcion.Text;
                ProductoUsado.Costo = Convert.ToDecimal(txtCosto.EditValue);
                ProductoUsado.Margen = Convert.ToDecimal(txtMargGanancia.EditValue);
                ProductoUsado.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.EditValue);

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void txtMargGanancia_EditValueChanged(object sender, EventArgs e)
        {
            if (isUpdating) return; // evita bucle
            isUpdating = true;

            if (decimal.TryParse(Convert.ToString(txtCosto.EditValue), out decimal costo) &&
                decimal.TryParse(Convert.ToString(txtMargGanancia.EditValue), out decimal margen))
            {
                // Aquí margen es el porcentaje de utilidad (markup sobre costo)
                decimal precioVenta = costo * (1 + margen / 100);
                txtPrecioVenta.EditValue = precioVenta;
            }

            isUpdating = false;
        }

        private void txtPrecioVenta_EditValueChanged(object sender, EventArgs e)
        {
            if (isUpdating) return; // evita bucle
            isUpdating = true;

            if (decimal.TryParse(Convert.ToString(txtCosto.EditValue), out decimal costo) &&
                decimal.TryParse(Convert.ToString(txtPrecioVenta.EditValue), out decimal precioVenta))
            {
                if (costo > 0)
                {
                    // Aquí margen se calcula en base a precio (margen real)
                    decimal ganancia = precioVenta - costo;
                    decimal margen = (ganancia / costo) * 100; // markup sobre costo
                    txtMargGanancia.EditValue = margen;
                }
                else
                {
                    txtMargGanancia.EditValue = 0;
                }
            }

            isUpdating = false;
        }
    }
}