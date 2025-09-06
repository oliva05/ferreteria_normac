using ACS.Classes;
using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO.Clases
{
    public class CuentasContables
    {
        public CuentasContables()
        {
        }

        private int cuentaID;
        private string codigoCuenta;
        private string nombreCuenta;
        private bool? enable;
        private char tipoCuenta;
        private bool esMovimiento;
        private int? cuentaPadreID;
        private DateTime? fechaCreacion;
        private int? idUserCreacion;
        private bool recuperado;

        public int CuentaID { get => cuentaID; set => cuentaID = value; }
        public string CodigoCuenta { get => codigoCuenta; set => codigoCuenta = value; }
        public string NombreCuenta { get => nombreCuenta; set => nombreCuenta = value; }
        public bool? Enable { get => enable; set => enable = value; }
        public char TipoCuenta { get => tipoCuenta; set => tipoCuenta = value; }
        public bool EsMovimiento { get => esMovimiento; set => esMovimiento = value; }
        public int? CuentaPadreID { get => cuentaPadreID; set => cuentaPadreID = value; }
        public DateTime? FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public int? IdUserCreacion { get => idUserCreacion; set => idUserCreacion = value; }
        public bool Recuperado { get => recuperado; set => recuperado = value; }

        public bool RecuperarRegistros(int pid)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_account_class",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CuentaID", pid);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    CuentaID = dr.GetInt32(dr.GetOrdinal("CuentaID"));
                    CodigoCuenta = dr.IsDBNull(dr.GetOrdinal("CodigoCuenta")) ? "" : dr.GetString(dr.GetOrdinal("CodigoCuenta"));
                    NombreCuenta = dr.IsDBNull(dr.GetOrdinal("NombreCuenta")) ? "" : dr.GetString(dr.GetOrdinal("NombreCuenta"));
                    Enable = (bool)(dr.IsDBNull(dr.GetOrdinal("Enable")) ? false : (bool?)dr.GetBoolean(dr.GetOrdinal("Enable")));
                    TipoCuenta = dr.IsDBNull(dr.GetOrdinal("TipoCuenta")) ? ' ' : dr.GetString(dr.GetOrdinal("TipoCuenta"))[0];
                    EsMovimiento = dr.IsDBNull(dr.GetOrdinal("EsMovimiento")) ? false : dr.GetBoolean(dr.GetOrdinal("EsMovimiento"));
                    CuentaPadreID = dr.IsDBNull(dr.GetOrdinal("CuentaPadreID")) ? null : (int?)dr.GetInt32(dr.GetOrdinal("CuentaPadreID"));
                    FechaCreacion = dr.IsDBNull(dr.GetOrdinal("FechaCreacion")) ? null : (DateTime?)dr.GetDateTime(dr.GetOrdinal("FechaCreacion"));
                    IdUserCreacion = dr.IsDBNull(dr.GetOrdinal("IdUserCreacion")) ? null : (int?)dr.GetInt32(dr.GetOrdinal("IdUserCreacion"));
                    Recuperado = true;
                }
                dr.Close();
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
            return Recuperado;
        }
    }
}
