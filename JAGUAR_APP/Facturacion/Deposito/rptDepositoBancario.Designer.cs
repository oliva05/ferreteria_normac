﻿namespace JAGUAR_PRO.Facturacion.Deposito
{
    partial class rptDepositoBancario
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
            DevExpress.XtraReports.UI.XRWatermark xrWatermark1 = new DevExpress.XtraReports.UI.XRWatermark();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.lblUsuario = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.lblNombreLega = new DevExpress.XtraReports.UI.XRLabel();
            this.lblDeposito = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNombreComercial = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTotal = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNumCuenta = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblReferenciaTransaccion = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblObs = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblBanco = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNumDeposito = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblFechaEmision = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 12F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.Visible = false;
            this.Detail.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.Detail_BeforePrint);
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblUsuario,
            this.xrLabel8,
            this.xrLine2,
            this.lblNombreLega,
            this.lblDeposito,
            this.lblNombreComercial,
            this.lblTotal,
            this.xrLabel7,
            this.lblNumCuenta,
            this.xrLabel5,
            this.lblReferenciaTransaccion,
            this.xrLabel2,
            this.lblObs,
            this.xrLabel6,
            this.lblBanco,
            this.xrLabel4,
            this.lblNumDeposito,
            this.xrLabel1,
            this.xrLabel14,
            this.lblFechaEmision});
            this.PageHeader.HeightF = 257.5659F;
            this.PageHeader.Name = "PageHeader";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblUsuario.Font = new DevExpress.Drawing.DXFont("Courier New", 9.5F);
            this.lblUsuario.LocationFloat = new DevExpress.Utils.PointFloat(121.9131F, 208.5658F);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblUsuario.SizeF = new System.Drawing.SizeF(138.2414F, 16F);
            this.lblUsuario.StylePriority.UseBorders = false;
            this.lblUsuario.StylePriority.UseFont = false;
            this.lblUsuario.StylePriority.UseTextAlignment = false;
            this.lblUsuario.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel8.Font = new DevExpress.Drawing.DXFont("Courier New", 9.5F);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(11F, 192.5658F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(110.9112F, 16F);
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "CUENTA No:";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLine2
            // 
            this.xrLine2.LineStyle = DevExpress.Drawing.DXDashStyle.Dash;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 112.42F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(260.1534F, 2.000008F);
            // 
            // lblNombreLega
            // 
            this.lblNombreLega.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblNombreLega.Font = new DevExpress.Drawing.DXFont("Courier New", 8.25F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.lblNombreLega.LocationFloat = new DevExpress.Utils.PointFloat(0.001080831F, 48.41665F);
            this.lblNombreLega.Name = "lblNombreLega";
            this.lblNombreLega.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNombreLega.SizeF = new System.Drawing.SizeF(260.1533F, 30.29168F);
            this.lblNombreLega.StylePriority.UseBorders = false;
            this.lblNombreLega.StylePriority.UseFont = false;
            this.lblNombreLega.StylePriority.UseTextAlignment = false;
            this.lblNombreLega.Text = "Nombre legal";
            this.lblNombreLega.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblDeposito
            // 
            this.lblDeposito.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblDeposito.Font = new DevExpress.Drawing.DXFont("Courier New", 12F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.lblDeposito.LocationFloat = new DevExpress.Utils.PointFloat(0.001084328F, 89.42004F);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDeposito.SizeF = new System.Drawing.SizeF(260.1529F, 23F);
            this.lblDeposito.StylePriority.UseBorders = false;
            this.lblDeposito.StylePriority.UseFont = false;
            this.lblDeposito.StylePriority.UseTextAlignment = false;
            this.lblDeposito.Text = "DEPOSITO BANCARIO";
            this.lblDeposito.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblNombreComercial
            // 
            this.lblNombreComercial.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblNombreComercial.Font = new DevExpress.Drawing.DXFont("Courier New", 12F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.lblNombreComercial.LocationFloat = new DevExpress.Utils.PointFloat(0.001084328F, 28.41666F);
            this.lblNombreComercial.Name = "lblNombreComercial";
            this.lblNombreComercial.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNombreComercial.SizeF = new System.Drawing.SizeF(260.1534F, 18F);
            this.lblNombreComercial.StylePriority.UseBorders = false;
            this.lblNombreComercial.StylePriority.UseFont = false;
            this.lblNombreComercial.StylePriority.UseTextAlignment = false;
            this.lblNombreComercial.Text = "Nombre Comercial";
            this.lblNombreComercial.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblTotal.Font = new DevExpress.Drawing.DXFont("Courier New", 9.5F);
            this.lblTotal.LocationFloat = new DevExpress.Utils.PointFloat(121.9126F, 224.5658F);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTotal.SizeF = new System.Drawing.SizeF(138.2415F, 16F);
            this.lblTotal.StylePriority.UseBorders = false;
            this.lblTotal.StylePriority.UseFont = false;
            this.lblTotal.StylePriority.UseTextAlignment = false;
            this.lblTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel7.Font = new DevExpress.Drawing.DXFont("Courier New", 9.5F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(11.00106F, 224.5658F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(110.911F, 15.99999F);
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "TOTAL:";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblNumCuenta
            // 
            this.lblNumCuenta.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblNumCuenta.Font = new DevExpress.Drawing.DXFont("Courier New", 9.5F);
            this.lblNumCuenta.LocationFloat = new DevExpress.Utils.PointFloat(121.9132F, 192.5657F);
            this.lblNumCuenta.Name = "lblNumCuenta";
            this.lblNumCuenta.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNumCuenta.SizeF = new System.Drawing.SizeF(138.2413F, 16.00002F);
            this.lblNumCuenta.StylePriority.UseBorders = false;
            this.lblNumCuenta.StylePriority.UseFont = false;
            this.lblNumCuenta.StylePriority.UseTextAlignment = false;
            this.lblNumCuenta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel5.Font = new DevExpress.Drawing.DXFont("Courier New", 9.5F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(11.00108F, 208.5658F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(110.9111F, 15.99999F);
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "CAJERO:";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblReferenciaTransaccion
            // 
            this.lblReferenciaTransaccion.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblReferenciaTransaccion.Font = new DevExpress.Drawing.DXFont("Courier New", 9.5F);
            this.lblReferenciaTransaccion.LocationFloat = new DevExpress.Utils.PointFloat(121.9123F, 144.5658F);
            this.lblReferenciaTransaccion.Name = "lblReferenciaTransaccion";
            this.lblReferenciaTransaccion.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblReferenciaTransaccion.SizeF = new System.Drawing.SizeF(138.2413F, 16F);
            this.lblReferenciaTransaccion.StylePriority.UseBorders = false;
            this.lblReferenciaTransaccion.StylePriority.UseFont = false;
            this.lblReferenciaTransaccion.StylePriority.UseTextAlignment = false;
            this.lblReferenciaTransaccion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Courier New", 9.5F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(11.00106F, 144.5658F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(110.9112F, 16.00001F);
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "REFERENCIA:";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblObs
            // 
            this.lblObs.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblObs.Font = new DevExpress.Drawing.DXFont("Courier New", 9.5F);
            this.lblObs.LocationFloat = new DevExpress.Utils.PointFloat(121.9121F, 240.5659F);
            this.lblObs.Multiline = true;
            this.lblObs.Name = "lblObs";
            this.lblObs.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblObs.SizeF = new System.Drawing.SizeF(138.2414F, 16.00002F);
            this.lblObs.StylePriority.UseBorders = false;
            this.lblObs.StylePriority.UseFont = false;
            this.lblObs.StylePriority.UseTextAlignment = false;
            this.lblObs.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.Font = new DevExpress.Drawing.DXFont("Courier New", 9.5F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(11.00108F, 240.5659F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(110.9111F, 15.99998F);
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "OBSERVACION:";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblBanco
            // 
            this.lblBanco.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblBanco.Font = new DevExpress.Drawing.DXFont("Courier New", 9.5F);
            this.lblBanco.LocationFloat = new DevExpress.Utils.PointFloat(121.9123F, 176.5657F);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblBanco.SizeF = new System.Drawing.SizeF(138.2414F, 16.00002F);
            this.lblBanco.StylePriority.UseBorders = false;
            this.lblBanco.StylePriority.UseFont = false;
            this.lblBanco.StylePriority.UseTextAlignment = false;
            this.lblBanco.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Courier New", 9.5F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(11.00106F, 176.5658F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(110.9112F, 16F);
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "BANCO:";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblNumDeposito
            // 
            this.lblNumDeposito.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblNumDeposito.Font = new DevExpress.Drawing.DXFont("Courier New", 9.5F);
            this.lblNumDeposito.LocationFloat = new DevExpress.Utils.PointFloat(121.9126F, 128.5659F);
            this.lblNumDeposito.Name = "lblNumDeposito";
            this.lblNumDeposito.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNumDeposito.SizeF = new System.Drawing.SizeF(138.2413F, 15.99998F);
            this.lblNumDeposito.StylePriority.UseBorders = false;
            this.lblNumDeposito.StylePriority.UseFont = false;
            this.lblNumDeposito.StylePriority.UseTextAlignment = false;
            this.lblNumDeposito.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Courier New", 9.5F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(11.00106F, 128.5658F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(110.9115F, 16F);
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "DEPOSITO No:";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel14.Font = new DevExpress.Drawing.DXFont("Courier New", 9.5F);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(11.00106F, 160.5658F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(110.9111F, 16F);
            this.xrLabel14.StylePriority.UseBorders = false;
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "FECHA:";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblFechaEmision.Font = new DevExpress.Drawing.DXFont("Courier New", 9.5F);
            this.lblFechaEmision.LocationFloat = new DevExpress.Utils.PointFloat(121.9122F, 160.5659F);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblFechaEmision.SizeF = new System.Drawing.SizeF(138.2414F, 16F);
            this.lblFechaEmision.StylePriority.UseBorders = false;
            this.lblFechaEmision.StylePriority.UseFont = false;
            this.lblFechaEmision.StylePriority.UseTextAlignment = false;
            this.lblFechaEmision.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel9,
            this.xrLine3,
            this.xrLine1,
            this.xrLabel3});
            this.PageFooter.HeightF = 153.3857F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrLine1
            // 
            this.xrLine1.LineStyle = DevExpress.Drawing.DXDashStyle.Dash;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(9.846588F, 52.99998F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(260.1534F, 2.000008F);
            // 
            // xrLabel3
            // 
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Courier New", 9.75F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(77.31441F, 54.99999F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(104.7805F, 16F);
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Cajero";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel9.Font = new DevExpress.Drawing.DXFont("Courier New", 9.75F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(77.25209F, 134.7432F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(104.7805F, 16F);
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Supervisor";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLine3
            // 
            this.xrLine3.LineStyle = DevExpress.Drawing.DXDashStyle.Dash;
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(9.846581F, 132.7432F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(260.1534F, 2.000008F);
            // 
            // rptDepositoBancario
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.PageHeader,
            this.PageFooter});
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(16F, 6F, 0F, 12F);
            this.PageWidth = 292;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom;
            this.RollPaper = true;
            this.ShowPreviewMarginLines = false;
            this.ShowPrintMarginsWarning = false;
            this.Version = "23.2";
            xrWatermark1.Id = "Watermark1";
            this.Watermarks.Add(xrWatermark1);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel lblFechaEmision;
        private DevExpress.XtraReports.UI.XRLabel lblReferenciaTransaccion;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel lblObs;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel lblBanco;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel lblNumDeposito;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel lblNumCuenta;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel lblTotal;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.XRLabel lblNombreLega;
        private DevExpress.XtraReports.UI.XRLabel lblDeposito;
        private DevExpress.XtraReports.UI.XRLabel lblNombreComercial;
        private DevExpress.XtraReports.UI.XRLabel lblUsuario;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLine xrLine3;
    }
}
