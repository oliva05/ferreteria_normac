namespace administracion.Huellas
{
    partial class frmIdentificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIdentificar));
            this.lblNombre = new System.Windows.Forms.Label();
            //this.acceptPict = new Infragistics.Win.UltraWinEditors.UltraPictureBox();
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.timerResetLabels = new System.Windows.Forms.Timer(this.components);
            this.txtCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNombre.Location = new System.Drawing.Point(12, 85);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNombre.Size = new System.Drawing.Size(544, 53);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Visible = false;
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // acceptPict
            // 
            //this.acceptPict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            //this.acceptPict.BorderShadowColor = System.Drawing.Color.Empty;
            //this.acceptPict.BorderStyle = Infragistics.Win.UIElementBorderStyle.Dashed;
            //this.acceptPict.Cursor = System.Windows.Forms.Cursors.Hand;
            //this.acceptPict.Image = ((object)(resources.GetObject("acceptPict.Image")));
            //this.acceptPict.Location = new System.Drawing.Point(549, 301);
            //this.acceptPict.Name = "acceptPict";
            //this.acceptPict.Size = new System.Drawing.Size(63, 67);
            //this.acceptPict.TabIndex = 33;
            //this.acceptPict.Visible = false;
            //this.acceptPict.Click += new System.EventHandler(this.acceptPict_Click);
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAsistencia.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistencia.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAsistencia.Location = new System.Drawing.Point(0, 408);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Size = new System.Drawing.Size(534, 37);
            this.lblAsistencia.TabIndex = 34;
            this.lblAsistencia.Text = "Asistencia marcada con exito!";
            this.lblAsistencia.Visible = false;
            this.lblAsistencia.Click += new System.EventHandler(this.lblAsistencia_Click);
            // 
            // timerResetLabels
            // 
            this.timerResetLabels.Interval = 3000;
            this.timerResetLabels.Tick += new System.EventHandler(this.timerResetLabels_Tick);
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Location = new System.Drawing.Point(515, 425);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 0;
            this.txtCode.Click += new System.EventHandler(this.txtCode_Click);
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // frmIdentificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            //this.BackgroundImage = global::administracion.Properties.Resources.Diseño_Pantalla_Digital_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(615, 445);
            this.Controls.Add(this.lblAsistencia);
            //this.Controls.Add(this.acceptPict);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCode);
            this.Name = "frmIdentificar";
            this.Text = "Asistencia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIdentificar_FormClosing);
            this.Load += new System.EventHandler(this.frmIdentificar_Load);
            this.Click += new System.EventHandler(this.frmIdentificar_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAsistencia;
        private System.Windows.Forms.Timer timerResetLabels;
        private System.Windows.Forms.TextBox txtCode;
    }
}