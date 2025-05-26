using ACS.Classes;
using DevExpress.Pdf.Native;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_PRO.Clases
{
    public class PedidoCliente
    {
        public long Id { get; set; }
        public string NumeroDocumento { get; set; }
        public bool Enable { get; set; }
        public int IdEstado { get; set; }
        public int IdUser { get; set; }
        public DateTime FechaDocumento { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpresa { get; set; }
        public string RTN { get; set; }
        public int IdPuntoVenta { get; set; }
        public string ClienteNombre { get; set; }
        public string direccion_cliente { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Comentario { get; set; }
        public string EstadoNombre { get; set; }
        public decimal TotalPedido { get; set; }
        public decimal SubTotal {  get; set; }
        public decimal Descuento { get; set; }
        public decimal ISV { get; set; }
        public string OrdenCompra { get; set; }
        public int Id_Vendedor { get; set; }
        public string CodigoVendedor { get; set; }
        
        public bool Recuperado { get; set; }

        DataOperations dp;

        public  PedidoCliente()
        {
            dp = new DataOperations();
        }

        public bool RecuperarRegistro(long pIdPedidoCliente)
        {
            string connectionString = dp.ConnectionStringJAGUAR_DB;
            NumberToLetters valorEnLetras = new NumberToLetters();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "dbo.sp_get_PedidoCliente_header_for_class_main";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id_PedidoCliente", pIdPedidoCliente);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Id = Convert.ToInt64(reader["id"]);
                        NumeroDocumento = reader["NumDoc"].ToString();
                        Enable = (bool)reader["enable"];
                        IdEstado = (int)reader["id_estado"];
                        IdUser = (int)reader["id_user"];

                        FechaDocumento = (DateTime)reader["fecha"];
                        if (!reader.IsDBNull(reader.GetOrdinal("id_cliente")))
                            IdCliente = (int)reader["id_cliente"];

                        if (!reader.IsDBNull(reader.GetOrdinal("RTN")))
                            RTN = reader["RTN"].ToString();

                        //IdPuntoVenta = (int)reader["id_punto_venta"];

                        if (!reader.IsDBNull(reader.GetOrdinal("cliente_nombre")))
                            ClienteNombre = reader["cliente_nombre"].ToString();

                        if (!reader.IsDBNull(reader.GetOrdinal("direccion_cliente")))
                            direccion_cliente = reader["direccion_cliente"].ToString();
                        FechaEntrega = (DateTime)reader["fecha_entrega_estimada"];
                        Comentario = reader["comentario"].ToString();
                        EstadoNombre = reader["estado_nombre"].ToString();
                        TotalPedido = Convert.ToDecimal(reader["total"]);
                        OrdenCompra = reader["orden_compra"].ToString();
                        if (!reader.IsDBNull(reader.GetOrdinal("id_punto_venta")))
                            IdPuntoVenta = (int)reader["id_punto_venta"];
                        //RecuperaDatosPDVFromPedidoCliente(IdPuntoVenta);

                        if (!reader.IsDBNull(reader.GetOrdinal("id_vendedor")))
                            Id_Vendedor = (int)reader["id_vendedor"];


                        if (!reader.IsDBNull(reader.GetOrdinal("codigo_vendedor")))
                            CodigoVendedor = reader["codigo_vendedor"].ToString();

                        if (!reader.IsDBNull(reader.GetOrdinal("sub_total")))
                            SubTotal = Convert.ToDecimal(reader["sub_total"]);

                        if (!reader.IsDBNull(reader.GetOrdinal("descuento")))
                            Descuento = Convert.ToDecimal(reader["descuento"]);

                        if (!reader.IsDBNull(reader.GetOrdinal("isv")))
                            ISV = Convert.ToDecimal(reader["isv"]);


                        Recuperado = true;
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Recuperado = false;
                    CajaDialogo.Error("Error al cargar la clase de PedidoClienteH. Msg: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return Recuperado;
        }

        public bool UpdatePrintCount(Int64 pIdPedidoCliente)
        {
            bool ret = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_set_increment_count_printer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_PedidoCliente", pIdPedidoCliente);
                cmd.ExecuteNonQuery();

                ret = true;
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return ret;
        }


        public decimal GetSaldoPedidoClienteH(Int64 pIdPedidoCliente)
        {
            decimal res = 0;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_saldo_PedidoClienteH", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_PedidoCliente", pIdPedidoCliente);
                res = Convert.ToDecimal(cmd.ExecuteScalar());   
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return res;
        }




        public bool UpdatePedidoClienteStatus(Int64 pIdPedidoCliente, int pIdStatus, int pIdTipoPago)
        {
            bool ret = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_set_update_estado_PedidoCliente_h]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_PedidoCliente", pIdPedidoCliente);
                cmd.Parameters.AddWithValue("@id_estado", pIdStatus);
                cmd.Parameters.AddWithValue("@id_tipo_pago", pIdTipoPago);
                
                cmd.ExecuteNonQuery();

                ret = true;
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return ret;
        }





        ////public bool RecuperarRegistro(string pNumPedidoCliente)
        ////{
        ////    string connectionString = dp.ConnectionStringJAGUAR_DB;

        ////    using (SqlConnection connection = new SqlConnection(connectionString))
        ////    {
        ////        string query = "dbo.sp_get_PedidoCliente_header_for_class_main_from_num_documento";

        ////        SqlCommand command = new SqlCommand(query, connection);
        ////        command.CommandType = System.Data.CommandType.StoredProcedure;
        ////        command.Parameters.AddWithValue("@NumPedidoCliente", pNumPedidoCliente);

        ////        try
        ////        {
        ////            connection.Open();
        ////            SqlDataReader reader = command.ExecuteReader();

        ////            if (reader.Read())
        ////            {
        ////                Id = (long)reader["id"];
        ////                NumeroDocumento = reader["numero_documento"].ToString();
        ////                Enable = (bool)reader["enable"];
        ////                IdEstado = (int)reader["id_estado"];
        ////                CantidadImpresionesPedidoCliente = (int)reader["cant_print"];
        ////                IdUser = (int)reader["id_user"];
        ////                FechaRow = (DateTime)reader["fecha_row"];
        ////                FechaDocumento = (DateTime)reader["fecha_documento"];
        ////                IdCliente = (int)reader["id_cliente"];
        ////                RTN = reader["RTN"].ToString();
        ////                NumOrdenCompra = reader["num_orden_compra"].ToString();
        ////                IdPuntoVenta = (int)reader["id_punto_venta"];
        ////                IdNumeracionFiscal = (int)reader["id_numeracion_fiscal"];
        ////                ClienteNombre = reader["cliente_nombre"].ToString();
        ////                if (!reader.IsDBNull(reader.GetOrdinal("CAI")))
        ////                    CAI = reader["CAI"].ToString();

        ////                if (!reader.IsDBNull(reader.GetOrdinal("fecha_limite")))
        ////                    FechaLimite = reader["fecha_limite"].ToString();

        ////                if (!reader.IsDBNull(reader.GetOrdinal("rango_autorizado")))
        ////                    RangoAutorizado = reader["rango_autorizado"].ToString();

        ////                if (!reader.IsDBNull(reader.GetOrdinal("direccion_cliente")))
        ////                    direccion_cliente = reader["direccion_cliente"].ToString();

        ////                subtotalPedidoCliente = Convert.ToDecimal(reader["subtotal"]);
        ////                descuentoTotalPedidoCliente = Convert.ToDecimal(reader["descuento"]);
        ////                ISV1 = Convert.ToDecimal(reader["isv1"]);
        ////                ISV2 = Convert.ToDecimal(reader["isv2"]);

        ////                if (!reader.IsDBNull(reader.GetOrdinal("id_formato_impresion")))
        ////                    idFormatoPedidoCliente = Convert.ToInt32(reader["id_formato_impresion"]);

        ////                IdPuntoVentaDestino = Convert.ToInt32("id_punto_venta_destino");
                        
        ////                IdTerminoPago = Convert.ToInt32(reader["id_termino_pago"]);
        ////                TerminoPagoName = reader["termino_pago_name"].ToString();


        ////                Recuperado = true;
        ////            }

        ////            reader.Close();
        ////        }
        ////        catch (Exception ex)
        ////        {
        ////            // Handle exceptions here
        ////            //Console.WriteLine("Error: " + ex.Message);
        ////            Recuperado = false;
        ////            CajaDialogo.Error("Error al cargar la clase de PedidoClienteH. Msg: " + ex.Message);
        ////        }
        ////        finally
        ////        {
        ////            connection.Close();
        ////        }
        ////    }

        ////    return Recuperado;
        ////}


        /// <summary>
        /// Para llamar esta funcion deben llenarse las propiedades de la clase antes.
        /// Para las lineas es necesario llenar la propiedad de tipo List->LineasPedidoCliente con objetos de clase PedidoClienteDetalle
        /// La funcion cuenta con un control de commit y rollback para efectuar el posteo completo de la transaccion o revertirlo en caso de error.
        /// </summary>
        /// <returns>Int64 Id de PedidoCliente H</returns>
        //public Int64 InsertPedidoCliente()
        //{
        //    Int64 rowsAffected = 0;
        //    string connectionString = dp.ConnectionStringJAGUAR_DB;

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        SqlCommand command = connection.CreateCommand();
        //        SqlTransaction transaction;
        //        transaction = connection.BeginTransaction("SampleTransaction");

        //        command.CommandType = CommandType.Text;
        //        command.CommandText = "dbo.[sp_fact_InsertPedidoClienteH_v3]";

        //        command.CommandType = CommandType.StoredProcedure;

        //        command.Parameters.AddWithValue("@numero_documento", NumeroDocumento);
        //        command.Parameters.AddWithValue("@id_estado", IdEstado);
        //        command.Parameters.AddWithValue("@id_user", IdUser);
        //        command.Parameters.AddWithValue("@fecha_documento", FechaDocumento);
        //        command.Parameters.AddWithValue("@id_cliente", IdCliente);
        //        command.Parameters.AddWithValue("@RTN", RTN);
        //        command.Parameters.AddWithValue("@num_orden_compra", NumOrdenCompra);
        //        command.Parameters.AddWithValue("@id_punto_venta", IdPuntoVenta);
        //        command.Parameters.AddWithValue("@id_numeracion_fiscal", IdNumeracionFiscal);
        //        command.Parameters.AddWithValue("@cliente_nombre", ClienteNombre);
        //        command.Parameters.AddWithValue("@id_formato_impresion", idFormatoPedidoCliente);

        //        if(IdPuntoVentaDestino == 0)
        //            command.Parameters.AddWithValue("@id_punto_venta_destino", DBNull.Value);
        //        else
        //            command.Parameters.AddWithValue("@id_punto_venta_destino", IdPuntoVentaDestino);

        //        try
        //        {
        //            connection.Open();
        //            rowsAffected = Convert.ToInt64(command.ExecuteScalar());

        //            //Vamos a guardar las lineas de detalle en la misma transaccion
        //            command.CommandText = "dbo.sp_fact_insert_linea_PedidoCliente_detalle";
        //            command.CommandType = CommandType.StoredProcedure;

        //            foreach (PedidoClienteDetalle FactDetalle in LineasPedidoCliente)
        //            {
        //                command.Parameters.Clear();
        //                //command.Parameters.AddWithValue("@pIdPedidoClienteH", FactDetalle.IdPedidoClienteH);
        //                command.Parameters.AddWithValue("@pIdPedidoClienteH", rowsAffected);
        //                command.Parameters.AddWithValue("@pIdPt", FactDetalle.IdPt);
        //                command.Parameters.AddWithValue("@pItemCode", FactDetalle.ItemCode);
        //                command.Parameters.AddWithValue("@pDescripcion", FactDetalle.Descripcion);
        //                command.Parameters.AddWithValue("@pCantidad", FactDetalle.Cantidad);
        //                command.Parameters.AddWithValue("@pPrecio", FactDetalle.Precio);
        //                command.Parameters.AddWithValue("@pDescuento", FactDetalle.Descuento);
        //                command.Parameters.AddWithValue("@pImpuesto1", FactDetalle.Impuesto1);
        //                command.Parameters.AddWithValue("@pImpuesto2", FactDetalle.Impuesto2);
        //                command.Parameters.AddWithValue("@pImpuesto3", FactDetalle.Impuesto3);
        //                command.Parameters.AddWithValue("@pTotalLinea", FactDetalle.TotalLinea);

        //                command.ExecuteNonQuery();
        //            }

        //            transaction.Commit();
        //            return rowsAffected;
        //        }
        //        catch (Exception ex)
        //        {
        //            transaction.Rollback();
        //            Console.WriteLine("Error: " + ex.Message);
        //            return rowsAffected;
        //        }
                
        //    }
        //}

        //private void RecuperaDatosPDVFromPedidoCliente(Int64 id_pdv)
        //{
        //    string connectionString = dp.ConnectionStringJAGUAR_DB;
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        string query = "dbo.uspGetPDVFromPedidoClienteClass";

        //        SqlCommand command = new SqlCommand(query, connection);
        //        command.CommandType = System.Data.CommandType.StoredProcedure;
        //        command.Parameters.AddWithValue("@id_pdv", id_pdv);

        //        try
        //        {
        //            connection.Open();
        //            SqlDataReader reader = command.ExecuteReader();

        //            if (reader.Read())
        //            {
        //                PDV_ID = (Int32)reader["id"];
        //                NombreComercial_PDV = reader["nombre_local"].ToString();
        //                DireccionPDV = reader["direccion"].ToString();
        //                Correo_PDV = reader["correo"].ToString();
        //                Telefono_PDV = reader["telefono"].ToString();
        //                NombreLegal_PDV = reader["nombre_legal"].ToString();
        //                RTN_PDV = reader["rtn"].ToString();
        //            }

        //            reader.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            // Handle exceptions here
        //            //Console.WriteLine("Error: " + ex.Message);
        //            Recuperado = false;
        //            CajaDialogo.Error("Error al cargar la clase de PedidoClienteH. Msg: " + ex.Message);
        //        }
        //        finally
        //        {
        //            connection.Close();
        //        }
        //    }
        //}

        //public bool RecuperarRegistroFor_NotaCreditoDebito(long pIdPedidoCliente)
        //{
        //    string connectionString = dp.ConnectionStringJAGUAR_DB;
        //    NumberToLetters valorEnLetras = new NumberToLetters();

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        string query = "dbo.sp_get_PedidoCliente_header_for_class_main_ForNotaCreditoDebito";

        //        SqlCommand command = new SqlCommand(query, connection);
        //        command.CommandType = System.Data.CommandType.StoredProcedure;
        //        command.Parameters.AddWithValue("@id_PedidoCliente", pIdPedidoCliente);

        //        try
        //        {
        //            connection.Open();
        //            SqlDataReader reader = command.ExecuteReader();

        //            if (reader.Read())
        //            {
        //                Id = (long)reader["id"];
        //                NumeroDocumento = reader["numero_documento"].ToString();
        //                Enable = (bool)reader["enable"];
        //                IdEstado = (int)reader["id_estado"];
        //                CantidadImpresionesPedidoCliente = (int)reader["cant_print"];
        //                IdUser = (int)reader["id_user"];
        //                FechaRow = (DateTime)reader["fecha_row"];
        //                FechaDocumento = (DateTime)reader["fecha_documento"];
        //                IdCliente = (int)reader["id_cliente"];
        //                RTN = reader["RTN"].ToString();
        //                NumOrdenCompra = reader["num_orden_compra"].ToString();
        //                IdPuntoVenta = (int)reader["id_punto_venta"];
        //                IdNumeracionFiscal = (int)reader["id_numeracion_fiscal"];

        //                if (!reader.IsDBNull(reader.GetOrdinal("cliente_nombre")))
        //                    ClienteNombre = reader["cliente_nombre"].ToString();

        //                if (!reader.IsDBNull(reader.GetOrdinal("CAI")))
        //                    CAI = reader["CAI"].ToString();

        //                if (!reader.IsDBNull(reader.GetOrdinal("fecha_limite")))
        //                    FechaLimite = reader["fecha_limite"].ToString();

        //                if (!reader.IsDBNull(reader.GetOrdinal("rango_autorizado")))
        //                    RangoAutorizado = reader["rango_autorizado"].ToString();

        //                if (!reader.IsDBNull(reader.GetOrdinal("direccion_cliente")))
        //                    direccion_cliente = reader["direccion_cliente"].ToString();

        //                subtotalPedidoCliente = Convert.ToDecimal(reader["subtotal"]);
        //                TotalPedidoCliente = Convert.ToDecimal(reader["total_PedidoCliente"]);
        //                descuentoTotalPedidoCliente = Convert.ToDecimal(reader["descuento"]);
        //                ISV1 = Convert.ToDecimal(reader["isv1"]);
        //                ISV2 = Convert.ToDecimal(reader["isv2"]);

        //                if (!reader.IsDBNull(reader.GetOrdinal("id_formato_impresion")))
        //                    idFormatoPedidoCliente = Convert.ToInt32(reader["id_formato_impresion"]);

        //                IdPuntoVentaDestino = Convert.ToInt32(reader["id_punto_venta_destino"]);

        //                IdTerminoPago = Convert.ToInt32(reader["id_termino_pago"]);
        //                TerminoPagoName = reader["termino_pago_name"].ToString();

        //                ValorLetras = valorEnLetras.Convertir((subtotalPedidoCliente - descuentoTotalPedidoCliente + ISV1 + ISV2).ToString(), true);
        //                RecuperaDatosPDVFromPedidoCliente(IdPuntoVenta);
        //                Recuperado = true;
        //                Cantidad = Convert.ToDecimal( reader["cantidad"].ToString());
        //                ProductoId = Convert.ToInt32( reader["id_pt"].ToString());
        //                Precio = Convert.ToDecimal(reader["precio"].ToString());
        //                PedidoClienteD_Id = Convert.ToInt64(reader["id_PedidoCliente_d"].ToString());
        //            }

        //            reader.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            // Handle exceptions here
        //            //Console.WriteLine("Error: " + ex.Message);
        //            Recuperado = false;
        //            CajaDialogo.Error("Error al cargar la clase de PedidoClienteH. Msg: " + ex.Message);
        //        }
        //        finally
        //        {
        //            connection.Close();
        //        }
        //    }

        //    return Recuperado;
        //}



    }
}
