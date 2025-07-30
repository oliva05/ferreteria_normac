using ACS.Classes;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.Layout;
using DevExpress.XtraSpreadsheet.Model;
using JAGUAR_PRO.Calidad.LoteConfConsumo;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Compras;
using JAGUAR_PRO.Mantenimientos.MaterialEmpaque.Model;
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

namespace JAGUAR_PRO.LogisticaJaguar
{
    public partial class frmAddFacturaProveedor : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        Proveedor ProveedorActual;
        FacturaProveedorH FacturaProveedorH_Actual;
        PDV PuntoVentaActual;
        int IdOrdenCompra = 0;
        public enum TipoAccionVentana
        {
            Insert = 1,
            Update = 2
        }

        TipoAccionVentana TipoAccionActualVentana;

        public frmAddFacturaProveedor(UserLogin pUsuarioLogeado, PDV pPVActual)
        {
            InitializeComponent();
            TipoAccionActualVentana = TipoAccionVentana.Insert;
            PuntoVentaActual = pPVActual; 
            FacturaProveedorH_Actual = new FacturaProveedorH();
            this.UsuarioLogeado = pUsuarioLogeado;
            dp = new DataOperations();
            dtFechaFactura.EditValue = dtHoraEntregado.EditValue = dtHoraRecibido.EditValue = dp.NowSetDateTime();
            if (UsuarioLogeado.ValidarNivelPermisos(3))
            {
                dtHoraRevisado.EditValue = dtHoraRecibido.EditValue;
                txtNombreRevisado.Text = pUsuarioLogeado.Nombre;
            }
            else
            {
                dtHoraRevisado.Enabled = false;
            }

            //LoadMateriasPrimas();
            LoadProveedoresList();
            LoadPresentacionFacturaList(); 
            LoadPresentacionJaguarList();
            LoadBodegaList();

            txtNombreRecibido.Text = pUsuarioLogeado.Nombre;
            tsWithCAI.IsOn = true;
        }

        public frmAddFacturaProveedor(UserLogin pUsuarioLogeado, TipoAccionVentana pTipoAccionVentana, Int64 pIdFacturaH)
        {
            InitializeComponent();
            TipoAccionActualVentana = pTipoAccionVentana;
            this.UsuarioLogeado = pUsuarioLogeado;
            FacturaProveedorH_Actual = new FacturaProveedorH();
            dp = new DataOperations();
         
            switch (TipoAccionActualVentana)
            {
                case TipoAccionVentana.Insert:
                    
                    dtFechaFactura.EditValue = dtHoraEntregado.EditValue = dtHoraRecibido.EditValue = dp.NowSetDateTime();
                    txtNombreRecibido.Text = pUsuarioLogeado.Nombre;

                    if (UsuarioLogeado.ValidarNivelPermisos(3))
                    {
                        dtHoraRevisado.EditValue = dtHoraRecibido.EditValue;
                        txtNombreRevisado.Text = pUsuarioLogeado.Nombre;
                    }
                    else
                    {
                        dtHoraRevisado.Enabled = false;
                    }

                    LoadMateriasPrimas();
                    LoadProveedoresList();
                    LoadPresentacionFacturaList();
                    LoadPresentacionJaguarList();
                    LoadBodegaList();

                    
                    break;
                case TipoAccionVentana.Update: //************* UPDATE CASE *****************//
                    if (FacturaProveedorH_Actual.RecuperarRegistro(pIdFacturaH))
                    {
                        dtFechaFactura.EditValue = FacturaProveedorH_Actual.fecha_factura;
                        dtHoraEntregado.EditValue = FacturaProveedorH_Actual.fecha_registro;
                        dtHoraRecibido.EditValue = FacturaProveedorH_Actual.fecha_registro;
                        
                        txtNumeroFactura.Text = FacturaProveedorH_Actual.factura;
                        

                        if (UsuarioLogeado.ValidarNivelPermisos(3))
                        {
                            dtHoraRevisado.EditValue = FacturaProveedorH_Actual.hora_revisado;
                            txtNombreRevisado.Text = FacturaProveedorH_Actual.usuario_revisado_name;
                        }
                        else
                        {
                            dtHoraRevisado.Enabled = false;
                        }

                        LoadMateriasPrimas();
                        LoadProveedoresList();
                        LoadPresentacionFacturaList();
                        LoadPresentacionJaguarList();
                        LoadBodegaList();

                        gridLookUpEditProveedor.EditValue = FacturaProveedorH_Actual.id_proveedor;
                        LoadProveedoresCAIList(FacturaProveedorH_Actual.id_proveedor);
                        ProveedorActual = new Proveedor();
                        ProveedorActual.RecuperarRegistro(FacturaProveedorH_Actual.id_proveedor);
                        //gridLookUpEdit_CAI_Proveedor.Text = FacturaProveedorH_Actual.cai;
                        if (FacturaProveedorH_Actual.IdCai == 0)
                        {
                            txtCAI.Text = FacturaProveedorH_Actual.cai;
                            txtCAI.Visible = true;
                            gridLookUpEdit_CAI_Proveedor.Visible = false;
                        }
                        else
                        {
                            gridLookUpEdit_CAI_Proveedor.EditValueChanged -= new EventHandler(gridLookUpEdit_CAI_Proveedor_EditValueChanged);
                            gridLookUpEdit_CAI_Proveedor.EditValue = FacturaProveedorH_Actual.IdCai;
                            gridLookUpEdit_CAI_Proveedor.EditValueChanged += new EventHandler(gridLookUpEdit_CAI_Proveedor_EditValueChanged);

                            
                            txtCAI.Visible = false;
                            gridLookUpEdit_CAI_Proveedor.Visible = true;
                        }
                        
                        txtNombreEntrega.Text = FacturaProveedorH_Actual.entregado_por_nombre;
                        txtIdentidadEntrega.Text = FacturaProveedorH_Actual.entregado_por_identidad;
                        txtTelefonoEntrega.Text = FacturaProveedorH_Actual.entregado_por_telefono;
                        txtObservaciones.Text = FacturaProveedorH_Actual.observaciones;

                        txtNombreRecibido.Text = FacturaProveedorH_Actual.usuario_recibido_name;
                        LoadDetalleFactura(pIdFacturaH);

                        //Validar si tiene permisos de guardar cambios
                        //AFC_ConsumoReal
                        bool accesoprevio = false;
                        int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
                        switch (idNivel)
                        {
                            case 1://Basic View
                            case 2://Basic No Autorization
                            case 3://Medium Autorization
                                cmdGuardar.Visible = false;
                                break;
                            case 4://Depth With Delta
                            case 5://Depth Without Delta
                                accesoprevio = true;
                                cmdGuardar.Visible = true;
                                break;
                            default:
                                cmdGuardar.Visible = false;
                                break;
                        }

                        if (!accesoprevio)
                        {
                            if (UsuarioLogeado.ValidarNivelPermisos(7))
                            {
                                cmdGuardar.Visible = true;
                            }
                            else
                            {
                                //CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #7 (Revisión de Facturas Entrada Mercancias)");
                            }
                        }
                    }
                    cmdGuardar.Visible = false;
                    cmdAddFactura.Visible = false;
                    gridView2.Columns["eliminar"].Visible = false;

                    gridView2.OptionsMenu.EnableColumnMenu = true;
                    foreach (GridColumn column in gridView2.Columns)
                    {
                        column.OptionsColumn.ReadOnly = true;
                    }
                    break;
            }
        }

        private void LoadDetalleFactura(long pIdFacturaH)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_lines_invoice_supplier_D", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_facturah", pIdFacturaH);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsLogisticaJaguar1.detalle_recepcion_fact.Clear();
                adat.Fill(dsLogisticaJaguar1.detalle_recepcion_fact);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadMateriasPrimas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_producto_terminado_recepcion]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                dsLogisticaJaguar1.MP_List.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLogisticaJaguar1.MP_List);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadProveedoresList()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[Jaguar_sp_GetProveedores_id_descripcion]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                dsLogisticaJaguar1.proveedores_list.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLogisticaJaguar1.proveedores_list);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        private void LoadProveedoresCAIList(int pIdProveedor)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[JAGUAR_sp_Get_CAIByProveedor]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_proveedor", pIdProveedor);
                dsLogisticaJaguar1.CAI_List.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLogisticaJaguar1.CAI_List);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadPresentacionFacturaList()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_presentacion_for_producto_factura_prv]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_proveedor", pIdProveedor);
                dsLogisticaJaguar1.unidad_medida_factura.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLogisticaJaguar1.unidad_medida_factura);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        private void LoadPresentacionJaguarList()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_presentacion_for_producto_jaguar_recepcion]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_proveedor", pIdProveedor);
                dsLogisticaJaguar1.unidad_medida_jaguar.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLogisticaJaguar1.unidad_medida_jaguar);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadBodegaList()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.jaguar_sp_get_detalle_bodegas_list", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_proveedor", pIdProveedor);
                dsLogisticaJaguar1.bodegas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLogisticaJaguar1.bodegas);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        private void gridLookUpEditTipoPresentacion_EditValueChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(gridLookUpEditProveedor.Text))
            {
                DataOperations dp = new DataOperations();
                if (gridLookUpEditProveedor.EditValue != null) {
                    int idProveedor = dp.ValidateNumberInt32(gridLookUpEditProveedor.EditValue);
                    ProveedorActual = new Proveedor();
                    LoadProveedoresCAIList(idProveedor);
                    ProveedorActual.RecuperarRegistro(idProveedor);
                }
            }
        }

        private void cmdAddFactura_Click(object sender, EventArgs e)
        {
            DataTable tablaPT = new DataTable();
            frmSearchItemsMulti frm = new frmSearchItemsMulti();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                tablaPT = frm.ListProductosSeleccionados;
            }


            int count_lines = dsLogisticaJaguar1.detalle_recepcion_fact.Rows.Count;

            foreach (DataRow item in tablaPT.Rows)
            {
                bool yaExiste = dsLogisticaJaguar1.detalle_recepcion_fact.AsEnumerable()
                                .Any(p => p.id_mp == (int)item["id"]);

                if (!yaExiste)
                {
                    dsLogisticaJaguar.detalle_recepcion_factRow row1 = dsLogisticaJaguar1.detalle_recepcion_fact.Newdetalle_recepcion_factRow();
                    row1.cantidad = 0;
                    row1.cantidad_ingreso = 0;
                    row1.id_ud_medida_prv = 1;
                    row1.id_ud_medida_jaguar = 1;
                    row1.id_mp = Convert.ToInt32(item["id"]);
                    row1.descripcion_mp = Convert.ToString(item["descripcion"]);
                    row1.costo_unitario = 0;
                    row1.isv = 0;
                    row1.ItemCode = item["code"].ToString();
                    row1.total_fila = 0;

                    row1.num_linea = count_lines + 1;
                    row1.porcentaje_utilidad = 0;
                    row1.precio_venta = 0;
                    ProductoTerminado pt = new ProductoTerminado();
                    row1.id_bodega = pt.GetAlmacenDefault(Convert.ToInt32(item["id"]));
                    //row1.id_bodega = 3;
                    dsLogisticaJaguar1.detalle_recepcion_fact.Adddetalle_recepcion_factRow(row1);
                    dsLogisticaJaguar1.AcceptChanges();
                }

                
            }

            if (dsLogisticaJaguar1.detalle_recepcion_fact.Count > 1)
            {
                int filai = 1;
                foreach (dsLogisticaJaguar.detalle_recepcion_factRow row in dsLogisticaJaguar1.detalle_recepcion_fact.Rows)
                {
                    row.num_linea = filai;
                    filai++;
                }
            }

            //int count_lines = dsLogisticaJaguar1.detalle_recepcion_fact.Rows.Count;

            //dsLogisticaJaguar.detalle_recepcion_factRow row1 = dsLogisticaJaguar1.detalle_recepcion_fact.Newdetalle_recepcion_factRow();
            ////row1.cantidad = 0;
            ////row1.cantidad_ingreso = 0;
            //row1.id_ud_medida_prv = 1;
            //row1.id_ud_medida_jaguar = 1;
            //row1.id_mp = 0;
            ////row1.ItemCode = "";
            ////row1.total_fila = 0;

            //row1.num_linea = count_lines + 1;
            //row1.id_bodega = 1;
            //dsLogisticaJaguar1.detalle_recepcion_fact.Adddetalle_recepcion_factRow(row1);
            //dsLogisticaJaguar1.AcceptChanges();


            //if (dsLogisticaJaguar1.detalle_recepcion_fact.Count > 1)
            //{
            //    int filai = 1;
            //    foreach(dsLogisticaJaguar.detalle_recepcion_factRow row in dsLogisticaJaguar1.detalle_recepcion_fact.Rows)
            //    {
            //        row.num_linea = filai;
            //        filai++;
            //    }
            //}
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DataOperations dp = new DataOperations();
            var gridView0 = (GridView)gridControl1.FocusedView;
            var row0 = (dsLogisticaJaguar.detalle_recepcion_factRow)gridView0.GetFocusedDataRow();
            decimal PrecioConISV = 0;
            Impuesto impuesto = new Impuesto();
            switch (e.Column.FieldName)
            {
                case "isv_aplicable":

                    row0.isv = row0.costo_unitario * (row0.isv_aplicable / 100m);
                    PrecioConISV = row0.costo_unitario + row0.isv;
                    row0.total_fila = Math.Round(( PrecioConISV * row0.cantidad_ingreso),2);

                    break;
                case "cantidad":

                    row0.isv = row0.costo_unitario * (row0.isv_aplicable / 100m);
                    PrecioConISV = row0.costo_unitario + row0.isv;
                    row0.total_fila = Math.Round((PrecioConISV * row0.cantidad_ingreso),2);

                    //row0.total_fila = row0.cantidad * row0.costo_unitario;
                    //impuesto.RecuperarRegistro(1);
                    //row0.isv = (row0.total_fila * impuesto.Valor) / 100;

                    //row0.total_fila = row0.cantidad * row0.costo_unitario + row0.isv;

                    break;

                case "cantidad_ingreso":
                    row0.isv = row0.costo_unitario * (row0.isv_aplicable / 100m);
                    PrecioConISV = row0.costo_unitario + row0.isv;
                    row0.total_fila = Math.Round((PrecioConISV * row0.cantidad_ingreso),2);
                    break;
                case "costo_unitario":
                    row0.isv = row0.costo_unitario * (row0.isv_aplicable / 100m);
                    PrecioConISV = row0.costo_unitario + row0.isv;
                    row0.total_fila = Math.Round((PrecioConISV * row0.cantidad_ingreso),2);
                    //row0.total_fila = row0.cantidad * row0.costo_unitario;
                    //impuesto.RecuperarRegistro(1);
                    //row0.isv = (row0.total_fila * impuesto.Valor) / 100;

                    //row0.total_fila = row0.cantidad * row0.costo_unitario + row0.isv;
                    break;

                case "isv":

                    row0.total_fila = Math.Round((row0.cantidad * row0.costo_unitario + row0.isv),2);

                    break;

                case "id_ud_medida_prv":
                case "id_ud_medida_jaguar":
                    var gridView = (GridView)gridControl1.FocusedView;
                    var row = (dsLogisticaJaguar.detalle_recepcion_factRow)gridView.GetFocusedDataRow();
                    
                    int idOrigen = dp.ValidateNumberInt32(row.id_ud_medida_prv);
                    int idDestino = dp.ValidateNumberInt32(row.id_ud_medida_jaguar);

                    if(idOrigen>0 && idDestino > 0)
                    {
                        PresentacionX Pres1 = new PresentacionX();
                        decimal factor = Pres1.Factor_conversion(idOrigen, idDestino);

                        if(factor > 0)
                        {
                            row.cantidad_ingreso = (row.cantidad * factor);
                        }
                    }
                    
                    break;
                case "id_mp":
                    var gridView1 = (GridView)gridControl1.FocusedView;
                    var row1 = (dsLogisticaJaguar.detalle_recepcion_factRow)gridView1.GetFocusedDataRow();

                    ProductoTerminado pt = new ProductoTerminado();
                    if (pt.Recuperar_producto(row1.id_mp))
                    {
                        row1.id_ud_medida_jaguar = pt.Id_presentacion;
                        idOrigen = dp.ValidateNumberInt32(row1.id_ud_medida_prv);
                        idDestino = dp.ValidateNumberInt32(row1.id_ud_medida_jaguar);
                        row1.ItemCode = pt.Code;
                        row1.descripcion_mp = pt.Descripcion;

                        if (idOrigen > 0 && idDestino > 0)
                        {
                            PresentacionX Pres1 = new PresentacionX();
                            decimal factor = Pres1.Factor_conversion(idOrigen, idDestino);

                            if (factor > 0)
                            {
                                row1.cantidad_ingreso = (row1.cantidad * factor);
                            }
                        }
                    }
                    break;
                case "ItemCode":
                    var gridView2 = (GridView)gridControl1.FocusedView;
                    var row2 = (dsLogisticaJaguar.detalle_recepcion_factRow)gridView2.GetFocusedDataRow();

                    if (row2.ItemCode.Contains("MP"))
                    {
                        MateriaPrima mp2 = new MateriaPrima();
                        if (mp2.RecuperarRegistroFromItemCode(row2.ItemCode))
                        {
                            row2.id_ud_medida_jaguar = mp2.IdPresentacionDefault;
                            idOrigen = dp.ValidateNumberInt32(row2.id_ud_medida_prv);
                            idDestino = dp.ValidateNumberInt32(row2.id_ud_medida_jaguar);
                            row2.ItemCode = mp2.Codigo;
                            row2.id_mp = mp2.IdMP_ACS;
                            row2.descripcion_mp = mp2.NameComercial;
                            row2.type_id = 1;//MP

                            if (idOrigen > 0 && idDestino > 0)
                            {
                                PresentacionX Pres1 = new PresentacionX();
                                decimal factor = Pres1.Factor_conversion(idOrigen, idDestino);

                                if (factor > 0)
                                {
                                    row2.cantidad_ingreso = (row2.cantidad * factor);
                                }
                            }
                        }
                    }
                    else
                    {
                        Material_Empaque mp2 = new Material_Empaque();
                        if (mp2.RecuperaRegistroFromItemCode(row2.ItemCode))
                        {
                            row2.id_ud_medida_jaguar = mp2.PresentacionID;
                            idOrigen = dp.ValidateNumberInt32(row2.id_ud_medida_prv);
                            idDestino = dp.ValidateNumberInt32(row2.id_ud_medida_jaguar);
                            row2.ItemCode = mp2.Codigo;
                            row2.descripcion_mp = mp2.Material;
                            row2.type_id = 2;//ME
                            row2.id_mp = mp2.ID;

                            if (idOrigen > 0 && idDestino > 0)
                            {
                                PresentacionX Pres1 = new PresentacionX();
                                decimal factor = Pres1.Factor_conversion(idOrigen, idDestino);

                                if (factor > 0)
                                {
                                    row2.cantidad_ingreso = (row2.cantidad * factor);
                                }
                            }
                        }
                    }

                    

                    break;
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (!dp.ValidateNumberStringText(gridLookUpEditProveedor.Text))
            {
                CajaDialogo.Error("Es necesario seleccionar el proveedor!");
                return;
            }

            if (!ProveedorActual.Recuperado)
            {
                CajaDialogo.Error("Es necesario seleccionar el proveedor!");
                return;
            }

            

            if (!dp.ValidateNumberStringText(txtNumeroFactura.Text))
            {
                CajaDialogo.Error("Es necesario ingresar el número de la Factura!");
                return;
            }

            if (!dp.ValidateNumberStringText(dtFechaFactura.Text))
            {
                CajaDialogo.Error("Es necesario indicar la fecha de la Factura!");
                return;
            }

            if (dsLogisticaJaguar1.detalle_recepcion_fact.Rows.Count == 0)
            {
                CajaDialogo.Error("Es necesario indicar el detalle de lineas de la Factura!");
                return;
            }

            if (tsWithCAI.IsOn)
            {
                if (!dp.ValidateNumberStringText(gridLookUpEdit_CAI_Proveedor.Text))
                {
                    CajaDialogo.Error("Es necesario seleccionar el CAI del Proveedor!");
                    return;
                }
            }
            else //tsWithCAI.IsOn = false
            {
                if (!dp.ValidateNumberStringText(txtCAI.Text))
                {
                    CajaDialogo.Error("Es necesario escribir el CAI del Proveedor!");
                    return;
                }
            }

            bool Problemas = false;
            int fila = 0;
            foreach (dsLogisticaJaguar.detalle_recepcion_factRow row in dsLogisticaJaguar1.detalle_recepcion_fact.Rows)
            {
                
                //if (row.type_id == 1)
                //{
                    if (row.cantidad == 0 || row.id_ud_medida_prv == 0 ||
                        row.cantidad_ingreso == 0 || row.id_ud_medida_jaguar == 0 ||
                        row.id_mp == 0 || row.total_fila == 0)
                    {
                        Problemas = true;
                        fila = row.num_linea;
                        break;
                    }
                //}
                //else
                //{
                //    if (row.cantidad == 0 || row.id_ud_medida_prv == 0 ||
                //        row.cantidad_ingreso == 0 || row.id_ud_medida_jaguar == 0 ||
                //        row. == 0 || row.total_fila == 0)
                //    {
                //        Problemas = true;
                //        fila = row.num_linea;
                //        break;
                //    }
                //}
            }

            if (Problemas)
            {
                CajaDialogo.Error("Se encontraron datos incompletos en el detalle de lineas de factura! Linea: " + fila.ToString());
                return;
            }

            try
            {

                DataOperations dp = new DataOperations();
                using (SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    connection.Open();

                    SqlCommand cmd = connection.CreateCommand();
                    SqlTransaction transaction;

                    // Start a local transaction.
                    transaction = connection.BeginTransaction("SampleTransaction");

                    // Must assign both transaction object and connection
                    cmd.Connection = connection;
                    cmd.Transaction = transaction;

                    try
                    {

                        if (TipoAccionActualVentana == TipoAccionVentana.Insert)
                        {
                            //Insert Header
                            cmd.CommandText = "[dbo].[jaguar_sp_insert_recepcion_factura_compra_v2]";
                            cmd.CommandType = CommandType.StoredProcedure;
                        }
                        else
                        {
                            //Update Header
                            cmd.CommandText = "[dbo].[jaguar_sp_update_recepcion_factura_compra]";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_header", FacturaProveedorH_Actual.idFacturaH);
                        }
                        
                        cmd.Parameters.AddWithValue("@id_proveedor", gridLookUpEditProveedor.EditValue);
                        cmd.Parameters.AddWithValue("@id_usuario_recibido", UsuarioLogeado.Id);
                        

                        if (tsWithCAI.IsOn)
                        {
                            cmd.Parameters.AddWithValue("@id_cai", gridLookUpEdit_CAI_Proveedor.EditValue);
                            cmd.Parameters.AddWithValue("@cai", gridLookUpEdit_CAI_Proveedor.Text);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@id_cai", DBNull.Value);
                            cmd.Parameters.AddWithValue("@cai", txtCAI.Text);
                        }
                        

                        cmd.Parameters.AddWithValue("@factura", txtNumeroFactura.Text);
                        cmd.Parameters.AddWithValue("@fecha_factura", dtFechaFactura.EditValue);
                        cmd.Parameters.AddWithValue("@entregado_por_nombre", txtNombreEntrega.Text);
                        cmd.Parameters.AddWithValue("@entregado_por_identidad", txtIdentidadEntrega.Text);
                        cmd.Parameters.AddWithValue("@entregado_por_hora", dtHoraEntregado.EditValue);
                        cmd.Parameters.AddWithValue("@entregado_por_telefono", txtTelefonoEntrega.Text);
                        
                        if(string.IsNullOrEmpty(dtHoraRevisado.Text))
                            cmd.Parameters.AddWithValue("@id_usuario_revisado", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@id_usuario_revisado", this.UsuarioLogeado.Id);

                        if (string.IsNullOrEmpty(dtHoraRevisado.Text))
                            cmd.Parameters.AddWithValue("@hora_revisado", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@hora_revisado", dtHoraRevisado.EditValue);

                        cmd.Parameters.AddWithValue("@observaciones", txtObservaciones.Text);
                        if (IdOrdenCompra == 0)
                            cmd.Parameters.AddWithValue("@id_orden_compra", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@id_orden_compra", IdOrdenCompra);

                        int id_H = 0;


                        if (TipoAccionActualVentana == TipoAccionVentana.Insert)
                            id_H = dp.ValidateNumberInt32(cmd.ExecuteScalar());
                        else
                            cmd.ExecuteNonQuery();

                        //Insert Detalle y transaccion de kardex
                        foreach (dsLogisticaJaguar.detalle_recepcion_factRow row in dsLogisticaJaguar1.detalle_recepcion_fact.Rows)
                        {
                            cmd.Parameters.Clear();
                            if (TipoAccionActualVentana == TipoAccionVentana.Insert)
                            {
                                //Insert Detalle
                                cmd.CommandText = "[dbo].[sp_set_insert_detalle_factura_proveedor_d_v4_compra_pt]"; 
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_factura_h", id_H);//Header id recien insertado en la transaccion
                            }
                            else
                            {
                                Int64 id_linea_new = 0;
                                try
                                {
                                    id_linea_new = row.id;
                                }
                                catch { }

                                if(id_linea_new == 0)
                                {
                                    cmd.CommandText = "[dbo].[sp_set_insert_detalle_factura_proveedor_d_v4_compra_pt]";
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@id_factura_h", FacturaProveedorH_Actual.idFacturaH);
                                }
                                else
                                {
                                    cmd.CommandText = "[dbo].[sp_set_update_detalle_factura_proveedor_d_v4_compra_pt]";
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@id_linea_detalle", row.id);
                                    cmd.Parameters.AddWithValue("@id_factura_h", FacturaProveedorH_Actual.idFacturaH);
                                }
                                
                            }
                            //cmd.CommandText = "[dbo].[sp_set_insert_detalle_factura_proveedor_d_v2]";
                            //cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@cantidad_factura", row.cantidad);
                            cmd.Parameters.AddWithValue("@id_unidad_medida_factura", row.id_ud_medida_prv);
                            cmd.Parameters.AddWithValue("@descripcion", row.descripcion_mp);
                            cmd.Parameters.AddWithValue("@cantidad_entrada", row.cantidad_ingreso);
                            cmd.Parameters.AddWithValue("@id_unidad_medida_entrada", row.id_ud_medida_jaguar);
                            cmd.Parameters.AddWithValue("@total_linea", row.total_fila);
                            cmd.Parameters.AddWithValue("@id_producto_terminado", row.id_mp);
                            cmd.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
                            cmd.Parameters.AddWithValue("@num_factura", txtNumeroFactura.Text);
                            cmd.Parameters.AddWithValue("@item_code", row.ItemCode);
                            cmd.Parameters.AddWithValue("@id_bodega", 1);//row.id_bodega);
                            cmd.Parameters.AddWithValue("@codigo_proveedor", ProveedorActual.Jaguar_codigo);
                            cmd.Parameters.AddWithValue("@tipo_item", DBNull.Value);
                            cmd.Parameters.AddWithValue("@isv", row.isv);
                            cmd.Parameters.AddWithValue("@costo_unitario", row.costo_unitario);
                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ec)
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ec.Message);
                    }
                }//End using
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }



        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Esta seguro de eliminar esta linea?");
            if (r != DialogResult.Yes)
                return;

            var gridView1 = (GridView)gridControl1.FocusedView;
            var row = (dsLogisticaJaguar.detalle_recepcion_factRow)gridView1.GetFocusedDataRow();

            try
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                dsLogisticaJaguar1.AcceptChanges();
                if (dsLogisticaJaguar1.detalle_recepcion_fact.Count > 1)
                {
                    int filai = 1;
                    foreach (dsLogisticaJaguar.detalle_recepcion_factRow rowx in dsLogisticaJaguar1.detalle_recepcion_fact.Rows)
                    {
                        rowx.num_linea = filai;
                        filai++;
                    }
                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

        }

        private void btnCopyOC_Click(object sender, EventArgs e)
        {
            
        }

        private void CargarInfoOC(int pidOrdenesSeleccionado)
        {
            OrdenesCompra oc = new OrdenesCompra();
            if (oc.RecuperarRegistos(pidOrdenesSeleccionado))
            {
                Proveedor prov = new Proveedor();
                prov.RecuperarRegistroByCodigo(oc.Itemcode_Prov);
                gridLookUpEditProveedor.EditValue = prov.Jaguar_id;
                IdOrdenCompra = oc.Id_OrdenCompra;
                txtObservaciones.Text = oc.Comentario;

                
                CargarDetalleOrdenCompra(oc.Id_OrdenCompra);
               
            }


        }

        private void CargarDetalleOrdenCompra(int idSolicitudSeleccionado)
        {

            try
            {
                string query = @"[sp_get_obetener_detalle_oc_para_factura_prov]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ordenCompra", idSolicitudSeleccionado);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                //dsCompras1.oc_detalle.Clear();
                //adat.Fill(dsCompras1.oc_detalle);
                dsLogisticaJaguar1.detalle_recepcion_fact.Clear();
                adat.Fill(dsLogisticaJaguar1.detalle_recepcion_fact);
                conn.Close();

                //CALCULAR TOTALES
                foreach (dsLogisticaJaguar.detalle_recepcion_factRow item in dsLogisticaJaguar1.detalle_recepcion_fact)
                {
                    item.isv = item.costo_unitario * (item.isv_aplicable / 100m);
                    decimal ValorProductoConISV = item.costo_unitario + item.isv;
                    
                    item.total_fila = item.cantidad_ingreso * ValorProductoConISV;
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void barButtonOC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSearchOrdenesC frm = new frmSearchOrdenesC(frmSearchOrdenesC.FiltroOrdenesCompra.Abiertas, PuntoVentaActual, UsuarioLogeado, frmSearchOrdenesC.TipoDoc.OrdenCompra);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.IdOrdenesSeleccionado != 0)
                {
                    CargarInfoOC(frm.IdOrdenesSeleccionado);
                }
            }
        }

        private void btnCopiarDe_Click(object sender, EventArgs e)
        {
            popupMenu1.ShowPopup(Cursor.Position);
        }

        private void tsWithCAI_Toggled(object sender, EventArgs e)
        {
            if (tsWithCAI.IsOn)
            {
                gridLookUpEdit_CAI_Proveedor.Visible = true;
                txtCAI.Visible = false;
            }
            else
            {
                gridLookUpEdit_CAI_Proveedor.Visible = false;
                txtCAI.Visible = true;
            }
        }

        private void gle_MP_y_ME_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsLogisticaJaguar.detalle_recepcion_factRow)gridview.GetFocusedDataRow();

            //GridLookUpEdit editor = gridView6.ActiveEditor as GridLookUpEdit;
            //if (editor != null)
            //{
            //    var editValue = editor.EditValue; // ← Aquí está el valor (ValueMember)
            //    row.id_mp = Convert.ToInt32(editValue);
            //}

        }

        private void gle_MP_y_ME_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void gridLookUpEdit_CAI_Proveedor_EditValueChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = gridLookUpEdit_CAI_Proveedor.Properties.View.GetRow(gridLookUpEdit_CAI_Proveedor.Properties.View.FocusedRowHandle) as DataRowView;
            //txtNumeroFactura.Text = selectedRow["leyenda"].ToString();
            txtNumeroFactura.Text = dp.ValidateNumberString(selectedRow["leyenda"]);
        }
    }
}