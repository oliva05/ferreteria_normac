namespace JAGUAR_PRO.Contabilidad.Depreciacion
{
    partial class frmDepreciacionOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepreciacionOP));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsActivosFijos1 = new JAGUAR_PRO.Contabilidad.ActivosFijos.dsActivosFijos();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colseleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_activo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_compra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_compra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_residual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvida_util = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepreciacion_mes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepreciacion_acumulada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_libro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtPriodo = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsActivosFijos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPriodo.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "calculo_depreciacion";
            this.gridControl1.DataSource = this.dsActivosFijos1;
            this.gridControl1.Location = new System.Drawing.Point(4, 107);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1328, 602);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsActivosFijos1
            // 
            this.dsActivosFijos1.DataSetName = "dsActivosFijos";
            this.dsActivosFijos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colseleccionado,
            this.colcodigo_activo,
            this.colnombre,
            this.colfecha_compra,
            this.colvalor_compra,
            this.colvalor_residual,
            this.colvida_util,
            this.coldepreciacion_mes,
            this.coldepreciacion_acumulada,
            this.colvalor_libro});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colseleccionado
            // 
            this.colseleccionado.Caption = "Seleccionado";
            this.colseleccionado.FieldName = "seleccionado";
            this.colseleccionado.Name = "colseleccionado";
            this.colseleccionado.Visible = true;
            this.colseleccionado.VisibleIndex = 0;
            this.colseleccionado.Width = 88;
            // 
            // colcodigo_activo
            // 
            this.colcodigo_activo.Caption = "Codigo";
            this.colcodigo_activo.FieldName = "codigo_activo";
            this.colcodigo_activo.Name = "colcodigo_activo";
            this.colcodigo_activo.OptionsColumn.ReadOnly = true;
            this.colcodigo_activo.Visible = true;
            this.colcodigo_activo.VisibleIndex = 1;
            this.colcodigo_activo.Width = 100;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Descripcion del Activo";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.ReadOnly = true;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 2;
            this.colnombre.Width = 174;
            // 
            // colfecha_compra
            // 
            this.colfecha_compra.Caption = "Fecha Compra";
            this.colfecha_compra.FieldName = "fecha_compra";
            this.colfecha_compra.Name = "colfecha_compra";
            this.colfecha_compra.OptionsColumn.ReadOnly = true;
            this.colfecha_compra.Visible = true;
            this.colfecha_compra.VisibleIndex = 3;
            this.colfecha_compra.Width = 131;
            // 
            // colvalor_compra
            // 
            this.colvalor_compra.Caption = "Valor Compra";
            this.colvalor_compra.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colvalor_compra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalor_compra.FieldName = "valor_compra";
            this.colvalor_compra.Name = "colvalor_compra";
            this.colvalor_compra.OptionsColumn.ReadOnly = true;
            this.colvalor_compra.Visible = true;
            this.colvalor_compra.VisibleIndex = 4;
            this.colvalor_compra.Width = 131;
            // 
            // colvalor_residual
            // 
            this.colvalor_residual.Caption = "Valor Residual";
            this.colvalor_residual.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colvalor_residual.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalor_residual.FieldName = "valor_residual";
            this.colvalor_residual.Name = "colvalor_residual";
            this.colvalor_residual.OptionsColumn.ReadOnly = true;
            this.colvalor_residual.Visible = true;
            this.colvalor_residual.VisibleIndex = 5;
            this.colvalor_residual.Width = 131;
            // 
            // colvida_util
            // 
            this.colvida_util.Caption = "Vida Util";
            this.colvida_util.FieldName = "vida_util";
            this.colvida_util.Name = "colvida_util";
            this.colvida_util.OptionsColumn.ReadOnly = true;
            this.colvida_util.Visible = true;
            this.colvida_util.VisibleIndex = 6;
            this.colvida_util.Width = 131;
            // 
            // coldepreciacion_mes
            // 
            this.coldepreciacion_mes.Caption = "Depreciacion Mes";
            this.coldepreciacion_mes.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.coldepreciacion_mes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldepreciacion_mes.FieldName = "depreciacion_mes";
            this.coldepreciacion_mes.Name = "coldepreciacion_mes";
            this.coldepreciacion_mes.OptionsColumn.ReadOnly = true;
            this.coldepreciacion_mes.Visible = true;
            this.coldepreciacion_mes.VisibleIndex = 7;
            this.coldepreciacion_mes.Width = 131;
            // 
            // coldepreciacion_acumulada
            // 
            this.coldepreciacion_acumulada.Caption = "Depreciacion Acumulada";
            this.coldepreciacion_acumulada.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.coldepreciacion_acumulada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldepreciacion_acumulada.FieldName = "depreciacion_acumulada";
            this.coldepreciacion_acumulada.Name = "coldepreciacion_acumulada";
            this.coldepreciacion_acumulada.OptionsColumn.ReadOnly = true;
            this.coldepreciacion_acumulada.Visible = true;
            this.coldepreciacion_acumulada.VisibleIndex = 8;
            this.coldepreciacion_acumulada.Width = 131;
            // 
            // colvalor_libro
            // 
            this.colvalor_libro.Caption = "Valor en Libro";
            this.colvalor_libro.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colvalor_libro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalor_libro.FieldName = "valor_libro";
            this.colvalor_libro.Name = "colvalor_libro";
            this.colvalor_libro.OptionsColumn.ReadOnly = true;
            this.colvalor_libro.Visible = true;
            this.colvalor_libro.VisibleIndex = 9;
            this.colvalor_libro.Width = 153;
            // 
            // dtPriodo
            // 
            this.dtPriodo.EditValue = null;
            this.dtPriodo.Location = new System.Drawing.Point(323, 48);
            this.dtPriodo.Name = "dtPriodo";
            this.dtPriodo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtPriodo.Properties.Appearance.Options.UseFont = true;
            this.dtPriodo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtPriodo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtPriodo.Properties.MaskSettings.Set("mask", "Y");
            this.dtPriodo.Properties.UseMaskAsDisplayFormat = true;
            this.dtPriodo.Size = new System.Drawing.Size(176, 24);
            this.dtPriodo.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(215, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Periodo Contable";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAgregar.ImageOptions.Image = global::JAGUAR_PRO.Properties.Resources.plus;
            this.btnAgregar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAgregar.Location = new System.Drawing.Point(12, 34);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(175, 47);
            this.btnAgregar.TabIndex = 148;
            this.btnAgregar.Text = "Correr Depreciacion";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(1223, 34);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(100, 47);
            this.btnAtras.TabIndex = 149;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frmDepreciacionOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 712);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtPriodo);
            this.Controls.Add(this.gridControl1);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmDepreciacionOP";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsActivosFijos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPriodo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPriodo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit dtPriodo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private ActivosFijos.dsActivosFijos dsActivosFijos1;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_activo;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_compra;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_compra;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_residual;
        private DevExpress.XtraGrid.Columns.GridColumn colvida_util;
        private DevExpress.XtraGrid.Columns.GridColumn coldepreciacion_mes;
        private DevExpress.XtraGrid.Columns.GridColumn coldepreciacion_acumulada;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_libro;
    }
}