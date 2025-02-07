namespace JAGUAR_PRO.TransaccionesMP
{
    partial class frmReporteDeCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteDeCompras));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsReportesMP_Transact1 = new JAGUAR_PRO.TransaccionesMP.dsReportesMP_Transact();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_detalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProveedoNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_usuario_recibido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_recibio_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_registro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentregado_por_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentregado_por_identidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentregado_por_hora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentregado_por_telefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_usuario_revisado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_revisado_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_revisado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_cai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_unidad_medida_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidad_medida_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_entrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_unidad_medida_entrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidad_medida_entrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal_linea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcosto_unitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbodega_descrip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_material_empaque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdExportToExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmdRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesMP_Transact1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.gridControl1.DataMember = "reporte_compras";
            this.gridControl1.DataSource = this.dsReportesMP_Transact1;
            this.gridControl1.Location = new System.Drawing.Point(2, 101);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1069, 415);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsReportesMP_Transact1
            // 
            this.dsReportesMP_Transact1.DataSetName = "dsReportesMP_Transact";
            this.dsReportesMP_Transact1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_detalle,
            this.colid_proveedor,
            this.colProveedoNombre,
            this.colid_usuario_recibido,
            this.colusuario_recibio_name,
            this.colcai,
            this.colfactura,
            this.colfecha_factura,
            this.colfecha_registro,
            this.colentregado_por_nombre,
            this.colentregado_por_identidad,
            this.colentregado_por_hora,
            this.colentregado_por_telefono,
            this.colid_usuario_revisado,
            this.colusuario_revisado_name,
            this.colhora_revisado,
            this.colobservaciones,
            this.colDocNum,
            this.colid_cai,
            this.colcantidad_factura,
            this.colid_unidad_medida_factura,
            this.colunidad_medida_factura,
            this.coldescripcion,
            this.colcantidad_entrada,
            this.colid_unidad_medida_entrada,
            this.colunidad_medida_entrada,
            this.coltotal_linea,
            this.colid_materia_prima,
            this.collote_mp,
            this.colcosto_unitario,
            this.colid_bodega,
            this.colbodega_descrip,
            this.colid_material_empaque,
            this.colItemName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_detalle
            // 
            this.colid_detalle.FieldName = "id_detalle";
            this.colid_detalle.Name = "colid_detalle";
            // 
            // colid_proveedor
            // 
            this.colid_proveedor.FieldName = "id_proveedor";
            this.colid_proveedor.Name = "colid_proveedor";
            // 
            // colProveedoNombre
            // 
            this.colProveedoNombre.FieldName = "ProveedoNombre";
            this.colProveedoNombre.Name = "colProveedoNombre";
            this.colProveedoNombre.Visible = true;
            this.colProveedoNombre.VisibleIndex = 0;
            // 
            // colid_usuario_recibido
            // 
            this.colid_usuario_recibido.FieldName = "id_usuario_recibido";
            this.colid_usuario_recibido.Name = "colid_usuario_recibido";
            // 
            // colusuario_recibio_name
            // 
            this.colusuario_recibio_name.FieldName = "usuario_recibio_name";
            this.colusuario_recibio_name.Name = "colusuario_recibio_name";
            // 
            // colcai
            // 
            this.colcai.FieldName = "cai";
            this.colcai.Name = "colcai";
            this.colcai.Visible = true;
            this.colcai.VisibleIndex = 1;
            // 
            // colfactura
            // 
            this.colfactura.FieldName = "factura";
            this.colfactura.Name = "colfactura";
            this.colfactura.Visible = true;
            this.colfactura.VisibleIndex = 2;
            // 
            // colfecha_factura
            // 
            this.colfecha_factura.FieldName = "fecha_factura";
            this.colfecha_factura.Name = "colfecha_factura";
            this.colfecha_factura.Visible = true;
            this.colfecha_factura.VisibleIndex = 3;
            // 
            // colfecha_registro
            // 
            this.colfecha_registro.FieldName = "fecha_registro";
            this.colfecha_registro.Name = "colfecha_registro";
            this.colfecha_registro.Visible = true;
            this.colfecha_registro.VisibleIndex = 4;
            // 
            // colentregado_por_nombre
            // 
            this.colentregado_por_nombre.FieldName = "entregado_por_nombre";
            this.colentregado_por_nombre.Name = "colentregado_por_nombre";
            // 
            // colentregado_por_identidad
            // 
            this.colentregado_por_identidad.FieldName = "entregado_por_identidad";
            this.colentregado_por_identidad.Name = "colentregado_por_identidad";
            // 
            // colentregado_por_hora
            // 
            this.colentregado_por_hora.FieldName = "entregado_por_hora";
            this.colentregado_por_hora.Name = "colentregado_por_hora";
            // 
            // colentregado_por_telefono
            // 
            this.colentregado_por_telefono.FieldName = "entregado_por_telefono";
            this.colentregado_por_telefono.Name = "colentregado_por_telefono";
            // 
            // colid_usuario_revisado
            // 
            this.colid_usuario_revisado.FieldName = "id_usuario_revisado";
            this.colid_usuario_revisado.Name = "colid_usuario_revisado";
            // 
            // colusuario_revisado_name
            // 
            this.colusuario_revisado_name.FieldName = "usuario_revisado_name";
            this.colusuario_revisado_name.Name = "colusuario_revisado_name";
            // 
            // colhora_revisado
            // 
            this.colhora_revisado.FieldName = "hora_revisado";
            this.colhora_revisado.Name = "colhora_revisado";
            // 
            // colobservaciones
            // 
            this.colobservaciones.FieldName = "observaciones";
            this.colobservaciones.Name = "colobservaciones";
            // 
            // colDocNum
            // 
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.Visible = true;
            this.colDocNum.VisibleIndex = 5;
            // 
            // colid_cai
            // 
            this.colid_cai.FieldName = "id_cai";
            this.colid_cai.Name = "colid_cai";
            // 
            // colcantidad_factura
            // 
            this.colcantidad_factura.FieldName = "cantidad_factura";
            this.colcantidad_factura.Name = "colcantidad_factura";
            this.colcantidad_factura.Visible = true;
            this.colcantidad_factura.VisibleIndex = 6;
            // 
            // colid_unidad_medida_factura
            // 
            this.colid_unidad_medida_factura.FieldName = "id_unidad_medida_factura";
            this.colid_unidad_medida_factura.Name = "colid_unidad_medida_factura";
            // 
            // colunidad_medida_factura
            // 
            this.colunidad_medida_factura.FieldName = "unidad_medida_factura";
            this.colunidad_medida_factura.Name = "colunidad_medida_factura";
            this.colunidad_medida_factura.Visible = true;
            this.colunidad_medida_factura.VisibleIndex = 10;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 8;
            // 
            // colcantidad_entrada
            // 
            this.colcantidad_entrada.FieldName = "cantidad_entrada";
            this.colcantidad_entrada.Name = "colcantidad_entrada";
            this.colcantidad_entrada.Visible = true;
            this.colcantidad_entrada.VisibleIndex = 7;
            // 
            // colid_unidad_medida_entrada
            // 
            this.colid_unidad_medida_entrada.FieldName = "id_unidad_medida_entrada";
            this.colid_unidad_medida_entrada.Name = "colid_unidad_medida_entrada";
            // 
            // colunidad_medida_entrada
            // 
            this.colunidad_medida_entrada.FieldName = "unidad_medida_entrada";
            this.colunidad_medida_entrada.Name = "colunidad_medida_entrada";
            this.colunidad_medida_entrada.Visible = true;
            this.colunidad_medida_entrada.VisibleIndex = 11;
            // 
            // coltotal_linea
            // 
            this.coltotal_linea.FieldName = "total_linea";
            this.coltotal_linea.Name = "coltotal_linea";
            this.coltotal_linea.Visible = true;
            this.coltotal_linea.VisibleIndex = 12;
            // 
            // colid_materia_prima
            // 
            this.colid_materia_prima.FieldName = "id_materia_prima";
            this.colid_materia_prima.Name = "colid_materia_prima";
            // 
            // collote_mp
            // 
            this.collote_mp.FieldName = "lote_mp";
            this.collote_mp.Name = "collote_mp";
            // 
            // colcosto_unitario
            // 
            this.colcosto_unitario.FieldName = "costo_unitario";
            this.colcosto_unitario.Name = "colcosto_unitario";
            this.colcosto_unitario.Visible = true;
            this.colcosto_unitario.VisibleIndex = 13;
            // 
            // colid_bodega
            // 
            this.colid_bodega.FieldName = "id_bodega";
            this.colid_bodega.Name = "colid_bodega";
            // 
            // colbodega_descrip
            // 
            this.colbodega_descrip.FieldName = "bodega_descrip";
            this.colbodega_descrip.Name = "colbodega_descrip";
            // 
            // colid_material_empaque
            // 
            this.colid_material_empaque.FieldName = "id_material_empaque";
            this.colid_material_empaque.Name = "colid_material_empaque";
            // 
            // colItemName
            // 
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 9;
            // 
            // cmdExportToExcel
            // 
            this.cmdExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExportToExcel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdExportToExcel.Appearance.Options.UseFont = true;
            this.cmdExportToExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdExportToExcel.ImageOptions.Image = global::JAGUAR_PRO.Properties.Resources.excel32px;
            this.cmdExportToExcel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdExportToExcel.Location = new System.Drawing.Point(775, 60);
            this.cmdExportToExcel.Name = "cmdExportToExcel";
            this.cmdExportToExcel.Size = new System.Drawing.Size(144, 35);
            this.cmdExportToExcel.TabIndex = 73;
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
            this.btnAtras.Location = new System.Drawing.Point(926, 60);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(145, 35);
            this.btnAtras.TabIndex = 72;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(91, 69);
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
            this.dtHasta.TabIndex = 82;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 74);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 17);
            this.labelControl3.TabIndex = 81;
            this.labelControl3.Text = "Fecha Hasta:";
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(91, 39);
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
            this.dtDesde.TabIndex = 80;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(9, 44);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(77, 17);
            this.labelControl5.TabIndex = 79;
            this.labelControl5.Text = "Fecha Desde:";
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdRefresh.Appearance.Options.UseFont = true;
            this.cmdRefresh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdRefresh.ImageOptions.SvgImage")));
            this.cmdRefresh.Location = new System.Drawing.Point(224, 60);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(145, 35);
            this.cmdRefresh.TabIndex = 78;
            this.cmdRefresh.Text = "Refresh";
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(2, -1);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(217, 34);
            this.labelControl1.TabIndex = 83;
            this.labelControl1.Text = "Reporte general de compras";
            // 
            // frmReporteDeCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 517);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cmdRefresh);
            this.Controls.Add(this.cmdExportToExcel);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmReporteDeCompras";
            this.Text = "Reporte de compras";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesMP_Transact1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton cmdExportToExcel;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton cmdRefresh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dsReportesMP_Transact dsReportesMP_Transact1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_detalle;
        private DevExpress.XtraGrid.Columns.GridColumn colid_proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colProveedoNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colid_usuario_recibido;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_recibio_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcai;
        private DevExpress.XtraGrid.Columns.GridColumn colfactura;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_registro;
        private DevExpress.XtraGrid.Columns.GridColumn colentregado_por_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colentregado_por_identidad;
        private DevExpress.XtraGrid.Columns.GridColumn colentregado_por_hora;
        private DevExpress.XtraGrid.Columns.GridColumn colentregado_por_telefono;
        private DevExpress.XtraGrid.Columns.GridColumn colid_usuario_revisado;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_revisado_name;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_revisado;
        private DevExpress.XtraGrid.Columns.GridColumn colobservaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cai;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colid_unidad_medida_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colunidad_medida_factura;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_entrada;
        private DevExpress.XtraGrid.Columns.GridColumn colid_unidad_medida_entrada;
        private DevExpress.XtraGrid.Columns.GridColumn colunidad_medida_entrada;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_linea;
        private DevExpress.XtraGrid.Columns.GridColumn colid_materia_prima;
        private DevExpress.XtraGrid.Columns.GridColumn collote_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colcosto_unitario;
        private DevExpress.XtraGrid.Columns.GridColumn colid_bodega;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega_descrip;
        private DevExpress.XtraGrid.Columns.GridColumn colid_material_empaque;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
    }
}