using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_PRO.Clases;
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

namespace JAGUAR_PRO.TransaccionesPT
{
    public partial class frmTrasladoKardexPT : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp1 = new DataOperations();
        UserLogin UsuarioLogeado;
        public int IdTipoLote;
        //string code_sap; //Codigo de MP de SAP
        private decimal factorValue;
        decimal costo_unitario;

        //private decimal FactorUnidades;
        int Id_PT; //ID de Producto Terminado - Tabla en AQFSVR003.ACS4
        string ItemCode; //Id de lote de Producto Terminado

        public frmTrasladoKardexPT(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;
            dtFechaDocumento.DateTime = dp1.NowSetDateTime();

            //gridLookUpEditDestino.EditValue = 10;

            LoadPresentaciones();

            //txtNumLote.Visible = true;
        }

        private void LoadPresentaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_presentaciones_activas_ajuste_PT_V2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsRecepcionMP1.presentaciones.Clear();
                adat.Fill(dsRecepcionMP1.presentaciones);
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

        private void txtPT_Name_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            frmPT frm = new frmPT();
            frm.MdiParent = this.MdiParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtPT_Name.Text = frm.ProductoT;
                Id_PT = frm.id_pt;
                ProductoTerminado productoTerminado = new ProductoTerminado();
                if (productoTerminado.Recuperar_producto(Id_PT))
                {
                    this.ItemCode = productoTerminado.Code;
                    gridLookUpEditPresentacion.EditValue = productoTerminado.Id_presentacion;
                    LoadBodegasAlmacenes(Id_PT);
                }
            }
        }

        private void LoadBodegasAlmacenes(int pID_PT)
        {
            //La primera Query devuelve la existencia > 0 del Articulo Independientemente, si esta configurado para el.
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_kardex_por_id_pt", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", pID_PT);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsRecepcionMP1.bodega_origen.Clear();
                adat.Fill(dsRecepcionMP1.bodega_origen);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            //Esta Query devuelve la Existencia aunque este en 0 si esta configurado para el.
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_kardex_por_id_pt_destino", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", pID_PT);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsRecepcionMP1.bodega_destino.Clear();
                adat.Fill(dsRecepcionMP1.bodega_destino);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        private void gridLookUpEditPresentacion_EditValueChanged(object sender, EventArgs e)
        {
            if (gvLookUpEditPresentacion.RowCount <= 0)
            {
                this.factorValue = 0;
            }
            else
            {
                this.factorValue = Convert.ToDecimal(gvLookUpEditPresentacion.GetFocusedRowCellValue(gvLookUpEditPresentacion.Columns[2]).ToString());
            }

            decimal cantidad_ = 0;
            try
            {
                cantidad_ = Convert.ToDecimal(txtCantidadUnidades.Text);
            }
            catch
            {
            }
        }

        private void txtCantidadUnidades_KeyDown(object sender, KeyEventArgs e)
        {
            decimal cantidad_ = 0;
            try
            {
                cantidad_ = Convert.ToDecimal(txtCantidadUnidades.Text);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void txtCantidadUnidades_Leave(object sender, EventArgs e)
        {

            decimal cantidad_ = 0;
            try
            {
                cantidad_ = Convert.ToDecimal(txtCantidadUnidades.Text);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdRecargar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPT_Name.Text))
            {
                CajaDialogo.Error("Es necesario seleccionar el Producto Terminado!");
                return;
            }

            if (gridLookUpEditPresentacion.EditValue == null)
            {
                CajaDialogo.Error("Debe Seleccionar el tipo de presentacion!");
                return;
            }

            if (Convert.ToDecimal(txtCantidadUnidades.Text) <= 0)
            {
                CajaDialogo.Error("No se puede registrar una cantidad de producto terminado en cero (0)!");
                return;
            }
            if (!string.IsNullOrEmpty(dtFechaDocumento.Text))
            {
                if (dtFechaDocumento.DateTime.Year <= 2020)
                {
                    CajaDialogo.Error("Es necesario ingresar una fecha de documento valida!");
                    return;
                }
            }

            int id_bodega = 0;
            if (!string.IsNullOrEmpty(gleAlmacen.Text))
            {
                id_bodega = dp1.ValidateNumberInt32(gleAlmacen.EditValue);
                if (id_bodega <= 0)
                {
                    CajaDialogo.Error("Es necesario indicar el almacen origen donde se aplicara el ajuste!");
                    return;
                }
            }

            int id_bodgea_destino = 0;
            if (!string.IsNullOrEmpty(grdAlmacenDestino.Text))
            {
                id_bodgea_destino = dp1.ValidateNumberInt32(grdAlmacenDestino.EditValue);
                if (id_bodgea_destino <= 0)
                {
                    CajaDialogo.Error("Es necesario indicar el almacen destino donde se aplicara el ajuste!");
                    return;
                }
            }

            DataOperations dp = new DataOperations();

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.[usp_InsertAjusteManual_Kardex_PT_V5]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", Convert.ToDecimal(Id_PT));
                cmd.Parameters.AddWithValue("@id_Usuario", UsuarioLogeado.Id);
                cmd.Parameters.AddWithValue("@fecha_doc", dtFechaDocumento.EditValue);
                cmd.Parameters.AddWithValue("@fecha_reg", DateTime.Now);
                cmd.Parameters.AddWithValue("@code", ItemCode);
                cmd.Parameters.AddWithValue("@unidades", txtCantidadUnidades.Text);
                //cmd.Parameters.Add("@lote", SqlDbType.VarChar).Value = !string.IsNullOrEmpty(txtNumLote.Text) ? txtNumLote.Text : null;
                if (string.IsNullOrEmpty(txtNumLote.Text))
                    cmd.Parameters.AddWithValue("@lote", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@lote", txtNumLote.Text);

                if (IdTipoLote == 0)
                    cmd.Parameters.AddWithValue("@id_tipo_lote", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@id_tipo_lote", IdTipoLote);


                if (IdTipoLote == 2)
                    cmd.Parameters.AddWithValue("@costo_unitario", costo_unitario);
                else
                    cmd.Parameters.AddWithValue("@costo_unitario", DBNull.Value);

                if (id_bodega == 0)
                    cmd.Parameters.AddWithValue("@id_almacen", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@id_almacen", id_bodega);

                cmd.ExecuteNonQuery();
                conn.Close();

                CajaDialogo.Information("Transaccion Entrada!");
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}