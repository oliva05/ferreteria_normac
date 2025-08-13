using ACS.Classes;
using DevExpress.CodeParser;
using DevExpress.XtraReports.Summary.Native;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_PRO.Clases
{
    public class Comisiones
    {
        public Comisiones() { }
        DataOperations dp = new DataOperations();
        public int IdComision { get; set; }

        public int Anio { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin {  get; set; }
        public bool Active { get; set; }
        public string Descripcion { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int TipoPlanId {  get; set; }
        public string TipoPlanName { get;set; }
        public decimal Porcentaje { get; set; }
        public bool Recuperado { get; set; }


        public bool RecuperarRegistrosComisionesById(int pIdComision)
        {
            Recuperado = false;
            try
            {
                string query = @"sp_comisiones_get_class";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdComision", pIdComision);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdComision = dr.GetInt32(0);
                    Anio = dr.GetInt32(1);
                    FechaInicio = dr.GetDateTime(2);
                    FechaFin = dr.GetDateTime(3);
                    Active = dr.IsDBNull(4) ? false : dr.GetBoolean(4);
                    Descripcion = dr.IsDBNull(5) ? "" : dr.GetString(5);
                    UserId = dr.GetInt32(6);
                    TipoPlanId = dr.GetInt32(8);
                    TipoPlanName = dr.GetString(9);
                    UserName = dr.GetString(10);
                    Recuperado = true;
                    //Porcentaje = dr.GetDecimal(11);
                    dr.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            return Recuperado;
        }

        

    }
}
