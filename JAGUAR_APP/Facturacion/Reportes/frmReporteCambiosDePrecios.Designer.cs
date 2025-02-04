namespace JAGUAR_APP.Facturacion.Reportes
{
    partial class frmReporteCambiosDePrecios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteCambiosDePrecios));
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnRefreshPage1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsReportesFacturacion1 = new JAGUAR_APP.Facturacion.Reportes.dsReportesFacturacion();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHabilitado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaHora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPuntoVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesFacturacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(339, 10);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtHasta.Properties.Appearance.Options.UseFont = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Size = new System.Drawing.Size(151, 24);
            this.dtHasta.TabIndex = 75;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(255, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 17);
            this.labelControl2.TabIndex = 74;
            this.labelControl2.Text = "Fecha hasta:";
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(97, 10);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtDesde.Properties.Appearance.Options.UseFont = true;
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Size = new System.Drawing.Size(151, 24);
            this.dtDesde.TabIndex = 73;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 17);
            this.labelControl1.TabIndex = 72;
            this.labelControl1.Text = "Fecha desde:";
            // 
            // btnRefreshPage1
            // 
            this.btnRefreshPage1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRefreshPage1.Appearance.Options.UseFont = true;
            this.btnRefreshPage1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefreshPage1.ImageOptions.SvgImage")));
            this.btnRefreshPage1.Location = new System.Drawing.Point(496, 1);
            this.btnRefreshPage1.Name = "btnRefreshPage1";
            this.btnRefreshPage1.Size = new System.Drawing.Size(114, 38);
            this.btnRefreshPage1.TabIndex = 71;
            this.btnRefreshPage1.Text = "Actualizar";
            this.btnRefreshPage1.Click += new System.EventHandler(this.btnRefreshPage1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "cambios_de_precio";
            this.gridControl1.DataSource = this.dsReportesFacturacion1;
            this.gridControl1.Location = new System.Drawing.Point(1, 45);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(880, 483);
            this.gridControl1.TabIndex = 76;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsReportesFacturacion1
            // 
            this.dsReportesFacturacion1.DataSetName = "dsReportesFacturacion";
            this.dsReportesFacturacion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransactionNumber,
            this.colcode,
            this.coldescripcion,
            this.colprecio,
            this.colNombreCliente,
            this.colHabilitado,
            this.colFechaHora,
            this.colNombreUsuario,
            this.colPuntoVenta});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colTransactionNumber
            // 
            this.colTransactionNumber.FieldName = "TransactionNumber";
            this.colTransactionNumber.Name = "colTransactionNumber";
            this.colTransactionNumber.OptionsColumn.ReadOnly = true;
            this.colTransactionNumber.Visible = true;
            this.colTransactionNumber.VisibleIndex = 0;
            // 
            // colcode
            // 
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.OptionsColumn.ReadOnly = true;
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 1;
            this.colcode.Width = 62;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.ReadOnly = true;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 2;
            this.coldescripcion.Width = 118;
            // 
            // colprecio
            // 
            this.colprecio.DisplayFormat.FormatString = "n2";
            this.colprecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colprecio.FieldName = "precio";
            this.colprecio.Name = "colprecio";
            this.colprecio.OptionsColumn.ReadOnly = true;
            this.colprecio.Visible = true;
            this.colprecio.VisibleIndex = 3;
            this.colprecio.Width = 56;
            // 
            // colNombreCliente
            // 
            this.colNombreCliente.FieldName = "NombreCliente";
            this.colNombreCliente.Name = "colNombreCliente";
            this.colNombreCliente.OptionsColumn.ReadOnly = true;
            this.colNombreCliente.Visible = true;
            this.colNombreCliente.VisibleIndex = 4;
            this.colNombreCliente.Width = 135;
            // 
            // colHabilitado
            // 
            this.colHabilitado.FieldName = "Habilitado";
            this.colHabilitado.Name = "colHabilitado";
            this.colHabilitado.OptionsColumn.ReadOnly = true;
            this.colHabilitado.Visible = true;
            this.colHabilitado.VisibleIndex = 5;
            this.colHabilitado.Width = 71;
            // 
            // colFechaHora
            // 
            this.colFechaHora.DisplayFormat.FormatString = "g";
            this.colFechaHora.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaHora.FieldName = "FechaHora";
            this.colFechaHora.Name = "colFechaHora";
            this.colFechaHora.OptionsColumn.ReadOnly = true;
            this.colFechaHora.Visible = true;
            this.colFechaHora.VisibleIndex = 6;
            this.colFechaHora.Width = 122;
            // 
            // colNombreUsuario
            // 
            this.colNombreUsuario.FieldName = "NombreUsuario";
            this.colNombreUsuario.Name = "colNombreUsuario";
            this.colNombreUsuario.OptionsColumn.ReadOnly = true;
            this.colNombreUsuario.Visible = true;
            this.colNombreUsuario.VisibleIndex = 7;
            this.colNombreUsuario.Width = 104;
            // 
            // colPuntoVenta
            // 
            this.colPuntoVenta.FieldName = "PuntoVenta";
            this.colPuntoVenta.Name = "colPuntoVenta";
            this.colPuntoVenta.OptionsColumn.ReadOnly = true;
            this.colPuntoVenta.Visible = true;
            this.colPuntoVenta.VisibleIndex = 8;
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
            this.simpleButton1.Location = new System.Drawing.Point(751, 1);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(114, 38);
            this.simpleButton1.TabIndex = 77;
            this.simpleButton1.Text = "Excel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmReporteCambiosDePrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 531);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnRefreshPage1);
            this.Name = "frmReporteCambiosDePrecios";
            this.Text = "Reporte de Cambios de Precios";
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesFacturacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnRefreshPage1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private dsReportesFacturacion dsReportesFacturacion1;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colHabilitado;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaHora;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colPuntoVenta;
    }
}