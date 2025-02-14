namespace JAGUAR_PRO.Mantenimientos.ProductoTerminado
{
    partial class frmMainPTFamilia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPTFamilia));
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
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNuevoPT = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridDetalleProductosCRUD = new DevExpress.XtraGrid.GridControl();
            this.dsProductoTerminado1 = new JAGUAR_PRO.Mantenimientos.ProductoTerminado.dsProductoTerminado();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEditar2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdReceta2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.reposClases = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tggViewFilter = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleProductosCRUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductoTerminado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdReceta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposClases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggViewFilter.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.Pink;
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdCerrar.ImageOptions.SvgImage")));
            this.cmdCerrar.Location = new System.Drawing.Point(663, 27);
            this.cmdCerrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(101, 42);
            this.cmdCerrar.TabIndex = 15;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // cmdNuevoPT
            // 
            this.cmdNuevoPT.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdNuevoPT.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmdNuevoPT.Appearance.Options.UseBackColor = true;
            this.cmdNuevoPT.Appearance.Options.UseFont = true;
            this.cmdNuevoPT.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdNuevoPT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdNuevoPT.ImageOptions.SvgImage")));
            this.cmdNuevoPT.Location = new System.Drawing.Point(12, 27);
            this.cmdNuevoPT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdNuevoPT.Name = "cmdNuevoPT";
            this.cmdNuevoPT.Size = new System.Drawing.Size(101, 42);
            this.cmdNuevoPT.TabIndex = 14;
            this.cmdNuevoPT.Text = "Nuevo";
            this.cmdNuevoPT.Click += new System.EventHandler(this.cmdNuevoPT_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(117, 12);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(536, 26);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Familia de Producto Terminado";
            // 
            // gridDetalleProductosCRUD
            // 
            this.gridDetalleProductosCRUD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDetalleProductosCRUD.DataMember = "familia";
            this.gridDetalleProductosCRUD.DataSource = this.dsProductoTerminado1;
            this.gridDetalleProductosCRUD.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridDetalleProductosCRUD.Location = new System.Drawing.Point(1, 84);
            this.gridDetalleProductosCRUD.MainView = this.gridView1;
            this.gridDetalleProductosCRUD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridDetalleProductosCRUD.Name = "gridDetalleProductosCRUD";
            this.gridDetalleProductosCRUD.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdEditar2,
            this.cmdReceta2,
            this.reposClases});
            this.gridDetalleProductosCRUD.Size = new System.Drawing.Size(779, 437);
            this.gridDetalleProductosCRUD.TabIndex = 17;
            this.gridDetalleProductosCRUD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsProductoTerminado1
            // 
            this.dsProductoTerminado1.DataSetName = "dsProductoTerminado";
            this.dsProductoTerminado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion,
            this.colcodigo,
            this.colenable,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridDetalleProductosCRUD;
            this.gridView1.LevelIndent = 0;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 685;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.PreviewIndent = 0;
            // 
            // colid
            // 
            this.colid.Caption = "Id";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 105;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.ReadOnly = true;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 2;
            this.coldescripcion.Width = 295;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.ReadOnly = true;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 1;
            this.colcodigo.Width = 147;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Editar";
            this.gridColumn1.ColumnEdit = this.cmdEditar2;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 207;
            // 
            // cmdEditar2
            // 
            this.cmdEditar2.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdEditar2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEditar2.Name = "cmdEditar2";
            this.cmdEditar2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdEditar2.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdEditar2_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            // 
            // cmdReceta2
            // 
            this.cmdReceta2.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdReceta2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdReceta2.Name = "cmdReceta2";
            this.cmdReceta2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // reposClases
            // 
            this.reposClases.AutoHeight = false;
            this.reposClases.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.reposClases.Name = "reposClases";
            // 
            // tggViewFilter
            // 
            this.tggViewFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tggViewFilter.Location = new System.Drawing.Point(392, 54);
            this.tggViewFilter.Name = "tggViewFilter";
            this.tggViewFilter.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.tggViewFilter.Properties.Appearance.Options.UseFont = true;
            this.tggViewFilter.Properties.OffText = "No";
            this.tggViewFilter.Properties.OnText = "Si";
            this.tggViewFilter.Size = new System.Drawing.Size(95, 24);
            this.tggViewFilter.TabIndex = 18;
            this.tggViewFilter.Toggled += new System.EventHandler(this.tggViewFilter_Toggled);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(273, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(113, 20);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Mostrar Inactivos";
            // 
            // frmMainPTFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 524);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.tggViewFilter);
            this.Controls.Add(this.gridDetalleProductosCRUD);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdNuevoPT);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmMainPTFamilia";
            this.Text = "Gestion Familia de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleProductosCRUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductoTerminado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdReceta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposClases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggViewFilter.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.SimpleButton cmdNuevoPT;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridDetalleProductosCRUD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEditar2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdReceta2;
        private dsProductoTerminado dsProductoTerminado1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.ToggleSwitch tggViewFilter;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposClases;
    }
}