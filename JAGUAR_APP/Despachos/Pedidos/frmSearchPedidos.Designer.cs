
namespace JAGUAR_PRO.Facturacion.Cotizaciones
{
    partial class frmSearchPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchPedidos));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cmdRefreshDisponibles = new DevExpress.XtraEditors.SimpleButton();
            this.dtFechaHastaDisponibles = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaDesdeDisponibles = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.dsFactCotizacion1 = new JAGUAR_PRO.Facturacion.Cotizaciones.dsFactCotizacion();
            this.dsPedidosClientesV1 = new JAGUAR_PRO.Despachos.Pedidos.dsPedidosClientesV();
            this.grdPedidos = new DevExpress.XtraGrid.GridControl();
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
            this.cmdEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colImprimir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdImprimir = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFactCotizacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidosClientesV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdImprimir)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdRefreshDisponibles
            // 
            this.cmdRefreshDisponibles.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.cmdRefreshDisponibles.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmdRefreshDisponibles.Appearance.Options.UseBackColor = true;
            this.cmdRefreshDisponibles.Appearance.Options.UseFont = true;
            this.cmdRefreshDisponibles.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRefreshDisponibles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRefreshDisponibles.ImageOptions.Image")));
            this.cmdRefreshDisponibles.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdRefreshDisponibles.Location = new System.Drawing.Point(523, 10);
            this.cmdRefreshDisponibles.Name = "cmdRefreshDisponibles";
            this.cmdRefreshDisponibles.Size = new System.Drawing.Size(106, 39);
            this.cmdRefreshDisponibles.TabIndex = 116;
            this.cmdRefreshDisponibles.Text = "Refresh";
            this.cmdRefreshDisponibles.Click += new System.EventHandler(this.cmdRefreshDisponibles_Click);
            // 
            // dtFechaHastaDisponibles
            // 
            this.dtFechaHastaDisponibles.EditValue = null;
            this.dtFechaHastaDisponibles.Location = new System.Drawing.Point(362, 19);
            this.dtFechaHastaDisponibles.Name = "dtFechaHastaDisponibles";
            this.dtFechaHastaDisponibles.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtFechaHastaDisponibles.Properties.Appearance.Options.UseFont = true;
            this.dtFechaHastaDisponibles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHastaDisponibles.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHastaDisponibles.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaHastaDisponibles.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaHastaDisponibles.Size = new System.Drawing.Size(142, 22);
            this.dtFechaHastaDisponibles.TabIndex = 114;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(276, 23);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(80, 16);
            this.labelControl9.TabIndex = 115;
            this.labelControl9.Text = "Fecha Hasta:";
            // 
            // dtFechaDesdeDisponibles
            // 
            this.dtFechaDesdeDisponibles.EditValue = null;
            this.dtFechaDesdeDisponibles.Location = new System.Drawing.Point(115, 19);
            this.dtFechaDesdeDisponibles.Name = "dtFechaDesdeDisponibles";
            this.dtFechaDesdeDisponibles.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtFechaDesdeDisponibles.Properties.Appearance.Options.UseFont = true;
            this.dtFechaDesdeDisponibles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDesdeDisponibles.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDesdeDisponibles.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaDesdeDisponibles.Properties.MinValue = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtFechaDesdeDisponibles.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaDesdeDisponibles.Size = new System.Drawing.Size(142, 22);
            this.dtFechaDesdeDisponibles.TabIndex = 112;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(24, 22);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(85, 16);
            this.labelControl8.TabIndex = 113;
            this.labelControl8.Text = "Fecha Desde:";
            // 
            // dsFactCotizacion1
            // 
            this.dsFactCotizacion1.DataSetName = "dsFactCotizacion";
            this.dsFactCotizacion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsPedidosClientesV1
            // 
            this.dsPedidosClientesV1.DataSetName = "dsPedidosClientesV";
            this.dsPedidosClientesV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdPedidos
            // 
            this.grdPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPedidos.DataMember = "lista_pedidos";
            this.grdPedidos.DataSource = this.dsPedidosClientesV1;
            this.grdPedidos.Location = new System.Drawing.Point(1, 55);
            this.grdPedidos.MainView = this.gridView1;
            this.grdPedidos.Name = "grdPedidos";
            this.grdPedidos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdEditar,
            this.cmdImprimir});
            this.grdPedidos.Size = new System.Drawing.Size(1124, 349);
            this.grdPedidos.TabIndex = 117;
            this.grdPedidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.colImprimir});
            this.gridView1.GridControl = this.grdPedidos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick_1);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // colfecha
            // 
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 0;
            this.colfecha.Width = 82;
            // 
            // colfecha_row
            // 
            this.colfecha_row.FieldName = "fecha_row";
            this.colfecha_row.Name = "colfecha_row";
            this.colfecha_row.OptionsColumn.AllowEdit = false;
            this.colfecha_row.OptionsColumn.ReadOnly = true;
            // 
            // colid_user
            // 
            this.colid_user.FieldName = "id_user";
            this.colid_user.Name = "colid_user";
            this.colid_user.OptionsColumn.AllowEdit = false;
            this.colid_user.OptionsColumn.ReadOnly = true;
            // 
            // colusuario_nombre
            // 
            this.colusuario_nombre.FieldName = "usuario_nombre";
            this.colusuario_nombre.Name = "colusuario_nombre";
            this.colusuario_nombre.OptionsColumn.AllowEdit = false;
            this.colusuario_nombre.OptionsColumn.ReadOnly = true;
            this.colusuario_nombre.Visible = true;
            this.colusuario_nombre.VisibleIndex = 1;
            this.colusuario_nombre.Width = 102;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.AllowEdit = false;
            this.colenable.OptionsColumn.ReadOnly = true;
            // 
            // colcomentario
            // 
            this.colcomentario.FieldName = "comentario";
            this.colcomentario.Name = "colcomentario";
            this.colcomentario.OptionsColumn.AllowEdit = false;
            this.colcomentario.OptionsColumn.ReadOnly = true;
            this.colcomentario.Visible = true;
            this.colcomentario.VisibleIndex = 6;
            this.colcomentario.Width = 182;
            // 
            // colDocNum
            // 
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.OptionsColumn.AllowEdit = false;
            this.colDocNum.OptionsColumn.ReadOnly = true;
            // 
            // colid_estado
            // 
            this.colid_estado.FieldName = "id_estado";
            this.colid_estado.Name = "colid_estado";
            this.colid_estado.OptionsColumn.AllowEdit = false;
            this.colid_estado.OptionsColumn.ReadOnly = true;
            // 
            // colestado_name
            // 
            this.colestado_name.FieldName = "estado_name";
            this.colestado_name.Name = "colestado_name";
            this.colestado_name.OptionsColumn.AllowEdit = false;
            this.colestado_name.OptionsColumn.ReadOnly = true;
            this.colestado_name.Visible = true;
            this.colestado_name.VisibleIndex = 2;
            this.colestado_name.Width = 90;
            // 
            // colid_cliente
            // 
            this.colid_cliente.FieldName = "id_cliente";
            this.colid_cliente.Name = "colid_cliente";
            this.colid_cliente.OptionsColumn.AllowEdit = false;
            this.colid_cliente.OptionsColumn.ReadOnly = true;
            // 
            // colNombreCorto
            // 
            this.colNombreCorto.FieldName = "NombreCorto";
            this.colNombreCorto.Name = "colNombreCorto";
            this.colNombreCorto.OptionsColumn.AllowEdit = false;
            this.colNombreCorto.OptionsColumn.ReadOnly = true;
            this.colNombreCorto.Visible = true;
            this.colNombreCorto.VisibleIndex = 3;
            this.colNombreCorto.Width = 169;
            // 
            // colfecha_entrega_estimada
            // 
            this.colfecha_entrega_estimada.FieldName = "fecha_entrega_estimada";
            this.colfecha_entrega_estimada.Name = "colfecha_entrega_estimada";
            this.colfecha_entrega_estimada.OptionsColumn.AllowEdit = false;
            this.colfecha_entrega_estimada.OptionsColumn.ReadOnly = true;
            this.colfecha_entrega_estimada.Visible = true;
            this.colfecha_entrega_estimada.VisibleIndex = 4;
            this.colfecha_entrega_estimada.Width = 126;
            // 
            // coldireccion
            // 
            this.coldireccion.FieldName = "direccion";
            this.coldireccion.Name = "coldireccion";
            this.coldireccion.OptionsColumn.AllowEdit = false;
            this.coldireccion.OptionsColumn.ReadOnly = true;
            this.coldireccion.Visible = true;
            this.coldireccion.VisibleIndex = 5;
            this.coldireccion.Width = 182;
            // 
            // coltotal
            // 
            this.coltotal.DisplayFormat.FormatString = "n2";
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.AllowEdit = false;
            this.coltotal.OptionsColumn.ReadOnly = true;
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 7;
            this.coltotal.Width = 197;
            // 
            // colEditar
            // 
            this.colEditar.Caption = "Editar";
            this.colEditar.ColumnEdit = this.cmdEditar;
            this.colEditar.Name = "colEditar";
            this.colEditar.OptionsColumn.AllowEdit = false;
            // 
            // cmdEditar
            // 
            this.cmdEditar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colImprimir
            // 
            this.colImprimir.Caption = "Vista Previa";
            this.colImprimir.ColumnEdit = this.cmdImprimir;
            this.colImprimir.Name = "colImprimir";
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdImprimir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmSearchPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 408);
            this.Controls.Add(this.grdPedidos);
            this.Controls.Add(this.cmdRefreshDisponibles);
            this.Controls.Add(this.dtFechaHastaDisponibles);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.dtFechaDesdeDisponibles);
            this.Controls.Add(this.labelControl8);
            this.Name = "frmSearchPedidos";
            this.Text = "Doble Click para seleccionar la Pre Factura";
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFactCotizacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidosClientesV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdImprimir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdRefreshDisponibles;
        private DevExpress.XtraEditors.DateEdit dtFechaHastaDisponibles;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.DateEdit dtFechaDesdeDisponibles;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private dsFactCotizacion dsFactCotizacion1;
        private Despachos.Pedidos.dsPedidosClientesV dsPedidosClientesV1;
        private DevExpress.XtraGrid.GridControl grdPedidos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEditar;
        private DevExpress.XtraGrid.Columns.GridColumn colImprimir;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdImprimir;
    }
}