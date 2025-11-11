namespace JAGUAR_PRO.Contabilidad.Reportes
{
    partial class frmDetalleFacturasResumenVentas
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
            this.dsReportesBasicosConta1 = new JAGUAR_PRO.Contabilidad.Reportes.dsReportesBasicosConta();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesBasicosConta1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsReportesBasicosConta1
            // 
            this.dsReportesBasicosConta1.DataSetName = "dsReportesBasicosConta";
            this.dsReportesBasicosConta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmDetalleFacturasResumenVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 476);
            this.Name = "frmDetalleFacturasResumenVentas";
            this.Text = "Detalle de Facturas Resumen Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesBasicosConta1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dsReportesBasicosConta dsReportesBasicosConta1;
    }
}