using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Layout;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Facturacion.Entrega;
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

namespace JAGUAR_PRO.TransaccionesPT
{
    public partial class frmTrasladoGestionKardexOP : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        int IdH;
        int IdBodegaOrigen, IdBodegaDestino;
        public frmTrasladoGestionKardexOP(UserLogin userLogin, int idH)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
            IdH = idH;
            txtUsuario.Text = UsuarioLogeado.Nombre;

            RequisaTraslado traslado = new RequisaTraslado();
            if (traslado.RecuperarRegistrosTraslado(IdH))
            {
                txtNumTraslado.Text = traslado.NumTraslado;
                txtDescr.Text = traslado.Descripcion;
                txtBodOrigen.Text = traslado.Origen;
                txtBodDestino.Text = traslado.Destino;
                IdBodegaOrigen = traslado.BodegaOrigen;
                IdBodegaDestino = traslado.BodegaDestino;
                //CargarDetalle
                LoadDetalleDestino(IdH);
            }
        }

        private void LoadDetalleDestino(int idH)
        {
            try
            {
                string query = @"[sp_get_traslado_detalle]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTraslado", idH);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPT1.almacen_destino.Clear();
                adat.Fill(dsPT1.almacen_destino);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checMarcarTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (checMarcarTodo.Checked)
            {
                foreach (dsPT.almacen_destinoRow item in dsPT1.almacen_destino)
                {
                    item.cantidad_fisica = item.cantidad_trasladar;
                    item.seleccion = true;
                }
            }
            else
            {
                foreach (dsPT.almacen_destinoRow item in dsPT1.almacen_destino)
                {
                    item.cantidad_fisica = 0;
                    item.seleccion = false;
                }
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            bool Error = false;
            string Mensaje = string.Empty;
            bool alMenosUnoSeleccionado = false;
            foreach (dsPT.almacen_destinoRow item in dsPT1.almacen_destino)
            {
                if (item.seleccion)
                {
                    if (item.cantidad_fisica <= 0)
                    {
                        Mensaje = "Debe indicar un valor mayor a 0!";
                        Error = true;
                        break;
                    }
                }

                if (item.seleccion == true)
                {
                    alMenosUnoSeleccionado = true;
                }

                if (item.cantidad_fisica> item.cantidad_pendiente)
                {
                    Mensaje = "Cantidad Fisica no puede ser mayor que la Cantidad Pendiente";
                    Error = true;
                    break;
                }
               
            }

            if (Error)
            {
                CajaDialogo.Error(Mensaje);
                return;
            }

            if (!alMenosUnoSeleccionado)
            {
                CajaDialogo.Error("Debe seleccionar al menos 1 Producto!");
                return;
            }


            try
            {
                bool Guardar = false;
                DataOperations dp = new DataOperations();
                using (SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        foreach (dsPT.almacen_destinoRow row in dsPT1.almacen_destino)
                        {
                            if (row.seleccion)
                            {
                                using (SqlCommand cmd = new SqlCommand("[usp_insert_Traslado_Kardex_PTV2]", conn, transaction))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    cmd.Parameters.AddWithValue("@id_pt", row.id_pt);
                                    cmd.Parameters.AddWithValue("@id_Usuario", UsuarioLogeado.Id);
                                    cmd.Parameters.AddWithValue("@fecha_doc", dp.Now());
                                    cmd.Parameters.AddWithValue("@code", row.itemcode);
                                    cmd.Parameters.AddWithValue("@unidades", row.cantidad_fisica);
                                    cmd.Parameters.AddWithValue("@fecha_reg", dp.Now());
                                    cmd.Parameters.AddWithValue("@lote", DBNull.Value);
                                    cmd.Parameters.AddWithValue("@id_tipo_lote", DBNull.Value);
                                    cmd.Parameters.AddWithValue("@costo_unitario", DBNull.Value);
                                    cmd.Parameters.AddWithValue("@id_almacen_origen", IdBodegaOrigen);
                                    cmd.Parameters.AddWithValue("@id_almacen_destino", IdBodegaDestino);
                                    cmd.Parameters.AddWithValue("@idTraslado", IdH);
                                    cmd.Parameters.AddWithValue("@IdTraslado_d", row.id);
                                    cmd.ExecuteNonQuery();


                                }
                            }
                            
                        }

                        // Si todo fue bien, confirma la transacción
                        transaction.Commit();
                        Guardar = true;
                    }
                    catch (Exception ex)
                    {
                        // Si algo falla, revierte todos los cambios
                        transaction.Rollback();
                        CajaDialogo.Error("Error en la carga masiva: " + ex.Message);
                    }

                    conn.Close();
                    if (Guardar)
                    {
                        CajaDialogo.Information("Traslado Completado con Exito!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error de conexión o transacción: " + ex.Message);
            }


        }

        private void gridView2_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string columnName = e.Column.FieldName;

            var row = (dsPT.almacen_destinoRow)gridView2.GetFocusedDataRow();

            if (columnName == "seleccion")
            {
                bool Estado = Convert.ToBoolean(e.Value);

                if (Estado)
                {
                    row.cantidad_fisica = 1;
                }
                else
                {
                    row.cantidad_fisica = 0;
                }

            }

            if (columnName == "cantidad_fisica")
            { 
                decimal Unidades = Convert.ToDecimal(e.Value);
                if (Unidades > 0)
                {
                    row.seleccion = true;
                }
                else 
                {
                    row.seleccion= false;
                }
            }
        }
    }
}