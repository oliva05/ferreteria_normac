namespace JAGUAR_PRO.Contabilidad.Reportes
{
    partial class frmReporteVentasXMes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteVentasXMes));
            this.cmdVerFacturas = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmdSalir = new DevExpress.XtraEditors.SimpleButton();
            this.cmdExcel = new DevExpress.XtraEditors.SimpleButton();
            this.dtMes = new DevExpress.XtraEditors.DateEdit();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.grdRpt = new DevExpress.XtraGrid.GridControl();
            this.dsReportesBasicosConta1 = new JAGUAR_PRO.Contabilidad.Reportes.dsReportesBasicosConta();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFechaDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesde = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHasta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExentas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGravable_15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISV15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGravable_18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISV18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtMes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMes.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRpt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesBasicosConta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdVerFacturas
            // 
            this.cmdVerFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdVerFacturas.Appearance.BackColor = System.Drawing.Color.Ivory;
            this.cmdVerFacturas.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVerFacturas.Appearance.Options.UseBackColor = true;
            this.cmdVerFacturas.Appearance.Options.UseFont = true;
            this.cmdVerFacturas.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdVerFacturas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdVerFacturas.ImageOptions.Image")));
            this.cmdVerFacturas.Location = new System.Drawing.Point(969, 81);
            this.cmdVerFacturas.Name = "cmdVerFacturas";
            this.cmdVerFacturas.Size = new System.Drawing.Size(114, 32);
            this.cmdVerFacturas.TabIndex = 89;
            this.cmdVerFacturas.Text = "Ver Facturas";
            this.cmdVerFacturas.Visible = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(420, 23);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(217, 23);
            this.labelControl3.TabIndex = 88;
            this.labelControl3.Text = "Resumen de ventas por mes";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSalir.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdSalir.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmdSalir.Appearance.Options.UseBackColor = true;
            this.cmdSalir.Appearance.Options.UseFont = true;
            this.cmdSalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.ImageOptions.Image")));
            this.cmdSalir.Location = new System.Drawing.Point(969, 23);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(114, 38);
            this.cmdSalir.TabIndex = 87;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdExcel
            // 
            this.cmdExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExcel.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.cmdExcel.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExcel.Appearance.Options.UseBackColor = true;
            this.cmdExcel.Appearance.Options.UseFont = true;
            this.cmdExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdExcel.ImageOptions.Image")));
            this.cmdExcel.Location = new System.Drawing.Point(849, 23);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.Size = new System.Drawing.Size(114, 38);
            this.cmdExcel.TabIndex = 86;
            this.cmdExcel.Text = "Excel";
            this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
            // 
            // dtMes
            // 
            this.dtMes.EditValue = null;
            this.dtMes.Location = new System.Drawing.Point(26, 40);
            this.dtMes.Name = "dtMes";
            this.dtMes.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtMes.Properties.Appearance.Options.UseFont = true;
            this.dtMes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtMes.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtMes.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtMes.Size = new System.Drawing.Size(151, 24);
            this.dtMes.TabIndex = 85;
            this.dtMes.EditValueChanged += new System.EventHandler(this.dtMes_EditValueChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            this.btnRefresh.Location = new System.Drawing.Point(199, 35);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 32);
            this.btnRefresh.TabIndex = 81;
            this.btnRefresh.Text = "Actualizar";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // grdRpt
            // 
            this.grdRpt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdRpt.DataMember = "resumen_ventas_x_mes";
            this.grdRpt.DataSource = this.dsReportesBasicosConta1;
            this.grdRpt.Location = new System.Drawing.Point(3, 133);
            this.grdRpt.MainView = this.gridView1;
            this.grdRpt.Name = "grdRpt";
            this.grdRpt.Size = new System.Drawing.Size(1088, 527);
            this.grdRpt.TabIndex = 90;
            this.grdRpt.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsReportesBasicosConta1
            // 
            this.dsReportesBasicosConta1.DataSetName = "dsReportesBasicosConta";
            this.dsReportesBasicosConta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFechaDocumento,
            this.colDesde,
            this.colHasta,
            this.colExentas,
            this.colGravable_15,
            this.colISV15,
            this.colGravable_18,
            this.colISV18,
            this.colTotal});
            this.gridView1.GridControl = this.grdRpt;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colFechaDocumento
            // 
            this.colFechaDocumento.FieldName = "FechaDocumento";
            this.colFechaDocumento.Name = "colFechaDocumento";
            this.colFechaDocumento.OptionsColumn.ReadOnly = true;
            this.colFechaDocumento.Visible = true;
            this.colFechaDocumento.VisibleIndex = 0;
            this.colFechaDocumento.Width = 122;
            // 
            // colDesde
            // 
            this.colDesde.FieldName = "Desde";
            this.colDesde.Name = "colDesde";
            this.colDesde.OptionsColumn.ReadOnly = true;
            this.colDesde.Visible = true;
            this.colDesde.VisibleIndex = 1;
            this.colDesde.Width = 162;
            // 
            // colHasta
            // 
            this.colHasta.FieldName = "Hasta";
            this.colHasta.Name = "colHasta";
            this.colHasta.OptionsColumn.ReadOnly = true;
            this.colHasta.Visible = true;
            this.colHasta.VisibleIndex = 2;
            this.colHasta.Width = 146;
            // 
            // colExentas
            // 
            this.colExentas.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colExentas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colExentas.FieldName = "Exentas";
            this.colExentas.Name = "colExentas";
            this.colExentas.OptionsColumn.ReadOnly = true;
            this.colExentas.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Exentas", "{0:#,###,##0.00}")});
            this.colExentas.Visible = true;
            this.colExentas.VisibleIndex = 3;
            this.colExentas.Width = 99;
            // 
            // colGravable_15
            // 
            this.colGravable_15.Caption = "Grav. 15%";
            this.colGravable_15.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colGravable_15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGravable_15.FieldName = "Gravable_15";
            this.colGravable_15.Name = "colGravable_15";
            this.colGravable_15.OptionsColumn.ReadOnly = true;
            this.colGravable_15.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Gravable_15", "{0:#,###,##0.00}")});
            this.colGravable_15.Visible = true;
            this.colGravable_15.VisibleIndex = 4;
            this.colGravable_15.Width = 97;
            // 
            // colISV15
            // 
            this.colISV15.Caption = "Isv. 15%";
            this.colISV15.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colISV15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colISV15.FieldName = "ISV15";
            this.colISV15.Name = "colISV15";
            this.colISV15.OptionsColumn.ReadOnly = true;
            this.colISV15.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ISV15", "{0:#,###,##0.00}")});
            this.colISV15.Visible = true;
            this.colISV15.VisibleIndex = 5;
            this.colISV15.Width = 93;
            // 
            // colGravable_18
            // 
            this.colGravable_18.Caption = "Grav. 18%";
            this.colGravable_18.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colGravable_18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGravable_18.FieldName = "Gravable_18";
            this.colGravable_18.Name = "colGravable_18";
            this.colGravable_18.OptionsColumn.ReadOnly = true;
            this.colGravable_18.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Gravable_18", "{0:#,###,##0.00}")});
            this.colGravable_18.Visible = true;
            this.colGravable_18.VisibleIndex = 6;
            this.colGravable_18.Width = 94;
            // 
            // colISV18
            // 
            this.colISV18.Caption = "Isv. 18%";
            this.colISV18.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colISV18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colISV18.FieldName = "ISV18";
            this.colISV18.Name = "colISV18";
            this.colISV18.OptionsColumn.ReadOnly = true;
            this.colISV18.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ISV18", "{0:#,###,##0.00}")});
            this.colISV18.Visible = true;
            this.colISV18.VisibleIndex = 7;
            this.colISV18.Width = 104;
            // 
            // colTotal
            // 
            this.colTotal.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.ReadOnly = true;
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:#,###,##0.00}")});
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 8;
            this.colTotal.Width = 106;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dtMes);
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Location = new System.Drawing.Point(12, 49);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(353, 78);
            this.groupControl1.TabIndex = 92;
            this.groupControl1.Text = "Seleccione Mes y Año";
            // 
            // frmReporteVentasXMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 663);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grdRpt);
            this.Controls.Add(this.cmdVerFacturas);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdExcel);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmReporteVentasXMes";
            ((System.ComponentModel.ISupportInitialize)(this.dtMes.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRpt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesBasicosConta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdVerFacturas;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton cmdSalir;
        private DevExpress.XtraEditors.SimpleButton cmdExcel;
        private DevExpress.XtraEditors.DateEdit dtMes;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraGrid.GridControl grdRpt;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsReportesBasicosConta dsReportesBasicosConta1;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colDesde;
        private DevExpress.XtraGrid.Columns.GridColumn colHasta;
        private DevExpress.XtraGrid.Columns.GridColumn colExentas;
        private DevExpress.XtraGrid.Columns.GridColumn colGravable_15;
        private DevExpress.XtraGrid.Columns.GridColumn colISV15;
        private DevExpress.XtraGrid.Columns.GridColumn colGravable_18;
        private DevExpress.XtraGrid.Columns.GridColumn colISV18;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}