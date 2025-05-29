
namespace JAGUAR_PRO.Accesos.GrupoLosa
{
    partial class PrincipalGrupoLosa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalGrupoLosa));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdAccesos = new DevExpress.XtraGrid.GridControl();
            this.dsAccesos1 = new JAGUAR_PRO.Accesos.dsAccesos();
            this.gvAccesos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_ventana = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlGruposJAGUAR_PRO = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Habilitado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposAdd = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccesos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAccesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGruposJAGUAR_PRO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposEditar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1082, 619);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdAccesos);
            this.panel1.Controls.Add(this.gridControlGruposJAGUAR_PRO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(23, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 516);
            this.panel1.TabIndex = 0;
            // 
            // grdAccesos
            // 
            this.grdAccesos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAccesos.DataMember = "roles_accesos";
            this.grdAccesos.DataSource = this.dsAccesos1;
            this.grdAccesos.Location = new System.Drawing.Point(644, 0);
            this.grdAccesos.MainView = this.gvAccesos;
            this.grdAccesos.Name = "grdAccesos";
            this.grdAccesos.Size = new System.Drawing.Size(392, 516);
            this.grdAccesos.TabIndex = 2;
            this.grdAccesos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAccesos});
            // 
            // dsAccesos1
            // 
            this.dsAccesos1.DataSetName = "dsAccesos";
            this.dsAccesos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvAccesos
            // 
            this.gvAccesos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_grupo,
            this.colid_ventana,
            this.colcodigo,
            this.coldescripcion});
            this.gvAccesos.GridControl = this.grdAccesos;
            this.gvAccesos.Name = "gvAccesos";
            this.gvAccesos.OptionsView.ShowAutoFilterRow = true;
            this.gvAccesos.OptionsView.ShowGroupPanel = false;
            this.gvAccesos.OptionsView.ShowViewCaption = true;
            this.gvAccesos.ViewCaption = "Accesos por Defecto";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colid_grupo
            // 
            this.colid_grupo.FieldName = "id_grupo";
            this.colid_grupo.Name = "colid_grupo";
            this.colid_grupo.OptionsColumn.AllowEdit = false;
            // 
            // colid_ventana
            // 
            this.colid_ventana.FieldName = "id_ventana";
            this.colid_ventana.Name = "colid_ventana";
            this.colid_ventana.OptionsColumn.AllowEdit = false;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 1;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Acceso";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // gridControlGruposJAGUAR_PRO
            // 
            this.gridControlGruposJAGUAR_PRO.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridControlGruposJAGUAR_PRO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlGruposJAGUAR_PRO.Location = new System.Drawing.Point(0, 0);
            this.gridControlGruposJAGUAR_PRO.MainView = this.gridView1;
            this.gridControlGruposJAGUAR_PRO.Name = "gridControlGruposJAGUAR_PRO";
            this.gridControlGruposJAGUAR_PRO.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposAdd,
            this.reposEditar});
            this.gridControlGruposJAGUAR_PRO.Size = new System.Drawing.Size(638, 516);
            this.gridControlGruposJAGUAR_PRO.TabIndex = 1;
            this.gridControlGruposJAGUAR_PRO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Grupo,
            this.Habilitado,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControlGruposJAGUAR_PRO;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Grupos";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "id";
            this.Id.Name = "Id";
            this.Id.OptionsColumn.AllowEdit = false;
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            this.Id.Width = 57;
            // 
            // Grupo
            // 
            this.Grupo.Caption = "Grupo";
            this.Grupo.FieldName = "grupo";
            this.Grupo.Name = "Grupo";
            this.Grupo.OptionsColumn.AllowEdit = false;
            this.Grupo.Visible = true;
            this.Grupo.VisibleIndex = 1;
            this.Grupo.Width = 177;
            // 
            // Habilitado
            // 
            this.Habilitado.Caption = "Habilitado";
            this.Habilitado.FieldName = "enable";
            this.Habilitado.Name = "Habilitado";
            this.Habilitado.OptionsColumn.AllowEdit = false;
            this.Habilitado.Visible = true;
            this.Habilitado.VisibleIndex = 2;
            this.Habilitado.Width = 153;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Agregar Accesos";
            this.gridColumn1.ColumnEdit = this.reposAdd;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 129;
            // 
            // reposAdd
            // 
            this.reposAdd.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.reposAdd.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposAdd.Name = "reposAdd";
            this.reposAdd.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposAdd.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposAdd_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Editar";
            this.gridColumn2.ColumnEdit = this.reposEditar;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 95;
            // 
            // reposEditar
            // 
            this.reposEditar.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.reposEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposEditar.Name = "reposEditar";
            this.reposEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposEditar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposEditar_ButtonClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdCerrar);
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(23, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1036, 71);
            this.panel2.TabIndex = 1;
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(932, 32);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(98, 36);
            this.cmdCerrar.TabIndex = 36;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.MediumAquamarine;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(7, 32);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(98, 36);
            this.simpleButton2.TabIndex = 31;
            this.simpleButton2.Text = "Nuevo";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
            // 
            // PrincipalGrupoLosa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 619);
            this.Controls.Add(this.tableLayoutPanel1);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.Name = "PrincipalGrupoLosa";
            this.Text = "Gestion Grupos y Accesos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAccesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccesos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAccesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGruposJAGUAR_PRO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposEditar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlGruposJAGUAR_PRO;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Grupo;
        private DevExpress.XtraGrid.Columns.GridColumn Habilitado;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl grdAccesos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAccesos;
        private dsAccesos dsAccesos1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_grupo;
        private DevExpress.XtraGrid.Columns.GridColumn colid_ventana;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposAdd;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposEditar;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
    }
}

