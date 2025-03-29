namespace JAGUAR_PRO.Mantenimientos.ProductoTerminado
{
    partial class frmCRUD_Marca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCRUD_Marca));
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitchEnablePT = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblTituloVentana = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxPaises = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.hyperSitio = new DevExpress.XtraEditors.HyperLinkEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchEnablePT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxPaises.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperSitio.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdGuardar.ImageOptions.SvgImage")));
            this.cmdGuardar.Location = new System.Drawing.Point(72, 273);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(132, 42);
            this.cmdGuardar.TabIndex = 45;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.Pink;
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdCerrar.ImageOptions.SvgImage")));
            this.cmdCerrar.Location = new System.Drawing.Point(249, 273);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(132, 42);
            this.cmdCerrar.TabIndex = 44;
            this.cmdCerrar.Text = "Cerrar";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.Location = new System.Drawing.Point(226, 83);
            this.txtNombre.MaxLength = 3;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 23);
            this.txtNombre.TabIndex = 43;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(38, 88);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(195, 15);
            this.labelControl5.TabIndex = 42;
            this.labelControl5.Text = "Nombre Marca_______________________";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescripcion.Location = new System.Drawing.Point(226, 120);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(177, 23);
            this.txtDescripcion.TabIndex = 41;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(38, 125);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(192, 15);
            this.labelControl4.TabIndex = 40;
            this.labelControl4.Text = "Descripcion__________________________";
            // 
            // toggleSwitchEnablePT
            // 
            this.toggleSwitchEnablePT.EditValue = true;
            this.toggleSwitchEnablePT.Location = new System.Drawing.Point(211, 233);
            this.toggleSwitchEnablePT.Name = "toggleSwitchEnablePT";
            this.toggleSwitchEnablePT.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toggleSwitchEnablePT.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitchEnablePT.Properties.OffText = "No";
            this.toggleSwitchEnablePT.Properties.OnText = "Si";
            this.toggleSwitchEnablePT.Size = new System.Drawing.Size(115, 22);
            this.toggleSwitchEnablePT.TabIndex = 39;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(114, 235);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(159, 15);
            this.labelControl2.TabIndex = 38;
            this.labelControl2.Text = "Activo_________________________";
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVentana.Appearance.Options.UseFont = true;
            this.lblTituloVentana.Location = new System.Drawing.Point(183, 34);
            this.lblTituloVentana.Name = "lblTituloVentana";
            this.lblTituloVentana.Size = new System.Drawing.Size(84, 20);
            this.lblTituloVentana.TabIndex = 37;
            this.lblTituloVentana.Text = "Crear Marca";
            // 
            // comboBoxPaises
            // 
            this.comboBoxPaises.Location = new System.Drawing.Point(226, 157);
            this.comboBoxPaises.Name = "comboBoxPaises";
            this.comboBoxPaises.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxPaises.Properties.Appearance.Options.UseFont = true;
            this.comboBoxPaises.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxPaises.Size = new System.Drawing.Size(177, 22);
            this.comboBoxPaises.TabIndex = 46;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(38, 161);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(195, 15);
            this.labelControl1.TabIndex = 47;
            this.labelControl1.Text = "Pais Origen___________________________";
            // 
            // hyperSitio
            // 
            this.hyperSitio.Location = new System.Drawing.Point(226, 194);
            this.hyperSitio.Name = "hyperSitio";
            this.hyperSitio.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hyperSitio.Properties.Appearance.Options.UseFont = true;
            this.hyperSitio.Size = new System.Drawing.Size(177, 22);
            this.hyperSitio.TabIndex = 48;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(38, 198);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(215, 15);
            this.labelControl3.TabIndex = 49;
            this.labelControl3.Text = "Sitio Web_________________________________";
            // 
            // frmCRUD_Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 336);
            this.Controls.Add(this.hyperSitio);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.comboBoxPaises);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.toggleSwitchEnablePT);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblTituloVentana);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmCRUD_Marca";
            this.Text = "Marca";
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchEnablePT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxPaises.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperSitio.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private System.Windows.Forms.TextBox txtNombre;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchEnablePT;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblTituloVentana;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxPaises;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.HyperLinkEdit hyperSitio;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}