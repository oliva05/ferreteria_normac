namespace JAGUAR_PRO.Contabilidad.Proveedores
{
    partial class frmCRUDAnticipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCRUDAnticipo));
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lueProveedor = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.jAGUARProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMantenimiento1 = new JAGUAR_PRO.Mantenimientos.dsMantenimiento();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
            this.txtMonto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.memoComentario = new DevExpress.XtraEditors.MemoEdit();
            this.txtDocOC = new DevExpress.XtraEditors.TextEdit();
            this.btnSelecOC = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lueProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jAGUARProveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoComentario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocOC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(0, 0);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(498, 25);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "Anticipo";
            // 
            // lueProveedor
            // 
            this.lueProveedor.Location = new System.Drawing.Point(149, 54);
            this.lueProveedor.Name = "lueProveedor";
            this.lueProveedor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lueProveedor.Properties.Appearance.Options.UseFont = true;
            this.lueProveedor.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lueProveedor.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueProveedor.Properties.DataSource = this.jAGUARProveedorBindingSource;
            this.lueProveedor.Properties.DisplayMember = "nombre";
            this.lueProveedor.Properties.NullText = "";
            this.lueProveedor.Properties.PopupView = this.searchLookUpEdit1View;
            this.lueProveedor.Properties.ValueMember = "id";
            this.lueProveedor.Size = new System.Drawing.Size(327, 24);
            this.lueProveedor.TabIndex = 30;
            this.lueProveedor.EditValueChanged += new System.EventHandler(this.lueProveedor_EditValueChanged);
            // 
            // jAGUARProveedorBindingSource
            // 
            this.jAGUARProveedorBindingSource.DataMember = "JAGUAR_Proveedor";
            this.jAGUARProveedorBindingSource.DataSource = this.dsMantenimiento1;
            // 
            // dsMantenimiento1
            // 
            this.dsMantenimiento1.DataSetName = "dsMantenimiento";
            this.dsMantenimiento1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "Codigo";
            this.gridColumn1.FieldName = "codigo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "Proveedor";
            this.gridColumn2.FieldName = "nombre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(21, 56);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(128, 17);
            this.labelControl7.TabIndex = 31;
            this.labelControl7.Text = "Proveedor:____________";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(261, 268);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(139, 42);
            this.simpleButton1.TabIndex = 33;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmdNew
            // 
            this.cmdNew.Appearance.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdNew.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNew.Appearance.Options.UseBackColor = true;
            this.cmdNew.Appearance.Options.UseFont = true;
            this.cmdNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cmdNew.ImageOptions.Image = global::JAGUAR_PRO.Properties.Resources.save_32x32;
            this.cmdNew.Location = new System.Drawing.Point(87, 268);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(139, 42);
            this.cmdNew.TabIndex = 32;
            this.cmdNew.Text = "Guardar";
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMonto.Location = new System.Drawing.Point(149, 87);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtMonto.Properties.Appearance.Options.UseFont = true;
            this.txtMonto.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMonto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtMonto.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtMonto.Properties.MaskSettings.Set("mask", "n");
            this.txtMonto.Properties.UseMaskAsDisplayFormat = true;
            this.txtMonto.Size = new System.Drawing.Size(160, 24);
            this.txtMonto.TabIndex = 34;
            this.txtMonto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonto_KeyDown);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(21, 90);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(144, 17);
            this.labelControl4.TabIndex = 35;
            this.labelControl4.Text = "Monto:___________________:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(21, 124);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(148, 17);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Ligar OC:__________________";
            // 
            // memoComentario
            // 
            this.memoComentario.Location = new System.Drawing.Point(149, 159);
            this.memoComentario.Name = "memoComentario";
            this.memoComentario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.memoComentario.Properties.Appearance.Options.UseFont = true;
            this.memoComentario.Size = new System.Drawing.Size(267, 92);
            this.memoComentario.TabIndex = 37;
            this.memoComentario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.memoComentario_KeyDown);
            // 
            // txtDocOC
            // 
            this.txtDocOC.EditValue = "";
            this.txtDocOC.Enabled = false;
            this.txtDocOC.Location = new System.Drawing.Point(149, 121);
            this.txtDocOC.Name = "txtDocOC";
            this.txtDocOC.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtDocOC.Properties.Appearance.Options.UseFont = true;
            this.txtDocOC.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDocOC.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDocOC.Size = new System.Drawing.Size(160, 24);
            this.txtDocOC.TabIndex = 38;
            // 
            // btnSelecOC
            // 
            this.btnSelecOC.Appearance.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSelecOC.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecOC.Appearance.Options.UseBackColor = true;
            this.btnSelecOC.Appearance.Options.UseFont = true;
            this.btnSelecOC.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSelecOC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecOC.ImageOptions.Image")));
            this.btnSelecOC.Location = new System.Drawing.Point(315, 116);
            this.btnSelecOC.Name = "btnSelecOC";
            this.btnSelecOC.Size = new System.Drawing.Size(105, 31);
            this.btnSelecOC.TabIndex = 39;
            this.btnSelecOC.Text = "Seleccionar";
            this.btnSelecOC.Click += new System.EventHandler(this.btnSelecOC_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(21, 160);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(167, 17);
            this.labelControl2.TabIndex = 40;
            this.labelControl2.Text = "Comentario:__________________";
            // 
            // frmCRUDAnticipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 338);
            this.Controls.Add(this.btnSelecOC);
            this.Controls.Add(this.txtDocOC);
            this.Controls.Add(this.memoComentario);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdNew);
            this.Controls.Add(this.lueProveedor);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl2);
            this.Name = "frmCRUDAnticipo";
            this.Text = "Anticipo";
            ((System.ComponentModel.ISupportInitialize)(this.lueProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jAGUARProveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoComentario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocOC.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SearchLookUpEdit lueProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton cmdNew;
        private DevExpress.XtraEditors.TextEdit txtMonto;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit memoComentario;
        private DevExpress.XtraEditors.TextEdit txtDocOC;
        private DevExpress.XtraEditors.SimpleButton btnSelecOC;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Mantenimientos.dsMantenimiento dsMantenimiento1;
        private System.Windows.Forms.BindingSource jAGUARProveedorBindingSource;
    }
}