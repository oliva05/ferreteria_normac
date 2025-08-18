using ACS.Classes;
using JAGUAR_PRO.Mantenimientos.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_PRO.Clases
{
    public class RecuentoInventario
    {

        public int IdRecuento { get; set; }  //0
        public DateTime FechaCreacion { get; set; }  //1
        public int UsuarioCreador { get; set; }   //2
        public int UsuarioAprobador { get; set; } //3
        public DateTime? FechaAprobacion { get; set; } //4 (nullable)
        public string Estado { get; set; }   //5
        public string DocNum { get; set; }      //6
        public int PuntoVentaId { get; set; } //7
        public int IdBodega { get; set; }    //8
        public string Bodega { get; set; }   //9
        public int EstadoId { get; set; } //10
        public bool Recuperado { get; set; }


        public bool RecuperarRegistros(int IdRecuento)
        {
            Recuperado = false;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_recuento_class", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idRecuento", IdRecuento);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdRecuento = dr.GetInt32(0);
                    FechaCreacion = dr.GetDateTime(1);
                    UsuarioCreador =  dr.GetInt32(2);
                    UsuarioAprobador = dr.GetInt32(3);
                    Estado = dr.IsDBNull(5) ? "" : dr.GetString(5);
                    DocNum = dr.IsDBNull(6) ? "" : dr.GetString(6);
                    PuntoVentaId = dr.GetInt32(7);
                    IdBodega = dr.GetInt32(8);
                    Bodega = dr.IsDBNull(9) ? "" : dr.GetString(9);
                    EstadoId = dr.GetInt32(10);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }



            return Recuperado;
        }

    }

   
}
