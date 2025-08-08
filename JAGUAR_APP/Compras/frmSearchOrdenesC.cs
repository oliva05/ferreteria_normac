using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Compras;
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

namespace JAGUAR_PRO.Compras
{
    public partial class frmSearchOrdenesC : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        PDV PuntoVentaActual;
        UserLogin UsuarioLogueado;
        public int IdOrdenesSeleccionado = 0;
        int PuntoVentaID;
        int IdProveedor;
        public enum FiltroOrdenesCompra
        {
            Todas = 1,
            Abiertas = 2,
            DisponiblesAncitipos = 3
        }

        public enum TipoDoc
        {
            OrdenCompra = 1,
            SolicitudCompra = 2
        }

        FiltroOrdenesCompra Filtro;
        TipoDoc TipoDocumento;

        public frmSearchOrdenesC(frmSearchOrdenesC.FiltroOrdenesCompra pfiltro, PDV pPuntoVentaActual, UserLogin pUserLogin, frmSearchOrdenesC.TipoDoc pTipoDoc)
        {
            InitializeComponent();
            TipoDocumento = pTipoDoc;
            Filtro = pfiltro;
            UsuarioLogueado = pUserLogin;
            this.PuntoVentaActual = pPuntoVentaActual;
            
            PuntoVentaID = PuntoVentaActual.ID;
            LoadSucursales();
            grdSucursales.EditValue = PuntoVentaID;

            switch (TipoDocumento)
            {
                case TipoDoc.OrdenCompra:
                    navigationFrame1.SelectedPage = navPOrdenCompra;
                    LoadData();
                    break;
                case TipoDoc.SolicitudCompra:
                    navigationFrame1.SelectedPage = navPSolicitudes;
                    LoadDataSolicitudes();
                    break;
                default:
                    break;
            }

            //int i = Convert.ToInt32(UsuarioLogueado.GrupoUsuario.GrupoUsuarioActivo);

            //switch (UsuarioLogueado.GrupoUsuario.GrupoUsuarioActivo)
            //{
            //    case GrupoUser.GrupoUsuario.Manager:
            //        grdSucursales.Enabled = true;
            //        break;
            //    case GrupoUser.GrupoUsuario.Facturacion:
            //        break;
            //    case GrupoUser.GrupoUsuario.Atencion_al_cliente:
            //        break;
            //    case GrupoUser.GrupoUsuario.Cajero:
            //        break;
            //    case GrupoUser.GrupoUsuario.Supervisor:
            //        grdSucursales.Enabled = true;
            //        break;
            //    default:
            //        break;
            //}
        }


        public frmSearchOrdenesC(frmSearchOrdenesC.FiltroOrdenesCompra pfiltro, PDV pPuntoVentaActual, UserLogin pUserLogin, frmSearchOrdenesC.TipoDoc pTipoDoc, int pIdProveedor)
        {
            InitializeComponent();
            TipoDocumento = pTipoDoc;
            Filtro = pfiltro;
            UsuarioLogueado = pUserLogin;
            this.PuntoVentaActual = pPuntoVentaActual;

            PuntoVentaID = PuntoVentaActual.ID;
            LoadSucursales();
            grdSucursales.EditValue = PuntoVentaID;
            IdProveedor = pIdProveedor;
            switch (TipoDocumento)
            {
                case TipoDoc.OrdenCompra:
                    navigationFrame1.SelectedPage = navPOrdenCompra;
                    LoadDatabyProveedor();
                    break;
                case TipoDoc.SolicitudCompra:
                    navigationFrame1.SelectedPage = navPSolicitudes;
                    LoadDataSolicitudes();
                    break;
                default:
                    break;
            }

        }

        private void LoadSucursales()
        {
            try
            {
                string query = @"[sp_get_lista_puntos_de_venta]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.sucursales.Clear();
                adat.Fill(dsCompras1.sucursales);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadDatabyProveedor()
        {

            try
            {
                string query = @"sp_get_ordenes_compra_openV2_byIdProveedor";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                switch (Filtro)
                {
                    case FiltroOrdenesCompra.DisponiblesAncitipos:
                        cmd.Parameters.AddWithValue("@filtro", 3);
                        break;

                    default:
                        break;
                }
                cmd.Parameters.AddWithValue("@PuntoVentaActual", PuntoVentaID);
                cmd.Parameters.AddWithValue("@idProv", IdProveedor);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.orden_compra.Clear();
                adat.Fill(dsCompras1.orden_compra);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadData()
        {

            try
            {
                string query = @"[sp_get_ordenes_compra_openV3]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                switch (Filtro)
                {
                    case FiltroOrdenesCompra.Todas:
                        cmd.Parameters.AddWithValue("@filtro", 1);
                        break;

                    case FiltroOrdenesCompra.Abiertas:
                        cmd.Parameters.AddWithValue("@filtro", 2);
                        break;

                    case FiltroOrdenesCompra.DisponiblesAncitipos:
                        cmd.Parameters.AddWithValue("@filtro", 3);
                        break;

                    default:
                        break;
                }
                cmd.Parameters.AddWithValue("@PuntoVentaActual", PuntoVentaID);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.orden_compra.Clear();
                adat.Fill(dsCompras1.orden_compra);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadDataSolicitudes()
        {

            try
            {
                string query = @"sp_compras_search_solicitudes";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                switch (Filtro)
                {
                    case FiltroOrdenesCompra.Todas:
                        cmd.Parameters.AddWithValue("@filtro", 1);
                        break;

                    case FiltroOrdenesCompra.Abiertas:
                        cmd.Parameters.AddWithValue("@filtro", 2);
                        break;

                    default:
                        break;
                }
                cmd.Parameters.AddWithValue("@puntoVentaId", PuntoVentaID);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.solicitudes_compra.Clear();
                adat.Fill(dsCompras1.solicitudes_compra);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridview = (GridView)grdOrdenCompra.FocusedView;
            var row = (dsCompras.orden_compraRow)gridview.GetFocusedDataRow();

            if (row.id > 0)
            {
                IdOrdenesSeleccionado = row.id;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void reposSelected_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdOrdenCompra.FocusedView;
            var row = (dsCompras.orden_compraRow)gridview.GetFocusedDataRow();

            if (row.id > 0)
            {
                IdOrdenesSeleccionado = row.id;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void grdSucursales_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(grdSucursales.EditValue) > 0)
            {
                PuntoVentaID = Convert.ToInt32(grdSucursales.EditValue);
                LoadData();
            }
        }

        private void reposSelectedes_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdSolicitudes.FocusedView;
            var row = (dsCompras.solicitudes_compraRow)gridview.GetFocusedDataRow();

            if (row.id > 0)
            {
                IdOrdenesSeleccionado = row.id;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        private void grdvSolicitudes_DoubleClick(object sender, EventArgs e)
        {
            var gridview = (GridView)grdSolicitudes.FocusedView;
            var row = (dsCompras.solicitudes_compraRow)gridview.GetFocusedDataRow();

            if (row.id > 0)
            {
                IdOrdenesSeleccionado = row.id;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}