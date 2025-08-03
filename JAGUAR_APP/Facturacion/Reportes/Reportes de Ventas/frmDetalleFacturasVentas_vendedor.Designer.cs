namespace JAGUAR_PRO.Facturacion.Reportes.Reportes_de_Ventas
{
    partial class frmDetalleFacturasVentas_vendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleFacturasVentas_vendedor));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsReportesDeVenta1 = new JAGUAR_PRO.Facturacion.Reportes.Reportes_de_Ventas.dsReportesDeVenta();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnumero_documento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcliente_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRTN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_documento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_termino_pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltermino_pago_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdVerDetalle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdExportToExcel = new DevExpress.XtraEditors.SimpleButton();
            this.lblVendedor = new DevExpress.XtraEditors.LabelControl();
            this.lblRangoFechas = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesDeVenta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(229, 20);
            this.labelControl1.TabIndex = 116;
            this.labelControl1.Text = "Resumen de ventas por vendedor";
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(823, 40);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(92, 34);
            this.btnAtras.TabIndex = 115;
            this.btnAtras.Text = "Cerrar";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "detalle_facturas";
            this.gridControl1.DataSource = this.dsReportesDeVenta1;
            this.gridControl1.Location = new System.Drawing.Point(3, 80);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdVerDetalle});
            this.gridControl1.Size = new System.Drawing.Size(912, 340);
            this.gridControl1.TabIndex = 114;
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
            this.colnumero_documento,
            this.colcliente_nombre,
            this.colRTN,
            this.colfecha_documento,
            this.colid_estado,
            this.colestado,
            this.colid_termino_pago,
            this.coltermino_pago_name,
            this.colTotal,
            this.colid_factura});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colnumero_documento
            // 
            this.colnumero_documento.FieldName = "numero_documento";
            this.colnumero_documento.Name = "colnumero_documento";
            this.colnumero_documento.OptionsColumn.ReadOnly = true;
            this.colnumero_documento.Visible = true;
            this.colnumero_documento.VisibleIndex = 0;
            this.colnumero_documento.Width = 138;
            // 
            // colcliente_nombre
            // 
            this.colcliente_nombre.FieldName = "cliente_nombre";
            this.colcliente_nombre.Name = "colcliente_nombre";
            this.colcliente_nombre.OptionsColumn.ReadOnly = true;
            this.colcliente_nombre.Visible = true;
            this.colcliente_nombre.VisibleIndex = 1;
            this.colcliente_nombre.Width = 199;
            // 
            // colRTN
            // 
            this.colRTN.FieldName = "RTN";
            this.colRTN.Name = "colRTN";
            this.colRTN.OptionsColumn.ReadOnly = true;
            this.colRTN.Visible = true;
            this.colRTN.VisibleIndex = 2;
            this.colRTN.Width = 78;
            // 
            // colfecha_documento
            // 
            this.colfecha_documento.FieldName = "fecha_documento";
            this.colfecha_documento.Name = "colfecha_documento";
            this.colfecha_documento.OptionsColumn.ReadOnly = true;
            this.colfecha_documento.Visible = true;
            this.colfecha_documento.VisibleIndex = 3;
            this.colfecha_documento.Width = 76;
            // 
            // colid_estado
            // 
            this.colid_estado.FieldName = "id_estado";
            this.colid_estado.Name = "colid_estado";
            this.colid_estado.OptionsColumn.ReadOnly = true;
            // 
            // colestado
            // 
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.ReadOnly = true;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 4;
            this.colestado.Width = 77;
            // 
            // colid_termino_pago
            // 
            this.colid_termino_pago.FieldName = "id_termino_pago";
            this.colid_termino_pago.Name = "colid_termino_pago";
            this.colid_termino_pago.OptionsColumn.ReadOnly = true;
            // 
            // coltermino_pago_name
            // 
            this.coltermino_pago_name.FieldName = "termino_pago_name";
            this.coltermino_pago_name.Name = "coltermino_pago_name";
            this.coltermino_pago_name.OptionsColumn.ReadOnly = true;
            this.coltermino_pago_name.Visible = true;
            this.coltermino_pago_name.VisibleIndex = 5;
            this.coltermino_pago_name.Width = 150;
            // 
            // colTotal
            // 
            this.colTotal.DisplayFormat.FormatString = "n2";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.ReadOnly = true;
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "SUM={0:n2}")});
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 6;
            this.colTotal.Width = 167;
            // 
            // colid_factura
            // 
            this.colid_factura.FieldName = "id_factura";
            this.colid_factura.Name = "colid_factura";
            this.colid_factura.OptionsColumn.ReadOnly = true;
            // 
            // cmdVerDetalle
            // 
            this.cmdVerDetalle.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdVerDetalle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdVerDetalle.Name = "cmdVerDetalle";
            this.cmdVerDetalle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // cmdExportToExcel
            // 
            this.cmdExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExportToExcel.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportToExcel.Appearance.Options.UseFont = true;
            this.cmdExportToExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdExportToExcel.ImageOptions.Image = global::JAGUAR_PRO.Properties.Resources.Excel_2_icon32px1;
            this.cmdExportToExcel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdExportToExcel.Location = new System.Drawing.Point(725, 40);
            this.cmdExportToExcel.Name = "cmdExportToExcel";
            this.cmdExportToExcel.Size = new System.Drawing.Size(92, 34);
            this.cmdExportToExcel.TabIndex = 117;
            this.cmdExportToExcel.Text = "Exportar";
            this.cmdExportToExcel.Click += new System.EventHandler(this.cmdExportToExcel_Click);
            // 
            // lblVendedor
            // 
            this.lblVendedor.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Appearance.Options.UseFont = true;
            this.lblVendedor.Location = new System.Drawing.Point(3, 43);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(86, 15);
            this.lblVendedor.TabIndex = 118;
            this.lblVendedor.Text = "Vendedor Datos";
            // 
            // lblRangoFechas
            // 
            this.lblRangoFechas.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRangoFechas.Appearance.Options.UseFont = true;
            this.lblRangoFechas.Location = new System.Drawing.Point(3, 62);
            this.lblRangoFechas.Name = "lblRangoFechas";
            this.lblRangoFechas.Size = new System.Drawing.Size(89, 15);
            this.lblRangoFechas.TabIndex = 119;
            this.lblRangoFechas.Text = "Rango de Fechas";
            // 
            // frmDetalleFacturasVentas_vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 423);
            this.Controls.Add(this.lblRangoFechas);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.cmdExportToExcel);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmDetalleFacturasVentas_vendedor";
            this.Text = "Detalle de Facturas por Vendedor";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesDeVenta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdVerDetalle;
        private dsReportesDeVenta dsReportesDeVenta1;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_documento;
        private DevExpress.XtraGrid.Columns.GridColumn colcliente_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colRTN;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_documento;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colid_termino_pago;
        private DevExpress.XtraGrid.Columns.GridColumn coltermino_pago_name;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colid_factura;
        private DevExpress.XtraEditors.SimpleButton cmdExportToExcel;
        private DevExpress.XtraEditors.LabelControl lblVendedor;
        private DevExpress.XtraEditors.LabelControl lblRangoFechas;
    }
}