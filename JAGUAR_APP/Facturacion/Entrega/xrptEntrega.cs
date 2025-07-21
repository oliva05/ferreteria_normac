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
        public xrptEntrega(int idPedido, int idBodega, UserLogin userLogin)
        {
            InitializeComponent();
            IdBodega = idBodega;
            

            
            Bodega bodega = new Bodega();
            if (bodega.RecuperarRegistro(idBodega))
                lblAlmOrigen.Text = bodega.DescripcionCorta;

            UsuarioLogeado = userLogin;
            lblUsuario.Text = UsuarioLogeado.Nombre;
            GetHeader(idPedido);
            GetDetalle(idPedido);
        }

        public xrptEntrega(int idPedido, int idBodega, UserLogin userLogin, DataTable pDetalle)
        {
            InitializeComponent();
            IdBodega = idBodega;



            Bodega bodega = new Bodega();
            if (bodega.RecuperarRegistro(idBodega))
                lblAlmOrigen.Text = bodega.DescripcionCorta;

            UsuarioLogeado = userLogin;
            lblUsuario.Text = UsuarioLogeado.Nombre;

            GetHeader(idPedido);
            dsEntregaPedidos1.detalle_entrega.Clear();
            foreach (DataRow item in pDetalle.Rows)
            {

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
                    lblNumTraslado.Text = pedidoCliente.NumeroDocumento;
                    lblFecha.Text = string.Format("{0:g}", dp.Now());
                    Factura fact = new Factura();
                    fact.RecuperarRegistro(pedidoCliente.IdFactura);
                    lblFacturaNo.Text = fact.NumeroDocumento;
                    lblCliente.Text = pedidoCliente.ClienteNombre;
                    lblDireccion.Text = pedidoCliente.direccion_cliente;


                    
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
