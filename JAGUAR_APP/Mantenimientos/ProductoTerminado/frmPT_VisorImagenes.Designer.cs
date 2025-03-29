namespace JAGUAR_PRO.Mantenimientos.ProductoTerminado
{
    partial class frmPT_VisorImagenes
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
            this.imageSlider = new DevExpress.XtraEditors.Controls.ImageSlider();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // imageSlider
            // 
            this.imageSlider.AllowLooping = true;
            this.imageSlider.AnimationTime = 5000;
            this.imageSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageSlider.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Squeeze;
            this.imageSlider.Location = new System.Drawing.Point(0, 0);
            this.imageSlider.Name = "imageSlider";
            this.imageSlider.ScrollButtonFadeAnimationTime = 100;
            this.imageSlider.ScrollButtonVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.imageSlider.Size = new System.Drawing.Size(1031, 423);
            this.imageSlider.TabIndex = 0;
            // 
            // frmPT_VisorImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 423);
            this.Controls.Add(this.imageSlider);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmPT_VisorImagenes";
            this.Text = "Catalogo";
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider;
    }
}