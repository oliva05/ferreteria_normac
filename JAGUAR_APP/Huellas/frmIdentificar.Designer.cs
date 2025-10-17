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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lbl_MensajeAsistencia = new System.Windows.Forms.Label();
            this.timerResetLabels = new System.Windows.Forms.Timer(this.components);
            this.txtCode = new System.Windows.Forms.TextBox();
            this.dsHuellasManto1 = new JAGUAR_PRO.Huellas.dsHuellasManto();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHoraMarcada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsHuellasManto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNombre.Location = new System.Drawing.Point(12, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNombre.Size = new System.Drawing.Size(591, 53);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Visible = false;
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lbl_MensajeAsistencia
            // 
            this.lbl_MensajeAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_MensajeAsistencia.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MensajeAsistencia.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_MensajeAsistencia.Location = new System.Drawing.Point(0, 408);
            this.lbl_MensajeAsistencia.Name = "lbl_MensajeAsistencia";
            this.lbl_MensajeAsistencia.Size = new System.Drawing.Size(534, 37);
            this.lbl_MensajeAsistencia.TabIndex = 34;
            this.lbl_MensajeAsistencia.Text = "Asistencia marcada con exito!";
            this.lbl_MensajeAsistencia.Visible = false;
            this.lbl_MensajeAsistencia.Click += new System.EventHandler(this.lblAsistencia_Click);
            // 
            // timerResetLabels
            // 
            this.timerResetLabels.Interval = 3000;
            this.timerResetLabels.Tick += new System.EventHandler(this.timerResetLabels_Tick);
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Location = new System.Drawing.Point(416, 425);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 0;
            this.txtCode.Click += new System.EventHandler(this.txtCode_Click);
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // dsHuellasManto1
            // 
            this.dsHuellasManto1.DataSetName = "dsHuellasManto";
            this.dsHuellasManto1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JAGUAR_PRO.Properties.Resources.reloj;
            this.pictureBox1.Location = new System.Drawing.Point(21, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(574, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 53);
            this.label1.TabIndex = 36;
            this.label1.Text = "Registro de Asistencia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // lblHoraMarcada
            // 
            this.lblHoraMarcada.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraMarcada.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold);
            this.lblHoraMarcada.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblHoraMarcada.Location = new System.Drawing.Point(12, 115);
            this.lblHoraMarcada.Name = "lblHoraMarcada";
            this.lblHoraMarcada.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHoraMarcada.Size = new System.Drawing.Size(591, 41);
            this.lblHoraMarcada.TabIndex = 37;
            this.lblHoraMarcada.Visible = false;
            // 
            // frmIdentificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(615, 445);
            this.Controls.Add(this.lblHoraMarcada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_MensajeAsistencia);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCode);
            this.Name = "frmIdentificar";
            this.Text = "Asistencia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIdentificar_FormClosing);
            this.Load += new System.EventHandler(this.frmIdentificar_Load);
            this.Click += new System.EventHandler(this.frmIdentificar_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dsHuellasManto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lbl_MensajeAsistencia;
        private System.Windows.Forms.Timer timerResetLabels;
        private System.Windows.Forms.TextBox txtCode;
        private JAGUAR_PRO.Huellas.dsHuellasManto dsHuellasManto1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHoraMarcada;
    }
}