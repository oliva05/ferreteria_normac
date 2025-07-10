using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace JAGUAR_PRO.Facturacion.Deposito
{
    public partial class rptDepositoBancario : DevExpress.XtraReports.UI.XtraReport
    {
        PDV PuntoVentaActual;
        DepositoBanco DepositoBanco;
        public rptDepositoBancario(int IdDeposito, PDV pdv)
        {
            InitializeComponent();

            PuntoVentaActual = pdv;
            lblNombreComercial.Text = PuntoVentaActual.Nombre;
            lblNombreLega.Text = PuntoVentaActual.NombreLegal;

            DepositoBanco = new DepositoBanco();
            if (DepositoBanco.RecuperarRegistros(IdDeposito))
            {
                lblFechaEmision.Text = string.Format("{0:g}", DepositoBanco.Fecha);
                lblNumDeposito.Text = DepositoBanco.DepositoN;
                lblReferenciaTransaccion.Text = DepositoBanco.NumTransaccion;
                lblBanco.Text = DepositoBanco.Banco;
                lblObs.Text = DepositoBanco.Obs;
                lblUsuario.Text = DepositoBanco.CreadoPor;
                lblTotal.Text = string.Format("Lps {0:###,##0.00}", DepositoBanco.Total);
            }


        }

        private void Detail_BeforePrint(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
