using ACS.Classes;
using ClosedXML.Excel;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.DocumentFormats.Xlsb;
using JAGUAR_PRO.Clases;
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

namespace JAGUAR_PRO.Mantenimientos.ProductoTerminado
{
    public partial class frmPTCargarMasivo : DevExpress.XtraEditors.XtraForm
    {
        public frmPTCargarMasivo()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    FTP_Class ftp = new FTP_Class();
            //    DataOperations dp = new DataOperations();
            //    saveFileDialog1.FileName = "NF-01-ImportarProductoTerminado.xlsx";

            //    // Establece el filtro para mostrar todos los tipos de archivos
            //    saveFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx";

            //    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        using (var workbook = new XLWorkbook())
            //        {
            //            var ws = workbook.Worksheets.Add("Productos");

            //            for (int col = 0; col < miDataTable.Columns.Count; col++)
            //            {
            //                ws.Cell(1, col + 1).Value = miDataTable.Columns[col].ColumnName;
            //            }

            //            workbook.SaveAs(saveFileDialog1.FileName);
            //            MessageBox.Show("Plantilla descargada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }    

            //    }


            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //    throw;
            //}
        }

        private void btnLoadTemplate_Click(object sender, EventArgs e)
        {
            using (openFileDialog1)
            {
                openFileDialog1.Filter = "Excel Workbook (*.xlsx)|*.xlsx";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var dt = new DataTable();

                    using (var workbook = new XLWorkbook(openFileDialog1.FileName))
                    {
                        var ws = workbook.Worksheet(1); // Primer hoja
                        bool encabezado = true;

                        foreach (var row in ws.RowsUsed())
                        {
                            if (encabezado)
                            {
                                foreach (var cell in row.Cells())
                                    dt.Columns.Add(cell.Value.ToString());

                                encabezado = false;
                            }
                            else
                            {
                                dt.Rows.Add();
                                for (int i = 0; i < dt.Columns.Count; i++)
                                    dt.Rows[dt.Rows.Count - 1][i] = row.Cell(i + 1).Value.ToString();
                            }
                        }

                        // Asignar al DataTable del GridControl
                        dsProductoTerminado1.lista_pt_temporal.Clear();
                        foreach (DataRow row in dt.Rows)
                        {
                            dsProductoTerminado1.lista_pt_temporal.ImportRow(row);
                        }

                        gridControl1.RefreshDataSource(); // Forzar refresco si es necesario
                    }

                }
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                CajaDialogo.Error("No se a cargado Data!");
                return;
            }

            string UltimoCOidgoBarraIngresado = string.Empty;
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    conn.Open();

                    foreach (dsProductoTerminado.lista_pt_temporalRow row in dsProductoTerminado1.lista_pt_temporal.Rows) // reemplaza "tuDataTable" con el nombre real de tu DataTable
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_pt_cargar_masiva", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@codigo_barra", row.CODIGO);
                            cmd.Parameters.AddWithValue("@descripcion", row.DESCRIPCION);
                            cmd.Parameters.AddWithValue("@grupo", row.GRUPO);
                            cmd.Parameters.AddWithValue("@precio_unit", row.PRECIO_UND);
                            cmd.Parameters.AddWithValue("@existencia", row.INVENTARIO);
                            UltimoCOidgoBarraIngresado = Convert.ToString(cmd.ExecuteScalar());

                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(UltimoCOidgoBarraIngresado + ex.Message);
            }

            CajaDialogo.Information("Items Agregados");

        }
    }
}