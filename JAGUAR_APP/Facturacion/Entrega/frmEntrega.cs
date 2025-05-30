using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_PRO.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO.Facturacion.Entrega
{
    public partial class frmEntrega : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmEntrega(UserLogin pUserLogin)
        {
            InitializeComponent();

            UsuarioLogeado = pUserLogin;

            //Generar factura
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (EquipoActual.id_bodega_entrega == 0)
                {
                    CajaDialogo.Error("Este Equipo de nombre: " + HostName + " no tiene una Bodega de Entrega configurada!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            

        }
    }
}