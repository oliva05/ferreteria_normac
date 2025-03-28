namespace JAGUAR_PRO.Despachos.Pedidos
{
    partial class frmElejirAlmacenPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmElejirAlmacenPedido));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsPedidosClientesV1 = new JAGUAR_PRO.Despachos.Pedidos.dsPedidosClientesV();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbodega_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_seleccionada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblProductoName = new DevExpress.XtraEditors.LabelControl();
            this.lblCantidadReq = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dsPrefacturas1 = new JAGUAR_PRO.Despachos.Pedidos.dsPrefacturas();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidosClientesV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrefacturas1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "stock_por_almacen";
            this.gridControl1.DataSource = this.dsPrefacturas1;
            this.gridControl1.Location = new System.Drawing.Point(1, 54);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(620, 226);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsPedidosClientesV1
            // 
            this.dsPedidosClientesV1.DataSetName = "dsPedidosClientesV";
            this.dsPedidosClientesV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_bodega,
            this.colbodega_name,
            this.colcantidad,
            this.colcantidad_seleccionada});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
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
            this.colbodega_name.VisibleIndex = 0;
            // 
            // colcantidad
            // 
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.ReadOnly = true;
            this.colcantidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", "SUM={0:0.##}")});
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 1;
            // 
            // colcantidad_seleccionada
            // 
            this.colcantidad_seleccionada.FieldName = "cantidad_seleccionada";
            this.colcantidad_seleccionada.Name = "colcantidad_seleccionada";
            this.colcantidad_seleccionada.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad_seleccionada", "SUM={0:0.##}")});
            this.colcantidad_seleccionada.Visible = true;
            this.colcantidad_seleccionada.VisibleIndex = 2;
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
            this.lblCantidadReq.Location = new System.Drawing.Point(106, 33);
            this.lblCantidadReq.Name = "lblCantidadReq";
            this.lblCantidadReq.Size = new System.Drawing.Size(465, 15);
            this.lblCantidadReq.TabIndex = 4;
            this.lblCantidadReq.Text = "Producto: ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 33);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(88, 15);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Cant. Requerido:";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmdGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdGuardar.ImageOptions.SvgImage")));
            this.cmdGuardar.Location = new System.Drawing.Point(181, 289);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(108, 41);
            this.cmdGuardar.TabIndex = 50;
            this.cmdGuardar.Text = "Aplicar";
            this.cmdGuardar.ToolTipTitle = "Guardar Entrada de Factura";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(295, 289);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(108, 41);
            this.simpleButton1.TabIndex = 51;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.ToolTipTitle = "Guardar Entrada de Factura";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dsPrefacturas1
            // 
            this.dsPrefacturas1.DataSetName = "dsPrefacturas";
            this.dsPrefacturas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmElejirAlmacenPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 338);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.lblCantidadReq);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lblProductoName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmElejirAlmacenPedido";
            this.Text = "Seleccion de Stock por Almacen";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidosClientesV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrefacturas1)).EndInit();
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
    }
}