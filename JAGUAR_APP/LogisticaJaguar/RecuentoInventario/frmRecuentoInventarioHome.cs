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
using JAGUAR_PRO.RecuentoInventario;
using DevExpress.Xpo;
using ACS.Classes;

namespace JAGUAR_PRO.LogisticaJaguar.RecuentoInventario
{
    public partial class frmRecuentoInventarioHome : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        PDV PuntoVentaActual;

        public frmRecuentoInventarioHome(UserLogin userLogin, PDV pDV)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
            PuntoVentaActual = pDV;

            LoadData();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmRecuentoInventarioDetalle frm = new frmRecuentoInventarioDetalle(UsuarioLogeado, PuntoVentaActual);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            try
            {

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}