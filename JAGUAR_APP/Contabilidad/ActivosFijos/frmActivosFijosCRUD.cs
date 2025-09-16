using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Contabilidad.CuentasContables;
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
        public Clases.ActivosFijos af1 = new Clases.ActivosFijos();
        public frmActivosFijosCRUD(frmActivosFijosCRUD.Operacion operacion, UserLogin userLogin, int idActivoFijo)
        {
            InitializeComponent();
            TOperacion = operacion;
            UsuarioLogeado = userLogin;
            IdActivoFijo = idActivoFijo;
            LoadCuentas();

            Clases.ActivosFijos af = new Clases.ActivosFijos();
            switch (TOperacion)
            {
                case Operacion.Nuevo:
                    comboEstados.Text = "Activo";
                    comboEstados.ReadOnly = true;
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
                    comboEstados.Text = af.Estado;
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
                    comboEstados.Text = af.Estado;
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
                SqlCommand cmd = new SqlCommand("[sp_get_account_enable_af]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCuentasC1.get_account.Clear();
                da.Fill(dsCuentasC1.get_account);
                conn.Close();
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
            try
            {
                
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_depreciacion_activo_fijo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ActivoID", IdActivoFijo);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsActivosFijos1.detalle_depreciacion.Clear();
                da.Fill(dsActivosFijos1.detalle_depreciacion);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
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

            if (Convert.ToDecimal(txtValorCompra.EditValue) <= 0)
            {
                CajaDialogo.Error("Valor de compra debe ser mayor que cero.");
                return;
            }

            if (Convert.ToDecimal(txtVidaUtil.EditValue) <= 0)
            {
                CajaDialogo.Error("Vida Util debe ser mayor que cero.");
                return;
            }

            if (Convert.ToInt32(grdCuentaContable.EditValue) > 0)
            {
                CajaDialogo.Error("Debe seleccionar una Cuenta Contable!");
                return;
            }

            if (Convert.ToInt32(grdCuentaDepreciacion.EditValue) > 0)
            {
                CajaDialogo.Error("Debe seleccionar una Cuenta de Depreciacion!");
                return;
            }

            if (Convert.ToInt32(grdCuentaGasto.EditValue) > 0)
            {
                CajaDialogo.Error("Debe seleccionar una Cuenta de Gastos!");
                return;
            }

            DataOperations dp = new DataOperations();
            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            bool Guardar = false;
            conn.Open();
            transaction = conn.BeginTransaction("Transaction Order");
            SqlCommand cmd = conn.CreateCommand();

            switch (TOperacion)
            {
                case Operacion.Nuevo:
                    try
                    {
                        cmd.CommandText = "sp_insert_activos_fijos";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@ActivoID", IdActivoFijo);
                        cmd.Parameters.AddWithValue("@NombreActivo", txtDescripcion.Text.Trim());
                        cmd.Parameters.AddWithValue("@FechaCompra", dtfCompra.DateTime);
                        cmd.Parameters.AddWithValue("@ValorCompra", Convert.ToDecimal(txtValorCompra.EditValue));
                        cmd.Parameters.AddWithValue("@VidaUtilMeses", Convert.ToInt32(txtVidaUtil.EditValue));
                        cmd.Parameters.AddWithValue("@ValorResidual", Convert.ToDecimal(txtValorResidual.EditValue));
                        if (Convert.ToInt32(grdCuentaContable.EditValue) == 0)
                            cmd.Parameters.AddWithValue("@CuentaContableActivoID", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@CuentaContableActivoID", Convert.ToInt32(grdCuentaContable.EditValue));
                        if (Convert.ToInt32(grdCuentaDepreciacion.EditValue) == 0)
                            cmd.Parameters.AddWithValue("@CuentaDepreciacionAcumuladaID", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@CuentaDepreciacionAcumuladaID", Convert.ToInt32(grdCuentaDepreciacion.EditValue));
                        if (Convert.ToInt32(grdCuentaGasto.EditValue) == 0)
                            cmd.Parameters.AddWithValue("@CuentaGastoDepreciacionID", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@CuentaGastoDepreciacionID", Convert.ToInt32(grdCuentaGasto.EditValue));
                        cmd.Parameters.AddWithValue("@Estado",comboEstados.Text);
                        IdActivoFijo = Convert.ToInt32(cmd.ExecuteScalar());

                        transaction.Commit();
                        Guardar = true;


                    }
                    catch (Exception ec)
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ec.Message);
                        Guardar = false;
                    }
                    break;
                case Operacion.Modificar:

                    try
                    {
                        cmd.CommandText = "sp_update_activos_fijos";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ActivoID", IdActivoFijo);
                        cmd.Parameters.AddWithValue("@NombreActivo", txtDescripcion.Text.Trim());
                        cmd.Parameters.AddWithValue("@FechaCompra", dtfCompra.DateTime);
                        cmd.Parameters.AddWithValue("@ValorCompra", Convert.ToDecimal(txtValorCompra.EditValue));
                        cmd.Parameters.AddWithValue("@VidaUtilMeses", Convert.ToDecimal(txtVidaUtil.EditValue));
                        cmd.Parameters.AddWithValue("@ValorResidual", Convert.ToDecimal(txtValorResidual.EditValue));
                        if (Convert.ToInt32(grdCuentaContable.EditValue) == 0)
                            cmd.Parameters.AddWithValue("@CuentaContableActivoID", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@CuentaContableActivoID", Convert.ToInt32(grdCuentaContable.EditValue));
                        if (Convert.ToInt32(grdCuentaDepreciacion.EditValue) == 0)
                            cmd.Parameters.AddWithValue("@CuentaDepreciacionAcumuladaID", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@CuentaDepreciacionAcumuladaID", Convert.ToInt32(grdCuentaDepreciacion.EditValue));
                        if (Convert.ToInt32(grdCuentaGasto.EditValue) == 0)
                            cmd.Parameters.AddWithValue("@CuentaGastoDepreciacionID", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@CuentaGastoDepreciacionID", Convert.ToInt32(grdCuentaGasto.EditValue));
                        cmd.Parameters.AddWithValue("@Estado", comboEstados.Text);
                        cmd.ExecuteNonQuery();
                        transaction.Commit();

                    }
                    catch (Exception ec)
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ec.Message);
                        Guardar = false;
                    }
                    break;
                case Operacion.Consultar:
                    break;
                default:
                    break;
            }

            if (Guardar)
            {
                af1.ActivoId = IdActivoFijo;
                af1.CodigoActivo = txtCodigo.Text.ToString();
                af1.NombreActivo = txtDescripcion.Text.Trim();
                af1.FechaCompra = dtfCompra.DateTime;
                af1.ValorCompra = Convert.ToDecimal(txtValorCompra.EditValue);
                af1.VidaUtilMeses = Convert.ToInt32(txtVidaUtil.EditValue);
                af1.ValorResidual = Convert.ToDecimal(txtValorResidual.EditValue);
                af1.CuentaContableActivoID = Convert.ToInt32(grdCuentaContable.EditValue);
                af1.CuentaContableActivoName = grdCuentaContable.Text;
                af1.CuentaDepreciacionAcumuladaID = Convert.ToInt32(grdCuentaDepreciacion.EditValue);
                af1.CuentaDepreciacionAcumuladaName = grdCuentaDepreciacion.Text;
                af1.CuentaGastoDepreciacionID = Convert.ToInt32(grdCuentaGasto.EditValue);
                af1.CuentaGastoDepreciacionName = grdCuentaGasto.Text;
                af1.Estado = comboEstados.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
    }
}