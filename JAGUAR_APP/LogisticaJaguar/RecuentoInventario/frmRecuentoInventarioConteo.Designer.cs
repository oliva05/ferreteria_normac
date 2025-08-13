namespace JAGUAR_PRO.LogisticaJaguar.RecuentoInventario
{
    partial class frmRecuentoInventarioConteo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuentoInventarioConteo));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.grdConteo = new DevExpress.XtraGrid.GridControl();
            this.grdvConteo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dsRecuento1 = new JAGUAR_PRO.LogisticaJaguar.RecuentoInventario.dsRecuento();
            this.gleAlmacen = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bodegasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRecepcionMP = new JAGUAR_PRO.LogisticaJaguar.dsRecepcionMP();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_almacen1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtRecuento = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaConta = new DevExpress.XtraEditors.DateEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.colid_detalle_recuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_recuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_referencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_sistema = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconteo_fisico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconteo_completado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCompletar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConteo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvConteo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecuento1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleAlmacen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecuento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaConta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaConta.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "StatusBar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "StatusBar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1316, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 799);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1316, 18);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 799);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1316, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 799);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // grdConteo
            // 
            this.grdConteo.DataMember = "conteo_recuento";
            this.grdConteo.DataSource = this.dsRecuento1;
            this.grdConteo.Location = new System.Drawing.Point(0, 125);
            this.grdConteo.MainView = this.grdvConteo;
            this.grdConteo.Name = "grdConteo";
            this.grdConteo.Size = new System.Drawing.Size(1316, 674);
            this.grdConteo.TabIndex = 4;
            this.grdConteo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvConteo});
            // 
            // grdvConteo
            // 
            this.grdvConteo.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdvConteo.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdvConteo.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdvConteo.Appearance.Row.Options.UseFont = true;
            this.grdvConteo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_detalle_recuento,
            this.colid_recuento,
            this.colid_pt,
            this.colpt,
            this.colcode_pt,
            this.colcode_referencia,
            this.colcantidad_sistema,
            this.colid_bodega,
            this.colbodega,
            this.colconteo_fisico,
            this.colconteo_completado});
            this.grdvConteo.GridControl = this.grdConteo;
            this.grdvConteo.Name = "grdvConteo";
            this.grdvConteo.OptionsView.ShowAutoFilterRow = true;
            this.grdvConteo.OptionsView.ShowGroupPanel = false;
            // 
            // dsRecuento1
            // 
            this.dsRecuento1.DataSetName = "dsRecuento";
            this.dsRecuento1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gleAlmacen
            // 
            this.gleAlmacen.Location = new System.Drawing.Point(120, 81);
            this.gleAlmacen.Name = "gleAlmacen";
            this.gleAlmacen.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gleAlmacen.Properties.Appearance.Options.UseFont = true;
            this.gleAlmacen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleAlmacen.Properties.DataSource = this.bodegasBindingSource;
            this.gleAlmacen.Properties.DisplayMember = "descripcion";
            this.gleAlmacen.Properties.NullText = "";
            this.gleAlmacen.Properties.PopupView = this.gridLookUpEdit1View;
            this.gleAlmacen.Properties.ValueMember = "id";
            this.gleAlmacen.Size = new System.Drawing.Size(215, 26);
            this.gleAlmacen.TabIndex = 182;
            this.gleAlmacen.EditValueChanged += new System.EventHandler(this.gleAlmacen_EditValueChanged);
            // 
            // bodegasBindingSource
            // 
            this.bodegasBindingSource.DataMember = "bodegas";
            this.bodegasBindingSource.DataSource = this.dsRecepcionMP;
            // 
            // dsRecepcionMP
            // 
            this.dsRecepcionMP.DataSetName = "dsRecepcionMP";
            this.dsRecepcionMP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_almacen1,
            this.coldescripcion1,
            this.colexistencia1});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid_almacen1
            // 
            this.colid_almacen1.FieldName = "id_almacen";
            this.colid_almacen1.Name = "colid_almacen1";
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.Caption = "Bodega";
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 0;
            // 
            // colexistencia1
            // 
            this.colexistencia1.Caption = "Existencia";
            this.colexistencia1.FieldName = "existencia";
            this.colexistencia1.Name = "colexistencia1";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(31, 84);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(103, 20);
            this.labelControl4.TabIndex = 181;
            this.labelControl4.Text = "Almacen ____";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(31, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 20);
            this.labelControl1.TabIndex = 183;
            this.labelControl1.Text = "# Recuento__";
            // 
            // txtRecuento
            // 
            this.txtRecuento.Enabled = false;
            this.txtRecuento.Location = new System.Drawing.Point(120, 33);
            this.txtRecuento.Name = "txtRecuento";
            this.txtRecuento.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRecuento.Properties.Appearance.Options.UseFont = true;
            this.txtRecuento.Size = new System.Drawing.Size(139, 26);
            this.txtRecuento.TabIndex = 187;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(421, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(272, 20);
            this.labelControl2.TabIndex = 188;
            this.labelControl2.Text = "Usuario________________________";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(592, 33);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Size = new System.Drawing.Size(172, 26);
            this.txtUsuario.TabIndex = 189;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(421, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(220, 20);
            this.labelControl3.TabIndex = 190;
            this.labelControl3.Text = "Fecha Contabilizacion_______";
            // 
            // dtFechaConta
            // 
            this.dtFechaConta.EditValue = null;
            this.dtFechaConta.Location = new System.Drawing.Point(592, 81);
            this.dtFechaConta.MenuManager = this.barManager1;
            this.dtFechaConta.Name = "dtFechaConta";
            this.dtFechaConta.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtFechaConta.Properties.Appearance.Options.UseFont = true;
            this.dtFechaConta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaConta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaConta.Size = new System.Drawing.Size(172, 26);
            this.dtFechaConta.TabIndex = 191;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Location = new System.Drawing.Point(1200, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 47);
            this.btnClose.TabIndex = 193;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.Appearance.Options.UseTextOptions = true;
            this.cmdGuardar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdGuardar.ImageOptions.SvgImage")));
            this.cmdGuardar.Location = new System.Drawing.Point(1065, 12);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(104, 47);
            this.cmdGuardar.TabIndex = 192;
            this.cmdGuardar.Text = "Guardar Avance";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // colid_detalle_recuento
            // 
            this.colid_detalle_recuento.FieldName = "id_detalle_recuento";
            this.colid_detalle_recuento.Name = "colid_detalle_recuento";
            this.colid_detalle_recuento.OptionsColumn.AllowEdit = false;
            // 
            // colid_recuento
            // 
            this.colid_recuento.FieldName = "id_recuento";
            this.colid_recuento.Name = "colid_recuento";
            this.colid_recuento.OptionsColumn.AllowEdit = false;
            // 
            // colid_pt
            // 
            this.colid_pt.FieldName = "id_pt";
            this.colid_pt.Name = "colid_pt";
            this.colid_pt.OptionsColumn.AllowEdit = false;
            // 
            // colpt
            // 
            this.colpt.Caption = "Producto";
            this.colpt.FieldName = "pt";
            this.colpt.Name = "colpt";
            this.colpt.OptionsColumn.AllowEdit = false;
            this.colpt.Visible = true;
            this.colpt.VisibleIndex = 0;
            // 
            // colcode_pt
            // 
            this.colcode_pt.Caption = "Cod. PT";
            this.colcode_pt.FieldName = "code_pt";
            this.colcode_pt.Name = "colcode_pt";
            this.colcode_pt.OptionsColumn.AllowEdit = false;
            this.colcode_pt.Visible = true;
            this.colcode_pt.VisibleIndex = 1;
            // 
            // colcode_referencia
            // 
            this.colcode_referencia.Caption = "Cod. Referencia";
            this.colcode_referencia.FieldName = "code_referencia";
            this.colcode_referencia.Name = "colcode_referencia";
            this.colcode_referencia.OptionsColumn.AllowEdit = false;
            this.colcode_referencia.Visible = true;
            this.colcode_referencia.VisibleIndex = 2;
            // 
            // colcantidad_sistema
            // 
            this.colcantidad_sistema.Caption = "Cantidad Sistema";
            this.colcantidad_sistema.FieldName = "cantidad_sistema";
            this.colcantidad_sistema.Name = "colcantidad_sistema";
            this.colcantidad_sistema.OptionsColumn.AllowEdit = false;
            this.colcantidad_sistema.Visible = true;
            this.colcantidad_sistema.VisibleIndex = 3;
            // 
            // colid_bodega
            // 
            this.colid_bodega.FieldName = "id_bodega";
            this.colid_bodega.Name = "colid_bodega";
            this.colid_bodega.OptionsColumn.AllowEdit = false;
            // 
            // colbodega
            // 
            this.colbodega.Caption = "Almacen";
            this.colbodega.FieldName = "bodega";
            this.colbodega.Name = "colbodega";
            this.colbodega.OptionsColumn.AllowEdit = false;
            this.colbodega.Visible = true;
            this.colbodega.VisibleIndex = 4;
            // 
            // colconteo_fisico
            // 
            this.colconteo_fisico.Caption = "Conteo Fisico";
            this.colconteo_fisico.FieldName = "conteo_fisico";
            this.colconteo_fisico.Name = "colconteo_fisico";
            this.colconteo_fisico.Visible = true;
            this.colconteo_fisico.VisibleIndex = 5;
            // 
            // colconteo_completado
            // 
            this.colconteo_completado.Caption = "Conteo Completado";
            this.colconteo_completado.FieldName = "conteo_completado";
            this.colconteo_completado.Name = "colconteo_completado";
            this.colconteo_completado.OptionsColumn.AllowEdit = false;
            this.colconteo_completado.Visible = true;
            this.colconteo_completado.VisibleIndex = 6;
            // 
            // btnCompletar
            // 
            this.btnCompletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompletar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompletar.Appearance.Options.UseFont = true;
            this.btnCompletar.Appearance.Options.UseTextOptions = true;
            this.btnCompletar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnCompletar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCompletar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnCompletar.Location = new System.Drawing.Point(1103, 77);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(174, 35);
            this.btnCompletar.TabIndex = 198;
            this.btnCompletar.Text = "Completar Conteo";
            this.btnCompletar.Click += new System.EventHandler(this.btnCompletar_Click);
            // 
            // frmRecuentoInventarioConteo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 817);
            this.Controls.Add(this.btnCompletar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.dtFechaConta);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtRecuento);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gleAlmacen);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.grdConteo);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmRecuentoInventarioConteo";
            this.Text = "frmRecuentoInventarioConteo";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConteo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvConteo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecuento1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleAlmacen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecuento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaConta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaConta.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl grdConteo;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvConteo;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private dsRecuento dsRecuento1;
        private DevExpress.XtraEditors.GridLookUpEdit gleAlmacen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid_almacen1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.BindingSource bodegasBindingSource;
        private dsRecepcionMP dsRecepcionMP;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtRecuento;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtFechaConta;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraGrid.Columns.GridColumn colid_detalle_recuento;
        private DevExpress.XtraGrid.Columns.GridColumn colid_recuento;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colpt;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_referencia;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_sistema;
        private DevExpress.XtraGrid.Columns.GridColumn colid_bodega;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega;
        private DevExpress.XtraGrid.Columns.GridColumn colconteo_fisico;
        private DevExpress.XtraGrid.Columns.GridColumn colconteo_completado;
        private DevExpress.XtraEditors.SimpleButton btnCompletar;
    }
}