using ACS.Classes;
using DevExpress.CodeParser;
using JAGUAR_PRO.Reportes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.DataProcessing.InMemoryDataProcessor.AddSurrogateOperationAlgorithm;

namespace JAGUAR_PRO.Clases
{
    public class Marcas
    {
        int idMarca;
        string nombre;
        string descripcion;
        string sitioWeb;
        bool estado;
        string pais;

        public int IdMarca { get => idMarca; set => idMarca = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string SitioWeb { get => sitioWeb; set => sitioWeb = value; }
        public bool Estado { get => estado; set => estado = value; }
        public string Pais { get => pais; set => pais = value; }

        DataOperations dp = new DataOperations();

        public bool RecuperarRegistros(int pIdMarca)
        {
            bool Recuperar = false;


            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_pt_get_marcas_clase",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_marca", pIdMarca);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IdMarca = reader.GetInt32(reader.GetOrdinal("id_marca"));
                    Nombre = reader.IsDBNull(reader.GetOrdinal("nombre")) ? "N/D" : reader.GetString(reader.GetOrdinal("nombre"));
                    Descripcion = reader.IsDBNull(reader.GetOrdinal("descripcion")) ? "" : reader.GetString(reader.GetOrdinal("descripcion"));
                    SitioWeb = reader.IsDBNull(reader.GetOrdinal("sitio_web")) ? "" : reader.GetString(reader.GetOrdinal("sitio_web"));
                    Estado = (bool)(reader.IsDBNull(reader.GetOrdinal("estado")) ? false : (bool?)reader.GetBoolean(reader.GetOrdinal("estado")));
                    Pais = reader.IsDBNull(reader.GetOrdinal("pais_origen")) ? "" : reader.GetString(reader.GetOrdinal("pais_origen"));
                }
                Recuperar = true;
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            return Recuperar;
        }
    }
}
