using ACS.Classes;
using DevExpress.Export;
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

namespace JAGUAR_PRO.Contabilidad.CuentasContables
{
    public partial class frmCuentasContablesCRUD : DevExpress.XtraEditors.XtraForm
    {
        public enum Operacion
        {
            Nuevo = 1,
            Modificar = 2,
            Consultar = 3
        }
        UserLogin UsuarioLogeado;
        int IdCuenta = 0;
        Clases.CuentasContables cc = new Clases.CuentasContables();
        Operacion OperacionActual;
        public frmCuentasContablesCRUD(frmCuentasContablesCRUD.Operacion operacion, UserLogin userLogin, int Pidcuenta)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
            IdCuenta = Pidcuenta;
            OperacionActual = operacion;
            CrearDataTipoCuenta();
            switch (OperacionActual)
            {
                case Operacion.Nuevo:
                    break;
                case Operacion.Modificar:
                    cc.RecuperarRegistros(IdCuenta);


                    break;
                case Operacion.Consultar:
                    break;
                default:
                    break;
            }


        }

        private void CrearDataTipoCuenta()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));

            dt.Rows.Add("A", "Activo");
            dt.Rows.Add("P", "Pasivo");
            dt.Rows.Add("C", "Capital");
            dt.Rows.Add("I", "Inactivo");
            dt.Rows.Add("G", "Gasto");

            dsCuentasC1.tipo_cuenta.Clear();

            foreach (DataRow row in dt.Rows)
            {
                var nuevaFila = dsCuentasC1.tipo_cuenta.Newtipo_cuentaRow();
                nuevaFila.Codigo = row["Codigo"].ToString();
                nuevaFila.Descripcion = row["Descripcion"].ToString();
                dsCuentasC1.tipo_cuenta.Addtipo_cuentaRow(nuevaFila);
            }

            dsCuentasC1.tipo_cuenta.AcceptChanges();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoCuenta.Text))
            {
                CajaDialogo.Error(Name + " - El campo Codigo Cuenta es obligatorio.");
                return;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                CajaDialogo.Error(Name + " - El campo Nombre Cuenta es obligatorio.");
                return;
            }

            if (string.IsNullOrEmpty(grdTipoCuenta.Text))
            {
                CajaDialogo.Error(Name + " - El campo Nombre Cuenta es obligatorio.");
                return;
            }

            switch (OperacionActual)
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
    }
}