
using ACS.Classes;
//using ACS.Forecast;
using ACS.IT_Managment;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraReports.UI;
using DocumentFormat.OpenXml.Spreadsheet;
using Eatery.Ventas;
using JAGUAR_PRO.Accesos;
using JAGUAR_PRO.Accesos.AccesosUsuarios;
using JAGUAR_PRO.Accesos.GestionGrupos;
using JAGUAR_PRO.Accesos.GestionSistemas;
using JAGUAR_PRO.Accesos.GrupoLosa;
using JAGUAR_PRO.Accesos.NivelAccesoSistema;
using JAGUAR_PRO.Accesos.TurnosUsuario;
using JAGUAR_PRO.ACS.RRHH;
using JAGUAR_PRO.AlmacenesExterno;
using JAGUAR_PRO.AlmacenesExterno.Salida_Almacen;
using JAGUAR_PRO.BancosYTitulares;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Compras;
using JAGUAR_PRO.Contabilidad.ActivosFijos;
using JAGUAR_PRO.Contabilidad.CuentasContables;
using JAGUAR_PRO.Contabilidad.Proveedores;
using JAGUAR_PRO.Despachos;
using JAGUAR_PRO.Despachos.Pedidos;
using JAGUAR_PRO.Facturacion.Configuraciones;
using JAGUAR_PRO.Facturacion.CoreFacturas;
using JAGUAR_PRO.Facturacion.Cotizaciones;
using JAGUAR_PRO.Facturacion.Deposito;
using JAGUAR_PRO.Facturacion.Entrega;
using JAGUAR_PRO.Facturacion.Mantenimientos;
using JAGUAR_PRO.Facturacion.Mantenimientos.Models;
using JAGUAR_PRO.Facturacion.Numeracion_Fiscal;
using JAGUAR_PRO.Facturacion.Reportes;
using JAGUAR_PRO.Facturacion.Reportes.Reportes_de_Ventas;
using JAGUAR_PRO.JaguarProduccion;
using JAGUAR_PRO.LogisticaJaguar;
using JAGUAR_PRO.LogisticaJaguar.Despacho;
using JAGUAR_PRO.LogisticaJaguar.Pedidos;
using JAGUAR_PRO.LogisticaJaguar.RecuentoInventario;
using JAGUAR_PRO.Mantenimientos;
using JAGUAR_PRO.Mantenimientos.Clientes;
using JAGUAR_PRO.Mantenimientos.Comisiones;
using JAGUAR_PRO.Mantenimientos.Facturacion.Mantenimiento;
using JAGUAR_PRO.Mantenimientos.Formulas;
using JAGUAR_PRO.Mantenimientos.MaterialEmpaque;
using JAGUAR_PRO.Mantenimientos.MateriaPrima;
using JAGUAR_PRO.Mantenimientos.Panaderos;
using JAGUAR_PRO.Mantenimientos.ProductoTerminado;
using JAGUAR_PRO.Mantenimientos.Proveedor;
using JAGUAR_PRO.RecuentoInventario;
using JAGUAR_PRO.Reportes;
using JAGUAR_PRO.Reproceso;
using JAGUAR_PRO.RRHH_Planilla.Mantenimientos;
using JAGUAR_PRO.RRHH_Planilla.Mantenimientos.MaestrosEmpleado;
using JAGUAR_PRO.RRHH_Planilla.Planilla;
using JAGUAR_PRO.Tools;
using JAGUAR_PRO.TransaccionesMP;
using JAGUAR_PRO.TransaccionesPT;
using JAGUAR_PRO.Utileria;
using LOSA.TransaccionesMP;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Windows.Forms;


namespace JAGUAR_PRO
{
    public partial class frmOpciones : XtraForm
    {
        UserLogin UsuarioLogeado;
        string ActiveUserCode;
        string ActiveUserName;
        string ActiveUserType;

        public frmOpciones(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            lblUsuarioLogeado.Text = "Usuario: " + pUser.Nombre;
            txtEquipoLogeadoActual.Text = Dns.GetHostName();
            if (string.IsNullOrEmpty(txtEquipoLogeadoActual.Text))
                txtEquipoLogeadoActual.Visible = false;
            else
                txtEquipoLogeadoActual.Visible = true;

            tabPageFacturacion.PageVisible = false;

            int i = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
            //int i = Convert.ToInt32(4);
            int idNivel;
            switch (pUser.GrupoUsuario.GrupoUsuarioActivo)
            {
                case GrupoUser.GrupoUsuario.Compras_y_Logistica: //id: 1
                    TabLogistica.PageVisible = true;
                    navBarItemCAI_Proveedores.Visible =
                    navBarItem23.Visible =
                    navBarItem151.Visible =
                    navBarGroup12.Visible =
                    navBarItem154.Visible =
                    nbReporteCompras.Visible =
                    navBarItem15.Visible = navBarItem15.Enabled =
                    navBarGroup5.Visible =
                    navBarItemKardexPT.Visible =
                    navBarItemRecepcionFactura.Visible = true;
                    //tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    //tabOpciones.TabPages[i].PageVisible = true;
                    break;
                case GrupoUser.GrupoUsuario.Logistica: //id: 8
                    TabLogistica.PageVisible = true;
                    navBarItemCAI_Proveedores.Visible =
                        navBarItem23.Visible =
                        navBarItem151.Visible =
                        navBarGroup12.Visible =
                        navBarItem154.Visible =
                        nbReporteCompras.Visible =
                        navBarItem15.Visible = navBarItem15.Enabled =
                        navBarGroup5.Visible =
                    navBarItemRecepcionFactura.Visible = true;
                    //tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    //tabOpciones.TabPages[i].PageVisible = true;
                    break;

                case GrupoUser.GrupoUsuario.Administradores://id: 2
                    //tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    //tabOpciones.TabPages[i].PageVisible = true;

                    idNivel = pUser.idNivelAcceso(pUser.Id, 11);//11 = JAGUAR
                    switch (idNivel)
                    {
                        case 1://Basic View
                            BasicView();
                            UsuarioLogeado.Idnivel = idNivel;
                            break;
                        case 2://Basic No Autorization
                            tabOpciones.TabPages[0].PageVisible = true; //Logistica
                            tabOpciones.TabPages[1].PageVisible = false;//Administracion
                            tabOpciones.TabPages[2].PageVisible = false;//RRHH
                            tabOpciones.TabPages[3].PageVisible = false;//Contabilidad
                            tabOpciones.TabPages[4].PageVisible = true; //Facturacion
                            break;
                        case 3://Medium Autorization
                            tabOpciones.TabPages[0].PageVisible = true; //Logistica
                            tabOpciones.TabPages[1].PageVisible = true; //Administracion
                            tabOpciones.TabPages[2].PageVisible = false;//RRHH
                            tabOpciones.TabPages[3].PageVisible = false;//Contabilidad
                            tabOpciones.TabPages[4].PageVisible = true; //Facturacion
                            navBarItemDepositoBancoCaja.Visible = true;
                            break;
                        case 4://Depth With Delta
                            tabOpciones.TabPages[0].PageVisible = true;
                            tabOpciones.TabPages[1].PageVisible = true; //Logistica
                            tabOpciones.TabPages[2].PageVisible = true; //Administracion
                            tabOpciones.TabPages[3].PageVisible = true; //RRHH
                            tabOpciones.TabPages[4].PageVisible = true; //Contabilidad
                            navBarItemDepositoBancoCaja.Visible = true;
                            //tabOpciones.TabPages[5].PageVisible = true; //Facturacion
                            //tabOpciones.TabPages[6].PageVisible = false;
                            //tabOpciones.TabPages[7].PageVisible = false;
                            //tabOpciones.TabPages[8].PageVisible = false;
                            navBarItemCambioDePrecio.Visible= true;
                            //Mantenimientos de Facturacion
                            xtraTabControl2.TabPages[2].PageVisible = true;
                            NBI_Despachos.Visible = NBI_ListaPrecios.Visible =
                            NBI_PuntoVenta.Visible = NBI_NumeracionFiscal.Visible =
                            NBI_Cliente.Visible = true;


                            //SubTab
                            xtraTabControl2.TabPages[2].PageVisible = true;
                            tabPageFacturacion.PageVisible = true;
                            break;
                        case 5://Depth Without Delta
                            tabPageFacturacion.PageVisible = true;
                            navBarItemCambioDePrecio.Visible = true;
                            //Mantenimientos de Facturacion
                            xtraTabControl2.TabPages[2].PageVisible = true;
                            NBI_Despachos.Visible = NBI_ListaPrecios.Visible =
                            NBI_PuntoVenta.Visible = NBI_NumeracionFiscal.Visible =
                            NBI_Cliente.Visible = true;
                            navBarItemDepositoBancoCaja.Visible = true;
                            break;
                        default:
                            tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                            tabOpciones.TabPages[i].PageVisible = true;
                            break;
                    }
                    break;
                case GrupoUser.GrupoUsuario.RRHH://id: 3
                    int idNivel3 = pUser.idNivelAcceso(pUser.Id, 11);//11 = JAGUAR

                    switch (idNivel3)
                    {
                        case 1://Basic View
                            BasicView();
                            UsuarioLogeado.Idnivel = idNivel3;
                            break;
                        case 2://Basic No Autorization
                            tabOpciones.TabPages[0].PageVisible = false; //Logistica
                            tabOpciones.TabPages[1].PageVisible = false;//Administracion
                            tabOpciones.TabPages[2].PageVisible = true;//RRHH
                            tabOpciones.TabPages[3].PageVisible = false;//Contabilidad
                            tabOpciones.TabPages[4].PageVisible = false; //Facturacion
                            break;
                        case 3://Medium Autorization
                            tabOpciones.TabPages[0].PageVisible = false;//Logistica
                            tabOpciones.TabPages[1].PageVisible = false;//Administracion
                            tabOpciones.TabPages[2].PageVisible = true; //RRHH
                            tabOpciones.TabPages[3].PageVisible = false;//Contabilidad
                            tabOpciones.TabPages[4].PageVisible = false; //Facturacion
                            break;
                        case 4://Depth With Delta
                            tabOpciones.TabPages[0].PageVisible = true;//Logistica
                            tabOpciones.TabPages[1].PageVisible = true;//Administracion 
                            tabOpciones.TabPages[2].PageVisible = true;//RRHH
                            tabOpciones.TabPages[3].PageVisible = true;//Contabilidad 
                            tabOpciones.TabPages[4].PageVisible = true;//Facturacion
                            //tabOpciones.TabPages[5].PageVisible = true; 
                            //tabOpciones.TabPages[6].PageVisible = false;
                            //tabOpciones.TabPages[7].PageVisible = false;
                            //tabOpciones.TabPages[8].PageVisible = false;
                            navBarItemCambioDePrecio.Visible = true;
                            //Mantenimientos de Facturacion
                            xtraTabControl2.TabPages[2].PageVisible = true;
                            NBI_Despachos.Visible = NBI_ListaPrecios.Visible =
                            NBI_PuntoVenta.Visible = NBI_NumeracionFiscal.Visible =
                            NBI_Cliente.Visible = true;


                            //SubTab
                            xtraTabControl2.TabPages[2].PageVisible = true;
                            tabPageFacturacion.PageVisible = true;
                            break;
                        case 5://Depth Without Delta
                            tabPageFacturacion.PageVisible = true;
                            navBarItemCambioDePrecio.Visible = true;

                            tabOpciones.TabPages[0].PageVisible = true;//Logistica
                            tabOpciones.TabPages[1].PageVisible = true;//Administracion
                            tabOpciones.TabPages[2].PageVisible = true;//RRHH 
                            tabOpciones.TabPages[3].PageVisible = false;//Contabilidad
                            tabOpciones.TabPages[4].PageVisible = true; //Facturacion

                            //Mantenimientos de Facturacion
                            xtraTabControl2.TabPages[2].PageVisible = true;
                            NBI_Despachos.Visible = NBI_ListaPrecios.Visible =
                            NBI_PuntoVenta.Visible = NBI_NumeracionFiscal.Visible =
                            NBI_Cliente.Visible = true;
                            break;
                        default:
                            tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                            tabOpciones.TabPages[i].PageVisible = true;
                            break;
                    }
                    break;
                case GrupoUser.GrupoUsuario.Contabilidad://id: 4
                    int idNivel2 = pUser.idNivelAcceso(pUser.Id, 11);//11 = JAGUAR

                    switch (idNivel2)
                    {
                        case 1://Basic View
                            BasicView();
                            UsuarioLogeado.Idnivel = idNivel2;
                            break;
                        case 2://Basic No Autorization
                            tabOpciones.TabPages[0].PageVisible = false; //Logistica
                            tabOpciones.TabPages[1].PageVisible = false;//Administracion
                            tabOpciones.TabPages[2].PageVisible = false;//RRHH
                            tabOpciones.TabPages[3].PageVisible = true;//Contabilidad
                            tabOpciones.TabPages[4].PageVisible = false; //Facturacion
                            break;
                        case 3://Medium Autorization
                            tabOpciones.TabPages[0].PageVisible = false;//Logistica
                            tabOpciones.TabPages[1].PageVisible = false;//Administracion
                            tabOpciones.TabPages[2].PageVisible = false; //RRHH
                            tabOpciones.TabPages[3].PageVisible = true;//Contabilidad
                            tabOpciones.TabPages[4].PageVisible = false; //Facturacion
                            break;
                        case 4://Depth With Delta
                            tabOpciones.TabPages[0].PageVisible = true;//Logistica
                            tabOpciones.TabPages[1].PageVisible = true;//Administracion 
                            tabOpciones.TabPages[2].PageVisible = true;//RRHH
                            tabOpciones.TabPages[3].PageVisible = true;//Contabilidad 
                            tabOpciones.TabPages[4].PageVisible = true;//Facturacion
                            //tabOpciones.TabPages[5].PageVisible = true; 
                            //tabOpciones.TabPages[6].PageVisible = false;
                            //tabOpciones.TabPages[7].PageVisible = false;
                            //tabOpciones.TabPages[8].PageVisible = false;
                            navBarItemCambioDePrecio.Visible = true;
                            //Mantenimientos de Facturacion
                            xtraTabControl2.TabPages[2].PageVisible = true;
                            NBI_Despachos.Visible = NBI_ListaPrecios.Visible =
                            NBI_PuntoVenta.Visible = NBI_NumeracionFiscal.Visible =
                            NBI_Cliente.Visible = true;


                            //SubTab
                            xtraTabControl2.TabPages[2].PageVisible = true;
                            tabPageFacturacion.PageVisible = true;
                            break;
                        case 5://Depth Without Delta
                            tabPageFacturacion.PageVisible = true;
                            navBarItemCambioDePrecio.Visible = true;

                            tabOpciones.TabPages[0].PageVisible = true;//Logistica
                            tabOpciones.TabPages[1].PageVisible = true;//Administracion
                            tabOpciones.TabPages[2].PageVisible = true;//RRHH 
                            tabOpciones.TabPages[3].PageVisible = false;//Contabilidad
                            tabOpciones.TabPages[4].PageVisible = true; //Facturacion

                            //Mantenimientos de Facturacion
                            xtraTabControl2.TabPages[2].PageVisible = true;
                            NBI_Despachos.Visible = NBI_ListaPrecios.Visible =
                            NBI_PuntoVenta.Visible = NBI_NumeracionFiscal.Visible =
                            NBI_Cliente.Visible = true;
                            break;
                        default:
                            tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                            tabOpciones.TabPages[i].PageVisible = true;
                            break;
                    }
                    break;

                case GrupoUser.GrupoUsuario.Facturacion_Admin://id: 5
                    //xtraTabControl2.TabPages[2].PageVisible = true;
                    int idNivel1 = pUser.idNivelAcceso(pUser.Id, 11);//11 = JAGUAR
                    switch (idNivel1)
                    {
                        case 1://Basic View
                            BasicView();
                            UsuarioLogeado.Idnivel = idNivel1;
                            break;
                        case 2://Basic No Autorization
                            tabOpciones.TabPages[0].PageVisible = false; //Logistica
                            tabOpciones.TabPages[1].PageVisible = false;//Administracion
                            tabOpciones.TabPages[2].PageVisible = false;//RRHH
                            tabOpciones.TabPages[3].PageVisible = false;//Contabilidad
                            tabOpciones.TabPages[4].PageVisible = true; //Facturacion
                            break;
                        case 3://Medium Autorization
                            tabOpciones.TabPages[0].PageVisible = false;//Logistica
                            tabOpciones.TabPages[1].PageVisible = false;//Administracion
                            tabOpciones.TabPages[2].PageVisible = false; //RRHH
                            tabOpciones.TabPages[3].PageVisible = false;//Contabilidad
                            tabOpciones.TabPages[4].PageVisible = true; //Facturacion
                            break;
                        case 4://Depth With Delta
                            tabOpciones.TabPages[0].PageVisible = true;//Logistica
                            tabOpciones.TabPages[1].PageVisible = true;//Administracion 
                            tabOpciones.TabPages[2].PageVisible = true;//RRHH
                            tabOpciones.TabPages[3].PageVisible = true;//Contabilidad 
                            tabOpciones.TabPages[4].PageVisible = true;//Facturacion
                            //tabOpciones.TabPages[5].PageVisible = true; 
                            //tabOpciones.TabPages[6].PageVisible = false;
                            //tabOpciones.TabPages[7].PageVisible = false;
                            //tabOpciones.TabPages[8].PageVisible = false;
                            navBarItemCambioDePrecio.Visible = true;
                            //Mantenimientos de Facturacion
                            xtraTabControl2.TabPages[2].PageVisible = true;
                            NBI_Despachos.Visible = NBI_ListaPrecios.Visible =
                            NBI_PuntoVenta.Visible = NBI_NumeracionFiscal.Visible =
                            NBI_Cliente.Visible = true;


                            //SubTab
                            xtraTabControl2.TabPages[2].PageVisible = true;
                            tabPageFacturacion.PageVisible = true;
                            break;
                        case 5://Depth Without Delta
                            tabPageFacturacion.PageVisible = true;
                            navBarItemCambioDePrecio.Visible = true;

                            tabOpciones.TabPages[0].PageVisible = true;//Logistica
                            tabOpciones.TabPages[1].PageVisible = false;//Administracion
                            tabOpciones.TabPages[2].PageVisible = false;//RRHH 
                            tabOpciones.TabPages[3].PageVisible = false;//Contabilidad
                            tabOpciones.TabPages[4].PageVisible = true; //Facturacion

                            //Mantenimientos de Facturacion
                            xtraTabControl2.TabPages[2].PageVisible = true;
                            NBI_Despachos.Visible = NBI_ListaPrecios.Visible =
                            NBI_PuntoVenta.Visible = NBI_NumeracionFiscal.Visible =
                            NBI_Cliente.Visible = true;
                            break;
                        default:
                            tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                            tabOpciones.TabPages[i].PageVisible = true;
                            break;
                    }
                    break;
                case GrupoUser.GrupoUsuario.Facturacion_EndUser://id: 6
                    int idNivel_11 = pUser.idNivelAcceso(pUser.Id, 11);//7 = ALOSY 11=JAGUAR
                    switch (idNivel_11)
                    {
                        case 1://Basic View
                        case 2://Basic No Autorization
                        case 3://Medium Autorization
                            UsuarioLogeado.Idnivel = idNivel_11;
                            tabOpciones.TabPages[4].PageVisible = false;
                            NBI_Despachos.Visible = NBI_ListaPrecios.Visible =
                            NBI_PuntoVenta.Visible = NBI_NumeracionFiscal.Visible = false;
                            NBI_Cliente.Visible = true;
                            navBarFacturaMain.Visible =
                            navBarItemFacturasEmitidas.Visible =
                            NBI_NumeracionFiscal.Visible =
                            NBI_PuntoVenta.Visible =
                            NBI_ListaPrecios.Visible =
                            NBI_Despachos.Visible =
                            navBarItem55.Visible =
                            nbRequest.Visible =
                            nB_PagoMultiple.Visible =
                            navBarItem56.Visible =
                            navBarItem57.Visible =
                            navBarItem58.Visible =
                            nbKardexFacturacion.Visible =
                            nbReportesFacturacionMain.Visible =
                            navBarItemCambioDePrecio.Visible =
                            navBarItem20.Visible = false;

                            navBarGroup11.Visible =
                            navBarG_ReportesFacturacion.Visible =
                            navBarGroup7.Visible = false;
                            break;
                        case 4://Depth With Delta
                            tabOpciones.TabPages[4].PageVisible = true;
                            NBI_Despachos.Visible = NBI_ListaPrecios.Visible =
                            NBI_PuntoVenta.Visible = NBI_NumeracionFiscal.Visible =
                            NBI_Cliente.Visible = true;
                            break;
                        case 5://Depth Without Delta
                            xtraTabControl2.TabPages[4].PageVisible = true;
                            NBI_Despachos.Visible = NBI_ListaPrecios.Visible =
                            NBI_PuntoVenta.Visible = NBI_NumeracionFiscal.Visible =
                            NBI_Cliente.Visible = true;
                            break;
                        default:
                            break;
                    }
                    tabPageFacturacion.PageVisible = true;
                    break;
                case GrupoUser.GrupoUsuario.Caja:
                    int idNivel_12 = pUser.idNivelAcceso(pUser.Id, 11);//7 = ALOSY 11=JAGUAR
                    switch (idNivel_12)
                    {
                        case 1://Basic View
                        case 2://Basic No Autorization
                            UsuarioLogeado.Idnivel = idNivel_12;
                            tabOpciones.TabPages[4].PageVisible = false;
                            NBI_Despachos.Visible = NBI_ListaPrecios.Visible =
                            NBI_PuntoVenta.Visible = NBI_NumeracionFiscal.Visible =
                            NBI_Cliente.Visible =
                            navBarFacturaMain.Visible =
                            NBI_NumeracionFiscal.Visible =
                            NBI_PuntoVenta.Visible =
                            NBI_ListaPrecios.Visible =
                            NBI_Despachos.Visible =
                            navBarItem55.Visible =
                            nbRequest.Visible =
                            nB_PagoMultiple.Visible =
                            navBarItem56.Visible =
                            navBarItem57.Visible =
                            navBarItem58.Visible =
                            nbKardexFacturacion.Visible =
                            nbReportesFacturacionMain.Visible =
                            navBarItemCambioDePrecio.Visible =
                            navBarItem20.Visible =
                            navBarGroup11.Visible =
                            navBarG_ReportesFacturacion.Visible =
                            navBarGroup7.Visible = false;

                            navBarItemDepositoBancoCaja.Visible = true;
                            navBarItemFacturasEmitidas.Visible = true;
                            //navBarItem57.Visible = true;//Cierre de caja
                            break;
                        case 3://Medium Autorization
                            UsuarioLogeado.Idnivel = idNivel_12;
                            tabOpciones.TabPages[4].PageVisible = false;
                            NBI_Despachos.Visible = NBI_ListaPrecios.Visible =
                            NBI_PuntoVenta.Visible = NBI_NumeracionFiscal.Visible =
                            NBI_Cliente.Visible =
                            navBarFacturaMain.Visible =
                            NBI_NumeracionFiscal.Visible =
                            NBI_PuntoVenta.Visible =
                            NBI_ListaPrecios.Visible =
                            NBI_Despachos.Visible =
                            navBarItem55.Visible =
                            nbRequest.Visible =
                            nB_PagoMultiple.Visible =
                            navBarItem56.Visible =
                            navBarItem57.Visible =
                            navBarItem58.Visible =
                            nbKardexFacturacion.Visible =
                            nbReportesFacturacionMain.Visible =
                            navBarItemCambioDePrecio.Visible =
                            navBarItem20.Visible =
                            navBarGroup11.Visible =
                            navBarG_ReportesFacturacion.Visible =
                            navBarGroup7.Visible = false;
                            
                            navBarItemDepositoBancoCaja.Visible = true;
                            navBarItemFacturasEmitidas.Visible = true;
                            //ACCESO a Logistica
                            TabLogistica.PageVisible = true;
                            navBarRecepBodegon.Visible = false;
                            navBarItem152.Visible = false;
                            break;
                        case 4://Depth With Delta
                            tabOpciones.TabPages[4].PageVisible = true;
                            NBI_Despachos.Visible = NBI_ListaPrecios.Visible =
                            NBI_PuntoVenta.Visible = NBI_NumeracionFiscal.Visible =
                            NBI_Cliente.Visible = true;
                            break;
                        case 5://Depth Without Delta
                            xtraTabControl2.TabPages[4].PageVisible = true;
                            NBI_Despachos.Visible = NBI_ListaPrecios.Visible =
                            NBI_PuntoVenta.Visible = NBI_NumeracionFiscal.Visible =
                            NBI_Cliente.Visible = true;
                            break;
                        default:
                            break;
                    }
                    tabPageFacturacion.PageVisible = true;
                    break;
                default:
                    tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    tabOpciones.TabPages[i].PageVisible = true;
                    break;
            }

            //Premisos especificos
            bool accesoprevio = false;
            
            int idNivelUser = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivelUser)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                    accesoprevio = false;
                    navBarItemCambioDePrecio.Visible = true;
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(18))//Cambios de precios
                {
                    navBarItemCambioDePrecio.Visible = true;
                }
            }
            
        }

        public void BasicView()
        {
            //TabCalidad.PageVisible = TabLogistica.PageVisible = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        { }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdRecepcionMPLogistica_Click(object sender, EventArgs e)
        { }

        private void BtnBodegas_Click(object sender, EventArgs e)
        {
            frmBodega frm = new frmBodega();
            frm.Show();
        }

        private void BtnTiposPresentaciones_Click(object sender, EventArgs e)
        {
            frmTipoPresentacion frm = new frmTipoPresentacion();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void BtnEstadosProgramacionesRequisiciones_Click(object sender, EventArgs e)
        { }

        private void BtnKardexTiposTransacciones_Click(object sender, EventArgs e)
        {
            frmKardexTipoTransaccion frm = new frmKardexTipoTransaccion();
            frm.Show();
        }

        private void BtnEstadosRequisiciones_Click(object sender, EventArgs e)
        {
            frmEstadoRequisicion frm = new frmEstadoRequisicion();
            frm.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        { }

        private void simpleButton3_Click(object sender, EventArgs e)
        { }

        private void cmdRegistroLote_Click(object sender, EventArgs e)
        {}

        private void simpleButton2_Click(object sender, EventArgs e)
        {  }

        private void BtnCambiarUbicacion_Click(object sender, EventArgs e)
        { }

        private void cmdProgramaRequisiciones_Click(object sender, EventArgs e)
        { }

        private void BtnDevolciones_Click(object sender, EventArgs e)
        {  }

        private void BtnAjustesKardex_Click(object sender, EventArgs e)
        {   }

        private void cmdRequisiciones_Click(object sender, EventArgs e)
        { }

        private void cmdRequisiciones__Click(object sender, EventArgs e)
        { }

        private void cmdPT_Click(object sender, EventArgs e)
        { }

        private void cmdMP_Click(object sender, EventArgs e)
        {}

        private void btnAlimentacionManual_Click(object sender, EventArgs e)
        {  }

        private void btnLotesPorProveedor_Click(object sender, EventArgs e)
        { }

        private void btnLotesXMP_Click(object sender, EventArgs e)
        { }

        private void btnLotes_Click(object sender, EventArgs e)
        {  }

        private void btnCantidadMP_Click(object sender, EventArgs e)
        { }

        private void btnDevolciones_Click_1(object sender, EventArgs e)
        { }

        private void btnTrazabilidad_Click(object sender, EventArgs e)
        {}

        private void cmdTarimasPT_Click(object sender, EventArgs e)
        { }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {}

        private void cmdLotesCalidad_Click(object sender, EventArgs e)
        { }

        private void btndespachos_Click(object sender, EventArgs e)
        {  }

        private void btnplanesdespachos_Click(object sender, EventArgs e)
        { }

        private void btnReq_PT_Click(object sender, EventArgs e)
        {
            JAGUAR_PRO.Despachos.frm_Reqresumen_pt frm = new Despachos.frm_Reqresumen_pt(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnreportes_Click(object sender, EventArgs e)
        { }

        private void btnconfiguracionCal_Click(object sender, EventArgs e)
        { }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
        }

        private void btnplanrequisas_Click(object sender, EventArgs e)
        {
        }

        private void cmdGestionIngresos_Click(object sender, EventArgs e)
        { }

        private void cmdUbicaciones_Click(object sender, EventArgs e)
        { }

        private void btnRecuento_Click(object sender, EventArgs e)
        {

        }

        private void btnAlimentacion_Click(object sender, EventArgs e)
        {   }

        private void btnPlantarimas_Click(object sender, EventArgs e)
        { }

        private void btnajuste_Click(object sender, EventArgs e)
        {

            //Poner validacion de permisos de forma restrictiva
            RecuentoInventario.frmRecuentoInventario frm = new RecuentoInventario.frmRecuentoInventario();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            //CajaDialogo.Error("Esta opcion esta en mantenimiento! No esta disponible actualmente!");
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        { }

        private void btnPrint_Click(object sender, EventArgs e)
        { }

        private void simpleButton5_Click(object sender, EventArgs e)
        { }

        private void btn_salidapt_Click(object sender, EventArgs e)
        { }

        private void simpleButton6_Click(object sender, EventArgs e)
        { }

        private void simpleButton7_Click(object sender, EventArgs e)
        { }

        private void simpleButton8_Click(object sender, EventArgs e)
        { }

        private void btnRequisasManuales_Click(object sender, EventArgs e)
        { }

        private void simpleButton10_Click(object sender, EventArgs e)
        { }

        private void simpleButton11_Click(object sender, EventArgs e)
        { }

        private void simpleButton12_Click(object sender, EventArgs e)
        { }

        private void btnAlmacenesExternos_Click(object sender, EventArgs e)
        {
            xfrmAlmacenesExternos_Main frm = new xfrmAlmacenesExternos_Main(UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                //frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            frm.Show();
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        { }

        private void simpleButton15_Click(object sender, EventArgs e)
        { }

        private void btntarimasactivadasPT_Click(object sender, EventArgs e)
        { }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            //xfrmMovimientoStock frm = new xfrmMovimientoStock(UsuarioLogeado);
            xfrmMovimientoStockMain frm = new xfrmMovimientoStockMain(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdReporteReqManuales_Click(object sender, EventArgs e)
        {
            frmRequisicionesManualesReporte frm = new frmRequisicionesManualesReporte();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            frmRequisicionesManualesReporte frm = new frmRequisicionesManualesReporte();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        { }

        private void btn_andenes_Click(object sender, EventArgs e)
        {
            frmSeleccionAnden frm = new frmSeleccionAnden();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void ManteIngresos_Click(object sender, EventArgs e)
        { }

        private void btnMPReproceso_Click(object sender, EventArgs e)
        { }

        private void simpleButton9_Click(object sender, EventArgs e)
        { }

        private void simpleButton17_Click(object sender, EventArgs e)
        { }

        private void simpleButton17_Click_1(object sender, EventArgs e)
        { }

        private void btnAut_Tm_Click(object sender, EventArgs e)
        { }

        private void tabEntregaMP_Paint(object sender, PaintEventArgs e)
        { }

        private void simpleButton17_Click_2(object sender, EventArgs e)
        { }

        private void simpleButton17_Click_3(object sender, EventArgs e)
        { }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            frmReporteExterno frm = new frmReporteExterno(this.UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnLoteActivoGranel_Click(object sender, EventArgs e)
        { }

        private void frmOpciones_Load(object sender, EventArgs e)
        {
            try
            {
                bool newVersion;
                bool notificacionesSinLeer;

                NotificacionesGenerales notifications = new NotificacionesGenerales();
                //xfrmPopup frm = new xfrmPopup(UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                this.ActiveUserCode = UsuarioLogeado.Id.ToString();
                this.ActiveUserName = UsuarioLogeado.NombreUser;
                this.ActiveUserType = UsuarioLogeado.Tipo;


                if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                {
                    Version ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
                    notifications.Major = ver.Major;
                    notifications.Minor = ver.Minor;
                    notifications.Build = ver.Build;
                    notifications.Revision = ver.Revision;
                }
                else
                {
                    var ver = Assembly.GetExecutingAssembly().GetName().Version;
                    notifications.Major = ver.Major;
                    notifications.Minor = ver.Minor;
                    notifications.Build = ver.Build;
                    notifications.Revision = ver.Revision;
                }

                newVersion = notifications.ValidarVersionBuild(notifications.Major, notifications.Minor, notifications.Build, notifications.Revision, UsuarioLogeado.Id);
                notificacionesSinLeer = notifications.ValidarNotificacionesSinLeer(UsuarioLogeado.Id);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnImprimirTm_Click(object sender, EventArgs e)
        {
            frmprint__tarimas frm = new frmprint__tarimas();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btn_rptubicaciones_Click(object sender, EventArgs e)
        {
            rptUbicaciones frm = new rptUbicaciones();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton19_Click(object sender, EventArgs e)
        { }

        private void simpleButton20_Click(object sender, EventArgs e)
        { }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            //frmReporteProductoTerminado frm = new frmReporteProductoTerminado();
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        { }

        private void simpleButton23_Click(object sender, EventArgs e)
        { }

        private void btnReporteProduccionDespachos_Click(object sender, EventArgs e)
        { }

        private void simpleButton24_Click(object sender, EventArgs e)
        { }

        private void simpleButton25_Click(object sender, EventArgs e)
        { }

        private void simpleButton26_Click(object sender, EventArgs e)
        { }

        private void simpleButton27_Click(object sender, EventArgs e)
        { }

        private void simpleButton28_Click(object sender, EventArgs e)
        { }

        private void tabMasterData_Paint(object sender, PaintEventArgs e)
        { }

        private void simpleButton29_Click(object sender, EventArgs e)
        { }

        private void simpleButton30_Click(object sender, EventArgs e)
        { }

        private void simpleButton31_Click(object sender, EventArgs e)
        { }

        private void tabPT_Paint(object sender, PaintEventArgs e)
        { }

        private void simpleButton32_Click(object sender, EventArgs e)
        { }

        private void simpleButton33_Click(object sender, EventArgs e)
        { }

        private void btnClientesLote_Click(object sender, EventArgs e)
        { }

        private void simpleButton34_Click(object sender, EventArgs e)
        { }

        private void cmdReportReqManual_Click(object sender, EventArgs e)
        {
            frmReporteRequisicionesManuales frm = new frmReporteRequisicionesManuales();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.Show();
            //frmrptMpEntregadaaProduccion
        }

        private void simpleButton35_Click(object sender, EventArgs e)
        { }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        { }

        private void simpleButton36_Click(object sender, EventArgs e)
        {
            frmReporteAsistencia frm = new frmReporteAsistencia(this.UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void cmdReporteInventarioPorFecha_Click(object sender, EventArgs e)
        {
            frmReporteInvPorLoteA_LaFecha frm = new frmReporteInvPorLoteA_LaFecha(this.UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void cmdVerConfiguracionLotesVencimientoMP_Click(object sender, EventArgs e)
        { }

        private void cmdLoteActivoGranel_Click(object sender, EventArgs e)
        { }

        private void cmdReporteProximosVencer_Click(object sender, EventArgs e)
        {
            //frmReporteKardexGeneralVencimiento frm = new frmReporteKardexGeneralVencimiento(this.UsuarioLogeado);
            //if (this.MdiParent != null)
            //    frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            //frmRutasTrazabilidad frm = new frmRutasTrazabilidad(this.UsuarioLogeado);
            //if (this.MdiParent != null)
            //    frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void btnRecuento_Click_1(object sender, EventArgs e)
        {
            //Logistica.frmRecuentoInventarios frmRecuentoInventario = new Logistica.frmRecuentoInventarios(this.UsuarioLogeado);
            //frmRecuentoInventario.Show();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            //frmEntregaTarimaMicros frm = new frmEntregaTarimaMicros(UsuarioLogeado);
            //if (this.MdiParent != null)
            //{
            //    frm.MdiParent = this.MdiParent;
            //    frm.FormBorderStyle = FormBorderStyle.Sizable;
            //}
            //frm.Show();
        }

        private void btnTransferenciaPendiente_Click(object sender, EventArgs e)
        {
            frmTransPendientes frm = new frmTransPendientes(UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();

        }

        private void btnHistorialPT_Click(object sender, EventArgs e)
        {
            //frmHisotrialPTCodigo frm = new frmHisotrialPTCodigo();
            //if (this.MdiParent != null)
            //    frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void cmdUsuarios_Click(object sender, EventArgs e)
        {
            AccesoUsuario frm = new AccesoUsuario(this.UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdGrupos_Click(object sender, EventArgs e)
        {
            PrincipalGestionGrupos frm = new PrincipalGestionGrupos();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdSistemas_Click(object sender, EventArgs e)
        {
            PrincipalSistemas frm = new PrincipalSistemas();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdGruposAlosy_Click(object sender, EventArgs e)
        {
            PrincipalGrupoLosa frm = new PrincipalGrupoLosa();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private void cmdAccesoSistemas_Click(object sender, EventArgs e)
        {
            NivelAccesoSistema frm = new NivelAccesoSistema();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }


        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmAlimentacionManual frm = new frmAlimentacionManual(UsuarioLogeado);
            //frm.Show();
            //frmAlimentacionPanel frm = new frmAlimentacionPanel();
            //frm.Show();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmPrintTM frm = new frmPrintTM(UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmactivacionPT frm = new frmactivacionPT(UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frm_reporte_alimentacion frm = new frm_reporte_alimentacion();
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //xfrmCheckActiveBin frm = new xfrmCheckActiveBin();
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                //PP_Operator_Panel_v2 frm = new PP_Operator_Panel_v2(this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;

                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbTrazabilidad_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {

                //RPT_Trazabilidad_Lote frm = new RPT_Trazabilidad_Lote(this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //frm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void bnProgramaProduccion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                //PP_Main_Products_Order frm = new PP_Main_Products_Order(UsuarioLogeado);
                //frm.ActiveUserCodeP = ActiveUserCode;
                //frm.ActiveUserNameP = ActiveUserName;
                //frm.ActiveUserTypeP = ActiveUserType;
                //frm.MdiParent = this.MdiParent;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void bnPortafolio_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                //PT_Productos frm = new PT_Productos(ActiveUserCode, ActiveUserName, ActiveUserType, this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbControlProduccion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                //string a = null;
                int group = 0;
                string Query = @"SELECT 
                                      [id_group]
                                  FROM [ACS].[dbo].[conf_usuarios]
                                  where id = " + ActiveUserCode;
                DataOperations dp = new DataOperations();

                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    group = dr.GetInt32(0);
                }
                //PRB_Registro pp = new PRB_Registro(ActiveUserCode, group, this.UsuarioLogeado);
                //pp.UsuarioLog1 = ActiveUserName;
                //pp.CodigoUss = ActiveUserCode;
                //pp.MdiParent = this.MdiParent;
                //pp.Show();

                try
                {
                    //PRB_Registro frm = new PRB_Registro(ActiveUserCode, group, this.UsuarioLogeado);
                    //frm.UsuarioLog1 = ActiveUserName;
                    //frm.CodigoUss = ActiveUserCode;
                    //frm.MdiParent = this.MdiParent;
                    //if (!frm.CerrarForm)
                    //    frm.Show();
                    //else
                    //    frm.Dispose();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    if (UsuarioLogeado.ValidarNivelPermisos(60))
            //    {
            //        frmDatosBrom frm = new frmDatosBrom(this.UsuarioLogeado);
            //        frm.MdiParent = this.MdiParent;
            //        frm.Show();
            //    }
            //    else
            //    {
            //        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #60");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
            try
            {
                //frmDatosBrom frm = new frmDatosBrom(this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbConsultaHora_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                //frmHorometrosLineas frm = new frmHorometrosLineas();
                //frm.MdiParent = this.MdiParent;
                //frm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                //PP_Operator_Panel_v2 frm = new PP_Operator_Panel_v2(this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;

                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }


            //accesoprevio = true;
            //PP_Operator_Panel_v2 frm = new PP_Operator_Panel_v2(this.UsuarioLogeado);
            //frm.MdiParent = this;
            //frm.Show();
            //try
            //{
            //    bool accesoprevio = false;
            //    int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7=ALOSY, 9=AMS
            //    switch (idNivel)
            //    {
            //        case 1://Basic View
            //        case 2://Basic No Autorization
            //        case 3://Medium Autorization
            //        case 4://Depth With Delta
            //        case 5://Depth Without Delta
            //            accesoprevio = true;
            //            PP_Operator_Panel_v2 frm = new PP_Operator_Panel_v2(this.UsuarioLogeado);
            //            frm.MdiParent = this;
            //            frm.Show();
            //            break;
            //        default:
            //            break;
            //    }

            //    if (!accesoprevio)
            //    {
            //        if (UsuarioLogeado.ValidarNivelPermisos(69))
            //        {
            //            //frmMantoPhotosTV frm = new frmMantoPhotosTV(UsuarioLogeado);
            //            PP_Operator_Panel_v2 frm = new PP_Operator_Panel_v2(this.UsuarioLogeado);
            //            frm.MdiParent = this;
            //            frm.Show();
            //        }
            //        else
            //        {
            //            CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #69");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
        }

        private void nbReporteBatch_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    if (UsuarioLogeado.ValidarNivelPermisos(46))
            //    {
            //        frmintakeKepserver frm = new frmintakeKepserver();
            //        frm.MdiParent = this.MdiParent;
            //        frm.Show();
            //    }
            //    else
            //    {
            //        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #46");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
            try
            {
                //frmintakeKepserver frm = new frmintakeKepserver(this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbReporteEnsacadora_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    //reporte ensacadora
            //    if (UsuarioLogeado.ValidarNivelPermisos(48))
            //    {
            //        frmReporteEnsacadora frm = new frmReporteEnsacadora();
            //        frm.MdiParent = this.MdiParent;
            //        frm.WindowState = FormWindowState.Maximized;
            //        frm.Show();
            //    }
            //    else
            //    {
            //        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #48");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
            try
            {
                //frmReporteEnsacadora frm = new frmReporteEnsacadora(this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Maximized;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    //reporte Ingenieria de procesos.
            //    //Sacos por lotes
            //    if (UsuarioLogeado.ValidarNivelPermisos(48))
            //    {
            //        frmSacosPorLote frm = new frmSacosPorLote();
            //        frm.MdiParent = this.MdiParent;
            //        frm.WindowState = FormWindowState.Maximized;
            //        frm.Show();
            //    }
            //    else
            //    {
            //        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #48");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
            try
            {
                //frmSacosPorLote frm = new frmSacosPorLote(this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Maximized;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbEficienciaTurno_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    frmDashBoardEficiencia frm = new frmDashBoardEficiencia(UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    frm.WindowState = FormWindowState.Maximized;
            //    frm.Show();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
            try
            {
                //frmDashBoardEficiencia frm = new frmDashBoardEficiencia(UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Maximized;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbGestionLotes_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    PP_Gestion_lote frm = new PP_Gestion_lote(UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    frm.Show();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
            try
            {
                //PP_Gestion_lote frm = new PP_Gestion_lote(UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Maximized;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbReporteEficiencia_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{

            //    //Imprimir reporte de eficiencia
            //    frmPrintReportEficiencia frm = new frmPrintReportEficiencia(this.UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    frm.Show();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
            try
            {
                //frmPrintReportEficiencia frm = new frmPrintReportEficiencia(this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Maximized;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbEficienciaMolinos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    frmEficienciaMolinos frm = new frmEficienciaMolinos();
            //    frm.MdiParent = this.MdiParent;
            //    frm.Show();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
            try
            {
                //frmEficienciaMolinos frm = new frmEficienciaMolinos(this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Maximized;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbBannerTV_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{

            //    frmBannerMainTV_PRD frm = new frmBannerMainTV_PRD(UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    //frm.WindowState = FormWindowState.Maximized;
            //    frm.Show();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
            try
            {
                //frmBannerMainTV_PRD frm = new frmBannerMainTV_PRD(UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Maximized;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarItem18_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    bool accesoprevio = false;
            //    int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            //    switch (idNivel)
            //    {
            //        case 1://Basic View
            //            break;
            //        case 2://Basic No Autorization
            //            break;
            //        case 3://Medium Autorization
            //            break;
            //        case 4://Depth With Delta
            //            accesoprevio = true;
            //            frmMantoPhotosTV frm = new frmMantoPhotosTV(UsuarioLogeado);
            //            frm.MdiParent = this.MdiParent;
            //            frm.Show();
            //            break;
            //        case 5://Depth Without Delta
            //            break;
            //        default:
            //            break;
            //    }

            //    if (!accesoprevio)
            //    {
            //        if (UsuarioLogeado.ValidarNivelPermisos(68))
            //        {
            //            frmMantoPhotosTV frm = new frmMantoPhotosTV(UsuarioLogeado);
            //            frm.MdiParent = this.MdiParent;
            //            frm.Show();
            //        }
            //        else
            //        {
            //            CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #68");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
            try
            {
                //frmMantoPhotosTV frm = new frmMantoPhotosTV(UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Maximized;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbTemperatura_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    xfrmMenuTemperatura frm = new xfrmMenuTemperatura();
            //    frm.MdiParent = this.MdiParent;
            //    frm.Show();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
            try
            {
                //xfrmMenuTemperatura frm = new xfrmMenuTemperatura(this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Maximized;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbForeCastPRD_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    bool accesoprevio = false;
            //    int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            //    switch (idNivel)
            //    {
            //        case 1://Basic View
            //            break;
            //        case 2://Basic No Autorization
            //            break;
            //        case 3://Medium Autorization
            //            break;
            //        case 4://Depth With Delta
            //            accesoprevio = true;
            //            frmFCT_produccion frm = new frmFCT_produccion(this.UsuarioLogeado);
            //            frm.MdiParent = this.MdiParent;
            //            frm.Show();
            //            break;
            //        case 5://Depth Without Delta
            //            break;
            //        default:
            //            break;
            //    }

            //    if (!accesoprevio)
            //    {
            //        if (UsuarioLogeado.ValidarNivelPermisos(71))
            //        {
            //            //frmMantoPhotosTV frm = new frmMantoPhotosTV(UsuarioLogeado);
            //            frmFCT_produccion frm = new frmFCT_produccion(this.UsuarioLogeado);
            //            frm.MdiParent = this.MdiParent;
            //            frm.Show();
            //        }
            //        else
            //        {
            //            CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #71");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
            try
            {
                //frmFCT_produccion frm = new frmFCT_produccion(this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Maximized;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbConfiguraciones_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                //bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
                //switch (idNivel)
                //{
                //    case 1://Basic View
                //        break;
                //    case 2://Basic No Autorization
                //        break;
                //    case 3://Medium Autorization
                //        break;
                //    case 4://Depth With Delta
                //        accesoprevio = true;
                //        xfrmMainConfiguracion frm = new xfrmMainConfiguracion();
                //        frm.MdiParent = this.MdiParent;
                //        frm.Show();
                //        break;
                //    case 5://Depth Without Delta
                //        break;
                //    default:
                //        break;
                //}

                //if (!accesoprevio)
                //{
                //    if (UsuarioLogeado.ValidarNivelPermisos(80))
                //    {
                //        xfrmMainConfiguracion frm = new xfrmMainConfiguracion();
                //        frm.MdiParent = this.MdiParent;
                //        frm.Show();
                //    }
                //    else
                //    {
                //        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #80");
                //    }
                //}
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        private void navBarItem22_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    IntakeBatchViewerFull frm = new IntakeBatchViewerFull();
            //    frm.MdiParent = this.MdiParent;
            //    frm.Show();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
        }

        private void nbPlanProduccion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    Prod_Ordenes_Produccion frm = new Prod_Ordenes_Produccion(ActiveUserCode, ActiveUserName, ActiveUserType, this.UsuarioLogeado);
            //    //frm.MdiParent = this.MdiParent;
            //    if (!frm.CerrarForm)
            //        frm.Show();
            //    else
            //        frm.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void frmTmVirtuales_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    frmrptarimasvirtuales frm = new frmrptarimasvirtuales();
            //    frm.MdiParent = this.MdiParent;
            //    frm.Show();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void simpleButton37_Click(object sender, EventArgs e)
        {
            xfrmAccesosTemporalesAdmin frm = new xfrmAccesosTemporalesAdmin(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void nbTrasladoAceiteExterno_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmOilRequest frm = new frmOilRequest(this.UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
            //try
            //{
            //    frmOilRequest frm = new frmOilRequest(this.UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    frm.WindowState = FormWindowState.Maximized;
            //    if (!frm.CerrarForm)
            //        frm.Show();
            //    else
            //        frm.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void nbSetMaterial_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmSetRM_Tantques_Ext frm = new frmSetRM_Tantques_Ext(this.UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
            //try
            //{
            //    frmSetRM_Tantques_Ext frm = new frmSetRM_Tantques_Ext(this.UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    frm.WindowState = FormWindowState.Maximized;
            //    if (!frm.CerrarForm)
            //        frm.Show();
            //    else
            //        frm.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void nbReporteTrasladoAceites_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    frmReporteTraslados prod = new frmReporteTraslados();
            //    prod.MdiParent = this.MdiParent;
            //    prod.Show();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
            //try
            //{
            //    frmReporteTraslados frm = new frmReporteTraslados(this.UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    frm.WindowState = FormWindowState.Maximized;
            //    if (!frm.CerrarForm)
            //        frm.Show();
            //    else
            //        frm.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void nbTrasladosTanquesArriba_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmReporteTrasladosArribaAdvanced frm = new frmReporteTrasladosArribaAdvanced();
            //prod.MdiParent = this.MdiParent;
            //prod.Show();
            //try
            //{
            //    frmReporteTrasladosArribaAdvanced frm = new frmReporteTrasladosArribaAdvanced(this.UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    frm.WindowState = FormWindowState.Maximized;
            //    if (!frm.CerrarForm)
            //        frm.Show();
            //    else
            //        frm.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void nbSalidaAceite_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmReporteConsumoLinea frm = new frmReporteConsumoLinea(this.UsuarioLogeado);
            //prod.MdiParent = this.MdiParent;
            //prod.Show();
            //try
            //{
            //    frmReporteConsumoLinea frm = new frmReporteConsumoLinea(this.UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    frm.WindowState = FormWindowState.Maximized;
            //    if (!frm.CerrarForm)
            //        frm.Show();
            //    else
            //        frm.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void nbSetLoteGranel_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //if (UsuarioLogeado.ValidarNivelPermisos(8))
            //{
            //    frmLoteActivoGraneles frm = new frmLoteActivoGraneles();
            //    frm.MdiParent = this.MdiParent;
            //    frm.Show();
            //}
            //else
            //{
            //    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #48");
            //}
        }

        private void navBarItem16_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frm_report_oil_in_and_out frm = new frm_report_oil_in_and_out();
            //frm.MdiParent = this.MdiParent;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();
            //try
            //{
            //    frm_report_oil_in_and_out frm = new frm_report_oil_in_and_out(this.UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    frm.WindowState = FormWindowState.Maximized;
            //    if (!frm.CerrarForm)
            //        frm.Show();
            //    else
            //        frm.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void navBarItem17_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //bool accesoprevio = false;
            //int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            //switch (idNivel)
            //{
            //    case 1://Basic View
            //        break;
            //    case 2://Basic No Autorization
            //        break;
            //    case 3://Medium Autorization
            //        break;
            //    case 4://Depth With Delta
            //        accesoprevio = true;
            //        frmReporteTrasladosArribaByOrden frm = new frmReporteTrasladosArribaByOrden();
            //        frm.MdiParent = this.MdiParent;
            //        frm.Show();
            //        break;
            //    case 5://Depth Without Delta
            //        break;
            //    default:
            //        break;
            //}

            //if (!accesoprevio)
            //{
            //    if (UsuarioLogeado.ValidarNivelPermisos(73))
            //    {
            //        //frmMantoPhotosTV frm = new frmMantoPhotosTV(UsuarioLogeado);
            //        frmReporteTrasladosArribaByOrden frm = new frmReporteTrasladosArribaByOrden();
            //        frm.MdiParent = this;
            //        frm.Show();
            //    }
            //    else
            //    {
            //        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #73");
            //    }
            //}

            //try
            //{
            //    frmReporteTrasladosArribaByOrden frm = new frmReporteTrasladosArribaByOrden(this.UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    frm.WindowState = FormWindowState.Maximized;
            //    if (!frm.CerrarForm)
            //        frm.Show();
            //    else
            //        frm.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void nbTrazabilidad_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    RPT_Trazabilidad_Lote frm = new RPT_Trazabilidad_Lote(this.UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;

            //    if (!frm.CerrarForm)
            //        frm.Show();
            //    else
            //        frm.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
        }

        private void simpleButton38_Click(object sender, EventArgs e)
        {
            //frmEmpleadosM FRM = new frmEmpleadosM();
            //FRM.MdiParent = this.MdiParent;
            //FRM.Show();
        }

        private void simpleButton39_Click(object sender, EventArgs e)
        {
            //OC_Menu frmCom = new OC_Menu(UsuarioLogeado);
            //frmCom.MdiParent = this.MdiParent;
            //frmCom.WindowState = FormWindowState.Maximized;
            //frmCom.Show();
        }

        private void simpleButton40_Click(object sender, EventArgs e)
        {

            //if (UsuarioLogeado.ValidarNivelPermisos(57))
            //{
            //    frmGestionAccesosEncuesta frm = new frmGestionAccesosEncuesta();
            //    frm.MdiParent = this.MdiParent;
            //    frm.Show();
            //}
            //else
            //{
            //    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #57");
            //}
        }

        private void simpleButton41_Click(object sender, EventArgs e)
        {
            //Frm_MantenimientoFace frm = new Frm_MantenimientoFace();
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void simpleButton42_Click(object sender, EventArgs e)
        {
            //frmResumenHorasExtra frm = new frmResumenHorasExtra(UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void simpleButton43_Click(object sender, EventArgs e)
        {
            //bool accesoprevio = false;
            //int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            //switch (idNivel)
            //{
            //    case 1://Basic View
            //        break;
            //    case 2://Basic No Autorization
            //        break;
            //    case 3://Medium Autorization
            //        break;
            //    case 4://Depth With Delta
            //        accesoprevio = true;
            //        frmResumenNominas frm = new frmResumenNominas();
            //        frm.MdiParent = this.MdiParent;
            //        frm.Show();
            //        break;
            //    case 5://Depth Without Delta
            //        break;
            //    default:
            //        break;
            //}
        }

        private void simpleButton44_Click(object sender, EventArgs e)
        {
            //bool accesoprevio = false;
            //int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            //switch (idNivel)
            //{
            //    case 1://Basic View
            //        break;
            //    case 2://Basic No Autorization
            //        break;
            //    case 3://Medium Autorization
            //        break;
            //    case 4://Depth With Delta
            //        accesoprevio = true;
            //        frmResumenVacaciones frm = new frmResumenVacaciones();
            //        frm.MdiParent = this;
            //        frm.Show();
            //        break;
            //    case 5://Depth Without Delta
            //        break;
            //    default:
            //        break;
            //}
        }

        private void simpleButton45_Click(object sender, EventArgs e)
        {
            //bool accesoprevio = false;
            //int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            //switch (idNivel)
            //{
            //    case 1://Basic View
            //        break;
            //    case 2://Basic No Autorization
            //        break;
            //    case 3://Medium Autorization
            //        break;
            //    case 4://Depth With Delta
            //        accesoprevio = true;
            //        frmLiquidacionesOP frm = new frmLiquidacionesOP(UsuarioLogeado);
            //        frm.MdiParent = this.MdiParent;
            //        frm.Show();
            //        break;
            //    case 5://Depth Without Delta
            //        break;
            //    default:
            //        break;
            //}
        }

        private void simpleButton46_Click(object sender, EventArgs e)
        {
            //frmSaldosVacacionesRRHH frm = new frmSaldosVacacionesRRHH(this.UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void simpleButton49_Click(object sender, EventArgs e)
        {
            //FML_Compare_Cost_External_Local form = new FML_Compare_Cost_External_Local();
            //form.MdiParent = this.MdiParent;
            //form.Show();
        }

        private void simpleButton47_Click(object sender, EventArgs e)
        {
            //FCT_Proyeccion_Ventas forecast = new FCT_Proyeccion_Ventas();
            ////forecast.MdiParent = this;
            //forecast.ActiveUserCode = ActiveUserCode;
            //forecast.ShowDialog();
        }

        private void simpleButton51_Click(object sender, EventArgs e)
        {
            //FCT_Volumenes vol = new FCT_Volumenes();
            ////vol.MdiParent = this;
            //vol.ActiveUserCode = ActiveUserCode;
            //vol.ShowDialog();
        }

        private void simpleButton50_Click(object sender, EventArgs e)
        {
            //FCT_MRP mrp = new FCT_MRP(this.UsuarioLogeado);
            ////mrp.MdiParent = this;
            //mrp.ActiveUserCode = ActiveUserCode;
            //mrp.ShowDialog();
        }

        private void simpleButton48_Click(object sender, EventArgs e)
        {
            //FCT_Proyeccion_Sacos frm = new FCT_Proyeccion_Sacos();
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void simpleButton56_Click(object sender, EventArgs e)
        {
            //FCT_Proyeccion_Etiquetas frm = new FCT_Proyeccion_Etiquetas();
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void simpleButton52_Click(object sender, EventArgs e)
        {
            //bool accesoprevio = false;
            //int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            //switch (idNivel)
            //{
            //    case 1://Basic View
            //        break;
            //    case 2://Basic No Autorization
            //        break;
            //    case 3://Medium Autorization
            //        break;
            //    case 4://Depth With Delta
            //        //accesoprevio = true;
            //        //FCT_MRP_Complete frm = new FCT_MRP_Complete(this.UsuarioLogeado);
            //        //frm.MdiParent = this.MdiParent;
            //        //frm.Show();
            //        break;
            //    case 5://Depth Without Delta
            //        break;
            //    default:
            //        break;
            //}
        }

        private void simpleButton53_Click(object sender, EventArgs e)
        {
            ////AFC_ProyeccionVentas
            //bool accesoprevio = false;
            //int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            //switch (idNivel)
            //{
            //    case 1://Basic View
            //        break;
            //    case 2://Basic No Autorization
            //        break;
            //    case 3://Medium Autorization
            //        break;
            //    case 4://Depth With Delta
            //        accesoprevio = true;
            //        //AFC_ProyeccionVentas frm = new AFC_ProyeccionVentas(UsuarioLogeado);
            //        //frm.MdiParent = this;
            //        //frm.Show();
            //        break;
            //    case 5://Depth Without Delta
            //        break;
            //    default:
            //        break;
            //}
        }

        private void simpleButton54_Click(object sender, EventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                    //accesoprevio = true;
                    //frmFCT_produccion frm = new frmFCT_produccion(this.UsuarioLogeado);
                    //frm.MdiParent = this;
                    //frm.Show();
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(71))
                {
                    //frmMantoPhotosTV frm = new frmMantoPhotosTV(UsuarioLogeado);
                    //frmFCT_produccion frm = new frmFCT_produccion(this.UsuarioLogeado);
                    //frm.MdiParent = this;
                    //frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #71");
                }
            }
        }

        private void simpleButton55_Click(object sender, EventArgs e)
        {
            //AFC_ConsumoReal
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                    accesoprevio = true;
                    //AFC_ConsumoReal frm = new AFC_ConsumoReal();
                    //frm.MdiParent = this;
                    //frm.Show();
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(71))
                {
                    //AFC_ConsumoReal frm = new AFC_ConsumoReal();
                    //frm.MdiParent = this;
                    //frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #71");
                }
            }
        }

        private void simpleButton58_Click(object sender, EventArgs e)
        {
            try
            {
                //MigracionACS.Produccion.Reports.Rep_Fml_Uso form = new MigracionACS.Produccion.Reports.Rep_Fml_Uso();
                //form.MdiParent = this.MdiParent;
                //form.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);               
            }
        }

        private void simpleButton59_Click(object sender, EventArgs e)
        {
            try
            {
                //MigracionACS.Finanzas.Reports.Rep_Fml_Uso form = new MigracionACS.Finanzas.Reports.Rep_Fml_Uso();
                //form.MdiParent = this.MdiParent;
                //form.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        
        }

        private void simpleButton62_Click(object sender, EventArgs e)
        {
            try
            {
              //MigracionACS.Finanzas.Reports.RPT_Conta_Varios form = new MigracionACS.Finanzas.Reports.RPT_Conta_Varios(ActiveUserCode, ActiveUserType, ActiveADUser, UserGroups, this.UsuarioLogeado);
              //  form.MdiParent = this.MdiParent;
              //  form.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton65_Click(object sender, EventArgs e)
        {
            try
            {
            //MigracionACS. Finanzas.Reports.RPT_FML_NC_MasterDetailReport form = new MigracionACS.Finanzas.Reports.RPT_FML_NC_MasterDetailReport();
            //    form.MdiParent = this.MdiParent;
            //form.Show();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton61_Click(object sender, EventArgs e)
        {
            try
            {
               //MigracionACS.Finanzas.Reports.RPT_FML_FL_FF_CostVar_MasterDetailReport form = new MigracionACS.Finanzas.Reports.RPT_FML_FL_FF_CostVar_MasterDetailReport(ActiveUserCode, ActiveUserName, ActiveUserType, UserGroups);
               // form.MdiParent = this.MdiParent;
               // form.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton60_Click(object sender, EventArgs e)
        {
            try
            {
                int user_id = int.Parse(ActiveUserCode);
                //user_id = GetUserID(ActiveUserName);

                if (user_id == 1020 || user_id == 1035 || user_id == 1037)
                {
                    //frm_Reporteador_Validate_byUser frm = new frm_Reporteador_Validate_byUser(ActiveUserCode, ActiveUserName, ActiveUserType);
                    //frm.MdiParent = this.MdiParent;
                    //frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene permisos para Abrir esta ventana");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                
            }
        }

        private void simpleButton66_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogeado.ValidarNivelPermisos(34))
                {
                   //MigracionACS.SAR.SAR_Main frmAll = new MigracionACS.SAR.SAR_Main();
                   // frmAll.MdiParent = this.MdiParent;
                   // frmAll.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #34");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                throw;
            }
        }

        private void simpleButton63_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogeado.ValidarNivelPermisos(58))
                {
                    //frmConsumoConsolaReal frm = new frmConsumoConsolaReal();
                    //frm.MdiParent = this;
                    //frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #58");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
             
            }
        }

        private void simpleButton64_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogeado.ValidarNivelPermisos(58))
                {
                    //frmConsumoConsolaTeorico frm = new frmConsumoConsolaTeorico();
                    //frm.MdiParent = this.MdiParent;
                    //frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #58");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            
            }
        }

        private void simpleButton57_Click(object sender, EventArgs e)
        {
            rd_OdooMenu.ShowPopup(new Point((this.Width / 2), (this.Height / 2)));
        }

        private void btnMP_BodsegaPRD_Click(object sender, EventArgs e)
        {
            //frm_MateriaPrimaEnBodegaPRd frm = new frm_MateriaPrimaEnBodegaPRd(UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void btn_mp_bodega_prd_finanzas_Click(object sender, EventArgs e)
        {
            //frm_MateriaPrimaEnBodegaPRd frm = new frm_MateriaPrimaEnBodegaPRd(UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void btnRutas_traza_produccion_Click(object sender, EventArgs e)
        {
            //frmRutasTrazabilidad frm = new frmRutasTrazabilidad(this.UsuarioLogeado);
            //if (this.MdiParent != null)
            //    frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void btnrutas_traz_logistica_Click(object sender, EventArgs e)
        {
            //frmRutasTrazabilidad frm = new frmRutasTrazabilidad(this.UsuarioLogeado);
            //if (this.MdiParent != null)
            //    frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void btn_rutas_traza_contabilidad_Click(object sender, EventArgs e)
        {
            //frmRutasTrazabilidad frm = new frmRutasTrazabilidad(this.UsuarioLogeado);
            //if (this.MdiParent != null)
            //    frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void btnAprobaTarimasConta_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_tarimas_pt_Click(object sender, EventArgs e)
        {

        }

        private void navBarItem19_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                //frmReporteTrasladosArribaByLotePT frm = new frmReporteTrasladosArribaByLotePT(this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Maximized;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton67_Click(object sender, EventArgs e)
        {
            //xfrmReporteLotesAConsumir frm = new xfrmReporteLotesAConsumir();
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //xfrmReporteLotesAConsumir frm = new xfrmReporteLotesAConsumir();
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void simpleButton68_Click(object sender, EventArgs e)
        {
            try
            {
                //TT_Arribo arrib = new TT_Arribo(ActiveUserCode);
                //arrib.MdiParent = this.MdiParent;
                //arrib.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton71_Click(object sender, EventArgs e)
        {
            try
            {
                //TT_reporte_bascula rept = new TT_reporte_bascula();
                //rept.MdiParent = this.MdiParent;
                //rept.WindowState = FormWindowState.Maximized;
                //rept.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton70_Click(object sender, EventArgs e)
        {
            try
            {
                //frmCamionesEnPredio rept = new frmCamionesEnPredio(UsuarioLogeado);
                //rept.MdiParent = this.MdiParent;
                ////rept.WindowState = FormWindowState.Maximized;
                //rept.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton69_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    bool accesoprevio = false;
            //    int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            //    switch (idNivel)
            //    {
            //        case 1://Basic View
            //            break;
            //        case 2://Basic No Autorization
            //            break;
            //        case 3://Medium Autorization
            //            break;
            //        case 4://Depth With Delta
            //            //accesoprevio = true;
            //            //frmDetalleDesechos frm = new frmDetalleDesechos(this.UsuarioLogeado);
            //            //frm.MdiParent = this.MdiParent;
            //            //frm.Show();
            //            break;
            //        case 5://Depth Without Delta
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void simpleButton72_Click(object sender, EventArgs e)
        {
            try
            {
                //FML_FF_Main_Panel form = new FML_FF_Main_Panel(ActiveUserCode, ActiveUserName, ActiveUserType, UserGroups);
                //form.MdiParent = this.MdiParent;
                //form.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton73_Click(object sender, EventArgs e)
        {
            try
            {
                //FML_Formulas_v2 fm = new FML_Formulas_v2(ActiveUserCode, ActiveUserName, ActiveUserType, UserGroups);
                //fm.MdiParent = this.MdiParent;
                //fm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarItem9_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //xfrmMP_Por_BIN frm = new xfrmMP_Por_BIN();
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void simpleButton74_Click(object sender, EventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            frmMainProductoTerminado frm = new frmMainProductoTerminado(UsuarioLogeado, puntoVenta1);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnMP_Click(object sender, EventArgs e)
        {
            Mantenimientos.MateriaPrima.xfrmMasterMP_Admin frm = new Mantenimientos.MateriaPrima.xfrmMasterMP_Admin(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton75_Click(object sender, EventArgs e)
        {
            //frmAddVentana frm = new frmAddVentana(frmAddVentana.Accion.nuevo, 0, this.UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
            frmMantVentanas frm = new frmMantVentanas(this.UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton76_Click(object sender, EventArgs e)
        {
            frmUsuariosAccesos frm = new frmUsuariosAccesos(this.UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdTiposMP_Click(object sender, EventArgs e)
        {
            Mantenimientos.MateriaPrima.xfrmMP_Tipo_Admin frm = new Mantenimientos.MateriaPrima.xfrmMP_Tipo_Admin();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdEstados_Click(object sender, EventArgs e)
        {
            Mantenimientos.MateriaPrima.xfrmMP_Estados_Admin frm = new Mantenimientos.MateriaPrima.xfrmMP_Estados_Admin();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdFML_Tipo_Click(object sender, EventArgs e)
        {
            xfrmMP_Tipo_Formula_Admin frm = new xfrmMP_Tipo_Formula_Admin();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmd_estadosFML_Click(object sender, EventArgs e)
        {
            xfrmFML_Formula_Estados_Admin frm = new xfrmFML_Formula_Estados_Admin();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmd_estadosFML_Click_1(object sender, EventArgs e)
        {
            xfrmFML_Formula_Estados_Admin frm = new xfrmFML_Formula_Estados_Admin();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

       

        private void cmdFML_Tipo_Click_1(object sender, EventArgs e)
        {
            xfrmMP_Tipo_Formula_Admin frm = new xfrmMP_Tipo_Formula_Admin();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdProveedores_Click(object sender, EventArgs e)
        {
            xfrmJAGUAR_Proveedor_Admin frm = new xfrmJAGUAR_Proveedor_Admin(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();

        }

        private void simpleButton77_Click(object sender, EventArgs e)
        {
            xfrmProveedorCAI frm = new xfrmProveedorCAI(this.UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdFacturas_Click(object sender, EventArgs e)
        {
            xfrmProveedorFactura frm = new xfrmProveedorFactura(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }


        private void cmdPanaderos_Click_1(object sender, EventArgs e)
        {
            xfrmJAGUAR_Panaderos frm = new xfrmJAGUAR_Panaderos(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItemRecepcionFactura_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();


            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este Equipo de Nombre: " + HostName + " no esta Configurado en ningun Punto de Venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este Equipo de Nombre: " + HostName + " no esta Configurado en ningun Punto de Venta!");
                return;
            }


            //AFC_ConsumoReal
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    
                    break;
                case 3://Medium Autorization
                   
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmRecepcionFacturaProveedor frm = new frmRecepcionFacturaProveedor(this.UsuarioLogeado, puntoVenta1);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(18))
                {
                    frmRecepcionFacturaProveedor frm = new frmRecepcionFacturaProveedor(this.UsuarioLogeado, puntoVenta1);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #18 (Recepción de Facturas)");
                }
            }
            
        }

        private void simpleButton78_Click(object sender, EventArgs e)
        {
            xfrmJAGUAR_TipoPresentacionConversion frm = new xfrmJAGUAR_TipoPresentacionConversion();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItemOrdenFabricacion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //AFC_ConsumoReal
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = true;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmProductionOrdersHome frm = new frmProductionOrdersHome(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(2))
                {
                    frmProductionOrdersHome frm = new frmProductionOrdersHome(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #2 (Recepción de Facturas)");
                }
            }
        }

        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = true;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    break;
                case 4://Depth With Delta
                    accesoprevio = true;
                    frmMainProductoTerminado frm = new frmMainProductoTerminado(this.UsuarioLogeado, puntoVenta1);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                case 5://Depth Without Delta


                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(4))
                {
                    frmMainProductoTerminado frm = new frmMainProductoTerminado(this.UsuarioLogeado, puntoVenta1);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #4 (Acceso Recetas)");
                }
            }



            //frmMainProductoTerminado frm = new frmMainProductoTerminado(UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmPedidoHome
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                    accesoprevio = true;
                    frmPedidoHome frm = new frmPedidoHome(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(4))
                {
                    frmPedidoHome frm = new frmPedidoHome(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #5 (Acceso Pedidos)");
                }
            }
        }//





        private void simpleButton2_Click_2(object sender, EventArgs e)
        {
            frmReporteInventarioKardexGeneral frm = new frmReporteInventarioKardexGeneral(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            xfrmJAGUAR_Clientes frm = new xfrmJAGUAR_Clientes(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmReporteInventarioKardexGeneral frm = new frmReporteInventarioKardexGeneral(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItemRequisiciones_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = true;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmRequisiciones frm = new frmRequisiciones(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(4))
                {
                    frmRequisiciones frm = new frmRequisiciones(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #6 (Acceso Requisiciones)");
                }
            }
        }

        private void navBarItemKardexPT_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmReporteGeneralProductoTerminado frm = new frmReporteGeneralProductoTerminado(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnME_Click(object sender, EventArgs e)
        {
            xfrmJAGUAR_MaterialEmpaque frm = new xfrmJAGUAR_MaterialEmpaque(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItemCAI_Proveedores_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //AFC_ConsumoReal
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    xfrmProveedorCAI frm = new xfrmProveedorCAI(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(19))
                {
                    xfrmProveedorCAI frm = new xfrmProveedorCAI(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #19 (CAI de Proveedores)");
                }
            }
            //xfrmProveedorCAI frm = new xfrmProveedorCAI();
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void navBarItemmaterialEmpaqueLogistica_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //AFC_ConsumoReal
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = true;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    xfrmJAGUAR_MaterialEmpaque frm = new xfrmJAGUAR_MaterialEmpaque(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(8))
                {
                    xfrmJAGUAR_MaterialEmpaque frm = new xfrmJAGUAR_MaterialEmpaque(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #8 (Gestión Datos maestros Material de Empaque)");
                }
            }
        }

        private void navBarItemAvanceProduccion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //avance de produccion ingreso de latas
            //AFC_ConsumoReal
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = true;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    break;
                case 4://Depth With Delta
                    accesoprevio = true;
                    frmHomeAvanceProduccion frm = new frmHomeAvanceProduccion(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(2))
                {
                    frmHomeAvanceProduccion frm = new frmHomeAvanceProduccion(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #2 (Recepción de Facturas)");
                }
            }
            
        }

        private void navBarItem20_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //Recibo de produccion
            //frmHomeAvanceProduccionBolsas
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = true;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmHomeAvanceProduccionBolsas frm = new frmHomeAvanceProduccionBolsas(this.UsuarioLogeado);
                    
                    //Version donde no se selecciona la orden de fabricacion
                    //frmHomeAvanceProduccionBolsasGroupBy frm = new frmHomeAvanceProduccionBolsasGroupBy(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(9))
                {
                    frmHomeAvanceProduccionBolsas frm = new frmHomeAvanceProduccionBolsas(this.UsuarioLogeado);

                    //Version donde no se selecciona la orden de fabricacion
                    //frmHomeAvanceProduccionBolsasGroupBy frm = new frmHomeAvanceProduccionBolsasGroupBy(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #9 (Recepción de Producto Terminado)");
                }
            }
        }

        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    //accesoprevio = true;
                    break;
                case 3://Medium Autorization
                    //accesoprevio = true;
                    break;
                case 4://Depth With Delta
                    accesoprevio = true;
                    xfrmJAGUAR_Proveedor_Admin frm = new xfrmJAGUAR_Proveedor_Admin(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(4))
                {
                    //xfrmProveedorCAI frm = new xfrmProveedorCAI(this.UsuarioLogeado);
                    //frm.MdiParent = this.MdiParent;
                    //frm.Show();
                    xfrmJAGUAR_Proveedor_Admin frm = new xfrmJAGUAR_Proveedor_Admin(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #4 (Gestión de Proveedores)");
                }
            }
        }

        private void navBarItem21_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //DateTime FechaInicio=Convert.ToDateTime( "2023-01-01");
            //DateTime FechaFin=Convert.ToDateTime( "2023-05-01");

            //rptHistoricoPT report = new rptHistoricoPT(FechaInicio, FechaFin);

            //using (ReportPrintTool printTool = new ReportPrintTool(report))
            //{
            //    // Send the report to the default printer.
            //    printTool.ShowPreviewDialog();
            //}

            frmReporteGeneralProductoTerminadoHST frm = new frmReporteGeneralProductoTerminadoHST(this.UsuarioLogeado);
            frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void navBarItem23_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = true;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmHomeProductoDanado frm = new frmHomeProductoDanado(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(9))
                {
                    frmHomeProductoDanado frm = new frmHomeProductoDanado(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #9 (Recepción de Producto Terminado)");
                }
            }
        }

        private void simpleButton2_Click_3(object sender, EventArgs e)
        {
            PrincipalTurnos frm = new PrincipalTurnos(UsuarioLogeado);
            //PrincipalTurnos frm = new PrincipalTurnos(this.UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnClienteFacturacion_Click(object sender, EventArgs e)
        {
            xfrmFacturacion_Clientes frm = new xfrmFacturacion_Clientes(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnNumeracion_Click(object sender, EventArgs e)
        {
            frmNumeracionFiscal frm = new frmNumeracionFiscal(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnMantoPDV_Click(object sender, EventArgs e)
        {
            xfrm_PDV frm = new xfrm_PDV(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarFacturaMain_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if(!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    
                    frmFactura frm = new frmFactura(this.UsuarioLogeado, puntoVenta1, EquipoActual, frmFactura.TipoFacturacionStock.VentaNormal);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(11))
                {
                    ////frmFactura frm = new frmFactura(this.UsuarioLogeado);
                    ////frm.MdiParent = this.MdiParent;
                    ////frm.Show();
                    //switch (puntoVenta1.TipoFacturacionID)
                    //{
                    //    //1	Facturación Rápida
                    //    case 1:
                    //        frmFactura frm = new frmFactura(this.UsuarioLogeado, puntoVenta1, EquipoActual);
                    //        frm.MdiParent = this.MdiParent;
                    //        frm.Show();
                    //        break;

                    //    //2	Facturación Normal
                    //    case 2:

                    //        break;
                    //}
                    frmFactura frm = new frmFactura(this.UsuarioLogeado, puntoVenta1, EquipoActual, frmFactura.TipoFacturacionStock.VentaNormal);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #11 (Facturacion punto de venta)");
                }
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnListaPrecios_Click(object sender, EventArgs e)
        {

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = true;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    xfrnListaPrecioAdmin frm = new xfrnListaPrecioAdmin(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(12))
                {
                    xfrnListaPrecioAdmin frm = new xfrnListaPrecioAdmin(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #12 (Gestion de Lista de Precio)");
                }
            }
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            xfrmDespachoAdmin xfrm = new xfrmDespachoAdmin(UsuarioLogeado);
            xfrm.MdiParent = this.MdiParent;
            xfrm.Show();
        }

        private void navBarItemFacturasEmitidas_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }



            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmHomeFacturasEmitidas frm = new frmHomeFacturasEmitidas(this.UsuarioLogeado, puntoVenta1, EquipoActual);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(16))
                {

                    frmHomeFacturasEmitidas frm = new frmHomeFacturasEmitidas(this.UsuarioLogeado, puntoVenta1, EquipoActual);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #16 (Facturacion punto de venta)");
                }
            }
        }

        private void navBarControl3_Click(object sender, EventArgs e)
        {

        }

        private void NBI_Cliente_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AccesoAMantoClientes();
        }

        private void AccesoAMantoClientes()
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    xfrmFacturacion_Clientes frm = new xfrmFacturacion_Clientes(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    accesoprevio = true;
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(2))
                {

                    xfrmFacturacion_Clientes frm = new xfrmFacturacion_Clientes(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #2 (Facturacion punto de venta)");
                }
            }
            
        }

        private void AccesoAMantoNumeracionFiscal()
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    frmNumeracionFiscal frm = new frmNumeracionFiscal(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    accesoprevio = true;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(3))
                {

                    frmNumeracionFiscal frm = new frmNumeracionFiscal(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #3 (Configuraciones de Facturacion)");
                }
            }
            
        }

        private void AccesoMantoPuntosDeVenta()
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    xfrm_PDV frm = new xfrm_PDV(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    accesoprevio = true;
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(16))
                {

                    xfrm_PDV frm = new xfrm_PDV(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #16 (Configuraciones de Facturacion)");
                }
            }
            
        }

        private void NBI_NumeracionFiscal_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AccesoAMantoNumeracionFiscal();
        }

        private void AccesoAMantoListasDePrecio()
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = true;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    xfrnListaPrecioAdmin frm2 = new xfrnListaPrecioAdmin(UsuarioLogeado);
                    frm2.MdiParent = this.MdiParent;
                    frm2.Show();
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    xfrnListaPrecioAdmin frm = new xfrnListaPrecioAdmin(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(6))
                {
                    xfrnListaPrecioAdmin frm = new xfrnListaPrecioAdmin(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #6 (Gestion de Lista de Precio)");
                }
            }
        }

        private void NBI_PuntoVenta_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AccesoMantoPuntosDeVenta();
        }

        private void NBI_ListaPrecios_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AccesoAMantoListasDePrecio();
        }

        private void NBI_Despachos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AccesoAMantoTraslados(true, "Recepcion de Factura");
        }

       

        private void AccesoAMantoTraslados(bool pMostrarCopiarDesdeFactura, string pStringVentana)
        {
            //xfrmDespachoAdmin xfrm = new xfrmDespachoAdmin(UsuarioLogeado);
            //xfrm.MdiParent = this.MdiParent;
            //xfrm.Show();

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    //accesoprevio = true;
                    break;
                case 3://Medium Autorization
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    string HostName = Dns.GetHostName();
                    FacturacionEquipo EquipoActual = new FacturacionEquipo();
                    PDV puntoVenta1 = new PDV();

                    if (EquipoActual.RecuperarRegistro(HostName))
                    {
                        if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                        {
                            CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                            return;
                        }
                    }
                    else
                    {
                        CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                        return;
                    }

                    xfrmTrasladoRecepcionDetalleFactura frm = new xfrmTrasladoRecepcionDetalleFactura(this.UsuarioLogeado, puntoVenta1.ID, pStringVentana);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(13))
                {
                    string HostName = Dns.GetHostName();
                    FacturacionEquipo EquipoActual = new FacturacionEquipo();
                    PDV puntoVenta1 = new PDV();

                    if (EquipoActual.RecuperarRegistro(HostName))
                    {
                        if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                        {
                            CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                            return;
                        }
                    }
                    else
                    {
                        CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                        return;
                    }

                    xfrmTrasladoRecepcionDetalleFactura frm = new xfrmTrasladoRecepcionDetalleFactura(this.UsuarioLogeado, puntoVenta1.ID, pStringVentana);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #13 (Despacho de Producto Terminado)");
                }
            }
        }

        private void navBarItem24_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AccesoAMantoTraslados(true, "Entrega de Factura");
        }

        private void navBarItem55_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    HomeEstadoCuenta frm2 = new HomeEstadoCuenta(20);
                    frm2.MdiParent = this.MdiParent;
                    frm2.Show();
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    HomeEstadoCuenta frm = new HomeEstadoCuenta(20);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(11))
                {
                    HomeEstadoCuenta frm = new HomeEstadoCuenta(20);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #11 (Gestion de Facturacion)");
                }
            }

        }

        private void nbRequest_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    frmHomeSolicitudesAutorizacion frm2 = new frmHomeSolicitudesAutorizacion(UsuarioLogeado, puntoVenta1);
                    frm2.MdiParent = this.MdiParent;
                    frm2.Show();
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmHomeSolicitudesAutorizacion frm = new frmHomeSolicitudesAutorizacion(UsuarioLogeado, puntoVenta1);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(16))
                {
                    frmHomeSolicitudesAutorizacion frm = new frmHomeSolicitudesAutorizacion(UsuarioLogeado, puntoVenta1);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #16 (Configuracion de Facturacion)");
                }
            }
        }

        private void nB_PagoMultiple_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmHomePagoMultipleSimple frm = new frmHomePagoMultipleSimple(this.UsuarioLogeado, puntoVenta1, EquipoActual);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(11))
                {
                    frmHomePagoMultipleSimple frm = new frmHomePagoMultipleSimple(this.UsuarioLogeado, puntoVenta1, EquipoActual);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #11 (Facturacion punto de venta)");
                }
            }
        }

        private void navBarItem56_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmHomeNotasCreditoDebito frm = new frmHomeNotasCreditoDebito(UsuarioLogeado );
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(16))
                {
                    frmHomeNotasCreditoDebito frm = new frmHomeNotasCreditoDebito( UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #16 (Configuracion de Facturacion)");
                }
            }
        }

        private void navBarItem57_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmCierreDiaHome frm = new frmCierreDiaHome(this.UsuarioLogeado, puntoVenta1);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(17))
                {
                    frmCierreDiaHome frm = new frmCierreDiaHome(this.UsuarioLogeado, puntoVenta1);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #17 (Cierre de caja, punto de venta)");
                }
            }
        }

        private void nbKardexFacturacion_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmKardexFacturacion frm = new frmKardexFacturacion(UsuarioLogeado, puntoVenta1);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }
            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(11))
                {
                    frmKardexFacturacion frm = new frmKardexFacturacion(UsuarioLogeado, puntoVenta1);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #11 (Perfil de facturador)");
                }
            }
        }

        private void navBarItem58_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }



            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;

                    frmFacturaWithPDV frm = new frmFacturaWithPDV(this.UsuarioLogeado, puntoVenta1, EquipoActual);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(11))
                {
                    frmFacturaWithPDV frm = new frmFacturaWithPDV(this.UsuarioLogeado, puntoVenta1, EquipoActual);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #11 (Facturacion punto de venta)");
                }
            }
        }

        private void navBarItem59_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;

                    frmReporteConsumoMPPorDia frm = new frmReporteConsumoMPPorDia();
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }
        }

        private void nBarRecepcionFactPuntoVenta_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }



            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;

                    //xfrmTrasladoRecepcion frm = new xfrmTrasladoRecepcion(this.UsuarioLogeado, puntoVenta1.ID, true);
                    xfrmTrasladoRecepcionDetalleFactura frm = new xfrmTrasladoRecepcionDetalleFactura(0, this.UsuarioLogeado, puntoVenta1.ID);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(11))
                {
                    //xfrmTrasladoRecepcion frm = new xfrmTrasladoRecepcion(this.UsuarioLogeado, puntoVenta1.ID, true);
                    xfrmTrasladoRecepcionDetalleFactura frm = new xfrmTrasladoRecepcionDetalleFactura(0, this.UsuarioLogeado, puntoVenta1.ID);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #11 (Facturacion punto de venta)");
                }
            }
        }

        private void nbReportesFacturacionMain_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }



            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmReportesFacturacionMultiple frm = new frmReportesFacturacionMultiple(this.UsuarioLogeado, puntoVenta1);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(11))
                {
                    //xfrmTrasladoRecepcion frm = new xfrmTrasladoRecepcion(this.UsuarioLogeado, puntoVenta1.ID, true);
                    frmReportesFacturacionMultiple frm = new frmReportesFacturacionMultiple(this.UsuarioLogeado, puntoVenta1);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #11 (Facturacion punto de venta)");
                }
            }
        }

        private void nbReporteCompras_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //AFC_ConsumoReal
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                    accesoprevio = true;
                    //frmRecepcionFacturaProveedor frm = new frmRecepcionFacturaProveedor(this.UsuarioLogeado);
                    frmReporteDeCompras frm = new frmReporteDeCompras(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(20))
                {
                    //frmRecepcionFacturaProveedor frm = new frmRecepcionFacturaProveedor(this.UsuarioLogeado);
                    frmReporteDeCompras frm = new frmReporteDeCompras(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #20 (Recepción de Facturas)");
                }
            }
        }

        private void navBarItem60_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                //AFC_ConsumoReal
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        accesoprevio = false;
                        break;
                    case 3://Medium Autorization
                        accesoprevio = false;
                        break;
                    case 4://Depth With Delta
                        accesoprevio = true;
                        //frmRecepcionFacturaProveedor frm = new frmRecepcionFacturaProveedor(this.UsuarioLogeado);
                        frmReporteChequeoLatas frm = new frmReporteChequeoLatas( );
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                        break;
                    case 5://Depth Without Delta
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(17))
                    {
                        //frmRecepcionFacturaProveedor frm = new frmRecepcionFacturaProveedor(this.UsuarioLogeado);
                        frmReporteChequeoLatas frm = new frmReporteChequeoLatas();
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }
                    else
                    {
                        //CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #2 (Recepción de Facturas)");
                        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #17 (Reporte de Producción)");
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarItem61_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                //AFC_ConsumoReal
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        accesoprevio = false;
                        break;
                    case 3://Medium Autorization
                        accesoprevio = false;
                        break;
                    case 4://Depth With Delta
                        accesoprevio = true;
                        //frmRecepcionFacturaProveedor frm = new frmRecepcionFacturaProveedor(this.UsuarioLogeado);
                        frmReportePTDanado frm = new frmReportePTDanado();
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                        break;
                    case 5://Depth Without Delta
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(17))
                    {
                        //frmRecepcionFacturaProveedor frm = new frmRecepcionFacturaProveedor(this.UsuarioLogeado);
                        frmReportePTDanado frm = new frmReportePTDanado();
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }
                    else
                    {
                        //CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #2 (Recepción de Facturas)");
                        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #17 (Reporte de Producción)");
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarItem62_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                //AFC_ConsumoReal
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        accesoprevio = false;
                        break;
                    case 3://Medium Autorization
                        accesoprevio = false;
                        break;
                    case 4://Depth With Delta
                        accesoprevio = true;
                        //frmRecepcionFacturaProveedor frm = new frmRecepcionFacturaProveedor(this.UsuarioLogeado);
                        frmReportePTTerminado frm = new frmReportePTTerminado();
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                        break;
                    case 5://Depth Without Delta
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(17))
                    {
                        //frmRecepcionFacturaProveedor frm = new frmRecepcionFacturaProveedor(this.UsuarioLogeado);
                        frmReportePTTerminado frm = new frmReportePTTerminado();
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }
                    else
                    {
                        //CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #2 (Recepción de Facturas)");
                        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #17 (Reporte de Producción)");
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarItem63_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                //AFC_ConsumoReal
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        accesoprevio = false;
                        break;
                    case 3://Medium Autorization
                        accesoprevio = false;
                        break;
                    case 4://Depth With Delta
                        accesoprevio = true;
                        //frmRecepcionFacturaProveedor frm = new frmRecepcionFacturaProveedor(this.UsuarioLogeado);
                        frmReportePT_By_panadero frm = new frmReportePT_By_panadero(this.UsuarioLogeado);
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                        break;
                    case 5://Depth Without Delta
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(17))
                    {
                        frmReportePT_By_panadero frm = new frmReportePT_By_panadero(this.UsuarioLogeado);
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }
                    else
                    {
                        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #17 (Reporte de Producción)");
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarItem64_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            try
            {
                //AFC_ConsumoReal
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        accesoprevio = false;
                        break;
                    case 3://Medium Autorization
                        accesoprevio = false;
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        //frmRecepcionFacturaProveedor frm = new frmRecepcionFacturaProveedor(this.UsuarioLogeado);
                        //frmCotizacionesHome frm = new frmCotizacionesHome(this.UsuarioLogeado, puntoVenta1);
                        //frmCotizacionOP frm = new frmCotizacionOP(frmCotizacionOP.TipoOperacion.Insert, UsuarioLogeado, puntoVenta1, 0);
                        frmPedidoCliente frm = new frmPedidoCliente(UsuarioLogeado, puntoVenta1,EquipoActual, new Vendedor(), frmPedidoCliente.TipoFacturacionStock.VentaNormal);
                        frm.MdiParent = this.MdiParent;
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        frm.Show();
                        frm.BringToFront();
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(5))
                    {
                        //frmCotizacionesHome frm = new frmCotizacionesHome(this.UsuarioLogeado, puntoVenta1);
                        //frmCotizacionOP frm = new frmCotizacionOP(frmCotizacionOP.TipoOperacion.Insert, UsuarioLogeado, puntoVenta1, 0);
                        frmPedidoCliente frm = new frmPedidoCliente(UsuarioLogeado, puntoVenta1, EquipoActual, new Vendedor(), frmPedidoCliente.TipoFacturacionStock.VentaNormal);
                        frm.MdiParent = this.MdiParent;
                        frm.StartPosition = FormStartPosition.CenterScreen; 
                        frm.Show();
                        frm.BringToFront();
                    }
                    else
                    {
                        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #5 (Pre Facturas)");
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarItemCambioDePrecio_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            frmReporteCambiosDePrecios frm = new frmReporteCambiosDePrecios(this.UsuarioLogeado, puntoVenta1);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdCuentas_Click(object sender, EventArgs e)
        {
            frmTitularMain frm = new frmTitularMain(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItem20_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmRptBancos frm = new frmRptBancos(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton1_Click_2(object sender, EventArgs e)
        {
            frmMainPTFamilia frm = new frmMainPTFamilia(UsuarioLogeado);
            frm.Show();
        }

        private void simpleButton4_Click_2(object sender, EventArgs e)
        {
            frmMainPTClase frm = new frmMainPTClase(UsuarioLogeado);
            
            frm.Show();
        }

        private void simpleButton5_Click_1(object sender, EventArgs e)
        {
            frmMainPTSubClase frm = new frmMainPTSubClase(UsuarioLogeado);
           
            frm.Show();
        }

        private void simpleButton6_Click_1(object sender, EventArgs e)
        {
            frmMainPTCategoria frm = new frmMainPTCategoria(UsuarioLogeado);
            
            frm.Show();
        }

        private void navBarItem23_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();


            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este Equipo de Nombre: " + HostName + " no esta Configurado en ningun Punto de Venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este Equipo de Nombre: " + HostName + " no esta Configurado en ningun Punto de Venta!");
                return;
            }

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmOrdenesCompraMain mtx = new frmOrdenesCompraMain(UsuarioLogeado, frmOrdenesCompraMain.TipoOperacion.New, puntoVenta1);
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();


                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(1))
                {
                    frmOrdenesCompraMain mtx = new frmOrdenesCompraMain(UsuarioLogeado, frmOrdenesCompraMain.TipoOperacion.New, puntoVenta1);
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();

                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #VT-1 (Ordenes de Compra)");
                }
            }

            //frmOrdenesCompraMain frm = new frmOrdenesCompraMain(UsuarioLogeado, frmOrdenesCompraMain.TipoOperacion.New);
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void tabPageFacturacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navBarItem59_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            try
            {
                //AFC_ConsumoReal
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        accesoprevio = false;
                        break;
                    case 3://Medium Autorization
                        accesoprevio = false;
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        //frmRecepcionFacturaProveedor frm = new frmRecepcionFacturaProveedor(this.UsuarioLogeado);
                        //frmCotizacionesHome frm = new frmCotizacionesHome(this.UsuarioLogeado, puntoVenta1);
                        frmHomePedidosClientes frm = new frmHomePedidosClientes(this.UsuarioLogeado, puntoVenta1);
                        frm.MdiParent = this.MdiParent;
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        frm.Show();
                        frm.BringToFront();
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(5))
                    {
                        //frmCotizacionesHome frm = new frmCotizacionesHome(this.UsuarioLogeado, puntoVenta1);
                        frmHomePedidosClientes frm = new frmHomePedidosClientes(this.UsuarioLogeado, puntoVenta1);
                        frm.MdiParent = this.MdiParent;
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        frm.Show();
                        frm.BringToFront();
                    }
                    else
                    {
                        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #5 (Pre Facturas)");
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarRecepBodegon_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmRecepcionCompraVentaUnica mtx = new frmRecepcionCompraVentaUnica(UsuarioLogeado);
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();


                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(25))
                {
                    frmRecepcionCompraVentaUnica mtx = new frmRecepcionCompraVentaUnica(UsuarioLogeado);
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();

                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #VT-25 (Recepcion Compras Usados)");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;    
            this.Close();
        }

        private void navBarItem60_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmMainTrasladoPT frm = new frmMainTrasladoPT(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

                    break;
                default:
                    break;
            }


            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(14))
                {
                    frmMainTrasladoPT frm = new frmMainTrasladoPT(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #VT-14 (Traslado Directo Entre Bodegas)");
                }
            }
        }

        private void simpleButton7_Click_1(object sender, EventArgs e)
        {
            frmMainMarcas frm = new frmMainMarcas(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarIteSoliTraslado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmRequisaTraslado frm = new frmRequisaTraslado(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton8_Click_1(object sender, EventArgs e)
        {
            frmMainPTCombinaciones frm = new frmMainPTCombinaciones(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnConfigComisiones_Click(object sender, EventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmMainComisiones mtx = new frmMainComisiones(UsuarioLogeado);
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();


                    break;
                default:
                    break;
            }
        }

        private void navBarItem62_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmPlanillaDepartmentHome frm = new frmPlanillaDepartmentHome(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                try
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(10))
                    {
                        frmPlanillaDepartmentHome frm = new frmPlanillaDepartmentHome(UsuarioLogeado);
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }
                    else
                    {
                        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #10");
                    }
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }

            
        }

        private void navBarItem63_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPlanillaProfessionHome frm = new frmPlanillaProfessionHome(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItem64_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPlanillaBancosHome frmPlanillaBancos = new frmPlanillaBancosHome(UsuarioLogeado);
            frmPlanillaBancos.MdiParent = this.MdiParent;
            frmPlanillaBancos.Show();
        }

        private void navBarItem65_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPlanillaPuestoTrabajoHome frm = new frmPlanillaPuestoTrabajoHome(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItem66_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frm_Hr_Employee_List frm = new frm_Hr_Employee_List(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                try
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(11))
                    {
                        frm_Hr_Employee_List frm = new frm_Hr_Employee_List(UsuarioLogeado);
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }
                    else
                    {
                        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #11");
                    }
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
        }

        private void navBarItem197_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPlanillaBandaSalarialHome frm = new frmPlanillaBandaSalarialHome(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItem198_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPlanillaTipoExpedienteHome frm = new frmPlanillaTipoExpedienteHome(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItem199_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPlanillaTipoAsignacionHome frm = new frmPlanillaTipoAsignacionHome(UsuarioLogeado);
            frm.MdiParent= this.MdiParent;
            frm.Show();
        }

        private void navBarItem200_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPlanillaCategoriaHome frm = new frmPlanillaCategoriaHome(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItem205_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPlanillaTipoCambioHome frm = new frmPlanillaTipoCambioHome(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItem201_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPlanillaSalaryRulesHome frm = new frmPlanillaSalaryRulesHome(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItem204_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPlanillaTiposPlanillaHome frm = new frmPlanillaTiposPlanillaHome(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItem207_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPlanillaEstructuraSalarialHome frm = new frmPlanillaEstructuraSalarialHome(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItem202_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPlanillaConceptsHome frm = new frmPlanillaConceptsHome(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItem206_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPlanillaConf_ISR_Home frm = new frmPlanillaConf_ISR_Home(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItem203_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPlanillaAccountHome frm = new frmPlanillaAccountHome(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItem111_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
            switch (idNivel)
            {
                case 1://Basic View
                case 2://Basic No Autorization
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                    accesoprevio = true;
                    frmHomePlanillas frm5 = new frmHomePlanillas(UsuarioLogeado);
                    frm5.MdiParent = this.MdiParent;
                    frm5.Show();
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                //if (UsuarioLogeado.ValidarNivelPermisos())
                //{
                    frmHomePlanillas frm1 = new frmHomePlanillas(UsuarioLogeado);
                    frm1.MdiParent = this.MdiParent;
                    frm1.Show();
                //}
                //else
                //{
                //    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #107");
                //}
            }
        }

        private void simpleButton9_Click_1(object sender, EventArgs e)
        {
            frmPTCargarMasivo frm = new frmPTCargarMasivo();
            frm.Show();
        }

        private void navBarItem107_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frm_Hr_Employee_List frm = new frm_Hr_Employee_List(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                try
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(11))
                    {
                        frm_Hr_Employee_List frm = new frm_Hr_Employee_List(UsuarioLogeado);
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }
                    else
                    {
                        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #11");
                    }
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
        }

        private void navBarItem151_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();


            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este Equipo de Nombre: " + HostName + " no esta Configurado en ningun Punto de Venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este Equipo de Nombre: " + HostName + " no esta Configurado en ningun Punto de Venta!");
                return;
            }

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmOrdenCompraList mtx = new frmOrdenCompraList(puntoVenta1, UsuarioLogeado);
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();


                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(21))
                {
                    frmOrdenCompraList mtx = new frmOrdenCompraList(puntoVenta1, UsuarioLogeado);
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();

                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #VT-21 (Ordenes de Compra)");
                }
            }


        }

        private void navBarItem152_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();


            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este Equipo de Nombre: " + HostName + " no esta Configurado en ningun Punto de Venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este Equipo de Nombre: " + HostName + " no esta Configurado en ningun Punto de Venta!");
                return;
            }

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmEntrega mtx = new frmEntrega(UsuarioLogeado, puntoVenta1);
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();

                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(13))
                {
                    frmEntrega mtx = new frmEntrega(UsuarioLogeado, puntoVenta1);
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #VT-13 (Lista de Entrega)");
                }
            }
        }

        private void navBarItem153_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmTrasladoGestionKardex frm = new frmTrasladoGestionKardex(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

                    break;
                default:
                    break;
            }


            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(14))
                {
                    frmTrasladoGestionKardex frm = new frmTrasladoGestionKardex(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #VT-14 (Traslado Directo Entre Bodegas)");
                }
            }
        }
        private void btnChangePin_Click(object sender, EventArgs e)
        {
            
        }

        private void navBarItem154_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();


            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este Equipo de Nombre: " + HostName + " no esta Configurado en ningun Punto de Venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este Equipo de Nombre: " + HostName + " no esta Configurado en ningun Punto de Venta!");
                return;
            }

            frmOC_SolicitudesMain frm = new frmOC_SolicitudesMain(UsuarioLogeado, puntoVenta1);
            frm.Show();
        }

        private void navBarItem208_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

           


            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmMainProductoTerminado frm = new frmMainProductoTerminado(UsuarioLogeado, puntoVenta1);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }


            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(22))
                {
                    frmMainProductoTerminado frm = new frmMainProductoTerminado(UsuarioLogeado, puntoVenta1);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #VT-22 (Master de Producto Terminado)");
                }
            }
        }

        private void navBarItemDepositoBancoCaja_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmDepositoBancoMain frm = new frmDepositoBancoMain(this.UsuarioLogeado, puntoVenta1, EquipoActual);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(23))
                {

                    frmDepositoBancoMain frm = new frmDepositoBancoMain(this.UsuarioLogeado, puntoVenta1, EquipoActual);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #23 (Deposito Bancario)");
                }
            }
        }

        private void navFacturacionUsados_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }


            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;

                    frmPedidoCliente frm = new frmPedidoCliente(this.UsuarioLogeado, puntoVenta1, 
                                                                EquipoActual, new Vendedor(),
                                                                frmPedidoCliente.TipoFacturacionStock.VentaUsados);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(24))
                {
                    frmPedidoCliente frm = new frmPedidoCliente(this.UsuarioLogeado, puntoVenta1, 
                                                                EquipoActual, new Vendedor(),
                                                                frmPedidoCliente.TipoFacturacionStock.VentaUsados);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #24 (Facturacion de usados)");
                }
            }
        }

        private void navBarItem209_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }


            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;

                    frmMainMarcas frm = new frmMainMarcas(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(26))
                {
                    frmMainMarcas frm = new frmMainMarcas(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #26 (Gestión de Marcas)");
                }
            }
        }

        private void navBarReporteVentasPorVendedor_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }


            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;

                    frmResumenVentasVendedoresPorFecha frm = new frmResumenVentasVendedoresPorFecha(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(27))
                {
                    frmResumenVentasVendedoresPorFecha frm = new frmResumenVentasVendedoresPorFecha(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #27 (Reporte de ventas por vendedor)");
                }
            }
        }

        private void navBarCotizaciones_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            try
            {
                //AFC_ConsumoReal
                bool accesoprevio = false;
                bool AccesoAdmin = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        accesoprevio = false;
                        break;
                    case 3://Medium Autorization
                        accesoprevio = false;
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        AccesoAdmin = accesoprevio = true;
                        frmCotizacionesHome frm = new frmCotizacionesHome(this.UsuarioLogeado, puntoVenta1, AccesoAdmin);
                        frm.MdiParent = this.MdiParent;
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        frm.Show();
                        frm.BringToFront();
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(5))
                    {
                        //frmCotizacionesHome frm = new frmCotizacionesHome(this.UsuarioLogeado, puntoVenta1);
                        frmCotizacionesHome frm = new frmCotizacionesHome(this.UsuarioLogeado, puntoVenta1, AccesoAdmin);
                        frm.MdiParent = this.MdiParent;
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        frm.Show();
                        frm.BringToFront();
                    }
                    else
                    {
                        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #5 (Pre Facturas)");
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarCotizaciones_LinkClicked_1(object sender, NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            try
            {
                //AFC_ConsumoReal
                bool accesoprevio = false;
                bool AccesoAdmin = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        accesoprevio = false;
                        break;
                    case 3://Medium Autorization
                        accesoprevio = false;
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = AccesoAdmin = true;
                        frmCotizacionesHome frm = new frmCotizacionesHome(this.UsuarioLogeado, puntoVenta1, AccesoAdmin);
                        //frmHomePedidosClientes frm = new frmHomePedidosClientes(this.UsuarioLogeado, puntoVenta1);
                        frm.MdiParent = this.MdiParent;
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        frm.Show();
                        frm.BringToFront();
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(28))
                    {
                        frmCotizacionesHome frm = new frmCotizacionesHome(this.UsuarioLogeado, puntoVenta1, AccesoAdmin);
                        //frmHomePedidosClientes frm = new frmHomePedidosClientes(this.UsuarioLogeado, puntoVenta1);
                        frm.MdiParent = this.MdiParent;
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        frm.Show();
                        frm.BringToFront();
                    }
                    else
                    {
                        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #28 (Cotizaciones)");
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarItem252_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            try
            {
                //AFC_ConsumoReal
                bool accesoprevio = false;
                bool AccesoAdmin = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        accesoprevio = false;
                        break;
                    case 3://Medium Autorization
                        accesoprevio = false;
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = AccesoAdmin = true;
                        frmProveedorMainPagos frm = new frmProveedorMainPagos(this.UsuarioLogeado, puntoVenta1);
                        frm.MdiParent = this.MdiParent;
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        frm.Show();
                        frm.BringToFront();
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(29))
                    {
                        frmProveedorMainPagos frm = new frmProveedorMainPagos(this.UsuarioLogeado, puntoVenta1);
                        frm.MdiParent = this.MdiParent;
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        frm.Show();
                        frm.BringToFront();
                    }
                    else
                    {
                        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #28 (Cotizaciones)");
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarItem253_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            try
            {
                //AFC_ConsumoReal
                bool accesoprevio = false;
                bool AccesoAdmin = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        accesoprevio = false;
                        break;
                    case 3://Medium Autorization
                        accesoprevio = false;
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = AccesoAdmin = true;
                        frmMainAnticipos frm = new frmMainAnticipos(this.UsuarioLogeado, puntoVenta1);
                        frm.MdiParent = this.MdiParent;
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        frm.Show();
                        frm.BringToFront();
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(30))
                    {
                        frmMainAnticipos frm = new frmMainAnticipos(this.UsuarioLogeado, puntoVenta1);
                        frm.MdiParent = this.MdiParent;
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        frm.Show();
                        frm.BringToFront();
                    }
                    else
                    {
                        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #28 (Cotizaciones)");
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarItem254_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }


            try
            {
                //AFC_ConsumoReal
                bool accesoprevio = false;
                bool AccesoAdmin = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        accesoprevio = false;
                        break;
                    case 3://Medium Autorization
                        accesoprevio = false;
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = AccesoAdmin = true;
                        frmRecuentoInventarioHome frm = new frmRecuentoInventarioHome(this.UsuarioLogeado, puntoVenta1);
                        frm.MdiParent = this.MdiParent;
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        frm.Show();
                        frm.BringToFront();
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(33))
                    {
                        frmRecuentoInventarioHome frm = new frmRecuentoInventarioHome(this.UsuarioLogeado, puntoVenta1);
                        frm.MdiParent = this.MdiParent;
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        frm.Show();
                        frm.BringToFront();
                    }
                    else
                    {
                        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #33 (Recuento de Inventario)");
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            
        }

        private void nBarConsultarAjusteInventario_LinkPressed(object sender, NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            try
            {
                //AFC_ConsumoReal
                bool accesoprevio = false;
                bool AccesoAdmin = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        accesoprevio = false;
                        break;
                    case 3://Medium Autorization
                        accesoprevio = false;
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = AccesoAdmin = true;
                        frmVerDetalleKardexTransactionsConsulta frm = new frmVerDetalleKardexTransactionsConsulta(this.UsuarioLogeado);
                        frm.MdiParent = this.MdiParent;
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        frm.Show();
                        frm.BringToFront();
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(36))
                    {
                        frmVerDetalleKardexTransactionsConsulta frm = new frmVerDetalleKardexTransactionsConsulta(this.UsuarioLogeado);
                        frm.MdiParent = this.MdiParent;
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        frm.Show();
                        frm.BringToFront();
                    }
                    else
                    {
                        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #36 (Consulta de Ajustes de Inventario)");
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarItem255_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {
                //AFC_ConsumoReal
                bool accesoprevio = false;
                bool AccesoAdmin = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        accesoprevio = false;
                        break;
                    case 3://Medium Autorization
                        accesoprevio = false;
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = AccesoAdmin = true;
                        frmPlanillaConf_IHSS_Home frm = new frmPlanillaConf_IHSS_Home(this.UsuarioLogeado);
                        frm.MdiParent = this.MdiParent;
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        frm.Show();
                        frm.BringToFront();
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(37))
                    {
                        frmPlanillaConf_IHSS_Home frm = new frmPlanillaConf_IHSS_Home(this.UsuarioLogeado);
                        frm.MdiParent = this.MdiParent;
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        frm.Show();
                        frm.BringToFront();
                    }
                    else
                    {
                        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #37 (Configuracion de IHSS)");
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarItem256_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();


            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este Equipo de Nombre: " + HostName + " no esta Configurado en ningun Punto de Venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este Equipo de Nombre: " + HostName + " no esta Configurado en ningun Punto de Venta!");
                return;
            }

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmEntrega mtx = new frmEntrega(UsuarioLogeado, puntoVenta1);
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();

                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(13))
                {
                    frmEntrega mtx = new frmEntrega(UsuarioLogeado, puntoVenta1);
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #VT-13 (Lista de Entrega)");
                }
            }
        }

        private void navBarItem257_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmActivosFijosHome mtx = new frmActivosFijosHome(UsuarioLogeado);
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();

                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(39))
                {
                    frmActivosFijosHome mtx = new frmActivosFijosHome(UsuarioLogeado);
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #VT-39 (Gestion de Activos Fijos)");
                }
            }
        }

        private void navBarItem258_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmCuentasContablesHome mtx = new frmCuentasContablesHome(UsuarioLogeado);
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();

                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(40))
                {
                    frmCuentasContablesHome mtx = new frmCuentasContablesHome(UsuarioLogeado);
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #VT-40 (Gestion de Cuentas Contables)");
                }
            }
            
        }
        //End Facturacion Usados



    }
}