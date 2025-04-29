//namespace JAGUAR_PRO.Clases
using ACS.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.RightsManagement;

public class CotizacionH
{
    public long Id { get; set; }
    public DateTime? Fecha { get; set; }
    public DateTime? FechaRow { get; set; }
    public int? IdUser { get; set; }
    public bool? Enable { get; set; }
    public string Comentario { get; set; }
    public int DocNum { get; set; }
    public int? IdEstado { get; set; }
    public int IdCliente { get; set; }
    public string NumDoc { get; set; }
    public DateTime? FechaEntregaEstimada { get; set; }
    public string Direccion { get; set; }
    public string ClienteNombre { get; set; }
    public string RTN { get; set; }
    public string OrdenCompra { get; set; }
    public int IdPuntoVenta { get; set; }
    public int? IdPedido { get; set; }
    public bool Recuperado { get; set; }
    public decimal SubTotal { get; set; }
    public decimal Total { get; set; }  
    DataOperations dp;

    public CotizacionH()
    {
        dp = new DataOperations();
    }

    public bool ObtenerPorId(Int64 id)
    {
        using (SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
        {
            string query = @"SELECT TOP 1 [id]
                                          ,[fecha]
                                          ,[fecha_row]
                                          ,[id_user]
                                          ,[enable]
                                          ,[comentario]
                                          ,[DocNum]
                                          ,[id_estado]
                                          ,[id_cliente]
                                          ,[NumDoc]
                                          ,[fecha_entrega_estimada]
                                          ,[direccion]
                                          ,[cliente_nombre]
                                          ,[RTN]
                                          ,[orden_compra]
                                          ,[id_punto_venta]
                                          ,[id_pedido]
	                                      ,isnull((
				                                    SELECT sum([cantidad] * [precio])
				                                    FROM [dbo].[JAGUAR_PRD_Cotizacion_D] B
				                                    where B.enable = 1
					                                    and B.id_h = A.id),0) as sub_total
	                                      ,isnull((
				                                    SELECT sum(([cantidad] * [precio])+isv)
				                                    FROM [dbo].[JAGUAR_PRD_Cotizacion_D] B
				                                    where B.enable = 1
					                                    and B.id_h = A.id),0) as total
                                      FROM [normac].[dbo].[JAGUAR_PRD_Cotizacion_H]A
                                    WHERE id = @id";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Id = reader.GetInt64(reader.GetOrdinal("id"));
                        Fecha = reader["fecha"] as DateTime?;
                        FechaRow = reader["fecha_row"] as DateTime?;
                        IdUser = reader["id_user"] as int?;
                        Enable = reader["enable"] as bool?;
                        Comentario = reader["comentario"] as string;
                        DocNum = reader.GetInt32(reader.GetOrdinal("DocNum"));
                        IdEstado = reader["id_estado"] as int?;
                        IdCliente = reader.GetInt32(reader.GetOrdinal("id_cliente"));
                        NumDoc = reader["NumDoc"] as string;
                        FechaEntregaEstimada = reader["fecha_entrega_estimada"] as DateTime?;
                        Direccion = reader["direccion"] as string;
                        ClienteNombre = reader["cliente_nombre"] as string;
                        RTN = reader["RTN"] as string;
                        OrdenCompra = reader["orden_compra"] as string;
                        if (!reader.IsDBNull(reader.GetOrdinal("id_punto_venta")))
                            IdPuntoVenta = Convert.ToInt32(reader["id_punto_venta"]); 

                        IdPedido = reader["id_pedido"] as int?;
                        SubTotal = Convert.ToDecimal(reader["sub_total"]);
                        Total = Convert.ToDecimal(reader["total"]);
                        Recuperado = true;
                        return true;
                    }
                    else
                    {
                        Recuperado = false;
                        return false;
                    }
                }
            }
        }
    }
}
