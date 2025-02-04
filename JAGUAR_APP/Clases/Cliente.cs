﻿using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Clases
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public decimal SaldoActual { get; set; }
        public string RTN { get; set; }
        public bool Recuperado { get; set; }

        public bool RecuperarRegistro(int pIdCliente)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

                using (SqlCommand cmd = new SqlCommand("[dbo].[dbo.uspGetClienteFacturacionByID]", cnx))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_cliente", System.Data.SqlDbType.Int).Value = pIdCliente;

                    cnx.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Id = pIdCliente;
                        Nombre = dr["NombreCliente"].ToString();
                        NombreCorto = dr["NombreCorto"].ToString();
                        Direccion = dr["Direccion"].ToString();
                        Codigo = dr["codigo"].ToString();
                        Telefono = dr["Telefono"].ToString();
                        Correo = dr["Correo"].ToString();
                        //Correo = dr["Correo"].ToString();
                        SaldoActual = Convert.ToDecimal(dr["saldo_actual"].ToString());

                        Recuperado = true;
                    }
                    cnx.Close();
                }
                 

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
