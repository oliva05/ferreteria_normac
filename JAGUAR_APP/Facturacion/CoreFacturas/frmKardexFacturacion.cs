﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ACS.Classes;
using JAGUAR_APP.Clases;
using JAGUAR_APP.TransaccionesPT;
using JAGUAR_APP.Reportes;
using DevExpress.XtraGrid.Views.Grid;

namespace JAGUAR_APP.Facturacion.CoreFacturas
{
    public partial class frmKardexFacturacion : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        PDV PuntoVentaActual;

        public frmKardexFacturacion(UserLogin pUserLogin, PDV pPuntoVenta)
        {
            InitializeComponent();

            UsuarioLogeado = pUserLogin;
            PuntoVentaActual = pPuntoVenta;

            LoadPuntosVenta();
            if (PuntoVentaActual == null)
            {
                //CajaDialogo.Error("No se configuro un punto de venta valido!");
                PuntoVentaActual = new PDV();
            }
            else
            {
                glePuntoVenta.EditValue = PuntoVentaActual.ID;
            }

            grdv_inventario.OptionsMenu.EnableColumnMenu = false;
            grdv_inventario.Columns["costo"].Visible = false;

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//11=Ovejita
            switch (idNivel)
            {
                case 1://Basic View
                case 2://Basic No Autorization
                case 3://Medium Autorization
                    cmdAjuste.Visible = false;
                    glePuntoVenta.Visible = false;
                    lblSeleccionarPuntoVenta.Visible = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    //Accesso a costos
                    grdv_inventario.OptionsMenu.EnableColumnMenu = true;
                    glePuntoVenta.Visible = true;
                    lblSeleccionarPuntoVenta.Visible = true;
                    break;
                default:
                    grdv_inventario.OptionsMenu.EnableColumnMenu = false;
                    glePuntoVenta.Visible = false;
                    lblSeleccionarPuntoVenta.Visible = false;
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(7))
                {
                    grdv_inventario.OptionsMenu.EnableColumnMenu = true;
                    glePuntoVenta.Visible = true;
                    lblSeleccionarPuntoVenta.Visible = true;
                }
                else
                {
                    //CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #7");
                }
            }


            get_inventario();

        }

        private void LoadPuntosVenta()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_lista_puntos_venta_ovejita", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsFacturasGestion.punto_venta.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsFacturasGestion.punto_venta);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void get_inventario()
        {
            try
            {
                //string query = @"dbo.sp_get_kardex_pt";
                string query = @"dbo.[uspGetKardexFacturacionGeneral_v2]";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_punto_venta", this.PuntoVentaActual.ID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsFacturasGestion.kardex_facturacion.Clear();
                da.Fill(dsFacturasGestion.kardex_facturacion);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
               //xtraOpenFileDialog1 dialog = new xtraOpenFileDialog1SaveFileDialog();
                xtraSaveFileDialog1.Filter = "Excel File (.xlsx)|*.xlsx";
                xtraSaveFileDialog1.FilterIndex = 0;
                xtraSaveFileDialog1.ShowDialog();
               grd_inventario.ExportToXlsx(xtraSaveFileDialog1.FileName);
                    
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdAjuste_Click(object sender, EventArgs e)
        {
            frmAjusteKardexFactura frm = new frmAjusteKardexFactura(UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
               
                get_inventario();
            }
        }

        private void cmdRecargar_Click(object sender, EventArgs e)
        {
            get_inventario();
        }

        private void glePuntoVenta_EditValueChanged(object sender, EventArgs e)
        {
            this.PuntoVentaActual.ID = dp.ValidateNumberInt32(glePuntoVenta.EditValue);
            get_inventario();
        }

        private void cmdVerDetalle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grd_inventario.FocusedView;
            var row = (dsFacturasGestion.kardex_facturacionRow)gridView.GetFocusedDataRow();

            if (row != null)
            {
                if (row.Isid_ptNull())
                {
                    CajaDialogo.Error("Ha ocurrido un error al seleccionar el registro para ver el detalle de movimientos! MSJ: columna id_pt");
                }
                else
                {
                    if (row.Isproducto_terminadoNull())
                    {
                        CajaDialogo.Error("Ha ocurrido un error al seleccionar el registro para ver el detalle de movimientos! MSJ: columna producto_terminado");
                    }
                    else
                    {
                        frmVerDetalleKardexTransactionsFact frm = new frmVerDetalleKardexTransactionsFact(row.id_pt,
                                                                                                          (row.itemcode + " - "+ row.producto_terminado),
                                                                                                          dp.ValidateNumberDecimal(row.existencia),
                                                                                                          this.PuntoVentaActual.ID);
                        frm.Show();
                    }
                }
            }
            else
            {
                CajaDialogo.Error("Ha ocurrido un error al seleccionar el registro para ver el detalle de movimientos!");
            }
        }
    }
}