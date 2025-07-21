using ACS.Classes;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Facturacion.CoreFacturas;
using JAGUAR_PRO.LogisticaJaguar;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO.Despachos.Pedidos
{
    public partial class frmElejirAlmacenPedidoOutStok : DevExpress.XtraEditors.XtraForm
    {
        int IdPT;
        decimal CantidadReq;
        public ArrayList ListaSeleccionAlmacen;
        decimal descuento;
        decimal descuento_porcentaje;
        decimal precio;
        decimal isv1;
        int id_presentacion;
        string itemcode;
        string itemname;
        bool IsUsados;
        
        public frmElejirAlmacenPedidoOutStok(int pIdPt, string ProductoName, decimal pCantidarReq, ArrayList pListaActual,
                                            decimal pdescuento, decimal pprecio, int id_presentacion, string itemcode, 
                                            string itemname, decimal itemIsv1, decimal pDescuentoPorcentaje, bool pIsUsados)
        {
            InitializeComponent();
            IsUsados = pIsUsados;
            ListaSeleccionAlmacen = new ArrayList();
            lblProductoName.Text = ProductoName;
            IdPT = pIdPt;
            CantidadReq = pCantidarReq;
            lblCantidadReq.Text =  string.Format("{0:###,##0.00}", pCantidarReq);
            descuento = pdescuento;
            precio = pprecio;
            descuento_porcentaje = pDescuentoPorcentaje;
            this.id_presentacion = id_presentacion;
            this.itemcode = itemcode;
            this.itemname = itemname;
            
            this.isv1 = itemIsv1;
            LoadInventarios();
            RecuperarCantidadSeleccionada(pListaActual);
            if (dsPrefacturas1.stock_por_almacen.Count > 0)
                gridView1.FocusedRowHandle = dsPrefacturas1.stock_por_almacen.Count - 1;
            else
                gridView1.FocusedRowHandle = 0;

            gridView1.FocusedColumn = colcantidad_seleccionada;
            gridView1.ShowEditor();

        }

       

        private void RecuperarCantidadSeleccionada(ArrayList pListaActual)
        {
            foreach (dsPrefacturas.stock_por_almacenRow row in dsPrefacturas1.stock_por_almacen.Rows)
            {
                //row.cantidad_seleccionada = 0;
                foreach (ElejirInvAlmacen item in pListaActual)
                {
                    if (row.id_bodega == item.IdBodega)
                    {
                        row.cantidad_seleccionada = item.CantSeleccionada;
                        row.itemcode = itemcode;
                        row.itemname = itemname;
                        row.id_presentacion = id_presentacion;
                        row.descuento = descuento;
                        row.descuento_porcentaje = descuento_porcentaje;
                        row.precio = precio;
                        row.isv1 = isv1;
                        lblMarca.Text = item.marca;
                        //row. = isv1;
                        //break;
                    }
                }
            }
        }

        private void LoadInventarios()
        {
            if (IsUsados)
            {

                dsPrefacturas.stock_por_almacenRow row1 = dsPrefacturas1.stock_por_almacen.Newstock_por_almacenRow();
                row1.itemcode = itemcode;
                ProductoUsado pt1 = new ProductoUsado();
                decimal cant_inv_usados = 0;

                cant_inv_usados = pt1.Recuperar_Cant_Inv_Actual_PT_for_facturacionUsados(IdPT, 1);
                

                row1.itemname = itemname;
                row1.id_presentacion = id_presentacion;
                row1.descuento = descuento;
                row1.descuento_porcentaje = descuento_porcentaje;
                row1.precio = precio;
                row1.isv1 = isv1;
                row1.cantidad = cant_inv_usados;
                //row1.cantidad = 0;
                row1.cantidad_seleccionada = 0;
                row1.whs_code = "BG002";
                row1.id_bodega = 2;
                row1.bodega_name = "ALMACEN DE USADOS";
                row1.comprometido = 0;
                dsPrefacturas1.stock_por_almacen.Addstock_por_almacenRow(row1);
                dsPrefacturas1.AcceptChanges();

            }
            else
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("[jaguar_sp_get_cantidad_inv_kardex_pt_for_elejir_stock]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_pt", IdPT);
                    dsPrefacturas1.stock_por_almacen.Clear();
                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    adat.Fill(dsPrefacturas1.stock_por_almacen);

                    foreach (dsPrefacturas.stock_por_almacenRow row in dsPrefacturas1.stock_por_almacen.Rows)
                    {
                        row.itemcode = itemcode;
                        row.itemname = itemname;
                        row.id_presentacion = id_presentacion;
                        row.descuento = descuento;
                        row.descuento_porcentaje = descuento_porcentaje;
                        row.precio = precio;
                        row.isv1 = isv1;
                    }

                    if (dsPrefacturas1.stock_por_almacen.Rows.Count == 0)
                    {
                        dsPrefacturas.stock_por_almacenRow row1 = dsPrefacturas1.stock_por_almacen.Newstock_por_almacenRow();
                        row1.itemcode = itemcode;
                        row1.itemname = itemname;
                        row1.id_presentacion = id_presentacion;
                        row1.descuento = descuento;
                        row1.descuento_porcentaje = descuento_porcentaje;
                        row1.precio = precio;
                        row1.isv1 = isv1;
                        row1.cantidad = 0;
                        row1.cantidad_seleccionada = 0;
                        row1.whs_code = null;
                        row1.id_bodega = 0;
                        row1.bodega_name = null;
                        row1.comprometido = 0;
                        dsPrefacturas1.stock_por_almacen.Addstock_por_almacenRow(row1);
                        dsPrefacturas1.AcceptChanges();
                    }
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
               
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close  ();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            decimal CantSeleccionada = 0;
            
            foreach(dsPrefacturas.stock_por_almacenRow row in dsPrefacturas1.stock_por_almacen.Rows)
            {
                CantSeleccionada += row.cantidad_seleccionada;
            }

            if(CantSeleccionada == 0)
            {
                CajaDialogo.Error("No se ha seleccionado ninguna cantidad de Inventario!");
                return;
            }

            
            foreach (dsPrefacturas.stock_por_almacenRow row in dsPrefacturas1.stock_por_almacen.Rows)
            {
                if (row.cantidad_seleccionada > 0)
                {
                    ElejirInvAlmacen Eleccion = new ElejirInvAlmacen();
                    Eleccion.id_pt = IdPT;
                    Eleccion.IdBodega = row.id_bodega;
                    if (row.Isbodega_nameNull())
                        Eleccion.BodegaName = string.Empty;
                    else
                        Eleccion.BodegaName = row.bodega_name;

                    Eleccion.CantSeleccionada = row.cantidad_seleccionada;
                    Eleccion.descuento = row.descuento;
                    Eleccion.descuento_porcentaje = row.descuento_porcentaje;
                    Eleccion.Precio = row.precio;
                    Eleccion.ItemCode = row.itemcode;
                    Eleccion.Descripcion = row.itemname;
                    Eleccion.id_presentacion = row.id_presentacion;
                    Eleccion.isv1 = row.isv1;

                    if (!string.IsNullOrEmpty(lblMarca.Text))
                        Eleccion.marca = lblMarca.Text;

                    ListaSeleccionAlmacen.Add(Eleccion);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //var gridView = (GridView)gridControl1.FocusedView;
            //var row = (dsPrefacturas.stock_por_almacenRow)gridView.GetFocusedDataRow();
            ////cantidad_seleccionada

            ////if(row.cantidad_seleccionada> row.cantidad)
            ////{
            ////    CajaDialogo.Error("La cantidad excede del inventario disponible!");
            ////    return;
            ////}

            if (dsPrefacturas1.stock_por_almacen.Rows.Count == 1)
            {
                var gv = (GridView)gridControl1.FocusedView;
                var row = (dsPrefacturas.stock_por_almacenRow)gv.GetDataRow(gv.FocusedRowHandle);
                dsPrefacturas1.AcceptChanges();
                decimal cant = row.cantidad_seleccionada;
                //var cell = 
                DevExpress.XtraGrid.Columns.GridColumn focusedColumn = gv.FocusedColumn;
                switch (focusedColumn.FieldName)
                {
                    case "cantidad_seleccionada":

                        cmdGuardar_Click(sender, new EventArgs());
                        break;
                    default:
                        break;
                }
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                int filaActual = gridView1.FocusedRowHandle;
                var columnaActual = gridView1.FocusedColumn;

                if (filaActual < gridView1.RowCount - 1)
                {
                    gridView1.FocusedRowHandle = filaActual + 1 ;
                    gridView1.FocusedColumn = columnaActual;

                    gridView1.ShowEditor();
                    gridView1.ActiveEditor?.SelectAll();
                }
                else
                {
                    cmdGuardar.Focus(); //para que haga focus en el boton

                    //cmdGuardar_Click(sender,e);//o ejecutar el evento.. no lo se, mejor que se posicione
                }

                //var gv = (GridView)gridControl1.FocusedView;
                //var row = (dsPrefacturas.stock_por_almacenRow)gv.GetDataRow(gv.FocusedRowHandle);
                //dsPrefacturas1.AcceptChanges();
                //decimal cant = row.cantidad_seleccionada;
                ////var cell = 
                //DevExpress.XtraGrid.Columns.GridColumn focusedColumn = gv.FocusedColumn;
                //switch (focusedColumn.FieldName)
                //{
                //    case "cantidad_seleccionada":
                        
                //        cmdGuardar_Click(sender, new EventArgs());
                //        break;
                //    default:
                //        break;
                //}
            }
        }

        private void gridView1_ShownEditor(object sender, EventArgs e)
        {
            //var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            //if (view.FocusedColumn != null && view.ActiveEditor != null)
            //{
            //    view.ActiveEditor.SelectAll();
            //}
        }
    }
}