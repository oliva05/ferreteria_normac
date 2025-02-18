namespace JAGUAR_PRO.Mantenimientos.ProductoTerminado
{
    partial class frmMainPTClase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPTClase));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dsProductoTerminado1 = new JAGUAR_PRO.Mantenimientos.ProductoTerminado.dsProductoTerminado();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tggViewFilter = new DevExpress.XtraEditors.ToggleSwitch();
            this.gridDetalleProductosCRUD = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_clase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_familia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfamilia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodFamilia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEditar2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdReceta2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.reposClases = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNuevoPT = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductoTerminado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggViewFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleProductosCRUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdReceta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposClases)).BeginInit();
            this.SuspendLayout();
            // 
            // dsProductoTerminado1
            // 
            this.dsProductoTerminado1.DataSetName = "dsProductoTerminado";
            this.dsProductoTerminado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(274, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(113, 20);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "Mostrar Inactivos";
            // 
            // tggViewFilter
            // 
            this.tggViewFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tggViewFilter.Location = new System.Drawing.Point(393, 50);
            this.tggViewFilter.Name = "tggViewFilter";
            this.tggViewFilter.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.tggViewFilter.Properties.Appearance.Options.UseFont = true;
            this.tggViewFilter.Properties.OffText = "No";
            this.tggViewFilter.Properties.OnText = "Si";
            this.tggViewFilter.Size = new System.Drawing.Size(95, 24);
            this.tggViewFilter.TabIndex = 24;
            this.tggViewFilter.Toggled += new System.EventHandler(this.tggViewFilter_Toggled);
            // 
            // gridDetalleProductosCRUD
            // 
            this.gridDetalleProductosCRUD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDetalleProductosCRUD.DataMember = "clase";
            this.gridDetalleProductosCRUD.DataSource = this.dsProductoTerminado1;
            this.gridDetalleProductosCRUD.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridDetalleProductosCRUD.Location = new System.Drawing.Point(2, 80);
            this.gridDetalleProductosCRUD.MainView = this.gridView1;
            this.gridDetalleProductosCRUD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridDetalleProductosCRUD.Name = "gridDetalleProductosCRUD";
            this.gridDetalleProductosCRUD.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdEditar2,
            this.cmdReceta2,
            this.reposClases});
            this.gridDetalleProductosCRUD.Size = new System.Drawing.Size(779, 437);
            this.gridDetalleProductosCRUD.TabIndex = 23;
            this.gridDetalleProductosCRUD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_clase,
            this.colid_familia,
            this.colnombre,
            this.colcodigo,
            this.colfamilia,
            this.colcodFamilia,
            this.gridColumn1,
            this.colenable});
            this.gridView1.GridControl = this.gridDetalleProductosCRUD;
            this.gridView1.LevelIndent = 0;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 685;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.PreviewIndent = 0;
            // 
            // colid_clase
            // 
            this.colid_clase.FieldName = "id_clase";
            this.colid_clase.Name = "colid_clase";
            this.colid_clase.OptionsColumn.ReadOnly = true;
            // 
            // colid_familia
            // 
            this.colid_familia.FieldName = "id_categoria";
            this.colid_familia.Name = "colid_familia";
            this.colid_familia.OptionsColumn.ReadOnly = true;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Clase";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.ReadOnly = true;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 226;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Cod. Clase";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.ReadOnly = true;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            this.colcodigo.Width = 89;
            // 
            // colfamilia
            // 
            this.colfamilia.Caption = "Categoria";
            this.colfamilia.FieldName = "categoria";
            this.colfamilia.Name = "colfamilia";
            this.colfamilia.OptionsColumn.ReadOnly = true;
            this.colfamilia.Visible = true;
            this.colfamilia.VisibleIndex = 3;
            this.colfamilia.Width = 197;
            // 
            // colcodFamilia
            // 
            this.colcodFamilia.Caption = "Cod. Categoaria";
            this.colcodFamilia.FieldName = "codCategoria";
            this.colcodFamilia.Name = "colcodFamilia";
            this.colcodFamilia.Visible = true;
            this.colcodFamilia.VisibleIndex = 2;
            this.colcodFamilia.Width = 118;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Editar";
            this.gridColumn1.ColumnEdit = this.cmdEditar2;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 124;
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
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
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
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.Pink;
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdCerrar.ImageOptions.SvgImage")));
            this.cmdCerrar.Location = new System.Drawing.Point(658, 23);
            this.cmdCerrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(101, 42);
            this.cmdCerrar.TabIndex = 21;
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
            this.cmdNuevoPT.Location = new System.Drawing.Point(13, 23);
            this.cmdNuevoPT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdNuevoPT.Name = "cmdNuevoPT";
            this.cmdNuevoPT.Size = new System.Drawing.Size(101, 42);
            this.cmdNuevoPT.TabIndex = 20;
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
            this.labelControl1.Location = new System.Drawing.Point(118, 8);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(536, 26);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Clases de Producto Terminado";
            // 
            // frmMainPTClase
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
            this.Name = "frmMainPTClase";
            this.Text = "Gestion de Clases";
            ((System.ComponentModel.ISupportInitialize)(this.dsProductoTerminado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggViewFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleProductosCRUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdReceta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposClases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsProductoTerminado dsProductoTerminado1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ToggleSwitch tggViewFilter;
        private DevExpress.XtraGrid.GridControl gridDetalleProductosCRUD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEditar2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdReceta2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposClases;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.SimpleButton cmdNuevoPT;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_clase;
        private DevExpress.XtraGrid.Columns.GridColumn colid_familia;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colfamilia;
        private DevExpress.XtraGrid.Columns.GridColumn colcodFamilia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
    }
}