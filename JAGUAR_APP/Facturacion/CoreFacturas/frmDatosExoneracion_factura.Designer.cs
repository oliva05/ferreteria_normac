namespace JAGUAR_PRO.Facturacion.CoreFacturas
{
    partial class frmDatosExoneracion_factura
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosExoneracion_factura));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsVentas1 = new JAGUAR_PRO.Facturacion.CoreFacturas.dsVentas();
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
            this.grCol_AplicarExo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdAplicarExoneracion = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.txtDireccion = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRTN = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new DevExpress.XtraEditors.TextEdit();
            this.txtRegistroSAG = new DevExpress.XtraEditors.TextEdit();
            this.txtConstancia = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrdenCompra = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdAplicarExoneracionTodaLaFactura = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelarAutorizacionDirecta = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirmarAutorizacionDirecta = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVentas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAplicarExoneracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistroSAG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConstancia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrdenCompra.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(354, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ingrese los datos para exonerar la factura";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "detalle_factura_transaction";
            this.gridControl1.DataSource = this.dsVentas1;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Location = new System.Drawing.Point(2, 155);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdAplicarExoneracion});
            this.gridControl1.Size = new System.Drawing.Size(859, 281);
            this.gridControl1.TabIndex = 21;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsVentas1
            // 
            this.dsVentas1.DataSetName = "dsVentas";
            this.dsVentas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.colinventario,
            this.grCol_AplicarExo});
            this.gridView1.DetailHeight = 182;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.LevelIndent = 0;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 400;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PreviewIndent = 0;
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
            this.coltotal_linea.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total_linea", "SUM={0:n2}")});
            this.coltotal_linea.Visible = true;
            this.coltotal_linea.VisibleIndex = 7;
            this.coltotal_linea.Width = 187;
            // 
            // colDelete
            // 
            this.colDelete.Caption = "Elminar";
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
            // grCol_AplicarExo
            // 
            this.grCol_AplicarExo.Caption = "Aplicar Exoneración";
            this.grCol_AplicarExo.ColumnEdit = this.cmdAplicarExoneracion;
            this.grCol_AplicarExo.Name = "grCol_AplicarExo";
            this.grCol_AplicarExo.Visible = true;
            this.grCol_AplicarExo.VisibleIndex = 8;
            // 
            // cmdAplicarExoneracion
            // 
            this.cmdAplicarExoneracion.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdAplicarExoneracion.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdAplicarExoneracion.Name = "cmdAplicarExoneracion";
            this.cmdAplicarExoneracion.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdAplicarExoneracion.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdAplicarExoneracion_ButtonClick);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(60, 86);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDireccion.Properties.Appearance.Options.UseFont = true;
            this.txtDireccion.Properties.NullValuePrompt = "Direcci del Cliente";
            this.txtDireccion.Properties.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(278, 24);
            this.txtDireccion.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.label3.Location = new System.Drawing.Point(2, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 41;
            this.label3.Text = "Dirección";
            // 
            // txtRTN
            // 
            this.txtRTN.Location = new System.Drawing.Point(60, 59);
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtRTN.Properties.Appearance.Options.UseFont = true;
            this.txtRTN.Properties.NullValuePrompt = "Nombre del Cliente";
            this.txtRTN.Properties.ReadOnly = true;
            this.txtRTN.Size = new System.Drawing.Size(278, 24);
            this.txtRTN.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.label2.Location = new System.Drawing.Point(2, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "RTN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.label1.Location = new System.Drawing.Point(-1, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Cliente";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(60, 32);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNombreCliente.Properties.Appearance.Options.UseFont = true;
            this.txtNombreCliente.Properties.NullValuePrompt = "Nombre del Cliente";
            this.txtNombreCliente.Properties.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(278, 24);
            this.txtNombreCliente.TabIndex = 37;
            // 
            // txtRegistroSAG
            // 
            this.txtRegistroSAG.Location = new System.Drawing.Point(631, 86);
            this.txtRegistroSAG.Name = "txtRegistroSAG";
            this.txtRegistroSAG.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistroSAG.Properties.Appearance.Options.UseFont = true;
            this.txtRegistroSAG.Properties.NullValuePrompt = "Direcci del Cliente";
            this.txtRegistroSAG.Size = new System.Drawing.Size(230, 24);
            this.txtRegistroSAG.TabIndex = 48;
            // 
            // txtConstancia
            // 
            this.txtConstancia.Location = new System.Drawing.Point(631, 59);
            this.txtConstancia.Name = "txtConstancia";
            this.txtConstancia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConstancia.Properties.Appearance.Options.UseFont = true;
            this.txtConstancia.Properties.NullValuePrompt = "Nombre del Cliente";
            this.txtConstancia.Size = new System.Drawing.Size(230, 24);
            this.txtConstancia.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.label6.Location = new System.Drawing.Point(349, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "No. Correlativo de orden de compra exenta";
            // 
            // txtOrdenCompra
            // 
            this.txtOrdenCompra.Location = new System.Drawing.Point(631, 32);
            this.txtOrdenCompra.Name = "txtOrdenCompra";
            this.txtOrdenCompra.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdenCompra.Properties.Appearance.Options.UseFont = true;
            this.txtOrdenCompra.Properties.NullValuePrompt = "Nombre del Cliente";
            this.txtOrdenCompra.Size = new System.Drawing.Size(230, 24);
            this.txtOrdenCompra.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.label7.Location = new System.Drawing.Point(349, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 15);
            this.label7.TabIndex = 49;
            this.label7.Text = "No. Correlativo de constancia de registro exonerado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.label4.Location = new System.Drawing.Point(349, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 15);
            this.label4.TabIndex = 50;
            this.label4.Text = "No. Identificativo del registro de la SAG";
            // 
            // cmdAplicarExoneracionTodaLaFactura
            // 
            this.cmdAplicarExoneracionTodaLaFactura.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAplicarExoneracionTodaLaFactura.ImageOptions.Image")));
            this.cmdAplicarExoneracionTodaLaFactura.Location = new System.Drawing.Point(670, 116);
            this.cmdAplicarExoneracionTodaLaFactura.Name = "cmdAplicarExoneracionTodaLaFactura";
            this.cmdAplicarExoneracionTodaLaFactura.Size = new System.Drawing.Size(191, 34);
            this.cmdAplicarExoneracionTodaLaFactura.TabIndex = 51;
            this.cmdAplicarExoneracionTodaLaFactura.Text = "Aplicar a toda la factura";
            this.cmdAplicarExoneracionTodaLaFactura.Click += new System.EventHandler(this.cmdAplicarExoneracionTodaLaFactura_Click);
            // 
            // btnCancelarAutorizacionDirecta
            // 
            this.btnCancelarAutorizacionDirecta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelarAutorizacionDirecta.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAutorizacionDirecta.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarAutorizacionDirecta.Appearance.Options.UseFont = true;
            this.btnCancelarAutorizacionDirecta.Appearance.Options.UseForeColor = true;
            this.btnCancelarAutorizacionDirecta.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnCancelarAutorizacionDirecta.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancelarAutorizacionDirecta.ImageOptions.SvgImage")));
            this.btnCancelarAutorizacionDirecta.Location = new System.Drawing.Point(434, 441);
            this.btnCancelarAutorizacionDirecta.Name = "btnCancelarAutorizacionDirecta";
            this.btnCancelarAutorizacionDirecta.Size = new System.Drawing.Size(110, 37);
            this.btnCancelarAutorizacionDirecta.TabIndex = 52;
            this.btnCancelarAutorizacionDirecta.Text = "Cancelar";
            this.btnCancelarAutorizacionDirecta.Click += new System.EventHandler(this.btnCancelarAutorizacionDirecta_Click);
            // 
            // btnConfirmarAutorizacionDirecta
            // 
            this.btnConfirmarAutorizacionDirecta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirmarAutorizacionDirecta.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(130)))), ((int)(((byte)(195)))));
            this.btnConfirmarAutorizacionDirecta.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarAutorizacionDirecta.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarAutorizacionDirecta.Appearance.Options.UseBackColor = true;
            this.btnConfirmarAutorizacionDirecta.Appearance.Options.UseFont = true;
            this.btnConfirmarAutorizacionDirecta.Appearance.Options.UseForeColor = true;
            this.btnConfirmarAutorizacionDirecta.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnConfirmarAutorizacionDirecta.ImageOptions.Image = global::JAGUAR_PRO.Properties.Resources.check_mark_24X24;
            this.btnConfirmarAutorizacionDirecta.Location = new System.Drawing.Point(315, 441);
            this.btnConfirmarAutorizacionDirecta.Name = "btnConfirmarAutorizacionDirecta";
            this.btnConfirmarAutorizacionDirecta.Size = new System.Drawing.Size(110, 37);
            this.btnConfirmarAutorizacionDirecta.TabIndex = 53;
            this.btnConfirmarAutorizacionDirecta.Text = "Confirmar";
            this.btnConfirmarAutorizacionDirecta.Click += new System.EventHandler(this.btnConfirmarAutorizacionDirecta_Click);
            // 
            // frmDatosExoneracion_factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 480);
            this.Controls.Add(this.btnCancelarAutorizacionDirecta);
            this.Controls.Add(this.btnConfirmarAutorizacionDirecta);
            this.Controls.Add(this.cmdAplicarExoneracionTodaLaFactura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRegistroSAG);
            this.Controls.Add(this.txtConstancia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOrdenCompra);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmDatosExoneracion_factura";
            this.Text = "Datos Exoneración de  Factura";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVentas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAplicarExoneracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistroSAG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConstancia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrdenCompra.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colinventario;
        private DevExpress.XtraEditors.TextEdit txtDireccion;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtRTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtNombreCliente;
        private DevExpress.XtraEditors.TextEdit txtRegistroSAG;
        private DevExpress.XtraEditors.TextEdit txtConstancia;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtOrdenCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private dsVentas dsVentas1;
        private DevExpress.XtraEditors.SimpleButton cmdAplicarExoneracionTodaLaFactura;
        private DevExpress.XtraEditors.SimpleButton btnCancelarAutorizacionDirecta;
        private DevExpress.XtraEditors.SimpleButton btnConfirmarAutorizacionDirecta;
        private DevExpress.XtraGrid.Columns.GridColumn grCol_AplicarExo;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdAplicarExoneracion;
    }
}