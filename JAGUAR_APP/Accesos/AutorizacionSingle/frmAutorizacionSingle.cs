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

namespace JAGUAR_PRO.Accesos.AutorizacionSingle
{
    public partial class frmAutorizacionSingle : DevExpress.XtraEditors.XtraForm
    {
        bool contraseniaCorrecta = false;
        public frmAutorizacionSingle()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                txtClave.Focus();
            }
        }

        private void frmAutorizacionSingle_Activated(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void frmAutorizacionSingle_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void btnConfirmarAutorizacionDirecta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text)) 
            {
                CajaDialogo.Error("Es necesario ingresar un usuario que autorice!");
                return;
            }

            if (string.IsNullOrEmpty(txtClave.Text))
            {
                CajaDialogo.Error("Es necesario ingresar la contraseña!");
                return;
            }

            var usuario = ValidateUserInfo(txtUsuario.Text, txtClave.Text);
            if (usuario.GrupoUsuario.GrupoUsuarioActivo == GrupoUser.GrupoUsuario.Administradores && contraseniaCorrecta == true)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelarAutorizacionDirecta_Click(object sender, EventArgs e)
        {
            this.DialogResult =  DialogResult.Cancel;
            this.Close();
        }

        private UserLogin ValidateUserInfo(string usuario, string clave)
        {
            UserLogin user = new UserLogin();
            //string usuario = user.EncrypPassword("Nutreco");//Users.EncrypPassword("Nutreco"); 
            if (user.RecuperarRegistroJAGUAR(usuario))
            {
                if (!user.Habilitado)
                {
                    CajaDialogo.Information("Este usuario no esta habilitado o no existe!");
                    return new UserLogin();
                }

                if (user.DecryptPassword(user.Pass) == clave)
                {
                    //Logramos validar el usuario correctamente.
                    contraseniaCorrecta = true;
                    return user;
                }
                else
                {
                    CajaDialogo.Error("Contraseña Incorrecta!");
                    txtClave.Text = "";
                    return new UserLogin();
                }

            }
            else
            {
                CajaDialogo.Error("No se pudo encontrar el usuario que usted ingreso, favor revise bien el alias de usuario.");
                txtUsuario.Focus();
                return new UserLogin();
            }
        }
    }
}