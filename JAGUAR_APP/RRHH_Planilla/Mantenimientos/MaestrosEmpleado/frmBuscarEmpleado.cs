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

namespace JAGUAR_PRO.RRHH_Planilla.Mantenimientos.MaestrosEmpleado
{
    public partial class frmBuscarEmpleado : DevExpress.XtraEditors.XtraForm
    {
        public Empleado EmpleadoBusqueda;
        public frmBuscarEmpleado(UserLogin pUser)
        {
            InitializeComponent();
        }
    }
}