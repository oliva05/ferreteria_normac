using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSpreadsheet.Import.Xls;
using Eatery.Ventas;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Facturacion.CoreFacturas;
using JAGUAR_PRO.Facturacion.Reportes;
using JAGUAR_PRO.LogisticaJaguar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO.Despachos.Pedidos
{
    public partial class frmHomePedidosClientes : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        FacturacionEquipo equipo;
        PDV PuntoVentaActual;
        public frmHomePedidosClientes(UserLogin pUsuarioLogeado, PDV pPuntoVenta)
        {
            InitializeComponent();
            equipo = new FacturacionEquipo();
            UsuarioLogeado = pUsuarioLogeado;
            PuntoVentaActual = pPuntoVenta;
            dp = new DataOperations();
            DateTime fechaActual = dp.NowSetDateTime();
            DateTime FechaInicial = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, 0, 0, 0);

            DateTime FechaFinal = FechaInicial.AddDays(3);
            FechaInicial = FechaInicial.AddDays(-30);

            dtDesde.EditValue = FechaInicial;
            dtHasta.EditValue = FechaFinal;
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

                SqlCommand cmd = new SqlCommand("[sp_get_listado_pedidos_clientes_venta_v3]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                cmd.Parameters.AddWithValue("@id_punto_venta", this.PuntoVentaActual.ID);
                cmd.Parameters.AddWithValue("@incluir_docs_cerrados", tggIncluirDocCerrados.IsOn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPedidosClientesV1.lista_pedidos.Clear();
                adat.Fill(dsPedidosClientesV1.lista_pedidos); 
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

        private void cmdEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Editar pedido
            string HostName = Dns.GetHostName();
            equipo = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (equipo.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(equipo.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsPedidosClientesV.lista_pedidosRow)gridView.GetFocusedDataRow();

            frmPedidoCliente frm = new frmPedidoCliente(this.UsuarioLogeado, puntoVenta1, equipo, row.id);
            frm.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string HostName = Dns.GetHostName();
            equipo = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (equipo.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(equipo.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            frmPedidoCliente frm = new frmPedidoCliente(this.UsuarioLogeado, puntoVenta1, equipo);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadDatos();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Nueva version

            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;
                string path = "Inventario PT JAGUAR";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                    //Customize export options
                    (gridControl1.MainView as GridView).OptionsPrint.PrintHeader = true;
                    XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                    advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.SheetName = "Exported from JAGUAR";

                    gridControl1.ExportToXlsx(path, advOptions);
                    // Open the created XLSX file with the default application.
                    Process.Start(path);
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdImprimir_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            PedidoCliente ped1 = new PedidoCliente();
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsPedidosClientesV.lista_pedidosRow)gridView.GetFocusedDataRow();

            if (ped1.RecuperarRegistro(row.id))
            {
                rptPedidoCliente report = new rptPedidoCliente(ped1);// { DataSource = dsCompras1, DataMember = "oc_detalle", ShowPrintMarginsWarning = false };
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(report);
                report.ShowPrintMarginsWarning = false;

                printReport.ShowPreviewDialog();
            }
            
            
        }

        private void cmdCrearCotizacion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsPedidosClientesV.lista_pedidosRow)gridView.GetFocusedDataRow();
            frmCotizaciones frm = new frmCotizaciones(row.id, this.UsuarioLogeado, PuntoVentaActual);
            frm.ShowDialog();

            ////Generar una nueva cotizacion 
            //DialogResult r = CajaDialogo.Pregunta("Esta seguro de generar una nueva cotización basado en esta pre factura?");
            //if (r != DialogResult.Yes)
            //    return;

            ////Generar la cotizacion 
            //try
            //{
            //    DataOperations dp = new DataOperations();
            //    SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            //    con.Open();

            //    SqlCommand cmd = new SqlCommand("[dbo].[sp_InsertCotizacion]", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@id_pedido", row.id);
            //    cmd.ExecuteScalar();

            //    con.Close();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }
    }
}