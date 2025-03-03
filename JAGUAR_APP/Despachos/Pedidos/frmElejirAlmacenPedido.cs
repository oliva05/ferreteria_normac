using ACS.Classes;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_PRO.Clases;
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
    public partial class frmElejirAlmacenPedido : DevExpress.XtraEditors.XtraForm
    {
        int IdPT;
        decimal CantidadReq;
        public ArrayList ListaSeleccionAlmacen;
        decimal descuento;
        decimal precio;
        int id_presentacion;
        string itemcode;
        string itemname;
        public frmElejirAlmacenPedido(int pIdPt, string ProductoName, decimal pCantidarReq, ArrayList pListaActual,
                                      decimal pdescuento, decimal pprecio, int id_presentacion, string itemcode, string itemname)
        {
            InitializeComponent();
            ListaSeleccionAlmacen = new ArrayList();
            lblProductoName.Text = ProductoName;
            IdPT = pIdPt;
            CantidadReq = pCantidarReq;
            lblCantidadReq.Text =  string.Format("{0:###,##0.00}", pCantidarReq);
            descuento = pdescuento;
            precio = pprecio;
            this.id_presentacion = id_presentacion;
            this.itemcode = itemcode;
            this.itemname = itemname;
            LoadInventarios();
            RecuperarCantidadSeleccionada(pListaActual);
        }

        private void RecuperarCantidadSeleccionada(ArrayList pListaActual)
        {
            foreach (dsPedidosClientesV.stock_por_almacenRow row in dsPedidosClientesV1.stock_por_almacen.Rows)
            {
                foreach(ElejirInvAlmacen item in pListaActual)
                {
                    if(row.id_bodega == item.IdBodega && IdPT == item.id_pt)
                    {
                        row.cantidad_seleccionada = item.CantSeleccionada;
                        row.itemcode = itemcode;
                        row.itemname = itemname;
                        row.id_presentacion = id_presentacion;
                        row.descuento = descuento;
                        row.precio = precio;
                        //break;
                    }
                }
            }
        }

        private void LoadInventarios()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[jaguar_sp_get_cantidad_inv_kardex_pt_for_elejir_stock]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", IdPT);
                dsPedidosClientesV1.stock_por_almacen.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPedidosClientesV1.stock_por_almacen);

                foreach (dsPedidosClientesV.stock_por_almacenRow row in dsPedidosClientesV1.stock_por_almacen.Rows)
                {
                    row.itemcode = itemcode;
                    row.itemname = itemname;
                    row.id_presentacion = id_presentacion;
                    row.descuento = descuento;
                    row.precio = precio;
                }

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
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
            foreach(dsPedidosClientesV.stock_por_almacenRow row in dsPedidosClientesV1.stock_por_almacen.Rows)
            {
                CantSeleccionada += row.cantidad_seleccionada;
            }

            if(CantSeleccionada == 0)
            {
                CajaDialogo.Error("No se ha seleccionado ninguna cantidad de Inventario!");
                return;
            }
            //
            foreach (dsPedidosClientesV.stock_por_almacenRow row in dsPedidosClientesV1.stock_por_almacen.Rows)
            {
                if (row.cantidad_seleccionada > 0)
                {
                    ElejirInvAlmacen Eleccion = new ElejirInvAlmacen();
                    Eleccion.id_pt = IdPT;
                    Eleccion.IdBodega = row.id_bodega;
                    Eleccion.BodegaName = row.bodega_name;
                    Eleccion.CantSeleccionada = row.cantidad_seleccionada;
                    Eleccion.descuento = row.descuento;
                    Eleccion.Precio = row.precio;
                    Eleccion.ItemCode = row.itemcode;
                    Eleccion.Descripcion = row.itemname;
                    Eleccion.id_presentacion = row.id_presentacion;
                    ListaSeleccionAlmacen.Add(Eleccion);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsPedidosClientesV.stock_por_almacenRow)gridView.GetFocusedDataRow();
            //cantidad_seleccionada

            if(row.cantidad_seleccionada> row.cantidad)
            {
                CajaDialogo.Error("La cantidad excede del inventario disponible!");
                return;
            }
            
        }
    }
}