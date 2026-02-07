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
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gcAcumulados = new DevExpress.XtraGrid.GridControl();
            this.dsReporte1 = new JAGUAR_PRO.RRHH_Planilla.Planilla.Reportes.dsReporte();
            this.gvAcumulados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colempleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_entrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_salida_almuerzo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_entrada_almuerzo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_salida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnCargarDatosAcumulados = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dtFecha = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAcumulados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporte1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAcumulados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(41, 57);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 17);
            this.labelControl5.TabIndex = 43;
            this.labelControl5.Text = "Fecha:";
            // 
            // gcAcumulados
            // 
            this.gcAcumulados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcAcumulados.DataMember = "asistencia_diaria";
            this.gcAcumulados.DataSource = this.dsReporte1;
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
            // dsReporte1
            // 
            this.dsReporte1.DataSetName = "dsReporte";
            this.dsReporte1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvAcumulados
            // 
            this.gvAcumulados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodigo,
            this.colempleado,
            this.colhora_entrada,
            this.colhora_salida_almuerzo,
            this.colhora_entrada_almuerzo,
            this.colhora_salida,
            this.colfecha});
            this.gvAcumulados.GridControl = this.gcAcumulados;
            this.gvAcumulados.Name = "gvAcumulados";
            this.gvAcumulados.OptionsView.ShowAutoFilterRow = true;
            this.gvAcumulados.OptionsView.ShowFooter = true;
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
            // colempleado
            // 
            this.colempleado.Caption = "Empleado";
            this.colempleado.FieldName = "empleado";
            this.colempleado.Name = "colempleado";
            this.colempleado.OptionsColumn.AllowEdit = false;
            this.colempleado.Visible = true;
            this.colempleado.VisibleIndex = 1;
            // 
            // colhora_entrada
            // 
            this.colhora_entrada.Caption = "Hora Entrada";
            this.colhora_entrada.DisplayFormat.FormatString = "{0:t}";
            this.colhora_entrada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colhora_entrada.FieldName = "hora_entrada";
            this.colhora_entrada.Name = "colhora_entrada";
            this.colhora_entrada.OptionsColumn.AllowEdit = false;
            this.colhora_entrada.Visible = true;
            this.colhora_entrada.VisibleIndex = 3;
            // 
            // colhora_salida_almuerzo
            // 
            this.colhora_salida_almuerzo.Caption = "H. Salida Almuerzo";
            this.colhora_salida_almuerzo.DisplayFormat.FormatString = "{0:t}";
            this.colhora_salida_almuerzo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colhora_salida_almuerzo.FieldName = "hora_salida_almuerzo";
            this.colhora_salida_almuerzo.Name = "colhora_salida_almuerzo";
            this.colhora_salida_almuerzo.OptionsColumn.AllowEdit = false;
            this.colhora_salida_almuerzo.Visible = true;
            this.colhora_salida_almuerzo.VisibleIndex = 4;
            // 
            // colhora_entrada_almuerzo
            // 
            this.colhora_entrada_almuerzo.Caption = "H. Entrada Almuerzo";
            this.colhora_entrada_almuerzo.DisplayFormat.FormatString = "{0:t}";
            this.colhora_entrada_almuerzo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colhora_entrada_almuerzo.FieldName = "hora_entrada_almuerzo";
            this.colhora_entrada_almuerzo.Name = "colhora_entrada_almuerzo";
            this.colhora_entrada_almuerzo.OptionsColumn.AllowEdit = false;
            this.colhora_entrada_almuerzo.Visible = true;
            this.colhora_entrada_almuerzo.VisibleIndex = 5;
            // 
            // colhora_salida
            // 
            this.colhora_salida.Caption = "Hora Salida";
            this.colhora_salida.DisplayFormat.FormatString = "{0:t}";
            this.colhora_salida.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colhora_salida.FieldName = "hora_salida";
            this.colhora_salida.Name = "colhora_salida";
            this.colhora_salida.OptionsColumn.AllowEdit = false;
            this.colhora_salida.Visible = true;
            this.colhora_salida.VisibleIndex = 6;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.DisplayFormat.FormatString = "{0:d}";
            this.colfecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 2;
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
            this.btnCargarDatosAcumulados.Location = new System.Drawing.Point(359, 46);
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
            this.simpleButton1.Location = new System.Drawing.Point(533, 46);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(137, 39);
            this.simpleButton1.TabIndex = 47;
            this.simpleButton1.Text = "Imprimir";
            this.simpleButton1.Visible = false;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dtFecha
            // 
            this.dtFecha.EditValue = null;
            this.dtFecha.Location = new System.Drawing.Point(83, 54);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtFecha.Properties.Appearance.Options.UseFont = true;
            this.dtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Size = new System.Drawing.Size(192, 24);
            this.dtFecha.TabIndex = 76;
            // 
            // frmAsistenciaDiaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 697);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnCargarDatosAcumulados);
            this.Controls.Add(this.gcAcumulados);
            this.Controls.Add(this.labelControl5);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmAsistenciaDiaria";
            this.Text = "Asistencia Diaria";
            ((System.ComponentModel.ISupportInitialize)(this.gcAcumulados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporte1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAcumulados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.GridControl gcAcumulados;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAcumulados;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEliminar;
        private DevExpress.XtraEditors.SimpleButton btnCargarDatosAcumulados;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DateEdit dtFecha;
        private Planilla.Reportes.dsReporte dsReporte1;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colempleado;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_entrada;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_salida_almuerzo;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_entrada_almuerzo;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_salida;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
    }
}