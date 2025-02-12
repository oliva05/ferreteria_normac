using ACS.Classes;
using DevExpress.XtraEditors;
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
    public partial class frmCRUD_PTFamilia : DevExpress.XtraEditors.XtraForm
    {
        public enum Operacion
        {
            Insert = 1,  Update = 2, View = 3
        }

        Operacion TipoOP;

        int Id;

        public frmCRUD_PTFamilia(frmCRUD_PTFamilia.Operacion pOP, int pid, string pdescripcion, bool penable, string pcode)
        {
            InitializeComponent();


            switch (TipoOP)
            {
                case Operacion.Insert:

                    toggleSwitchEnablePT.IsOn = true;
                    break;
                case Operacion.Update:
                    Id = pid;
                    txtDescripcion.Text = pdescripcion;
                    toggleSwitchEnablePT.IsOn = penable;
                    txtCodigo.Text = pcode;

                    break;
                case Operacion.View:
                    break;
                default:
                    break;
            }
        }

        

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            bool Guardar = false;   
            DataOperations dp = new DataOperations();

            if (string.IsNullOrEmpty(txtDescripcion.Text)) 
            {
                CajaDialogo.Error("Debe colocar una descripcion!");
                return;
            }

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                CajaDialogo.Error("Debe colocar un codigo!");
                return;
            }

            switch (TipoOP)
            {
                case Operacion.Insert:

                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_pt_insert_familia", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id",0);
                        cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text.Trim());
                        cmd.Parameters.AddWithValue("@enable", toggleSwitchEnablePT.IsOn);
                        cmd.Parameters.AddWithValue("@codigo",txtCodigo.Text);
                        cmd.Parameters.AddWithValue("@tipoOp", Operacion.Insert);
                        //cmd.ExecuteNonQuery();

                        Guardar = true;
                    }
                    catch (Exception ex)
                    {

                        CajaDialogo.Error(ex.Message);
                        
                    }
                    break;
                case Operacion.Update:

                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_pt_insert_familia", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id",Id);
                        cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text.Trim());
                        cmd.Parameters.AddWithValue("@enable", toggleSwitchEnablePT.IsOn);
                        cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                        cmd.Parameters.AddWithValue("@tipoOp", Operacion.Update);
                        cmd.ExecuteNonQuery();

                        Guardar = true;
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                    break;
                case Operacion.View:
                    break;
                default:
                    break;
            }

            if(Guardar)
            {
                CajaDialogo.Information("Actulizado con Exito!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}