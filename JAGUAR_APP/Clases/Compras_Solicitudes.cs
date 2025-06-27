using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_PRO.Clases
{
   public class SolicitudOC
   {
        public SolicitudOC() { }
        public int Id { get; set; }

        public string Comentario { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public int IdEstado { get; set; }
        public bool Enable { get; set; }
        public int IdUserCre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdUserModi { get; set; }
        public DateTime FechaModi { get; set; }
        public string UsuarioCreacion { get; set; }
        public string DocNum { get; set; } 
        public bool Recuperado { get; set; }
        public string Estado { get; set; }

        public bool RecuperarRegistros(int idSolicitud)
        {
            DataOperations dp = new DataOperations();
            try
            {
                using (SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    string query = @"sp_get_compras_solicitud_class";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idSolicitud", idSolicitud);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Id = reader.GetInt32(0);
                        Comentario = reader.IsDBNull(reader.GetOrdinal("comentario")) ? "" : reader.GetString(reader.GetOrdinal("comentario"));
                        FechaSolicitud = reader.GetDateTime(reader.GetOrdinal("fecha_solicitud"));
                        IdEstado = reader.IsDBNull(reader.GetOrdinal("id_estado")) ? 0 : reader.GetInt32(reader.GetOrdinal("id_estado"));
                        Enable = reader.GetBoolean(reader.GetOrdinal("enable"));
                        IdUserCre = reader.IsDBNull(reader.GetOrdinal("id_user_cre")) ? 0 : reader.GetInt32(reader.GetOrdinal("id_user_cre"));
                        FechaCreacion = reader.GetDateTime(reader.GetOrdinal("fecha_creacion"));
                        UsuarioCreacion = reader.IsDBNull(reader.GetOrdinal("user_creador")) ? "" : reader.GetString(reader.GetOrdinal("user_creador"));
                        IdUserModi = reader.IsDBNull(reader.GetOrdinal("id_user_modi")) ? 0 : reader.GetInt32(reader.GetOrdinal("id_user_modi"));
                        FechaModi =  reader.GetDateTime(reader.GetOrdinal("fecha_modi"));
                        DocNum = reader.IsDBNull(reader.GetOrdinal("doc_num")) ? "" : reader.GetString(reader.GetOrdinal("doc_num"));
                        Estado = reader.IsDBNull(reader.GetOrdinal("estado")) ? "" : reader.GetString(reader.GetOrdinal("estado")); 
                        Recuperado = true;

                    }
                    reader.Close();
                    

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                Recuperado = false;
            }
            
            return Recuperado;
        }


   }


}
