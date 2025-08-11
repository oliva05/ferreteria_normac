using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Compras;
using JAGUAR_PRO.Contabilidad;
using JAGUAR_PRO.LogisticaJaguar;
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

namespace JAGUAR_PRO.Contabilidad.Proveedores
{
    public partial class frmMainAnticipos : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        PDV PuntoVentaActual;
        DataOperations dp = new DataOperations();
        public frmMainAnticipos(UserLogin userLogin, PDV puntoVenta)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
            PuntoVentaActual = puntoVenta;
            DateTime fechaActual = dp.NowSetDateTime();
            DateTime FechaInicial = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, 0, 0, 0);

            DateTime FechaFinal = FechaInicial.AddHours(23);
            //FechaInicial.AddDays(-30);
            //FechaInicial.Date.AddDays(-30);
            FechaInicial = FechaInicial.AddDays(-30);

            dtDesde.EditValue = FechaInicial;
            dtHasta.EditValue = FechaFinal;
            LoadAnticipos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCRUDAnticipo frm = new frmCRUDAnticipo(UsuarioLogeado, PuntoVentaActual);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadAnticipos();
            }
        }

        private void LoadAnticipos()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_anticipo_load", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@filto", 1);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsAnticipo1.list_anticipo.Clear();
                adat.Fill(dsAnticipo1.list_anticipo);
                conn.Close();


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            LoadAnticipos();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdAnticipo.ExportToXlsx(dialog.FileName);
            }
        }

        private void reposCancelar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdAnticipo.FocusedView;
            var row = (dsAnticipo.list_anticipoRow)gridview.GetFocusedDataRow();


            bool Permitir = false;

            if (row != null)
            {
                switch (row.estado_id)
                {
                    case 1://CREADO
                        Permitir = true;
                        break;
                    default:
                        Permitir = false;
                        break;
                }

                if (Permitir)
                {


                    DialogResult r = CajaDialogo.Pregunta("Desea Guardar los cambios?");
                    if (r == DialogResult.Yes)
                    {

                        SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        SqlTransaction transaction = null;
                        try
                        {
                            conn.Open();
                            transaction = conn.BeginTransaction("Transaction Order");
                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandText = "sp_anticipo_cancelar";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id", row.id);
                            cmd.Parameters.AddWithValue("@usuario_id", UsuarioLogeado.Id);
                            cmd.ExecuteNonQuery();
                            transaction.Commit();
                            CajaDialogo.Information("Anticipo Cancelado Correctamente!");
                            LoadAnticipos();
                        }
                        catch (Exception ex)
                        {
                            if (transaction != null)
                                transaction.Rollback();
                            CajaDialogo.Error(ex.Message);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
                else
                {
                    CajaDialogo.Error("No se puede cancelar el anticipo seleccionado!");
                }
            }
        }

        private void reposVerOC_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdAnticipo.FocusedView;
            var row = (dsAnticipo.list_anticipoRow)gridview.GetFocusedDataRow();

            if (row.orden_compra_id > 0)
            {
                frmOrdenesCompraMain frm = new frmOrdenesCompraMain(UsuarioLogeado,frmOrdenesCompraMain.TipoOperacion.View , PuntoVentaActual, row.orden_compra_id);
                frm.ShowDialog();
            }
            
        }

        private void cmdVerDetalle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdAnticipo.FocusedView;
            var row = (dsAnticipo.list_anticipoRow)gridview.GetFocusedDataRow();

            if (row != null)
            {
                switch (row.estado_id)
                {
                    case 1://creado

                        frmSearchOrdenesC frm = new frmSearchOrdenesC(frmSearchOrdenesC.FiltroOrdenesCompra.DisponiblesAncitipos, PuntoVentaActual, UsuarioLogeado, frmSearchOrdenesC.TipoDoc.OrdenCompra, row.proveedor_id);
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            if (frm.IdOrdenesSeleccionado > 0)
                            {
                                try
                                {
                                    SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                                    conn.Open();
                                    SqlCommand cmd = new SqlCommand("sp_anticipo_ligarOC", conn);
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@anticipo_id", row.id);
                                    cmd.Parameters.AddWithValue("@orden_compra_id", frm.IdOrdenesSeleccionado);
                                    cmd.Parameters.AddWithValue("@usuario_id", UsuarioLogeado.Id);
                                    cmd.ExecuteNonQuery();
                                    CajaDialogo.Information("Anticipo ligado a Orden de Compra!");
                                    LoadAnticipos();
                                }
                                catch (Exception ex)
                                {
                                    CajaDialogo.Error(ex.Message);
                                }
                            }

                        }

                        break;
                    default:
                        break;
                }
            }
            else
            {
                CajaDialogo.Error("No se ha seleccionado ningun anticipo!");
            }
        }
    }
}