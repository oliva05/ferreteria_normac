using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace JAGUAR_PRO.Facturacion.Reportes
{
    partial class frmReportesFacturacionMultiple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportesFacturacionMultiple));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefreshPage1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSalir = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsReporte1 = new JAGUAR_PRO.Despachos.Reportes.dsReporte();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPuntodeVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumentoInicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumentoFinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gleCliente = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bsListReportes = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.dtHastaPage1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtDesdePage1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.dtHastaPage2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dtDesdePage2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_punto_venta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPuntodeVenta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmes_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal_mes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colanio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRefreshPage2 = new DevExpress.XtraEditors.SimpleButton();
            this.navigationPage3 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.dtHastaPage3 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtDesdePage3 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRefreshPage3 = new DevExpress.XtraEditors.SimpleButton();
            this.navigationPage4 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.dtHastaPage4 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.dtDesdePage4 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_punto_venta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_punto_venta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalFila = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRefreshPage4 = new DevExpress.XtraEditors.SimpleButton();
            this.navigationPage5 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.dtHastaPage5 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.dtDesdePage5 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl5 = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_punto_venta2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_punto_venta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcliente_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalFila1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRefreshPage5 = new DevExpress.XtraEditors.SimpleButton();
            this.navigationPage6 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.glePuntoVenta6 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bS_PuntosVenta = new System.Windows.Forms.BindingSource(this.components);
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl6 = new DevExpress.XtraGrid.GridControl();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_ventas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtHastaPage6 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.dtDesdePage6 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.btnRefreshPage6 = new DevExpress.XtraEditors.SimpleButton();
            this.navigationPage7 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.glePuntoVenta7 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.dtHastaPage7 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.dtDesdePage7 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.btnRefreshPage7 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl7 = new DevExpress.XtraGrid.GridControl();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.navigationPage8 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.glePuntoVenta8 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView10 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.dtHastaPage8 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.dtDesdePage8 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.btnRefreshPage8 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl8 = new DevExpress.XtraGrid.GridControl();
            this.gridView11 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporte1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage1.Properties.CalendarTimeProperties)).BeginInit();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.navigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage3.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage3.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.navigationPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage4.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage4.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.navigationPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage5.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage5.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.navigationPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glePuntoVenta6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_PuntosVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage6.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage6.Properties.CalendarTimeProperties)).BeginInit();
            this.navigationPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glePuntoVenta7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage7.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage7.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            this.navigationPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glePuntoVenta8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage8.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage8.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(584, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(114, 38);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Excel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnRefreshPage1
            // 
            this.btnRefreshPage1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRefreshPage1.Appearance.Options.UseFont = true;
            this.btnRefreshPage1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefreshPage1.ImageOptions.SvgImage")));
            this.btnRefreshPage1.Location = new System.Drawing.Point(488, 4);
            this.btnRefreshPage1.Name = "btnRefreshPage1";
            this.btnRefreshPage1.Size = new System.Drawing.Size(114, 32);
            this.btnRefreshPage1.TabIndex = 11;
            this.btnRefreshPage1.Text = "Actualizar";
            this.btnRefreshPage1.Click += new System.EventHandler(this.btnRefreshPage1_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSalir.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdSalir.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmdSalir.Appearance.Options.UseBackColor = true;
            this.cmdSalir.Appearance.Options.UseFont = true;
            this.cmdSalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.ImageOptions.Image")));
            this.cmdSalir.Location = new System.Drawing.Point(704, 2);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(114, 38);
            this.cmdSalir.TabIndex = 13;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "Libro de Ventas";
            this.gridControl1.DataSource = this.dsReporte1;
            this.gridControl1.Location = new System.Drawing.Point(0, 39);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(817, 363);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsReporte1
            // 
            this.dsReporte1.DataSetName = "dsReporte";
            this.dsReporte1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFecha,
            this.colPuntodeVenta,
            this.colTipoDocumento,
            this.colCAI,
            this.colDocumentoInicial,
            this.colDocumentoFinal,
            this.colValor,
            this.colHora});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colFecha
            // 
            this.colFecha.DisplayFormat.FormatString = "d";
            this.colFecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.ReadOnly = true;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 0;
            this.colFecha.Width = 62;
            // 
            // colPuntodeVenta
            // 
            this.colPuntodeVenta.FieldName = "Punto de Venta";
            this.colPuntodeVenta.Name = "colPuntodeVenta";
            this.colPuntodeVenta.OptionsColumn.ReadOnly = true;
            this.colPuntodeVenta.Visible = true;
            this.colPuntodeVenta.VisibleIndex = 2;
            this.colPuntodeVenta.Width = 110;
            // 
            // colTipoDocumento
            // 
            this.colTipoDocumento.FieldName = "Tipo Documento";
            this.colTipoDocumento.Name = "colTipoDocumento";
            this.colTipoDocumento.OptionsColumn.ReadOnly = true;
            this.colTipoDocumento.Visible = true;
            this.colTipoDocumento.VisibleIndex = 3;
            this.colTipoDocumento.Width = 110;
            // 
            // colCAI
            // 
            this.colCAI.FieldName = "CAI";
            this.colCAI.Name = "colCAI";
            this.colCAI.OptionsColumn.ReadOnly = true;
            this.colCAI.Visible = true;
            this.colCAI.VisibleIndex = 4;
            this.colCAI.Width = 110;
            // 
            // colDocumentoInicial
            // 
            this.colDocumentoInicial.FieldName = "Documento Inicial";
            this.colDocumentoInicial.Name = "colDocumentoInicial";
            this.colDocumentoInicial.OptionsColumn.ReadOnly = true;
            this.colDocumentoInicial.Visible = true;
            this.colDocumentoInicial.VisibleIndex = 5;
            this.colDocumentoInicial.Width = 110;
            // 
            // colDocumentoFinal
            // 
            this.colDocumentoFinal.FieldName = "Documento Final";
            this.colDocumentoFinal.Name = "colDocumentoFinal";
            this.colDocumentoFinal.OptionsColumn.ReadOnly = true;
            this.colDocumentoFinal.Visible = true;
            this.colDocumentoFinal.VisibleIndex = 6;
            this.colDocumentoFinal.Width = 110;
            // 
            // colValor
            // 
            this.colValor.DisplayFormat.FormatString = "n2";
            this.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValor.FieldName = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.OptionsColumn.ReadOnly = true;
            this.colValor.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Valor", "SUM={0:##,###,##0.00}")});
            this.colValor.Visible = true;
            this.colValor.VisibleIndex = 7;
            this.colValor.Width = 113;
            // 
            // colHora
            // 
            this.colHora.FieldName = "Hora";
            this.colHora.Name = "colHora";
            this.colHora.OptionsColumn.ReadOnly = true;
            this.colHora.Visible = true;
            this.colHora.VisibleIndex = 1;
            this.colHora.Width = 67;
            // 
            // gleCliente
            // 
            this.gleCliente.Location = new System.Drawing.Point(64, 15);
            this.gleCliente.Name = "gleCliente";
            this.gleCliente.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gleCliente.Properties.Appearance.Options.UseFont = true;
            this.gleCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleCliente.Properties.DataSource = this.bsListReportes;
            this.gleCliente.Properties.DisplayMember = "descripcion";
            this.gleCliente.Properties.NullText = "";
            this.gleCliente.Properties.PopupView = this.gridLookUpEdit1View;
            this.gleCliente.Properties.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSearch;
            this.gleCliente.Properties.ValueMember = "id";
            this.gleCliente.Size = new System.Drawing.Size(344, 24);
            this.gleCliente.TabIndex = 65;
            this.gleCliente.EditValueChanged += new System.EventHandler(this.gleCliente_EditValueChanged);
            // 
            // bsListReportes
            // 
            this.bsListReportes.DataMember = "reportes_lista";
            this.bsListReportes.DataSource = this.dsReporte1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsFilter.ShowInHeaderSearchTextMode = DevExpress.XtraGrid.Views.Grid.ShowInHeaderSearchTextMode.Text;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(6, 18);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 17);
            this.labelControl3.TabIndex = 66;
            this.labelControl3.Text = "Reporte:";
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigationFrame1.Controls.Add(this.navigationPage1);
            this.navigationFrame1.Controls.Add(this.navigationPage2);
            this.navigationFrame1.Controls.Add(this.navigationPage3);
            this.navigationFrame1.Controls.Add(this.navigationPage4);
            this.navigationFrame1.Controls.Add(this.navigationPage5);
            this.navigationFrame1.Controls.Add(this.navigationPage6);
            this.navigationFrame1.Controls.Add(this.navigationPage7);
            this.navigationFrame1.Controls.Add(this.navigationPage8);
            this.navigationFrame1.Location = new System.Drawing.Point(1, 47);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2,
            this.navigationPage3,
            this.navigationPage4,
            this.navigationPage5,
            this.navigationPage6,
            this.navigationPage7,
            this.navigationPage8});
            this.navigationFrame1.SelectedPage = this.navigationPage1;
            this.navigationFrame1.Size = new System.Drawing.Size(817, 402);
            this.navigationFrame1.TabIndex = 67;
            this.navigationFrame1.Text = "navigationFrame1";
            this.navigationFrame1.TransitionAnimationProperties.FrameInterval = 3000;
            // 
            // navigationPage1
            // 
            this.navigationPage1.Controls.Add(this.dtHastaPage1);
            this.navigationPage1.Controls.Add(this.labelControl2);
            this.navigationPage1.Controls.Add(this.dtDesdePage1);
            this.navigationPage1.Controls.Add(this.labelControl1);
            this.navigationPage1.Controls.Add(this.gridControl1);
            this.navigationPage1.Controls.Add(this.btnRefreshPage1);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(817, 402);
            // 
            // dtHastaPage1
            // 
            this.dtHastaPage1.EditValue = null;
            this.dtHastaPage1.Location = new System.Drawing.Point(331, 10);
            this.dtHastaPage1.Name = "dtHastaPage1";
            this.dtHastaPage1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtHastaPage1.Properties.Appearance.Options.UseFont = true;
            this.dtHastaPage1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHastaPage1.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtHastaPage1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHastaPage1.Size = new System.Drawing.Size(151, 24);
            this.dtHastaPage1.TabIndex = 70;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(247, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 17);
            this.labelControl2.TabIndex = 69;
            this.labelControl2.Text = "Fecha hasta:";
            // 
            // dtDesdePage1
            // 
            this.dtDesdePage1.EditValue = null;
            this.dtDesdePage1.Location = new System.Drawing.Point(89, 10);
            this.dtDesdePage1.Name = "dtDesdePage1";
            this.dtDesdePage1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtDesdePage1.Properties.Appearance.Options.UseFont = true;
            this.dtDesdePage1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesdePage1.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtDesdePage1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesdePage1.Size = new System.Drawing.Size(151, 24);
            this.dtDesdePage1.TabIndex = 68;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 17);
            this.labelControl1.TabIndex = 67;
            this.labelControl1.Text = "Fecha desde:";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "navigationPage2";
            this.navigationPage2.Controls.Add(this.dtHastaPage2);
            this.navigationPage2.Controls.Add(this.labelControl6);
            this.navigationPage2.Controls.Add(this.dtDesdePage2);
            this.navigationPage2.Controls.Add(this.labelControl7);
            this.navigationPage2.Controls.Add(this.gridControl3);
            this.navigationPage2.Controls.Add(this.btnRefreshPage2);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(817, 402);
            // 
            // dtHastaPage2
            // 
            this.dtHastaPage2.EditValue = null;
            this.dtHastaPage2.Location = new System.Drawing.Point(328, 9);
            this.dtHastaPage2.Name = "dtHastaPage2";
            this.dtHastaPage2.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtHastaPage2.Properties.Appearance.Options.UseFont = true;
            this.dtHastaPage2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHastaPage2.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtHastaPage2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHastaPage2.Size = new System.Drawing.Size(151, 24);
            this.dtHastaPage2.TabIndex = 82;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(247, 12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(75, 17);
            this.labelControl6.TabIndex = 81;
            this.labelControl6.Text = "Fecha hasta:";
            // 
            // dtDesdePage2
            // 
            this.dtDesdePage2.EditValue = null;
            this.dtDesdePage2.Location = new System.Drawing.Point(89, 9);
            this.dtDesdePage2.Name = "dtDesdePage2";
            this.dtDesdePage2.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtDesdePage2.Properties.Appearance.Options.UseFont = true;
            this.dtDesdePage2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesdePage2.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtDesdePage2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesdePage2.Size = new System.Drawing.Size(151, 24);
            this.dtDesdePage2.TabIndex = 80;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(5, 12);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(78, 17);
            this.labelControl7.TabIndex = 79;
            this.labelControl7.Text = "Fecha desde:";
            // 
            // gridControl3
            // 
            this.gridControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl3.DataMember = "Ventas_mensuales";
            this.gridControl3.DataSource = this.dsReporte1;
            this.gridControl3.Location = new System.Drawing.Point(0, 36);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(817, 363);
            this.gridControl3.TabIndex = 78;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_punto_venta,
            this.colPuntodeVenta1,
            this.colnmes,
            this.colmes_name,
            this.coltotal_mes,
            this.colanio});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.GroupCount = 1;
            this.gridView3.GroupFormat = "SUM={0:##,###,##0.00}";
            this.gridView3.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total_mes", this.coltotal_mes, "(Valor: SUM={0:n2})")});
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridView3.OptionsView.ShowFooter = true;
            this.gridView3.OptionsView.ShowGroupedColumns = true;
            this.gridView3.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPuntodeVenta1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colid_punto_venta
            // 
            this.colid_punto_venta.FieldName = "id_punto_venta";
            this.colid_punto_venta.Name = "colid_punto_venta";
            // 
            // colPuntodeVenta1
            // 
            this.colPuntodeVenta1.FieldName = "Punto de Venta";
            this.colPuntodeVenta1.Name = "colPuntodeVenta1";
            this.colPuntodeVenta1.OptionsColumn.ReadOnly = true;
            this.colPuntodeVenta1.Visible = true;
            this.colPuntodeVenta1.VisibleIndex = 0;
            // 
            // colnmes
            // 
            this.colnmes.FieldName = "nmes";
            this.colnmes.Name = "colnmes";
            // 
            // colmes_name
            // 
            this.colmes_name.FieldName = "mes_name";
            this.colmes_name.Name = "colmes_name";
            this.colmes_name.OptionsColumn.ReadOnly = true;
            this.colmes_name.Visible = true;
            this.colmes_name.VisibleIndex = 1;
            // 
            // coltotal_mes
            // 
            this.coltotal_mes.DisplayFormat.FormatString = "n2";
            this.coltotal_mes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal_mes.FieldName = "total_mes";
            this.coltotal_mes.Name = "coltotal_mes";
            this.coltotal_mes.OptionsColumn.ReadOnly = true;
            this.coltotal_mes.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total_mes", "SUM={0:##,###,##0.00}")});
            this.coltotal_mes.Visible = true;
            this.coltotal_mes.VisibleIndex = 2;
            // 
            // colanio
            // 
            this.colanio.FieldName = "anio";
            this.colanio.Name = "colanio";
            // 
            // btnRefreshPage2
            // 
            this.btnRefreshPage2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRefreshPage2.Appearance.Options.UseFont = true;
            this.btnRefreshPage2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefreshPage2.ImageOptions.SvgImage")));
            this.btnRefreshPage2.Location = new System.Drawing.Point(485, 3);
            this.btnRefreshPage2.Name = "btnRefreshPage2";
            this.btnRefreshPage2.Size = new System.Drawing.Size(114, 32);
            this.btnRefreshPage2.TabIndex = 77;
            this.btnRefreshPage2.Text = "Actualizar";
            this.btnRefreshPage2.Click += new System.EventHandler(this.btnRefreshPage2_Click);
            // 
            // navigationPage3
            // 
            this.navigationPage3.Caption = "navigationPage3";
            this.navigationPage3.Controls.Add(this.dtHastaPage3);
            this.navigationPage3.Controls.Add(this.labelControl4);
            this.navigationPage3.Controls.Add(this.dtDesdePage3);
            this.navigationPage3.Controls.Add(this.labelControl5);
            this.navigationPage3.Controls.Add(this.gridControl2);
            this.navigationPage3.Controls.Add(this.btnRefreshPage3);
            this.navigationPage3.Name = "navigationPage3";
            this.navigationPage3.Size = new System.Drawing.Size(817, 402);
            // 
            // dtHastaPage3
            // 
            this.dtHastaPage3.EditValue = null;
            this.dtHastaPage3.Location = new System.Drawing.Point(328, 10);
            this.dtHastaPage3.Name = "dtHastaPage3";
            this.dtHastaPage3.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtHastaPage3.Properties.Appearance.Options.UseFont = true;
            this.dtHastaPage3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHastaPage3.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtHastaPage3.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHastaPage3.Size = new System.Drawing.Size(151, 24);
            this.dtHastaPage3.TabIndex = 76;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(247, 13);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 17);
            this.labelControl4.TabIndex = 75;
            this.labelControl4.Text = "Fecha hasta:";
            // 
            // dtDesdePage3
            // 
            this.dtDesdePage3.EditValue = null;
            this.dtDesdePage3.Location = new System.Drawing.Point(89, 10);
            this.dtDesdePage3.Name = "dtDesdePage3";
            this.dtDesdePage3.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtDesdePage3.Properties.Appearance.Options.UseFont = true;
            this.dtDesdePage3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesdePage3.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtDesdePage3.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesdePage3.Size = new System.Drawing.Size(151, 24);
            this.dtDesdePage3.TabIndex = 74;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(5, 13);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(78, 17);
            this.labelControl5.TabIndex = 73;
            this.labelControl5.Text = "Fecha desde:";
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataMember = "Ventas_diarias";
            this.gridControl2.DataSource = this.dsReporte1;
            this.gridControl2.Location = new System.Drawing.Point(0, 37);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(817, 363);
            this.gridControl2.TabIndex = 72;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn7});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.GroupCount = 1;
            this.gridView2.GroupFormat = "SUM={0:##,###,##0.00}";
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Valor", this.gridColumn7, "(Valor: SUM={0:n2})")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupedColumns = true;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.DisplayFormat.FormatString = "d";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn1.FieldName = "Fecha";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "Punto de Venta";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn7
            // 
            this.gridColumn7.DisplayFormat.FormatString = "n2";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn7.FieldName = "Valor";
            this.gridColumn7.GroupFormat.FormatString = "n2";
            this.gridColumn7.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Valor", "SUM={0:##,###,##0.00}")});
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            // 
            // btnRefreshPage3
            // 
            this.btnRefreshPage3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRefreshPage3.Appearance.Options.UseFont = true;
            this.btnRefreshPage3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefreshPage3.ImageOptions.SvgImage")));
            this.btnRefreshPage3.Location = new System.Drawing.Point(485, 4);
            this.btnRefreshPage3.Name = "btnRefreshPage3";
            this.btnRefreshPage3.Size = new System.Drawing.Size(114, 32);
            this.btnRefreshPage3.TabIndex = 71;
            this.btnRefreshPage3.Text = "Actualizar";
            this.btnRefreshPage3.Click += new System.EventHandler(this.btnRefreshPage3_Click);
            // 
            // navigationPage4
            // 
            this.navigationPage4.Caption = "navigationPage4";
            this.navigationPage4.Controls.Add(this.dtHastaPage4);
            this.navigationPage4.Controls.Add(this.labelControl8);
            this.navigationPage4.Controls.Add(this.dtDesdePage4);
            this.navigationPage4.Controls.Add(this.labelControl9);
            this.navigationPage4.Controls.Add(this.gridControl4);
            this.navigationPage4.Controls.Add(this.btnRefreshPage4);
            this.navigationPage4.Name = "navigationPage4";
            this.navigationPage4.Size = new System.Drawing.Size(817, 402);
            // 
            // dtHastaPage4
            // 
            this.dtHastaPage4.EditValue = null;
            this.dtHastaPage4.Location = new System.Drawing.Point(328, 9);
            this.dtHastaPage4.Name = "dtHastaPage4";
            this.dtHastaPage4.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtHastaPage4.Properties.Appearance.Options.UseFont = true;
            this.dtHastaPage4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHastaPage4.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtHastaPage4.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHastaPage4.Size = new System.Drawing.Size(151, 24);
            this.dtHastaPage4.TabIndex = 82;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(247, 12);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(75, 17);
            this.labelControl8.TabIndex = 81;
            this.labelControl8.Text = "Fecha hasta:";
            // 
            // dtDesdePage4
            // 
            this.dtDesdePage4.EditValue = null;
            this.dtDesdePage4.Location = new System.Drawing.Point(89, 9);
            this.dtDesdePage4.Name = "dtDesdePage4";
            this.dtDesdePage4.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtDesdePage4.Properties.Appearance.Options.UseFont = true;
            this.dtDesdePage4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesdePage4.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtDesdePage4.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesdePage4.Size = new System.Drawing.Size(151, 24);
            this.dtDesdePage4.TabIndex = 80;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(5, 12);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(78, 17);
            this.labelControl9.TabIndex = 79;
            this.labelControl9.Text = "Fecha desde:";
            // 
            // gridControl4
            // 
            this.gridControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl4.DataMember = "ventas_por_producto";
            this.gridControl4.DataSource = this.dsReporte1;
            this.gridControl4.Location = new System.Drawing.Point(0, 36);
            this.gridControl4.MainView = this.gridView4;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(817, 363);
            this.gridControl4.TabIndex = 78;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_punto_venta1,
            this.colnombre_punto_venta,
            this.colid_pt,
            this.colItemCode,
            this.colItemName,
            this.colTotalFila,
            this.colcantidad});
            this.gridView4.GridControl = this.gridControl4;
            this.gridView4.GroupCount = 1;
            this.gridView4.GroupFormat = "SUM={0:##,###,##0.00}";
            this.gridView4.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalFila", this.colTotalFila, "(Valor: SUM={0:n2})")});
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridView4.OptionsView.ShowFooter = true;
            this.gridView4.OptionsView.ShowGroupedColumns = true;
            this.gridView4.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colnombre_punto_venta, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colid_punto_venta1
            // 
            this.colid_punto_venta1.FieldName = "id_punto_venta";
            this.colid_punto_venta1.Name = "colid_punto_venta1";
            this.colid_punto_venta1.OptionsColumn.ReadOnly = true;
            // 
            // colnombre_punto_venta
            // 
            this.colnombre_punto_venta.FieldName = "nombre_punto_venta";
            this.colnombre_punto_venta.Name = "colnombre_punto_venta";
            this.colnombre_punto_venta.OptionsColumn.ReadOnly = true;
            this.colnombre_punto_venta.Visible = true;
            this.colnombre_punto_venta.VisibleIndex = 0;
            this.colnombre_punto_venta.Width = 168;
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
            this.colItemCode.VisibleIndex = 1;
            this.colItemCode.Width = 88;
            // 
            // colItemName
            // 
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.ReadOnly = true;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 2;
            this.colItemName.Width = 204;
            // 
            // colTotalFila
            // 
            this.colTotalFila.DisplayFormat.FormatString = "n2";
            this.colTotalFila.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalFila.FieldName = "TotalFila";
            this.colTotalFila.Name = "colTotalFila";
            this.colTotalFila.OptionsColumn.ReadOnly = true;
            this.colTotalFila.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalFila", "SUM={0:##,###,##0.00}")});
            this.colTotalFila.Visible = true;
            this.colTotalFila.VisibleIndex = 4;
            this.colTotalFila.Width = 169;
            // 
            // colcantidad
            // 
            this.colcantidad.DisplayFormat.FormatString = "n2";
            this.colcantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.ReadOnly = true;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 3;
            this.colcantidad.Width = 163;
            // 
            // btnRefreshPage4
            // 
            this.btnRefreshPage4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRefreshPage4.Appearance.Options.UseFont = true;
            this.btnRefreshPage4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefreshPage4.ImageOptions.SvgImage")));
            this.btnRefreshPage4.Location = new System.Drawing.Point(485, 3);
            this.btnRefreshPage4.Name = "btnRefreshPage4";
            this.btnRefreshPage4.Size = new System.Drawing.Size(114, 32);
            this.btnRefreshPage4.TabIndex = 77;
            this.btnRefreshPage4.Text = "Actualizar";
            this.btnRefreshPage4.Click += new System.EventHandler(this.btnRefreshPage4_Click);
            // 
            // navigationPage5
            // 
            this.navigationPage5.Caption = "navigationPage5";
            this.navigationPage5.Controls.Add(this.dtHastaPage5);
            this.navigationPage5.Controls.Add(this.labelControl10);
            this.navigationPage5.Controls.Add(this.dtDesdePage5);
            this.navigationPage5.Controls.Add(this.labelControl11);
            this.navigationPage5.Controls.Add(this.gridControl5);
            this.navigationPage5.Controls.Add(this.btnRefreshPage5);
            this.navigationPage5.Name = "navigationPage5";
            this.navigationPage5.Size = new System.Drawing.Size(817, 402);
            // 
            // dtHastaPage5
            // 
            this.dtHastaPage5.EditValue = null;
            this.dtHastaPage5.Location = new System.Drawing.Point(328, 9);
            this.dtHastaPage5.Name = "dtHastaPage5";
            this.dtHastaPage5.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtHastaPage5.Properties.Appearance.Options.UseFont = true;
            this.dtHastaPage5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHastaPage5.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtHastaPage5.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHastaPage5.Size = new System.Drawing.Size(151, 24);
            this.dtHastaPage5.TabIndex = 88;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(247, 12);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(75, 17);
            this.labelControl10.TabIndex = 87;
            this.labelControl10.Text = "Fecha hasta:";
            // 
            // dtDesdePage5
            // 
            this.dtDesdePage5.EditValue = null;
            this.dtDesdePage5.Location = new System.Drawing.Point(89, 9);
            this.dtDesdePage5.Name = "dtDesdePage5";
            this.dtDesdePage5.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtDesdePage5.Properties.Appearance.Options.UseFont = true;
            this.dtDesdePage5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesdePage5.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtDesdePage5.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesdePage5.Size = new System.Drawing.Size(151, 24);
            this.dtDesdePage5.TabIndex = 86;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(5, 12);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(78, 17);
            this.labelControl11.TabIndex = 85;
            this.labelControl11.Text = "Fecha desde:";
            // 
            // gridControl5
            // 
            this.gridControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl5.DataMember = "ventas_por_cliente";
            this.gridControl5.DataSource = this.dsReporte1;
            this.gridControl5.Location = new System.Drawing.Point(0, 36);
            this.gridControl5.MainView = this.gridView5;
            this.gridControl5.Name = "gridControl5";
            this.gridControl5.Size = new System.Drawing.Size(817, 363);
            this.gridControl5.TabIndex = 84;
            this.gridControl5.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_punto_venta2,
            this.colnombre_punto_venta1,
            this.colcliente_nombre,
            this.colTotalFila1});
            this.gridView5.GridControl = this.gridControl5;
            this.gridView5.GroupCount = 1;
            this.gridView5.GroupFormat = "SUM={0:##,###,##0.00}";
            this.gridView5.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalFila", null, "(Valor: SUM={0:n2})")});
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView5.OptionsView.ShowAutoFilterRow = true;
            this.gridView5.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridView5.OptionsView.ShowFooter = true;
            this.gridView5.OptionsView.ShowGroupedColumns = true;
            this.gridView5.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colnombre_punto_venta1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colid_punto_venta2
            // 
            this.colid_punto_venta2.FieldName = "id_punto_venta";
            this.colid_punto_venta2.Name = "colid_punto_venta2";
            this.colid_punto_venta2.OptionsColumn.ReadOnly = true;
            // 
            // colnombre_punto_venta1
            // 
            this.colnombre_punto_venta1.FieldName = "nombre_punto_venta";
            this.colnombre_punto_venta1.Name = "colnombre_punto_venta1";
            this.colnombre_punto_venta1.OptionsColumn.ReadOnly = true;
            this.colnombre_punto_venta1.Visible = true;
            this.colnombre_punto_venta1.VisibleIndex = 0;
            // 
            // colcliente_nombre
            // 
            this.colcliente_nombre.FieldName = "cliente_nombre";
            this.colcliente_nombre.Name = "colcliente_nombre";
            this.colcliente_nombre.OptionsColumn.ReadOnly = true;
            this.colcliente_nombre.Visible = true;
            this.colcliente_nombre.VisibleIndex = 1;
            // 
            // colTotalFila1
            // 
            this.colTotalFila1.DisplayFormat.FormatString = "n2";
            this.colTotalFila1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalFila1.FieldName = "TotalFila";
            this.colTotalFila1.Name = "colTotalFila1";
            this.colTotalFila1.OptionsColumn.ReadOnly = true;
            this.colTotalFila1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalFila", "SUM={0:n2}")});
            this.colTotalFila1.Visible = true;
            this.colTotalFila1.VisibleIndex = 2;
            // 
            // btnRefreshPage5
            // 
            this.btnRefreshPage5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRefreshPage5.Appearance.Options.UseFont = true;
            this.btnRefreshPage5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefreshPage5.ImageOptions.SvgImage")));
            this.btnRefreshPage5.Location = new System.Drawing.Point(485, 3);
            this.btnRefreshPage5.Name = "btnRefreshPage5";
            this.btnRefreshPage5.Size = new System.Drawing.Size(114, 32);
            this.btnRefreshPage5.TabIndex = 83;
            this.btnRefreshPage5.Text = "Actualizar";
            this.btnRefreshPage5.Click += new System.EventHandler(this.btnRefreshPage5_Click);
            // 
            // navigationPage6
            // 
            this.navigationPage6.Caption = "navigationPage6";
            this.navigationPage6.Controls.Add(this.glePuntoVenta6);
            this.navigationPage6.Controls.Add(this.labelControl14);
            this.navigationPage6.Controls.Add(this.gridControl6);
            this.navigationPage6.Controls.Add(this.dtHastaPage6);
            this.navigationPage6.Controls.Add(this.labelControl12);
            this.navigationPage6.Controls.Add(this.dtDesdePage6);
            this.navigationPage6.Controls.Add(this.labelControl13);
            this.navigationPage6.Controls.Add(this.btnRefreshPage6);
            this.navigationPage6.Name = "navigationPage6";
            this.navigationPage6.Size = new System.Drawing.Size(817, 402);
            // 
            // glePuntoVenta6
            // 
            this.glePuntoVenta6.Location = new System.Drawing.Point(106, 38);
            this.glePuntoVenta6.Name = "glePuntoVenta6";
            this.glePuntoVenta6.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.glePuntoVenta6.Properties.Appearance.Options.UseFont = true;
            this.glePuntoVenta6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glePuntoVenta6.Properties.DataSource = this.bS_PuntosVenta;
            this.glePuntoVenta6.Properties.DisplayMember = "descripcion";
            this.glePuntoVenta6.Properties.NullText = "";
            this.glePuntoVenta6.Properties.PopupView = this.gridView7;
            this.glePuntoVenta6.Properties.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSearch;
            this.glePuntoVenta6.Properties.ValueMember = "id";
            this.glePuntoVenta6.Size = new System.Drawing.Size(390, 24);
            this.glePuntoVenta6.TabIndex = 96;
            // 
            // bS_PuntosVenta
            // 
            this.bS_PuntosVenta.DataMember = "puntos_venta";
            this.bS_PuntosVenta.DataSource = this.dsReporte1;
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsFilter.ShowInHeaderSearchTextMode = DevExpress.XtraGrid.Views.Grid.ShowInHeaderSearchTextMode.Text;
            this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "id";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "descripcion";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(5, 41);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(95, 17);
            this.labelControl14.TabIndex = 95;
            this.labelControl14.Text = "Punto de Venta";
            // 
            // gridControl6
            // 
            this.gridControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl6.DataMember = "ventas_gravadas";
            this.gridControl6.DataSource = this.dsReporte1;
            this.gridControl6.Location = new System.Drawing.Point(2, 68);
            this.gridControl6.MainView = this.gridView6;
            this.gridControl6.Name = "gridControl6";
            this.gridControl6.Size = new System.Drawing.Size(814, 332);
            this.gridControl6.TabIndex = 94;
            this.gridControl6.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView6});
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.coldescripcion1,
            this.colvalor1,
            this.colvalor_ventas,
            this.colisv});
            this.gridView6.GridControl = this.gridControl6;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsView.ShowAutoFilterRow = true;
            this.gridView6.OptionsView.ShowFooter = true;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            this.colid1.OptionsColumn.ReadOnly = true;
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.OptionsColumn.ReadOnly = true;
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 0;
            // 
            // colvalor1
            // 
            this.colvalor1.DisplayFormat.FormatString = "n2";
            this.colvalor1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalor1.FieldName = "valor";
            this.colvalor1.Name = "colvalor1";
            this.colvalor1.OptionsColumn.ReadOnly = true;
            // 
            // colvalor_ventas
            // 
            this.colvalor_ventas.DisplayFormat.FormatString = "n2";
            this.colvalor_ventas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalor_ventas.FieldName = "valor_ventas";
            this.colvalor_ventas.Name = "colvalor_ventas";
            this.colvalor_ventas.OptionsColumn.ReadOnly = true;
            this.colvalor_ventas.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "valor_ventas", "SUM={0:##,###,##0.00}")});
            this.colvalor_ventas.Visible = true;
            this.colvalor_ventas.VisibleIndex = 1;
            // 
            // colisv
            // 
            this.colisv.DisplayFormat.FormatString = "n2";
            this.colisv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colisv.FieldName = "isv";
            this.colisv.Name = "colisv";
            this.colisv.OptionsColumn.ReadOnly = true;
            this.colisv.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "isv", "SUM={0:##,###,##0.00}")});
            this.colisv.Visible = true;
            this.colisv.VisibleIndex = 2;
            // 
            // dtHastaPage6
            // 
            this.dtHastaPage6.EditValue = null;
            this.dtHastaPage6.Location = new System.Drawing.Point(345, 10);
            this.dtHastaPage6.Name = "dtHastaPage6";
            this.dtHastaPage6.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtHastaPage6.Properties.Appearance.Options.UseFont = true;
            this.dtHastaPage6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHastaPage6.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtHastaPage6.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHastaPage6.Size = new System.Drawing.Size(151, 24);
            this.dtHastaPage6.TabIndex = 93;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(264, 13);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(75, 17);
            this.labelControl12.TabIndex = 92;
            this.labelControl12.Text = "Fecha hasta:";
            // 
            // dtDesdePage6
            // 
            this.dtDesdePage6.EditValue = null;
            this.dtDesdePage6.Location = new System.Drawing.Point(106, 10);
            this.dtDesdePage6.Name = "dtDesdePage6";
            this.dtDesdePage6.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtDesdePage6.Properties.Appearance.Options.UseFont = true;
            this.dtDesdePage6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesdePage6.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtDesdePage6.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesdePage6.Size = new System.Drawing.Size(151, 24);
            this.dtDesdePage6.TabIndex = 91;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(5, 13);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(78, 17);
            this.labelControl13.TabIndex = 90;
            this.labelControl13.Text = "Fecha desde:";
            // 
            // btnRefreshPage6
            // 
            this.btnRefreshPage6.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRefreshPage6.Appearance.Options.UseFont = true;
            this.btnRefreshPage6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefreshPage6.ImageOptions.SvgImage")));
            this.btnRefreshPage6.Location = new System.Drawing.Point(502, 30);
            this.btnRefreshPage6.Name = "btnRefreshPage6";
            this.btnRefreshPage6.Size = new System.Drawing.Size(114, 32);
            this.btnRefreshPage6.TabIndex = 89;
            this.btnRefreshPage6.Text = "Actualizar";
            this.btnRefreshPage6.Click += new System.EventHandler(this.btnRefreshPage6_Click);
            // 
            // navigationPage7
            // 
            this.navigationPage7.Caption = "navigationPage7";
            this.navigationPage7.Controls.Add(this.glePuntoVenta7);
            this.navigationPage7.Controls.Add(this.labelControl15);
            this.navigationPage7.Controls.Add(this.dtHastaPage7);
            this.navigationPage7.Controls.Add(this.labelControl16);
            this.navigationPage7.Controls.Add(this.dtDesdePage7);
            this.navigationPage7.Controls.Add(this.labelControl17);
            this.navigationPage7.Controls.Add(this.btnRefreshPage7);
            this.navigationPage7.Controls.Add(this.gridControl7);
            this.navigationPage7.Name = "navigationPage7";
            this.navigationPage7.Size = new System.Drawing.Size(817, 402);
            // 
            // glePuntoVenta7
            // 
            this.glePuntoVenta7.Location = new System.Drawing.Point(108, 41);
            this.glePuntoVenta7.Name = "glePuntoVenta7";
            this.glePuntoVenta7.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.glePuntoVenta7.Properties.Appearance.Options.UseFont = true;
            this.glePuntoVenta7.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glePuntoVenta7.Properties.DataSource = this.bS_PuntosVenta;
            this.glePuntoVenta7.Properties.DisplayMember = "descripcion";
            this.glePuntoVenta7.Properties.NullText = "";
            this.glePuntoVenta7.Properties.PopupView = this.gridView9;
            this.glePuntoVenta7.Properties.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSearch;
            this.glePuntoVenta7.Properties.ValueMember = "id";
            this.glePuntoVenta7.Size = new System.Drawing.Size(390, 24);
            this.glePuntoVenta7.TabIndex = 103;
            // 
            // gridView9
            // 
            this.gridView9.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn12});
            this.gridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView9.Name = "gridView9";
            this.gridView9.OptionsFilter.ShowInHeaderSearchTextMode = DevExpress.XtraGrid.Views.Grid.ShowInHeaderSearchTextMode.Text;
            this.gridView9.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView9.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn11
            // 
            this.gridColumn11.FieldName = "id";
            this.gridColumn11.Name = "gridColumn11";
            // 
            // gridColumn12
            // 
            this.gridColumn12.FieldName = "descripcion";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(7, 44);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(95, 17);
            this.labelControl15.TabIndex = 102;
            this.labelControl15.Text = "Punto de Venta";
            // 
            // dtHastaPage7
            // 
            this.dtHastaPage7.EditValue = null;
            this.dtHastaPage7.Location = new System.Drawing.Point(347, 13);
            this.dtHastaPage7.Name = "dtHastaPage7";
            this.dtHastaPage7.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtHastaPage7.Properties.Appearance.Options.UseFont = true;
            this.dtHastaPage7.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHastaPage7.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtHastaPage7.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHastaPage7.Size = new System.Drawing.Size(151, 24);
            this.dtHastaPage7.TabIndex = 101;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(266, 16);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(75, 17);
            this.labelControl16.TabIndex = 100;
            this.labelControl16.Text = "Fecha hasta:";
            // 
            // dtDesdePage7
            // 
            this.dtDesdePage7.EditValue = null;
            this.dtDesdePage7.Location = new System.Drawing.Point(108, 13);
            this.dtDesdePage7.Name = "dtDesdePage7";
            this.dtDesdePage7.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtDesdePage7.Properties.Appearance.Options.UseFont = true;
            this.dtDesdePage7.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesdePage7.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtDesdePage7.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesdePage7.Size = new System.Drawing.Size(151, 24);
            this.dtDesdePage7.TabIndex = 99;
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(7, 16);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(78, 17);
            this.labelControl17.TabIndex = 98;
            this.labelControl17.Text = "Fecha desde:";
            // 
            // btnRefreshPage7
            // 
            this.btnRefreshPage7.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRefreshPage7.Appearance.Options.UseFont = true;
            this.btnRefreshPage7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefreshPage7.ImageOptions.SvgImage")));
            this.btnRefreshPage7.Location = new System.Drawing.Point(504, 33);
            this.btnRefreshPage7.Name = "btnRefreshPage7";
            this.btnRefreshPage7.Size = new System.Drawing.Size(114, 32);
            this.btnRefreshPage7.TabIndex = 97;
            this.btnRefreshPage7.Text = "Actualizar";
            this.btnRefreshPage7.Click += new System.EventHandler(this.btnRefreshPage7_Click);
            // 
            // gridControl7
            // 
            this.gridControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl7.Location = new System.Drawing.Point(3, 67);
            this.gridControl7.MainView = this.gridView8;
            this.gridControl7.Name = "gridControl7";
            this.gridControl7.Size = new System.Drawing.Size(811, 332);
            this.gridControl7.TabIndex = 95;
            this.gridControl7.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView8});
            // 
            // gridView8
            // 
            this.gridView8.GridControl = this.gridControl7;
            this.gridView8.Name = "gridView8";
            this.gridView8.OptionsView.ShowAutoFilterRow = true;
            this.gridView8.OptionsView.ShowFooter = true;
            // 
            // navigationPage8
            // 
            this.navigationPage8.Caption = "navigationPage8";
            this.navigationPage8.Controls.Add(this.glePuntoVenta8);
            this.navigationPage8.Controls.Add(this.labelControl18);
            this.navigationPage8.Controls.Add(this.dtHastaPage8);
            this.navigationPage8.Controls.Add(this.labelControl19);
            this.navigationPage8.Controls.Add(this.dtDesdePage8);
            this.navigationPage8.Controls.Add(this.labelControl20);
            this.navigationPage8.Controls.Add(this.btnRefreshPage8);
            this.navigationPage8.Controls.Add(this.gridControl8);
            this.navigationPage8.Name = "navigationPage8";
            this.navigationPage8.Size = new System.Drawing.Size(817, 402);
            // 
            // glePuntoVenta8
            // 
            this.glePuntoVenta8.Location = new System.Drawing.Point(108, 36);
            this.glePuntoVenta8.Name = "glePuntoVenta8";
            this.glePuntoVenta8.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.glePuntoVenta8.Properties.Appearance.Options.UseFont = true;
            this.glePuntoVenta8.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glePuntoVenta8.Properties.DataSource = this.bS_PuntosVenta;
            this.glePuntoVenta8.Properties.DisplayMember = "descripcion";
            this.glePuntoVenta8.Properties.NullText = "";
            this.glePuntoVenta8.Properties.PopupView = this.gridView10;
            this.glePuntoVenta8.Properties.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSearch;
            this.glePuntoVenta8.Properties.ValueMember = "id";
            this.glePuntoVenta8.Size = new System.Drawing.Size(390, 24);
            this.glePuntoVenta8.TabIndex = 111;
            // 
            // gridView10
            // 
            this.gridView10.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn13,
            this.gridColumn14});
            this.gridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView10.Name = "gridView10";
            this.gridView10.OptionsFilter.ShowInHeaderSearchTextMode = DevExpress.XtraGrid.Views.Grid.ShowInHeaderSearchTextMode.Text;
            this.gridView10.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView10.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn13
            // 
            this.gridColumn13.FieldName = "id";
            this.gridColumn13.Name = "gridColumn13";
            // 
            // gridColumn14
            // 
            this.gridColumn14.FieldName = "descripcion";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 0;
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Location = new System.Drawing.Point(7, 39);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(95, 17);
            this.labelControl18.TabIndex = 110;
            this.labelControl18.Text = "Punto de Venta";
            // 
            // dtHastaPage8
            // 
            this.dtHastaPage8.EditValue = null;
            this.dtHastaPage8.Location = new System.Drawing.Point(347, 8);
            this.dtHastaPage8.Name = "dtHastaPage8";
            this.dtHastaPage8.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtHastaPage8.Properties.Appearance.Options.UseFont = true;
            this.dtHastaPage8.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHastaPage8.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtHastaPage8.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHastaPage8.Size = new System.Drawing.Size(151, 24);
            this.dtHastaPage8.TabIndex = 109;
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Location = new System.Drawing.Point(266, 11);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(75, 17);
            this.labelControl19.TabIndex = 108;
            this.labelControl19.Text = "Fecha hasta:";
            // 
            // dtDesdePage8
            // 
            this.dtDesdePage8.EditValue = null;
            this.dtDesdePage8.Location = new System.Drawing.Point(108, 8);
            this.dtDesdePage8.Name = "dtDesdePage8";
            this.dtDesdePage8.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtDesdePage8.Properties.Appearance.Options.UseFont = true;
            this.dtDesdePage8.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesdePage8.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtDesdePage8.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesdePage8.Size = new System.Drawing.Size(151, 24);
            this.dtDesdePage8.TabIndex = 107;
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.Appearance.Options.UseFont = true;
            this.labelControl20.Location = new System.Drawing.Point(7, 11);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(78, 17);
            this.labelControl20.TabIndex = 106;
            this.labelControl20.Text = "Fecha desde:";
            // 
            // btnRefreshPage8
            // 
            this.btnRefreshPage8.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRefreshPage8.Appearance.Options.UseFont = true;
            this.btnRefreshPage8.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefreshPage8.ImageOptions.SvgImage")));
            this.btnRefreshPage8.Location = new System.Drawing.Point(504, 28);
            this.btnRefreshPage8.Name = "btnRefreshPage8";
            this.btnRefreshPage8.Size = new System.Drawing.Size(114, 32);
            this.btnRefreshPage8.TabIndex = 105;
            this.btnRefreshPage8.Text = "Actualizar";
            this.btnRefreshPage8.Click += new System.EventHandler(this.btnRefreshPage8_Click);
            // 
            // gridControl8
            // 
            this.gridControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl8.Location = new System.Drawing.Point(3, 62);
            this.gridControl8.MainView = this.gridView11;
            this.gridControl8.Name = "gridControl8";
            this.gridControl8.Size = new System.Drawing.Size(811, 332);
            this.gridControl8.TabIndex = 104;
            this.gridControl8.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView11});
            // 
            // gridView11
            // 
            this.gridView11.GridControl = this.gridControl8;
            this.gridView11.Name = "gridView11";
            this.gridView11.OptionsView.ShowAutoFilterRow = true;
            this.gridView11.OptionsView.ShowFooter = true;
            // 
            // frmReportesFacturacionMultiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 451);
            this.Controls.Add(this.navigationFrame1);
            this.Controls.Add(this.gleCliente);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.simpleButton1);
            this.Name = "frmReportesFacturacionMultiple";
            this.Text = "Reportes Facturacion";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporte1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage1.Properties)).EndInit();
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.navigationPage3.ResumeLayout(false);
            this.navigationPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage3.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage3.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.navigationPage4.ResumeLayout(false);
            this.navigationPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage4.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage4.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.navigationPage5.ResumeLayout(false);
            this.navigationPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage5.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage5.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.navigationPage6.ResumeLayout(false);
            this.navigationPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glePuntoVenta6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_PuntosVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage6.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage6.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage6.Properties)).EndInit();
            this.navigationPage7.ResumeLayout(false);
            this.navigationPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glePuntoVenta7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage7.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage7.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            this.navigationPage8.ResumeLayout(false);
            this.navigationPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glePuntoVenta8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage8.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastaPage8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage8.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesdePage8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SimpleButton simpleButton1;
        private SimpleButton btnRefreshPage1;
        private SimpleButton cmdSalir;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridLookUpEdit gleCliente;
        private GridView gridLookUpEdit1View;
        private LabelControl labelControl3;
        private Despachos.Reportes.dsReporte dsReporte1;
        private System.Windows.Forms.BindingSource bsListReportes;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage3;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colPuntodeVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colCAI;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentoInicial;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentoFinal;
        private DevExpress.XtraGrid.Columns.GridColumn colValor;
        private DateEdit dtDesdePage1;
        private LabelControl labelControl1;
        private DateEdit dtHastaPage1;
        private LabelControl labelControl2;
        private DateEdit dtHastaPage3;
        private LabelControl labelControl4;
        private DateEdit dtDesdePage3;
        private LabelControl labelControl5;
        private GridControl gridControl2;
        private GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private SimpleButton btnRefreshPage3;
        private DateEdit dtHastaPage2;
        private LabelControl labelControl6;
        private DateEdit dtDesdePage2;
        private LabelControl labelControl7;
        private GridControl gridControl3;
        private GridView gridView3;
        private SimpleButton btnRefreshPage2;
        private DevExpress.XtraGrid.Columns.GridColumn colid_punto_venta;
        private DevExpress.XtraGrid.Columns.GridColumn colPuntodeVenta1;
        private DevExpress.XtraGrid.Columns.GridColumn colnmes;
        private DevExpress.XtraGrid.Columns.GridColumn colmes_name;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_mes;
        private DevExpress.XtraGrid.Columns.GridColumn colanio;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage4;
        private DateEdit dtHastaPage4;
        private LabelControl labelControl8;
        private DateEdit dtDesdePage4;
        private LabelControl labelControl9;
        private GridControl gridControl4;
        private GridView gridView4;
        private SimpleButton btnRefreshPage4;
        private DevExpress.XtraGrid.Columns.GridColumn colid_punto_venta1;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_punto_venta;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalFila;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage5;
        private DateEdit dtHastaPage5;
        private LabelControl labelControl10;
        private DateEdit dtDesdePage5;
        private LabelControl labelControl11;
        private GridControl gridControl5;
        private GridView gridView5;
        private SimpleButton btnRefreshPage5;
        private DevExpress.XtraGrid.Columns.GridColumn colid_punto_venta2;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_punto_venta1;
        private DevExpress.XtraGrid.Columns.GridColumn colcliente_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalFila1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage6;
        private DateEdit dtHastaPage6;
        private LabelControl labelControl12;
        private DateEdit dtDesdePage6;
        private LabelControl labelControl13;
        private SimpleButton btnRefreshPage6;
        private GridControl gridControl6;
        private GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor1;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_ventas;
        private DevExpress.XtraGrid.Columns.GridColumn colisv;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private GridLookUpEdit glePuntoVenta6;
        private GridView gridView7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private LabelControl labelControl14;
        private System.Windows.Forms.BindingSource bS_PuntosVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colHora;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage7;
        private GridLookUpEdit glePuntoVenta7;
        private GridView gridView9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private LabelControl labelControl15;
        private DateEdit dtHastaPage7;
        private LabelControl labelControl16;
        private DateEdit dtDesdePage7;
        private LabelControl labelControl17;
        private SimpleButton btnRefreshPage7;
        private GridControl gridControl7;
        private GridView gridView8;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage8;
        private GridLookUpEdit glePuntoVenta8;
        private GridView gridView10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private LabelControl labelControl18;
        private DateEdit dtHastaPage8;
        private LabelControl labelControl19;
        private DateEdit dtDesdePage8;
        private LabelControl labelControl20;
        private SimpleButton btnRefreshPage8;
        private GridControl gridControl8;
        private GridView gridView11;
    }
}