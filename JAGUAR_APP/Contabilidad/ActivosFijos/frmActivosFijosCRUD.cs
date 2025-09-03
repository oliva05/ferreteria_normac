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
    public partial class frmActivosFijosCRUD : DevExpress.XtraEditors.XtraForm
    {
        public enum Operacion
        {
            Nuevo = 1,
            Modificar = 2,
            Consultar = 3
        }
        Operacion TOperacion;
        UserLogin UsuarioLogeado;

        public frmActivosFijosCRUD(frmActivosFijosCRUD.Operacion operacion, UserLogin userLogin)
        {
            InitializeComponent();
            TOperacion = operacion;
            UsuarioLogeado = userLogin;

            CSSControles();

            switch (TOperacion)
            {
                case Operacion.Nuevo:
                    break;
                case Operacion.Modificar:
                    break;
                case Operacion.Consultar:
                    break;
                default:
                    break;
            }
        }

        private void CSSControles()
        {
            var btnGuardar = new DevExpress.XtraEditors.SimpleButton
            {
                Text = "Guardar",
                Width = 120,
                Height = 38,
                ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder,
                Appearance = {
                    Font = new Font("Segoe UI", 10F),
                    BackColor = Color.FromArgb(0, 120, 215),
                    ForeColor = Color.White
                },
                AppearanceHovered = { BackColor = Color.FromArgb(0, 153, 255) },
                AppearancePressed = { BackColor = Color.FromArgb(0, 100, 180) }
            };
            btnGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;

        }
    }
}