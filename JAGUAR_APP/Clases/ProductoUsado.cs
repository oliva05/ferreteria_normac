using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO.Clases
{
    public  class ProductoUsado
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string ItemCode { get; set; }
        public decimal? Costo { get; set; }
        public decimal? Margen { get; set; }
        public decimal PrecioVenta { get; set; }
        public bool? Enable { get; set; }
        public string Barcode { get; set; }
        public string Correlativo { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public int? UserId { get; set; }
        public int? IdBodega { get; set; }
        public int? IdPT { get; set; }

        public ProductoUsado()
        {

        }
        public decimal Recuperar_Cant_Inv_Actual_PT_for_facturacionUsados(int IdProd, int pIdPuntoVenta)
        {
            decimal val = 0;
            try
            {//Recupera las caracteristicas 
                //string sql = @"[dbo].[jaguar_sp_get_cantidad_inv_kardex_pt_for_facturacion_v2]";
                string sql = @"[dbo].[jaguar_sp_get_cantidad_inv_usados]";

                DataOperations dp = new DataOperations();

                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", IdProd);
                //cmd.Parameters.AddWithValue("@id_punto_facturacion", pIdPuntoVenta);
                SqlDataReader dl = cmd.ExecuteReader();
                if (dl.Read())
                {
                    val = dl.GetDecimal(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return val;
        }

        public bool RecuperarRegistro(int id)
        {
            // Ejemplo de conexión - ajustar cadena de conexión según tu entorno
            DataOperations dp = new DataOperations();
            string connectionString = dp.ConnectionStringJAGUAR_DB;
            string query = "sp_get_producto_usado_for_factura";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id"));
                        Descripcion = reader["descripcion"] as string;
                        ItemCode = reader["itemcode"] as string;
                        Costo = reader["costo"] as decimal?;
                        Margen = reader["margen"] as decimal?;

                        PrecioVenta = Convert.ToDecimal(reader["precio_venta"]);
                        Enable = reader["enable"] as bool?;
                        Barcode = reader["barcode"] as string;
                        Correlativo = reader["correlativo"] as string;
                        FechaIngreso = reader["fecha_ingreso"] as DateTime?;
                        UserId = reader["user_id"] as int?;
                        IdBodega = reader["id_bodega"] as int?;
                        IdPT = reader["id_pt"] as int?;
                        return true;

                        // Validar que ninguna propiedad sea null (solo para campos no anulables si aplica)
                        //return Descripcion != null &&
                        //       ItemCode != null &&
                        //       Costo.HasValue &&
                        //       Margen.HasValue &&
                        //       PrecioVenta.HasValue &&
                        //       Enable.HasValue &&
                        //       Barcode != null &&
                        //       Correlativo != null &&
                        //       FechaIngreso.HasValue &&
                        //       UserId.HasValue &&
                        //       IdBodega.HasValue &&
                        //       IdPT.HasValue;
                    }
                }
            }

            return false; // No se encontró el registro
        }
    }
}
