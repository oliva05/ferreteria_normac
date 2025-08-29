using ACS.Classes;
using DevExpress.DashboardCommon.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Mantenimientos.ProductoTerminado;
using LOSA.Calidad.LoteConfConsumo;
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
    public partial class frmAddRecepcionCompraVentaUnica : DevExpress.XtraEditors.XtraForm
    {
        int ContadorVuelta = 0;
        bool isUpdating = false; // bandera global en el formulario
        UserLogin UsuarioLogeado;
        public frmAddRecepcionCompraVentaUnica(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            
        }

        private void btnSelecItemCode_Click(object sender, EventArgs e)
        {
            frmSearchDefault frm = new frmSearchDefault(frmSearchDefault.TipoBusqueda.PTParaCrearUsados);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtCodigoPT.Text = frm.ItemSeleccionado.ItemCode;
                txtItemName.Text = frm.ItemSeleccionado.ItemName;
                txtDescripcion.Text = frm.ItemSeleccionado.ItemName;
                txtDescripcion.Focus();
            }

            
        }

        private void btnAddLote_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCodigoPT.Text))
            {
                CajaDialogo.Error("Debe seleccionar codigo padre!");
                btnSelecItemCode.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                CajaDialogo.Error("Debe indicar una descripcion!");
                txtDescripcion.Focus();
                return;
            }

            if (Convert.ToDecimal(txtCosto.EditValue) == 0)
            {
                CajaDialogo.Error("El Valor del Costo debe ser mayor a 0");
                txtCosto.Focus();
                return;
            }

            if (Convert.ToDecimal(txtPrecioVenta.EditValue) == 0)
            {
                CajaDialogo.Error("Debe inidcar el Precio de Venta!");
                txtPrecioVenta.Focus();
                return;
            }

            if (Convert.ToInt32(spinUd.EditValue) <= 0)
            {
                CajaDialogo.Error("Debe indicar cantidad mayor a 0!");
                txtPrecioVenta.Focus();
                return;
            }

            try
            {
                ProductoTerminado pt = new ProductoTerminado();
                if (ContadorVuelta == 0)
                {
                    if (pt.GenerarCodigoPTVentaUnica(txtCodigoPT.Text.Trim()))
                    {
                        int Contador = Convert.ToInt32(spinUd.EditValue);
                        int correlativo = pt.IdSiguiente;
                        pt.Recuperar_productoByBarCodeUsados(txtCodigoPT.Text.Trim());


                        while (Contador > 0)
                        {
                            DataRow dr = dsProductoTerminado1.pt_venta_unica.NewRow();
                            dr[0] = 0;
                            dr[1] = txtDescripcion.Text;
                            dr[2] = txtCodigoPT.Text.Trim();
                            dr[3] = txtCosto.EditValue;
                            dr[4] = txtMargGanancia.EditValue;
                            dr[5] = txtPrecioVenta.EditValue;
                            dr[6] = txtCodigoPT.Text + "B" + "00" + correlativo.ToString();
                            dr[7] = correlativo.ToString();
                            dr[8] = pt.Id_Almacen_standard == 0 ? 2 : pt.Id_Almacen_standard;
                            dr[9] = pt.Id;
                            dsProductoTerminado1.pt_venta_unica.Rows.Add(dr);
                            dsProductoTerminado1.pt_venta_unica.AcceptChanges();

                            correlativo++;
                            Contador--;
                        }
                        LimpiarControles();
                        
                    }
                    ContadorVuelta++;
                }
                else
                {
                    int CorrelativoMemoria = dsProductoTerminado1.pt_venta_unica.AsEnumerable()
                    .Where(row => row.Field<string>("itemcode") == txtCodigoPT.Text)
                    .Select(row => row["correlativo"] != DBNull.Value ? Convert.ToInt32(row["correlativo"]) : 0) // Conversión segura
                    .DefaultIfEmpty(0)
                    .Max();

                    int Contador = Convert.ToInt32(spinUd.EditValue);

                    CorrelativoMemoria++;//Obtenemos el ultimo valor del correlativo y le sumamos 1

                    while (Contador > 0)
                    {
                        DataRow dr = dsProductoTerminado1.pt_venta_unica.NewRow();
                        dr[0] = 0;
                        dr[1] = txtDescripcion.Text;
                        dr[2] = txtCodigoPT.Text.Trim();
                        dr[3] = txtCosto.EditValue;
                        dr[4] = txtMargGanancia.EditValue;
                        dr[5] = txtPrecioVenta.EditValue;
                        dr[6] = txtCodigoPT.Text + "B" + "00" + CorrelativoMemoria.ToString();
                        dr[7] = CorrelativoMemoria.ToString();
                        dr[8] = pt.Id_Almacen_standard;
                        dr[9] = pt.Id;
                        dsProductoTerminado1.pt_venta_unica.Rows.Add(dr);
                        dsProductoTerminado1.pt_venta_unica.AcceptChanges();

                        CorrelativoMemoria++;
                        Contador--;
                    }
                    LimpiarControles();
                }

                
                
                
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LimpiarControles()
        {
            txtCodigoPT.Text = txtItemName.Text = txtDescripcion.Text = string.Empty;
            txtCosto.EditValue = txtMargGanancia.EditValue  = txtPrecioVenta.EditValue = 0.00;
            spinUd.EditValue = 1;
            btnSelecItemCode.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                DialogResult r = CajaDialogo.Pregunta("Esta seguro de cerrar la ventana?");
                if (r == DialogResult.Yes) 
                    this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void txtMargGanancia_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
          
        }

        private void txtMargGanancia_EditValueChanged(object sender, EventArgs e)
        {
            if (isUpdating) return; // evita bucle
            isUpdating = true;

            if (decimal.TryParse(Convert.ToString(txtCosto.EditValue), out decimal costo) &&
                decimal.TryParse(Convert.ToString(txtMargGanancia.EditValue), out decimal margen))
            {
                // Aquí margen es el porcentaje de utilidad (markup sobre costo)
                decimal precioVenta = costo * (1 + margen / 100);
                txtPrecioVenta.EditValue = precioVenta;
            }

            isUpdating = false;

        }

        private void CalcularPrecioVenta()
        {
            if (txtPrecioVenta == null || txtCosto == null || txtMargGanancia == null) return;

            txtPrecioVenta.EditValueChanged -= txtPrecioVenta_EditValueChanged;

            if (decimal.TryParse(Convert.ToString(txtCosto.EditValue), out decimal costo) &&
                decimal.TryParse(Convert.ToString(txtMargGanancia.EditValue), out decimal utilidad))
            {
                decimal precio = costo * (1 + utilidad / 100);
                txtPrecioVenta.EditValue = precio;
            }

            txtPrecioVenta.EditValueChanged += txtPrecioVenta_EditValueChanged;
        }

        private void reposDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView1 = (GridView)gridControl1.FocusedView;
            var row = (dsProductoTerminado.pt_venta_unicaRow)gridView1.GetFocusedDataRow();

            try
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                dsProductoTerminado1.AcceptChanges();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            bool error = false;
            foreach (dsProductoTerminado.pt_venta_unicaRow item in dsProductoTerminado1.pt_venta_unica)
            {
                if (string.IsNullOrEmpty(item.descripcion))
                {
                    CajaDialogo.Error("Debe colocar un nombre, no puede quedar vacio!");
                    error = true;
                    break;
                }

                if (string.IsNullOrEmpty(item.costo.ToString()) || item.costo <= 0)
                {
                    CajaDialogo.Error("Debe agregar un Costo valido!");
                    error = true;
                    break;
                }
            }

            if (error)
                return;


            SqlTransaction transaction = null;
            DataOperations dp = new DataOperations();
            SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            bool Guardar = false;
            List<int> ids = new List<int>();
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction("Transaction Order");

                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "sp_get_insert_pt_venta_unica";
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (dsProductoTerminado.pt_venta_unicaRow row in dsProductoTerminado1.pt_venta_unica.Rows)
                {
                    
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@descripcion",row.descripcion);
                    cmd.Parameters.AddWithValue("@itemcode",row.itemcode);
                    cmd.Parameters.AddWithValue("@costo", row.costo);
                    cmd.Parameters.AddWithValue("@margen",row.margen);
                    cmd.Parameters.AddWithValue("@precio_venta",row.precio_venta);
                    cmd.Parameters.AddWithValue("@barcode",row.barcode);
                    cmd.Parameters.AddWithValue("@correlativo", row.correlativo);
                    cmd.Parameters.AddWithValue("@fecha_ingreso", dp.Now());
                    cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                    if (row.id_bodega == 0)
                        cmd.Parameters.AddWithValue("@id_bodega", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@id_bodega", row.id_bodega);
                    cmd.Parameters.AddWithValue("@id_pt", row.id_pt);

                    ids.Add(Convert.ToInt32(cmd.ExecuteScalar()));
                }
               
                transaction.Commit();
                Guardar = true;
            }
            catch (Exception ec)
            {
                transaction.Rollback();
                CajaDialogo.Error(ec.Message);
                Guardar = false;
            }

            if (Guardar) 
            {
                DialogResult r = CajaDialogo.Pregunta("Guardado con Exito!\nDeseas Imprimir los Codigos de Barra?");
                if (r == DialogResult.Yes)
                {
                    int contador_print = 0;
                    xrptBarCode reportResumen = null;

                    foreach (int item in ids)
                    {
                        ProductoTerminado pt = new ProductoTerminado();
                        pt.RecuperarPTVentaUsados(item);

                        if (contador_print == 0)
                        {
                            reportResumen = new xrptBarCode(pt.Barcode);
                            reportResumen.CreateDocument();
                            contador_print++;
                        }
                        else
                        {
                            xrptBarCode report2 = new xrptBarCode(pt.Barcode);
                            report2.CreateDocument();
                            if (reportResumen != null)
                            {
                                // Add all pages of the second report to the end of the first report.
                                reportResumen.ModifyDocument(x => { x.AddPages(report2.Pages); });
                            }
                        }
                    }

                    if (reportResumen != null)
                    {
                        using (ReportPrintTool printTool = new ReportPrintTool(reportResumen))
                        {
                            printTool.ShowPreviewDialog();
                        }
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();


            }
            


        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCosto.Focus();
            }
        }

        private void txtCosto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMargGanancia.Focus();
            }
        }

        private void txtMargGanancia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                spinUd.Focus();
            }
        }

        private void spinUd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPrecioVenta.Focus();
            }
        }

        private void txtPrecioVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnAddLote.Focus();
            }
        }

        private void frmAddRecepcionCompraVentaUnica_Shown(object sender, EventArgs e)
        {
            btnSelecItemCode.Focus();
        }

        private void txtPrecioVenta_EditValueChanged(object sender, EventArgs e)
        {
            if (isUpdating) return; // evita bucle
            isUpdating = true;

            if (decimal.TryParse(Convert.ToString(txtCosto.EditValue), out decimal costo) &&
                decimal.TryParse(Convert.ToString(txtPrecioVenta.EditValue), out decimal precioVenta))
            {
                if (costo > 0)
                {
                    // Aquí margen se calcula en base a precio (margen real)
                    decimal ganancia = precioVenta - costo;
                    decimal margen = (ganancia / costo) * 100; // markup sobre costo
                    txtMargGanancia.EditValue = margen;
                }
                else
                {
                    txtMargGanancia.EditValue = 0;
                }
            }

            isUpdating = false;
        }
    }
}