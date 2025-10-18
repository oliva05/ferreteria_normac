using ACS.Classes;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Contabilidad.ActivosFijos;
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

namespace JAGUAR_PRO.Contabilidad.Depreciacion
{
    public partial class frmDepreciacionOP : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogueado;
        int IdActivoFijo = 0;   
        public frmDepreciacionOP(UserLogin userLogin, int pIdActivoFijo)
        {
            InitializeComponent();
            UsuarioLogueado = userLogin;
            IdActivoFijo = pIdActivoFijo;
            dtPriodo.DateTime = dp.Now();
            LoadData();
        }

        private void LoadData() 
        {
            try
            {
                string query = @"sp_get_depreciacion_preview_af";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Periodo", dtPriodo.DateTime);
                cmd.Parameters.AddWithValue("@IdActivoFijo", IdActivoFijo);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsActivosFijos1.calculo_depreciacion.Clear();
                adat.Fill(dsActivosFijos1.calculo_depreciacion);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var dt = new DataTable())
            {
                dt.Columns.Add("ActivoID", typeof(int));
                foreach (dsActivosFijos.calculo_depreciacionRow row in dsActivosFijos1.calculo_depreciacion)
                {
                    if (row.seleccionado)
                    {
                        dt.Rows.Add(row.codigo_activo);
                    }
                }

                using (var conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    conn.Open();

                    using (var cmd = new SqlCommand("sp_af_insert_depreciacion",conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Periodo", dtPriodo.DateTime);
                        cmd.Parameters.AddWithValue("@Usuario", UsuarioLogueado.Usuario);
                        var tvp = cmd.Parameters.AddWithValue("@Activos", dt);
                        tvp.SqlDbType = SqlDbType.Structured;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}