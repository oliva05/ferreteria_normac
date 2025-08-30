using ACS.Classes;
using DevExpress.Charts.Native;
using DevExpress.Pdf.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using DocumentFormat.OpenXml.Wordprocessing;
using JAGUAR_PRO.Calidad.LoteConfConsumo;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.RecuentoInventario;
using JAGUAR_PRO.TransaccionesPT;
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

namespace JAGUAR_PRO.LogisticaJaguar.RecuentoInventario
{
    public partial class frmRecuentoInventarioDetalle : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        PDV PuntoVentaActual;
        bool hayUnicoRegistro = false;
        DataOperations dp = new DataOperations();
        public frmRecuentoInventarioDetalle(UserLogin userLogin,PDV puntoVentaActual)
        {
            InitializeComponent();
            PuntoVentaActual = puntoVentaActual;
            UsuarioLogeado = userLogin;
            dtFechaDocumento.EditValue = dp.dNow();
            txtUsuario.Text = UsuarioLogeado.Nombre;
            LoadAlmacenes();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;  // o FixedSingle
            this.MaximizeBox = false;
        }

        private void gleAlmacen_EditValueChanged(object sender, EventArgs e)
        {
            int id_bodega = Convert.ToInt32(gleAlmacen.EditValue);
            if (id_bodega != 0)
            {
                LoadInvAlmacenes(id_bodega);
                btnAddPT.Enabled = true;
                dsRecuento1.productos_conteo.Clear(); // Limpiar el DataTable antes de cargar nuevos datos
            }
        }
        private void LoadAlmacenes()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[spObtenerBodegasActivas]", con);
                cmd.CommandType = CommandType.StoredProcedure;

                dsRecepcionMP1.bodegas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMP1.bodegas);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadInvAlmacenes(int id_bodega)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_pt_inventario_by_almacen_by_recuento]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_almacen", id_bodega);
                dsRecuento1.seleccion_producots.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecuento1.seleccion_producots);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(gleAlmacen.Text))
            {
                int id_bodeg_origen = Convert.ToInt32(gleAlmacen.EditValue);

                var existentes = new HashSet<string>(
                    dsRecuento1.productos_conteo.AsEnumerable()
                    .Select(r => $"{r.Field<string>("code_pt")}|{r.Field<int>("id_bodega")}")
                );

                foreach (var fila in dsRecuento1.seleccion_producots.AsEnumerable().Where(r => r.Field<bool>("seleccion")))
                {
                    string clave = $"{fila.Field<string>("code_pt")}|{fila.Field<int>("id_bodega")}";

                    if (!existentes.Contains(clave))
                    {
                        var newRow = dsRecuento1.productos_conteo.Newproductos_conteoRow();

                        newRow.id_pt = fila.id_pt;
                        newRow.code_pt = fila.code_pt;
                        newRow.productName = fila.productName;
                        newRow.id_bodega = id_bodeg_origen;
                        newRow.bodega = gleAlmacen.Text;
                        newRow.code_refe = fila.code_refe;
                        newRow.existencia = fila.existencia;

                        dsRecuento1.productos_conteo.Addproductos_conteoRow(newRow);
                        existentes.Add(clave); // añadir para evitar duplicados

                        //dsRecuento1.productos_conteo.ImportRow(fila); // o clonar como necesites
                        //existentes.Add(clave); // añadir para evitar duplicados
                    }
                }

                chkAll.Checked = false; 
            }

            
        }

        private void cmdRecargar_Click(object sender, EventArgs e)
        {
            if (grdvProductosConteo.RowCount == 0)
            {
                CajaDialogo.Error("No hay productos en el recuento.");
                return;
            }

            SplashScreenManager.ShowDefaultWaitForm("Procesando", "Guardando recuento...");

            DataTable dtDetalle = new DataTable();
            dtDetalle.Columns.Add("id_pt", typeof(int));
            dtDetalle.Columns.Add("cantidad_sistema", typeof(decimal));
            dtDetalle.Columns.Add("id_bodega", typeof(int));

            foreach (dsRecuento.productos_conteoRow row in dsRecuento1.productos_conteo.Rows)
            {
                dtDetalle.Rows.Add(row.id_pt,
                                   Convert.ToDecimal(row.existencia),
                                   Convert.ToInt32(gleAlmacen.EditValue)
                    );

            }

            SqlTransaction transaction = null;

            SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            bool Guardar = false;

            try
            {
                conn.Open();
                transaction = conn.BeginTransaction("Transaction Order");

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "[sp_recuento_insert_h]";
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario_creador", UsuarioLogeado.Id);
                cmd.Parameters.AddWithValue("@puntoVentaId", PuntoVentaActual.ID);
                cmd.Parameters.AddWithValue("@fecha_recuento", Convert.ToDateTime(dtFechaDocumento.EditValue));
                cmd.Parameters.AddWithValue("@idBodega", Convert.ToInt32(gleAlmacen.EditValue));

                int id_header = Convert.ToInt32(cmd.ExecuteScalar());

                SqlCommand cmdDetalle = conn.CreateCommand();
                cmdDetalle.CommandText = "[sp_recuento_insert_detalle]";
                cmdDetalle.Connection = conn;
                cmdDetalle.Transaction = transaction;
                cmdDetalle.CommandType = CommandType.StoredProcedure;
                cmdDetalle.Parameters.AddWithValue("@id_recuento", id_header);
                
                SqlParameter tvpParam = cmdDetalle.Parameters.AddWithValue("@Detalles", dtDetalle);
                tvpParam.SqlDbType = SqlDbType.Structured;
                tvpParam.TypeName = "dbo.RecuentoDetalleType";

                cmdDetalle.ExecuteNonQuery();
                transaction.Commit();
                Guardar = true;

            }
            catch (Exception ec)
            {
                transaction.Rollback();
                CajaDialogo.Error(ec.Message);
                Guardar = false;
            }
            finally 
            {
                conn.Close();
                if (SplashScreenManager.Default != null && SplashScreenManager.Default.IsSplashFormVisible)
                    SplashScreenManager.CloseDefaultWaitForm();
            }

            if (Guardar)
            {
                CajaDialogo.Information("Recuento Guardado!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            var gridView = (GridView)grdSelectProductos.FocusedView;
            int conta = dsRecuento1.seleccion_producots.Count;
            //int filtered = 0;
            //string ids = "";

            for (int i = 0; i < conta; i++)
            {
                dsRecuento.seleccion_producotsRow row = (dsRecuento.seleccion_producotsRow)gridView.GetDataRow(i);
                int r = gridView.GetVisibleRowHandle(i);
                if (r >= 0)
                {
                    //filtered++;
                    if (row != null)
                    {
                        row.seleccion = chkAll.Checked;
                        //ids+= ", "+ row.id;
                    }
                }
                else
                {
                    if (row != null)
                        row.seleccion = false;
                }
            }

        }

        private void reposDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView1 = (GridView)grdProductosConteo.FocusedView;
            //var row = (dsRecuento.productos_conteoRow)gridView1.GetFocusedDataRow();

            try
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                dsRecuento1.AcceptChanges();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAddPT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gleAlmacen.Text))
                return;


            frmSearchItems frm = new frmSearchItems();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataRow dr = dsRecuento1.productos_conteo.NewRow();
                dr[0] = frm.ItemSeleccionado.id;
                dr[1] = frm.ItemSeleccionado.ItemName;
                dr[2] = Convert.ToInt32(gleAlmacen.EditValue);
                dr[3] = Convert.ToString(gleAlmacen.Text);
                ProductoTerminado pt = new ProductoTerminado();
                pt.Recuperar_producto(frm.ItemSeleccionado.id);
                dr[4] = pt.GetExistenciaByAlmacen(frm.ItemSeleccionado.id, Convert.ToInt32(gleAlmacen.EditValue));//Existencia
                dr[5] = frm.ItemSeleccionado.ItemCode;//code_pt
                dr[6] = pt.Codig_Referencia;//code_refe
                dsRecuento1.productos_conteo.Rows.Add(dr);
                dsRecuento1.productos_conteo.AcceptChanges();

                grdvSelectProductos.ActiveFilter.Clear();
                grdvSelectProductos.FocusedRowHandle = GridControl.AutoFilterRowHandle;
                grdvSelectProductos.FocusedColumn = grdvSelectProductos.VisibleColumns[0];
                grdvSelectProductos.ShowEditor();
                grdvSelectProductos.FocusedColumn = grdvSelectProductos.Columns["code_pt"];

            }

        }

        private void grdvSelectProductos_ColumnFilterChanged(object sender, EventArgs e)
        {
            
            if (grdvSelectProductos.RowCount == 1)
            {
                hayUnicoRegistro = true;
            }
            else
            {
                hayUnicoRegistro = false;
            }



        }

        private void grdSelectProductos_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter && hayUnicoRegistro)
            {
                int rowHanle = grdvSelectProductos.GetVisibleRowHandle(0);
                if (rowHanle >= 0) 
                {
                    grdvSelectProductos.SetRowCellValue(rowHanle, "seleccion", true);
                }

                //btnRight.PerformClick();
                btnRight_Click(sender, e);

                e.Handled = true; // Evitar comportamiento por defecto
            }
        }
    }
}