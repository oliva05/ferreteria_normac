using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_PRO.Clases
{
    public class ActivosFijos
    {
        public ActivosFijos()
        { }

        private int activoId;
        private string codigoActivo;
        private string nombreActivo;
        private DateTime fechaCompra;
        private decimal valorCompra;
        private int vidaUtilMeses;
        private decimal valorResidual;
        private int cuentaContableActivoID;
        private int cuentaDepreciacionAcumuladaID;
        private int cuentaGastoDepreciacionID;
        private string estado;
        private bool enable;
        private bool recuperado;

        public int ActivoId { get => activoId; set => activoId = value; }
        public string CodigoActivo { get => codigoActivo; set => codigoActivo = value; }
        public string NombreActivo { get => nombreActivo; set => nombreActivo = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }
        public decimal ValorCompra { get => valorCompra; set => valorCompra = value; }
        public int VidaUtilMeses { get => vidaUtilMeses; set => vidaUtilMeses = value; }
        public decimal ValorResidual { get => valorResidual; set => valorResidual = value; }
        public int CuentaContableActivoID { get => cuentaContableActivoID; set => cuentaContableActivoID = value; }
        public int CuentaDepreciacionAcumuladaID { get => cuentaDepreciacionAcumuladaID; set => cuentaDepreciacionAcumuladaID = value; }
        public int CuentaGastoDepreciacionID { get => cuentaGastoDepreciacionID; set => cuentaGastoDepreciacionID = value; }
        public string Estado { get => estado; set => estado = value; }
        public bool Enable { get => enable; set => enable = value; }
        public bool Recuperado { get => recuperado; set => recuperado = value; }

        public bool RecuperarRegistros(int id)
        {
            Recuperado = false;

            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    string query = @"sp_get_activo_fijos_class";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ActivoID", id);
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                ActivoId = Convert.ToInt32(reader["ActivoID"]);
                                CodigoActivo = reader["CodigoActivo"].ToString();
                                NombreActivo = reader["NombreActivo"].ToString();
                                FechaCompra = Convert.ToDateTime(reader["FechaCompra"]);
                                ValorCompra = Convert.ToDecimal(reader["ValorCompra"]);
                                VidaUtilMeses = Convert.ToInt32(reader["VidaUtilMeses"]);
                                ValorResidual = Convert.ToDecimal(reader["ValorResidual"]);
                                CuentaContableActivoID = Convert.ToInt32(reader["CuentaContableActivoID"]);
                                CuentaDepreciacionAcumuladaID = Convert.ToInt32(reader["CuentaDepreciacionAcumuladaID"]);
                                CuentaGastoDepreciacionID = Convert.ToInt32(reader["CuentaGastoDepreciacionID"]);
                                Estado = reader["Estado"].ToString();
                                Enable = reader.IsDBNull(reader.GetOrdinal("Enable")) ? false : reader.GetBoolean(reader.GetOrdinal("Enable"));
                                Recuperado = true;
                            }
                            reader.Close();
                        }
                        conn.Close();
                    }
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
