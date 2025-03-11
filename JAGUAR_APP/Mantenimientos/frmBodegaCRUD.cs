using System;
using System.Data;
using System.Windows.Forms;
using JAGUAR_PRO.Mantenimientos.Modelos;
using System.Data.SqlClient;
using ACS.Classes;
using Core.Clases.Herramientas;
using DevExpress.Utils.Drawing;
using DevExpress.PivotGrid.Criteria;
using JAGUAR_PRO.Clases;

namespace JAGUAR_PRO.Mantenimientos
{
    public partial class frmBodegaCRUD : Form
    {
        DataOperations dp = new DataOperations();
        private Bodega bodega;
        CajaDialogo CajaDialogo = new CajaDialogo();
        Operacion operacion;
        public frmBodegaCRUD(Operacion op, int pId)
        {
            InitializeComponent();
            operacion = op;
            switch (operacion)
            {
                case Operacion.New:
                    Conf_TablesID tables = new Conf_TablesID();
                    tables.ObtenerIDTable(7, 3);//7 Bodegas //3 Caracteres
                    txtCodBodega.Text = tables.Codigo;
                    chkEnable.Checked = true;
                    break;
                case Operacion.Update:
                    bodega = new Bodega();
                    bodega.RecuperarRegistro(pId);
                    txtCodBodega.Text = bodega.CodigoBodega;
                    txtDescripcionCorta.Text = bodega.DescripcionCorta;
                    memoDescripcion.Text = bodega.Descripcion;
                    chkEnable.Checked = bodega.Enable;

                    break;
                case Operacion.View:
                    break;
                default:
                    break;
            }
        }

        public enum Operacion
        {
            New = 1,
            Update = 2,
            View = 3
        }


        
        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

            using (SqlConnection conexionJAGUAR_PRO = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                try
                {
                    if (txtDescripcionCorta.Text.Length <= 0 || memoDescripcion.Text.Length <= 0)
                        {
                        CajaDialogo.Error("Debe de llenar todos los campos del formulario");
                        return;
                       
                    }
                    else
                    {
                        conexionJAGUAR_PRO.Open();
                        using (SqlCommand command = new SqlCommand("spInsertarActualizarBodegas", conexionJAGUAR_PRO))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@Id", SqlDbType.Int).Value = bodega.Id;
                            command.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = memoDescripcion.Text;
                            command.Parameters.Add("@DescripcionCorta", SqlDbType.VarChar).Value = txtDescripcionCorta.Text;
                            command.Parameters.Add("@Enable", SqlDbType.Bit).Value = chkEnable.Checked;
                            command.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = dp.Now();
                            command.Parameters.AddWithValue("@CodBodega", txtCodBodega.Text);
                            command.ExecuteNonQuery();

                            this.DialogResult = DialogResult.OK;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void memoDescripcion_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }

        private void txtDescripcionCorta_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }
    }
}
