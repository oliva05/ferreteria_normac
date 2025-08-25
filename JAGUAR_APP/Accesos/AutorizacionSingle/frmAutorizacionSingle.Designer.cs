namespace JAGUAR_PRO.Accesos.AutorizacionSingle
{
    partial class frmAutorizacionSingle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutorizacionSingle));
            this.btnCancelarAutorizacionDirecta = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirmarAutorizacionDirecta = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtClave = new DevExpress.XtraEditors.TextEdit();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtClave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarAutorizacionDirecta
            // 
            this.btnCancelarAutorizacionDirecta.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAutorizacionDirecta.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarAutorizacionDirecta.Appearance.Options.UseFont = true;
            this.btnCancelarAutorizacionDirecta.Appearance.Options.UseForeColor = true;
            this.btnCancelarAutorizacionDirecta.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnCancelarAutorizacionDirecta.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancelarAutorizacionDirecta.ImageOptions.SvgImage")));
            this.btnCancelarAutorizacionDirecta.Location = new System.Drawing.Point(159, 152);
            this.btnCancelarAutorizacionDirecta.Name = "btnCancelarAutorizacionDirecta";
            this.btnCancelarAutorizacionDirecta.Size = new System.Drawing.Size(110, 47);
            this.btnCancelarAutorizacionDirecta.TabIndex = 8;
            this.btnCancelarAutorizacionDirecta.Text = "Cancelar";
            this.btnCancelarAutorizacionDirecta.Click += new System.EventHandler(this.btnCancelarAutorizacionDirecta_Click);
            // 
            // btnConfirmarAutorizacionDirecta
            // 
            this.btnConfirmarAutorizacionDirecta.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(130)))), ((int)(((byte)(195)))));
            this.btnConfirmarAutorizacionDirecta.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarAutorizacionDirecta.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarAutorizacionDirecta.Appearance.Options.UseBackColor = true;
            this.btnConfirmarAutorizacionDirecta.Appearance.Options.UseFont = true;
            this.btnConfirmarAutorizacionDirecta.Appearance.Options.UseForeColor = true;
            this.btnConfirmarAutorizacionDirecta.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnConfirmarAutorizacionDirecta.ImageOptions.Image = global::JAGUAR_PRO.Properties.Resources.check_mark_24X24;
            this.btnConfirmarAutorizacionDirecta.Location = new System.Drawing.Point(40, 152);
            this.btnConfirmarAutorizacionDirecta.Name = "btnConfirmarAutorizacionDirecta";
            this.btnConfirmarAutorizacionDirecta.Size = new System.Drawing.Size(110, 47);
            this.btnConfirmarAutorizacionDirecta.TabIndex = 9;
            this.btnConfirmarAutorizacionDirecta.Text = "Confirmar";
            this.btnConfirmarAutorizacionDirecta.Click += new System.EventHandler(this.btnConfirmarAutorizacionDirecta_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(13, 116);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(80, 16);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Contraseña:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(40, 73);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 16);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Usuario:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(99, 112);
            this.txtClave.Name = "txtClave";
            this.txtClave.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Properties.Appearance.Options.UseFont = true;
            this.txtClave.Properties.PasswordChar = '*';
            this.txtClave.Properties.UseSystemPasswordChar = true;
            this.txtClave.Size = new System.Drawing.Size(170, 24);
            this.txtClave.TabIndex = 7;
            this.txtClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClave_KeyDown);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(99, 69);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Size = new System.Drawing.Size(170, 24);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(64, 25);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(181, 25);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Aplicar Autorización";
            // 
            // frmAutorizacionSingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 211);
            this.Controls.Add(this.btnCancelarAutorizacionDirecta);
            this.Controls.Add(this.btnConfirmarAutorizacionDirecta);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.labelControl4);
            this.Name = "frmAutorizacionSingle";
            this.Text = "frmAutorizacionSingle";
            this.Activated += new System.EventHandler(this.frmAutorizacionSingle_Activated);
            this.Load += new System.EventHandler(this.frmAutorizacionSingle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtClave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancelarAutorizacionDirecta;
        private DevExpress.XtraEditors.SimpleButton btnConfirmarAutorizacionDirecta;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtClave;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}