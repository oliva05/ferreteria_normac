namespace JAGUAR_PRO.Compras
{
    partial class frmOCompraAutorizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOCompraAutorizacion));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cdmRechazar = new DevExpress.XtraEditors.SimpleButton();
            this.cdmAprobar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton1.ImageOptions.Image = global::JAGUAR_PRO.Properties.Resources.close32px;
            this.simpleButton1.Location = new System.Drawing.Point(316, 88);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(110, 47);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Cerrar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cdmRechazar
            // 
            this.cdmRechazar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.cdmRechazar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdmRechazar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cdmRechazar.Appearance.Options.UseBackColor = true;
            this.cdmRechazar.Appearance.Options.UseFont = true;
            this.cdmRechazar.Appearance.Options.UseForeColor = true;
            this.cdmRechazar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cdmRechazar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cdmRechazar.ImageOptions.SvgImage")));
            this.cdmRechazar.Location = new System.Drawing.Point(186, 88);
            this.cdmRechazar.Name = "cdmRechazar";
            this.cdmRechazar.Size = new System.Drawing.Size(110, 47);
            this.cdmRechazar.TabIndex = 9;
            this.cdmRechazar.Text = "Rechazar";
            this.cdmRechazar.Click += new System.EventHandler(this.cdmRechazar_Click);
            // 
            // cdmAprobar
            // 
            this.cdmAprobar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(130)))), ((int)(((byte)(195)))));
            this.cdmAprobar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdmAprobar.Appearance.ForeColor = System.Drawing.Color.White;
            this.cdmAprobar.Appearance.Options.UseBackColor = true;
            this.cdmAprobar.Appearance.Options.UseFont = true;
            this.cdmAprobar.Appearance.Options.UseForeColor = true;
            this.cdmAprobar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cdmAprobar.ImageOptions.Image = global::JAGUAR_PRO.Properties.Resources.check_mark_24X24;
            this.cdmAprobar.Location = new System.Drawing.Point(54, 88);
            this.cdmAprobar.Name = "cdmAprobar";
            this.cdmAprobar.Size = new System.Drawing.Size(110, 47);
            this.cdmAprobar.TabIndex = 8;
            this.cdmAprobar.Text = "Aprobar";
            this.cdmAprobar.Click += new System.EventHandler(this.cdmAprobar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(87, 16);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(360, 49);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Por favor seleccione una opcion para finalizar esta solicitud";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::JAGUAR_PRO.Properties.Resources.information_64X64;
            this.pictureEdit1.Location = new System.Drawing.Point(19, 7);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(62, 52);
            this.pictureEdit1.TabIndex = 6;
            // 
            // frmOCompraAutorizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 142);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cdmRechazar);
            this.Controls.Add(this.cdmAprobar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Name = "frmOCompraAutorizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmación";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton cdmRechazar;
        private DevExpress.XtraEditors.SimpleButton cdmAprobar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}