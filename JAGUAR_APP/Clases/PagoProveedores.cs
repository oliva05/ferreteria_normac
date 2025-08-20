using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_PRO.Clases
{
    public class PagoProveedores
    {
        private int idPagoProveedor;
        private DateTime fechaPago;
        private int idProveedor;
        private string nombreProveedor;
        private decimal montoPago;
        private int idMetodoPago;
        private string metodoPago;
        private string observacion;
        private string docNum;
        private int puntoVentaId;
        private bool enable;
        private int idUsuario;
        private string usuarioNombre;
        private bool recuperado;
        private string rtn;

      

        public int IdPagoProveedor { get => idPagoProveedor; set => idPagoProveedor = value; }
        public DateTime FechaPago { get => fechaPago; set => fechaPago = value; }
        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string NombreProveedor { get => nombreProveedor; set => nombreProveedor = value; }
        public decimal MontoPago { get => montoPago; set => montoPago = value; }
        public int IdMetodoPago { get => idMetodoPago; set => idMetodoPago = value; }
        public string MetodoPago { get => metodoPago; set => metodoPago = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public string DocNum { get => docNum; set => docNum = value; }
        public int PuntoVentaId { get => puntoVentaId; set => puntoVentaId = value; }
        public bool Enable { get => enable; set => enable = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string UsuarioNombre { get => usuarioNombre; set => usuarioNombre = value; }
        public bool Recuperado { get => recuperado; set => recuperado = value; }
        public string Rtn { get => rtn; set => rtn = value; }

        public bool RecuperarRegistros(int pIdPagoProveedor)
        {
            Recuperado = false;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_gets_pago_proveedores_class", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPago", pIdPagoProveedor);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdPagoProveedor = Convert.ToInt32(dr.GetOrdinal("id_pago"));
                    FechaPago = Convert.ToDateTime(dr["fecha_pago"]);
                    IdProveedor = Convert.ToInt32(dr["id_proveedor"]);
                    NombreProveedor = dr["proveedor"].ToString();
                    MontoPago = Convert.ToDecimal(dr["total_pagado"]);
                    IdMetodoPago = Convert.ToInt32(dr["idmetodo"]);
                    MetodoPago = dr["metodo_pago"].ToString();
                    Observacion = dr["observaciones"].ToString();
                    DocNum = dr["docnum"].ToString();
                    PuntoVentaId = Convert.ToInt32(dr["puntoVenta"]);
                    Enable = Convert.ToBoolean(dr["enable"]);
                    IdUsuario = Convert.ToInt32(dr["id_usuario"]);
                    UsuarioNombre = dr["usuario"].ToString();
                    Rtn = dr["RTN"].ToString();
                    dr.Close();

                }
                conn.Close();
                Recuperado = true;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                
            }

            return Recuperado;
        }
    }
}
