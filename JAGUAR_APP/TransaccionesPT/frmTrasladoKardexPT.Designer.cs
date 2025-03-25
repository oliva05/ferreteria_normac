namespace JAGUAR_PRO.TransaccionesPT
{
    partial class frmTrasladoKardexPT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrasladoKardexPT));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRecargar = new DevExpress.XtraEditors.SimpleButton();
            this.gleAlmacen = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bodegaorigenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRecepcionMP1 = new JAGUAR_PRO.LogisticaJaguar.dsRecepcionMP();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_almacen1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCantidadUnidades = new DevExpress.XtraEditors.TextEdit();
            this.gridLookUpEditPresentacion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.presentacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvLookUpEditPresentacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaDocumento = new DevExpress.XtraEditors.DateEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtPT_Name = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.grdAlmacenDestino = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bodegadestinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_almacen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumLote = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gleAlmacen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaorigenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadUnidades.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditPresentacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLookUpEditPresentacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDocumento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPT_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlmacenDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegadestinoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumLote.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Location = new System.Drawing.Point(505, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 47);
            this.btnClose.TabIndex = 148;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmdRecargar
            // 
            this.cmdRecargar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRecargar.Appearance.Options.UseFont = true;
            this.cmdRecargar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRecargar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdRecargar.ImageOptions.SvgImage")));
            this.cmdRecargar.Location = new System.Drawing.Point(12, 13);
            this.cmdRecargar.Name = "cmdRecargar";
            this.cmdRecargar.Size = new System.Drawing.Size(104, 47);
            this.cmdRecargar.TabIndex = 147;
            this.cmdRecargar.Text = "Guardar";
            this.cmdRecargar.Click += new System.EventHandler(this.cmdRecargar_Click);
            // 
            // gleAlmacen
            // 
            this.gleAlmacen.Location = new System.Drawing.Point(232, 195);
            this.gleAlmacen.Name = "gleAlmacen";
            this.gleAlmacen.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gleAlmacen.Properties.Appearance.Options.UseFont = true;
            this.gleAlmacen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleAlmacen.Properties.DataSource = this.bodegaorigenBindingSource;
            this.gleAlmacen.Properties.DisplayMember = "descripcion";
            this.gleAlmacen.Properties.PopupView = this.gridLookUpEdit1View;
            this.gleAlmacen.Properties.ValueMember = "id_almacen";
            this.gleAlmacen.Size = new System.Drawing.Size(356, 26);
            this.gleAlmacen.TabIndex = 158;
            this.gleAlmacen.EditValueChanged += new System.EventHandler(this.gleAlmacen_EditValueChanged);
            // 
            // bodegaorigenBindingSource
            // 
            this.bodegaorigenBindingSource.DataMember = "bodega_origen";
            this.bodegaorigenBindingSource.DataSource = this.dsRecepcionMP1;
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
            this.colexistencia1.Visible = true;
            this.colexistencia1.VisibleIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(31, 197);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(138, 24);
            this.labelControl4.TabIndex = 157;
            this.labelControl4.Text = "Almacen Origen";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(30, 226);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 24);
            this.labelControl1.TabIndex = 156;
            this.labelControl1.Text = "Unidades";
            // 
            // txtCantidadUnidades
            // 
            this.txtCantidadUnidades.EditValue = "0";
            this.txtCantidadUnidades.Location = new System.Drawing.Point(232, 226);
            this.txtCantidadUnidades.Name = "txtCantidadUnidades";
            this.txtCantidadUnidades.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtCantidadUnidades.Properties.Appearance.Options.UseFont = true;
            this.txtCantidadUnidades.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCantidadUnidades.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCantidadUnidades.Properties.MaskSettings.Set("mask", "n");
            this.txtCantidadUnidades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCantidadUnidades.Size = new System.Drawing.Size(355, 26);
            this.txtCantidadUnidades.TabIndex = 155;
            this.txtCantidadUnidades.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidadUnidades_KeyDown);
            this.txtCantidadUnidades.Leave += new System.EventHandler(this.txtCantidadUnidades_Leave);
            // 
            // gridLookUpEditPresentacion
            // 
            this.gridLookUpEditPresentacion.EditValue = "";
            this.gridLookUpEditPresentacion.Enabled = false;
            this.gridLookUpEditPresentacion.Location = new System.Drawing.Point(232, 164);
            this.gridLookUpEditPresentacion.Name = "gridLookUpEditPresentacion";
            this.gridLookUpEditPresentacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gridLookUpEditPresentacion.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEditPresentacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditPresentacion.Properties.DataSource = this.presentacionesBindingSource;
            this.gridLookUpEditPresentacion.Properties.DisplayMember = "descripcion";
            this.gridLookUpEditPresentacion.Properties.PopupView = this.gvLookUpEditPresentacion;
            this.gridLookUpEditPresentacion.Properties.ValueMember = "id";
            this.gridLookUpEditPresentacion.Size = new System.Drawing.Size(355, 26);
            this.gridLookUpEditPresentacion.TabIndex = 153;
            this.gridLookUpEditPresentacion.EditValueChanged += new System.EventHandler(this.gridLookUpEditPresentacion_EditValueChanged);
            // 
            // presentacionesBindingSource
            // 
            this.presentacionesBindingSource.DataMember = "presentaciones";
            this.presentacionesBindingSource.DataSource = this.dsRecepcionMP1;
            // 
            // gvLookUpEditPresentacion
            // 
            this.gvLookUpEditPresentacion.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvLookUpEditPresentacion.Appearance.Row.Options.UseFont = true;
            this.gvLookUpEditPresentacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion,
            this.colFactor});
            this.gvLookUpEditPresentacion.DetailHeight = 284;
            this.gvLookUpEditPresentacion.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvLookUpEditPresentacion.Name = "gvLookUpEditPresentacion";
            this.gvLookUpEditPresentacion.OptionsEditForm.PopupEditFormWidth = 686;
            this.gvLookUpEditPresentacion.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvLookUpEditPresentacion.OptionsView.ShowAutoFilterRow = true;
            this.gvLookUpEditPresentacion.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.MinWidth = 17;
            this.colid.Name = "colid";
            this.colid.Width = 64;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Presentaciones";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.MinWidth = 17;
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            this.coldescripcion.Width = 64;
            // 
            // colFactor
            // 
            this.colFactor.Caption = "gridColumn3";
            this.colFactor.FieldName = "factor";
            this.colFactor.MinWidth = 17;
            this.colFactor.Name = "colFactor";
            this.colFactor.Width = 64;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(33, 164);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(110, 24);
            this.labelControl11.TabIndex = 154;
            this.labelControl11.Text = "Presentación";
            // 
            // dtFechaDocumento
            // 
            this.dtFechaDocumento.EditValue = null;
            this.dtFechaDocumento.Location = new System.Drawing.Point(232, 132);
            this.dtFechaDocumento.Name = "dtFechaDocumento";
            this.dtFechaDocumento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dtFechaDocumento.Properties.Appearance.Options.UseFont = true;
            this.dtFechaDocumento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDocumento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDocumento.Properties.CalendarTimeProperties.EditFormat.FormatString = "d";
            this.dtFechaDocumento.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtFechaDocumento.Size = new System.Drawing.Size(355, 26);
            this.dtFechaDocumento.TabIndex = 152;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(33, 132);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(157, 24);
            this.labelControl12.TabIndex = 151;
            this.labelControl12.Text = "Fecha Documento";
            // 
            // txtPT_Name
            // 
            this.txtPT_Name.Location = new System.Drawing.Point(233, 96);
            this.txtPT_Name.Name = "txtPT_Name";
            this.txtPT_Name.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPT_Name.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = global::JAGUAR_PRO.Properties.Resources.wheat;
            serializableAppearanceObject1.BackColor = System.Drawing.Color.Transparent;
            serializableAppearanceObject1.Options.UseBackColor = true;
            serializableAppearanceObject2.BackColor = System.Drawing.Color.LightBlue;
            serializableAppearanceObject2.Options.UseBackColor = true;
            serializableAppearanceObject3.BackColor = System.Drawing.Color.LightBlue;
            serializableAppearanceObject3.Options.UseBackColor = true;
            serializableAppearanceObject4.BackColor = System.Drawing.Color.LightBlue;
            serializableAppearanceObject4.Options.UseBackColor = true;
            this.txtPT_Name.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtPT_Name.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtPT_Name.Properties.ReadOnly = true;
            this.txtPT_Name.Size = new System.Drawing.Size(355, 30);
            this.txtPT_Name.TabIndex = 149;
            this.txtPT_Name.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtPT_Name_ButtonClick);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(33, 98);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(173, 24);
            this.labelControl2.TabIndex = 150;
            this.labelControl2.Text = "Producto Terminado";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(30, 261);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(143, 24);
            this.labelControl3.TabIndex = 159;
            this.labelControl3.Text = "Almacen Destino";
            // 
            // grdAlmacenDestino
            // 
            this.grdAlmacenDestino.Location = new System.Drawing.Point(232, 258);
            this.grdAlmacenDestino.Name = "grdAlmacenDestino";
            this.grdAlmacenDestino.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdAlmacenDestino.Properties.Appearance.Options.UseFont = true;
            this.grdAlmacenDestino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdAlmacenDestino.Properties.DataSource = this.bodegadestinoBindingSource;
            this.grdAlmacenDestino.Properties.DisplayMember = "descripcion";
            this.grdAlmacenDestino.Properties.PopupView = this.gridView1;
            this.grdAlmacenDestino.Properties.ValueMember = "id_almacen";
            this.grdAlmacenDestino.Size = new System.Drawing.Size(356, 26);
            this.grdAlmacenDestino.TabIndex = 160;
            // 
            // bodegadestinoBindingSource
            // 
            this.bodegadestinoBindingSource.DataMember = "bodega_destino";
            this.bodegadestinoBindingSource.DataSource = this.dsRecepcionMP1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_almacen,
            this.coldescripcion2,
            this.colexistencia});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_almacen
            // 
            this.colid_almacen.FieldName = "id_almacen";
            this.colid_almacen.Name = "colid_almacen";
            // 
            // coldescripcion2
            // 
            this.coldescripcion2.Caption = "Bodega";
            this.coldescripcion2.FieldName = "descripcion";
            this.coldescripcion2.Name = "coldescripcion2";
            this.coldescripcion2.Visible = true;
            this.coldescripcion2.VisibleIndex = 0;
            // 
            // colexistencia
            // 
            this.colexistencia.Caption = "Existencia";
            this.colexistencia.FieldName = "existencia";
            this.colexistencia.Name = "colexistencia";
            this.colexistencia.Visible = true;
            this.colexistencia.VisibleIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(34, 338);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(51, 24);
            this.labelControl5.TabIndex = 161;
            this.labelControl5.Text = "# Lote";
            this.labelControl5.Visible = false;
            // 
            // txtNumLote
            // 
            this.txtNumLote.Location = new System.Drawing.Point(232, 336);
            this.txtNumLote.Name = "txtNumLote";
            this.txtNumLote.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtNumLote.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions2.Image = global::JAGUAR_PRO.Properties.Resources.wheat;
            serializableAppearanceObject5.BackColor = System.Drawing.Color.Transparent;
            serializableAppearanceObject5.Options.UseBackColor = true;
            serializableAppearanceObject6.BackColor = System.Drawing.Color.LightBlue;
            serializableAppearanceObject6.Options.UseBackColor = true;
            serializableAppearanceObject7.BackColor = System.Drawing.Color.LightBlue;
            serializableAppearanceObject7.Options.UseBackColor = true;
            serializableAppearanceObject8.BackColor = System.Drawing.Color.LightBlue;
            serializableAppearanceObject8.Options.UseBackColor = true;
            this.txtNumLote.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtNumLote.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtNumLote.Properties.ReadOnly = true;
            this.txtNumLote.Size = new System.Drawing.Size(355, 30);
            this.txtNumLote.TabIndex = 162;
            this.txtNumLote.Visible = false;
            // 
            // frmTrasladoKardexPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 302);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtNumLote);
            this.Controls.Add(this.grdAlmacenDestino);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.gleAlmacen);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCantidadUnidades);
            this.Controls.Add(this.gridLookUpEditPresentacion);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.dtFechaDocumento);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.txtPT_Name);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmdRecargar);
            this.IconOptions.Image = global::JAGUAR_PRO.Properties.Resources.traslado_de_paqueteria;
            this.Name = "frmTrasladoKardexPT";
            this.Text = "Traslado entre Almacenes";
            ((System.ComponentModel.ISupportInitialize)(this.gleAlmacen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaorigenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadUnidades.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditPresentacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLookUpEditPresentacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDocumento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPT_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlmacenDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegadestinoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumLote.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton cmdRecargar;
        private DevExpress.XtraEditors.GridLookUpEdit gleAlmacen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCantidadUnidades;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditPresentacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLookUpEditPresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colFactor;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.DateEdit dtFechaDocumento;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.ButtonEdit txtPT_Name;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GridLookUpEdit grdAlmacenDestino;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource presentacionesBindingSource;
        private LogisticaJaguar.dsRecepcionMP dsRecepcionMP1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ButtonEdit txtNumLote;
        private System.Windows.Forms.BindingSource bodegaorigenBindingSource;
        private System.Windows.Forms.BindingSource bodegadestinoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid_almacen1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_almacen;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion2;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia;
    }
}