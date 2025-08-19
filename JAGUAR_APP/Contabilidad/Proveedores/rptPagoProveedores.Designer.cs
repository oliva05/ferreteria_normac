namespace JAGUAR_PRO.Contabilidad.Proveedores
{
    partial class rptPagoProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptPagoProveedores));
            DevExpress.XtraReports.UI.XRWatermark xrWatermark1 = new DevExpress.XtraReports.UI.XRWatermark();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.lblCompanyName = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNumPago = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblmail = new DevExpress.XtraReports.UI.XRLabel();
            this.lblLegalName = new DevExpress.XtraReports.UI.XRLabel();
            this.lblDireccion = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTelefono = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.lblRTN = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblProveedor = new DevExpress.XtraReports.UI.XRLabel();
            this.lblClienteRTN = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblFechaEmision = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblMetodoPago = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTotalPagar = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblObservacion = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblUsuario = new DevExpress.XtraReports.UI.XRLabel();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.dsAnticipo1 = new JAGUAR_PRO.Contabilidad.Proveedores.dsAnticipo();
            ((System.ComponentModel.ISupportInitialize)(this.dsAnticipo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 16.5078F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 9.533882F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblUsuario,
            this.xrLabel2,
            this.xrLabel11,
            this.xrLabel12,
            this.lblProveedor,
            this.lblClienteRTN,
            this.xrLabel14,
            this.lblFechaEmision,
            this.xrLabel1,
            this.lblMetodoPago,
            this.lblCompanyName,
            this.lblRTN,
            this.lblNumPago,
            this.xrLabel6,
            this.lblmail,
            this.lblLegalName,
            this.lblDireccion,
            this.lblTelefono,
            this.xrPictureBox1});
            this.ReportHeader.HeightF = 212.5F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // PageHeader
            // 
            this.PageHeader.Expanded = false;
            this.PageHeader.HeightF = 0F;
            this.PageHeader.Name = "PageHeader";
            // 
            // PageFooter
            // 
            this.PageFooter.Name = "PageFooter";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblObservacion,
            this.xrLabel7,
            this.xrLabel38,
            this.lblTotalPagar});
            this.ReportFooter.HeightF = 100.0001F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblCompanyName.Font = new DevExpress.Drawing.DXFont("Consolas", 16F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(194)))), ((int)(((byte)(252)))));
            this.lblCompanyName.LocationFloat = new DevExpress.Utils.PointFloat(237.5506F, 1.999998F);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblCompanyName.SizeF = new System.Drawing.SizeF(307.1373F, 33.75011F);
            this.lblCompanyName.StylePriority.UseBorders = false;
            this.lblCompanyName.StylePriority.UseFont = false;
            this.lblCompanyName.StylePriority.UseForeColor = false;
            this.lblCompanyName.StylePriority.UseTextAlignment = false;
            this.lblCompanyName.Text = "Company Name";
            this.lblCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblNumPago
            // 
            this.lblNumPago.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblNumPago.Font = new DevExpress.Drawing.DXFont("Consolas", 11.25F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.lblNumPago.LocationFloat = new DevExpress.Utils.PointFloat(7.474709F, 25F);
            this.lblNumPago.Name = "lblNumPago";
            this.lblNumPago.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNumPago.SizeF = new System.Drawing.SizeF(205.9369F, 28.5F);
            this.lblNumPago.StylePriority.UseBorders = false;
            this.lblNumPago.StylePriority.UseFont = false;
            this.lblNumPago.StylePriority.UseTextAlignment = false;
            this.lblNumPago.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.Font = new DevExpress.Drawing.DXFont("Consolas", 12F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(7.474709F, 1.999998F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(185.1035F, 23F);
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Pago Proveedor";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblmail
            // 
            this.lblmail.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblmail.Font = new DevExpress.Drawing.DXFont("Consolas", 9F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.lblmail.LocationFloat = new DevExpress.Utils.PointFloat(213.4118F, 76.49995F);
            this.lblmail.Name = "lblmail";
            this.lblmail.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblmail.SizeF = new System.Drawing.SizeF(360.262F, 13.00001F);
            this.lblmail.StylePriority.UseBorders = false;
            this.lblmail.StylePriority.UseFont = false;
            this.lblmail.StylePriority.UseTextAlignment = false;
            this.lblmail.Text = "email@mail.com";
            this.lblmail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
            // lblDireccion
            // 
            this.lblDireccion.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblDireccion.Font = new DevExpress.Drawing.DXFont("Consolas", 9F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.lblDireccion.LocationFloat = new DevExpress.Utils.PointFloat(213.4115F, 53.5F);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDireccion.SizeF = new System.Drawing.SizeF(360.2622F, 15.70833F);
            this.lblDireccion.StylePriority.UseBorders = false;
            this.lblDireccion.StylePriority.UseFont = false;
            this.lblDireccion.StylePriority.UseTextAlignment = false;
            this.lblDireccion.Text = "Address 1";
            this.lblDireccion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblTelefono.Font = new DevExpress.Drawing.DXFont("Consolas", 9F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.lblTelefono.LocationFloat = new DevExpress.Utils.PointFloat(7.472897F, 76.49995F);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTelefono.SizeF = new System.Drawing.SizeF(205.9387F, 13.00001F);
            this.lblTelefono.StylePriority.UseBorders = false;
            this.lblTelefono.StylePriority.UseFont = false;
            this.lblTelefono.StylePriority.UseTextAlignment = false;
            this.lblTelefono.Text = "Phone";
            this.lblTelefono.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox1.ImageSource"));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(604.8076F, 1.999998F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(166.1924F, 99.87118F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // lblRTN
            // 
            this.lblRTN.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblRTN.Font = new DevExpress.Drawing.DXFont("Consolas", 11.25F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.lblRTN.LocationFloat = new DevExpress.Utils.PointFloat(7.474693F, 53.5F);
            this.lblRTN.Name = "lblRTN";
            this.lblRTN.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblRTN.SizeF = new System.Drawing.SizeF(205.9369F, 22.99997F);
            this.lblRTN.StylePriority.UseBorders = false;
            this.lblRTN.StylePriority.UseFont = false;
            this.lblRTN.StylePriority.UseTextAlignment = false;
            this.lblRTN.Text = "R.T.N. 1804 1972 015523";
            this.lblRTN.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel11.Font = new DevExpress.Drawing.DXFont("Consolas", 9F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(9.371193F, 143.4962F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(101.8649F, 17F);
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Proveedor";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel12.Font = new DevExpress.Drawing.DXFont("Consolas", 9F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(9.371217F, 160.4962F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(101.8649F, 17.63638F);
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "RTN:";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblProveedor
            // 
            this.lblProveedor.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblProveedor.Font = new DevExpress.Drawing.DXFont("Consolas", 9F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.lblProveedor.LocationFloat = new DevExpress.Utils.PointFloat(122.6945F, 143.4962F);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblProveedor.SizeF = new System.Drawing.SizeF(637.8801F, 17.31818F);
            this.lblProveedor.StylePriority.UseBorders = false;
            this.lblProveedor.StylePriority.UseFont = false;
            this.lblProveedor.StylePriority.UseTextAlignment = false;
            this.lblProveedor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblClienteRTN
            // 
            this.lblClienteRTN.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblClienteRTN.Font = new DevExpress.Drawing.DXFont("Consolas", 9F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.lblClienteRTN.LocationFloat = new DevExpress.Utils.PointFloat(122.6945F, 160.8144F);
            this.lblClienteRTN.Name = "lblClienteRTN";
            this.lblClienteRTN.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblClienteRTN.SizeF = new System.Drawing.SizeF(145.2955F, 17.31815F);
            this.lblClienteRTN.StylePriority.UseBorders = false;
            this.lblClienteRTN.StylePriority.UseFont = false;
            this.lblClienteRTN.StylePriority.UseTextAlignment = false;
            this.lblClienteRTN.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel14.Font = new DevExpress.Drawing.DXFont("Consolas", 9F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(9.371431F, 111.2462F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(101.8647F, 16F);
            this.xrLabel14.StylePriority.UseBorders = false;
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "Fecha";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblFechaEmision.Font = new DevExpress.Drawing.DXFont("Consolas", 9F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.lblFechaEmision.LocationFloat = new DevExpress.Utils.PointFloat(122.6945F, 111.2462F);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblFechaEmision.SizeF = new System.Drawing.SizeF(145.2955F, 16F);
            this.lblFechaEmision.StylePriority.UseBorders = false;
            this.lblFechaEmision.StylePriority.UseFont = false;
            this.lblFechaEmision.StylePriority.UseTextAlignment = false;
            this.lblFechaEmision.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Consolas", 9F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(9.371448F, 127.2462F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(101.8647F, 16.00001F);
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Metodo de Pago";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblMetodoPago.Font = new DevExpress.Drawing.DXFont("Consolas", 9F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.lblMetodoPago.LocationFloat = new DevExpress.Utils.PointFloat(122.6945F, 127.2462F);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblMetodoPago.SizeF = new System.Drawing.SizeF(145.2955F, 16.00001F);
            this.lblMetodoPago.StylePriority.UseBorders = false;
            this.lblMetodoPago.StylePriority.UseFont = false;
            this.lblMetodoPago.StylePriority.UseTextAlignment = false;
            this.lblMetodoPago.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel38
            // 
            this.xrLabel38.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel38.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(, \'MiddleRight\', ?)"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(, True, ?)")});
            this.xrLabel38.Font = new DevExpress.Drawing.DXFont("Consolas", 11.25F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(535.9399F, 0F);
            this.xrLabel38.Name = "xrLabel38";
            this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel38.SizeF = new System.Drawing.SizeF(150.6F, 17.99998F);
            this.xrLabel38.StylePriority.UseBorders = false;
            this.xrLabel38.StylePriority.UseFont = false;
            this.xrLabel38.StylePriority.UseTextAlignment = false;
            this.xrLabel38.Text = "Total Pagado L.";
            this.xrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left;
            this.lblTotalPagar.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblTotalPagar.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(, \'MiddleRight\', ?)"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(, True, ?)")});
            this.lblTotalPagar.Font = new DevExpress.Drawing.DXFont("Consolas", 11.25F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.lblTotalPagar.LocationFloat = new DevExpress.Utils.PointFloat(686.5399F, 0F);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTotalPagar.SizeF = new System.Drawing.SizeF(92.91669F, 17.99998F);
            this.lblTotalPagar.StylePriority.UseBorders = false;
            this.lblTotalPagar.StylePriority.UseFont = false;
            this.lblTotalPagar.StylePriority.UseTextAlignment = false;
            this.lblTotalPagar.Text = "$ 0.00";
            this.lblTotalPagar.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(, \'MiddleRight\', ?)"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(, True, ?)")});
            this.xrLabel7.Font = new DevExpress.Drawing.DXFont("Consolas", 9F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 3.999964F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(148.2417F, 14F);
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Comentario";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblObservacion
            // 
            this.lblObservacion.Font = new DevExpress.Drawing.DXFont("Consolas", 9F);
            this.lblObservacion.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 17.99997F);
            this.lblObservacion.Multiline = true;
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblObservacion.SizeF = new System.Drawing.SizeF(446.5657F, 82.00009F);
            this.lblObservacion.StylePriority.UseFont = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Consolas", 9F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(9.371217F, 178.1326F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(101.8649F, 17.31818F);
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Generado por";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblUsuario.Font = new DevExpress.Drawing.DXFont("Consolas", 9F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.lblUsuario.LocationFloat = new DevExpress.Utils.PointFloat(122.6945F, 178.1326F);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblUsuario.SizeF = new System.Drawing.SizeF(145.2955F, 17.31815F);
            this.lblUsuario.StylePriority.UseBorders = false;
            this.lblUsuario.StylePriority.UseFont = false;
            this.lblUsuario.StylePriority.UseTextAlignment = false;
            this.lblUsuario.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1});
            this.DetailReport.DataSource = this.dsAnticipo1;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Name = "Detail1";
            // 
            // dsAnticipo1
            // 
            this.dsAnticipo1.DataSetName = "dsAnticipo";
            this.dsAnticipo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptPagoProveedores
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.PageHeader,
            this.PageFooter,
            this.ReportFooter,
            this.DetailReport});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dsAnticipo1});
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(19F, 35F, 16.5078F, 9.533882F);
            this.PageWidth = 836;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom;
            this.ShowPreviewMarginLines = false;
            this.ShowPrintMarginsWarning = false;
            this.Version = "23.2";
            xrWatermark1.Id = "Watermark1";
            this.Watermarks.Add(xrWatermark1);
            ((System.ComponentModel.ISupportInitialize)(this.dsAnticipo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel lblCompanyName;
        private DevExpress.XtraReports.UI.XRLabel lblRTN;
        private DevExpress.XtraReports.UI.XRLabel lblNumPago;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel lblmail;
        private DevExpress.XtraReports.UI.XRLabel lblLegalName;
        private DevExpress.XtraReports.UI.XRLabel lblDireccion;
        private DevExpress.XtraReports.UI.XRLabel lblTelefono;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel lblProveedor;
        private DevExpress.XtraReports.UI.XRLabel lblClienteRTN;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel lblFechaEmision;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel lblMetodoPago;
        private DevExpress.XtraReports.UI.XRLabel xrLabel38;
        private DevExpress.XtraReports.UI.XRLabel lblTotalPagar;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel lblObservacion;
        private DevExpress.XtraReports.UI.XRLabel lblUsuario;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private dsAnticipo dsAnticipo1;
    }
}
