using ACS.Classes;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.Facturacion.CoreFacturas;
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

namespace JAGUAR_PRO.Mantenimientos.Comisiones
{
    public partial class frmCRUDComisionesDetalle : DevExpress.XtraEditors.XtraForm
    {
        public enum TipoOperacion
        {
            Nuevo = 1,
            Editar = 2
        }
        TipoOperacion tipoOperacion;
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        int IdComision = 0;
        public frmCRUDComisionesDetalle(frmCRUDComisionesDetalle.TipoOperacion tipo, UserLogin userLogin, int Pid)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
            IdComision = Pid;
            tipoOperacion = tipo;
            CargarTiposPlanes();
            switch (tipoOperacion)
            {
                case TipoOperacion.Nuevo:
                    txtAnio.Text = dp.Now().Year.ToString();

                    break;
                case TipoOperacion.Editar:
                    Clases.Comisiones comisiones = new Clases.Comisiones();
                    comisiones.RecuperarRegistrosComisionesById(IdComision);
                    txtAnio.Text = comisiones.Anio.ToString();
                    dtDesde.DateTime = comisiones.FechaInicio.Date;
                    dtHasta.DateTime = comisiones.FechaFin.Date;
                    gridLookUpEdit1.EditValue = comisiones.TipoPlanId;
                    txtDescripcion.Text = comisiones.Descripcion;
                    txtInicioComision.EditValue = comisiones.Porcentaje;

                    CargarDetalle();
                    break;
                default:
                    break;
            }
        }

        private void CargarDetalle()
        {
            try
            {
                string query = @"sp_comisiones_detalle_config";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdComision",IdComision);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsComisiones1.detalle_comisiones.Clear();
                adat.Fill(dsComisiones1.detalle_comisiones);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CargarTiposPlanes()
        {
            try
            {
                string query = @"sp_comisiones_get_tipo_plan";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsComisiones1.tipo_planes.Clear();
                adat.Fill(dsComisiones1.tipo_planes);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAnio.Text))
            {
                CajaDialogo.Error("Debe Seleccionar el Año!");
                return;
            }

            if (gvComisiones.RowCount == 0)
            {
                CajaDialogo.Error("Debe de ingresar la configuración de las Comisiones.");
                return;
            }

            if (dtDesde.DateTime >= dtHasta.DateTime)
            {
                CajaDialogo.Error("La fecha de inicio no puede ser mayor o igual a la fecha de fin.");
                return;
            }
            bool Guardar = false;
            SqlTransaction transaction = null;

            SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            switch (tipoOperacion)
            {
                case TipoOperacion.Nuevo:

                    try
                    {
                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "sp_comisiones_insert_h";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@anio",dp.ValidateNumberInt32(txtAnio.Text));
                        cmd.Parameters.AddWithValue("@fecha_inicio",dtDesde.DateTime);
                        cmd.Parameters.AddWithValue("@fecha_fin",dtHasta.DateTime);
                        cmd.Parameters.AddWithValue("@descripcion",txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@user_id",UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@tipo_plan",gridLookUpEdit1.EditValue);
                        cmd.Parameters.AddWithValue("@inicio_comision",txtInicioComision.EditValue);
                        //cmd.Parameters.AddWithValue("", Istraslado ? Convert.ToDecimal(row.id_traslado) : 0);

                        int id_header= Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (dsComisiones.detalle_comisionesRow row in dsComisiones1.detalle_comisiones.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "sp_comisiones_insert_d";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_header", id_header); 
                            cmd.Parameters.AddWithValue("@piso", row.piso);
                            cmd.Parameters.AddWithValue("@techo", row.techo);
                            cmd.Parameters.AddWithValue("@porcentaje", row.porcentaje);
                            cmd.Parameters.AddWithValue("@porcentaje_lps", row.porcentaje_lps);
                            cmd.Parameters.AddWithValue("@bonificacion_extra", row.bonificacion_extra);
                            cmd.Parameters.AddWithValue("@tiene_limite_techo", row.limite_techo);
                            cmd.ExecuteNonQuery();
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

                    break;
                case TipoOperacion.Editar:

                    try
                    {
                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "[sp_comisiones_update_h]";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idComision", IdComision);
                        cmd.Parameters.AddWithValue("@anio", dp.ValidateNumberInt32(txtAnio.Text));
                        cmd.Parameters.AddWithValue("@fecha_inicio", dtDesde.DateTime);
                        cmd.Parameters.AddWithValue("@fecha_fin", dtHasta.DateTime);
                        cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@tipo_plan", gridLookUpEdit1.EditValue);
                        cmd.Parameters.AddWithValue("@inicio_comision", txtInicioComision.EditValue);
                        //cmd.Parameters.AddWithValue("", Istraslado ? Convert.ToDecimal(row.id_traslado) : 0);

                        cmd.ExecuteNonQuery();

                        foreach (dsComisiones.detalle_comisionesRow row in dsComisiones1.detalle_comisiones.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "[sp_comisiones_update_d]";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_header", IdComision);
                            cmd.Parameters.AddWithValue("@piso", row.piso);
                            cmd.Parameters.AddWithValue("@techo", row.techo);
                            cmd.Parameters.AddWithValue("@porcentaje", row.porcentaje);
                            cmd.Parameters.AddWithValue("@porcentaje_lps", row.porcentaje_lps);
                            cmd.Parameters.AddWithValue("@bonificacion_extra", row.bonificacion_extra);
                            cmd.Parameters.AddWithValue("@tiene_limite_techo", row.limite_techo);
                            cmd.ExecuteNonQuery();
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
                    break;
                default:
                    break;
            }

            if (Guardar)
            {
                CajaDialogo.Information("Configuracion Guardada con Exito!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvComisiones_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridview = (GridView)gcComisiones.FocusedView;
            var row = (dsComisiones.detalle_comisionesRow)gridview.GetFocusedDataRow();

            decimal InicioComision = Convert.ToDecimal(txtInicioComision.EditValue);

            if (InicioComision == 0)
            {
                CajaDialogo.Error("Debe indicar un monto minimo de comision!");
                return;
            }

            switch (e.Column.FieldName)
            {
                case "porcentaje":

                    if (row.limite_techo)
                    {
                        row.porcentaje_lps = row.piso * (row.porcentaje / 100);
                        row.total_pago = row.porcentaje_lps + row.bonificacion_extra;
                    }
                    else
                    {
                        if (row.techo < InicioComision)
                        {
                            row.porcentaje = 0;
                            row.porcentaje_lps = 0;
                            row.bonificacion_extra = 0;
                            row.total_pago = 0;
                        }
                        else
                        {

                            row.porcentaje_lps = row.techo * (row.porcentaje / 100);
                            row.total_pago = row.porcentaje_lps + row.bonificacion_extra;

                        }
                    }
                   

                    break;

                case "techo":
                    if (row.techo < InicioComision)
                    {
                        row.porcentaje = 0;
                        row.porcentaje_lps = 0;
                        row.bonificacion_extra = 0;
                        row.total_pago = 0;
                    }
                    else
                    {
                        row.porcentaje_lps = row.techo * (row.porcentaje / 100);
                        row.total_pago = row.porcentaje_lps + row.bonificacion_extra;
                    }

                    break;

                case "bonificacion_extra":
                    if (row.techo < InicioComision)
                    {
                        row.porcentaje = 0;
                        row.porcentaje_lps = 0;
                        row.bonificacion_extra = 0;
                        row.total_pago = 0;
                    }
                    else
                    {
                        row.porcentaje_lps = row.techo * (row.porcentaje / 100);
                        row.total_pago = row.porcentaje_lps + row.bonificacion_extra;
                    }
                    break;

                case "limite_techo":

                    bool TieneLimiteMaximo = Convert.ToBoolean(e.Value);
                    if (TieneLimiteMaximo)
                    {
                        row.techo = 0;// DBNull.Value;
                        row.porcentaje_lps = row.piso * (row.porcentaje / 100);
                        row.total_pago = row.porcentaje_lps + row.bonificacion_extra;
                    }
                    break;
                default:
                    break;
            }
        }

        private void UpdateComisionDetalleEnable(int pId, bool pEnable)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_set_enable_comiciones_detalle]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pId);
                cmd.Parameters.AddWithValue("@enable", pEnable);
                cmd.ExecuteNonQuery();
                
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Button Click delete row in comisiones detalle.
            DialogResult r = MessageBox.Show("¿Desea Eliminar esta linea?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes)
                return;
            
            var gridView1 = (GridView)gcComisiones.FocusedView;
            var row = (dsComisiones.detalle_comisionesRow)gridView1.GetFocusedDataRow();

            try
            {
                //Nueva funcion de elminar 
                int idRow = row.id; // ID que quieres eliminar

                // Buscar las filas que coincidan con el ID
                DataRow[] filas = dsComisiones1.detalle_comisiones.Select($"id = {idRow}");

                // Eliminar cada fila encontrada
                foreach (DataRow fila in filas)
                {
                    dsComisiones1.detalle_comisiones.Rows.Remove(fila);
                }

                UpdateComisionDetalleEnable(idRow, false);

                //Eliminamos el registro padre 
                //gridView1.DeleteRow(gridView1.FocusedRowHandle);
                dsComisiones1.AcceptChanges();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}