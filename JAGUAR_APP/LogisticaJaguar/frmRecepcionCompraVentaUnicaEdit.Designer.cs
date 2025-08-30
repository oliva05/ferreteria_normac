namespace JAGUAR_PRO.LogisticaJaguar
{
    partial class frmRecepcionCompraVentaUnicaEdit
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
            this.txtPrecioVenta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtMargGanancia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCosto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnFinalizar = new DevExpress.XtraEditors.SimpleButton();
            this.lblTituloVentana = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMargGanancia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.EditValue = "0.00";
            this.txtPrecioVenta.Location = new System.Drawing.Point(154, 137);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Properties.Appearance.Options.UseFont = true;
            this.txtPrecioVenta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecioVenta.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPrecioVenta.Properties.MaskSettings.Set("mask", "n");
            this.txtPrecioVenta.Properties.MaxLength = 100;
            this.txtPrecioVenta.Properties.NullText = "0";
            this.txtPrecioVenta.Properties.UseMaskAsDisplayFormat = true;
            this.txtPrecioVenta.Size = new System.Drawing.Size(155, 22);
            this.txtPrecioVenta.TabIndex = 105;
            this.txtPrecioVenta.EditValueChanged += new System.EventHandler(this.txtPrecioVenta_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(54, 140);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(101, 15);
            this.labelControl6.TabIndex = 106;
            this.labelControl6.Text = "Precio Venta_______";
            // 
            // txtMargGanancia
            // 
            this.txtMargGanancia.EditValue = "0";
            this.txtMargGanancia.Location = new System.Drawing.Point(154, 108);
            this.txtMargGanancia.Name = "txtMargGanancia";
            this.txtMargGanancia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargGanancia.Properties.Appearance.Options.UseFont = true;
            this.txtMargGanancia.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMargGanancia.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtMargGanancia.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtMargGanancia.Properties.MaskSettings.Set("mask", "P");
            this.txtMargGanancia.Properties.MaxLength = 100;
            this.txtMargGanancia.Properties.NullText = "0";
            this.txtMargGanancia.Properties.UseMaskAsDisplayFormat = true;
            this.txtMargGanancia.Size = new System.Drawing.Size(155, 22);
            this.txtMargGanancia.TabIndex = 100;
            this.txtMargGanancia.EditValueChanged += new System.EventHandler(this.txtMargGanancia_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(54, 111);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(128, 15);
            this.labelControl5.TabIndex = 104;
            this.labelControl5.Text = "Margen Ganancia_______";
            // 
            // txtCosto
            // 
            this.txtCosto.EditValue = "0.00";
            this.txtCosto.Location = new System.Drawing.Point(154, 80);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Properties.Appearance.Options.UseFont = true;
            this.txtCosto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCosto.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCosto.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtCosto.Properties.MaskSettings.Set("mask", "n");
            this.txtCosto.Properties.UseMaskAsDisplayFormat = true;
            this.txtCosto.Size = new System.Drawing.Size(155, 22);
            this.txtCosto.TabIndex = 99;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(54, 83);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(116, 15);
            this.labelControl4.TabIndex = 103;
            this.labelControl4.Text = "Costo_________________";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.EditValue = "";
            this.txtDescripcion.Location = new System.Drawing.Point(137, 51);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Size = new System.Drawing.Size(172, 22);
            this.txtDescripcion.TabIndex = 98;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(54, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 15);
            this.labelControl2.TabIndex = 102;
            this.labelControl2.Text = "Descripcion_____";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = global::JAGUAR_PRO.Properties.Resources.cancel_16x16;
            this.btnCancelar.Location = new System.Drawing.Point(198, 180);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 38);
            this.btnCancelar.TabIndex = 109;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFinalizar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Appearance.Options.UseFont = true;
            this.btnFinalizar.ImageOptions.Image = global::JAGUAR_PRO.Properties.Resources.apply_16x16;
            this.btnFinalizar.Location = new System.Drawing.Point(78, 180);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(90, 38);
            this.btnFinalizar.TabIndex = 108;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVentana.Appearance.Options.UseFont = true;
            this.lblTituloVentana.Location = new System.Drawing.Point(97, 12);
            this.lblTituloVentana.Name = "lblTituloVentana";
            this.lblTituloVentana.Size = new System.Drawing.Size(175, 20);
            this.lblTituloVentana.TabIndex = 110;
            this.lblTituloVentana.Text = "Editar Producto de Usado";
            // 
            // frmRecepcionCompraVentaUnicaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 235);
            this.Controls.Add(this.lblTituloVentana);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtMargGanancia);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.labelControl2);
            this.Name = "frmRecepcionCompraVentaUnicaEdit";
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMargGanancia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtPrecioVenta;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtMargGanancia;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtCosto;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnFinalizar;
        private DevExpress.XtraEditors.LabelControl lblTituloVentana;
    }
}