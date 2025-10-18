using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace administracion.Huellas
{
    public partial class frmProcesando : Form
    {
        private int elapsedTime = 0;
        private int duration = 1000; // milisegundos (1 segundo)
        public frmProcesando()
        {
            InitializeComponent();
            InicializarProgressBar();
        }

        private void frmProcesando_Load(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
            //progressBar1.po
            //Thread.Sleep(5000);
            // Close();
        }
        private void InicializarProgressBar()
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            //timer = new Timer();
            timer1.Interval = 50; // se actualiza cada 10 ms
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime += timer1.Interval;

            // calcular porcentaje
            int progress = (int)((double)elapsedTime / duration * 100);

            if (progress > 100)
            {
                progress = 100;
                timer1.Stop();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            progressBar1.Value = progress;
        }
    }
}
