using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using JAGUAR_PRO.Clases;
using ACS.Classes;
using JAGUAR_PRO.Accesos;
using DevExpress.XtraGrid.Views.Grid;

namespace PRININ.Gestion_de_Usuarios
{
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        public enum TipoEdicion
        {
            Nuevo = 1,
            Editar = 2
        }

        private bool ValidoContrasenia;

        //private SqlConnection conn;
        //DBOperations op;
        DataOperations op = new DataOperations();
        private TipoEdicion vTipoEdition;
        private UserLogin UserParametro;
        private UserLogin UserEdicion;
        int IdNivel = 0;
        public frmUser(TipoEdicion pTipo, UserLogin pUser, int pIdUserEditar)
        {
            InitializeComponent();
            vTipoEdition = pTipo;
            op = new DataOperations();
            UserParametro = pUser;
            LoadGroup();
            LoadTurnos();
            LoadNivelesAcceso();

            switch (vTipoEdition)
            {
                case TipoEdicion.Nuevo:
                    txtAlias.Text = "";
                    txtNombre.Text = "";
                    //txtApellido.Text = "";
                    chkUsuarioHabilitado.IsOn = true;
                    chkSuperUsuario.IsOn = false;
                    ValidoContrasenia = false;
                    txtPass.Text = "";
                    txtConfirmar.Text = "";
                    tsIsVendedor.IsOn = false;
                    GetCodeSig();
                    break;
                case TipoEdicion.Editar:
                    UserEdicion = new UserLogin();
                    if (UserEdicion.RecuperarRegistroJAGUAR(pIdUserEditar))
                    {
                        txtAlias.Text = UserEdicion.Usuario;
                        txtNombre.Text = UserEdicion.Nombre;
                        lueGrupo.EditValue = UserEdicion.IdGrupo;
                        chkUsuarioHabilitado.IsOn = UserEdicion.Habilitado;
                        txtPass.Text = UserParametro.DecryptPassword(UserEdicion.Pass);
                        txtConfirmar.Text = UserParametro.DecryptPassword(UserEdicion.Pass);
                        chkSuperUsuario.IsOn = UserEdicion.IsSuperUser;
                        lueTurno.EditValue = UserEdicion.TurnoId;
                        txtCodigo.Text = UserEdicion.Codigo;
                        txtPIN.Text = UserEdicion.PIN.ToString();
                        tsIsVendedor.IsOn = UserEdicion.IsVendedor;
                        ValidoContrasenia = true;
                        txtCodigoEmpleado.Text = UserEdicion.CodigoEmpleado;
                        if (UserEdicion.Idnivel != 0)
                        {
                            foreach (dsAccesos.niveles_accesoRow item in dsAccesos1.niveles_acceso.Rows)
                            {
                                if (UserEdicion.Idnivel == item.id)
                                {
                                    item.selected = true;
                                }
                            }
                        }

                    }
                    break;
            }
        }

        private void GetCodeSig()
        {
            try
            {
                SqlConnection conn = new SqlConnection(op.ConnectionStringJAGUAR_DB);
                conn.Open();
                string sql = "ft_cargar_codigo_siguiente_empleados";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //IdSiguiente = dr.GetInt32(1);
                    txtCodigoEmpleado.Text = dr.GetString(2);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadNivelesAcceso()
        {
            try
            {
           
                using (SqlConnection cnx = new SqlConnection(op.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();
                    string sql = @"sp_get_niveles_accesos";
                    SqlDataAdapter da = new SqlDataAdapter(sql, cnx);

                    dsAccesos1.niveles_acceso.Clear();
                    da.Fill(dsAccesos1.niveles_acceso);

                    cnx.Close();
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public bool GuardarNivelAcceso()
        {
            try
            {
                
                using (SqlConnection cnx = new SqlConnection(op.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();
                    string sql = @"sp_guardar_nivel_acceso";
                    SqlCommand cmd = new SqlCommand(sql, cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_user", UserEdicion.Id);
                    cmd.Parameters.AddWithValue("@id_nivel", IdNivel);
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }

        private void cmdSAve_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAlias.Text) 
                //|| string.IsNullOrEmpty(txtApellido.Text) 
                || string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Los campos: Usuario, Nombre y Apellidos no pueden quedar en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(lueGrupo.Text))
            {
                MessageBox.Show("DEBE DE SELECCIONAR UN GRUPO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtConfirmar.Text != txtPass.Text)
            {
                ValidoContrasenia = false;
            }
            else
            {
                ValidoContrasenia = true;
            }

            //if(lueGrupo.EditValue == 4) //Si es Vendedor debe llevar Codigo Obligatoriamente
            //{
            //    CajaDialogo.Error("Debe colocar un Codigo de Vendedor");
            //    return;
            //}

            if (ValidoContrasenia)
            {
                switch (vTipoEdition)
                {
                    case TipoEdicion.Nuevo: 
                        UserEdicion = new UserLogin();
                        UserEdicion.Usuario = txtAlias.Text.Trim();
                        UserEdicion.Nombre = txtNombre.Text.Trim();
                        UserEdicion.NombreUser = txtNombre.Text.Trim();
                        //UserParametro.apellido = txtApellido.Text.Trim();
                        UserEdicion.Habilitado = chkUsuarioHabilitado.IsOn;
                        UserEdicion.IsSuperUser = chkSuperUsuario.IsOn;
                        UserEdicion.Pass = txtPass.Text;
                        UserEdicion.IdGrupo =Convert.ToInt32( lueGrupo.EditValue);
                        UserEdicion.TurnoId = Convert.ToInt32(lueTurno.EditValue);
                        UserEdicion.Codigo = txtCodigo.Text;
                        UserEdicion.PIN = txtPIN.Text;
                        UserEdicion.IsVendedor = tsIsVendedor.IsOn;
                        if (UserEdicion.GuardarNuevoUsuario())
                        {
                            if (IdNivel > 0)
                            {
                                GuardarNivelAcceso();
                            }
                            CajaDialogo.Information("Guardado con exito!");
                            this.DialogResult = DialogResult.OK;
                            this.Close();

                        }


                        break;
                    case TipoEdicion.Editar:
                        //UserEdicion = new UserLogin();
                        UserEdicion.Usuario = txtAlias.Text.Trim();
                        UserEdicion.Nombre = txtNombre.Text.Trim();
                        UserEdicion.NombreUser = txtNombre.Text.Trim();
                        UserEdicion.Habilitado = chkUsuarioHabilitado.IsOn;
                        UserEdicion.IsSuperUser = chkSuperUsuario.IsOn;
                        UserEdicion.Pass = txtPass.Text;
                        UserEdicion.IdGrupo = Convert.ToInt32(lueGrupo.EditValue);
                        UserEdicion.TurnoId = Convert.ToInt32(lueTurno.EditValue);
                        UserEdicion.Codigo = txtCodigo.Text;
                        UserEdicion.PIN = txtPIN.Text;
                        UserEdicion.IsVendedor = tsIsVendedor.IsOn;
                        if (UserEdicion.ModificarUsuario())
                        {
                            if (IdNivel > 0)
                            {
                                GuardarNivelAcceso();
                            }
                            CajaDialogo.Information("Guardado con exito!");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        break;
                }
            }
            else
            {
                CajaDialogo.Error("Las contraseñas no coinciden!");
                return;
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            //this.Close();
        }

        private void LoadGroup()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();
                    string sql = @"SELECT id,
                                       grupo
	                                FROM dbo.conf_grupos_losa
                                WHERE enable=1";

                    SqlDataAdapter da = new SqlDataAdapter(sql,cnx);

                    dsAccesos1.Acceso_Grupo.Clear();
                    da.Fill(dsAccesos1.Acceso_Grupo);

                    cnx.Close();
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadTurnos()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();
                    string sql = @"SELECT id,
                                       descripcion
	                                FROM dbo.JAGUAR_Usuarios_Turnos
                                WHERE enable=1";

                    SqlDataAdapter da = new SqlDataAdapter(sql, cnx);

                    dsAccesos1.Turno.Clear();
                    da.Fill(dsAccesos1.Turno);

                    cnx.Close();
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gridViewAccesos_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "selected")
            {
                var gridView = (GridView)gridControlAccesos.FocusedView;
                var row = (dsAccesos.niveles_accesoRow)gridView.GetFocusedDataRow();
                
                if (Convert.ToBoolean(e.Value))
                {
                    UserEdicion.Idnivel = IdNivel = row.id;
                }

                foreach (dsAccesos.niveles_accesoRow item in dsAccesos1.niveles_acceso)
                {
                    if (UserEdicion.Idnivel != item.id)
                    {
                        item.selected = false;
                    }
                }
            }

           
        }

        private void tsIsVendedor_Toggled(object sender, EventArgs e)
        {
            if (tsIsVendedor.IsOn)
            {
                groupVendedor.Enabled = true;
            }
            else
            {
                groupVendedor.Enabled = false;
                txtPIN.Text = "";
                txtCodigo.Text = "";
            }
        }
    }
}