﻿
using DevExpress.XtraEditors;

namespace JAGUAR_PRO.Reportes
{
    partial class frmReporteGeneralProductoTerminado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteGeneralProductoTerminado));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.dsReportesInventario1 = new JAGUAR_PRO.Reportes.dsReportesInventario();
            this.grd_inventario = new DevExpress.XtraGrid.GridControl();
            this.grdv_inventario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_pt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_pt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_in1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_out1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_in1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_out1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_referencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdVerDetalle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colAlmacenCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomprometido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldisponible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlmacenName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRecargar = new DevExpress.XtraEditors.SimpleButton();
            this.tggVerSoloMayorA_Cero = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdAgregarAjuste_ = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSolicitarAjusteInventario = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesInventario1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_inventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_inventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggVerSoloMayorA_Cero.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Location = new System.Drawing.Point(1163, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 47);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dsReportesInventario1
            // 
            this.dsReportesInventario1.DataSetName = "dsReportesInventario";
            this.dsReportesInventario1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grd_inventario
            // 
            this.grd_inventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_inventario.DataMember = "inventario_kardex_pt";
            this.grd_inventario.DataSource = this.dsReportesInventario1;
            this.grd_inventario.Location = new System.Drawing.Point(3, 62);
            this.grd_inventario.MainView = this.grdv_inventario;
            this.grd_inventario.Name = "grd_inventario";
            this.grd_inventario.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdVerDetalle});
            this.grd_inventario.Size = new System.Drawing.Size(1264, 442);
            this.grd_inventario.TabIndex = 0;
            this.grd_inventario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_inventario});
            // 
            // grdv_inventario
            // 
            this.grdv_inventario.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdv_inventario.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_inventario.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_inventario.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_inventario.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_inventario.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_inventario.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario.Appearance.Preview.Options.UseFont = true;
            this.grdv_inventario.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_inventario.Appearance.Row.Options.UseFont = true;
            this.grdv_inventario.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_inventario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_pt1,
            this.colProducto1,
            this.collote_pt1,
            this.colcantidad_in1,
            this.colcantidad_out1,
            this.colpeso_in1,
            this.colpeso_out1,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.colcosto,
            this.colcode,
            this.colcode_referencia,
            this.colVerDetalle,
            this.colAlmacenCode,
            this.colcomprometido,
            this.coldisponible,
            this.colAlmacenName});
            this.grdv_inventario.GridControl = this.grd_inventario;
            this.grdv_inventario.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_kg", null, "(Kilogramos: SUMA={0:0.##.##} Kg)"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_unidades", null, "(Unidades en Existencia: SUMA={0:0.##.##} Ud)"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_tm", null, "(TM Existencia: SUMA={0:0.##.##} TM)")});
            this.grdv_inventario.Name = "grdv_inventario";
            this.grdv_inventario.OptionsEditForm.PopupEditFormWidth = 686;
            this.grdv_inventario.OptionsView.ShowAutoFilterRow = true;
            this.grdv_inventario.OptionsView.ShowFooter = true;
            this.grdv_inventario.OptionsView.ShowGroupPanel = false;
            // 
            // colid_pt1
            // 
            this.colid_pt1.FieldName = "id_pt";
            this.colid_pt1.Name = "colid_pt1";
            // 
            // colProducto1
            // 
            this.colProducto1.Caption = "N Producto";
            this.colProducto1.FieldName = "PT";
            this.colProducto1.Name = "colProducto1";
            this.colProducto1.OptionsColumn.AllowEdit = false;
            this.colProducto1.OptionsColumn.ReadOnly = true;
            this.colProducto1.Visible = true;
            this.colProducto1.VisibleIndex = 4;
            this.colProducto1.Width = 251;
            // 
            // collote_pt1
            // 
            this.collote_pt1.Caption = "# Lote";
            this.collote_pt1.FieldName = "lote";
            this.collote_pt1.Name = "collote_pt1";
            this.collote_pt1.OptionsColumn.AllowEdit = false;
            this.collote_pt1.OptionsColumn.ReadOnly = true;
            // 
            // colcantidad_in1
            // 
            this.colcantidad_in1.Caption = "Cantidad Entrada";
            this.colcantidad_in1.DisplayFormat.FormatString = "{0:0.##.##} Ud";
            this.colcantidad_in1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcantidad_in1.FieldName = "cantidad_in";
            this.colcantidad_in1.Name = "colcantidad_in1";
            this.colcantidad_in1.OptionsColumn.AllowEdit = false;
            // 
            // colcantidad_out1
            // 
            this.colcantidad_out1.Caption = "Cantidad Salida";
            this.colcantidad_out1.DisplayFormat.FormatString = "{0:0.##.##} Ud";
            this.colcantidad_out1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcantidad_out1.FieldName = "cantidad_out";
            this.colcantidad_out1.Name = "colcantidad_out1";
            this.colcantidad_out1.OptionsColumn.AllowEdit = false;
            // 
            // colpeso_in1
            // 
            this.colpeso_in1.Caption = "Peso Entrada";
            this.colpeso_in1.DisplayFormat.FormatString = "{0:0.##.##} Kg";
            this.colpeso_in1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpeso_in1.FieldName = "peso_in";
            this.colpeso_in1.Name = "colpeso_in1";
            this.colpeso_in1.OptionsColumn.AllowEdit = false;
            // 
            // colpeso_out1
            // 
            this.colpeso_out1.Caption = "Peso Salida";
            this.colpeso_out1.DisplayFormat.FormatString = "{0:0.##.##} Kg";
            this.colpeso_out1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpeso_out1.FieldName = "peso_out";
            this.colpeso_out1.Name = "colpeso_out1";
            this.colpeso_out1.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Existencia";
            this.gridColumn1.FieldName = "existencia";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 143;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Presentacion";
            this.gridColumn2.FieldName = "presentacion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            this.gridColumn2.Width = 162;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Factor";
            this.gridColumn3.FieldName = "factor";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            // 
            // colcosto
            // 
            this.colcosto.DisplayFormat.FormatString = "n4";
            this.colcosto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcosto.FieldName = "costo";
            this.colcosto.Name = "colcosto";
            this.colcosto.OptionsColumn.ReadOnly = true;
            this.colcosto.Visible = true;
            this.colcosto.VisibleIndex = 9;
            this.colcosto.Width = 105;
            // 
            // colcode
            // 
            this.colcode.Caption = "Código";
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.OptionsColumn.ReadOnly = true;
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 2;
            this.colcode.Width = 59;
            // 
            // colcode_referencia
            // 
            this.colcode_referencia.Caption = "Cod. Referencia";
            this.colcode_referencia.FieldName = "code_referencia";
            this.colcode_referencia.Name = "colcode_referencia";
            this.colcode_referencia.OptionsColumn.ReadOnly = true;
            this.colcode_referencia.Visible = true;
            this.colcode_referencia.VisibleIndex = 3;
            this.colcode_referencia.Width = 98;
            // 
            // colVerDetalle
            // 
            this.colVerDetalle.Caption = "Ver Detalle";
            this.colVerDetalle.ColumnEdit = this.cmdVerDetalle;
            this.colVerDetalle.Name = "colVerDetalle";
            this.colVerDetalle.Visible = true;
            this.colVerDetalle.VisibleIndex = 10;
            this.colVerDetalle.Width = 76;
            // 
            // cmdVerDetalle
            // 
            this.cmdVerDetalle.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdVerDetalle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdVerDetalle.Name = "cmdVerDetalle";
            this.cmdVerDetalle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdVerDetalle.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdVerDetalle_ButtonClick);
            // 
            // colAlmacenCode
            // 
            this.colAlmacenCode.FieldName = "AlmacenCode";
            this.colAlmacenCode.Name = "colAlmacenCode";
            this.colAlmacenCode.OptionsColumn.ReadOnly = true;
            this.colAlmacenCode.Visible = true;
            this.colAlmacenCode.VisibleIndex = 0;
            this.colAlmacenCode.Width = 49;
            // 
            // colcomprometido
            // 
            this.colcomprometido.Caption = "Comprometido";
            this.colcomprometido.FieldName = "comprometido";
            this.colcomprometido.Name = "colcomprometido";
            this.colcomprometido.OptionsColumn.ReadOnly = true;
            this.colcomprometido.Visible = true;
            this.colcomprometido.VisibleIndex = 7;
            this.colcomprometido.Width = 120;
            // 
            // coldisponible
            // 
            this.coldisponible.Caption = "Disponible";
            this.coldisponible.FieldName = "disponible";
            this.coldisponible.Name = "coldisponible";
            this.coldisponible.OptionsColumn.ReadOnly = true;
            this.coldisponible.Visible = true;
            this.coldisponible.VisibleIndex = 8;
            this.coldisponible.Width = 98;
            // 
            // colAlmacenName
            // 
            this.colAlmacenName.FieldName = "AlmacenName";
            this.colAlmacenName.Name = "colAlmacenName";
            this.colAlmacenName.OptionsColumn.ReadOnly = true;
            this.colAlmacenName.Visible = true;
            this.colAlmacenName.VisibleIndex = 1;
            this.colAlmacenName.Width = 76;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1053, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(104, 47);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Excel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmdRecargar
            // 
            this.cmdRecargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRecargar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRecargar.Appearance.Options.UseFont = true;
            this.cmdRecargar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRecargar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdRecargar.ImageOptions.SvgImage")));
            this.cmdRecargar.Location = new System.Drawing.Point(943, 9);
            this.cmdRecargar.Name = "cmdRecargar";
            this.cmdRecargar.Size = new System.Drawing.Size(104, 47);
            this.cmdRecargar.TabIndex = 7;
            this.cmdRecargar.Text = "Recargar";
            this.cmdRecargar.Click += new System.EventHandler(this.cmdRecargar_Click);
            // 
            // tggVerSoloMayorA_Cero
            // 
            this.tggVerSoloMayorA_Cero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tggVerSoloMayorA_Cero.Location = new System.Drawing.Point(842, 34);
            this.tggVerSoloMayorA_Cero.Name = "tggVerSoloMayorA_Cero";
            this.tggVerSoloMayorA_Cero.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tggVerSoloMayorA_Cero.Properties.Appearance.Options.UseFont = true;
            this.tggVerSoloMayorA_Cero.Properties.OffText = "No";
            this.tggVerSoloMayorA_Cero.Properties.OnText = "Si";
            this.tggVerSoloMayorA_Cero.Size = new System.Drawing.Size(95, 24);
            this.tggVerSoloMayorA_Cero.TabIndex = 8;
            this.tggVerSoloMayorA_Cero.Toggled += new System.EventHandler(this.tggVerSoloMayorA_Cero_Toggled);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(718, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(118, 17);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Ver con INV en cero";
            // 
            // cmdAgregarAjuste_
            // 
            this.cmdAgregarAjuste_.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregarAjuste_.Appearance.Options.UseFont = true;
            this.cmdAgregarAjuste_.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAgregarAjuste_.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdAgregarAjuste_.ImageOptions.SvgImage")));
            this.cmdAgregarAjuste_.Location = new System.Drawing.Point(201, 12);
            this.cmdAgregarAjuste_.Name = "cmdAgregarAjuste_";
            this.cmdAgregarAjuste_.Size = new System.Drawing.Size(192, 47);
            this.cmdAgregarAjuste_.TabIndex = 60;
            this.cmdAgregarAjuste_.Text = "Nuevo Ajuste de Inventario";
            this.cmdAgregarAjuste_.Click += new System.EventHandler(this.cmdAgregarAjuste__Click);
            // 
            // cmdSolicitarAjusteInventario
            // 
            this.cmdSolicitarAjusteInventario.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSolicitarAjusteInventario.Appearance.Options.UseFont = true;
            this.cmdSolicitarAjusteInventario.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSolicitarAjusteInventario.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdSolicitarAjusteInventario.ImageOptions.SvgImage")));
            this.cmdSolicitarAjusteInventario.Location = new System.Drawing.Point(3, 12);
            this.cmdSolicitarAjusteInventario.Name = "cmdSolicitarAjusteInventario";
            this.cmdSolicitarAjusteInventario.Size = new System.Drawing.Size(192, 47);
            this.cmdSolicitarAjusteInventario.TabIndex = 61;
            this.cmdSolicitarAjusteInventario.Text = "Solicitar Ajuste de Inventario";
            this.cmdSolicitarAjusteInventario.Click += new System.EventHandler(this.cmdSolicitarAjusteInventario_Click);
            // 
            // frmReporteGeneralProductoTerminado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 506);
            this.Controls.Add(this.cmdSolicitarAjusteInventario);
            this.Controls.Add(this.cmdAgregarAjuste_);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tggVerSoloMayorA_Cero);
            this.Controls.Add(this.grd_inventario);
            this.Controls.Add(this.cmdRecargar);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnClose);
            this.Name = "frmReporteGeneralProductoTerminado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte General de Producto Terminado.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesInventario1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_inventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_inventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggVerSoloMayorA_Cero.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.GridControl grd_inventario;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_inventario;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private dsReportesInventario dsReportesInventario1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt1;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto1;
        private DevExpress.XtraGrid.Columns.GridColumn collote_pt1;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_in1;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_out1;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_in1;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_out1;
        private DevExpress.XtraEditors.SimpleButton cmdRecargar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colcosto;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private ToggleSwitch tggVerSoloMayorA_Cero;
        private LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colVerDetalle;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdVerDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colAlmacenCode;
        private DevExpress.XtraGrid.Columns.GridColumn colAlmacenName;
        private SimpleButton cmdAgregarAjuste_;
        private SimpleButton cmdSolicitarAjusteInventario;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_referencia;
        private DevExpress.XtraGrid.Columns.GridColumn colcomprometido;
        private DevExpress.XtraGrid.Columns.GridColumn coldisponible;
    }
}