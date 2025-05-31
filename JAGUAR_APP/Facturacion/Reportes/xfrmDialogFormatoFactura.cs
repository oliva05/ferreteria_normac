using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Facturacion.CoreFacturas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO.Facturacion.Reportes
{
    public partial class xfrmDialogFormatoFactura : DevExpress.XtraEditors.XtraForm
    {
        Factura factura = new Factura();
        int factura_id = 0;
        PDV PuntoVentaActual;
        UserLogin UsuarioLogeado;

        public enum TipoInforme
        {
            TipoCinta3_pulg =1,
            TipoCarta = 2
        }
        TipoInforme TipoInformeActual;

        enum EstadosFactura
        {
            Emitida = 1
          , Pagada = 2
          , Anulada = 3
          , PagoParcial = 4
        }

        public xfrmDialogFormatoFactura(int pFactura_id, PDV pPuntoVenta, UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            factura_id = pFactura_id;
            PuntoVentaActual = pPuntoVenta;
            UsuarioLogeado = pUsuarioLogeado;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //if (factura.RecuperarRegistro(factura_id))
            //{
            //    if (factura.CantidadImpresionesFactura == 0)
            //    {
            //        rptFactura report = new rptFactura(factura, rptFactura.TipoCopia.Blanco);

            //        using (ReportPrintTool printTool = new ReportPrintTool(report))
            //        {
            //            // Send the report to the default printer.
            //            factura.UpdatePrintCount(factura_id);
            //            printTool.ShowPreviewDialog();
            //        }
            //    }
            //    else
            //    {
            //        CajaDialogo.Error("Esta factura ya se imprimió! Para una reimpresión debe solicitar una autorización!");
            //    }
            //}
            //this.Close();
            TipoInformeActual = TipoInforme.TipoCinta3_pulg;
            if (factura.RecuperarRegistro(factura_id))
            {
                if (PuntoVentaActual.PermiteReimpresionFacturaConAutorizacion)
                {
                    if (factura.CantidadImpresionesFactura == 0)
                    {
                        Reimpresion();
                    }
                    else
                    {
                        DialogResult r = CajaDialogo.Pregunta("Esta factura ya se imprimió! Desea solicitar una reimpresión por autorización?");
                        if (r == DialogResult.Yes)
                        {
                            try
                            {
                                //var row = (dsFacturasGestion.HomeFacturasRow)gvFacturas.GetFocusedDataRow();
                                Factura_SolicitudAutorizacion solicitud = new Factura_SolicitudAutorizacion();
                                solicitud.Facturas_seleccionadas = new List<FacturasSeleccionada>();
                                solicitud.Clientes_Seleccionados = new List<int>();

                                if (factura.IdEstado == (int)EstadosFactura.Anulada)
                                {
                                    CajaDialogo.Error("No se puede proceder con facturas que estan anuladas");
                                    return;
                                }

                                solicitud.Facturas_seleccionadas.Add(new FacturasSeleccionada()
                                {
                                    FacturaId = factura.Id,
                                    NumeroFactura = factura.NumeroDocumento,
                                    Monto = factura.TotalFactura,
                                    PuntoVenda_Id = this.PuntoVentaActual.ID,
                                    PuntoVenta = this.PuntoVentaActual.Nombre
                                });
                                //solicitud.Facturas_seleccionadas.Add(item.id);
                                DataOperations dp = new DataOperations();
                                solicitud.Clientes_Seleccionados.Add(dp.ValidateNumberInt32(factura.IdCliente));
                                solicitud.UsuarioSolicita_Id = UsuarioLogeado.Id;
                                solicitud.FacturaId = factura.Id;
                                solicitud.PuntoDeVenta_Id = this.PuntoVentaActual.ID;
                                solicitud.ClienteId = dp.ValidateNumberInt32(factura.IdCliente);
                                solicitud.Cliente = factura.ClienteNombre;
                                solicitud.Cliente_RTN = factura.RTN;
                                //xfrmDialogAutorizacion authorize = new xfrmDialogAutorizacion(solicitud, this.PuntoDeVentaActual);
                                frmNavigationPageAutorizacion authorize = new frmNavigationPageAutorizacion(solicitud, this.PuntoVentaActual);

                                if (authorize.ShowDialog() == DialogResult.OK)
                                {
                                    if (authorize.tipoAutorizacionActual == frmNavigationPageAutorizacion.TipoAutorizacion.Reimpresion && authorize.autorizacion_directa == true)
                                    {
                                        //row.EstadoName = "Anulada";
                                        Reimpresion();
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                CajaDialogo.Error(ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    Reimpresion();
                }
            }
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TipoInformeActual = TipoInforme.TipoCarta;
            if (factura.RecuperarRegistro(factura_id))
            {
                if (PuntoVentaActual.PermiteReimpresionFacturaConAutorizacion)
                {
                    if (factura.CantidadImpresionesFactura == 0)
                    {
                        Reimpresion();
                    }
                    else
                    {
                        DialogResult r = CajaDialogo.Pregunta("Esta factura ya se imprimió! Desea solicitar una reimpresión por autorización?");
                        if(r == DialogResult.Yes)
                        {
                            try
                            {
                                //var row = (dsFacturasGestion.HomeFacturasRow)gvFacturas.GetFocusedDataRow();
                                Factura_SolicitudAutorizacion solicitud = new Factura_SolicitudAutorizacion();
                                solicitud.Facturas_seleccionadas = new List<FacturasSeleccionada>();
                                solicitud.Clientes_Seleccionados = new List<int>();

                                if (factura.IdEstado == (int)EstadosFactura.Anulada)
                                {
                                    CajaDialogo.Error("No se puede proceder con facturas que estan anuladas");
                                    return;
                                }

                                solicitud.Facturas_seleccionadas.Add(new FacturasSeleccionada()
                                {
                                    FacturaId = factura.Id,
                                    NumeroFactura = factura.NumeroDocumento,
                                    Monto = factura.TotalFactura,
                                    PuntoVenda_Id = this.PuntoVentaActual.ID,
                                    PuntoVenta = this.PuntoVentaActual.Nombre
                                });
                                //solicitud.Facturas_seleccionadas.Add(item.id);
                                DataOperations dp =     new DataOperations();
                                solicitud.Clientes_Seleccionados.Add(dp.ValidateNumberInt32(factura.IdCliente));
                                solicitud.UsuarioSolicita_Id = UsuarioLogeado.Id;
                                solicitud.FacturaId = factura.Id;
                                solicitud.PuntoDeVenta_Id = this.PuntoVentaActual.ID;
                                solicitud.ClienteId = dp.ValidateNumberInt32(factura.IdCliente);
                                solicitud.Cliente = factura.ClienteNombre;
                                solicitud.Cliente_RTN = factura.RTN;
                                //xfrmDialogAutorizacion authorize = new xfrmDialogAutorizacion(solicitud, this.PuntoDeVentaActual);
                                frmNavigationPageAutorizacion authorize = new frmNavigationPageAutorizacion(solicitud, this.PuntoVentaActual);

                                if (authorize.ShowDialog() == DialogResult.OK)
                                {
                                    if (authorize.tipoAutorizacionActual == frmNavigationPageAutorizacion.TipoAutorizacion.Reimpresion && authorize.autorizacion_directa == true)
                                    {
                                        //row.EstadoName = "Anulada";
                                        Reimpresion();
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                CajaDialogo.Error(ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    Reimpresion();
                }
            }
            this.Close();
        }

        private void Reimpresion()
        {
            //if (factura.IdNumeracionFiscal == 0)
            if(TipoInformeActual  == TipoInforme.TipoCinta3_pulg)
            {
                //rptFact_ReciboVentaLetterSize report = new rptFact_ReciboVentaLetterSize(factura, rptFact_ReciboVentaLetterSize.TipoCopia.Blanco);
                rptFactura report = new rptFactura(factura, rptFactura.TipoCopia.Blanco);
                using (ReportPrintTool printTool = new ReportPrintTool(report))
                {
                    // Send the report to the default printer.
                    factura.UpdatePrintCount(factura_id);
                    printTool.ShowPreviewDialog();
                }
            }
            else
            {
                //rptFacturaLetterSize report = new rptFacturaLetterSize(factura, rptFacturaLetterSize.TipoCopia.Blanco);
                //rptFactura report = new rptFactura(factura, rptFactura.TipoCopia.Blanco);
                rptFacturaLetterSize report = new rptFacturaLetterSize(factura, rptFacturaLetterSize.TipoCopia.Blanco);
                using (ReportPrintTool printTool = new ReportPrintTool(report))
                {
                    // Send the report to the default printer.
                    factura.UpdatePrintCount(factura_id);
                    printTool.ShowPreviewDialog();
                }
            }
        }
    }
}