namespace JAGUAR_APP.TransaccionesPT
{
    partial class frmReportePT_By_panadero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportePT_By_panadero));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmdRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.cmdExportToExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dsPT1 = new JAGUAR_APP.TransaccionesPT.dsPT();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_arrobas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal_bolsas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbolsas_by_arroba = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPT1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(9, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(413, 34);
            this.labelControl1.TabIndex = 92;
            this.labelControl1.Text = "Reporte de productos elaborados por panadero";
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(98, 73);
            this.dtHasta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.Properties.Appearance.Options.UseFont = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtHasta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtHasta.Size = new System.Drawing.Size(128, 26);
            this.dtHasta.TabIndex = 91;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(20, 78);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 17);
            this.labelControl3.TabIndex = 90;
            this.labelControl3.Text = "Fecha Hasta:";
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(98, 43);
            this.dtDesde.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Properties.Appearance.Options.UseFont = true;
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtDesde.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDesde.Size = new System.Drawing.Size(128, 26);
            this.dtDesde.TabIndex = 89;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(16, 48);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(77, 17);
            this.labelControl5.TabIndex = 88;
            this.labelControl5.Text = "Fecha Desde:";
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdRefresh.Appearance.Options.UseFont = true;
            this.cmdRefresh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdRefresh.ImageOptions.SvgImage")));
            this.cmdRefresh.Location = new System.Drawing.Point(231, 64);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(145, 35);
            this.cmdRefresh.TabIndex = 87;
            this.cmdRefresh.Text = "Refresh";
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // cmdExportToExcel
            // 
            this.cmdExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExportToExcel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdExportToExcel.Appearance.Options.UseFont = true;
            this.cmdExportToExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdExportToExcel.ImageOptions.Image = global::JAGUAR_APP.Properties.Resources.excel32px;
            this.cmdExportToExcel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdExportToExcel.Location = new System.Drawing.Point(782, 64);
            this.cmdExportToExcel.Name = "cmdExportToExcel";
            this.cmdExportToExcel.Size = new System.Drawing.Size(144, 35);
            this.cmdExportToExcel.TabIndex = 86;
            this.cmdExportToExcel.Text = "Exportar a Excel";
            this.cmdExportToExcel.Click += new System.EventHandler(this.cmdExportToExcel_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.Appearance.Options.UseTextOptions = true;
            this.btnAtras.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAtras.ImageOptions.SvgImage")));
            this.btnAtras.Location = new System.Drawing.Point(933, 64);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(145, 35);
            this.btnAtras.TabIndex = 85;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "reporte_pt_by_panadero";
            this.gridControl1.DataSource = this.dsPT1;
            this.gridControl1.Location = new System.Drawing.Point(9, 105);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1069, 415);
            this.gridControl1.TabIndex = 84;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre,
            this.colfecha,
            this.colDocNum,
            this.colid_orden,
            this.colcant_arrobas,
            this.coltotal_bolsas,
            this.coldescripcion,
            this.colcode,
            this.colbolsas_by_arroba});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // dsPT1
            // 
            this.dsPT1.DataSetName = "dsPT";
            this.dsPT1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colnombre
            // 
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.ReadOnly = true;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            this.colnombre.Width = 255;
            // 
            // colfecha
            // 
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 1;
            this.colfecha.Width = 76;
            // 
            // colDocNum
            // 
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.OptionsColumn.ReadOnly = true;
            this.colDocNum.Visible = true;
            this.colDocNum.VisibleIndex = 2;
            this.colDocNum.Width = 117;
            // 
            // colid_orden
            // 
            this.colid_orden.FieldName = "id_orden";
            this.colid_orden.Name = "colid_orden";
            this.colid_orden.OptionsColumn.ReadOnly = true;
            // 
            // colcant_arrobas
            // 
            this.colcant_arrobas.DisplayFormat.FormatString = "n2";
            this.colcant_arrobas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcant_arrobas.FieldName = "cant_arrobas";
            this.colcant_arrobas.Name = "colcant_arrobas";
            this.colcant_arrobas.OptionsColumn.ReadOnly = true;
            this.colcant_arrobas.Visible = true;
            this.colcant_arrobas.VisibleIndex = 5;
            this.colcant_arrobas.Width = 81;
            // 
            // coltotal_bolsas
            // 
            this.coltotal_bolsas.DisplayFormat.FormatString = "n0";
            this.coltotal_bolsas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal_bolsas.FieldName = "total_bolsas";
            this.coltotal_bolsas.Name = "coltotal_bolsas";
            this.coltotal_bolsas.OptionsColumn.ReadOnly = true;
            this.coltotal_bolsas.Visible = true;
            this.coltotal_bolsas.VisibleIndex = 6;
            this.coltotal_bolsas.Width = 122;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.ReadOnly = true;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 4;
            this.coldescripcion.Width = 188;
            // 
            // colcode
            // 
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.OptionsColumn.ReadOnly = true;
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 3;
            this.colcode.Width = 63;
            // 
            // colbolsas_by_arroba
            // 
            this.colbolsas_by_arroba.DisplayFormat.FormatString = "n2";
            this.colbolsas_by_arroba.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colbolsas_by_arroba.FieldName = "bolsas_by_arroba";
            this.colbolsas_by_arroba.Name = "colbolsas_by_arroba";
            this.colbolsas_by_arroba.OptionsColumn.ReadOnly = true;
            this.colbolsas_by_arroba.Visible = true;
            this.colbolsas_by_arroba.VisibleIndex = 7;
            this.colbolsas_by_arroba.Width = 142;
            // 
            // frmReportePT_By_panadero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 524);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cmdRefresh);
            this.Controls.Add(this.cmdExportToExcel);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmReportePT_By_panadero";
            this.Text = "Reporte de Producto terminado por panadero";
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPT1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton cmdRefresh;
        private DevExpress.XtraEditors.SimpleButton cmdExportToExcel;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsPT dsPT1;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
        private DevExpress.XtraGrid.Columns.GridColumn colid_orden;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_arrobas;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_bolsas;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private DevExpress.XtraGrid.Columns.GridColumn colbolsas_by_arroba;
    }
}