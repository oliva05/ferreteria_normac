using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Formulas;
using JAGUAR_PRO.LogisticaJaguar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO.Mantenimientos.ProductoTerminado
{
    public partial class frmMainProductoTerminado : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        PDV PuntoVentaActual;

        public frmMainProductoTerminado(UserLogin pUserLogin, PDV pPuntoVentaActual)
        {
            InitializeComponent();
            PuntoVentaActual = pPuntoVentaActual;
            MagiaEmbellezedora();
            dp = new DataOperations();
            tggViewFilter.IsOn = false;
            UsuarioLogeado = pUserLogin;
            LoadDataDetallePT();
        }

        private void MagiaEmbellezedora()
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("The Bezier");
            
            gridView1.OptionsView.EnableAppearanceEvenRow = true;
            gridView1.OptionsView.EnableAppearanceOddRow = true;
            gridView1.Appearance.Row.BackColor = Color.LightGray;
            gridView1.Appearance.OddRow.BackColor = Color.White;



        }

        private void LoadDataDetallePT()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_datos_maestros_pt_list_crudV2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ver_todos", tggViewFilter.IsOn);
                dsProductoTerminado1.lista_main_CRUD.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProductoTerminado1.lista_main_CRUD);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdEditarPT_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Boton editar el master de producto
            var gridView = (GridView)gridDetalleProductosCRUD.FocusedView;
            var row = (dsProductoTerminado.lista_main_CRUDRow)gridView.GetFocusedDataRow();
            if (row != null)
            {
                if (row.id > 0)
                {
                    frmCRUD_ProductoTerminado frm = new frmCRUD_ProductoTerminado(this.UsuarioLogeado, frmCRUD_ProductoTerminado.TipoOperacion.Update, row.id);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadDataDetallePT();
                    }
                }
            }
        }


        private void cmdReceta_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Ver Receta del Producto
            var gridView = (GridView)gridDetalleProductosCRUD.FocusedView;
            var row = (dsProductoTerminado.lista_main_CRUDRow)gridView.GetFocusedDataRow();

            if (UsuarioLogeado.ValidarNivelPermisos(1))
            {
                frmFormulasJaguar frm = new frmFormulasJaguar(this.UsuarioLogeado, row.id);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            else
            {
                CajaDialogo.Error("No cuenta con los privilegios para acceder a esta opción! Permiso requerido #1");
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdNuevoPT_Click(object sender, EventArgs e)
        {
            //frmCRUD_ProductoTerminado frm = new frmCRUD_ProductoTerminado(this.UsuarioLogeado, frmCRUD_ProductoTerminado.TipoOperacion.Insert,0);
            frmCRUD_ProductoTerminadoV2 frm = new frmCRUD_ProductoTerminadoV2(this.UsuarioLogeado, frmCRUD_ProductoTerminadoV2.TipoOperacion.Insert, 0, this.PuntoVentaActual);
            if (frm.ShowDialog()== DialogResult.OK)
            {
                LoadDataDetallePT();
            }

        }

        private void cmdExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridDetalleProductosCRUD.ExportToXlsx(dialog.FileName);
        }

        private void tggViewFilter_Toggled(object sender, EventArgs e)
        {
            LoadDataDetallePT();
        }

        private void cmdEditar2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            //Boton editar el master de producto
            var gridView = (GridView)gridDetalleProductosCRUD.FocusedView;
            var row = (dsProductoTerminado.lista_main_CRUDRow)gridView.GetFocusedDataRow();
            if (row != null)
            {
                if (row.id > 0)
                {
                    //frmCRUD_ProductoTerminado frm = new frmCRUD_ProductoTerminado(this.UsuarioLogeado, frmCRUD_ProductoTerminado.TipoOperacion.Update, row.id);
                    frmCRUD_ProductoTerminadoV2 frm = new frmCRUD_ProductoTerminadoV2(this.UsuarioLogeado, frmCRUD_ProductoTerminadoV2.TipoOperacion.Update, row.id, puntoVenta1);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        frm.PT_Actualizado.Id = row.id;
                        frm.PT_Actualizado.Code = row.code;
                        frm.PT_Actualizado.CodeOEM = row.codeOEM;
                        frm.PT_Actualizado.Enable = row.enable; 
                        frm.PT_Actualizado.Fecha = row.fecha;
                        frm.PT_Actualizado.Id_estado = 1;
                        frm.PT_Actualizado.Id_presentacion = row.id_presentacion;
                        frm.PT_Actualizado.Code_interno = row.codeInterno;
                        frm.PT_Actualizado.Codig_Referencia = row.codeReferencia;
                        frm.PT_Actualizado.Id_user_created = row.id_user_created;
                        frm.PT_Actualizado.Usuario_nombre = row.name_user;
                        frm.PT_Actualizado.Descripcion = row.descripcion;
                        frm.PT_Actualizado.Presentacion_name = row.presentacion_name;
                        frm.PT_Actualizado.TipoProductoName = row.tipo_producto;
                        //LoadDataDetallePT();
                    }
                }
            }
        }





        private void cmdReceta2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Ver Receta del Producto
            var gridView = (GridView)gridDetalleProductosCRUD.FocusedView;
            var row = (dsProductoTerminado.lista_main_CRUDRow)gridView.GetFocusedDataRow();

            if (UsuarioLogeado.ValidarNivelPermisos(1))
            {
                frmFormulasJaguar frm = new frmFormulasJaguar(this.UsuarioLogeado, row.id);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            else
            {
                CajaDialogo.Error("No cuenta con los privilegios para acceder a esta opción! Permiso requerido #1");
            }
        }

        private void cmdVistaImagenes_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridDetalleProductosCRUD.FocusedView;
            var row = (dsProductoTerminado.lista_main_CRUDRow)gridview.GetFocusedDataRow();

            FTP_Class ftp = new FTP_Class();
            if (ftp.ValidateConnection())
            {
                frmPT_VisorImagenes frm = new frmPT_VisorImagenes(row.id);
                frm.ShowDialog();
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}