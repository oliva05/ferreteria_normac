namespace JAGUAR_PRO.LogisticaJaguar
{
    partial class ProveedorCRUDPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveedorCRUDPagos));
            this.grdProveedor = new DevExpress.XtraEditors.GridLookUpEdit();
            this.proveedoreslistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLogisticaJaguar1 = new JAGUAR_PRO.LogisticaJaguar.dsLogisticaJaguar();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.grdDetalleFacturas = new DevExpress.XtraGrid.GridControl();
            this.grdvDetalleFacturas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_registro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto_pagado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto_pendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdClose = new DevExpress.XtraEditors.DropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoreslistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogisticaJaguar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvDetalleFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProveedor
            // 
            this.grdProveedor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grdProveedor.EditValue = "";
            this.grdProveedor.Location = new System.Drawing.Point(511, 28);
            this.grdProveedor.Name = "grdProveedor";
            this.grdProveedor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdProveedor.Properties.Appearance.Options.UseFont = true;
            this.grdProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdProveedor.Properties.DataSource = this.proveedoreslistBindingSource;
            this.grdProveedor.Properties.DisplayMember = "descripcion";
            this.grdProveedor.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdProveedor.Properties.ValueMember = "id";
            this.grdProveedor.Size = new System.Drawing.Size(327, 26);
            this.grdProveedor.TabIndex = 42;
            this.grdProveedor.EditValueChanged += new System.EventHandler(this.grdProveedor_EditValueChanged);
            // 
            // proveedoreslistBindingSource
            // 
            this.proveedoreslistBindingSource.DataMember = "proveedores_list";
            this.proveedoreslistBindingSource.DataSource = this.dsLogisticaJaguar1;
            // 
            // dsLogisticaJaguar1
            // 
            this.dsLogisticaJaguar1.DataSetName = "dsLogisticaJaguar";
            this.dsLogisticaJaguar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.coldescripcion1});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.LevelIndent = 0;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.PreviewIndent = 0;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(422, 31);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 20);
            this.labelControl4.TabIndex = 41;
            this.labelControl4.Text = "Proveedor";
            // 
            // grdDetalleFacturas
            // 
            this.grdDetalleFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDetalleFacturas.DataMember = "detalle_factura";
            this.grdDetalleFacturas.DataSource = this.dsLogisticaJaguar1;
            this.grdDetalleFacturas.Location = new System.Drawing.Point(2, 146);
            this.grdDetalleFacturas.MainView = this.grdvDetalleFacturas;
            this.grdDetalleFacturas.Name = "grdDetalleFacturas";
            this.grdDetalleFacturas.Size = new System.Drawing.Size(1295, 556);
            this.grdDetalleFacturas.TabIndex = 43;
            this.grdDetalleFacturas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvDetalleFacturas});
            // 
            // grdvDetalleFacturas
            // 
            this.grdvDetalleFacturas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcai,
            this.colfactura,
            this.colfecha_factura,
            this.colfecha_registro,
            this.colobservacion,
            this.colDocNum,
            this.colmonto_factura,
            this.colmonto_pagado,
            this.colmonto_pendiente});
            this.grdvDetalleFacturas.GridControl = this.grdDetalleFacturas;
            this.grdvDetalleFacturas.Name = "grdvDetalleFacturas";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colcai
            // 
            this.colcai.FieldName = "cai";
            this.colcai.Name = "colcai";
            this.colcai.Visible = true;
            this.colcai.VisibleIndex = 1;
            // 
            // colfactura
            // 
            this.colfactura.FieldName = "factura";
            this.colfactura.Name = "colfactura";
            this.colfactura.Visible = true;
            this.colfactura.VisibleIndex = 2;
            // 
            // colfecha_factura
            // 
            this.colfecha_factura.FieldName = "fecha_factura";
            this.colfecha_factura.Name = "colfecha_factura";
            this.colfecha_factura.Visible = true;
            this.colfecha_factura.VisibleIndex = 3;
            // 
            // colfecha_registro
            // 
            this.colfecha_registro.FieldName = "fecha_registro";
            this.colfecha_registro.Name = "colfecha_registro";
            this.colfecha_registro.Visible = true;
            this.colfecha_registro.VisibleIndex = 4;
            // 
            // colobservacion
            // 
            this.colobservacion.FieldName = "observacion";
            this.colobservacion.Name = "colobservacion";
            this.colobservacion.Visible = true;
            this.colobservacion.VisibleIndex = 5;
            // 
            // colDocNum
            // 
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.Visible = true;
            this.colDocNum.VisibleIndex = 6;
            // 
            // colmonto_factura
            // 
            this.colmonto_factura.FieldName = "monto_factura";
            this.colmonto_factura.Name = "colmonto_factura";
            this.colmonto_factura.Visible = true;
            this.colmonto_factura.VisibleIndex = 7;
            // 
            // colmonto_pagado
            // 
            this.colmonto_pagado.FieldName = "monto_pagado";
            this.colmonto_pagado.Name = "colmonto_pagado";
            this.colmonto_pagado.Visible = true;
            this.colmonto_pagado.VisibleIndex = 8;
            // 
            // colmonto_pendiente
            // 
            this.colmonto_pendiente.FieldName = "monto_pendiente";
            this.colmonto_pendiente.Name = "colmonto_pendiente";
            this.colmonto_pendiente.Visible = true;
            this.colmonto_pendiente.VisibleIndex = 9;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(12, 21);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(108, 41);
            this.cmdGuardar.TabIndex = 50;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.ToolTipTitle = "Guardar Entrada de Factura";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmdClose.Appearance.Options.UseFont = true;
            this.cmdClose.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.cmdClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdClose.ImageOptions.SvgImage")));
            this.cmdClose.Location = new System.Drawing.Point(1181, 21);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(108, 41);
            this.cmdClose.TabIndex = 99;
            this.cmdClose.Text = "Cerrar";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // ProveedorCRUDPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 704);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.grdDetalleFacturas);
            this.Controls.Add(this.grdProveedor);
            this.Controls.Add(this.labelControl4);
            this.Name = "ProveedorCRUDPagos";
            ((System.ComponentModel.ISupportInitialize)(this.grdProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoreslistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogisticaJaguar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvDetalleFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit grdProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl grdDetalleFacturas;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvDetalleFacturas;
        private dsLogisticaJaguar dsLogisticaJaguar1;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.DropDownButton cmdClose;
        private System.Windows.Forms.BindingSource proveedoreslistBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcai;
        private DevExpress.XtraGrid.Columns.GridColumn colfactura;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_registro;
        private DevExpress.XtraGrid.Columns.GridColumn colobservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto_pagado;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto_pendiente;
    }
}