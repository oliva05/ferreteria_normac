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

namespace JAGUAR_PRO.LogisticaJaguar
{
    public partial class frmRecepcionCompraVentaUnicaEdit : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        int IdUsado;
        public frmRecepcionCompraVentaUnicaEdit(UserLogin userLogin, int pIdUsado)
        {
            InitializeComponent();

            IdUsado = pIdUsado;
            UsuarioLogeado = userLogin; 
            ProductoUsado pt1 = new ProductoUsado();
            if (pt1.RecuperarRegistro(pIdUsado))
            {

            }
        }
    }
}