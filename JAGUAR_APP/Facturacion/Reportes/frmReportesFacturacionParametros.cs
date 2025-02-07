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

namespace JAGUAR_PRO.Facturacion.Reportes
{
    public partial class frmReportesFacturacionParametros : DevExpress.XtraEditors.XtraForm
    {
        int IdReporteActual;
        public frmReportesFacturacionParametros(int idReporte)
        {
            InitializeComponent();
            IdReporteActual = idReporte;
            LoadComportamiento();
        }

        private void LoadComportamiento()
        {
            switch(IdReporteActual)
            {
                case 1:
                    NavigationFrameParametro.SelectedPage = nvPage1;
                    break; 
                case 2:
                    NavigationFrameParametro.SelectedPage = nvPage2;
                    break;
                case 3:
                    break;
                default:
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                    break;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}