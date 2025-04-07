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
using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.LogisticaJaguar;

namespace JAGUAR_PRO.TransaccionesPT
{
    public partial class frmRequisaTraslado : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();


        public frmRequisaTraslado(UserLogin userLogin)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
            dtDesde.DateTime = dp.Now().AddDays(-30);
            dtHasta.DateTime = dp.Now().AddDays(1);
            LoadDatos();
            gridView1.ExpandAllGroups();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                //SqlCommand cmd = new SqlCommand("codesahn.sp_get_detalle_facturas_recibidas", con);
                SqlCommand cmd = new SqlCommand("dbo.[sp_get_solicitudes_traslados_by_date]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@ver_todas", toggleSwitchVerTodas.IsOn);
                cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                dsPT1.solcitudes_h.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPT1.solcitudes_h);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnTraslado_Click(object sender, EventArgs e)
        {
            frmNewTrasladoPT frm = new frmNewTrasladoPT(UsuarioLogeado, frmNewTrasladoPT.TipoOperacion.SolicitudTraslado, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDatos();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (tsExpandir.IsOn)
            {
                gridView1.ExpandAllGroups();
            }
            else
            {
                gridView1.CollapseAllGroups();
                
            }
        }

        private void reposVerDetalle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsPT.solcitudes_hRow)gridview.GetFocusedDataRow();

            if (row != null)
            {
                frmNewTrasladoPT frm = new frmNewTrasladoPT(UsuarioLogeado, frmNewTrasladoPT.TipoOperacion.SoloVista, row.id);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadDatos();
                }

            }    

        }

        private void reposTraslado_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsPT.solcitudes_hRow)gridview.GetFocusedDataRow();

            bool Permitir = false;
            if (row != null)
            {
                switch (row.id_estado)
                {
                    case 1: //Pendiente de Aprobación
                        CajaDialogo.Error("No se puede realizar el traslado, la Requisa no ha sido aprobada.");
                        break;

                    case 2://Autorizado
                        Permitir = true;
                        break;

                    case 3://Cancelado
                        CajaDialogo.Error("No se puede realizar el traslado, la Requisa ya ha sido Cancelada.");
                        
                        break;

                    case 4://Rechazado
                        CajaDialogo.Error("No se puede realizar el traslado, la Requisa ya ha sido Rechazada.");

                        break;

                    case 5://Completado
                        CajaDialogo.Error("No se puede realizar el traslado, la Requisa ya ha sido completada.");
                        break;
                    default:
                        break;
                }

                if (Permitir)
                {
                    frmNewTrasladoPT frm = new frmNewTrasladoPT(UsuarioLogeado, frmNewTrasladoPT.TipoOperacion.TrasladoFinal, row.id);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadDatos();
                    }
                }
                
            }

        }

        private void reposAprobacion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsPT.solcitudes_hRow)gridview.GetFocusedDataRow();

            bool Permitir = false;
            if (row != null)
            {
                switch (row.id_estado)
                {
                    case 1: //Pendiente de Aprobación
                        Permitir = true;
                        break;

                    case 2://Autorizado
                        CajaDialogo.Error("No se puede realizar el traslado, la Requisa ya ha sido Aprobada.");
                        break;

                    case 3://Cancelado
                        CajaDialogo.Error("No se puede realizar el traslado, la Requisa ya ha sido Cancelada.");

                        break;

                    case 4://Rechazado
                        CajaDialogo.Error("No se puede realizar el traslado, la Requisa ya ha sido Rechazada.");

                        break;

                    case 5://Completado
                        CajaDialogo.Error("No se puede realizar el traslado, la Requisa ya ha sido completada.");
                        break;
                    default:
                        break;
                }

                if (Permitir)
                {
                    frmCambiarEstadoDoc frm = new frmCambiarEstadoDoc(row.id_estado);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("sp_update_requisa_estado", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@idRequisa", row.id);
                            cmd.Parameters.AddWithValue("@idEstado", frm.IdEstadoSeleccionado);
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            CajaDialogo.Error(ex.Message);
                        }

                        CajaDialogo.Information("Requisa Actualizada!");
                        LoadDatos();
                    }
                }
            }
        }
    }
}