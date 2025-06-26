using JAGUAR_PRO.Facturacion.CoreFacturas;

namespace Eatery.Ventas
{
    partial class frmFactura
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cmdDeleteRowFactura = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.txtNombreCliente = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAbrirBusqueda = new DevExpress.XtraEditors.SimpleButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmdFacturar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSalir = new DevExpress.XtraEditors.SimpleButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
            this.panelNotificacion = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.timerLimpiarMensaje = new System.Windows.Forms.Timer(this.components);
            this.lblfecha = new System.Windows.Forms.Label();
            this.dsVentas1 = new JAGUAR_PRO.Facturacion.CoreFacturas.dsVentas();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.cmdChangeVendedor = new DevExpress.XtraEditors.SimpleButton();
            this.txtVendedor = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.cmdCopiarFromPedido = new DevExpress.XtraEditors.SimpleButton();
            this.rdCredito = new System.Windows.Forms.RadioButton();
            this.rdContado = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdConsumidorFinal = new DevExpress.XtraEditors.SimpleButton();
            this.txtRTN = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtScanProducto = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_pt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisv1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisv2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisv3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal_linea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinventario = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDeleteRowFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCliente.Properties)).BeginInit();
            this.panelNotificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsVentas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVendedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScanProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdDeleteRowFactura
            // 
            this.cmdDeleteRowFactura.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdDeleteRowFactura.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdDeleteRowFactura.Name = "cmdDeleteRowFactura";
            this.cmdDeleteRowFactura.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(99, 29);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtNombreCliente.Properties.Appearance.Options.UseFont = true;
            this.txtNombreCliente.Properties.NullValuePrompt = "Nombre del Cliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(495, 26);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cliente";
            // 
            // cmdAbrirBusqueda
            // 
            this.cmdAbrirBusqueda.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.cmdAbrirBusqueda.Appearance.Options.UseFont = true;
            this.cmdAbrirBusqueda.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAbrirBusqueda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAbrirBusqueda.ImageOptions.Image")));
            this.cmdAbrirBusqueda.Location = new System.Drawing.Point(597, 76);
            this.cmdAbrirBusqueda.Name = "cmdAbrirBusqueda";
            this.cmdAbrirBusqueda.Size = new System.Drawing.Size(161, 38);
            this.cmdAbrirBusqueda.TabIndex = 3;
            this.cmdAbrirBusqueda.Text = "&Buscar Cliente";
            this.cmdAbrirBusqueda.Click += new System.EventHandler(this.cmdAbrirBusqueda_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(8, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(667, 23);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Generar Factura";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdFacturar
            // 
            this.cmdFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdFacturar.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFacturar.Appearance.Options.UseFont = true;
            this.cmdFacturar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdFacturar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdFacturar.ImageOptions.Image")));
            this.cmdFacturar.Location = new System.Drawing.Point(837, 539);
            this.cmdFacturar.Name = "cmdFacturar";
            this.cmdFacturar.Size = new System.Drawing.Size(246, 38);
            this.cmdFacturar.TabIndex = 7;
            this.cmdFacturar.Text = "&Facturar";
            this.cmdFacturar.Click += new System.EventHandler(this.cmdFacturar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdSalir.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Appearance.Options.UseFont = true;
            this.cmdSalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.ImageOptions.Image")));
            this.cmdSalir.Location = new System.Drawing.Point(255, 539);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(246, 38);
            this.cmdSalir.TabIndex = 6;
            this.cmdSalir.Text = "&Salir";
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(964, 504);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(119, 29);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdNew
            // 
            this.cmdNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdNew.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNew.Appearance.Options.UseFont = true;
            this.cmdNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdNew.ImageOptions.Image")));
            this.cmdNew.Location = new System.Drawing.Point(3, 539);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(246, 38);
            this.cmdNew.TabIndex = 14;
            this.cmdNew.Text = "&Nuevo";
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // panelNotificacion
            // 
            this.panelNotificacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNotificacion.BackColor = System.Drawing.Color.White;
            this.panelNotificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNotificacion.Controls.Add(this.lblMensaje);
            this.panelNotificacion.Location = new System.Drawing.Point(3, 583);
            this.panelNotificacion.Name = "panelNotificacion";
            this.panelNotificacion.Size = new System.Drawing.Size(1080, 31);
            this.panelNotificacion.TabIndex = 15;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(6, 6);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(1059, 17);
            this.lblMensaje.TabIndex = 0;
            // 
            // timerLimpiarMensaje
            // 
            this.timerLimpiarMensaje.Interval = 4000;
            this.timerLimpiarMensaje.Tick += new System.EventHandler(this.timerLimpiarMensaje_Tick);
            // 
            // lblfecha
            // 
            this.lblfecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(1315, 22);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(121, 24);
            this.lblfecha.TabIndex = 16;
            this.lblfecha.Text = "Fecha Actual";
            // 
            // dsVentas1
            // 
            this.dsVentas1.DataSetName = "dsVentas";
            this.dsVentas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigationFrame1.Controls.Add(this.navigationPage1);
            this.navigationFrame1.Location = new System.Drawing.Point(0, 2);
            this.navigationFrame1.Margin = new System.Windows.Forms.Padding(2);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1});
            this.navigationFrame1.SelectedPage = this.navigationPage1;
            this.navigationFrame1.Size = new System.Drawing.Size(1086, 617);
            this.navigationFrame1.TabIndex = 19;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Controls.Add(this.txtVendedor);
            this.navigationPage1.Controls.Add(this.cmdChangeVendedor);
            this.navigationPage1.Controls.Add(this.label10);
            this.navigationPage1.Controls.Add(this.lblCodigoProducto);
            this.navigationPage1.Controls.Add(this.cmdCopiarFromPedido);
            this.navigationPage1.Controls.Add(this.rdCredito);
            this.navigationPage1.Controls.Add(this.rdContado);
            this.navigationPage1.Controls.Add(this.label4);
            this.navigationPage1.Controls.Add(this.txtDireccion);
            this.navigationPage1.Controls.Add(this.label3);
            this.navigationPage1.Controls.Add(this.panelNotificacion);
            this.navigationPage1.Controls.Add(this.cmdConsumidorFinal);
            this.navigationPage1.Controls.Add(this.txtRTN);
            this.navigationPage1.Controls.Add(this.label2);
            this.navigationPage1.Controls.Add(this.simpleButton1);
            this.navigationPage1.Controls.Add(this.cmdSalir);
            this.navigationPage1.Controls.Add(this.cmdNew);
            this.navigationPage1.Controls.Add(this.txtScanProducto);
            this.navigationPage1.Controls.Add(this.cmdFacturar);
            this.navigationPage1.Controls.Add(this.gridControl1);
            this.navigationPage1.Controls.Add(this.txtTotal);
            this.navigationPage1.Controls.Add(this.lblfecha);
            this.navigationPage1.Controls.Add(this.cmdAbrirBusqueda);
            this.navigationPage1.Controls.Add(this.label1);
            this.navigationPage1.Controls.Add(this.lblTitulo);
            this.navigationPage1.Controls.Add(this.txtNombreCliente);
            this.navigationPage1.Margin = new System.Windows.Forms.Padding(2);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(1086, 617);
            this.navigationPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.navigationPage1_Paint);
            // 
            // cmdChangeVendedor
            // 
            this.cmdChangeVendedor.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.cmdChangeVendedor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdChangeVendedor.ImageOptions.Image")));
            this.cmdChangeVendedor.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdChangeVendedor.Location = new System.Drawing.Point(1040, 47);
            this.cmdChangeVendedor.Name = "cmdChangeVendedor";
            this.cmdChangeVendedor.Size = new System.Drawing.Size(39, 24);
            this.cmdChangeVendedor.TabIndex = 56;
            this.cmdChangeVendedor.Click += new System.EventHandler(this.cmdChangeVendedor_Click);
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(869, 47);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txtVendedor.Properties.Appearance.Options.UseFont = true;
            this.txtVendedor.Size = new System.Drawing.Size(170, 24);
            this.txtVendedor.TabIndex = 55;
            this.txtVendedor.DoubleClick += new System.EventHandler(this.txtVendedor_DoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label10.Location = new System.Drawing.Point(807, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 54;
            this.label10.Text = "Asesor";
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCodigoProducto.Location = new System.Drawing.Point(12, 130);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(61, 20);
            this.lblCodigoProducto.TabIndex = 41;
            this.lblCodigoProducto.Text = "Código";
            // 
            // cmdCopiarFromPedido
            // 
            this.cmdCopiarFromPedido.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmdCopiarFromPedido.Appearance.Options.UseFont = true;
            this.cmdCopiarFromPedido.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCopiarFromPedido.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdCopiarFromPedido.ImageOptions.SvgImage")));
            this.cmdCopiarFromPedido.Location = new System.Drawing.Point(763, 116);
            this.cmdCopiarFromPedido.Name = "cmdCopiarFromPedido";
            this.cmdCopiarFromPedido.Size = new System.Drawing.Size(172, 38);
            this.cmdCopiarFromPedido.TabIndex = 40;
            this.cmdCopiarFromPedido.Text = "Copiar de Prefactura";
            this.cmdCopiarFromPedido.Click += new System.EventHandler(this.cmdCopiarFromPedido_Click);
            // 
            // rdCredito
            // 
            this.rdCredito.AutoSize = true;
            this.rdCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rdCredito.Location = new System.Drawing.Point(676, 48);
            this.rdCredito.Name = "rdCredito";
            this.rdCredito.Size = new System.Drawing.Size(100, 22);
            this.rdCredito.TabIndex = 39;
            this.rdCredito.Text = "Por Cobrar";
            this.rdCredito.UseVisualStyleBackColor = true;
            this.rdCredito.CheckedChanged += new System.EventHandler(this.rdCredito_CheckedChanged);
            // 
            // rdContado
            // 
            this.rdContado.AutoSize = true;
            this.rdContado.Checked = true;
            this.rdContado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rdContado.Location = new System.Drawing.Point(675, 27);
            this.rdContado.Name = "rdContado";
            this.rdContado.Size = new System.Drawing.Size(83, 22);
            this.rdContado.TabIndex = 38;
            this.rdContado.TabStop = true;
            this.rdContado.Text = "Contado";
            this.rdContado.UseVisualStyleBackColor = true;
            this.rdContado.CheckedChanged += new System.EventHandler(this.rdContado_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(600, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Término";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(99, 86);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtDireccion.Properties.Appearance.Options.UseFont = true;
            this.txtDireccion.Properties.NullValuePrompt = "Direcci del Cliente";
            this.txtDireccion.Size = new System.Drawing.Size(495, 26);
            this.txtDireccion.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Dirección";
            // 
            // cmdConsumidorFinal
            // 
            this.cmdConsumidorFinal.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.cmdConsumidorFinal.Appearance.Options.UseFont = true;
            this.cmdConsumidorFinal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdConsumidorFinal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdConsumidorFinal.ImageOptions.Image")));
            this.cmdConsumidorFinal.Location = new System.Drawing.Point(763, 76);
            this.cmdConsumidorFinal.Name = "cmdConsumidorFinal";
            this.cmdConsumidorFinal.Size = new System.Drawing.Size(172, 38);
            this.cmdConsumidorFinal.TabIndex = 34;
            this.cmdConsumidorFinal.Text = "Consumidor Final";
            this.cmdConsumidorFinal.Click += new System.EventHandler(this.cmdConsumidorFinal_Click);
            // 
            // txtRTN
            // 
            this.txtRTN.Location = new System.Drawing.Point(99, 57);
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtRTN.Properties.Appearance.Options.UseFont = true;
            this.txtRTN.Properties.NullValuePrompt = "Nombre del Cliente";
            this.txtRTN.Size = new System.Drawing.Size(495, 26);
            this.txtRTN.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "RTN";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(597, 116);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(161, 38);
            this.simpleButton1.TabIndex = 31;
            this.simpleButton1.Text = "&Buscar Producto";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_2);
            // 
            // txtScanProducto
            // 
            this.txtScanProducto.Location = new System.Drawing.Point(99, 124);
            this.txtScanProducto.Name = "txtScanProducto";
            this.txtScanProducto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtScanProducto.Properties.Appearance.Options.UseFont = true;
            this.txtScanProducto.Properties.NullValuePrompt = "Leer código";
            this.txtScanProducto.Size = new System.Drawing.Size(495, 30);
            this.txtScanProducto.TabIndex = 30;
            this.txtScanProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScanProducto_KeyDown);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "detalle_factura_transaction";
            this.gridControl1.DataSource = this.dsVentas1;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Location = new System.Drawing.Point(9, 156);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1072, 343);
            this.gridControl1.TabIndex = 20;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_pt1,
            this.colitemcode,
            this.colitemname,
            this.colcantidad,
            this.colprecio,
            this.coldescuento,
            this.colisv1,
            this.colisv2,
            this.colisv3,
            this.coltotal_linea,
            this.colDelete,
            this.colinventario});
            this.gridView1.DetailHeight = 182;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.LevelIndent = 0;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 400;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PreviewIndent = 0;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colid_pt1
            // 
            this.colid_pt1.FieldName = "id_pt";
            this.colid_pt1.Name = "colid_pt1";
            // 
            // colitemcode
            // 
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.ReadOnly = true;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 0;
            this.colitemcode.Width = 105;
            // 
            // colitemname
            // 
            this.colitemname.FieldName = "itemname";
            this.colitemname.Name = "colitemname";
            this.colitemname.OptionsColumn.ReadOnly = true;
            this.colitemname.Visible = true;
            this.colitemname.VisibleIndex = 1;
            this.colitemname.Width = 244;
            // 
            // colcantidad
            // 
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 3;
            this.colcantidad.Width = 106;
            // 
            // colprecio
            // 
            this.colprecio.DisplayFormat.FormatString = "n2";
            this.colprecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colprecio.FieldName = "precio";
            this.colprecio.Name = "colprecio";
            this.colprecio.OptionsColumn.ReadOnly = true;
            this.colprecio.Visible = true;
            this.colprecio.VisibleIndex = 4;
            this.colprecio.Width = 147;
            // 
            // coldescuento
            // 
            this.coldescuento.DisplayFormat.FormatString = "n2";
            this.coldescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldescuento.FieldName = "descuento";
            this.coldescuento.Name = "coldescuento";
            this.coldescuento.Visible = true;
            this.coldescuento.VisibleIndex = 5;
            this.coldescuento.Width = 109;
            // 
            // colisv1
            // 
            this.colisv1.Caption = "ISV";
            this.colisv1.DisplayFormat.FormatString = "n2";
            this.colisv1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colisv1.FieldName = "isv1";
            this.colisv1.Name = "colisv1";
            this.colisv1.OptionsColumn.ReadOnly = true;
            this.colisv1.Visible = true;
            this.colisv1.VisibleIndex = 6;
            this.colisv1.Width = 108;
            // 
            // colisv2
            // 
            this.colisv2.FieldName = "isv2";
            this.colisv2.Name = "colisv2";
            // 
            // colisv3
            // 
            this.colisv3.FieldName = "isv3";
            this.colisv3.Name = "colisv3";
            // 
            // coltotal_linea
            // 
            this.coltotal_linea.DisplayFormat.FormatString = "n2";
            this.coltotal_linea.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal_linea.FieldName = "total_linea";
            this.coltotal_linea.Name = "coltotal_linea";
            this.coltotal_linea.OptionsColumn.ReadOnly = true;
            this.coltotal_linea.Visible = true;
            this.coltotal_linea.VisibleIndex = 7;
            this.coltotal_linea.Width = 187;
            // 
            // colDelete
            // 
            this.colDelete.Caption = "Elminar";
            this.colDelete.ColumnEdit = this.cmdDeleteRowFactura;
            this.colDelete.Name = "colDelete";
            this.colDelete.Width = 53;
            // 
            // colinventario
            // 
            this.colinventario.Caption = "Inventario";
            this.colinventario.DisplayFormat.FormatString = "n2";
            this.colinventario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colinventario.FieldName = "inventario";
            this.colinventario.Name = "colinventario";
            this.colinventario.OptionsColumn.ReadOnly = true;
            this.colinventario.Visible = true;
            this.colinventario.VisibleIndex = 2;
            this.colinventario.Width = 74;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 620);
            this.Controls.Add(this.navigationFrame1);
            this.Name = "frmFactura";
            this.Text = "Factura";
            this.Activated += new System.EventHandler(this.frmFactura_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFactura_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.cmdDeleteRowFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCliente.Properties)).EndInit();
            this.panelNotificacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsVentas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVendedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScanProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtNombreCliente;
        private DevExpress.XtraEditors.SimpleButton cmdAbrirBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private DevExpress.XtraEditors.SimpleButton cmdFacturar;
        private DevExpress.XtraEditors.SimpleButton cmdSalir;
        private System.Windows.Forms.TextBox txtTotal;
        private DevExpress.XtraEditors.SimpleButton cmdNew;
        private System.Windows.Forms.Panel panelNotificacion;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Timer timerLimpiarMensaje;
        private System.Windows.Forms.Label lblfecha;
        private dsVentas dsVentas1;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtScanProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt1;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colitemname;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio;
        private DevExpress.XtraGrid.Columns.GridColumn coldescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colisv1;
        private DevExpress.XtraGrid.Columns.GridColumn colisv2;
        private DevExpress.XtraGrid.Columns.GridColumn colisv3;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_linea;
        private DevExpress.XtraEditors.TextEdit txtRTN;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton cmdConsumidorFinal;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colinventario;
        private DevExpress.XtraEditors.TextEdit txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdCredito;
        private System.Windows.Forms.RadioButton rdContado;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton cmdCopiarFromPedido;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdDeleteRowFactura;
        private System.Windows.Forms.Label lblCodigoProducto;
        private DevExpress.XtraEditors.SimpleButton cmdChangeVendedor;
        private DevExpress.XtraEditors.TextEdit txtVendedor;
        private System.Windows.Forms.Label label10;
    }
}