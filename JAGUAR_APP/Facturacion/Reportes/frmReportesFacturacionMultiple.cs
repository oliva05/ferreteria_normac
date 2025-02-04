using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Mantenimientos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_APP.Facturacion.Reportes
{
    public partial class frmReportesFacturacionMultiple : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        PDV puntoVentaActual = new PDV();
        DataOperations dp;
        int IdReporte;

        public frmReportesFacturacionMultiple(UserLogin pUsuario, PDV pPuntoVentaActual)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuario;
            puntoVentaActual = pPuntoVentaActual;
            dp = new DataOperations();
            LoadReportsList();
            InicializeParametersDates();
            LoadPuntosVenta();
        }

        private void LoadPuntosVenta()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_reportes_ventas_puntos_venta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReporte1.puntos_venta.Clear();
                adat.Fill(dsReporte1.puntos_venta);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void InicializeParametersDates()
        {
            dtDesdePage1.EditValue = dtHastaPage1.EditValue =
            dtDesdePage3.EditValue = dtHastaPage3.EditValue = 
            dtHastaPage2.EditValue = dtDesdePage4.EditValue = 
            dtHastaPage4.EditValue = dtDesdePage5.EditValue =
            dtHastaPage5.EditValue = dtDesdePage6.EditValue =
            dtHastaPage6.EditValue = dtDesdePage7.EditValue =
            dtHastaPage7.EditValue = dtDesdePage8.EditValue = 
            dtHastaPage8.EditValue = dp.NowSetDateTime();

            int anioactual = dp.NowSetDateTime().Year;
            dtDesdePage2.EditValue = new DateTime(anioactual,1,1);
        }

        private void LoadReportsList()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_lista_reportes_facturacion_core", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReporte1.reportes_lista.Clear();
                adat.Fill(dsReporte1.reportes_lista);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void gleCliente_EditValueChanged(object sender, EventArgs e)
        {
            IdReporte = dp.ValidateNumberInt32(gleCliente.EditValue);
            if(IdReporte > 0)
            {
                //frmReportesFacturacionParametros frm = new frmReportesFacturacionParametros(idReporte);
                //if(frm.ShowDialog() == DialogResult.OK)
                //{

                //}
                switch (IdReporte)
                {
                    case 1:
                        navigationFrame1.SelectedPage = navigationPage1;
                        break;
                    case 2:
                        navigationFrame1.SelectedPage = navigationPage2;
                        break;
                    case 3:
                        navigationFrame1.SelectedPage = navigationPage3;
                        break;
                    case 4:
                        navigationFrame1.SelectedPage = navigationPage4;
                        break;
                    case 5:
                        navigationFrame1.SelectedPage = navigationPage5;
                        break;
                    case 6:
                        navigationFrame1.SelectedPage = navigationPage6;
                        glePuntoVenta6.EditValue = 0;
                        break;
                    case 7:
                        navigationFrame1.SelectedPage = navigationPage7;
                        glePuntoVenta6.EditValue = 0;
                        break;
                    case 8:
                        navigationFrame1.SelectedPage = navigationPage8;
                        glePuntoVenta6.EditValue = 0;
                        break;
                    default:
                        //this.DialogResult = DialogResult.Cancel;
                        //this.Close();
                        break;
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (IdReporte > 0)
            {
                switch (IdReporte)
                {
                    case 1://Libro de Ventas
                        if (dsReporte1.Libro_de_Ventas.Count <= 0)
                        {
                            CajaDialogo.Error("No se puede exportar datos ya que no se han cargado registros en el reporte!");
                            return;
                        }
                        try
                        {
                            SaveFileDialog dialog = new SaveFileDialog();
                            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                            dialog.FilterIndex = 0;
                            string path = "Libro de Ventas";

                            if (dialog.ShowDialog() == DialogResult.OK)
                            {
                                path = dialog.FileName;
                                (gridControl1.MainView as GridView).OptionsPrint.PrintHeader = true;
                                XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                                advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                                advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                                advOptions.SheetName = "Detalle Ventas";
                                gridControl1.ExportToXlsx(path, advOptions);
                                Process.Start(path);
                            }
                        }
                        catch (Exception ex)
                        {
                            CajaDialogo.Error(ex.Message);
                        }
                        break;
                    case 2://Ventas mensuales por punto de ventas
                        if(dsReporte1.Ventas_mensuales.Count <= 0)
                        {
                            CajaDialogo.Error("No se puede exportar datos ya que no se han cargado registros en el reporte!");
                            return;
                        }

                        try
                        {
                            SaveFileDialog dialog = new SaveFileDialog();
                            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                            dialog.FilterIndex = 0;
                            string path = "Ventas Mensuales";

                            if (dialog.ShowDialog() == DialogResult.OK)
                            {
                                path = dialog.FileName;
                                (gridControl3.MainView as GridView).OptionsPrint.PrintHeader = true;
                                XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                                advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                                advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                                advOptions.SheetName = "Detalle Ventas Mensuales";
                                gridControl3.ExportToXlsx(path, advOptions);
                                Process.Start(path);
                            }
                        }
                        catch (Exception ex)
                        {
                            CajaDialogo.Error(ex.Message);
                        }
                        break;
                    case 3://Ventas diarias por punto de ventas
                        if (dsReporte1.Ventas_diarias.Count <= 0)
                        {
                            CajaDialogo.Error("No se puede exportar datos ya que no se han cargado registros en el reporte!");
                            return;
                        }
                        try
                        {
                            SaveFileDialog dialog = new SaveFileDialog();
                            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                            dialog.FilterIndex = 0;
                            string path = "Ventas Diarias";

                            if (dialog.ShowDialog() == DialogResult.OK)
                            {
                                path = dialog.FileName;
                                (gridControl2.MainView as GridView).OptionsPrint.PrintHeader = true;
                                XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                                advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                                advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                                advOptions.SheetName = "Detalle Ventas Diarias";
                                gridControl2.ExportToXlsx(path, advOptions);
                                Process.Start(path);
                            }
                        }
                        catch (Exception ex)
                        {
                            CajaDialogo.Error(ex.Message);
                        }
                        break;
                    case 4://Ventas por producto
                        if (dsReporte1.ventas_por_producto.Count <= 0)
                        {
                            CajaDialogo.Error("No se puede exportar datos ya que no se han cargado registros en el reporte!");
                            return;
                        }
                        try
                        {
                            SaveFileDialog dialog = new SaveFileDialog();
                            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                            dialog.FilterIndex = 0;
                            string path = "Ventas por Producto";

                            if (dialog.ShowDialog() == DialogResult.OK)
                            {
                                path = dialog.FileName;
                                (gridControl4.MainView as GridView).OptionsPrint.PrintHeader = true;
                                XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                                advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                                advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                                advOptions.SheetName = "Detalle Ventas Producto";
                                gridControl4.ExportToXlsx(path, advOptions);
                                Process.Start(path);
                            }
                        }
                        catch (Exception ex)
                        {
                            CajaDialogo.Error(ex.Message);
                        }
                        break;
                    case 5://Ventas por Cliente
                        if (dsReporte1.ventas_por_cliente.Count <= 0)
                        {
                            CajaDialogo.Error("No se puede exportar datos ya que no se han cargado registros en el reporte!");
                            return;
                        }
                        try
                        {
                            SaveFileDialog dialog = new SaveFileDialog();
                            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                            dialog.FilterIndex = 0;
                            string path = "Ventas por Cliente";

                            if (dialog.ShowDialog() == DialogResult.OK)
                            {
                                path = dialog.FileName;
                                (gridControl5.MainView as GridView).OptionsPrint.PrintHeader = true;
                                XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                                advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                                advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                                advOptions.SheetName = "Detalle Ventas Cliente";
                                gridControl5.ExportToXlsx(path, advOptions);
                                Process.Start(path);
                            }
                        }
                        catch (Exception ex)
                        {
                            CajaDialogo.Error(ex.Message);
                        }
                        break;
                    case 6://Ventas gravadas
                        if (dsReporte1.ventas_gravadas.Count <= 0)
                        {
                            CajaDialogo.Error("No se puede exportar datos ya que no se han cargado registros en el reporte!");
                            return;
                        }
                        try
                        {
                            SaveFileDialog dialog = new SaveFileDialog();
                            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                            dialog.FilterIndex = 0;
                            string path = "Ventas por Cliente";

                            if (dialog.ShowDialog() == DialogResult.OK)
                            {
                                path = dialog.FileName;
                                (gridControl6.MainView as GridView).OptionsPrint.PrintHeader = true;
                                XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                                advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                                advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                                advOptions.SheetName = "Detalle Ventas Cliente";
                                gridControl6.ExportToXlsx(path, advOptions);
                                Process.Start(path);
                            }
                        }
                        catch (Exception ex)
                        {
                            CajaDialogo.Error(ex.Message);
                        }
                        break;
                    case 7://Ventas de Productos por mes
                        if (gridControl7.Views[0].RowCount <= 0)
                        {
                            CajaDialogo.Error("No se puede exportar datos ya que no se han cargado registros en el reporte!");
                            return;
                        }
                        try
                        {
                            SaveFileDialog dialog = new SaveFileDialog();
                            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                            dialog.FilterIndex = 0;
                            string path = "Ventas por Producto";

                            if (dialog.ShowDialog() == DialogResult.OK)
                            {
                                path = dialog.FileName;
                                (gridControl7.MainView as GridView).OptionsPrint.PrintHeader = true;
                                XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                                advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                                advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                                advOptions.SheetName = "Ventas por Producto";
                                gridControl7.ExportToXlsx(path, advOptions);
                                Process.Start(path);
                            }
                        }
                        catch (Exception ex)
                        {
                            CajaDialogo.Error(ex.Message);
                        }
                        break;
                    case 8://Ventas por Producto y Cliente
                        if (gridControl8.Views[0].RowCount <= 0)
                        {
                            CajaDialogo.Error("No se puede exportar datos ya que no se han cargado registros en el reporte!");
                            return;
                        }
                        try
                        {
                            SaveFileDialog dialog = new SaveFileDialog();
                            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                            dialog.FilterIndex = 0;
                            string path = "Ventas Producto y Cliente";

                            if (dialog.ShowDialog() == DialogResult.OK)
                            {
                                path = dialog.FileName;
                                (gridControl8.MainView as GridView).OptionsPrint.PrintHeader = true;
                                XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                                advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                                advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                                advOptions.SheetName = "Ventas Producto y Cliente";
                                gridControl8.ExportToXlsx(path, advOptions);
                                Process.Start(path);
                            }
                        }
                        catch (Exception ex)
                        {
                            CajaDialogo.Error(ex.Message);
                        }
                        break;
                    default:
                        //this.DialogResult = DialogResult.Cancel;
                        //this.Close();
                        break;
                }
            }
        }

        private void btnRefreshPage1_Click(object sender, EventArgs e)
        {
            LoadDatosPage1();
        }

        private void LoadDatosPage1()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_reportes_libro_ventas_resumen", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesdePage1.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHastaPage1.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReporte1.Libro_de_Ventas.Clear();
                adat.Fill(dsReporte1.Libro_de_Ventas);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDatosPage2()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_reporte_ventas_ventas_mensuales_por_punto_venta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesdePage2.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHastaPage2.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReporte1.Ventas_mensuales.Clear();
                adat.Fill(dsReporte1.Ventas_mensuales);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void LoadDatosPage3()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_reporte_ventas_ventas_diarias_por_punto_venta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesdePage3.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHastaPage3.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReporte1.Ventas_diarias.Clear();
                adat.Fill(dsReporte1.Ventas_diarias);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        

        private void LoadDatosPage4()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_reportes_ventas_venta_por_producto_por_punto_venta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesdePage4.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHastaPage4.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReporte1.ventas_por_producto.Clear();
                adat.Fill(dsReporte1.ventas_por_producto);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void LoadDatosPage5()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_reportes_ventas_ventas_por_cliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesdePage5.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHastaPage5.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReporte1.ventas_por_cliente.Clear();
                adat.Fill(dsReporte1.ventas_por_cliente);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDatosPage6()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[sp_get_reportes_ventas_resumen_isv_gravado_v2]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesdePage6.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHastaPage6.EditValue);
                cmd.Parameters.AddWithValue("@id_punto_venta", glePuntoVenta6.EditValue);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReporte1.ventas_gravadas.Clear();
                adat.Fill(dsReporte1.ventas_gravadas);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnRefreshPage3_Click(object sender, EventArgs e)
        {
            LoadDatosPage3();
        }

        private void btnRefreshPage2_Click(object sender, EventArgs e)
        {
            LoadDatosPage2();
        }

        private void btnRefreshPage4_Click(object sender, EventArgs e)
        {
            LoadDatosPage4();
        }

        private void btnRefreshPage5_Click(object sender, EventArgs e)
        {
            LoadDatosPage5();
        }

        private void btnRefreshPage6_Click(object sender, EventArgs e)
        {
            LoadDatosPage6();
        }

        private void btnRefreshPage7_Click(object sender, EventArgs e)
        {
            LoadDatosPage7();
        }

        private void btnRefreshPage8_Click(object sender, EventArgs e)
        {
            LoadDatosPage8();
        }
        private void LoadDatosPage7()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[sp_get_reportes_ventas_ventas_por_producto_por_mes]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesdePage7.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHastaPage7.EditValue);
                int id_punto_venta = dp.ValidateNumberInt32(glePuntoVenta7.EditValue);
                cmd.Parameters.AddWithValue("@id_punto_venta", id_punto_venta);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                //dsReporte1.ventas_gravadas.Clear();
                //adat.Fill(dsReporte1.ventas_gravadas);

                // Create and fill a dataset. 
                DataSet sourceDataSet = new DataSet();
                adat.Fill(sourceDataSet);
                gridControl7.DataSource = null;
                // Specify the data source for the grid control. 
                gridControl7.DataSource = sourceDataSet.Tables[0];
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void LoadDatosPage8()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[sp_get_reportes_ventas_ventas_por_cliente_y_producto_por_mes]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesdePage8.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHastaPage8.EditValue);
                int id_punto_venta = dp.ValidateNumberInt32(glePuntoVenta8.EditValue);
                cmd.Parameters.AddWithValue("@id_punto_venta", id_punto_venta);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                //dsReporte1.ventas_gravadas.Clear();
                //adat.Fill(dsReporte1.ventas_gravadas);

                // Create and fill a dataset. 
                DataSet sourceDataSet = new DataSet();
                adat.Fill(sourceDataSet);

                gridControl8.DataSource = null;
                // Specify the data source for the grid control. 
                gridControl8.DataSource = sourceDataSet.Tables[0];
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}