﻿using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace JAGUAR_PRO.Reportes
{
    partial class frmVerDetalleKardexTransactions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerDetalleKardexTransactions));
            this.cmdRecargar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsKardexReportes1 = new JAGUAR_PRO.Reportes.dsKardexReportes();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_reg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tipo_transaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaDoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblItemName = new DevExpress.XtraEditors.LabelControl();
            this.lblInventario = new DevExpress.XtraEditors.LabelControl();
            this.lblAlmacen = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKardexReportes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdRecargar
            // 
            this.cmdRecargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRecargar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRecargar.Appearance.Options.UseFont = true;
            this.cmdRecargar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRecargar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdRecargar.ImageOptions.SvgImage")));
            this.cmdRecargar.Location = new System.Drawing.Point(812, 4);
            this.cmdRecargar.Name = "cmdRecargar";
            this.cmdRecargar.Size = new System.Drawing.Size(104, 47);
            this.cmdRecargar.TabIndex = 10;
            this.cmdRecargar.Text = "Recargar";
            this.cmdRecargar.Click += new System.EventHandler(this.cmdRecargar_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(922, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(104, 47);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Excel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(1032, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 47);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "detalle_transacciones_kardex";
            this.gridControl1.DataSource = this.dsKardexReportes1;
            this.gridControl1.Location = new System.Drawing.Point(3, 94);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1128, 421);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsKardexReportes1
            // 
            this.dsKardexReportes1.DataSetName = "dsKardexReportes";
            this.dsKardexReportes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colfecha_reg,
            this.colNumDocumento,
            this.colid_tipo_transaccion,
            this.colTipo,
            this.colenable,
            this.colenable_descripcion,
            this.colid_pt,
            this.colItemCode,
            this.colItemName,
            this.colid_usuario,
            this.colUsuario,
            this.colFechaDoc,
            this.colEntrada,
            this.colSalida,
            this.colsaldo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // colfecha_reg
            // 
            this.colfecha_reg.Caption = "Fecha Transacción";
            this.colfecha_reg.DisplayFormat.FormatString = "g";
            this.colfecha_reg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_reg.FieldName = "fecha_reg";
            this.colfecha_reg.Name = "colfecha_reg";
            this.colfecha_reg.OptionsColumn.ReadOnly = true;
            this.colfecha_reg.Visible = true;
            this.colfecha_reg.VisibleIndex = 0;
            this.colfecha_reg.Width = 104;
            // 
            // colNumDocumento
            // 
            this.colNumDocumento.FieldName = "NumDocumento";
            this.colNumDocumento.Name = "colNumDocumento";
            this.colNumDocumento.OptionsColumn.ReadOnly = true;
            this.colNumDocumento.Visible = true;
            this.colNumDocumento.VisibleIndex = 2;
            this.colNumDocumento.Width = 95;
            // 
            // colid_tipo_transaccion
            // 
            this.colid_tipo_transaccion.FieldName = "id_tipo_transaccion";
            this.colid_tipo_transaccion.Name = "colid_tipo_transaccion";
            this.colid_tipo_transaccion.OptionsColumn.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.Caption = "Tipo Transacción";
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.OptionsColumn.ReadOnly = true;
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 1;
            this.colTipo.Width = 94;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.ReadOnly = true;
            // 
            // colenable_descripcion
            // 
            this.colenable_descripcion.FieldName = "enable_descripcion";
            this.colenable_descripcion.Name = "colenable_descripcion";
            this.colenable_descripcion.OptionsColumn.ReadOnly = true;
            this.colenable_descripcion.Visible = true;
            this.colenable_descripcion.VisibleIndex = 3;
            this.colenable_descripcion.Width = 102;
            // 
            // colid_pt
            // 
            this.colid_pt.FieldName = "id_pt";
            this.colid_pt.Name = "colid_pt";
            this.colid_pt.OptionsColumn.ReadOnly = true;
            // 
            // colItemCode
            // 
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.ReadOnly = true;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 4;
            this.colItemCode.Width = 81;
            // 
            // colItemName
            // 
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.ReadOnly = true;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 5;
            this.colItemName.Width = 165;
            // 
            // colid_usuario
            // 
            this.colid_usuario.FieldName = "id_usuario";
            this.colid_usuario.Name = "colid_usuario";
            this.colid_usuario.OptionsColumn.ReadOnly = true;
            // 
            // colUsuario
            // 
            this.colUsuario.FieldName = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.OptionsColumn.ReadOnly = true;
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 6;
            this.colUsuario.Width = 100;
            // 
            // colFechaDoc
            // 
            this.colFechaDoc.FieldName = "FechaDoc";
            this.colFechaDoc.Name = "colFechaDoc";
            this.colFechaDoc.OptionsColumn.ReadOnly = true;
            this.colFechaDoc.Visible = true;
            this.colFechaDoc.VisibleIndex = 7;
            this.colFechaDoc.Width = 76;
            // 
            // colEntrada
            // 
            this.colEntrada.DisplayFormat.FormatString = "n0";
            this.colEntrada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colEntrada.FieldName = "Entrada";
            this.colEntrada.Name = "colEntrada";
            this.colEntrada.OptionsColumn.ReadOnly = true;
            this.colEntrada.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Entrada", "SUM={0:n0}")});
            this.colEntrada.Visible = true;
            this.colEntrada.VisibleIndex = 8;
            this.colEntrada.Width = 90;
            // 
            // colSalida
            // 
            this.colSalida.DisplayFormat.FormatString = "n0";
            this.colSalida.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalida.FieldName = "Salida";
            this.colSalida.Name = "colSalida";
            this.colSalida.OptionsColumn.ReadOnly = true;
            this.colSalida.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Salida", "SUM={0:n0}")});
            this.colSalida.Visible = true;
            this.colSalida.VisibleIndex = 9;
            this.colSalida.Width = 100;
            // 
            // colsaldo
            // 
            this.colsaldo.FieldName = "saldo";
            this.colsaldo.Name = "colsaldo";
            this.colsaldo.OptionsColumn.ReadOnly = true;
            this.colsaldo.Visible = true;
            this.colsaldo.VisibleIndex = 10;
            this.colsaldo.Width = 94;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(209, 25);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Detalle de Transacciones";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(4, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 19);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Producto:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(4, 50);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(107, 19);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Inventario Actual:";
            // 
            // lblItemName
            // 
            this.lblItemName.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblItemName.Appearance.Options.UseFont = true;
            this.lblItemName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblItemName.Location = new System.Drawing.Point(117, 30);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(412, 15);
            this.lblItemName.TabIndex = 15;
            this.lblItemName.Text = "PT Name";
            // 
            // lblInventario
            // 
            this.lblInventario.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblInventario.Appearance.Options.UseFont = true;
            this.lblInventario.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblInventario.Location = new System.Drawing.Point(117, 50);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(412, 19);
            this.lblInventario.TabIndex = 16;
            this.lblInventario.Text = "0";
            // 
            // lblAlmacen
            // 
            this.lblAlmacen.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblAlmacen.Appearance.Options.UseFont = true;
            this.lblAlmacen.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAlmacen.Location = new System.Drawing.Point(117, 71);
            this.lblAlmacen.Name = "lblAlmacen";
            this.lblAlmacen.Size = new System.Drawing.Size(412, 19);
            this.lblAlmacen.TabIndex = 18;
            this.lblAlmacen.Text = "0";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(3, 71);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 19);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Almacen:";
            // 
            // frmVerDetalleKardexTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 516);
            this.Controls.Add(this.lblAlmacen);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cmdRecargar);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnClose);
            this.Name = "frmVerDetalleKardexTransactions";
            this.Text = "Detalle Transacciones Kardex Item";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKardexReportes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdRecargar;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private GridControl gridControl1;
        private GridView gridView1;
        private LabelControl labelControl1;
        private dsKardexReportes dsKardexReportes1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_reg;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo_transaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colenable_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colid_usuario;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaDoc;
        private DevExpress.XtraGrid.Columns.GridColumn colEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colSalida;
        private LabelControl labelControl2;
        private LabelControl labelControl3;
        private LabelControl lblItemName;
        private LabelControl lblInventario;
        private DevExpress.XtraGrid.Columns.GridColumn colsaldo;
        private LabelControl lblAlmacen;
        private LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn colNumDocumento;
    }
}