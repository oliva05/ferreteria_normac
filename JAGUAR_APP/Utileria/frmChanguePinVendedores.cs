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

namespace JAGUAR_PRO.Utileria
{
    public partial class frmChanguePinVendedores : DevExpress.XtraEditors.XtraForm
    {
        UserLogin vVendedorLogeado;
        public string NombreVendedor;
        public int IdVendedorUser;
        public string CodigoVendedor;
        public Vendedor Vendedor_;

        public frmChanguePinVendedores()
        {
            InitializeComponent();
            LimpiarControlesCodigo();
            LimpiarControlesPIN();
        }

        private void LimpiarControlesPIN()
        {
            txtPass1.Text = string.Empty;
            txtPass2.Text = string.Empty;
            txtPass3.Text = string.Empty;
            txtPass4.Text = string.Empty;
 
        }

        private void LimpiarControlesCodigo()
        {
            lblNombreUser.Text = string.Empty;
            txtCode1.Text = string.Empty;
            txtCode2.Text = string.Empty;
            txtCode3.Text = string.Empty;
            txtCode4.Text = string.Empty;
        }

        private void txtCode1_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCode1.Text))
            {
                txtCode2.Focus();
            }
        }

        private void txtCode1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 ||
              e.KeyCode == Keys.NumPad1 ||
              e.KeyCode == Keys.NumPad2 ||
              e.KeyCode == Keys.NumPad3 ||
              e.KeyCode == Keys.NumPad4 ||
              e.KeyCode == Keys.NumPad5 ||
              e.KeyCode == Keys.NumPad6 ||
              e.KeyCode == Keys.NumPad7 ||
              e.KeyCode == Keys.NumPad8 ||
              e.KeyCode == Keys.NumPad9 ||
              e.KeyCode == Keys.NumPad0)
            {
                if (txtCode1.Text.Length > 0)
                    txtCode1.Text = string.Empty;
            }
            else
            {
                if (e.KeyCode == Keys.Back)
                {
                    lblNombreUser.Text = string.Empty;
                }
            }
        }

        private void txtCode1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))// && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtCode2_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCode2.Text))
            {
                txtCode3.Focus();
            }
        }

        private void txtCode2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (txtCode2.Text == string.Empty)
                {
                    txtCode1.Focus();
                    lblNombreUser.Text = string.Empty;
                }

            }
            else
            {
                if (e.KeyCode == Keys.NumPad0 ||
                       e.KeyCode == Keys.NumPad1 ||
                       e.KeyCode == Keys.NumPad2 ||
                       e.KeyCode == Keys.NumPad3 ||
                       e.KeyCode == Keys.NumPad4 ||
                       e.KeyCode == Keys.NumPad5 ||
                       e.KeyCode == Keys.NumPad6 ||
                       e.KeyCode == Keys.NumPad7 ||
                       e.KeyCode == Keys.NumPad8 ||
                       e.KeyCode == Keys.NumPad9 ||
                       e.KeyCode == Keys.NumPad0)
                {
                    if (txtCode2.Text.Length > 0)
                        txtCode2.Text = string.Empty;
                }
            }

        }

        private void txtCode2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCode2.Text))
            {
                txtCode3.Focus();
            }
        }

        private void txtCode3_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCode3.Text))
            {
                txtCode4.Focus();
            }
        }

        private void txtCode3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (txtCode3.Text == string.Empty)
                {
                    txtCode2.Focus();
                    lblNombreUser.Text = string.Empty;
                }
            }
            else
            {
                if (e.KeyCode == Keys.NumPad0 ||
                       e.KeyCode == Keys.NumPad1 ||
                       e.KeyCode == Keys.NumPad2 ||
                       e.KeyCode == Keys.NumPad3 ||
                       e.KeyCode == Keys.NumPad4 ||
                       e.KeyCode == Keys.NumPad5 ||
                       e.KeyCode == Keys.NumPad6 ||
                       e.KeyCode == Keys.NumPad7 ||
                       e.KeyCode == Keys.NumPad8 ||
                       e.KeyCode == Keys.NumPad9 ||
                       e.KeyCode == Keys.NumPad0)
                {
                    if (txtCode3.Text.Length > 0)
                        txtCode3.Text = string.Empty;
                }
            }
        }

        private void txtCode3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtCode4_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCode4.Text))
            {
                //validate user
                LoadDatosVendedor();
            }
        }

        private void txtCode4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (txtCode4.Text == string.Empty)
                {
                    txtCode3.Focus();
                    lblNombreUser.Text = string.Empty;
                }
            }
            else
            {
                if (e.KeyCode == Keys.NumPad0 ||
                       e.KeyCode == Keys.NumPad1 ||
                       e.KeyCode == Keys.NumPad2 ||
                       e.KeyCode == Keys.NumPad3 ||
                       e.KeyCode == Keys.NumPad4 ||
                       e.KeyCode == Keys.NumPad5 ||
                       e.KeyCode == Keys.NumPad6 ||
                       e.KeyCode == Keys.NumPad7 ||
                       e.KeyCode == Keys.NumPad8 ||
                       e.KeyCode == Keys.NumPad9 ||
                       e.KeyCode == Keys.NumPad0)
                {
                    if (txtCode4.Text.Length > 0)
                        txtCode4.Text = string.Empty;
                }
                if (e.KeyCode == Keys.Enter)
                {
                    LoadDatosVendedor();
                }
            }
        }

        private void txtCode4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void LoadDatosVendedor()
        {
            if (string.IsNullOrEmpty(txtCode1.Text) || string.IsNullOrEmpty(txtCode2.Text) || string.IsNullOrEmpty(txtCode3.Text) ||
                string.IsNullOrEmpty(txtCode4.Text))
                return;

            string Codigo = txtCode1.Text + txtCode2.Text + txtCode3.Text + txtCode4.Text;

            Vendedor vend1 = new Vendedor();
            if (vend1.RecuperarRegistro(Codigo))
            {
                lblNombreUser.Text = vend1.Nombre;
                vVendedorLogeado = new UserLogin();
                vVendedorLogeado.RecuperarRegistro(vend1.Id);

                if (vend1.Id <= 0)
                {
                    txtPass1.Enabled =
                    txtPass2.Enabled =
                    txtPass3.Enabled =
                    txtPass4.Enabled = false;
                    txtCode1.Focus();
                }
                else
                {
                    txtPass1.Enabled =
                    txtPass2.Enabled =
                    txtPass3.Enabled =
                    txtPass4.Enabled = true;
                    gpPinActual.Enabled = true;
                    txtPass1.Focus();
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (Vendedor_.Recuperado)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("dbo.[sp_update_vendedor_pin]", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_vendedor", Vendedor_.Id);
                    cmd.Parameters.AddWithValue("@pin", txtPassNew1.Text + txtPassNew2.Text + txtPassNew3.Text + txtPassNew4.Text);
                    cmd.ExecuteNonQuery();

                    CajaDialogo.Information("El PIN del vendedor ha sido actualizado correctamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
        }

        private void txtPass1_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPass1.Text))
            {
                txtPass2.Focus();
            }
        }

        private void txtPass1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 ||
               e.KeyCode == Keys.NumPad1 ||
               e.KeyCode == Keys.NumPad2 ||
               e.KeyCode == Keys.NumPad3 ||
               e.KeyCode == Keys.NumPad4 ||
               e.KeyCode == Keys.NumPad5 ||
               e.KeyCode == Keys.NumPad6 ||
               e.KeyCode == Keys.NumPad7 ||
               e.KeyCode == Keys.NumPad8 ||
               e.KeyCode == Keys.NumPad9 ||
               e.KeyCode == Keys.NumPad0)
            {
                if (txtPass1.Text.Length > 0)
                    txtPass1.Text = string.Empty;
            }
            else
            {
                if (e.KeyCode == Keys.Back)
                {
                    //lblNombreUser.Text = string.Empty;
                }
            }
        }

        private void txtPass1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtPass2_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPass2.Text))
            {
                txtPass3.Focus();
            }

        }

        private void txtPass2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                txtPass1.Focus();
            }
            else
            {
                if (e.KeyCode == Keys.NumPad0 ||
                   e.KeyCode == Keys.NumPad1 ||
                   e.KeyCode == Keys.NumPad2 ||
                   e.KeyCode == Keys.NumPad3 ||
                   e.KeyCode == Keys.NumPad4 ||
                   e.KeyCode == Keys.NumPad5 ||
                   e.KeyCode == Keys.NumPad6 ||
                   e.KeyCode == Keys.NumPad7 ||
                   e.KeyCode == Keys.NumPad8 ||
                   e.KeyCode == Keys.NumPad9 ||
                   e.KeyCode == Keys.NumPad0)
                {
                    if (txtPass2.Text.Length > 0)
                        txtPass2.Text = string.Empty;
                }
            }
        }

        private void txtPass2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtPass3_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPass3.Text))
            {
                txtPass4.Focus();
            }
        }

        private void txtPass3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                txtPass2.Focus();
            }
            else
            {
                if (e.KeyCode == Keys.NumPad0 ||
                   e.KeyCode == Keys.NumPad1 ||
                   e.KeyCode == Keys.NumPad2 ||
                   e.KeyCode == Keys.NumPad3 ||
                   e.KeyCode == Keys.NumPad4 ||
                   e.KeyCode == Keys.NumPad5 ||
                   e.KeyCode == Keys.NumPad6 ||
                   e.KeyCode == Keys.NumPad7 ||
                   e.KeyCode == Keys.NumPad8 ||
                   e.KeyCode == Keys.NumPad9 ||
                   e.KeyCode == Keys.NumPad0)
                {
                    if (txtPass3.Text.Length > 0)
                        txtPass3.Text = string.Empty;
                }
            }
        }

        private void txtPass3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtPass4_EditValueChanged(object sender, EventArgs e)
        {

            //validate user
            LoginVendedor_();
        }

        private void txtPass4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                txtPass3.Focus();
            }
            else
            {
                if (e.KeyCode == Keys.NumPad0 ||
                   e.KeyCode == Keys.NumPad1 ||
                   e.KeyCode == Keys.NumPad2 ||
                   e.KeyCode == Keys.NumPad3 ||
                   e.KeyCode == Keys.NumPad4 ||
                   e.KeyCode == Keys.NumPad5 ||
                   e.KeyCode == Keys.NumPad6 ||
                   e.KeyCode == Keys.NumPad7 ||
                   e.KeyCode == Keys.NumPad8 ||
                   e.KeyCode == Keys.NumPad9 ||
                   e.KeyCode == Keys.NumPad0)
                {
                    if (txtPass4.Text.Length > 0)
                        txtPass4.Text = string.Empty;
                }
            }
        }

        private void txtPass4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void LoginVendedor_()
        {
            if (vVendedorLogeado != null)
            {
                if (string.IsNullOrEmpty(txtPass1.Text) ||
                    string.IsNullOrEmpty(txtPass2.Text) ||
                    string.IsNullOrEmpty(txtPass3.Text) ||
                    string.IsNullOrEmpty(txtPass4.Text)) //||
                    //string.IsNullOrEmpty(txtPass5.Text) ||
                    //string.IsNullOrEmpty(txtPass6.Text))
                    return;

                string pin = txtPass1.Text + txtPass2.Text + txtPass3.Text + txtPass4.Text;// + txtPass5.Text + txtPass6.Text;

                if (pin == vVendedorLogeado.PIN)
                {
                    NombreVendedor = vVendedorLogeado.NombreUser;
                    IdVendedorUser = vVendedorLogeado.Id;
                    CodigoVendedor = vVendedorLogeado.Codigo;
                    Vendedor_ = new Vendedor();
                    Vendedor_.Id = vVendedorLogeado.Id;
                    Vendedor_.Nombre = vVendedorLogeado.NombreUser;
                    Vendedor_.CodigoVendedor = vVendedorLogeado.Codigo;
                    Vendedor_.Recuperado = true;

                    gpPinNuevo.Enabled = true;
                    txtPassNew1.Focus();
                }
                else
                {
                    CajaDialogo.Error("El pin es incorrecto!");
                    txtPass1.Focus();
                }
            }
        }

        private void txtPassNew1_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassNew1.Text))
            {
                txtPassNew2.Focus();
            }
        }

        private void txtPassNew1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 ||
              e.KeyCode == Keys.NumPad1 ||
              e.KeyCode == Keys.NumPad2 ||
              e.KeyCode == Keys.NumPad3 ||
              e.KeyCode == Keys.NumPad4 ||
              e.KeyCode == Keys.NumPad5 ||
              e.KeyCode == Keys.NumPad6 ||
              e.KeyCode == Keys.NumPad7 ||
              e.KeyCode == Keys.NumPad8 ||
              e.KeyCode == Keys.NumPad9 ||
              e.KeyCode == Keys.NumPad0)
            {
                if (txtPassNew1.Text.Length > 0)
                    txtPassNew1.Text = string.Empty;
            }
            else
            {
                if (e.KeyCode == Keys.Back)
                {
                    //lblNombreUser.Text = string.Empty;
                }
            }
        }

        private void txtPassNew1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtPassNew2_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassNew2.Text))
            {
                txtPassNew3.Focus();
            }
        }

        private void txtPassNew2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 ||
             e.KeyCode == Keys.NumPad1 ||
             e.KeyCode == Keys.NumPad2 ||
             e.KeyCode == Keys.NumPad3 ||
             e.KeyCode == Keys.NumPad4 ||
             e.KeyCode == Keys.NumPad5 ||
             e.KeyCode == Keys.NumPad6 ||
             e.KeyCode == Keys.NumPad7 ||
             e.KeyCode == Keys.NumPad8 ||
             e.KeyCode == Keys.NumPad9 ||
             e.KeyCode == Keys.NumPad0)
            {
                if (txtPassNew2.Text.Length > 0)
                    txtPassNew2.Text = string.Empty;
            }
            else
            {
                if (e.KeyCode == Keys.Back)
                {
                    //lblNombreUser.Text = string.Empty;
                }
            }
        }

        private void txtPassNew2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtPassNew3_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassNew3.Text))
            {
                txtPassNew4.Focus();
            }
        }

        private void txtPassNew3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 ||
            e.KeyCode == Keys.NumPad1 ||
            e.KeyCode == Keys.NumPad2 ||
            e.KeyCode == Keys.NumPad3 ||
            e.KeyCode == Keys.NumPad4 ||
            e.KeyCode == Keys.NumPad5 ||
            e.KeyCode == Keys.NumPad6 ||
            e.KeyCode == Keys.NumPad7 ||
            e.KeyCode == Keys.NumPad8 ||
            e.KeyCode == Keys.NumPad9 ||
            e.KeyCode == Keys.NumPad0)
            {
                if (txtPassNew3.Text.Length > 0)
                    txtPassNew3.Text = string.Empty;
            }
            else
            {
                if (e.KeyCode == Keys.Back)
                {
                    //lblNombreUser.Text = string.Empty;
                }
            }
        }

        private void txtPassNew3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtPassNew4_EditValueChanged(object sender, EventArgs e)
        {
            cmdGuardar.Focus();
        }

        private void txtPassNew4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 ||
           e.KeyCode == Keys.NumPad1 ||
           e.KeyCode == Keys.NumPad2 ||
           e.KeyCode == Keys.NumPad3 ||
           e.KeyCode == Keys.NumPad4 ||
           e.KeyCode == Keys.NumPad5 ||
           e.KeyCode == Keys.NumPad6 ||
           e.KeyCode == Keys.NumPad7 ||
           e.KeyCode == Keys.NumPad8 ||
           e.KeyCode == Keys.NumPad9 ||
           e.KeyCode == Keys.NumPad0)
            {
                if (txtPassNew4.Text.Length > 0)
                    txtPassNew4.Text = string.Empty;
            }
            else
            {
                if (e.KeyCode == Keys.Back)
                {
                    //lblNombreUser.Text = string.Empty;
                }
            }
        }

        private void txtPassNew4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void checkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMostrar.Checked)
            {
                txtPassNew1.Properties.PasswordChar = '\0';
                txtPassNew2.Properties.PasswordChar = '\0';
                txtPassNew3.Properties.PasswordChar = '\0';
                txtPassNew4.Properties.PasswordChar = '\0';
            }
            else
            {
                txtPassNew1.Properties.PasswordChar = '●';
                txtPassNew2.Properties.PasswordChar = '●';
                txtPassNew3.Properties.PasswordChar = '●';
                txtPassNew4.Properties.PasswordChar = '●';
            }
        }
    }
}