namespace JAGUAR_PRO.RRHH_Planilla.Planilla.Ausencias
{
    partial class frmAusenciasGestionRpt
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            this.grdAusencias = new DevExpress.XtraGrid.GridControl();
            this.dsInasistencias1 = new JAGUAR_PRO.RRHH_Planilla.Planilla.Ausencias.dsInasistencias();
            this.gvAusencias = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemployee_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_from = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_to = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_return = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumber_of_days = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartment_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_ausencia_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdTipoAusencia = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaplicar_planilla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposBtnAnular = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAusencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInasistencias1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAusencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoAusencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposBtnAnular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAusencias
            // 
            this.grdAusencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAusencias.DataMember = "ausencias_gestion";
            this.grdAusencias.DataSource = this.dsInasistencias1;
            this.grdAusencias.Location = new System.Drawing.Point(0, 71);
            this.grdAusencias.MainView = this.gvAusencias;
            this.grdAusencias.Name = "grdAusencias";
            this.grdAusencias.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.grdTipoAusencia,
            this.reposBtnAnular});
            this.grdAusencias.Size = new System.Drawing.Size(1192, 542);
            this.grdAusencias.TabIndex = 1;
            this.grdAusencias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAusencias});
            // 
            // dsInasistencias1
            // 
            this.dsInasistencias1.DataSetName = "dsInasistencias";
            this.dsInasistencias1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvAusencias
            // 
            this.gvAusencias.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colemployee_id,
            this.colcode,
            this.coldate_from,
            this.colid1,
            this.coldate_to,
            this.coldate_return,
            this.colnumber_of_days,
            this.coldepartment_id,
            this.coldepartment,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.coltipo_ausencia_id,
            this.colaplicar_planilla,
            this.colusuario,
            this.colid_estado,
            this.colestado,
            this.gridColumn5});
            this.gvAusencias.GridControl = this.grdAusencias;
            this.gvAusencias.Name = "gvAusencias";
            this.gvAusencias.OptionsView.ShowAutoFilterRow = true;
            this.gvAusencias.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "holiday_status_id";
            this.colid.Name = "colid";
            this.colid.Width = 100;
            // 
            // colemployee_id
            // 
            this.colemployee_id.FieldName = "employee_id";
            this.colemployee_id.Name = "colemployee_id";
            this.colemployee_id.Width = 63;
            // 
            // colcode
            // 
            this.colcode.Caption = "Código";
            this.colcode.FieldName = "codigo";
            this.colcode.Name = "colcode";
            this.colcode.OptionsColumn.AllowEdit = false;
            this.colcode.OptionsColumn.ReadOnly = true;
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 1;
            this.colcode.Width = 48;
            // 
            // coldate_from
            // 
            this.coldate_from.Caption = "Fecha Inicio";
            this.coldate_from.FieldName = "date_from";
            this.coldate_from.Name = "coldate_from";
            this.coldate_from.OptionsColumn.AllowEdit = false;
            this.coldate_from.Visible = true;
            this.coldate_from.VisibleIndex = 4;
            this.coldate_from.Width = 95;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            this.colid1.Width = 63;
            // 
            // coldate_to
            // 
            this.coldate_to.Caption = "Fecha Fin";
            this.coldate_to.FieldName = "date_to";
            this.coldate_to.Name = "coldate_to";
            this.coldate_to.OptionsColumn.AllowEdit = false;
            this.coldate_to.Visible = true;
            this.coldate_to.VisibleIndex = 5;
            this.coldate_to.Width = 95;
            // 
            // coldate_return
            // 
            this.coldate_return.Caption = "F. de Registro";
            this.coldate_return.FieldName = "create_date";
            this.coldate_return.Name = "coldate_return";
            this.coldate_return.OptionsColumn.AllowEdit = false;
            this.coldate_return.Visible = true;
            this.coldate_return.VisibleIndex = 11;
            this.coldate_return.Width = 77;
            // 
            // colnumber_of_days
            // 
            this.colnumber_of_days.Caption = "Dias Solicitados";
            this.colnumber_of_days.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colnumber_of_days.FieldName = "number_of_days";
            this.colnumber_of_days.Name = "colnumber_of_days";
            this.colnumber_of_days.OptionsColumn.AllowEdit = false;
            this.colnumber_of_days.Visible = true;
            this.colnumber_of_days.VisibleIndex = 6;
            this.colnumber_of_days.Width = 76;
            // 
            // coldepartment_id
            // 
            this.coldepartment_id.FieldName = "department_id";
            this.coldepartment_id.Name = "coldepartment_id";
            this.coldepartment_id.OptionsColumn.AllowEdit = false;
            // 
            // coldepartment
            // 
            this.coldepartment.Caption = "Departamento";
            this.coldepartment.FieldName = "departamento";
            this.coldepartment.Name = "coldepartment";
            this.coldepartment.OptionsColumn.AllowEdit = false;
            this.coldepartment.OptionsColumn.ReadOnly = true;
            this.coldepartment.Visible = true;
            this.coldepartment.VisibleIndex = 3;
            this.coldepartment.Width = 95;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Nombre";
            this.gridColumn1.FieldName = "nombre";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 147;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Puesto";
            this.gridColumn2.FieldName = "puesto";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Width = 102;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nota";
            this.gridColumn3.FieldName = "notes";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 7;
            this.gridColumn3.Width = 132;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tipo Ausencia";
            this.gridColumn4.FieldName = "tipo_ausencia";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 107;
            // 
            // coltipo_ausencia_id
            // 
            this.coltipo_ausencia_id.Caption = "Tipo Ausencia";
            this.coltipo_ausencia_id.ColumnEdit = this.grdTipoAusencia;
            this.coltipo_ausencia_id.FieldName = "holiday_status_id";
            this.coltipo_ausencia_id.Name = "coltipo_ausencia_id";
            this.coltipo_ausencia_id.OptionsColumn.AllowEdit = false;
            this.coltipo_ausencia_id.Width = 82;
            // 
            // grdTipoAusencia
            // 
            this.grdTipoAusencia.AutoHeight = false;
            this.grdTipoAusencia.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdTipoAusencia.DisplayMember = "name";
            this.grdTipoAusencia.Name = "grdTipoAusencia";
            this.grdTipoAusencia.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.grdTipoAusencia.ValueMember = "id";
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colname
            // 
            this.colname.Caption = "Tipo de Ausencia";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            // 
            // colaplicar_planilla
            // 
            this.colaplicar_planilla.Caption = "Aplica en Planilla";
            this.colaplicar_planilla.FieldName = "aplicar_planilla";
            this.colaplicar_planilla.Name = "colaplicar_planilla";
            this.colaplicar_planilla.OptionsColumn.AllowEdit = false;
            this.colaplicar_planilla.Visible = true;
            this.colaplicar_planilla.VisibleIndex = 8;
            this.colaplicar_planilla.Width = 82;
            // 
            // colusuario
            // 
            this.colusuario.Caption = "Creador por";
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            this.colusuario.OptionsColumn.AllowEdit = false;
            this.colusuario.Visible = true;
            this.colusuario.VisibleIndex = 10;
            this.colusuario.Width = 66;
            // 
            // colid_estado
            // 
            this.colid_estado.FieldName = "id_estado";
            this.colid_estado.Name = "colid_estado";
            this.colid_estado.OptionsColumn.AllowEdit = false;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.AllowEdit = false;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 9;
            this.colestado.Width = 64;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Anular";
            this.gridColumn5.ColumnEdit = this.reposBtnAnular;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 12;
            this.gridColumn5.Width = 83;
            // 
            // reposBtnAnular
            // 
            this.reposBtnAnular.AutoHeight = false;
            editorButtonImageOptions1.Image = global::JAGUAR_PRO.Properties.Resources.cancel_16x16;
            this.reposBtnAnular.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposBtnAnular.Name = "reposBtnAnular";
            this.reposBtnAnular.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposBtnAnular.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposBtnAnular_ButtonClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = global::JAGUAR_PRO.Properties.Resources.cancel_32x32;
            this.btnCancelar.Location = new System.Drawing.Point(1080, 25);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 39);
            toolTipTitleItem1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            toolTipTitleItem1.Text = "<b>Boton para Agregar Ausencias Masivas</b>";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.btnCancelar.SuperTip = superToolTip1;
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = global::JAGUAR_PRO.Properties.Resources.refresh_24x24;
            this.simpleButton1.Location = new System.Drawing.Point(215, 25);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 39);
            toolTipTitleItem2.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            toolTipTitleItem2.Text = "<b>Boton para Agregar Ausencias Masivas</b>";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.simpleButton1.SuperTip = superToolTip2;
            this.simpleButton1.TabIndex = 32;
            this.simpleButton1.Text = "Actualizar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Hasta:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Desde:";
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(76, 41);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.Properties.Appearance.Options.UseFont = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Size = new System.Drawing.Size(121, 22);
            this.dtHasta.TabIndex = 34;
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(76, 18);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Properties.Appearance.Options.UseFont = true;
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Size = new System.Drawing.Size(121, 22);
            this.dtDesde.TabIndex = 33;
            // 
            // frmAusenciasGestionRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 614);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grdAusencias);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmAusenciasGestionRpt";
            this.Text = "Gestion de Ausencias";
            ((System.ComponentModel.ISupportInitialize)(this.grdAusencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInasistencias1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAusencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoAusencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposBtnAnular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdAusencias;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAusencias;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_from;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_to;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_return;
        private DevExpress.XtraGrid.Columns.GridColumn colnumber_of_days;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartment_id;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartment;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_ausencia_id;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit grdTipoAusencia;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private dsInasistencias dsInasistencias1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colemployee_id;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colaplicar_planilla;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposBtnAnular;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
    }
}