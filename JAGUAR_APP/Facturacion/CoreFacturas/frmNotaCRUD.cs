using ACS.Classes;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Facturacion.Notas;
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
using static JAGUAR_PRO.Clases.Conf_TablesID;

namespace JAGUAR_PRO.Facturacion.CoreFacturas
{
    public partial class frmNotaCRUD : DevExpress.XtraEditors.XtraForm
    {
        NumeracionFiscal NumDocumentoFiscal = new NumeracionFiscal();
        PDV punto_venta = new PDV();
        Cliente cliente = new Cliente();

        int tipoNotaId = 0;
        
        public enum SourceSolicitud
        {
            FacturaEmitida=1,
            AutorizacionDirecta=2,
            FromCRUD=3 //Registro nuevo desde el Home de Notas Credito/Debito
        }

        public enum TipoNota
        {
            Credito=1,
            Debito=2
        }

        TipoNota TipoNotaActual;

        public enum EstadoSolicitud
        {
            Pendiente = 1,
            Aprobada = 2,
            Rechazada = 3
        }

        SourceSolicitud solicitudActual;
        long factura_id;
        //Factura factura1 = new Factura();

        Factura_SolicitudAutorizacion solicitud = new Factura_SolicitudAutorizacion();
        long solicitud_id = 0;
        UserLogin userLog = new UserLogin();
        public frmNotaCRUD(SourceSolicitud request,long p_solicitud_id,UserLogin pUser)
        {
            InitializeComponent();
            solicitudActual = request;
            //factura_id = factura_id_p;
            solicitud_id = p_solicitud_id;
            TipoNotaActual = TipoNota.Credito;
            punto_venta = new PDV();
            punto_venta.RecuperaRegistro(1);
            userLog = pUser;
        }

        public frmNotaCRUD(SourceSolicitud request, UserLogin pUser, int PuntVentaId, int ptipoNotaId, Factura_SolicitudAutorizacion pSolicitud)
        {
            InitializeComponent();
            solicitudActual = request;
            userLog = pUser;
            punto_venta.RecuperaRegistro(PuntVentaId);
            tipoNotaId = ptipoNotaId;
            solicitud = pSolicitud;
            cliente.RecuperarRegistro(pSolicitud.ClienteId);
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {

            Factura_SolicitudAutorizacion solicitud = new Factura_SolicitudAutorizacion();

            try
            {
                

                if (SourceSolicitud.AutorizacionDirecta==solicitudActual || SourceSolicitud.FromCRUD == solicitudActual)
                {
                    this.Close();
                }
                else
                {


                    DialogResult res = MessageBox.Show("Desea Rechazar la solicitud?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        if (solicitud.RechazarSolicitud_NotaCredito_NotaDebito(solicitud_id, (int)EstadoSolicitud.Rechazada, userLog.Id))
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    if (res == DialogResult.No)
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception exc)
            {
                CajaDialogo.Error(exc.Message);
            }
            
        }

        SqlTransaction transaccion;

        [Obsolete]
        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                var id_numeracion = NumDocumentoFiscal.ID;
                var correlativoSiguiente = NumDocumentoFiscal.Correlative;
                string doc_num="";
                total = 0;
                bool encontrar_seleccionados = false;

                foreach (var item in dsFacturasGestion.NotaD)
                {
                    if (item.seleccion == true)
                    {
                        encontrar_seleccionados = true;
                    }
                }


                if (encontrar_seleccionados == false)
                {
                    CajaDialogo.Error("Debe seleccionar las facturas a aplicarle la nota de crédito o débito");
                    return;
                }

                foreach (var nota in dsFacturasGestion.NotaD)
                {
                    if (nota.seleccion == true)
                    {
                        total = total + nota.total_line;
                    }
                }

                if (NumDocumentoFiscal.RecuperarRegistro(NumDocumentoFiscal.ID))
                {
                    string sCorrelativo = correlativoSiguiente.ToString();

                    //Rellenar ceros a la izquierda
                    while (sCorrelativo.Length < 8)
                    {
                        sCorrelativo = "0" + sCorrelativo;
                    }

                    doc_num = NumDocumentoFiscal.Leyenda + sCorrelativo;
                }

                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

                cnx.Open();
                transaccion = cnx.BeginTransaction();

                SqlCommand cmd = new SqlCommand("dbo.UspInsertNotaH_V2", cnx);
                cmd.Transaction = transaccion;
                cmd.CommandType = CommandType.StoredProcedure;

                if (SourceSolicitud.FromCRUD==solicitudActual)
                {
                    if (TipoNotaActual == TipoNota.Credito)
                    {
                        cmd.Parameters.AddWithValue("@credito", total);
                        cmd.Parameters.AddWithValue("@debito", 0);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@credito", 0);
                        cmd.Parameters.AddWithValue("@debito", total);
                    }

                    cmd.Parameters.AddWithValue("@id_punto_venta", punto_venta.ID);
                    cmd.Parameters.AddWithValue("@id_tipo_nota", (int)TipoNotaActual);
                    cmd.Parameters.AddWithValue("@solicitud_id", -1);
                    cmd.Parameters.AddWithValue("@id_cliente", cliente.Id);
                    cmd.Parameters.AddWithValue("@cliente", cliente.Nombre);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@credito", solicitud.TipoNotaId == (int)TipoNota.Credito ? total : 0);
                    cmd.Parameters.AddWithValue("@debito", solicitud.TipoNotaId == (int)TipoNota.Debito ? total : 0);
                    cmd.Parameters.AddWithValue("@id_punto_venta", solicitud.PuntoDeVenta_Id);
                    cmd.Parameters.AddWithValue("@id_tipo_nota", solicitud.TipoNotaId);
                    cmd.Parameters.AddWithValue("@solicitud_id", solicitud_id);
                    cmd.Parameters.AddWithValue("@id_cliente", solicitud.ClienteId);
                }

                cmd.Parameters.AddWithValue("@created_date", DateTime.Now);
                cmd.Parameters.AddWithValue("@cai", txtCAI.Text);
                    
                cmd.Parameters.AddWithValue("@num_documento", doc_num);
                cmd.Parameters.AddWithValue("@rtn", txtClienteRTN.Text);
                cmd.Parameters.AddWithValue("@fecha_documento", deFecha.EditValue);
                cmd.Parameters.AddWithValue("@id_doc_fiscal", NumDocumentoFiscal.ID);
                //cmd.Parameters.AddWithValue("@factura_id",factura1.Id);
                //cmd.Parameters.AddWithValue("@due_date",);
                cmd.Parameters.AddWithValue("@concepto", txtConcepto.Text);
                long id_inserted = Convert.ToInt64(cmd.ExecuteScalar());

                //Detalle
                foreach (var item in dsFacturasGestion.NotaD)
                {
                    if (item.seleccion == true)
                    {

                        SqlCommand cmd2 = new SqlCommand("dbo.uspInsertNotaD_v2", cnx);
                        cmd2.Transaction = transaccion;
                        cmd2.CommandType = CommandType.StoredProcedure;

                        cmd2.Parameters.AddWithValue("@id_nota", id_inserted);
                        cmd2.Parameters.AddWithValue("@id_factura", item.id_factura);
                        cmd2.Parameters.AddWithValue("@cuenta", "");
                        //cmd2.Parameters.AddWithValue("@price",item.price);
                        cmd2.Parameters.AddWithValue("@total_line", item.total_line);
                        cmd2.Parameters.AddWithValue("@descripcion", item.descripcion);
                        cmd2.Parameters.AddWithValue("@num_doc", item.num_doc);
                        cmd2.Parameters.AddWithValue("@id_pt", item.id_pt);
                        cmd2.Parameters.AddWithValue("@cantidad", item.cantidad);
                        cmd2.Parameters.AddWithValue("@precio", item.precio);
                        cmd2.Parameters.AddWithValue("@factura_d_id", item.id_factura_d);

                        cmd2.ExecuteNonQuery();
                    }
                }


                transaccion.Commit();

                CajaDialogo.Information("Datos Guardados");
                cnx.Close();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                transaccion.Rollback();
            }
        }

        private void frmNotaCRUD_Load(object sender, EventArgs e)
        {
            try
            {
                deFecha.EditValue = DateTime.Now;
                switch (solicitudActual)
                {
                    case SourceSolicitud.FacturaEmitida:
                        

                        DataOperations dp = new DataOperations();
                        SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        solicitud.RecuperaRegistro(solicitud_id);
                        punto_venta.RecuperaRegistro(solicitud.PuntoDeVenta_Id);
                
                        txtCliente.Text = solicitud.Cliente;
                        txtClienteRTN.Text = solicitud.Cliente_RTN;
                        deFecha.EditValue = DateTime.Now;
                        txtPDV.Text = punto_venta.NombreLegal;
                        txtRTN.Text = punto_venta.RTN;
                        txtConcepto.Text = solicitud.Justificacion;

                        //Cargar las lineas de la facturas para crear la nota de credito o debito
                        SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetLineasToCreate_NC_ND", cnx);

                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@id_autorizacion_h", solicitud_id);

                        dsFacturasGestion.NotaD.Clear();
                        da.Fill(dsFacturasGestion.NotaD);

                        NumDocumentoFiscal = new NumeracionFiscal();

                        

                        if (solicitud.TipoNotaId == (int)TipoNota.Credito)
                        {
                            if (NumDocumentoFiscal.GetIdNumeracionFiscalFromPuntoVentaId(solicitud.PuntoDeVenta_Id, NumeracionFiscal.TipoDocumentoFiscal.Nota_de_Credito))
                            {
                                if (NumDocumentoFiscal.ValidaVencimientoNumeracionFiscal(NumDocumentoFiscal.ID))
                                {
                                    CajaDialogo.Error("La numeración fiscal de las "+NumDocumentoFiscal.TipoDoc+" para este punto de venta se ha vencido.");
                                    this.Close();
                                }

                                txtCAI.Text = NumDocumentoFiscal.CAI;
                                lblNota.Text = "Nota de Crédito";
                            }

                        }

                        if (solicitud.TipoNotaId == (int)TipoNota.Debito)
                        {
                            if (NumDocumentoFiscal.GetIdNumeracionFiscalFromPuntoVentaId(solicitud.PuntoDeVenta_Id, NumeracionFiscal.TipoDocumentoFiscal.Nota_de_Debito))
                            {
                                if (NumDocumentoFiscal.ValidaVencimientoNumeracionFiscal(NumDocumentoFiscal.ID))
                                {
                                    CajaDialogo.Error("La numeración fiscal de las " + NumDocumentoFiscal.TipoDoc + "para este punto de venta se ha vencido.");
                                    return;
                                }
                                txtCAI.Text = NumDocumentoFiscal.CAI;
                                lblNota.Text = "Nota de Débito";
                            }
                        }

                        break;
                    case SourceSolicitud.AutorizacionDirecta:
                        //punto_venta.RecuperaRegistro(solicitud.PuntoDeVenta_Id);
    
                        txtPDV.Text = punto_venta.NombreLegal;
                        txtRTN.Text = punto_venta.RTN;
                        txtCliente.Text = solicitud.Cliente;
                        txtClienteRTN.Text = solicitud.Cliente_RTN;
                        txtConcepto.ReadOnly = false;
                        txtConcepto.Text = "Nota de Crédito/Débito autorizada de forma directa";

                        if (tipoNotaId == (int)TipoNota.Credito)
                        {
                            if (NumDocumentoFiscal.GetIdNumeracionFiscalFromPuntoVentaId(punto_venta.ID, NumeracionFiscal.TipoDocumentoFiscal.Nota_de_Credito))
                            {
                                if (NumDocumentoFiscal.ValidaVencimientoNumeracionFiscal(NumDocumentoFiscal.ID))
                                {
                                    CajaDialogo.Error("La numeración fiscal de las " + NumDocumentoFiscal.TipoDoc + " para este punto de venta se ha vencido.");
                                    this.Close();
                                }

                                txtCAI.Text = NumDocumentoFiscal.CAI;
                                lblNota.Text = "Nota de Crédito";
                            }

                        }

                        if (tipoNotaId == (int)TipoNota.Debito)
                        {
                            if (NumDocumentoFiscal.GetIdNumeracionFiscalFromPuntoVentaId(punto_venta.ID, NumeracionFiscal.TipoDocumentoFiscal.Nota_de_Debito))
                            {
                                if (NumDocumentoFiscal.ValidaVencimientoNumeracionFiscal(NumDocumentoFiscal.ID))
                                {
                                    CajaDialogo.Error("La numeración fiscal de las " + NumDocumentoFiscal.TipoDoc + "para este punto de venta se ha vencido.");
                                    return;
                                }
                                txtCAI.Text = NumDocumentoFiscal.CAI;
                                lblNota.Text = "Nota de Débito";
                            }
                        }
                        FacturaDetalle factura_detalle = new FacturaDetalle();

                        foreach (var item in solicitud.Facturas_seleccionadas)
                        {
                            factura_detalle = new FacturaDetalle();

                            if (factura_detalle.RecuperaDetallFactura(item.FacturaId))
                            {

                                foreach (var detalle in factura_detalle.factura_detalle)
                                {

                                dsFacturasGestion.NotaD.Rows.Add(0,item.FacturaId, "", detalle.TotalLinea, item.NumeroFactura,detalle.Descripcion,detalle.Cantidad,detalle.ProductoTerminadoId, detalle.Precio,false,detalle.FacturaDetalleId);
                                    
                                }
                            }
                        }
                        break;

                    case SourceSolicitud.FromCRUD:
                        cmdSearchCliente.Visible = true;
                        cmdSearchPDV.Visible = true;
                        cmdSearchFacturas.Visible = true;
                        txtConcepto.ReadOnly = false;
                        break;

                }

                

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            try
            {
                NumDocumentoFiscal = new NumeracionFiscal();

                if (solicitud.TipoNotaId==(int)TipoNota.Credito)
                {

                    if (NumDocumentoFiscal.GetIdNumeracionFiscalFromPuntoVentaId(solicitud.PuntoDeVenta_Id, NumeracionFiscal.TipoDocumentoFiscal.Nota_de_Credito))
                        txtCAI.Text = NumDocumentoFiscal.CAI;
                    lblNota.Text = "Nota de Crédito";
                }

                if (solicitud.TipoNotaId == (int)TipoNota.Debito)
                {
                    if(NumDocumentoFiscal.GetIdNumeracionFiscalFromPuntoVentaId(solicitud.PuntoDeVenta_Id, NumeracionFiscal.TipoDocumentoFiscal.Nota_de_Debito))
                        txtCAI.Text = NumDocumentoFiscal.CAI;
                    lblNota.Text = "Nota de Débito";
                }




            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        Decimal total = 0;
        private void grd_data_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                total = 0;

                if (e.Column.FieldName=="cantidad")
                {
                  decimal cantidad= Convert.ToDecimal(    grd_data.GetRowCellValue(e.RowHandle,grd_data.Columns[6]));
                  decimal precio= Convert.ToDecimal(grd_data.GetRowCellValue(e.RowHandle,grd_data.Columns[8]));

                    var row = (dsFacturasGestion.NotaDRow)grd_data.GetDataRow(e.RowHandle);

                    row.total_line = cantidad * precio;

                    //grd_data.SetRowCellValue(e.RowHandle, grd_data.Columns[3], (cantidad * precio));
                }

                foreach (var item in dsFacturasGestion.NotaD)
                {
                    if (item.seleccion==true)
                    {
                        total = total + item.total_line;
                    }
                }

                lblTotal.Text = "Total: L "+ total.ToString("N2");
            }
            catch (Exception exc)
            {
                CajaDialogo.Error(exc.Message);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void cmdSearchPDV_Click(object sender, EventArgs e)
        {
            frmNotasSearchPDV frm = new frmNotasSearchPDV();



            if (frm.ShowDialog()== DialogResult.OK)
            {
                txtPDV.Text = frm.pdv;

                punto_venta.RecuperaRegistro(frm.id_pdv);

                txtPDV.Text = punto_venta.NombreLegal;
                txtRTN.Text = punto_venta.RTN;

                if (TipoNotaActual == TipoNota.Credito)
                {
                    txtCAI.Text = punto_venta.CAI_NotaCredido;
                }
                else
                {
                    txtCAI.Text = punto_venta.CAI_NotaDebito;
                }

                if (TipoNotaActual == TipoNota.Credito)
                {
                    if (NumDocumentoFiscal.GetIdNumeracionFiscalFromPuntoVentaId(punto_venta.ID, NumeracionFiscal.TipoDocumentoFiscal.Nota_de_Credito))
                    {
                        if (NumDocumentoFiscal.ValidaVencimientoNumeracionFiscal(NumDocumentoFiscal.ID))
                        {
                            CajaDialogo.Error("La numeración fiscal de las " + NumDocumentoFiscal.TipoDoc + " para este punto de venta se ha vencido.");
                            this.Close();
                        }

                        txtCAI.Text = NumDocumentoFiscal.CAI;
                        lblNota.Text = "Nota de Crédito";
                    }

                }

                if (TipoNotaActual == TipoNota.Debito)
                {
                    if (NumDocumentoFiscal.GetIdNumeracionFiscalFromPuntoVentaId(punto_venta.ID, NumeracionFiscal.TipoDocumentoFiscal.Nota_de_Debito))
                    {
                        if (NumDocumentoFiscal.ValidaVencimientoNumeracionFiscal(NumDocumentoFiscal.ID))
                        {
                            CajaDialogo.Error("La numeración fiscal de las " + NumDocumentoFiscal.TipoDoc + "para este punto de venta se ha vencido.");
                            return;
                        }
                        txtCAI.Text = NumDocumentoFiscal.CAI;
                        lblNota.Text = "Nota de Débito";
                    }
                }

            }
        }

        private void tsNotaCD_Toggled(object sender, EventArgs e)
        {

            if (punto_venta.ID != 0)
            {
                if (TipoNotaActual == TipoNota.Credito)
                {
                    txtCAI.Text = punto_venta.CAI_NotaCredido;
                }
                else
                {
                    txtCAI.Text = punto_venta.CAI_NotaDebito;
                }
            }
        }

        private void cmdSearchCliente_Click(object sender, EventArgs e)
        {
            frmNotasSearchClientes frm = new frmNotasSearchClientes();
            cliente = new Cliente();
            if (frm.ShowDialog()== DialogResult.OK)
            {
                if (cliente.RecuperarRegistro(frm.id_cliente))
                {
                    txtCliente.Text = string.IsNullOrEmpty(cliente.NombreCorto) ? cliente.Nombre : cliente.NombreCorto ;
                }
            }
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            frmNotasSearchFacturas frm = new frmNotasSearchFacturas(punto_venta.ID,cliente.Id);

            if (punto_venta.ID==0)
            {
                CajaDialogo.Error("DEBE DE SELECCIONAR UN PUNTO DE VENTA");
                return;
            }

            if (cliente.Id == 0)
            {
                CajaDialogo.Error("DEBE DE SELECCIONAR UN CLIENTE");
                return;
            }

            if (frm.ShowDialog() == DialogResult.OK)
            {

                foreach (var item in frm.facturasSeleccionadas)
                {
                    dsFacturasGestion.NotaD.Rows.Add(0,item.FacturaId,"",item.TotalLinea,item.NumeroDocumento,item.Descripcion,item.Cantidad,item.ProductoTerminadoId,item.Precio,false,0);
                }
            }
        }

        private void grd_data_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.IsTotalSummary)// && (e.Item as GridSummaryItem).FieldName == "Length")
            {
                GridSummaryItem item = e.Item as GridSummaryItem;

                //if (item.FieldName == "Length")
                {
                    switch (e.SummaryProcess)
                    {
                        case CustomSummaryProcess.Start:
                            //sum = 0;
                            break;
                        case CustomSummaryProcess.Calculate:
                            bool shouldSum = (bool)view.GetRowCellValue(e.RowHandle, "seleccionar");
                            if (shouldSum)
                            {
                                //sum += (double)e.FieldValue;
                            }
                            break;
                        case CustomSummaryProcess.Finalize:
                            e.TotalValue = 0;
                            break;
                    }
                }
            }
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void rdCredito_CheckedChanged(object sender, EventArgs e)
        {
            TipoNotaActual = TipoNota.Credito;
            rdDebito.CheckedChanged -= new EventHandler(rdDebito_CheckedChanged);
            rdDebito.Checked = false;
            rdDebito.CheckedChanged += new EventHandler(rdDebito_CheckedChanged);
        }

        private void rdDebito_CheckedChanged(object sender, EventArgs e)
        {
            TipoNotaActual = TipoNota.Debito;
            rdCredito.CheckedChanged -= new EventHandler(rdCredito_CheckedChanged);
            rdCredito.Checked = false;
            rdCredito.CheckedChanged += new EventHandler(rdCredito_CheckedChanged);
        }
    }
}