namespace administracion.Huellas
{
    partial class frmProcesando
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
           // this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ultraLabel1
            // 
            //this.ultraLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.ultraLabel1.Location = new System.Drawing.Point(74, 30);
            //this.ultraLabel1.Name = "ultraLabel1";
            //this.ultraLabel1.Size = new System.Drawing.Size(117, 23);
            //this.ultraLabel1.TabIndex = 0;
            //this.ultraLabel1.Text = "Procesando...";
            // 
            // timer1
            // 
            this.timer1.Interval = 4500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmProcesando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 82);
            this.ControlBox = false;
            //this.Controls.Add(this.ultraLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(280, 120);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(280, 120);
            this.Name = "frmProcesando";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesando";
            this.Load += new System.EventHandler(this.frmProcesando_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        //public Infragistics.Win.Misc.UltraLabel ultraLabel1;
    }
}