using ACS.Classes;
using DevExpress.Xpo;
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
    public partial class frmMainMarcas : DevExpress.XtraEditors.XtraForm
    {

        UserLogin UsuarioLogeado;

        public frmMainMarcas(UserLogin user)
        {
            InitializeComponent();
       
            UsuarioLogeado = user;
            tsAll.IsOn = true;

            LoadData();
  
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_pt_get_marcas", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@estado", tsAll.IsOn);
                dsProductoTerminado1.lista_marcas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProductoTerminado1.lista_marcas);
                connection.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsAll_Toggled(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCRUD_Marca frm = new frmCRUD_Marca(frmCRUD_Marca.TipoOperacion.Nuevo, UsuarioLogeado, 0);
            if (frm.ShowDialog() ==DialogResult.OK)
            {
                LoadData();
            }
        }

        private void reposEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsProductoTerminado.lista_marcasRow)gridview.GetFocusedDataRow();

            if (row != null)
            {
                frmCRUD_Marca frm = new frmCRUD_Marca(frmCRUD_Marca.TipoOperacion.Editar, UsuarioLogeado, row.id_marca);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }

        }
    }
}