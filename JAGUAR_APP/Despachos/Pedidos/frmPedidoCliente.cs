using ACS.Classes;
using DevExpress.CodeParser;
using DevExpress.DashboardWin.Design;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Calidad.LoteConfConsumo;

//using Infragistics.Win.Misc;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Despachos.Pedidos;

//using JAGUAR_PRO.Despachos.Pedidos;
using JAGUAR_PRO.Facturacion.CoreFacturas;
using JAGUAR_PRO.Facturacion.Mantenimientos.Models;
using JAGUAR_PRO.Facturacion.Numeracion_Fiscal;
using JAGUAR_PRO.Facturacion.Reportes;
using JAGUAR_PRO.Mantenimientos;
using JAGUAR_PRO.Mantenimientos.Modelos;
using JAGUAR_PRO.Mantenimientos.ProductoTerminado;
using JAGUAR_PRO.RecuentoInventario;
using JAGUAR_PRO.TransaccionesPT;
using JAGUAR_PRO.Utileria;
using LOSA.Calidad.LoteConfConsumo;
using Microsoft.VisualBasic;
using System;
using System.Collections;
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


namespace Eatery.Ventas
{
    public partial class frmPedidoCliente : Form
    {
        DataOperations dp = new DataOperations();
        PDV PuntoDeVentaActual;
        Vendedor VendedorActual;
        FacturacionEquipo EquipoActual;
        Int64 ProIdCliente;
        ClienteFacturacion ClienteFactura;
        int IdTerminoPago;
        PedidoCliente PedidoActual;
        public enum TipoOperacionSQL
        {
            Insert = 1, Update = 2
        }

        public enum TipoFacturacionStock
        {
            VentaNormal = 1,
            VentaUsados = 2
        }

        TipoFacturacionStock TipoFacturacionActual;
        TipoOperacionSQL TipoOperacionActual;

        UserLogin UsuarioLogeado;
        public enum Busqueda
        {
            LoMasVendido = 1,
            Todos = 2
        }

        Busqueda BusquedaSet;

        public frmPedidoCliente(UserLogin pUser, PDV pPuntoDeVentaActual, FacturacionEquipo pEquipoActual, 
                                Vendedor pVendedor, TipoFacturacionStock pTipo)
        {
            InitializeComponent();
            TipoFacturacionActual = pTipo;
            

            TipoOperacionActual = TipoOperacionSQL.Insert;

            this.VendedorActual = pVendedor;
            if (VendedorActual != null)
            {
                if (VendedorActual.Recuperado)
                {
                    txtAsesorVendedor.Text = VendedorActual.CodigoVendedor + " - " + VendedorActual.Nombre;
                }
            }

            ckConfirmarPedido.Visible = ckGenerarCotizacion.Visible = true;
            ClienteFactura = new ClienteFacturacion();
            IdTerminoPago = 1;
            PuntoDeVentaActual = pPuntoDeVentaActual;
            EquipoActual = pEquipoActual;

            LoadEstadosPedidos();
            gleEstados.EditValue = 6;

            BusquedaSet = Busqueda.LoMasVendido;
            SetBusqueda();
            txtNombreCliente.Text = "Consumidor Final";
            txtRTN.Text = string.Empty;
            txtRTN.Properties.NullValuePrompt =
            txtDireccion.Properties.NullValuePrompt = "No Aplica";

            UsuarioLogeado = pUser;
            DateTime FechaActual_ = dp.NowSetDateTime();
            lblfecha.Text = Convert.ToString(FechaActual_);
            dtFechaEntrega.DateTime = FechaActual_;//.AddDays(1);
            string.Format("{0:MM/dd/yyyy}", lblfecha.Text);

            string HostName = Dns.GetHostName();
            
            FacturacionEquipo Equipo1 = new FacturacionEquipo();
            if (Equipo1.RecuperarRegistro(HostName))
            {
                if (PuntoDeVentaActual.RecuperaRegistro(Equipo1.id_punto_venta))
                {
                    if (PuntoDeVentaActual.FacturaComidaBuffet)//Mostramos todas las opciones
                    {
                        //lblOpcionesBuffetRadioButtonGroup.Visible =
                        //radioGroupVentaComidaBuffet.Visible = true;
                        LoadDefaultOptionRadioButtos();
                    }
                    else
                    {
                        //lblOpcionesBuffetRadioButtonGroup.Visible = 
                        //radioGroupVentaComidaBuffet.Visible = false;
                        LoadDefaultOptionRadioButtos();
                    }
                }
            }
            LoadBancosAndTiposPago();

            if (TipoFacturacionActual == TipoFacturacionStock.VentaUsados)
            {
                lblScanProducto.Visible =
                txtScanProducto.Visible = true;
                cmdCopiarDesde.Visible =
                ckGenerarCotizacion.Visible = false;
            }
            else
            {
                gridView1.Columns["entrega_almacen_bit"].Visible = false; 
            }

            //if (HostName == "7L12TV3" || HostName == "F3DYSQ2" /*Danys Oliva*/ ||
            //    HostName == "9SSCBV2" || HostName == "9PG91W2" /*Ruben Garcia */ ||
            //    HostName == "F9Q11Q2" /*PC Soporte La 50*/||
            //    HostName == "EUCEDA-PC" /*Euceda*/)
            //{
            //    cmdIngresarAdmin.Visible = SaltarLogin.Visible = simpleButton2.Visible = SaltarLoginPRD.Visible = true;
            //}
        }

       

        public frmPedidoCliente(UserLogin pUser, PDV pPuntoDeVentaActual, FacturacionEquipo pEquipoActual, 
                                Int64 pIdPedido, TipoFacturacionStock pTipo)
        {
            InitializeComponent();
            TipoOperacionActual = TipoOperacionSQL.Update;
            TipoFacturacionActual = pTipo;
            ckConfirmarPedido.Visible = ckGenerarCotizacion.Visible = false;
            simpleButton1.Enabled = true;
            
            LoadEstadosPedidos();
            PedidoActual = new PedidoCliente();
            ClienteFactura = new ClienteFacturacion();
            //IdTerminoPago = 1;
            PuntoDeVentaActual = pPuntoDeVentaActual;
            EquipoActual = pEquipoActual;

            BusquedaSet = Busqueda.LoMasVendido;
            SetBusqueda();
            txtNombreCliente.Text = "Consumidor Final";
            txtRTN.Text = string.Empty;
            txtRTN.Properties.NullValuePrompt =
            txtDireccion.Properties.NullValuePrompt = "No Aplica";

            UsuarioLogeado = pUser;
            DateTime FechaActual_ = dp.NowSetDateTime();
            lblfecha.Text = Convert.ToString(FechaActual_);
            dtFechaEntrega.DateTime = FechaActual_.AddDays(1);
            string.Format("{0:dd/MM/yyyy}", lblfecha.Text);

            string HostName = Dns.GetHostName();

            FacturacionEquipo Equipo1 = new FacturacionEquipo();
            if (Equipo1.RecuperarRegistro(HostName))
            {
                if (PuntoDeVentaActual.RecuperaRegistro(Equipo1.id_punto_venta))
                {
                    if (PuntoDeVentaActual.FacturaComidaBuffet)//Mostramos todas las opciones
                    {
                        //lblOpcionesBuffetRadioButtonGroup.Visible =
                        //radioGroupVentaComidaBuffet.Visible = true;
                        //LoadDefaultOptionRadioButtos();
                    }
                    else
                    {
                        //lblOpcionesBuffetRadioButtonGroup.Visible = 
                        //radioGroupVentaComidaBuffet.Visible = false;
                        //LoadDefaultOptionRadioButtos();
                    }
                }
            }

            if (pIdPedido > 0)
            {
                PedidoCliente pedidoCliente = new PedidoCliente();  
                if(pedidoCliente.RecuperarRegistro(pIdPedido))
                {
                    if(pedidoCliente.IdEstado == 6)// || pedidoCliente.IdEstado == 1)
                    {
                        cmdConfirmarFactura.Visible = true;
                    }
                    else
                    {
                        cmdConfirmarFactura.Visible = false;
                    }

                    PedidoActual = pedidoCliente;
                    ClienteFactura = new ClienteFacturacion();
                    
                    IdTerminoPago = pedidoCliente.IdTerminoPago;
                    if(IdTerminoPago== 1)//Contado
                    {
                        rdContado.CheckedChanged -= new EventHandler(rdContado_CheckedChanged_1);
                        rdPorCobrar.CheckedChanged -= new EventHandler(rdCredito_CheckedChanged_1);
                        rdContado.Checked = true;
                        rdPorCobrar.Checked = false;
                        rdPorCobrar.CheckedChanged += new EventHandler(rdCredito_CheckedChanged_1);
                        rdContado.CheckedChanged += new EventHandler(rdContado_CheckedChanged_1);
                    }

                    if (IdTerminoPago == 2)//Credito
                    {
                        rdContado.CheckedChanged -= new EventHandler(rdContado_CheckedChanged_1);
                        rdPorCobrar.CheckedChanged -= new EventHandler(rdCredito_CheckedChanged_1);
                        rdContado.Checked = false;
                        rdPorCobrar.Checked = true;
                        rdPorCobrar.CheckedChanged += new EventHandler(rdCredito_CheckedChanged_1);
                        rdContado.CheckedChanged += new EventHandler(rdContado_CheckedChanged_1);
                    }

                        txtNombreCliente.Text = pedidoCliente.ClienteNombre;
                    txtRTN.Text = pedidoCliente.RTN;
                    txtDireccion.Text = pedidoCliente.direccion_cliente;
                    ClienteFactura.Id = pedidoCliente.IdCliente;

                    lblfecha.Text = string.Format("{0:dd/MM/yyyy}", pedidoCliente.FechaDocumento);
                    dtFechaEntrega.DateTime = pedidoCliente.FechaEntrega;
                    txtComentario.Text = pedidoCliente.Comentario;
                    VendedorActual = new Vendedor();
                    if (!string.IsNullOrEmpty(pedidoCliente.CodigoVendedor))
                    {
                        if (VendedorActual.RecuperarRegistro(pedidoCliente.CodigoVendedor))
                        {
                            txtAsesorVendedor.Text = VendedorActual.Nombre;
                        }
                    }
                    LoadDetallePedidoForEdit(pIdPedido);
                    gleEstados.EditValue = pedidoCliente.IdEstado;
                    ckGenerarCotizacion.Visible = ckConfirmarPedido.Visible = false;
                    

                }
                txtNombreCliente.Focus();
                txtNombreCliente.SelectAll();
            }

            //if (HostName == "7L12TV3" || HostName == "F3DYSQ2" /*Danys Oliva*/ ||
            //    HostName == "9SSCBV2" || HostName == "9PG91W2" /*Ruben Garcia */ ||
            //    HostName == "F9Q11Q2" /*PC Soporte La 50*/||
            //    HostName == "EUCEDA-PC" /*Euceda*/)
            //{
            //    cmdIngresarAdmin.Visible = SaltarLogin.Visible = simpleButton2.Visible = SaltarLoginPRD.Visible = true;
            //}
        }


        private void LoadEstadosPedidos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_detalle_estados_pedidos_h]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);
                //cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                //cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPedidosVentas1.estados_pedidos.Clear();
                adat.Fill(dsPedidosVentas1.estados_pedidos);

                con.Close();
                txtScanProducto.Focus();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void LoadDetalleCotizacionForEdit(Int64 pIdPrefacturaH)
        {
            //Recuperar los id PT agrupados para iterar precios y cantidad total
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_rows_from_cotizacion]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", pIdPrefacturaH);
                //cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                //cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //Iteramos agregar cada PT 
                    //id_pt
                    //,sum([cantidad]) as [cantidad]
                    //,[id_h]
                    //,[id_presentacion_pt]
                    //,[precio]
                    //,[id_user]
                    //,[id_estado]
                    //,[descripcion]
                    //,[isv]

                    ProductoTerminado pt = new ProductoTerminado();
                    decimal Cantidad = 0;
                    string Descripcion = string.Empty;
                    decimal descuentoLinea = 0;
                    decimal descuentoPorcentaje = 0;

                    if (!dr.IsDBNull(dr.GetOrdinal("id_pt")))
                        pt.Id = dr.GetInt32(0);

                    if (!dr.IsDBNull(dr.GetOrdinal("cantidad")))
                        Cantidad = dr.GetDecimal(1);

                    if (!dr.IsDBNull(dr.GetOrdinal("descripcion")))
                        Descripcion = dr.GetString(7);

                    if (!dr.IsDBNull(dr.GetOrdinal("descuento")))
                        descuentoLinea = dr.GetDecimal(9);

                    //if (!dr.IsDBNull(dr.GetOrdinal("descuento_porcentaje")))
                    //    descuentoPorcentaje = dr.GetDecimal(10);

                    if (pt.Recuperar_producto(pt.Id))
                        AgregarProductoA_Prefactura(pt.Id, pt.Code, Descripcion, Cantidad, false, descuentoPorcentaje, pt, pt.MarcaName);

                }
                dr.Close();

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            //Iterar el detalle por almacen que se habia configurado 
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_rows_from_prefactura_lines]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", pIdPrefacturaH);
                //cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                //cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);

                dsVentas1.detalle_factura_transaccion_inv.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsVentas1.detalle_factura_transaccion_inv);

                con.Close();
                txtScanProducto.Focus();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDetallePedidoForEdit(Int64 pIdPrefacturaH)
        {
            //Recuperar los id PT agrupados para iterar precios y cantidad total
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_rows_from_prefactura_group_by_pt]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", pIdPrefacturaH);
                //cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                //cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //Iteramos agregar cada PT 
                    //id_pt
                    //,sum([cantidad]) as [cantidad]
                    //,[id_h]
                    //,[id_presentacion_pt]
                    //,[precio]
                    //,[id_user]
                    //,[id_estado]
                    //,[descripcion]
                    //,[isv]

                    ProductoTerminado pt = new ProductoTerminado();
                    decimal Cantidad = 0;
                    string Descripcion = string.Empty;
                    decimal descuentoLinea = 0;
                    decimal descuentoPorcentaje = 0;

                    if (!dr.IsDBNull(dr.GetOrdinal("id_pt")))
                        pt.Id = dr.GetInt32(0);

                    if (!dr.IsDBNull(dr.GetOrdinal("cantidad")))
                        Cantidad = dr.GetDecimal(1);

                    if (!dr.IsDBNull(dr.GetOrdinal("descripcion")))
                        Descripcion = dr.GetString(7);

                    if (!dr.IsDBNull(dr.GetOrdinal("descuento")))
                        descuentoLinea = dr.GetDecimal(9);

                    if (!dr.IsDBNull(dr.GetOrdinal("descuento_porcentaje")))
                        descuentoPorcentaje = dr.GetDecimal(10);

                    if (pt.Recuperar_producto(pt.Id))
                        AgregarProductoA_Prefactura(pt.Id, pt.Code, Descripcion, Cantidad, false, descuentoPorcentaje, pt, pt.MarcaName);
                    
                }
                dr.Close();

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            //Iterar el detalle por almacen que se habia configurado 
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_rows_from_prefactura_lines]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", pIdPrefacturaH);
                //cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                //cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);

                dsVentas1.detalle_factura_transaccion_inv.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsVentas1.detalle_factura_transaccion_inv);

                con.Close();
                txtScanProducto.Focus();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        void LoadBancosAndTiposPago()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_tipos_de_pago", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                //cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPedidosClientesV1.tipo_pagos.Clear();
                adat.Fill(dsPedidosClientesV1.tipo_pagos);

                cmd = new SqlCommand("sp_get_detalle_cuentas_para_depositos_bancarios", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                //cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                adat = new SqlDataAdapter(cmd);
                dsPedidosClientesV1.lista_cuentas.Clear();
                adat.Fill(dsPedidosClientesV1.lista_cuentas);

                if (dsPedidosClientesV1.tipo_pagos.Count() > 0)
                {
                    //gleTipoPago.EditValueChanged -= new EventHandler(gleTipoPago_EditValueChanged);
                    //gleTipoPago.EditValue = 1;
                    //gleBanco.Enabled = false;
                    //gleTipoPago.EditValueChanged += new EventHandler(gleTipoPago_EditValueChanged);
                }

                con.Close();
                txtScanProducto.Focus();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDefaultOptionRadioButtos()
        {
            int HoraActualInt = DateTime.Now.Hour;
            if (HoraActualInt <= 10)
            {
                //radioGroupVentaComidaBuffet.SelectedIndexChanged -= new EventHandler(radioGroupVentaComidaBuffet_SelectedIndexChanged);
                //radioGroupVentaComidaBuffet.SelectedIndex = 0;//Desayuno
                //radioGroupVentaComidaBuffet.SelectedIndexChanged += new EventHandler(radioGroupVentaComidaBuffet_SelectedIndexChanged);

                LoadOpcionesRapidas(1);
            }

            if (HoraActualInt > 10 && HoraActualInt <= 15)
            {
                //radioGroupVentaComidaBuffet.SelectedIndexChanged -= new EventHandler(radioGroupVentaComidaBuffet_SelectedIndexChanged);
                //radioGroupVentaComidaBuffet.SelectedIndex = 1;//Almuerzos
                //radioGroupVentaComidaBuffet.SelectedIndexChanged += new EventHandler(radioGroupVentaComidaBuffet_SelectedIndexChanged);
                LoadOpcionesRapidas(1);
            }

            if (HoraActualInt > 15)
            {

                //radioGroupVentaComidaBuffet.SelectedIndexChanged -= new EventHandler(radioGroupVentaComidaBuffet_SelectedIndexChanged);
                //radioGroupVentaComidaBuffet.SelectedIndex = 2;//cenas
                //radioGroupVentaComidaBuffet.SelectedIndexChanged += new EventHandler(radioGroupVentaComidaBuffet_SelectedIndexChanged);
                LoadOpcionesRapidas(1);
            }
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
                        
                        if(PedidoActual == null)
                            PedidoActual = new PedidoCliente();

                        PedidoActual.IdCliente = clienteEmpresa1.Id;
                        PedidoActual.IdEmpresa = frm.EmpresaID;
                        PedidoActual.RTN = clienteEmpresa1.RTN;
                        PedidoActual.ClienteNombre = clienteEmpresa1.NombreLargo;
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
            txtScanProducto.Focus();
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
                CalcularTotalFactura();
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
                    CalcularTotalFactura();
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

            CalcularTotalFactura();
        }

        private void btnRestar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Restar en cantidad
            //var gridView = (GridView)grMain.FocusedView;
            //var row = (dsVentas.factura_detalleRow)gridView.GetFocusedDataRow();
            //if (!row.apply_subsidio)
            //    if (row.cantidad > 1)
            //        row.cantidad -= 1;

            CalcularTotalFactura();
        }

        public void SetErrorBarra(string msj)
        {
            lblMensaje.Text = msj;
            panelNotificacion.BackColor = Color.FromArgb(232, 134, 114);// Color.Red;
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
            txtComentario.Text = string.Empty;
            ckConfirmarPedido.Checked = ckGenerarCotizacion.Checked = false;
            txtTotal.Text = "0.00";
        }

        private void cmdFacturar_Click(object sender, EventArgs e)
        {
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
                    if(row.inventario < row.cantidad)
                    {
                        SetErrorBarra("Esta intentando facturar producto con menor existencia en Inventario!");
                        return;
                    }
                }
            }

            bool ImprimirFactura = false;
            Factura facturaGenerada = null;

            //Efectuar que se haga la facturacion en dos pasos, primero la factura y luego el pago
            if (PuntoDeVentaActual.EmisionFacturaDosPasos)
            {
                    Factura factura = new Factura();

                if (!string.IsNullOrEmpty(txtRTN.Text))
                    factura.RTN = txtRTN.Text;

                if (!string.IsNullOrEmpty(txtNombreCliente.Text))
                    factura.ClienteNombre = txtNombreCliente.Text;

                if (!string.IsNullOrEmpty(txtDireccion.Text))
                    factura.direccion_cliente = txtDireccion.Text;
                    
                    if(ClienteFactura != null)
                        if(ClienteFactura.Id>0)
                            factura.IdCliente = ClienteFactura.Id;

                    factura.FechaDocumento = dp.NowSetDateTime();
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
                            command.CommandText = "[dbo].[sp_set_insert_factura_header_punto_venta_v7]";

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

                            command.Parameters.AddWithValue("@cliente_nombre", factura.ClienteNombre);
                            command.Parameters.AddWithValue("@id_tipo_pago", DBNull.Value);
                            command.Parameters.AddWithValue("@direccion_cliente", factura.direccion_cliente);
                            command.Parameters.AddWithValue("@subtotal", factura.subtotalFactura);
                            command.Parameters.AddWithValue("@descuento", factura.descuentoTotalFactura);
                            command.Parameters.AddWithValue("@isv1", factura.ISV1);
                            command.Parameters.AddWithValue("@isv2", factura.ISV2);
                            command.Parameters.AddWithValue("@id_formato_impresion", PuntoDeVentaActual.IdFormatoFactura);
                            command.Parameters.AddWithValue("@id_termino_pago", IdTerminoPago);

                            Int64 IdFacturaH = Convert.ToInt64(command.ExecuteScalar());
                            decimal TotalFactura = 0;
                            factura.Id = IdFacturaH;

                            //Posteamos lineas de factura y Transaccion en Kardex
                            foreach (dsVentas.detalle_factura_transactionRow row in dsVentas1.detalle_factura_transaction)
                            {
                                command.CommandText = "dbo.sp_set_insert_factura__lineas__punto_venta_dos_pasos";
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

                                if (row.id_isv_aplicable > 0)
                                    command.Parameters.AddWithValue("@id_isv_aplicado", row.id_isv_aplicable);
                                else
                                    command.Parameters.AddWithValue("@id_isv_aplicado", DBNull.Value);
                                TotalFactura += row.total_linea;
                                command.ExecuteNonQuery();
                            }

                            //Vamos a postear transaccion en estado de cuenta de cliente
                            if (factura.IdCliente > 0)
                            {
                                command.CommandText = "dbo.[sp_set_insert_estado_cuenta_cliente_v4]";
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Clear();
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

                            // Attempt to commit the transaction.
                            transaction.Commit();

                            SetInformationBarra("Factura Generada con Exito!");
                            ImprimirFactura = true;
                            facturaGenerada = factura;

                            //Limpiar Datos
                            dsVentas1.detalle_factura_transaction.Clear();
                            ClienteFactura = new ClienteFacturacion();
                            cmdConsumidorFinal_Click(sender, e);
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
            else
            {

                //PRIMERO EL PAGO LUEGO LA FACTURA
                decimal ValorTotalFactura = dp.ValidateNumberDecimal(txtTotal.Text);
                Int64 IdReciboH_Inserted = 0;

                frmPagoFactura frm = new frmPagoFactura(this.UsuarioLogeado, ValorTotalFactura, this.PuntoDeVentaActual, 
                                                        facturaGenerada.subtotalFactura, facturaGenerada.ISV1);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Factura factura = new Factura();
                    factura.monto_entregado = dp.ValidateNumberDecimal(frm.txtEntregado.Text);
                    factura.cambio = dp.ValidateNumberDecimal(frm.txtCambio.Text);

                    if (!string.IsNullOrEmpty(txtRTN.Text))
                        factura.RTN = txtRTN.Text;

                    if (!string.IsNullOrEmpty(txtNombreCliente.Text))
                        factura.ClienteNombre = txtNombreCliente.Text;

                    if (!string.IsNullOrEmpty(txtDireccion.Text))
                        factura.direccion_cliente = txtDireccion.Text;

                    if (ClienteFactura != null)
                        if (ClienteFactura.Id > 0)
                            factura.IdCliente = ClienteFactura.Id;

                    factura.FechaDocumento = dp.NowSetDateTime();

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
                            command.CommandText = "[dbo].[sp_set_insert_factura_header_punto_venta_v12]";
                            command.CommandType = CommandType.StoredProcedure;
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

                            command.Parameters.AddWithValue("@cliente_nombre", factura.ClienteNombre);
                            command.Parameters.AddWithValue("@id_tipo_pago", (int)frm.TipoPagoSeleccionadoActual);
                            command.Parameters.AddWithValue("@emiteFacturaFiscal", PuntoDeVentaActual.EmiteFacturaFiscal);

                            command.Parameters.AddWithValue("@direccion_cliente", factura.direccion_cliente);
                            command.Parameters.AddWithValue("@subtotal", factura.subtotalFactura);
                            command.Parameters.AddWithValue("@descuento", factura.descuentoTotalFactura);
                            command.Parameters.AddWithValue("@isv1", factura.ISV1);
                            command.Parameters.AddWithValue("@isv2", factura.ISV2);
                            command.Parameters.AddWithValue("@id_formato_impresion", PuntoDeVentaActual.IdFormatoFactura);
                            command.Parameters.AddWithValue("@monto_entregado", factura.monto_entregado);
                            command.Parameters.AddWithValue("@cambio", factura.cambio);

                            Int64 IdFacturaH = Convert.ToInt64(command.ExecuteScalar());
                            decimal TotalFactura = 0;
                            factura.Id = IdFacturaH;


                            //Posteamos lineas de factura y Transaccion en Kardex
                            foreach (dsVentas.detalle_factura_transactionRow row in dsVentas1.detalle_factura_transaction)
                            {
                                command.CommandText = "dbo.sp_set_insert_factura__lineas__punto_venta_dos_pasos";
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
                                if (row.id_isv_aplicable > 0)
                                    command.Parameters.AddWithValue("@id_isv_aplicado", row.id_isv_aplicable);
                                else
                                    command.Parameters.AddWithValue("@id_isv_aplicado", DBNull.Value);

                                TotalFactura += row.total_linea;
                                command.ExecuteNonQuery();
                            }

                            //El cargo por la factura
                            command.CommandText = "dbo.[sp_set_insert_estado_cuenta_cliente_v5]";
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Clear();
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
                                command.CommandText = "dbo.[sp_set_insert_recibo_pago_detalle_v3]";
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
            }//Bloque emitir Recibo de venta



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
                CalcularTotalFactura();
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
            txtRTN.Text = txtDireccion.Text = txtNombreCliente.Text = lblMensaje.Text = "";
            txtTotal.Text = "0.00";
            dsVentas1.detalle_factura_transaction.Clear();
            dsVentas1.detalle_factura_transaccion_inv.Clear();
            ClienteFactura = new ClienteFacturacion();

            txtAsesorVendedor.Enabled =
            cmdChangeVendedor.Visible =
            cmdCopiarDesde.Visible =
            simpleButton1.Visible = 
            simpleButton2.Visible = true;

            gridView1.OptionsMenu.EnableColumnMenu = true;//Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna, para elegir columnas, ordenar, etc
            gridView1.Columns["delete"].Visible = true; //Permite mostrar o ocultar una columna, se utiliza colocando el string de FieldName que se define desde el dataset

            CalcularTotalFactura();


            //Reiniciar la ventana Totalmente
            ckConfirmarPedido.Visible = ckGenerarCotizacion.Visible = true;
            ckConfirmarPedido.Checked = ckGenerarCotizacion.Checked = false;

            gleEstados.EditValue = 6;//Nuevo
            txtNombreCliente.Text = "Consumidor Final";
            //txtRTN.Text = string.Empty;
            //txtRTN.Properties.NullValuePrompt =
            //txtDireccion.Properties.NullValuePrompt = "No Aplica";
                        
            if (TipoFacturacionActual == TipoFacturacionStock.VentaUsados)
            {
                lblScanProducto.Visible =
                txtScanProducto.Visible =
                cmdCopiarDesde.Visible =
                ckGenerarCotizacion.Visible = false;
            }
            else
            {
                gridView1.Columns["entrega_almacen_bit"].Visible = false;
            }

        }

        private void timerLimpiarMensaje_Tick(object sender, EventArgs e)
        {
            timerLimpiarMensaje.Stop();
            timerLimpiarMensaje.Enabled = false;
            panelNotificacion.BackColor = Color.White;
            lblMensaje.Text = "";
            
            //cmdNew_Click(sender, e);
        }

        private void frmPedidoCliente_Activated(object sender, EventArgs e)
        {
            txtNombreCliente.Focus();
            txtNombreCliente.SelectAll();
        }

        private void toggleTipoVenta_Toggled(object sender, EventArgs e){}

        private void frmPedidoCliente_FormClosing(object sender, FormClosingEventArgs e){ }

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

        private void LoadOpcionesRapidas(int pIdTipoVentanaFacturacion)
        {
            //try
            //{
            //    DataOperations dp = new DataOperations();
            //    SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            //    con.Open();

            //    SqlCommand cmd = new SqlCommand("dbo.sp_get_lista_rapida_segun_tipo_ventana_facturacion", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@id_tipo_facturacion", pIdTipoVentanaFacturacion);
            //    cmd.Parameters.AddWithValue("@id_tipo_buffet", radioGroupVentaComidaBuffet.SelectedIndex);
                
            //    dsVentas1.Buffet_TopProductos.Clear();
            //    SqlDataAdapter adat = new SqlDataAdapter(cmd);
            //    adat.Fill(dsVentas1.Buffet_TopProductos);
            //    con.Close();
            //    ultraTilePanel1.Tiles.Clear();

            //    int i = 1;
            //    foreach (dsVentas.Buffet_TopProductosRow row in dsVentas1.Buffet_TopProductos)
            //    {
            //        //AddTilePanel(row.descripcion, i);
            //        AddTilePanel(row.descripcion, row.id);
            //        i++;
            //    }
                
            //}
            //catch (Exception ec)
            //{
            //    CajaDialogo.Error(ec.Message);
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


            ////button2.Dock = DockStyle.Fill;
            //tile2.State = TileState.Normal;
            //tile2.Settings.ShowStateChangeButton = Infragistics.Win.DefaultableBoolean.False;
            
            ////tile2.UseAppStyling = true;
            //ultraTilePanel1.Tiles.Add(tile2);
            ////ultraTilePanel1.Margin =pad1;

            //ultraTilePanel1.TileSettings.MaximumSize = new Size(362, 100);
        }

        private void radioGroupVentaComidaBuffet_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOpcionesRapidas(1);
            CargarOpcionesMasVendidas(2);
            
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
            txtScanProducto.Focus();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //Comidas
            CargarOpcionesMasVendidasLeftPriority(2);//1=Lo mas Vendido, 2=Comida(s), 3=Bebidas Frias, 4=Bebidas Calientes, 5=PAN, 6=Reposteria
            txtScanProducto.Focus();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //Bebidas Frias
            CargarOpcionesMasVendidasLeftPriority(3);//1=Lo mas Vendido, 2=Comida(s), 3=Bebidas Frias, 4=Bebidas Calientes, 5=PAN, 6=Reposteria
            txtScanProducto.Focus();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            //Bebidas Calientes
            CargarOpcionesMasVendidasLeftPriority(4);//1=Lo mas Vendido, 2=Comida(s), 3=Bebidas Frias, 4=Bebidas Calientes, 5=PAN, 6=Reposteria
            txtScanProducto.Focus();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            //PAN
            CargarOpcionesMasVendidasLeftPriority(5);//1=Lo mas Vendido, 2=Comida(s), 3=Bebidas Frias, 4=Bebidas Calientes, 5=PAN, 6=Reposteria
            txtScanProducto.Focus();
        }
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            //Reposteria
            CargarOpcionesMasVendidasLeftPriority(6);//1=Lo mas Vendido, 2=Comida(s), 3=Bebidas Frias, 4=Bebidas Calientes, 5=PAN, 6=Reposteria
            txtScanProducto.Focus();
        }

        private void CargarOpcionesMasVendidas(int pidClase)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();
                SqlCommand cmd;
               
                    cmd = new SqlCommand("[dbo].[sp_get_productos_mas_vendidos_para_pedidos]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@tipo_buffet", radioGroupVentaComidaBuffet.SelectedIndex + 1);
                    //cmd.Parameters.AddWithValue("@id_clase", pidClase);
                    cmd.Parameters.AddWithValue("@ver_lo_mas_vendido", (Int32)BusquedaSet);
                

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
            SetBusqueda();
            CargarOpcionesMasVendidas(2);
            txtScanProducto.Focus();
        }

        private void SetBusqueda()
        {
            //switch (BusquedaSet)
            //{
            //    case Busqueda.LoMasVendido:
            //        cmdTodosLosProductos.Appearance.BackColor = Color.White;
            //        cmdLoMasVendido.Appearance.BackColor = Color.LightGreen;
            //        break;
            //    case Busqueda.Todos:
            //        cmdTodosLosProductos.Appearance.BackColor = Color.LightGreen;
            //        cmdLoMasVendido.Appearance.BackColor = Color.White;
            //        break;
            //}
        }

        private void cmdTodosLosProductos_Click(object sender, EventArgs e)
        {
            BusquedaSet = Busqueda.Todos;
            SetBusqueda();
            txtScanProducto.Focus();
            CargarOpcionesMasVendidas(2);
        }

        private void cmdAddToCart_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ////agregar al carrito para facturar 
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
            //frmSearchDefault frm = new frmSearchDefault(frmSearchDefault.TipoBusqueda.ProductoTerminado, this.PuntoDeVentaActual);

            switch (TipoFacturacionActual)
            {
                case TipoFacturacionStock.VentaNormal:
                    //frmSearchItems.TipoFacturacion TipoFactBusqueda;
                    //if (TipoFacturacionActual == TipoFacturacionStock.VentaNormal)
                    //    TipoFactBusqueda = frmSearchItems.TipoFacturacion.VentaNormal;
                    //else
                    //    TipoFactBusqueda = frmSearchItems.TipoFacturacion.VentaUsados;

                    frmSearchItems frm = new frmSearchItems();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        AgregarProductoA_Prefactura(frm.ItemSeleccionado.id, frm.ItemSeleccionado.ItemCode,
                                                    frm.ItemSeleccionado.ItemName, 1, true, 0,
                                                    new ProductoTerminado(), frm.ItemSeleccionado.Marca);
                        txtScanProducto.Focus();
                    }
                    break;
                case TipoFacturacionStock.VentaUsados:
                    frmSearchDefault frm2 = new frmSearchDefault( frmSearchDefault.TipoBusqueda.ProductoTerminadoVentaUnica);
                    if (frm2.ShowDialog() == DialogResult.OK)
                    {
                        AgregarProductoA_PrefacturaUsados(frm2.ItemSeleccionado.id, frm2.ItemSeleccionado.ItemCode,
                                                          frm2.ItemSeleccionado.ItemName, 1, true, 0,
                                                          new ProductoTerminado(), frm2.ItemSeleccionado.Marca);
                        txtScanProducto.Focus();
                    }
                    break;
                default:

                    break;
            }

            

            

        }



        private void AgregarProductoA_Prefactura(int pIdPT, string pItemCode, string pItemName, 
                                                 decimal pCantidad, bool AddDistribucionAlmacen, 
                                                 decimal pDescuentoPorcentaje, ProductoTerminado pProductoTerminado
                                                 ,string pMarca)
        {
            ProductoTerminado pt1;
            if (pProductoTerminado == null) 
                pt1 = new ProductoTerminado();
            else
                pt1 = pProductoTerminado;
            

            if (!pt1.Recuperado)
                pt1.Recuperar_producto(pIdPT);


            if (pt1.Id>0)
            {

                decimal valor_total = 0;

                bool AgregarNuevo = true;
                foreach (dsVentas.detalle_factura_transactionRow rowF in dsVentas1.detalle_factura_transaction)
                {
                    if (rowF.id_pt == pIdPT)
                    {
                        //Sumar cantidad nada mas

                        rowF.inventario = pt1.Recuperar_Cant_Inv_Actual_PT_for_facturacion(pt1.Id, this.PuntoDeVentaActual.ID);
                       

                        rowF.cantidad = rowF.cantidad + 1;
                        rowF.codigo_referencia = pt1.Codig_Referencia;
                        rowF.isv1 = rowF.isv2 = rowF.isv3 = 0;
                        rowF.isv1 = ((rowF.cantidad * rowF.precio) - rowF.descuento) * rowF.tasa_isv;
                        rowF.total_linea = ((rowF.cantidad * rowF.precio) - rowF.descuento) + rowF.isv1 + rowF.isv2 + rowF.isv3;
                        AgregarNuevo = false;
                    }
                    //valor_total += (rowF.total_linea + rowF.isv1);
                    valor_total += rowF.total_linea;
                    txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(valor_total, 2));
                }

                if (AgregarNuevo)
                {
                    dsVentas.detalle_factura_transactionRow row1 = dsVentas1.detalle_factura_transaction.Newdetalle_factura_transactionRow();
                    row1.id_pt = pIdPT;
                    row1.cantidad = pCantidad;
                    row1.descuento = 
                    row1.descuento_porcentaje = 0;
                    row1.codigo_referencia = pt1.Codig_Referencia;
                    row1.marca = pt1.MarcaName;
                    row1.precio = PuntoDeVentaActual.RecuperarPrecioItem(row1.id_pt, PuntoDeVentaActual.ID, this.ClienteFactura.Id);
                    row1.id_presentacion = pt1.Id_presentacion;
                    row1.entrega_almacen_bit = false;

                    if (row1.precio == 0)
                    {
                        SetErrorBarra("Este producto no tiene definido un precio. Por favor valide Lista de Precios!");
                        return;
                    }


                    row1.itemcode = pItemCode;
                    row1.itemname = pItemName;
                    decimal invTotal = pt1.Recuperar_Cant_Inv_Actual_PT_for_facturacion(pt1.Id, this.PuntoDeVentaActual.ID);

                    //Recalculamos el Descuento si hay alguno
                    if (pDescuentoPorcentaje > 0 && pDescuentoPorcentaje < 100)
                    {
                        decimal vDescuento = pDescuentoPorcentaje;

                        decimal vPorcentajeDescuento = PuntoDeVentaActual.RecuperarMaximoDescuentoItem(pt1.Id, PuntoDeVentaActual.ID, this.ClienteFactura.Id);

                        if (vDescuento > vPorcentajeDescuento)
                        {
                            row1.descuento = row1.descuento_porcentaje = 0;
                            //CajaDialogo.Error("No se permite un descuento mayor al permitido!");
                            return;
                        }

                        row1.descuento_porcentaje = vDescuento;
                        decimal vDescuentoLinea = ((row1.cantidad * row1.precio) * (vDescuento / 100));
                        row1.descuento = vDescuentoLinea;

                        
                    }
                    else
                    {
                        row1.descuento_porcentaje = 0;
                    }

                    //Calculo del impuesto
                    row1.isv1 = row1.isv2 = row1.isv3 = 0;
                    Impuesto impuesto = new Impuesto();
                    decimal tasaISV = 0;

                    if (impuesto.RecuperarRegistro(pt1.Id_isv_aplicable))
                    {
                        tasaISV = impuesto.Valor / 100;

                        //row1.isv1 = (row1.precio - row1.descuento) * tasaISV;
                        decimal isv_calculo = (row1.precio - row1.descuento) - ((row1.precio - row1.descuento) / (1 + tasaISV));
                        row1.isv1 = isv_calculo;
                        row1.precio = (row1.precio - row1.descuento) - isv_calculo;

                        row1.tasa_isv = tasaISV;
                        row1.id_isv_aplicable = impuesto.Id;
                        row1.total_linea = row1.cantidad * ((row1.precio - row1.descuento) + isv_calculo);
                    }
                    else
                    {
                        row1.tasa_isv = 0;
                        row1.id_isv_aplicable = 0;
                        //row1.precio = (row1.precio - row1.descuento);
                        row1.isv1 = 0;
                    }

                    row1.total_linea =  (row1.cantidad * (row1.precio - row1.descuento)) + 
                                        (row1.cantidad * row1.isv1) + 
                                        (row1.cantidad * row1.isv2) + 
                                        (row1.cantidad * row1.isv3);

                    int IdBodega_ = 0;
                    string BodegaName_ = "N/D";
                    decimal Cantidad_ = 0;
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        con.Open();

                        SqlCommand cmd = new SqlCommand("dbo.[sp_get_cantidad_inv_kardex_pt_for_elejir_stock]", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_pt", row1.id_pt);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            IdBodega_ = dr.GetInt32(0);
                            BodegaName_ = dr.GetString(1);
                            Cantidad_ = dr.GetDecimal(2);
                            row1.inventario = invTotal;
                            row1.inventario_seleccionado = 1;
                            row1.bodega_descripcion = BodegaName_;
                        }
                        else
                        {
                            row1.inventario =
                            row1.inventario_seleccionado = 0;
                        }
                        dr.Close();


                        if (AddDistribucionAlmacen)
                        {
                            AgregarDetalleInventarioSeleccionado(row1.id_pt, IdBodega_, BodegaName_,
                                                                 1, pt1.Id_presentacion, row1.precio, row1.descuento,
                                                                 pt1.Code, pt1.Descripcion, row1.isv1, row1.descuento_porcentaje, 
                                                                 row1.marca, row1.entrega_almacen_bit);

                            //Buscamos el detalle en la seleccion de stock
                            foreach (dsVentas.detalle_factura_transaccion_invRow RowInv in dsVentas1.detalle_factura_transaccion_inv)
                            {
                                if (RowInv.id_pt == row1.id_pt)
                                {
                                    RowInv.descuento = row1.descuento;
                                    RowInv.descuento_porcentaje = row1.descuento_porcentaje;
                                }
                            }
                        }
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }



                    dsVentas1.detalle_factura_transaction.Adddetalle_factura_transactionRow(row1);
                    valor_total += (row1.total_linea);// + row1.isv1);
                    txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(valor_total, 2));

                    dsVentas1.AcceptChanges();

                    if (dsVentas1.detalle_factura_transaction.Count > 0)
                        gridView1.FocusedRowHandle = dsVentas1.detalle_factura_transaction.Count - 1;
                    else
                        gridView1.FocusedRowHandle = 0;


                    gridView1.FocusedColumn = colcantidad;
                    gridView1.ShowEditor();
                }
            }
        }
        private void AgregarProductoUsadoA_Prefactura(int pIdPT, string pItemCode, string pItemName,
                                                 decimal pCantidad, bool AddDistribucionAlmacen,
                                                 decimal pDescuentoPorcentaje, ProductoUsado pProductoUsado
                                                 , string pMarca)
        {
            ProductoUsado pt1;
            if (pProductoUsado == null)
                pt1 = new ProductoUsado();
            else
                pt1 = pProductoUsado;


            if (!pt1.Recuperado)
                pt1.RecuperarRegistro(pIdPT);


            if (pt1.Id > 0)
            {

                decimal valor_total = 0;

                bool AgregarNuevo = true;
                foreach (dsVentas.detalle_factura_transactionRow rowF in dsVentas1.detalle_factura_transaction)
                {
                    if (rowF.id_pt == pIdPT)
                    {
                        //Sumar cantidad nada mas

                        rowF.inventario = pt1.Recuperar_Cant_Inv_Actual_PT_for_facturacionUsados(pt1.Id, this.PuntoDeVentaActual.ID);


                        rowF.cantidad = rowF.cantidad + 1;
                        rowF.codigo_referencia = pt1.Barcode;
                        rowF.isv1 = rowF.isv2 = rowF.isv3 = 0;
                        rowF.isv1 = ((rowF.cantidad * rowF.precio) - rowF.descuento) * rowF.tasa_isv;
                        rowF.total_linea = ((rowF.cantidad * rowF.precio) - rowF.descuento) + rowF.isv1 + rowF.isv2 + rowF.isv3;
                        AgregarNuevo = false;
                    }
                    //valor_total += (rowF.total_linea + rowF.isv1);
                    valor_total += rowF.total_linea;
                    txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(valor_total, 2));
                }

                if (AgregarNuevo)
                {
                    dsVentas.detalle_factura_transactionRow row1 = dsVentas1.detalle_factura_transaction.Newdetalle_factura_transactionRow();
                    row1.id_pt = pIdPT;
                    row1.cantidad = pCantidad;
                    row1.descuento =
                    row1.descuento_porcentaje = 0;
                    row1.codigo_referencia = pt1.Barcode;
                    row1.marca = "N/D";
                    //row1.precio = PuntoDeVentaActual.RecuperarPrecioItem(row1.id_pt, PuntoDeVentaActual.ID, this.ClienteFactura.Id);
                    row1.precio = pt1.PrecioVenta;
                    //row1.id_presentacion = pt1.Id_presentacion;
                    row1.entrega_almacen_bit = false;

                    if (row1.precio == 0)
                    {
                        SetErrorBarra("Este producto no tiene definido un precio. Por favor valide Lista de Precios!");
                        return;
                    }


                    row1.itemcode = pItemCode;
                    row1.itemname = pItemName;
                    decimal invTotal = pt1.Recuperar_Cant_Inv_Actual_PT_for_facturacionUsados(pt1.Id, this.PuntoDeVentaActual.ID);

                    //Recalculamos el Descuento si hay alguno
                    if (pDescuentoPorcentaje > 0 && pDescuentoPorcentaje < 100)
                    {
                        decimal vDescuento = pDescuentoPorcentaje;

                        decimal vPorcentajeDescuento = PuntoDeVentaActual.RecuperarMaximoDescuentoItem(pt1.Id, PuntoDeVentaActual.ID, this.ClienteFactura.Id);

                        if (vDescuento > vPorcentajeDescuento)
                        {
                            row1.descuento = row1.descuento_porcentaje = 0;
                            //CajaDialogo.Error("No se permite un descuento mayor al permitido!");
                            return;
                        }

                        row1.descuento_porcentaje = vDescuento;
                        decimal vDescuentoLinea = ((row1.cantidad * row1.precio) * (vDescuento / 100));
                        row1.descuento = vDescuentoLinea;


                    }
                    else
                    {
                        row1.descuento_porcentaje = 0;
                    }

                    //Calculo del impuesto
                    row1.isv1 = row1.isv2 = row1.isv3 = 0;
                    Impuesto impuesto = new Impuesto();
                    decimal tasaISV = 0;

                    //if (impuesto.RecuperarRegistro(pt1.Id_isv_aplicable))
                    //{
                    //    tasaISV = impuesto.Valor / 100;

                    //    //row1.isv1 = (row1.precio - row1.descuento) * tasaISV;
                    //    decimal isv_calculo = (row1.precio - row1.descuento) - ((row1.precio - row1.descuento) / (1 + tasaISV));
                    //    row1.isv1 = isv_calculo;
                    //    row1.precio = (row1.precio - row1.descuento) - isv_calculo;

                    //    row1.tasa_isv = tasaISV;
                    //    row1.id_isv_aplicable = impuesto.Id;
                    //    row1.total_linea = row1.cantidad * ((row1.precio - row1.descuento) + isv_calculo);
                    //}
                    //else
                    //{
                    //    row1.tasa_isv = 0;
                    //    row1.id_isv_aplicable = 0;
                    //    //row1.precio = (row1.precio - row1.descuento);
                    //    row1.isv1 = 0;
                    //}

                    row1.tasa_isv = 0;
                    row1.id_isv_aplicable = 0;
                    //row1.precio = (row1.precio - row1.descuento);
                    row1.isv1 = 0;

                    row1.total_linea = (row1.cantidad * (row1.precio - row1.descuento)) +
                                        (row1.cantidad * row1.isv1) +
                                        (row1.cantidad * row1.isv2) +
                                        (row1.cantidad * row1.isv3);

                    int IdBodega_ = 0;
                    string BodegaName_ = "N/D";
                    decimal Cantidad_ = 0;


                    //try
                    //{
                    //    DataOperations dp = new DataOperations();
                    //    SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    //    con.Open();

                    //    SqlCommand cmd = new SqlCommand("dbo.[sp_get_cantidad_inv_kardex_pt_for_elejir_stock]", con);
                    //    cmd.CommandType = CommandType.StoredProcedure;
                    //    cmd.Parameters.AddWithValue("@id_pt", row1.id_pt);
                    //    SqlDataReader dr = cmd.ExecuteReader();
                    //    if (dr.Read())
                    //    {
                    //        IdBodega_ = dr.GetInt32(0);
                    //        BodegaName_ = dr.GetString(1);
                    //        Cantidad_ = dr.GetDecimal(2);
                    //        row1.inventario = invTotal;
                    //        row1.inventario_seleccionado = 1;
                    //        row1.bodega_descripcion = BodegaName_;
                    //    }
                    //    else
                    //    {
                    //        row1.inventario =
                    //        row1.inventario_seleccionado = 0;
                    //    }
                    //    dr.Close();


                    //    if (AddDistribucionAlmacen)
                    //    {
                    //        AgregarDetalleInventarioSeleccionado(row1.id_pt, IdBodega_, BodegaName_,
                    //                                             1, pt1.Id_presentacion, row1.precio, row1.descuento,
                    //                                             pt1.Code, pt1.Descripcion, row1.isv1, row1.descuento_porcentaje, row1.marca);

                    //        //Buscamos el detalle en la seleccion de stock
                    //        foreach (dsVentas.detalle_factura_transaccion_invRow RowInv in dsVentas1.detalle_factura_transaccion_inv)
                    //        {
                    //            if (RowInv.id_pt == row1.id_pt)
                    //            {
                    //                RowInv.descuento = row1.descuento;
                    //                RowInv.descuento_porcentaje = row1.descuento_porcentaje;
                    //            }
                    //        }
                    //    }
                    //}
                    //catch (Exception ec)
                    //{
                    //    CajaDialogo.Error(ec.Message);
                    //}

                    row1.inventario =1;
                    row1.id_bodega = 2;
                    row1.bodega_descripcion = "BG002";
                    dsVentas1.detalle_factura_transaction.Adddetalle_factura_transactionRow(row1);
                    valor_total += (row1.total_linea);// + row1.isv1);
                    txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(valor_total, 2));

                    dsVentas1.AcceptChanges();

                    if (dsVentas1.detalle_factura_transaction.Count > 0)
                        gridView1.FocusedRowHandle = dsVentas1.detalle_factura_transaction.Count - 1;
                    else
                        gridView1.FocusedRowHandle = 0;


                    gridView1.FocusedColumn = colcantidad;
                    gridView1.ShowEditor();
                }
            }
        }




        private void AgregarProductoA_PrefacturaUsados(int pIdUsado, string pItemCode, string pItemName,
                                                       decimal pCantidad, bool AddDistribucionAlmacen,
                                                       decimal pDescuentoPorcentaje, ProductoTerminado pProductoTerminado,
                                                       string pMarca)
        {
            ProductoUsado pt1 = new ProductoUsado();
            if (pt1.RecuperarRegistro(pIdUsado))
            {

                decimal valor_total = 0;

                bool AgregarNuevo = true;
                foreach (dsVentas.detalle_factura_transactionRow rowF in dsVentas1.detalle_factura_transaction)
                {
                    if (rowF.id_pt == pIdUsado)
                    {
                        //Sumar cantidad nada mas

                        rowF.inventario = pt1.Recuperar_Cant_Inv_Actual_PT_for_facturacionUsados(pt1.Id, this.PuntoDeVentaActual.ID);


                        //rowF.id_pt_usado = pt1.Id;
                        rowF.cantidad = rowF.cantidad + 1;
                        rowF.codigo_referencia = "N/D";
                        rowF.isv1 = rowF.isv2 = rowF.isv3 = 0;
                        rowF.isv1 = ((rowF.cantidad * rowF.precio) - rowF.descuento) * rowF.tasa_isv;
                        rowF.total_linea = ((rowF.cantidad * rowF.precio) - rowF.descuento) + rowF.isv1 + rowF.isv2 + rowF.isv3;
                        AgregarNuevo = false;
                    }
                    //valor_total += (rowF.total_linea + rowF.isv1);
                    valor_total += rowF.total_linea;
                    txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(valor_total, 2));
                }

                if (AgregarNuevo)
                {
                    dsVentas.detalle_factura_transactionRow row1 = dsVentas1.detalle_factura_transaction.Newdetalle_factura_transactionRow();
                    row1.id_pt = pIdUsado;
                    row1.cantidad = pCantidad;
                    row1.descuento =
                    row1.descuento_porcentaje = 0;
                    row1.codigo_referencia = "N/D";
                    row1.marca = "N/D";
                    //row1.precio = PuntoDeVentaActual.RecuperarPrecioItem(row1.id_pt, PuntoDeVentaActual.ID, this.ClienteFactura.Id);
                    row1.precio = pt1.PrecioVenta;
                    row1.id_presentacion = 1;// pt1.Id_presentacion;
                    row1.entrega_almacen_bit = false;

                    if (row1.precio == 0)
                    {
                        SetErrorBarra("Este producto no tiene definido un precio. Por favor valide Lista de Precios!");
                        return;
                    }


                    row1.itemcode = pItemCode;
                    row1.itemname = pItemName;
                    decimal invTotal = pt1.Recuperar_Cant_Inv_Actual_PT_for_facturacionUsados(pt1.Id, this.PuntoDeVentaActual.ID);
                    // pt1.Recuperar_Cant_Inv_Actual_PT_for_facturacion(pt1.Id, this.PuntoDeVentaActual.ID);

                    //Recalculamos el Descuento si hay alguno
                    if (pDescuentoPorcentaje > 0 && pDescuentoPorcentaje < 100)
                    {
                        decimal vDescuento = pDescuentoPorcentaje;

                        //decimal vPorcentajeDescuento = PuntoDeVentaActual.RecuperarMaximoDescuentoItem(pt1.Id, PuntoDeVentaActual.ID, this.ClienteFactura.Id);
                        decimal vPorcentajeDescuento = 0;

                        if (vDescuento > vPorcentajeDescuento)
                        {
                            row1.descuento = row1.descuento_porcentaje = 0;
                            //CajaDialogo.Error("No se permite un descuento mayor al permitido!");
                            return;
                        }

                        row1.descuento_porcentaje = vDescuento;
                        decimal vDescuentoLinea = ((row1.cantidad * row1.precio) * (vDescuento / 100));
                        row1.descuento = vDescuentoLinea;


                    }
                    else
                    {
                        row1.descuento_porcentaje = 0;
                    }

                    //Calculo del impuesto
                    row1.isv1 = row1.isv2 = row1.isv3 = 0;
                    Impuesto impuesto = new Impuesto();
                    decimal tasaISV = 0;

                    //if (impuesto.RecuperarRegistro(pt1.Id_isv_aplicable))
                    //{
                    //    tasaISV = impuesto.Valor / 100;

                    //    //row1.isv1 = (row1.precio - row1.descuento) * tasaISV;
                    //    decimal isv_calculo = (row1.precio - row1.descuento) - ((row1.precio - row1.descuento) / (1 + tasaISV));
                    //    row1.isv1 = isv_calculo;
                    //    row1.precio = (row1.precio - row1.descuento) - isv_calculo;

                    //    row1.tasa_isv = tasaISV;
                    //    row1.id_isv_aplicable = impuesto.Id;
                    //    row1.total_linea = row1.cantidad * (row1.precio + isv_calculo);
                    //}
                    //else
                    //{
                    //    row1.tasa_isv = 0;
                    //    row1.id_isv_aplicable = 0;
                    //    //row1.precio = (row1.precio - row1.descuento);
                    //    row1.isv1 = 0;
                    //}

                    row1.tasa_isv = 0;
                    row1.id_isv_aplicable = 0;
                    //row1.precio = (row1.precio - row1.descuento);
                    row1.isv1 = 0;

                    row1.total_linea = ((row1.cantidad * row1.precio) - row1.descuento) +
                                        (row1.cantidad * row1.isv1) +
                                        (row1.cantidad * row1.isv2) +
                                        (row1.cantidad * row1.isv3);


                    int IdBodega_ = 2;
                    string BodegaName_ = "BG002 - ALMACEN DE USADOS";
                    decimal Cantidad_ = 1;
                    row1.inventario = invTotal;
                    row1.inventario_seleccionado = 1;
                    row1.bodega_descripcion = BodegaName_;

                    if (AddDistribucionAlmacen)
                    {
                        AgregarDetalleInventarioSeleccionado(row1.id_pt, IdBodega_, BodegaName_,
                                                             1, 1, row1.precio, row1.descuento,
                                                             pt1.ItemCode, pt1.Descripcion, row1.isv1, 
                                                             row1.descuento_porcentaje, row1.marca,
                                                             row1.entrega_almacen_bit);

                        //Buscamos el detalle en la seleccion de stock
                        foreach (dsVentas.detalle_factura_transaccion_invRow RowInv in dsVentas1.detalle_factura_transaccion_inv)
                        {
                            if (RowInv.id_pt == row1.id_pt)
                            {
                                RowInv.descuento = row1.descuento;
                                RowInv.descuento_porcentaje = row1.descuento_porcentaje;
                            }
                        }
                    }





                    dsVentas1.detalle_factura_transaction.Adddetalle_factura_transactionRow(row1);
                    valor_total += (row1.total_linea);// + row1.isv1);
                    txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(valor_total, 2));

                    dsVentas1.AcceptChanges();

                    if (dsVentas1.detalle_factura_transaction.Count > 0)
                        gridView1.FocusedRowHandle = dsVentas1.detalle_factura_transaction.Count - 1;
                    else
                        gridView1.FocusedRowHandle = 0;


                    gridView1.FocusedColumn = colcantidad;
                    gridView1.ShowEditor();
                }

            }




        }




        private void cmdConsumidorFinal_Click(object sender, EventArgs e)
        {
            txtNombreCliente.Text = "Consumidor Final";
            txtRTN.Text =  
            txtDireccion.Text = string.Empty;

            txtDireccion.Properties.NullText = 
            txtRTN.Properties.NullText = "No Aplica";

            ClienteFactura = new ClienteFacturacion();
            ClienteFactura.Recuperado = false;
            ClienteFactura.ClearClass();
            txtScanProducto.Focus();
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

                //foreach(dsVentas.detalle_factura_transaccion_invRow rowi in dsVentas1.detalle_factura_transaccion_inv.Rows)
                //for (int h = 0; h < dsVentas1.detalle_factura_transaccion_inv.Rows.Count; h++)
                //{

                //}

                //for (int h = 0; h < dsVentas1.detalle_factura_transaccion_inv.Rows.Count; h++)
                //{
                //    dsVentas.detalle_factura_transaccion_invRow rowDel = dsVentas1.detalle_factura_transaccion_inv[h];

                //    if (rowDel.id_pt == row.id_pt)
                //    {
                //        //dsVentas1.detalle_factura_transaccion_inv[h].Delete();
                //        //h = dsVentas1.detalle_factura_transaccion_inv.Count;
                //        rowDel.Delete();
                //        dsVentas1.AcceptChanges();
                //    }
                //}

                //Nueva funcion de elminar 
                int idPT_Eliminar = row.id_pt; // ID que quieres eliminar

                // Buscar las filas que coincidan con el ID
                DataRow[] filas = dsVentas1.detalle_factura_transaccion_inv.Select($"id_pt = {idPT_Eliminar}");

                // Eliminar cada fila encontrada
                foreach (DataRow fila in filas)
                {
                    dsVentas1.detalle_factura_transaccion_inv.Rows.Remove(fila);
                }

                //Eliminamos el registro padre 
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                dsVentas1.AcceptChanges();
                //detalle_factura_transaction
                int count = dsVentas1.detalle_factura_transaction.Count;
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
                    txtScanProducto.Focus();
                    break;
                case "descuento":
                    decimal vDescuento = dp.ValidateNumberDecimal(e.Value);

                    if (vDescuento <= 0)
                    {
                        row.descuento = row.descuento_porcentaje = 0;
                        CajaDialogo.Error("No se permite valores menores a cero (0)!");
                        return;
                    }

                    if (vDescuento > 99)
                    {
                        row.descuento = row.descuento_porcentaje = 0;
                        CajaDialogo.Error("No se permite valores mayores a noventa y nueve (99)!");
                        return;
                    }


                    decimal vPorcentajeDescuento = PuntoDeVentaActual.RecuperarMaximoDescuentoItem(row.id_pt, PuntoDeVentaActual.ID, this.ClienteFactura.Id);

                    if (vDescuento > vPorcentajeDescuento)
                    {
                        row.descuento = row.descuento_porcentaje = 0;
                        CajaDialogo.Error("No se permite un descuento mayor al permitido!");
                        return;
                    }

                    row.descuento_porcentaje = vDescuento;
                    decimal vDescuentoLinea = ((row.cantidad * row.precio) * (vDescuento / 100));
                    row.descuento = vDescuentoLinea;

                    foreach(dsVentas.detalle_factura_transaccion_invRow RowInv in dsVentas1.detalle_factura_transaccion_inv)
                    {
                        if(RowInv.id_pt == row.id_pt)
                        {
                            RowInv.descuento = row.descuento;
                            RowInv.descuento_porcentaje = row.descuento_porcentaje;
                        }
                    }
                    //recalculamos 
                    CalcularTotalFactura();
                    txtScanProducto.Focus();
                    break;
                case "precio":
                    row.total_linea = (row.cantidad * (row.precio - row.descuento)); 
                    CalcularTotalFactura();
                    txtScanProducto.Focus();
                    break;
                case "entrega_almacen_bit":
                    foreach (dsVentas.detalle_factura_transaccion_invRow RowInv in dsVentas1.detalle_factura_transaccion_inv)
                    {
                        if (RowInv.id_pt == row.id_pt)
                        {
                            RowInv.entrega_almacen_bit = row.entrega_almacen_bit;
                            if (RowInv.entrega_almacen_bit)
                            {
                                RowInv.id_bodega = 3;//BG003
                            }
                        }
                    }
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
                //row.total_linea = row.total_linea + (row.cantidad * row.isv1) + (row.cantidad * row.isv2) + (row.cantidad * row.isv3);
                
                //Recalculamos impuestos

                row.total_linea = ((row.cantidad * row.precio) - row.descuento) + 
                                   (row.cantidad * row.isv1) + 
                                   (row.cantidad * row.isv2) + 
                                   (row.cantidad * row.isv3);

                total += row.total_linea;    
            }

            txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(total,2));
            return total;
        }

        private void txtScanProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtScanProducto.Text)) return;
                //errorProvLecturaCodigo.Clear();

                if (TipoFacturacionActual == TipoFacturacionStock.VentaNormal)
                {
                    ProductoTerminado pt1 = new ProductoTerminado();
                    if (pt1.Recuperar_productoByBarCode(txtScanProducto.Text))
                    {
                        AgregarProductoA_Prefactura(pt1.Id, pt1.Code, pt1.Descripcion, 1, true, 0, pt1, pt1.MarcaName);

                        gridView1.RefreshData();
                        int newRowHandle = gridView1.RowCount - 1;
                        gridView1.FocusedRowHandle = newRowHandle;

                        if (ckEscaner.Checked == false)
                        {
                            if (dsVentas1.detalle_factura_transaction.Rows.Count > 0)
                            {
                                cmdElejirAlmacen_ButtonClick(cmdElejirAlmacen, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(cmdElejirAlmacen.Buttons[0]));
                            }
                        }

                        txtScanProducto.Text = "";
                        txtScanProducto.Focus();
                    }
                    else
                    {
                        //Set error
                        //errorProvLecturaCodigo.SetError(txtScanProducto, "No se encontró el código escaneado!");
                        SetErrorBarra("No se encontró el código escaneado!");
                        txtScanProducto.Text = "";
                        txtScanProducto.Focus();
                        timerLimpiarMensaje.Enabled = true;
                        timerLimpiarMensaje.Start();
                    }
                }
                else
                {
                    //Usados
                    ProductoUsado pt1 = new ProductoUsado();
                    if (pt1.RecuperarRegistro(txtScanProducto.Text))
                    {
                        AgregarProductoUsadoA_Prefactura(pt1.Id, pt1.Barcode, pt1.Descripcion, 1, true, 0, pt1, "N/D");

                        gridView1.RefreshData();
                        int newRowHandle = gridView1.RowCount - 1;
                        gridView1.FocusedRowHandle = newRowHandle;

                        //if (ckEscaner.Checked == false)
                        //{
                        //    if (dsVentas1.detalle_factura_transaction.Rows.Count > 0)
                        //    {
                        //        cmdElejirAlmacen_ButtonClick(cmdElejirAlmacen, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(cmdElejirAlmacen.Buttons[0]));
                        //    }
                        //}

                        txtScanProducto.Text = "";
                        txtScanProducto.Focus();
                    }
                    else
                    {
                        //Set error
                        //errorProvLecturaCodigo.SetError(txtScanProducto, "No se encontró el código escaneado!");
                        SetErrorBarra("No se encontró el código escaneado!");
                        txtScanProducto.Text = "";
                        txtScanProducto.Focus();
                        timerLimpiarMensaje.Enabled = true;
                        timerLimpiarMensaje.Start();
                    }
                }
            }
        }

        private void rdContado_CheckedChanged(object sender, EventArgs e)
        {
            //if (rdContado.Checked)
            //{
            //    rdCredito.CheckedChanged -= new EventHandler(rdCredito_CheckedChanged); 
            //    rdCredito.Checked = false;
            //    IdTerminoPago = 1;
            //    gleTipoPago.Enabled =
            //    gleBanco.Enabled =
            //    txtReferenciaPago.Enabled = true;
            //    rdCredito.CheckedChanged += new EventHandler(rdCredito_CheckedChanged);
            //}
        }

        private void rdCredito_CheckedChanged(object sender, EventArgs e)
        {
            //if (rdCredito.Checked)
            //{
            //    rdContado.CheckedChanged -= new EventHandler(rdContado_CheckedChanged);
            //    rdContado.Checked = false;
            //    IdTerminoPago = 2;
            //    gleTipoPago.Enabled =
            //    gleBanco.Enabled =
            //    txtReferenciaPago.Enabled = false;
            //    rdContado.CheckedChanged += new EventHandler(rdContado_CheckedChanged);
            //}
        }

        private void AgregarDetalleInventarioSeleccionado(int id_pt, int idBodega_, string bodegaName_, decimal cantidad_, 
                                                          int pIdPresentacion, decimal pPrecio, decimal pDescuento,
                                                          string pItemCode, string pItemName, decimal isv1, 
                                                          decimal pDescuentoPorcentaje, string pMarca, bool pEntregaAlmacenUsados)
        {
            dsVentas.detalle_factura_transaccion_invRow row = dsVentas1.detalle_factura_transaccion_inv.Newdetalle_factura_transaccion_invRow();
            row.id_pt = id_pt;
            row.id_bodega = idBodega_;
            row.cantidad = cantidad_;
            row.chequeado = true;
            row.bodega_descripcion = bodegaName_;
            row.precio = pPrecio;
            row.descuento = pDescuento;
            row.id_presentacion = pIdPresentacion;
            row.item_code = pItemCode;
            row.descripcion = pItemName;
            row.isv1 = isv1;
            row.marca = pMarca;
            row.descuento_porcentaje = pDescuentoPorcentaje;
            row.entrega_almacen_bit = pEntregaAlmacenUsados;
            dsVentas1.detalle_factura_transaccion_inv.Adddetalle_factura_transaccion_invRow(row);
            dsVentas1.AcceptChanges();
        }
        private decimal AgregarDetalleInventarioSeleccionadoList(ArrayList pListaSelected, int pIdPT_row)
        {
            string LabelAlmacenesMix = "";
            int conta = 0;
            decimal cantidad = 0;

            //Desmarcamos toda la seleccion para limipiar y sobre escribir la nueva seleccion
            foreach (dsVentas.detalle_factura_transaccion_invRow rowi in dsVentas1.detalle_factura_transaccion_inv.Rows)
            {
                if (pIdPT_row == rowi.id_pt)
                {
                    rowi.chequeado = false;
                    rowi.cantidad = 0;
                }
            }

            
            foreach (ElejirInvAlmacen i in pListaSelected)//Iteramos la lista de selecciones
            {
                bool encontrado = false;

                foreach (dsVentas.detalle_factura_transaccion_invRow rowi in dsVentas1.detalle_factura_transaccion_inv.Rows)//Iteramos a ver los items pendientes
                {
                    if (rowi.id_bodega == i.IdBodega && rowi.id_pt == i.id_pt)
                    {
                        rowi.cantidad = i.CantSeleccionada;
                        encontrado = true;
                    }
                }

                if (!encontrado)
                {
                    if (i.CantSeleccionada > 0)
                    {
                        dsVentas.detalle_factura_transaccion_invRow row = dsVentas1.detalle_factura_transaccion_inv.Newdetalle_factura_transaccion_invRow();
                        row.id_pt = i.id_pt;
                        row.id_bodega = i.IdBodega;
                        row.cantidad = i.CantSeleccionada;
                        row.bodega_descripcion = i.BodegaName;
                        row.chequeado = true;
                        row.precio = i.Precio;
                        row.descuento = i.descuento;
                        row.id_presentacion = i.id_presentacion;
                        row.item_code = i.ItemCode;
                        row.descripcion = i.Descripcion;
                        row.isv1 = i.isv1;
                        row.descuento_porcentaje = i.descuento_porcentaje;
                        row.marca = i.marca;
                        row.entrega_almacen_bit = i.entrega_almacen_bit;
                        dsVentas1.detalle_factura_transaccion_inv.Adddetalle_factura_transaccion_invRow(row);
                        dsVentas1.AcceptChanges();
                    }
                }


                if (conta == 0)
                {
                    LabelAlmacenesMix = i.BodegaName;
                    conta++;
                }
                else
                {
                    LabelAlmacenesMix += ", " + i.BodegaName;
                    conta++;
                }
                cantidad += i.CantSeleccionada;
            }


            var gridView = (GridView)gridControl1.FocusedView;
            var row1 = (dsVentas.detalle_factura_transactionRow)gridView.GetFocusedDataRow();
            row1.bodega_descripcion = LabelAlmacenesMix;
            return cantidad;
        }

        private void cmdElejirAlmacen_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ElejirAlmacen();
        }

        void ElejirAlmacen()
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsVentas.detalle_factura_transactionRow)gridView.GetFocusedDataRow();
            ArrayList ListaActual = new ArrayList();

            //Vamos a iterar la distribucion que contenga el item actual
            foreach (dsVentas.detalle_factura_transaccion_invRow rowi in dsVentas1.detalle_factura_transaccion_inv.Rows)//Iteramos a ver los items pendientes
            {
                if (row.id_pt == rowi.id_pt)
                {
                    ElejirInvAlmacen item = new ElejirInvAlmacen();
                    item.id_pt = rowi.id_pt;

                    if (rowi.Isid_bodegaNull())
                        item.IdBodega = 0;
                    else
                        item.IdBodega = rowi.id_bodega;


                    if (rowi.Isbodega_descripcionNull())
                        item.BodegaName = string.Empty;
                    else
                        item.BodegaName = rowi.bodega_descripcion;

                    item.CantSeleccionada = rowi.cantidad;

                    if (!rowi.IsdescuentoNull())
                        item.descuento = rowi.descuento;

                    if(!rowi.Isdescuento_porcentajeNull())
                        item.descuento_porcentaje = rowi.descuento_porcentaje;

                    if (!rowi.IsprecioNull())
                        item.Precio = rowi.precio;

                    if (!rowi.Isid_presentacionNull())
                        item.id_presentacion = rowi.id_presentacion;

                    if (!rowi.Isitem_codeNull())
                        item.ItemCode = rowi.item_code;

                    if(!rowi.IsdescripcionNull())
                        item.Descripcion = rowi.descripcion;

                    if(!rowi.IsmarcaNull())
                        item.marca = rowi.marca;
                    
                    if(!rowi.Isisv1Null())
                        item.isv1 = rowi.isv1;

                    if (!rowi.Isentrega_almacen_bitNull())
                        item.entrega_almacen_bit = rowi.entrega_almacen_bit;

                    ListaActual.Add(item);
                }
            }

            bool isUsados = false;
            if (TipoFacturacionActual == TipoFacturacionStock.VentaUsados)
                isUsados = true;

            frmElejirAlmacenPedidoOutStok frm = new frmElejirAlmacenPedidoOutStok(row.id_pt, row.itemcode + " - " +
                                                                              row.itemname, row.cantidad, ListaActual,
                                                                              row.descuento, row.precio, row.id_presentacion,
                                                                              row.itemcode, row.itemname, row.isv1, row.descuento_porcentaje, isUsados);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                row.inventario_seleccionado = row.cantidad = AgregarDetalleInventarioSeleccionadoList(frm.ListaSeleccionAlmacen, row.id_pt);
                row.total_linea = (row.cantidad * row.precio) - row.descuento;
                //CalcularTotal();
                CalcularTotalFactura();
            }
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {

            //Validamos el nombre del cliente que no este vacio
            DataOperations dp = new DataOperations();
            if (dp.ValidateStringIsNullOrEmpty(txtNombreCliente.Text))
            {
                SetErrorBarra("No se puede crear la Pre Factura sin definir el nombre de cliente!");
                return;
            }

            //Validamos que la proforma sea mayor a cero 
            if (dp.ValidateNumberDecimal(txtTotal.Text) <= 0)
            {
                SetErrorBarra("No se permite generar la Pre Factura con valor total cero(0)!");
                return;
            }

            //Validar disponibilidad de Inventario si el punto de venta lo tiene configurado
            if (PuntoDeVentaActual.BloqueoPorFaltaStock)
            {
                foreach (dsVentas.detalle_factura_transactionRow row in dsVentas1.detalle_factura_transaction.Rows)
                {
                    if (row.inventario < row.cantidad)
                    {
                        SetErrorBarra("Esta intentando generar un pedido con un producto con menor existencia en Inventario!");
                        return;
                    }
                }
            }

            if (ckConfirmarPedido.Checked)
            {
                bool ItemSinInventario = false;
                foreach (dsVentas.detalle_factura_transactionRow row in dsVentas1.detalle_factura_transaction)
                {
                    if (row.inventario < row.cantidad)
                    {
                        ItemSinInventario = true;
                        break;
                    }
                }

                if (ItemSinInventario)
                {
                    CajaDialogo.Error("Hay productos que No tienen suficiente invetario.\n" +
                                      "Debe eliminar estos productos para poder confirmar la Pre Factura!");
                    ckConfirmarPedido.Checked = false;
                    return;
                }
            }


            //Valiadmos que se haya elejido un vendedor
            if (VendedorActual == null)
            {
                CajaDialogo.Error("Es necesario indicar el Vendedor!");
                return;
            }
            if (!VendedorActual.Recuperado)
            {
                CajaDialogo.Error("Es necesario indicar el Vendedor!");
                return;
            }

            bool ImprimirFactura = false;
            Factura facturaGenerada = null;

            //Efectuar que se haga la facturacion en dos pasos, primero la factura y luego el pago
            //if (PuntoDeVentaActual.EmisionFacturaDosPasos)
            //{
            //Factura factura = new Factura();
            PedidoCliente Pedido_ = new PedidoCliente();

            if (!string.IsNullOrEmpty(txtRTN.Text))
                Pedido_.RTN = txtRTN.Text;

            if (!string.IsNullOrEmpty(txtNombreCliente.Text))
                Pedido_.ClienteNombre = txtNombreCliente.Text;

            if (!string.IsNullOrEmpty(txtDireccion.Text))
                Pedido_.direccion_cliente = txtDireccion.Text;

            int IdClientePreFactura = 0;
            if (ClienteFactura != null)
            {
                if (ClienteFactura.Id > 0)
                {
                    IdClientePreFactura = 
                    Pedido_.IdCliente = ClienteFactura.Id;
                    if (PedidoActual != null)
                    {
                        Pedido_.IdEmpresa = PedidoActual.IdEmpresa;
                        Pedido_.IdCliente = PedidoActual.IdCliente;
                    }
                }
            }



            if(rdCredito.Checked && IdClientePreFactura == 0)
            {
                //CajaDialogo.Error("Para una Pre Factura al Crédito, es necesario buscar el codigo de cliente!");
                SetErrorBarra("Para una Pre Factura al Crédito es necesario buscar el código de cliente!");
                return;
            }

            Pedido_.FechaDocumento = dp.NowSetDateTime();
            //1   Emitida
            //2   Pagada
            //3   Anulada
            Pedido_.IdEstado = 1;//Creado
            Pedido_.IdUser = this.UsuarioLogeado.Id;
            Pedido_.IdPuntoVenta = this.PuntoDeVentaActual.ID;
            Pedido_.Enable = true;
            int correlativoSiguiente = 0;
            //int id_numeracion = 0;


            //Vamos por el detalle de lineas para el Pedido y la transaccion
            switch (TipoOperacionActual)
            {
                case TipoOperacionSQL.Insert:
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
                            //Guardamos el Header del Pedido 
                            //command.CommandText = "[dbo].[sp_set_insert_pedido_header]";
                            command.CommandText = "[dbo].[sp_set_insert_pedido_header_v2]";
                            command.CommandType = CommandType.StoredProcedure;
                            
                            //command.Parameters.AddWithValue("@id_user", Pedido_.IdUser);


                            command.Parameters.AddWithValue("@fecha_documento", Pedido_.FechaDocumento);

                            if (Pedido_.IdCliente == 0)
                                command.Parameters.AddWithValue("@id_cliente", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@id_cliente", Pedido_.IdCliente);

                            if(Pedido_.IdEmpresa == 0)
                                command.Parameters.AddWithValue("@id_cliente_empresa", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@id_cliente_empresa", Pedido_.IdEmpresa);

                            if (string.IsNullOrEmpty(Pedido_.RTN))
                                command.Parameters.AddWithValue("@RTN", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@RTN", Pedido_.RTN);

                            command.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);
                            command.Parameters.AddWithValue("@cliente_nombre", Pedido_.ClienteNombre);

                            if (string.IsNullOrEmpty(Pedido_.direccion_cliente))
                                command.Parameters.AddWithValue("@direccion", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@direccion", Pedido_.direccion_cliente);

                            if (string.IsNullOrEmpty(txtComentario.Text))
                                command.Parameters.AddWithValue("@comentario", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@comentario", txtComentario.Text);



                            command.Parameters.AddWithValue("@fecha_entrega_estimada", dtFechaEntrega.DateTime);

                            if (VendedorActual != null)
                            {
                                if (VendedorActual.Id > 0)
                                {
                                    command.Parameters.AddWithValue("@id_vendedor", VendedorActual.Id);
                                    command.Parameters.AddWithValue("@id_user", VendedorActual.Id);
                                }
                                else
                                {
                                    command.Parameters.AddWithValue("@id_vendedor", DBNull.Value);
                                    command.Parameters.AddWithValue("@id_user", DBNull.Value);
                                }
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@id_vendedor", DBNull.Value);
                                command.Parameters.AddWithValue("@id_user", DBNull.Value);
                            }


                            int _id_estado = 6;//Nuevo

                            if (ckConfirmarPedido.Checked)
                                _id_estado = 1;//Confirmado 

                            command.Parameters.AddWithValue("@id_estado", _id_estado);
                            command.Parameters.AddWithValue("@id_termino_pago", IdTerminoPago);

                            int tipo_factura = 0;
                            if (TipoFacturacionActual == TipoFacturacionStock.VentaNormal)
                                tipo_factura = 1;
                            else
                                tipo_factura = 2;
                            
                            if(tipo_factura == 0)
                                command.Parameters.AddWithValue("@id_tipo_factura", 1);
                            else
                                command.Parameters.AddWithValue("@id_tipo_factura", tipo_factura);

                            Int64 IdPedidoH = Convert.ToInt64(command.ExecuteScalar());
                            decimal TotalFactura = 0;
                            Pedido_.Id = IdPedidoH;

                            //Posteamos lineas de la pre factura 
                            foreach (dsVentas.detalle_factura_transaccion_invRow row in dsVentas1.detalle_factura_transaccion_inv)
                            {
                                decimal descuentoLinea = 0;
                                decimal descuentoPorcentaje = 0;

                                if (row.IsdescuentoNull()) descuentoLinea = 0;
                                else descuentoLinea = row.descuento;

                                if (row.Isdescuento_porcentajeNull()) descuentoPorcentaje = 0;
                                else descuentoPorcentaje = row.descuento_porcentaje;

                                Int64 idPedidoDetalle = 0;

                                if (row.cantidad > 0)
                                {
                                    command.CommandText = "dbo.[sp_set_insert_pedido_cliente_lineas_v2]";
                                    command.Parameters.Clear();
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.AddWithValue("@id_pedidoH", IdPedidoH);
                                    command.Parameters.AddWithValue("@id_pt", row.id_pt);
                                    command.Parameters.AddWithValue("@item_code", row.item_code);
                                    command.Parameters.AddWithValue("@descripcion", row.descripcion);
                                    command.Parameters.AddWithValue("@cantidad", row.cantidad);
                                    command.Parameters.AddWithValue("@precio", row.precio);
                                    command.Parameters.AddWithValue("@descuento", descuentoLinea);
                                    command.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);
                                    command.Parameters.AddWithValue("@fecha_hora_row", Pedido_.FechaDocumento);
                                    command.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
                                    command.Parameters.AddWithValue("@id_presentacion", row.id_presentacion);

                                    if (TipoFacturacionActual == TipoFacturacionStock.VentaNormal)
                                    {
                                        if (row.id_bodega == 0)
                                            command.Parameters.AddWithValue("@id_bodega", DBNull.Value);
                                        else
                                            command.Parameters.AddWithValue("@id_bodega", row.id_bodega);

                                    }
                                    else
                                    {
                                        //Es usados
                                        if (row.id_bodega == 0)
                                        {
                                            if(row.entrega_almacen_bit)
                                                command.Parameters.AddWithValue("@id_bodega", 3);//BG003
                                            else
                                                command.Parameters.AddWithValue("@id_bodega", DBNull.Value);//NULL
                                        }
                                        else
                                        {
                                            command.Parameters.AddWithValue("@id_bodega", row.id_bodega);
                                        }
                                    }



                                    command.Parameters.AddWithValue("@isv", row.isv1);
                                    command.Parameters.AddWithValue("@descuento_porcentaje", descuentoPorcentaje);

                                    if (!row.IsmarcaNull())
                                    {
                                        if (!string.IsNullOrEmpty(row.marca))
                                        {
                                            command.Parameters.AddWithValue("@marca", row.marca);
                                        }
                                        else
                                        {
                                            command.Parameters.AddWithValue("@marca", DBNull.Value);
                                        }
                                    }
                                    else
                                    {
                                        command.Parameters.AddWithValue("@marca", DBNull.Value);
                                    }

                                    command.Parameters.AddWithValue("@entrega_bodega", row.entrega_almacen_bit);


                                    idPedidoDetalle = Convert.ToInt64(command.ExecuteScalar());
                                }

                                
                                //if (idPedidoDetalle > 0)
                                //{
                                //    //Guardamos la distribucion por almacen de cada detalle de la prefactura 
                                //    foreach (dsVentas.detalle_factura_transaccion_invRow rowA in dsVentas1.detalle_factura_transaccion_inv)
                                //    {
                                //        command.CommandText = "dbo.[sp_set_insert_detalle_cantidad_requerida_por_almacen_pre_factura]";
                                //        command.Parameters.Clear();
                                //        command.CommandType = CommandType.StoredProcedure;
                                //        command.Parameters.AddWithValue("@id_pedido_d", idPedidoDetalle);
                                //        command.Parameters.AddWithValue("@id_almacen", rowA.id_bodega);
                                //        command.Parameters.AddWithValue("@cantidad", rowA.cantidad);
                                //        command.ExecuteNonQuery();
                                //    }
                                //}

                                TotalFactura += (row.cantidad * row.precio) - row.descuento;
                            }


                            if (ckGenerarCotizacion.Checked)
                            {
                                //SqlCommand cmd = new SqlCommand("[dbo].[sp_InsertCotizacion]", con);
                                command.Parameters.Clear();
                                command.CommandText = "[dbo].[sp_InsertCotizacion]";
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@id_pedido", IdPedidoH);
                                command.Parameters.AddWithValue("@id_user", VendedorActual.Id);
                                command.ExecuteScalar();
                            }



                            ////Vamos a postear transaccion en estado de cuenta de cliente
                            //if (Pedido_.IdCliente > 0)
                            //{
                            //    command.CommandText = "dbo.[sp_set_insert_estado_cuenta_cliente_v6]";
                            //    command.CommandType = CommandType.StoredProcedure;
                            //    command.Parameters.Clear();
                            //    command.Parameters.AddWithValue("@id_pedidoH", IdPedidoH);
                            //    command.Parameters.AddWithValue("@enable", 1);
                            //    command.Parameters.AddWithValue("@credito", 0);//Abonos
                            //    command.Parameters.AddWithValue("@debito", TotalFactura);//cargos
                            //    command.Parameters.AddWithValue("@concepto", string.Concat("Por Pedido #", Pedido_.NumeroDocumento));
                            //    command.Parameters.AddWithValue("@doc_date", Pedido_.FechaDocumento);
                            //    command.Parameters.AddWithValue("@date_created", Pedido_.FechaDocumento);
                            //    command.Parameters.AddWithValue("@id_user_created", this.UsuarioLogeado.Id);
                            //    command.Parameters.AddWithValue("@id_cliente", Pedido_.IdCliente);
                            //    command.ExecuteNonQuery();

                            //    if (IdTerminoPago == 1)//Contado
                            //    {
                            //        command.CommandText = "dbo.[sp_set_insert_estado_cuenta_cliente_v7]";
                            //        command.CommandType = CommandType.StoredProcedure;
                            //        command.Parameters.Clear();
                            //        command.Parameters.AddWithValue("@id_pedidoH", IdPedidoH);
                            //        command.Parameters.AddWithValue("@enable", 1);
                            //        command.Parameters.AddWithValue("@credito", TotalFactura);//Abonos
                            //        command.Parameters.AddWithValue("@debito", 0);//cargos
                            //        command.Parameters.AddWithValue("@concepto", string.Concat("Pago de Pedido #", Pedido_.NumeroDocumento));
                            //        command.Parameters.AddWithValue("@doc_date", Pedido_.FechaDocumento);
                            //        command.Parameters.AddWithValue("@date_created", Pedido_.FechaDocumento);
                            //        command.Parameters.AddWithValue("@id_user_created", this.UsuarioLogeado.Id);
                            //        command.Parameters.AddWithValue("@id_cliente", Pedido_.IdCliente);

                            //        if (dp.ValidateNumberInt32(gleBanco.EditValue) == 0)
                            //            command.Parameters.AddWithValue("@id_cuenta_banco", DBNull.Value);
                            //        else
                            //            command.Parameters.AddWithValue("@id_cuenta_banco", Pedido_.IdCliente);

                            //        if (string.IsNullOrEmpty(txtReferenciaPago.Text))
                            //            command.Parameters.AddWithValue("@referencia", DBNull.Value);
                            //        else
                            //            command.Parameters.AddWithValue("@referencia", Pedido_.IdCliente);

                            //        command.ExecuteNonQuery();
                            //    }
                            //    //else
                            //    //{
                            //    //    //Crédito

                            //    //}
                            //}

                            // Attempt to commit the transaction.
                            transaction.Commit();

                            SetInformationBarra("Pre Factura Generada con Exito!");
                            dsVentas1.detalle_factura_transaccion_inv.Clear();
                            ImprimirFactura = true;
                            //facturaGenerada = Pedido_;

                            //Limpiar Datos
                            dsVentas1.detalle_factura_transaction.Clear();
                            ClienteFactura = new ClienteFacturacion();
                            //cmdConsumidorFinal_Click(sender, e);
                            cmdNew_Click(sender, e);
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
                    break;
                case TipoOperacionSQL.Update:
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
                            //Guardamos el Header del Pedido 
                            command.CommandText = "[dbo].[sp_set_update_pedido_header]";
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@id_user", Pedido_.IdUser);
                            command.Parameters.AddWithValue("@fecha_documento", Pedido_.FechaDocumento);

                            if (Pedido_.IdCliente == 0)
                                command.Parameters.AddWithValue("@id_cliente", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@id_cliente", Pedido_.IdCliente);

                            if (Pedido_.IdEmpresa == 0)
                                command.Parameters.AddWithValue("@id_cliente_empresa", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@id_cliente_empresa", Pedido_.IdEmpresa);

                            if (string.IsNullOrEmpty(Pedido_.RTN))
                                command.Parameters.AddWithValue("@RTN", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@RTN", Pedido_.RTN);

                            command.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);
                            command.Parameters.AddWithValue("@cliente_nombre", Pedido_.ClienteNombre);

                            if (string.IsNullOrEmpty(Pedido_.RTN))
                                command.Parameters.AddWithValue("@direccion", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@direccion", Pedido_.direccion_cliente);

                            if (string.IsNullOrEmpty(txtComentario.Text))
                                command.Parameters.AddWithValue("@comentario", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@comentario", txtComentario.Text);



                            command.Parameters.AddWithValue("@fecha_entrega_estimada", dtFechaEntrega.DateTime);
                            if (VendedorActual != null)
                            {
                                if (VendedorActual.Id > 0)
                                    command.Parameters.AddWithValue("@id_vendedor", VendedorActual.Id);
                                else
                                    command.Parameters.AddWithValue("@id_vendedor", DBNull.Value);
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@id_vendedor", DBNull.Value);
                            }

                            command.Parameters.AddWithValue("@id_h", PedidoActual.Id);
                            command.Parameters.AddWithValue("@id_termino_pago", IdTerminoPago);

                            Int64 IdPedidoH = Convert.ToInt64(command.ExecuteScalar());
                            decimal TotalFactura = 0;
                            Pedido_.Id = IdPedidoH;


                            //Limpiamos las lineas de detalle
                            command.CommandText = "dbo.[sp_set_clean_pedido_cliente_lineas]";
                            command.Parameters.Clear();
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@id_pedidoH", IdPedidoH);
                            command.ExecuteNonQuery();

                            //Posteamos lineas de la pre factura 
                            foreach (dsVentas.detalle_factura_transaccion_invRow row in dsVentas1.detalle_factura_transaccion_inv)
                            {
                                Int64 idPedidoDetalle = 0;
                                if (row.cantidad > 0)
                                {
                                    command.CommandText = "dbo.[sp_set_insert_pedido_cliente_lineas_v2]";
                                    command.Parameters.Clear();
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.AddWithValue("@id_pedidoH", IdPedidoH);
                                    command.Parameters.AddWithValue("@id_pt", row.id_pt);
                                    command.Parameters.AddWithValue("@item_code", row.item_code);
                                    command.Parameters.AddWithValue("@descripcion", row.descripcion);
                                    command.Parameters.AddWithValue("@cantidad", row.cantidad);
                                    command.Parameters.AddWithValue("@precio", row.precio);
                                    command.Parameters.AddWithValue("@descuento", row.descuento);
                                    command.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);
                                    command.Parameters.AddWithValue("@fecha_hora_row", Pedido_.FechaDocumento);
                                    command.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
                                    command.Parameters.AddWithValue("@id_presentacion", row.id_presentacion);

                                    //command.Parameters.AddWithValue("@id_bodega", row.id_bodega);
                                    if (row.Isid_bodegaNull())
                                    {
                                        command.Parameters.AddWithValue("@id_bodega", DBNull.Value);
                                    }
                                    else
                                    {
                                        if (row.id_bodega == 0)
                                            command.Parameters.AddWithValue("@id_bodega", DBNull.Value);
                                        else
                                            command.Parameters.AddWithValue("@id_bodega", row.id_bodega);
                                    }
                                    

                                    command.Parameters.AddWithValue("@isv", row.isv1);

                                    if(row.Isdescuento_porcentajeNull())
                                        command.Parameters.AddWithValue("@descuento_porcentaje", 0);
                                    else
                                        command.Parameters.AddWithValue("@descuento_porcentaje", dp.ValidateNumberDecimal(row.descuento_porcentaje));

                                    if (!row.IsmarcaNull())
                                    {
                                        if (!string.IsNullOrEmpty(row.marca))
                                        {
                                            command.Parameters.AddWithValue("@marca", row.marca);
                                        }
                                        else
                                        {
                                            command.Parameters.AddWithValue("@marca", DBNull.Value);
                                        }
                                    }
                                    else
                                    {
                                        command.Parameters.AddWithValue("@marca", DBNull.Value);
                                    }
                                    command.Parameters.AddWithValue("@entrega_bodega", row.entrega_almacen_bit);

                                    idPedidoDetalle = Convert.ToInt64(command.ExecuteScalar());
                                }

                                TotalFactura += (row.cantidad * row.precio) - row.descuento;
                            }

                            // Attempt to commit the transaction.
                            transaction.Commit();

                            SetInformationBarra("Pre Factura Generada con Exito!");
                            dsVentas1.detalle_factura_transaccion_inv.Clear();
                            ImprimirFactura = true;
                            //facturaGenerada = Pedido_;

                            //Limpiar Datos
                            dsVentas1.detalle_factura_transaction.Clear();
                            ClienteFactura = new ClienteFacturacion();
                            //cmdConsumidorFinal_Click(sender, e);
                            cmdNew_Click(sender, e);

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

                    break;
            }




            //if (ImprimirFactura)
            //{
            //    //rptFactura
            //    if (facturaGenerada != null)
            //    {
            //        if (facturaGenerada.RecuperarRegistro(facturaGenerada.Id))
            //        {
            //            if (!string.IsNullOrEmpty(facturaGenerada.NumeroDocumento))
            //            {
            //                if (facturaGenerada.Id > 0)
            //                {
            //                    if (facturaGenerada.RecuperarRegistro(facturaGenerada.Id))
            //                    {
            //                        switch (PuntoDeVentaActual.IdFormatoFactura)
            //                        {
            //                            case 1://3.5 pulg. cinta
            //                                rptFactura report = new rptFactura(facturaGenerada, rptFactura.TipoCopia.Blanco) { ShowPrintMarginsWarning = false };
            //                                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            //                                ReportPrintTool printReport = new ReportPrintTool(report);
            //                                //printReport.ShowPreviewDialog();
            //                                printReport.PrinterSettings.Copies = Convert.ToInt16(PuntoDeVentaActual.Cantidad_copiasFactura);
            //                                printReport.Print();
            //                                facturaGenerada.UpdatePrintCount(facturaGenerada.Id);
            //                                break;
            //                            case 2://8x11.5 pulg. Carta
            //                            default:
            //                                rptFacturaLetterSize reportLetter = new rptFacturaLetterSize(facturaGenerada, rptFacturaLetterSize.TipoCopia.Blanco) { ShowPrintMarginsWarning = false };
            //                                reportLetter.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            //                                ReportPrintTool printReportLetter = new ReportPrintTool(reportLetter);
            //                                //printReport.ShowPreviewDialog();
            //                                printReportLetter.PrinterSettings.Copies = Convert.ToInt16(PuntoDeVentaActual.Cantidad_copiasFactura);
            //                                printReportLetter.Print();
            //                                facturaGenerada.UpdatePrintCount(facturaGenerada.Id);
            //                                break;
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}//if (ImprimirFactura)
        }

        private void gleTipoPago_EditValueChanged(object sender, EventArgs e)
        {
            //int pIdTipoPago = dp.ValidateNumberInt32(gleTipoPago.EditValue);
            //if (pIdTipoPago == 1)
            //{
            //    gleBanco.Enabled = false;
            //    gleBanco.EditValue = DBNull.Value;
            //    gleBanco.Text = "";
            //}
            //else
            //{
            //    gleBanco.Enabled = true;
            //    gleBanco.EditValue = 2;
            //}
        }

        private void textEdit1_DoubleClick(object sender, EventArgs e)
        {
            frmLoginVendedores frmLoginVendedores = new frmLoginVendedores();   
            if(frmLoginVendedores.ShowDialog() == DialogResult.OK )
            {
                txtAsesorVendedor.Text = frmLoginVendedores.CodigoVendedor + " - " + frmLoginVendedores.NombreVendedor;
                VendedorActual = frmLoginVendedores.Vendedor_;
                this.UsuarioLogeado = new UserLogin();
                if (UsuarioLogeado.RecuperarRegistro(VendedorActual.Id))
                {
                    txtScanProducto.Focus();
                }
            }
        }

        private void cmdChangeVendedor_Click(object sender, EventArgs e)
        {
            frmLoginVendedores frmLoginVendedores = new frmLoginVendedores();
            if (frmLoginVendedores.ShowDialog() == DialogResult.OK)
            {
                txtAsesorVendedor.Text = frmLoginVendedores.CodigoVendedor + " - " + frmLoginVendedores.NombreVendedor;
                VendedorActual = frmLoginVendedores.Vendedor_;
                this.UsuarioLogeado = new UserLogin();
                if(UsuarioLogeado.RecuperarRegistro(VendedorActual.Id))
                {
                    txtScanProducto.Focus();
                }
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void cmdConfirmarFactura_Click(object sender, EventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Confirma si desea enviar esta factura para cobro en caja?");
            if (r != DialogResult.Yes)
            {
                return;
            }

            if(PedidoActual.IdEstado == 1)
            {
                CajaDialogo.Error("Esta pre factura ya fue confirmada!");
                return;
            }

            bool ItemSinInventario = false;
            foreach (dsVentas.detalle_factura_transactionRow row in dsVentas1.detalle_factura_transaction)
            {
                //if (row.inventario <= 0)
                if (row.inventario < row.cantidad)
                {
                    ItemSinInventario = true;
                    break;
                }
            }

            if (ItemSinInventario)
            {
                CajaDialogo.Error("Hay productos en este pedido que No tienen invetario suficiente.\nDebe eliminar estos productos para poder confirmar la Pre Factura!");
                return;
                //if (PedidoActual != null)
                //{
                //    PedidoActual.IdEstado = 8;//8=Inventario Insuficiente
                //}
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_set_cambio_estado_pedido_h]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_estado", 1);//Confirmado
                cmd.Parameters.AddWithValue("@id_pedido", this.PedidoActual.Id);
                cmd.ExecuteScalar();
                con.Close();
                gleEstados.EditValue = PedidoActual.IdEstado;

                simpleButton2.Visible =
                cmdCopiarDesde.Visible =
                simpleButton1.Visible = false;

                gridView1.OptionsMenu.EnableColumnMenu = false;//Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna, para elegir columnas, ordenar, etc
                gridView1.Columns["delete"].Visible = false; //Permite mostrar o ocultar una columna, se utiliza colocando el string de FieldName que se define desde el dataset

                cmdConfirmarFactura.Visible = false;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCopiarDesde_Click(object sender, EventArgs e)
        {
            frmCopiarPedidoDesde frm = new frmCopiarPedidoDesde();
            //frm.MdiParent = this.MdiParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                int pIdPedido = frm.IdPedido;
                if (pIdPedido > 0)
                {
                    TipoOperacionActual = TipoOperacionSQL.Insert;
                    ckConfirmarPedido.Visible = ckGenerarCotizacion.Visible = true;
                    cmdChangeVendedor.Visible = false;
                    txtAsesorVendedor.Enabled = false;

                    LoadEstadosPedidos();
                    PedidoActual = new PedidoCliente();
                    ClienteFactura = new ClienteFacturacion();
                    IdTerminoPago = 1;

                    BusquedaSet = Busqueda.LoMasVendido;
                    SetBusqueda();
                    txtNombreCliente.Text = "Consumidor Final";
                    txtRTN.Text = string.Empty;
                    txtRTN.Properties.NullValuePrompt =
                    txtDireccion.Properties.NullValuePrompt = "No Aplica";

                    DateTime FechaActual_ = dp.NowSetDateTime();
                    lblfecha.Text = Convert.ToString(FechaActual_);
                    dtFechaEntrega.DateTime = FechaActual_.AddDays(1);
                    string.Format("{0:dd/MM/yyyy}", lblfecha.Text);

                    string HostName = Dns.GetHostName();

                    FacturacionEquipo Equipo1 = new FacturacionEquipo();
                    if (Equipo1.RecuperarRegistro(HostName))
                    {
                        if (PuntoDeVentaActual.RecuperaRegistro(Equipo1.id_punto_venta))
                        {
                            if (PuntoDeVentaActual.FacturaComidaBuffet)//Mostramos todas las opciones
                            {
                                //lblOpcionesBuffetRadioButtonGroup.Visible =
                                //radioGroupVentaComidaBuffet.Visible = true;
                                //LoadDefaultOptionRadioButtos();
                            }
                            else
                            {
                                //lblOpcionesBuffetRadioButtonGroup.Visible = 
                                //radioGroupVentaComidaBuffet.Visible = false;
                                //LoadDefaultOptionRadioButtos();
                            }
                        }
                    }

                    PedidoCliente pedidoCliente = new PedidoCliente();
                    if (pedidoCliente.RecuperarRegistro(pIdPedido))
                    {
                        if (pedidoCliente.IdEstado == 6)// || pedidoCliente.IdEstado == 1)
                        {
                            cmdConfirmarFactura.Visible = true;
                        }
                        else
                        {
                            cmdConfirmarFactura.Visible = false;
                        }

                        PedidoActual = pedidoCliente;
                        ClienteFactura = new ClienteFacturacion();

                        txtNombreCliente.Text = pedidoCliente.ClienteNombre;
                        txtRTN.Text = pedidoCliente.RTN;
                        txtDireccion.Text = pedidoCliente.direccion_cliente;
                        ClienteFactura.Id = pedidoCliente.IdCliente;

                        lblfecha.Text = string.Format("{0:dd/MM/yyyy}", FechaActual_);
                        dtFechaEntrega.DateTime = pedidoCliente.FechaEntrega;
                        txtComentario.Text = pedidoCliente.Comentario;

                        VendedorActual = new Vendedor();
                        if (!string.IsNullOrEmpty(pedidoCliente.CodigoVendedor))
                        {
                            if (VendedorActual.RecuperarRegistro(pedidoCliente.CodigoVendedor))
                            {
                                txtAsesorVendedor.Text = VendedorActual.Nombre;
                            }
                        }
                        LoadDetallePedidoForEdit(pIdPedido);
                        gleEstados.EditValue = pedidoCliente.IdEstado;
                        //ckGenerarCotizacion.Visible = ckConfirmarPedido.Visible = false;
                        txtScanProducto.Focus();
                    }
                }
                else//Recuperamos desde COTIZACION
                {
                    TipoOperacionActual = TipoOperacionSQL.Insert;
                    ckConfirmarPedido.Visible = ckGenerarCotizacion.Visible = true;
                    cmdChangeVendedor.Visible = false;
                    txtAsesorVendedor.Enabled = false;

                    LoadEstadosPedidos();
                    PedidoActual = new PedidoCliente();
                    ClienteFactura = new ClienteFacturacion();
                    IdTerminoPago = 1;

                    BusquedaSet = Busqueda.LoMasVendido;
                    SetBusqueda();
                    txtNombreCliente.Text = "Consumidor Final";
                    txtRTN.Text = string.Empty;
                    txtRTN.Properties.NullValuePrompt =
                    txtDireccion.Properties.NullValuePrompt = "No Aplica";

                    DateTime FechaActual_ = dp.NowSetDateTime();
                    lblfecha.Text = Convert.ToString(FechaActual_);
                    dtFechaEntrega.DateTime = FechaActual_;
                    string.Format("{0:dd/MM/yyyy}", lblfecha.Text);

                    string HostName = Dns.GetHostName();

                    CotizacionH Cotizacion1 = new CotizacionH();
                    //if (pedidoCliente.RecuperarRegistro(pIdPedido))
                    if (Cotizacion1.ObtenerPorId(frm.IdCotizacion))
                    {
                        cmdConfirmarFactura.Visible = true;

                        PedidoActual = new PedidoCliente();
                        ClienteFactura = new ClienteFacturacion();

                        txtNombreCliente.Text = Cotizacion1.ClienteNombre;
                        txtRTN.Text = Cotizacion1.RTN;
                        txtDireccion.Text = Cotizacion1.Direccion;
                        ClienteFactura.Id = Cotizacion1.IdCliente;

                        lblfecha.Text = string.Format("{0:dd/MM/yyyy}", FechaActual_);
                        dtFechaEntrega.DateTime = FechaActual_;
                        txtComentario.Text = Cotizacion1.Comentario;

                        VendedorActual = new Vendedor();
                        if (Cotizacion1.IdUser > 0)
                        {
                            if (VendedorActual.RecuperarRegistro(Cotizacion1.IdUser))
                            {
                                txtAsesorVendedor.Text = VendedorActual.Nombre;
                            }
                        }
                        LoadDetalleCotizacionForEdit(Cotizacion1.Id);
                        gleEstados.EditValue = 6;// pedidoCliente.IdEstado;
                        //ckGenerarCotizacion.Visible = ckConfirmarPedido.Visible = false;
                        txtScanProducto.Focus();
                    }
                }




                //if (HostName == "7L12TV3" || HostName == "F3DYSQ2" /*Danys Oliva*/ ||
                //    HostName == "9SSCBV2" || HostName == "9PG91W2" /*Ruben Garcia */ ||
                //    HostName == "F9Q11Q2" /*PC Soporte La 50*/||
                //    HostName == "EUCEDA-PC" /*Euceda*/)
                //{
                //    cmdIngresarAdmin.Visible = SaltarLogin.Visible = simpleButton2.Visible = SaltarLoginPRD.Visible = true;
                //}
            }
        }

        private void rdContado_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdContado.Checked)
            {
                rdCredito.CheckedChanged -=  new EventHandler(rdCredito_CheckedChanged_2);
                rdPorCobrar.CheckedChanged -= new EventHandler(rdCredito_CheckedChanged);
                rdContado.CheckedChanged -= new EventHandler(rdContado_CheckedChanged);

                rdCredito.Checked = 
                rdPorCobrar.Checked = false;
                IdTerminoPago = 1;

                rdContado.CheckedChanged += new EventHandler(rdContado_CheckedChanged);
                rdPorCobrar.CheckedChanged += new EventHandler(rdCredito_CheckedChanged);
                rdCredito.CheckedChanged += new EventHandler(rdCredito_CheckedChanged_2);
            }
        }

        private void rdCredito_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdPorCobrar.Checked)
            {
                rdCredito.CheckedChanged -= new EventHandler(rdCredito_CheckedChanged_2);
                rdContado.CheckedChanged -= new EventHandler(rdContado_CheckedChanged);
                rdPorCobrar.CheckedChanged -= new EventHandler(rdCredito_CheckedChanged);

                rdCredito.Checked = 
                rdContado.Checked = false;
                IdTerminoPago = 3;

                rdPorCobrar.CheckedChanged += new EventHandler(rdCredito_CheckedChanged);
                rdContado.CheckedChanged += new EventHandler(rdContado_CheckedChanged);
                rdCredito.CheckedChanged += new EventHandler(rdCredito_CheckedChanged_2);
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var gv = (GridView)gridControl1.FocusedView;
                var row = (dsVentas.detalle_factura_transactionRow)gv.GetDataRow(gv.FocusedRowHandle);
                //var cell = 
                DevExpress.XtraGrid.Columns.GridColumn focusedColumn = gv.FocusedColumn;
                switch (focusedColumn.FieldName) 
                {
                    case "cantidad":
                        //DevExpress.XtraEditors.Controls.ButtonPressedEventArgs event_ = new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(cmdElejirAlmacen);
                        //cmdElejirAlmacen_ButtonClick(sender, new );
                        ElejirAlmacen();
                        break;
                    default:
                        break;
                }
            }
        }

        private void cmdSalir2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();   
        }

        private void rdCredito_CheckedChanged_2(object sender, EventArgs e)
        {
            if (rdCredito.Checked)
            {
                rdContado.CheckedChanged -= new EventHandler(rdContado_CheckedChanged);
                rdPorCobrar.CheckedChanged -= new EventHandler(rdCredito_CheckedChanged);
                rdCredito.CheckedChanged -= new EventHandler(rdCredito_CheckedChanged_2);

                rdPorCobrar.Checked =
                rdContado.Checked = false;
                IdTerminoPago = 2;

                rdCredito.CheckedChanged += new EventHandler(rdCredito_CheckedChanged_2);
                rdPorCobrar.CheckedChanged += new EventHandler(rdCredito_CheckedChanged);
                rdContado.CheckedChanged += new EventHandler(rdContado_CheckedChanged);
            }
        }

        private string CapitalizarCadaPalabra(string texto)
        {
            var resultado = new System.Text.StringBuilder();
            bool nuevaPalabra = true;

            foreach (char c in texto)
            {
                if (char.IsWhiteSpace(c))
                {
                    nuevaPalabra = true;
                    resultado.Append(c);
                }
                else
                {
                    if (nuevaPalabra)
                        resultado.Append(char.ToUpper(c));
                    else
                        resultado.Append(char.ToLower(c));

                    nuevaPalabra = false;
                }
            }
            return resultado.ToString();
        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null) return;

            if (e.RowHandle >= 0)
            {
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsVentas.detalle_factura_transactionRow)gridView.GetDataRow(e.RowHandle);// GetFocusedDataRow();

                if (row.inventario<=0)
                {
                    //BackColor Rojo Suave
                    e.Appearance.Font = new Font(gridView2.Appearance.Row.Font.FontFamily,
                        gridView2.Appearance.Row.Font.Size,
                        FontStyle.Bold);

                    //e.Appearance.BackColor = Color.FromArgb(102, 255, 102);//Verde
                    e.Appearance.BackColor = Color.FromArgb(245, 141, 105);//Rojo Suave
                    e.HighPriority = true;
                }
                else
                {
                    //Backcolor Blanco
                    //e.Appearance.BackColor = Color.FromArgb(255, 255, 255);

                    //Verde
                    e.Appearance.BackColor = Color.FromArgb(102, 255, 102);
                    e.HighPriority = true;
                }

               
            }
        }

        private void txtNombreCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRTN.Focus();
            }
        }

        private void txtRTN_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {


                txtDireccion.Focus();
            }
        }

        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtScanProducto.Focus();
            }
        }


        private void txtNombreCliente_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

        }

        private void txtDireccion_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            
        }

        private void txtNombreCliente_EditValueChanged(object sender, EventArgs e)
        {
            var te = (DevExpress.XtraEditors.TextEdit)sender;
            int selStart = te.SelectionStart;

            te.Text = CapitalizarCadaPalabra(te.Text);
            te.SelectionStart = selStart;
        }

        private void txtDireccion_EditValueChanged(object sender, EventArgs e)
        {
            var te = (DevExpress.XtraEditors.TextEdit)sender;
            int selStart = te.SelectionStart;

            te.Text = CapitalizarCadaPalabra(te.Text);
            te.SelectionStart = selStart;
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null || e.RowHandle < 0)
                return;

            // Verifica si es la columna "inventario"
            if (e.Column.FieldName == "inventario")
            {
                var row = (dsVentas.detalle_factura_transactionRow)view.GetDataRow(e.RowHandle);

                if (row.inventario <= 0)
                {
                    e.Appearance.BackColor = Color.FromArgb(245, 141, 105); // Rojo suave
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                    e.Appearance.Options.UseBackColor = true;
                    e.Appearance.Options.UseFont = true;
                }
                else
                {
                    //Backcolor Blanco
                    //e.Appearance.BackColor = Color.FromArgb(255, 255, 255);

                    //Verde
                    e.Appearance.BackColor = Color.FromArgb(102, 255, 102);
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                    e.Appearance.Options.UseBackColor = true;
                    e.Appearance.Options.UseFont = true;
                }
            }
            
        }

        private void ckEscaner_CheckedChanged(object sender, EventArgs e)
        {
            if(ckEscaner.Checked)
            {
                if (txtScanProducto.Visible == false)
                {
                    lblScanProducto.Visible = txtScanProducto.Visible = true;
                }
            }
        }

        //frmLoginVendedores
    }
}