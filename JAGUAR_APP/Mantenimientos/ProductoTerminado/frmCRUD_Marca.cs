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
    public partial class frmCRUD_Marca : DevExpress.XtraEditors.XtraForm
    {
        int IdMarca = 0;
        UserLogin UsuarioLogeado;
        public enum TipoOperacion
        {
            Nuevo =1,
            Editar = 2
        }

        TipoOperacion Operacion;
        public frmCRUD_Marca(frmCRUD_Marca.TipoOperacion tipoOperacion, UserLogin userLogin, int pIdMarca)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
            IdMarca = pIdMarca;
            Operacion = tipoOperacion;
            CargarPaises();
            switch (Operacion)
            {
                case TipoOperacion.Nuevo:
                    lblTituloVentana.Text = "Crear Marca";
                    toggleSwitchEnablePT.IsOn = true;
                    break;
                case TipoOperacion.Editar:
                    lblTituloVentana.Text = "Editar Marca";
                    Marcas mc = new Marcas();
                    if (mc.RecuperarRegistros(IdMarca))
                    {
                        txtNombre.Text = mc.Nombre;
                        txtDescripcion.Text = mc.Descripcion;
                        comboBoxPaises.Text = mc.Pais;
                        hyperSitio.Text = mc.SitioWeb;
                        toggleSwitchEnablePT.IsOn = mc.Estado;
                    }

                    break;
                default:
                    break;
            }

        }
        private void CargarPaises()
        {
            List<string> paises = new List<string>
            {
                "Afganistán", "Alemania", "Argentina", "Australia", "Bélgica", "Bolivia", "Brasil", "Canadá", "Chile", "China", "Colombia", "Corea del Sur", "Costa Rica", "Cuba", "Dinamarca", "Ecuador", "Egipto", "El Salvador", "España", "Estados Unidos", "Francia", "Guatemala", "Honduras", "India", "Italia", "Japón", "México", "Nicaragua", "Noruega", "Países Bajos", "Panamá", "Paraguay", "Perú", "Portugal", "Reino Unido", "República Dominicana", "Rusia", "Suecia", "Suiza", "Uruguay", "Venezuela"
            };

            comboBoxPaises.Properties.Items.AddRange(paises);
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                CajaDialogo.Error("Debe agregar el Nombre de la Marca!");
                return;
            }
            DataOperations dp = new DataOperations();
            bool Guardar = false;
            switch (Operacion)
            {
                case TipoOperacion.Nuevo:

                    try
                    {
                        using (SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                        {
                            conn.Open();

                            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM PT_Marca WHERE nombre = @nombre", conn);
                            checkCmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                            int count = (int)checkCmd.ExecuteScalar();

                            if (count > 0)
                            {
                                CajaDialogo.Error("El nombre ya existe en la base de datos.");
                                return;
                            }

                            SqlCommand cmd = new SqlCommand("sp_pt_insert_update_marca", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_marca", 0);
                            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                            if (string.IsNullOrEmpty(txtDescripcion.Text))
                                cmd.Parameters.AddWithValue("@descripcion", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                            if (string.IsNullOrEmpty(comboBoxPaises.Text))
                                cmd.Parameters.AddWithValue("@pais_origen", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@pais_origen", comboBoxPaises.Text);
                            if (string.IsNullOrEmpty(hyperSitio.Text))
                                cmd.Parameters.AddWithValue("@sitio_web", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@sitio_web", hyperSitio.Text);
                            cmd.Parameters.AddWithValue("@estado", 1);
                            cmd.Parameters.AddWithValue("@fecha_creacion", dp.Now());
                            cmd.Parameters.AddWithValue("@user_id_create", UsuarioLogeado.Id);
                            cmd.Parameters.AddWithValue("@fecha_actualizacion", DBNull.Value);
                            cmd.Parameters.AddWithValue("@user_id_modi", DBNull.Value);

                            cmd.ExecuteNonQuery();
                            Guardar = true;
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }

                    break;
                case TipoOperacion.Editar:

                    try
                    {
                        using (SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                        {
                            conn.Open();


                            // Verificar si el nombre ya existe en otro registro (excluyendo el mismo ID si es un update)
                            SqlCommand checkCmd = new SqlCommand(@"SELECT COUNT(*) FROM PT_Marca 
                                                                         WHERE nombre = @nombre AND id_marca <> @id_marca", conn);
                            checkCmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                            checkCmd.Parameters.AddWithValue("@id_marca", IdMarca);

                            int count = (int)checkCmd.ExecuteScalar();

                            if (count > 0)
                            {
                                CajaDialogo.Error("El nombre ya existe en otro registro.");
                                return;
                            }

                            // Crear comando para Insert o Update
                            SqlCommand cmd = new SqlCommand("sp_pt_insert_update_marca", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_marca", IdMarca);
                            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                            if (string.IsNullOrEmpty(txtDescripcion.Text))
                                cmd.Parameters.AddWithValue("@descripcion", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                            if (string.IsNullOrEmpty(comboBoxPaises.Text))
                                cmd.Parameters.AddWithValue("@pais_origen", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@pais_origen", comboBoxPaises.Text);
                            if (string.IsNullOrEmpty(hyperSitio.Text))
                                cmd.Parameters.AddWithValue("@sitio_web", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@sitio_web", hyperSitio.Text);
                            cmd.Parameters.AddWithValue("@estado", toggleSwitchEnablePT.IsOn);

                            cmd.Parameters.AddWithValue("@fecha_creacion", dp.Now());
                            cmd.Parameters.AddWithValue("@user_id_create", UsuarioLogeado.Id);
                            cmd.Parameters.AddWithValue("@fecha_actualizacion", dp.Now());
                            cmd.Parameters.AddWithValue("@user_id_modi", UsuarioLogeado.Id);
                            cmd.ExecuteNonQuery();
                            Guardar = true;
                        }
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627) // Código de error de clave única duplicada
                        {
                            CajaDialogo.Error("El nombre ya existe en la base de datos.");
                        }
                        else
                        {
                            CajaDialogo.Error(ex.Message);
                        }
                    }
                    break;
                default:
                    break;
            }

            if (Guardar)
            {
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