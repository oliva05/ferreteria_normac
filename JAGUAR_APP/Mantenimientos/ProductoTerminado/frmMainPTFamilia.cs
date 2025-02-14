using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.LogisticaJaguar;
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
    public partial class frmMainPTFamilia : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;

        public frmMainPTFamilia(UserLogin userLogin)
        {
            InitializeComponent();
            tggViewFilter.IsOn = false;
            loaddate();
        }

        private void loaddate()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_pt_get_familia", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ver_todos", tggViewFilter.IsOn);
                dsProductoTerminado1.familia.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProductoTerminado1.familia);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdEditar2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridDetalleProductosCRUD.FocusedView;
            var row = (dsProductoTerminado.familiaRow)gridview.GetFocusedDataRow();

            frmCRUD_PTFamilia frm = new frmCRUD_PTFamilia(frmCRUD_PTFamilia.Operacion.Update, row.id, row.descripcion, row.enable , row.codigo);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                loaddate();
            }

        }

        private void cmdNuevoPT_Click(object sender, EventArgs e)
        {
            frmCRUD_PTFamilia frm = new frmCRUD_PTFamilia(frmCRUD_PTFamilia.Operacion.Insert, 0, string.Empty, true, string.Empty);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                loaddate();
            }
        }

        private void tggViewFilter_Toggled(object sender, EventArgs e)
        {
            loaddate();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}