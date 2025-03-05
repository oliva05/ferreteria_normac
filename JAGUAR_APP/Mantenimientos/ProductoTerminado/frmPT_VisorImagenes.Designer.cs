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
            this.galleryControl = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl)).BeginInit();
            this.galleryControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageSlider
            // 
            this.imageSlider.AllowLooping = true;
            this.imageSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageSlider.AnimationTime = 5000;
            this.imageSlider.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Squeeze;
            this.imageSlider.Location = new System.Drawing.Point(0, -9);
            this.imageSlider.Name = "imageSlider";
            this.imageSlider.ScrollButtonFadeAnimationTime = 100;
            this.imageSlider.ScrollButtonVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.imageSlider.Size = new System.Drawing.Size(1022, 307);
            this.imageSlider.TabIndex = 0;
            // 
            // galleryControl
            // 
            this.galleryControl.Controls.Add(this.galleryControlClient1);
            this.galleryControl.Location = new System.Drawing.Point(0, 322);
            this.galleryControl.Name = "galleryControl";
            this.galleryControl.Size = new System.Drawing.Size(1022, 305);
            this.galleryControl.TabIndex = 1;
            this.galleryControl.Text = "galleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.galleryControl;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(1001, 301);
            // 
            // frmPT_VisorImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 629);
            this.Controls.Add(this.galleryControl);
            this.Controls.Add(this.imageSlider);
            this.Name = "frmPT_VisorImagenes";
            this.Text = "Catalogo";
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl)).EndInit();
            this.galleryControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider;
        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControl;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
    }
}