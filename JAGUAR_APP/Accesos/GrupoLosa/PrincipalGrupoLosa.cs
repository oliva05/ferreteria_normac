using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace JAGUAR_PRO.Accesos.GrupoLosa
{
    public partial class PrincipalGrupoLosa : DevExpress.XtraEditors.XtraForm
    {
        #region Variables Constantes Propiedades
        private SqlConnection sqlConnection;
        private  SqlCommand sqlCommand;
        private  SqlDataReader sqlDataReader;
        private DataTable dataTable;
        //private const string connectionString = @"Server=DESKTOP-4Q0PPMK\SQLEXPRESS;Database=ACS;User Id=sa;Password=Sap5erver;";
        DataOperations dp = new DataOperations();
        int IdGrupo = 0;
        #endregion
        public PrincipalGrupoLosa()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            dataTable = new DataTable();
            this.RefrescarDatos();
        }
        #region Metodos
        private void RefrescarDatos()
        {
            try
            {
                var query = "Select * from dbo.conf_grupos_losa";
                sqlCommand = new SqlCommand(query, sqlConnection);
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                    sqlDataReader = sqlCommand.ExecuteReader();
                    dataTable.Clear();
                    dataTable.Load(sqlDataReader);

                    this.gridControlGruposJAGUAR_PRO.DataSource = dataTable;
                    this.gridView1.OptionsSelection.EnableAppearanceFocusedRow = true;
                    this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
                    sqlConnection.Close();
                }
            }
            catch(Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
           
            
        }
        #endregion

        #region Eventos


        private void CrearGrupoLosa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.RefrescarDatos();
        }


        #endregion

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var gridView = gridControlGruposJAGUAR_PRO.MainView as GridView;

            int rowHandle = gridView.GetRowHandle(e.RowHandle);

            object value = gridView.GetRowCellValue(rowHandle, "id");

            if (value != null)
            {
                CargarAccesos(Convert.ToInt32(value));
            }

        }

        private void CargarAccesos(int v)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_conf_get_roles_accesos_default", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_grupo", v);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsAccesos1.roles_accesos.Clear();
                adat.Fill(dsAccesos1.roles_accesos);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void reposEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.gridView1.SelectedRowsCount > 0)
            {
                var selectedId = this.gridView1.GetDataRow(this.gridView1.GetSelectedRows().FirstOrDefault()).Field<int>("Id");
                EditarGrupoLosa editarGrupoJAGUAR_PRO = new EditarGrupoLosa(selectedId);
                editarGrupoJAGUAR_PRO.StartPosition = FormStartPosition.CenterParent;
                editarGrupoJAGUAR_PRO.FormClosed += CrearGrupoLosa_FormClosed;
                editarGrupoJAGUAR_PRO.ShowDialog(this);
            }
            else
            {
                XtraMessageBox.Show("Error", "Debe se seleccionar un grupo a editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            CrearGrupoLosa crearGrupoJAGUAR_PRO = new CrearGrupoLosa();
            crearGrupoJAGUAR_PRO.StartPosition = FormStartPosition.CenterParent;
            crearGrupoJAGUAR_PRO.FormClosed += CrearGrupoLosa_FormClosed;
            crearGrupoJAGUAR_PRO.ShowDialog(this);
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reposAdd_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.gridView1.SelectedRowsCount > 0)
            {
                var selectedId = this.gridView1.GetDataRow(this.gridView1.GetSelectedRows().FirstOrDefault()).Field<int>("Id");
                frmAccesosPorGrupos frm = new frmAccesosPorGrupos(selectedId);
                IdGrupo = selectedId;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarAccesos(IdGrupo);
                }
            }
            else
            {
                XtraMessageBox.Show("Error", "Debe se seleccionar un grupo a editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
