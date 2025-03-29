using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_PRO.Clases
{
    public class ProductoSubClase
    {
        public int IdSubClase { get; set; }
        public int IdClase { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public bool Enable { get; set; }
        public bool Recuperado { get; set; }


        private string connectionString = "your_connection_string_here";

        public bool ObtenerPorId(int id)
        {
            DataOperations dp = new DataOperations();
            connectionString = dp.ConnectionStringJAGUAR_DB;
            Recuperado = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id_subClase, id_clase, nombre, codigo, enable FROM PT_Producto_SubClase WHERE id_subClase = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        IdSubClase = Convert.ToInt32(reader["id_subClase"]);
                        IdClase = Convert.ToInt32(reader["id_clase"]);
                        Nombre = reader["nombre"].ToString();
                        Codigo = reader["codigo"].ToString();
                        Enable = Convert.ToBoolean(reader["enable"]);
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
