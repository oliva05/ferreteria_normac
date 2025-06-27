using ACS.Classes;
using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace JAGUAR_PRO.Facturacion.Reportes
{
    public partial class rptEstadoCuenta : DevExpress.XtraReports.UI.XtraReport
    {
        DateTime Desde;
        DateTime Hasta;
        bool UtilizaRangoFechas;
        public rptEstadoCuenta(int id_cliente, DateTime pDesde, DateTime phasta,  bool pUtilizaRangoFechas)
        {
            InitializeComponent();
            Cliente cliente = new Cliente();
            Desde = pDesde;
            Hasta = phasta;
            UtilizaRangoFechas = pUtilizaRangoFechas;

            LoadData(id_cliente);

            cliente.RecuperarRegistro(id_cliente);

            lblCliente.Text = cliente.Nombre;
            blbCodigo.Text = cliente.Codigo;
            lblTelefono.Text = cliente.Telefono;
            lblCorreo.Text = cliente.Correo;
            lblSaldo.Text = string.Format("L {0: ###,##0.00}", cliente.SaldoActual);

        }

        private void LoadData(int id_cliente)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    //UtilizaRangoFechas
                    SqlDataAdapter da;
                    if (UtilizaRangoFechas)
                        da = new SqlDataAdapter("dbo.[uspCargarEstadoCuentaByClienteV2]", cnx);
                    else
                        da = new SqlDataAdapter("dbo.uspCargarEstadoCuentaByCliente", cnx);


                    dsContabilidad1.EstadoCuenta.Clear();

                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int).Value = id_cliente;

                    if (UtilizaRangoFechas)
                    {
                        da.SelectCommand.Parameters.AddWithValue("@desde", Desde);
                        da.SelectCommand.Parameters.AddWithValue("@hasta", Hasta);
                    }

                    da.Fill(dsContabilidad1.EstadoCuenta);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

    }
}
