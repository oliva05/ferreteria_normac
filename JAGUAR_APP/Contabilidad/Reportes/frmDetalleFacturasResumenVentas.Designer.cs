namespace JAGUAR_PRO.Contabilidad.Reportes
{
    partial class frmDetalleFacturasResumenVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleFacturasResumenVentas));
            this.dsReportesBasicosConta1 = new JAGUAR_PRO.Contabilidad.Reportes.dsReportesBasicosConta();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfactura_i = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfactura_f = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgravado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmdSalir = new DevExpress.XtraEditors.SimpleButton();
            this.cmdExcel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesBasicosConta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsReportesBasicosConta1
            // 
            this.dsReportesBasicosConta1.DataSetName = "dsReportesBasicosConta";
            this.dsReportesBasicosConta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "detalle_facturas_rpt";
            this.gridControl1.DataSource = this.dsReportesBasicosConta1;
            this.gridControl1.Location = new System.Drawing.Point(1, 51);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(737, 424);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfecha,
            this.colfactura_i,
            this.colfactura_f,
            this.colexento,
            this.colgravado,
            this.colisv,
            this.coltotal});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colfecha
            // 
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 0;
            // 
            // colfactura_i
            // 
            this.colfactura_i.FieldName = "factura_i";
            this.colfactura_i.Name = "colfactura_i";
            this.colfactura_i.Visible = true;
            this.colfactura_i.VisibleIndex = 1;
            // 
            // colfactura_f
            // 
            this.colfactura_f.FieldName = "factura_f";
            this.colfactura_f.Name = "colfactura_f";
            this.colfactura_f.Visible = true;
            this.colfactura_f.VisibleIndex = 2;
            // 
            // colexento
            // 
            this.colexento.DisplayFormat.FormatString = "n2";
            this.colexento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colexento.FieldName = "exento";
            this.colexento.Name = "colexento";
            this.colexento.Visible = true;
            this.colexento.VisibleIndex = 3;
            // 
            // colgravado
            // 
            this.colgravado.DisplayFormat.FormatString = "n2";
            this.colgravado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colgravado.FieldName = "gravado";
            this.colgravado.Name = "colgravado";
            this.colgravado.Visible = true;
            this.colgravado.VisibleIndex = 4;
            // 
            // colisv
            // 
            this.colisv.DisplayFormat.FormatString = "n2";
            this.colisv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colisv.FieldName = "isv";
            this.colisv.Name = "colisv";
            this.colisv.Visible = true;
            this.colisv.VisibleIndex = 5;
            // 
            // coltotal
            // 
            this.coltotal.DisplayFormat.FormatString = "n2";
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(8, 22);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(177, 23);
            this.labelControl3.TabIndex = 81;
            this.labelControl3.Text = "Detalle de documentos";
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
            this.cmdSalir.Location = new System.Drawing.Point(624, 7);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(114, 38);
            this.cmdSalir.TabIndex = 80;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdExcel
            // 
            this.cmdExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExcel.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.cmdExcel.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExcel.Appearance.Options.UseBackColor = true;
            this.cmdExcel.Appearance.Options.UseFont = true;
            this.cmdExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdExcel.ImageOptions.Image")));
            this.cmdExcel.Location = new System.Drawing.Point(504, 7);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.Size = new System.Drawing.Size(114, 38);
            this.cmdExcel.TabIndex = 79;
            this.cmdExcel.Text = "Excel";
            this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
            // 
            // frmDetalleFacturasResumenVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 476);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdExcel);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmDetalleFacturasResumenVentas";
            this.Text = "Detalle de Facturas Resumen Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesBasicosConta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsReportesBasicosConta dsReportesBasicosConta1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colfactura_i;
        private DevExpress.XtraGrid.Columns.GridColumn colfactura_f;
        private DevExpress.XtraGrid.Columns.GridColumn colexento;
        private DevExpress.XtraGrid.Columns.GridColumn colgravado;
        private DevExpress.XtraGrid.Columns.GridColumn colisv;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton cmdSalir;
        private DevExpress.XtraEditors.SimpleButton cmdExcel;
    }
}