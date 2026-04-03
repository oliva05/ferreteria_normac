using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_PRO.Clases;
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

namespace JAGUAR_PRO.Facturacion.Reportes.Reportes_de_Ventas
{
    public partial class frmReporteFletes : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp;
        UserLogin UsuarioLogeado;
        public frmReporteFletes(UserLogin pUsuario)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuario;
            dp = new DataOperations();

            DateTime fechaActual = dp.NowSetDateTime();
            DateTime FechaInicial = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, 0, 0, 0);
            DateTime FechaFinal = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, 23, 59, 0);

            dtDesde.EditValue = FechaInicial;
            dtHasta.EditValue = FechaFinal;

            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_detalle_fletes_facturados_por_fecha]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReportesDeVenta1.detalle_fletes.Clear();
                adat.Fill(dsReportesDeVenta1.detalle_fletes);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            LoadDatos();
        }
    }
}