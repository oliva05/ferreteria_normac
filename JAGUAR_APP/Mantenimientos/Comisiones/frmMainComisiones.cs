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
using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.Layout;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.LogisticaJaguar;

namespace JAGUAR_PRO.Mantenimientos.Comisiones
{
    public partial class frmMainComisiones : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmMainComisiones(UserLogin userLogin)
        {
            InitializeComponent();
            UsuarioLogeado= userLogin;
            toggleSwitch1.IsOn = false;
            CargarDatos();
        }

        private void cmdCargarDatos_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public void CargarDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

                dsComisiones1.lista_planes_comisiones.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("sp_comisiones_get_lista_by_active", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@activa", SqlDbType.Int).Value = toggleSwitch1.IsOn;
                    da.Fill(dsComisiones1.lista_planes_comisiones);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmCRUDComisionesDetalle frm = new frmCRUDComisionesDetalle(frmCRUDComisionesDetalle.TipoOperacion.Nuevo,UsuarioLogeado, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void reposEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsComisiones.lista_planes_comisionesRow)gridview.GetFocusedDataRow();

            frmCRUDComisionesDetalle frm = new frmCRUDComisionesDetalle(frmCRUDComisionesDetalle.TipoOperacion.Editar, UsuarioLogeado, row.id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }
    }
}