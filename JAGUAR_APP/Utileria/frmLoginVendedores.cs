using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO.Utileria
{
    public partial class frmLoginVendedores : DevExpress.XtraEditors.XtraForm
    {
        public frmLoginVendedores()
        {
            InitializeComponent();
            LimpiarControlesCodigo();
        }

        private void LimpiarControlesCodigo()
        {
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
            }
        }

        private void txtCode4_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back)
            {
                if(txtCode4.Text == string.Empty) 
                { 
                    txtCode3.Focus(); 
                }
                
            }
        }
    }
}