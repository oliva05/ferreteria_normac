using ACS.Classes;
using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using JAGUAR_PRO.TransaccionesPT;
using JAGUAR_PRO.Mantenimientos.Modelos;

namespace JAGUAR_PRO.Facturacion.Entrega
{
    public partial class xrptEntrega : DevExpress.XtraReports.UI.XtraReport
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public int Conteo;
        int IdBodega;
        PDV PuntoVentaActual;
        public xrptEntrega(int idPedido, int idBodega, UserLogin userLogin,PDV PuntoVenta)
        {
            InitializeComponent();
            IdBodega = idBodega;
            
            PuntoVentaActual = PuntoVenta;
            
            Bodega bodega = new Bodega();
            if (bodega.RecuperarRegistro(idBodega))
                lblAlmOrigen.Text = bodega.DescripcionCorta;

            UsuarioLogeado = userLogin;
            lblUsuario.Text = UsuarioLogeado.Nombre;
            GetHeader(idPedido);
            GetDetalle(idPedido);
        }

        public xrptEntrega(int idPedido, int idBodega, UserLogin userLogin, DataTable pDetalle , PDV PuntoVenta)
        {
            InitializeComponent();
            IdBodega = idBodega;
            PuntoVentaActual = PuntoVenta;
            Bodega bodega = new Bodega();
            if (bodega.RecuperarRegistro(idBodega))
                lblAlmOrigen.Text = bodega.DescripcionCorta;

            UsuarioLogeado = userLogin;
            lblUsuario.Text = UsuarioLogeado.Nombre;

            GetHeader(idPedido);
            dsEntregaPedidos1.detalle_entrega.Clear();
            foreach (DataRow item in pDetalle.Rows)
            {
                DataRow dr  = dsEntregaPedidos1.detalle_entrega.NewRow();
                dr[0] = item["id"];
                dr[1] = item["id_pt"];
                dr[2] = item["cant_a_entregar"];
                dr[3] = item["id_h"];
                dr[4] = item["precio"];
                dr[5] = item["id_estado"];
                dr[6] = item["bodega"];
                dr[7] = item["id_bodega"]; 
                dr[8] = item["code"];
                dr[9] = "COD:"+item["code_referencia"];
                dr[10] = item["descripcion"];
                dsEntregaPedidos1.detalle_entrega.Rows.Add(dr);
                dsEntregaPedidos1.detalle_entrega.AcceptChanges();

                //dsEntregaPedidos1.detalle_entrega.ImportRow(item);
            }
        }

        private void GetHeader(int idPedido)
        {
            try
            {
                PedidoCliente pedidoCliente = new PedidoCliente();
                if (pedidoCliente.RecuperarRegistro(idPedido))
                {
                    lblNombreLegal.Text = PuntoVentaActual.NombreLegal;
                    lblRtn.Text = "R.T.N " + PuntoVentaActual.RTN;

                    lblNumTraslado.Text = pedidoCliente.NumeroDocumento;
                    lblFecha.Text = string.Format("{0:g}", dp.Now());
                    Factura fact = new Factura();
                    fact.RecuperarRegistro(pedidoCliente.IdFactura);
                    lblFacturaNo.Text = fact.NumeroDocumento;
                    lblCliente.Text = pedidoCliente.ClienteNombre;
                    lblDireccion.Text = pedidoCliente.direccion_cliente;
                    lblCodeVenedor.Text = pedidoCliente.VendedorNombre;
                    
                }
                
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void GetDetalle(int idTraslado)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_rpt_get_entregado_pedido", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", idTraslado);
                cmd.Parameters.AddWithValue("@idBodega", IdBodega);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsEntregaPedidos1.detalle_entrega.Clear();
                adat.Fill(dsEntregaPedidos1.detalle_entrega);
                Conteo = dsEntregaPedidos1.detalle_entrega.Count;
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }
    }

}
