﻿using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_PRO.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO.JaguarProduccion
{
    public partial class frmHomeAvanceProduccionBolsas : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        public event EventHandler Aplicar;
        public frmHomeAvanceProduccionBolsas(UserLogin pUserLogin)
        {
            InitializeComponent();
            this.UsuarioLogeado = pUserLogin;
            dp = new DataOperations();
            DateTime FechaInicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            DateTime FechaFinal = FechaInicial.AddHours(23);
            dtDesde.EditValue = FechaInicial;
            dtHasta.EditValue = FechaFinal;

            LoadDataHome();
        }
        public void InvocarAplicar()
        {
            this.Aplicar?.Invoke(this, EventArgs.Empty);
        }
        public void Aplicar_Click(object sender, EventArgs e)
        {
            InvocarAplicar();
        }

        private void LoadDataHome()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.[sp_get_lista_avances_de_orden_fabricacion_bolsas_v2]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                dsProduccion1.avance_produccion_bolsas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProduccion1.avance_produccion_bolsas); 
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdActualizar_Click(object sender, EventArgs e)
        {
            LoadDataHome();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Agregar nueva entrada de latas


            frmAddAvanceProduccionBolsas frm = new frmAddAvanceProduccionBolsas(this.UsuarioLogeado, 0, frmAddAvanceProduccionBolsas.TipoAccion.Bolsas);
            frm.EventoPasarId_Lata_inserted += new frmAddAvanceProduccionBolsas.get_latas_inserted(Ejecutar);
            frm.Show();
        }

        public void Ejecutar(Int64 pIdLataInserted)
        {
            //CajaDialogo.Information(pIdLataInserted.ToString());
            BolsasProduccion bolsa1 = new BolsasProduccion();
            if (bolsa1.RecuperarRegistro(pIdLataInserted))
            {
                dsProduccion.avance_produccion_bolsasRow row1 = dsProduccion1.avance_produccion_bolsas.Newavance_produccion_bolsasRow();
                //dsCompras.oc_d_normalRow row1 = dsCompras1.oc_d_normal.Newoc_d_normalRow();
                row1.id = pIdLataInserted;
                row1.id_orden = bolsa1.id_orden;
                row1.id_pt = bolsa1.id_pt;
                row1.ItemCode = bolsa1.ItemCode;
                row1.ItemName = bolsa1.ItemName;
                row1.cantidad_bolsas = bolsa1.cantidad_bolsas;
                row1.enable = bolsa1.enable;
                row1.fecha_hora = bolsa1.fecha_hora;
                row1.id_user = bolsa1.id_user;
                row1.UsuarioName = bolsa1.UsuarioName;
                row1.DocNum = bolsa1.DocNum;

                dsProduccion1.avance_produccion_bolsas.Addavance_produccion_bolsasRow(row1);
                //dsCompras.oc_d_normal.Addoc_d_normalRow(row1);
                dsProduccion1.AcceptChanges();
                //dsCompras.AcceptChanges();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
        }

        private void CargarDatos_Click(object sender, EventArgs e)
        {
            LoadDataHome();
        }
    }

}