using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_PRO.Facturacion.Reportes.Reportes_de_Ventas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO.Mantenimientos.Comisiones
{
    public partial class frmListaVendedores : DevExpress.XtraEditors.XtraForm
    {
        public class ItemBusquedaLocal
        {
            public int id;
            public string lote;
            public int idmp;
            public string ItemCode;
            public string ItemName;
            public ItemBusquedaLocal()
            {
                id = 0;
                ItemCode = "";
                ItemName = "";
            }
        }

        public ItemBusquedaLocal ItemSeleccionado;
        int IdComisionH;
        public frmListaVendedores(int pIdH, ArrayList pListaVendedoresActual)
        {
            InitializeComponent();
            IdComisionH = pIdH;
            ItemSeleccionado = new ItemBusquedaLocal();
            LoadVendedores();
            foreach(int id_v in pListaVendedoresActual)
            {
                
                // Buscar las filas que coincidan con el ID
                DataRow[] filas = dsComisiones1.vendedores_lista.Select($"id = {id_v}");

                // Eliminar cada fila encontrada
                foreach (DataRow fila in filas)
                {
                    dsComisiones1.vendedores_lista.Rows.Remove(fila);
                }
            }
        }
        

        private void LoadVendedores()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_lista_vendedores_habilitados]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", this.IdComisionH);
                //cmd.Parameters.AddWithValue("@fecha_desde", dtDesde.DateTime);
                //cmd.Parameters.AddWithValue("@fecha_hasta", dtHasta.DateTime);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsComisiones1.vendedores_lista.Clear();
                adat.Fill(dsComisiones1.vendedores_lista);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCancelare_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ItemSeleccionado.id > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                CajaDialogo.Error("Es necesario seleccionar un vendedor!");
            }
        }

        private void chk_Seleccionar_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "seleccionar")
            {
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsComisiones.vendedores_listaRow)gridView.GetFocusedDataRow();
                if (Convert.ToBoolean(e.Value))
                {
                    ItemSeleccionado.id = row.id;
                    ItemSeleccionado.ItemCode = row.codigo_vendedor;
                    ItemSeleccionado.ItemName = row.nombre;
                    row.seleccionar = true;
                }

                foreach (dsComisiones.vendedores_listaRow row1 in dsComisiones1.vendedores_lista)
                {
                    if (row1.id != ItemSeleccionado.id)
                        row1.seleccionar = false;
                }
            }
        }
    }
}