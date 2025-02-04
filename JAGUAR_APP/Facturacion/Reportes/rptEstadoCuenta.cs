﻿using ACS.Classes;
using DevExpress.XtraReports.UI;
using JAGUAR_APP.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace JAGUAR_APP.Facturacion.Reportes
{
    public partial class rptEstadoCuenta : DevExpress.XtraReports.UI.XtraReport
    {
        public rptEstadoCuenta(int id_cliente)
        {
            InitializeComponent();
            Cliente cliente = new Cliente();

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
                    SqlDataAdapter da = new SqlDataAdapter("dbo.uspCargarEstadoCuentaByCliente", cnx);

                    dsContabilidad1.EstadoCuenta.Clear();

                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int).Value = id_cliente;
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
