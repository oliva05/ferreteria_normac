namespace JAGUAR_PRO.RRHH_Planilla.Reportes
{
    partial class frmAsistenciaDiaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsistenciaDiaria));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.deFechaInicial = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gcAcumulados = new DevExpress.XtraGrid.GridControl();
            this.gvAcumulados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_employee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_cerrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tipo_marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnCargarDatosAcumulados = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAcumulados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAcumulados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // deFechaInicial
            // 
            this.deFechaInicial.EditValue = null;
            this.deFechaInicial.Location = new System.Drawing.Point(124, 52);
            this.deFechaInicial.Name = "deFechaInicial";
            this.deFechaInicial.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.deFechaInicial.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.deFechaInicial.Properties.Appearance.Options.UseFont = true;
            this.deFechaInicial.Properties.Appearance.Options.UseForeColor = true;
            this.deFechaInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaInicial.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.deFechaInicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaInicial.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.deFechaInicial.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deFechaInicial.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.deFechaInicial.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deFechaInicial.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deFechaInicial.Size = new System.Drawing.Size(214, 26);
            this.deFechaInicial.TabIndex = 44;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(41, 57);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(77, 17);
            this.labelControl5.TabIndex = 43;
            this.labelControl5.Text = "Fecha Desde:";
            // 
            // gcAcumulados
            // 
            this.gcAcumulados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcAcumulados.DataMember = "get_marcas_by_empleado";
            this.gcAcumulados.Location = new System.Drawing.Point(3, 124);
            this.gcAcumulados.MainView = this.gvAcumulados;
            this.gcAcumulados.Name = "gcAcumulados";
            this.gcAcumulados.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdEliminar});
            this.gcAcumulados.Size = new System.Drawing.Size(1408, 571);
            this.gcAcumulados.TabIndex = 45;
            this.gcAcumulados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAcumulados});
            // 
            // gvAcumulados
            // 
            this.gvAcumulados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colid_employee,
            this.colbarcode,
            this.colnombre1,
            this.colfecha1,
            this.colhora_cerrada,
            this.colid_tipo_marca,
            this.coltipo_marca});
            this.gvAcumulados.GridControl = this.gcAcumulados;
            this.gvAcumulados.Name = "gvAcumulados";
            this.gvAcumulados.OptionsView.ShowAutoFilterRow = true;
            this.gvAcumulados.OptionsView.ShowFooter = true;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            this.colid1.OptionsColumn.ReadOnly = true;
            // 
            // colid_employee
            // 
            this.colid_employee.FieldName = "id_employee";
            this.colid_employee.Name = "colid_employee";
            this.colid_employee.OptionsColumn.ReadOnly = true;
            // 
            // colbarcode
            // 
            this.colbarcode.Caption = "Codigo";
            this.colbarcode.FieldName = "barcode";
            this.colbarcode.Name = "colbarcode";
            this.colbarcode.OptionsColumn.ReadOnly = true;
            this.colbarcode.Visible = true;
            this.colbarcode.VisibleIndex = 0;
            // 
            // colnombre1
            // 
            this.colnombre1.Caption = "Empleado";
            this.colnombre1.FieldName = "nombre";
            this.colnombre1.Name = "colnombre1";
            this.colnombre1.OptionsColumn.ReadOnly = true;
            this.colnombre1.Visible = true;
            this.colnombre1.VisibleIndex = 1;
            // 
            // colfecha1
            // 
            this.colfecha1.Caption = "Fecha y Hora";
            this.colfecha1.DisplayFormat.FormatString = "g";
            this.colfecha1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha1.FieldName = "fecha";
            this.colfecha1.Name = "colfecha1";
            this.colfecha1.OptionsColumn.ReadOnly = true;
            this.colfecha1.Visible = true;
            this.colfecha1.VisibleIndex = 2;
            // 
            // colhora_cerrada
            // 
            this.colhora_cerrada.Caption = "Procesado";
            this.colhora_cerrada.FieldName = "hora_cerrada";
            this.colhora_cerrada.Name = "colhora_cerrada";
            this.colhora_cerrada.OptionsColumn.ReadOnly = true;
            this.colhora_cerrada.Visible = true;
            this.colhora_cerrada.VisibleIndex = 3;
            // 
            // colid_tipo_marca
            // 
            this.colid_tipo_marca.FieldName = "id_tipo_marca";
            this.colid_tipo_marca.Name = "colid_tipo_marca";
            this.colid_tipo_marca.OptionsColumn.ReadOnly = true;
            // 
            // coltipo_marca
            // 
            this.coltipo_marca.Caption = "Tipo de Marca";
            this.coltipo_marca.FieldName = "tipo_marca";
            this.coltipo_marca.Name = "coltipo_marca";
            this.coltipo_marca.OptionsColumn.ReadOnly = true;
            this.coltipo_marca.Visible = true;
            this.coltipo_marca.VisibleIndex = 4;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnCargarDatosAcumulados
            // 
            this.btnCargarDatosAcumulados.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDatosAcumulados.Appearance.Options.UseFont = true;
            this.btnCargarDatosAcumulados.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarDatosAcumulados.ImageOptions.Image")));
            this.btnCargarDatosAcumulados.Location = new System.Drawing.Point(378, 46);
            this.btnCargarDatosAcumulados.Name = "btnCargarDatosAcumulados";
            this.btnCargarDatosAcumulados.Size = new System.Drawing.Size(137, 39);
            this.btnCargarDatosAcumulados.TabIndex = 46;
            this.btnCargarDatosAcumulados.Text = "Cargar Datos";
            this.btnCargarDatosAcumulados.Click += new System.EventHandler(this.btnCargarDatosAcumulados_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = global::JAGUAR_PRO.Properties.Resources.printer_32x32;
            this.simpleButton1.Location = new System.Drawing.Point(547, 46);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(137, 39);
            this.simpleButton1.TabIndex = 47;
            this.simpleButton1.Text = "Imprimir";
            this.simpleButton1.Visible = false;
            // 
            // frmAsistenciaDiaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 697);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnCargarDatosAcumulados);
            this.Controls.Add(this.gcAcumulados);
            this.Controls.Add(this.deFechaInicial);
            this.Controls.Add(this.labelControl5);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmAsistenciaDiaria";
            this.Text = "Asistencia Diaria";
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAcumulados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAcumulados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit deFechaInicial;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.GridControl gcAcumulados;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAcumulados;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_employee;
        private DevExpress.XtraGrid.Columns.GridColumn colbarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre1;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha1;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_cerrada;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo_marca;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_marca;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEliminar;
        private DevExpress.XtraEditors.SimpleButton btnCargarDatosAcumulados;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}