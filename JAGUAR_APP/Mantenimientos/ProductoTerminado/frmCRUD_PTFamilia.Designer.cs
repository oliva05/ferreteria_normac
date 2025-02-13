namespace JAGUAR_PRO.Mantenimientos.ProductoTerminado
{
    partial class frmCRUD_PTFamilia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCRUD_PTFamilia));
            this.lblTituloVentana = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitchEnablePT = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchEnablePT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVentana.Appearance.Options.UseFont = true;
            this.lblTituloVentana.Location = new System.Drawing.Point(158, 12);
            this.lblTituloVentana.Name = "lblTituloVentana";
            this.lblTituloVentana.Size = new System.Drawing.Size(90, 20);
            this.lblTituloVentana.TabIndex = 28;
            this.lblTituloVentana.Text = "Crear Familia";
            // 
            // toggleSwitchEnablePT
            // 
            this.toggleSwitchEnablePT.Location = new System.Drawing.Point(201, 161);
            this.toggleSwitchEnablePT.Name = "toggleSwitchEnablePT";
            this.toggleSwitchEnablePT.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toggleSwitchEnablePT.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitchEnablePT.Properties.OffText = "No";
            this.toggleSwitchEnablePT.Properties.OnText = "Si";
            this.toggleSwitchEnablePT.Size = new System.Drawing.Size(115, 20);
            this.toggleSwitchEnablePT.TabIndex = 30;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(104, 163);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(159, 15);
            this.labelControl2.TabIndex = 29;
            this.labelControl2.Text = "Activo_________________________";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodigo.Location = new System.Drawing.Point(201, 69);
            this.txtCodigo.MaxLength = 3;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(177, 23);
            this.txtCodigo.TabIndex = 34;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(13, 74);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(196, 15);
            this.labelControl5.TabIndex = 33;
            this.labelControl5.Text = "Código de Familia____________________";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescripcion.Location = new System.Drawing.Point(201, 98);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(177, 23);
            this.txtDescripcion.TabIndex = 32;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(13, 102);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(194, 15);
            this.labelControl4.TabIndex = 31;
            this.labelControl4.Text = "Descripcion de Familia_______________";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdGuardar.ImageOptions.SvgImage")));
            this.cmdGuardar.Location = new System.Drawing.Point(50, 236);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(132, 42);
            this.cmdGuardar.TabIndex = 36;
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
            this.cmdCerrar.Location = new System.Drawing.Point(227, 236);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(132, 42);
            this.cmdCerrar.TabIndex = 35;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // frmCRUD_PTFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 303);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.toggleSwitchEnablePT);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblTituloVentana);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmCRUD_PTFamilia";
            this.Text = "CRUD Familia";
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchEnablePT.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTituloVentana;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchEnablePT;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
    }
}