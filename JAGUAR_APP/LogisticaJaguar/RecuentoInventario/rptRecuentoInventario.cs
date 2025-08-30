using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using JAGUAR_PRO.Clases;
using ACS.Classes;
using System.Data.SqlClient;

namespace JAGUAR_PRO.LogisticaJaguar.RecuentoInventario
{
    public partial class rptRecuentoInventario : DevExpress.XtraReports.UI.XtraReport
    {
        bool IsComplete = false;
        public enum TipoVista
        {
            PendienteAprobacion = 1,
            Completado = 2
        }
        TipoVista tipoVista;
        public rptRecuentoInventario(int PidRecuento, rptRecuentoInventario.TipoVista tipo)
        {
            InitializeComponent();
            tipoVista = tipo;

            Clases.RecuentoInventario recuento = new Clases.RecuentoInventario();
            if (recuento.RecuperarRegistros(PidRecuento))
            {
                lblNumero.Text = recuento.DocNum;
                lblBodega.Text = recuento.Bodega;
                lblFecha.Text = recuento.FechaCreacion.ToString("dd/MM/yyyy HH:mm:ss");
                lblUsuarioCreador.Text = recuento.UsuarioCreador.ToString();
                lblEstado.Text = recuento.Estado;
                lblUsuarioCreador.Text = recuento.UsuarioCreadorNombre;
                lblUsuarioAutorizado.Text = recuento.UsuarioAprobadorNombre;

                PDV PuntoVenta1 = new PDV();
                if (PuntoVenta1.RecuperaRegistro(recuento.PuntoVentaId))
                {
                    lblRTN.Text = "R.T.N. " + PuntoVenta1.RTN;
                    lblRTN.Visible = lblmail.Visible = lblDireccion.Visible = true;
                    lblmail.Text = PuntoVenta1.Correo;
                    lblDireccion.Text = PuntoVenta1.Direccion;
                    lblTelefono.Text = "Telefono: " + PuntoVenta1.Telefono;
                    lblLegalName.Text = PuntoVenta1.NombreLegal;
                    lblCompanyName.Text = PuntoVenta1.Nombre;
                }

                
                GetResumenTotal(PidRecuento);

                switch (tipoVista)
                {
                    case TipoVista.PendienteAprobacion:
                        xrTable2.Visible = false;
                        xrTotalLps.Text = "Re Chequeo";
                        GetDetalleRecuento(PidRecuento, IsComplete = false);
                        break;

                    case TipoVista.Completado:
                        xrTable2.Visible = true;
                        GetDetalleRecuento(PidRecuento, IsComplete = true);
                        break;

                    default:

                        break;
                }

            }

        }

        private void GetResumenTotal(int PidRecuento)
        {
            try
            {
                string query = @"sp_rpt_get_resumen_total";
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idRecuento", PidRecuento);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    xrTableTotal.Text = string.Format("{0:N2}", dr["impacto_total"]);
                    xrTablePerdidas.Text = string.Format("{0:N2}", dr["total_perdidas"]);
                    xrTableGanancias.Text = string.Format("{0:N2}", dr["total_ganancias"]);
                    dr.Close();
                }
                conn.Close();




            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void GetDetalleRecuento(int PidRecuento, bool pIsComplete)
        {
            try
            {
                string query = @"[sp_rpt_get_recuento_inventarioV2]";
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idRecuento", PidRecuento);
                cmd.Parameters.AddWithValue("@IsComplete", pIsComplete);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsRecuento1.rpt_detalle_recuento.Clear();
                adat.Fill(dsRecuento1.rpt_detalle_recuento);
                conn.Close();


                

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}
