namespace JAGUAR_PRO.RRHH_Planilla.Mantenimientos
{
    partial class frmPlanillaConf_IHSS
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAnio = new DevExpress.XtraEditors.TextEdit();
            this.grdConfigIHSS = new DevExpress.XtraGrid.GridControl();
            this.grdvConfigIHSS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dsMantenimientoPlanilla1 = new JAGUAR_PRO.RRHH_Planilla.Mantenimientos.dsMantenimientoPlanilla();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltecho_ivm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltecho_em = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltecho_rp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colporcentaje_ivm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colporcentaje_em = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colporcentaje_rp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colporcentaje_afp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposComboTipo = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConfigIHSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvConfigIHSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoPlanilla1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposComboTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(189, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 17);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Año:";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(224, 52);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnio.Properties.Appearance.Options.UseFont = true;
            this.txtAnio.Properties.Appearance.Options.UseTextOptions = true;
            this.txtAnio.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtAnio.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtAnio.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtAnio.Properties.MaskSettings.Set("mask", "d");
            this.txtAnio.Size = new System.Drawing.Size(130, 24);
            this.txtAnio.TabIndex = 2;
            // 
            // grdConfigIHSS
            // 
            this.grdConfigIHSS.DataMember = "hr_ihss_detalle";
            this.grdConfigIHSS.DataSource = this.dsMantenimientoPlanilla1;
            this.grdConfigIHSS.Location = new System.Drawing.Point(1, 115);
            this.grdConfigIHSS.MainView = this.grdvConfigIHSS;
            this.grdConfigIHSS.Name = "grdConfigIHSS";
            this.grdConfigIHSS.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposComboTipo});
            this.grdConfigIHSS.Size = new System.Drawing.Size(577, 241);
            this.grdConfigIHSS.TabIndex = 4;
            this.grdConfigIHSS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvConfigIHSS});
            // 
            // grdvConfigIHSS
            // 
            this.grdvConfigIHSS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colyear,
            this.coltecho_ivm,
            this.coltecho_em,
            this.coltipo,
            this.coltecho_rp,
            this.colporcentaje_ivm,
            this.colporcentaje_em,
            this.colporcentaje_rp,
            this.colporcentaje_afp});
            this.grdvConfigIHSS.GridControl = this.grdConfigIHSS;
            this.grdvConfigIHSS.Name = "grdvConfigIHSS";
            this.grdvConfigIHSS.OptionsView.ShowGroupPanel = false;
            // 
            // dsMantenimientoPlanilla1
            // 
            this.dsMantenimientoPlanilla1.DataSetName = "dsMantenimientoPlanilla";
            this.dsMantenimientoPlanilla1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colyear
            // 
            this.colyear.FieldName = "year";
            this.colyear.Name = "colyear";
            // 
            // coltecho_ivm
            // 
            this.coltecho_ivm.Caption = "Techo IVM";
            this.coltecho_ivm.DisplayFormat.FormatString = "{0:#,###,##0.00} Lps";
            this.coltecho_ivm.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltecho_ivm.FieldName = "techo_ivm";
            this.coltecho_ivm.Name = "coltecho_ivm";
            this.coltecho_ivm.Visible = true;
            this.coltecho_ivm.VisibleIndex = 0;
            // 
            // coltecho_em
            // 
            this.coltecho_em.Caption = "Techo EM";
            this.coltecho_em.DisplayFormat.FormatString = "{0:#,###,##0.00} Lps";
            this.coltecho_em.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltecho_em.FieldName = "techo_em";
            this.coltecho_em.Name = "coltecho_em";
            this.coltecho_em.Visible = true;
            this.coltecho_em.VisibleIndex = 1;
            // 
            // coltipo
            // 
            this.coltipo.Caption = "Tipo";
            this.coltipo.ColumnEdit = this.reposComboTipo;
            this.coltipo.FieldName = "tipo";
            this.coltipo.Name = "coltipo";
            this.coltipo.Visible = true;
            this.coltipo.VisibleIndex = 2;
            // 
            // coltecho_rp
            // 
            this.coltecho_rp.Caption = "Techo RP";
            this.coltecho_rp.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.coltecho_rp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltecho_rp.FieldName = "techo_rp";
            this.coltecho_rp.Name = "coltecho_rp";
            this.coltecho_rp.Visible = true;
            this.coltecho_rp.VisibleIndex = 3;
            // 
            // colporcentaje_ivm
            // 
            this.colporcentaje_ivm.Caption = "% IVM";
            this.colporcentaje_ivm.DisplayFormat.FormatString = "{0:###,##0.00}";
            this.colporcentaje_ivm.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colporcentaje_ivm.FieldName = "porcentaje_ivm";
            this.colporcentaje_ivm.Name = "colporcentaje_ivm";
            this.colporcentaje_ivm.Visible = true;
            this.colporcentaje_ivm.VisibleIndex = 4;
            // 
            // colporcentaje_em
            // 
            this.colporcentaje_em.Caption = "% EM";
            this.colporcentaje_em.DisplayFormat.FormatString = "{0:###,##0.00}";
            this.colporcentaje_em.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colporcentaje_em.FieldName = "porcentaje_em";
            this.colporcentaje_em.Name = "colporcentaje_em";
            this.colporcentaje_em.Visible = true;
            this.colporcentaje_em.VisibleIndex = 5;
            // 
            // colporcentaje_rp
            // 
            this.colporcentaje_rp.Caption = "% RP";
            this.colporcentaje_rp.DisplayFormat.FormatString = "{0:###,##0.00}";
            this.colporcentaje_rp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colporcentaje_rp.FieldName = "porcentaje_rp";
            this.colporcentaje_rp.Name = "colporcentaje_rp";
            this.colporcentaje_rp.Visible = true;
            this.colporcentaje_rp.VisibleIndex = 6;
            // 
            // colporcentaje_afp
            // 
            this.colporcentaje_afp.Caption = "% AFP";
            this.colporcentaje_afp.DisplayFormat.FormatString = "{0:###,##0.00}";
            this.colporcentaje_afp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colporcentaje_afp.FieldName = "porcentaje_afp";
            this.colporcentaje_afp.Name = "colporcentaje_afp";
            this.colporcentaje_afp.Visible = true;
            this.colporcentaje_afp.VisibleIndex = 7;
            // 
            // reposComboTipo
            // 
            this.reposComboTipo.AutoHeight = false;
            this.reposComboTipo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reposComboTipo.Items.AddRange(new object[] {
            "Trabajadores",
            "Patronal"});
            this.reposComboTipo.Name = "reposComboTipo";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = global::JAGUAR_PRO.Properties.Resources.cancel_24x24;
            this.simpleButton2.Location = new System.Drawing.Point(471, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(96, 46);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Cancelar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = global::JAGUAR_PRO.Properties.Resources.save_24x24;
            this.btnSave.Location = new System.Drawing.Point(12, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 46);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmPlanillaConf_IHSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 358);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grdConfigIHSS);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtAnio);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmPlanillaConf_IHSS";
            this.Text = "Configuracion de IHSS";
            ((System.ComponentModel.ISupportInitialize)(this.txtAnio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConfigIHSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvConfigIHSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoPlanilla1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposComboTipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtAnio;
        private DevExpress.XtraGrid.GridControl grdConfigIHSS;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvConfigIHSS;
        private dsMantenimientoPlanilla dsMantenimientoPlanilla1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colyear;
        private DevExpress.XtraGrid.Columns.GridColumn coltecho_ivm;
        private DevExpress.XtraGrid.Columns.GridColumn coltecho_em;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox reposComboTipo;
        private DevExpress.XtraGrid.Columns.GridColumn coltecho_rp;
        private DevExpress.XtraGrid.Columns.GridColumn colporcentaje_ivm;
        private DevExpress.XtraGrid.Columns.GridColumn colporcentaje_em;
        private DevExpress.XtraGrid.Columns.GridColumn colporcentaje_rp;
        private DevExpress.XtraGrid.Columns.GridColumn colporcentaje_afp;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}