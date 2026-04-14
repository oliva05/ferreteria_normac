using ACS.Classes;
using DevExpress.DashboardWin.Native;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSpellChecker.Parser;
using DocumentFormat.OpenXml.Office.Word;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Accesos;
using LOSA.RecepcionMP;
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

namespace JAGUAR_PRO.RRHH_Planilla.Planilla.Ausencias
{
    public partial class frmAusenciasGestionRpt : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        public frmAusenciasGestionRpt(UserLogin user)
        {
            InitializeComponent();

            UsuarioLogeado = user;

            dtDesde.DateTime = dp.dNow().AddDays(-15);
            dtHasta.DateTime = dp.dNow();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_get_all_leaves_from_dates",conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@fecha_desde",dtDesde.DateTime);
                        cmd.Parameters.AddWithValue("@fecha_hasta", dtHasta.DateTime.AddDays(1));
                        dsInasistencias1.ausencias_gestion.Clear();
                        using (SqlDataAdapter adat = new SqlDataAdapter(cmd))
                        {
                            adat.Fill(dsInasistencias1.ausencias_gestion);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reposBtnAnular_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview1 = (GridView)grdAusencias.FocusedView;
            var row = (dsInasistencias.ausencias_gestionRow)gridview1.GetFocusedDataRow();

            if (row != null)
            {
                DialogResult r = CajaDialogo.Pregunta("Desea Anular este registro de " + row.tipo_ausencia +"?");
                if (r == DialogResult.Yes)
                {
                
                    try
                    {
                        DataOperations dp = new DataOperations();
                        using (SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand("sp_leaves_update", conn))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id", row.id);
                                cmd.Parameters.AddWithValue("@employeeId", row.employee_id);
                                cmd.Parameters.AddWithValue("@userLog", UsuarioLogeado.Id);
                                cmd.ExecuteNonQuery();

                                LoadData();
                            }
                        }
                        
                    }
                    catch (SqlException sqlEx)
                    {
                        CajaDialogo.Error($"Error SQL: {sqlEx.Message}");
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error($"Error general: {ex.Message}");
                    }
                }
            }
        }
    }
}