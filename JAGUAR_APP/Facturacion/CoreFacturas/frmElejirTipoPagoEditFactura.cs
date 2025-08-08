using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace JAGUAR_PRO.Facturacion.CoreFacturas
{
    public partial class frmElejirTipoPagoEditFactura : DevExpress.XtraEditors.XtraForm
    {

        public class ItemBusquedaLocal
        {
            public int id;
            public string ItemCode;
            public string ItemName;
            public ItemBusquedaLocal()
            {
                id = 0;
                ItemCode = "";
                ItemName = "";
            }
        }
        public ItemBusquedaLocal ItemSeleccionado;
        int IdTipoPagoActual;
        
        public frmElejirTipoPagoEditFactura(int pIdTipoPagoActual, string pTipoPagoName)
        {
            InitializeComponent();
            lblTipoPagoActual.Text = pTipoPagoName;
            ItemSeleccionado = new ItemBusquedaLocal();
            IdTipoPagoActual = pIdTipoPagoActual;
            LoadTiposDePago();
        }

        private void LoadTiposDePago()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_new_tipo_pagos_de_Factura_H_edit]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tipo_actual", IdTipoPagoActual);
                //cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                //cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMantoFacturas1.tipos_de_pago.Clear();
                adat.Fill(dsMantoFacturas1.tipos_de_pago);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //EVENTO CellValueChanging
            if (e.Column.FieldName == "seleccionar")
            {
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsMantoFacturas.tipos_de_pagoRow)gridView.GetFocusedDataRow();
                if (Convert.ToBoolean(e.Value))
                {
                    ItemSeleccionado.id = row.id;
                    //ItemSeleccionado.ItemCode = row.ItemCode;
                    ItemSeleccionado.ItemName = row.descripcion;
                    row.seleccionar = true;
                }

                foreach (dsMantoFacturas.tipos_de_pagoRow row1 in dsMantoFacturas1.tipos_de_pago)
                {
                    if (row1.id != ItemSeleccionado.id)
                        row1.seleccionar = false;
                }
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (ItemSeleccionado.id > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                CajaDialogo.Error("Es necesario seleccionar un tipo de pago para poder continuar...");
                return;
            }
        }
    }
}