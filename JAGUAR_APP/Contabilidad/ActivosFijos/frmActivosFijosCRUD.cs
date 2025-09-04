using ACS.Classes;
using DevExpress.XtraEditors;
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

namespace JAGUAR_PRO.Contabilidad.ActivosFijos
{
    public partial class frmActivosFijosCRUD : DevExpress.XtraEditors.XtraForm
    {
        public enum Operacion
        {
            Nuevo = 1,
            Modificar = 2,
            Consultar = 3
        }
        Operacion TOperacion;
        UserLogin UsuarioLogeado;
        int IdActivoFijo = 0;
        Clases.ActivosFijos af = new Clases.ActivosFijos();
        public frmActivosFijosCRUD(frmActivosFijosCRUD.Operacion operacion, UserLogin userLogin, int idActivoFijo)
        {
            InitializeComponent();
            TOperacion = operacion;
            UsuarioLogeado = userLogin;
            IdActivoFijo = idActivoFijo;
            LoadCuentas();
            
            switch (TOperacion)
            {
                case Operacion.Nuevo:
                    break;
                case Operacion.Modificar:
                   
                    af.RecuperarRegistros(IdActivoFijo);
                    txtCodigo.Text = af.CodigoActivo;
                    txtDescripcion.Text = af.NombreActivo;
                    dtfCompra.DateTime = af.FechaCompra;
                    txtValorCompra.Text = af.ValorCompra.ToString("N2");
                    txtVidaUtil.Text = af.VidaUtilMeses.ToString();
                    txtValorResidual.Text = af.ValorResidual.ToString("N2");
                    grdCuentaContable.EditValue = af.CuentaContableActivoID;
                    grdCuentaDepreciacion.EditValue = af.CuentaDepreciacionAcumuladaID;
                    grdCuentaGasto.EditValue = af.CuentaGastoDepreciacionID;

                    LoadDetalleDepreciacion();
                    break;
                case Operacion.Consultar:

                    af.RecuperarRegistros(IdActivoFijo);
                    txtCodigo.Text = af.CodigoActivo;
                    txtDescripcion.Text = af.NombreActivo;
                    dtfCompra.DateTime = af.FechaCompra;
                    txtValorCompra.Text = af.ValorCompra.ToString("N2");
                    txtVidaUtil.Text = af.VidaUtilMeses.ToString();
                    txtValorResidual.Text = af.ValorResidual.ToString("N2");
                    grdCuentaContable.EditValue = af.CuentaContableActivoID;
                    grdCuentaDepreciacion.EditValue = af.CuentaDepreciacionAcumuladaID;
                    grdCuentaGasto.EditValue = af.CuentaGastoDepreciacionID;
                    LoadDetalleDepreciacion();
                    SoloVista();
                    break;
                default:
                    break;
            }
        }

        private void LoadCuentas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_cuentas_contables_combo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void SoloVista()
        {
            try
            {
                txtDescripcion.ReadOnly = true;
                dtfCompra.ReadOnly = true;
                txtValorCompra.ReadOnly = true;
                txtVidaUtil.ReadOnly = true;
                txtValorResidual.ReadOnly = true;
                grdCuentaContable.ReadOnly = true;
                grdCuentaDepreciacion.ReadOnly = true;
                grdCuentaGasto.ReadOnly = true;
                btnGuardar.Visible = false;

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);  
            }
        }

        private void LoadDetalleDepreciacion()
        {
            throw new NotImplementedException();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                CajaDialogo.Error("Debe colocar la Descripcion del Articulo!");
                return;
            }

            if (string.IsNullOrEmpty(txtValorCompra.Text) || (decimal)txtValorCompra.EditValue <= 0)
            {
                CajaDialogo.Error("Valor de compra debe ser mayor que cero.");
                return;
            }

            if (string.IsNullOrEmpty(txtVidaUtil.Text) || (int)txtVidaUtil.EditValue <= 0)
            {
                CajaDialogo.Error("Vida Util debe ser mayor que cero.");
                return;
            }



        }
    }
}