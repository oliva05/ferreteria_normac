namespace JAGUAR_PRO.Despachos.Pedidos
{
    partial class frmElejirAlmacenPedidoOutStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmElejirAlmacenPedidoOutStok));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsPrefacturas1 = new JAGUAR_PRO.Despachos.Pedidos.dsPrefacturas();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbodega_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_seleccionada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colwhs_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomprometido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldisponible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dsPedidosClientesV1 = new JAGUAR_PRO.Despachos.Pedidos.dsPedidosClientesV();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblProductoName = new DevExpress.XtraEditors.LabelControl();
            this.lblCantidadReq = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblMarca = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrefacturas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidosClientesV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "stock_por_almacen";
            this.gridControl1.DataSource = this.dsPrefacturas1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(672, 217);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsPrefacturas1
            // 
            this.dsPrefacturas1.DataSetName = "dsPrefacturas";
            this.dsPrefacturas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_bodega,
            this.colbodega_name,
            this.colcantidad,
            this.colcantidad_seleccionada,
            this.colwhs_code,
            this.colcomprometido,
            this.colmarca,
            this.coldisponible});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.ShownEditor += new System.EventHandler(this.gridView1_ShownEditor);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colid_bodega
            // 
            this.colid_bodega.FieldName = "id_bodega";
            this.colid_bodega.Name = "colid_bodega";
            // 
            // colbodega_name
            // 
            this.colbodega_name.FieldName = "bodega_name";
            this.colbodega_name.Name = "colbodega_name";
            this.colbodega_name.OptionsColumn.ReadOnly = true;
            this.colbodega_name.Visible = true;
            this.colbodega_name.VisibleIndex = 1;
            this.colbodega_name.Width = 164;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad Inventario";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.ReadOnly = true;
            this.colcantidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", "SUM={0:0.##}")});
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 2;
            this.colcantidad.Width = 113;
            // 
            // colcantidad_seleccionada
            // 
            this.colcantidad_seleccionada.FieldName = "cantidad_seleccionada";
            this.colcantidad_seleccionada.Name = "colcantidad_seleccionada";
            this.colcantidad_seleccionada.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad_seleccionada", "SUM={0:0.##}")});
            this.colcantidad_seleccionada.Visible = true;
            this.colcantidad_seleccionada.VisibleIndex = 5;
            this.colcantidad_seleccionada.Width = 127;
            // 
            // colwhs_code
            // 
            this.colwhs_code.FieldName = "whs_code";
            this.colwhs_code.Name = "colwhs_code";
            this.colwhs_code.OptionsColumn.ReadOnly = true;
            this.colwhs_code.Visible = true;
            this.colwhs_code.VisibleIndex = 0;
            this.colwhs_code.Width = 48;
            // 
            // colcomprometido
            // 
            this.colcomprometido.DisplayFormat.FormatString = "n2";
            this.colcomprometido.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcomprometido.FieldName = "comprometido";
            this.colcomprometido.Name = "colcomprometido";
            this.colcomprometido.OptionsColumn.ReadOnly = true;
            this.colcomprometido.Visible = true;
            this.colcomprometido.VisibleIndex = 3;
            this.colcomprometido.Width = 87;
            // 
            // colmarca
            // 
            this.colmarca.FieldName = "marca";
            this.colmarca.Name = "colmarca";
            this.colmarca.OptionsColumn.ReadOnly = true;
            this.colmarca.Width = 108;
            // 
            // coldisponible
            // 
            this.coldisponible.FieldName = "disponible";
            this.coldisponible.Name = "coldisponible";
            this.coldisponible.OptionsColumn.ReadOnly = true;
            this.coldisponible.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "disponible", "SUM={0:###,##0.00}")});
            this.coldisponible.Visible = true;
            this.coldisponible.VisibleIndex = 4;
            // 
            // dsPedidosClientesV1
            // 
            this.dsPedidosClientesV1.DataSetName = "dsPedidosClientesV";
            this.dsPedidosClientesV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 15);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Producto: ";
            // 
            // lblProductoName
            // 
            this.lblProductoName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoName.Appearance.Options.UseFont = true;
            this.lblProductoName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblProductoName.Location = new System.Drawing.Point(106, 12);
            this.lblProductoName.Name = "lblProductoName";
            this.lblProductoName.Size = new System.Drawing.Size(465, 15);
            this.lblProductoName.TabIndex = 2;
            this.lblProductoName.Text = "Producto: ";
            // 
            // lblCantidadReq
            // 
            this.lblCantidadReq.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadReq.Appearance.Options.UseFont = true;
            this.lblCantidadReq.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCantidadReq.Location = new System.Drawing.Point(106, 49);
            this.lblCantidadReq.Name = "lblCantidadReq";
            this.lblCantidadReq.Size = new System.Drawing.Size(465, 15);
            this.lblCantidadReq.TabIndex = 4;
            this.lblCantidadReq.Text = "Producto: ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 49);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(88, 15);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Cant. Requerido:";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmdGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdGuardar.ImageOptions.SvgImage")));
            this.cmdGuardar.Location = new System.Drawing.Point(230, 322);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(108, 41);
            this.cmdGuardar.TabIndex = 50;
            this.cmdGuardar.Text = "Aplicar";
            this.cmdGuardar.ToolTipTitle = "Guardar Entrada de Factura";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(344, 322);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(108, 41);
            this.simpleButton1.TabIndex = 51;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.ToolTipTitle = "Guardar Entrada de Factura";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Appearance.Options.UseFont = true;
            this.lblMarca.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblMarca.Location = new System.Drawing.Point(106, 30);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(465, 15);
            this.lblMarca.TabIndex = 53;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 30);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 15);
            this.labelControl3.TabIndex = 52;
            this.labelControl3.Text = "Marca:";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(1, 70);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(674, 246);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(672, 217);
            this.xtraTabPage1.Text = "Inventario";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(672, 217);
            this.xtraTabPage2.Text = "Ver Negativos y Ceros";
            // 
            // gridControl2
            // 
            this.gridControl2.DataMember = "stock_por_almacenNegativos";
            this.gridControl2.DataSource = this.dsPrefacturas1;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(672, 217);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "id_bodega";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "bodega_name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 164;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cantidad Inventario";
            this.gridColumn3.FieldName = "cantidad";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", "SUM={0:0.##}")});
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 113;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "cantidad_seleccionada";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad_seleccionada", "SUM={0:0.##}")});
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 127;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "whs_code";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 48;
            // 
            // gridColumn6
            // 
            this.gridColumn6.DisplayFormat.FormatString = "n2";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "comprometido";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 87;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "marca";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Width = 108;
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "disponible";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "disponible", "SUM={0:###,##0.00}")});
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            // 
            // frmElejirAlmacenPedidoOutStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 364);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.lblCantidadReq);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lblProductoName);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmElejirAlmacenPedidoOutStok";
            this.Text = "Seleccion de Stock por Almacen";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrefacturas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidosClientesV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblProductoName;
        private DevExpress.XtraEditors.LabelControl lblCantidadReq;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private dsPedidosClientesV dsPedidosClientesV1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_bodega;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_seleccionada;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private dsPrefacturas dsPrefacturas1;
        private DevExpress.XtraGrid.Columns.GridColumn colwhs_code;
        private DevExpress.XtraGrid.Columns.GridColumn colcomprometido;
        private DevExpress.XtraGrid.Columns.GridColumn colmarca;
        private DevExpress.XtraEditors.LabelControl lblMarca;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn coldisponible;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}