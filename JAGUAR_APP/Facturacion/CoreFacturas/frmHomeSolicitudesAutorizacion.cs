using ACS.Classes;
using DevExpress.DashboardWin.Commands;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.Commands.Internal;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Compras;
using JAGUAR_PRO.LogisticaJaguar;
using JAGUAR_PRO.TransaccionesPT;
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
    public partial class frmHomeSolicitudesAutorizacion : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLogeado = new UserLogin();
        public frmHomeSolicitudesAutorizacion(UserLogin userLog)
        {
            InitializeComponent();
            LoadData(false);
            usuarioLogeado = userLog;

        }

        private void LoadData(bool filtro)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadSolicitudesAutorizacion", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@filtro", SqlDbType.Bit).Value = filtro;

                    dsFacturasGestion1.SolicitudAutorizacion.Clear();

                    //da.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int).Value = id_cliente;
                    da.Fill(dsFacturasGestion1.SolicitudAutorizacion);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsFiltro_Toggled(object sender, EventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage.Name == "TabFacturas")
            {
                LoadData(Convert.ToBoolean(tsFiltro.EditValue));
            }

            if (xtraTabControl1.SelectedTabPage.Name == "TabCompras")
            {
                LoadDataOrdensCompra(tsFiltro.IsOn);
            }

            if (xtraTabControl1.SelectedTabPage.Name == "TabSolicitudesAjuste")
            {
                LoadSolicitudes(tsFiltro.IsOn);
            }
        }

        private void btnGestionar_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsFacturasGestion.SolicitudAutorizacionRow)grd_data.GetFocusedDataRow();

                switch (row.id_tipoAutorizacion)
                {
                    case 1://Anulación
                        xfrmDialogGestionSolicitud frm = new xfrmDialogGestionSolicitud(row.id, usuarioLogeado);

                        if (row.estado_id != 1)
                        {
                            CajaDialogo.Error("Esta solicitud ya ha sido procesada");
                            return;
                        }

                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            LoadData(Convert.ToBoolean(tsFiltro.EditValue));
                        }
                        break;

                    case 2://Reimpresión
                        xfrmDialogGestionSolicitud frm2 = new xfrmDialogGestionSolicitud(row.id, usuarioLogeado);

                        if (row.estado_id != 1)
                        {
                            CajaDialogo.Error("Esta solicitud ya ha sido procesada");
                            return;
                        }

                        if (frm2.ShowDialog() == DialogResult.OK)
                        {
                            LoadData(Convert.ToBoolean(tsFiltro.EditValue));
                            
                            //Impresion de voucher de Anulacion de factura.
                            //To do


                        }
                        break;

                    case 3://Nota de Crédito/Débito
                        if (row.estado_id != 1)
                        {
                            CajaDialogo.Error("Esta solicitud ya ha sido procesada");
                            return;
                        }
                        frmNotaCRUD frm3 = new frmNotaCRUD(frmNotaCRUD.SourceSolicitud.FacturaEmitida,row.id, usuarioLogeado);

                        if (frm3.ShowDialog() == DialogResult.OK)
                            LoadData(Convert.ToBoolean(tsFiltro.EditValue));

                        break;
                    case 4://Anulación de Recibo
                        xfrmDialogGestionSolicitud frm4 = new xfrmDialogGestionSolicitud(row.id, usuarioLogeado);

                        if (row.estado_id != 1)
                        {
                            CajaDialogo.Error("Esta solicitud ya ha sido procesada");
                            return;
                        }

                        if (frm4.ShowDialog() == DialogResult.OK)
                        {
                            LoadData(Convert.ToBoolean(tsFiltro.EditValue));
                        }
                        break;
                }

                
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
          
            }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage.Name == "TabFacturas")
            {
                LoadData(Convert.ToBoolean(tsFiltro.EditValue));
            }

            if (xtraTabControl1.SelectedTabPage.Name == "TabCompras")
            {
                LoadDataOrdensCompra(tsFiltro.IsOn);
            }

            if (xtraTabControl1.SelectedTabPage.Name == "TabSolicitudesAjuste")
            {
                LoadSolicitudes(tsFiltro.IsOn);
            }
        }

        private void btnGestionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == TabFacturas)
            {
                LoadData(false);
            }

            if (e.Page == TabCompras)
            {
                LoadDataOrdensCompra(false);
            }

            if (e.Page == TabSolicitudesAjuste)
            {
                LoadSolicitudes(false);
            }
        }

        private void LoadSolicitudes(bool Filtro)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_lista_solicitudes_ajuste", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@filtro", SqlDbType.Bit).Value = Filtro;
                    dsFacturasGestion1.AjusteInventarioAutorizacion.Clear();
                    //da.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int).Value = id_cliente;
                    da.Fill(dsFacturasGestion1.AjusteInventarioAutorizacion);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadDataOrdensCompra(bool Filtro)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_ordenes_compra_autorizacion", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@filtro", SqlDbType.Bit).Value = Filtro;
                    dsFacturasGestion1.ordenesCompraAuto.Clear();
                    //da.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int).Value = id_cliente;
                    da.Fill(dsFacturasGestion1.ordenesCompraAuto);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //if (!ValidarPermisoDeGestion(usuarioLogeado))
            //{
            //    CajaDialogo.Error("No tiene Permiso para realizar Gestiones de Ordenes de Compra!");
            //    return;
            //}

            try
            {
                var gridview = (GridView)grdOrdenesCompras.FocusedView;
                var row = (dsFacturasGestion.ordenesCompraAutoRow)gridview.GetFocusedDataRow();
                bool Permitir = false;
                switch (row.id_estado)
                {
                    case 1://Creado
                        CajaDialogo.Error("No se puede Gestionar esta en Estado:"+row.estado);
                        break;

                    case 2://Autorizada
                        CajaDialogo.Error("Orden de Compra ya se encuentra Autorizada.");
                        break;

                    case 3://Cerrada
                        CajaDialogo.Error("Orden de Compra ya fue procesada.");
                        break;

                    case 4://Cancelada
                        CajaDialogo.Error("Orden de Compra Cancelada por el Usuario Solicitante.");
                        break;

                    case 5://Pendiente Aprobacion
                        Permitir = true;
                        break;

                    case 6://Rechazada
                        CajaDialogo.Error("Orden de Compra ya fue Rechazada.");
                        break;
                    default:
                        break;
                }

                if (Permitir)
                {
                    frmOCompraAutorizacion frm = new frmOCompraAutorizacion();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            DataOperations dp = new DataOperations();
                            SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("sp_orden_compras_aprobar_rechazar", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@idOrdenCompra",row.id);
                            cmd.Parameters.AddWithValue("@Respuesta", frm.Respuesta);
                            cmd.Parameters.AddWithValue("@puntoVenta", row.id_punto_venta);
                            cmd.ExecuteNonQuery();

                            LoadDataOrdensCompra(tsFiltro.IsOn);
                        }
                        catch (Exception ex)
                        {
                            CajaDialogo.Error(ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private bool ValidarPermisoDeGestion(UserLogin usuarioLogeado)
        {
            throw new NotImplementedException();
        }

        private void repositoryItemGestion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl3.FocusedView;
            var row = (dsFacturasGestion.AjusteInventarioAutorizacionRow)gridview.GetFocusedDataRow();

            if (row != null) {


                bool Proceder = false;
                string mensaje = string.Empty;
                switch (row.idestado)
                {
                    case 1://Pendiente de Aprobacion
                        Proceder = true;

                        break;
                    case 2:
                        Proceder = false;
                        mensaje = "La Solicitud esta Aprobada\nCree una nueva Soliciutd";
                        break;
                    default:
                        break;
                }

                if (Proceder)
                {
                    frmSolicitudAjusteKardexPT frm = new frmSolicitudAjusteKardexPT(frmSolicitudAjusteKardexPT.TipoOperacion.Aprobacion, usuarioLogeado, row.id);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                           
                            LoadSolicitudes(tsFiltro.IsOn);
                        }
                        catch (Exception ex)
                        {
                            CajaDialogo.Error(ex.Message);
                        }
                    }
                }
                else
                {
                    CajaDialogo.Error(mensaje);
                    return;
                }

            }
        }
    }
}