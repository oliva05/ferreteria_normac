using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACS.Classes;
using System.Windows.Forms;

namespace JAGUAR_PRO.Clases
{
    
    public class RequisaTraslado
    {
        public RequisaTraslado()
        {
        }

        DataOperations dp = new DataOperations();
        public int Id { get; set; }

        public int IdTraslado { get; set; }
        public string Descripcion { get; set; }
        public DateTime? Fecha { get; set; }
        public int? UserId { get; set; }
        public string Usuario { get; set; }
        public int? BodegaOrigen { get; set; }
        public int? BodegaDestino { get; set; }
        public bool? Enable { get; set; }
        public int? IdEstado { get; set; }
        public string NumRequisa { get; set; }
        public string NumTraslado { get; set; }
        public bool Recuperado { get; set; }

        public string Origen { get; set; }
        public string Destino { get; set; }
        public bool RecuperarRegistros(int Id)
        {
            Recuperado = false;
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_requisa_traslado_class", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id",Id);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(dr.GetOrdinal("id"));
                    Descripcion = dr.IsDBNull(dr.GetOrdinal("descripcion")) ? "" : dr.GetString(dr.GetOrdinal("descripcion"));
                    Fecha = (DateTime)(dr.IsDBNull(dr.GetOrdinal("fecha")) ? null : (DateTime?)dr.GetDateTime(dr.GetOrdinal("fecha")));
                    UserId = (int)(dr.IsDBNull(dr.GetOrdinal("user_id")) ? null : (int?)dr.GetInt32(dr.GetOrdinal("user_id")));
                    Usuario = dr.IsDBNull(dr.GetOrdinal("usuario")) ? "" : dr.GetString(dr.GetOrdinal("usuario"));
                    BodegaOrigen = (int)(dr.IsDBNull(dr.GetOrdinal("bodega_origen")) ? null : (int?)dr.GetInt32(dr.GetOrdinal("bodega_origen")));
                    BodegaDestino = (int)(dr.IsDBNull(dr.GetOrdinal("bodega_destino")) ? null : (int?)dr.GetInt32(dr.GetOrdinal("bodega_destino")));
                    IdEstado = (int)(dr.IsDBNull(dr.GetOrdinal("id_estado")) ? null : (int?)dr.GetInt32(dr.GetOrdinal("id_estado")));
                    NumRequisa = dr.IsDBNull(dr.GetOrdinal("num_requisa")) ? "" : dr.GetString(dr.GetOrdinal("num_requisa"));
                    Enable = (bool)(dr.IsDBNull(dr.GetOrdinal("enable")) ? false : (bool?)dr.GetBoolean(dr.GetOrdinal("enable")));
                    Recuperado = true;
                }
                dr.Close();
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            return Recuperado;
        }

        public bool RecuperarRegistrosTraslado(int Id)
        {
            Recuperado = false;
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_get_traslado_class]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Id);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdTraslado = dr.GetInt32(dr.GetOrdinal("[id_traslado]"));
                    Descripcion = dr.IsDBNull(dr.GetOrdinal("[descripcion]")) ? "" : dr.GetString(dr.GetOrdinal("[descripcion]"));
                    Fecha = (DateTime)(dr.IsDBNull(dr.GetOrdinal("[fecha]")) ? null : (DateTime?)dr.GetDateTime(dr.GetOrdinal("[fecha]")));
                    UserId = (int)(dr.IsDBNull(dr.GetOrdinal("user_id")) ? null : (int?)dr.GetInt32(dr.GetOrdinal("user_id")));
                    Usuario = dr.IsDBNull(dr.GetOrdinal("usuario")) ? "" : dr.GetString(dr.GetOrdinal("usuario"));
                    BodegaOrigen = (int)(dr.IsDBNull(dr.GetOrdinal("[bodega_origen]")) ? null : (int?)dr.GetInt32(dr.GetOrdinal("[bodega_origen]")));
                    BodegaDestino = (int)(dr.IsDBNull(dr.GetOrdinal("[bodega_destino]")) ? null : (int?)dr.GetInt32(dr.GetOrdinal("[bodega_destino]")));
                    IdEstado = (int)(dr.IsDBNull(dr.GetOrdinal("[id_estado]")) ? null : (int?)dr.GetInt32(dr.GetOrdinal("[id_estado]")));
                    NumTraslado = dr.IsDBNull(dr.GetOrdinal("[num_traslado]")) ? "" : dr.GetString(dr.GetOrdinal("[num_traslado]"));
                    Enable = (bool)(dr.IsDBNull(dr.GetOrdinal("[enable]")) ? false : (bool?)dr.GetBoolean(dr.GetOrdinal("[enable]")));
                    Origen = dr.IsDBNull(dr.GetOrdinal("origen")) ? "" : dr.GetString(dr.GetOrdinal("origen"));
                    Destino = dr.IsDBNull(dr.GetOrdinal("destino")) ? "" : dr.GetString(dr.GetOrdinal("destino"));
                    Recuperado = true;
                }
                dr.Close();
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            return Recuperado;

        }

    }
}
