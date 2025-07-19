namespace JAGUAR_PRO.Facturacion.CoreFacturas
{
    partial class frmPagoFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagoFactura));
            this.tabPagos = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageEfectivo = new DevExpress.XtraTab.XtraTabPage();
            this.ListboxPrintersEfectivo = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdPagar = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEntregado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorEfectivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageTarjeta = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ListboxPrintersTarjeta = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioGroup2 = new DevExpress.XtraEditors.RadioGroup();
            this.txtValorTC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEntregadoTC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPageTransferenciaCliente = new DevExpress.XtraTab.XtraTabPage();
            this.gleCuentaBanco = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bsCuentaBanco = new System.Windows.Forms.BindingSource(this.components);
            this.dsRegistroPagos1 = new JAGUAR_PRO.Facturacion.CoreFacturas.dsRegistroPagos();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_banco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltitular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label31 = new System.Windows.Forms.Label();
            this.txtValorTransferencia = new System.Windows.Forms.TextBox();
            this.gleBancoDeposito = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bsBancosList_Deposito = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label30 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.ListboxPrintersTransferencia = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.label16 = new System.Windows.Forms.Label();
            this.txtValorPagarTransferencia = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.radioGroup3 = new DevExpress.XtraEditors.RadioGroup();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPageCheques = new DevExpress.XtraTab.XtraTabPage();
            this.gleBancosList = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bsBancosList_Cheque = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label29 = new System.Windows.Forms.Label();
            this.txtNombreEmisorCheque = new DevExpress.XtraEditors.MemoEdit();
            this.label28 = new System.Windows.Forms.Label();
            this.txtNumeroCheque = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cmdAgregarPagoCheque = new DevExpress.XtraEditors.SimpleButton();
            this.ListBoxCheque = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.label23 = new System.Windows.Forms.Label();
            this.txtValorPagarChque = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.radioGroup4 = new DevExpress.XtraEditors.RadioGroup();
            this.cmdValorCheque = new DevExpress.XtraEditors.SpinEdit();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.cmdEfectivo = new DevExpress.XtraEditors.SimpleButton();
            this.cmdTarjeta = new DevExpress.XtraEditors.SimpleButton();
            this.cmdDepositoBancario = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colreferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.lblResumenPagosTotal = new System.Windows.Forms.Label();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.label19 = new System.Windows.Forms.Label();
            this.lblTotalPagoRequerido = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.cmdCheque = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabPagos)).BeginInit();
            this.tabPagos.SuspendLayout();
            this.tabPageEfectivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListboxPrintersEfectivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.tabPageTarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListboxPrintersTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup2.Properties)).BeginInit();
            this.tabPageTransferenciaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gleCuentaBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCuentaBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRegistroPagos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleBancoDeposito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBancosList_Deposito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListboxPrintersTransferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup3.Properties)).BeginInit();
            this.tabPageCheques.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gleBancosList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBancosList_Cheque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreEmisorCheque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxCheque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdValorCheque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPagos
            // 
            this.tabPagos.Appearance.BackColor = System.Drawing.Color.White;
            this.tabPagos.Appearance.Options.UseBackColor = true;
            this.tabPagos.Location = new System.Drawing.Point(209, 2);
            this.tabPagos.Name = "tabPagos";
            this.tabPagos.SelectedTabPage = this.tabPageEfectivo;
            this.tabPagos.Size = new System.Drawing.Size(355, 516);
            this.tabPagos.TabIndex = 0;
            this.tabPagos.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageEfectivo,
            this.tabPageTarjeta,
            this.tabPageTransferenciaCliente,
            this.tabPageCheques});
            // 
            // tabPageEfectivo
            // 
            this.tabPageEfectivo.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.tabPageEfectivo.Appearance.PageClient.Options.UseBackColor = true;
            this.tabPageEfectivo.Controls.Add(this.ListboxPrintersEfectivo);
            this.tabPageEfectivo.Controls.Add(this.label6);
            this.tabPageEfectivo.Controls.Add(this.cmdPagar);
            this.tabPageEfectivo.Controls.Add(this.label5);
            this.tabPageEfectivo.Controls.Add(this.radioGroup1);
            this.tabPageEfectivo.Controls.Add(this.txtCambio);
            this.tabPageEfectivo.Controls.Add(this.label4);
            this.tabPageEfectivo.Controls.Add(this.txtEntregado);
            this.tabPageEfectivo.Controls.Add(this.label3);
            this.tabPageEfectivo.Controls.Add(this.txtValorEfectivo);
            this.tabPageEfectivo.Controls.Add(this.label2);
            this.tabPageEfectivo.Controls.Add(this.label1);
            this.tabPageEfectivo.Name = "tabPageEfectivo";
            this.tabPageEfectivo.Size = new System.Drawing.Size(353, 487);
            this.tabPageEfectivo.Text = "Detalles del Pago";
            // 
            // ListboxPrintersEfectivo
            // 
            this.ListboxPrintersEfectivo.CheckMode = DevExpress.XtraEditors.CheckMode.Single;
            this.ListboxPrintersEfectivo.Location = new System.Drawing.Point(115, 203);
            this.ListboxPrintersEfectivo.Name = "ListboxPrintersEfectivo";
            this.ListboxPrintersEfectivo.Size = new System.Drawing.Size(227, 145);
            this.ListboxPrintersEfectivo.TabIndex = 33;
            this.ListboxPrintersEfectivo.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.ListboxPrinters_ItemCheck);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(22, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "Impresora";
            // 
            // cmdPagar
            // 
            this.cmdPagar.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPagar.Appearance.Options.UseFont = true;
            this.cmdPagar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdPagar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdPagar.ImageOptions.Image")));
            this.cmdPagar.Location = new System.Drawing.Point(115, 359);
            this.cmdPagar.Name = "cmdPagar";
            this.cmdPagar.Size = new System.Drawing.Size(130, 45);
            this.cmdPagar.TabIndex = 31;
            this.cmdPagar.Text = "Agregar";
            this.cmdPagar.Click += new System.EventHandler(this.cmdPagar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(35, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "Formato";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(115, 136);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup1.Properties.Appearance.Options.UseFont = true;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "3.5 pulg. cinta"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "8x11.5 pulg. Carta")});
            this.radioGroup1.Size = new System.Drawing.Size(227, 61);
            this.radioGroup1.TabIndex = 29;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // txtCambio
            // 
            this.txtCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Location = new System.Drawing.Point(115, 101);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(227, 29);
            this.txtCambio.TabIndex = 28;
            this.txtCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(40, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cambio";
            // 
            // txtEntregado
            // 
            this.txtEntregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntregado.Location = new System.Drawing.Point(115, 66);
            this.txtEntregado.Name = "txtEntregado";
            this.txtEntregado.Size = new System.Drawing.Size(227, 29);
            this.txtEntregado.TabIndex = 26;
            this.txtEntregado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEntregado.TextChanged += new System.EventHandler(this.txtEntregado_TextChanged_1);
            this.txtEntregado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEntregado_KeyDown);
            this.txtEntregado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntregado_KeyPress);
            this.txtEntregado.Validated += new System.EventHandler(this.txtEntregado_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(20, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Entregado";
            // 
            // txtValorEfectivo
            // 
            this.txtValorEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorEfectivo.Location = new System.Drawing.Point(115, 31);
            this.txtValorEfectivo.Name = "txtValorEfectivo";
            this.txtValorEfectivo.ReadOnly = true;
            this.txtValorEfectivo.Size = new System.Drawing.Size(227, 29);
            this.txtValorEfectivo.TabIndex = 24;
            this.txtValorEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Pago en Efectivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(59, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Valor";
            // 
            // tabPageTarjeta
            // 
            this.tabPageTarjeta.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.tabPageTarjeta.Appearance.PageClient.Options.UseBackColor = true;
            this.tabPageTarjeta.Controls.Add(this.simpleButton1);
            this.tabPageTarjeta.Controls.Add(this.ListboxPrintersTarjeta);
            this.tabPageTarjeta.Controls.Add(this.label7);
            this.tabPageTarjeta.Controls.Add(this.label8);
            this.tabPageTarjeta.Controls.Add(this.radioGroup2);
            this.tabPageTarjeta.Controls.Add(this.txtValorTC);
            this.tabPageTarjeta.Controls.Add(this.label9);
            this.tabPageTarjeta.Controls.Add(this.txtEntregadoTC);
            this.tabPageTarjeta.Controls.Add(this.label10);
            this.tabPageTarjeta.Controls.Add(this.label11);
            this.tabPageTarjeta.Name = "tabPageTarjeta";
            this.tabPageTarjeta.Size = new System.Drawing.Size(353, 487);
            this.tabPageTarjeta.Text = "Detalles del Pago";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(96, 373);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(147, 45);
            this.simpleButton1.TabIndex = 25;
            this.simpleButton1.Text = "Agregar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ListboxPrintersTarjeta
            // 
            this.ListboxPrintersTarjeta.CheckMode = DevExpress.XtraEditors.CheckMode.Single;
            this.ListboxPrintersTarjeta.Location = new System.Drawing.Point(96, 172);
            this.ListboxPrintersTarjeta.Name = "ListboxPrintersTarjeta";
            this.ListboxPrintersTarjeta.Size = new System.Drawing.Size(236, 176);
            this.ListboxPrintersTarjeta.TabIndex = 24;
            this.ListboxPrintersTarjeta.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.checkedListBoxControl1_ItemCheck);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(5, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Impresora";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(20, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "Formato";
            // 
            // radioGroup2
            // 
            this.radioGroup2.Location = new System.Drawing.Point(96, 105);
            this.radioGroup2.Name = "radioGroup2";
            this.radioGroup2.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup2.Properties.Appearance.Options.UseFont = true;
            this.radioGroup2.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "3.5 pulg. cinta"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "8x11.5 pulg. Carta")});
            this.radioGroup2.Size = new System.Drawing.Size(236, 61);
            this.radioGroup2.TabIndex = 21;
            this.radioGroup2.SelectedIndexChanged += new System.EventHandler(this.radioGroup2_SelectedIndexChanged);
            // 
            // txtValorTC
            // 
            this.txtValorTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTC.Location = new System.Drawing.Point(96, 32);
            this.txtValorTC.Name = "txtValorTC";
            this.txtValorTC.ReadOnly = true;
            this.txtValorTC.Size = new System.Drawing.Size(236, 29);
            this.txtValorTC.TabIndex = 20;
            this.txtValorTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(41, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Valor";
            // 
            // txtEntregadoTC
            // 
            this.txtEntregadoTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntregadoTC.Location = new System.Drawing.Point(96, 67);
            this.txtEntregadoTC.Name = "txtEntregadoTC";
            this.txtEntregadoTC.Size = new System.Drawing.Size(236, 29);
            this.txtEntregadoTC.TabIndex = 18;
            this.txtEntregadoTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEntregadoTC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.txtEntregadoTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntregadoTC_KeyPress);
            this.txtEntregadoTC.Validated += new System.EventHandler(this.txtEntregadoTC_Validated);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(28, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tarjeta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(106, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 24);
            this.label11.TabIndex = 16;
            this.label11.Text = "Pago con Tarjeta";
            // 
            // tabPageTransferenciaCliente
            // 
            this.tabPageTransferenciaCliente.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.tabPageTransferenciaCliente.Appearance.PageClient.Options.UseBackColor = true;
            this.tabPageTransferenciaCliente.Controls.Add(this.gleCuentaBanco);
            this.tabPageTransferenciaCliente.Controls.Add(this.label31);
            this.tabPageTransferenciaCliente.Controls.Add(this.txtValorTransferencia);
            this.tabPageTransferenciaCliente.Controls.Add(this.gleBancoDeposito);
            this.tabPageTransferenciaCliente.Controls.Add(this.label30);
            this.tabPageTransferenciaCliente.Controls.Add(this.txtReferencia);
            this.tabPageTransferenciaCliente.Controls.Add(this.label17);
            this.tabPageTransferenciaCliente.Controls.Add(this.simpleButton2);
            this.tabPageTransferenciaCliente.Controls.Add(this.ListboxPrintersTransferencia);
            this.tabPageTransferenciaCliente.Controls.Add(this.label16);
            this.tabPageTransferenciaCliente.Controls.Add(this.txtValorPagarTransferencia);
            this.tabPageTransferenciaCliente.Controls.Add(this.label12);
            this.tabPageTransferenciaCliente.Controls.Add(this.radioGroup3);
            this.tabPageTransferenciaCliente.Controls.Add(this.label13);
            this.tabPageTransferenciaCliente.Controls.Add(this.label14);
            this.tabPageTransferenciaCliente.Controls.Add(this.label15);
            this.tabPageTransferenciaCliente.Name = "tabPageTransferenciaCliente";
            this.tabPageTransferenciaCliente.Size = new System.Drawing.Size(353, 487);
            this.tabPageTransferenciaCliente.Text = "Detalles del Pago";
            this.tabPageTransferenciaCliente.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPageTransferenciaCliente_Paint);
            // 
            // gleCuentaBanco
            // 
            this.gleCuentaBanco.Location = new System.Drawing.Point(188, 182);
            this.gleCuentaBanco.Name = "gleCuentaBanco";
            this.gleCuentaBanco.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.gleCuentaBanco.Properties.Appearance.Options.UseFont = true;
            this.gleCuentaBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleCuentaBanco.Properties.DataSource = this.bsCuentaBanco;
            this.gleCuentaBanco.Properties.DisplayMember = "cuenta";
            this.gleCuentaBanco.Properties.NullText = "";
            this.gleCuentaBanco.Properties.PopupView = this.gridView3;
            this.gleCuentaBanco.Properties.ValueMember = "id_cuenta";
            this.gleCuentaBanco.Size = new System.Drawing.Size(156, 28);
            this.gleCuentaBanco.TabIndex = 61;
            this.gleCuentaBanco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gleCuentaBanco_KeyDown);
            // 
            // bsCuentaBanco
            // 
            this.bsCuentaBanco.DataMember = "cuentas";
            this.bsCuentaBanco.DataSource = this.dsRegistroPagos1;
            // 
            // dsRegistroPagos1
            // 
            this.dsRegistroPagos1.DataSetName = "dsRegistroPagos";
            this.dsRegistroPagos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_cuenta,
            this.colid_banco,
            this.colcuenta,
            this.coltitular,
            this.colnum_cuenta,
            this.colmoneda});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colid_cuenta
            // 
            this.colid_cuenta.FieldName = "id_cuenta";
            this.colid_cuenta.Name = "colid_cuenta";
            // 
            // colid_banco
            // 
            this.colid_banco.FieldName = "id_banco";
            this.colid_banco.Name = "colid_banco";
            // 
            // colcuenta
            // 
            this.colcuenta.Caption = "Numero de Cuenta";
            this.colcuenta.FieldName = "cuenta";
            this.colcuenta.Name = "colcuenta";
            this.colcuenta.OptionsColumn.ReadOnly = true;
            this.colcuenta.Visible = true;
            this.colcuenta.VisibleIndex = 0;
            // 
            // coltitular
            // 
            this.coltitular.FieldName = "titular";
            this.coltitular.Name = "coltitular";
            // 
            // colnum_cuenta
            // 
            this.colnum_cuenta.FieldName = "num_cuenta";
            this.colnum_cuenta.Name = "colnum_cuenta";
            // 
            // colmoneda
            // 
            this.colmoneda.FieldName = "moneda";
            this.colmoneda.Name = "colmoneda";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(3, 183);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(64, 21);
            this.label31.TabIndex = 60;
            this.label31.Text = "Cuenta";
            // 
            // txtValorTransferencia
            // 
            this.txtValorTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTransferencia.Location = new System.Drawing.Point(188, 72);
            this.txtValorTransferencia.Name = "txtValorTransferencia";
            this.txtValorTransferencia.Size = new System.Drawing.Size(156, 29);
            this.txtValorTransferencia.TabIndex = 59;
            this.txtValorTransferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorTransferencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorTransferencia_KeyDown);
            this.txtValorTransferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorTransferencia_KeyPress);
            this.txtValorTransferencia.Validated += new System.EventHandler(this.txtValorTransferencia_Validated);
            // 
            // gleBancoDeposito
            // 
            this.gleBancoDeposito.Location = new System.Drawing.Point(188, 147);
            this.gleBancoDeposito.Name = "gleBancoDeposito";
            this.gleBancoDeposito.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.gleBancoDeposito.Properties.Appearance.Options.UseFont = true;
            this.gleBancoDeposito.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleBancoDeposito.Properties.DataSource = this.bsBancosList_Deposito;
            this.gleBancoDeposito.Properties.DisplayMember = "descripcion";
            this.gleBancoDeposito.Properties.NullText = "";
            this.gleBancoDeposito.Properties.PopupView = this.gridView2;
            this.gleBancoDeposito.Properties.ValueMember = "id";
            this.gleBancoDeposito.Size = new System.Drawing.Size(156, 28);
            this.gleBancoDeposito.TabIndex = 58;
            this.gleBancoDeposito.EditValueChanged += new System.EventHandler(this.gleBancoDeposito_EditValueChanged);
            this.gleBancoDeposito.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gleBancoDeposito_KeyDown);
            // 
            // bsBancosList_Deposito
            // 
            this.bsBancosList_Deposito.DataMember = "bancos_listDeposito";
            this.bsBancosList_Deposito.DataSource = this.dsRegistroPagos1;
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
            this.label30.Location = new System.Drawing.Point(3, 150);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(57, 21);
            this.label30.TabIndex = 57;
            this.label30.Text = "Banco";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.Location = new System.Drawing.Point(188, 110);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(156, 29);
            this.txtReferencia.TabIndex = 40;
            this.txtReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtReferencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReferencia_KeyDown);
            this.txtReferencia.Validated += new System.EventHandler(this.txtReferencia_Validated);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 21);
            this.label17.TabIndex = 39;
            this.label17.Text = "Referencia";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton2.Appearance.BorderColor = System.Drawing.Color.LightGray;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(98, 429);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(145, 46);
            this.simpleButton2.TabIndex = 38;
            this.simpleButton2.Text = "Agregar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // ListboxPrintersTransferencia
            // 
            this.ListboxPrintersTransferencia.CheckMode = DevExpress.XtraEditors.CheckMode.Single;
            this.ListboxPrintersTransferencia.Location = new System.Drawing.Point(98, 283);
            this.ListboxPrintersTransferencia.Name = "ListboxPrintersTransferencia";
            this.ListboxPrintersTransferencia.Size = new System.Drawing.Size(246, 140);
            this.ListboxPrintersTransferencia.TabIndex = 37;
            this.ListboxPrintersTransferencia.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.checkedListBoxControl2_ItemCheck);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(3, 283);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 21);
            this.label16.TabIndex = 36;
            this.label16.Text = "Impresora";
            // 
            // txtValorPagarTransferencia
            // 
            this.txtValorPagarTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPagarTransferencia.Location = new System.Drawing.Point(188, 37);
            this.txtValorPagarTransferencia.Name = "txtValorPagarTransferencia";
            this.txtValorPagarTransferencia.ReadOnly = true;
            this.txtValorPagarTransferencia.Size = new System.Drawing.Size(156, 29);
            this.txtValorPagarTransferencia.TabIndex = 35;
            this.txtValorPagarTransferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(3, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 21);
            this.label12.TabIndex = 34;
            this.label12.Text = "Formato";
            // 
            // radioGroup3
            // 
            this.radioGroup3.Location = new System.Drawing.Point(188, 216);
            this.radioGroup3.Name = "radioGroup3";
            this.radioGroup3.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup3.Properties.Appearance.Options.UseFont = true;
            this.radioGroup3.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "3.5 pulg. cinta"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "8x11.5 pulg. Carta")});
            this.radioGroup3.Size = new System.Drawing.Size(156, 61);
            this.radioGroup3.TabIndex = 33;
            this.radioGroup3.SelectedIndexChanged += new System.EventHandler(this.radioGroup3_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 21);
            this.label13.TabIndex = 31;
            this.label13.Text = "Valor de Transferencia";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 21);
            this.label14.TabIndex = 30;
            this.label14.Text = "Valor a Pagar";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(74, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(220, 25);
            this.label15.TabIndex = 29;
            this.label15.Text = "Pago con Transferencia";
            // 
            // tabPageCheques
            // 
            this.tabPageCheques.Controls.Add(this.gleBancosList);
            this.tabPageCheques.Controls.Add(this.label29);
            this.tabPageCheques.Controls.Add(this.txtNombreEmisorCheque);
            this.tabPageCheques.Controls.Add(this.label28);
            this.tabPageCheques.Controls.Add(this.txtNumeroCheque);
            this.tabPageCheques.Controls.Add(this.label22);
            this.tabPageCheques.Controls.Add(this.cmdAgregarPagoCheque);
            this.tabPageCheques.Controls.Add(this.ListBoxCheque);
            this.tabPageCheques.Controls.Add(this.label23);
            this.tabPageCheques.Controls.Add(this.txtValorPagarChque);
            this.tabPageCheques.Controls.Add(this.label24);
            this.tabPageCheques.Controls.Add(this.radioGroup4);
            this.tabPageCheques.Controls.Add(this.cmdValorCheque);
            this.tabPageCheques.Controls.Add(this.label25);
            this.tabPageCheques.Controls.Add(this.label26);
            this.tabPageCheques.Controls.Add(this.label27);
            this.tabPageCheques.Name = "tabPageCheques";
            this.tabPageCheques.Size = new System.Drawing.Size(353, 487);
            this.tabPageCheques.Text = "Detalles del Pago";
            // 
            // gleBancosList
            // 
            this.gleBancosList.Location = new System.Drawing.Point(169, 100);
            this.gleBancosList.Name = "gleBancosList";
            this.gleBancosList.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.gleBancosList.Properties.Appearance.Options.UseFont = true;
            this.gleBancosList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleBancosList.Properties.DataSource = this.bsBancosList_Cheque;
            this.gleBancosList.Properties.DisplayMember = "descripcion";
            this.gleBancosList.Properties.NullText = "";
            this.gleBancosList.Properties.PopupView = this.gridLookUpEdit1View;
            this.gleBancosList.Properties.ValueMember = "id";
            this.gleBancosList.Size = new System.Drawing.Size(178, 28);
            this.gleBancosList.TabIndex = 56;
            this.gleBancosList.EditValueChanged += new System.EventHandler(this.gleBancosList_EditValueChanged);
            // 
            // bsBancosList_Cheque
            // 
            this.bsBancosList_Cheque.DataMember = "bancos_list";
            this.bsBancosList_Cheque.DataSource = this.dsRegistroPagos1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.coldescripcion1});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.Caption = "Elija el Banco";
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 0;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(6, 103);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(57, 21);
            this.label29.TabIndex = 55;
            this.label29.Text = "Banco";
            // 
            // txtNombreEmisorCheque
            // 
            this.txtNombreEmisorCheque.Location = new System.Drawing.Point(169, 167);
            this.txtNombreEmisorCheque.Name = "txtNombreEmisorCheque";
            this.txtNombreEmisorCheque.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtNombreEmisorCheque.Properties.Appearance.Options.UseFont = true;
            this.txtNombreEmisorCheque.Size = new System.Drawing.Size(178, 66);
            this.txtNombreEmisorCheque.TabIndex = 54;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label28.Location = new System.Drawing.Point(6, 244);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(74, 21);
            this.label28.TabIndex = 53;
            this.label28.Text = "Formato";
            // 
            // txtNumeroCheque
            // 
            this.txtNumeroCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCheque.Location = new System.Drawing.Point(169, 133);
            this.txtNumeroCheque.Name = "txtNumeroCheque";
            this.txtNumeroCheque.Size = new System.Drawing.Size(178, 29);
            this.txtNumeroCheque.TabIndex = 52;
            this.txtNumeroCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumeroCheque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroCheque_KeyDown);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 138);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(127, 21);
            this.label22.TabIndex = 51;
            this.label22.Text = "No. del Cheque";
            // 
            // cmdAgregarPagoCheque
            // 
            this.cmdAgregarPagoCheque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAgregarPagoCheque.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdAgregarPagoCheque.Appearance.BorderColor = System.Drawing.Color.LightGray;
            this.cmdAgregarPagoCheque.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cmdAgregarPagoCheque.Appearance.Options.UseBackColor = true;
            this.cmdAgregarPagoCheque.Appearance.Options.UseBorderColor = true;
            this.cmdAgregarPagoCheque.Appearance.Options.UseFont = true;
            this.cmdAgregarPagoCheque.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAgregarPagoCheque.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAgregarPagoCheque.ImageOptions.Image")));
            this.cmdAgregarPagoCheque.Location = new System.Drawing.Point(119, 390);
            this.cmdAgregarPagoCheque.Name = "cmdAgregarPagoCheque";
            this.cmdAgregarPagoCheque.Size = new System.Drawing.Size(117, 46);
            this.cmdAgregarPagoCheque.TabIndex = 50;
            this.cmdAgregarPagoCheque.Text = "Agregar";
            this.cmdAgregarPagoCheque.Click += new System.EventHandler(this.cmdAgregarPagoCheque_Click);
            // 
            // ListBoxCheque
            // 
            this.ListBoxCheque.CheckMode = DevExpress.XtraEditors.CheckMode.Single;
            this.ListBoxCheque.Location = new System.Drawing.Point(119, 306);
            this.ListBoxCheque.Name = "ListBoxCheque";
            this.ListBoxCheque.Size = new System.Drawing.Size(231, 78);
            this.ListBoxCheque.TabIndex = 49;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(6, 306);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(87, 21);
            this.label23.TabIndex = 48;
            this.label23.Text = "Impresora";
            // 
            // txtValorPagarChque
            // 
            this.txtValorPagarChque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPagarChque.Location = new System.Drawing.Point(169, 33);
            this.txtValorPagarChque.Name = "txtValorPagarChque";
            this.txtValorPagarChque.ReadOnly = true;
            this.txtValorPagarChque.Size = new System.Drawing.Size(178, 29);
            this.txtValorPagarChque.TabIndex = 47;
            this.txtValorPagarChque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label24.Location = new System.Drawing.Point(6, 168);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(157, 21);
            this.label24.TabIndex = 46;
            this.label24.Text = "Nombre del Emisor";
            // 
            // radioGroup4
            // 
            this.radioGroup4.Location = new System.Drawing.Point(119, 239);
            this.radioGroup4.Name = "radioGroup4";
            this.radioGroup4.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup4.Properties.Appearance.Options.UseFont = true;
            this.radioGroup4.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "3.5 pulg. cinta"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "8x11.5 pulg. Carta")});
            this.radioGroup4.Size = new System.Drawing.Size(228, 61);
            this.radioGroup4.TabIndex = 45;
            // 
            // cmdValorCheque
            // 
            this.cmdValorCheque.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cmdValorCheque.Location = new System.Drawing.Point(169, 65);
            this.cmdValorCheque.Name = "cmdValorCheque";
            this.cmdValorCheque.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cmdValorCheque.Properties.Appearance.Options.UseFont = true;
            this.cmdValorCheque.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmdValorCheque.Size = new System.Drawing.Size(178, 32);
            this.cmdValorCheque.TabIndex = 44;
            this.cmdValorCheque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmdValorCheque_KeyDown);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(6, 71);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(140, 21);
            this.label25.TabIndex = 43;
            this.label25.Text = "Valor del Cheque";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(6, 38);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(111, 21);
            this.label26.TabIndex = 42;
            this.label26.Text = "Valor a Pagar";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label27.Location = new System.Drawing.Point(96, 6);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(168, 25);
            this.label27.TabIndex = 41;
            this.label27.Text = "Pago con Cheque";
            // 
            // cmdEfectivo
            // 
            this.cmdEfectivo.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEfectivo.Appearance.Options.UseFont = true;
            this.cmdEfectivo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdEfectivo.ImageOptions.Image")));
            this.cmdEfectivo.Location = new System.Drawing.Point(3, 23);
            this.cmdEfectivo.Name = "cmdEfectivo";
            this.cmdEfectivo.Size = new System.Drawing.Size(200, 92);
            this.cmdEfectivo.TabIndex = 1;
            this.cmdEfectivo.Text = "Efectivo";
            this.cmdEfectivo.Click += new System.EventHandler(this.cmdEfectivo_Click);
            // 
            // cmdTarjeta
            // 
            this.cmdTarjeta.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTarjeta.Appearance.Options.UseFont = true;
            this.cmdTarjeta.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdTarjeta.ImageOptions.Image")));
            this.cmdTarjeta.Location = new System.Drawing.Point(4, 154);
            this.cmdTarjeta.Name = "cmdTarjeta";
            this.cmdTarjeta.Size = new System.Drawing.Size(200, 92);
            this.cmdTarjeta.TabIndex = 2;
            this.cmdTarjeta.Text = "Tarjeta";
            this.cmdTarjeta.Click += new System.EventHandler(this.cmdTarjeta_Click);
            // 
            // cmdDepositoBancario
            // 
            this.cmdDepositoBancario.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDepositoBancario.Appearance.Options.UseFont = true;
            this.cmdDepositoBancario.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdDepositoBancario.ImageOptions.Image")));
            this.cmdDepositoBancario.Location = new System.Drawing.Point(3, 276);
            this.cmdDepositoBancario.Name = "cmdDepositoBancario";
            this.cmdDepositoBancario.Size = new System.Drawing.Size(200, 92);
            this.cmdDepositoBancario.TabIndex = 3;
            this.cmdDepositoBancario.Text = "Depósito\r\nBancario";
            this.cmdDepositoBancario.Click += new System.EventHandler(this.cmdDepositoBancario_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "resumen_pago";
            this.gridControl1.DataSource = this.dsRegistroPagos1;
            this.gridControl1.Location = new System.Drawing.Point(580, 138);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(310, 220);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion,
            this.colvalor,
            this.coltipo_id,
            this.coltipo_descripcion,
            this.colreferencia});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            this.coldescripcion.Width = 183;
            // 
            // colvalor
            // 
            this.colvalor.DisplayFormat.FormatString = "n2";
            this.colvalor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalor.FieldName = "valor";
            this.colvalor.Name = "colvalor";
            this.colvalor.OptionsColumn.AllowEdit = false;
            this.colvalor.Visible = true;
            this.colvalor.VisibleIndex = 1;
            this.colvalor.Width = 102;
            // 
            // coltipo_id
            // 
            this.coltipo_id.FieldName = "tipo_id";
            this.coltipo_id.Name = "coltipo_id";
            // 
            // coltipo_descripcion
            // 
            this.coltipo_descripcion.FieldName = "tipo_descripcion";
            this.coltipo_descripcion.Name = "coltipo_descripcion";
            // 
            // colreferencia
            // 
            this.colreferencia.FieldName = "referencia";
            this.colreferencia.Name = "colreferencia";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(576, 117);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(165, 21);
            this.label18.TabIndex = 31;
            this.label18.Text = "Resumen de Pago(s)";
            // 
            // lblResumenPagosTotal
            // 
            this.lblResumenPagosTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumenPagosTotal.Location = new System.Drawing.Point(725, 361);
            this.lblResumenPagosTotal.Name = "lblResumenPagosTotal";
            this.lblResumenPagosTotal.Size = new System.Drawing.Size(165, 21);
            this.lblResumenPagosTotal.TabIndex = 32;
            this.lblResumenPagosTotal.Text = "L 0.00";
            this.lblResumenPagosTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton3.Appearance.BorderColor = System.Drawing.Color.LightGray;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseBorderColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(664, 412);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(145, 46);
            this.simpleButton3.TabIndex = 39;
            this.simpleButton3.Text = "Pagar";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(576, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 21);
            this.label19.TabIndex = 40;
            this.label19.Text = "Total a pagar:";
            // 
            // lblTotalPagoRequerido
            // 
            this.lblTotalPagoRequerido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagoRequerido.Location = new System.Drawing.Point(725, 81);
            this.lblTotalPagoRequerido.Name = "lblTotalPagoRequerido";
            this.lblTotalPagoRequerido.Size = new System.Drawing.Size(165, 21);
            this.lblTotalPagoRequerido.TabIndex = 41;
            this.lblTotalPagoRequerido.Text = "L 0.00";
            this.lblTotalPagoRequerido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalPagoRequerido.Click += new System.EventHandler(this.label20_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(576, 361);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 21);
            this.label20.TabIndex = 42;
            this.label20.Text = "Total Cobro:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(576, 382);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 21);
            this.label21.TabIndex = 43;
            this.label21.Text = "Saldo:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(725, 382);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(165, 21);
            this.lblSaldo.TabIndex = 44;
            this.lblSaldo.Text = "L 0.00";
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdCheque
            // 
            this.cmdCheque.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCheque.Appearance.Options.UseFont = true;
            this.cmdCheque.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCheque.ImageOptions.Image")));
            this.cmdCheque.Location = new System.Drawing.Point(3, 397);
            this.cmdCheque.Name = "cmdCheque";
            this.cmdCheque.Size = new System.Drawing.Size(200, 92);
            this.cmdCheque.TabIndex = 45;
            this.cmdCheque.Text = "Cheque";
            this.cmdCheque.Click += new System.EventHandler(this.cmdCheque_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdCerrar.Appearance.BorderColor = System.Drawing.Color.LightGray;
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseBorderColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(664, 464);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(145, 46);
            this.cmdCerrar.TabIndex = 46;
            this.cmdCerrar.Text = "Salir";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuesto.Location = new System.Drawing.Point(725, 60);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(165, 21);
            this.lblImpuesto.TabIndex = 48;
            this.lblImpuesto.Text = "L 0.00";
            this.lblImpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(576, 60);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(86, 21);
            this.label33.TabIndex = 47;
            this.label33.Text = "Impuesto:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(725, 39);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(165, 21);
            this.lblSubTotal.TabIndex = 50;
            this.lblSubTotal.Text = "L 0.00";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(576, 39);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(85, 21);
            this.label35.TabIndex = 49;
            this.label35.Text = "Sub Total:";
            // 
            // frmPagoFactura
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 521);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.lblImpuesto);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdCheque);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblTotalPagoRequerido);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.lblResumenPagosTotal);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cmdDepositoBancario);
            this.Controls.Add(this.cmdTarjeta);
            this.Controls.Add(this.cmdEfectivo);
            this.Controls.Add(this.tabPagos);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmPagoFactura.IconOptions.Image")));
            this.Name = "frmPagoFactura";
            this.Text = "Pago Factura";
            ((System.ComponentModel.ISupportInitialize)(this.tabPagos)).EndInit();
            this.tabPagos.ResumeLayout(false);
            this.tabPageEfectivo.ResumeLayout(false);
            this.tabPageEfectivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListboxPrintersEfectivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.tabPageTarjeta.ResumeLayout(false);
            this.tabPageTarjeta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListboxPrintersTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup2.Properties)).EndInit();
            this.tabPageTransferenciaCliente.ResumeLayout(false);
            this.tabPageTransferenciaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gleCuentaBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCuentaBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRegistroPagos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleBancoDeposito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBancosList_Deposito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListboxPrintersTransferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup3.Properties)).EndInit();
            this.tabPageCheques.ResumeLayout(false);
            this.tabPageCheques.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gleBancosList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBancosList_Cheque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreEmisorCheque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxCheque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdValorCheque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabPagos;
        private DevExpress.XtraTab.XtraTabPage tabPageEfectivo;
        private DevExpress.XtraTab.XtraTabPage tabPageTarjeta;
        private DevExpress.XtraTab.XtraTabPage tabPageTransferenciaCliente;
        private DevExpress.XtraEditors.SimpleButton cmdEfectivo;
        private DevExpress.XtraEditors.SimpleButton cmdTarjeta;
        private DevExpress.XtraEditors.SimpleButton cmdDepositoBancario;
        private DevExpress.XtraEditors.CheckedListBoxControl ListboxPrintersEfectivo;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton cmdPagar;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorEfectivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.CheckedListBoxControl ListboxPrintersTarjeta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.RadioGroup radioGroup2;
        private System.Windows.Forms.TextBox txtValorTC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEntregadoTC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.RadioGroup radioGroup3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtValorPagarTransferencia;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.CheckedListBoxControl ListboxPrintersTransferencia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label17;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblResumenPagosTotal;
        private dsRegistroPagos dsRegistroPagos1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_id;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_descripcion;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblTotalPagoRequerido;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblSaldo;
        private DevExpress.XtraGrid.Columns.GridColumn colreferencia;
        private DevExpress.XtraEditors.SimpleButton cmdCheque;
        private DevExpress.XtraTab.XtraTabPage tabPageCheques;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtNumeroCheque;
        private System.Windows.Forms.Label label22;
        private DevExpress.XtraEditors.SimpleButton cmdAgregarPagoCheque;
        private DevExpress.XtraEditors.CheckedListBoxControl ListBoxCheque;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtValorPagarChque;
        private System.Windows.Forms.Label label24;
        private DevExpress.XtraEditors.RadioGroup radioGroup4;
        private DevExpress.XtraEditors.SpinEdit cmdValorCheque;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private DevExpress.XtraEditors.MemoEdit txtNombreEmisorCheque;
        private System.Windows.Forms.Label label29;
        private DevExpress.XtraEditors.GridLookUpEdit gleBancosList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource bsBancosList_Cheque;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.GridLookUpEdit gleBancoDeposito;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.BindingSource bsBancosList_Deposito;
        private System.Windows.Forms.TextBox txtValorTransferencia;
        private DevExpress.XtraEditors.GridLookUpEdit gleCuentaBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.BindingSource bsCuentaBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colid_banco;
        private DevExpress.XtraGrid.Columns.GridColumn colcuenta;
        private DevExpress.XtraGrid.Columns.GridColumn coltitular;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colmoneda;
        public System.Windows.Forms.TextBox txtCambio;
        public System.Windows.Forms.TextBox txtEntregado;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label35;
    }
}