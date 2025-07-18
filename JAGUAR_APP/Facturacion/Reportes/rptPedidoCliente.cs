using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Clases;
using ACS.Classes;
using System.Data.SqlClient;
using JAGUAR_PRO.Facturacion.CoreFacturas;

namespace JAGUAR_PRO.Facturacion.Reportes
{
    public partial class rptPedidoCliente : DevExpress.XtraReports.UI.XtraReport
    {
        //PgSqlConnection psConnection;
        int idFact;
        decimal IsvTotal = 0;
        public enum TipoCopia
        {
            Blanco = 0,//White
            Verde = 10,//SeaGreen
            Azul = 11,//CadetBlue
            Rosa = 12//LightPink
        }

        public TipoCopia TipoCopiaActual = TipoCopia.Blanco;

        public rptPedidoCliente(PedidoCliente PedidoCliente1)
        {
            InitializeComponent();
            //TipoCopiaActual = pTipoCopia;

            //psConnection = pConnection;
            //ConfiguracionSuccess conf = new ConfiguracionSuccess(psConnection);

           
            //lblTelefono.Text ="Telefonos: "+ Factura1.Telefono_PDV;
            
            //lblLegalName.Text = "Distribuidora Don Fidel";// Factura1.NombreLegal_PDV;
            //lblCai.Text = "CAI: " + Factura1.CAI;
            PDV PuntoVenta1 = new PDV();
            if (PuntoVenta1.RecuperaRegistro(PedidoCliente1.IdPuntoVenta))
            {
                lblRTN.Text = "R.T.N. " + PuntoVenta1.RTN;
                lblRTN.Visible = lblmail.Visible =  lblDireccion.Visible = true;
                lblmail.Text = PuntoVenta1.Correo;
                lblDireccion.Text = PuntoVenta1.Direccion;
                lblTelefono.Text = "Telefono: " + PuntoVenta1.Telefono;
                lblLegalName.Text = PuntoVenta1.NombreLegal;
                lblCompanyName.Text = PuntoVenta1.Nombre;
            }

            lblNumeroFactura.Text = PedidoCliente1.NumeroDocumento;
            ////lblFechaEmision.Text = string.Format("{0:MM/dd/yyyy}", Factura1.FechaDocumento);
            lblFechaEmision.Text = string.Format("{0:dd/MM/yyyy}", PedidoCliente1.FechaDocumento);
            lblCliente.Text = PedidoCliente1.ClienteNombre;
            lblClienteRTN.Text = PedidoCliente1.RTN;
            lblOrdenCompra.Text = PedidoCliente1.OrdenCompra;
            lblDireccionCliente.Text = PedidoCliente1.direccion_cliente;// Factura1.direccion_cliente;
            //lblValorLetras.Text = Factura1.ValorLetras;
            //lblRangoAutorizado.Text = Factura1.RangoAutorizado;
            //lblFechaLimite.Text = string.Format("{0:dd/MM/yyyy}", Factura1.FechaLimite);
            lblSubTotal.Text = string.Format("{0: ###,##0.00}", PedidoCliente1.SubTotal );
            lbl_impuesto.Text = string.Format("{0: ###,##0.00}", PedidoCliente1.ISV);
            lblDescuento.Text = string.Format("{0: ###,##0.00}", PedidoCliente1.Descuento);
            
            //lblISV.Text = string.Format("{0: ###,##0.00}", 0);
            //lblISV2.Text = string.Format("{0: ###,##0.00}", 0);
            lblTotalPagar.Text = string.Format("{0: ###,##0.00}", PedidoCliente1.TotalPedido);
            lblTermino.Text = "Contado";
            txtFechaentrega.Text = string.Format("{0:dd/MM/yyyy}", PedidoCliente1.FechaEntrega);
            txtComentario.Text = PedidoCliente1.Comentario;
            txtVendedor.Text = PedidoCliente1.CodigoVendedor + " - " + PedidoCliente1.VendedorNombre;
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

            CargarDetalle(PedidoCliente1.Id);
            
        }

        private void CargarDetalle(long pIdFactura)
        {
            try
            {
                string sql = "[uspRptGetDetailOrder]";
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

                SqlDataAdapter da = new SqlDataAdapter(sql, cnx);
                da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                //PgSqlCommand cmd = new PgSqlCommand(sql, psConnection);
                da.SelectCommand.Parameters.Add("@id_pedido", System.Data.SqlDbType.Int).Value = pIdFactura;
                dsFacturasGestion1.Factura_Detalle.Clear();
                da.Fill(dsFacturasGestion1.Factura_Detalle);

                //foreach (dsFacturasGestion.Factura_DetalleRow item in dsFacturasGestion1.Factura_Detalle)
                //{
                //    IsvTotal += dp.ValidateNumberDecimal(item.cantidad * item.impuesto2);
                //}

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void rptPedidoCliente_BeforePrint(object sender, CancelEventArgs e)
        {
        }
        private void rptPedidoCliente_DataSourceDemanded(object sender, EventArgs e)
        {
        }

    }
}
