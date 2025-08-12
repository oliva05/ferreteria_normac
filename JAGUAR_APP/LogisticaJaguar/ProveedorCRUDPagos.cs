using ACS.Classes;
using DevExpress.Charts.Native;
using DevExpress.Utils.About;
using DevExpress.XtraBars.Painters;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.Commands.Internal;
using DocumentFormat.OpenXml.Office2010.Excel;
using JAGUAR_PRO.Clases;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace JAGUAR_PRO.LogisticaJaguar
{
    public partial class ProveedorCRUDPagos : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        decimal MontoOrigen = 0;
        DataOperations dp = new DataOperations();
        PDV PuntoVentaActual;
        Dictionary<int, decimal> saldoPorAnticipo = new Dictionary<int, decimal>();
        public ProveedorCRUDPagos(UserLogin userLogin, PDV puntoVentaActual)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
            txtMontoPagar.Properties.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            GetTipoPago();
            grdTipoPago.EditValue = 3;
            LoadProveedoresList();
            grdvDetalleFacturas.OptionsMenu.EnableColumnMenu = true;
            PuntoVentaActual = puntoVentaActual;
            txtMontoPagar.Properties.Mask.Culture = new System.Globalization.CultureInfo("en-US");
            txtMontoPagar.Properties.Mask.EditMask = "n2";
            txtMontoPagar.Properties.Mask.UseMaskAsDisplayFormat = true;
            //Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna, para elegir columnas, ordenar, etc


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

        private void grdProveedor_EditValueChanged(object sender, EventArgs e)
        {
            if ((int)grdProveedor.EditValue > 0)
            {
                //Vamos a Limpiar Controles
                chkAll.Checked = false;
                txtMontoPagar.EditValue = 0;
                txtObs.Text = string.Empty;


                GetFacturasByIdProv();

                //Obtener anticipos
                saldoPorAnticipo.Clear();

                foreach (dsLogisticaJaguar.detalle_facturaRow item in dsLogisticaJaguar1.detalle_factura)
                {
                    if (item.id_anticipo > 0)
                    {
                        int id = item.id_anticipo;
                        decimal saldo = item.monto_anticipo;

                        if (!saldoPorAnticipo.ContainsKey(id))
                            saldoPorAnticipo[id] = saldo;
                    }
                }

                foreach (var kvp in saldoPorAnticipo.ToList())
                {
                    foreach (dsLogisticaJaguar.detalle_facturaRow item in dsLogisticaJaguar1.detalle_factura)
                    {
                        if (item.id_anticipo == kvp.Key)
                        {
                            
                            if (kvp.Value <= item.monto_pendiente)
                            {
                                item.montoAnticipoAplicado = kvp.Value;
                                saldoPorAnticipo[kvp.Key] = 0;
                                item.aplicarAnticipo = true;
                                item.monto_pendiente = item.monto_pendiente - item.montoAnticipoAplicado;
                            }
                            else if (kvp.Value > item.monto_pendiente)
                            {
                                item.montoAnticipoAplicado = item.monto_pendiente;
                                saldoPorAnticipo[kvp.Key] = kvp.Value - item.montoAnticipoAplicado;
                                item.aplicarAnticipo = true;
                                item.monto_pendiente = item.monto_pendiente - item.montoAnticipoAplicado;
                            }
                            else if (kvp.Value == 0)
                            {
                                item.aplicarAnticipo = false;
                            }
                            
                        }
                    }
                }


                txtMontoPagar.Focus();
            }
        }

        private void GetFacturasByIdProv() 
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_facturas_by_id_prov]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_prov", grdProveedor.EditValue);
                dsLogisticaJaguar1.detalle_factura.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLogisticaJaguar1.detalle_factura);

                con.Close();




                grdTipoPago.Focus();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void GetTipoPago()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_tipo_pago_facturas]", con);
                cmd.CommandType = CommandType.StoredProcedure;
            
                dsLogisticaJaguar1.tipo_pagos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLogisticaJaguar1.tipo_pagos);

                con.Close();

                grdTipoPago.Focus();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(grdProveedor.EditValue) <= 0 || string.IsNullOrEmpty(grdProveedor.Text))
            {
                CajaDialogo.Error("Debe seleccionar un Proveedor!");
                grdProveedor.Focus();
                return;
            }

            if (grdTipoPago.EditValue == null || Convert.ToInt32(grdTipoPago.EditValue) <= 0)
            {
                CajaDialogo.Error("Debe seleccionar un Tipo de Pago!");
                grdTipoPago.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtMontoPagar.Text) || Convert.ToDecimal(txtMontoPagar.EditValue) <= 0)
            {
                CajaDialogo.Error("Debe ingresar un monto a pagar mayor a cero!");
                txtMontoPagar.Focus();
                return;
            }

            if (grdvDetalleFacturas.RowCount <= 0)
            {
                CajaDialogo.Error("Debe existir al menos una factura a pagar!");
                grdTipoPago.Focus();
                return;
            }

            


            string errorMensaje = string.Empty;
            decimal TotalEntrega = 0;
            bool Error = false;
            foreach (dsLogisticaJaguar.detalle_facturaRow item in dsLogisticaJaguar1.detalle_factura)
            {
                if (item.seleccionar)
                {
                    if (item.monto_a_pagar <= 0)
                    {
                        errorMensaje = "Se selecciono una factura pero no se inidico el Monto!";
                        Error = true;
                        break;
                    }

                    if (item.monto_a_pagar > item.monto_pendiente)
                    {
                        errorMensaje = "El monto a pagar no debe ser mayor que el monto pendiente!";
                        Error = true;
                        break;
                    }

                    TotalEntrega += item.monto_a_pagar;
                }
            }

            if (TotalEntrega != Convert.ToDecimal(txtMontoPagar.EditValue))
            {
                CajaDialogo.Error("Existe un monto sobrante");
                return;
            }


            if (Error)
            {
                CajaDialogo.Error(errorMensaje);
                return;
            }


     

            SqlTransaction transaction = null;

            SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            bool Guardar = false;

            try
            {
                conn.Open();
                transaction = conn.BeginTransaction("Transaction Order");

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "sp_insert_pago_fact_proveedor";
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha_pago",dp.Now());
                cmd.Parameters.AddWithValue("@id_proveedor", dp.ValidateNumberInt32(grdProveedor.EditValue));
                cmd.Parameters.AddWithValue("@metodo_pago",dp.ValidateNumberInt32(grdTipoPago.EditValue));
                cmd.Parameters.AddWithValue("@total_pagado", dp.ValidateNumberDecimal(txtMontoPagar.EditValue));
                cmd.Parameters.AddWithValue("@observaciones", txtObs.Text.Trim());
                cmd.Parameters.AddWithValue("@created_user_id", UsuarioLogeado.Id);
                cmd.Parameters.AddWithValue("@puntoVentaId", PuntoVentaActual.ID);
                int id_hPago = Convert.ToInt32(cmd.ExecuteScalar());

                foreach (dsLogisticaJaguar.detalle_facturaRow row in dsLogisticaJaguar1.detalle_factura.Rows)
                {
                    if (row.monto_a_pagar > 0 && row.seleccionar == true)
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "sp_insert_pago_factura_proveedor_detalle";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_pago", id_hPago);
                        cmd.Parameters.AddWithValue("@id_factura", row.id);
                        cmd.Parameters.AddWithValue("@monto_pagado", row.monto_a_pagar);
                        cmd.Parameters.AddWithValue("@observaciones", row.observacion);
                        cmd.Parameters.AddWithValue("@monto_anticipo", row.montoAnticipoAplicado);
                        cmd.Parameters.AddWithValue("@anticipo_id", row.id_anticipo);
                        cmd.Parameters.AddWithValue("@usuario_aplico", UsuarioLogeado.Id);
                        cmd.ExecuteNonQuery();

                    }
                }

                transaction.Commit();
                Guardar = true;

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ec)
            {
                transaction.Rollback();
                CajaDialogo.Error(ec.Message);
                Guardar = false;
            }

            if (Guardar)
            {
                CajaDialogo.Information("Guardado con exito!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void txtMontoPagar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chkAll.Checked)
                {
                    chkAll_CheckedChanged(sender, e);
                }
                txtObs.Focus();
            }
            MontoOrigen = Convert.ToDecimal(txtMontoPagar.EditValue);
        }

        private void grdTipoPago_EditValueChanged(object sender, EventArgs e)
        {
            txtMontoPagar.Focus();
        }

        private void txtObs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (grdvDetalleFacturas.RowCount > 0)
                {
                    grdvDetalleFacturas.FocusedRowHandle = 0;

                    grdvDetalleFacturas.FocusedColumn = grdvDetalleFacturas.Columns["monto_a_pagar"];
                    grdvDetalleFacturas.ShowEditor();
                }
            }
        }

        private void RecalculoMontoOrgien()
        {
            decimal total = 0;
            foreach (dsLogisticaJaguar.detalle_facturaRow row in dsLogisticaJaguar1.detalle_factura.Rows)
            {
                total = total + row.monto_a_pagar;
            }
            MontoOrigen = Convert.ToDecimal(txtMontoPagar.EditValue) - total;
            txtMontoDisponible.Text = MontoOrigen.ToString("N2");   
        }


        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll.Checked)
            {
                decimal MontoTotal = Convert.ToDecimal(txtMontoPagar.EditValue);
                foreach (dsLogisticaJaguar.detalle_facturaRow item in dsLogisticaJaguar1.detalle_factura)
                {
                    if(MontoTotal > 0)
                    {
                        item.seleccionar = true;
                        if (MontoTotal > item.monto_pendiente)
                        {
                            item.monto_a_pagar = item.monto_pendiente;
                            MontoTotal -= item.monto_pendiente;
                        }
                        else
                        {
                            item.monto_a_pagar = MontoTotal;
                            MontoTotal -= item.monto_a_pagar;
                        }
                    }
                    RecalculoMontoOrgien();
                }
            }
            else
            {
                foreach (dsLogisticaJaguar.detalle_facturaRow item in dsLogisticaJaguar1.detalle_factura)
                {
                    item.seleccionar = false;
                    item.monto_a_pagar = 0;
                    item.observacion = string.Empty;
                    RecalculoMontoOrgien();
                }
            }
        }


        private void grdvDetalleFacturas_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
           
        }

        private void grdvDetalleFacturas_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; // evitar comportamiento por defecto

                // Obtener la fila actual
                int currentRow = grdvDetalleFacturas.FocusedRowHandle;

                // Obtener siguiente fila visible
                int nextRow = grdvDetalleFacturas.GetNextVisibleRow(currentRow);

                if (nextRow >= 0)
                {
                    // Establecer el foco en la siguiente fila
                    grdvDetalleFacturas.FocusedRowHandle = nextRow;

                    // Establecer el foco en la columna deseada
                    grdvDetalleFacturas.FocusedColumn = grdvDetalleFacturas.Columns["monto_a_pagar"]; // nombre exacto de la columna

                    // Activar edición
                    grdvDetalleFacturas.ShowEditor();
                }

            }
        }

        private void grdvDetalleFacturas_CellValueChanged_1(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridview = (GridView)grdDetalleFacturas.FocusedView;
            var row = (dsLogisticaJaguar.detalle_facturaRow)gridview.GetFocusedDataRow();

            if (row != null)
            {
                switch (e.Column.FieldName)
                {
                    case "seleccionar":

                        if (row.monto_a_pagar == 0)
                        {
                            row.seleccionar = false;
                        }

                        break;


                    case "monto_a_pagar":

                        if (MontoOrigen > 0)
                        {
                            if (row.monto_a_pagar > 0)
                            {
                                if (row.monto_a_pagar > row.monto_pendiente)
                                {
                                    row.monto_a_pagar = row.monto_pendiente;
                                    row.seleccionar = true;
                                }
                            }
                            else
                            {
                                row.monto_a_pagar = 0;
                                row.seleccionar = false;
                            }
                            RecalculoMontoOrgien();

                        }

                        break;

                    default:
                        break;
                }
            }
        }

        private void grdvDetalleFacturas_CellValueChanging_1(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridview = (GridView)grdDetalleFacturas.FocusedView;
            var row = (dsLogisticaJaguar.detalle_facturaRow)gridview.GetFocusedDataRow();

            if (row != null)
            {
                switch (e.Column.FieldName)
                {
                    case "seleccionar":
                        bool nuevaValor = Convert.ToBoolean(e.Value);

                        if (nuevaValor)
                        {
                            if (row.monto_pendiente > 0)
                            {
                                if (MontoOrigen > 0)
                                {
                                    if (MontoOrigen >= row.monto_pendiente)
                                    {
                                        row.monto_a_pagar = row.monto_pendiente;

                                    }
                                    else
                                    {
                                        row.monto_a_pagar = MontoOrigen;

                                    }
                                }
                                else
                                {
                                    CajaDialogo.Error("No existe monto disponible!");
                                    this.BeginInvoke(new Action(() =>
                                    {
                                        row.seleccionar = false;
                                    }));

                                    return;
                                }
                            }
                            else
                            {
                                CajaDialogo.Error("No hay monto pendiente para esta factura!");
                                this.BeginInvoke(new Action(() =>
                                {
                                    row.seleccionar = false;
                                }));

                                return;
                            }
                        }
                        else
                        {
                            row.monto_a_pagar = 0;
                        }
                        RecalculoMontoOrgien();
                        break;

                    case "monto_a_pagar":

                        if (MontoOrigen > 0)
                        {
                            if (MontoOrigen > row.monto_pendiente)
                            {
                                row.monto_a_pagar = row.monto_pendiente;
                                row.seleccionar = true;
                            }
                            else
                            {
                                row.monto_a_pagar = MontoOrigen;
                                row.seleccionar = true;
                            }
                        }
                        else
                        {
                            row.monto_a_pagar = 0;
                            row.seleccionar = false;
                        }


                        break;

                    default:
                        break;
                }
            }
        }
    }
}