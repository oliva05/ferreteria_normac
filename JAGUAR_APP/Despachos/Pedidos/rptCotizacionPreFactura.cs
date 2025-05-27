using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Clases;
using ACS.Classes;
using System.Data.SqlClient;

namespace JAGUAR_PRO.Facturacion.Reportes
{
    public partial class rptCotizacionPreFactura : DevExpress.XtraReports.UI.XtraReport
    {
        //PgSqlConnection psConnection;
        int idFact;
        public enum TipoCopia
        {
            Blanco = 0,//White
            Verde = 10,//SeaGreen
            Azul = 11,//CadetBlue
            Rosa = 12//LightPink
        }

        public TipoCopia TipoCopiaActual = TipoCopia.Blanco;
        CotizacionH CotizacionActual;

        public rptCotizacionPreFactura(Int64 pIdCotizacionH)
        {
            InitializeComponent();
            //TipoCopiaActual = pTipoCopia;

            //psConnection = pConnection;
            //ConfiguracionSuccess conf = new ConfiguracionSuccess(psConnection);


            //lblTelefono.Text ="Telefonos: "+ Factura1.Telefono_PDV;

            //lblLegalName.Text = "Distribuidora Don Fidel";// Factura1.NombreLegal_PDV;
            //lblCai.Text = "CAI: " + Factura1.CAI;
            CotizacionActual = new CotizacionH();
            if (CotizacionActual.ObtenerPorId(pIdCotizacionH))
            {
                PDV PuntoVenta1 = new PDV();
                if (PuntoVenta1.RecuperaRegistro(CotizacionActual.IdPuntoVenta))
                {
                    lblRTN.Text = "R.T.N. " + PuntoVenta1.RTN;
                    lblRTN.Visible = lblmail.Visible = lblDireccion.Visible = true;
                    lblmail.Text = PuntoVenta1.Correo;
                    lblDireccion.Text = PuntoVenta1.Direccion;
                    lblTelefono.Text = "Telefono: " + PuntoVenta1.Telefono;
                    lblLegalName.Text = PuntoVenta1.NombreLegal;
                    lblCompanyName.Text = PuntoVenta1.Nombre;
                }

                lblNumeroDocumento.Text = CotizacionActual.NumDoc;
                ////lblFechaEmision.Text = string.Format("{0:MM/dd/yyyy}", Factura1.FechaDocumento);
                lblFechaEmision.Text = string.Format("{0:dd/MM/yyyy}", CotizacionActual.Fecha);
                lblCliente.Text = CotizacionActual.ClienteNombre;
                lblClienteRTN.Text = CotizacionActual.RTN;
                lblOrdenCompra.Text = "";// CotizacionActual.OrdenCompra;
                lblDireccionCliente.Text = CotizacionActual.Direccion;// Factura1.direccion_cliente;
                                                                            //lblValorLetras.Text = Factura1.ValorLetras;
                                                                            //lblRangoAutorizado.Text = Factura1.RangoAutorizado;
                                                                            //lblFechaLimite.Text = string.Format("{0:dd/MM/yyyy}", Factura1.FechaLimite);
                lblSubTotal.Text = string.Format("{0: ###,##0.00}", CotizacionActual.SubTotal);
                lblDescuento.Text = string.Format("{0: ###,##0.00}", CotizacionActual.Descuento);
                lbl_Impuesto.Text = string.Format("{0: ###,##0.00}", CotizacionActual.ISV);
                //lblISV.Text = string.Format("{0: ###,##0.00}", 0);
                //lblISV2.Text = string.Format("{0: ###,##0.00}", 0);
                lblTotalPagar.Text = string.Format("{0: ###,##0.00}", CotizacionActual.Total);
                lblTermino.Text = "Contado";
                txtFechaentrega.Text = "";// string.Format("{0:dd/MM/yyyy}", CotizacionActual.FechaEntregaEstimada);
                txtComentario.Text = CotizacionActual.Comentario;
                //((Factura1.sub - Factura1.descuento) + Factura1.Recargo));
                //if (Factura1.Recargo > 0)
                //{
                //    lblRecargo.Text = string.Format("{0: ###,##0.00}", Factura1.Recargo);
                //    lblRecargoDescuentoDescrip.Text = "Recargo";
                //}
                //else
                //{
                //    lblRecargoDescuentoDescrip.Text = "Descuento";
                //    lblRecargo.Text = string.Format("{0: ###,##0.00}", Factura1.descuento);
                //}

                //idFact = Factura1.id;
                //decimal saldo_actual = Factura1.Saldo;
                //lblSaldoAnterior.Text = string.Format("{0: ###,##0.00}", ((saldo_actual- Factura1.descuento) + Factura1.Recargo));
                //lblAbono.Text = string.Format("{0: ###,##0.00}", (Factura1.sub - Factura1.descuento + Factura1.Recargo));
                //lblSaldoActual.Text = string.Format("{0: ###,##0.00}",
                //(((saldo_actual - Factura1.descuento) + Factura1.Recargo) - (Factura1.sub + Factura1.Recargo - Factura1.descuento)));

                CargarDetalle(CotizacionActual.Id);
            }
            
        }

        private void CargarDetalle(long pIdFactura)
        {
            try
            {
                string sql = "[uspRptGetDetailOrderQuotation]";
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

                SqlDataAdapter da = new SqlDataAdapter(sql, cnx);
                da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                //PgSqlCommand cmd = new PgSqlCommand(sql, psConnection);
                da.SelectCommand.Parameters.AddWithValue("@idQuotation", pIdFactura);
                dsFacturasGestion1.Factura_Detalle.Clear();
                da.Fill(dsFacturasGestion1.Factura_Detalle);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void rptCotizacionPreFactura_BeforePrint(object sender, CancelEventArgs e)
        {
        }
        private void rptCotizacionPreFactura_DataSourceDemanded(object sender, EventArgs e)
        {
        }

    }
}
