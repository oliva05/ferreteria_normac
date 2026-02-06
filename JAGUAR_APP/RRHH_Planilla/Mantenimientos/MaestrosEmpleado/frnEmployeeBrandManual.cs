using ACS.Classes;
using core.Clases.Huellas;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using JAGUAR_PRO.Accesos;
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

        Int64 IdMarca;
        int IdTipoMarca;
        DateTime FechaMarca;
        Huella h1;
        int cantidad_marcas;

        public enum  Operacion 
        {
            Nueva = 1,
            Editar = 2
        }
        Operacion TipoOp = new Operacion();

        public frnEmployeeBrandManual(UserLogin user, int pidEmp)
        {
            InitializeComponent();
            LoadData();
            UsuarioLogueado = user;
            IdEmpleadoActual = pidEmp;
            h1 = new Huella();
            FechaMarca = dp.Now();
            dtFechaHora.DateTime = FechaMarca;
            cantidad_marcas = h1.GetCantidadMarcasDelDia(this.IdEmpleadoActual, this.FechaMarca);
            lblCantMarcas.Text = cantidad_marcas.ToString();

            if (EmpleadoActual.GetById(IdEmpleadoActual))
            {
                txtEmpleado.Text = EmpleadoActual.Barcode + " - " + EmpleadoActual.Name;
               
            }
            TipoOp = Operacion.Nueva;
         
        }

        public frnEmployeeBrandManual(UserLogin user, int pidEmp, int pidMarca)
        {
            InitializeComponent();
            LoadData();
            UsuarioLogueado = user;
            IdEmpleadoActual = pidEmp;

            if (EmpleadoActual.GetById(IdEmpleadoActual))
            {
                txtEmpleado.Text = EmpleadoActual.Barcode + " - " + EmpleadoActual.Name;
            }

            cmdBuscar.Visible = false;
            TipoOp = Operacion.Editar;

            if (pidMarca > 0) 
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("[sp_get_marcas_by_id]", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@IdMarca", pidMarca);
                            SqlDataReader dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                IdMarca = dr.GetInt64(0);
                                FechaMarca = dr.GetDateTime(1);
                                    dtFechaHora.DateTime = FechaMarca;
                                IdTipoMarca = dr.GetInt32(2);
                                    grdTipoMarca.EditValue = IdTipoMarca;
                                dr.Close();
                            }
                        }
                    }

                }
                catch (SqlException sqlEx)
                {
                    CajaDialogo.Error($"Error SQL: {sqlEx.Message}");
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error($"Error general: {ex.Message}");
                }

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

            if (cantidad_marcas == 3)
                tggCierreDia.IsOn = true;

            switch (TipoOp)
            {
                case Operacion.Nueva:

                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("[sp_insert_marca_manual_v2]", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_employee", IdEmpleadoActual);
                        cmd.Parameters.AddWithValue("@fecha", dtFechaHora.DateTime);
                        cmd.Parameters.AddWithValue("@id_tipo_marca", Convert.ToInt32(grdTipoMarca.EditValue));
                        cmd.Parameters.AddWithValue("@user_log", UsuarioLogueado.Id);
                        cmd.Parameters.AddWithValue("@generar_cierre", tggCierreDia.IsOn);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception EX)
                    {
                        CajaDialogo.Error(EX.Message);
                    }

                    break;
                case Operacion.Editar:

                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("[sp_update_marca_manual]", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_employee", IdEmpleadoActual);
                        cmd.Parameters.AddWithValue("@fecha", dtFechaHora.DateTime);
                        cmd.Parameters.AddWithValue("@id_tipo_marca", Convert.ToInt32(grdTipoMarca.EditValue));
                        cmd.Parameters.AddWithValue("@idMarca", IdMarca);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception EX)
                    {
                        CajaDialogo.Error(EX.Message);
                    }

                    break;
                default:
                    break;
            }

            
        }

        private void tggCierreDia_Toggled(object sender, EventArgs e)
        {
            if (tggCierreDia.IsOn)
            {
                switch (cantidad_marcas)
                {
                    case 0:
                        tggCierreDia.IsOn = false;
                        CajaDialogo.Error("No se puede generar un cierre de dia solo con una marca!");
                        break;
                    case 1:
                        //Permitimos porque ya existe una marca mas la nueva.
                        break;
                    case 2:
                        tggCierreDia.IsOn = false;
                        CajaDialogo.Error("No se puede generar un cierre de dia con tres marcas!");
                        break;
                    case 3:
                        //Permitimos el cierre ya que se generara marca par.
                        break;
                    case 4:
                        CajaDialogo.Error("El empleado ya cuenta con 4 marcas en esta fecha!");
                        tggCierreDia.IsOn = false;
                        break;
                    default:

                        break;
                }
            }
        }

        private void dtFechaHora_EditValueChanged(object sender, EventArgs e)
        {
            FechaMarca = dtFechaHora.DateTime;
            cantidad_marcas = h1.GetCantidadMarcasDelDia(IdEmpleadoActual, FechaMarca);
            lblCantMarcas.Text = cantidad_marcas.ToString();
        }
    }
}