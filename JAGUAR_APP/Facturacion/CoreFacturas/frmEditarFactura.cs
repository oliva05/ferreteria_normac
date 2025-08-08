using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace JAGUAR_PRO.Facturacion.CoreFacturas
{
    public partial class frmEditarFactura : DevExpress.XtraEditors.XtraForm
    {
        Factura FacturaActual;
        FacturaEstado EstadoFacturaActual;
        int IdEstadoActual;
        int IdEstadoNuevo;
        bool FacturaCargada = false;

        public class ItemBusquedaLocal
        {
            public int id;
            public string ItemCode;
            public string ItemName;
            public ItemBusquedaLocal()
            {
                id = 0;
                ItemCode = "";
                ItemName = "";
            }
        }
        ItemBusquedaLocal ItemSeleccionado;
        public frmEditarFactura(long pIdFacturaH)
        {
            InitializeComponent();
            ItemSeleccionado = new ItemBusquedaLocal();
            FacturaActual = new Factura();
            if (FacturaActual.RecuperarRegistro(pIdFacturaH))
            {
                FacturaCargada = true;
                txtDireccion.Text = FacturaActual.direccion_cliente;
                txtNombreCliente.Text = FacturaActual.ClienteNombre;
                txtRTN.Text = FacturaActual.RTN;
                IdEstadoActual = FacturaActual.IdEstado;
                EstadoFacturaActual = new FacturaEstado();
                LoadDetalleRecibos(FacturaActual.NumeroDocumento);
                lblNumeroFactura.Text = FacturaActual.NumeroDocumento;

                if (EstadoFacturaActual.RecuperarRegistro(FacturaActual.IdEstado))
                {
                    lblEstadoActual.Text = EstadoFacturaActual.Descripcion;
                }

                switch (IdEstadoActual)
                {
                    //case 1://Emitida
                        
                    //    break;
                    //case 2://Pagada
                    //    dsMantoFacturas.estados_facturaRow row1 = dsMantoFacturas1.estados_factura.Newestados_facturaRow();
                    //    row1.id = 3;
                    //    row1.descripcion = "Anulada";
                    //    row1.seleccionar = false;
                    //    dsMantoFacturas1.estados_factura.Addestados_facturaRow(row1);
                    //    dsMantoFacturas1.AcceptChanges();
                    //    break;
                    case 3://Anulada
                        dsMantoFacturas.estados_facturaRow row3 = dsMantoFacturas1.estados_factura.Newestados_facturaRow();
                        row3.id = 2;
                        row3.descripcion = "Pagada";
                        row3.seleccionar = false;
                        dsMantoFacturas1.estados_factura.Addestados_facturaRow(row3);
                        dsMantoFacturas1.AcceptChanges();
                        break;
                }
            }
        }

        public void LoadDetalleRecibos(string pNumeroFactura)
        {
            //sp_get_detalle_pagos_de_Factura_H
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_detalle_pagos_de_Factura_H]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@doc_num", pNumeroFactura);
                //cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                //cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMantoFacturas1.recibos_por_factura.Clear();
                adat.Fill(dsMantoFacturas1.recibos_por_factura);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

      

        private void gridView2_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //EVENTO CellValueChanging
            if (e.Column.FieldName == "seleccionar")
            {
                var gridView = (GridView)gridControl2.FocusedView;
                var row = (dsMantoFacturas.estados_facturaRow)gridView.GetFocusedDataRow();
                if (Convert.ToBoolean(e.Value))
                {
                    ItemSeleccionado.id = row.id;
                    //ItemSeleccionado.ItemCode = row.ItemCode;
                    ItemSeleccionado.ItemName = row.descripcion;
                    row.seleccionar = true;
                }

                foreach (dsMantoFacturas.estados_facturaRow row1 in dsMantoFacturas1.estados_factura)
                {
                    if (row1.id != ItemSeleccionado.id)
                        row1.seleccionar = false;
                }
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreCliente.Text))
            {
                CajaDialogo.Error("No se permite dejar el nombre del cliente en blanco!");
                return;
            }
            if (string.IsNullOrEmpty(txtRTN.Text))
            {
                txtRTN.Text = "N/D";
            }

            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                txtDireccion.Text = "N/D";
            }

            if (!FacturaCargada)
            {
                CajaDialogo.Error("No se cargo de manera correcta la factura a editar, por favor cierre y abra de nuevo la ventana...");
                return;
            }

            DataOperations dp = new DataOperations();
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction("SampleTransaction");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    //Modificar el header de factura.
                    command.CommandText = "sp_set_update_factura_h";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@rtn", txtRTN.Text);
                    command.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    command.Parameters.AddWithValue("@nombre", txtNombreCliente.Text);
                    command.Parameters.AddWithValue("@id_factura", FacturaActual.Id);
                    command.ExecuteNonQuery();

                    //Vamos a modificar el estado de la factura.
                    if (ItemSeleccionado.id > 0)
                    {
                        command.CommandText = "sp_set_update_factura_h_estado";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@id_estado", ItemSeleccionado.id);
                        command.Parameters.AddWithValue("@id_factura", FacturaActual.Id);
                        command.ExecuteNonQuery();
                    }

                    //Modificamos solo los registros donde el nuevo tipo de pago sea mayor a cero.
                    foreach (dsMantoFacturas.recibos_por_facturaRow row in dsMantoFacturas1.recibos_por_factura)
                    {
                        if (row.id_tipo_pago_nuevo > 0)
                        {
                            command.CommandText = "sp_set_update_pago_recibo_detalle_edit_factura";
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@id_tipo_pago", row.id_tipo_pago_nuevo);
                            command.Parameters.AddWithValue("@id_recibo_detalle", row.id);
                            command.Parameters.AddWithValue("@id_factura_h", FacturaActual.Id);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Attempt to commit the transaction.
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        CajaDialogo.Error(ex2.Message);
                    }
                }
            }
        }

        private void txtNombreCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtRTN.Focus();
                txtRTN.SelectAll();
            }
        }

        private void txtRTN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDireccion.Focus();
                txtDireccion.SelectAll();
            }
        }

        private void cmdEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gv = (GridView)gridControl1.FocusedView;
            var row = (dsMantoFacturas.recibos_por_facturaRow)gv.GetDataRow(gv.FocusedRowHandle);
            frmElejirTipoPagoEditFactura frm = new frmElejirTipoPagoEditFactura(row.id_tipo_pago_actual, row.tipo_pago_actual);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                row.id_tipo_pago_nuevo = frm.ItemSeleccionado.id;
                row.tipo_pago_nuevo = frm.ItemSeleccionado.ItemName;
            }
        }
    }
}