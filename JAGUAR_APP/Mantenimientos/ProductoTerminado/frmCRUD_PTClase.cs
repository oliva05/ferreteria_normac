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
using static DevExpress.DataProcessing.InMemoryDataProcessor.AddSurrogateOperationAlgorithm;

namespace JAGUAR_PRO.Mantenimientos.ProductoTerminado
{
    public partial class frmCRUD_PTClase : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public enum Operacion
        {
            Insert = 1, Update = 2, View = 3
        }

        Operacion TipoOP;

        int Id;

        public frmCRUD_PTClase(frmCRUD_PTClase.Operacion operacion, int pid_clase, int pid_familia, string pnombre,string pcodigo, bool penable)
        {
            InitializeComponent();
            TipoOP = operacion;
            
            switch (TipoOP)
            {
                case Operacion.Insert:

                    toggleSwitchEnablePT.IsOn = true;
                    lblTituloVentana.Text = "Crear Clase";
                    break;
                case Operacion.Update:
                    lblTituloVentana.Text = "Editar Clase";
                    Id = pid_clase;
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
            LoadFamilia();
        }

        private void LoadFamilia()
        {
            try
            {
                SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_pt_get_categoria_activo", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                dsProductoTerminado1.categoaria_select.Clear();
                adapter.Fill(dsProductoTerminado1.categoaria_select);
                connection.Close();
                ProductoClase ClaseActual = new ProductoClase();
                if(ClaseActual.ObtenerPorId(Id))
                {
                    ProductoCategoria categoriaActual = new ProductoCategoria();
                    if (categoriaActual.ObtenerPorId(ClaseActual.IdCategoria))
                    {
                        ProductoFamilia FamiliaActual =  new ProductoFamilia();
                        if(FamiliaActual.ObtenerPorId(categoriaActual.IdFamilia))
                        {
                            txtFamilia_.Text = FamiliaActual.Codigo + " - " + FamiliaActual.Descripcion;
                        }
                    }
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

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            bool Guardar = false;
            DataOperations dp = new DataOperations();

            TablesId tab = new TablesId();

            if (!tab.ValidacionCodigos(txtCodigo.Text.Trim(), 2, Id))
            {
                CajaDialogo.Error("Este Codigo ya existe en el Grupo de Clases");
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
                        cmd.Parameters.AddWithValue("@id_clase", 0);
                        cmd.Parameters.AddWithValue("@id_categoria", grdTipo.EditValue);
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
                        SqlCommand cmd = new SqlCommand("sp_pt_insert_update_clase", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_clase", Id);
                        cmd.Parameters.AddWithValue("@id_categoria", grdTipo.EditValue);
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
    }
}