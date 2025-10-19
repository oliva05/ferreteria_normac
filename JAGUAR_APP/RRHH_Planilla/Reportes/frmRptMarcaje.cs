﻿using ACS.Classes;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.RRHH_Planilla.Mantenimientos.MaestrosEmpleado;
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

namespace JAGUAR_PRO.RRHH_Planilla.Reportes
{
    public partial class frmRptMarcaje : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogueado;
        public frmRptMarcaje(UserLogin userLogin)
        {
            InitializeComponent();
            UsuarioLogueado = userLogin;
            dtDesde.DateTime = dp.dNow().AddDays(-1);
            dtHasta.DateTime = dp.dNow().Date.AddDays(1).AddSeconds(-1); // hoy, 23:59:59

            deFechaInicial.DateTime = dp.dNow().AddDays(-1);
            deFechaFinal.DateTime = dp.dNow().Date.AddDays(1).AddSeconds(-1); // hoy, 23:59:59
            LoadDataGeneral();
        }

        private void LoadDataGeneral()
        {
            try
            {
                string query = @"sp_get_marcas_employee";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@IdEmpleado",);
                cmd.Parameters.AddWithValue("@desde",dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@hasta",dtHasta.DateTime);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReporte1.get_marcas_empleado.Clear();
                adat.Fill(dsReporte1.get_marcas_empleado);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void LoadData()
        {
            try
            {
                string query = @"sp_get_marcas_by_employee";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEmpleado",Convert.ToInt32(grdEmployee.EditValue));
                cmd.Parameters.AddWithValue("@desde", deFechaInicial.DateTime);
                cmd.Parameters.AddWithValue("@hasta", deFechaFinal.DateTime);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReporte1.get_marcas_by_empleado.Clear();
                adat.Fill(dsReporte1.get_marcas_by_empleado);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void btnCambiarImagen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(grdEmployee.Text))
            {
                CajaDialogo.Error("Debe seleccionar un empleado!");
                return;
            }

            frnEmployeeBrandManual frm = new frnEmployeeBrandManual(UsuarioLogueado, Convert.ToInt32(grdEmployee.EditValue));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnCargarDatosAcumulados_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(grdEmployee.Text))
            {
                CajaDialogo.Error("Debe seleccionar un empleado!");
                return;
            }
            LoadData();
        }

        private void CargarDatos_Click(object sender, EventArgs e)
        {
            LoadDataGeneral();
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == TabGeneral)
            {
                LoadDataGeneral();
            }
            else if (e.Page == TabByEmpleado) 
            {
                LoadEmployee();            
            }
        }

        private void LoadEmployee()
        {
            try
            {
                string query = @"sp_get_employee_active";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@IdEmpleado", Convert.ToInt32(grdEmployee.EditValue));
                //cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                //cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReporte1.get_employee_active.Clear();
                adat.Fill(dsReporte1.get_employee_active);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnExportarAcumulados_Click(object sender, EventArgs e)
        {

        }
    }
}