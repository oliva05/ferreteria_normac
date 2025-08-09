using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Model;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Compras;
using JAGUAR_PRO.Mantenimientos;
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

namespace JAGUAR_PRO.Contabilidad.Proveedores
{
    public partial class frmCRUDAnticipo : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        PDV PuntoVentaActual;
        int IdOrdenCompra = 0;
        DataOperations dp = new DataOperations();

    
        public frmCRUDAnticipo(UserLogin userLogin, PDV pDV)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
            PuntoVentaActual = pDV;
            ObtenerProveedores();
        }

        private void lueProveedor_EditValueChanged(object sender, EventArgs e)
        {
            if ((int)lueProveedor.EditValue > 0)
            {
                txtMonto.Focus();
            }
        }

        private void ObtenerProveedores()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    dsMantenimiento1.JAGUAR_Proveedor.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_GetProveedores", cnx);
                    da.Fill(dsMantenimiento1.JAGUAR_Proveedor);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void txtMonto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSelecOC_Click(sender, e);
            }
        }

        private void btnSelecOC_Click(object sender, EventArgs e)
        {
            frmSearchOrdenesC frm = new frmSearchOrdenesC(frmSearchOrdenesC.FiltroOrdenesCompra.DisponiblesAncitipos,PuntoVentaActual, UsuarioLogeado, frmSearchOrdenesC.TipoDoc.OrdenCompra, Convert.ToInt32(lueProveedor.EditValue));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.IdOrdenesSeleccionado > 0)
                {
                    IdOrdenCompra = frm.IdOrdenesSeleccionado;
                    OrdenesCompra oc = new OrdenesCompra();
                    oc.RecuperarRegistos(IdOrdenCompra);
                    txtDocOC.Text = oc.DocNum1;

                    memoComentario.Focus();
                }
            }
        }

        private void memoComentario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmdNew.Focus();
            }
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lueProveedor.EditValue) == 0 || string.IsNullOrEmpty(lueProveedor.Text))
            {
                CajaDialogo.Error("Debe seleccionar un Proveedor!");
                lueProveedor.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtMonto.Text) || Convert.ToDecimal(txtMonto.Text) <= 0)
            {
                CajaDialogo.Error("Debe ingresar un monto mayor a 0!");
                txtMonto.Focus();
                return;
            }

            //if (IdOrdenCompra <= 0)
            //{
            //    CajaDialogo.Error("Debe seleccionar una Orden de Compra!");
            //    btnSelecOC.Focus();
            //    return;
            //}

            SqlTransaction transaction = null;

            SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            bool Guardar = false;

            try
            {
                conn.Open();
                transaction = conn.BeginTransaction("Transaction Order");

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "sp_create_anticipo";
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proveedor_id",Convert.ToInt32(lueProveedor.EditValue));
                cmd.Parameters.AddWithValue("@monto_total", Convert.ToDecimal(txtMonto.EditValue));
                if (string.IsNullOrEmpty(txtDocOC.Text))
                    cmd.Parameters.AddWithValue("@orden_compra_id",0);
                else
                    cmd.Parameters.AddWithValue("@orden_compra_id", IdOrdenCompra);
                cmd.Parameters.AddWithValue("@descripcion",memoComentario.Text.Trim());
                cmd.Parameters.AddWithValue("@moneda_id", 44);// Moneda Lempira
                cmd.Parameters.AddWithValue("@usuario_creacion", UsuarioLogeado.Id);
                cmd.Parameters.AddWithValue("@puntoVentaId", PuntoVentaActual.ID);
                cmd.ExecuteNonQuery();

                transaction.Commit();
                Guardar = true;

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ec)
            {
                transaction.Rollback();
                CajaDialogo.Error(ec.Message);
                Guardar = false;
            }

            if (Guardar)
            {
                CajaDialogo.Information("Guardado con exito!");
                return;
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}