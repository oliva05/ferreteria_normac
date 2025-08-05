using ACS.Classes;
using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;

namespace JAGUAR_PRO.Compras
{
    public partial class rptOrdenCompra : DevExpress.XtraReports.UI.XtraReport
    {
        DataOperations dp = new DataOperations();
        public rptOrdenCompra(int pIdOrdenCompraActual)
        {
            InitializeComponent();

            OrdenesCompra oc = new OrdenesCompra();
            oc.RecuperarRegistos(pIdOrdenCompraActual);
            lblCliente.Text = oc.Itemcode_Prov + " - " + oc.Nombre_Prov;
            Proveedor prov = new Proveedor();
            prov.RecuperarRegistroByCodigo(oc.Itemcode_Prov);
            lblRTN.Text = prov.Jaguar_RTN;
            lblDireccion.Text = oc.Direccion;
            lblNumeroOrden.Text = "Orden de Compra #" + oc.DocNum1;
            lblFechaOrden.Text = string.Format("{0:dd/MM/yyyy}",oc.Fecha_Contabilizacion);
            lblFechaVencimiento.Text = string.Format("{0:dd/MM/yyyy}", oc.Fecha_Contabilizacion.AddDays(30).ToString());
            lblComentario.Text = oc.Comentario;
            load_detalle(pIdOrdenCompraActual);
            switch (oc.Id_Estado)
            {
                case 5:
                    txtBorrador.Visible = true;
                    break;

                case 2:
                    txtBorrador.Visible = false; 
                    break;
                default:
                    txtBorrador.Visible = true;
                    break;
            }

            lblSub.Text = string.Format("{0: ###,##0.00}", oc.Subtotal);
            lblIsv.Text = string.Format("{0: ###,##0.00}", oc.Impuesto); 
            lblTotal.Text = string.Format("{0: ###,##0.00}", oc.Total);

            PDV PuntoVentaActual = new PDV();
            PuntoVentaActual.RecuperaRegistro(oc.Id_PuntoVenta);
            lblDireccionPuntoVenta.Text = PuntoVentaActual.Direccion + " " + PuntoVentaActual.Ciudad + " " + PuntoVentaActual.Departamento;
            lblTelefonoPuntoVenta.Text = PuntoVentaActual.Telefono;
            lblRTNPuntoVenta.Text = PuntoVentaActual.RTN;

        }

        private void load_detalle(int PIdOrdenCompraActual)
        {
            try
            {
                string sql = @"[sp_get_compras_ordenes_detalle]";

                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_header_orden", PIdOrdenCompraActual);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.oc_detalle.Clear();
                adat.Fill(dsCompras1.oc_detalle);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}
