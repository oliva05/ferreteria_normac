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
    public partial class frmCRUD_PTCategoria : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public enum Operacion
        {
            Insert = 1, Update = 2, View = 3
        }

        Operacion TipoOP;

        int Id;
        public frmCRUD_PTCategoria(frmCRUD_PTCategoria.Operacion operacion, int pid_categoria, int pid_familia, string pnombre, string pcodigo, bool penable)
        {
            InitializeComponent();
            TipoOP = operacion;
            LoadFamilia();

            switch (TipoOP)
            {
                case Operacion.Insert:

                    toggleSwitchEnablePT.IsOn = true;
                    lblTituloVentana.Text = "Crear Categoria";
                    break;
                case Operacion.Update:
                    lblTituloVentana.Text = "Editar Categoria";
                    Id = pid_categoria;
                    grdTipo.EditValue = pid_familia;
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

        private void LoadFamilia()
        {
            try
            {
                SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                connection.Open();
                SqlCommand cmd = new SqlCommand("[sp_pt_get_familia_activo]", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                dsProductoTerminado1.familia_select.Clear();
                adapter.Fill(dsProductoTerminado1.familia_select);
                connection.Close();
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

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            bool Guardar = false;
            DataOperations dp = new DataOperations();

            TablesId tab = new TablesId();

            if (!tab.ValidacionCodigos(txtCodigo.Text.Trim(), 4, Id))
            {
                CajaDialogo.Error("Este Codigo ya existe en el Grupo de Categorias");
                return;
            }

            if (string.IsNullOrEmpty(grdTipo.Text))
            {
                CajaDialogo.Error("Debe seleccionar Familia de Producto");
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

            if (txtCodigo.TextLength < 2)
            {
                CajaDialogo.Error("El Codigo debe ser de 2 Digitos!");
                return;
            }


            switch (TipoOP)
            {
                case Operacion.Insert:

                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_pt_insert_update_categoria", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", 0);
                        cmd.Parameters.AddWithValue("@id_familia", grdTipo.EditValue);
                        cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
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
                        SqlCommand cmd = new SqlCommand("sp_pt_insert_update_categoria", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", Id);
                        cmd.Parameters.AddWithValue("@id_familia", grdTipo.EditValue);
                        cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
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

        private void grdTipo_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}