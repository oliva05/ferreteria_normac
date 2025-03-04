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
            this.components = new System.ComponentModel.Container();
            this.galleryPT = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.galleryPT)).BeginInit();
            this.galleryPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // galleryPT
            // 
            this.galleryPT.Controls.Add(this.galleryControlClient1);
            this.galleryPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.galleryPT.Location = new System.Drawing.Point(0, 0);
            this.galleryPT.Name = "galleryPT";
            this.galleryPT.Size = new System.Drawing.Size(1134, 664);
            this.galleryPT.TabIndex = 0;
            this.galleryPT.Text = "galleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.galleryPT;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(1113, 660);
            // 
            // galleryDropDown1
            // 
            this.galleryDropDown1.Manager = null;
            this.galleryDropDown1.Name = "galleryDropDown1";
            // 
            // frmPT_VisorImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 664);
            this.Controls.Add(this.galleryPT);
            this.Name = "frmPT_VisorImagenes";
            this.Text = "Catalogo";
            ((System.ComponentModel.ISupportInitialize)(this.galleryPT)).EndInit();
            this.galleryPT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.GalleryControl galleryPT;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
    }
}