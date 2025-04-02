using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmMainPTCategoria : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        public frmMainPTCategoria(UserLogin pUserLog)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLog;
            loaddate();
        }
        private void loaddate()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_pt_get_categoria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ver_todos", tggViewFilter.IsOn);
                dsProductoTerminado1.categoria.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProductoTerminado1.categoria);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tggViewFilter_Toggled(object sender, EventArgs e)
        {
            loaddate();
        }

        private void cmdEditar2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridDetalleProductosCRUD.FocusedView;
            var row = (dsProductoTerminado.categoriaRow)gridview.GetFocusedDataRow();

            frmCRUD_PTCategoria frm = new frmCRUD_PTCategoria(frmCRUD_PTCategoria.Operacion.Update, row.id, row.id_familia, row.descripcion, row.codigo, row.enable);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                loaddate();
            }
        }

        private void cmdNuevoPT_Click(object sender, EventArgs e)
        {
            frmCRUD_PTCategoria frm = new frmCRUD_PTCategoria(frmCRUD_PTCategoria.Operacion.Insert, 0, 0, string.Empty, string.Empty, true);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                loaddate();
            }
        }
    }
}