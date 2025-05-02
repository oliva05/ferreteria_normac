namespace JAGUAR_PRO.Mantenimientos.Comisiones
{
    partial class frmCRUDComisionesDetalle
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCRUDComisionesDetalle));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.MemoEdit();
            this.gcComisiones = new DevExpress.XtraGrid.GridControl();
            this.dsComisiones1 = new JAGUAR_PRO.Mantenimientos.Comisiones.dsComisiones();
            this.gvComisiones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_header = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpiso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltecho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colporcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colporcentaje_lps = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbonificacion_extra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal_pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tipoplanesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_criterio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtAnio = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtInicioComision = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcComisiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComisiones1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvComisiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoplanesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInicioComision.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(52, 192);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 17);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "Descripción:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(250, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(261, 25);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Configuración de Comisiones";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(578, 77);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(96, 29);
            this.simpleButton2.TabIndex = 22;
            this.simpleButton2.Text = "Cancelar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(477, 77);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 29);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(99, 73);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 17);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Año:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(141, 190);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Properties.MaxLength = 100;
            this.txtDescripcion.Size = new System.Drawing.Size(470, 53);
            this.txtDescripcion.TabIndex = 6;
            // 
            // gcComisiones
            // 
            this.gcComisiones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcComisiones.DataMember = "detalle_comisiones";
            this.gcComisiones.DataSource = this.dsComisiones1;
            this.gcComisiones.Location = new System.Drawing.Point(0, 293);
            this.gcComisiones.MainView = this.gvComisiones;
            this.gcComisiones.Name = "gcComisiones";
            this.gcComisiones.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDelete});
            this.gcComisiones.Size = new System.Drawing.Size(688, 256);
            this.gcComisiones.TabIndex = 8;
            this.gcComisiones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvComisiones});
            // 
            // dsComisiones1
            // 
            this.dsComisiones1.DataSetName = "dsComisiones";
            this.dsComisiones1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvComisiones
            // 
            this.gvComisiones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_header,
            this.colpiso,
            this.coltecho,
            this.colporcentaje,
            this.colporcentaje_lps,
            this.colbonificacion_extra,
            this.coltotal_pago,
            this.gridColumn1,
            this.gridColumn2});
            this.gvComisiones.GridControl = this.gcComisiones;
            this.gvComisiones.Name = "gvComisiones";
            this.gvComisiones.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvComisiones.OptionsView.ShowGroupPanel = false;
            this.gvComisiones.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvComisiones_CellValueChanged);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colid_header
            // 
            this.colid_header.FieldName = "id_header";
            this.colid_header.Name = "colid_header";
            this.colid_header.OptionsColumn.AllowEdit = false;
            // 
            // colpiso
            // 
            this.colpiso.Caption = "Piso";
            this.colpiso.DisplayFormat.FormatString = "L. {0:N2}";
            this.colpiso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpiso.FieldName = "piso";
            this.colpiso.Name = "colpiso";
            this.colpiso.Visible = true;
            this.colpiso.VisibleIndex = 0;
            this.colpiso.Width = 77;
            // 
            // coltecho
            // 
            this.coltecho.Caption = "Techo";
            this.coltecho.DisplayFormat.FormatString = "L. {0:N2}";
            this.coltecho.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltecho.FieldName = "techo";
            this.coltecho.Name = "coltecho";
            this.coltecho.Visible = true;
            this.coltecho.VisibleIndex = 1;
            this.coltecho.Width = 77;
            // 
            // colporcentaje
            // 
            this.colporcentaje.Caption = "% Comision";
            this.colporcentaje.DisplayFormat.FormatString = "{0:N2}";
            this.colporcentaje.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colporcentaje.FieldName = "porcentaje";
            this.colporcentaje.Name = "colporcentaje";
            this.colporcentaje.Visible = true;
            this.colporcentaje.VisibleIndex = 2;
            this.colporcentaje.Width = 77;
            // 
            // colporcentaje_lps
            // 
            this.colporcentaje_lps.Caption = "Monto Lps";
            this.colporcentaje_lps.DisplayFormat.FormatString = "L. {0:N2}";
            this.colporcentaje_lps.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colporcentaje_lps.FieldName = "porcentaje_lps";
            this.colporcentaje_lps.Name = "colporcentaje_lps";
            this.colporcentaje_lps.OptionsColumn.ReadOnly = true;
            this.colporcentaje_lps.Visible = true;
            this.colporcentaje_lps.VisibleIndex = 3;
            this.colporcentaje_lps.Width = 77;
            // 
            // colbonificacion_extra
            // 
            this.colbonificacion_extra.Caption = "Premio";
            this.colbonificacion_extra.DisplayFormat.FormatString = "L. {0:N2}";
            this.colbonificacion_extra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colbonificacion_extra.FieldName = "bonificacion_extra";
            this.colbonificacion_extra.Name = "colbonificacion_extra";
            this.colbonificacion_extra.Visible = true;
            this.colbonificacion_extra.VisibleIndex = 4;
            this.colbonificacion_extra.Width = 77;
            // 
            // coltotal_pago
            // 
            this.coltotal_pago.Caption = "Total a Pagar";
            this.coltotal_pago.DisplayFormat.FormatString = "L. {0:N2}";
            this.coltotal_pago.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal_pago.FieldName = "total_pago";
            this.coltotal_pago.Name = "coltotal_pago";
            this.coltotal_pago.OptionsColumn.ReadOnly = true;
            this.coltotal_pago.Visible = true;
            this.coltotal_pago.VisibleIndex = 5;
            this.coltotal_pago.Width = 108;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Eliminar";
            this.gridColumn1.ColumnEdit = this.btnDelete;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            this.gridColumn1.Width = 72;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Con Limite Techo";
            this.gridColumn2.FieldName = "limite_techo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            this.gridColumn2.Width = 96;
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(141, 131);
            this.dtHasta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtHasta.Properties.Appearance.Options.UseFont = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtHasta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtHasta.Size = new System.Drawing.Size(100, 24);
            this.dtHasta.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(50, 134);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 17);
            this.labelControl2.TabIndex = 121;
            this.labelControl2.Text = "Fecha Hasta:";
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(141, 100);
            this.dtDesde.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtDesde.Properties.Appearance.Options.UseFont = true;
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtDesde.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDesde.Size = new System.Drawing.Size(100, 24);
            this.dtDesde.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(47, 103);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(81, 17);
            this.labelControl5.TabIndex = 119;
            this.labelControl5.Text = "Fecha Desde:";
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Location = new System.Drawing.Point(141, 160);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridLookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DataSource = this.tipoplanesBindingSource;
            this.gridLookUpEdit1.Properties.DisplayMember = "descripcion";
            this.gridLookUpEdit1.Properties.NullText = "";
            this.gridLookUpEdit1.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Properties.ValueMember = "id";
            this.gridLookUpEdit1.Size = new System.Drawing.Size(318, 24);
            this.gridLookUpEdit1.TabIndex = 3;
            // 
            // tipoplanesBindingSource
            // 
            this.tipoplanesBindingSource.DataMember = "tipo_planes";
            this.tipoplanesBindingSource.DataSource = this.dsComisiones1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.coldescripcion,
            this.colid_criterio});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // colid_criterio
            // 
            this.colid_criterio.FieldName = "id_criterio";
            this.colid_criterio.Name = "colid_criterio";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(65, 164);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 17);
            this.labelControl6.TabIndex = 124;
            this.labelControl6.Text = "Tipo Plan:";
            this.labelControl6.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Asterisk;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(141, 70);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAnio.Properties.Appearance.Options.UseFont = true;
            this.txtAnio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAnio.Properties.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034"});
            this.txtAnio.Size = new System.Drawing.Size(100, 24);
            this.txtAnio.TabIndex = 2;
            // 
            // txtInicioComision
            // 
            this.txtInicioComision.EditValue = "";
            this.txtInicioComision.Location = new System.Drawing.Point(141, 253);
            this.txtInicioComision.Name = "txtInicioComision";
            this.txtInicioComision.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtInicioComision.Properties.Appearance.Options.UseFont = true;
            this.txtInicioComision.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtInicioComision.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtInicioComision.Properties.MaskSettings.Set("mask", "n");
            this.txtInicioComision.Properties.MaskSettings.Set("valueType", typeof(decimal));
            this.txtInicioComision.Properties.UseMaskAsDisplayFormat = true;
            this.txtInicioComision.Size = new System.Drawing.Size(100, 24);
            this.txtInicioComision.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl7.LineVisible = true;
            this.labelControl7.Location = new System.Drawing.Point(28, 256);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(100, 17);
            this.labelControl7.TabIndex = 126;
            this.labelControl7.Text = "Inicio Comision:";
            // 
            // frmCRUDComisionesDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 548);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtInicioComision);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.gridLookUpEdit1);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.gcComisiones);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtDescripcion);
            this.Name = "frmCRUDComisionesDetalle";
            this.Text = "Gestion de Comisiones";
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcComisiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComisiones1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvComisiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoplanesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInicioComision.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtDescripcion;
        private DevExpress.XtraGrid.GridControl gcComisiones;
        private DevExpress.XtraGrid.Views.Grid.GridView gvComisiones;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private dsComisiones dsComisiones1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.BindingSource tipoplanesBindingSource;
        private DevExpress.XtraEditors.ComboBoxEdit txtAnio;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_header;
        private DevExpress.XtraGrid.Columns.GridColumn colpiso;
        private DevExpress.XtraGrid.Columns.GridColumn coltecho;
        private DevExpress.XtraGrid.Columns.GridColumn colporcentaje;
        private DevExpress.XtraGrid.Columns.GridColumn colporcentaje_lps;
        private DevExpress.XtraGrid.Columns.GridColumn colbonificacion_extra;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_pago;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_criterio;
        private DevExpress.XtraEditors.TextEdit txtInicioComision;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}