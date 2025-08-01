﻿using ACS.Classes;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Facturacion.Configuraciones;
using JAGUAR_PRO.Facturacion.CoreFacturas;
using JAGUAR_PRO.Facturacion.Deposito;
using JAGUAR_PRO.Mantenimientos.Modelos;
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

namespace JAGUAR_PRO.Facturacion.Reportes
{
    public partial class frmArqueoCajaV2 : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        PDV PuntoVentaActual;
        DateTime fechaDesde;
        DateTime fechaHasta;
        DataOperations dp;
        UserLogin UserCajero;

        public FacturacionCierreDiaPuntoVenta CierreDiaActual;

        public enum TipoTransaccion
        {
            Insert = 1,
            Update = 2, 
            Delete = 3
        }

        TipoTransaccion TipoTransaccionActual { get; set; }
        public frmArqueoCajaV2(UserLogin pUser, PDV pPuntoVenta, Int64 pIdCierreDia, TipoTransaccion ptipoTransaccion, bool PermitirAutorizarCierre)
        {
            InitializeComponent();
            TipoTransaccionActual = ptipoTransaccion;
            CierreDiaActual = new FacturacionCierreDiaPuntoVenta();
            UsuarioLogeado = pUser;
            dp = new DataOperations();
            DateTime fechaActual = dp.NowSetDateTime();
            
            PuntoVentaActual = pPuntoVenta;
            
            LoadCajeros();
            txtPuntoVenta.Text = PuntoVentaActual.Nombre;
            //txtCajero.Text = this.UsuarioLogeado.Nombre;

            switch (TipoTransaccionActual)
            {
                case TipoTransaccion.Insert:
                    lblCodigoCierre.Visible = txtCodigoCierre.Visible = false;
                    txtEstado.Text = "Borrador";
                    

                    dtHasta.EditValueChanged -= new EventHandler(dtHasta_EditValueChanged);
                    dtHasta.EditValue = fechaActual;
                    dtHasta.EditValueChanged += new EventHandler(dtHasta_EditValueChanged);

                    CierreDiaActual.id_estado = 1;
                    fechaDesde = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, 0, 0, 0);
                    fechaHasta = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, 23, 59, 59);
                    dtHasta.ReadOnly = false;
                    cmdRefresh.Visible = true;
                    break;
                case TipoTransaccion.Update:
                    lblCodigoCierre.Visible = txtCodigoCierre.Visible = true;
                    if (CierreDiaActual.RecuperarRegistro(pIdCierreDia))
                    {
                        UserCajero = new UserLogin();

                        txtCodigoCierre.Text = CierreDiaActual.codigo;
                        txtEstado.Text = CierreDiaActual.estado_descripcion;
                        fechaDesde = new DateTime(CierreDiaActual.fecha.Year, CierreDiaActual.fecha.Month, CierreDiaActual.fecha.Day, 0, 0, 0);
                        fechaHasta = CierreDiaActual.fecha;
                        //txtCajero.Text = CierreDiaActual.usuario_responsable_nombre;
                        gleCajero.EditValue = CierreDiaActual.id_user_responsable;
                        

                        dtHasta.EditValueChanged -= new EventHandler(dtHasta_EditValueChanged);
                        dtHasta.EditValue = fechaHasta;
                        dtHasta.EditValueChanged += new EventHandler(dtHasta_EditValueChanged);

                        dtHasta.ReadOnly = true;
                        cmdRefresh.Visible = false;
                        cmdImprimir.Visible = true;

                        txtAutorizadoPor.Text = this.CierreDiaActual.usuario_validacion_nombre;
                    }
                    break;
                    default: break;
            }

            if (CierreDiaActual.id_estado == 2)//Confirmado
                gleCajero.Properties.ReadOnly = true;

            if (PermitirAutorizarCierre)
            {
                if (CierreDiaActual.Recuperado)
                {
                    if (CierreDiaActual.id_estado == 2)
                        cmdAutorizarCierre.Visible = false;
                    else
                        cmdAutorizarCierre.Visible = true;
                }
                
            }
            else
            {
                cmdAutorizarCierre.Visible = false;
            }
            LoadDatosResumen(CierreDiaActual.id);
            LoadDetalleFacturas();
            LoadDetalleFacturasAnuladas();
            LoadRecibos(fechaDesde, fechaHasta);
            LoadFacturasCredito(fechaDesde, fechaHasta);
            LoadDepositosDeCaja(fechaDesde, fechaHasta);
        }

        private void LoadCajeros()
        {
            string query = @"sp_get_lista_cajeros_activos";
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@desde", pDesde);
                //cmd.Parameters.AddWithValue("@hasta", pHasta);
                //cmd.Parameters.AddWithValue("@puntoVentaId", this.PuntoVentaActual.ID);
                //cmd.Parameters.AddWithValue("@completado", 1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsContabilidad1.cajeros.Clear();
                da.Fill(dsContabilidad1.cajeros);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadDepositosDeCaja(DateTime pDesde, DateTime pHasta)
        {
            string query = @"sp_get_listad_depositos";
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", pDesde);
                cmd.Parameters.AddWithValue("@hasta", pHasta);
                cmd.Parameters.AddWithValue("@puntoVentaId", this.PuntoVentaActual.ID);
                cmd.Parameters.AddWithValue("@completado", 1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsDepositos1.lista_depositos.Clear();
                da.Fill(dsDepositos1.lista_depositos);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadDatosResumen(Int64 pIdCierreH)
        {
            //sp_get_datos_resumen_cierre_caja
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();
                SqlCommand cmd;

                if (pIdCierreH == 0)
                {
                    //cmd = new SqlCommand("dbo.[sp_get_datos_resumen_cierre_caja]", con);
                    cmd = new SqlCommand("dbo.[sp_get_datos_resumen_cierre_caja_v2]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fechadesde", fechaDesde);
                    cmd.Parameters.AddWithValue("@fechahasta", fechaHasta);
                    cmd.Parameters.AddWithValue("@id_punto_venta", PuntoVentaActual.ID);
                }
                else
                {
                    //cmd = new SqlCommand("[dbo].[sp_get_datos_resumen_cierre_caja_by_id_v2]", con);
                    cmd = new SqlCommand("[dbo].[sp_get_datos_resumen_cierre_caja_by_id_v3]", con);
                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCierreH", pIdCierreH);
                    //cmd.Parameters.AddWithValue("@fechahasta", fechaHasta);
                    //cmd.Parameters.AddWithValue("@id_punto_venta", PuntoVentaActual.ID);
                }

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsContabilidad1.resumen_cobros.Clear();
                adat.Fill(dsContabilidad1.resumen_cobros);

                

                //decimal valor = 0;

                //foreach (dsContabilidad.resumen_cobrosRow rowi in dsContabilidad1.resumen_cobros)
                //{
                //    try
                //    {
                //        if (rowi.id_tipo_pago < 5)//SI no es la linea del total
                //        {
                //            valor += rowi.valor_contado;
                //            rowi.diferencia = rowi.valor_contado - rowi.total;
                //        }
                //        else
                //        {
                //            rowi.valor_contado = valor;//LInea del total
                //            rowi.diferencia = rowi.valor_contado - rowi.total;
                //        }

                //    }
                //    catch { }
                //}


                con.Close();
                CalcularDiferenciaTotal();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        void CalcularDiferenciaTotal()
        {
            decimal total_dif = 0;
            foreach (dsContabilidad.resumen_cobrosRow row in dsContabilidad1.resumen_cobros)
            {
                if (row.id_tipo_pago != 5)
                    total_dif += row.diferencia;
            }

            foreach (dsContabilidad.resumen_cobrosRow row in dsContabilidad1.resumen_cobros)
            {
                if (row.id_tipo_pago == 5)
                {
                    row.diferencia = total_dif;
                    break;
                }
            }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtHasta.Text))
                return;

            DateTime fechaActual = dtHasta.DateTime;
            fechaDesde = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, 0, 0, 0);
            fechaHasta = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, 23, 59, 59);
            LoadDatosResumen(CierreDiaActual.id);
            LoadDetalleFacturas();
            LoadDetalleFacturasAnuladas();
            LoadRecibos(fechaDesde, fechaHasta);
            LoadFacturasCredito(fechaDesde, fechaHasta);
            LoadDepositosDeCaja(fechaDesde, fechaHasta);
        }

        private void LoadFacturasCredito(DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_detalle_facturas_credito_cierre_caja]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_punto_venta", this.PuntoVentaActual.ID);
                cmd.Parameters.AddWithValue("@desde", fechaDesde);
                cmd.Parameters.AddWithValue("@hasta", fechaHasta);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsContabilidad1.facturas_credito.Clear();
                adat.Fill(dsContabilidad1.facturas_credito);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadRecibos(DateTime pDesde, DateTime pHasta)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_header_recibosH_all]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_punto_venta", this.PuntoVentaActual.ID);
                cmd.Parameters.AddWithValue("@desde", pDesde);
                cmd.Parameters.AddWithValue("@hasta", pHasta);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsFacturasGestion1.RecibosH.Clear();
                adat.Fill(dsFacturasGestion1.RecibosH);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDetalleFacturas()
        {
           
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd;
                if (this.CierreDiaActual.id == 0)
                {
                    cmd = new SqlCommand("[dbo].[sp_get_home_facturacion_punto_venta_v3]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_punto_venta", this.PuntoVentaActual.ID);
                    cmd.Parameters.AddWithValue("@desde", fechaDesde);
                    cmd.Parameters.AddWithValue("@hasta", fechaHasta);
                }
                else
                {
                    cmd = new SqlCommand("[dbo].[sp_get_home_facturacion_punto_venta_v4]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCierreDia", this.CierreDiaActual.id);
                }

                

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsContabilidad1.HomeFacturas.Clear();
                adat.Fill(dsContabilidad1.HomeFacturas);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void LoadDetalleFacturasAnuladas()
        {

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd;
                if (this.CierreDiaActual.id == 0)
                {
                    cmd = new SqlCommand("[dbo].[sp_get_home_facturacion_punto_venta_fact_anuladas]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_punto_venta", this.PuntoVentaActual.ID);
                    cmd.Parameters.AddWithValue("@desde", fechaDesde);
                    cmd.Parameters.AddWithValue("@hasta", fechaHasta);
                }
                else
                {
                    cmd = new SqlCommand("[dbo].[sp_get_home_facturacion_punto_venta_fact_anuladas_by_id_cierre]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCierreDia", this.CierreDiaActual.id);
                }

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsContabilidad1.FacturasNulas.Clear();
                adat.Fill(dsContabilidad1.FacturasNulas);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            int count = dsContabilidad1.HomeFacturas.Count;
            if(count <=0)
            {
                CajaDialogo.Error("Es necesario que hayan facturas emitidas para poder generar un cierre!");
                return;
            }

            if (string.IsNullOrEmpty(gleCajero.Text))
            {
                CajaDialogo.Error("Es necesario seleccionar el cajero!");
                return;
            }

            LoadDetalleFacturas();
            LoadDetalleFacturasAnuladas();
            LoadRecibos(fechaDesde, fechaHasta);
           // LoadFacturasCredito(fechaDesde, fechaHasta);
            LoadDepositosDeCaja(fechaDesde, fechaHasta);

            Int64 IdInserted = 0;
            dp = new DataOperations();
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
                    if (TipoTransaccionActual == TipoTransaccion.Insert)
                    {
                        command.CommandText = "dbo.sp_set_insert_header_cierre_dia";
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetros de entrada
                        command.Parameters.AddWithValue("@id_punto_venta", this.PuntoVentaActual.ID);
                        command.Parameters.AddWithValue("@fecha", fechaHasta);
                        command.Parameters.AddWithValue("@id_user_responsable", gleCajero.EditValue);

                        //// Parámetro de salida
                        //SqlParameter outputParameter = new SqlParameter("@value", SqlDbType.Int);
                        //outputParameter.Direction = ParameterDirection.Output;
                        //command.Parameters.Add(outputParameter);
                        //command.ExecuteNonQuery();

                        //// Obtener el valor de retorno
                        //if (outputParameter.Value != DBNull.Value)
                        //    IdInserted = (int)outputParameter.Value;
                        IdInserted = Convert.ToInt64(command.ExecuteScalar());
                        if (IdInserted > 0)
                        {

                            //Ligamos los documentos al cierre de caja - FACTURAS EMITIDAS -
                            foreach (dsContabilidad.HomeFacturasRow row in dsContabilidad1.HomeFacturas)
                            {
                                command.CommandText = "dbo.sp_set_cierre_dia_punto_venta";
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@id_cierre_h", IdInserted);
                                command.Parameters.AddWithValue("@num_doc", row.numero_documento);
                                command.ExecuteNonQuery();
                            }

                            //Ligamos los documentos al cierre de caja - FACTURAS NULAS - 
                            foreach (dsContabilidad.FacturasNulasRow row in dsContabilidad1.FacturasNulas)
                            {
                                command.CommandText = "dbo.sp_set_cierre_dia_punto_venta";
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@id_cierre_h", IdInserted);
                                command.Parameters.AddWithValue("@num_doc", row.numero_documento);
                                command.ExecuteNonQuery();
                            }

                            //Ligamos los documentos al cierre de caja - Depositos Internos de CAJA - 
                            foreach (dsDepositos.lista_depositosRow row in dsDepositos1.lista_depositos)
                            {
                                command.CommandText = "dbo.sp_set_id_Cierre_caja_deposito_bancario";
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@id_cierre_caja", IdInserted);
                                command.Parameters.AddWithValue("@id", row.id);//Id del deposito
                                command.ExecuteNonQuery();
                            }

                            //Guardamos los valores resumen
                            foreach (dsContabilidad.resumen_cobrosRow row in dsContabilidad1.resumen_cobros)
                            {
                                if (row.id_tipo_pago != 5)
                                {
                                    command.CommandText = "[dbo].[sp_set_cierre_dia_punto_venta_resumen]";
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.Clear();
                                    command.Parameters.AddWithValue("@id_cierre_h", IdInserted);
                                    command.Parameters.AddWithValue("@valor_contado", row.valor_contado);
                                    command.Parameters.AddWithValue("@id_tipo_pago", row.id_tipo_pago);
                                    command.Parameters.AddWithValue("@tipo_pago_name", row.tipo_pago_name);
                                    command.Parameters.AddWithValue("@total", row.total);
                                    command.ExecuteNonQuery();
                                }
                            }
                            // Attempt to commit the transaction.
                            transaction.Commit();
                            CajaDialogo.InformationAuto();
                            //this.DialogResult = DialogResult.OK;
                            //this.Close();
                            CierreDiaActual = new FacturacionCierreDiaPuntoVenta();
                            if (CierreDiaActual.RecuperarRegistro(IdInserted))
                            {
                                txtCodigoCierre.Text = CierreDiaActual.codigo;
                                if(!txtCodigoCierre.Visible)
                                    txtCodigoCierre.Visible = true;

                                txtEstado.Text = CierreDiaActual.estado_descripcion;
                                cmdImprimir.Visible = true;
                                txtAutorizadoPor.Text = CierreDiaActual.usuario_validacion_nombre;
                            }
                        }
                        else
                        {
                            transaction.Rollback();
                        }
                    }
                    else
                    {
                        if (CierreDiaActual.id > 0)
                        {
                            //Actualizamos el cajero en el header
                            command.CommandText = "[dbo].[sp_set_cambio_cajero_cierre_caja]";
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@id_cierre_caja", this.CierreDiaActual.id);
                            command.Parameters.AddWithValue("@id_user_responsable", gleCajero.EditValue);
                            command.ExecuteNonQuery();


                            foreach (dsContabilidad.resumen_cobrosRow row in dsContabilidad1.resumen_cobros)
                            {
                                if (row.id_tipo_pago != 4)
                                {
                                    command.CommandText = "[dbo].[sp_set_cierre_dia_punto_venta_resumen_update]";
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.Clear();
                                    command.Parameters.AddWithValue("@id_cierre_h", this.CierreDiaActual.id);
                                    command.Parameters.AddWithValue("@valor_contado", row.valor_contado);
                                    command.Parameters.AddWithValue("@id_tipo_pago", row.id_tipo_pago);
                                    command.Parameters.AddWithValue("@tipo_pago_name", row.tipo_pago_name);
                                    command.Parameters.AddWithValue("@total", row.total);
                                    command.Parameters.AddWithValue("@id", row.id);
                                    command.ExecuteNonQuery();
                                }
                            }
                            // Attempt to commit the transaction.
                            transaction.Commit();
                            CajaDialogo.InformationAuto();
                            //this.DialogResult = DialogResult.OK;
                            //this.Close();

                            if (CierreDiaActual.RecuperarRegistro(this.CierreDiaActual.id))
                            {
                                txtCodigoCierre.Text = CierreDiaActual.codigo;
                                if (!txtCodigoCierre.Visible)
                                    txtCodigoCierre.Visible = true;

                                txtEstado.Text = CierreDiaActual.estado_descripcion;
                                cmdImprimir.Visible = true;
                                txtAutorizadoPor.Text = CierreDiaActual.usuario_validacion_nombre;
                            }
                        }
                        else
                        {
                            transaction.Rollback();
                        }
                    }
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
                        CajaDialogo.Error("Error1: " + ex.Message + " Error2:"+ex2.Message);
                    }
                }
            }
        }

        private void dtHasta_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtHasta.Text))
                return;

            DateTime fechaActual = dtHasta.DateTime;
            fechaDesde = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, 0, 0, 0);
            fechaHasta = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, 23, 59, 59);
            LoadDatosResumen(this.CierreDiaActual.id);
            LoadDetalleFacturas();
            LoadDetalleFacturasAnuladas();
            LoadDepositosDeCaja(fechaDesde, fechaHasta);
        }

        private void cmdAutorizarCierre_Click(object sender, EventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Esta seguro de Autorizar este cierre dia?");
            if (r != DialogResult.Yes)
                return;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_set_update_cierre_dia_status", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCierre", this.CierreDiaActual.id);
                cmd.Parameters.AddWithValue("@id_estado", 2);//Confirmado
                cmd.Parameters.AddWithValue("@id_user_validacion", this.UsuarioLogeado.Id);
                cmd.Parameters.AddWithValue("@fecha_autorizado", dp.NowSetDateTime());
                cmd.ExecuteNonQuery();
                con.Close();
                this.CierreDiaActual.RecuperarRegistro(this.CierreDiaActual.id);
                CajaDialogo.InformationAuto();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }


        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //Calcular el total del valor contado
            decimal valor = 0;
            //var row = (dsContabilidad.resumen_cobrosRow)gridView1.GetFocusedDataRow();

            foreach (dsContabilidad.resumen_cobrosRow rowi in dsContabilidad1.resumen_cobros)
            {
                try
                {
                    //if (rowi.id_tipo_pago < 5)//SI no es la linea del total
                    //{
                    //    valor += rowi.valor_contado;
                    //    rowi.diferencia = rowi.valor_contado - rowi.total;
                    //}
                    //else
                    //{
                    //    rowi.valor_contado = valor;//LInea del total
                    //    rowi.diferencia = rowi.valor_contado - rowi.total;
                    //}
                    if(rowi.id_tipo_pago == 1)
                    {
                        if ((rowi.total_deposito_caja + rowi.valor_contado) > rowi.total) 
                        {
                            rowi.diferencia = (rowi.total_deposito_caja + rowi.valor_contado) - rowi.total;
                            rowi.tipo_diferencia = "Sobrante";
                        }
                        if ((rowi.total_deposito_caja + rowi.valor_contado) == rowi.total)
                        {
                            rowi.diferencia = 0;
                            rowi.tipo_diferencia = "Cuadrado";
                        }
                        if ((rowi.total_deposito_caja + rowi.valor_contado) < rowi.total)
                        {
                            rowi.diferencia = (rowi.total - (rowi.total_deposito_caja + rowi.valor_contado));
                            rowi.tipo_diferencia = "Faltante";
                        }
                    }

                    if (rowi.id_tipo_pago == 2 || rowi.id_tipo_pago == 3 || rowi.id_tipo_pago == 4)
                    {
                        if (rowi.valor_contado > rowi.total)
                        {
                            rowi.diferencia = rowi.valor_contado - rowi.total;
                            rowi.tipo_diferencia = "Sobrante";
                        }
                        if (rowi.valor_contado == rowi.total)
                        {
                            rowi.diferencia = 0;
                            rowi.tipo_diferencia = "Cuadrado";
                        }
                        if (rowi.valor_contado < rowi.total)
                        {
                            rowi.diferencia = rowi.total - rowi.valor_contado;
                            rowi.tipo_diferencia = "Faltante";
                        }
                    }
                    

                }catch { }
            }
            CalcularDiferenciaTotal();
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            //Imprimir
            if (CierreDiaActual.Recuperado)
            {
                rpt_cierre_dia_completeV2 report = new rpt_cierre_dia_completeV2(CierreDiaActual) { ShowPrintMarginsWarning = false };
                //RPT_OrdenCompra report = new RPT_OrdenCompra(num) { DataSource = dsCompras1, ShowPrintMarginsWarning = false };
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(report);
                printReport.ShowPreviewDialog();
            }
        }

        private void cmdImprimirNula_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Imprimir nuevo formato de las factura anulada

        }

        private void gleCajero_EditValueChanged(object sender, EventArgs e)
        {
            if(TipoTransaccionActual == TipoTransaccion.Insert)
            {
                UserCajero = new UserLogin();
                if (UserCajero.RecuperarRegistro(dp.ValidateNumberInt32(gleCajero.EditValue))) 
                {

                }
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            //var gv = (GridView)gridControl1.FocusedView;
            //var row = (dsContabilidad.resumen_cobrosRow)gv.GetDataRow(gv.FocusedRowHandle);

            if (e.KeyCode == Keys.Enter) 
            {
                if (gridView1.FocusedColumn.FieldName == "valor_contado")
                {
                    GridView view = sender as GridView;
                    e.Handled = true;

                    // Obtener la celda actual
                    int rowHandle = view.FocusedRowHandle;
                    int colIndex = view.FocusedColumn.VisibleIndex;

                    // Si hay otra celda hacia abajo en la misma columna
                    if (view.IsValidRowHandle(rowHandle + 1))
                    {
                        view.FocusedRowHandle = rowHandle + 1;
                        view.FocusedColumn = view.VisibleColumns[colIndex];
                    }
                    else
                    {
                        // Opcional: agregar nueva fila si estás en modo edición
                        // view.AddNewRow();
                    }
                }
            }
            

            //if (dsVentas1.detalle_factura_transaction.Count > 0)
            //    gridView1.FocusedRowHandle = dsVentas1.detalle_factura_transaction.Count - 1;
            //else
            //    gridView1.FocusedRowHandle = 0;


            //gridView1.FocusedColumn = colcantidad;
            //gridView1.ShowEditor();
        }
    }
}