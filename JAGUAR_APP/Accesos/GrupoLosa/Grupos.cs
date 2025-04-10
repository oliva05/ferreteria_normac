using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACS.Classes;

namespace JAGUAR_PRO.Accesos.GrupoLosa
{
    public class Grupos
    {
        DataOperations dp;
        public int Id { get; set; }
        public string Grupo { get; set; }
        public bool? Enable { get; set; } // Nullable porque en la tabla puede ser NULL
        public bool Recuperado { get; set; } = false;

        public bool RecuperarRegistros(int IdGrupo)
        {
            try
            {
                dp = new DataOperations();
                using (SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    conn.Open();

                    string query = "SELECT id, grupo, enable FROM dbo.conf_grupos_losa where id = " + IdGrupo;

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id"));
                            Grupo = reader.IsDBNull(reader.GetOrdinal("grupo")) ? null : reader.GetString(reader.GetOrdinal("grupo"));
                            Enable = reader.IsDBNull(reader.GetOrdinal("enable")) ? (bool?)null : reader.GetBoolean(reader.GetOrdinal("enable"));
                            Recuperado = true;
                            reader.Close();

                        }
                    }
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
