using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_PRO.Clases
{
    public class ProductoCategoria
    {
        public int Id { get; set; }
        public int IdFamilia { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool Enable { get; set; }
        public bool Recuperado { get; set; }  
        public int IdSig { get; set; }

        private string connectionString = "your_connection_string_here";

        public bool ObtenerPorId(int id)
        {
            DataOperations dp = new DataOperations();
            connectionString = dp.ConnectionStringJAGUAR_DB;
            Recuperado = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id, id_familia, codigo, descripcion, enable, id_sig FROM PT_Producto_Categoria WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Id = Convert.ToInt32(reader["id"]);
                        IdFamilia = Convert.ToInt32(reader["id_familia"]);
                        Codigo = reader["codigo"].ToString();
                        Descripcion = reader["descripcion"].ToString();
                        Enable = Convert.ToBoolean(reader["enable"]);
                        IdSig = Convert.ToInt32(reader["id_sig"]);
                        Recuperado = true;
                        return true;
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public int ObtenerIdSigCategoria()
        {
            int idSig = 0;
            DataOperations dp = new DataOperations();
            connectionString = dp.ConnectionStringJAGUAR_DB;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "sp_pt_get_table_id_sig_cat";
                SqlCommand command = new SqlCommand(query, connection); 
                command.CommandType = System.Data.CommandType.StoredProcedure;
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) 
                    {
                        IdSig = Convert.ToInt32(reader["id_siguiente"]);
                        
                    }

                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                    return idSig;
                }
            }

            return IdSig;
        }
    }
}
