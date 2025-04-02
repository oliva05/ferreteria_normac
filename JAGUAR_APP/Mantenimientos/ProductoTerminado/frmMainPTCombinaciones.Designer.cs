namespace JAGUAR_PRO.Mantenimientos.ProductoTerminado
{
    partial class frmMainPTCombinaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPTCombinaciones));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridDetalleProductosCRUD = new DevExpress.XtraGrid.GridControl();
            this.dsProductoTerminado1 = new JAGUAR_PRO.Mantenimientos.ProductoTerminado.dsProductoTerminado();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_row = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFamilia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubClase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEditar2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdReceta2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.reposClases = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleProductosCRUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductoTerminado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdReceta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposClases)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDetalleProductosCRUD
            // 
            this.gridDetalleProductosCRUD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDetalleProductosCRUD.DataMember = "pt_combinaciones_generadas";
            this.gridDetalleProductosCRUD.DataSource = this.dsProductoTerminado1;
            this.gridDetalleProductosCRUD.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridDetalleProductosCRUD.Location = new System.Drawing.Point(1, 72);
            this.gridDetalleProductosCRUD.MainView = this.gridView1;
            this.gridDetalleProductosCRUD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridDetalleProductosCRUD.Name = "gridDetalleProductosCRUD";
            this.gridDetalleProductosCRUD.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdEditar2,
            this.cmdReceta2,
            this.reposClases});
            this.gridDetalleProductosCRUD.Size = new System.Drawing.Size(1046, 637);
            this.gridDetalleProductosCRUD.TabIndex = 25;
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
            this.colid_row,
            this.colFamilia,
            this.colCategoria,
            this.colClase,
            this.colSubClase,
            this.colCodigo});
            this.gridView1.GridControl = this.gridDetalleProductosCRUD;
            this.gridView1.LevelIndent = 0;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 685;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.PreviewIndent = 0;
            // 
            // colid_row
            // 
            this.colid_row.FieldName = "id_row";
            this.colid_row.Name = "colid_row";
            this.colid_row.OptionsColumn.ReadOnly = true;
            // 
            // colFamilia
            // 
            this.colFamilia.FieldName = "Familia";
            this.colFamilia.Name = "colFamilia";
            this.colFamilia.OptionsColumn.ReadOnly = true;
            this.colFamilia.Visible = true;
            this.colFamilia.VisibleIndex = 0;
            // 
            // colCategoria
            // 
            this.colCategoria.FieldName = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.OptionsColumn.ReadOnly = true;
            this.colCategoria.Visible = true;
            this.colCategoria.VisibleIndex = 1;
            // 
            // colClase
            // 
            this.colClase.FieldName = "Clase";
            this.colClase.Name = "colClase";
            this.colClase.OptionsColumn.ReadOnly = true;
            this.colClase.Visible = true;
            this.colClase.VisibleIndex = 2;
            // 
            // colSubClase
            // 
            this.colSubClase.FieldName = "SubClase";
            this.colSubClase.Name = "colSubClase";
            this.colSubClase.OptionsColumn.ReadOnly = true;
            this.colSubClase.Visible = true;
            this.colSubClase.VisibleIndex = 3;
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.OptionsColumn.ReadOnly = true;
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 4;
            // 
            // cmdEditar2
            // 
            this.cmdEditar2.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdEditar2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEditar2.Name = "cmdEditar2";
            this.cmdEditar2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
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
            this.cmdCerrar.Location = new System.Drawing.Point(924, 15);
            this.cmdCerrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(101, 42);
            this.cmdCerrar.TabIndex = 24;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // frmMainPTCombinaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 711);
            this.Controls.Add(this.gridDetalleProductosCRUD);
            this.Controls.Add(this.cmdCerrar);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmMainPTCombinaciones";
            this.Text = "Combinacion de Codigos";
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleProductosCRUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductoTerminado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdReceta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposClases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridDetalleProductosCRUD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEditar2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdReceta2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposClases;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private dsProductoTerminado dsProductoTerminado1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_row;
        private DevExpress.XtraGrid.Columns.GridColumn colFamilia;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn colClase;
        private DevExpress.XtraGrid.Columns.GridColumn colSubClase;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
    }
}