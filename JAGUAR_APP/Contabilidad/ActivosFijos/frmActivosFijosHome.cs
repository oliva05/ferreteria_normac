using DevExpress.XtraEditors;
using JAGUAR_PRO.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO.Contabilidad.ActivosFijos
{
    public partial class frmActivosFijosHome : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        
        public frmActivosFijosHome(UserLogin userLogin)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmActivosFijosCRUD frm = new frmActivosFijosCRUD(frmActivosFijosCRUD.Operacion.Nuevo, UsuarioLogeado, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }

        }
    }
}