namespace JAGUAR_PRO.LogisticaJaguar
{
    partial class frmAddRecepcionCompraVentaUnica
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsProductoTerminado1 = new JAGUAR_PRO.Mantenimientos.ProductoTerminado.dsProductoTerminado();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmargen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio_venta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorrelativo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnSelecItemCode = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoPT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtItemName = new DevExpress.XtraEditors.TextEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.spinUd = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnAddLote = new DevExpress.XtraEditors.SimpleButton();
            this.txtPrecioVenta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtMargGanancia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCosto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnFinalizar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductoTerminado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoPT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinUd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMargGanancia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "pt_venta_unica";
            this.gridControl1.DataSource = this.dsProductoTerminado1;
            this.gridControl1.Location = new System.Drawing.Point(2, 134);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposDelete});
            this.gridControl1.Size = new System.Drawing.Size(951, 430);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsProductoTerminado1
            // 
            this.dsProductoTerminado1.DataSetName = "dsProductoTerminado";
            this.dsProductoTerminado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion,
            this.colitemcode,
            this.colcosto,
            this.colmargen,
            this.colprecio_venta,
            this.colbarcode,
            this.colcorrelativo,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Detalle de Productos";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripcion de Venta";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            this.coldescripcion.Width = 158;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "ItemCode";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.ReadOnly = true;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 1;
            this.colitemcode.Width = 64;
            // 
            // colcosto
            // 
            this.colcosto.Caption = "Costo";
            this.colcosto.DisplayFormat.FormatString = "{0:#,###,##0.00} Lps";
            this.colcosto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcosto.FieldName = "costo";
            this.colcosto.Name = "colcosto";
            this.colcosto.OptionsColumn.ReadOnly = true;
            this.colcosto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "costo", "{0:#,###,##0.00} Lps")});
            this.colcosto.Visible = true;
            this.colcosto.VisibleIndex = 2;
            // 
            // colmargen
            // 
            this.colmargen.Caption = "Margen Ganancia";
            this.colmargen.DisplayFormat.FormatString = "{0:#,###,##0.00} %";
            this.colmargen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmargen.FieldName = "margen";
            this.colmargen.Name = "colmargen";
            this.colmargen.OptionsColumn.ReadOnly = true;
            this.colmargen.Visible = true;
            this.colmargen.VisibleIndex = 3;
            // 
            // colprecio_venta
            // 
            this.colprecio_venta.Caption = "Precio Venta";
            this.colprecio_venta.DisplayFormat.FormatString = "{0:#,###,##0.00} Lps";
            this.colprecio_venta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colprecio_venta.FieldName = "precio_venta";
            this.colprecio_venta.Name = "colprecio_venta";
            this.colprecio_venta.OptionsColumn.ReadOnly = true;
            this.colprecio_venta.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "precio_venta", "{0:#,###,##0.00} Lps")});
            this.colprecio_venta.Visible = true;
            this.colprecio_venta.VisibleIndex = 4;
            // 
            // colbarcode
            // 
            this.colbarcode.Caption = "Codigo Barra";
            this.colbarcode.FieldName = "barcode";
            this.colbarcode.Name = "colbarcode";
            this.colbarcode.OptionsColumn.ReadOnly = true;
            this.colbarcode.Visible = true;
            this.colbarcode.VisibleIndex = 5;
            // 
            // colcorrelativo
            // 
            this.colcorrelativo.FieldName = "correlativo";
            this.colcorrelativo.Name = "colcorrelativo";
            this.colcorrelativo.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Eliminar";
            this.gridColumn1.ColumnEdit = this.reposDelete;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 146;
            // 
            // reposDelete
            // 
            this.reposDelete.AutoHeight = false;
            editorButtonImageOptions1.Image = global::JAGUAR_PRO.Properties.Resources.po_delete_24;
            this.reposDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposDelete.Name = "reposDelete";
            this.reposDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposDelete_ButtonClick);
            // 
            // btnSelecItemCode
            // 
            this.btnSelecItemCode.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSelecItemCode.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecItemCode.Appearance.Options.UseBackColor = true;
            this.btnSelecItemCode.Appearance.Options.UseFont = true;
            this.btnSelecItemCode.ImageOptions.Image = global::JAGUAR_PRO.Properties.Resources.lookup_reference_16x16;
            this.btnSelecItemCode.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSelecItemCode.Location = new System.Drawing.Point(226, 54);
            this.btnSelecItemCode.Name = "btnSelecItemCode";
            this.btnSelecItemCode.Size = new System.Drawing.Size(117, 34);
            this.btnSelecItemCode.TabIndex = 10;
            this.btnSelecItemCode.Text = "Buscar Codigo";
            this.btnSelecItemCode.Click += new System.EventHandler(this.btnSelecItemCode_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(10, 46);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(86, 15);
            this.labelControl3.TabIndex = 73;
            this.labelControl3.Text = "Cod. PT_________";
            // 
            // txtCodigoPT
            // 
            this.txtCodigoPT.EditValue = "";
            this.txtCodigoPT.Enabled = false;
            this.txtCodigoPT.Location = new System.Drawing.Point(85, 43);
            this.txtCodigoPT.Name = "txtCodigoPT";
            this.txtCodigoPT.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPT.Properties.Appearance.Options.UseFont = true;
            this.txtCodigoPT.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoPT.Size = new System.Drawing.Size(125, 22);
            this.txtCodigoPT.TabIndex = 72;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 84);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 15);
            this.labelControl1.TabIndex = 74;
            this.labelControl1.Text = "Descripcion____";
            // 
            // txtItemName
            // 
            this.txtItemName.EditValue = "";
            this.txtItemName.Enabled = false;
            this.txtItemName.Location = new System.Drawing.Point(84, 81);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Properties.Appearance.Options.UseFont = true;
            this.txtItemName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItemName.Size = new System.Drawing.Size(125, 22);
            this.txtItemName.TabIndex = 75;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.EditValue = "";
            this.txtDescripcion.Location = new System.Drawing.Point(111, 32);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Size = new System.Drawing.Size(152, 22);
            this.txtDescripcion.TabIndex = 11;
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(35, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 15);
            this.labelControl2.TabIndex = 77;
            this.labelControl2.Text = "Descripcion_____";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSelecItemCode);
            this.groupControl1.Controls.Add(this.txtCodigoPT);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtItemName);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(2, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(348, 130);
            this.groupControl1.TabIndex = 78;
            this.groupControl1.Text = "Seleccion de Codigo PT";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.spinUd);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.btnAddLote);
            this.groupControl2.Controls.Add(this.txtPrecioVenta);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.txtMargGanancia);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.txtCosto);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.txtDescripcion);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Location = new System.Drawing.Point(351, 1);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(600, 130);
            this.groupControl2.TabIndex = 79;
            this.groupControl2.Text = "Detalle de Producto";
            // 
            // spinUd
            // 
            this.spinUd.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinUd.Location = new System.Drawing.Point(368, 34);
            this.spinUd.Name = "spinUd";
            this.spinUd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinUd.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinUd.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinUd.Size = new System.Drawing.Size(107, 20);
            this.spinUd.TabIndex = 14;
            this.spinUd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spinUd_KeyDown);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(268, 33);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(128, 15);
            this.labelControl7.TabIndex = 97;
            this.labelControl7.Text = "Cantidad________________";
            // 
            // btnAddLote
            // 
            this.btnAddLote.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddLote.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLote.Appearance.Options.UseBackColor = true;
            this.btnAddLote.Appearance.Options.UseFont = true;
            this.btnAddLote.ImageOptions.Image = global::JAGUAR_PRO.Properties.Resources.addnewdatasource_16x16;
            this.btnAddLote.Location = new System.Drawing.Point(490, 37);
            this.btnAddLote.Name = "btnAddLote";
            this.btnAddLote.Size = new System.Drawing.Size(91, 34);
            this.btnAddLote.TabIndex = 15;
            this.btnAddLote.Text = "Agregar";
            this.btnAddLote.Click += new System.EventHandler(this.btnAddLote_Click);
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.EditValue = "0.00";
            this.txtPrecioVenta.Location = new System.Drawing.Point(368, 60);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Properties.Appearance.Options.UseFont = true;
            this.txtPrecioVenta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecioVenta.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPrecioVenta.Properties.MaskSettings.Set("mask", "n");
            this.txtPrecioVenta.Properties.MaxLength = 100;
            this.txtPrecioVenta.Properties.NullText = "0";
            this.txtPrecioVenta.Size = new System.Drawing.Size(107, 22);
            this.txtPrecioVenta.TabIndex = 82;
            this.txtPrecioVenta.EditValueChanged += new System.EventHandler(this.txtPrecioVenta_EditValueChanged);
            this.txtPrecioVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecioVenta_KeyDown);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(268, 64);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(101, 15);
            this.labelControl6.TabIndex = 83;
            this.labelControl6.Text = "Precio Venta_______";
            // 
            // txtMargGanancia
            // 
            this.txtMargGanancia.EditValue = "0.00";
            this.txtMargGanancia.Location = new System.Drawing.Point(135, 90);
            this.txtMargGanancia.Name = "txtMargGanancia";
            this.txtMargGanancia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargGanancia.Properties.Appearance.Options.UseFont = true;
            this.txtMargGanancia.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMargGanancia.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtMargGanancia.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtMargGanancia.Properties.MaskSettings.Set("mask", "P");
            this.txtMargGanancia.Properties.MaxLength = 100;
            this.txtMargGanancia.Properties.NullText = "0";
            this.txtMargGanancia.Properties.UseMaskAsDisplayFormat = true;
            this.txtMargGanancia.Size = new System.Drawing.Size(128, 22);
            this.txtMargGanancia.TabIndex = 13;
            this.txtMargGanancia.EditValueChanged += new System.EventHandler(this.txtMargGanancia_EditValueChanged);
            this.txtMargGanancia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMargGanancia_KeyDown);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(35, 94);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(128, 15);
            this.labelControl5.TabIndex = 81;
            this.labelControl5.Text = "Margen Ganancia_______";
            // 
            // txtCosto
            // 
            this.txtCosto.EditValue = "0.00";
            this.txtCosto.Location = new System.Drawing.Point(135, 60);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Properties.Appearance.Options.UseFont = true;
            this.txtCosto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCosto.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCosto.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtCosto.Properties.MaskSettings.Set("mask", "n");
            this.txtCosto.Size = new System.Drawing.Size(128, 22);
            this.txtCosto.TabIndex = 12;
            this.txtCosto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCosto_KeyDown);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(35, 64);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(116, 15);
            this.labelControl4.TabIndex = 79;
            this.labelControl4.Text = "Costo_________________";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFinalizar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Appearance.Options.UseFont = true;
            this.btnFinalizar.ImageOptions.Image = global::JAGUAR_PRO.Properties.Resources.apply_16x16;
            this.btnFinalizar.Location = new System.Drawing.Point(351, 570);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(90, 38);
            this.btnFinalizar.TabIndex = 16;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = global::JAGUAR_PRO.Properties.Resources.cancel_16x16;
            this.btnCancelar.Location = new System.Drawing.Point(486, 570);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 38);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAddRecepcionCompraVentaUnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 620);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmAddRecepcionCompraVentaUnica";
            this.Text = "Recepcion de Productos Usados";
            this.Shown += new System.EventHandler(this.frmAddRecepcionCompraVentaUnica_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductoTerminado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoPT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinUd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMargGanancia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnSelecItemCode;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCodigoPT;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtItemName;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtMargGanancia;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtCosto;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtPrecioVenta;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnAddLote;
        private DevExpress.XtraEditors.SimpleButton btnFinalizar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SpinEdit spinUd;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Mantenimientos.ProductoTerminado.dsProductoTerminado dsProductoTerminado1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colcosto;
        private DevExpress.XtraGrid.Columns.GridColumn colmargen;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio_venta;
        private DevExpress.XtraGrid.Columns.GridColumn colbarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colcorrelativo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposDelete;
    }
}