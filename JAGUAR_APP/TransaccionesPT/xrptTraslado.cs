using ACS.Classes;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using JAGUAR_PRO.Clases;

namespace JAGUAR_PRO.TransaccionesPT
{
    public partial class xrptTraslado : DevExpress.XtraReports.UI.XtraReport
    {
        public xrptTraslado(int IdTraslado)
        {
            InitializeComponent();

            GetHeader(IdTraslado);

        }

        private void GetHeader(int IdTraslado)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_pt_rpt_traslados_by_id_traslado]",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_traslado", IdTraslado);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lblNumTraslado.Text = "# Traslado " + dr.GetString(0);
                    lblFecha.Text = string.Format("{0:d}",dr.GetDateTime(2));
                    lblUsuario.Text = dr.GetString(3);
                    lblAlmOrigen.Text = dr.GetString(4);
                    lblAlmDestino.Text = dr.GetString(5);
                    dr.Close();
                }
                dr.Close();
                conn.Close();
                GetDetalle(IdTraslado);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void GetDetalle(int idTraslado)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_pt_get_detalle_traslado", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_traslado", idTraslado);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPT1.rpt_detalle_traslado.Clear();
                adat.Fill(dsPT1.rpt_detalle_traslado);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);  

            }
        }
    }
}
