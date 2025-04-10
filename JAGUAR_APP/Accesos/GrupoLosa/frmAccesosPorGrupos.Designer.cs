namespace JAGUAR_PRO.Accesos.GrupoLosa
{
    partial class frmAccesosPorGrupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccesosPorGrupos));
            this.grdAccesos = new DevExpress.XtraGrid.GridControl();
            this.dsAccesos1 = new JAGUAR_PRO.Accesos.dsAccesos();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_ventana = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtGrupo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tsAll = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccesos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsAll.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAccesos
            // 
            this.grdAccesos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAccesos.DataMember = "roles_accesos";
            this.grdAccesos.DataSource = this.dsAccesos1;
            this.grdAccesos.Location = new System.Drawing.Point(1, 56);
            this.grdAccesos.MainView = this.gridView1;
            this.grdAccesos.Name = "grdAccesos";
            this.grdAccesos.Size = new System.Drawing.Size(722, 482);
            this.grdAccesos.TabIndex = 0;
            this.grdAccesos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsAccesos1
            // 
            this.dsAccesos1.DataSetName = "dsAccesos";
            this.dsAccesos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_grupo,
            this.colid_ventana,
            this.coldescripcion,
            this.colcodigo,
            this.gridColumn1});
            this.gridView1.GridControl = this.grdAccesos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Nombre de Acceso";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Seleccionado";
            this.gridColumn1.FieldName = "selected";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // txtGrupo
            // 
            this.txtGrupo.Enabled = false;
            this.txtGrupo.Location = new System.Drawing.Point(203, 26);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtGrupo.Properties.Appearance.Options.UseFont = true;
            this.txtGrupo.Size = new System.Drawing.Size(145, 24);
            this.txtGrupo.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(157, 29);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 17);
            this.labelControl2.TabIndex = 34;
            this.labelControl2.Text = "Grupo:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnGuardar.Appearance.Options.UseBackColor = true;
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnGuardar.Location = new System.Drawing.Point(12, 18);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 32);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(616, 18);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(96, 32);
            this.btnAtras.TabIndex = 36;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(354, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 17);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "Seleccionar Todos";
            // 
            // tsAll
            // 
            this.tsAll.Location = new System.Drawing.Point(467, 26);
            this.tsAll.Name = "tsAll";
            this.tsAll.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tsAll.Properties.Appearance.Options.UseFont = true;
            this.tsAll.Properties.OffText = "No";
            this.tsAll.Properties.OnText = "Si";
            this.tsAll.Size = new System.Drawing.Size(101, 24);
            this.tsAll.TabIndex = 38;
            this.tsAll.Toggled += new System.EventHandler(this.tsAll_Toggled);
            // 
            // frmAccesosPorGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 540);
            this.Controls.Add(this.tsAll);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.grdAccesos);
            this.Name = "frmAccesosPorGrupos";
            this.Text = "Gestion de Accesos";
            ((System.ComponentModel.ISupportInitialize)(this.grdAccesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccesos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsAll.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdAccesos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtGrupo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private dsAccesos dsAccesos1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_grupo;
        private DevExpress.XtraGrid.Columns.GridColumn colid_ventana;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ToggleSwitch tsAll;
    }
}