using ACS.Classes;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.LogisticaJaguar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.DynamicData;
using System.Windows.Forms;
using static JAGUAR_PRO.Compras.frmSearchOrdenesC;

namespace JAGUAR_PRO.Compras
{
    public partial class frmOrdenCompraList : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        PDV PuntoVentaActual;
        UserLogin UsuarioLogueado;
        public int IdOrdenesSeleccionado = 0;
        int PuntoVentaID;
        public frmOrdenCompraList(PDV pPuntoVentaActual, UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;
            this.PuntoVentaActual = pPuntoVentaActual;

            dtDesde.DateTime = dp.Now().AddDays(-7);
            dtHasta.DateTime = dp.Now().AddDays(1);
            
            PuntoVentaID = PuntoVentaActual.ID;
            LoadData();
        }


        private void LoadData()
        {

            try
            {
                string query = @"[sp_get_ordenes_compra_creadasypendientesV2]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PuntoVentaActual", PuntoVentaID);
                cmd.Parameters.AddWithValue("@desde",dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.orden_compra.Clear();
                adat.Fill(dsCompras1.orden_compra);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadDataAutorizadas()
        {

            try
            {
                string query = @"[sp_get_ordenes_compra_autorizadasycerradas]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PuntoVentaActual", PuntoVentaID);
                cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.orden_compra_autorizadas.Clear();
                adat.Fill(dsCompras1.orden_compra_autorizadas);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        private void reposGestionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdPendientes.FocusedView;
            var row = (dsCompras.orden_compraRow)gridview.GetFocusedDataRow();
            bool Permitir = false;
            switch (row.id_estado)
            {
                case 1:
                    Permitir = true;
                    break;

                case 5:
                    CajaDialogo.Error("Esta orden ya se encuentra pendiente de Aprobacion!");
                    break;

                case 6:
                    DialogResult r = CajaDialogo.Pregunta("La Orden de Compra fue Rechazada\nDesea enviarla de nuevo a Aprobacion?");
                    if (r == DialogResult.Yes)
                    {
                        Permitir = true;
                    }
                    else
                    {
                        Permitir = false;
                    }
                    break;
                default:

                    break;
            }

            if (Permitir)
            {

                try
                {
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_compras_enviar_aprobacion_oc", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_orden_compra",row.id);
                    cmd.Parameters.AddWithValue("@id_usuario",UsuarioLogueado.Id);
                    cmd.Parameters.AddWithValue("@id_estado", row.id_estado);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    CajaDialogo.Error (ex.Message);
                }

                LoadData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdRecargar_Click(object sender, EventArgs e)
        {
            var pestañaActiva = (xtraTabControl1.SelectedTabPage);

            if (pestañaActiva == xtraTabPagePendientes)
            {
                LoadData();
            }
            else if (pestañaActiva == xtraTabPageAutorizadas)
            {
                LoadDataAutorizadas();
            }
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            
            if (xtraTabControl1.SelectedTabPage == xtraTabPagePendientes)
            {
                LoadData();
            }
            if (xtraTabControl1.SelectedTabPage == xtraTabPageAutorizadas)
            {
                LoadDataAutorizadas();
            }
        }

        private void repositoryItemPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdAllOC.FocusedView;
            var row = (dsCompras.orden_compra_autorizadasRow)gridview.GetFocusedDataRow();

            if (row.id > 0)
            {
                CargarDetalle(row.id);
                rptOrdenCompra report = new rptOrdenCompra(row.id) { DataSource = dsCompras1, DataMember = "oc_detalle", ShowPrintMarginsWarning = false };
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool reportPrint = new ReportPrintTool(report);
                reportPrint.ShowPreview();
            }
            else
            {
                CajaDialogo.Error("Debe seleccionar una Orden de Compra!");
                return;
            }
        }

        private void CargarDetalle(int id)
        {
            try
            {
                string query = @"[sp_get_compras_ordenes_detalle]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_header_orden", id);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.oc_detalle.Clear();
                adat.Fill(dsCompras1.oc_detalle);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}