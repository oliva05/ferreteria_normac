using DevExpress.XtraEditors;
using JAGUAR_PRO.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JAGUAR_PRO.RecuentoInventario;
using DevExpress.Xpo;
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraExport.Helpers;

namespace JAGUAR_PRO.LogisticaJaguar.RecuentoInventario
{
    public partial class frmRecuentoInventarioHome : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        PDV PuntoVentaActual;
        DataOperations dp = new DataOperations();
        public frmRecuentoInventarioHome(UserLogin userLogin, PDV pDV)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
            PuntoVentaActual = pDV;
            dtDesde.DateTime = dp.dNow().AddDays(-7);
            dtHasta.DateTime = dp.dNow().Date.AddDays(1).AddSeconds(-1);
            LoadData();

            try
            {
                //AFC_ConsumoReal
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
                switch (idNivel)
                {
                    case 1://Basic View
                    case 2://Basic No Autorization
                    case 3://Medium Autorization
                        accesoprevio = false;
                        grdvRecuento.Columns["gestion"].Visible = false;
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        grdvRecuento.Columns["gestion"].Visible = true;
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(34))
                    {
                        grdvRecuento.Columns["gestion"].Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }


            //Permiso de Gestion de Aprobacion de Recuento de Inventario
            grdvRecuento.OptionsMenu.EnableColumnMenu = false;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmRecuentoInventarioDetalle frm = new frmRecuentoInventarioDetalle(UsuarioLogeado, PuntoVentaActual);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_recuento_load", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                cmd.Parameters.AddWithValue("@id_punto_venta", PuntoVentaActual.ID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsRecuento1.load_recuentos.Clear();
                da.Fill(dsRecuento1.load_recuentos);
                conn.Close();
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

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void reposCancelar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdRecuento.FocusedView;
            var row = (dsRecuento.load_recuentosRow)gridview.GetFocusedDataRow();

            if (row != null)
            {
                bool Permitir = false;

                switch (row.estadoId)
                {
                    case 1://creado
                        Permitir = true;
                        break;

                    case 2://aprobado
                        Permitir = false;
                        break;
                    case 3://cancelado
                        Permitir = false;
                        break;
                    case 4://completado
                        Permitir = false;
                        break;
                    case 5://rechazo
                        Permitir = false;
                        break;

                    case 6://pendiente de aprobacion
                        Permitir = true;
                        break;

                    default:

                        break;
                }

                if (Permitir)
                {
                    if (CajaDialogo.Pregunta("¿Está seguro de cancelar el recuento?") == DialogResult.Yes)
                    {
                        try
                        {
                            SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("sp_recuento_cancelar", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_recuento", row.id_recuento);
                            cmd.Parameters.AddWithValue("@usuario_cancelacion", UsuarioLogeado.Id);
                            cmd.Parameters.AddWithValue("@punto_venta_id", PuntoVentaActual.ID);
                            cmd.ExecuteNonQuery();

                            LoadData();
                        }
                        catch (Exception ex)
                        {
                            CajaDialogo.Error(ex.Message);
                        }
                    }
                }



            }
        }

        private void reposRealizarConteo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdRecuento.FocusedView;
            var row = (dsRecuento.load_recuentosRow)gridview.GetFocusedDataRow();

            if (row != null)
            {
                bool Permitir = false;

                switch (row.estadoId)
                {
                    case 1://creado
                        Permitir = true;
                        break;

                    case 2://aprobado
                        Permitir = false;
                        break;
                    case 3://cancelado
                        Permitir = false;
                        break;
                    case 4://completado
                        Permitir = false;
                        break;
                    case 5://rechazo
                        Permitir = false;
                        break;

                    case 6://pendiente de aprobacion
                        Permitir = false;
                        break;

                    default:

                        break;
                }

                if (Permitir)
                {
                    frmRecuentoInventarioConteo frm = new frmRecuentoInventarioConteo(UsuarioLogeado, PuntoVentaActual, row.id_recuento, row.docnum, row.fecha_creacion, frmRecuentoInventarioConteo.AccionesRecuento.Conteo);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadData();
                    }
                }



            }
        }

        private void reposAprobacion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdRecuento.FocusedView;
            var row = (dsRecuento.load_recuentosRow)gridview.GetFocusedDataRow();

            if (row != null)
            {
                bool Permitir = false;

                switch (row.estadoId)
                {
                    case 1://creado
                        Permitir = true;
                        break;

                    case 2://aprobado
                        Permitir = false;
                        break;
                    case 3://cancelado
                        Permitir = false;
                        break;
                    case 4://completado
                        Permitir = false;
                        break;
                    case 5://rechazo
                        Permitir = false;
                        break;

                    case 6://pendiente de aprobacion
                        Permitir = true;
                        break;

                    default:

                        break;
                }

                if (Permitir)
                {
                    frmRecuentoInventarioConteo frm = new frmRecuentoInventarioConteo(UsuarioLogeado, PuntoVentaActual, row.id_recuento, row.docnum, row.fecha_creacion, frmRecuentoInventarioConteo.AccionesRecuento.RevisionAprobacion);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadData();
                    }
                }



            }
        }

        private void cmdVerDetalle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdRecuento.FocusedView;
            var row = (dsRecuento.load_recuentosRow)gridview.GetFocusedDataRow();

            if (row != null)
            {
                bool Permitir = false;

                switch (row.estadoId)
                {
                    case 1://creado
                        Permitir = false;
                        break;

                    case 2://aprobado
                        Permitir = false;
                        break;
                    case 3://cancelado
                        Permitir = false;
                        break;
                    case 4://completado
                        Permitir = true;
                        break;
                    case 5://rechazo
                        Permitir = false;
                        break;

                    case 6://pendiente de aprobacion
                        Permitir = false;
                        break;

                    default:

                        break;
                }

                if (Permitir)
                {
                    frmRecuentoInventarioConteo frm = new frmRecuentoInventarioConteo(UsuarioLogeado, PuntoVentaActual, row.id_recuento, row.docnum, row.fecha_creacion, frmRecuentoInventarioConteo.AccionesRecuento.Vista);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadData();
                    }
                }


            }
        }
    }
}