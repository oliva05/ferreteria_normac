using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_PRO.Clases
{
    public class ProductoClase
    {
        public int IdClase { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public bool Enable { get; set; }
        public int IdCategoria { get; set; }
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
                string query = "SELECT id_clase, nombre, codigo, enable, id_categoria, id_sig FROM PT_Producto_Clase WHERE id_clase = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        IdClase = Convert.ToInt32(reader["id_clase"]);
                        Nombre = reader["nombre"].ToString();
                        Codigo = reader["codigo"].ToString();
                        Enable = Convert.ToBoolean(reader["enable"]);
                        IdCategoria = Convert.ToInt32(reader["id_categoria"]);
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
    }
}
