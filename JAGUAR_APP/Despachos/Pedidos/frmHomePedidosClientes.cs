using ACS.Classes;
using DevExpress.Pdf.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraNavBar;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSpreadsheet.Import.Xls;
using DocumentFormat.OpenXml.Office2010.Excel;
using Eatery.Ventas;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Facturacion.CoreFacturas;
using JAGUAR_PRO.Facturacion.Reportes;
using JAGUAR_PRO.LogisticaJaguar;
using JAGUAR_PRO.Utileria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO.Despachos.Pedidos
{
    public partial class frmHomePedidosClientes : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        FacturacionEquipo equipo;
        PDV PuntoVentaActual;
        Vendedor VendedorActual;
        public frmHomePedidosClientes(UserLogin pUsuarioLogeado, PDV pPuntoVenta)
        {
            InitializeComponent();
            equipo = new FacturacionEquipo();
            UsuarioLogeado = pUsuarioLogeado;
            PuntoVentaActual = pPuntoVenta;
            dp = new DataOperations();
            DateTime fechaActual = dp.NowSetDateTime();
            DateTime FechaInicial = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, 0, 0, 0);

            DateTime FechaFinal = FechaInicial.AddDays(3);
            FechaInicial = FechaInicial.AddDays(-30);

            dtDesde.EditValue = FechaInicial;
            dtHasta.EditValue = FechaFinal;
            LoadDatos();

        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            switch (UsuarioLogeado.GrupoUsuarioActivo)
            {
                case GrupoUser.GrupoUsuario.Logistica:
                    break;
                case GrupoUser.GrupoUsuario.Administradores:
                    LoadDatos();
                    gridView1.OptionsMenu.EnableColumnMenu = true;//Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna, para elegir columnas, ordenar, etc
                    gridView1.Columns["facturar"].Visible = true; //Permite mostrar o ocultar una columna, se utiliza colocando el string de FieldName que se define desde el dataset
                    break;
                case GrupoUser.GrupoUsuario.RRHH:
                    break;
                case GrupoUser.GrupoUsuario.Contabilidad:
                    break;
                case GrupoUser.GrupoUsuario.Facturacion_Admin:
                    LoadDatos();
                    break;
                case GrupoUser.GrupoUsuario.Facturacion_EndUser:
                    //cmdChangeVendedor_Click(sender, e);
                    LoadDatos();
                    gridView1.OptionsMenu.EnableColumnMenu = false;//Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna, para elegir columnas, ordenar, etc
                    gridView1.Columns["facturar"].Visible = false; //Permite mostrar o ocultar una columna, se utiliza colocando el string de FieldName que se define desde el dataset
                    break;
                case GrupoUser.GrupoUsuario.Caja:
                    LoadDatos();
                    gridView1.OptionsMenu.EnableColumnMenu = false;//Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna, para elegir columnas, ordenar, etc
                    gridView1.Columns["facturar"].Visible = true; //Permite mostrar o ocultar una columna, se utiliza colocando el string de FieldName que se define desde el dataset
                    break;
                default:
                    break;
            }
        }

        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_listado_pedidos_clientes_venta_facturacion_user]", con);//Facturacion User por default
                switch (this.UsuarioLogeado.IdGrupo)
                {
                    
                    case 1://Logistica

                    break;
                    case 2://Admin
                        cmd = new SqlCommand("[sp_get_listado_pedidos_clientes_venta_v6]", con);
                        break;
                    case 3://RRHH
                    break;
                    case 4://Contabilidad
                    break;
                    case 5://Facturacion Admin
                        cmd = new SqlCommand("[sp_get_listado_pedidos_clientes_venta_v6]", con);
                        break;
                    case 6://Facturacion User
                        break;
                    case 7://Caja
                        cmd = new SqlCommand("sp_get_listado_pedidos_clientes_venta_v6", con);
                        break;
                    default:
                        break;
                }
                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                cmd.Parameters.AddWithValue("@id_punto_venta", this.PuntoVentaActual.ID);
                cmd.Parameters.AddWithValue("@incluir_docs_cerrados", tggIncluirDocCerrados.IsOn);
                if (VendedorActual == null)
                    cmd.Parameters.AddWithValue("@id_vendedor", 0);
                else
                    cmd.Parameters.AddWithValue("@id_vendedor", VendedorActual.Id);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPedidosClientesV1.lista_pedidos.Clear();
                adat.Fill(dsPedidosClientesV1.lista_pedidos); 
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

        private void cmdEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Editar pedido
            string HostName = Dns.GetHostName();
            equipo = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsPedidosClientesV.lista_pedidosRow)gridView.GetFocusedDataRow();

            if (row != null)
            {
                if (!row.Isid_estadoNull())
                {
                    switch (row.id_estado)
                    {
                        case 1://Confirmado
                            CajaDialogo.Error("El pedido ya fue confirmado para pago, no se permite modificar!\nPuede crear un nuevo pedido copiando desde el numero de pedido actual...");
                        break;
                        case 2://Facturado
                            CajaDialogo.Error("El pedido ya fue facturado, no se permite modificar!\nPuede crear un nuevo pedido copiando desde el numero de pedido actual...");
                            break;
                        case 3://Entregado
                            CajaDialogo.Error("El pedido ya fue entregado, no se permite modificar!\nPuede crear un nuevo pedido copiando desde el numero de pedido actual...");
                            break; 
                        case 4://Cancelado
                            CajaDialogo.Error("El pedido ya fue cancelado, no se permite modificar!\nPuede crear un nuevo pedido copiando desde el numero de pedido actual...");
                            break;
                        case 5://Anulado
                            CajaDialogo.Error("El pedido ya fue anulado, no se permite modificar!\nPuede crear un nuevo pedido copiando desde el numero de pedido actual...");
                            break;
                        case 6://Nuevo
                            frmPedidoCliente frm = new frmPedidoCliente(this.UsuarioLogeado, puntoVenta1, equipo, row.id);
                            if (this.MdiParent != null)
                            {
                                frm.MdiParent = this.MdiParent;
                                frm.StartPosition = FormStartPosition.CenterParent;
                            }
                            frm.TopMost = true;
                            frm.Show();
                            break;
                        case 7://Parcialmente Entregado
                            CajaDialogo.Error("El pedido ya esta en proceso de entrega, no se permite modificar!\nPuede crear un nuevo pedido copiando desde el numero de pedido actual...");
                            break;
                        default:
                        break;
                    }
                    
                }
            }

            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string HostName = Dns.GetHostName();
            equipo = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (equipo.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(equipo.id_punto_venta))
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


            frmPedidoCliente frm = new frmPedidoCliente(this.UsuarioLogeado, puntoVenta1, equipo, VendedorActual);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                frm.StartPosition = FormStartPosition.CenterScreen;
            }

            frm.Show();
            //if(frm.ShowDialog() == DialogResult.OK)
            //{
            //    LoadDatos();
            //}
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Nueva version

            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;
                string path = "Inventario PT JAGUAR";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                    //Customize export options
                    (gridControl1.MainView as GridView).OptionsPrint.PrintHeader = true;
                    XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                    advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.SheetName = "Exported from JAGUAR";

                    gridControl1.ExportToXlsx(path, advOptions);
                    // Open the created XLSX file with the default application.
                    Process.Start(path);
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdImprimir_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            PedidoCliente ped1 = new PedidoCliente();
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsPedidosClientesV.lista_pedidosRow)gridView.GetFocusedDataRow();

            if (ped1.RecuperarRegistro(row.id))
            {
                rptPedidoCliente report = new rptPedidoCliente(ped1);// { DataSource = dsCompras1, DataMember = "oc_detalle", ShowPrintMarginsWarning = false };
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(report);
                report.ShowPrintMarginsWarning = false;

                printReport.ShowPreviewDialog();
            }
            
            
        }

        private void cmdCrearCotizacion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsPedidosClientesV.lista_pedidosRow)gridView.GetFocusedDataRow();
            frmCotizaciones frm = new frmCotizaciones(row.id, this.UsuarioLogeado, PuntoVentaActual, this.VendedorActual);
            frm.ShowDialog();

            ////Generar una nueva cotizacion 
            //DialogResult r = CajaDialogo.Pregunta("Esta seguro de generar una nueva cotización basado en esta pre factura?");
            //if (r != DialogResult.Yes)
            //    return;

            ////Generar la cotizacion 
            //try
            //{
            //    DataOperations dp = new DataOperations();
            //    SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            //    con.Open();

            //    SqlCommand cmd = new SqlCommand("[dbo].[sp_InsertCotizacion]", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@id_pedido", row.id);
            //    cmd.ExecuteScalar();

            //    con.Close();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void cmdFacturar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Generar factura
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
                    var gridView = (GridView)gridControl1.FocusedView;
                    var row = (dsPedidosClientesV.lista_pedidosRow)gridView.GetFocusedDataRow();
                    frmFactura frm = new frmFactura(this.UsuarioLogeado, puntoVenta1, EquipoActual, row.id);

                    frm.MdiParent = this.MdiParent;
                    frm.TopMost = true;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                UserLogin VendedorValidate = new UserLogin();
                if(VendedorActual == null)
                    VendedorActual = new Vendedor();

                if (VendedorValidate.Recuperado == false)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(15))
                    //if (VendedorValidate.ValidarNivelPermisos(15, VendedorActual.Id))
                    {
                        var gridView = (GridView)gridControl1.FocusedView;
                        var row = (dsPedidosClientesV.lista_pedidosRow)gridView.GetFocusedDataRow();
                        frmFactura frm = new frmFactura(this.UsuarioLogeado, puntoVenta1, EquipoActual, row.id);
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }
                    else
                    {
                        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #15 (Facturacion punto de venta)");
                    }
                }
                else
                {
                    if (VendedorValidate.RecuperarRegistro(VendedorActual.Id))
                    {
                        //if (UsuarioLogeado.ValidarNivelPermisos(15))
                        if (VendedorValidate.ValidarNivelPermisos(15, VendedorActual.Id))
                        {
                            var gridView = (GridView)gridControl1.FocusedView;
                            var row = (dsPedidosClientesV.lista_pedidosRow)gridView.GetFocusedDataRow();
                            frmFactura frm = new frmFactura(this.UsuarioLogeado, puntoVenta1, EquipoActual, row.id);
                            frm.MdiParent = this.MdiParent;
                            frm.Show();
                        }
                        else
                        {
                            CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #15 (Facturacion punto de venta)");
                        }
                    }
                }
                
            }
        }

        private void txtAsesorVendedor_DoubleClick(object sender, EventArgs e)
        {
            frmLoginVendedores frmLoginVendedores = new frmLoginVendedores();
            if (frmLoginVendedores.ShowDialog() == DialogResult.OK)
            {
                txtAsesorVendedor.Text = frmLoginVendedores.CodigoVendedor + " - " + frmLoginVendedores.NombreVendedor;
                VendedorActual = frmLoginVendedores.Vendedor_;               

                this.UsuarioLogeado = new UserLogin();
                if (UsuarioLogeado.RecuperarRegistro(VendedorActual.Id))
                {
                    cmdCargar_Click(sender, e);
                    
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
                if (UsuarioLogeado.RecuperarRegistro(VendedorActual.Id))
                {
                    cmdCargar_Click(sender, e);
                }
            }
            cmdCargar_Click(sender, e);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmChanguePinVendedores frm = new frmChanguePinVendedores();
            frm.ShowDialog();
        }
    }
}