using ACS.Classes;
using DevExpress.CodeParser;
using DevExpress.DashboardWin.Design;
using DevExpress.Internal;
using DevExpress.Office.Utils;
using DevExpress.Utils.CommonDialogs;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGauges.Core.Primitive;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSpreadsheet.Forms;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Compras;
using JAGUAR_PRO.Facturacion.CoreFacturas;
using JAGUAR_PRO.LogisticaJaguar;
using JAGUAR_PRO.Mantenimientos.Modelos;
using JAGUAR_PRO.Mantenimientos.ProductoTerminado;
using JAGUAR_PRO.Reportes;
using JAGUAR_PRO.TransaccionesMP;
using JAGUAR_PRO.TransaccionesPT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Image = System.Drawing.Image;

namespace JAGUAR_PRO.Mantenimientos.ProductoTerminado
{
    public partial class frmCRUD_ProductoTerminadoV2 : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        public enum TipoOperacion
        {
            Insert = 1,
            Update = 2
        }
        TipoOperacion TipoOperacionActual;
        Clases.ProductoTerminado PT_Class_instance;
        FTP_Class ftp = new FTP_Class();
        decimal CostoPorArroba;
        int IdPT;

        public decimal PrecioVenta;
        public decimal CostoActual;
        public decimal PorcentajeDescuento;
        public decimal PorcentajeUtilidad;

        public PDV PuntoVentaActual;

        public frmCRUD_ProductoTerminadoV2(UserLogin pUser, TipoOperacion pTipoOperacion, int pId_PT, PDV pPuntoVentaActual)
        {
            InitializeComponent();
            PuntoVentaActual = pPuntoVentaActual ?? new PDV();
            MagiaEmbellezedora();
           
            UsuarioLogeado = pUser;
            LoadPresentacionesPT();
            
            LoadTiposPT();
            LoadEstadosPT();
            LoadTipoFacturacion();
            LoadTipoInventario();
            LoadTipoDestinoFacturacion();
            LoadClasesProductoTerminado();
            LoadImpuestosAplicables();
            LoadConfiguracionAlmacenes(pId_PT);
            LoadMarcas();
            LoadFamilia();

            TipoOperacionActual = pTipoOperacion;
            PT_Class_instance = new Clases.ProductoTerminado();
            //defaultToolTipController1.SetToolTip(gridLookUpEditTipoFacturacionDestino, "Si el producto se programa para pedido(s) es de tipo producción!" +
            //                                                                            "\nSi el Producto no pasa por producción de panificadora es Factura Detalle.");
            switch (pTipoOperacion)
            {
                case TipoOperacion.Insert:
                    txtCodigoPT.Text = PT_Class_instance.GenerarSiguienteCodigoPT();
                    toggleSwitchEnablePT.IsOn = true;
                    toggleSwitchEnablePT.Enabled = false;
                    gridLookUpEdit_Presentaciones.EditValue = 1;

                    TabConfigVentas.PageVisible = false;


                    int contador = 0;
                    foreach (dsProductoTerminado.config_pt_invRow rowI in dsProductoTerminado1.config_pt_inv)
                    {
                        if(contador == 0)
                        {
                            rowI.fijado_como_estandar_bit = rowI.hablitado_bit = true;
                            rowI.fijado_como_estandar_descrip = rowI.hablitado_descrip = "Si";
                            contador++;
                        }
                        else
                        {
                            rowI.fijado_como_estandar_bit = false;
                            rowI.fijado_como_estandar_descrip = "No";
                            rowI.hablitado_descrip = "Si";
                            rowI.hablitado_bit = true;
                        }
                    }
                    break;
                case TipoOperacion.Update:
                    TabConfigVentas.PageVisible = true;
                    IdPT = pId_PT;
                    if (PT_Class_instance.Recuperar_producto(IdPT))
                    {
                        lblTituloVentana.Text = "Edición de Producto Terminado";
                        
                        //gridLookUpEditTipoProducto.EditValue = PT_Class_instance.Tipo_id;
                        gridLookUpEdit_Presentaciones.EditValue = PT_Class_instance.Id_presentacion;
                        txtDescripcionProducto.Text = PT_Class_instance.Descripcion;
                        toggleSwitchEnablePT.IsOn = PT_Class_instance.Enable;
                        txtCodigoPT.Text = PT_Class_instance.Code;
                        
                        txtCodigoInterno.Text = PT_Class_instance.Code_interno;

                        gridTipoInventario.EditValueChanged -= new EventHandler(gridTipoInventario_EditValueChanged);
                        gridTipoInventario.EditValue = PT_Class_instance.TipoInventario;
                        gridTipoInventario.EditValueChanged += new EventHandler(gridTipoInventario_EditValueChanged);

                        txtBarCode.Text = PT_Class_instance.Barcode;
                        txtOEM.Text = PT_Class_instance.CodeOEM;
                        grdMarca.EditValue = PT_Class_instance.IdMarca;

                        gle_ClaseProducto.EditValue = PT_Class_instance.Id_clase;
                        gleImpuestoAplicable.EditValue = PT_Class_instance.Id_isv_aplicable;

                        txtPorcentajeUtilidad.Text = string.Format("{0:###,##0.00}", PT_Class_instance.porcentaje_utilidad);
                        txtDescuentoMaximo.Text = string.Format("{0:###,##0.00}", PT_Class_instance.porcentaje_descuento);
                        PorcentajeUtilidad = PT_Class_instance.porcentaje_utilidad;
                        PorcentajeDescuento = PT_Class_instance.porcentaje_descuento;
                        tsComision.IsOn = PT_Class_instance.Pt_comisiona;
                        LoadFamilia();
                        CargarCategorias(0); 
                        CargarClases(0); 
                        CargarSubClases(0);
                        CargarDatosDeCostos(IdPT, PuntoVentaActual.ID);

                        if (PT_Class_instance.Id_Familia > 0)
                        {
                            grdTipoFamilia.EditValue = PT_Class_instance.Id_Familia;
                            if (PT_Class_instance.Id_Categoria > 0)
                            {
                                grdTipoCategoria.EditValue = PT_Class_instance.Id_Categoria;
                                if (PT_Class_instance.Id_clase > 0)
                                {
                                    grdTipoClase.EditValue = PT_Class_instance.Id_clase;
                                    if (PT_Class_instance.Id_sub_clase > 0)
                                    {
                                        grdSubClase.EditValue = PT_Class_instance.Id_sub_clase;
                                    }
                                }
                            }
                        }

                        txtCodigoReferencia.Text = PT_Class_instance.Codig_Referencia;

                        //grdSubClase.EditValue = PT_Class_instance.Id_sub_clase;

                        DataTable dtPTPic = new DataTable();
                        dtPTPic = PT_Class_instance.GetImagenesPT(IdPT);
                        

                        if (ftp.ValidateConnection() != false)
                        {
                            foreach (DataRow item in dtPTPic.Rows)
                            {
                                dsProductoTerminado.PTImagenesRow row1 = dsProductoTerminado1.PTImagenes.NewPTImagenesRow();
                                row1.id = (int)item.ItemArray[0];
                                row1.id_pt = (int)item.ItemArray[1];
                                row1.path = (string)item.ItemArray[2];
                                row1.file_name = (string)item.ItemArray[3];
                                row1.fecha_registro = (DateTime)item.ItemArray[4];
                                row1.user = (string)item.ItemArray[5];

                                Image img = ftp.ShowImageFromFtp(row1.path);
                                byte[] imgBytes = ImageToByteArray(img);
                                row1.imagen = imgBytes;

                                dsProductoTerminado1.PTImagenes.AddPTImagenesRow(row1);
                            }

                            lblStatusFTP.Visible = true;
                            lblStatusFTP.Text = "Servidor de Imagenes: DISPONIBLE";
                            lblStatusFTP.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblStatusFTP.Visible = true;
                            lblStatusFTP.Text = "Servidor de Imagenes: NO DISPONIBLE";
                            lblStatusFTP.ForeColor = Color.Red;
                        }
                        
                        

                        //gridLookUpEditTipoFacturacionDestino.TextChanged -= new EventHandler(gridLookUpEditTipoFacturacionDestino_TextChanged);
                        //gridLookUpEditTipoFacturacionDestino.Text = PT_Class_instance.TipoFacturacion_prd_name;
                        //gridLookUpEditTipoFacturacionDestino.TextChanged += new EventHandler(gridLookUpEditTipoFacturacionDestino_TextChanged);
                    }
                    break;
                default:

                    break;
            }
            
        }

        private void CargarDatosDeCostos(int pIdPt, int pIdPuntoVenta)
        {
            try
            {
                //SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                //connection.Open();
                //SqlCommand cmd = new SqlCommand("[]", connection);
                //cmd.CommandType = CommandType.StoredProcedure;
                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //dsProductoTerminado1.familia_select.Clear();
                //adapter.Fill(dsProductoTerminado1.familia_select);
                //connection.Close();
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                using (SqlCommand cmd = new SqlCommand("[dbo].[sp_get_precio_pt_from_lista_y_punto_venta_v2]", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_pt", System.Data.SqlDbType.Int).Value = pIdPt;
                    cmd.Parameters.Add("@id_punto_venta", System.Data.SqlDbType.Int).Value = pIdPuntoVenta;
                    cmd.Parameters.Add("@id_cliente", System.Data.SqlDbType.Int).Value = 0;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        //CostoActual = dr.GetDecimal(0);
                        PrecioVenta = dr.GetDecimal(0);
                        txtPrecioVenta.Text = string.Format("{0:###,##0.00}", PrecioVenta);
                    }
                    dr.Close();
                    cnx.Close();
                }

                using (SqlCommand cmd = new SqlCommand("[dbo].[sp_get_historial_de_compra_costo_pt]", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_pt", System.Data.SqlDbType.Int).Value = pIdPt;
                    //cmd.Parameters.Add("@id_punto_venta", System.Data.SqlDbType.Int).Value = pIdPuntoVenta;
                    //cmd.Parameters.Add("@id_cliente", System.Data.SqlDbType.Int).Value = 0;
                    dsDatosProductos1.historial_costo.Clear();
                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    adat.Fill(dsDatosProductos1.historial_costo);
                    cnx.Close();

                    if (dsDatosProductos1.historial_costo.Rows.Count > 0)
                    {
                        foreach(dsDatosProductos.historial_costoRow row in dsDatosProductos1.historial_costo)
                        {
                            if (row.costo > 0)
                            {
                                CostoActual = row.costo;
                                txtCostoActual.Text = string.Format("{0:###,##0.00}", CostoActual);
                                break;
                            }
                        }
                    }
                    else
                    {
                        CostoActual = 0;
                        txtCostoActual.Text = string.Format("{0:###,##0.00}", CostoActual);
                    }
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadFamilia()
        {
            try
            {
                SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                connection.Open();
                SqlCommand cmd = new SqlCommand("[sp_pt_get_familia_activo]", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                dsProductoTerminado1.familia_select.Clear();
                adapter.Fill(dsProductoTerminado1.familia_select);
                connection.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadMarcas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_pt_get_marcas_activos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsProductoTerminado1.lista_marcas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProductoTerminado1.lista_marcas);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void MagiaEmbellezedora()
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("The Bezier");
            //DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("WXI Compact");
            gridView9.OptionsView.EnableAppearanceEvenRow = true;
            gridView9.OptionsView.EnableAppearanceOddRow = true;
            gridView9.Appearance.Row.BackColor = Color.LightGray;
            gridView9.Appearance.OddRow.BackColor = Color.White;

        }

        private void LoadSubClases()
        {
            
        }

        private void LoadClasesProductoTerminado()
        {
            //
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_lista_clases_para_producto_terminado]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                dsProductoTerminado1.claseProducto.Clear();
                sqlDataAdapter.Fill(dsProductoTerminado1.claseProducto);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadImpuestosAplicables()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].sp_get_lista_impuestos_aplicables_for_crud_pt", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                dsProductoTerminado1.ImpuestoAplicable.Clear();
                sqlDataAdapter.Fill(dsProductoTerminado1.ImpuestoAplicable);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadPresentacionesPT()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_presentacion_pt", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsProductoTerminado1.presentaciones.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProductoTerminado1.presentaciones);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void LoadEstadosPT()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_estados_pt", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsProductoTerminado1.Estados.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProductoTerminado1.Estados);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void LoadTiposPT()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_tipo_pt", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsProductoTerminado1.TipoPT.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProductoTerminado1.TipoPT);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadTipoFacturacion()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                string sql = @"SELECT id,
                                   descripcion
                            FROM dbo.Facturacion_TipoFacturacion
                            WHERE enable = 1";

                SqlCommand cmd = new SqlCommand(sql, con);
                dsMantenimientosFacturacion.TipoFacturacion.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMantenimientosFacturacion.TipoFacturacion);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadTipoInventario()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                string sql = @"dbo.sp_get_pt_productos_tipo_inventario";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                dsProductoTerminado1.tipo_inventario.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProductoTerminado1.tipo_inventario);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        private void LoadTipoDestinoFacturacion()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                string sql = @"dbo.uspGetTipoFacturacionDestino";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                dsProductoTerminado1.tipo_facturacion_destino.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProductoTerminado1.tipo_facturacion_destino);
                con.Close();
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

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            
        }

      
        

        private void gridLookUpEditTipoFacturacionDestino_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridLookUpEditTipoFacturacionDestino_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if ((int)grdSubClase.EditValue > 0)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_pt_concatenacion_codigos", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", (int)grdSubClase.EditValue);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        switch (TipoOperacionActual)
                        {
                            case TipoOperacion.Insert:
                                txtCodigoInterno.Text = dr.GetString(0) + PT_Class_instance.GenerarSiguienteCodigoPTSoloNumero();
                                break;
                            case TipoOperacion.Update:
                                string solo_numero = txtCodigoPT.Text.Substring(2);
                                txtCodigoInterno.Text = dr.GetString(0) + solo_numero;
                                break;
                            default:
                                break;
                        }
                        
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
        }

        private void gridView8_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        private byte[] ImageToByteArray(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Guardar como JPG
                return ms.ToArray(); // Convertir a byte[]
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            if (ftp.ValidateConnection())
            {
                int contador = 0;
                try
                {
                    openFileDialog1.InitialDirectory = "c:\\";
                    openFileDialog1.Filter = "Files|*.jpg;*.jpeg;*.png;*.pdf;*.xlsx";

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        contador = 0;

                        Image img = Image.FromFile(openFileDialog1.FileName);
                        byte[] imgBytes = ImageToByteArray(img);

                        foreach (var item in openFileDialog1.SafeFileNames)
                        {
                            DataRow newRow = dsProductoTerminado1.PTImagenes.NewRow();
                            newRow["id"] = 0;
                            newRow["fecha_registro"] = DateTime.Now;
                            newRow["path"] = openFileDialog1.FileNames[contador];
                            newRow["file_name"] = item;
                            newRow["id_user"] = UsuarioLogeado.Id;
                            newRow["user"] = UsuarioLogeado.Nombre;
                            newRow["id_pt"] = IdPT;
                            newRow["imagen"] = imgBytes;
                            dsProductoTerminado1.PTImagenes.Rows.Add(newRow);
                            contador++;
                        }
                    }

                    lblStatusFTP.Visible = true;
                    lblStatusFTP.Text = "Servidor de Imagenes: DISPONIBLE";
                    lblStatusFTP.ForeColor = Color.Green;

                }
                catch (Exception ex)
                {
                    CajaDialogo.Show(ex.Message);
                }
            }
            else
            {
                lblStatusFTP.Visible = true;
                lblStatusFTP.Text = "Servidor de Imagenes: NO DISPONIBLE";
                lblStatusFTP.ForeColor = Color.Red;
            }
            
        }

        private void reposPictureItemImage_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gridLookUpEdit_Presentaciones.Text))
            {
                CajaDialogo.Error("Es necesario indicar la presentación!");
                return;
            }

            //if ((string)grdTipoFamilia.Text == "")
            //{
            //    CajaDialogo.Error("Debe Seleccionar una Familia!");
            //    return;
            //}
            //else
            //{
            //    if ((string)grdTipoCategoria.Text == "")
            //    {
            //        CajaDialogo.Error("Debe Seleccionar una Categoria!");
            //        return;
            //    }
            //    else
            //    {
            //        if ((string)grdTipoClase.Text == "")
            //        {
            //            CajaDialogo.Error("Debe Seleccionar una Clase!");
            //            return;
            //        }
            //        else
            //        {
            //            if ((string)grdSubClase.Text == "")
            //            {
            //                CajaDialogo.Error("Debe Seleccionar una SubClase!");
            //                return;
            //            }
            //        }
            //    }

            //}

            if (string.IsNullOrEmpty(txtDescripcionProducto.Text))
            {
                CajaDialogo.Error("Es necesario indicar el Nombre del Producto!");
                return;
            }

            if (string.IsNullOrEmpty(grdMarca.Text))
            {
                CajaDialogo.Error("Debe colocar la Marca del Producto!");
                return;
            }

            //if (string.IsNullOrEmpty(gridLookUpEditTipoProducto.Text))
            //{
            //    CajaDialogo.Error("Es necesario indicar el Destino del Producto!");
            //    return;
            //}


            if (string.IsNullOrEmpty(gridTipoInventario.Text))
            {
                CajaDialogo.Error("Es necesario indicar el Tipo de Producto!");
                return;
            }

            //if (string.IsNullOrEmpty(txtBarCode.Text))
            //{
            //    CajaDialogo.Error("Es necesario indicar el Codigo de Barra para el Escaneo!");
            //    return;
            //}


            //if (string.IsNullOrEmpty(glueTipoBuffet.Text))
            //{
            //    CajaDialogo.Error("Es necesario indicar un tipo de buffet del Producto!");
            //    return;
            //}

            //if (string.IsNullOrEmpty(glueTipoFacturacion.Text))
            //{
            //    CajaDialogo.Error("Es necesario indicar el tipo de facturación del Producto!");
            //    return;
            //}

            DialogResult r = CajaDialogo.Pregunta("Desea guardar los cambios?");
            if (r != DialogResult.Yes)
                return;


            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection Conn1 = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                Conn1.Open();
                SqlCommand cmd = new SqlCommand("", Conn1);
                cmd.CommandType = CommandType.StoredProcedure;
                switch (TipoOperacionActual)
                {
                    case TipoOperacion.Insert:
                        cmd.CommandText = "[dbo].[sp_set_insert_nuevo_producto_terminado_v7]";

                        break;
                    case TipoOperacion.Update:
                        cmd.CommandText = "[dbo].[sp_set_update_nuevo_producto_terminado_v7]";
                        cmd.Parameters.AddWithValue("@id", PT_Class_instance.Id);
                        break;
                }

                //if (!tggCosteoPorArroba.IsOn)
                //    CostoPorArroba = 0;

                cmd.Parameters.AddWithValue("@id_user_created", UsuarioLogeado.Id);
                cmd.Parameters.AddWithValue("@enable", toggleSwitchEnablePT.IsOn);
                cmd.Parameters.AddWithValue("@id_presentacion", gridLookUpEdit_Presentaciones.EditValue);
                cmd.Parameters.AddWithValue("@id_estado", 1);
                cmd.Parameters.AddWithValue("@descripcion", txtDescripcionProducto.Text);
                cmd.Parameters.AddWithValue("@code", txtCodigoPT.Text);
                cmd.Parameters.AddWithValue("@tipo_id", DBNull.Value/*gridLookUpEditTipoProducto.EditValue*/);
                cmd.Parameters.AddWithValue("@costo_mo_por_arroba", 0);
                cmd.Parameters.AddWithValue("@costo_por_arroba", CostoPorArroba);
                cmd.Parameters.AddWithValue("@id_tipo_facturacion", DBNull.Value /*glueTipoFacturacion.EditValue*/);

                //int id_tipoBuffet = dp.ValidateNumberInt32(glueTipoBuffet.EditValue);
                //if(id_tipoBuffet <= 0)
                cmd.Parameters.AddWithValue("@id_tipo_buffet", DBNull.Value);
                //else
                //    cmd.Parameters.AddWithValue("@id_tipo_buffet", glueTipoBuffet.EditValue);

                cmd.Parameters.AddWithValue("@id_tipo_facturacion_prd", DBNull.Value /*gridLookUpEditTipoFacturacionDestino.EditValue*/);

                //if(dp.ValidateNumberInt32(Convert.ToInt32(gle_ClaseProducto.EditValue))==0)
                if (string.IsNullOrEmpty(grdSubClase.Text) || (int)grdSubClase.EditValue == 0)
                    cmd.Parameters.AddWithValue("@id_clase", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@id_clase", dp.ValidateNumberInt32(grdTipoClase.EditValue));
                //else
                //    cmd.Parameters.AddWithValue("@id_clase", gle_ClaseProducto.EditValue);


                if (dp.ValidateNumberInt32(Convert.ToInt32(gleImpuestoAplicable.EditValue)) == 0)
                    cmd.Parameters.AddWithValue("@id_impuesto_aplicable", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@id_impuesto_aplicable", gleImpuestoAplicable.EditValue);

                cmd.Parameters.AddWithValue("@codigo_interno", txtCodigoInterno.Text);
                if (string.IsNullOrEmpty(grdSubClase.Text) || (int)grdSubClase.EditValue == 0)
                    cmd.Parameters.AddWithValue("@id_subClase", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@id_subClase", grdSubClase.EditValue);
                cmd.Parameters.AddWithValue("@idTipoInventario", gridTipoInventario.EditValue);
                cmd.Parameters.AddWithValue("@barcode", txtBarCode.Text.Trim());
                cmd.Parameters.AddWithValue("@codeOEM", txtOEM.Text.Trim());
                cmd.Parameters.AddWithValue("@id_marca", grdMarca.EditValue);
                if (string.IsNullOrEmpty(grdTipoFamilia.Text) || (int)grdTipoFamilia.EditValue == 0)
                    cmd.Parameters.AddWithValue("@id_familia", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@id_familia", dp.ValidateNumberInt32(grdTipoFamilia.EditValue));
                if (string.IsNullOrEmpty(grdTipoCategoria.Text) || (int)grdTipoCategoria.EditValue == 0)
                    cmd.Parameters.AddWithValue("@id_categoria", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@id_categoria", dp.ValidateNumberInt32(grdTipoCategoria.EditValue));

                cmd.Parameters.AddWithValue("@code_referencia", txtCodigoReferencia.Text);
                cmd.Parameters.AddWithValue("@comision", tsComision.IsOn);
                if (TipoOperacionActual == TipoOperacion.Insert)
                {
                    IdPT = dp.ValidateNumberInt32(cmd.ExecuteScalar());  
                }
                else
                {
                    cmd.ExecuteNonQuery();
                }

                FTP_Class ftp = new FTP_Class();
                string file_name;
                foreach (dsProductoTerminado.PTImagenesRow item in dsProductoTerminado1.PTImagenes)
                {
                    if (item.id == 0)
                    {
                        string ext = Path.GetExtension(item.file_name);
                        file_name = dp.Now().ToString("ddMMyyyyhhmmss") + '_' + item.file_name;

                        if (ftp.GuardarArchivo(UsuarioLogeado, file_name, item.path))
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "sp_pt_insert_imagenes";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_pt", IdPT);
                            cmd.Parameters.AddWithValue("@path", dp.FTP_Normac_PT + file_name);
                            cmd.Parameters.AddWithValue("@file_name", item.file_name);
                            cmd.Parameters.AddWithValue("@id_user", UsuarioLogeado.Id);
                            cmd.ExecuteNonQuery();
                        }
                    }

                }

                if (IdPT > 0)
                {
                    if (TipoOperacionActual == TipoOperacion.Insert)
                    {
                        //Agregamos la informacion de almacenes configurada
                        foreach (dsProductoTerminado.config_pt_invRow rowI in dsProductoTerminado1.config_pt_inv)
                        {
                            SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                            conn.Open();
                            SqlCommand cmd_b = new SqlCommand("dbo.[sp_add_or_update_config_bodega_for_pt_v2]", conn);
                            cmd_b.CommandType = CommandType.StoredProcedure;
                            cmd_b.Parameters.AddWithValue("@id_pt", IdPT);
                            cmd_b.Parameters.AddWithValue("@id_bodega", rowI.id);
                            cmd_b.Parameters.AddWithValue("@id_usuario", this.UsuarioLogeado.Id);
                            cmd_b.Parameters.AddWithValue("@enable", rowI.hablitado_bit);
                            cmd_b.Parameters.AddWithValue("@fijar_como_estandar", rowI.fijado_como_estandar_bit);
                            cmd_b.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                }
                        


                switch (TipoOperacionActual)
                {
                    case TipoOperacion.Insert:
                        CajaDialogo.Information("Producto Terminado Creado con Exito!");
                        break;

                    case TipoOperacion.Update:
                        CajaDialogo.Information("Producto Terminado Actualizado con Exito!");
                        break;
                    default:
                        break;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void LoadConfiguracionAlmacenes(int pIdPT)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.sp_get_config_producto_terminado_bodegas", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", pIdPT);
                dsProductoTerminado1.config_pt_inv.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProductoTerminado1.config_pt_inv);
                
                gridView2.ClearSelection(); // Borra cualquier selección
                gridView2.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle;

                gridView2.OptionsSelection.EnableAppearanceFocusedRow = false;
                gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdFijarComoEstandar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl2.FocusedView;
            var row = (dsProductoTerminado.config_pt_invRow)gridView.GetFocusedDataRow();
            bool HabilitarRow = !row.fijado_como_estandar_bit;
            int idBodega = row.id;

            if (row.fijado_como_estandar_bit)
                return;

            DialogResult r = CajaDialogo.Pregunta("Esta seguro de fijar esta bodega como estandar para este producto?");
            if (r != DialogResult.Yes) return;

            if (HabilitarRow)
            {
                row.fijado_como_estandar_bit = true;
                row.fijado_como_estandar_descrip = "Si";
            }

            foreach (dsProductoTerminado.config_pt_invRow rowI in dsProductoTerminado1.config_pt_inv)
            {
                if (rowI.id != idBodega)
                {
                    rowI.fijado_como_estandar_bit = false;
                    rowI.fijado_como_estandar_descrip = "No";
                }
            }

            switch (TipoOperacionActual)
            {
                case TipoOperacion.Update:
                    
                    //Hacemos el update
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("dbo.sp_fijar_estandar_config_bodega_for_pt", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_pt", IdPT);
                        cmd.Parameters.AddWithValue("@id_bodega", row.id);
                        cmd.Parameters.AddWithValue("@id_usuario", this.UsuarioLogeado.Id);
                        cmd.ExecuteNonQuery();

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                    break;
                case TipoOperacion.Insert:
                    break;
                default:
                    break;
            }
            
        }

        private void cmdHabilitarAlmacen_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Habilitar deshabilitar
            var gridView = (GridView)gridControl2.FocusedView;
            var row = (dsProductoTerminado.config_pt_invRow)gridView.GetFocusedDataRow();
            bool HabilitarRow = false;

            DialogResult r;
            if (row.hablitado_bit)
            {
                //Vamos a deshabilitar
                HabilitarRow = false;
                r = CajaDialogo.Pregunta("Confirme que desea deshabiltar este producto para el almacen " + row.whs_equivalente + "?");
            }
            else
            {
                //Vamos a Habilitar
                HabilitarRow = true;
                r = CajaDialogo.Pregunta("Confirme que desea habiltar este producto para el almacen " + row.whs_equivalente + "?");
            }

            if (r != DialogResult.Yes)
                return;

            if (HabilitarRow)
            {
                row.hablitado_bit = true;
                row.hablitado_descrip = "Si";
            }
            else
            {
                row.hablitado_bit = false;
                row.hablitado_descrip = "No";
                row.fijado_como_estandar_bit = false;
                row.fijado_como_estandar_descrip = "No";
            }

            switch (TipoOperacionActual)
            {
                case TipoOperacion.Update:
                    

                    //Hacemos el update
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("dbo.sp_add_or_update_config_bodega_for_pt", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_pt", IdPT);
                        cmd.Parameters.AddWithValue("@id_bodega", row.id);
                        cmd.Parameters.AddWithValue("@id_usuario", this.UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@enable", HabilitarRow);

                        cmd.ExecuteNonQuery();

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                    break;
                case TipoOperacion.Insert:
                    break;
                default:
                    break;
            }
        }

        private void gridView2_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null) return;

            if (e.RowHandle >= 0)
            {
                var gridView = (GridView)gridControl2.FocusedView;
                var row = (dsProductoTerminado.config_pt_invRow)gridView.GetDataRow(e.RowHandle);// GetFocusedDataRow();

                if (row.fijado_como_estandar_bit)
                {
                    e.Appearance.Font = new Font(gridView2.Appearance.Row.Font.FontFamily,
                        gridView2.Appearance.Row.Font.Size,
                        FontStyle.Bold);

                    e.Appearance.BackColor = Color.FromArgb(102, 255, 102);
                }
                else
                {
                    
                    e.Appearance.BackColor = Color.FromArgb(255, 255, 255);
                }
            }
        }

        private void gridTipoInventario_EditValueChanged(object sender, EventArgs e)
        {
            DataOperations dp = new DataOperations();
            int tipoInventarioSelected = dp.ValidateNumberInt32(gridTipoInventario.EditValue);

            switch(tipoInventarioSelected)
            {
                case 1://Ferreteria
                    int contador = 0;
                    foreach (dsProductoTerminado.config_pt_invRow rowI in dsProductoTerminado1.config_pt_inv)
                    {
                        if (rowI.id == 2)//BG002 Almacen Usados
                        {
                            rowI.fijado_como_estandar_bit = false;
                            rowI.fijado_como_estandar_descrip = "No";
                            rowI.hablitado_bit = false;
                            rowI.hablitado_descrip = "No";
                        }
                        else
                        {
                            rowI.hablitado_bit = true;
                            rowI.hablitado_descrip = "Si";
                            rowI.fijado_como_estandar_bit = false;
                            rowI.fijado_como_estandar_descrip = "No";

                            if (contador == 0)
                            {
                                contador++;
                                rowI.fijado_como_estandar_bit = true;
                                rowI.fijado_como_estandar_descrip = "Si";
                            }
                        }
                    }
                    break;
                case 2://Usados
                    foreach (dsProductoTerminado.config_pt_invRow rowI in dsProductoTerminado1.config_pt_inv)
                    {
                        if (rowI.id != 2)//BG002 Almacen Usados
                        {
                            rowI.fijado_como_estandar_bit = false;
                            rowI.fijado_como_estandar_descrip = "No";
                            rowI.hablitado_bit = false;
                            rowI.hablitado_descrip = "No";
                        }

                        if (rowI.id == 2)
                        {
                            rowI.fijado_como_estandar_bit = true;
                            rowI.fijado_como_estandar_descrip = "Si";
                            rowI.hablitado_bit = true;
                            rowI.hablitado_descrip = "Si";
                        }
                    }
                    break;
                default:

                    break;
            }
        }

        private void reposDelete_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = (dsProductoTerminado.PTImagenesRow)gridView9.GetFocusedDataRow();

            try
            {
                if (row.id == 0)//No existe detalle, solo como memoria
                {
                    gridView9.DeleteRow(gridView9.FocusedRowHandle);
                    dsProductoTerminado1.AcceptChanges();
                }
                else
                {
                    DialogResult r = CajaDialogo.Pregunta("Desea eliminar la imagen?");
                    if (r != DialogResult.Yes)
                        return;

                    //FTP_Class fTP_Class = new FTP_Class();

                    //fTP_Class.RemoveFile(row.path);

                    DataOperations dp = new DataOperations();
                    SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("dbo.sp_pt_producto_delete_imagen", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = row.id;
                    cmd.ExecuteNonQuery();

                    gridView9.DeleteRow(gridView9.FocusedRowHandle);
                    dsProductoTerminado1.AcceptChanges();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void grdTipo_EditValueChanged(object sender, EventArgs e)
        {
            
            int IdFamilia = dp.ValidateNumberInt32(grdTipoFamilia.EditValue);

            CargarCategorias(IdFamilia);
        }

        private void CargarCategorias(int idFamilia)
        {
            try
            {
                SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                connection.Open();
                SqlCommand cmd = new SqlCommand("[sp_pt_get_categoria_activo_by_familia]", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@id_familia", idFamilia);
                dsProductoTerminado1.categoaria_select.Clear();
                adapter.Fill(dsProductoTerminado1.categoaria_select);
                connection.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void grdTipoCategoria_EditValueChanged(object sender, EventArgs e)
        {
            int IdCategoria = dp.ValidateNumberInt32(grdTipoCategoria.EditValue);

            CargarClases(IdCategoria);

        }

        private void CargarClases(int idCategoria)
        {
            try
            {
                SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                connection.Open();
                SqlCommand cmd = new SqlCommand("[sp_pt_get_clases_activos_by_categoria]", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                dsProductoTerminado1.clase_select.Clear();
                adapter.Fill(dsProductoTerminado1.clase_select);
                connection.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void grdTipoClase_EditValueChanged(object sender, EventArgs e)
        {
            int IdClase = dp.ValidateNumberInt32(grdTipoClase.EditValue);

            CargarSubClases(IdClase);

        }

        private void CargarSubClases(int idClase)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_pt_get_sub_clases_actives_by_id_clase]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdClase", idClase);
                dsProductoTerminado1.subClaseSelect.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProductoTerminado1.subClaseSelect);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdEditarPrecio_Click(object sender, EventArgs e)
        {
            InputBox Input1 = new InputBox();
            decimal valor = Input1.ShowNumeric("Ingrese un precio de venta:", "Ingrese el valor");

            if (Input1.IsOk)
            {
                //MessageBox.Show("Ingresaste: " + valor);
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("[]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("", idClase);
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
        }

        private void cmdEditarCosto_Click(object sender, EventArgs e)
        {
            InputBox Input1 = new InputBox();
            decimal valor = Input1.ShowNumeric("Ingrese un costo de compra:", "Ingrese el valor");

            if (Input1.IsOk)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("[sp_set_costo_producto]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_pt", IdPT);
                    cmd.Parameters.AddWithValue("@costo", valor);
                    cmd.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
                    cmd.ExecuteNonQuery();
                    txtCostoActual.Text = string.Format("{0:###,##0.00}", valor);

                    dsDatosProductos.historial_costoRow row = dsDatosProductos1.historial_costo.Newhistorial_costoRow();
                    int cantRows = dsDatosProductos1.historial_costo.Rows.Count;
                    row.id = 0;
                    row.id_pt = IdPT;
                    row.costo = valor;
                    row.cantidad = 0;
                    row.fecha_entrada = dp.NowSetDateTime();
                    row.usuario_name = this.UsuarioLogeado.Nombre;
                    row.id_usuario = this.UsuarioLogeado.Id;
                    row.num_linea = cantRows + 1;


                    dsDatosProductos1.historial_costo.Addhistorial_costoRow(row);
                    dsDatosProductos1.AcceptChanges();
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
        }

        private void cmdEditarMargenUtilidad_Click(object sender, EventArgs e)
        {
            InputBox Input1 = new InputBox();
            decimal valor = Input1.ShowNumeric("Ingrese el valor para el margen de utilidad:", "Ingrese el valor");

            if (Input1.IsOk)
            {
                //MessageBox.Show("Ingresaste: " + valor);
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("[sp_set_margen_utilidad_master_producto]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@porcentaje_utilidad", valor);
                    cmd.Parameters.AddWithValue("@id_pt", IdPT);
                    cmd.ExecuteNonQuery();
                    txtPorcentajeUtilidad.Text = string.Format("{0:###,##0.00}", valor);
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
        }

        private void cmdDescuentoMaximo_Click(object sender, EventArgs e)
        {
            InputBox Input1 = new InputBox();
            decimal valor = Input1.ShowNumeric("Ingrese el descuento maximo permitido por defecto:", "Ingrese el valor");
            if (Input1.IsOk)
            {
                //MessageBox.Show("Ingresaste: " + valor);
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("[sp_set_porcentaje_descuento_master_producto]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@porcentaje_descuento", valor);
                    cmd.Parameters.AddWithValue("@id_pt", IdPT);
                    cmd.ExecuteNonQuery();
                    txtDescuentoMaximo.Text = string.Format("{0:###,##0.00}", valor);
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
        }
    }
}