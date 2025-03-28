using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JAGUAR_PRO.Facturacion.Cotizaciones;
using JAGUAR_PRO.Clases;
using System.Data.SqlClient;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Despachos.Pedidos;

namespace JAGUAR_PRO.Facturacion.Cotizaciones
{
    public partial class frmSearchPedidos : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        PDV PuntoVentaActual;
        public int IdPedido = 0;
        DataOperations dp;
        public frmSearchPedidos(UserLogin pUserLog, PDV pPuntoVenta)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLog;
            PuntoVentaActual = pPuntoVenta;
            dp  = new DataOperations();
            dtFechaDesdeDisponibles.DateTime = dp.dNow().AddDays(-30);
            dtFechaHastaDisponibles.DateTime = dp.dNow().AddDays(2);

            LoadData();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridview = (GridView)grdPedidos.FocusedView;
            var row = (dsFactCotizacion.ListaCotizacionesRow)gridview.GetFocusedDataRow();

            if (row.id > 0)
            {
                IdPedido = row.id;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void LoadData()
        {
            try
            {
                string query = @"[sp_get_listado_pedidos_clientes_venta_v2]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtFechaDesdeDisponibles.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtFechaHastaDisponibles.DateTime);
                cmd.Parameters.AddWithValue("@id_punto_venta", PuntoVentaActual.ID);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPedidosClientesV1.lista_pedidos.Clear();
                adat.Fill(dsPedidosClientesV1.lista_pedidos);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdRefreshDisponibles_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gridView1_DoubleClick_1(object sender, EventArgs e)
        {
            var gridView = (GridView)grdPedidos.FocusedView;
            var row = (dsPedidosClientesV.lista_pedidosRow)gridView.GetFocusedDataRow();

            DataOperations dp = new DataOperations();
            IdPedido = dp.ValidateNumberInt32(row.id);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}