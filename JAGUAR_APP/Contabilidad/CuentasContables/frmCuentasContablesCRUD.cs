using ACS.Classes;
using DevExpress.Export;
using DevExpress.Spreadsheet;
using DevExpress.XtraEditors;
using DocumentFormat.OpenXml.Spreadsheet;
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

namespace JAGUAR_PRO.Contabilidad.CuentasContables
{
    public partial class frmCuentasContablesCRUD : DevExpress.XtraEditors.XtraForm
    {
        public enum Operacion
        {
            Nuevo = 1,
            Modificar = 2,
            Consultar = 3
        }
        UserLogin UsuarioLogeado;
        int IdCuenta = 0;
        Clases.CuentasContables cc = new Clases.CuentasContables();
        Operacion OperacionActual;
        public frmCuentasContablesCRUD(frmCuentasContablesCRUD.Operacion operacion, UserLogin userLogin, int Pidcuenta)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
            IdCuenta = Pidcuenta;
            OperacionActual = operacion;
            CrearDataTipoCuenta();
            switch (OperacionActual)
            {
                case Operacion.Nuevo:
                    tsActivo.IsOn = true;
                    tsActivo.Enabled = false;
                    break;
                case Operacion.Modificar:
                    cc.RecuperarRegistros(IdCuenta);
                    txtCodigoCuenta.Text = cc.CodigoCuenta;
                    txtDescripcion.Text = cc.NombreCuenta;
                    grdTipoCuenta.EditValue = cc.TipoCuenta.ToString();
                    grdCuentaPadre.EditValue = cc.CuentaPadreID;
                    tsMovimiento.IsOn = cc.EsMovimiento;
                    tsActivo.IsOn = cc.Enable.HasValue ? cc.Enable.Value : false;
                    LoadCuentas();

                    break;
                case Operacion.Consultar:
                    cc.RecuperarRegistros(IdCuenta);
                    txtCodigoCuenta.Text = cc.CodigoCuenta;
                    txtDescripcion.Text = cc.NombreCuenta;
                    grdTipoCuenta.EditValue = cc.TipoCuenta.ToString();
                    grdCuentaPadre.EditValue = cc.CuentaPadreID;
                    tsMovimiento.IsOn = cc.EsMovimiento;
                    tsActivo.IsOn = cc.Enable.HasValue ? cc.Enable.Value : false;
                    LoadCuentas();
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
                SqlCommand cmd = new SqlCommand("[sp_get_account_enable]", conn);
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

        private void CrearDataTipoCuenta()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));

            dt.Rows.Add("A", "Activo");
            dt.Rows.Add("P", "Pasivo");
            dt.Rows.Add("C", "Capital");
            dt.Rows.Add("I", "Inactivo");
            dt.Rows.Add("G", "Gasto");

            dsCuentasC1.tipo_cuenta.Clear();

            foreach (DataRow row in dt.Rows)
            {
                var nuevaFila = dsCuentasC1.tipo_cuenta.Newtipo_cuentaRow();
                nuevaFila.Codigo = row["Codigo"].ToString();
                nuevaFila.Descripcion = row["Descripcion"].ToString();
                dsCuentasC1.tipo_cuenta.Addtipo_cuentaRow(nuevaFila);
            }

            dsCuentasC1.tipo_cuenta.AcceptChanges();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoCuenta.Text))
            {
                CajaDialogo.Error(Name + " - El campo Codigo Cuenta es obligatorio.");
                return;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                CajaDialogo.Error(Name + " - El campo Nombre Cuenta es obligatorio.");
                return;
            }

            if (string.IsNullOrEmpty(grdTipoCuenta.Text))
            {
                CajaDialogo.Error(Name + " - El campo Nombre Cuenta es obligatorio.");
                return;
            }

            DataOperations dp = new DataOperations();
            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            bool Guardar = false;
            conn.Open();
            transaction = conn.BeginTransaction("Transaction Order");
            SqlCommand cmd = conn.CreateCommand();

            switch (OperacionActual)
            {
                case Operacion.Nuevo:
                    
                    try
                    {
                        cmd.CommandText = "sp_cuentas_contables_insert";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CodigoCuenta",txtCodigoCuenta.Text.Trim());
                        cmd.Parameters.AddWithValue("@NombreCuenta",txtDescripcion.Text.Trim());
                        cmd.Parameters.AddWithValue("@TipoCuenta",grdTipoCuenta.EditValue.ToString());
                        cmd.Parameters.AddWithValue("@EsMovimiento",Convert.ToBoolean(tsMovimiento.IsOn));
                        cmd.Parameters.AddWithValue("@CuentaPadreID", grdCuentaPadre.EditValue == null ? (object)DBNull.Value : Convert.ToInt32(grdCuentaPadre.EditValue));
                        cmd.Parameters.AddWithValue("@IdUserCreacion", UsuarioLogeado.Id);
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
                    break;
                case Operacion.Modificar:
                    try
                    {
                        cmd.CommandText = "sp_cuentas_contables_update";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CodigoCuenta", txtCodigoCuenta.Text.Trim());
                        cmd.Parameters.AddWithValue("@NombreCuenta", txtDescripcion.Text.Trim());
                        cmd.Parameters.AddWithValue("@TipoCuenta", grdTipoCuenta.EditValue.ToString());
                        cmd.Parameters.AddWithValue("@EsMovimiento", Convert.ToBoolean(tsMovimiento.IsOn));
                        cmd.Parameters.AddWithValue("@CuentaPadreID", grdCuentaPadre.EditValue == null ? (object)DBNull.Value : Convert.ToInt32(grdCuentaPadre.EditValue));
                        cmd.Parameters.AddWithValue("@CuentaID", IdCuenta);
                        cmd.Parameters.AddWithValue("@Enable", Convert.ToBoolean(tsActivo.IsOn));
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
                    break;
                case Operacion.Consultar:
                    break;
                default:
                    break;
            }


        }
    }
}