using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_PRO.Clases
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string PIN { get; set; }
        public string CodigoVendedor { get; set; }
        public bool Recuperado { get; set; }

        public Vendedor()
        {
        }

        public bool RecuperarRegistro(string pCodigo)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[sp_get_vendedor_id_name_and_pin]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", pCodigo);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    Id = Convert.ToInt32(dr["id"]);
                    Nombre = dr["nombre"].ToString();
                    PIN = dr["pin"].ToString();
                    Recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }
        public bool RecuperarRegistro(int pIdVendedor)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[sp_get_vendedor_id_name_and_pin_by_id]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pIdVendedor);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = Convert.ToInt32(dr["id"]);
                    Nombre = dr["nombre"].ToString();
                    PIN = dr["pin"].ToString();
                    CodigoVendedor = dr["codigo"].ToString();
                    Recuperado = true;
                }
                dr.Close();
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
