namespace JAGUAR_PRO.Contabilidad.CuentasContables
{
    partial class frmCuentasContablesCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuentasContablesCRUD));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoCuenta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.tsActivo = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.grdTipoCuenta = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dsCuentasC1 = new JAGUAR_PRO.Contabilidad.CuentasContables.dsCuentasC();
            this.tipocuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.grdCuentaPadre = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.getaccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoCuenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoCuenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCuentasC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipocuentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCuentaPadre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getaccountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(69, 202);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(89, 17);
            this.labelControl3.TabIndex = 132;
            this.labelControl3.Text = "Tipo de Cuenta";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(212, 158);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Properties.MaxLength = 50;
            this.txtDescripcion.Size = new System.Drawing.Size(215, 24);
            this.txtDescripcion.TabIndex = 131;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(69, 161);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(126, 17);
            this.labelControl2.TabIndex = 130;
            this.labelControl2.Text = "Nombre de la Cuenta";
            // 
            // txtCodigoCuenta
            // 
            this.txtCodigoCuenta.Enabled = false;
            this.txtCodigoCuenta.Location = new System.Drawing.Point(212, 122);
            this.txtCodigoCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoCuenta.Name = "txtCodigoCuenta";
            this.txtCodigoCuenta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCuenta.Properties.Appearance.Options.UseFont = true;
            this.txtCodigoCuenta.Properties.MaxLength = 20;
            this.txtCodigoCuenta.Size = new System.Drawing.Size(215, 24);
            this.txtCodigoCuenta.TabIndex = 129;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(69, 125);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 17);
            this.labelControl1.TabIndex = 128;
            this.labelControl1.Text = "Codigo Cuenta";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Coral;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(418, 26);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(107, 42);
            this.simpleButton2.TabIndex = 143;
            this.simpleButton2.Text = "Volver";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Appearance.Options.UseBackColor = true;
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.Appearance.Options.UseForeColor = true;
            this.btnGuardar.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnGuardar.AppearanceHovered.Options.UseBackColor = true;
            this.btnGuardar.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnGuardar.AppearancePressed.Options.UseBackColor = true;
            this.btnGuardar.ImageOptions.Image = global::JAGUAR_PRO.Properties.Resources.save_24x24;
            this.btnGuardar.Location = new System.Drawing.Point(29, 26);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 42);
            this.btnGuardar.TabIndex = 142;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tsActivo
            // 
            this.tsActivo.EditValue = true;
            this.tsActivo.Location = new System.Drawing.Point(243, 350);
            this.tsActivo.Name = "tsActivo";
            this.tsActivo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tsActivo.Properties.Appearance.Options.UseFont = true;
            this.tsActivo.Properties.OffText = "No";
            this.tsActivo.Properties.OnText = "Si";
            this.tsActivo.Size = new System.Drawing.Size(95, 24);
            this.tsActivo.TabIndex = 144;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(201, 353);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 17);
            this.labelControl5.TabIndex = 145;
            this.labelControl5.Text = "Activo";
            // 
            // grdTipoCuenta
            // 
            this.grdTipoCuenta.Location = new System.Drawing.Point(213, 199);
            this.grdTipoCuenta.Name = "grdTipoCuenta";
            this.grdTipoCuenta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdTipoCuenta.Properties.Appearance.Options.UseFont = true;
            this.grdTipoCuenta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdTipoCuenta.Properties.DataSource = this.tipocuentaBindingSource;
            this.grdTipoCuenta.Properties.DisplayMember = "Descripcion";
            this.grdTipoCuenta.Properties.NullText = "";
            this.grdTipoCuenta.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdTipoCuenta.Properties.ValueMember = "Codigo";
            this.grdTipoCuenta.Size = new System.Drawing.Size(214, 24);
            this.grdTipoCuenta.TabIndex = 146;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // dsCuentasC1
            // 
            this.dsCuentasC1.DataSetName = "dsCuentasC";
            this.dsCuentasC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipocuentaBindingSource
            // 
            this.tipocuentaBindingSource.DataMember = "tipo_cuenta";
            this.tipocuentaBindingSource.DataSource = this.dsCuentasC1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(69, 245);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(118, 17);
            this.labelControl4.TabIndex = 147;
            this.labelControl4.Text = "Tipo de Movimiento";
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.EditValue = true;
            this.toggleSwitch1.Location = new System.Drawing.Point(213, 242);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.toggleSwitch1.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch1.Properties.OffText = "Cuenta de Agrupaciones";
            this.toggleSwitch1.Properties.OnText = "Transacciones";
            this.toggleSwitch1.Size = new System.Drawing.Size(214, 24);
            this.toggleSwitch1.TabIndex = 148;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(69, 289);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(78, 17);
            this.labelControl6.TabIndex = 149;
            this.labelControl6.Text = "Cuenta Padre";
            // 
            // grdCuentaPadre
            // 
            this.grdCuentaPadre.Location = new System.Drawing.Point(212, 286);
            this.grdCuentaPadre.Name = "grdCuentaPadre";
            this.grdCuentaPadre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdCuentaPadre.Properties.Appearance.Options.UseFont = true;
            this.grdCuentaPadre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdCuentaPadre.Properties.DataSource = this.getaccountBindingSource;
            this.grdCuentaPadre.Properties.DisplayMember = "concat_";
            this.grdCuentaPadre.Properties.NullText = "";
            this.grdCuentaPadre.Properties.PopupView = this.gridLookUpEdit2View;
            this.grdCuentaPadre.Properties.ValueMember = "CuentaID";
            this.grdCuentaPadre.Size = new System.Drawing.Size(214, 24);
            this.grdCuentaPadre.TabIndex = 150;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // getaccountBindingSource
            // 
            this.getaccountBindingSource.DataMember = "get_account";
            this.getaccountBindingSource.DataSource = this.dsCuentasC1;
            // 
            // frmCuentasContablesCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 412);
            this.Controls.Add(this.grdCuentaPadre);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.grdTipoCuenta);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.tsActivo);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtCodigoCuenta);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.Name = "frmCuentasContablesCRUD";
            this.Text = "Cuenta Contable";
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoCuenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoCuenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCuentasC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipocuentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCuentaPadre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getaccountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCodigoCuenta;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.ToggleSwitch tsActivo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GridLookUpEdit grdTipoCuenta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource tipocuentaBindingSource;
        private dsCuentasC dsCuentasC1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GridLookUpEdit grdCuentaPadre;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private System.Windows.Forms.BindingSource getaccountBindingSource;
    }
}