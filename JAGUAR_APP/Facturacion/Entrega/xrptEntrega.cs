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
        public xrptEntrega(int idPedido, int idBodega, UserLogin userLogin)
        {
            InitializeComponent();
            GetHeader(idPedido);

            Bodega bodega = new Bodega();
            if (bodega.RecuperarRegistro(idBodega))
                lblAlmOrigen.Text = bodega.DescripcionCorta;

            UsuarioLogeado = userLogin;
            lblUsuario.Text = UsuarioLogeado.Nombre;
        }

        private void GetHeader(int idPedido)
        {
            try
            {
                PedidoCliente pedidoCliente = new PedidoCliente();
                if (pedidoCliente.RecuperarRegistro(idPedido))
                {
                    lblNumTraslado.Text = "# Entrega " + pedidoCliente.NumeroDocumento;
                    lblFecha.Text = string.Format("{0:G}", pedidoCliente.FechaEntrega);
                    GetDetalle(idPedido);
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
