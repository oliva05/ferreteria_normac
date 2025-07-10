using ACS.Classes;
using DevExpress.XtraRichEdit.Import.Doc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_PRO.Clases
{
    public class DepositoBanco
    {
        public DepositoBanco()
        {
        }

        private int id;
        private string numTransaccion;
        private string depositoN;
        private DateTime fecha;
        private int idBanco;
        private string banco;
        private decimal total;
        private string obs;
        private int createdUserId;
        private string creadoPor;
        private DateTime creadoEl;
        private int modiPor;
        private DateTime moidEl;
        private bool recuperado;

        // Propiedades públicas
        public int Id { get => id; set => id = value; }
        public string NumTransaccion { get => numTransaccion; set => numTransaccion = value; }
        public string DepositoN { get => depositoN; set => depositoN = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int IdBanco { get => idBanco; set => idBanco = value; }
        public string Banco { get => banco; set => banco = value; }
        public decimal Total { get => total; set => total = value; }
        public string Obs { get => obs; set => obs = value; }
        public int CreatedUserId { get => createdUserId; set => createdUserId = value; }
        public string CreadoPor { get => creadoPor; set => creadoPor = value; }
        public DateTime CreadoEl { get => creadoEl; set => creadoEl = value; }
        public int ModiPor { get => modiPor; set => modiPor = value; }
        public DateTime MoidEl { get => moidEl; set => moidEl = value; }
        public bool Recuperado { get => recuperado; set => recuperado = value; }

        public bool RecuperarRegistros(int id)
        {
            Recuperado = false;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_get_deposito_bancario_by_id]", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Id = reader.GetInt32(0);
                    NumTransaccion = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                    DepositoN = reader.GetString(2);
                    Fecha = reader.GetDateTime(3);
                    IdBanco = reader.GetInt32(4);
                    Banco = reader.GetString(5);
                    Total = reader.GetDecimal(6);
                    Obs = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
                    CreatedUserId = reader.GetInt32(8);
                    CreadoPor = reader.GetString(9);
                    CreadoEl = reader.GetDateTime(10);
                    ModiPor = reader.IsDBNull(11) ? 0 : reader.GetInt32(11);
                    MoidEl = reader.IsDBNull(12) ? DateTime.MinValue : reader.GetDateTime(12);
                    Recuperado = true;
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
