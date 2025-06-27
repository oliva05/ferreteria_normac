using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Facturacion.CoreFacturas;
using JAGUAR_PRO.Facturacion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO.Despachos.Pedidos
{
    public partial class frmCotizaciones : DevExpress.XtraEditors.XtraForm
    {
        int IdPedidoH;
        UserLogin UsuarioLogeado;
        DataOperations dp;
        FacturacionEquipo equipo;
        PDV PuntoVentaActual;
        Vendedor Vendedor;

        public frmCotizaciones(int pIdPedidoH, UserLogin pUsuarioLogeado, PDV pPuntoVenta, Vendedor pVendedor)
        {
            InitializeComponent();
            IdPedidoH = pIdPedidoH;
            dp = new DataOperations();
            PuntoVentaActual = pPuntoVenta;
            UsuarioLogeado = pUsuarioLogeado;
            Vendedor = pVendedor;
            LoadDatos();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_listado_cotizaciones_clientes_ventas]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                //cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                //cmd.Parameters.AddWithValue("@id_punto_venta", this.PuntoVentaActual.ID);
                //cmd.Parameters.AddWithValue("@incluir_docs_cerrados", tggIncluirDocCerrados.IsOn);
                cmd.Parameters.AddWithValue("@id_pedido_h", IdPedidoH);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPrefacturas1.lista_cotizaciones.Clear();
                adat.Fill(dsPrefacturas1.lista_cotizaciones);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Generar una nueva cotizacion 
            DialogResult r = CajaDialogo.Pregunta("Esta seguro de generar una nueva cotización basado en esta pre factura?");
            if (r != DialogResult.Yes)
                return;

            //Generar la cotizacion 
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_InsertCotizacion]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pedido", IdPedidoH);
                cmd.Parameters.AddWithValue("@id_user", Vendedor.Id);
                cmd.ExecuteScalar();
                
                con.Close();
                LoadDatos();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdPrintCotizacion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsPrefacturas.lista_cotizacionesRow)gridView.GetFocusedDataRow();

            if(!row.IsidNull() )
            {
                rptCotizacionPreFactura report = new rptCotizacionPreFactura(row.id);
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(report);
                report.ShowPrintMarginsWarning = false;

                printReport.ShowPreviewDialog();
            }
        }
    }
}