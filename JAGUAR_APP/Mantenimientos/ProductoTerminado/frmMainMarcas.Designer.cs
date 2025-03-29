namespace JAGUAR_PRO.Mantenimientos.ProductoTerminado
{
    partial class frmMainMarcas
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMarcas));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsProductoTerminado1 = new JAGUAR_PRO.Mantenimientos.ProductoTerminado.dsProductoTerminado();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpais_origen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsitio_web = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_creacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_actualizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_create = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_modi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.tsAll = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductoTerminado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsAll.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "lista_marcas";
            this.gridControl1.DataSource = this.dsProductoTerminado1;
            this.gridControl1.Location = new System.Drawing.Point(3, 86);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposEdit});
            this.gridControl1.Size = new System.Drawing.Size(1176, 462);
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
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_marca,
            this.colnombre,
            this.coldescripcion,
            this.colpais_origen,
            this.colsitio_web,
            this.colfecha_creacion,
            this.colfecha_actualizacion,
            this.coluser_create,
            this.coluser_modi,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            // 
            // colid_marca
            // 
            this.colid_marca.FieldName = "id_marca";
            this.colid_marca.Name = "colid_marca";
            this.colid_marca.OptionsColumn.ReadOnly = true;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre de la Marca";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.ReadOnly = true;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            this.colnombre.Width = 126;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.ReadOnly = true;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            this.coldescripcion.Width = 174;
            // 
            // colpais_origen
            // 
            this.colpais_origen.Caption = "Pais Origen";
            this.colpais_origen.FieldName = "pais_origen";
            this.colpais_origen.Name = "colpais_origen";
            this.colpais_origen.OptionsColumn.ReadOnly = true;
            this.colpais_origen.Visible = true;
            this.colpais_origen.VisibleIndex = 2;
            // 
            // colsitio_web
            // 
            this.colsitio_web.Caption = "Sitio Web";
            this.colsitio_web.FieldName = "sitio_web";
            this.colsitio_web.Name = "colsitio_web";
            this.colsitio_web.OptionsColumn.ReadOnly = true;
            this.colsitio_web.Visible = true;
            this.colsitio_web.VisibleIndex = 3;
            this.colsitio_web.Width = 182;
            // 
            // colfecha_creacion
            // 
            this.colfecha_creacion.Caption = "Fecha Creacion";
            this.colfecha_creacion.FieldName = "fecha_creacion";
            this.colfecha_creacion.Name = "colfecha_creacion";
            this.colfecha_creacion.OptionsColumn.ReadOnly = true;
            this.colfecha_creacion.Visible = true;
            this.colfecha_creacion.VisibleIndex = 4;
            // 
            // colfecha_actualizacion
            // 
            this.colfecha_actualizacion.Caption = "Fecha Modificacion";
            this.colfecha_actualizacion.FieldName = "fecha_actualizacion";
            this.colfecha_actualizacion.Name = "colfecha_actualizacion";
            this.colfecha_actualizacion.OptionsColumn.ReadOnly = true;
            this.colfecha_actualizacion.Visible = true;
            this.colfecha_actualizacion.VisibleIndex = 5;
            // 
            // coluser_create
            // 
            this.coluser_create.Caption = "Creado por:";
            this.coluser_create.FieldName = "user_create";
            this.coluser_create.Name = "coluser_create";
            this.coluser_create.OptionsColumn.ReadOnly = true;
            this.coluser_create.Visible = true;
            this.coluser_create.VisibleIndex = 6;
            // 
            // coluser_modi
            // 
            this.coluser_modi.Caption = "Modificado por:";
            this.coluser_modi.FieldName = "user_modi";
            this.coluser_modi.Name = "coluser_modi";
            this.coluser_modi.OptionsColumn.ReadOnly = true;
            this.coluser_modi.Visible = true;
            this.coluser_modi.VisibleIndex = 7;
            this.coluser_modi.Width = 118;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Editar";
            this.gridColumn1.ColumnEdit = this.reposEdit;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 134;
            // 
            // reposEdit
            // 
            this.reposEdit.AutoHeight = false;
            editorButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions2.SvgImage")));
            this.reposEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposEdit.Name = "reposEdit";
            this.reposEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposEdit_ButtonClick);
            // 
            // btnNew
            // 
            this.btnNew.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.ImageOptions.Image = global::JAGUAR_PRO.Properties.Resources.save_32x32;
            this.btnNew.Location = new System.Drawing.Point(12, 37);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(101, 43);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Nuevo";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tsAll
            // 
            this.tsAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tsAll.EditValue = true;
            this.tsAll.Location = new System.Drawing.Point(520, 49);
            this.tsAll.Name = "tsAll";
            this.tsAll.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsAll.Properties.Appearance.Options.UseFont = true;
            this.tsAll.Properties.OffText = "No";
            this.tsAll.Properties.OnText = "Si";
            this.tsAll.Size = new System.Drawing.Size(113, 22);
            this.tsAll.TabIndex = 3;
            this.tsAll.Toggled += new System.EventHandler(this.tsAll_Toggled);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(449, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 15);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Solo Activos";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = global::JAGUAR_PRO.Properties.Resources.close32px;
            this.btnClose.Location = new System.Drawing.Point(1069, 37);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 43);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMainMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 550);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tsAll);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.gridControl1);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmMainMarcas";
            this.Text = "Marca de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductoTerminado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsAll.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.ToggleSwitch tsAll;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private dsProductoTerminado dsProductoTerminado1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_marca;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colpais_origen;
        private DevExpress.XtraGrid.Columns.GridColumn colsitio_web;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_creacion;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_actualizacion;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_create;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_modi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposEdit;
    }
}