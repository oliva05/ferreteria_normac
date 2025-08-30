using ACS.Classes;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSpreadsheet.Commands;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Mantenimientos.ProductoTerminado;
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
    public partial class frmRecepcionCompraVentaUnica : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public frmRecepcionCompraVentaUnica(UserLogin pUserLog)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLog;
            dtDesde.DateTime = dp.Now().AddDays(-30);
            dtHasta.DateTime = dp.Now().AddDays(1);
            LoadaData();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAddRecepcionCompraVentaUnica frm = new frmAddRecepcionCompraVentaUnica(UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadaData();
            }
        }

        private void LoadaData()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_pt_load_ingresos_venta_unica", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsProductoTerminado1.ingreso_pt_venta_unica.Clear();
                adat.Fill(dsProductoTerminado1.ingreso_pt_venta_unica);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void frmRecepcionCompraVentaUnica_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            LoadaData();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd.ExportToXlsx(dialog.FileName);
            }
        }

        private void cmdPrintFromGrid_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grd.FocusedView;
            var row = (dsProductoTerminado.ingreso_pt_venta_unicaRow)gridview.GetFocusedDataRow();

            xrptBarCode report = new xrptBarCode(row.barcode);
            

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                // Send the report to the default printer.
                printTool.ShowPreviewDialog();
            }
        }

        private void cmdVer_Editar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grd.FocusedView;
            var row = (dsProductoTerminado.ingreso_pt_venta_unicaRow)gridview.GetFocusedDataRow();

            if (row != null)
            {
                ProductoUsado ptu = new ProductoUsado();
                ptu.Id = row.id;
                ptu.Descripcion = row.descripcion;
                ptu.Costo = row.costo;
                ptu.Margen = row.margen;
                ptu.PrecioVenta = row.precio_venta;

                frmRecepcionCompraVentaUnicaEdit frm = new frmRecepcionCompraVentaUnicaEdit(UsuarioLogeado, ptu);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    //Cargar de Nuevo a la linea!
                    bool Guardar = false;
                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_update_pt_usado", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@descripcion", frm.ProductoUsado.Descripcion);
                        cmd.Parameters.AddWithValue("@costo", Convert.ToDecimal(frm.ProductoUsado.Costo));
                        cmd.Parameters.AddWithValue("@margen", Convert.ToDecimal(frm.ProductoUsado.Margen));
                        cmd.Parameters.AddWithValue("@precio_venta", Convert.ToDecimal(frm.ProductoUsado.PrecioVenta));
                        cmd.Parameters.AddWithValue("@idUsado", row.id);
                        cmd.ExecuteNonQuery();
                        Guardar = true;
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }

                    if(Guardar)
                    {
                        row.descripcion = frm.ProductoUsado.Descripcion;
                        row.costo = Convert.ToDecimal(frm.ProductoUsado.Costo);
                        row.margen = Convert.ToDecimal(frm.ProductoUsado.Margen);
                        row.precio_venta = Convert.ToDecimal(frm.ProductoUsado.PrecioVenta);
                    }

                }
            }
        }

        private void repostDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Desea eliminar este producto usado.");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            var gridview = (GridView)grd.FocusedView;
            var row = (dsProductoTerminado.ingreso_pt_venta_unicaRow)gridview.GetFocusedDataRow();

            if (row != null)
            {
                try
                {
                    //Antes de Eliminar debo validar si no esta en Pedido!
                    //if (ExisteEnPREFACTURA(row.id))
                    //{
                    //    CajaDialogo.Error("No se puede Eliminar\nEl Producto Usado esta en PreFactura!");
                    //    return;
                    //}

                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_eliminar_pt_usado", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idUsado", row.id);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        LoadaData();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }


                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }

        }

        private bool ExisteEnPREFACTURA(int id)
        {
            bool Existe = true;



            return Existe;
        }
    }
}