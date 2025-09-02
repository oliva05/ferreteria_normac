﻿using ACS.Classes;
using DevExpress.CodeParser;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Accesos.AutorizacionSingle;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Facturacion.CoreFacturas;
using JAGUAR_PRO.Facturacion.Cotizaciones;
using JAGUAR_PRO.Facturacion.Mantenimientos.Models;
using JAGUAR_PRO.Facturacion.Numeracion_Fiscal;
using JAGUAR_PRO.Facturacion.Reportes;
using JAGUAR_PRO.Mantenimientos;
using JAGUAR_PRO.Mantenimientos.Modelos;
using JAGUAR_PRO.RecuentoInventario;
using JAGUAR_PRO.Utileria;
using LOSA.Calidad.LoteConfConsumo;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Data.Filtering.Helpers.SubExprHelper.ThreadHoppingFiltering;
using static DevExpress.DataProcessing.InMemoryDataProcessor.AddSurrogateOperationAlgorithm;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;
using static JAGUAR_PRO.Clases.BinGranel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace Eatery.Ventas
{
    public partial class frmFactura : Form
    {
        DataOperations dp = new DataOperations();
        PDV PuntoDeVentaActual;
        FacturacionEquipo EquipoActual;
        int ProIdCliente;
        ClienteFacturacion ClienteFactura;
        int IdTerminoPago;
        int IdPedido = 0;
        PedidoCliente PedidoRecuperado;
        Vendedor VendedorActual;

        public enum TipoFacturacionStock
        {
            VentaNormal = 1,
            VentaUsados = 2
        }

        UserLogin UsuarioLogeado;
        public enum Busqueda
        {
            LoMasVendido = 1,
            Todos = 2
        }

        Busqueda BusquedaSet;

        public frmFactura(UserLogin pUser, PDV pPuntoDeVentaActual, FacturacionEquipo pEquipoActual, TipoFacturacionStock pTipo)
        {
            InitializeComponent();
            ClienteFactura = new ClienteFacturacion();
            IdTerminoPago = 1;
            PuntoDeVentaActual = pPuntoDeVentaActual;
            EquipoActual = pEquipoActual;

            BusquedaSet = Busqueda.LoMasVendido;
            //SetBusqueda();
            txtNombreCliente.Text = "Consumidor Final";
            txtRTN.Text = string.Empty;
            txtRTN.Properties.NullValuePrompt =
            txtDireccion.Properties.NullValuePrompt = "No Aplica";

            UsuarioLogeado = pUser;
            lblfecha.Text = Convert.ToString(dp.NowSetDateTime());
            string.Format("{0:MM/dd/yyyy}", lblfecha.Text);

            string HostName = Dns.GetHostName();
            
            //FacturacionEquipo Equipo1 = new FacturacionEquipo();
            //if (Equipo1.RecuperarRegistro(HostName))
            //{
            //    if (PuntoDeVentaActual.RecuperaRegistro(Equipo1.id_punto_venta))
            //    {
            //        if (PuntoDeVentaActual.FacturaComidaBuffet)//Mostramos todas las opciones
            //        {
            //            //lblOpcionesBuffetRadioButtonGroup.Visible =
            //            radioGroupVentaComidaBuffet.Visible = true;
            //            LoadDefaultOptionRadioButtos();
            //        }
            //        else
            //        {
            //            //lblOpcionesBuffetRadioButtonGroup.Visible = 
            //            radioGroupVentaComidaBuffet.Visible = false;
            //            LoadDefaultOptionRadioButtos();
            //        }
            //    }
            //}
            //if (HostName == "7L12TV3" || HostName == "F3DYSQ2" /*Danys Oliva*/ ||
            //    HostName == "9SSCBV2" || HostName == "9PG91W2" /*Ruben Garcia */ ||
            //    HostName == "F9Q11Q2" /*PC Soporte La 50*/||
            //    HostName == "EUCEDA-PC" /*Euceda*/)
            //{
            //    cmdIngresarAdmin.Visible = SaltarLogin.Visible = simpleButton2.Visible = SaltarLoginPRD.Visible = true;
            //}
        }

        public frmFactura(UserLogin pUser, PDV pPuntoDeVentaActual, FacturacionEquipo pEquipoActual, int pIdPedido)
        {
            InitializeComponent();
            ClienteFactura = new ClienteFacturacion();
            
            PuntoDeVentaActual = pPuntoDeVentaActual;
            EquipoActual = pEquipoActual;

            BusquedaSet = Busqueda.LoMasVendido;
            //SetBusqueda();
            txtNombreCliente.Text = "Consumidor Final";
            txtRTN.Text = string.Empty;
            txtRTN.Properties.NullValuePrompt =
            txtDireccion.Properties.NullValuePrompt = "No Aplica";
            //lblCodigoProducto.Visible = txtScanProducto.Visible = simpleButton1.Visible = cmdCopiarFromPedido.Visible = false;
            cmdChangeVendedor.Visible = false ;
            txtVendedor.ReadOnly = true;

            UsuarioLogeado = pUser;
            lblfecha.Text = Convert.ToString(dp.NowSetDateTime());
            string.Format("{0:MM/dd/yyyy}", lblfecha.Text);

            string HostName = Dns.GetHostName();

            PedidoCliente Pedido1 = new PedidoCliente();
            if (Pedido1.RecuperarRegistro(pIdPedido))
            {
                IdPedido = pIdPedido;
                ProIdCliente = Pedido1.IdCliente;
                if (ClienteFactura == null)
                    ClienteFactura = new ClienteFacturacion();

                txtComentario.Text =  Pedido1.Comentario;
                IdTerminoPago = Pedido1.IdTerminoPago;

                if (IdTerminoPago == 1)//Contado
                {
                    rdContado.CheckedChanged -= new EventHandler(rdContado_CheckedChanged);
                    rdCredito.CheckedChanged -= new EventHandler(rdCredito_CheckedChanged);
                    rdPorCobrar.CheckedChanged -= new EventHandler(rdPorCobrar_CheckedChanged);
                    rdContado.Checked = true;
                    rdCredito.Checked = false;
                    rdPorCobrar.Checked = false;
                    rdCredito.CheckedChanged += new EventHandler(rdCredito_CheckedChanged);
                    rdContado.CheckedChanged += new EventHandler(rdContado_CheckedChanged);
                    rdPorCobrar.CheckedChanged += new EventHandler(rdPorCobrar_CheckedChanged);
                }

                if (IdTerminoPago == 2)//Credito
                {
                    rdContado.CheckedChanged -= new EventHandler(rdContado_CheckedChanged);
                    rdContado.CheckedChanged -= new EventHandler(rdContado_CheckedChanged);
                    rdCredito.CheckedChanged -= new EventHandler(rdCredito_CheckedChanged);
                    rdContado.Checked = false;
                    rdCredito.Checked = true;
                    rdPorCobrar.Checked = false;
                    rdCredito.CheckedChanged += new EventHandler(rdCredito_CheckedChanged);
                    rdContado.CheckedChanged += new EventHandler(rdContado_CheckedChanged);
                    rdContado.CheckedChanged += new EventHandler(rdContado_CheckedChanged);
                }
                
                if (IdTerminoPago == 3)//Por Cobrar
                {
                    rdContado.CheckedChanged -= new EventHandler(rdContado_CheckedChanged);
                    rdContado.CheckedChanged -= new EventHandler(rdContado_CheckedChanged);
                    rdCredito.CheckedChanged -= new EventHandler(rdCredito_CheckedChanged);
                    rdContado.Checked = false;
                    rdCredito.Checked = false;
                    rdPorCobrar.Checked = true;
                    rdCredito.CheckedChanged += new EventHandler(rdCredito_CheckedChanged);
                    rdContado.CheckedChanged += new EventHandler(rdContado_CheckedChanged);
                    rdContado.CheckedChanged += new EventHandler(rdContado_CheckedChanged);
                }

                //this.UsuarioLogeado = new UserLogin();
                //if (UsuarioLogeado.RecuperarRegistro(Pedido1.IdUser))
                //{
                //    txtVendedor.Text = UsuarioLogeado.Codigo + " - " + UsuarioLogeado.NombreUser;
                //}
                VendedorActual = new Vendedor();
                if (VendedorActual.RecuperarRegistro(Pedido1.Id_Vendedor))
                {
                    txtVendedor.Text = VendedorActual.CodigoVendedor + " - " + VendedorActual.Nombre;
                    
                }

                PedidoRecuperado = Pedido1;

                if (!string.IsNullOrEmpty(Pedido1.ClienteNombre))
                    txtNombreCliente.Text = Pedido1.ClienteNombre;
                else
                    txtNombreCliente.Text = ClienteFactura.NombreCliente;

                if (!string.IsNullOrEmpty(Pedido1.direccion_cliente))
                    txtDireccion.Text = Pedido1.direccion_cliente;
                else
                    txtDireccion.Text = ClienteFactura.Direccion;

                if (!string.IsNullOrEmpty(Pedido1.RTN))
                    txtRTN.Text = Pedido1.RTN;
                else
                    txtRTN.Text = "";

                CargarDetalleCotizacion(pIdPedido);

                //Poner todas las columnas como ReadOnly = true
                foreach (GridColumn column in gridView1.Columns)
                {
                    column.OptionsColumn.ReadOnly = true;
                }
                gridView1.OptionsMenu.EnableColumnMenu = false;
                //if (ClienteFactura.RecuperarRegistro(Pedido1.IdCliente))
                //{
                //    //ClienteEmpresa clienteEmpresa1 = new ClienteEmpresa();
                //    //if (clienteEmpresa1.RecuperarEmpresaRTNCliente(ClienteFactura.Id, Pedido1.RTN))
                //    //{
                //    //    txtNombreCliente.Text = clienteEmpresa1.NombreLargo;
                //    //    txtRTN.Text = clienteEmpresa1.RTN;
                //    //    txtDireccion.Text = clienteEmpresa1.Direccion;
                //    //}
                //    //else
                //    //{
                        
                //    //}

                    
                //    //Habilita o deshabilita que el user pueda manipular
                //    //el menu haciendo clic derecho sobre el header de una columna,
                //    //para elegir columnas, ordenar, etc

                //}
            }
        }

        private void LoadDefaultOptionRadioButtos()
        {
            //int HoraActualInt = DateTime.Now.Hour;
            //if (HoraActualInt <= 10)
            //{
            //    radioGroupVentaComidaBuffet.SelectedIndexChanged -= new EventHandler(radioGroupVentaComidaBuffet_SelectedIndexChanged);
            //    radioGroupVentaComidaBuffet.SelectedIndex = 0;//Desayuno
            //    radioGroupVentaComidaBuffet.SelectedIndexChanged += new EventHandler(radioGroupVentaComidaBuffet_SelectedIndexChanged);

            //    LoadOpcionesRapidas(1);
            //}

            //if (HoraActualInt > 10 && HoraActualInt <= 15)
            //{
            //    radioGroupVentaComidaBuffet.SelectedIndexChanged -= new EventHandler(radioGroupVentaComidaBuffet_SelectedIndexChanged);
            //    radioGroupVentaComidaBuffet.SelectedIndex = 1;//Almuerzos
            //    radioGroupVentaComidaBuffet.SelectedIndexChanged += new EventHandler(radioGroupVentaComidaBuffet_SelectedIndexChanged);
            //    LoadOpcionesRapidas(1);
            //}

            //if (HoraActualInt > 15)
            //{

            //    radioGroupVentaComidaBuffet.SelectedIndexChanged -= new EventHandler(radioGroupVentaComidaBuffet_SelectedIndexChanged);
            //    radioGroupVentaComidaBuffet.SelectedIndex = 2;//cenas
            //    radioGroupVentaComidaBuffet.SelectedIndexChanged += new EventHandler(radioGroupVentaComidaBuffet_SelectedIndexChanged);
            //    LoadOpcionesRapidas(1);
            //}
        }

        private void pictAquafeed_Click(object sender, EventArgs e)
        {
            //Busqueda filtrando solo empleados de aquafeed
            //El parametro es el id de la compañia.
            //cuatro (4) es aquafeed
            BuscarCliente(4);
        }

        private void cmdAbrirBusqueda_Click(object sender, EventArgs e)
        {
            //Busqueda General
            //El parametro es el id de la compañia.
            //Cero (0) es todas
            BuscarCliente(0);
        }


        void BuscarCliente(int pParametro)
        {
            frmSearch frm = new frmSearch(frmSearch.TipoBusqueda.Clientes);
            if(frm.ShowDialog()== DialogResult.OK)
            {
                ProIdCliente = frm.ItemSeleccionado.id;
                if (ClienteFactura == null)
                    ClienteFactura = new ClienteFacturacion();

                if (ClienteFactura.RecuperarRegistro(frm.ItemSeleccionado.id))
                {
                    //txtNombreCliente.Text = ClienteFactura.Nombre;
                    //txtRTN.Text = ClienteFactura.rtn
                    ClienteEmpresa clienteEmpresa1 = new ClienteEmpresa();
                    if (clienteEmpresa1.RecuperarRegistro(frm.EmpresaID, ClienteFactura.Id))
                    {
                        txtNombreCliente.Text = clienteEmpresa1.NombreLargo;
                        txtRTN.Text = clienteEmpresa1.RTN;
                        txtDireccion.Text = clienteEmpresa1.Direccion;
                    }
                    else
                    {
                        txtNombreCliente.Text = ClienteFactura.NombreCliente;
                        txtDireccion.Text = ClienteFactura.Direccion;
                        txtRTN.Text = "";
                    }

                    if (dsVentas1.detalle_factura_transaction.Count > 0)
                    {
                        decimal AcumuladoTotalFactura = 0;
                        foreach (dsVentas.detalle_factura_transactionRow row1 in dsVentas1.detalle_factura_transaction)
                        {
                            ProductoTerminado pt1 = new ProductoTerminado();
                            if (pt1.Recuperar_producto(row1.id_pt))
                            {
                                row1.precio = PuntoDeVentaActual.RecuperarPrecioItem(row1.id_pt, PuntoDeVentaActual.ID, this.ClienteFactura.Id);

                                if (row1.precio == 0)
                                {
                                    SetErrorBarra("Este producto no tiene definido un precio. Por favor valide Lista de Precios!");
                                }

                                row1.descuento = 0;
                                row1.inventario = pt1.Recuperar_Cant_Inv_Actual_PT_for_facturacion(pt1.Id, this.PuntoDeVentaActual.ID);

                                row1.isv1 = row1.isv2 = row1.isv3 = 0;
                                Impuesto impuesto = new Impuesto();
                                decimal tasaISV = 0;

                                if (impuesto.RecuperarRegistro(pt1.Id_isv_aplicable))
                                {
                                    tasaISV = impuesto.Valor / 100;
                                    row1.isv1 = ((row1.precio - row1.descuento) / 100) * impuesto.Valor;
                                    row1.precio = (row1.precio - row1.descuento) - row1.isv1;

                                    row1.tasa_isv = tasaISV;
                                    row1.id_isv_aplicable = impuesto.Id;
                                }
                                else
                                {
                                    row1.tasa_isv = 0;
                                    row1.id_isv_aplicable = 0;
                                    row1.precio = (row1.precio - row1.descuento);
                                }

                                row1.total_linea = (row1.cantidad * row1.precio) + (row1.cantidad * row1.isv1) + (row1.cantidad * row1.isv2) + (row1.cantidad * row1.isv3);
                                AcumuladoTotalFactura += row1.total_linea;
                            }
                        }
                        txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(AcumuladoTotalFactura, 2));
                    }
                }
            }
        }

        private void cmdPlusAQ_Click(object sender, EventArgs e)
        {
            //txtCodigo.Focus();
            //txtCodigo.Text = "AQ";
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter) && (e.KeyChar != '.'))
            {
                CajaDialogo.Error("Solo se permiten numeros");
                e.Handled = true;
                return;
            }
        }

        private void cmdMas_Click(object sender, EventArgs e)
        {
            try
            {
                //int val = Convert.ToInt32(txtCantidad.Text);
                //val = val + 1;
                //txtCantidad.Text = val.ToString();
            }
            catch {}
        }

        private void cmdMenos_Click(object sender, EventArgs e)
        {
            try
            {
                //int val = Convert.ToInt32(txtCantidad.Text);
                //if (val >= 2)
                //    val = val - 1;
                //txtCantidad.Text = val.ToString();
            }
            catch { }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string code = "";
                try
                {
                    //code = Convert.ToInt32(txtCodigo.Text).ToString();
                    code = "AQ" + code;
                }
                catch 
                {
                    //code = txtCodigo.Text;
                }

                Cliente Cliente1 = new Cliente();
                if (Cliente1.RecuperarRegistro(0))
                {
                    txtNombreCliente.Text = Cliente1.Nombre;
                    //txtCodigo.Text = code;
                    //txtCodigoProducto.Focus();
                    ProIdCliente = Cliente1.Id;
                    //ProId_company = Cliente1.Id_compania;
                    //ProApplySubsidio = Cliente1.ApplySubsidio;
                    //toggleTipoVenta.IsOn = false;
              
                }
                else
                {
                    txtNombreCliente.Text = "";
                    //txtCodigo.Text = "";
                    ProIdCliente = 0;
                }
            }
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            //txtCodigo.Focus();
            //txtCodigo.SelectAll();
        }

        private void cmdBuscarProducto_Click(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void cmdAddWithValue_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtCodigo.Text))
            //{
            //    try
            //    {
            //        AddWithValueProducto(Convert.ToInt32(txtCodigo.Text));
            //    }
            //    catch
            //    {
            //    }
            //}
        }

        private void AddWithValueProducto(int pIdProducto)
        {
            int id_producto = pIdProducto;
            bool existe = false;
            foreach (dsVentas.factura_detalleRow row in dsVentas1.factura_detalle.Rows)
            {
                if (id_producto == row.id_producto)
                {
                    existe = true;
                    if (!row.apply_subsidio)
                    {
                        row.cantidad = row.cantidad + 1;

                        //Validar inventario


                        //txtCodigoProducto.Text = "";
                        //txtCodigoProducto.Focus();
                    }
                    break;
                }
            }

            if (existe)
            {
                //Aumentó la cantidad
                CalcularTotal();
                //txtCodigoProducto.Text = "";
                //txtCodigoProducto.Focus();
            }
            else
            {
                //dsOrdenes.ordenes_dRow row1 = dsOrdenes1.ordenes_d.Newordenes_dRow();
                dsVentas.factura_detalleRow row1 = dsVentas1.factura_detalle.Newfactura_detalleRow();

                row1.id_producto = id_producto;
                ProductoTerminado Pro = new ProductoTerminado();
                if (Pro.Recuperar_producto(id_producto))
                {
                    row1.nombre = Pro.Descripcion;
                    row1.cantidad = 1;
                    //row1.apply_subsidio = Pro.ApplySubsidio;
                    //if (Pro.ApplySubsidio)
                    //{
                    //    Subsidio sub1 = new Subsidio();
                    //    row1.precio = (sub1.GetPrecioAsociadoFromSubsidio(ProId_company) + sub1.GetPrecioEmpresaFromSubsidio(ProId_company));
                    //    row1.subsidio = (-1 * sub1.GetPrecioEmpresaFromSubsidio(ProId_company));
                    //    //CalcularTotal();
                    //}
                    //else
                    //{
                    //    row1.precio = Pro.GetPrecioProducto(id_producto, ProId_company);
                    //    row1.subsidio = 0;
                    //}
                    row1.total_fila = row1.cantidad * row1.precio;

                    //dsOrdenes1.ordenes_d.AddWithValueordenes_dRow(row1);
                    //dsVentas1.factura_detalle.AddWithValuefactura_detalleRow(row1);
                    CalcularTotal();
                    //txtCodigoProducto.Text = "";
                    //txtCodigoProducto.Focus();
                }
            }
        }

        private void btnAddWithValue_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Sumar en cantidad
            //var gridView = (GridView)grMain.FocusedView;
            //var row = (dsVentas.factura_detalleRow)gridView.GetFocusedDataRow();
            ////int cant = row.cantidad;
            //if(!row.apply_subsidio)
            //    row.cantidad += 1;

            CalcularTotal();
        }

        private void btnRestar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Restar en cantidad
            //var gridView = (GridView)grMain.FocusedView;
            //var row = (dsVentas.factura_detalleRow)gridView.GetFocusedDataRow();
            //if (!row.apply_subsidio)
            //    if (row.cantidad > 1)
            //        row.cantidad -= 1;

            CalcularTotal();
        }

        public void SetErrorBarra(string msj)
        {
            lblMensaje.Text = msj;
            panelNotificacion.BackColor = Color.Red;
            timerLimpiarMensaje.Enabled = true;
            timerLimpiarMensaje.Start();
        }

        public void SetInformationBarra(string msj)
        {
            lblMensaje.Text = msj;
            lblMensaje.Visible = true;
            panelNotificacion.Visible = true;
            panelNotificacion.BackColor = Color.LightGreen;
            timerLimpiarMensaje.Enabled = true;
            timerLimpiarMensaje.Start();
        }

        private void cmdFacturar_Click(object sender, EventArgs e)
        {
            //txtNombreCliente
            //txtRTN
            DataOperations dp = new DataOperations();
            if (dp.ValidateStringIsNullOrEmpty(txtNombreCliente.Text))
            {
                SetErrorBarra("No se puede Facturar sin definir el nombre de cliente!");
                return;
            }

            if (dp.ValidateNumberDecimal(txtTotal.Text)<=0)
            {
                SetErrorBarra("No se permite generar facturas con valor total cero(0)!");
                return;
            }

            //Validar disponibilidad de Inventario si el punto de venta lo tiene configurado
            if (PuntoDeVentaActual.BloqueoPorFaltaStock)
            {
                foreach (dsVentas.detalle_factura_transactionRow row in dsVentas1.detalle_factura_transaction.Rows)
                {
                    if (row.inventario < row.cantidad)
                    {
                        SetErrorBarra("Esta intentando facturar producto con menor existencia en Inventario!");
                        return;
                    }
                }
            }

            if (dsVentas1.detalle_factura_transaction.Count <= 0)
            {
                CajaDialogo.Error("Es necesario agregar al menos un producto para generar la Factura!");
                return;
            }

            bool ImprimirFactura = false;
            Factura facturaGenerada = null;

            //Efectuar que se haga la facturacion en dos pasos, primero la factura y luego el pago
            //if (PuntoDeVentaActual.EmisionFacturaDosPasos)
            if (rdCredito.Checked || rdPorCobrar.Checked)
            {
                DialogResult r = CajaDialogo.Pregunta("Esta seguro de generar esta factura?");
                if (r != DialogResult.Yes)
                    return;

                Factura factura = new Factura();

                if (string.IsNullOrEmpty(txtRTN.Text))
                    factura.RTN = "N/D";
                else
                    factura.RTN = txtRTN.Text;


                if (string.IsNullOrEmpty(txtNombreCliente.Text))
                    factura.ClienteNombre = "Consumidor Final";
                else
                    factura.ClienteNombre = txtNombreCliente.Text;


                if (string.IsNullOrEmpty(txtDireccion.Text))
                    factura.direccion_cliente = "N/D";
                else
                    factura.direccion_cliente = txtDireccion.Text;



                //if (ClienteFactura != null)
                //    if (ClienteFactura.Id > 0)
                //        factura.IdCliente = ClienteFactura.Id;
                factura.IdCliente = ProIdCliente;

                factura.FechaDocumento = dp.NowSetDateTime();

                if (this.VendedorActual != null)
                    factura.IdVendedor = this.VendedorActual.Id;

                //1   Emitida
                //2   Pagada
                //3   Anulada
                factura.IdEstado = 1;
                factura.CantidadImpresionesFactura = 0;
                factura.IdUser = this.UsuarioLogeado.Id;
                factura.IdPuntoVenta = this.PuntoDeVentaActual.ID;
                factura.Enable = true;
                factura.NumOrdenCompra = "";
                factura.IdTerminoPago = IdTerminoPago;

                int correlativoSiguiente = 0;
                //int id_numeracion = 0;

                factura.descuentoTotalFactura = factura.subtotalFactura =
                factura.ISV1 = factura.ISV2 = 0;

                foreach (dsVentas.detalle_factura_transactionRow row in dsVentas1.detalle_factura_transaction)
                {
                    factura.subtotalFactura += dp.ValidateNumberDecimal((row.cantidad * row.precio));
                    factura.descuentoTotalFactura += dp.ValidateNumberDecimal(row.descuento);
                    factura.ISV1 += dp.ValidateNumberDecimal(row.isv1);
                    factura.ISV2 += dp.ValidateNumberDecimal(row.isv2);
                }

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
                        //Guardamos el Header de la factura 
                        //command.CommandText = "[dbo].[sp_set_insert_factura_header_punto_venta_v4]";
                        //command.CommandText = "[dbo].[sp_set_insert_factura_header_punto_venta_v5]";
                        //command.CommandText = "[dbo].[sp_set_insert_factura_header_punto_venta_v7]";
                        command.CommandText = "[dbo].[sp_set_insert_factura_header_punto_venta_v14]";

                        command.CommandType = CommandType.StoredProcedure;
                        //command.Parameters.AddWithValue("@numero_documento", factura.NumeroDocumento);
                        command.Parameters.AddWithValue("@enable", 1);
                        command.Parameters.AddWithValue("@id_estado", factura.IdEstado);
                        command.Parameters.AddWithValue("@cant_print", factura.CantidadImpresionesFactura);
                        command.Parameters.AddWithValue("@id_user", factura.IdUser);
                        command.Parameters.AddWithValue("@fecha_row", factura.FechaDocumento);
                        command.Parameters.AddWithValue("@fecha_documento", factura.FechaDocumento);

                        if (factura.IdCliente == 0)
                            command.Parameters.AddWithValue("@id_cliente", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@id_cliente", factura.IdCliente);

                        if (string.IsNullOrEmpty(factura.RTN))
                            command.Parameters.AddWithValue("@RTN", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@RTN", factura.RTN);


                        command.Parameters.AddWithValue("@num_orden_compra", factura.NumOrdenCompra);
                        command.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);

                        //if(factura.IdNumeracionFiscal == 0)
                        //    command.Parameters.AddWithValue("@id_numeracion_fiscal", DBNull.Value);
                        //else
                        //    command.Parameters.AddWithValue("@id_numeracion_fiscal", id_numeracion);

                        if (string.IsNullOrEmpty(factura.ClienteNombre))
                            command.Parameters.AddWithValue("@cliente_nombre", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@cliente_nombre", factura.ClienteNombre);


                        command.Parameters.AddWithValue("@id_tipo_pago", DBNull.Value);

                        if (string.IsNullOrEmpty(factura.direccion_cliente))
                            command.Parameters.AddWithValue("@direccion_cliente", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@direccion_cliente", factura.direccion_cliente);



                        command.Parameters.AddWithValue("@subtotal", factura.subtotalFactura);
                        command.Parameters.AddWithValue("@descuento", factura.descuentoTotalFactura);
                        command.Parameters.AddWithValue("@isv1", factura.ISV1);
                        command.Parameters.AddWithValue("@isv2", factura.ISV2);
                        command.Parameters.AddWithValue("@id_formato_impresion", PuntoDeVentaActual.IdFormatoFactura);
                        command.Parameters.AddWithValue("@id_termino_pago", IdTerminoPago);

                        if (IdPedido == 0)
                            command.Parameters.AddWithValue("@id_pedido", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@id_pedido", IdPedido);

                        if (factura.IdVendedor == 0)
                            command.Parameters.AddWithValue("@id_vendedor", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@id_vendedor", factura.IdVendedor);

                        if(string.IsNullOrEmpty(lblOrdenCompaExoValue.Text))
                            command.Parameters.AddWithValue("@oc_exonerada", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@oc_exonerada", lblOrdenCompaExoValue.Text);


                        if (string.IsNullOrEmpty(lblConstanciaExo.Text))
                            command.Parameters.AddWithValue("@constancia_exonerada", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@constancia_exonerada", lblConstanciaExoValue.Text);

                        if (string.IsNullOrEmpty(lblConstanciaExo.Text))
                            command.Parameters.AddWithValue("@registro_sag_exonerada", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@registro_sag_exonerada", lblRegistroExoValue.Text);

                        Int64 IdFacturaH = Convert.ToInt64(command.ExecuteScalar());
                        decimal TotalFactura = 0;
                        factura.Id = IdFacturaH;

                        //Posteamos lineas de factura y Transaccion en Kardex
                        foreach (dsVentas.detalle_factura_transactionRow row in dsVentas1.detalle_factura_transaction)
                        {
                            //command.CommandText = "dbo.sp_set_insert_factura__lineas__punto_venta_dos_pasos";
                            command.CommandText = "dbo.[sp_set_insert_factura__lineas__punto_venta_dos_pasos_v2]";
                            command.Parameters.Clear();
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@id_facturaH", IdFacturaH);
                            command.Parameters.AddWithValue("@id_pt", row.id_pt);
                            command.Parameters.AddWithValue("@item_code", row.itemcode);
                            command.Parameters.AddWithValue("@descripcion", row.itemname);
                            command.Parameters.AddWithValue("@cantidad", row.cantidad);
                            command.Parameters.AddWithValue("@precio", row.precio);
                            command.Parameters.AddWithValue("@descuento", row.descuento);
                            command.Parameters.AddWithValue("@impuesto1", row.isv1);
                            command.Parameters.AddWithValue("@impuesto2", row.isv2);
                            command.Parameters.AddWithValue("@impuesto3", row.isv3);
                            command.Parameters.AddWithValue("@total_linea", row.total_linea);
                            command.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);
                            command.Parameters.AddWithValue("@fecha_hora_row", factura.FechaDocumento);
                            command.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
                            command.Parameters.AddWithValue("@id_bodega", row.id_bodega);

                            if (row.id_isv_aplicable > 0)
                                command.Parameters.AddWithValue("@id_isv_aplicado", row.id_isv_aplicable);
                            else
                                command.Parameters.AddWithValue("@id_isv_aplicado", DBNull.Value);

                            //int tipo_factura_ = tipo
                            
                            command.Parameters.AddWithValue("@tipo_factura", PedidoRecuperado.TipoFactura);
                            TotalFactura += row.total_linea;
                            command.ExecuteNonQuery();
                        }

                        //Vamos a postear transaccion en estado de cuenta de cliente
                        if (factura.IdCliente > 0)
                        {
                            command.CommandText = "dbo.[sp_set_insert_estado_cuenta_cliente_v4]";
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Clear();
                            //command.Parameters.AddWithValue("@num_doc", factura.NumeroDocumento);
                            command.Parameters.AddWithValue("@id_facturaH", IdFacturaH);
                            command.Parameters.AddWithValue("@enable", 1);
                            command.Parameters.AddWithValue("@credito", 0);//Abonos
                            command.Parameters.AddWithValue("@debito", TotalFactura);//cargos
                            command.Parameters.AddWithValue("@concepto", string.Concat("Por Factura #", factura.NumeroDocumento));
                            command.Parameters.AddWithValue("@doc_date", factura.FechaDocumento);
                            command.Parameters.AddWithValue("@date_created", factura.FechaDocumento);
                            command.Parameters.AddWithValue("@id_user_created", this.UsuarioLogeado.Id);
                            command.Parameters.AddWithValue("@id_cliente", factura.IdCliente);
                            command.ExecuteNonQuery();
                        }

                        if (PedidoRecuperado != null)
                        {
                            if (PedidoRecuperado.Recuperado)
                            {
                                //Actualizamos el estado del pedido a facturado!
                                command.CommandText = "dbo.[sp_set_update_prefactura_pedido]";
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Clear();
                                //command.Parameters.AddWithValue("@num_doc", factura.NumeroDocumento);
                                command.Parameters.AddWithValue("@id_pedido", PedidoRecuperado.Id);
                                command.Parameters.AddWithValue("@id_estado", 2);//Facturado
                                command.Parameters.AddWithValue("@id_factura", IdFacturaH);
                                command.ExecuteNonQuery();
                            }
                        }



                        // Attempt to commit the transaction.
                        transaction.Commit();
                        //CajaDialogo.InformationAuto();

                        SetInformationBarra("Factura Generada con Exito!");
                        ImprimirFactura = true;
                        facturaGenerada = factura;

                        //Limpiar Datos
                        dsVentas1.detalle_factura_transaction.Clear();
                        ClienteFactura = new ClienteFacturacion();
                        cmdConsumidorFinal_Click(sender, e);
                        txtVendedor.Text = txtTotal.Text = "";
                    
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
                }
                //}
            }
            else
            {
                //PRIMERO EL PAGO LUEGO LA FACTURA

                decimal ValorTotalFactura = dp.ValidateNumberDecimal(txtTotal.Text);
                Int64 IdReciboH_Inserted = 0;

                frmPagoFactura frm = new frmPagoFactura(this.UsuarioLogeado, ValorTotalFactura, this.PuntoDeVentaActual,
                                                        PedidoRecuperado.SubTotal, PedidoRecuperado.ISV);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Factura factura = new Factura();
                    factura.cambio = dp.ValidateNumberDecimal(frm.txtCambio.Text);
                    factura.monto_entregado = dp.ValidateNumberDecimal(frm.txtEntregado.Text);

                    //if (!string.IsNullOrEmpty(txtRTN.Text))
                    //    factura.RTN = txtRTN.Text;

                    //if (!string.IsNullOrEmpty(txtNombreCliente.Text))
                    //    factura.ClienteNombre = txtNombreCliente.Text;

                    //if (!string.IsNullOrEmpty(txtDireccion.Text))
                    //    factura.direccion_cliente = txtDireccion.Text;
                    if (string.IsNullOrEmpty(txtRTN.Text))
                        factura.RTN = "N/D";
                    else
                        factura.RTN = txtRTN.Text;

                    if (string.IsNullOrEmpty(txtNombreCliente.Text))
                        factura.ClienteNombre = "Consumidor Final";
                    else
                        factura.ClienteNombre = txtNombreCliente.Text;

                    if (string.IsNullOrEmpty(txtDireccion.Text))
                        factura.direccion_cliente = "N/D";
                    else
                        factura.direccion_cliente = txtDireccion.Text;


                    if (ClienteFactura != null)
                        if (ClienteFactura.Id > 0)
                            factura.IdCliente = ClienteFactura.Id;

                    factura.FechaDocumento = dp.NowSetDateTime();

                    if (this.VendedorActual != null)
                        factura.IdVendedor = this.VendedorActual.Id;

                    //1   Emitida
                    //2   Pagada
                    //3   Anulada
                    factura.IdEstado = 2;
                    factura.CantidadImpresionesFactura = 0;
                    factura.IdUser = this.UsuarioLogeado.Id;
                    factura.IdPuntoVenta = this.PuntoDeVentaActual.ID;
                    factura.Enable = true;
                    factura.NumOrdenCompra = "";
                    factura.idFormatoFactura = this.PuntoDeVentaActual.IdFormatoFactura;
                    factura.IdTerminoPago = IdTerminoPago;

                    int correlativoSiguiente = 0;

                    factura.descuentoTotalFactura = factura.subtotalFactura =
                    factura.ISV1 = factura.ISV2 = 0;

                    foreach (dsVentas.detalle_factura_transactionRow row in dsVentas1.detalle_factura_transaction)
                    {
                        factura.subtotalFactura += dp.ValidateNumberDecimal((row.cantidad * row.precio));
                        factura.descuentoTotalFactura += dp.ValidateNumberDecimal(row.descuento);
                        factura.ISV1 += dp.ValidateNumberDecimal(row.isv1);
                        factura.ISV2 += dp.ValidateNumberDecimal(row.isv2);
                    }

                    factura.descuentoTotalFactura = factura.subtotalFactura =
                    factura.ISV1 = factura.ISV2 = 0;

                    foreach (dsVentas.detalle_factura_transactionRow row in dsVentas1.detalle_factura_transaction)
                    {
                        factura.subtotalFactura += dp.ValidateNumberDecimal((row.cantidad * row.precio));
                        factura.descuentoTotalFactura += dp.ValidateNumberDecimal(row.descuento);
                        factura.ISV1 += dp.ValidateNumberDecimal(row.isv1);
                        factura.ISV2 += dp.ValidateNumberDecimal(row.isv2);
                    }


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
                            //Guardamos el Header de la factura 
                            command.CommandText = "[dbo].[sp_set_insert_factura_header_punto_venta_v15]";
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@numero_documento", factura.NumeroDocumento);
                            command.Parameters.AddWithValue("@enable", 1);
                            command.Parameters.AddWithValue("@id_estado", factura.IdEstado);
                            command.Parameters.AddWithValue("@cant_print", factura.CantidadImpresionesFactura);
                            command.Parameters.AddWithValue("@id_user", factura.IdUser);
                            command.Parameters.AddWithValue("@fecha_row", factura.FechaDocumento);
                            command.Parameters.AddWithValue("@fecha_documento", factura.FechaDocumento);

                            if (factura.IdCliente == 0)
                                command.Parameters.AddWithValue("@id_cliente", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@id_cliente", factura.IdCliente);

                            command.Parameters.AddWithValue("@RTN", factura.RTN);
                            command.Parameters.AddWithValue("@num_orden_compra", factura.NumOrdenCompra);
                            command.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);

                            //if (factura.IdNumeracionFiscal == 0)
                            //    command.Parameters.AddWithValue("@id_numeracion_fiscal", DBNull.Value);
                            //else
                            //    command.Parameters.AddWithValue("@id_numeracion_fiscal", id_numeracion);

                            command.Parameters.AddWithValue("@cliente_nombre", factura.ClienteNombre);
                            int id_tipo_pago = (int)frm.TipoPagoSeleccionadoActual;
                            command.Parameters.AddWithValue("@id_tipo_pago", id_tipo_pago);
                            command.Parameters.AddWithValue("@emiteFacturaFiscal", PuntoDeVentaActual.EmiteFacturaFiscal);

                            command.Parameters.AddWithValue("@direccion_cliente", factura.direccion_cliente);
                            command.Parameters.AddWithValue("@subtotal", factura.subtotalFactura);
                            command.Parameters.AddWithValue("@descuento", factura.descuentoTotalFactura);
                            command.Parameters.AddWithValue("@isv1", factura.ISV1);
                            command.Parameters.AddWithValue("@isv2", factura.ISV2);
                            command.Parameters.AddWithValue("@id_formato_impresion", PuntoDeVentaActual.IdFormatoFactura);

                            if (IdPedido == 0)
                                command.Parameters.AddWithValue("@id_pedido", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@id_pedido", IdPedido);

                            if (factura.IdVendedor == 0)
                                command.Parameters.AddWithValue("@id_vendedor", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@id_vendedor", factura.IdVendedor);

                            if (factura.IdTerminoPago == 0)
                                command.Parameters.AddWithValue("@id_termino_pago", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@id_termino_pago", factura.IdTerminoPago);

                            command.Parameters.AddWithValue("@monto_recibido", factura.monto_entregado);
                            command.Parameters.AddWithValue("@cambio", factura.cambio);


                            if (string.IsNullOrEmpty(lblOrdenCompaExoValue.Text))
                                command.Parameters.AddWithValue("@oc_exonerada", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@oc_exonerada", lblOrdenCompaExoValue.Text);

                            if (string.IsNullOrEmpty(lblConstanciaExo.Text))
                                command.Parameters.AddWithValue("@constancia_exonerada", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@constancia_exonerada", lblConstanciaExoValue.Text);

                            if (string.IsNullOrEmpty(lblConstanciaExo.Text))
                                command.Parameters.AddWithValue("@registro_sag_exonerada", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@registro_sag_exonerada", lblRegistroExoValue.Text);

                            Int64 IdFacturaH = Convert.ToInt64(command.ExecuteScalar());
                            decimal TotalFactura = 0;
                            factura.Id = IdFacturaH;


                            //Posteamos lineas de factura y Transaccion en Kardex
                            foreach (dsVentas.detalle_factura_transactionRow row in dsVentas1.detalle_factura_transaction)
                            {
                                command.CommandText = "dbo.sp_set_insert_factura__lineas__punto_venta_dos_pasos_v2";
                                command.Parameters.Clear();
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@id_facturaH", IdFacturaH);
                                command.Parameters.AddWithValue("@id_pt", row.id_pt);
                                command.Parameters.AddWithValue("@item_code", row.itemcode);
                                command.Parameters.AddWithValue("@descripcion", row.itemname);
                                command.Parameters.AddWithValue("@cantidad", row.cantidad);
                                command.Parameters.AddWithValue("@precio", row.precio);
                                command.Parameters.AddWithValue("@descuento", row.descuento);
                                command.Parameters.AddWithValue("@impuesto1", row.isv1);
                                command.Parameters.AddWithValue("@impuesto2", row.isv2);
                                command.Parameters.AddWithValue("@impuesto3", row.isv3);
                                command.Parameters.AddWithValue("@total_linea", row.total_linea);
                                command.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);
                                command.Parameters.AddWithValue("@fecha_hora_row", factura.FechaDocumento);
                                command.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
                                command.Parameters.AddWithValue("@id_bodega", row.id_bodega);

                                if (row.id_isv_aplicable > 0)
                                    command.Parameters.AddWithValue("@id_isv_aplicado", row.id_isv_aplicable);
                                else
                                    command.Parameters.AddWithValue("@id_isv_aplicado", DBNull.Value);

                                command.Parameters.AddWithValue("@tipo_factura", PedidoRecuperado.TipoFactura);
                                TotalFactura += row.total_linea;
                                command.ExecuteNonQuery();
                            }

                            //Vamos a postear transaccion en estado de cuenta de cliente
                            command.CommandText = "dbo.[sp_set_insert_estado_cuenta_cliente_v5]";
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Clear();
                            //command.Parameters.AddWithValue("@num_doc", factura.NumeroDocumento);
                            command.Parameters.AddWithValue("@id_facturaH", IdFacturaH);
                            command.Parameters.AddWithValue("@enable", 1);
                            command.Parameters.AddWithValue("@credito", 0);//Abonos
                            command.Parameters.AddWithValue("@debito", TotalFactura);//cargos
                            command.Parameters.AddWithValue("@concepto", string.Concat("Por Factura #", factura.NumeroDocumento));
                            command.Parameters.AddWithValue("@doc_date", factura.FechaDocumento);
                            command.Parameters.AddWithValue("@date_created", factura.FechaDocumento);
                            command.Parameters.AddWithValue("@id_user_created", this.UsuarioLogeado.Id);

                            //Cliente
                            if (factura.IdCliente == 0)
                                command.Parameters.AddWithValue("@id_cliente", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@id_cliente", factura.IdCliente);

                            command.Parameters.AddWithValue("@referencia", DBNull.Value);
                            command.ExecuteNonQuery();

                            //Postear el recibo para homologar toda la recepcion de valores
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

                            if (string.IsNullOrEmpty(frm.ReferenciaReciboPago))
                                command.Parameters.AddWithValue("@referencia", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@referencia", frm.ReferenciaReciboPago);

                            IdReciboH_Inserted = Convert.ToInt64(command.ExecuteScalar());


                            //postearemos varias lineas por si el pago se combina entre si
                            foreach (RegistroPago registroPago in frm.ListaDetallePago)
                            {
                                command.CommandText = "dbo.[sp_set_insert_recibo_pago_detalle_v5]";
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@id_facturaH", IdFacturaH);
                                command.Parameters.AddWithValue("@valor", registroPago.Valor);
                                command.Parameters.AddWithValue("@date_created", dp.NowSetDateTime());
                                command.Parameters.AddWithValue("@id_recibo_h", IdReciboH_Inserted);
                                command.Parameters.AddWithValue("@id_usuario", this.UsuarioLogeado.Id);

                                if (factura.IdCliente == 0)
                                    command.Parameters.AddWithValue("@id_cliente", DBNull.Value);
                                else
                                    command.Parameters.AddWithValue("@id_cliente", factura.IdCliente);

                                if (registroPago.IdTipo == 3)//Deposito bancario
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

                                if (registroPago.id_banco == 0)
                                    command.Parameters.AddWithValue("@id_banco", DBNull.Value);
                                else
                                    command.Parameters.AddWithValue("@id_banco", registroPago.id_banco);

                                if (string.IsNullOrEmpty(registroPago.NumeroCheque))
                                    command.Parameters.AddWithValue("@numero_cheque", DBNull.Value);
                                else
                                    command.Parameters.AddWithValue("@numero_cheque", registroPago.id_banco);


                                if (string.IsNullOrEmpty(registroPago.EmisorCheque))
                                    command.Parameters.AddWithValue("@emisor_cheque", DBNull.Value);
                                else
                                    command.Parameters.AddWithValue("@emisor_cheque", registroPago.id_banco);

                                if (registroPago.id_cuenta == 0)
                                    command.Parameters.AddWithValue("@id_cuenta", DBNull.Value);
                                else
                                    command.Parameters.AddWithValue("@id_cuenta", registroPago.id_cuenta);

                                if (string.IsNullOrEmpty(registroPago.CuentaBanco))
                                    command.Parameters.AddWithValue("@numero_cuenta", DBNull.Value);
                                else
                                    command.Parameters.AddWithValue("@numero_cuenta", registroPago.CuentaBanco);

                                command.ExecuteNonQuery();
                            }

                            if (PedidoRecuperado != null)
                            {
                                if (PedidoRecuperado.Recuperado)
                                {
                                    //Actualizamos el estado del pedido a facturado!
                                    command.CommandText = "dbo.[sp_set_update_prefactura_pedido]";
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.Clear();
                                    //command.Parameters.AddWithValue("@num_doc", factura.NumeroDocumento);
                                    command.Parameters.AddWithValue("@id_pedido", PedidoRecuperado.Id);
                                    command.Parameters.AddWithValue("@id_estado", 2);//Facturado
                                    command.Parameters.AddWithValue("@id_factura", IdFacturaH);
                                    command.ExecuteNonQuery();
                                }
                            }



                            // Attempt to commit the transaction.
                            transaction.Commit();
                            //CajaDialogo.InformationAuto();
                            SetInformationBarra("Factura Generada con Exito!");
                            ImprimirFactura = true;
                            facturaGenerada = factura;


                            //Limpiar Datos
                            dsVentas1.detalle_factura_transaction.Clear();
                            //dsVentas1.detalle_factura_transaccion_inv.Clear();
                            ClienteFactura = new ClienteFacturacion();
                            cmdConsumidorFinal_Click(sender, e);
                            txtVendedor.Text = txtTotal.Text = "";
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
                    }
                }
            }



            if (ImprimirFactura)
            {
                //rptFactura
                if (facturaGenerada != null)
                {
                    if (facturaGenerada.RecuperarRegistro(facturaGenerada.Id))
                    {
                        if (!string.IsNullOrEmpty(facturaGenerada.NumeroDocumento))
                        {
                            if (facturaGenerada.Id > 0)
                            {
                                if (facturaGenerada.RecuperarRegistro(facturaGenerada.Id))
                                {
                                    switch (PuntoDeVentaActual.IdFormatoFactura)
                                    {
                                        case 1://3.5 pulg. cinta
                                            rptFactura report = new rptFactura(facturaGenerada, rptFactura.TipoCopia.Blanco) { ShowPrintMarginsWarning = false };
                                            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                                            ReportPrintTool printReport = new ReportPrintTool(report);
                                            //printReport.ShowPreviewDialog();
                                            printReport.PrinterSettings.Copies = Convert.ToInt16(PuntoDeVentaActual.Cantidad_copiasFactura);
                                            printReport.Print();
                                            facturaGenerada.UpdatePrintCount(facturaGenerada.Id);
                                            this.DialogResult = DialogResult.OK;
                                            this.Close();
                                            break;
                                        case 2://8x11.5 pulg. Carta
                                        default:
                                            rptFacturaLetterSize reportLetter = new rptFacturaLetterSize(facturaGenerada, rptFacturaLetterSize.TipoCopia.Blanco) { ShowPrintMarginsWarning = false };
                                            reportLetter.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                                            ReportPrintTool printReportLetter = new ReportPrintTool(reportLetter);
                                            //printReport.ShowPreviewDialog();
                                            printReportLetter.PrinterSettings.Copies = Convert.ToInt16(PuntoDeVentaActual.Cantidad_copiasFactura);
                                            printReportLetter.Print();
                                            facturaGenerada.UpdatePrintCount(facturaGenerada.Id);
                                            this.DialogResult = DialogResult.OK;
                                            this.Close();
                                            break;
                                    }
                                }
                            }
                        }
                    }
                }
            }



            #region Codigo Original de Factura Base
            //SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            //conn.Open();
            //SqlTransaction tran = conn.BeginTransaction();
            //try
            //{
            //    //Guardar encabezado de factura
            //    string sqlEnc = @"INSERT INTO  public.ventas
            //                                    (
            //                                      id_Cliente,
            //                                      fecha,
            //                                      id_usuario,
            //                                      tipo,
            //                                      contabilizado,
            //                                      totaltaxes,
            //                                      subtotal,
            //                                      print_count
            //                                    )
            //                                    VALUES (
            //                                      :id_Cliente,
            //                                      CURRENT_TIMESTAMP,
            //                                      :id_usuario,
            //                                      :tipo,
            //                                      false,
            //                                      :totaltaxes,
            //                                      :subtotal,
            //                                      :print_count
            //                                    ) returning id;";
            //    SqlCommand cmdE = new SqlCommand(sqlEnc, conn);
            //    cmdE.Parameters.AddWithValue("id_Cliente", 0);
            //    cmdE.Parameters.AddWithValue("id_usuario", 1);

            //    int tipoFactura = 2;//credito
            //    //if (toggleTipoVenta.IsOn)
            //    //    tipoFactura = 1;//contado

            //    cmdE.Parameters.AddWithValue("tipo", tipoFactura);
            //    cmdE.Parameters.AddWithValue("totaltaxes", 0);
            //    cmdE.Parameters.AddWithValue("subtotal", Convert.ToDecimal(txtTotal.Text));
            //    int print_recibo = 0;
            //    //if (toggleImprimeRecibo.IsOn)
            //    //    print_recibo = 1;
            //    cmdE.Parameters.AddWithValue("print_count", print_recibo);

            //    if (print_recibo >= 1)
            //        imprimirTicket = true;

            //    idFact = Convert.ToInt32(cmdE.ExecuteScalar());

            //    //Guardar detalle de Factura
            //    foreach(dsVentas.factura_detalleRow rowD in dsVentas1.factura_detalle)
            //    {
            //        string sqlD = @"INSERT INTO public.ventas_d
            //                                                (
            //                                                  id_venta,
            //                                                  cantidad,
            //                                                  precio_unit,
            //                                                  taxtotal,
            //                                                  subsidio,
            //                                                  id_producto,
            //                                                  linetotal,
            //                                                  id_receta
            //                                                )
            //                                                VALUES (
            //                                                  :id_venta,
            //                                                  :cantidad,
            //                                                  :precio_unit,
            //                                                  0,
            //                                                  :subsidio,
            //                                                  :id_producto,
            //                                                  :linetotal,
            //                                                  :id_receta
            //                                                );";
            //        SqlCommand cmdD = new SqlCommand(sqlD, conn);
            //        cmdD.Parameters.AddWithValue("id_venta",idFact);
            //        cmdD.Parameters.AddWithValue("cantidad",  rowD.cantidad);
            //        cmdD.Parameters.AddWithValue("precio_unit",  rowD.precio);
            //        cmdD.Parameters.AddWithValue("subsidio",  rowD.subsidio);
            //        cmdD.Parameters.AddWithValue("id_producto", rowD.id_producto);
            //        cmdD.Parameters.AddWithValue("linetotal",  rowD.total_fila);



            //        cmdD.ExecuteNonQuery();


            //        //Rebaja en el kardex de lo facturado
            //        string sqlK = @"INSERT INTO public.kardex
            //                                                (
            //                                                  id_producto,
            //                                                  entrada,
            //                                                  salida,
            //                                                  fecha_hora,
            //                                                  id_usuario,
            //                                                  id_venta,
            //                                                  id_lotetrans,
            //                                                  unit_price,
            //                                                  cantidad
            //                                                )
            //                                                VALUES (
            //                                                  :id_producto,
            //                                                  false,
            //                                                  true,
            //                                                  CURRENT_TIMESTAMP,
            //                                                  :id_usuario,
            //                                                  :id_venta,
            //                                                  :id_lotetrans,
            //                                                  :unit_price,
            //                                                  :cantidad
            //                                                );";
            //        SqlCommand cmdK = new SqlCommand(sqlK, conn);
            //        cmdK.Parameters.AddWithValue("id_producto",  rowD.id_producto);
            //        cmdK.Parameters.AddWithValue("id_usuario",  UsuarioLogeado.Id);
            //        cmdK.Parameters.AddWithValue("id_lotetrans",  DBNull.Value);
            //        cmdK.Parameters.AddWithValue("unit_price",  rowD.precio);
            //        cmdK.Parameters.AddWithValue("cantidad",  rowD.cantidad);
            //        cmdK.Parameters.AddWithValue("id_venta",  idFact);

            //        cmdK.ExecuteNonQuery();
            //    }


            //    tran.Commit();

            //    cmdNew_Click(new object(),new EventArgs());
            //    lblMensaje.Text = "Transacción Exitosa!";
            //    panelNotificacion.BackColor = Color.MediumSeaGreen;
            //    conn.Close();
            //    timerLimpiarMensaje.Enabled = true;
            //    timerLimpiarMensaje.Start();
            //}
            //catch (Exception ec)
            //{
            //    tran.Rollback();
            //    conn.Close();
            //    lblMensaje.Text = ec.Message;
            //    panelNotificacion.BackColor = Color.Red;
            //    timerLimpiarMensaje.Enabled = true;
            //    timerLimpiarMensaje.Start();
            //    CajaDialogo.Error(ec.Message);
            //}

            ////Impresion del ticket
            //if (imprimirTicket)
            //{
            //    Factura fact1 = new Factura();
            //    //dsReportesX factR = new dsReportesX();

            //    if (fact1.RecuperarRegistro(idFact))
            //    {
            //        //Recuperar el detalle de factura
            //        try
            //        {
            //            if(conn.State == ConnectionState.Closed)
            //            {
            //                conn.ConnectionString = dp.ConnectionStringJAGUAR_DB;
            //                conn.Open();
            //            }


            //            string sql1 = @"SELECT 
            //                                 cantidad, 
            //                                 precio_unit as precio, 
            //                                 case when vv.subsidio>0 then vv.subsidio else vv.taxtotal end subsidio, 
            //                                 (SELECT case when LENGTH(nombre)>30 then substring(pp.nombre from 2 for 3) else pp.nombre end as name_
            //                                 FROM public.productos pp
            //                                 where pp.id = vv.id_producto) as descripcion, 
            //                                 (cantidad * precio_unit) as total
            //                            FROM public.ventas_d vv
            //                            where id_venta = :id_fact;";

            //            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            //            cmd1.Parameters.AddWithValue("id_fact",  idFact);
            //            SqlDataAdapter adat = new SqlDataAdapter(cmd1);
            //            //factR.detalle_venta.Clear();
            //            //adat.Fill(factR.detalle_venta);

            //            //Cliente Cliente1 = new Cliente();
            //            //if (Cliente1.RecuperarRegistro(fact1.id_Cliente))
            //            //{
            //            //    POS_Ticket rpt = new POS_Ticket(DateTime.Now,
            //            //                                    Cliente1.codigo,
            //            //                                    Cliente1.nombre,
            //            //                                    fact1.GetValorSubtotal(idFact),
            //            //                                    fact1.GetValorSubsidio(idFact),
            //            //                                    fact1.subtotal)
            //            //    { DataSource = factR, DataMember = "detalle_venta", ShowPrintMarginsWarning = false };

            //            //    rpt.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            //            //    ReportPrintTool printReport = new ReportPrintTool(rpt);

            //            //    DBOps db = new DBOps();
            //            //    printReport.PrinterSettings.PrinterName = db.GetPrinterNameTicketsVenta();
            //            //    printReport.Print();
            //            //    //printReport.ShowPreview();
            //            //}
            //            conn.Close();
            //        }
            //        catch (Exception ec)
            //        {
            //            CajaDialogo.Error(ec.Message);
            //        }
            //    }
            //}
            #endregion

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void toggleImprimeRecibo_Toggled(object sender, EventArgs e)
        {
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);

                if (Convert.ToBoolean(row["apply_subsidio"]))
                {
                    row["total_fila"] = (Convert.ToDecimal(row["cantidad"]) * Convert.ToDecimal(row["precio"]) - Math.Abs(Convert.ToDecimal(row["subsidio"]))  );
                }
                else
                {
                    row["total_fila"] = ((Convert.ToDecimal(row["cantidad"]) * Convert.ToDecimal(row["precio"])) - Convert.ToDecimal(row["descuento"]) + Convert.ToDecimal(row["isv1"]));
                }
                
                //decimal Totfila = 
                total += Convert.ToDecimal(row["total_fila"]); ;
            }
            txtTotal.Text = string.Format("{0:#,##0.00}", Math.Round(total,2));
        }

        private void txtCodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //int ptipoVenta = Convert.ToInt32(ProTipoVentaActual);
                //frmBuscarProducto frm1 = new frmBuscarProducto(Connection, (frmBuscarProducto.TipoVenta)ptipoVenta);
                //if (frm1.ShowDialog() == DialogResult.OK)
                //{
                    //ProductoTerminado pro1 = new ProductoTerminado();
                    //if (pro1.Recuperar_productoByBarCode(txtCodigoProducto.Text))
                    //{
                    //    //Recuperado con exito
                    //    //txtCodigoProducto.Text = pro1.BarCode;
                    //    //txtNombreProducto.Text = pro1.Nombre;
                    //    //AddWithValueProducto(pro1.Id_p);
                    //}
                    //else
                    //{
                    //    //producto no existente o error
                    //    CajaDialogo.Error("No se pudo recuperar el registro del producto seleccionado!");
                    //}
                //}    
                CalcularTotal();
            }
        }

        private void btnEliminarFila_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //var gridView1 = (GridView)grMain.FocusedView;
            //var row = (dsVentas.factura_detalleRow)gridView1.GetFocusedDataRow();

            //try
            //{
            //    gridView1.DeleteRow(gridView1.FocusedRowHandle);
            //    CalcularTotal();
            //}
            //catch (Exception ec)
            //{
            //    CajaDialogo.Error(ec.Message);
            //}
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            panelNotificacion.BackColor = Color.White;
            txtRTN.Text = txtNombreCliente.Text = txtDireccion.Text = lblMensaje.Text = "";
            txtTotal.Text = "0.00";
            dsVentas1.detalle_factura_transaction.Clear();
            ClienteFactura = new ClienteFacturacion();
            CalcularTotalFactura();
        }

        private void timerLimpiarMensaje_Tick(object sender, EventArgs e)
        {
            timerLimpiarMensaje.Stop();
            timerLimpiarMensaje.Enabled = false;
            panelNotificacion.BackColor = Color.White;
            lblMensaje.Text = "";
            
            //cmdNew_Click(sender, e);
        }

        private void frmFactura_Activated(object sender, EventArgs e)
        {
            //txtScanProducto.Focus();
        }

        private void toggleTipoVenta_Toggled(object sender, EventArgs e){}

        private void frmFactura_FormClosing(object sender, FormClosingEventArgs e){ }

        private void gridView2_RowStyle(object sender, RowStyleEventArgs e)
        {
            //if (e.RowHandle >= 0)
            //{
            //    var gridView = (GridView)gridControlTop_ProductosBuffet.FocusedView;
            //    var row = (dsVentas.Buffet_TopProductosRow)gridView.GetDataRow(e.RowHandle);
            //    if (row != null)
            //    {
            //        if (row.seleccionado)
            //            e.Appearance.BackColor = Color.FromArgb(204, 255, 153);
            //        else
            //            e.Appearance.BackColor = Color.FromArgb(255, 255, 255);//White

            //    }
            //}
        }

        

        private void AddTilePanel(string descripcion, int p_button)
        {
            //UltraTile tile2 = new Infragistics.Win.Misc.UltraTile();

            //tile2.Settings.Appearance.BackColor = Color.Olive;
            //SimpleButton button2 = new SimpleButton();
            Font fuent1 = new Font("Microsoft Sans Serif", 14);

            //Estos botones son de cajon para ambas opciones
            SimpleButton simpleButton1 = new SimpleButton();
            SimpleButton simpleButton5 = new SimpleButton();
            SimpleButton simpleButton6 = new SimpleButton();

            if (!PuntoDeVentaActual.EmisionFacturaDosPasos) 
            {
                //Punto de venta de facturacion rapida y buffett
                //Estos botones solo son para 
                SimpleButton simpleButton2 = new SimpleButton();
                SimpleButton simpleButton3 = new SimpleButton();
                SimpleButton simpleButton4 = new SimpleButton();

                switch (p_button)
                {
                    case 1:
                        simpleButton1.Text = descripcion;
                        simpleButton1.Font = fuent1;
                        //tile2.Control = simpleButton1;
                        break;
                    case 2:
                        simpleButton2.Text = descripcion;
                        simpleButton2.Font = fuent1;
                        //tile2.Control = simpleButton2;
                        break;
                    case 3:
                        simpleButton3.Font = fuent1;
                        simpleButton3.Text = descripcion;
                        //tile2.Control = simpleButton3;
                        break;
                    case 4:
                        simpleButton4.Font = fuent1;
                        simpleButton4.Text = descripcion;
                        //tile2.Control = simpleButton4;
                        break;
                    case 5:
                        simpleButton5.Font = fuent1;
                        simpleButton5.Text = descripcion;
                        //tile2.Control = simpleButton5;
                        break;
                    case 6:
                        simpleButton6.Font = fuent1;
                        simpleButton6.Text = descripcion;
                        //tile2.Control = simpleButton6;
                        break;
                }

                simpleButton1.Click += new EventHandler(simpleButton1_Click_1);
                simpleButton2.Click += new EventHandler(simpleButton2_Click);
                simpleButton3.Click += new EventHandler(simpleButton3_Click);
                simpleButton4.Click += new EventHandler(simpleButton4_Click);
                simpleButton5.Click += new EventHandler(simpleButton5_Click);
                simpleButton6.Click += new EventHandler(simpleButton6_Click);
            }
            else
            {
                //Punto de Venta Normal sin comidas rapidas
                switch (p_button)
                {
                    case 1:
                        simpleButton1.Text = descripcion;
                        simpleButton1.Font = fuent1;
                        //tile2.Control = simpleButton1;
                        break;
                    case 5:
                        simpleButton5.Font = fuent1;
                        simpleButton5.Text = descripcion;
                        //tile2.Control = simpleButton5;
                        break;
                    case 6:
                        simpleButton6.Font = fuent1;
                        simpleButton6.Text = descripcion;
                        //tile2.Control = simpleButton6;
                        break;
                }

                simpleButton1.Click += new EventHandler(simpleButton1_Click_1);
                simpleButton5.Click += new EventHandler(simpleButton5_Click);
                simpleButton6.Click += new EventHandler(simpleButton6_Click);

                //Ocultamos Radio Buttons box
                //radioGroupVentaComidaBuffet.Visible = false;
            }



            #region Codigo Original de los tiles basicos
            //switch (p_button)
            //{
            //    case 1:
            //        simpleButton1.Text = descripcion;
            //        simpleButton1.Font = fuent1;
            //        tile2.Control = simpleButton1;
            //        break;
            //    case 2:
            //        simpleButton2.Text = descripcion;
            //        simpleButton2.Font = fuent1;
            //        tile2.Control = simpleButton2;
            //        break;
            //    case 3:
            //        simpleButton3.Font = fuent1;
            //        simpleButton3.Text = descripcion;
            //        tile2.Control = simpleButton3;
            //        break;
            //    case 4:
            //        simpleButton4.Font = fuent1;
            //        simpleButton4.Text = descripcion;
            //        tile2.Control = simpleButton4;
            //        break;
            //    case 5:
            //        simpleButton5.Font = fuent1;
            //        simpleButton5.Text = descripcion;
            //        tile2.Control = simpleButton5;
            //        break;
            //    case 6:
            //        simpleButton6.Font = fuent1;
            //        simpleButton6.Text = descripcion;
            //        tile2.Control = simpleButton6;
            //        break;
            //}

            //simpleButton1.Click += new EventHandler(simpleButton1_Click_1);
            //simpleButton2.Click += new EventHandler(simpleButton2_Click);
            //simpleButton3.Click += new EventHandler(simpleButton3_Click);
            //simpleButton4.Click += new EventHandler(simpleButton4_Click);
            //simpleButton5.Click += new EventHandler(simpleButton5_Click);
            //simpleButton6.Click += new EventHandler(simpleButton6_Click);
            #endregion


            //button2.Dock = DockStyle.Fill;
            //tile2.State = TileState.Normal;
            //tile2.Settings.ShowStateChangeButton = Infragistics.Win.DefaultableBoolean.False;
            
            ////tile2.UseAppStyling = true;
            //ultraTilePanel1.Tiles.Add(tile2);
            ////ultraTilePanel1.Margin =pad1;

            //ultraTilePanel1.TileSettings.MaximumSize = new Size(362, 100);
        }

        private void radioGroupVentaComidaBuffet_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadOpcionesRapidas(1);
            //CargarOpcionesMasVendidas(2);
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //var gridView = (GridView)gridControlTop_ProductosBuffet.FocusedView;
            //var row = (dsVentas.Buffet_TopProductosRow)gridView.GetFocusedDataRow();

            //CajaDialogo.Information(row.descripcion);
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            //1=Lo mas vendido
            //2=Comida(s)
            //3=Bebidas Frias
            //4=Bebidas Calientes
            //5=PAN
            //6=Reposteria

            CargarOpcionesMasVendidasLeftPriority(1);
            //txtScanProducto.Focus();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //Comidas
            CargarOpcionesMasVendidasLeftPriority(2);//1=Lo mas Vendido, 2=Comida(s), 3=Bebidas Frias, 4=Bebidas Calientes, 5=PAN, 6=Reposteria
            //txtScanProducto.Focus();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //Bebidas Frias
            CargarOpcionesMasVendidasLeftPriority(3);//1=Lo mas Vendido, 2=Comida(s), 3=Bebidas Frias, 4=Bebidas Calientes, 5=PAN, 6=Reposteria
            //txtScanProducto.Focus();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            //Bebidas Calientes
            CargarOpcionesMasVendidasLeftPriority(4);//1=Lo mas Vendido, 2=Comida(s), 3=Bebidas Frias, 4=Bebidas Calientes, 5=PAN, 6=Reposteria
            //txtScanProducto.Focus();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            //PAN
            CargarOpcionesMasVendidasLeftPriority(5);//1=Lo mas Vendido, 2=Comida(s), 3=Bebidas Frias, 4=Bebidas Calientes, 5=PAN, 6=Reposteria
            //txtScanProducto.Focus();
        }
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            //Reposteria
            CargarOpcionesMasVendidasLeftPriority(6);//1=Lo mas Vendido, 2=Comida(s), 3=Bebidas Frias, 4=Bebidas Calientes, 5=PAN, 6=Reposteria
            //txtScanProducto.Focus();
        }

       

        private void CargarOpcionesMasVendidasLeftPriority(int pidClase)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[sp_get_productos_mas_vendidos_para_buffet_class_priority]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@tipo_buffet", radioGroupVentaComidaBuffet.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@id_clase", pidClase);
                cmd.Parameters.AddWithValue("@ver_lo_mas_vendido", (Int32)BusquedaSet);
                cmd.Parameters.AddWithValue("@id_facturacion_dos_pasos", this.PuntoDeVentaActual.EmisionFacturaDosPasos);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                dsVentas1.mas_vendidos.Clear();
                sqlDataAdapter.Fill(dsVentas1.mas_vendidos);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdLoMasVendido_Click(object sender, EventArgs e)
        {
            BusquedaSet = Busqueda.LoMasVendido;
            //SetBusqueda();
            //CargarOpcionesMasVendidas(2);
            //txtScanProducto.Focus();
        }


        private void cmdTodosLosProductos_Click(object sender, EventArgs e)
        {
            BusquedaSet = Busqueda.Todos;
            //SetBusqueda();
            //txtScanProducto.Focus();
        }

        private void cmdAddToCart_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //agregar al carrito para facturar 
            //var gridView = (GridView)gridControl2.FocusedView;
            //var row = (dsVentas.mas_vendidosRow)gridView.GetFocusedDataRow();

            //decimal valor_total = 0;

            //bool AgregarNuevo = true;
            //foreach (dsVentas.detalle_factura_transactionRow rowF in dsVentas1.detalle_factura_transaction) 
            //{
            //    if(rowF.id_pt == row.id_pt)
            //    {
            //        //Sumar cantidad nada mas
            //        rowF.cantidad = rowF.cantidad + 1;
            //        rowF.isv1 = rowF.isv2 = rowF.isv3 = 0;
            //        rowF.isv1 = ((rowF.cantidad * rowF.precio) - rowF.descuento) * rowF.tasa_isv;
            //        rowF.total_linea = (rowF.cantidad * rowF.precio) - rowF.descuento + rowF.isv1 + rowF.isv2 + rowF.isv3;
            //        AgregarNuevo = false;
            //    }
            //    valor_total += (rowF.total_linea);
            //    txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(valor_total,2));
            //}

            //if (AgregarNuevo)
            //{
            //    dsVentas.detalle_factura_transactionRow row1 = dsVentas1.detalle_factura_transaction.Newdetalle_factura_transactionRow();
            //    //dsCompras.oc_d_normalRow row1 = dsCompras1.oc_d_normal.Newoc_d_normalRow();
            //    row1.id_pt = row.id_pt;
            //    row1.cantidad = 1;
            //    //row1.precio = 50;
            //    row1.precio = PuntoDeVentaActual.RecuperarPrecioItem(row1.id_pt, this.PuntoDeVentaActual.ID, this.ClienteFactura.Id);

            //    if (row1.precio == 0)
            //    {
            //        SetErrorBarra("Este producto no tiene definido un precio. Por favor valide Lista de Precios!");
            //    }

            //    row1.descuento = 0;
            //    row1.itemcode = row.item_code;
            //    row1.itemname = row.descripcion;
            //    ProductoTerminado pt1= new ProductoTerminado();
            //    row1.inventario = pt1.Recuperar_Cant_Inv_Actual_PT_for_facturacion(row.id_pt, this.PuntoDeVentaActual.ID);

            //    row1.isv1 = row1.isv2 = row1.isv3 = 0;
            //    Impuesto impuesto = new Impuesto();
            //    decimal tasaISV = 0;

            //    if (impuesto.RecuperarRegistro(row.id_isv_aplicable))
            //    {
            //        tasaISV = impuesto.Valor / 100;
            //        row1.isv1 = ((row1.cantidad * row1.precio) - row1.descuento) * tasaISV;
            //        row1.tasa_isv = tasaISV;
            //        row1.id_isv_aplicable = impuesto.Id;
            //    }
            //    else
            //    {
            //        row1.tasa_isv = 0;
            //        row1.id_isv_aplicable = 0;
            //    }

            //    row1.total_linea = (row1.cantidad * row1.precio) - row1.descuento + row1.isv1 + row1.isv2 + row1.isv3;
                
            //    //dsCompras.oc_d_normal.Addoc_d_normalRow(row1);
            //    dsVentas1.detalle_factura_transaction.Adddetalle_factura_transactionRow(row1);
            //    valor_total += (row1.total_linea );
            //    txtTotal.Text= string.Format("{0:#,###,##0.00}", Math.Round(valor_total,2));
            //}
        }

        private void simpleButton1_Click_2(object sender, EventArgs e)
        {
            //frmSearch frm = new frmSearch(frmSearch.TipoBusqueda.ProductoTerminado);
            frmSearchDefault frm = new frmSearchDefault(frmSearchDefault.TipoBusqueda.ProductoTerminado, this.PuntoDeVentaActual);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //txtNombreCliente.Text = frm.ItemSeleccionado.ItemName;
                //ProIdCliente = frm.ItemSeleccionado.id;
                ProductoTerminado pt1 = new ProductoTerminado();
                if (pt1.Recuperar_producto(frm.ItemSeleccionado.id))
                {

                    decimal valor_total = 0;

                    bool AgregarNuevo = true;
                    foreach (dsVentas.detalle_factura_transactionRow rowF in dsVentas1.detalle_factura_transaction)
                    {
                        if (rowF.id_pt == frm.ItemSeleccionado.id)
                        {
                            //Sumar cantidad nada mas
                            rowF.inventario = pt1.Recuperar_Cant_Inv_Actual_PT_for_facturacion(pt1.Id, this.PuntoDeVentaActual.ID);
                            rowF.cantidad = rowF.cantidad + 1;
                            rowF.isv1 = rowF.isv2 = rowF.isv3 = 0;
                            rowF.isv1 = ((rowF.cantidad * rowF.precio) - rowF.descuento) * rowF.tasa_isv;
                            rowF.total_linea = (rowF.cantidad * rowF.precio) - rowF.descuento + rowF.isv1 + rowF.isv2 + rowF.isv3;
                            AgregarNuevo = false;
                        }
                        //valor_total += (rowF.total_linea + rowF.isv1);
                        valor_total += rowF.total_linea;
                        txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(valor_total,2));
                    }

                    if (AgregarNuevo)
                    {
                        dsVentas.detalle_factura_transactionRow row1 = dsVentas1.detalle_factura_transaction.Newdetalle_factura_transactionRow();
                        //dsCompras.oc_d_normalRow row1 = dsCompras1.oc_d_normal.Newoc_d_normalRow();
                        row1.id_pt = frm.ItemSeleccionado.id;
                        row1.cantidad = 1;
                        row1.descuento = 0;


                        row1.precio = PuntoDeVentaActual.RecuperarPrecioItem(row1.id_pt, PuntoDeVentaActual.ID, this.ClienteFactura.Id);
                        row1.descuento_porcentaje = PuntoDeVentaActual.RecuperarMaximoDescuentoItem(row1.id_pt, PuntoDeVentaActual.ID, this.ClienteFactura.Id);
                        
                        row1.descuento = ((row1.cantidad * row1.precio) * (row1.descuento_porcentaje / 100));


                        #region Calculo del precio base mas ISV
                        //if (row1.precio == 0)
                        //{
                        //    SetErrorBarra("Este producto no tiene definido un precio. Por favor valide Lista de Precios!");
                        //}

                        //row1.descuento = 0;
                        //row1.itemcode = frm.ItemSeleccionado.ItemCode;
                        //row1.itemname = frm.ItemSeleccionado.ItemName;
                        //row1.inventario = pt1.Recuperar_Cant_Inv_Actual_PT_for_facturacion(pt1.Id);

                        //row1.isv1 = row1.isv2 = row1.isv3 = 0;
                        //Impuesto impuesto = new Impuesto();
                        //decimal tasaISV = 0;

                        //if (impuesto.RecuperarRegistro(pt1.Id_isv_aplicable))
                        //{
                        //    tasaISV = impuesto.Valor / 100;
                        //    row1.isv1 = ((row1.cantidad * row1.precio) - row1.descuento) * tasaISV;
                        //    row1.tasa_isv = tasaISV;
                        //    row1.id_isv_aplicable = impuesto.Id;
                        //}
                        //else
                        //{
                        //    row1.tasa_isv = 0;
                        //    row1.id_isv_aplicable = 0;
                        //}

                        //row1.total_linea = (row1.cantidad * row1.precio) - row1.descuento + row1.isv1 + row1.isv2 + row1.isv3;
                        #endregion

                        if (row1.precio == 0)
                        {
                            SetErrorBarra("Este producto no tiene definido un precio. Por favor valide Lista de Precios!");
                            return;
                        }

                        
                        row1.itemcode = frm.ItemSeleccionado.ItemCode;
                        row1.itemname = frm.ItemSeleccionado.ItemName;
                        row1.inventario = pt1.Recuperar_Cant_Inv_Actual_PT_for_facturacion(pt1.Id, this.PuntoDeVentaActual.ID);

                        row1.isv1 = row1.isv2 = row1.isv3 = 0;
                        Impuesto impuesto = new Impuesto();
                        decimal tasaISV = 0;

                        if (impuesto.RecuperarRegistro(pt1.Id_isv_aplicable))
                        {
                            tasaISV = impuesto.Valor / 100;
                            row1.isv1 = ((row1.precio - row1.descuento) / 100) * impuesto.Valor;
                            row1.precio = (row1.precio - row1.descuento) - row1.isv1;

                            row1.tasa_isv = tasaISV;
                            row1.id_isv_aplicable = impuesto.Id;
                        }
                        else
                        {
                            row1.tasa_isv = 0;
                            row1.id_isv_aplicable = 0;
                            row1.precio = (row1.precio - row1.descuento);
                        }

                        row1.total_linea = (row1.cantidad * row1.precio) + (row1.cantidad * row1.isv1) + (row1.cantidad * row1.isv2) + (row1.cantidad * row1.isv3);


                        //dsCompras.oc_d_normal.Addoc_d_normalRow(row1);
                        dsVentas1.detalle_factura_transaction.Adddetalle_factura_transactionRow(row1);
                        valor_total += (row1.total_linea);// + row1.isv1);
                        txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(valor_total,2));

                        if(dsVentas1.detalle_factura_transaction.Count>0)
                            gridView1.FocusedRowHandle = dsVentas1.detalle_factura_transaction.Count - 1;
                        else
                            gridView1.FocusedRowHandle = 0;

                        gridView1.FocusedColumn = colcantidad;
                        gridView1.ShowEditor();
                    }
                }
            }
        }

        private void cmdConsumidorFinal_Click(object sender, EventArgs e)
        {
            txtNombreCliente.Text = "Consumidor Final";
            txtRTN.Text =  
            txtDireccion.Text = "N/D";

            //txtDireccion.Properties.NullText = 
            //txtRTN.Properties.NullText = "No Aplica";

            ClienteFactura = new ClienteFacturacion();
            ClienteFactura.Recuperado = false;
            ClienteFactura.ClearClass();
        }

        private void cmdDeleteRowFactura_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Button Click delete row in factura.
            DialogResult r = MessageBox.Show("¿Desea Eliminar esta linea?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes)
            {
                return;
            }

            var gridView1 = (GridView)gridControl1.FocusedView;
            var row = (dsVentas.detalle_factura_transactionRow)gridView1.GetFocusedDataRow();

            try
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                CalcularTotalFactura();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void navigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsVentas.detalle_factura_transactionRow)gridView.GetFocusedDataRow();
            switch (e.Column.FieldName)
            {
                case "cantidad":
                    
                    if (row.cantidad > 0)
                    {
                        //No permitiremos facturar mas que lo que hay en inventario
                        if(row.cantidad > row.inventario)
                        {
                            //row.cantidad = dp.ValidateNumberDecimal(e.OldValue);
                            row.SetColumnError("cantidad", "No se puede facturar una cantidad mayor al inventario actual!");
                        }
                        else
                        {
                            row.ClearErrors();
                        }
                    }
                    break;
                case "descuento":
                    decimal vDescuento = dp.ValidateNumberDecimal(e.Value);

                    if (vDescuento < 0)
                    {
                        CajaDialogo.Error("No se permite valores menores a cero (0)!");
                        return;
                    }

                    if (vDescuento > 100)
                    {
                        CajaDialogo.Error("No se permite valores mayores a cien (100)!");
                        return;
                    }


                    decimal vPorcentajeDescuento = PuntoDeVentaActual.RecuperarMaximoDescuentoItem(row.id_pt, PuntoDeVentaActual.ID, this.ClienteFactura.Id);

                    if (vDescuento > vPorcentajeDescuento)
                    {
                        CajaDialogo.Error("No se permite un descuento mayor al permitido!");
                        row.descuento = 0;
                        return;
                    }

                    decimal vDescuentoLinea = ((row.cantidad * row.precio) * (vDescuento / 100));
                    row.descuento = vDescuentoLinea;

                    //recalculamos 
                    break;
            }
            CalcularTotalFactura();
        }

        decimal CalcularTotalFactura()
        {
            decimal total = 0;  
            foreach(dsVentas.detalle_factura_transactionRow row in dsVentas1.detalle_factura_transaction)
            {
                row.total_linea = (row.cantidad * row.precio) - row.descuento;
                row.total_linea = ((row.cantidad * row.precio) - row.descuento ) + (row.cantidad * row.isv1) + (row.cantidad * row.isv2) + (row.cantidad * row.isv3);
                total += row.total_linea;    
            }

            txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(total,2));
            return total;
        }


        private void rdContado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdContado.Checked)
            {
                rdContado.CheckedChanged -= new EventHandler(rdContado_CheckedChanged);
                rdCredito.CheckedChanged -= new EventHandler(rdCredito_CheckedChanged); 
                rdPorCobrar.CheckedChanged -= new EventHandler(rdPorCobrar_CheckedChanged);
                rdCredito.Checked = false;
                rdPorCobrar.Checked = false;
                IdTerminoPago = 1;
                rdPorCobrar.CheckedChanged += new EventHandler(rdPorCobrar_CheckedChanged);
                rdCredito.CheckedChanged += new EventHandler(rdCredito_CheckedChanged);
                rdContado.CheckedChanged += new EventHandler(rdContado_CheckedChanged);
            }
        }

        private void rdCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCredito.Checked)
            {
                rdCredito.CheckedChanged -= new EventHandler(rdPorCobrar_CheckedChanged);
                rdPorCobrar.CheckedChanged -= new EventHandler(rdPorCobrar_CheckedChanged);
                rdContado.CheckedChanged -= new EventHandler(rdContado_CheckedChanged);
                rdContado.Checked = false;
                rdPorCobrar.Checked = false;
                IdTerminoPago = 2;
                rdContado.CheckedChanged += new EventHandler(rdContado_CheckedChanged);
                rdPorCobrar.CheckedChanged += new EventHandler(rdPorCobrar_CheckedChanged);
                rdCredito.CheckedChanged += new EventHandler(rdPorCobrar_CheckedChanged);
            }
        }

        private void CargarDetalleCotizacion(int pIdCotizacion)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_get_pedido_detalle_for_factura_final_with_inv_v2]", conn);
                cmd.CommandType = CommandType.StoredProcedure; ;
                cmd.Parameters.AddWithValue("@id_h", pIdCotizacion);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsVentas1.detalle_factura_transaction.Clear();
                adat.Fill(dsVentas1.detalle_factura_transaction);
                conn.Close();
                //CalcularTotal();
                CalcularTotalFactura();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdCopiarFromPedido_Click(object sender, EventArgs e)
        {
            frmSearchPedidos frm = new frmSearchPedidos(UsuarioLogeado, PuntoDeVentaActual);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //Cotizacion coti = new Cotizacion();
                PedidoCliente Pedido1 = new PedidoCliente();
                if (Pedido1.RecuperarRegistro(frm.IdPedido))
                {
                    IdPedido = frm.IdPedido;
                    ProIdCliente = Pedido1.IdCliente;
                    if (ClienteFactura == null)
                        ClienteFactura = new ClienteFacturacion();

                    this.UsuarioLogeado = new UserLogin();
                    if (UsuarioLogeado.RecuperarRegistro(Pedido1.IdUser))
                    {
                        txtVendedor.Text = UsuarioLogeado.Codigo + " - " + UsuarioLogeado.NombreUser;
                    }

                    PedidoRecuperado = Pedido1;

                    if (ClienteFactura.RecuperarRegistro(Pedido1.IdCliente))
                    {
                        ClienteEmpresa clienteEmpresa1 = new ClienteEmpresa();
                        if (clienteEmpresa1.RecuperarEmpresaRTNCliente(ClienteFactura.Id, Pedido1.RTN))
                        {
                            txtNombreCliente.Text = clienteEmpresa1.NombreLargo;
                            txtRTN.Text = clienteEmpresa1.RTN;
                            txtDireccion.Text = clienteEmpresa1.Direccion;

                        }
                        else
                        {
                            txtNombreCliente.Text = ClienteFactura.NombreCliente;
                            txtDireccion.Text = ClienteFactura.Direccion;
                            txtRTN.Text = "";
                        }

                        CargarDetalleCotizacion(frm.IdPedido);

                        if (dsVentas1.detalle_factura_transaction.Count > 0)
                        {
                            decimal AcumuladoTotalFactura = 0;
                            foreach (dsVentas.detalle_factura_transactionRow row1 in dsVentas1.detalle_factura_transaction)
                            {
                                ProductoTerminado pt1 = new ProductoTerminado();
                                if (pt1.Recuperar_producto(row1.id_pt))
                                {
                                    row1.precio = PuntoDeVentaActual.RecuperarPrecioItem(row1.id_pt, PuntoDeVentaActual.ID, this.ClienteFactura.Id);

                                    if (row1.precio == 0)
                                    {
                                        SetErrorBarra("Este producto no tiene definido un precio. Por favor valide Lista de Precios!");
                                    }

                                    row1.descuento = 0;
                                    row1.inventario = pt1.Recuperar_Cant_Inv_Actual_PT_for_facturacion(pt1.Id, this.PuntoDeVentaActual.ID);

                                    row1.isv1 = row1.isv2 = row1.isv3 = 0;
                                    Impuesto impuesto = new Impuesto();
                                    decimal tasaISV = 0;

                                    if (impuesto.RecuperarRegistro(pt1.Id_isv_aplicable))
                                    {
                                        tasaISV = impuesto.Valor / 100;
                                        row1.isv1 = ((row1.precio - row1.descuento) / 100) * impuesto.Valor;
                                        row1.precio = (row1.precio - row1.descuento) - row1.isv1;

                                        row1.tasa_isv = tasaISV;
                                        row1.id_isv_aplicable = impuesto.Id;
                                    }
                                    else
                                    {
                                        row1.tasa_isv = 0;
                                        row1.id_isv_aplicable = 0;
                                        row1.precio = (row1.precio - row1.descuento);
                                    }

                                    row1.total_linea = (row1.cantidad * row1.precio) + (row1.cantidad * row1.isv1) + (row1.cantidad * row1.isv2) + (row1.cantidad * row1.isv3);
                                    AcumuladoTotalFactura += row1.total_linea;
                                }
                            }
                            txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(AcumuladoTotalFactura, 2));
                        }

                    }
                }
            }
        }//End cmd copiar from pedido

        private void cmdChangeVendedor_Click(object sender, EventArgs e)
        {
            frmLoginVendedores frmLogin1 = new frmLoginVendedores();
            if (frmLogin1.ShowDialog() == DialogResult.OK)
            {
                txtVendedor.Text = frmLogin1.CodigoVendedor + " - " + frmLogin1.NombreVendedor;
                VendedorActual = frmLogin1.Vendedor_;
                this.UsuarioLogeado = new UserLogin();
                if (UsuarioLogeado.RecuperarRegistro(VendedorActual.Id))
                {

                }
            }
        }

        private void txtVendedor_DoubleClick(object sender, EventArgs e)
        {
            frmLoginVendedores frmLogin1 = new frmLoginVendedores();
            if (frmLogin1.ShowDialog() == DialogResult.OK)
            {
                txtVendedor.Text = frmLogin1.CodigoVendedor + " - " + frmLogin1.NombreVendedor;
                VendedorActual = frmLogin1.Vendedor_;
                this.UsuarioLogeado = new UserLogin();
                if (UsuarioLogeado.RecuperarRegistro(VendedorActual.Id))
                {

                }
            }
        }

        private void rdPorCobrar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPorCobrar.Checked)
            {
                rdPorCobrar.CheckedChanged -= new EventHandler(rdPorCobrar_CheckedChanged);
                rdCredito.CheckedChanged -= new EventHandler(rdCredito_CheckedChanged);
                rdContado.CheckedChanged -= new EventHandler(rdContado_CheckedChanged);
                rdContado.Checked = false;
                rdCredito.Checked = false;
                IdTerminoPago = 3;
                rdPorCobrar.CheckedChanged += new EventHandler(rdPorCobrar_CheckedChanged);
                rdContado.CheckedChanged += new EventHandler(rdContado_CheckedChanged);
                rdCredito.CheckedChanged += new EventHandler(rdCredito_CheckedChanged);
            }
        }

        private void cmdExonerarFactura_Click(object sender, EventArgs e)
        {
            frmDatosExoneracion_factura frm = new frmDatosExoneracion_factura(this.UsuarioLogeado, this.PedidoRecuperado.Id);
            //frmAutorizacionSingle frm = new frmAutorizacionSingle();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //this.dsVentas1.detalle_factura_transaction.Clear();
                foreach(dsVentas.detalle_factura_transactionRow rowH in dsVentas1.detalle_factura_transaction)
                {
                    foreach (dsVentas.detalle_factura_transactionRow row in frm.dsVentas1.detalle_factura_transaction)
                    {
                        if(rowH.id_pt == row.id_pt)
                        {
                            rowH.isv1 = row.isv1;
                            rowH.isv2 = row.isv2;
                            rowH.isv3 = row.isv3;

                            rowH.total_linea = rowH.cantidad * (rowH.precio - rowH.descuento);
                            break;
                        }
                    }
                }
                CalcularTotalFactura();

                lblConstanciaExo.Visible = lblRegistroExo.Visible = lblOrdenCompraExo.Visible = true;
                lblConstanciaExoValue.Visible = lblRegistroExoValue.Visible = lblOrdenCompaExoValue.Visible = true;
                lblConstanciaExoValue.Text = frm.txtConstancia.Text;
                lblRegistroExoValue.Text = frm.txtRegistroSAG.Text;
                lblOrdenCompaExoValue.Text = frm.txtOrdenCompra.Text;
            }
            else
            {
                lblConstanciaExo.Visible = lblRegistroExo.Visible = lblOrdenCompraExo.Visible = false;
                lblConstanciaExoValue.Visible = lblRegistroExoValue.Visible = lblOrdenCompaExoValue.Visible = false;
            }
        }
    }
}