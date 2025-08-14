namespace JAGUAR_PRO.Facturacion.Reportes.Reportes_de_Ventas
{
    partial class frmCalculoDeComisionesPorVentasVendedoresPorFecha
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculoDeComisionesPorVentasVendedoresPorFecha));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsReportesDeVenta1 = new JAGUAR_PRO.Facturacion.Reportes.Reportes_de_Ventas.dsReportesDeVenta();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_vendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colventas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colver_detalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdVerDetalle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdCargar = new DevExpress.XtraEditors.SimpleButton();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdExportToExcel = new DevExpress.XtraEditors.SimpleButton();
            this.colcomision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_rango = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colporcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpremio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrangof = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrangoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesDeVenta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "calculo_comisiones_vendedores";
            this.gridControl1.DataSource = this.dsReportesDeVenta1;
            this.gridControl1.Location = new System.Drawing.Point(2, 84);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdVerDetalle});
            this.gridControl1.Size = new System.Drawing.Size(923, 396);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsReportesDeVenta1
            // 
            this.dsReportesDeVenta1.DataSetName = "dsReportesDeVenta";
            this.dsReportesDeVenta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcodigo_vendedor,
            this.colnombre,
            this.colventas,
            this.colver_detalle,
            this.colcomision,
            this.colid_rango,
            this.colporcentaje,
            this.colpremio,
            this.colrangof,
            this.colrangoi,
            this.coltotal});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // colcodigo_vendedor
            // 
            this.colcodigo_vendedor.FieldName = "codigo_vendedor";
            this.colcodigo_vendedor.Name = "colcodigo_vendedor";
            this.colcodigo_vendedor.OptionsColumn.ReadOnly = true;
            this.colcodigo_vendedor.Visible = true;
            this.colcodigo_vendedor.VisibleIndex = 0;
            this.colcodigo_vendedor.Width = 52;
            // 
            // colnombre
            // 
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.ReadOnly = true;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 159;
            // 
            // colventas
            // 
            this.colventas.DisplayFormat.FormatString = "n2";
            this.colventas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colventas.FieldName = "ventas";
            this.colventas.Name = "colventas";
            this.colventas.OptionsColumn.ReadOnly = true;
            this.colventas.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ventas", "SUM={0:#,###,##0.00}")});
            this.colventas.Visible = true;
            this.colventas.VisibleIndex = 2;
            this.colventas.Width = 111;
            // 
            // colver_detalle
            // 
            this.colver_detalle.ColumnEdit = this.cmdVerDetalle;
            this.colver_detalle.FieldName = "ver_detalle";
            this.colver_detalle.Name = "colver_detalle";
            this.colver_detalle.Visible = true;
            this.colver_detalle.VisibleIndex = 9;
            this.colver_detalle.Width = 71;
            // 
            // cmdVerDetalle
            // 
            this.cmdVerDetalle.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdVerDetalle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdVerDetalle.Name = "cmdVerDetalle";
            this.cmdVerDetalle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdVerDetalle.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdVerDetalle_ButtonClick);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargar.Appearance.Options.UseFont = true;
            this.cmdCargar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCargar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCargar.ImageOptions.Image")));
            this.cmdCargar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdCargar.Location = new System.Drawing.Point(221, 45);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(92, 34);
            this.cmdCargar.TabIndex = 112;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(88, 57);
            this.dtHasta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.Properties.Appearance.Options.UseFont = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtHasta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtHasta.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtHasta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtHasta.Size = new System.Drawing.Size(128, 22);
            this.dtHasta.TabIndex = 111;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(6, 62);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 15);
            this.labelControl3.TabIndex = 110;
            this.labelControl3.Text = "Fecha Hasta:";
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(88, 34);
            this.dtDesde.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Properties.Appearance.Options.UseFont = true;
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtDesde.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDesde.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtDesde.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDesde.Size = new System.Drawing.Size(128, 22);
            this.dtDesde.TabIndex = 109;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(6, 39);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 15);
            this.labelControl5.TabIndex = 108;
            this.labelControl5.Text = "Fecha Desde:";
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(833, 45);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(92, 34);
            this.btnAtras.TabIndex = 107;
            this.btnAtras.Text = "Cerrar";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(2, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(229, 20);
            this.labelControl1.TabIndex = 113;
            this.labelControl1.Text = "Resumen de ventas por vendedor";
            // 
            // cmdExportToExcel
            // 
            this.cmdExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExportToExcel.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportToExcel.Appearance.Options.UseFont = true;
            this.cmdExportToExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdExportToExcel.ImageOptions.Image = global::JAGUAR_PRO.Properties.Resources.Excel_2_icon32px1;
            this.cmdExportToExcel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdExportToExcel.Location = new System.Drawing.Point(735, 45);
            this.cmdExportToExcel.Name = "cmdExportToExcel";
            this.cmdExportToExcel.Size = new System.Drawing.Size(92, 34);
            this.cmdExportToExcel.TabIndex = 118;
            this.cmdExportToExcel.Text = "Exportar";
            this.cmdExportToExcel.Click += new System.EventHandler(this.cmdExportToExcel_Click);
            // 
            // colcomision
            // 
            this.colcomision.DisplayFormat.FormatString = "n2";
            this.colcomision.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcomision.FieldName = "comision";
            this.colcomision.Name = "colcomision";
            this.colcomision.OptionsColumn.ReadOnly = true;
            this.colcomision.Visible = true;
            this.colcomision.VisibleIndex = 6;
            this.colcomision.Width = 94;
            // 
            // colid_rango
            // 
            this.colid_rango.FieldName = "id_rango";
            this.colid_rango.Name = "colid_rango";
            this.colid_rango.OptionsColumn.ReadOnly = true;
            // 
            // colporcentaje
            // 
            this.colporcentaje.DisplayFormat.FormatString = "n2";
            this.colporcentaje.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colporcentaje.FieldName = "porcentaje";
            this.colporcentaje.Name = "colporcentaje";
            this.colporcentaje.OptionsColumn.ReadOnly = true;
            this.colporcentaje.Visible = true;
            this.colporcentaje.VisibleIndex = 5;
            this.colporcentaje.Width = 64;
            // 
            // colpremio
            // 
            this.colpremio.DisplayFormat.FormatString = "n2";
            this.colpremio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpremio.FieldName = "premio";
            this.colpremio.Name = "colpremio";
            this.colpremio.OptionsColumn.ReadOnly = true;
            this.colpremio.Visible = true;
            this.colpremio.VisibleIndex = 7;
            this.colpremio.Width = 94;
            // 
            // colrangof
            // 
            this.colrangof.DisplayFormat.FormatString = "n2";
            this.colrangof.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colrangof.FieldName = "rangof";
            this.colrangof.Name = "colrangof";
            this.colrangof.OptionsColumn.ReadOnly = true;
            this.colrangof.Visible = true;
            this.colrangof.VisibleIndex = 4;
            this.colrangof.Width = 83;
            // 
            // colrangoi
            // 
            this.colrangoi.DisplayFormat.FormatString = "n2";
            this.colrangoi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colrangoi.FieldName = "rangoi";
            this.colrangoi.Name = "colrangoi";
            this.colrangoi.OptionsColumn.ReadOnly = true;
            this.colrangoi.Visible = true;
            this.colrangoi.VisibleIndex = 3;
            this.colrangoi.Width = 76;
            // 
            // coltotal
            // 
            this.coltotal.DisplayFormat.FormatString = "n2";
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.ReadOnly = true;
            this.coltotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", "SUM={0:0.##}")});
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 8;
            this.coltotal.Width = 92;
            // 
            // frmCalculoDeComisionesPorVentasVendedoresPorFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 480);
            this.Controls.Add(this.cmdExportToExcel);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmCalculoDeComisionesPorVentasVendedoresPorFecha";
            this.Text = "Resumen de Ventas por Vendedor";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesDeVenta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton cmdCargar;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private dsReportesDeVenta dsReportesDeVenta1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_vendedor;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colventas;
        private DevExpress.XtraGrid.Columns.GridColumn colver_detalle;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdVerDetalle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdExportToExcel;
        private DevExpress.XtraGrid.Columns.GridColumn colcomision;
        private DevExpress.XtraGrid.Columns.GridColumn colid_rango;
        private DevExpress.XtraGrid.Columns.GridColumn colporcentaje;
        private DevExpress.XtraGrid.Columns.GridColumn colpremio;
        private DevExpress.XtraGrid.Columns.GridColumn colrangof;
        private DevExpress.XtraGrid.Columns.GridColumn colrangoi;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
    }
}