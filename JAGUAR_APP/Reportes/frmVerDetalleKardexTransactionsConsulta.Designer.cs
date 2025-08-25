using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace JAGUAR_PRO.Reportes
{
    partial class frmVerDetalleKardexTransactionsConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerDetalleKardexTransactionsConsulta));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cmdRecargar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsKardexReportes1 = new JAGUAR_PRO.Reportes.dsKardexReportes();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_reg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tipo_transaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaDoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_aprueba_ajuste = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdImprimir = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoTransaccion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.colalmacen_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colalmacen_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKardexReportes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoTransaccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdRecargar
            // 
            this.cmdRecargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRecargar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRecargar.Appearance.Options.UseFont = true;
            this.cmdRecargar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRecargar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdRecargar.ImageOptions.SvgImage")));
            this.cmdRecargar.Location = new System.Drawing.Point(812, 12);
            this.cmdRecargar.Name = "cmdRecargar";
            this.cmdRecargar.Size = new System.Drawing.Size(104, 39);
            this.cmdRecargar.TabIndex = 10;
            this.cmdRecargar.Text = "Recargar";
            this.cmdRecargar.Click += new System.EventHandler(this.cmdRecargar_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(922, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(104, 39);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Excel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(1032, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 38);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "detalle_transacciones_kardex";
            this.gridControl1.DataSource = this.dsKardexReportes1;
            this.gridControl1.Location = new System.Drawing.Point(3, 57);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdImprimir});
            this.gridControl1.Size = new System.Drawing.Size(1128, 458);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsKardexReportes1
            // 
            this.dsKardexReportes1.DataSetName = "dsKardexReportes";
            this.dsKardexReportes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colfecha_reg,
            this.colNumDocumento,
            this.colid_tipo_transaccion,
            this.colTipo,
            this.colenable,
            this.colenable_descripcion,
            this.colid_pt,
            this.colItemCode,
            this.colItemName,
            this.colid_usuario,
            this.colUsuario,
            this.colFechaDoc,
            this.colEntrada,
            this.colSalida,
            this.colusuario_aprueba_ajuste,
            this.colPrint,
            this.colalmacen_codigo,
            this.colalmacen_nombre});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // colfecha_reg
            // 
            this.colfecha_reg.Caption = "Fecha Transacción";
            this.colfecha_reg.DisplayFormat.FormatString = "g";
            this.colfecha_reg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_reg.FieldName = "fecha_reg";
            this.colfecha_reg.Name = "colfecha_reg";
            this.colfecha_reg.OptionsColumn.ReadOnly = true;
            this.colfecha_reg.Visible = true;
            this.colfecha_reg.VisibleIndex = 0;
            this.colfecha_reg.Width = 97;
            // 
            // colNumDocumento
            // 
            this.colNumDocumento.FieldName = "NumDocumento";
            this.colNumDocumento.Name = "colNumDocumento";
            this.colNumDocumento.OptionsColumn.ReadOnly = true;
            this.colNumDocumento.Visible = true;
            this.colNumDocumento.VisibleIndex = 2;
            this.colNumDocumento.Width = 88;
            // 
            // colid_tipo_transaccion
            // 
            this.colid_tipo_transaccion.FieldName = "id_tipo_transaccion";
            this.colid_tipo_transaccion.Name = "colid_tipo_transaccion";
            this.colid_tipo_transaccion.OptionsColumn.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.Caption = "Tipo Transacción";
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.OptionsColumn.ReadOnly = true;
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 1;
            this.colTipo.Width = 88;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.ReadOnly = true;
            // 
            // colenable_descripcion
            // 
            this.colenable_descripcion.FieldName = "enable_descripcion";
            this.colenable_descripcion.Name = "colenable_descripcion";
            this.colenable_descripcion.OptionsColumn.ReadOnly = true;
            this.colenable_descripcion.Visible = true;
            this.colenable_descripcion.VisibleIndex = 3;
            this.colenable_descripcion.Width = 95;
            // 
            // colid_pt
            // 
            this.colid_pt.FieldName = "id_pt";
            this.colid_pt.Name = "colid_pt";
            this.colid_pt.OptionsColumn.ReadOnly = true;
            // 
            // colItemCode
            // 
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.ReadOnly = true;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 4;
            // 
            // colItemName
            // 
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.ReadOnly = true;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 5;
            this.colItemName.Width = 154;
            // 
            // colid_usuario
            // 
            this.colid_usuario.FieldName = "id_usuario";
            this.colid_usuario.Name = "colid_usuario";
            this.colid_usuario.OptionsColumn.ReadOnly = true;
            // 
            // colUsuario
            // 
            this.colUsuario.FieldName = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.OptionsColumn.ReadOnly = true;
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 6;
            this.colUsuario.Width = 93;
            // 
            // colFechaDoc
            // 
            this.colFechaDoc.FieldName = "FechaDoc";
            this.colFechaDoc.Name = "colFechaDoc";
            this.colFechaDoc.OptionsColumn.ReadOnly = true;
            this.colFechaDoc.Visible = true;
            this.colFechaDoc.VisibleIndex = 8;
            this.colFechaDoc.Width = 67;
            // 
            // colEntrada
            // 
            this.colEntrada.DisplayFormat.FormatString = "n0";
            this.colEntrada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colEntrada.FieldName = "Entrada";
            this.colEntrada.Name = "colEntrada";
            this.colEntrada.OptionsColumn.ReadOnly = true;
            this.colEntrada.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Entrada", "SUM={0:n0}")});
            this.colEntrada.Visible = true;
            this.colEntrada.VisibleIndex = 9;
            this.colEntrada.Width = 80;
            // 
            // colSalida
            // 
            this.colSalida.DisplayFormat.FormatString = "n0";
            this.colSalida.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalida.FieldName = "Salida";
            this.colSalida.Name = "colSalida";
            this.colSalida.OptionsColumn.ReadOnly = true;
            this.colSalida.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Salida", "SUM={0:n0}")});
            this.colSalida.Visible = true;
            this.colSalida.VisibleIndex = 10;
            this.colSalida.Width = 88;
            // 
            // colusuario_aprueba_ajuste
            // 
            this.colusuario_aprueba_ajuste.FieldName = "usuario_aprueba_ajuste";
            this.colusuario_aprueba_ajuste.Name = "colusuario_aprueba_ajuste";
            this.colusuario_aprueba_ajuste.OptionsColumn.ReadOnly = true;
            this.colusuario_aprueba_ajuste.Visible = true;
            this.colusuario_aprueba_ajuste.VisibleIndex = 7;
            this.colusuario_aprueba_ajuste.Width = 85;
            // 
            // colPrint
            // 
            this.colPrint.Caption = "Imprimir";
            this.colPrint.ColumnEdit = this.cmdImprimir;
            this.colPrint.Name = "colPrint";
            this.colPrint.Visible = true;
            this.colPrint.VisibleIndex = 13;
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdImprimir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdImprimir.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdImprimir_ButtonClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(209, 25);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Detalle de Transacciones";
            // 
            // txtCodigoTransaccion
            // 
            this.txtCodigoTransaccion.Location = new System.Drawing.Point(604, 25);
            this.txtCodigoTransaccion.Name = "txtCodigoTransaccion";
            this.txtCodigoTransaccion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtCodigoTransaccion.Properties.Appearance.Options.UseFont = true;
            this.txtCodigoTransaccion.Size = new System.Drawing.Size(202, 26);
            this.txtCodigoTransaccion.TabIndex = 19;
            this.txtCodigoTransaccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit1_KeyDown);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(603, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(203, 24);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Ingrese el código de transacción";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // colalmacen_codigo
            // 
            this.colalmacen_codigo.FieldName = "almacen_codigo";
            this.colalmacen_codigo.Name = "colalmacen_codigo";
            this.colalmacen_codigo.OptionsColumn.ReadOnly = true;
            this.colalmacen_codigo.Visible = true;
            this.colalmacen_codigo.VisibleIndex = 11;
            // 
            // colalmacen_nombre
            // 
            this.colalmacen_nombre.FieldName = "almacen_nombre";
            this.colalmacen_nombre.Name = "colalmacen_nombre";
            this.colalmacen_nombre.OptionsColumn.ReadOnly = true;
            this.colalmacen_nombre.Visible = true;
            this.colalmacen_nombre.VisibleIndex = 12;
            // 
            // frmVerDetalleKardexTransactionsConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 516);
            this.Controls.Add(this.txtCodigoTransaccion);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cmdRecargar);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnClose);
            this.Name = "frmVerDetalleKardexTransactionsConsulta";
            this.Text = "Detalle Transacciones Kardex Item";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKardexReportes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoTransaccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdRecargar;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private GridControl gridControl1;
        private GridView gridView1;
        private LabelControl labelControl1;
        private dsKardexReportes dsKardexReportes1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_reg;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo_transaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colenable_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colid_usuario;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaDoc;
        private DevExpress.XtraGrid.Columns.GridColumn colEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colSalida;
        private DevExpress.XtraGrid.Columns.GridColumn colNumDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_aprueba_ajuste;
        private DevExpress.XtraGrid.Columns.GridColumn colPrint;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdImprimir;
        private TextEdit txtCodigoTransaccion;
        private LabelControl labelControl4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraGrid.Columns.GridColumn colalmacen_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colalmacen_nombre;
    }
}