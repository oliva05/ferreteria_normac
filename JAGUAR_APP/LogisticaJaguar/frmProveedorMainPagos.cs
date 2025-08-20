using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Contabilidad.Proveedores;
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

namespace JAGUAR_PRO.LogisticaJaguar
{
    public partial class frmProveedorMainPagos : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        PDV PuntoVentaActual;
        public frmProveedorMainPagos(UserLogin userLogin, PDV p1)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
            PuntoVentaActual = p1;
            //PuntoVentaActual = pPDActual;
            //LoadFacturasList();
            dp = new DataOperations();
            DateTime fechaActual = dp.NowSetDateTime();
            DateTime FechaInicial = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, 0, 0, 0);

            DateTime FechaFinal = FechaInicial.AddHours(23);
            //FechaInicial.AddDays(-30);
            //FechaInicial.Date.AddDays(-30);
            FechaInicial = FechaInicial.AddDays(-30);

            dtDesde.EditValue = FechaInicial;
            dtHasta.EditValue = FechaFinal;
            LoadPagos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ProveedorCRUDPagos frm = new ProveedorCRUDPagos(this.UsuarioLogeado, PuntoVentaActual);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadPagos();
            }
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage.Name == "TabFacturas")
            {
                LoadFacturas();

            }

            if (xtraTabControl1.SelectedTabPage.Name == "TabPagos")
            {
                LoadPagos();
            }
        }

        private void LoadPagos()
        {
            try
            {
                dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_list_pagos_fact_prov]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                dsLogisticaJaguar1.pagos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLogisticaJaguar1.pagos);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadFacturas()
        {
            //try
            //{
            //    DataOperations dp = new DataOperations();
            //    SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            //    con.Open();

            //    SqlCommand cmd = new SqlCommand("[dbo].[]", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
            //    cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
            //    dsLogisticaJaguar1.proveedores_list.Clear();
            //    SqlDataAdapter adat = new SqlDataAdapter(cmd);
            //    adat.Fill(dsLogisticaJaguar1.proveedores_list);

            //    con.Close();
            //}
            //catch (Exception ec)
            //{
            //    CajaDialogo.Error(ec.Message);
            //}
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdPagos.ExportToXlsx(dialog.FileName);
            }
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == TabFacturas)
            {
                LoadFacturas();
                btnAgregar.Visible = false;
            }
            if (e.Page == TabPagos)
            {
                LoadPagos();
                btnAgregar.Visible = true;
            }
        }

        private void cmdVerDetalle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdPagos.FocusedView;
            var row = (dsLogisticaJaguar.pagosRow)gridview.GetFocusedDataRow();

            if (row != null)
            {

            }

        }

        private void cmdPrintFromGrid_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grdPagos.FocusedView;
            var row = (dsLogisticaJaguar.pagosRow)gridView.GetFocusedDataRow();

            rptPagoProveedores compra = new rptPagoProveedores(row.id_pago);
            compra.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printOrden = new DevExpress.XtraReports.UI.ReportPrintTool(compra);
            printOrden.ShowPreview();
        }
    }
}