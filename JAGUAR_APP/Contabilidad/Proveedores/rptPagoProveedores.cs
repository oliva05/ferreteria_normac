using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace JAGUAR_PRO.Contabilidad.Proveedores
{
    public partial class rptPagoProveedores : DevExpress.XtraReports.UI.XtraReport
    {
        public rptPagoProveedores(int pIdPago)
        {
            InitializeComponent();

            PDV puntoVentaActual = new PDV();

            PagoProveedores pago = new PagoProveedores();
            if (pago.RecuperarRegistros(pIdPago))
            {
                lblProveedor.Text = pago.NombreProveedor;
                lblFechaEmision.Text = pago.FechaPago.ToString("dd/MM/yyyy");
                lblTotalPagar.Text = string.Format("{0: ###,##0.00}", pago.MontoPago);
                lblMetodoPago.Text = pago.MetodoPago;
                lblObservacion.Text = pago.Observacion;
                lblRTN.Text = pago.Rtn;
                lblNumPago.Text = pago.DocNum;
                lblUsuario.Text = pago.UsuarioNombre;

                if (puntoVentaActual.RecuperaRegistro(pago.PuntoVentaId))
                {
                    lblRTN.Text = "R.T.N. " + puntoVentaActual.RTN;
                    lblRTN.Visible = lblmail.Visible = lblDireccion.Visible = true;
                    lblmail.Text = puntoVentaActual.Correo;
                    lblDireccion.Text = puntoVentaActual.Direccion;
                    lblTelefono.Text = "Telefono: " + puntoVentaActual.Telefono;
                    lblLegalName.Text = puntoVentaActual.NombreLegal;
                    lblCompanyName.Text = puntoVentaActual.Nombre;
                }

            }
        }

    }
}
