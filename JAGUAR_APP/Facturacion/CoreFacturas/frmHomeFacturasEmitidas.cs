﻿using ACS.Classes;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Facturacion.Mantenimientos.Models;
using JAGUAR_PRO.Facturacion.Reportes;
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
using static DevExpress.DataProcessing.InMemoryDataProcessor.AddSurrogateOperationAlgorithm;

namespace JAGUAR_PRO.Facturacion.CoreFacturas
{
    public partial class frmHomeFacturasEmitidas : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        PDV PuntoDeVentaActual;
        FacturacionEquipo EquipoActual;
        DataOperations dp;

        enum EstadosFactura
        {
             Emitida=1
            ,Pagada=2
            ,Anulada=3
            ,PagoParcial=4
        }

        public frmHomeFacturasEmitidas(UserLogin pUsuarioLogeado, PDV pPuntoDeVentaActual, FacturacionEquipo pEquipoActual)
        {
            InitializeComponent();
            dp = new DataOperations();
            this.UsuarioLogeado = pUsuarioLogeado;
            this.EquipoActual = pEquipoActual;
            this.PuntoDeVentaActual = pPuntoDeVentaActual;
            DateTime NowDate = dp.NowSetDateTime();
            dtDesde.EditValueChanged -= new EventHandler(dtDesde_EditValueChanged);
            dtDesde.EditValue = new DateTime(NowDate.Year, NowDate.Month, NowDate.Day, 0,0,0);
            dtDesde.EditValueChanged += new EventHandler(dtDesde_EditValueChanged);

            dtHasta.EditValueChanged -= new EventHandler(dtHasta_EditValueChanged);
            NowDate = NowDate.AddDays(1);
            dtHasta.EditValue = new DateTime(NowDate.Year, NowDate.Month, NowDate.Day,0,0,0);
            dtHasta.EditValueChanged += new EventHandler(dtHasta_EditValueChanged);
            Loadfacturas();

            //Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna, para elegir columnas, ordenar, etc
            gvFacturas.OptionsMenu.EnableColumnMenu = false;

            //Permite mostrar o ocultar una columna, se utiliza colocando el string de FieldName que se define desde el dataset
            if (this.PuntoDeVentaActual.PermiteAnulacionConAutorizacion || this.PuntoDeVentaActual.PermiteReimpresionFacturaConAutorizacion)
                gvFacturas.Columns["autorizacion"].Visible = true; 
            else
                gvFacturas.Columns["autorizacion"].Visible = false;

        }

        private void Loadfacturas()
        {
            if (string.IsNullOrEmpty(dtDesde.Text))
                return;

            if (string.IsNullOrEmpty(dtHasta.Text))
                return;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_home_facturacion_punto_venta_v2]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsFacturasGestion1.HomeFacturas.Clear();
                adat.Fill(dsFacturasGestion1.HomeFacturas);

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

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            Loadfacturas();
        }

        private void cmdExportToExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }

        private void dtDesde_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dtHasta_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimir_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                //var row = (dsFacturasGestion.HomeFacturasRow)gridView1.GetFocusedDataRow();

                //var gridView = (GridView)gvFacturas.FocusedView;
                var row = (dsFacturasGestion.HomeFacturasRow)gvFacturas.GetFocusedDataRow();

                Factura factura = new Factura();

                xfrmDialogFormatoFactura frm = new xfrmDialogFormatoFactura(row.id, this.PuntoDeVentaActual, this.UsuarioLogeado);

                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdPagarFactura_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = (dsFacturasGestion.HomeFacturasRow)gvFacturas.GetFocusedDataRow();
            //Estados de Factura
            //1=Emitida
            //2=Pagada
            //3=Anulada

            bool ActivarReturn = false;

            PDV puntoVentaFactura = new PDV();
            if (puntoVentaFactura.RecuperaRegistro(row.id_punto_venta))
            {
                Factura factura = new Factura();
                if (factura.RecuperarRegistro(row.id))
                {
                    if (factura.IdPuntoVentaDestino == 0)
                    {
                        switch (row.id_estado)
                        {
                            //case 1:
                            //    break; 
                            case 2://2=Pagada
                                ActivarReturn = true;
                                CajaDialogo.Error("Esta Factura ya fue pagada, No se puede pagar nuevamente!");

                                break;
                            case 3://3=Anulada
                                ActivarReturn = true;
                                CajaDialogo.Error("Esta factura ya fue Anulada, No se puede efectuar el pago!");
                                break;
                        }

                        if (ActivarReturn)
                            return;
                    }
                    else
                    {
                        if (factura.SaldoFactura <= 0)
                        {
                            CajaDialogo.Error("Esta Factura ya fue pagada, No se puede pagar nuevamente!");
                            return;
                        }
                    }

                    //frmPagoFactura frm = new frmPagoFactura(this.UsuarioLogeado, row.TotalFactura, puntoVentaFactura);
                    frmPagoFactura frm = new frmPagoFactura(this.UsuarioLogeado, row.saldo, puntoVentaFactura,
                                                            factura.subtotalFactura, factura.ISV1);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        bool TransaccionExitosa = false;
                        int IdTipoPago = 0;

                        //Vamos por el detalle de lineas para la factura y la transaccion
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
                                //Vamos a postear transaccion en estado de cuenta de cliente
                                //if (factura.IdCliente > 0)
                                //{
                                //    //El pago de la misma
                                //    command.CommandText = "dbo.[sp_set_insert_estado_cuenta_cliente_v2]";
                                //    command.CommandType = CommandType.StoredProcedure;
                                //    command.Parameters.Clear();
                                //    command.Parameters.AddWithValue("@num_doc", factura.NumeroDocumento);
                                //    command.Parameters.AddWithValue("@enable", 1);
                                //    command.Parameters.AddWithValue("@credito", frm.varPago);//Abonos
                                //    command.Parameters.AddWithValue("@debito", 0);//cargos
                                //    command.Parameters.AddWithValue("@concepto", string.Concat("Pago de Factura #", factura.NumeroDocumento));
                                //    command.Parameters.AddWithValue("@doc_date", factura.FechaDocumento);
                                //    command.Parameters.AddWithValue("@date_created", factura.FechaDocumento);
                                //    command.Parameters.AddWithValue("@id_user_created", this.UsuarioLogeado.Id);
                                //    command.Parameters.AddWithValue("@id_cliente", factura.IdCliente);

                                //    if(string.IsNullOrEmpty(frm.ReferenciaReciboPago))
                                //        command.Parameters.AddWithValue("@referencia", DBNull.Value);
                                //    else
                                //        command.Parameters.AddWithValue("@referencia", frm.ReferenciaReciboPago);

                                //    command.ExecuteNonQuery();

                                //}

                                command.CommandText = "[dbo].[sp_set_update_estado_factura_h]";
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@id_factura", factura.Id);
                                command.Parameters.AddWithValue("@id_estado", 2);//Pagada
                                IdTipoPago = (int)frm.TipoPagoSeleccionadoActual;
                                command.Parameters.AddWithValue("@id_tipo_pago", IdTipoPago);
                                command.Parameters.AddWithValue("@monto_entregado", dp.ValidateNumberDecimal(frm.txtEntregado.Text));
                                command.Parameters.AddWithValue("@cambio", dp.ValidateNumberDecimal(frm.txtCambio.Text));
                                command.ExecuteNonQuery();





                                //Postear el recibo de la recepcion de valor o dinero
                                command.CommandText = "dbo.sp_set_insert_new_recibo_pago_h";
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@id_usuario_created", this.UsuarioLogeado.Id);
                                command.Parameters.AddWithValue("@concepto", "Pago a Facturas");

                                if (factura.IdCliente == 0)
                                    command.Parameters.AddWithValue("@id_cliente", DBNull.Value);
                                else
                                    command.Parameters.AddWithValue("@id_cliente", factura.IdCliente);

                                command.Parameters.AddWithValue("@fecha_created", dp.NowSetDateTime());
                                command.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);
                                command.Parameters.AddWithValue("@valor", frm.varPago);
                                command.Parameters.AddWithValue("@id_tipo_pago", (int)frm.TipoPagoSeleccionadoActual);
                                command.Parameters.AddWithValue("@id_formato_impresion", this.PuntoDeVentaActual.IdFormatoFactura);

                                if(string.IsNullOrEmpty(frm.ReferenciaReciboPago))
                                    command.Parameters.AddWithValue("@referencia", DBNull.Value);
                                else
                                    command.Parameters.AddWithValue("@referencia", frm.ReferenciaReciboPago);

                                Int64 IdReciboH_Inserted = Convert.ToInt64(command.ExecuteScalar());

                                //Posteamos la linea del recibo.
                                foreach (RegistroPago registroPago in frm.ListaDetallePago)
                                {
                                    command.CommandText = "dbo.[sp_set_insert_recibo_pago_detalle_v2]";
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.Clear();
                                    command.Parameters.AddWithValue("@num_doc", factura.NumeroDocumento);
                                    //command.Parameters.AddWithValue("@valor", frm.varPago);
                                    command.Parameters.AddWithValue("@valor", registroPago.Valor);
                                    command.Parameters.AddWithValue("@date_created", dp.NowSetDateTime());
                                    command.Parameters.AddWithValue("@id_recibo_h", IdReciboH_Inserted);
                                    command.Parameters.AddWithValue("@id_usuario", this.UsuarioLogeado.Id);

                                    if (factura.IdCliente == 0)
                                        command.Parameters.AddWithValue("@id_cliente", DBNull.Value);
                                    else
                                        command.Parameters.AddWithValue("@id_cliente", factura.IdCliente);

                                    if (registroPago.IdTipo == 3)
                                    {
                                        if (string.IsNullOrEmpty(registroPago.Referencia))
                                            command.Parameters.AddWithValue("@referencia", registroPago.Referencia);
                                        else
                                            command.Parameters.AddWithValue("@referencia", DBNull.Value);
                                    }
                                    else
                                    {
                                        command.Parameters.AddWithValue("@referencia", DBNull.Value);
                                    }

                                    if (registroPago.IdTipo == 0)
                                        command.Parameters.AddWithValue("@id_tipo_pago", DBNull.Value);
                                    else
                                        command.Parameters.AddWithValue("@id_tipo_pago", registroPago.IdTipo);

                                    command.ExecuteNonQuery();
                                }






                                TransaccionExitosa = true;

                                // Attempt to commit the transaction.
                                transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                // Attempt to roll back the transaction.
                                try
                                {
                                    transaction.Rollback();
                                    CajaDialogo.Error(ex.Message);
                                }
                                catch (Exception ex2)
                                {
                                    CajaDialogo.Error(ex2.Message);
                                }
                            }
                        }//En Using Connection

                        //Vamos a notificar de la factura efectuada y actualizar el row Status
                        if (TransaccionExitosa)
                        {
                            row.id_estado = 1;
                            row.EstadoName = "Pagada";

                            //Tabla [JAGUAR_DB].[dbo].[Facturacion_Tipo_Pago]
                            //1   Efectivo
                            //2   Tarjeta
                            //3   Depósito Bancario
                            
                            row.id_tipo_pago = IdTipoPago;

                            switch (IdTipoPago)
                            {
                                case 1:
                                    row.TipoPagoName = "Efectivo";
                                    break;
                                case 2:
                                    row.TipoPagoName = "Tarjeta";
                                    break;
                                case 3:
                                    row.TipoPagoName = "Depósito Bancario";
                                    break;
                            }


                            CajaDialogo.InformationAuto();
                        }
                    }
                }//End If recuperar Factura
            }//End If recuperar Punto de Venta Factura



        }

        private void btnAutorizar_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Solicitar autorizacion
            try
            {
                var row = (dsFacturasGestion.HomeFacturasRow)gvFacturas.GetFocusedDataRow();
                Factura_SolicitudAutorizacion solicitud = new Factura_SolicitudAutorizacion();
                solicitud.Facturas_seleccionadas = new List<FacturasSeleccionada>();
                solicitud.Clientes_Seleccionados = new List<int>();

                if (row.id_estado==(int)EstadosFactura.Anulada)
                {
                    CajaDialogo.Error("No se puede proceder con facturas que estan anuladas");
                    return;
                }

                if (dsFacturasGestion1.HomeFacturas.Where(x=> x.seleccionado==true).Count()==0)
                {
                    row.seleccionado = true;
                }


                foreach (var item in dsFacturasGestion1.HomeFacturas)
                {
                    if (item.seleccionado==true)
                    {
                        solicitud.Facturas_seleccionadas.Add(new FacturasSeleccionada()
                        {
                            FacturaId = item.id, 
                            NumeroFactura = item.numero_documento, 
                            Monto = item.TotalFactura,
                            PuntoVenda_Id=item.id_punto_venta,
                            PuntoVenta=item.PuntoVentaName
                        });
                        //solicitud.Facturas_seleccionadas.Add(item.id);
                        solicitud.Clientes_Seleccionados.Add(item.id_cliente);
                    }
                }

        
                solicitud.UsuarioSolicita_Id = UsuarioLogeado.Id;
                solicitud.FacturaId = row.id;
                solicitud.PuntoDeVenta_Id = row.id_punto_venta;
                solicitud.ClienteId = row.id_cliente;
                solicitud.Cliente = row.cliente_nombre;
                solicitud.Cliente_RTN = row.RTN;
                //xfrmDialogAutorizacion authorize = new xfrmDialogAutorizacion(solicitud, this.PuntoDeVentaActual);
                frmNavigationPageAutorizacion authorize = new frmNavigationPageAutorizacion(solicitud, this.PuntoDeVentaActual);

                if (authorize.ShowDialog()== DialogResult.OK)
                {
                    if (authorize.tipoAutorizacionActual == frmNavigationPageAutorizacion.TipoAutorizacion.Anulacion && authorize.autorizacion_directa == true)
                    {
                        row.EstadoName = "Anulada";
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void dtDesde_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtHasta.Focus();
            }
        }

        private void dtHasta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmdRefresh.Focus();
            }
        }

        private void cmdEditarFactura_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Editar el tipo de pago.
            var row = (dsFacturasGestion.HomeFacturasRow)gvFacturas.GetFocusedDataRow();
            frmEditarFactura frm = new frmEditarFactura(row.id);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
            }
            frm.Show();
        }

        private void cmdRevertirAnulacion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Revertir anulacion

        }
    }
}