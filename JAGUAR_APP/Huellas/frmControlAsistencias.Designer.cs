namespace Proyecto.Huellas
{
    partial class frmControlAsistencias
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
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControlAsistencias));
            //Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            //Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            //Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            //this.lblNombre = new Infragistics.Win.Misc.UltraLabel();
            //this.pbHuella = new Infragistics.Win.UltraWinEditors.UltraPictureBox();
            //this.lblfecha = new Infragistics.Win.Misc.UltraLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            //this.pbQuality = new Infragistics.Win.UltraWinProgressBar.UltraProgressBar();
            //this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.cmbSalir = new System.Windows.Forms.Button();
            this.cmdIdentificar = new System.Windows.Forms.Button();
            this.axGrFingerXCtrl1 = new AxGrFingerXLib.AxGrFingerXCtrl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();


            this.axGrFingerXCtrl1.Enabled = true;
            this.axGrFingerXCtrl1.Location = new System.Drawing.Point(564, 167);
            this.axGrFingerXCtrl1.Name = "axGrFingerXCtrl1";
            //this.axGrFingerXCtrl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGrFingerXCtrl1.OcxState")));
            //this.axGrFingerXCtrl1.OcxState = ((System.Windows.Forms.AxHost.State)(resour)
            this.axGrFingerXCtrl1.Size = new System.Drawing.Size(32, 32);
            this.axGrFingerXCtrl1.TabIndex = 39;
            this.axGrFingerXCtrl1.SensorPlug += new AxGrFingerXLib._IGrFingerXCtrlEvents_SensorPlugEventHandler(this.axGrFingerXCtrl1_SensorPlug);
            this.axGrFingerXCtrl1.FingerUp += new AxGrFingerXLib._IGrFingerXCtrlEvents_FingerUpEventHandler(this.axGrFingerXCtrl1_FingerUp);
            this.axGrFingerXCtrl1.FingerDown += new AxGrFingerXLib._IGrFingerXCtrlEvents_FingerDownEventHandler(this.axGrFingerXCtrl1_FingerDown);
            this.axGrFingerXCtrl1.SensorUnplug += new AxGrFingerXLib._IGrFingerXCtrlEvents_SensorUnplugEventHandler(this.axGrFingerXCtrl1_SensorUnplug);
            this.axGrFingerXCtrl1.ImageAcquired += new AxGrFingerXLib._IGrFingerXCtrlEvents_ImageAcquiredEventHandler(this.axGrFingerXCtrl1_ImageAcquired);
            


            ((System.ComponentModel.ISupportInitialize)(this.axGrFingerXCtrl1)).BeginInit();
            // 
            // lblNombre
            // 
            //appearance3.BackColor = System.Drawing.SystemColors.Control;
            //appearance3.ForeColor = System.Drawing.Color.Teal;
            //this.lblNombre.Appearance = appearance3;
            //this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.lblNombre.Location = new System.Drawing.Point(133, 295);
            //this.lblNombre.Name = "lblNombre";
            //this.lblNombre.Size = new System.Drawing.Size(493, 72);
            //this.lblNombre.TabIndex = 2;
            //this.lblNombre.Text = "Nombre";
            // 
            // pbHuella
            // 
            //this.pbHuella.BorderShadowColor = System.Drawing.Color.Empty;
            //this.pbHuella.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded4;
            //this.pbHuella.Location = new System.Drawing.Point(8, 18);
            //this.pbHuella.Name = "pbHuella";
            //this.pbHuella.Size = new System.Drawing.Size(168, 185);
            //this.pbHuella.TabIndex = 3;
            // 
            // lblfecha
            // 
            //appearance4.BackColor = System.Drawing.SystemColors.Control;
            //appearance4.ForeColor = System.Drawing.Color.Teal;
            //appearance4.TextHAlignAsString = "Center";
            //this.lblfecha.Appearance = appearance4;
            //this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.lblfecha.Location = new System.Drawing.Point(12, 11);
            //this.lblfecha.Name = "lblfecha";
            //this.lblfecha.Size = new System.Drawing.Size(614, 31);
            //this.lblfecha.TabIndex = 6;
            //this.lblfecha.Text = "Fecha";
            //// 
            //// groupBox1
            //// 
            //this.groupBox1.Controls.Add(this.pbQuality);
            //this.groupBox1.Controls.Add(this.pbHuella);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(227, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 236);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Huella";
            // 
            // pbQuality
            // 
            //this.pbQuality.Dock = System.Windows.Forms.DockStyle.Bottom;
            //this.pbQuality.Location = new System.Drawing.Point(3, 210);
            //this.pbQuality.Name = "pbQuality";
            //this.pbQuality.Size = new System.Drawing.Size(177, 23);
            //this.pbQuality.TabIndex = 4;
            //this.pbQuality.Text = "[Formatted]";
            //// 
            //// ultraLabel1
            //// 
            //appearance2.BackColor = System.Drawing.SystemColors.Control;
            //appearance2.ForeColor = System.Drawing.Color.Black;
            //this.ultraLabel1.Appearance = appearance2;
            //this.ultraLabel1.AutoSize = true;
            //this.ultraLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.ultraLabel1.Location = new System.Drawing.Point(12, 295);
            //this.ultraLabel1.Name = "ultraLabel1";
            //this.ultraLabel1.Size = new System.Drawing.Size(120, 34);
            //this.ultraLabel1.TabIndex = 9;
            //this.ultraLabel1.Text = "Nombre:";
            // 
            // cmbSalir
            // 
            this.cmbSalir.BackColor = System.Drawing.Color.Coral;
            this.cmbSalir.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.cmbSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbSalir.Location = new System.Drawing.Point(416, 123);
            this.cmbSalir.Name = "cmbSalir";
            this.cmbSalir.Size = new System.Drawing.Size(90, 46);
            this.cmbSalir.TabIndex = 10;
            this.cmbSalir.Text = "Salir";
            this.cmbSalir.UseVisualStyleBackColor = false;
            this.cmbSalir.Click += new System.EventHandler(this.cmbSalir_Click);
            // 
            // cmdIdentificar
            // 
            this.cmdIdentificar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdIdentificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdIdentificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdIdentificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIdentificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdIdentificar.Location = new System.Drawing.Point(416, 62);
            this.cmdIdentificar.Name = "cmdIdentificar";
            this.cmdIdentificar.Size = new System.Drawing.Size(90, 46);
            this.cmdIdentificar.TabIndex = 11;
            this.cmdIdentificar.Text = "Identificar";
            this.cmdIdentificar.UseVisualStyleBackColor = false;
            this.cmdIdentificar.Visible = false;
            this.cmdIdentificar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmControlAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 378);
            this.Controls.Add(this.cmdIdentificar);
            this.Controls.Add(this.cmbSalir);
            //this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.groupBox1);
            //this.Controls.Add(this.lblfecha);
            //this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.axGrFingerXCtrl1);
            this.MaximizeBox = false;
            this.Name = "frmControlAsistencias";
            this.Text = "Control Asistencias";

            //((System.ComponentModel.ISupportInitialize)(this.axGrFingerXCtrl1)).EndInit();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmControlAsistencias_FormClosing);
            this.Load += new System.EventHandler(this.frmControlAsistencias_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private Infragistics.Win.Misc.UltraLabel lblNombre;
        //private Infragistics.Win.UltraWinEditors.UltraPictureBox pbHuella;
        //private Infragistics.Win.Misc.UltraLabel lblfecha;
        private System.Windows.Forms.GroupBox groupBox1;
        //private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private System.Windows.Forms.Button cmbSalir;
        private System.Windows.Forms.Button cmdIdentificar;
        //private Infragistics.Win.UltraWinProgressBar.UltraProgressBar pbQuality;
        private AxGrFingerXLib.AxGrFingerXCtrl axGrFingerXCtrl1;
    }
}