using ACS.Classes;
using JAGUAR_PRO.Mantenimientos.Modelos;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JAGUAR_PRO.Mantenimientos
{
    public partial class frmBodega : Form
    {
        DataOperations dp = new DataOperations();
        public frmBodega()
        {
            InitializeComponent();
            CargarDatos();
        }
             
        void CargarDatos()
        {
            try
            {
                using (SqlConnection conexionLOSA = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    dsMantenimiento1.BodegasDataTable.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter("exec spObtenerBodegas", conexionLOSA);
                    adapter.Fill(dsMantenimiento1.BodegasDataTable);
                }

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {            
            frmBodegaCRUD frm = new frmBodegaCRUD(frmBodegaCRUD.Operacion.New, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Bodega bodega = new Bodega
            {
                Id = Convert.ToInt32(gvBodegas.GetRowCellValue(gvBodegas.GetRowHandle(gvBodegas.GetSelectedRows()[0]), colid)),
            };

            frmBodegaCRUD frm = new frmBodegaCRUD(frmBodegaCRUD.Operacion.Update, bodega.Id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }
    }
}