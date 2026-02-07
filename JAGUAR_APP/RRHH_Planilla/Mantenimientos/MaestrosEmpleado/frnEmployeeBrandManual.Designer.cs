namespace JAGUAR_PRO.RRHH_Planilla.Mantenimientos.MaestrosEmpleado
{
    partial class frnEmployeeBrandManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frnEmployeeBrandManual));
            this.grdTipoMarca = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tipomarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaestroEmpleados1 = new JAGUAR_PRO.RRHH_Planilla.Mantenimientos.MaestrosEmpleado.dsMaestroEmpleados();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.labelControl54 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFechaHora = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tggCierreDia = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblCantMarcas = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipomarcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaestroEmpleados1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHora.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggCierreDia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTipoMarca
            // 
            this.grdTipoMarca.Location = new System.Drawing.Point(210, 78);
            this.grdTipoMarca.Name = "grdTipoMarca";
            this.grdTipoMarca.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdTipoMarca.Properties.Appearance.Options.UseFont = true;
            this.grdTipoMarca.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdTipoMarca.Properties.DataSource = this.tipomarcaBindingSource;
            this.grdTipoMarca.Properties.DisplayMember = "descripcion";
            this.grdTipoMarca.Properties.NullText = "";
            this.grdTipoMarca.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdTipoMarca.Properties.ValueMember = "id";
            this.grdTipoMarca.Size = new System.Drawing.Size(263, 24);
            this.grdTipoMarca.TabIndex = 1;
            // 
            // tipomarcaBindingSource
            // 
            this.tipomarcaBindingSource.DataMember = "tipo_marca";
            this.tipomarcaBindingSource.DataSource = this.dsMaestroEmpleados1;
            // 
            // dsMaestroEmpleados1
            // 
            this.dsMaestroEmpleados1.DataSetName = "dsMaestroEmpleados";
            this.dsMaestroEmpleados1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Image = global::JAGUAR_PRO.Properties.Resources.save_24x24;
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(211, 217);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(86, 33);
            this.cmdGuardar.TabIndex = 10;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Image = global::JAGUAR_PRO.Properties.Resources.cancel_32x32;
            this.cmdCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCerrar.Location = new System.Drawing.Point(303, 217);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(86, 33);
            this.cmdCerrar.TabIndex = 11;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // labelControl54
            // 
            this.labelControl54.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl54.Appearance.Options.UseFont = true;
            this.labelControl54.Location = new System.Drawing.Point(65, 78);
            this.labelControl54.Name = "labelControl54";
            this.labelControl54.Size = new System.Drawing.Size(86, 17);
            this.labelControl54.TabIndex = 14;
            this.labelControl54.Text = "Tipo de Marca";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(65, 115);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 17);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Fecha y Hora";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdBuscar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdBuscar.Enabled = false;
            this.cmdBuscar.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.cmdBuscar.FlatAppearance.BorderSize = 2;
            this.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Image = ((System.Drawing.Image)(resources.GetObject("cmdBuscar.Image")));
            this.cmdBuscar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.cmdBuscar.Location = new System.Drawing.Point(479, 37);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(96, 33);
            this.cmdBuscar.TabIndex = 40;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdBuscar.UseVisualStyleBackColor = false;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Enabled = false;
            this.txtEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtEmpleado.Location = new System.Drawing.Point(210, 41);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(263, 25);
            this.txtEmpleado.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(62, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Empleado";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtFechaHora
            // 
            this.dtFechaHora.EditValue = null;
            this.dtFechaHora.Location = new System.Drawing.Point(210, 112);
            this.dtFechaHora.Name = "dtFechaHora";
            this.dtFechaHora.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtFechaHora.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.dtFechaHora.Properties.Appearance.Options.UseFont = true;
            this.dtFechaHora.Properties.Appearance.Options.UseForeColor = true;
            this.dtFechaHora.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHora.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtFechaHora.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHora.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dtFechaHora.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtFechaHora.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dtFechaHora.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtFechaHora.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtFechaHora.Size = new System.Drawing.Size(263, 26);
            this.dtFechaHora.TabIndex = 44;
            this.dtFechaHora.EditValueChanged += new System.EventHandler(this.dtFechaHora_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(65, 180);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(128, 17);
            this.labelControl2.TabIndex = 45;
            this.labelControl2.Text = "Generar Cierre de dia";
            // 
            // tggCierreDia
            // 
            this.tggCierreDia.Location = new System.Drawing.Point(210, 177);
            this.tggCierreDia.Name = "tggCierreDia";
            this.tggCierreDia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tggCierreDia.Properties.Appearance.Options.UseFont = true;
            this.tggCierreDia.Properties.OffText = "No";
            this.tggCierreDia.Properties.OnText = "Si";
            this.tggCierreDia.Size = new System.Drawing.Size(95, 24);
            this.tggCierreDia.TabIndex = 46;
            this.tggCierreDia.Toggled += new System.EventHandler(this.tggCierreDia_Toggled);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(65, 148);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(120, 17);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "Cantidad de Marcas";
            // 
            // lblCantMarcas
            // 
            this.lblCantMarcas.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantMarcas.Appearance.Options.UseFont = true;
            this.lblCantMarcas.Location = new System.Drawing.Point(212, 148);
            this.lblCantMarcas.Name = "lblCantMarcas";
            this.lblCantMarcas.Size = new System.Drawing.Size(7, 17);
            this.lblCantMarcas.TabIndex = 48;
            this.lblCantMarcas.Text = "0";
            // 
            // frnEmployeeBrandManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 261);
            this.Controls.Add(this.lblCantMarcas);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.tggCierreDia);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.dtFechaHora);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl54);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.grdTipoMarca);
            this.IconOptions.ShowIcon = false;
            this.Name = "frnEmployeeBrandManual";
            this.Text = "Marcaje Manual";
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipomarcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaestroEmpleados1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHora.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggCierreDia.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GridLookUpEdit grdTipoMarca;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdCerrar;
        private DevExpress.XtraEditors.LabelControl labelControl54;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource tipomarcaBindingSource;
        private dsMaestroEmpleados dsMaestroEmpleados1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraEditors.DateEdit dtFechaHora;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ToggleSwitch tggCierreDia;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblCantMarcas;
    }
}