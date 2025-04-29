namespace JAGUAR_PRO.Despachos.Pedidos
{
    partial class frmCotizaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCotizaciones));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cmdCargar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsPrefacturas1 = new JAGUAR_PRO.Despachos.Pedidos.dsPrefacturas();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_row = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCorto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_entrega_estimada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImprimir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdPrintCotizacion = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrefacturas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPrintCotizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCargar
            // 
            this.cmdCargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCargar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdCargar.Appearance.Options.UseFont = true;
            this.cmdCargar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCargar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCargar.ImageOptions.Image")));
            this.cmdCargar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdCargar.Location = new System.Drawing.Point(620, 9);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(94, 35);
            this.cmdCargar.TabIndex = 108;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(720, 9);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(94, 35);
            this.btnAtras.TabIndex = 107;
            this.btnAtras.Text = "Cerrar";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(103, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(158, 34);
            this.labelControl1.TabIndex = 110;
            this.labelControl1.Text = "Cotizaciones";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAgregar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAgregar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAgregar.ImageOptions.SvgImage")));
            this.btnAgregar.Location = new System.Drawing.Point(3, 9);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 35);
            this.btnAgregar.TabIndex = 109;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "lista_cotizaciones";
            this.gridControl1.DataSource = this.dsPrefacturas1;
            this.gridControl1.Location = new System.Drawing.Point(3, 50);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdPrintCotizacion});
            this.gridControl1.Size = new System.Drawing.Size(811, 349);
            this.gridControl1.TabIndex = 111;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsPrefacturas1
            // 
            this.dsPrefacturas1.DataSetName = "dsPrefacturas";
            this.dsPrefacturas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colfecha,
            this.colfecha_row,
            this.colid_user,
            this.colusuario_nombre,
            this.colenable,
            this.colcomentario,
            this.colDocNum,
            this.colid_estado,
            this.colestado_name,
            this.colid_cliente,
            this.colNombreCorto,
            this.colfecha_entrega_estimada,
            this.coldireccion,
            this.coltotal,
            this.colEditar,
            this.colImprimir,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // colfecha
            // 
            this.colfecha.DisplayFormat.FormatString = "g";
            this.colfecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 0;
            this.colfecha.Width = 115;
            // 
            // colfecha_row
            // 
            this.colfecha_row.FieldName = "fecha_row";
            this.colfecha_row.Name = "colfecha_row";
            this.colfecha_row.OptionsColumn.ReadOnly = true;
            // 
            // colid_user
            // 
            this.colid_user.FieldName = "id_user";
            this.colid_user.Name = "colid_user";
            this.colid_user.OptionsColumn.ReadOnly = true;
            // 
            // colusuario_nombre
            // 
            this.colusuario_nombre.FieldName = "usuario_nombre";
            this.colusuario_nombre.Name = "colusuario_nombre";
            this.colusuario_nombre.OptionsColumn.ReadOnly = true;
            this.colusuario_nombre.Visible = true;
            this.colusuario_nombre.VisibleIndex = 1;
            this.colusuario_nombre.Width = 89;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.ReadOnly = true;
            // 
            // colcomentario
            // 
            this.colcomentario.FieldName = "comentario";
            this.colcomentario.Name = "colcomentario";
            this.colcomentario.OptionsColumn.ReadOnly = true;
            this.colcomentario.Visible = true;
            this.colcomentario.VisibleIndex = 4;
            this.colcomentario.Width = 159;
            // 
            // colDocNum
            // 
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.OptionsColumn.ReadOnly = true;
            // 
            // colid_estado
            // 
            this.colid_estado.FieldName = "id_estado";
            this.colid_estado.Name = "colid_estado";
            this.colid_estado.OptionsColumn.ReadOnly = true;
            // 
            // colestado_name
            // 
            this.colestado_name.FieldName = "estado_name";
            this.colestado_name.Name = "colestado_name";
            this.colestado_name.OptionsColumn.ReadOnly = true;
            this.colestado_name.Visible = true;
            this.colestado_name.VisibleIndex = 2;
            this.colestado_name.Width = 78;
            // 
            // colid_cliente
            // 
            this.colid_cliente.FieldName = "id_cliente";
            this.colid_cliente.Name = "colid_cliente";
            this.colid_cliente.OptionsColumn.ReadOnly = true;
            // 
            // colNombreCorto
            // 
            this.colNombreCorto.FieldName = "NombreCorto";
            this.colNombreCorto.Name = "colNombreCorto";
            this.colNombreCorto.OptionsColumn.ReadOnly = true;
            this.colNombreCorto.Visible = true;
            this.colNombreCorto.VisibleIndex = 3;
            this.colNombreCorto.Width = 163;
            // 
            // colfecha_entrega_estimada
            // 
            this.colfecha_entrega_estimada.FieldName = "fecha_entrega_estimada";
            this.colfecha_entrega_estimada.Name = "colfecha_entrega_estimada";
            this.colfecha_entrega_estimada.OptionsColumn.ReadOnly = true;
            this.colfecha_entrega_estimada.Width = 78;
            // 
            // coldireccion
            // 
            this.coldireccion.FieldName = "direccion";
            this.coldireccion.Name = "coldireccion";
            this.coldireccion.OptionsColumn.ReadOnly = true;
            this.coldireccion.Width = 103;
            // 
            // coltotal
            // 
            this.coltotal.DisplayFormat.FormatString = "n2";
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.ReadOnly = true;
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 5;
            this.coltotal.Width = 102;
            // 
            // colEditar
            // 
            this.colEditar.Caption = "Editar";
            this.colEditar.Name = "colEditar";
            // 
            // colImprimir
            // 
            this.colImprimir.Caption = "Vista Previa";
            this.colImprimir.ColumnEdit = this.cmdPrintCotizacion;
            this.colImprimir.Name = "colImprimir";
            this.colImprimir.Visible = true;
            this.colImprimir.VisibleIndex = 6;
            this.colImprimir.Width = 78;
            // 
            // cmdPrintCotizacion
            // 
            this.cmdPrintCotizacion.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdPrintCotizacion.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdPrintCotizacion.Name = "cmdPrintCotizacion";
            this.cmdPrintCotizacion.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdPrintCotizacion.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdPrintCotizacion_ButtonClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ver Cotización";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // frmCotizaciones
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 402);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.btnAtras);
            this.Name = "frmCotizaciones";
            this.Text = "Cotizaciones";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrefacturas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPrintCotizacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdCargar;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsPrefacturas dsPrefacturas1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_row;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colcomentario;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colestado_name;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCorto;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_entrega_estimada;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn colEditar;
        private DevExpress.XtraGrid.Columns.GridColumn colImprimir;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdPrintCotizacion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}