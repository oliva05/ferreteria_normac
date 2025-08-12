using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.TransaccionesPT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO.LogisticaJaguar.RecuentoInventario
{
    public partial class frmRecuentoInventarioDetalle : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        PDV PuntoVentaActual;
        public frmRecuentoInventarioDetalle(UserLogin userLogin,PDV puntoVentaActual)
        {
            InitializeComponent();
            PuntoVentaActual = puntoVentaActual;
            UsuarioLogeado = userLogin;

        }

        private void gleAlmacen_EditValueChanged(object sender, EventArgs e)
        {
            int id_bodega = Convert.ToInt32(gleAlmacen.EditValue);
            if (id_bodega != 0)
            {
                LoadInvAlmacenes(id_bodega);

                dsRecuento1.productos_conteo.Clear();
            }
        }

        private void LoadInvAlmacenes(int id_bodega)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_pt_inventario_by_almacen_by_recuento]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_almacen", id_bodega);
                dsRecuento1.productos_conteo.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecuento1.productos_conteo);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {

            int id_bodeg_origen = Convert.ToInt32(gleAlmacen.EditValue);

            var existentes = new HashSet<string>(
                dsRecuento1.productos_conteo.AsEnumerable()
                .Select(r => $"{r.Field<string>("code_pt")}|{r.Field<string>("id_bodega")}")
            );

            foreach (var fila in dsRecuento1.seleccion_producots.AsEnumerable().Where(r => r.Field<bool>("seleccion")))
            {
                string clave = $"{fila.Field<string>("code_pt")}|{fila.Field<string>("id_bodega")}";

                if (!existentes.Contains(clave))
                {
                    dsRecuento1.productos_conteo.ImportRow(fila); // o clonar como necesites
                    existentes.Add(clave); // añadir para evitar duplicados
                }
            }
        }
    }
}