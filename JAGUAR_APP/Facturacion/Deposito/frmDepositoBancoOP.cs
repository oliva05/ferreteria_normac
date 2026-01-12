using ACS.Classes;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DocumentFormat.OpenXml.Wordprocessing;
using JAGUAR_PRO.Accesos.AccesosUsuarios;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Facturacion.CoreFacturas;
using JAGUAR_PRO.Facturacion.Reportes;
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

namespace JAGUAR_PRO.Facturacion.Deposito
{
    public partial class frmDepositoBancoOP : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp;
        public int IdFormato = 0;
        public enum TipoOperacion
        {
            Nuevo = 1,
            Editar = 2
        }
        UserLogin UsuarioLogeado;
        PDV PuntoVenta;
        TipoOperacion Operacion;
        DepositoBanco DepositoActual;
       
        public frmDepositoBancoOP(frmDepositoBancoOP.TipoOperacion pOperacion, 
                                  UserLogin userLogin, PDV ppdv, int pIdDeposito, 
                                  bool pCanChangeDate, bool pCanEditDocument)
        {
            InitializeComponent();
            dp = new DataOperations();
            DepositoActual = new DepositoBanco();
            UsuarioLogeado = userLogin;
            PuntoVenta = ppdv;
            Operacion = pOperacion;
            GetBancos();
            
            //txtValorEnCaja.EditValue = 0.00;//
            if (Operacion == TipoOperacion.Nuevo)
            {
                this.Text = lblTituloVentana.Text = "Generar un nuevo depósito";
                dtFechaDeposito.DateTime = dp.Now();

                if (!pCanChangeDate)
                {
                    dtFechaDeposito.ReadOnly = true;
                }
            }
            else if (Operacion == TipoOperacion.Editar)
            {
                if (DepositoActual.RecuperarRegistros(pIdDeposito)) 
                {
                    gleBancoDeposito.EditValue = DepositoActual.IdBanco;
                    gleCuentaBanco.EditValue = DepositoActual.IdCuenta;
                    txtValorTransferencia.Text = string.Format("{0:###,##0.00}", DepositoActual.Total);
                    txtReferencia.Text = DepositoActual.NumTransaccion;
                    lblNumeroDeposito.Text = DepositoActual.DepositoN;
                    txtComentario.Text = DepositoActual.Obs;
                    lblEnable.Visible = tggEnable.Visible = true;
                    tggEnable.IsOn = DepositoActual.Enable;
                    dtFechaDeposito.DateTime = DepositoActual.Fecha;
                    this.Text = lblTituloVentana.Text = "Modificación del depósito";
                    cmdGuardarGenerar.Text = "Guardar";
                }
            }
        }

        private decimal GetSaldoEnCaja() 
        {
            decimal saldo = 0;

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_saldo_caja", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_punto_venta", PuntoVenta.ID);
                //cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.ID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    saldo = reader.GetDecimal(0);
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }


            return saldo;
        }

        private void GetBancos()
        {
            //sp_get_lista_bancos_finanzas
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_lista_bancos_finanzas_with_account]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);
                //cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                //cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsRegistroPagos1.bancos_list.Clear();
                adat.Fill(dsRegistroPagos1.bancos_list);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gleBancoDeposito.Text))
            {
                CajaDialogo.Error("Debe seleccionar un banco para el depósito.");
                gleBancoDeposito.Focus();
                return;
            }

            //if ((decimal)txtValorTransferencia.EditValue > (decimal)txtValorEnCaja.EditValue)
            //{
            //    CajaDialogo.Error("El valor del depósito no puede ser mayor al saldo en caja.");
            //    return;
            //}

            if (string.IsNullOrEmpty(txtValorTransferencia.Text))
            {
                CajaDialogo.Error("Debe indicar un valor para el depósito.");
                txtValorTransferencia.Focus();
                return;
            }


            if (string.IsNullOrEmpty(dtFechaDeposito.Text))
            {
                CajaDialogo.Error("Debe indicar una fecha para el depósito.");
                dtFechaDeposito.Focus();
                return;
            }

            if (IdFormato == 0)
            {
                IdFormato = Convert.ToInt32(radioGroup1.EditValue);
            }

            SqlTransaction transaction = null;

            SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            bool Guardar = false;

            int IdInserted = 0;
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction("Transaction Order");

                SqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;

                switch (Operacion)
                {
                    case TipoOperacion.Nuevo:
                        cmd.CommandText = "[dbo].[sp_facturacion_deposito_insert_v2]";
                        cmd.Parameters.AddWithValue("@num_transaccion", txtReferencia.Text.Trim());
                        cmd.Parameters.AddWithValue("@fecha", dp.Now());
                        cmd.Parameters.AddWithValue("@id_banco", gleBancoDeposito.EditValue);
                        cmd.Parameters.AddWithValue("@cuenta_banco", gleCuentaBanco.Text.Trim());
                        cmd.Parameters.AddWithValue("@total", txtValorTransferencia.EditValue);
                        
                        if (string.IsNullOrEmpty(txtComentario.Text))
                            cmd.Parameters.AddWithValue("@obs", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@obs", txtComentario.Text);

                        cmd.Parameters.AddWithValue("@created_user_id", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@created_date", dp.Now());
                        cmd.Parameters.AddWithValue("@puntoVentaId", PuntoVenta.ID);
                        cmd.Parameters.AddWithValue("@id_cuenta", gleCuentaBanco.EditValue);


                        IdInserted = Convert.ToInt32(cmd.ExecuteScalar());
                        break;
                    case TipoOperacion.Editar:
                        cmd.CommandText = "[dbo].[sp_facturacion_deposito_update]";
                        cmd.Parameters.AddWithValue("@id", this.DepositoActual.Id);
                        cmd.Parameters.AddWithValue("@num_transaccion", txtReferencia.Text.Trim());
                        cmd.Parameters.AddWithValue("@fecha", dtFechaDeposito.DateTime);
                        cmd.Parameters.AddWithValue("@enable", tggEnable.IsOn);
                        cmd.Parameters.AddWithValue("@id_banco", gleBancoDeposito.EditValue);
                        cmd.Parameters.AddWithValue("@cuenta_banco", gleCuentaBanco.Text.Trim());
                        decimal total_ = dp.ValidateNumberDecimal(txtValorTransferencia.EditValue);
                        cmd.Parameters.AddWithValue("@total", total_);

                        if (string.IsNullOrEmpty(txtComentario.Text))
                            cmd.Parameters.AddWithValue("@obs", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@obs", txtComentario.Text);

                        cmd.Parameters.AddWithValue("@modified_user_id", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@modified_date", dp.Now());
                        //cmd.Parameters.AddWithValue("@puntoVentaId", PuntoVenta.ID);
                        cmd.Parameters.AddWithValue("@id_cuenta", gleCuentaBanco.EditValue);
                        cmd.ExecuteNonQuery();
                        IdInserted = DepositoActual.Id;
                        break;
                }
                
                

                transaction.Commit();
                Guardar = true;
            }
            catch (Exception ec)
            {
                transaction.Rollback();
                CajaDialogo.Error(ec.Message);
                Guardar = false;
            }

            if (Guardar)
            {
                //IMPRIMIR
                rptDepositoBancario report = new rptDepositoBancario(IdInserted, PuntoVenta) { ShowPrintMarginsWarning = false };
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(report);
                //printReport.ShowPreviewDialog();
                printReport.Print();
            }
            else
            {
                CajaDialogo.Error("No se pudo guardar el depósito, verifique los datos ingresados.");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gleBancoDeposito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gleCuentaBanco.Focus();
            }
        }

        private void GetCuentasBancos(int pIDBanco)
        {
            //sp_get_lista_bancos_finanzas
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_finanzas_get_cuentas_by_idbanco", con); 
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);
                //cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@id_banco", pIDBanco);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsRegistroPagos1.cuentas.Clear();
                adat.Fill(dsRegistroPagos1.cuentas);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void gleBancoDeposito_EditValueChanged(object sender, EventArgs e)
        {
            if (gleBancoDeposito != null)
            {
                GetCuentasBancos(dp.ValidateNumberInt32(gleBancoDeposito.EditValue));
            }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdFormato = Convert.ToInt32(radioGroup1.EditValue);
        }
    }
}