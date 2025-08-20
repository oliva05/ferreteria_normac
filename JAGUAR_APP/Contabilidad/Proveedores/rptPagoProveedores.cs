using ACS.Classes;
using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
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

                GetDetalleReporte(pIdPago);

            }
        }

        private void GetDetalleReporte(int pIdPago)
        {
            try
            {
                string query = @"sp_get_pago_rpt";
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPago", pIdPago);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsLogisticaJaguar1.rpt_detalle_pago.Clear();
                adat.Fill(dsLogisticaJaguar1.rpt_detalle_pago);
                conn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}
