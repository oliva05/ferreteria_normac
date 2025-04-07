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
using DevExpress.Charts.Native;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_PRO.LogisticaJaguar;

namespace JAGUAR_PRO.TransaccionesPT
{
    public partial class frmCambiarEstadoDoc : DevExpress.XtraEditors.XtraForm
    {
        int IdEstado = 0;
        public int IdEstadoSeleccionado = 0;
        public frmCambiarEstadoDoc(int pIdEstado)
        {
            InitializeComponent();
            IdEstado = pIdEstado;

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string query = @"sp_get_estados_documentos";
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEstado", IdEstado);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPT1.estados_documentos.Clear();
                adat.Fill(dsPT1.estados_documentos);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            ;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            foreach (dsPT.estados_documentosRow item in dsPT1.estados_documentos)
            {
                if (item.seleccion)
                {
                    IdEstadoSeleccionado = item.id;
                }
            }

            if (IdEstadoSeleccionado == 0)
            {
                CajaDialogo.Error("Seleccione un estado");
                return;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsPT.estados_documentosRow)gridview.GetFocusedDataRow();

            IdEstado = row.id;
            row.seleccion = true;

            foreach (dsPT.estados_documentosRow item in dsPT1.estados_documentos)
            {
                if (item.id != IdEstado)
                    item.seleccion = false;
            }
            dsPT1.AcceptChanges();
            
        }
    }
}