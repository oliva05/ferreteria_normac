namespace JAGUAR_PRO.Facturacion.Deposito
{
    partial class frmDepositoBancoOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepositoBancoOP));
            this.gleCuentaBanco = new DevExpress.XtraEditors.GridLookUpEdit();
            this.cuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRegistroPagos1 = new JAGUAR_PRO.Facturacion.CoreFacturas.dsRegistroPagos();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label31 = new System.Windows.Forms.Label();
            this.gleBancoDeposito = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bancoslistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label30 = new System.Windows.Forms.Label();
            this.lblTituloVentana = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdGuardarGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.txtValorTransferencia = new DevExpress.XtraEditors.CalcEdit();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.txtComentario = new DevExpress.XtraEditors.MemoEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroDeposito = new System.Windows.Forms.Label();
            this.lblEnable = new System.Windows.Forms.Label();
            this.tggEnable = new DevExpress.XtraEditors.ToggleSwitch();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFechaDeposito = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gleCuentaBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRegistroPagos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleBancoDeposito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoslistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorTransferencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggEnable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDeposito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDeposito.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // gleCuentaBanco
            // 
            this.gleCuentaBanco.Location = new System.Drawing.Point(213, 106);
            this.gleCuentaBanco.Name = "gleCuentaBanco";
            this.gleCuentaBanco.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.gleCuentaBanco.Properties.Appearance.Options.UseFont = true;
            this.gleCuentaBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleCuentaBanco.Properties.DataSource = this.cuentasBindingSource;
            this.gleCuentaBanco.Properties.DisplayMember = "num_cuenta";
            this.gleCuentaBanco.Properties.NullText = "";
            this.gleCuentaBanco.Properties.PopupView = this.gridView3;
            this.gleCuentaBanco.Properties.ValueMember = "id_cuenta";
            this.gleCuentaBanco.Size = new System.Drawing.Size(195, 28);
            this.gleCuentaBanco.TabIndex = 21;
            // 
            // cuentasBindingSource
            // 
            this.cuentasBindingSource.DataMember = "cuentas";
            this.cuentasBindingSource.DataSource = this.dsRegistroPagos1;
            // 
            // dsRegistroPagos1
            // 
            this.dsRegistroPagos1.DataSetName = "dsRegistroPagos";
            this.dsRegistroPagos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.colmoneda});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "id_cuenta";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Elija la Cuenta";
            this.gridColumn4.FieldName = "num_cuenta";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // colmoneda
            // 
            this.colmoneda.Caption = "Moneda";
            this.colmoneda.FieldName = "moneda";
            this.colmoneda.Name = "colmoneda";
            this.colmoneda.Visible = true;
            this.colmoneda.VisibleIndex = 1;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(40, 113);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(64, 21);
            this.label31.TabIndex = 64;
            this.label31.Text = "Cuenta";
            // 
            // gleBancoDeposito
            // 
            this.gleBancoDeposito.Location = new System.Drawing.Point(213, 72);
            this.gleBancoDeposito.Name = "gleBancoDeposito";
            this.gleBancoDeposito.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.gleBancoDeposito.Properties.Appearance.Options.UseFont = true;
            this.gleBancoDeposito.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleBancoDeposito.Properties.DataSource = this.bancoslistBindingSource;
            this.gleBancoDeposito.Properties.DisplayMember = "descripcion";
            this.gleBancoDeposito.Properties.NullText = "";
            this.gleBancoDeposito.Properties.PopupView = this.gridView2;
            this.gleBancoDeposito.Properties.ValueMember = "id";
            this.gleBancoDeposito.Size = new System.Drawing.Size(195, 28);
            this.gleBancoDeposito.TabIndex = 20;
            this.gleBancoDeposito.EditValueChanged += new System.EventHandler(this.gleBancoDeposito_EditValueChanged);
            this.gleBancoDeposito.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gleBancoDeposito_KeyDown);
            // 
            // bancoslistBindingSource
            // 
            this.bancoslistBindingSource.DataMember = "bancos_list";
            this.bancoslistBindingSource.DataSource = this.dsRegistroPagos1;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Elija el Banco";
            this.gridColumn2.FieldName = "descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(40, 79);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(57, 21);
            this.label30.TabIndex = 62;
            this.label30.Text = "Banco";
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTituloVentana.AutoSize = true;
            this.lblTituloVentana.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloVentana.Location = new System.Drawing.Point(340, 9);
            this.lblTituloVentana.Name = "lblTituloVentana";
            this.lblTituloVentana.Size = new System.Drawing.Size(169, 25);
            this.lblTituloVentana.TabIndex = 66;
            this.lblTituloVentana.Text = "Generar Deposito";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(40, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 21);
            this.label12.TabIndex = 68;
            this.label12.Text = "Formato";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.txtReferencia.Location = new System.Drawing.Point(213, 174);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(195, 29);
            this.txtReferencia.TabIndex = 23;
            this.txtReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(40, 182);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 21);
            this.label17.TabIndex = 70;
            this.label17.Text = "Num. Referencia";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(40, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 21);
            this.label13.TabIndex = 69;
            this.label13.Text = "Valor de Deposito";
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdCerrar.Appearance.BorderColor = System.Drawing.Color.LightGray;
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseBorderColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(472, 290);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(120, 46);
            this.cmdCerrar.TabIndex = 74;
            this.cmdCerrar.Text = "Salir";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // cmdGuardarGenerar
            // 
            this.cmdGuardarGenerar.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdGuardarGenerar.Appearance.BorderColor = System.Drawing.Color.LightGray;
            this.cmdGuardarGenerar.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cmdGuardarGenerar.Appearance.Options.UseBackColor = true;
            this.cmdGuardarGenerar.Appearance.Options.UseBorderColor = true;
            this.cmdGuardarGenerar.Appearance.Options.UseFont = true;
            this.cmdGuardarGenerar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardarGenerar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.cmdGuardarGenerar.Location = new System.Drawing.Point(302, 290);
            this.cmdGuardarGenerar.Name = "cmdGuardarGenerar";
            this.cmdGuardarGenerar.Size = new System.Drawing.Size(120, 46);
            this.cmdGuardarGenerar.TabIndex = 73;
            this.cmdGuardarGenerar.Text = "Generar";
            this.cmdGuardarGenerar.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // txtValorTransferencia
            // 
            this.txtValorTransferencia.Location = new System.Drawing.Point(213, 140);
            this.txtValorTransferencia.Name = "txtValorTransferencia";
            this.txtValorTransferencia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.txtValorTransferencia.Properties.Appearance.Options.UseFont = true;
            this.txtValorTransferencia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtValorTransferencia.Properties.MaskSettings.Set("mask", "n");
            this.txtValorTransferencia.Properties.NullValuePrompt = "0.00";
            this.txtValorTransferencia.Properties.ShowNullValuePrompt = DevExpress.XtraEditors.ShowNullValuePromptOptions.EmptyValue;
            this.txtValorTransferencia.Properties.UseMaskAsDisplayFormat = true;
            this.txtValorTransferencia.Size = new System.Drawing.Size(195, 28);
            this.txtValorTransferencia.TabIndex = 22;
            // 
            // radioGroup1
            // 
            this.radioGroup1.EditValue = 1;
            this.radioGroup1.Location = new System.Drawing.Point(213, 209);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup1.Properties.Appearance.Options.UseFont = true;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "3.5 pulg. cinta"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "8x11.5 pulg. Carta", false)});
            this.radioGroup1.Size = new System.Drawing.Size(195, 61);
            this.radioGroup1.TabIndex = 77;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(602, 78);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.txtComentario.Properties.Appearance.Options.UseFont = true;
            this.txtComentario.Size = new System.Drawing.Size(248, 117);
            this.txtComentario.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(443, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 80;
            this.label2.Text = "Comentario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 81;
            this.label1.Text = "Depósito No.";
            // 
            // lblNumeroDeposito
            // 
            this.lblNumeroDeposito.AutoSize = true;
            this.lblNumeroDeposito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDeposito.Location = new System.Drawing.Point(209, 47);
            this.lblNumeroDeposito.Name = "lblNumeroDeposito";
            this.lblNumeroDeposito.Size = new System.Drawing.Size(0, 21);
            this.lblNumeroDeposito.TabIndex = 82;
            // 
            // lblEnable
            // 
            this.lblEnable.AutoSize = true;
            this.lblEnable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEnable.Location = new System.Drawing.Point(443, 209);
            this.lblEnable.Name = "lblEnable";
            this.lblEnable.Size = new System.Drawing.Size(136, 21);
            this.lblEnable.TabIndex = 83;
            this.lblEnable.Text = "Depósito Activo:";
            this.lblEnable.Visible = false;
            // 
            // tggEnable
            // 
            this.tggEnable.EditValue = true;
            this.tggEnable.Location = new System.Drawing.Point(602, 209);
            this.tggEnable.Name = "tggEnable";
            this.tggEnable.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tggEnable.Properties.Appearance.Options.UseFont = true;
            this.tggEnable.Properties.OffText = "No";
            this.tggEnable.Properties.OnText = "Si";
            this.tggEnable.Size = new System.Drawing.Size(95, 24);
            this.tggEnable.TabIndex = 84;
            this.tggEnable.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 21);
            this.label3.TabIndex = 85;
            this.label3.Text = "Fecha del depósito";
            // 
            // dtFechaDeposito
            // 
            this.dtFechaDeposito.EditValue = null;
            this.dtFechaDeposito.Location = new System.Drawing.Point(602, 242);
            this.dtFechaDeposito.Name = "dtFechaDeposito";
            this.dtFechaDeposito.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.dtFechaDeposito.Properties.Appearance.Options.UseFont = true;
            this.dtFechaDeposito.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDeposito.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDeposito.Size = new System.Drawing.Size(248, 28);
            this.dtFechaDeposito.TabIndex = 86;
            // 
            // frmDepositoBancoOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 342);
            this.Controls.Add(this.dtFechaDeposito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tggEnable);
            this.Controls.Add(this.lblEnable);
            this.Controls.Add(this.lblNumeroDeposito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.radioGroup1);
            this.Controls.Add(this.txtValorTransferencia);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdGuardarGenerar);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblTituloVentana);
            this.Controls.Add(this.gleCuentaBanco);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.gleBancoDeposito);
            this.Controls.Add(this.label30);
            this.Name = "frmDepositoBancoOP";
            ((System.ComponentModel.ISupportInitialize)(this.gleCuentaBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRegistroPagos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleBancoDeposito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoslistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorTransferencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggEnable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDeposito.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDeposito.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit gleCuentaBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.Label label31;
        private DevExpress.XtraEditors.GridLookUpEdit gleBancoDeposito;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblTituloVentana;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.SimpleButton cmdGuardarGenerar;
        private CoreFacturas.dsRegistroPagos dsRegistroPagos1;
        private System.Windows.Forms.BindingSource cuentasBindingSource;
        private System.Windows.Forms.BindingSource bancoslistBindingSource;
        private DevExpress.XtraEditors.CalcEdit txtValorTransferencia;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.MemoEdit txtComentario;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn colmoneda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumeroDeposito;
        private System.Windows.Forms.Label lblEnable;
        private DevExpress.XtraEditors.ToggleSwitch tggEnable;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit dtFechaDeposito;
    }
}