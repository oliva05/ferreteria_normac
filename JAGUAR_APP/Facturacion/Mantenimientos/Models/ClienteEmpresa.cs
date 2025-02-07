﻿using JAGUAR_PRO.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACS.Classes;

namespace JAGUAR_PRO.Facturacion.Mantenimientos.Models
{
    public class ClienteEmpresa
    {
        public ClienteEmpresa() { }

        public int Id { get; set; }
        public int IdEmpresa { get; set; }
        public string NombreLargo { get; set; }
        public string NombreCorto { get; set; }
        public string Codigo { get; set; }
        public string RTN { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int UsuarioModificacion { get; set; }
        public int UsuarioCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Recuperado { get; set; }
        public bool ENABLE { get; set; }

        public bool RecuperarRegistro(int pidEmpresa, int pIdCliente)
        {
            Recuperado = false;
            DataOperations dp = new DataOperations();
            SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            //Por la premura del cliente hare una excepcion de hacer un Store Procedure
            //Pero en la proxima modificacion de esta clase debe modificarse *** Danys Oliva ***
            string query = "SELECT * FROM [dbo].[Facturacion_ClienteEmpresa] WHERE IdEmpresa = @IdEmpresa AND IdCliente = @idcliente";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdEmpresa", pidEmpresa);
            command.Parameters.AddWithValue("@idcliente", pIdCliente);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                if (reader.Read())
                {
                    IdEmpresa = (int)reader["IdEmpresa"];
                    Id = (int)reader["IdCliente"];
                    NombreLargo = reader["NombreLargo"].ToString();
                    if (!reader.IsDBNull(reader.GetOrdinal("NombreCorto")))
                        NombreCorto = reader["NombreCorto"].ToString();
                    if (!reader.IsDBNull(reader.GetOrdinal("Direccion")))
                        Direccion = reader["Direccion"].ToString();
                    if (!reader.IsDBNull(reader.GetOrdinal("RTN")))
                        RTN = reader["RTN"].ToString();
                    if (!reader.IsDBNull(reader.GetOrdinal("ENABLE")))
                        ENABLE = (bool)reader["ENABLE"];
                    if (!reader.IsDBNull(reader.GetOrdinal("FechaCreacion")))
                        FechaCreacion = (DateTime)reader["FechaCreacion"];
                    if (!reader.IsDBNull(reader.GetOrdinal("UsuarioCreacion")))
                        UsuarioCreacion = (int)reader["UsuarioCreacion"];
                    if (!reader.IsDBNull(reader.GetOrdinal("FechaModificacion")))
                        FechaModificacion = (DateTime)reader["FechaModificacion"];
                    if (!reader.IsDBNull(reader.GetOrdinal("UsuarioModificacion")))
                        UsuarioModificacion = (int)reader["UsuarioModificacion"];
                    if (!reader.IsDBNull(reader.GetOrdinal("telefono")))
                        Telefono = reader["telefono"].ToString();
                    if (!reader.IsDBNull(reader.GetOrdinal("correo")))
                        Correo = reader["correo"].ToString();
                    if (!reader.IsDBNull(reader.GetOrdinal("codigo")))
                        Codigo = reader["codigo"].ToString();
                    Recuperado = true;
                }
                
                reader.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error en la clase: ClienteFacturacion, Error MSJ: " + ex.Message);
            }

            return Recuperado;
        }
        public bool RecuperarEmpresaRTNCliente(int pIdCliente, string pRTN)
        {
            DataOperations dp = new DataOperations();
            try
            {
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cnx.Open();
                SqlCommand cmd = new SqlCommand("[sp_get_empresas_rtn_cliente_class]", cnx);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cliente", pIdCliente);
                cmd.Parameters.AddWithValue("@rtn", pRTN);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdEmpresa = dr.GetInt32(0);
                    Id = dr.GetInt32(1);
                    NombreLargo = dr.GetString(2);
                    NombreCorto = dr.GetString(3);
                    Direccion = dr.GetString(4);
                    RTN = dr.GetString(5);
                    Recuperado = true;
                }
                cnx.Close();
                return Recuperado;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }







    }
}
