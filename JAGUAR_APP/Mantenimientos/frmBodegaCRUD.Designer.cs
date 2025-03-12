namespace JAGUAR_PRO.Mantenimientos
{
    partial class frmBodegaCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBodegaCRUD));
            this.txtDescripcionCorta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkEnable = new DevExpress.XtraEditors.CheckEdit();
            this.memoDescripcion = new DevExpress.XtraEditors.MemoEdit();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodBodega = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionCorta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodBodega.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcionCorta
            // 
            this.txtDescripcionCorta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcionCorta.Location = new System.Drawing.Point(12, 281);
            this.txtDescripcionCorta.Name = "txtDescripcionCorta";
            this.txtDescripcionCorta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionCorta.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcionCorta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcionCorta.Size = new System.Drawing.Size(180, 28);
            this.txtDescripcionCorta.TabIndex = 1;
            this.txtDescripcionCorta.Enter += new System.EventHandler(this.txtDescripcionCorta_Enter);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(15, 155);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(100, 24);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Descripción";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 256);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(149, 24);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Descripción Corta";
            // 
            // chkEnable
            // 
            this.chkEnable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEnable.Location = new System.Drawing.Point(220, 280);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.chkEnable.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.chkEnable.Properties.Appearance.Options.UseBackColor = true;
            this.chkEnable.Properties.Appearance.Options.UseFont = true;
            this.chkEnable.Properties.AutoHeight = false;
            this.chkEnable.Properties.Caption = "Activo";
            this.chkEnable.Size = new System.Drawing.Size(80, 28);
            this.chkEnable.TabIndex = 2;
            // 
            // memoDescripcion
            // 
            this.memoDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoDescripcion.Location = new System.Drawing.Point(12, 182);
            this.memoDescripcion.Name = "memoDescripcion";
            this.memoDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoDescripcion.Properties.Appearance.Options.UseFont = true;
            this.memoDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.memoDescripcion.Size = new System.Drawing.Size(265, 63);
            this.memoDescripcion.TabIndex = 0;
            this.memoDescripcion.Enter += new System.EventHandler(this.memoDescripcion_Enter);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(370, 25);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(124, 39);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnGuardar.Location = new System.Drawing.Point(12, 25);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(134, 39);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(15, 97);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 24);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Codigo";
            // 
            // txtCodBodega
            // 
            this.txtCodBodega.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodBodega.Enabled = false;
            this.txtCodBodega.Location = new System.Drawing.Point(12, 122);
            this.txtCodBodega.Name = "txtCodBodega";
            this.txtCodBodega.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBodega.Properties.Appearance.Options.UseFont = true;
            this.txtCodBodega.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodBodega.Size = new System.Drawing.Size(180, 28);
            this.txtCodBodega.TabIndex = 14;
            // 
            // frmBodegaCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 436);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtCodBodega);
            this.Controls.Add(this.memoDescripcion);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chkEnable);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtDescripcionCorta);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBodegaCRUD";
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionCorta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodBodega.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtDescripcionCorta;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit chkEnable;
        private DevExpress.XtraEditors.MemoEdit memoDescripcion;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCodBodega;
    }
}