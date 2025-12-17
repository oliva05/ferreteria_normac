using ACS.Classes;
using DevExpress.DashboardCommon;
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Eatery.Ventas;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Despachos.Pedidos;
using JAGUAR_PRO.Facturacion.Cotizaciones;
using JAGUAR_PRO.Facturacion.Reportes;
using JAGUAR_PRO.Utileria;
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

namespace JAGUAR_PRO.Facturacion.Cotizaciones
{
    public partial class frmCotizacionesHome : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        PDV PuntoVentaActual;
        UserLogin UsuarioLogeado;
        int PuntoVentaId;
        Vendedor VendedorActual;
        bool AccesoAdmin;

        public frmCotizacionesHome(UserLogin userLogin, PDV ppuntoventa, bool pAccesoAdmin)
        {
            InitializeComponent();
            AccesoAdmin = pAccesoAdmin;
            UsuarioLogeado = userLogin;
            PuntoVentaActual = ppuntoventa;
            DateTime FechaActual = dp.dNow();
            dtFechaDesdeDisponibles.DateTime = new DateTime(FechaActual.Year, FechaActual.Month, FechaActual.Day, 0, 0, 0);
            dtFechaHastaDisponibles.DateTime = new DateTime(FechaActual.Year, FechaActual.Month, FechaActual.Day, 23, 59, 0);
            LoadData();
        }

        private void LoadData()
        {
            int IdVendedor = 0;
            if (!AccesoAdmin)
            {
                if (VendedorActual == null)
                {
                    CajaDialogo.Error("Es necesario cargar un vendedor!");
                    return;
                }
                else
                {
                    IdVendedor = VendedorActual.Id;
                }
            }

            if (!AccesoAdmin)
            {
                if (VendedorActual.Id == 0)
                {
                    CajaDialogo.Error("Es necesario cargar un vendedor!");
                    return;
                }
                else
                {
                    IdVendedor = VendedorActual.Id;
                }
            }

            

            try
            {
                //string query = @"sp_cotizaciones_lista";
                string query = @"sp_get_lista_cotizaciones_h";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtFechaDesdeDisponibles.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtFechaHastaDisponibles.DateTime);
                cmd.Parameters.AddWithValue("@id_vendedor", IdVendedor);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsFactCotizacion1.home_cotizaciones.Clear();
                adat.Fill(dsFactCotizacion1.home_cotizaciones);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            frmCotizacionOP frm = new frmCotizacionOP(frmCotizacionOP.TipoOperacion.Insert, UsuarioLogeado, PuntoVentaActual, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void cmdRefreshDisponibles_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void reposEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var grdvDetalle = (GridView)gridControl1.FocusedView;
            var row = (dsFactCotizacion.ListaCotizacionesRow)grdvDetalle.GetFocusedDataRow();

            if (row.id > 0)
            {
                frmCotizacionOP frm = new frmCotizacionOP(frmCotizacionOP.TipoOperacion.Update, UsuarioLogeado, PuntoVentaActual, row.id);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }

        }

        private void reposEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var grdvDetalle = (GridView)gridControl1.FocusedView;
            var row = (dsFactCotizacion.ListaCotizacionesRow)grdvDetalle.GetFocusedDataRow();

            DialogResult r = CajaDialogo.Pregunta("Desea eliminar esta Cotizacion?");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;


            if (row.id > 0)
            {
                bool Proceder = false;
                switch (row.id_estado)
                {
                    case 1:
                        Proceder = true;
                        break;

                    case 2:
                        Proceder = false;
                        

                        break;
                    default:
                        break;
                }


                if (Proceder)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_cotizacion_eliminar", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_h", row.id);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        LoadData();
                    }

                    catch (Exception EX)
                    {
                        CajaDialogo.Error(EX.Message);
                    }
                }
                else
                {
                    CajaDialogo.Error("No se puede eliminar una Cotizacion Cerrada!");
                    return;
                }


            }
        }

        private void reposPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var grdvDetalle = (GridView)gridControl1.FocusedView;
            var row = (dsFactCotizacion.ListaCotizacionesRow)grdvDetalle.GetFocusedDataRow();

            if(row.id > 0)
            {

                xrptCotizacion report = new xrptCotizacion(row.id);
                //subRptCotiz subRpt = new subRptCotiz();
                //subRpt.Parameters["Id_cotizacion"].Value = row.id;
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool reportPrint = new ReportPrintTool(report);
                reportPrint.ShowPreview();
            }
            
        }

        private void cmdChangeVendedor_Click(object sender, EventArgs e)
        {
            frmLoginVendedores frmLoginVend = new frmLoginVendedores();
            if (frmLoginVend.ShowDialog() == DialogResult.OK)
            {
                txtAsesorVendedor.Text = frmLoginVend.CodigoVendedor + " - " + frmLoginVend.NombreVendedor;
                VendedorActual = frmLoginVend.Vendedor_;
                this.UsuarioLogeado = new UserLogin();
                if (UsuarioLogeado.RecuperarRegistro(VendedorActual.Id))
                {
                    cmdRefreshDisponibles_Click(sender, e);
                }
            }
            cmdRefreshDisponibles_Click(sender, e);
        }

        private void cmdVistaPrevia_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsFactCotizacion.home_cotizacionesRow)gridView.GetFocusedDataRow();

            if (!row.IsidNull())
            {
                rptCotizacionPreFactura report = new rptCotizacionPreFactura(row.id);
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(report);
                report.ShowPrintMarginsWarning = false;

                printReport.ShowPreviewDialog();
            }
        }

        private void cmdNuevaCotizacion_Click(object sender, EventArgs e)
        {
            frmCotizacionesCRUD frm = new frmCotizacionesCRUD(this.UsuarioLogeado, this.PuntoVentaActual, VendedorActual);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent; 
            }
            frm.Show();
        }
    }
}