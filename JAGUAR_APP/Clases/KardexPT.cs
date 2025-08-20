using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_PRO.Clases
{

    public class KardexPT
    {
        // Propiedades del modelo
        public int Id { get; set; }
        public DateTime FechaReg { get; set; }
        public int IdTipoTransaccion { get; set; }
        public string TipoTransaccionName { get; set; }
        public bool Enable { get; set; }
        public string EnableDescripcion { get; set; }
        public int IdPT { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaDoc { get; set; }
        public decimal Entrada { get; set; }
        public decimal Salida { get; set; }
        public decimal Saldo { get; set; }
        public string NumDocumento { get; set; }
        public string UsuarioApruebaAjuste { get; set; }
        public string CodigoAlmacen { get; set; }
        public string DescripcionAlmacen { get; set; }
        public string Razon_motivo { get; set; }
        public decimal Precio { get; set; }

        // Método para cargar un registro por ID
        public bool RecuperarRegistro(Int64 idKardexPT)
        {
            DataOperations dp = new DataOperations();   
            string query = @"dbo.sp_get_movimiento_kardex_to_print";

            try
            {
                using (var conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_kardex_pt", idKardexPT);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id"));
                            FechaReg = reader.GetDateTime(reader.GetOrdinal("fecha_reg"));
                            IdTipoTransaccion = reader.GetInt32(reader.GetOrdinal("id_tipo_transaccion"));
                            TipoTransaccionName = reader["Tipo"]?.ToString();
                            Enable = reader.GetBoolean(reader.GetOrdinal("enable"));
                            EnableDescripcion = reader["enable_descripcion"]?.ToString();
                            IdPT = reader.GetInt32(reader.GetOrdinal("id_pt"));
                            ItemCode = reader["ItemCode"]?.ToString();
                            ItemName = reader["ItemName"]?.ToString();
                            IdUsuario = reader.GetInt32(reader.GetOrdinal("id_usuario"));
                            Usuario = reader["Usuario"]?.ToString();
                            FechaDoc = reader.GetDateTime(reader.GetOrdinal("FechaDoc"));
                            Entrada = Convert.ToDecimal(reader["Entrada"]);
                            Salida = Convert.ToDecimal(reader["Salida"]);
                            Saldo = Convert.ToDecimal(reader["saldo"]);
                            NumDocumento = reader["NumDocumento"]?.ToString();
                            UsuarioApruebaAjuste = reader["usuario_aprueba_ajuste"]?.ToString();
                            CodigoAlmacen = reader["codigo_almacen"]?.ToString();
                            DescripcionAlmacen = reader["descripcion_almacen"]?.ToString();
                            Razon_motivo = reader["razon_motivo"]?.ToString();
                            Precio = Convert.ToDecimal(reader["precio"]);
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Aquí podrías registrar el error si deseas
                CajaDialogo.Error($"Error al cargar KardexPT: {ex.Message}");
            }

            return false;
        }
    }
}
