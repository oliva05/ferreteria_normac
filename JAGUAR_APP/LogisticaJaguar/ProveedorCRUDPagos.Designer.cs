namespace JAGUAR_PRO.LogisticaJaguar
{
    partial class ProveedorCRUDPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveedorCRUDPagos));
            this.grdProveedor = new DevExpress.XtraEditors.GridLookUpEdit();
            this.proveedoreslistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLogisticaJaguar1 = new JAGUAR_PRO.LogisticaJaguar.dsLogisticaJaguar();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.grdDetalleFacturas = new DevExpress.XtraGrid.GridControl();
            this.grdvDetalleFacturas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_registro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto_pagado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto_pendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto_a_pagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdClose = new DevExpress.XtraEditors.DropDownButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMontoPagar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.grdTipoPago = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tipopagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkAll = new DevExpress.XtraEditors.CheckEdit();
            this.txtObs = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMontoDisponible = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoreslistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogisticaJaguar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvDetalleFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoPagar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipopagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoDisponible.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProveedor
            // 
            this.grdProveedor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grdProveedor.EditValue = "";
            this.grdProveedor.Location = new System.Drawing.Point(534, 28);
            this.grdProveedor.Name = "grdProveedor";
            this.grdProveedor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdProveedor.Properties.Appearance.Options.UseFont = true;
            this.grdProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdProveedor.Properties.DataSource = this.proveedoreslistBindingSource;
            this.grdProveedor.Properties.DisplayMember = "descripcion";
            this.grdProveedor.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdProveedor.Properties.ValueMember = "id";
            this.grdProveedor.Size = new System.Drawing.Size(332, 26);
            this.grdProveedor.TabIndex = 42;
            this.grdProveedor.EditValueChanged += new System.EventHandler(this.grdProveedor_EditValueChanged);
            // 
            // proveedoreslistBindingSource
            // 
            this.proveedoreslistBindingSource.DataMember = "proveedores_list";
            this.proveedoreslistBindingSource.DataSource = this.dsLogisticaJaguar1;
            // 
            // dsLogisticaJaguar1
            // 
            this.dsLogisticaJaguar1.DataSetName = "dsLogisticaJaguar";
            this.dsLogisticaJaguar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.coldescripcion1});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.LevelIndent = 0;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.PreviewIndent = 0;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(422, 31);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 20);
            this.labelControl4.TabIndex = 41;
            this.labelControl4.Text = "Proveedor";
            // 
            // grdDetalleFacturas
            // 
            this.grdDetalleFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDetalleFacturas.DataMember = "detalle_factura";
            this.grdDetalleFacturas.DataSource = this.dsLogisticaJaguar1;
            this.grdDetalleFacturas.Location = new System.Drawing.Point(2, 219);
            this.grdDetalleFacturas.MainView = this.grdvDetalleFacturas;
            this.grdDetalleFacturas.Name = "grdDetalleFacturas";
            this.grdDetalleFacturas.Size = new System.Drawing.Size(1295, 516);
            this.grdDetalleFacturas.TabIndex = 43;
            this.grdDetalleFacturas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvDetalleFacturas});
            // 
            // grdvDetalleFacturas
            // 
            this.grdvDetalleFacturas.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdvDetalleFacturas.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdvDetalleFacturas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcai,
            this.colfactura,
            this.colfecha_factura,
            this.colfecha_registro,
            this.colobservacion,
            this.colDocNum,
            this.colmonto_factura,
            this.colmonto_pagado,
            this.colmonto_pendiente,
            this.colmonto_a_pagar,
            this.colseleccionar});
            this.grdvDetalleFacturas.GridControl = this.grdDetalleFacturas;
            this.grdvDetalleFacturas.Name = "grdvDetalleFacturas";
            this.grdvDetalleFacturas.OptionsView.ShowFooter = true;
            this.grdvDetalleFacturas.OptionsView.ShowGroupPanel = false;
            this.grdvDetalleFacturas.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdvDetalleFacturas_CellValueChanged);
            this.grdvDetalleFacturas.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdvDetalleFacturas_CellValueChanging);
            this.grdvDetalleFacturas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdvDetalleFacturas_KeyDown);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // colcai
            // 
            this.colcai.Caption = "CAI";
            this.colcai.FieldName = "cai";
            this.colcai.Name = "colcai";
            this.colcai.OptionsColumn.ReadOnly = true;
            this.colcai.Visible = true;
            this.colcai.VisibleIndex = 2;
            this.colcai.Width = 125;
            // 
            // colfactura
            // 
            this.colfactura.Caption = "# Factura";
            this.colfactura.FieldName = "factura";
            this.colfactura.Name = "colfactura";
            this.colfactura.OptionsColumn.ReadOnly = true;
            this.colfactura.Visible = true;
            this.colfactura.VisibleIndex = 1;
            this.colfactura.Width = 152;
            // 
            // colfecha_factura
            // 
            this.colfecha_factura.Caption = "Fecha Factura";
            this.colfecha_factura.FieldName = "fecha_factura";
            this.colfecha_factura.Name = "colfecha_factura";
            this.colfecha_factura.OptionsColumn.ReadOnly = true;
            this.colfecha_factura.Visible = true;
            this.colfecha_factura.VisibleIndex = 3;
            this.colfecha_factura.Width = 99;
            // 
            // colfecha_registro
            // 
            this.colfecha_registro.Caption = "Fecha Registro";
            this.colfecha_registro.FieldName = "fecha_registro";
            this.colfecha_registro.Name = "colfecha_registro";
            this.colfecha_registro.OptionsColumn.ReadOnly = true;
            this.colfecha_registro.Visible = true;
            this.colfecha_registro.VisibleIndex = 4;
            this.colfecha_registro.Width = 97;
            // 
            // colobservacion
            // 
            this.colobservacion.Caption = "Observacion";
            this.colobservacion.FieldName = "observacion";
            this.colobservacion.Name = "colobservacion";
            this.colobservacion.Visible = true;
            this.colobservacion.VisibleIndex = 5;
            this.colobservacion.Width = 145;
            // 
            // colDocNum
            // 
            this.colDocNum.Caption = "# Documento";
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.OptionsColumn.ReadOnly = true;
            this.colDocNum.Visible = true;
            this.colDocNum.VisibleIndex = 0;
            this.colDocNum.Width = 91;
            // 
            // colmonto_factura
            // 
            this.colmonto_factura.Caption = "Monto Factura";
            this.colmonto_factura.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colmonto_factura.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmonto_factura.FieldName = "monto_factura";
            this.colmonto_factura.Name = "colmonto_factura";
            this.colmonto_factura.OptionsColumn.ReadOnly = true;
            this.colmonto_factura.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "monto_factura", "SUM={0:#,###,##0.00}")});
            this.colmonto_factura.Visible = true;
            this.colmonto_factura.VisibleIndex = 6;
            this.colmonto_factura.Width = 100;
            // 
            // colmonto_pagado
            // 
            this.colmonto_pagado.Caption = "Monto Pagado";
            this.colmonto_pagado.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colmonto_pagado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmonto_pagado.FieldName = "monto_pagado";
            this.colmonto_pagado.Name = "colmonto_pagado";
            this.colmonto_pagado.OptionsColumn.ReadOnly = true;
            this.colmonto_pagado.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "monto_pagado", "SUM={0:#,###,##0.00}")});
            this.colmonto_pagado.Visible = true;
            this.colmonto_pagado.VisibleIndex = 7;
            this.colmonto_pagado.Width = 100;
            // 
            // colmonto_pendiente
            // 
            this.colmonto_pendiente.Caption = "Monto Pendiente";
            this.colmonto_pendiente.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colmonto_pendiente.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmonto_pendiente.FieldName = "monto_pendiente";
            this.colmonto_pendiente.Name = "colmonto_pendiente";
            this.colmonto_pendiente.OptionsColumn.ReadOnly = true;
            this.colmonto_pendiente.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "monto_pendiente", "SUM={0:#,###,##0.00}")});
            this.colmonto_pendiente.Visible = true;
            this.colmonto_pendiente.VisibleIndex = 8;
            this.colmonto_pendiente.Width = 117;
            // 
            // colmonto_a_pagar
            // 
            this.colmonto_a_pagar.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.colmonto_a_pagar.AppearanceCell.Options.UseBackColor = true;
            this.colmonto_a_pagar.Caption = "Por Pagar";
            this.colmonto_a_pagar.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colmonto_a_pagar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmonto_a_pagar.FieldName = "monto_a_pagar";
            this.colmonto_a_pagar.Name = "colmonto_a_pagar";
            this.colmonto_a_pagar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "monto_a_pagar", "SUM={0:#,###,##0.00}")});
            this.colmonto_a_pagar.Visible = true;
            this.colmonto_a_pagar.VisibleIndex = 9;
            this.colmonto_a_pagar.Width = 112;
            // 
            // colseleccionar
            // 
            this.colseleccionar.Caption = "Seleccionar";
            this.colseleccionar.FieldName = "seleccionar";
            this.colseleccionar.Name = "colseleccionar";
            this.colseleccionar.Visible = true;
            this.colseleccionar.VisibleIndex = 10;
            this.colseleccionar.Width = 130;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(12, 21);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(108, 41);
            this.cmdGuardar.TabIndex = 50;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.ToolTipTitle = "Guardar Entrada de Factura";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmdClose.Appearance.Options.UseFont = true;
            this.cmdClose.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.cmdClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdClose.ImageOptions.SvgImage")));
            this.cmdClose.Location = new System.Drawing.Point(1181, 21);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(108, 41);
            this.cmdClose.TabIndex = 99;
            this.cmdClose.Text = "Cerrar";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(422, 110);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 20);
            this.labelControl1.TabIndex = 100;
            this.labelControl1.Text = "Monto a Pagar";
            // 
            // txtMontoPagar
            // 
            this.txtMontoPagar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMontoPagar.Location = new System.Drawing.Point(534, 104);
            this.txtMontoPagar.Name = "txtMontoPagar";
            this.txtMontoPagar.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtMontoPagar.Properties.Appearance.Options.UseFont = true;
            this.txtMontoPagar.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtMontoPagar.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtMontoPagar.Properties.MaskSettings.Set("mask", "n3");
            this.txtMontoPagar.Properties.UseMaskAsDisplayFormat = true;
            this.txtMontoPagar.Size = new System.Drawing.Size(159, 26);
            this.txtMontoPagar.TabIndex = 101;
            this.txtMontoPagar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMontoPagar_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(422, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 20);
            this.labelControl2.TabIndex = 102;
            this.labelControl2.Text = "Tipo de Pago";
            // 
            // grdTipoPago
            // 
            this.grdTipoPago.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grdTipoPago.Location = new System.Drawing.Point(534, 66);
            this.grdTipoPago.Name = "grdTipoPago";
            this.grdTipoPago.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdTipoPago.Properties.Appearance.Options.UseFont = true;
            this.grdTipoPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdTipoPago.Properties.DataSource = this.tipopagosBindingSource;
            this.grdTipoPago.Properties.DisplayMember = "descripcion";
            this.grdTipoPago.Properties.NullText = "";
            this.grdTipoPago.Properties.PopupView = this.gridView1;
            this.grdTipoPago.Properties.ValueMember = "id";
            this.grdTipoPago.Size = new System.Drawing.Size(198, 26);
            this.grdTipoPago.TabIndex = 103;
            this.grdTipoPago.EditValueChanged += new System.EventHandler(this.grdTipoPago_EditValueChanged);
            // 
            // tipopagosBindingSource
            // 
            this.tipopagosBindingSource.DataMember = "tipo_pagos";
            this.tipopagosBindingSource.DataSource = this.dsLogisticaJaguar1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid2,
            this.coldescripcion});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // chkAll
            // 
            this.chkAll.Location = new System.Drawing.Point(1133, 181);
            this.chkAll.Name = "chkAll";
            this.chkAll.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.chkAll.Properties.Appearance.Options.UseFont = true;
            this.chkAll.Properties.Caption = "Selec. Automatica";
            this.chkAll.Size = new System.Drawing.Size(156, 24);
            this.chkAll.TabIndex = 104;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // txtObs
            // 
            this.txtObs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtObs.Location = new System.Drawing.Point(534, 140);
            this.txtObs.Name = "txtObs";
            this.txtObs.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtObs.Properties.Appearance.Options.UseFont = true;
            this.txtObs.Size = new System.Drawing.Size(274, 65);
            this.txtObs.TabIndex = 105;
            this.txtObs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtObs_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(422, 185);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 20);
            this.labelControl3.TabIndex = 106;
            this.labelControl3.Text = "Observacion";
            // 
            // txtMontoDisponible
            // 
            this.txtMontoDisponible.Enabled = false;
            this.txtMontoDisponible.Location = new System.Drawing.Point(882, 187);
            this.txtMontoDisponible.Name = "txtMontoDisponible";
            this.txtMontoDisponible.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtMontoDisponible.Properties.Appearance.Options.UseFont = true;
            this.txtMontoDisponible.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtMontoDisponible.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtMontoDisponible.Properties.MaskSettings.Set("mask", "n3");
            this.txtMontoDisponible.Properties.UseMaskAsDisplayFormat = true;
            this.txtMontoDisponible.Size = new System.Drawing.Size(159, 26);
            this.txtMontoDisponible.TabIndex = 107;
            this.txtMontoDisponible.Visible = false;
            // 
            // ProveedorCRUDPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 737);
            this.Controls.Add(this.txtMontoDisponible);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.grdTipoPago);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMontoPagar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.grdDetalleFacturas);
            this.Controls.Add(this.grdProveedor);
            this.Controls.Add(this.labelControl4);
            this.Name = "ProveedorCRUDPagos";
            ((System.ComponentModel.ISupportInitialize)(this.grdProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoreslistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogisticaJaguar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvDetalleFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoPagar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipopagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoDisponible.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit grdProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl grdDetalleFacturas;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvDetalleFacturas;
        private dsLogisticaJaguar dsLogisticaJaguar1;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.DropDownButton cmdClose;
        private System.Windows.Forms.BindingSource proveedoreslistBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcai;
        private DevExpress.XtraGrid.Columns.GridColumn colfactura;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_registro;
        private DevExpress.XtraGrid.Columns.GridColumn colobservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto_pagado;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto_pendiente;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto_a_pagar;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMontoPagar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit grdTipoPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tipopagosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid2;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraEditors.CheckEdit chkAll;
        private DevExpress.XtraEditors.MemoEdit txtObs;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtMontoDisponible;
    }
}