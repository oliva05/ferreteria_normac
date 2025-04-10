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
using DevExpress.XtraGauges.Core.Primitive;
using JAGUAR_PRO.Clases;

namespace JAGUAR_PRO.Accesos.GrupoLosa
{
    public partial class frmAccesosPorGrupos : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp;
        DataTable dt;
        int IdGrupo = 0;
        public frmAccesosPorGrupos(int pIdGrupo)
        {
            InitializeComponent(); //sp_conf_get_all_ventanas
            
            IdGrupo = pIdGrupo;
            if (IdGrupo > 0)
            {
                Grupos grupos = new Grupos();
                grupos.RecuperarRegistros(IdGrupo);
                txtGrupo.Text = grupos.Grupo;
                CargarAccesosHabilitados();
            }
        }

        private void CargarAccesosHabilitados()
        {
            try
            {
                dp = new DataOperations();
                string query = @"[sp_conf_grupo_ventanas]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdGrupo",IdGrupo);
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                CajaDialogo.Error("Debe seleccionar por lo menos un acceso!");
                return;
            }

            SqlTransaction transaction = null;

            SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            bool Guardar = false;

            try
            {
                conn.Open();
                transaction = conn.BeginTransaction("Transaction Order");

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "sp_conf_delete_accesos_by_grupo";
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdGrupo",IdGrupo);

                cmd.ExecuteNonQuery();

                foreach (dsAccesos.roles_accesosRow row in dsAccesos1.roles_accesos.Rows)
                {
                    if (row.selected)
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "sp_conf_insert_accesos_a_grupo";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdGrupo", IdGrupo);
                        cmd.Parameters.AddWithValue("@IdVentana", row.id_ventana);
                        cmd.ExecuteNonQuery();
                    }
                    
                }


                transaction.Commit();
                Guardar = true;

            }
            catch (Exception ec)
            {
                transaction.Rollback();
                CajaDialogo.Error(ec.Message);
                Guardar = false;
            }

            if (Guardar)
            {
                CajaDialogo.Information("Accesos guardados correctamente!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void tsAll_Toggled(object sender, EventArgs e)
        {
            if (tsAll.IsOn)
            {
                foreach (dsAccesos.roles_accesosRow item in dsAccesos1.roles_accesos.Rows)
                {
                    item.selected = true;
                }
            }
            else
            {
                foreach (dsAccesos.roles_accesosRow item in dsAccesos1.roles_accesos.Rows)
                {
                    item.selected = false;
                }
            }
        }
    }
}