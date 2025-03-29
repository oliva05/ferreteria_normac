using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_PRO.Clases
{
    public class ProductoFamilia
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Enable { get; set; }
        public string Codigo { get; set; }
        public bool Recuperado;

        private string connectionString = "your_connection_string_here";

        public bool ObtenerPorId(int id)
        {
            DataOperations dp = new DataOperations();
            connectionString = dp.ConnectionStringJAGUAR_DB;
            Recuperado = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id, descripcion, enable, codigo FROM PT_Producto_familia WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Id = Convert.ToInt32(reader["id"]);
                        Descripcion = reader["descripcion"].ToString();
                        Enable = Convert.ToBoolean(reader["enable"]);
                        Codigo = reader["codigo"].ToString();
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
    }
}
