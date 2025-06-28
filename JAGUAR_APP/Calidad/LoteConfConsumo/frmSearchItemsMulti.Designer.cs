namespace JAGUAR_PRO.Calidad.LoteConfConsumo
{
    partial class frmSearchItemsMulti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchItemsMulti));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.txtMarca = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodRefe = new DevExpress.XtraEditors.TextEdit();
            this.txtCodComb = new DevExpress.XtraEditors.TextEdit();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsConfigLoteConsumo1 = new JAGUAR_PRO.Calidad.LoteConfConsumo.dsConfigLoteConsumo();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDesc = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnObtener = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridConfirmados = new DevExpress.XtraGrid.GridControl();
            this.grdvConfirmados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_referencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnBuscare = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodRefe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodComb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfigLoteConsumo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridConfirmados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvConfirmados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(483, 5);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Properties.Appearance.Options.UseFont = true;
            this.txtMarca.Size = new System.Drawing.Size(122, 24);
            this.txtMarca.TabIndex = 44;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            this.txtMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMarca_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(440, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 17);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "Marca";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(236, 38);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 17);
            this.labelControl5.TabIndex = 42;
            this.labelControl5.Text = "Cod. Interno";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(5, 8);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(92, 17);
            this.labelControl4.TabIndex = 41;
            this.labelControl4.Text = "Cod. Referencia";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(5, 38);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 17);
            this.labelControl3.TabIndex = 40;
            this.labelControl3.Text = "Descripcion";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(247, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 17);
            this.labelControl2.TabIndex = 39;
            this.labelControl2.Text = "Codigo PT";
            // 
            // txtCodRefe
            // 
            this.txtCodRefe.Location = new System.Drawing.Point(101, 5);
            this.txtCodRefe.Name = "txtCodRefe";
            this.txtCodRefe.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodRefe.Properties.Appearance.Options.UseFont = true;
            this.txtCodRefe.Size = new System.Drawing.Size(131, 24);
            this.txtCodRefe.TabIndex = 38;
            this.txtCodRefe.TextChanged += new System.EventHandler(this.txtCodRefe_TextChanged);
            this.txtCodRefe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodRefe_KeyDown);
            // 
            // txtCodComb
            // 
            this.txtCodComb.Location = new System.Drawing.Point(317, 35);
            this.txtCodComb.Name = "txtCodComb";
            this.txtCodComb.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodComb.Properties.Appearance.Options.UseFont = true;
            this.txtCodComb.Size = new System.Drawing.Size(117, 24);
            this.txtCodComb.TabIndex = 37;
            this.txtCodComb.TextChanged += new System.EventHandler(this.txtCodComb_TextChanged);
            this.txtCodComb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodComb_KeyDown);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(317, 5);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Properties.Appearance.Options.UseFont = true;
            this.txtCode.Size = new System.Drawing.Size(117, 24);
            this.txtCode.TabIndex = 36;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "search_pt";
            this.gridControl1.DataSource = this.dsConfigLoteConsumo1;
            this.gridControl1.Location = new System.Drawing.Point(2, 62);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(702, 396);
            this.gridControl1.TabIndex = 34;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // dsConfigLoteConsumo1
            // 
            this.dsConfigLoteConsumo1.DataSetName = "dsConfigLoteConsumo";
            this.dsConfigLoteConsumo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colid,
            this.colmarca});
            this.gridView2.CustomizationFormBounds = new System.Drawing.Rectangle(553, 343, 259, 287);
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowViewCaption = true;
            this.gridView2.ViewCaption = "Productos Activos";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Codigo PT";
            this.gridColumn1.FieldName = "code";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 60;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Descripcion";
            this.gridColumn2.FieldName = "descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 228;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cod. Referencia";
            this.gridColumn3.FieldName = "code_referencia";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 88;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "Seleccionado";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 110;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Cod. Interno";
            this.gridColumn5.FieldName = "code_interno";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 104;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "concat_";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colmarca
            // 
            this.colmarca.Caption = "Marca";
            this.colmarca.FieldName = "marca";
            this.colmarca.Name = "colmarca";
            this.colmarca.OptionsColumn.AllowEdit = false;
            this.colmarca.Visible = true;
            this.colmarca.VisibleIndex = 4;
            this.colmarca.Width = 85;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(101, 35);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Properties.Appearance.Options.UseFont = true;
            this.txtDesc.Size = new System.Drawing.Size(131, 24);
            this.txtDesc.TabIndex = 35;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            this.txtDesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDesc_KeyDown);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1037, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(86, 47);
            this.simpleButton1.TabIndex = 32;
            this.simpleButton1.Text = "Cerrar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnObtener
            // 
            this.btnObtener.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObtener.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObtener.Appearance.Options.UseFont = true;
            this.btnObtener.Appearance.Options.UseTextOptions = true;
            this.btnObtener.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnObtener.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnObtener.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnObtener.ImageOptions.Image")));
            this.btnObtener.Location = new System.Drawing.Point(898, 7);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(122, 47);
            this.btnObtener.TabIndex = 33;
            this.btnObtener.Text = "Cargar Seleccionados";
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAdd.ImageOptions.Image")));
            this.cmdAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cmdAdd.Location = new System.Drawing.Point(710, 212);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(30, 29);
            this.cmdAdd.TabIndex = 46;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // gridConfirmados
            // 
            this.gridConfirmados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridConfirmados.DataMember = "items_confirmados";
            this.gridConfirmados.DataSource = this.dsConfigLoteConsumo1;
            this.gridConfirmados.Location = new System.Drawing.Point(744, 62);
            this.gridConfirmados.MainView = this.grdvConfirmados;
            this.gridConfirmados.Name = "gridConfirmados";
            this.gridConfirmados.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposDelete});
            this.gridConfirmados.Size = new System.Drawing.Size(400, 396);
            this.gridConfirmados.TabIndex = 47;
            this.gridConfirmados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvConfirmados});
            // 
            // grdvConfirmados
            // 
            this.grdvConfirmados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colcode_pt,
            this.colcode_referencia,
            this.coldescripcion,
            this.gridColumn7});
            this.grdvConfirmados.GridControl = this.gridConfirmados;
            this.grdvConfirmados.Name = "grdvConfirmados";
            this.grdvConfirmados.OptionsView.ShowGroupPanel = false;
            this.grdvConfirmados.OptionsView.ShowViewCaption = true;
            this.grdvConfirmados.ViewCaption = "Productos Seleccionados";
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            this.colid1.OptionsColumn.AllowEdit = false;
            // 
            // colcode_pt
            // 
            this.colcode_pt.Caption = "Cod. PT";
            this.colcode_pt.FieldName = "code_pt";
            this.colcode_pt.Name = "colcode_pt";
            this.colcode_pt.OptionsColumn.AllowEdit = false;
            this.colcode_pt.Visible = true;
            this.colcode_pt.VisibleIndex = 0;
            this.colcode_pt.Width = 51;
            // 
            // colcode_referencia
            // 
            this.colcode_referencia.Caption = "Cod. Referencia";
            this.colcode_referencia.FieldName = "code_referencia";
            this.colcode_referencia.Name = "colcode_referencia";
            this.colcode_referencia.OptionsColumn.AllowEdit = false;
            this.colcode_referencia.Visible = true;
            this.colcode_referencia.VisibleIndex = 1;
            this.colcode_referencia.Width = 91;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 2;
            this.coldescripcion.Width = 145;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Eliminar";
            this.gridColumn7.ColumnEdit = this.reposDelete;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 86;
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
            // btnBuscare
            // 
            this.btnBuscare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscare.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscare.Appearance.Options.UseFont = true;
            this.btnBuscare.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnBuscare.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscare.ImageOptions.Image")));
            this.btnBuscare.Location = new System.Drawing.Point(618, 6);
            this.btnBuscare.Name = "btnBuscare";
            this.btnBuscare.Size = new System.Drawing.Size(86, 47);
            this.btnBuscare.TabIndex = 48;
            this.btnBuscare.Text = "Buscar";
            this.btnBuscare.Click += new System.EventHandler(this.btnBuscare_Click);
            // 
            // frmSearchItemsMulti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 459);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscare);
            this.Controls.Add(this.gridConfirmados);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtCodRefe);
            this.Controls.Add(this.txtCodComb);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnObtener);
            this.Name = "frmSearchItemsMulti";
            this.Text = "Seleccion Multiple de Items";
            this.Load += new System.EventHandler(this.frmSearchItemsMulti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodRefe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodComb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfigLoteConsumo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridConfirmados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvConfirmados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtMarca;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCodRefe;
        private DevExpress.XtraEditors.TextEdit txtCodComb;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colmarca;
        private DevExpress.XtraEditors.TextEdit txtDesc;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnObtener;
        private dsConfigLoteConsumo dsConfigLoteConsumo1;
        private DevExpress.XtraEditors.SimpleButton cmdAdd;
        private DevExpress.XtraGrid.GridControl gridConfirmados;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvConfirmados;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_referencia;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.SimpleButton btnBuscare;
    }
}