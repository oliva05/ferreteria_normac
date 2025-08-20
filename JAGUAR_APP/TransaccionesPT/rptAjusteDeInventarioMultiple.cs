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
    public partial class rptAjusteDeInventarioMultiple : DevExpress.XtraReports.UI.XtraReport
    {
        //PgSqlConnection psConnection;
        int idFact;
        public enum TipoCopia
        {
            Blanco = 0,//White
            Verde = 10,//SeaGreen
            Azul = 11, //CadetBlue
            Rosa = 12  //LightPink
        }

        public TipoCopia TipoCopiaActual = TipoCopia.Blanco;

        public rptAjusteDeInventarioMultiple(Int64 pIdKardexPT_row)
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

                if (kardex1.Entrada > 0)
                {
                    lblTipoTransaccionEntrada_Salida.Text = "Entrada de Mercancías";
                }
                else
                {
                    lblTipoTransaccionEntrada_Salida.Text = "Salida de Mercancías";
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

                //lblCantidad.Text = string.Format("{0:###,##0.00}", Cantidad);
                //lblProductoDescripcionItemName.Text = kardex1.ItemName;
                //lblItemCode.Text = kardex1.ItemCode;

                //lblEntradaSalida.Text  = string.Format("{0:###,##0.00}", Cantidad);
                //lblPrecio.Text = string.Format("{0:###,##0.00}", kardex1.Precio);
                //lblTotal.Text = string.Format("{0:###,##0.00}", Math.Round(kardex1.Precio * Cantidad),2);
                CargarDetalle(pIdKardexPT_row);
            }
            
        }

        private void CargarDetalle(long pIdKardexPT_row)
        {
            try
            {
                string sql = "[sp_get_detalle_solicitud_ajuste_inventario_rpt]";
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

                SqlDataAdapter da = new SqlDataAdapter(sql, cnx);
                da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                //PgSqlCommand cmd = new PgSqlCommand(sql, psConnection);
                da.SelectCommand.Parameters.AddWithValue("@id_solicitud_h", pIdKardexPT_row);
                dsReportesKardex1.detalle_ajuste_manual.Clear();
                da.Fill(dsReportesKardex1.detalle_ajuste_manual);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void rptAjusteDeInventarioMultiple_BeforePrint(object sender, CancelEventArgs e)
        {
        }
        private void rptAjusteDeInventarioMultiple_DataSourceDemanded(object sender, EventArgs e)
        {
        }

    }
}
