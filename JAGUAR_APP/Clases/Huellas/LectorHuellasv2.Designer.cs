namespace core.Clases.Huellas
{
    partial class LectorHuellasv2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Lector de Huella";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(0, 257);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(354, 50);
            this.cmdGuardar.TabIndex = 29;
            this.cmdGuardar.Text = "OK [F12]";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Visible = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            this.cmdGuardar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmdCancelar_KeyDown);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancelar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancelar.Location = new System.Drawing.Point(0, 307);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(354, 49);
            this.cmdCancelar.TabIndex = 28;
            this.cmdCancelar.Text = "Cancelar [ESC]";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            this.cmdCancelar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmdCancelar_KeyDown);
            // 
            // LectorHuellasv2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 356);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdCancelar);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(500, 395);
            this.MinimumSize = new System.Drawing.Size(223, 395);
            this.Name = "LectorHuellasv2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lectura de Huella";
            this.Activated += new System.EventHandler(this.LectorHuellasv2_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LectorHuellasv2_FormClosing);
            this.Load += new System.EventHandler(this.LectorHuellasv2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmdCancelar_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Label label1;
        //public Infragistics.Win.UltraWinEditors.UltraPictureBox pictureBox1;
        //public Infragistics.Win.Misc.UltraLabel lblNumero;
        //private Infragistics.Win.UltraWinProgressBar.UltraProgressBar pbQuality;
    }
}