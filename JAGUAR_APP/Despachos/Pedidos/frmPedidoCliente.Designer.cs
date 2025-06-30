using JAGUAR_PRO.Facturacion.CoreFacturas;

namespace Eatery.Ventas
{
    partial class frmPedidoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidoCliente));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.txtNombreCliente = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAbrirBusqueda = new DevExpress.XtraEditors.SimpleButton();
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
            this.label10 = new System.Windows.Forms.Label();
            this.cmdSalir2 = new DevExpress.XtraEditors.SimpleButton();
            this.rdCredito = new System.Windows.Forms.RadioButton();
            this.rdPorCobrar = new System.Windows.Forms.RadioButton();
            this.rdContado = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdCopiarDesde = new DevExpress.XtraEditors.SimpleButton();
            this.ckConfirmarPedido = new DevExpress.XtraEditors.CheckEdit();
            this.ckGenerarCotizacion = new DevExpress.XtraEditors.CheckEdit();
            this.cmdConfirmarFactura = new DevExpress.XtraEditors.SimpleButton();
            this.gleEstados = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bsEstadosFacturas = new System.Windows.Forms.BindingSource(this.components);
            this.dsPedidosVentas1 = new JAGUAR_PRO.Despachos.Pedidos.dsPedidosVentas();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmdChangeVendedor = new DevExpress.XtraEditors.SimpleButton();
            this.txtAsesorVendedor = new DevExpress.XtraEditors.TextEdit();
            this.dtFechaEntrega = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComentario = new DevExpress.XtraEditors.MemoEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
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
            this.colcodigo_referencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisv1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisv2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisv3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal_linea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdDeleteRowFactura = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colinventario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbodega_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGestionAlmacen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdElejirAlmacen = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colinventario_seleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsBancos = new System.Windows.Forms.BindingSource(this.components);
            this.dsPedidosClientesV1 = new JAGUAR_PRO.Despachos.Pedidos.dsPedidosClientesV();
            this.bsTipoPago = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvLecturaCodigo = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCliente.Properties)).BeginInit();
            this.panelNotificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsVentas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckConfirmarPedido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckGenerarCotizacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleEstados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstadosFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidosVentas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsesorVendedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaEntrega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaEntrega.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScanProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDeleteRowFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdElejirAlmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidosClientesV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvLecturaCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(99, 8);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Properties.Appearance.Options.UseFont = true;
            this.txtNombreCliente.Properties.NullValuePrompt = "Nombre del Cliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(392, 22);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cliente";
            // 
            // cmdAbrirBusqueda
            // 
            this.cmdAbrirBusqueda.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAbrirBusqueda.Appearance.Options.UseFont = true;
            this.cmdAbrirBusqueda.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAbrirBusqueda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAbrirBusqueda.ImageOptions.Image")));
            this.cmdAbrirBusqueda.Location = new System.Drawing.Point(493, 52);
            this.cmdAbrirBusqueda.Name = "cmdAbrirBusqueda";
            this.cmdAbrirBusqueda.Size = new System.Drawing.Size(123, 34);
            this.cmdAbrirBusqueda.TabIndex = 3;
            this.cmdAbrirBusqueda.Text = "&Buscar Cliente";
            this.cmdAbrirBusqueda.Click += new System.EventHandler(this.cmdAbrirBusqueda_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdSalir.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmdSalir.Appearance.Options.UseFont = true;
            this.cmdSalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.ImageOptions.Image")));
            this.cmdSalir.Location = new System.Drawing.Point(3, 435);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(139, 38);
            this.cmdSalir.TabIndex = 6;
            this.cmdSalir.Text = "&Salir";
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(831, 396);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(122, 29);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdNew
            // 
            this.cmdNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdNew.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmdNew.Appearance.Options.UseFont = true;
            this.cmdNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdNew.ImageOptions.Image")));
            this.cmdNew.Location = new System.Drawing.Point(3, 396);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(139, 38);
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
            this.panelNotificacion.Location = new System.Drawing.Point(3, 474);
            this.panelNotificacion.Name = "panelNotificacion";
            this.panelNotificacion.Size = new System.Drawing.Size(953, 31);
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
            this.lblMensaje.Size = new System.Drawing.Size(932, 17);
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
            this.lblfecha.Location = new System.Drawing.Point(1188, 22);
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
            this.navigationFrame1.Size = new System.Drawing.Size(959, 509);
            this.navigationFrame1.TabIndex = 19;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Controls.Add(this.label10);
            this.navigationPage1.Controls.Add(this.cmdSalir2);
            this.navigationPage1.Controls.Add(this.rdCredito);
            this.navigationPage1.Controls.Add(this.rdPorCobrar);
            this.navigationPage1.Controls.Add(this.rdContado);
            this.navigationPage1.Controls.Add(this.label4);
            this.navigationPage1.Controls.Add(this.cmdCopiarDesde);
            this.navigationPage1.Controls.Add(this.txtTotal);
            this.navigationPage1.Controls.Add(this.ckConfirmarPedido);
            this.navigationPage1.Controls.Add(this.ckGenerarCotizacion);
            this.navigationPage1.Controls.Add(this.cmdConfirmarFactura);
            this.navigationPage1.Controls.Add(this.gleEstados);
            this.navigationPage1.Controls.Add(this.label12);
            this.navigationPage1.Controls.Add(this.label11);
            this.navigationPage1.Controls.Add(this.cmdChangeVendedor);
            this.navigationPage1.Controls.Add(this.txtAsesorVendedor);
            this.navigationPage1.Controls.Add(this.dtFechaEntrega);
            this.navigationPage1.Controls.Add(this.label6);
            this.navigationPage1.Controls.Add(this.txtComentario);
            this.navigationPage1.Controls.Add(this.label5);
            this.navigationPage1.Controls.Add(this.simpleButton2);
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
            this.navigationPage1.Controls.Add(this.gridControl1);
            this.navigationPage1.Controls.Add(this.lblfecha);
            this.navigationPage1.Controls.Add(this.cmdAbrirBusqueda);
            this.navigationPage1.Controls.Add(this.label1);
            this.navigationPage1.Controls.Add(this.txtNombreCliente);
            this.navigationPage1.Margin = new System.Windows.Forms.Padding(2);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(959, 509);
            this.navigationPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.navigationPage1_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label10.Location = new System.Drawing.Point(624, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 51;
            this.label10.Text = "Vendedor";
            // 
            // cmdSalir2
            // 
            this.cmdSalir2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmdSalir2.Appearance.Options.UseFont = true;
            this.cmdSalir2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSalir2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir2.ImageOptions.Image")));
            this.cmdSalir2.Location = new System.Drawing.Point(878, 8);
            this.cmdSalir2.Name = "cmdSalir2";
            this.cmdSalir2.Size = new System.Drawing.Size(77, 38);
            this.cmdSalir2.TabIndex = 65;
            this.cmdSalir2.Text = "&Salir";
            this.cmdSalir2.Click += new System.EventHandler(this.cmdSalir2_Click);
            // 
            // rdCredito
            // 
            this.rdCredito.AutoSize = true;
            this.rdCredito.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdCredito.Location = new System.Drawing.Point(865, 73);
            this.rdCredito.Name = "rdCredito";
            this.rdCredito.Size = new System.Drawing.Size(64, 19);
            this.rdCredito.TabIndex = 64;
            this.rdCredito.Text = "Crédito";
            this.rdCredito.UseVisualStyleBackColor = true;
            this.rdCredito.CheckedChanged += new System.EventHandler(this.rdCredito_CheckedChanged_2);
            // 
            // rdPorCobrar
            // 
            this.rdPorCobrar.AutoSize = true;
            this.rdPorCobrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdPorCobrar.Location = new System.Drawing.Point(770, 73);
            this.rdPorCobrar.Name = "rdPorCobrar";
            this.rdPorCobrar.Size = new System.Drawing.Size(82, 19);
            this.rdPorCobrar.TabIndex = 63;
            this.rdPorCobrar.Text = "Por Cobrar";
            this.rdPorCobrar.UseVisualStyleBackColor = true;
            this.rdPorCobrar.CheckedChanged += new System.EventHandler(this.rdCredito_CheckedChanged_1);
            // 
            // rdContado
            // 
            this.rdContado.AutoSize = true;
            this.rdContado.Checked = true;
            this.rdContado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdContado.Location = new System.Drawing.Point(689, 73);
            this.rdContado.Name = "rdContado";
            this.rdContado.Size = new System.Drawing.Size(71, 19);
            this.rdContado.TabIndex = 62;
            this.rdContado.TabStop = true;
            this.rdContado.Text = "Contado";
            this.rdContado.UseVisualStyleBackColor = true;
            this.rdContado.CheckedChanged += new System.EventHandler(this.rdContado_CheckedChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label4.Location = new System.Drawing.Point(624, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 61;
            this.label4.Text = "Término";
            // 
            // cmdCopiarDesde
            // 
            this.cmdCopiarDesde.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCopiarDesde.Appearance.Options.UseFont = true;
            this.cmdCopiarDesde.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCopiarDesde.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCopiarDesde.ImageOptions.Image")));
            this.cmdCopiarDesde.Location = new System.Drawing.Point(493, 94);
            this.cmdCopiarDesde.Name = "cmdCopiarDesde";
            this.cmdCopiarDesde.Size = new System.Drawing.Size(123, 34);
            this.cmdCopiarDesde.TabIndex = 60;
            this.cmdCopiarDesde.Text = "Copiar desde";
            this.cmdCopiarDesde.Click += new System.EventHandler(this.cmdCopiarDesde_Click);
            // 
            // ckConfirmarPedido
            // 
            this.ckConfirmarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckConfirmarPedido.Location = new System.Drawing.Point(548, 427);
            this.ckConfirmarPedido.Name = "ckConfirmarPedido";
            this.ckConfirmarPedido.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.ckConfirmarPedido.Properties.Appearance.Options.UseFont = true;
            this.ckConfirmarPedido.Properties.Caption = "Confirmar Pre Factura";
            this.ckConfirmarPedido.Size = new System.Drawing.Size(165, 23);
            this.ckConfirmarPedido.TabIndex = 59;
            // 
            // ckGenerarCotizacion
            // 
            this.ckGenerarCotizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckGenerarCotizacion.Location = new System.Drawing.Point(548, 450);
            this.ckGenerarCotizacion.Name = "ckGenerarCotizacion";
            this.ckGenerarCotizacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.ckGenerarCotizacion.Properties.Appearance.Options.UseFont = true;
            this.ckGenerarCotizacion.Properties.Caption = "Generar Cotización";
            this.ckGenerarCotizacion.Size = new System.Drawing.Size(158, 23);
            this.ckGenerarCotizacion.TabIndex = 58;
            // 
            // cmdConfirmarFactura
            // 
            this.cmdConfirmarFactura.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.cmdConfirmarFactura.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmdConfirmarFactura.Appearance.Options.UseBackColor = true;
            this.cmdConfirmarFactura.Appearance.Options.UseFont = true;
            this.cmdConfirmarFactura.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdConfirmarFactura.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdConfirmarFactura.ImageOptions.SvgImage")));
            this.cmdConfirmarFactura.Location = new System.Drawing.Point(689, 32);
            this.cmdConfirmarFactura.Name = "cmdConfirmarFactura";
            this.cmdConfirmarFactura.Size = new System.Drawing.Size(186, 34);
            this.cmdConfirmarFactura.TabIndex = 57;
            this.cmdConfirmarFactura.Text = "Confirmar Pre Factura";
            this.cmdConfirmarFactura.Visible = false;
            this.cmdConfirmarFactura.Click += new System.EventHandler(this.cmdConfirmarFactura_Click);
            // 
            // gleEstados
            // 
            this.gleEstados.Location = new System.Drawing.Point(689, 9);
            this.gleEstados.Name = "gleEstados";
            this.gleEstados.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gleEstados.Properties.Appearance.Options.UseFont = true;
            this.gleEstados.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleEstados.Properties.DataSource = this.bsEstadosFacturas;
            this.gleEstados.Properties.DisplayMember = "descripcion";
            this.gleEstados.Properties.NullText = "";
            this.gleEstados.Properties.PopupView = this.gridView2;
            this.gleEstados.Properties.ReadOnly = true;
            this.gleEstados.Properties.ValueMember = "id";
            this.gleEstados.Size = new System.Drawing.Size(186, 22);
            this.gleEstados.TabIndex = 56;
            // 
            // bsEstadosFacturas
            // 
            this.bsEstadosFacturas.DataMember = "estados_pedidos";
            this.bsEstadosFacturas.DataSource = this.dsPedidosVentas1;
            // 
            // dsPedidosVentas1
            // 
            this.dsPedidosVentas1.DataSetName = "dsPedidosVentas";
            this.dsPedidosVentas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid2,
            this.coldescripcion});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colid2
            // 
            this.colid2.FieldName = "id";
            this.colid2.Name = "colid2";
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label12.Location = new System.Drawing.Point(623, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 55;
            this.label12.Text = "Estado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label11.Location = new System.Drawing.Point(10, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 17);
            this.label11.TabIndex = 54;
            this.label11.Text = "Código";
            // 
            // cmdChangeVendedor
            // 
            this.cmdChangeVendedor.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.cmdChangeVendedor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdChangeVendedor.ImageOptions.Image")));
            this.cmdChangeVendedor.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdChangeVendedor.Location = new System.Drawing.Point(885, 105);
            this.cmdChangeVendedor.Name = "cmdChangeVendedor";
            this.cmdChangeVendedor.Size = new System.Drawing.Size(39, 24);
            this.cmdChangeVendedor.TabIndex = 53;
            this.cmdChangeVendedor.Click += new System.EventHandler(this.cmdChangeVendedor_Click);
            // 
            // txtAsesorVendedor
            // 
            this.txtAsesorVendedor.Location = new System.Drawing.Point(689, 106);
            this.txtAsesorVendedor.Name = "txtAsesorVendedor";
            this.txtAsesorVendedor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAsesorVendedor.Properties.Appearance.Options.UseFont = true;
            this.txtAsesorVendedor.Size = new System.Drawing.Size(195, 22);
            this.txtAsesorVendedor.TabIndex = 52;
            this.txtAsesorVendedor.DoubleClick += new System.EventHandler(this.textEdit1_DoubleClick);
            // 
            // dtFechaEntrega
            // 
            this.dtFechaEntrega.EditValue = null;
            this.dtFechaEntrega.Location = new System.Drawing.Point(99, 80);
            this.dtFechaEntrega.Name = "dtFechaEntrega";
            this.dtFechaEntrega.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaEntrega.Properties.Appearance.Options.UseFont = true;
            this.dtFechaEntrega.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaEntrega.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtFechaEntrega.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaEntrega.Size = new System.Drawing.Size(214, 22);
            this.dtFechaEntrega.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label6.Location = new System.Drawing.Point(10, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Fecha Entrega";
            // 
            // txtComentario
            // 
            this.txtComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtComentario.Location = new System.Drawing.Point(148, 421);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtComentario.Properties.Appearance.Options.UseFont = true;
            this.txtComentario.Size = new System.Drawing.Size(312, 52);
            this.txtComentario.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label5.Location = new System.Drawing.Point(145, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Comentario";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(770, 435);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(186, 38);
            this.simpleButton2.TabIndex = 40;
            this.simpleButton2.Text = "&Guardar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(99, 56);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Properties.Appearance.Options.UseFont = true;
            this.txtDireccion.Properties.NullValuePrompt = "Direcci del Cliente";
            this.txtDireccion.Size = new System.Drawing.Size(392, 22);
            this.txtDireccion.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label3.Location = new System.Drawing.Point(10, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Dirección";
            // 
            // cmdConsumidorFinal
            // 
            this.cmdConsumidorFinal.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsumidorFinal.Appearance.Options.UseFont = true;
            this.cmdConsumidorFinal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdConsumidorFinal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdConsumidorFinal.ImageOptions.Image")));
            this.cmdConsumidorFinal.Location = new System.Drawing.Point(493, 8);
            this.cmdConsumidorFinal.Name = "cmdConsumidorFinal";
            this.cmdConsumidorFinal.Size = new System.Drawing.Size(123, 34);
            this.cmdConsumidorFinal.TabIndex = 34;
            this.cmdConsumidorFinal.Text = "Consumidor Final";
            this.cmdConsumidorFinal.Click += new System.EventHandler(this.cmdConsumidorFinal_Click);
            // 
            // txtRTN
            // 
            this.txtRTN.Location = new System.Drawing.Point(99, 32);
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRTN.Properties.Appearance.Options.UseFont = true;
            this.txtRTN.Properties.NullValuePrompt = "Nombre del Cliente";
            this.txtRTN.Size = new System.Drawing.Size(392, 22);
            this.txtRTN.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label2.Location = new System.Drawing.Point(10, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "RTN";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(319, 94);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(172, 34);
            this.simpleButton1.TabIndex = 31;
            this.simpleButton1.Text = "Agregar Producto";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_2);
            // 
            // txtScanProducto
            // 
            this.txtScanProducto.Location = new System.Drawing.Point(99, 104);
            this.txtScanProducto.Name = "txtScanProducto";
            this.txtScanProducto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtScanProducto.Properties.Appearance.Options.UseFont = true;
            this.txtScanProducto.Properties.NullValuePrompt = "Leer código de Producto";
            this.txtScanProducto.Size = new System.Drawing.Size(214, 24);
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
            this.gridControl1.Location = new System.Drawing.Point(3, 134);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdDeleteRowFactura,
            this.cmdElejirAlmacen});
            this.gridControl1.Size = new System.Drawing.Size(950, 257);
            this.gridControl1.TabIndex = 20;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
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
            this.colcodigo_referencia,
            this.colitemname,
            this.colcantidad,
            this.colprecio,
            this.coldescuento,
            this.colisv1,
            this.colisv2,
            this.colisv3,
            this.coltotal_linea,
            this.colDelete,
            this.colinventario,
            this.colbodega_descripcion,
            this.colGestionAlmacen,
            this.colinventario_seleccionado,
            this.colmarca});
            this.gridView1.DetailHeight = 182;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.LevelIndent = 0;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 400;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PreviewIndent = 0;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
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
            this.colitemcode.Width = 51;
            // 
            // colcodigo_referencia
            // 
            this.colcodigo_referencia.FieldName = "codigo_referencia";
            this.colcodigo_referencia.Name = "colcodigo_referencia";
            this.colcodigo_referencia.Visible = true;
            this.colcodigo_referencia.VisibleIndex = 1;
            this.colcodigo_referencia.Width = 83;
            // 
            // colitemname
            // 
            this.colitemname.FieldName = "itemname";
            this.colitemname.Name = "colitemname";
            this.colitemname.OptionsColumn.ReadOnly = true;
            this.colitemname.Visible = true;
            this.colitemname.VisibleIndex = 2;
            this.colitemname.Width = 189;
            // 
            // colcantidad
            // 
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.ReadOnly = true;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 7;
            this.colcantidad.Width = 63;
            // 
            // colprecio
            // 
            this.colprecio.DisplayFormat.FormatString = "n2";
            this.colprecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colprecio.FieldName = "precio";
            this.colprecio.Name = "colprecio";
            this.colprecio.OptionsColumn.ReadOnly = true;
            this.colprecio.Visible = true;
            this.colprecio.VisibleIndex = 8;
            this.colprecio.Width = 83;
            // 
            // coldescuento
            // 
            this.coldescuento.DisplayFormat.FormatString = "n2";
            this.coldescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldescuento.FieldName = "descuento";
            this.coldescuento.Name = "coldescuento";
            this.coldescuento.Visible = true;
            this.coldescuento.VisibleIndex = 9;
            this.coldescuento.Width = 73;
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
            this.colisv1.VisibleIndex = 10;
            this.colisv1.Width = 49;
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
            this.coltotal_linea.VisibleIndex = 11;
            this.coltotal_linea.Width = 73;
            // 
            // colDelete
            // 
            this.colDelete.Caption = "Elminar";
            this.colDelete.ColumnEdit = this.cmdDeleteRowFactura;
            this.colDelete.FieldName = "delete";
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 12;
            this.colDelete.Width = 50;
            // 
            // cmdDeleteRowFactura
            // 
            this.cmdDeleteRowFactura.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.cmdDeleteRowFactura.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdDeleteRowFactura.Name = "cmdDeleteRowFactura";
            this.cmdDeleteRowFactura.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdDeleteRowFactura.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdDeleteRowFactura_ButtonClick);
            // 
            // colinventario
            // 
            this.colinventario.Caption = "Inv. Total";
            this.colinventario.DisplayFormat.FormatString = "n2";
            this.colinventario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colinventario.FieldName = "inventario";
            this.colinventario.Name = "colinventario";
            this.colinventario.OptionsColumn.ReadOnly = true;
            this.colinventario.Visible = true;
            this.colinventario.VisibleIndex = 4;
            this.colinventario.Width = 67;
            // 
            // colbodega_descripcion
            // 
            this.colbodega_descripcion.FieldName = "bodega_descripcion";
            this.colbodega_descripcion.Name = "colbodega_descripcion";
            this.colbodega_descripcion.Visible = true;
            this.colbodega_descripcion.VisibleIndex = 5;
            this.colbodega_descripcion.Width = 88;
            // 
            // colGestionAlmacen
            // 
            this.colGestionAlmacen.Caption = "Elejir Almacen";
            this.colGestionAlmacen.ColumnEdit = this.cmdElejirAlmacen;
            this.colGestionAlmacen.Name = "colGestionAlmacen";
            this.colGestionAlmacen.Visible = true;
            this.colGestionAlmacen.VisibleIndex = 6;
            this.colGestionAlmacen.Width = 67;
            // 
            // cmdElejirAlmacen
            // 
            this.cmdElejirAlmacen.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.cmdElejirAlmacen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdElejirAlmacen.Name = "cmdElejirAlmacen";
            this.cmdElejirAlmacen.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdElejirAlmacen.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdElejirAlmacen_ButtonClick);
            // 
            // colinventario_seleccionado
            // 
            this.colinventario_seleccionado.DisplayFormat.FormatString = "n2";
            this.colinventario_seleccionado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colinventario_seleccionado.FieldName = "inventario_seleccionado";
            this.colinventario_seleccionado.Name = "colinventario_seleccionado";
            this.colinventario_seleccionado.OptionsColumn.ReadOnly = true;
            this.colinventario_seleccionado.Width = 58;
            // 
            // colmarca
            // 
            this.colmarca.FieldName = "marca";
            this.colmarca.Name = "colmarca";
            this.colmarca.OptionsColumn.ReadOnly = true;
            this.colmarca.Visible = true;
            this.colmarca.VisibleIndex = 3;
            this.colmarca.Width = 83;
            // 
            // bsBancos
            // 
            this.bsBancos.DataMember = "lista_cuentas";
            this.bsBancos.DataSource = this.dsPedidosClientesV1;
            // 
            // dsPedidosClientesV1
            // 
            this.dsPedidosClientesV1.DataSetName = "dsPedidosClientesV";
            this.dsPedidosClientesV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsTipoPago
            // 
            this.bsTipoPago.DataMember = "tipo_pagos";
            this.bsTipoPago.DataSource = this.dsPedidosClientesV1;
            // 
            // errorProvLecturaCodigo
            // 
            this.errorProvLecturaCodigo.ContainerControl = this;
            // 
            // frmPedidoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 512);
            this.Controls.Add(this.navigationFrame1);
            this.Name = "frmPedidoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pre Factura";
            this.Activated += new System.EventHandler(this.frmPedidoCliente_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPedidoCliente_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCliente.Properties)).EndInit();
            this.panelNotificacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsVentas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckConfirmarPedido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckGenerarCotizacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleEstados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstadosFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidosVentas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsesorVendedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaEntrega.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaEntrega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScanProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDeleteRowFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdElejirAlmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidosClientesV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvLecturaCodigo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtNombreCliente;
        private DevExpress.XtraEditors.SimpleButton cmdAbrirBusqueda;
        private System.Windows.Forms.Label label1;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdDeleteRowFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colinventario;
        private DevExpress.XtraEditors.TextEdit txtDireccion;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colGestionAlmacen;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdElejirAlmacen;
        private DevExpress.XtraGrid.Columns.GridColumn colinventario_seleccionado;
        private JAGUAR_PRO.Despachos.Pedidos.dsPedidosClientesV dsPedidosClientesV1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.MemoEdit txtComentario;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.DateEdit dtFechaEntrega;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bsTipoPago;
        private System.Windows.Forms.BindingSource bsBancos;
        private DevExpress.XtraEditors.TextEdit txtAsesorVendedor;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton cmdChangeVendedor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.GridLookUpEdit gleEstados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private JAGUAR_PRO.Despachos.Pedidos.dsPedidosVentas dsPedidosVentas1;
        private System.Windows.Forms.BindingSource bsEstadosFacturas;
        private DevExpress.XtraGrid.Columns.GridColumn colid2;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraEditors.SimpleButton cmdConfirmarFactura;
        private DevExpress.XtraEditors.CheckEdit ckConfirmarPedido;
        private DevExpress.XtraEditors.CheckEdit ckGenerarCotizacion;
        private DevExpress.XtraEditors.SimpleButton cmdCopiarDesde;
        private System.Windows.Forms.ErrorProvider errorProvLecturaCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_referencia;
        private System.Windows.Forms.RadioButton rdPorCobrar;
        private System.Windows.Forms.RadioButton rdContado;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn colmarca;
        private System.Windows.Forms.RadioButton rdCredito;
        private DevExpress.XtraEditors.SimpleButton cmdSalir2;
    }
}