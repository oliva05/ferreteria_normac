﻿using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmPT : DevExpress.XtraEditors.XtraForm
    {
        public string ProductoT, CodeSAP;
        public int id_pt;

        //int tipoTransaccion = 0;

        public frmPT()
        {
            InitializeComponent();
            //tipoTransaccion = pTipoTransaccion;
            cargardatos();
        }

        private void cargardatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                string SQL = @"dbo.usp_get_PT_Kardex_V2";
                SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);
                adat.SelectCommand.CommandType = CommandType.StoredProcedure;
                dsPT1.producto_terminado.Clear();
               
                adat.Fill(dsPT1.producto_terminado);
                cn.Close();
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

        private void btnSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gcPT.FocusedView;
            var row = (dsPT.producto_terminadoRow)gvPT.GetFocusedDataRow();

            this.ProductoT = row.pt;

            id_pt = row.id_pt;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gvMP_DoubleClick(object sender, EventArgs e)
        {
            var gridView = (GridView)gcPT.FocusedView;
            var row = (dsPT.producto_terminadoRow)gridView.GetFocusedDataRow();

            this.ProductoT = row.pt;
       
            id_pt = row.id_pt;

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}