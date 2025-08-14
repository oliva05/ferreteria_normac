namespace JAGUAR_PRO.Mantenimientos.Comisiones
{
    partial class frmListaVendedores
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmdCancelare = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsComisiones1 = new JAGUAR_PRO.Mantenimientos.Comisiones.dsComisiones();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_vendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.chkSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.chk_Seleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComisiones1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdSeleccionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_Seleccionar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 30);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(164, 20);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "Seleccione un vendedor";
            // 
            // cmdCancelare
            // 
            this.cmdCancelare.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.cmdCancelare.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelare.Appearance.Options.UseBackColor = true;
            this.cmdCancelare.Appearance.Options.UseFont = true;
            this.cmdCancelare.Location = new System.Drawing.Point(425, 26);
            this.cmdCancelare.Name = "cmdCancelare";
            this.cmdCancelare.Size = new System.Drawing.Size(96, 29);
            this.cmdCancelare.TabIndex = 26;
            this.cmdCancelare.Text = "Cancelar";
            this.cmdCancelare.Click += new System.EventHandler(this.cmdCancelare_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(324, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 29);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "vendedores_lista";
            this.gridControl1.DataSource = this.dsComisiones1;
            this.gridControl1.Location = new System.Drawing.Point(1, 61);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdSeleccionar,
            this.chkSeleccionar,
            this.chk_Seleccionar});
            this.gridControl1.Size = new System.Drawing.Size(520, 265);
            this.gridControl1.TabIndex = 27;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsComisiones1
            // 
            this.dsComisiones1.DataSetName = "dsComisiones";
            this.dsComisiones1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcodigo_vendedor,
            this.colnombre,
            this.colseleccionar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // colcodigo_vendedor
            // 
            this.colcodigo_vendedor.FieldName = "codigo_vendedor";
            this.colcodigo_vendedor.Name = "colcodigo_vendedor";
            this.colcodigo_vendedor.OptionsColumn.ReadOnly = true;
            this.colcodigo_vendedor.Visible = true;
            this.colcodigo_vendedor.VisibleIndex = 0;
            this.colcodigo_vendedor.Width = 90;
            // 
            // colnombre
            // 
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.ReadOnly = true;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 303;
            // 
            // colseleccionar
            // 
            this.colseleccionar.FieldName = "seleccionar";
            this.colseleccionar.Name = "colseleccionar";
            this.colseleccionar.Visible = true;
            this.colseleccionar.VisibleIndex = 2;
            // 
            // cmdSeleccionar
            // 
            this.cmdSeleccionar.AutoHeight = false;
            this.cmdSeleccionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cmdSeleccionar.Name = "cmdSeleccionar";
            // 
            // chkSeleccionar
            // 
            this.chkSeleccionar.AutoHeight = false;
            this.chkSeleccionar.Caption = "Seleccionar";
            this.chkSeleccionar.Name = "chkSeleccionar";
            // 
            // chk_Seleccionar
            // 
            this.chk_Seleccionar.AutoHeight = false;
            this.chk_Seleccionar.Name = "chk_Seleccionar";
            this.chk_Seleccionar.CheckedChanged += new System.EventHandler(this.chk_Seleccionar_CheckedChanged);
            // 
            // frmListaVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 329);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cmdCancelare);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl3);
            this.Name = "frmListaVendedores";
            this.Text = "Seleccione un Vendedor";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComisiones1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdSeleccionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_Seleccionar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton cmdCancelare;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsComisiones dsComisiones1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_vendedor;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdSeleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chk_Seleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkSeleccionar;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionar;
    }
}