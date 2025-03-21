﻿using ACS.Classes;
using DevExpress.XtraEditors;
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

namespace JAGUAR_PRO.Mantenimientos.MateriaPrima
{
    public partial class xfrmMateriasPrimas_Estado_CRUD : DevExpress.XtraEditors.XtraForm
    {

        public delegate void get_estado_inserted(int Id_inserted);
        public event get_estado_inserted EventoPasarId_estado_inserted;

       public enum TipoTransaccion
        {
            Nuevo=1,
            Editar=2
        }

        int tipoTransacion = 0;
        int id;
        string descripcion;


        public xfrmMateriasPrimas_Estado_CRUD(int TipoTransaccionP,int PId, string pDescripcion)
        {
            InitializeComponent();
            tipoTransacion = TipoTransaccionP;
            id = PId;
            descripcion = pDescripcion;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            try
            {
                int id_inserted = 0;

                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    CajaDialogo.Error("DEBE DE INGRESAR UN ESTADO");
                    return;
                }

                switch (tipoTransacion)
                {
                    case (int)TipoTransaccion.Nuevo:
                        DataOperations dp = new DataOperations();

                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                        {
                            cnx.Open();

                            SqlCommand cmd = new SqlCommand("dbo.usp_InsertNewEstadoMP_V2", cnx);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("descripcion",SqlDbType.VarChar).Value=txtDescripcion.Text;

                           id_inserted=Convert.ToInt32( cmd.ExecuteScalar());

                            cnx.Close();

                            CajaDialogo.Information("DATOS GUARDADOS");
                            EventoPasarId_estado_inserted(id_inserted);
                            this.DialogResult = DialogResult.OK;
                        }
                        break;

                    case (int)TipoTransaccion.Editar:
                        DataOperations dp2 = new DataOperations();

                        using (SqlConnection cnx2 = new SqlConnection(dp2.ConnectionStringJAGUAR_DB))
                        {
                            cnx2.Open();

                            SqlCommand cmd2 = new SqlCommand("dbo.usp_UpdateEstadoMP", cnx2);
                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Parameters.Add("@id", SqlDbType.Int).Value = id;
                            cmd2.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text;

                            cmd2.ExecuteNonQuery();

                            cnx2.Close();

                            CajaDialogo.Information("DATOS ACTALIZADOS");
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                //throw;
            }
        }

        private void xfrmMateriasPrimas_Estado_CRUD_Load(object sender, EventArgs e)
        {
            if (tipoTransacion ==(int)TipoTransaccion.Editar)
            {
                txtDescripcion.Text = descripcion;
            }
        }
    }
}