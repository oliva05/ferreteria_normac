using ACS.Classes;
using DevExpress.Charts.Native;
using DevExpress.Pdf.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using DocumentFormat.OpenXml.Wordprocessing;
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

                foreach (dsRecuento.productos_conteoRow row in dsRecuento1.productos_conteo.Rows)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "sp_recuento_insert_detalle";
                    cmd.Connection = conn;
                    cmd.Transaction = transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_recuento", id_header);
                    cmd.Parameters.AddWithValue("@id_pt", row.id_pt);
                    cmd.Parameters.AddWithValue("@cantidad_sistema", Convert.ToDecimal(row.existencia));
                    cmd.Parameters.AddWithValue("@id_bodega", Convert.ToInt32(row.id_bodega));
                    cmd.ExecuteNonQuery();
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
    }
}