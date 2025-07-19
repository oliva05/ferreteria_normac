using ACS.Classes;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Import.Html;
using DevExpress.XtraSpreadsheet.Import.Xls;
using DocumentFormat.OpenXml.Office.CoverPageProps;
using DocumentFormat.OpenXml.Office2010.CustomUI;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Facturacion.Reportes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO.Facturacion.CoreFacturas
{
    public partial class frmPagoFactura : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        public ArrayList ListaDetallePago;
        public enum TipoPago
        {
            Efectivo = 1,
            Tarjeta = 2,
            DepositoBancario = 3,
            Cheque = 4
        }

        public TipoPago TipoPagoSeleccionadoActual;
        public decimal ValorA_Pagar;
        public decimal varPago;

        //Saldo total al combinar pagos.
        decimal Saldo;

        //Suma total de la combinacion de pagos
        decimal SumaTotal;

        public int IdFormato;
        public string PrinterName;
        public string ReferenciaReciboPago;
        public string NumeroCheque;
        public int BancoId;
        public string BancoName;
        public string NombreEmisorCheque;

        PDV PuntoVentaActual;

        public frmPagoFactura(UserLogin pUsuarioLogeado, decimal pValorA_Pagar, PDV pPuntoVentaActual, decimal pSubTotal, decimal pImpuesto)
        {
            InitializeComponent();
            dp = new DataOperations();
            PuntoVentaActual = pPuntoVentaActual;

            this.UsuarioLogeado = pUsuarioLogeado;
            ValorA_Pagar = pValorA_Pagar;
            lblTotalPagoRequerido.Text = string.Format("{0: L #,###,##0.00}", pValorA_Pagar);
            lblSubTotal.Text = string.Format("{0: L #,###,##0.00}", pSubTotal);
            lblImpuesto.Text = string.Format("{0: L #,###,##0.00}", pImpuesto);
            //spinEdit2.EditValue = pValorA_Pagar;
            txtValorPagarChque.Text = txtValorEfectivo.Text = txtValorTC.Text = txtValorPagarTransferencia.Text = string.Format("{0:###,##0.00}", pValorA_Pagar);

            TipoPagoSeleccionadoActual = TipoPago.Efectivo;
            SetButtonPago();
            
            SetRadioButtonFormatt();
            GetPrintersNames();
            GetBancosTodos();
            GetBancosDeposito();
            radioGroup1.EditValue = 1;
            radioGroup2.EditValue = 1;
            radioGroup3.EditValue = 1;
            radioGroup4.EditValue = 1;
            txtEntregado.Focus();
        }

        private void GetBancosTodos()
        {
            //sp_get_lista_bancos_finanzas
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_lista_bancos_finanzas]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);
                //cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                //cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsRegistroPagos1.bancos_list.Clear();
                //dsRegistroPagos1.bancos_listDeposito.Clear();
                adat.Fill(dsRegistroPagos1.bancos_list);
                //adat.Fill(dsRegistroPagos1.bancos_listDeposito);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void GetBancosDeposito()
        {
            //sp_get_lista_bancos_finanzas
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_lista_bancos_finanzas_normac]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);
                //cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                //cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsRegistroPagos1.bancos_listDeposito.Clear();
                adat.Fill(dsRegistroPagos1.bancos_listDeposito);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
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

                SqlCommand cmd = new SqlCommand("[dbo].[sp_finanzas_get_cuentas_by_titular_y_banco]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);
                cmd.Parameters.AddWithValue("@IdTitular", 1);//NORMAC=1
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

        private void SetRadioButtonFormatt()
        {
            switch (PuntoVentaActual.IdFormatoFactura)
            {
                case 1:
                    radioGroup1.EditValue = 1;
                    radioGroup2.EditValue = 1;
                    radioGroup3.EditValue = 1;
                    radioGroup4.EditValue = 1;
                    radioGroup1.ReadOnly = true;
                    radioGroup2.ReadOnly = true;
                    radioGroup3.ReadOnly = true;
                    radioGroup4.ReadOnly = true;
                    break;
                case 2:
                    radioGroup1.EditValue = 2;
                    radioGroup2.EditValue = 2;
                    radioGroup3.EditValue = 2;
                    radioGroup4.EditValue= 2;
                    radioGroup1.ReadOnly = true;
                    radioGroup2.ReadOnly = true;
                    radioGroup3.ReadOnly = true;
                    radioGroup4.ReadOnly = true;
                    break;
            }
            
        }

        private void GetPrintersNames()
        {
            //PrintersConfig conf = new PrintersConfig(PsConnection);
            //int id = conf.getIdPrinterDefault();
            //if (id > 0)
            //{
            //    radioGroup1.EditValue = id;
            //}

            //if (PuntoVentaActual.Recuperado)
            //{

            ListboxPrintersEfectivo.Items.Clear();
            foreach (string printname in PrinterSettings.InstalledPrinters)
            {
                //Console.WriteLine(printname);

                //if (conf.Key == printname)
                //{
                //    ListboxPrinters.Items.Add(printname, true);
                //}
                //else
                //{
                //    ListboxPrinters.Items.Add(printname, false);
                //}
                ListboxPrintersEfectivo.Items.Add(printname, false);
            }

            ListboxPrintersTransferencia.Items.Clear();
            foreach (string printname in PrinterSettings.InstalledPrinters)
            {
                //Console.WriteLine(printname);

                //if (conf.Key == printname)
                //{
                //    ListboxPrinters.Items.Add(printname, true);
                //}
                //else
                //{
                //    ListboxPrinters.Items.Add(printname, false);
                //}
                ListboxPrintersTransferencia.Items.Add(printname, false);
            }

            ListboxPrintersTarjeta.Items.Clear();
            foreach (string printname in PrinterSettings.InstalledPrinters)
            {
                //Console.WriteLine(printname);

                //if (conf.Key == printname)
                //{
                //    ListboxPrinters.Items.Add(printname, true);
                //}
                //else
                //{
                //    ListboxPrinters.Items.Add(printname, false);
                //}
                ListboxPrintersTarjeta.Items.Add(printname, false);
            }


            ListBoxCheque.Items.Clear();
            foreach (string printname in PrinterSettings.InstalledPrinters)
            {
                //Console.WriteLine(printname);

                //if (conf.Key == printname)
                //{
                //    ListboxPrinters.Items.Add(printname, true);
                //}
                //else
                //{
                //    ListboxPrinters.Items.Add(printname, false);
                //}
                ListBoxCheque.Items.Add(printname, false);
            }


        }

        private void SetButtonPago()
        {
            switch(this.TipoPagoSeleccionadoActual)
            {
                case TipoPago.Efectivo: //1
                    cmdEfectivo.Appearance.BackColor = Color.LightSkyBlue;
                    cmdTarjeta.Appearance.BackColor =
                    cmdCheque.Appearance.BackColor =
                    cmdDepositoBancario.Appearance.BackColor = Color.White;
                    tabPageEfectivo.PageVisible = true;
                    tabPageTarjeta.PageVisible = 
                    tabPageTransferenciaCliente.PageVisible =
                    tabPageCheques.PageVisible = false;
                    break;
                case TipoPago.Tarjeta: //2
                    cmdEfectivo.Appearance.BackColor =
                    cmdCheque.Appearance.BackColor = Color.White;
                    cmdTarjeta.Appearance.BackColor = Color.LightSkyBlue;
                    cmdDepositoBancario.Appearance.BackColor = Color.White;
                    tabPageEfectivo.PageVisible = false;
                    tabPageTarjeta.PageVisible = true;
                    tabPageTransferenciaCliente.PageVisible =
                    tabPageCheques.PageVisible = false;
                    break;
                case TipoPago.DepositoBancario: //3
                    cmdEfectivo.Appearance.BackColor =
                    cmdCheque.Appearance.BackColor = 
                    cmdTarjeta.Appearance.BackColor = Color.White;
                    cmdDepositoBancario.Appearance.BackColor = Color.LightSkyBlue;
                    tabPageEfectivo.PageVisible = 
                    tabPageTarjeta.PageVisible =
                    tabPageCheques.PageVisible = false;
                    tabPageTransferenciaCliente.PageVisible = true;
                    break;
                case TipoPago.Cheque: //4
                    cmdEfectivo.Appearance.BackColor = 
                    cmdTarjeta.Appearance.BackColor = cmdDepositoBancario.Appearance.BackColor = Color.White;
                    cmdCheque.Appearance.BackColor = Color.LightSkyBlue;
                    tabPageEfectivo.PageVisible =
                    tabPageTarjeta.PageVisible = 
                    tabPageTransferenciaCliente.PageVisible = false;
                    tabPageCheques.PageVisible = true;
                    break;
            }
        }

        private void cmdEfectivo_Click(object sender, EventArgs e)
        {
            tabPagos.SelectedTabPage = tabPageEfectivo;
            TipoPagoSeleccionadoActual = TipoPago.Efectivo;
            SetButtonPago();
            txtEntregado.Focus();
        }

        private void cmdTarjeta_Click(object sender, EventArgs e)
        {
            tabPagos.SelectedTabPage = tabPageTarjeta;
            TipoPagoSeleccionadoActual = TipoPago.Tarjeta;
            SetButtonPago();
        }

        private void cmdDepositoBancario_Click(object sender, EventArgs e)
        {
            tabPagos.SelectedTabPage = tabPageTransferenciaCliente;
            TipoPagoSeleccionadoActual = TipoPago.DepositoBancario;
            SetButtonPago();
        }
        void calcularCambio()
        {
            if (!string.IsNullOrEmpty(txtEntregado.Text))
            {
                try
                {
                    varPago = Convert.ToDecimal(txtEntregado.Text);
                }
                catch
                {
                    CajaDialogo.Error("Debe ingresar un valor Decimal Valido!");
                    return;
                }

                decimal cambio = varPago - ValorA_Pagar;
                if(cambio < 0) 
                    cambio = 0;

                txtCambio.Text = string.Format("{0:###,##0.00}", cambio);
            }
        }

        private void txtEntregado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcularCambio();
                //cmdPagar.Focus();
                cmdPagar_Click(sender, new EventArgs());
            }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdFormato = Convert.ToInt32(radioGroup1.EditValue);
        }

        private void cmdPagar_Click(object sender, EventArgs e)
        {
            calcularCambio();


            //if (ValorA_Pagar > varPago)
            //{
            //    CajaDialogo.Error("No se puede realizar la transaccion, el valor entregado debe ser mayor o igual al de la factura.");
            //    return;
            //}

            varPago = (dp.ValidateNumberDecimal(txtEntregado.Text) - dp.ValidateNumberDecimal(txtCambio.Text));

            if (string.IsNullOrEmpty(PrinterName))
            {
                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListboxPrintersEfectivo.Items)
                {
                    if (item.CheckState == CheckState.Checked)
                        PrinterName = item.Value.ToString();
                }
            }
            

            if (IdFormato == 0)
            {
                IdFormato = Convert.ToInt32(radioGroup1.EditValue);
            }

            AgregarPago(1, "Efectivo", varPago,"N/D",0,"N/D", "N/D",0,"N/D");

            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void AgregarPago(int IdPago, string NombrePago, decimal vValor, string pReferencia, int pIdBanco, string pNumeroCheque, string pEmisorCheque, int pIdCuenta, string pNumeroCuenta)
        {
            Saldo = 0;
            int ExistePreviamente = 0;
            SumaTotal = 0;
            foreach(dsRegistroPagos.resumen_pagoRow row in dsRegistroPagos1.resumen_pago)
            {
                if (row.id == IdPago)
                {
                    ExistePreviamente++;
                    break;
                }
            }

            if (ExistePreviamente <= 0)
            {
                //Agregamos un nuevo Row
                dsRegistroPagos.resumen_pagoRow row1 = dsRegistroPagos1.resumen_pago.Newresumen_pagoRow();
                row1.id = IdPago;
                row1.descripcion = NombrePago;
                row1.valor = vValor;
                row1.tipo_id = IdPago;
                row1.referencia = pReferencia;
                row1.id_banco = pIdBanco;
                row1.numero_cheque = NumeroCheque;
                row1.emisor_cheque = pEmisorCheque;
                row1.id_cuenta = pIdCuenta;
                row1.CuentaBanco = pNumeroCuenta;

                dsRegistroPagos1.resumen_pago.Addresumen_pagoRow(row1);
                dsRegistroPagos1.AcceptChanges();
            }
            else
            {
                //Actualizamos el row existente
                foreach (dsRegistroPagos.resumen_pagoRow row in dsRegistroPagos1.resumen_pago)
                {
                    if (row.id == IdPago)
                        row.valor = vValor;

                    //if (row.id == 3)//Deposito Bancario
                    row.referencia = pReferencia;
                    row.id_banco = pIdBanco;
                    row.numero_cheque = NumeroCheque;
                    row.emisor_cheque = pEmisorCheque;
                    row.id_cuenta = pIdCuenta;
                    row.CuentaBanco = pNumeroCuenta;
                    //SumaTotal += vValor;
                }

                //lblResumenPagosTotal.Text = string.Format("{0:###,##0.00}", SumaTotal);
            }

            foreach (dsRegistroPagos.resumen_pagoRow row in dsRegistroPagos1.resumen_pago)
            {
                SumaTotal += row.valor;
            }

            Saldo = ValorA_Pagar - SumaTotal;
            lblSaldo.Text = string.Format("{0:L #,###,##0.00}", Saldo); 

            if (Saldo == 0)
            {
                //Verde
                lblSaldo.ForeColor = Color.LightGreen;
            }
            else
            {
                //Rojo
                lblSaldo.ForeColor = Color.LightCoral;
            }

            lblResumenPagosTotal.Text = string.Format("{0:L #,###,##0.00}", SumaTotal);
        }


        private void ListboxPrinters_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListboxPrintersEfectivo.Items)
            {
                if (item.CheckState == CheckState.Checked)
                    PrinterName = item.Value.ToString();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcularCambioTC();
                cmdPagar.Focus();
            }
        }

        private void calcularCambioTC()
        {
            if (!string.IsNullOrEmpty(txtEntregadoTC.Text))
            {
                try
                {
                    varPago = Convert.ToDecimal(txtEntregadoTC.Text);
                }
                catch
                {
                    CajaDialogo.Error("Debe ingresar un valor Decimal Valido!");
                    return;
                }
                decimal cambio = varPago - ValorA_Pagar;
                //txtCambio.Text = string.Format("{0:###,##0.00}", cambio);
            }
        }

        private void radioGroup2_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdFormato = Convert.ToInt32(radioGroup2.EditValue);
        }

        private void checkedListBoxControl1_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListboxPrintersEfectivo.Items)
            {
                if (item.CheckState == CheckState.Checked)
                    PrinterName = item.Value.ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            calcularCambioTC();
            varPago = dp.ValidateNumberDecimal(txtEntregadoTC.Text);

            //if (ValorA_Pagar > varPago)
            //{
            //    CajaDialogo.Error("No se puede realizar la transaccion, el valor entregado debe ser mayor o igual al de la factura.");
            //    return;
            //}

            if (string.IsNullOrEmpty(PrinterName))
            {
                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListboxPrintersEfectivo.Items)
                {
                    if (item.CheckState == CheckState.Checked)
                        PrinterName = item.Value.ToString();
                }
            }

            if (IdFormato == 0)
            {
                IdFormato = Convert.ToInt32(radioGroup1.EditValue);
            }

            AgregarPago(2, "Tarjeta", varPago, "N/D", 0, "N/D", "N/D", 0, "N/D");
            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            //varPago = spinEdit1.Value;
        }

        private void radioGroup3_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdFormato = Convert.ToInt32(radioGroup3.EditValue);
        }

        private void checkedListBoxControl2_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListboxPrintersEfectivo.Items)
            {
                if (item.CheckState == CheckState.Checked)
                    PrinterName = item.Value.ToString();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            varPago = dp.ValidateNumberDecimal(txtValorTransferencia.Text);
            //if (ValorA_Pagar > varPago)
            //{
            //    CajaDialogo.Error("No se puede realizar la transaccion, el valor transferido debe ser mayor o igual al de la factura.");
            //    return;
            //}
            if (string.IsNullOrEmpty(PrinterName))
            {
                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListboxPrintersEfectivo.Items)
                {
                    if (item.CheckState == CheckState.Checked)
                        PrinterName = item.Value.ToString();
                }
            }

            if (!string.IsNullOrEmpty(txtReferencia.Text))
            {
                ReferenciaReciboPago = txtReferencia.Text;
            }
            else
            {
                ReferenciaReciboPago = "N/D";
            }

            int pIdCuenta;
            if (string.IsNullOrEmpty(gleCuentaBanco.Text))
            {
                CajaDialogo.Error("Es necesario indicar la cuenta a la que se efectuo el deposito!");
                return;
            }
            else
            {
                pIdCuenta = dp.ValidateNumberInt32(gleCuentaBanco.EditValue);

            }

            if (IdFormato == 0)
            {
                IdFormato = Convert.ToInt32(radioGroup1.EditValue);
            }
            AgregarPago(3, "Deposito Bancario", varPago, ReferenciaReciboPago, dp.ValidateNumberInt32(gleBancoDeposito.EditValue), 
                        "N/D", "N/D", pIdCuenta, gleCuentaBanco.Text);
            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void txtEntregado_TextChanged(object sender, EventArgs e)
        {
            //calcularCambio();
            //cmdPagar.Focus();
        }

        private void txtEntregado_Validated(object sender, EventArgs e)
        {
            calcularCambio();
            cmdPagar.Focus();
        }

        private void txtEntregadoTC_Validated(object sender, EventArgs e)
        {
            calcularCambioTC();
            cmdPagar.Focus();
        }

        private void txtEntregado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtEntregadoTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtReferencia_Validated(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtReferencia.Text)) 
            {
                ReferenciaReciboPago = txtReferencia.Text;
            }
        }

        private void spinEdit1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            //varPago = spinEdit1.Value;
        }

        private void txtEntregado_TextChanged_1(object sender, EventArgs e)
        {
            calcularCambio();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if(SumaTotal<=0)
            {
                CajaDialogo.Error("Es necesario ingresar un pago mayor a cero (0) para continuar...");
                return;
            }

            if(ListaDetallePago == null)
                ListaDetallePago = new ArrayList();

            
            foreach (dsRegistroPagos.resumen_pagoRow row in dsRegistroPagos1.resumen_pago)
            {
                RegistroPago PagoParcial = new RegistroPago();
                PagoParcial.Id = row.id;

                if (row.id == 3)//Deposito bancario
                {
                    PagoParcial.Referencia = row.referencia;
                    PagoParcial.id_banco = row.id_banco;
                    PagoParcial.id_cuenta = row.id_cuenta;
                    PagoParcial.CuentaBanco = row.CuentaBanco;
                }
                else
                {
                    PagoParcial.id_cuenta = 0;
                    PagoParcial.Referencia = 
                    PagoParcial.CuentaBanco = "N/D";
                }

                if (row.id == 4)//Cheque
                {
                    //PagoParcial.Referencia = row.referencia;
                    PagoParcial.id_banco = row.id_banco;
                    PagoParcial.EmisorCheque = row.emisor_cheque;
                    PagoParcial.NumeroCheque = row.numero_cheque;
                    PagoParcial.CuentaBanco = "N/D";
                }
                else
                {
                    PagoParcial.Referencia = "N/D";
                    PagoParcial.EmisorCheque = "N/D";
                    PagoParcial.CuentaBanco =
                    PagoParcial.NumeroCheque = "N/D";
                }

                PagoParcial.IdTipo = row.tipo_id;

                PagoParcial.Description = row.descripcion;
                PagoParcial.Valor = row.valor;

                ListaDetallePago.Add(PagoParcial);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdCheque_Click(object sender, EventArgs e)
        {
            tabPagos.SelectedTabPage = tabPageCheques;
            TipoPagoSeleccionadoActual = TipoPago.Cheque;
            SetButtonPago();
            cmdValorCheque.Focus();
        }

        private void cmdAgregarPagoCheque_Click(object sender, EventArgs e)
        {
            varPago = dp.ValidateNumberDecimal(cmdValorCheque.Value);
            //if (ValorA_Pagar > varPago)
            //{
            //    CajaDialogo.Error("No se puede realizar la transaccion, el valor transferido debe ser mayor o igual al de la factura.");
            //    return;
            //}
            if (string.IsNullOrEmpty(PrinterName))
            {
                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListBoxCheque.Items)
                {
                    if (item.CheckState == CheckState.Checked)
                        PrinterName = item.Value.ToString();
                }
            }

            if (!string.IsNullOrEmpty(txtNumeroCheque.Text))
            {
                NumeroCheque = txtNumeroCheque.Text;
            }
            else
            {
                //NumeroCheque = "N/D";
                CajaDialogo.Error("Ingrese el numero del cheque!");
                return;
            }

            if (!string.IsNullOrEmpty(txtNombreEmisorCheque.Text))
            {
                NombreEmisorCheque = txtNombreEmisorCheque.Text;
            }
            else
            {
                //NombreEmisorCheque = "N/D";
                CajaDialogo.Error("Ingrese el nombre del emisor del cheque!");
                return;
            }

            if (!string.IsNullOrEmpty(gleBancosList.Text))
            {
                BancoId = dp.ValidateNumberInt32(gleBancosList.EditValue);
            }
            else
            {
                CajaDialogo.Error("Ingrese el nombre del banco emisor del cheque!");
                return;
            }



            if (IdFormato == 0)
            {
                IdFormato = Convert.ToInt32(radioGroup1.EditValue);
            }
            AgregarPago(4, "Cheque", varPago, ReferenciaReciboPago,dp.ValidateNumberInt32(gleBancosList.EditValue),NumeroCheque, NombreEmisorCheque,0,"N/D");
            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtValorTransferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtValorTransferencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtReferencia.Focus();
            }
        }

        private void txtReferencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                gleBancoDeposito.Focus();
            }
        }

        private void gleBancoDeposito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gleCuentaBanco.Focus();
            }
        }

        private void gleCuentaBanco_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                simpleButton2_Click(sender, new EventArgs());
            }
        }

        private void gleBancoDeposito_EditValueChanged(object sender, EventArgs e)
        {
            if (gleBancoDeposito != null) 
            {
                int idBanco = dp.ValidateNumberInt32(gleBancoDeposito.EditValue);
                if (idBanco > 0)
                {
                    GetCuentasBancos(idBanco);
                }
            }

        }

        private void txtValorTransferencia_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValorTransferencia.Text))
                varPago = dp.ValidateNumberDecimal(txtValorTransferencia.Text);
        }

        private void tabPageTransferenciaCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdValorCheque_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                gleBancosList.Focus();
            }
        }

        private void gleBancosList_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gleBancosList.Text))
            {
                txtNumeroCheque.Focus();
            }
        }

        private void txtNumeroCheque_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtNombreEmisorCheque.Focus();
            }
        }
    }
}