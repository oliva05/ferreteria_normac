using ACS.Classes;
using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using DevExpress.CodeParser;

namespace JAGUAR_PRO.Facturacion.Reportes
{
    public partial class rpt_cierre_dia_completeV2 : DevExpress.XtraReports.UI.XtraReport
    {
        PDV PuntoVentaActual;
        public rpt_cierre_dia_completeV2(FacturacionCierreDiaPuntoVenta cierre1)
        {
            InitializeComponent();
            if ( cierre1 != null)
            {
                if (cierre1.Recuperado)
                {
                    PuntoVentaActual = new PDV();
                    if (PuntoVentaActual.RecuperaRegistro(cierre1.id_punto_venta))
                    {
                        lblDireccion.Text = PuntoVentaActual.Direccion;
                        lblCompanyName.Text = PuntoVentaActual.Nombre;
                        lblLegalName.Text = PuntoVentaActual.NombreLegal;
                        lblCodigoCierreDia.Text = cierre1.codigo;
                    }
                    lblResponsable.Text = cierre1.usuario_responsable_nombre;
                    lblRevisadoPor.Text = cierre1.usuario_validacion_nombre;
                    lblFechaCierre.Text = string.Format("{0:dd/MMM/yyyy}", cierre1.fecha);

                    LoadDatosHeader(cierre1.id);

                    LoadDatosDetalle(cierre1.id);
                }
            }
            
        }

        private void LoadDatosHeader(Int64 pIdCierre)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                //SqlCommand cmd = new SqlCommand("[dbo].[sp_get_datos_resumen_cierre_caja_by_id_v2]", con);
                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_datos_resumen_cierre_caja_by_id_v3]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCierreH", pIdCierre);
                SqlDataReader dr = cmd.ExecuteReader();
                decimal Total = 0;
                decimal TotalContado = 0;
                decimal TotalDespoitos = 0;
                decimal TotalDiferencias = 0;

                while (dr.Read())
                {
                    int tipopago = 0;
                    if (!dr.IsDBNull(dr.GetOrdinal("id_tipo_pago")))
                        tipopago = dr.GetInt32(1);



                    switch (tipopago)
                    {
                        case 1://Efectivo
                            decimal valor1 = dr.GetDecimal(3);//Total
                            decimal TotalEfectivoDeposito = dr.GetDecimal(4);//Total deposito caja

                            decimal valorC1 = dr.GetDecimal(5);//Valor contado
                            
                            Total += valor1;
                            TotalContado += valorC1;
                            lblTipoDiferenciaEfectivo.Text = dr.GetString(6);
                            decimal diferenciaEfectivo = dr.GetDecimal(7);
                            TotalDespoitos += TotalEfectivoDeposito;
                            TotalDiferencias += diferenciaEfectivo;

                            lblTotalEfectivo.Text = string.Format("{0:L ###,##0.00}", valor1);
                            lblDepositoEfectivoCaja.Text = string.Format("{0:L ###,##0.00}", TotalEfectivoDeposito);
                            lblTotalEfectivoVerificado.Text = string.Format("{0:L ###,##0.00}", valorC1);
                            //Arriba pusimos la descripcion de tipo de diferencia
                            lblDiferenciaEfectivo.Text = string.Format("{0:L ###,##0.00}", diferenciaEfectivo);
                            break;
                        case 2:
                            decimal valor2 = dr.GetDecimal(3);
                            decimal valorC2 = dr.GetDecimal(5);

                            Total += valor2;
                            TotalContado += valorC2;
                            lblTipoDiferenciaTarjetas.Text = dr.GetString(6);
                            decimal diferenciaTarjeta = dr.GetDecimal(7);
                            TotalDiferencias += diferenciaTarjeta;

                            lblTotalTarjetas.Text = string.Format("{0:L ###,##0.00}", valor2);
                            lblTotalTarjetaVerificado.Text = string.Format("{0:L ###,##0.00}", valorC2);
                            lblDiferenciaTarjetas.Text = string.Format("{0:L ###,##0.00}", diferenciaTarjeta);
                            break;
                        case 3:
                            decimal valor3 = dr.GetDecimal(3);
                            decimal valorC3 = dr.GetDecimal(5);

                            Total += valor3;
                            TotalContado += valorC3;
                            lblTipoDiferenciaTransferencia.Text = dr.GetString(6);
                            decimal diferenciaTransferencia = dr.GetDecimal(7);
                            TotalDiferencias += diferenciaTransferencia;

                            lblTotalDeposito.Text = string.Format("{0:L ###,##0.00}", valor3);
                            lblTotalBancosVerificado.Text = string.Format("{0:L ###,##0.00}", valorC3);
                            lblDiferenciaTransferencia.Text = string.Format("{0:L ###,##0.00}", diferenciaTransferencia);
                            break;
                        case 4:
                            decimal valor4 = dr.GetDecimal(3);
                            decimal valorC4 = dr.GetDecimal(5);

                            Total += valor4;
                            TotalContado += valorC4;
                            lblTipoDiferenciaCheque.Text = dr.GetString(6);
                            decimal diferenciaCheque = dr.GetDecimal(7);
                            TotalDiferencias += diferenciaCheque;

                            lblTotalCheque.Text = string.Format("{0:L ###,##0.00}", valor4);
                            lblTotalChequeVerificado.Text = string.Format("{0:L ###,##0.00}", valorC4);
                            lblDiferenciaCheque.Text = string.Format("{0:L ###,##0.00}", diferenciaCheque);
                            break;
                        case 5:
                            break;
                        default:
                            break;
                    }
                    
                }
                lblTotalIngresos.Text = 
                lblTotalGeneral.Text = string.Format("{0:L ###,##0.00}", Total);

                lblTotalVerificado.Text = string.Format("{0:L ###,##0.00}", TotalContado);
                lblTotalDepositoCaja.Text = string.Format("{0:L ###,##0.00}", TotalDespoitos);
                lblDiferencia_Total.Text = string.Format("{0:L ###,##0.00}", TotalDiferencias);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDatosDetalle(Int64 pIdCierre)
        {
            //
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                //SqlCommand cmd = new SqlCommand("[dbo].[sp_get_home_facturacion_punto_venta_print_version]", con);
                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_home_facturacion_punto_venta_print_version_v4]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCierreDia", pIdCierre);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsContabilidad1.cierre_caja_detalle.Clear();
                adat.Fill(dsContabilidad1.cierre_caja_detalle);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}
