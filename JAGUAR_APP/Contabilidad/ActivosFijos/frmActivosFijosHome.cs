using ACS.Classes;
using DevExpress.XtraEditors;
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

namespace JAGUAR_PRO.Contabilidad.ActivosFijos
{
    public partial class frmActivosFijosHome : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        
        public frmActivosFijosHome(UserLogin userLogin)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
            comboEstados.Text = "Activo";
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_list_activos_fijos", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Estado", comboEstados.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsActivosFijos1.lista_activos_fijos.Clear();
                da.Fill(dsActivosFijos1.lista_activos_fijos);
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmActivosFijosCRUD frm = new frmActivosFijosCRUD(frmActivosFijosCRUD.Operacion.Nuevo, UsuarioLogeado, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.af1 != null)
                {
                    DataRow dr = dsActivosFijos1.lista_activos_fijos.NewRow();
                    dr[0] = frm.af1.ActivoId;
                    dr[1] = frm.af1.CodigoActivo;
                    dr[2] = frm.af1.NombreActivo;
                    dr[3] = frm.af1.FechaCompra;
                    dr[4] = frm.af1.ValorCompra;
                    dr[5] = frm.af1.VidaUtilMeses;
                    dr[6] = frm.af1.ValorResidual;
                    dr[7] = frm.af1.CuentaContableActivoID;
                    dr[8] = frm.af1.CuentaDepreciacionAcumuladaID;
                    dr[9] = frm.af1.CuentaGastoDepreciacionID;
                    dr[10] = frm.af1.Estado;
                    dr[11] = frm.af1.Enable;
                    dr[12] = frm.af1.CuentaContableActivoName;
                    dr[13] = frm.af1.CuentaDepreciacionAcumuladaName;
                    dr[14] = frm.af1.CuentaGastoDepreciacionName;
                    dsActivosFijos1.lista_activos_fijos.Rows.Add(dr);
                    dsActivosFijos1.lista_activos_fijos.AcceptChanges();
                }
                else
                {
                    CargarDatos();
                }
            }

        }

        private void comboEstados_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboEstados.Text))
            {
                CargarDatos();
            }
        }
   

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}