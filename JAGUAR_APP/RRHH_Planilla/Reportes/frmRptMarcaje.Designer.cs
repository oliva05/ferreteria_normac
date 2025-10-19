﻿namespace JAGUAR_PRO.RRHH_Planilla.Reportes
{
    partial class frmRptMarcaje
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptMarcaje));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.TabGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.gcBreak = new DevExpress.XtraGrid.GridControl();
            this.dsReporte1 = new JAGUAR_PRO.RRHH_Planilla.Planilla.Reportes.dsReporte();
            this.gvBreak = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_employee1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarcode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_cerrada1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tipo_marca1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_marca1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.CargarDatos = new DevExpress.XtraEditors.SimpleButton();
            this.cmdExportar = new DevExpress.XtraEditors.SimpleButton();
            this.TabByEmpleado = new DevExpress.XtraTab.XtraTabPage();
            this.deFechaFinal = new DevExpress.XtraEditors.DateEdit();
            this.deFechaInicial = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.grdEmployee = new DevExpress.XtraEditors.GridLookUpEdit();
            this.getemployeeactiveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcat_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCambiarImagen = new System.Windows.Forms.Button();
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
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnCargarDatosAcumulados = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportarAcumulados = new DevExpress.XtraEditors.SimpleButton();
            this.dsReporte1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.TabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBreak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporte1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBreak)).BeginInit();
            this.TabByEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getemployeeactiveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAcumulados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAcumulados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporte1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.TabGeneral;
            this.xtraTabControl1.Size = new System.Drawing.Size(1366, 703);
            this.xtraTabControl1.TabIndex = 25;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabGeneral,
            this.TabByEmpleado});
            this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
            // 
            // TabGeneral
            // 
            this.TabGeneral.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabGeneral.Appearance.Header.Options.UseFont = true;
            this.TabGeneral.Controls.Add(this.dtHasta);
            this.TabGeneral.Controls.Add(this.dtDesde);
            this.TabGeneral.Controls.Add(this.gcBreak);
            this.TabGeneral.Controls.Add(this.labelControl1);
            this.TabGeneral.Controls.Add(this.labelControl2);
            this.TabGeneral.Controls.Add(this.CargarDatos);
            this.TabGeneral.Controls.Add(this.cmdExportar);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.Size = new System.Drawing.Size(1364, 670);
            this.TabGeneral.Text = "Reporte de General";
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(418, 39);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtHasta.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.dtHasta.Properties.Appearance.Options.UseFont = true;
            this.dtHasta.Properties.Appearance.Options.UseForeColor = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dtHasta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtHasta.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dtHasta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtHasta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtHasta.Size = new System.Drawing.Size(214, 26);
            this.dtHasta.TabIndex = 25;
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(119, 39);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtDesde.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.dtDesde.Properties.Appearance.Options.UseFont = true;
            this.dtDesde.Properties.Appearance.Options.UseForeColor = true;
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dtDesde.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtDesde.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dtDesde.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtDesde.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtDesde.Size = new System.Drawing.Size(214, 26);
            this.dtDesde.TabIndex = 24;
            // 
            // gcBreak
            // 
            this.gcBreak.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcBreak.DataMember = "get_marcas_empleado";
            this.gcBreak.DataSource = this.dsReporte1;
            this.gcBreak.Location = new System.Drawing.Point(3, 104);
            this.gcBreak.MainView = this.gvBreak;
            this.gcBreak.Name = "gcBreak";
            this.gcBreak.Size = new System.Drawing.Size(1362, 566);
            this.gcBreak.TabIndex = 23;
            this.gcBreak.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBreak});
            // 
            // dsReporte1
            // 
            this.dsReporte1.DataSetName = "dsReporte";
            this.dsReporte1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvBreak
            // 
            this.gvBreak.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_employee1,
            this.colbarcode1,
            this.colnombre,
            this.colfecha,
            this.colhora_cerrada1,
            this.colid_tipo_marca1,
            this.coltipo_marca1});
            this.gvBreak.GridControl = this.gcBreak;
            this.gvBreak.Name = "gvBreak";
            this.gvBreak.OptionsView.ShowAutoFilterRow = true;
            this.gvBreak.OptionsView.ShowFooter = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // colid_employee1
            // 
            this.colid_employee1.FieldName = "id_employee";
            this.colid_employee1.Name = "colid_employee1";
            this.colid_employee1.OptionsColumn.ReadOnly = true;
            // 
            // colbarcode1
            // 
            this.colbarcode1.Caption = "Codigo";
            this.colbarcode1.FieldName = "barcode";
            this.colbarcode1.Name = "colbarcode1";
            this.colbarcode1.OptionsColumn.ReadOnly = true;
            this.colbarcode1.Visible = true;
            this.colbarcode1.VisibleIndex = 0;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Empleado";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.ReadOnly = true;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha y Hora";
            this.colfecha.DisplayFormat.FormatString = "g";
            this.colfecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 2;
            // 
            // colhora_cerrada1
            // 
            this.colhora_cerrada1.Caption = "Pocesado";
            this.colhora_cerrada1.FieldName = "hora_cerrada";
            this.colhora_cerrada1.Name = "colhora_cerrada1";
            this.colhora_cerrada1.OptionsColumn.ReadOnly = true;
            this.colhora_cerrada1.Visible = true;
            this.colhora_cerrada1.VisibleIndex = 4;
            // 
            // colid_tipo_marca1
            // 
            this.colid_tipo_marca1.FieldName = "id_tipo_marca";
            this.colid_tipo_marca1.Name = "colid_tipo_marca1";
            this.colid_tipo_marca1.OptionsColumn.ReadOnly = true;
            // 
            // coltipo_marca1
            // 
            this.coltipo_marca1.Caption = "Tipo de Marca";
            this.coltipo_marca1.FieldName = "tipo_marca";
            this.coltipo_marca1.Name = "coltipo_marca1";
            this.coltipo_marca1.OptionsColumn.ReadOnly = true;
            this.coltipo_marca1.Visible = true;
            this.coltipo_marca1.VisibleIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(36, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 17);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Fecha Desde:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(339, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 17);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Fecha Hasta:";
            // 
            // CargarDatos
            // 
            this.CargarDatos.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargarDatos.Appearance.Options.UseFont = true;
            this.CargarDatos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CargarDatos.ImageOptions.Image")));
            this.CargarDatos.Location = new System.Drawing.Point(657, 33);
            this.CargarDatos.Name = "CargarDatos";
            this.CargarDatos.Size = new System.Drawing.Size(137, 39);
            this.CargarDatos.TabIndex = 18;
            this.CargarDatos.Text = "Cargar Datos";
            this.CargarDatos.Click += new System.EventHandler(this.CargarDatos_Click);
            // 
            // cmdExportar
            // 
            this.cmdExportar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportar.Appearance.Options.UseFont = true;
            this.cmdExportar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdExportar.ImageOptions.Image")));
            this.cmdExportar.Location = new System.Drawing.Point(800, 33);
            this.cmdExportar.Name = "cmdExportar";
            this.cmdExportar.Size = new System.Drawing.Size(116, 39);
            this.cmdExportar.TabIndex = 19;
            this.cmdExportar.Text = "Exportar";
            this.cmdExportar.Visible = false;
            // 
            // TabByEmpleado
            // 
            this.TabByEmpleado.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.TabByEmpleado.Appearance.Header.Options.UseFont = true;
            this.TabByEmpleado.Controls.Add(this.deFechaFinal);
            this.TabByEmpleado.Controls.Add(this.deFechaInicial);
            this.TabByEmpleado.Controls.Add(this.labelControl3);
            this.TabByEmpleado.Controls.Add(this.grdEmployee);
            this.TabByEmpleado.Controls.Add(this.btnCambiarImagen);
            this.TabByEmpleado.Controls.Add(this.gcAcumulados);
            this.TabByEmpleado.Controls.Add(this.labelControl5);
            this.TabByEmpleado.Controls.Add(this.labelControl6);
            this.TabByEmpleado.Controls.Add(this.btnCargarDatosAcumulados);
            this.TabByEmpleado.Controls.Add(this.btnExportarAcumulados);
            this.TabByEmpleado.Name = "TabByEmpleado";
            this.TabByEmpleado.Size = new System.Drawing.Size(1364, 670);
            this.TabByEmpleado.Text = "Reporte por Empleado";
            // 
            // deFechaFinal
            // 
            this.deFechaFinal.EditValue = null;
            this.deFechaFinal.Location = new System.Drawing.Point(433, 67);
            this.deFechaFinal.Name = "deFechaFinal";
            this.deFechaFinal.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.deFechaFinal.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.deFechaFinal.Properties.Appearance.Options.UseFont = true;
            this.deFechaFinal.Properties.Appearance.Options.UseForeColor = true;
            this.deFechaFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaFinal.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.deFechaFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaFinal.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.deFechaFinal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deFechaFinal.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.deFechaFinal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deFechaFinal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deFechaFinal.Size = new System.Drawing.Size(214, 26);
            this.deFechaFinal.TabIndex = 43;
            // 
            // deFechaInicial
            // 
            this.deFechaInicial.EditValue = null;
            this.deFechaInicial.Location = new System.Drawing.Point(117, 67);
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
            this.deFechaInicial.TabIndex = 42;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(34, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 17);
            this.labelControl3.TabIndex = 41;
            this.labelControl3.Text = "Empleado";
            // 
            // grdEmployee
            // 
            this.grdEmployee.Location = new System.Drawing.Point(117, 28);
            this.grdEmployee.Name = "grdEmployee";
            this.grdEmployee.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdEmployee.Properties.Appearance.Options.UseFont = true;
            this.grdEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdEmployee.Properties.DataSource = this.getemployeeactiveBindingSource;
            this.grdEmployee.Properties.DisplayMember = "concat_";
            this.grdEmployee.Properties.NullText = "";
            this.grdEmployee.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdEmployee.Properties.ValueMember = "id";
            this.grdEmployee.Size = new System.Drawing.Size(370, 24);
            this.grdEmployee.TabIndex = 40;
            // 
            // getemployeeactiveBindingSource
            // 
            this.getemployeeactiveBindingSource.DataMember = "get_employee_active";
            this.getemployeeactiveBindingSource.DataSource = this.dsReporte1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid2,
            this.colconcat_});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid2
            // 
            this.colid2.FieldName = "id";
            this.colid2.Name = "colid2";
            // 
            // colconcat_
            // 
            this.colconcat_.Caption = "Nombre Completo";
            this.colconcat_.FieldName = "concat_";
            this.colconcat_.Name = "colconcat_";
            this.colconcat_.Visible = true;
            this.colconcat_.VisibleIndex = 0;
            // 
            // btnCambiarImagen
            // 
            this.btnCambiarImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCambiarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarImagen.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarImagen.Image = global::JAGUAR_PRO.Properties.Resources._click_32X32;
            this.btnCambiarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCambiarImagen.Location = new System.Drawing.Point(1030, 40);
            this.btnCambiarImagen.Name = "btnCambiarImagen";
            this.btnCambiarImagen.Size = new System.Drawing.Size(137, 39);
            this.btnCambiarImagen.TabIndex = 39;
            this.btnCambiarImagen.Text = "Marca Manual";
            this.btnCambiarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCambiarImagen.UseVisualStyleBackColor = true;
            this.btnCambiarImagen.Click += new System.EventHandler(this.btnCambiarImagen_Click);
            // 
            // gcAcumulados
            // 
            this.gcAcumulados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcAcumulados.DataMember = "get_marcas_by_empleado";
            this.gcAcumulados.DataSource = this.dsReporte1;
            this.gcAcumulados.Location = new System.Drawing.Point(1, 99);
            this.gcAcumulados.MainView = this.gvAcumulados;
            this.gcAcumulados.Name = "gcAcumulados";
            this.gcAcumulados.Size = new System.Drawing.Size(1362, 566);
            this.gcAcumulados.TabIndex = 31;
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
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(34, 72);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(77, 17);
            this.labelControl5.TabIndex = 24;
            this.labelControl5.Text = "Fecha Desde:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(354, 72);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(73, 17);
            this.labelControl6.TabIndex = 25;
            this.labelControl6.Text = "Fecha Hasta:";
            // 
            // btnCargarDatosAcumulados
            // 
            this.btnCargarDatosAcumulados.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDatosAcumulados.Appearance.Options.UseFont = true;
            this.btnCargarDatosAcumulados.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarDatosAcumulados.ImageOptions.Image")));
            this.btnCargarDatosAcumulados.Location = new System.Drawing.Point(878, 40);
            this.btnCargarDatosAcumulados.Name = "btnCargarDatosAcumulados";
            this.btnCargarDatosAcumulados.Size = new System.Drawing.Size(137, 39);
            this.btnCargarDatosAcumulados.TabIndex = 26;
            this.btnCargarDatosAcumulados.Text = "Cargar Datos";
            this.btnCargarDatosAcumulados.Click += new System.EventHandler(this.btnCargarDatosAcumulados_Click);
            // 
            // btnExportarAcumulados
            // 
            this.btnExportarAcumulados.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarAcumulados.Appearance.Options.UseFont = true;
            this.btnExportarAcumulados.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarAcumulados.ImageOptions.Image")));
            this.btnExportarAcumulados.Location = new System.Drawing.Point(1186, 40);
            this.btnExportarAcumulados.Name = "btnExportarAcumulados";
            this.btnExportarAcumulados.Size = new System.Drawing.Size(116, 39);
            this.btnExportarAcumulados.TabIndex = 27;
            this.btnExportarAcumulados.Text = "Exportar";
            this.btnExportarAcumulados.Visible = false;
            this.btnExportarAcumulados.Click += new System.EventHandler(this.btnExportarAcumulados_Click);
            // 
            // dsReporte1BindingSource
            // 
            this.dsReporte1BindingSource.DataSource = this.dsReporte1;
            this.dsReporte1BindingSource.Position = 0;
            // 
            // frmRptMarcaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 703);
            this.Controls.Add(this.xtraTabControl1);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmRptMarcaje";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.TabGeneral.ResumeLayout(false);
            this.TabGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBreak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporte1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBreak)).EndInit();
            this.TabByEmpleado.ResumeLayout(false);
            this.TabByEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getemployeeactiveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAcumulados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAcumulados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporte1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage TabGeneral;
        private DevExpress.XtraGrid.GridControl gcBreak;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBreak;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton CargarDatos;
        private DevExpress.XtraEditors.SimpleButton cmdExportar;
        private DevExpress.XtraTab.XtraTabPage TabByEmpleado;
        private DevExpress.XtraGrid.GridControl gcAcumulados;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAcumulados;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnCargarDatosAcumulados;
        private DevExpress.XtraEditors.SimpleButton btnExportarAcumulados;
        private System.Windows.Forms.Button btnCambiarImagen;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GridLookUpEdit grdEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private Planilla.Reportes.dsReporte dsReporte1;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_employee;
        private DevExpress.XtraGrid.Columns.GridColumn colbarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre1;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha1;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_cerrada;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo_marca;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_marca;
        private System.Windows.Forms.BindingSource getemployeeactiveBindingSource;
        private System.Windows.Forms.BindingSource dsReporte1BindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_employee1;
        private DevExpress.XtraGrid.Columns.GridColumn colbarcode1;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_cerrada1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo_marca1;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_marca1;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.DateEdit deFechaFinal;
        private DevExpress.XtraEditors.DateEdit deFechaInicial;
        private DevExpress.XtraGrid.Columns.GridColumn colid2;
        private DevExpress.XtraGrid.Columns.GridColumn colconcat_;
    }
}