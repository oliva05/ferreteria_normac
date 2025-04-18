﻿using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_PRO.Mantenimientos.MateriaPrima.Models
{
   public class MP_Tipo
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public bool Recuperado { get; set; }

        public bool RecuperarRegistro(int pId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.usp_get_selected_MP_Tipo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pId);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ID = pId;
                    Descripcion = dr.GetString(1); //dr.GetDouble(5);

                    Recuperado = true;
                }
                con.Close();

                return Recuperado;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }
    }
}
