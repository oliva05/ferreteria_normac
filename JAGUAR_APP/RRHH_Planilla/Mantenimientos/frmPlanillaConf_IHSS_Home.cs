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

namespace JAGUAR_PRO.RRHH_Planilla.Mantenimientos
{
    public partial class frmPlanillaConf_IHSS_Home : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        public frmPlanillaConf_IHSS_Home(UserLogin userLogin)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                
                SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_get_conf_ihss", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@filtro", toggleSwitch1.IsOn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsMantenimientoPlanilla1.hr_ihss.Clear();
                da.Fill(dsMantenimientoPlanilla1.hr_ihss);
                connection.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            bool Bloquear = false;
            foreach (dsMantenimientoPlanilla.hr_ihssRow item in dsMantenimientoPlanilla1.hr_ihss)
            {
                if (item.activo)
                {
                    Bloquear = true;
                }
            }

            if (!Bloquear)
            {
                try
                {
                    
                    frmPlanillaConf_IHSS frm = new frmPlanillaConf_IHSS(frmPlanillaConf_IHSS.TipoTransaccionPlanilla.Nuevo, UsuarioLogeado, 0, 0);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        CargarDatos();
                    }
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            else
            {
                CajaDialogo.Error("No se puede crear un Registro nuevo, porque ya existe un registro activo.\nDeshabilite el registro activo para crear uno nuevo.");
            }

            
        }

        private void btnEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdIHSS.FocusedView;
            var row = (dsMantenimientoPlanilla.hr_ihssRow)gridview.GetFocusedDataRow();

            if (row != null)
            {
                frmPlanillaConf_IHSS frm = new frmPlanillaConf_IHSS(frmPlanillaConf_IHSS.TipoTransaccionPlanilla.Modificar, UsuarioLogeado, row.id, row.anio);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarDatos();
                }
            }
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void cmdCargarDatos_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdIHSS.FocusedView;
            var row = (dsMantenimientoPlanilla.hr_ihssRow)gridview.GetFocusedDataRow();

            if (row != null)
            {
                if (row.activo)
                {
                    DesactivarRegistro(row.id);
                }
            }

        }

        private void DesactivarRegistro(int pid)
        {
            bool Guardaro = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_delete_conf_ihss", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pid);
                Guardaro = Convert.ToBoolean(cmd.ExecuteNonQuery());
                connection.Close();

                if (Guardaro)
                {
                    CajaDialogo.Information("Registro Desactivado!");
                    CargarDatos();
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
    }
}