using DevExpress.XtraBars.Navigation;

namespace JAGUAR_PRO.Facturacion.Reportes
{
    partial class frmReportesFacturacionParametros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportesFacturacionParametros));
            this.NavigationFrameParametro = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.nvPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.nvPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.cmdSalir = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationFrameParametro)).BeginInit();
            this.NavigationFrameParametro.SuspendLayout();
            this.nvPage1.SuspendLayout();
            this.nvPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigationFrameParametro
            // 
            this.NavigationFrameParametro.Controls.Add(this.nvPage1);
            this.NavigationFrameParametro.Controls.Add(this.nvPage2);
            this.NavigationFrameParametro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationFrameParametro.Location = new System.Drawing.Point(0, 0);
            this.NavigationFrameParametro.Name = "NavigationFrameParametro";
            this.NavigationFrameParametro.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.nvPage1,
            this.nvPage2});
            this.NavigationFrameParametro.SelectedPage = this.nvPage1;
            this.NavigationFrameParametro.Size = new System.Drawing.Size(699, 306);
            this.NavigationFrameParametro.TabIndex = 0;
            this.NavigationFrameParametro.Text = "navigationFrame1";
            // 
            // nvPage1
            // 
            this.nvPage1.Controls.Add(this.labelControl3);
            this.nvPage1.Controls.Add(this.cmdSalir);
            this.nvPage1.Name = "nvPage1";
            this.nvPage1.Size = new System.Drawing.Size(699, 306);
            // 
            // nvPage2
            // 
            this.nvPage2.Controls.Add(this.labelControl1);
            this.nvPage2.Controls.Add(this.simpleButton1);
            this.nvPage2.Name = "nvPage2";
            this.nvPage2.Size = new System.Drawing.Size(699, 306);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSalir.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdSalir.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmdSalir.Appearance.Options.UseBackColor = true;
            this.cmdSalir.Appearance.Options.UseFont = true;
            this.cmdSalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.ImageOptions.Image")));
            this.cmdSalir.Location = new System.Drawing.Point(573, 12);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(114, 38);
            this.cmdSalir.TabIndex = 14;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(323, 145);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 17);
            this.labelControl3.TabIndex = 67;
            this.labelControl3.Text = "Page 1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(573, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(114, 38);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "Salir";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(329, 145);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 17);
            this.labelControl1.TabIndex = 68;
            this.labelControl1.Text = "Page 2";
            // 
            // frmReportesFacturacionParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 306);
            this.Controls.Add(this.NavigationFrameParametro);
            this.Name = "frmReportesFacturacionParametros";
            this.Text = "Definicion de Parametros";
            ((System.ComponentModel.ISupportInitialize)(this.NavigationFrameParametro)).EndInit();
            this.NavigationFrameParametro.ResumeLayout(false);
            this.nvPage1.ResumeLayout(false);
            this.nvPage1.PerformLayout();
            this.nvPage2.ResumeLayout(false);
            this.nvPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NavigationFrame NavigationFrameParametro;
        private NavigationPage nvPage1;
        private NavigationPage nvPage2;
        private DevExpress.XtraEditors.SimpleButton cmdSalir;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}