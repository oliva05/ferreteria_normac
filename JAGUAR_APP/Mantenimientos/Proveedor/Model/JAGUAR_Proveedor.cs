using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_PRO.Mantenimientos.Proveedor.Model
{
   public class JAGUAR_Proveedor
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string RTN { get; set; }
        public string Direccion { get; set; }
        public string Codigo { get; set; }
        public bool Recuperado { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public bool RecuperarRegistro(int pId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.usp_get_selected_proveedor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pId);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ID = pId;
                    Codigo = dr.GetString(1); //dr.GetDouble(5);
                    Nombre = dr.GetString(2);
                    RTN = dr.GetString(3);
                    Direccion = dr.GetString(4);
                    FechaCreacion = Convert.IsDBNull(dr["FechaCreacion"]) ? (DateTime?)null : Convert.ToDateTime(dr["FechaCreacion"]);
                    UsuarioCreador = dr.GetString(6);
                    FechaModificacion = Convert.IsDBNull(dr["FechaModificacion"]) ? (DateTime?)null : Convert.ToDateTime(dr["FechaModificacion"]);
                    UsuarioModificacion = dr.IsDBNull(dr.GetOrdinal("usuario_modificacion")) ? "" : dr.GetString(dr.GetOrdinal("usuario_modificacion"));

                    Recuperado = true;
                }
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }
    }
}
