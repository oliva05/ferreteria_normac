namespace JAGUAR_PRO.Facturacion.Entrega
{
    partial class frmEntregaGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntregaGestion));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_detalle_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitem_code1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_ingresada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsEntregaPedidos1 = new JAGUAR_PRO.Facturacion.Entrega.dsEntregaPedidos();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_h = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_referencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_entregada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_pendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentregar_todo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_a_entregar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtClienteNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtNumDocumento = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtBodega = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtDireccion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigBarra = new DevExpress.XtraEditors.TextEdit();
            this.txtNumFactura = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEntregaPedidos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBodega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigBarra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumFactura.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colid_detalle_factura,
            this.colitem_code1,
            this.coldescripcion1,
            this.colcantidad_ingresada,
            this.colid_user,
            this.colusuario,
            this.colfecha});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // colid_detalle_factura
            // 
            this.colid_detalle_factura.FieldName = "id_detalle_factura";
            this.colid_detalle_factura.Name = "colid_detalle_factura";
            // 
            // colitem_code1
            // 
            this.colitem_code1.Caption = "Item Code";
            this.colitem_code1.FieldName = "item_code";
            this.colitem_code1.Name = "colitem_code1";
            this.colitem_code1.OptionsColumn.ReadOnly = true;
            this.colitem_code1.Visible = true;
            this.colitem_code1.VisibleIndex = 0;
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.Caption = "Item Name";
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.OptionsColumn.ReadOnly = true;
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 1;
            // 
            // colcantidad_ingresada
            // 
            this.colcantidad_ingresada.Caption = "Cant Ingresada";
            this.colcantidad_ingresada.DisplayFormat.FormatString = "n2";
            this.colcantidad_ingresada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcantidad_ingresada.FieldName = "cantidad_ingresada";
            this.colcantidad_ingresada.Name = "colcantidad_ingresada";
            this.colcantidad_ingresada.OptionsColumn.ReadOnly = true;
            this.colcantidad_ingresada.Visible = true;
            this.colcantidad_ingresada.VisibleIndex = 2;
            // 
            // colid_user
            // 
            this.colid_user.FieldName = "id_user";
            this.colid_user.Name = "colid_user";
            // 
            // colusuario
            // 
            this.colusuario.Caption = "Usuario";
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            this.colusuario.OptionsColumn.ReadOnly = true;
            this.colusuario.Visible = true;
            this.colusuario.VisibleIndex = 3;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.DisplayFormat.FormatString = "g";
            this.colfecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "detalle_entrega_gestion";
            this.gridControl1.DataSource = this.dsEntregaPedidos1;
            this.gridControl1.Location = new System.Drawing.Point(4, 163);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1515, 621);
            this.gridControl1.TabIndex = 76;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView1});
            // 
            // dsEntregaPedidos1
            // 
            this.dsEntregaPedidos1.DataSetName = "dsEntregaPedidos";
            this.dsEntregaPedidos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_pt,
            this.colcantidad,
            this.colid_h,
            this.colprecio,
            this.colid_estado,
            this.colbodega,
            this.colid_bodega,
            this.colcode,
            this.colcode_referencia,
            this.coldescripcion,
            this.colcant_entregada,
            this.colcant_pendiente,
            this.colentregar_todo,
            this.colcant_a_entregar});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView2_RowStyle);
            this.gridView2.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanged);
            this.gridView2.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanging);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colid_pt
            // 
            this.colid_pt.FieldName = "id_pt";
            this.colid_pt.Name = "colid_pt";
            this.colid_pt.OptionsColumn.AllowEdit = false;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad Facturada";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 2;
            this.colcantidad.Width = 217;
            // 
            // colid_h
            // 
            this.colid_h.FieldName = "id_h";
            this.colid_h.Name = "colid_h";
            this.colid_h.OptionsColumn.AllowEdit = false;
            this.colid_h.Width = 109;
            // 
            // colprecio
            // 
            this.colprecio.FieldName = "precio";
            this.colprecio.Name = "colprecio";
            this.colprecio.OptionsColumn.AllowEdit = false;
            this.colprecio.Width = 109;
            // 
            // colid_estado
            // 
            this.colid_estado.FieldName = "id_estado";
            this.colid_estado.Name = "colid_estado";
            this.colid_estado.OptionsColumn.AllowEdit = false;
            this.colid_estado.Width = 109;
            // 
            // colbodega
            // 
            this.colbodega.FieldName = "bodega";
            this.colbodega.Name = "colbodega";
            this.colbodega.OptionsColumn.AllowEdit = false;
            this.colbodega.Width = 109;
            // 
            // colid_bodega
            // 
            this.colid_bodega.FieldName = "id_bodega";
            this.colid_bodega.Name = "colid_bodega";
            this.colid_bodega.OptionsColumn.AllowEdit = false;
            this.colid_bodega.Width = 109;
            // 
            // colcode
            // 
            this.colcode.Caption = "Codigo del Producto";
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.OptionsColumn.AllowEdit = false;
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 0;
            this.colcode.Width = 166;
            // 
            // colcode_referencia
            // 
            this.colcode_referencia.FieldName = "code_referencia";
            this.colcode_referencia.Name = "colcode_referencia";
            this.colcode_referencia.OptionsColumn.AllowEdit = false;
            this.colcode_referencia.Width = 109;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripcion del Producto";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            this.coldescripcion.Width = 266;
            // 
            // colcant_entregada
            // 
            this.colcant_entregada.Caption = "Cantidad Entregada";
            this.colcant_entregada.FieldName = "cant_entregada";
            this.colcant_entregada.Name = "colcant_entregada";
            this.colcant_entregada.OptionsColumn.AllowEdit = false;
            this.colcant_entregada.Visible = true;
            this.colcant_entregada.VisibleIndex = 3;
            this.colcant_entregada.Width = 217;
            // 
            // colcant_pendiente
            // 
            this.colcant_pendiente.Caption = "Pendiente de Entrega";
            this.colcant_pendiente.FieldName = "cant_pendiente";
            this.colcant_pendiente.Name = "colcant_pendiente";
            this.colcant_pendiente.OptionsColumn.AllowEdit = false;
            this.colcant_pendiente.Visible = true;
            this.colcant_pendiente.VisibleIndex = 5;
            this.colcant_pendiente.Width = 217;
            // 
            // colentregar_todo
            // 
            this.colentregar_todo.Caption = "Entregar Todo";
            this.colentregar_todo.FieldName = "entregar_todo";
            this.colentregar_todo.Name = "colentregar_todo";
            this.colentregar_todo.Visible = true;
            this.colentregar_todo.VisibleIndex = 6;
            this.colentregar_todo.Width = 216;
            // 
            // colcant_a_entregar
            // 
            this.colcant_a_entregar.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.colcant_a_entregar.AppearanceCell.Options.UseBackColor = true;
            this.colcant_a_entregar.Caption = "Cantidad por Entregar";
            this.colcant_a_entregar.FieldName = "cant_a_entregar";
            this.colcant_a_entregar.Name = "colcant_a_entregar";
            this.colcant_a_entregar.Visible = true;
            this.colcant_a_entregar.VisibleIndex = 4;
            this.colcant_a_entregar.Width = 189;
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.Enabled = false;
            this.txtClienteNombre.Location = new System.Drawing.Point(113, 100);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteNombre.Properties.Appearance.Options.UseFont = true;
            this.txtClienteNombre.Properties.ReadOnly = true;
            this.txtClienteNombre.Size = new System.Drawing.Size(276, 24);
            this.txtClienteNombre.TabIndex = 71;
            // 
            // txtNumDocumento
            // 
            this.txtNumDocumento.Enabled = false;
            this.txtNumDocumento.Location = new System.Drawing.Point(113, 72);
            this.txtNumDocumento.Name = "txtNumDocumento";
            this.txtNumDocumento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDocumento.Properties.Appearance.Options.UseFont = true;
            this.txtNumDocumento.Properties.ReadOnly = true;
            this.txtNumDocumento.Size = new System.Drawing.Size(276, 24);
            this.txtNumDocumento.TabIndex = 70;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(11, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(146, 17);
            this.labelControl2.TabIndex = 69;
            this.labelControl2.Text = "No de Doc________________";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(11, 107);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(107, 17);
            this.labelControl5.TabIndex = 68;
            this.labelControl5.Text = "Cliente____________:";
            // 
            // txtBodega
            // 
            this.txtBodega.Enabled = false;
            this.txtBodega.Location = new System.Drawing.Point(113, 14);
            this.txtBodega.Name = "txtBodega";
            this.txtBodega.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodega.Properties.Appearance.Options.UseFont = true;
            this.txtBodega.Properties.ReadOnly = true;
            this.txtBodega.Size = new System.Drawing.Size(162, 24);
            this.txtBodega.TabIndex = 66;
            this.txtBodega.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(11, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(146, 17);
            this.labelControl1.TabIndex = 65;
            this.labelControl1.Text = "Bodega Entrega_________:";
            this.labelControl1.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Appearance.Options.UseFont = true;
            this.lblTitulo.Appearance.Options.UseTextOptions = true;
            this.lblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitulo.Location = new System.Drawing.Point(4, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1515, 25);
            this.lblTitulo.TabIndex = 67;
            this.lblTitulo.Text = "Entrega de Producto";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdGuardar.ImageOptions.SvgImage")));
            this.cmdGuardar.Location = new System.Drawing.Point(1148, 12);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(170, 45);
            this.cmdGuardar.TabIndex = 72;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.LightCoral;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1348, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(161, 45);
            this.simpleButton1.TabIndex = 73;
            this.simpleButton1.Text = "Home";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(113, 130);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Properties.Appearance.Options.UseFont = true;
            this.txtDireccion.Properties.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(276, 24);
            this.txtDireccion.TabIndex = 75;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(11, 137);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(122, 17);
            this.labelControl3.TabIndex = 74;
            this.labelControl3.Text = "Direccion____________:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(450, 132);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(215, 21);
            this.labelControl4.TabIndex = 77;
            this.labelControl4.Text = "Escanear Producto__________:";
            // 
            // txtCodigBarra
            // 
            this.txtCodigBarra.Location = new System.Drawing.Point(611, 125);
            this.txtCodigBarra.Name = "txtCodigBarra";
            this.txtCodigBarra.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigBarra.Properties.Appearance.Options.UseFont = true;
            this.txtCodigBarra.Size = new System.Drawing.Size(276, 28);
            this.txtCodigBarra.TabIndex = 78;
            this.txtCodigBarra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigBarra_KeyDown);
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.Location = new System.Drawing.Point(113, 42);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumFactura.Properties.Appearance.Options.UseFont = true;
            this.txtNumFactura.Properties.ReadOnly = true;
            this.txtNumFactura.Size = new System.Drawing.Size(276, 24);
            this.txtNumFactura.TabIndex = 80;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(11, 49);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(118, 17);
            this.labelControl6.TabIndex = 79;
            this.labelControl6.Text = "Num Factura_______:";
            // 
            // frmEntregaGestion
            // 
            this.Appearance.BackColor = System.Drawing.Color.FloralWhite;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 788);
            this.Controls.Add(this.txtNumFactura);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtCodigBarra);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.txtClienteNombre);
            this.Controls.Add(this.txtNumDocumento);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtBodega);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblTitulo);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmEntregaGestion";
            this.Text = "Entrega Gestion";
            this.Shown += new System.EventHandler(this.frmEntregaGestion_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEntregaPedidos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBodega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigBarra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumFactura.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtClienteNombre;
        private DevExpress.XtraEditors.TextEdit txtNumDocumento;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtBodega;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblTitulo;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtDireccion;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_detalle_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colitem_code1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_ingresada;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCodigBarra;
        private DevExpress.XtraEditors.TextEdit txtNumFactura;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private dsEntregaPedidos dsEntregaPedidos1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colid_h;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega;
        private DevExpress.XtraGrid.Columns.GridColumn colid_bodega;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_referencia;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_entregada;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_pendiente;
        private DevExpress.XtraGrid.Columns.GridColumn colentregar_todo;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_a_entregar;
    }
}