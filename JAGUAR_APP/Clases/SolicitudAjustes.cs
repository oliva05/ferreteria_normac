using ACS.Classes;
using DevExpress.XtraRichEdit.Import.Rtf;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_PRO.Clases
{
    public class SolicitudAjustes
    {
        public SolicitudAjustes() { }

        public int Id { get; set; }
        public string Comentario { get; set; }
        public int? UsuarioSolicitante { get; set; }
        public DateTime FechaSolicitada { get; set; }
        public int? IdEstado { get; set; }
        public bool? Enable { get; set; }
        public string DocNum { get; set; }
        public int? UsuarioAprobador { get; set; }
        public bool Recuperado { get; set; }
        public string nameUsuarioSolicitante { get; set; }

        public bool RecuperarRegistros(int id)
        {
            Recuperado = false;

            string query = @"sp_Get_LOSA_Kardex_Solicitud_Ajuste_h";
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            Id = reader.GetInt32(reader.GetOrdinal("id"));
                            Comentario = reader.GetString(reader.GetOrdinal("comentario"));
                            UsuarioSolicitante = reader.GetInt32(reader.GetOrdinal("usuario_solicitante"));
                            FechaSolicitada = reader.GetDateTime(reader.GetOrdinal("fecha_solicitada"));
                            IdEstado = reader.GetInt32(reader.GetOrdinal("id_estado"));
                            DocNum = reader.GetString(reader.GetOrdinal("docnum"));
                            UsuarioAprobador = reader.IsDBNull(reader.GetOrdinal("usuario_aprobador")) ? 0 : reader.GetOrdinal("usuario_aprobador");
                            nameUsuarioSolicitante = reader.GetString(reader.GetOrdinal("nameUsuarioSolicitante"));

                            reader.Close();
                        }
                    }conn.Close();

                }
            }
            catch (Exception EX)
            {

                CajaDialogo.Error(EX.Message);
            }

            return Recuperado;
        }

    }
}
