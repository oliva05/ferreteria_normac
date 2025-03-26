using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Facturacion.CoreFacturas;
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
using System.Windows.Input;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;

namespace JAGUAR_PRO.Utileria
{
    public partial class frmLoginVendedores : DevExpress.XtraEditors.XtraForm
    {
        UserLogin pVendedorLogeado;
        public frmLoginVendedores()
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
            txtPass5.Text = string.Empty;
            txtPass6.Text = string.Empty;
        }

        private void LimpiarControlesCodigo()
        {
            lblNombreUser.Text = string.Empty;
            txtCode1.Text = string.Empty;
            txtCode2.Text = string.Empty;
            txtCode3.Text = string.Empty;
            txtCode4.Text = string.Empty;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;    
            this.Close();
        }

        private void txtCode1_EditValueChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtCode1.Text))
            {
                txtCode2.Focus();
            }
        }

        private void txtCode2_EditValueChanged(object sender, EventArgs e)
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
                if(e.KeyCode == Keys.Enter)
                {
                    LoadDatosVendedor();
                }
            }
            //if (txtCode4.Text.Length > 0)
            //{
            //    LoadDatosVendedor();
            //}
        }

        private void LoadDatosVendedor()
        {
            string Codigo = txtCode1.Text + txtCode2.Text + txtCode3.Text + txtCode4.Text;

            Vendedor vend1 = new Vendedor();
            if (vend1.RecuperarRegistro(Codigo))
            {
                lblNombreUser.Text = vend1.Nombre;
                pVendedorLogeado = new UserLogin();
                pVendedorLogeado.RecuperarRegistro(vend1.Id);

                if (vend1.Id <= 0)
                {
                    txtPass1.Enabled =
                    txtPass2.Enabled =
                    txtPass3.Enabled =
                    txtPass4.Enabled =
                    txtPass5.Enabled =
                    txtPass6.Enabled = false;
                    txtCode1.Focus();
                }
                else
                {
                    txtPass1.Enabled =
                    txtPass2.Enabled =
                    txtPass3.Enabled =
                    txtPass4.Enabled =
                    txtPass5.Enabled =
                    txtPass6.Enabled = true;
                    txtPass1.Focus();
                }
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

        public static string GetKeyString(Keys e)
        {
            switch (e)
            {
                case Keys.A: return "A";
                case Keys.B: return "B";
                case Keys.C: return "C";
                case Keys.D: return "D";
                case Keys.E: return "E";
                case Keys.F: return "F";
                case Keys.G: return "G";
                case Keys.H: return "H";
                case Keys.I: return "I";
                case Keys.J: return "J";
                case Keys.K: return "K";
                case Keys.L: return "L";
                case Keys.M: return "M";
                case Keys.N: return "N";
                case Keys.O: return "O";
                case Keys.P: return "P";
                case Keys.Q: return "Q";
                case Keys.R: return "R";
                case Keys.S: return "S";
                case Keys.T: return "T";
                case Keys.U: return "U";
                case Keys.V: return "V";
                case Keys.W: return "W";
                case Keys.X: return "X";
                case Keys.Y: return "Y";
                case Keys.Z: return "Z";
                case Keys.D0: return "0";
                case Keys.D1: return "1";
                case Keys.D2: return "2";
                case Keys.D3: return "3";
                case Keys.D4: return "4";
                case Keys.D5: return "5";
                case Keys.D6: return "6";
                case Keys.D7: return "7";
                case Keys.D8: return "8";
                case Keys.D9: return "9";
                case Keys.NumPad0: return "0";
                case Keys.NumPad1: return "1";
                case Keys.NumPad2: return "2";
                case Keys.NumPad3: return "3";
                case Keys.NumPad4: return "4";
                case Keys.NumPad5: return "5";
                case Keys.NumPad6: return "6";
                case Keys.NumPad7: return "7";
                case Keys.NumPad8: return "8";
                case Keys.NumPad9: return "9";
                case Keys.Space: return " ";
                case Keys.Enter: return "Enter";
                case Keys.Back: return "Backspace";
                case Keys.Tab: return "Tab";
                //case Keys.Escape: return "Escape";
                //case Keys.LeftShift: return "Left Shift";
                //case Keys.RightShift: return "Right Shift";
                //case Keys.LeftCtrl: return "Left Ctrl";
                //case Keys.RightCtrl: return "Right Ctrl";
                //case Keys.LeftAlt: return "Left Alt";
                //case Keys.RightAlt: return "Right Alt";
                default: return "Unknown Key";
            }
        }

        private void txtCode1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.NumPad0 ||
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
                if(txtCode1.Text.Length > 0)
                    txtCode1.Text = string.Empty;
            }
            else
            {
                if(e.KeyCode == Keys.Back)
                {
                    lblNombreUser.Text = string.Empty;
                }
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

        private void txtPass2_KeyDown(object sender, KeyEventArgs e)
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
            else
            {
                if (e.KeyCode == Keys.Back)
                {
                    //lblNombreUser.Text = string.Empty;
                }
            }
        }

        private void txtPass3_KeyDown(object sender, KeyEventArgs e)
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
            else
            {
                if (e.KeyCode == Keys.Back)
                {
                    //lblNombreUser.Text = string.Empty;
                }
            }
        }

        private void txtPass4_KeyDown(object sender, KeyEventArgs e)
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
            else
            {
                if (e.KeyCode == Keys.Back)
                {
                    //lblNombreUser.Text = string.Empty;
                }
            }
        }

        private void txtPass5_KeyDown(object sender, KeyEventArgs e)
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
                if (txtPass5.Text.Length > 0)
                    txtPass5.Text = string.Empty;
            }
            else
            {
                if (e.KeyCode == Keys.Back)
                {
                    //lblNombreUser.Text = string.Empty;
                }
            }
        }

        private void txtPass6_KeyDown(object sender, KeyEventArgs e)
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
            else
            {
                if (e.KeyCode == Keys.Back)
                {
                    //lblNombreUser.Text = string.Empty;
                }
            }
        }
    }
}