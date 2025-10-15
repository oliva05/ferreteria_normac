using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace administracion.Huellas
{
    public partial class frmProcesando : Form
    {
        public frmProcesando()
        {
            InitializeComponent();
            
        }

        private void frmProcesando_Load(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;

            //Thread.Sleep(5000);
           // Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
