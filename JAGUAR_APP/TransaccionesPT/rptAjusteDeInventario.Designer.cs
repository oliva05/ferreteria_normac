namespace JAGUAR_PRO.Facturacion.Reportes
{
    partial class rptAjusteDeInventario
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptAjusteDeInventario));
            DevExpress.XtraReports.UI.XRWatermark xrWatermark1 = new DevExpress.XtraReports.UI.XRWatermark();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.lblCantidad = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblProductoDescripcionItemName = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblItemCode = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblEntradaSalida = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPrecio = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblTotal = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.lblFechaEmision = new DevExpress.XtraReports.UI.XRLabel();
            this.lblRotuloEntradaSalidaRow = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblCompanyName = new DevExpress.XtraReports.UI.XRLabel();
            this.lblLegalName = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTipoTransaccionEntrada_Salida = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.txtComentario = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lblUsuarioAprobador = new DevExpress.XtraReports.UI.XRLabel();
            this.lblUsuarioAprobadorLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAlmacen = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblUsuario = new DevExpress.XtraReports.UI.XRLabel();
            this.lblEstado = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTipoTransaccionMovimiento = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNumeroDocumento = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.dsFacturasGestion1 = new JAGUAR_PRO.Facturacion.CoreFacturas.dsFacturasGestion();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasGestion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.HeightF = 15.625F;
            this.Detail.KeepTogether = true;
            this.Detail.KeepTogetherWithDetailReports = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTable1.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrTable1.Font = new DevExpress.Drawing.DXFont("Consolas", 9.75F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(10.41325F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(756.5869F, 15.625F);
            this.xrTable1.StylePriority.UseBorderDashStyle = false;
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lblCantidad,
            this.lblProductoDescripcionItemName,
            this.lblItemCode,
            this.lblEntradaSalida,
            this.lblPrecio,
            this.lblTotal});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.lblCantidad.BorderWidth = 0.5F;
            this.lblCantidad.Font = new DevExpress.Drawing.DXFont("Consolas", 8.5F);
            this.lblCantidad.Multiline = true;
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.StylePriority.UseBorders = false;
            this.lblCantidad.StylePriority.UseBorderWidth = false;
            this.lblCantidad.StylePriority.UseFont = false;
            this.lblCantidad.StylePriority.UseTextAlignment = false;
            this.lblCantidad.Text = "lblCantidad";
            this.lblCantidad.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lblCantidad.TextFormatString = "{0:###.####}";
            this.lblCantidad.Weight = 1.0459104488576638D;
            // 
            // lblProductoDescripcionItemName
            // 
            this.lblProductoDescripcionItemName.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
            this.lblProductoDescripcionItemName.BorderWidth = 0.5F;
            this.lblProductoDescripcionItemName.Font = new DevExpress.Drawing.DXFont("Consolas", 8.5F);
            this.lblProductoDescripcionItemName.Multiline = true;
            this.lblProductoDescripcionItemName.Name = "lblProductoDescripcionItemName";
            this.lblProductoDescripcionItemName.StylePriority.UseBorders = false;
            this.lblProductoDescripcionItemName.StylePriority.UseBorderWidth = false;
            this.lblProductoDescripcionItemName.StylePriority.UseFont = false;
            this.lblProductoDescripcionItemName.StylePriority.UseTextAlignment = false;
            this.lblProductoDescripcionItemName.Text = "lblProductoDescripcionItemName";
            this.lblProductoDescripcionItemName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblProductoDescripcionItemName.Weight = 4.5005206908337039D;
            // 
            // lblItemCode
            // 
            this.lblItemCode.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
            this.lblItemCode.BorderWidth = 0.5F;
            this.lblItemCode.Font = new DevExpress.Drawing.DXFont("Consolas", 8.5F);
            this.lblItemCode.Multiline = true;
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.StylePriority.UseBorders = false;
            this.lblItemCode.StylePriority.UseBorderWidth = false;
            this.lblItemCode.StylePriority.UseFont = false;
            this.lblItemCode.StylePriority.UseTextAlignment = false;
            this.lblItemCode.Text = "lblItemCode";
            this.lblItemCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lblItemCode.Weight = 2.2141357851991765D;
            // 
            // lblEntradaSalida
            // 
            this.lblEntradaSalida.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
            this.lblEntradaSalida.BorderWidth = 0.5F;
            this.lblEntradaSalida.Font = new DevExpress.Drawing.DXFont("Consolas", 8.5F);
            this.lblEntradaSalida.Multiline = true;
            this.lblEntradaSalida.Name = "lblEntradaSalida";
            this.lblEntradaSalida.StylePriority.UseBorders = false;
            this.lblEntradaSalida.StylePriority.UseBorderWidth = false;
            this.lblEntradaSalida.StylePriority.UseFont = false;
            this.lblEntradaSalida.Text = "lblEntradaSalida";
            this.lblEntradaSalida.TextFormatString = "{0: ###,##0.00}";
            this.lblEntradaSalida.Weight = 1.6815234099581415D;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
            this.lblPrecio.BorderWidth = 0.5F;
            this.lblPrecio.Font = new DevExpress.Drawing.DXFont("Consolas", 8.5F);
            this.lblPrecio.Multiline = true;
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.StylePriority.UseBorders = false;
            this.lblPrecio.StylePriority.UseBorderWidth = false;
            this.lblPrecio.StylePriority.UseFont = false;
            this.lblPrecio.Text = "lblPrecio";
            this.lblPrecio.TextFormatString = "{0: ###,##0.00}";
            this.lblPrecio.Weight = 1.6815213506771181D;
            // 
            // lblTotal
            // 
            this.lblTotal.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
            this.lblTotal.BorderWidth = 0.5F;
            this.lblTotal.Font = new DevExpress.Drawing.DXFont("Consolas", 8.5F);
            this.lblTotal.Multiline = true;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.StylePriority.UseBorders = false;
            this.lblTotal.StylePriority.UseBorderWidth = false;
            this.lblTotal.StylePriority.UseFont = false;
            this.lblTotal.Text = "lblTotal";
            this.lblTotal.TextFormatString = "{0: ###,##0.00}";
            this.lblTotal.Weight = 1.6397286970351772D;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 16F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 25.70362F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.HeightF = 0F;
            this.PageHeader.Name = "PageHeader";
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblFechaEmision.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.lblFechaEmision.LocationFloat = new DevExpress.Utils.PointFloat(143.2746F, 101.8712F);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblFechaEmision.SizeF = new System.Drawing.SizeF(228.6288F, 15.99999F);
            this.lblFechaEmision.StylePriority.UseBorders = false;
            this.lblFechaEmision.StylePriority.UseFont = false;
            this.lblFechaEmision.StylePriority.UseTextAlignment = false;
            this.lblFechaEmision.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblRotuloEntradaSalidaRow
            // 
            this.lblRotuloEntradaSalidaRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(194)))), ((int)(((byte)(252)))));
            this.lblRotuloEntradaSalidaRow.BorderColor = System.Drawing.Color.White;
            this.lblRotuloEntradaSalidaRow.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.lblRotuloEntradaSalidaRow.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblRotuloEntradaSalidaRow.Font = new DevExpress.Drawing.DXFont("Consolas", 8.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblRotuloEntradaSalidaRow.ForeColor = System.Drawing.Color.White;
            this.lblRotuloEntradaSalidaRow.LocationFloat = new DevExpress.Utils.PointFloat(470.4451F, 218.8861F);
            this.lblRotuloEntradaSalidaRow.Name = "lblRotuloEntradaSalidaRow";
            this.lblRotuloEntradaSalidaRow.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblRotuloEntradaSalidaRow.SizeF = new System.Drawing.SizeF(99.67743F, 23.00002F);
            this.lblRotuloEntradaSalidaRow.StylePriority.UseBackColor = false;
            this.lblRotuloEntradaSalidaRow.StylePriority.UseBorderColor = false;
            this.lblRotuloEntradaSalidaRow.StylePriority.UseBorderDashStyle = false;
            this.lblRotuloEntradaSalidaRow.StylePriority.UseBorders = false;
            this.lblRotuloEntradaSalidaRow.StylePriority.UseFont = false;
            this.lblRotuloEntradaSalidaRow.StylePriority.UseForeColor = false;
            this.lblRotuloEntradaSalidaRow.StylePriority.UseTextAlignment = false;
            this.lblRotuloEntradaSalidaRow.Text = "Entrada";
            this.lblRotuloEntradaSalidaRow.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel10
            // 
            this.xrLabel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(194)))), ((int)(((byte)(252)))));
            this.xrLabel10.BorderColor = System.Drawing.Color.White;
            this.xrLabel10.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel10.Font = new DevExpress.Drawing.DXFont("Consolas", 8.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel10.ForeColor = System.Drawing.Color.White;
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(72.41286F, 218.8859F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(266.7823F, 23.00006F);
            this.xrLabel10.StylePriority.UseBackColor = false;
            this.xrLabel10.StylePriority.UseBorderColor = false;
            this.xrLabel10.StylePriority.UseBorderDashStyle = false;
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseForeColor = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Descripción";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel8
            // 
            this.xrLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(194)))), ((int)(((byte)(252)))));
            this.xrLabel8.BorderColor = System.Drawing.Color.White;
            this.xrLabel8.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel8.Font = new DevExpress.Drawing.DXFont("Consolas", 8.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel8.ForeColor = System.Drawing.Color.White;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(10.41325F, 218.886F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(61.99961F, 22.99997F);
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.StylePriority.UseBorderColor = false;
            this.xrLabel8.StylePriority.UseBorderDashStyle = false;
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseForeColor = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Cantidad";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel14.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(10.4131F, 101.8712F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(55.59119F, 16F);
            this.xrLabel14.StylePriority.UseBorders = false;
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "Fecha:";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblCompanyName.Font = new DevExpress.Drawing.DXFont("Consolas", 16F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(194)))), ((int)(((byte)(252)))));
            this.lblCompanyName.LocationFloat = new DevExpress.Utils.PointFloat(213.4116F, 1.999998F);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblCompanyName.SizeF = new System.Drawing.SizeF(360.2621F, 33.75011F);
            this.lblCompanyName.StylePriority.UseBorders = false;
            this.lblCompanyName.StylePriority.UseFont = false;
            this.lblCompanyName.StylePriority.UseForeColor = false;
            this.lblCompanyName.StylePriority.UseTextAlignment = false;
            this.lblCompanyName.Text = "Company Name";
            this.lblCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblLegalName
            // 
            this.lblLegalName.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblLegalName.Font = new DevExpress.Drawing.DXFont("Consolas", 9F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.lblLegalName.LocationFloat = new DevExpress.Utils.PointFloat(213.4116F, 35.75012F);
            this.lblLegalName.Name = "lblLegalName";
            this.lblLegalName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblLegalName.SizeF = new System.Drawing.SizeF(360.2621F, 16.75002F);
            this.lblLegalName.StylePriority.UseBorders = false;
            this.lblLegalName.StylePriority.UseFont = false;
            this.lblLegalName.StylePriority.UseTextAlignment = false;
            this.lblLegalName.Text = "Legal Name";
            this.lblLegalName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblTipoTransaccionEntrada_Salida
            // 
            this.lblTipoTransaccionEntrada_Salida.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblTipoTransaccionEntrada_Salida.Font = new DevExpress.Drawing.DXFont("Arial", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblTipoTransaccionEntrada_Salida.LocationFloat = new DevExpress.Utils.PointFloat(213.4116F, 52.50014F);
            this.lblTipoTransaccionEntrada_Salida.Name = "lblTipoTransaccionEntrada_Salida";
            this.lblTipoTransaccionEntrada_Salida.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTipoTransaccionEntrada_Salida.SizeF = new System.Drawing.SizeF(360.2621F, 28.5F);
            this.lblTipoTransaccionEntrada_Salida.StylePriority.UseBorders = false;
            this.lblTipoTransaccionEntrada_Salida.StylePriority.UseFont = false;
            this.lblTipoTransaccionEntrada_Salida.StylePriority.UseTextAlignment = false;
            this.lblTipoTransaccionEntrada_Salida.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // PageFooter
            // 
            this.PageFooter.HeightF = 17.77456F;
            this.PageFooter.Name = "PageFooter";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine2,
            this.txtComentario,
            this.xrLabel7,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLine1});
            this.GroupFooter1.HeightF = 238.7959F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // xrLine2
            // 
            this.xrLine2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(194)))), ((int)(((byte)(252)))));
            this.xrLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(194)))), ((int)(((byte)(252)))));
            this.xrLine2.LineWidth = 0.8F;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(10.36981F, 6.999992F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(756.5868F, 2.083333F);
            this.xrLine2.StylePriority.UseBorderColor = false;
            this.xrLine2.StylePriority.UseForeColor = false;
            // 
            // txtComentario
            // 
            this.txtComentario.Font = new DevExpress.Drawing.DXFont("Consolas", 9F);
            this.txtComentario.LocationFloat = new DevExpress.Utils.PointFloat(10.41288F, 23.08334F);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtComentario.SizeF = new System.Drawing.SizeF(756.5437F, 67.79167F);
            this.txtComentario.StylePriority.UseFont = false;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(, \'MiddleRight\', ?)"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(, True, ?)")});
            this.xrLabel7.Font = new DevExpress.Drawing.DXFont("Consolas", 9F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(10.41325F, 9.083335F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(328.7819F, 14F);
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Comentario / Justificación:";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Consolas", 7.25F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(447.3956F, 152.5998F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(122.7269F, 14.87503F);
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Autorizado";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Consolas", 7.25F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(217.4884F, 152.5998F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(122.7269F, 14.87503F);
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Revisado";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLine1
            // 
            this.xrLine1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(194)))), ((int)(((byte)(252)))));
            this.xrLine1.ForeColor = System.Drawing.Color.Black;
            this.xrLine1.LineWidth = 0.8F;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(10.41325F, 0F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(756.5868F, 2.083333F);
            this.xrLine1.StylePriority.UseBorderColor = false;
            this.xrLine1.StylePriority.UseForeColor = false;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblUsuarioAprobador,
            this.lblUsuarioAprobadorLabel,
            this.lblAlmacen,
            this.xrLabel16,
            this.xrLabel6,
            this.lblUsuario,
            this.lblEstado,
            this.xrLabel11,
            this.xrLabel4,
            this.lblTipoTransaccionMovimiento,
            this.lblNumeroDocumento,
            this.xrLabel1,
            this.xrLabel19,
            this.xrLabel17,
            this.xrPictureBox1,
            this.xrLabel22,
            this.lblFechaEmision,
            this.lblRotuloEntradaSalidaRow,
            this.xrLabel10,
            this.xrLabel8,
            this.xrLabel14,
            this.lblLegalName,
            this.lblTipoTransaccionEntrada_Salida,
            this.lblCompanyName});
            this.ReportHeader.HeightF = 241.8861F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lblUsuarioAprobador
            // 
            this.lblUsuarioAprobador.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblUsuarioAprobador.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.lblUsuarioAprobador.LocationFloat = new DevExpress.Utils.PointFloat(143.2746F, 181.8712F);
            this.lblUsuarioAprobador.Name = "lblUsuarioAprobador";
            this.lblUsuarioAprobador.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblUsuarioAprobador.SizeF = new System.Drawing.SizeF(228.6288F, 16.00002F);
            this.lblUsuarioAprobador.StylePriority.UseBorders = false;
            this.lblUsuarioAprobador.StylePriority.UseFont = false;
            this.lblUsuarioAprobador.StylePriority.UseTextAlignment = false;
            this.lblUsuarioAprobador.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblUsuarioAprobador.Visible = false;
            // 
            // lblUsuarioAprobadorLabel
            // 
            this.lblUsuarioAprobadorLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblUsuarioAprobadorLabel.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.lblUsuarioAprobadorLabel.LocationFloat = new DevExpress.Utils.PointFloat(10.41325F, 181.8712F);
            this.lblUsuarioAprobadorLabel.Name = "lblUsuarioAprobadorLabel";
            this.lblUsuarioAprobadorLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblUsuarioAprobadorLabel.SizeF = new System.Drawing.SizeF(121.2162F, 15.99999F);
            this.lblUsuarioAprobadorLabel.StylePriority.UseBorders = false;
            this.lblUsuarioAprobadorLabel.StylePriority.UseFont = false;
            this.lblUsuarioAprobadorLabel.StylePriority.UseTextAlignment = false;
            this.lblUsuarioAprobadorLabel.Text = "Usuario Aprobación:";
            this.lblUsuarioAprobadorLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblUsuarioAprobadorLabel.Visible = false;
            // 
            // lblAlmacen
            // 
            this.lblAlmacen.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblAlmacen.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.lblAlmacen.LocationFloat = new DevExpress.Utils.PointFloat(539.2988F, 101.8712F);
            this.lblAlmacen.Name = "lblAlmacen";
            this.lblAlmacen.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblAlmacen.SizeF = new System.Drawing.SizeF(231.7015F, 15.99999F);
            this.lblAlmacen.StylePriority.UseBorders = false;
            this.lblAlmacen.StylePriority.UseFont = false;
            this.lblAlmacen.StylePriority.UseTextAlignment = false;
            this.lblAlmacen.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel16
            // 
            this.xrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel16.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(463.8634F, 101.8712F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(75.43533F, 15.99998F);
            this.xrLabel16.StylePriority.UseBorders = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "Almacén:";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(10.41325F, 165.8712F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(121.2162F, 15.99999F);
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Usuario:";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblUsuario.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.lblUsuario.LocationFloat = new DevExpress.Utils.PointFloat(143.2746F, 165.8712F);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblUsuario.SizeF = new System.Drawing.SizeF(228.6288F, 16F);
            this.lblUsuario.StylePriority.UseBorders = false;
            this.lblUsuario.StylePriority.UseFont = false;
            this.lblUsuario.StylePriority.UseTextAlignment = false;
            this.lblUsuario.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblEstado
            // 
            this.lblEstado.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblEstado.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.lblEstado.LocationFloat = new DevExpress.Utils.PointFloat(143.2746F, 149.8712F);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblEstado.SizeF = new System.Drawing.SizeF(228.6288F, 16F);
            this.lblEstado.StylePriority.UseBorders = false;
            this.lblEstado.StylePriority.UseFont = false;
            this.lblEstado.StylePriority.UseTextAlignment = false;
            this.lblEstado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel11.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(10.41325F, 149.8712F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(121.2162F, 15.99999F);
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Estado:";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(10.41325F, 133.8712F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(121.2162F, 15.99999F);
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Tipo de Transacción:";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblTipoTransaccionMovimiento
            // 
            this.lblTipoTransaccionMovimiento.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblTipoTransaccionMovimiento.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.lblTipoTransaccionMovimiento.LocationFloat = new DevExpress.Utils.PointFloat(143.2746F, 133.8712F);
            this.lblTipoTransaccionMovimiento.Name = "lblTipoTransaccionMovimiento";
            this.lblTipoTransaccionMovimiento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTipoTransaccionMovimiento.SizeF = new System.Drawing.SizeF(228.6288F, 16F);
            this.lblTipoTransaccionMovimiento.StylePriority.UseBorders = false;
            this.lblTipoTransaccionMovimiento.StylePriority.UseFont = false;
            this.lblTipoTransaccionMovimiento.StylePriority.UseTextAlignment = false;
            this.lblTipoTransaccionMovimiento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblNumeroDocumento.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.lblNumeroDocumento.LocationFloat = new DevExpress.Utils.PointFloat(143.2746F, 117.8712F);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNumeroDocumento.SizeF = new System.Drawing.SizeF(228.6288F, 15.99999F);
            this.lblNumeroDocumento.StylePriority.UseBorders = false;
            this.lblNumeroDocumento.StylePriority.UseFont = false;
            this.lblNumeroDocumento.StylePriority.UseTextAlignment = false;
            this.lblNumeroDocumento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(10.41325F, 117.8712F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(121.2162F, 15.99999F);
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Número Documento:";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel19
            // 
            this.xrLabel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(194)))), ((int)(((byte)(252)))));
            this.xrLabel19.BorderColor = System.Drawing.Color.White;
            this.xrLabel19.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel19.Font = new DevExpress.Drawing.DXFont("Consolas", 8.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel19.ForeColor = System.Drawing.Color.White;
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(339.1953F, 218.886F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(131.2498F, 23.00006F);
            this.xrLabel19.StylePriority.UseBackColor = false;
            this.xrLabel19.StylePriority.UseBorderColor = false;
            this.xrLabel19.StylePriority.UseBorderDashStyle = false;
            this.xrLabel19.StylePriority.UseBorders = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseForeColor = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "Código";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel17
            // 
            this.xrLabel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(194)))), ((int)(((byte)(252)))));
            this.xrLabel17.BorderColor = System.Drawing.Color.White;
            this.xrLabel17.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel17.Font = new DevExpress.Drawing.DXFont("Consolas", 8.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel17.ForeColor = System.Drawing.Color.White;
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(570.1226F, 218.8861F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(99.67743F, 23.00002F);
            this.xrLabel17.StylePriority.UseBackColor = false;
            this.xrLabel17.StylePriority.UseBorderColor = false;
            this.xrLabel17.StylePriority.UseBorderDashStyle = false;
            this.xrLabel17.StylePriority.UseBorders = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseForeColor = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Precio";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox1.ImageSource"));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(604.8076F, 1.999998F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(166.1924F, 99.87118F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // xrLabel22
            // 
            this.xrLabel22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(194)))), ((int)(((byte)(252)))));
            this.xrLabel22.BorderColor = System.Drawing.Color.White;
            this.xrLabel22.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel22.Font = new DevExpress.Drawing.DXFont("Consolas", 8.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel22.ForeColor = System.Drawing.Color.White;
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(669.8F, 218.886F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(97.20013F, 23F);
            this.xrLabel22.StylePriority.UseBackColor = false;
            this.xrLabel22.StylePriority.UseBorderColor = false;
            this.xrLabel22.StylePriority.UseBorderDashStyle = false;
            this.xrLabel22.StylePriority.UseBorders = false;
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseForeColor = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "Total";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // dsFacturasGestion1
            // 
            this.dsFacturasGestion1.DataSetName = "dsFacturasGestion";
            this.dsFacturasGestion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportFooter
            // 
            this.ReportFooter.HeightF = 0F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // rptAjusteDeInventario
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.PageFooter,
            this.GroupFooter1,
            this.ReportHeader,
            this.ReportFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dsFacturasGestion1});
            this.DataMember = "Factura_Detalle";
            this.DataSource = this.dsFacturasGestion1;
            this.Margins = new DevExpress.Drawing.DXMargins(20F, 35F, 16F, 25.70362F);
            this.PageWidth = 836;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom;
            this.ShowPreviewMarginLines = false;
            this.ShowPrintMarginsWarning = false;
            this.Version = "23.2";
            xrWatermark1.Id = "Watermark1";
            this.Watermarks.Add(xrWatermark1);
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.rptAjusteDeInventario_DataSourceDemanded);
            this.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.rptAjusteDeInventario_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasGestion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel lblLegalName;
        private DevExpress.XtraReports.UI.XRLabel lblCompanyName;
        private DevExpress.XtraReports.UI.XRLabel lblTipoTransaccionEntrada_Salida;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel lblRotuloEntradaSalidaRow;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel lblFechaEmision;
        //private dsFacturacion dsFacturacion1;
        //private dsFacturacion dsFacturacion2;
        //private administracion.Facturacion.dsFactura dsFactura1;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell lblCantidad;
        private DevExpress.XtraReports.UI.XRTableCell lblProductoDescripcionItemName;
        private DevExpress.XtraReports.UI.XRTableCell lblEntradaSalida;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private CoreFacturas.dsFacturasGestion dsFacturasGestion1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel txtComentario;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.XRTableCell lblItemCode;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel lblNumeroDocumento;
        private DevExpress.XtraReports.UI.XRLabel lblEstado;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel lblTipoTransaccionMovimiento;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel lblUsuario;
        private DevExpress.XtraReports.UI.XRLabel lblAlmacen;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel lblUsuarioAprobador;
        private DevExpress.XtraReports.UI.XRLabel lblUsuarioAprobadorLabel;
        private DevExpress.XtraReports.UI.XRTableCell lblPrecio;
        private DevExpress.XtraReports.UI.XRTableCell lblTotal;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel22;
    }
}
