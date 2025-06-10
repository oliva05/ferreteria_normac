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

namespace JAGUAR_PRO.TransaccionesPT
{
    public partial class frmTrasladoGestionKardexOP : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        int IdH;
        public frmTrasladoGestionKardexOP(UserLogin userLogin, int idH)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
            IdH = idH;
            txtUsuario.Text = UsuarioLogeado.Nombre;

            RequisaTraslado traslado = new RequisaTraslado();
            if (traslado.RecuperarRegistrosTraslado(IdH))
            {
                txtNumTraslado.Text = traslado.NumTraslado;
                txtDescr.Text = traslado.Descripcion;
                txtBodOrigen.Text = traslado.Origen;
                txtBodDestino.Text = traslado.Destino;

                //CargarDetalle
                LoadDetalleDestino(IdH);
            }
        }

        private void LoadDetalleDestino(int idH)
        {
            try
            {
                string query = @"sp_get_requisa_traslado_detalle";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTraslado", idH);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPT1.almacen_destino.Clear();
                adat.Fill(dsPT1.almacen_destino);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}