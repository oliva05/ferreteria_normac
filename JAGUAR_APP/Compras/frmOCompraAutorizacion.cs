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

namespace JAGUAR_PRO.Compras
{
    public partial class frmOCompraAutorizacion : DevExpress.XtraEditors.XtraForm
    {
        public int Respuesta = 0;
        //1 Autorizado
        //2 Rechazado

        public frmOCompraAutorizacion()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cdmAprobar_Click(object sender, EventArgs e)
        {
            Respuesta = 1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cdmRechazar_Click(object sender, EventArgs e)
        {
            Respuesta = 2;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}