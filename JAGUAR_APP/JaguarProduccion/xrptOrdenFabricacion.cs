﻿using ACS.Classes;
using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.LogisticaJaguar.Models;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;

namespace JAGUAR_PRO.JaguarProduccion
{
    public partial class xrptOrdenFabricacion : DevExpress.XtraReports.UI.XtraReport
    {
        long id_header = 0;

        public xrptOrdenFabricacion(OrdenFabriacion_H order, int idNivel, UserLogin UsuarioLogeado)
        {
            InitializeComponent();

            this.ID.Value = order.ID;
            id_header = order.ID;
            xlPanadero.Text = order.GrupoPanadero;
            xlPT.Text = order.ItemCode +" - "+ order.ItemName;
            xlEstado.Text = order.Estado;
            xlFecha.Text = order.Fecha.ToString("dd/MM/yyyy");
            xlCantidadArrobas.Text = order.CantidadArrobas.ToString("N4");
            xlCantidadBolsas.Text = order.CantidadBolsasPlan.ToString("N4");
            xlCantidadLatas.Text = order.CantidadLatasPlan.ToString("N4");
            xrlCantidadBolsasReal.Text = order.CantidadBolsasReal.ToString("N4");
            xrlCantLatasReal.Text = order.CantidadLatasReal.ToString("N4");
            xlOrder.Text = "# "+ order.DocNum.ToString().PadLeft(5, '0');
            lblCostoXBolsa.Text = order.CostoPorBolsa.ToString("N4");
            xrlCostoTotal.Text = order.CostoTotal.ToString("N4");
            xrlCostoMO.Text = order.CostoMO.ToString("N4");
            LoadDetail(order.ID);

            bool accesoprevio = false;
            switch (idNivel)
            {
                case 1://Basic View
                case 2://Basic No Autorization
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    lblCostoXBolsa.Visible = true;
                    labelCostoXBolsa.Visible = true;
                    lblCostoMO.Visible = true;
                    xrlCostoMO.Visible = true;
                    lblCostoTotal.Visible = true;
                    xrlCostoTotal.Visible = true;
                    break;
                default:
                    //gridView1.OptionsMenu.EnableColumnMenu = false;
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(7))
                {
                    lblCostoXBolsa.Visible = true;
                    labelCostoXBolsa.Visible = true;
                    lblCostoMO.Visible = true;
                    xrlCostoMO.Visible = true;
                    lblCostoTotal.Visible = true;
                    xrlCostoTotal.Visible = true;
                }
                else
                {
                    //CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #2 (Recepción de Facturas)");
                }
            }

        }

        private void LoadDetail(long id_h)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_get_RPT_OrdenFabricacion_D_V2", cnx);
                    da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("id", id_h);

                    dsLogisticaJaguar1.rpt_OrdenFabricacion_D.Clear();
                    da.Fill(dsLogisticaJaguar1.rpt_OrdenFabricacion_D);


                    cnx.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void xrSubreport1_BeforePrint(object sender, CancelEventArgs e)
        {
            //this.Parameters["ID"].Value = id_header;

        }

        private void xrSubreport1_BeforePrint_1(object sender, CancelEventArgs e)
        {
            //this.Parameters["ID"].Value = id_header;
        }

        private void Load(int id)
        {
            try
            {
                DataOperations dp = new DataOperations();

                int id_h = Convert.ToInt32(this.Parameters[0].Value);

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.rpt_pt_recibido_by_id_order_production", cnx);
                    da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("id", this.ID.Value);

                    dsLogisticaJaguar1.Recepcion_Bolsas.Clear();
                    da.Fill(dsLogisticaJaguar1.Recepcion_Bolsas);


                    cnx.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
