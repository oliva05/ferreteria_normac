﻿using ACS.Classes;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using JAGUAR_PRO.Accesos.AccesosUsuarios;
using JAGUAR_PRO.Clases;
using LOSA.Calidad.LoteConfConsumo;
using NormacApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO.RRHH_Planilla.Mantenimientos.MaestrosEmpleado
{
    public partial class frnEmployeeBrandManual : DevExpress.XtraEditors.XtraForm
    {
        public hr_employee EmpleadoActual = new hr_employee();
        int IdEmpleadoActual;
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();   
        public frnEmployeeBrandManual(UserLogin user, int pidEmp)
        {
            InitializeComponent();
            LoadData();
            UsuarioLogueado = user;
            IdEmpleadoActual = pidEmp;

            if (EmpleadoActual.GetById(IdEmpleadoActual))
            {
                txtEmpleado.Text = EmpleadoActual.Barcode + " - " + EmpleadoActual.Name;
               
            }

        }

        private void LoadData()
        {
            string query = @"sp_get_horario_tipo_marca";
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMaestroEmpleados1.tipo_marca.Clear();
                adat.Fill(dsMaestroEmpleados1.tipo_marca);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmSearchDefault frm = new frmSearchDefault(frmSearchDefault.TipoBusqueda.Empleados);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (EmpleadoActual.GetById(frm.ItemSeleccionado.id))
                {
                    txtEmpleado.Text = EmpleadoActual.Barcode + " - " + EmpleadoActual.Name;
                    IdEmpleadoActual = frm.ItemSeleccionado.id;
                }
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmpleado.Text))
            {
                CajaDialogo.Error("Debe seleccionar el Empleado!");
                return;
            }

            if (string.IsNullOrEmpty(grdTipoMarca.Text))
            {
                CajaDialogo.Error("Debe seleccionar el Tipo de Marca!");
                return;
            }

            if (dtFechaHora.EditValue == null)
            {
                CajaDialogo.Error("Debe seleccionar una Fecha y Hora");
                return;
            }

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_insert_marca_manual", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_employee",IdEmpleadoActual);
                cmd.Parameters.AddWithValue("@fecha",dtFechaHora.DateTime);
                cmd.Parameters.AddWithValue("@id_tipo_marca",Convert.ToInt32(grdTipoMarca.EditValue));
                cmd.Parameters.AddWithValue("@user_log",UsuarioLogueado.Id);
                cmd.ExecuteNonQuery();
                conn.Close();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception EX)
            {
                CajaDialogo.Error(EX.Message);
            }
        }
    }
}