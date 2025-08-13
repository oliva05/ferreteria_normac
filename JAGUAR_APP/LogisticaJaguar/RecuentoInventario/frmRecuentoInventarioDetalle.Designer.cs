namespace JAGUAR_PRO.LogisticaJaguar.RecuentoInventario
{
    partial class frmRecuentoInventarioDetalle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuentoInventarioDetalle));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dtFechaDocumento = new DevExpress.XtraEditors.DateEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRecargar = new DevExpress.XtraEditors.SimpleButton();
            this.gleAlmacen = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bodegasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRecepcionMP1 = new JAGUAR_PRO.LogisticaJaguar.dsRecepcionMP();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_almacen1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.grdSelectProductos = new DevExpress.XtraGrid.GridControl();
            this.dsRecuento1 = new JAGUAR_PRO.LogisticaJaguar.RecuentoInventario.dsRecuento();
            this.grdvSelectProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproductName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_pt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_refe1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdProductosConteo = new DevExpress.XtraGrid.GridControl();
            this.grdvProductosConteo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_pt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_refe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnRight = new DevExpress.XtraEditors.SimpleButton();
            this.chkAll = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDocumento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleAlmacen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSelectProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecuento1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvSelectProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductosConteo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvProductosConteo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFechaDocumento
            // 
            this.dtFechaDocumento.EditValue = null;
            this.dtFechaDocumento.Location = new System.Drawing.Point(178, 32);
            this.dtFechaDocumento.Name = "dtFechaDocumento";
            this.dtFechaDocumento.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtFechaDocumento.Properties.Appearance.Options.UseFont = true;
            this.dtFechaDocumento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDocumento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDocumento.Properties.CalendarTimeProperties.EditFormat.FormatString = "d";
            this.dtFechaDocumento.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtFechaDocumento.Size = new System.Drawing.Size(184, 26);
            this.dtFechaDocumento.TabIndex = 174;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(22, 35);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(136, 20);
            this.labelControl12.TabIndex = 173;
            this.labelControl12.Text = "Fecha Documento:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Location = new System.Drawing.Point(1209, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 47);
            this.btnClose.TabIndex = 178;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmdRecargar
            // 
            this.cmdRecargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRecargar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRecargar.Appearance.Options.UseFont = true;
            this.cmdRecargar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRecargar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdRecargar.ImageOptions.SvgImage")));
            this.cmdRecargar.Location = new System.Drawing.Point(1074, 25);
            this.cmdRecargar.Name = "cmdRecargar";
            this.cmdRecargar.Size = new System.Drawing.Size(104, 47);
            this.cmdRecargar.TabIndex = 177;
            this.cmdRecargar.Text = "Guardar";
            this.cmdRecargar.Click += new System.EventHandler(this.cmdRecargar_Click);
            // 
            // gleAlmacen
            // 
            this.gleAlmacen.Location = new System.Drawing.Point(169, 134);
            this.gleAlmacen.Name = "gleAlmacen";
            this.gleAlmacen.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gleAlmacen.Properties.Appearance.Options.UseFont = true;
            this.gleAlmacen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleAlmacen.Properties.DataSource = this.bodegasBindingSource;
            this.gleAlmacen.Properties.DisplayMember = "descripcion";
            this.gleAlmacen.Properties.NullText = "";
            this.gleAlmacen.Properties.PopupView = this.gridLookUpEdit1View;
            this.gleAlmacen.Properties.ValueMember = "id";
            this.gleAlmacen.Size = new System.Drawing.Size(247, 26);
            this.gleAlmacen.TabIndex = 180;
            this.gleAlmacen.EditValueChanged += new System.EventHandler(this.gleAlmacen_EditValueChanged);
            // 
            // bodegasBindingSource
            // 
            this.bodegasBindingSource.DataMember = "bodegas";
            this.bodegasBindingSource.DataSource = this.dsRecepcionMP1;
            // 
            // dsRecepcionMP1
            // 
            this.dsRecepcionMP1.DataSetName = "dsRecepcionMP";
            this.dsRecepcionMP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_almacen1,
            this.coldescripcion1,
            this.colexistencia1});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid_almacen1
            // 
            this.colid_almacen1.FieldName = "id_almacen";
            this.colid_almacen1.Name = "colid_almacen1";
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.Caption = "Bodega";
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 0;
            // 
            // colexistencia1
            // 
            this.colexistencia1.Caption = "Existencia";
            this.colexistencia1.FieldName = "existencia";
            this.colexistencia1.Name = "colexistencia1";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(50, 137);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 20);
            this.labelControl4.TabIndex = 179;
            this.labelControl4.Text = "Almacen ";
            // 
            // grdSelectProductos
            // 
            this.grdSelectProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSelectProductos.DataMember = "seleccion_producots";
            this.grdSelectProductos.DataSource = this.dsRecuento1;
            this.grdSelectProductos.Location = new System.Drawing.Point(3, 166);
            this.grdSelectProductos.MainView = this.grdvSelectProductos;
            this.grdSelectProductos.Name = "grdSelectProductos";
            this.grdSelectProductos.Size = new System.Drawing.Size(577, 546);
            this.grdSelectProductos.TabIndex = 181;
            this.grdSelectProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvSelectProductos});
            // 
            // dsRecuento1
            // 
            this.dsRecuento1.DataSetName = "dsRecuento";
            this.dsRecuento1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdvSelectProductos
            // 
            this.grdvSelectProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_pt,
            this.colproductName1,
            this.colexistencia,
            this.colseleccion,
            this.colcode_pt1,
            this.colcode_refe1});
            this.grdvSelectProductos.GridControl = this.grdSelectProductos;
            this.grdvSelectProductos.Name = "grdvSelectProductos";
            this.grdvSelectProductos.OptionsView.ShowAutoFilterRow = true;
            this.grdvSelectProductos.OptionsView.ShowFooter = true;
            this.grdvSelectProductos.OptionsView.ShowGroupPanel = false;
            this.grdvSelectProductos.OptionsView.ShowViewCaption = true;
            this.grdvSelectProductos.ViewCaption = "Seleccion de Productos";
            // 
            // colid_pt
            // 
            this.colid_pt.FieldName = "id_pt";
            this.colid_pt.Name = "colid_pt";
            this.colid_pt.OptionsColumn.AllowEdit = false;
            this.colid_pt.OptionsColumn.ReadOnly = true;
            // 
            // colproductName1
            // 
            this.colproductName1.Caption = "Producto";
            this.colproductName1.FieldName = "productName";
            this.colproductName1.Name = "colproductName1";
            this.colproductName1.OptionsColumn.AllowEdit = false;
            this.colproductName1.OptionsColumn.ReadOnly = true;
            this.colproductName1.Visible = true;
            this.colproductName1.VisibleIndex = 0;
            this.colproductName1.Width = 176;
            // 
            // colexistencia
            // 
            this.colexistencia.Caption = "Existencia";
            this.colexistencia.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colexistencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colexistencia.FieldName = "existencia";
            this.colexistencia.Name = "colexistencia";
            this.colexistencia.OptionsColumn.AllowEdit = false;
            this.colexistencia.OptionsColumn.ReadOnly = true;
            this.colexistencia.Visible = true;
            this.colexistencia.VisibleIndex = 3;
            this.colexistencia.Width = 83;
            // 
            // colseleccion
            // 
            this.colseleccion.Caption = "Seleccionar";
            this.colseleccion.FieldName = "seleccion";
            this.colseleccion.Name = "colseleccion";
            this.colseleccion.Visible = true;
            this.colseleccion.VisibleIndex = 4;
            this.colseleccion.Width = 92;
            // 
            // colcode_pt1
            // 
            this.colcode_pt1.Caption = "Cod. PT";
            this.colcode_pt1.FieldName = "code_pt";
            this.colcode_pt1.Name = "colcode_pt1";
            this.colcode_pt1.OptionsColumn.AllowEdit = false;
            this.colcode_pt1.Visible = true;
            this.colcode_pt1.VisibleIndex = 1;
            this.colcode_pt1.Width = 89;
            // 
            // colcode_refe1
            // 
            this.colcode_refe1.Caption = "Cod. Referencia";
            this.colcode_refe1.FieldName = "code_refe";
            this.colcode_refe1.Name = "colcode_refe1";
            this.colcode_refe1.OptionsColumn.AllowEdit = false;
            this.colcode_refe1.Visible = true;
            this.colcode_refe1.VisibleIndex = 2;
            this.colcode_refe1.Width = 97;
            // 
            // grdProductosConteo
            // 
            this.grdProductosConteo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProductosConteo.DataMember = "productos_conteo";
            this.grdProductosConteo.DataSource = this.dsRecuento1;
            this.grdProductosConteo.Location = new System.Drawing.Point(665, 166);
            this.grdProductosConteo.MainView = this.grdvProductosConteo;
            this.grdProductosConteo.Name = "grdProductosConteo";
            this.grdProductosConteo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposDelete});
            this.grdProductosConteo.Size = new System.Drawing.Size(669, 546);
            this.grdProductosConteo.TabIndex = 182;
            this.grdProductosConteo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvProductosConteo});
            // 
            // grdvProductosConteo
            // 
            this.grdvProductosConteo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_pt1,
            this.colproductName,
            this.colid_bodega,
            this.colbodega,
            this.colexistencia2,
            this.colcode_pt,
            this.colcode_refe,
            this.gridColumn1});
            this.grdvProductosConteo.GridControl = this.grdProductosConteo;
            this.grdvProductosConteo.Name = "grdvProductosConteo";
            this.grdvProductosConteo.OptionsView.ShowGroupPanel = false;
            this.grdvProductosConteo.OptionsView.ShowViewCaption = true;
            this.grdvProductosConteo.ViewCaption = "Productos Seleccionados para Conteo";
            // 
            // colid_pt1
            // 
            this.colid_pt1.FieldName = "id_pt";
            this.colid_pt1.Name = "colid_pt1";
            this.colid_pt1.OptionsColumn.AllowEdit = false;
            // 
            // colproductName
            // 
            this.colproductName.Caption = "Producto";
            this.colproductName.FieldName = "productName";
            this.colproductName.Name = "colproductName";
            this.colproductName.OptionsColumn.AllowEdit = false;
            this.colproductName.Visible = true;
            this.colproductName.VisibleIndex = 0;
            this.colproductName.Width = 177;
            // 
            // colid_bodega
            // 
            this.colid_bodega.FieldName = "id_bodega";
            this.colid_bodega.Name = "colid_bodega";
            this.colid_bodega.OptionsColumn.AllowEdit = false;
            // 
            // colbodega
            // 
            this.colbodega.Caption = "Almacen";
            this.colbodega.FieldName = "bodega";
            this.colbodega.Name = "colbodega";
            this.colbodega.OptionsColumn.AllowEdit = false;
            this.colbodega.Visible = true;
            this.colbodega.VisibleIndex = 3;
            this.colbodega.Width = 98;
            // 
            // colexistencia2
            // 
            this.colexistencia2.Caption = "Inventario";
            this.colexistencia2.FieldName = "existencia";
            this.colexistencia2.Name = "colexistencia2";
            this.colexistencia2.OptionsColumn.AllowEdit = false;
            this.colexistencia2.Visible = true;
            this.colexistencia2.VisibleIndex = 4;
            this.colexistencia2.Width = 70;
            // 
            // colcode_pt
            // 
            this.colcode_pt.Caption = "Cod. PT";
            this.colcode_pt.FieldName = "code_pt";
            this.colcode_pt.Name = "colcode_pt";
            this.colcode_pt.OptionsColumn.AllowEdit = false;
            this.colcode_pt.Visible = true;
            this.colcode_pt.VisibleIndex = 2;
            this.colcode_pt.Width = 81;
            // 
            // colcode_refe
            // 
            this.colcode_refe.Caption = "Cod. Referencia";
            this.colcode_refe.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colcode_refe.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcode_refe.FieldName = "code_refe";
            this.colcode_refe.Name = "colcode_refe";
            this.colcode_refe.OptionsColumn.AllowEdit = false;
            this.colcode_refe.Visible = true;
            this.colcode_refe.VisibleIndex = 1;
            this.colcode_refe.Width = 110;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Eliminar";
            this.gridColumn1.ColumnEdit = this.reposDelete;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 85;
            // 
            // reposDelete
            // 
            this.reposDelete.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.reposDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposDelete.Name = "reposDelete";
            this.reposDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposDelete_ButtonClick);
            // 
            // btnRight
            // 
            this.btnRight.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.ImageOptions.Image")));
            this.btnRight.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnRight.Location = new System.Drawing.Point(584, 293);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 36);
            this.btnRight.TabIndex = 183;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // chkAll
            // 
            this.chkAll.Location = new System.Drawing.Point(471, 139);
            this.chkAll.Name = "chkAll";
            this.chkAll.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAll.Properties.Appearance.Options.UseFont = true;
            this.chkAll.Properties.Caption = "Selec. Todos";
            this.chkAll.Size = new System.Drawing.Size(96, 20);
            this.chkAll.TabIndex = 184;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(22, 81);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 20);
            this.labelControl1.TabIndex = 185;
            this.labelControl1.Text = "Usaurio:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(178, 78);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Size = new System.Drawing.Size(184, 26);
            this.txtUsuario.TabIndex = 186;
            // 
            // frmRecuentoInventarioDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 713);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.grdProductosConteo);
            this.Controls.Add(this.grdSelectProductos);
            this.Controls.Add(this.gleAlmacen);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmdRecargar);
            this.Controls.Add(this.dtFechaDocumento);
            this.Controls.Add(this.labelControl12);
            this.Name = "frmRecuentoInventarioDetalle";
            this.Text = "Detalle de Recuento de Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDocumento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleAlmacen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSelectProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecuento1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvSelectProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductosConteo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvProductosConteo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtFechaDocumento;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton cmdRecargar;
        private DevExpress.XtraEditors.GridLookUpEdit gleAlmacen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid_almacen1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl grdSelectProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvSelectProductos;
        private DevExpress.XtraGrid.GridControl grdProductosConteo;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvProductosConteo;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposDelete;
        private DevExpress.XtraEditors.SimpleButton btnRight;
        private DevExpress.XtraEditors.CheckEdit chkAll;
        private dsRecuento dsRecuento1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt1;
        private DevExpress.XtraGrid.Columns.GridColumn colproductName;
        private DevExpress.XtraGrid.Columns.GridColumn colid_bodega;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia2;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_refe;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private dsRecepcionMP dsRecepcionMP1;
        private System.Windows.Forms.BindingSource bodegasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colproductName1;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccion;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_pt1;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_refe1;
    }
}