using ACS.Classes;
using DevExpress.XtraEditors;
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
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CrearGrupoLosa crearGrupoJAGUAR_PRO = new CrearGrupoLosa();
            crearGrupoJAGUAR_PRO.StartPosition = FormStartPosition.CenterParent;
            crearGrupoJAGUAR_PRO.FormClosed += CrearGrupoLosa_FormClosed;
            crearGrupoJAGUAR_PRO.ShowDialog(this);
        }

        private void CrearGrupoLosa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.RefrescarDatos();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
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
        #endregion
    }
}
