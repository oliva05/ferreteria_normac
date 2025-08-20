using ACS.Classes;
using DevExpress.CodeParser;
using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;

namespace JAGUAR_PRO.Facturacion.Reportes
{
    public partial class rptAjusteDeInventario : DevExpress.XtraReports.UI.XtraReport
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

        public rptAjusteDeInventario(Int64 pIdKardexPT_row)
        {
            InitializeComponent();
            KardexPT kardex1 = new KardexPT();

            if (kardex1.RecuperarRegistro(pIdKardexPT_row))
            {
                PDV PuntoVenta1 = new PDV();
                if (PuntoVenta1.RecuperaRegistro(1))
                {
                    lblLegalName.Text = PuntoVenta1.NombreLegal;
                    lblCompanyName.Text = PuntoVenta1.Nombre;
                }
                decimal Cantidad = 0;

                if (kardex1.Entrada > 0)
                {
                    lblTipoTransaccionEntrada_Salida.Text = "Entrada de Mercancías";
                    Cantidad = kardex1.Entrada;
                    lblRotuloEntradaSalidaRow.Text = "Entrada";
                }
                else
                {
                    lblTipoTransaccionEntrada_Salida.Text = "Salida de Mercancías";
                    Cantidad = kardex1.Salida;
                    lblRotuloEntradaSalidaRow.Text = "Salida";
                }

                lblFechaEmision.Text = kardex1.FechaReg.ToString("dd/MM/yyyy hh:mm:ss tt", new CultureInfo("en-US"));
                lblNumeroDocumento.Text = kardex1.NumDocumento;
                lblTipoTransaccionMovimiento.Text = kardex1.TipoTransaccionName;
                lblEstado.Text = kardex1.EnableDescripcion;
                lblUsuario.Text = kardex1.Usuario;

                if (kardex1.UsuarioApruebaAjuste != "N/D")
                {
                    lblUsuarioAprobador.Text = kardex1.UsuarioApruebaAjuste;
                    lblUsuarioAprobador.Visible = lblUsuarioAprobadorLabel.Visible = true;
                }

                txtComentario.Text = kardex1.Razon_motivo;
                lblAlmacen.Text = string.Concat(kardex1.CodigoAlmacen, " ", kardex1.DescripcionAlmacen);
                
                lblCantidad.Text = string.Format("{0:###,##0.00}", Cantidad);
                lblProductoDescripcionItemName.Text = kardex1.ItemName;
                lblItemCode.Text = kardex1.ItemCode;

                lblEntradaSalida.Text  = string.Format("{0:###,##0.00}", Cantidad);
                lblPrecio.Text = string.Format("{0:###,##0.00}", kardex1.Precio);
                lblTotal.Text = string.Format("{0:###,##0.00}", Math.Round(kardex1.Precio * Cantidad),2);
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

        private void rptAjusteDeInventario_BeforePrint(object sender, CancelEventArgs e)
        {
        }
        private void rptAjusteDeInventario_DataSourceDemanded(object sender, EventArgs e)
        {
        }

    }
}
