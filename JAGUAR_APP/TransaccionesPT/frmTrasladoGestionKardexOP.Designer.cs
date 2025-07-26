namespace JAGUAR_PRO.TransaccionesPT
{
    partial class frmTrasladoGestionKardexOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrasladoGestionKardexOP));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsPT1 = new JAGUAR_PRO.TransaccionesPT.dsPT();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_trasladar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_fisica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_enviada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_pendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_detalle_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitem_code1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_ingresada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checMarcarTodo = new System.Windows.Forms.CheckBox();
            this.txtNumTraslado = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtBodOrigen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtBodDestino = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescr = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumTraslado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBodOrigen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBodDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescr.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.simpleButton1.Location = new System.Drawing.Point(1230, 21);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(161, 45);
            this.simpleButton1.TabIndex = 76;
            this.simpleButton1.Text = "Home";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
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
            this.cmdGuardar.Location = new System.Drawing.Point(1039, 21);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(170, 45);
            this.cmdGuardar.TabIndex = 75;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Appearance.Options.UseFont = true;
            this.lblTitulo.Appearance.Options.UseTextOptions = true;
            this.lblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitulo.Location = new System.Drawing.Point(2, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1389, 25);
            this.lblTitulo.TabIndex = 74;
            this.lblTitulo.Text = "Traslado Entre Bodegas";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "almacen_destino";
            this.gridControl1.DataSource = this.dsPT1;
            this.gridControl1.Location = new System.Drawing.Point(2, 174);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1389, 488);
            this.gridControl1.TabIndex = 77;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView1});
            // 
            // dsPT1
            // 
            this.dsPT1.DataSetName = "dsPT";
            this.dsPT1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_pt,
            this.colitemcode,
            this.coldescripcion,
            this.colexistencia,
            this.colcantidad_trasladar,
            this.colid,
            this.colcantidad_fisica,
            this.colseleccion,
            this.colcantidad_enviada,
            this.colcantidad_pendiente});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanging);
            // 
            // colid_pt
            // 
            this.colid_pt.FieldName = "id_pt";
            this.colid_pt.Name = "colid_pt";
            this.colid_pt.OptionsColumn.AllowEdit = false;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Codigo";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 0;
            this.colitemcode.Width = 107;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripcion del Producto";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            this.coldescripcion.Width = 397;
            // 
            // colexistencia
            // 
            this.colexistencia.FieldName = "existencia";
            this.colexistencia.Name = "colexistencia";
            this.colexistencia.OptionsColumn.AllowEdit = false;
            // 
            // colcantidad_trasladar
            // 
            this.colcantidad_trasladar.Caption = "Cantidad segun Requisa";
            this.colcantidad_trasladar.FieldName = "cantidad_trasladar";
            this.colcantidad_trasladar.Name = "colcantidad_trasladar";
            this.colcantidad_trasladar.OptionsColumn.AllowEdit = false;
            this.colcantidad_trasladar.Visible = true;
            this.colcantidad_trasladar.VisibleIndex = 2;
            this.colcantidad_trasladar.Width = 227;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colcantidad_fisica
            // 
            this.colcantidad_fisica.Caption = "Cantidad Fisica por Entregar";
            this.colcantidad_fisica.FieldName = "cantidad_fisica";
            this.colcantidad_fisica.Name = "colcantidad_fisica";
            this.colcantidad_fisica.Visible = true;
            this.colcantidad_fisica.VisibleIndex = 5;
            this.colcantidad_fisica.Width = 201;
            // 
            // colseleccion
            // 
            this.colseleccion.Caption = "Seleccionado";
            this.colseleccion.FieldName = "seleccion";
            this.colseleccion.Name = "colseleccion";
            this.colseleccion.Visible = true;
            this.colseleccion.VisibleIndex = 6;
            this.colseleccion.Width = 106;
            // 
            // colcantidad_enviada
            // 
            this.colcantidad_enviada.Caption = "Cantidad Trasladada";
            this.colcantidad_enviada.FieldName = "cantidad_enviada";
            this.colcantidad_enviada.Name = "colcantidad_enviada";
            this.colcantidad_enviada.OptionsColumn.AllowEdit = false;
            this.colcantidad_enviada.Visible = true;
            this.colcantidad_enviada.VisibleIndex = 3;
            this.colcantidad_enviada.Width = 158;
            // 
            // colcantidad_pendiente
            // 
            this.colcantidad_pendiente.Caption = "Cantidad Pendiente";
            this.colcantidad_pendiente.FieldName = "cantidad_pendiente";
            this.colcantidad_pendiente.Name = "colcantidad_pendiente";
            this.colcantidad_pendiente.Visible = true;
            this.colcantidad_pendiente.VisibleIndex = 4;
            this.colcantidad_pendiente.Width = 166;
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
            // checMarcarTodo
            // 
            this.checMarcarTodo.AutoSize = true;
            this.checMarcarTodo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checMarcarTodo.Location = new System.Drawing.Point(1260, 147);
            this.checMarcarTodo.Name = "checMarcarTodo";
            this.checMarcarTodo.Size = new System.Drawing.Size(121, 22);
            this.checMarcarTodo.TabIndex = 78;
            this.checMarcarTodo.Text = "Marca Todos";
            this.checMarcarTodo.UseVisualStyleBackColor = true;
            this.checMarcarTodo.CheckedChanged += new System.EventHandler(this.checMarcarTodo_CheckedChanged);
            // 
            // txtNumTraslado
            // 
            this.txtNumTraslado.Enabled = false;
            this.txtNumTraslado.Location = new System.Drawing.Point(135, 42);
            this.txtNumTraslado.Name = "txtNumTraslado";
            this.txtNumTraslado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTraslado.Properties.Appearance.Options.UseFont = true;
            this.txtNumTraslado.Properties.ReadOnly = true;
            this.txtNumTraslado.Size = new System.Drawing.Size(162, 24);
            this.txtNumTraslado.TabIndex = 80;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(140, 17);
            this.labelControl1.TabIndex = 79;
            this.labelControl1.Text = "Num. Traslado_________:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(135, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Properties.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(162, 24);
            this.txtUsuario.TabIndex = 82;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(150, 17);
            this.labelControl2.TabIndex = 81;
            this.labelControl2.Text = "Usuario Conectado______:";
            // 
            // txtBodOrigen
            // 
            this.txtBodOrigen.Enabled = false;
            this.txtBodOrigen.Location = new System.Drawing.Point(135, 144);
            this.txtBodOrigen.Name = "txtBodOrigen";
            this.txtBodOrigen.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodOrigen.Properties.Appearance.Options.UseFont = true;
            this.txtBodOrigen.Properties.ReadOnly = true;
            this.txtBodOrigen.Size = new System.Drawing.Size(162, 24);
            this.txtBodOrigen.TabIndex = 84;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 151);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(133, 17);
            this.labelControl3.TabIndex = 83;
            this.labelControl3.Text = "Bod. Origen___________:";
            // 
            // txtBodDestino
            // 
            this.txtBodDestino.Enabled = false;
            this.txtBodDestino.Location = new System.Drawing.Point(435, 144);
            this.txtBodDestino.Name = "txtBodDestino";
            this.txtBodDestino.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodDestino.Properties.Appearance.Options.UseFont = true;
            this.txtBodDestino.Properties.ReadOnly = true;
            this.txtBodDestino.Size = new System.Drawing.Size(162, 24);
            this.txtBodDestino.TabIndex = 86;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(333, 151);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(129, 17);
            this.labelControl4.TabIndex = 85;
            this.labelControl4.Text = "Bod. Destino_________:";
            // 
            // txtDescr
            // 
            this.txtDescr.Enabled = false;
            this.txtDescr.Location = new System.Drawing.Point(135, 72);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDescr.Properties.Appearance.Options.UseFont = true;
            this.txtDescr.Size = new System.Drawing.Size(265, 66);
            this.txtDescr.TabIndex = 87;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 73);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(136, 17);
            this.labelControl5.TabIndex = 88;
            this.labelControl5.Text = "Comentario____________:";
            // 
            // frmTrasladoGestionKardexOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 664);
            this.Controls.Add(this.txtDescr);
            this.Controls.Add(this.txtBodDestino);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtBodOrigen);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtNumTraslado);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.checMarcarTodo);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.labelControl5);
            this.Name = "frmTrasladoGestionKardexOP";
            this.Text = "frmTrasladoGestionKardexOP";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumTraslado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBodOrigen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBodDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescr.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.LabelControl lblTitulo;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_detalle_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colitem_code1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_ingresada;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private System.Windows.Forms.CheckBox checMarcarTodo;
        private DevExpress.XtraEditors.TextEdit txtNumTraslado;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtBodOrigen;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtBodDestino;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit txtDescr;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private dsPT dsPT1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_trasladar;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_fisica;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccion;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_enviada;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_pendiente;
    }
}