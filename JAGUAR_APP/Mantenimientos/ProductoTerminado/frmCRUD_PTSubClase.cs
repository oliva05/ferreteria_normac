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

namespace JAGUAR_PRO.Mantenimientos.ProductoTerminado
{
    public partial class frmCRUD_PTSubClase : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public enum Operacion
        {
            Insert = 1, Update = 2, View = 3
        }

        Operacion TipoOP;

        int Id;

        public frmCRUD_PTSubClase(frmCRUD_PTSubClase.Operacion operacion, int pid_subClase, int pid_clase, string pnombre, string pcodigo, bool penable)
        {
            InitializeComponent();
            TipoOP = operacion;
            LoadClases();
            switch (TipoOP)
            {
                case Operacion.Insert:

                    toggleSwitchEnablePT.IsOn = true;
                    lblTituloVentana.Text = "Crear Sub Clase";
                    break;
                case Operacion.Update:
                    lblTituloVentana.Text = "Editar Sub Clase";
                    Id = pid_clase;
                    grdTipo.EditValue = pid_clase;
                    txtDescripcion.Text = pnombre;
                    toggleSwitchEnablePT.IsOn = penable;
                    txtCodigo.Text = pcodigo;

                    break;
                case Operacion.View:
                    break;
                default:
                    break;
            }
        }

        private void LoadClases()
        {
            try
            {
                SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                connection.Open();
                SqlCommand cmd = new SqlCommand("[sp_pt_get_sub_clases_activos]", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                dsProductoTerminado1.clase_select.Clear();
                adapter.Fill(dsProductoTerminado1.clase_select);
                connection.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            bool Guardar = false;
            DataOperations dp = new DataOperations();

            TablesId tab = new TablesId();
            if (!tab.ValidacionCodigos(txtCodigo.Text.Trim(), 3))
            {
                CajaDialogo.Error("Este Codigo ya existe en el Grupo de Sub Clases");
                return;
            }

            if (string.IsNullOrEmpty(grdTipo.Text))
            {
                CajaDialogo.Error("Debe seleccionar Clase de Producto");
                return;
            }

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

            if (txtCodigo.TextLength < 3)
            {
                CajaDialogo.Error("El Codigo debe ser de 3 Digitos!");
                return;
            }

            switch (TipoOP)
            {
                case Operacion.Insert:

                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_pt_insert_update_clase", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_subclase", 0);
                        cmd.Parameters.AddWithValue("@id_clase", grdTipo.EditValue);
                        cmd.Parameters.AddWithValue("@nombre", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text.Trim());
                        cmd.Parameters.AddWithValue("@enable", toggleSwitchEnablePT.IsOn);

                        cmd.ExecuteNonQuery();

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
                        SqlCommand cmd = new SqlCommand("sp_pt_insert_sub_clases", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_subclase", Id);
                        cmd.Parameters.AddWithValue("@id_clase", grdTipo.EditValue);
                        cmd.Parameters.AddWithValue("@nombre", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text.Trim());
                        cmd.Parameters.AddWithValue("@enable", toggleSwitchEnablePT.IsOn);

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

            if (Guardar)
            {
                CajaDialogo.Information("Actulizado con Exito!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}