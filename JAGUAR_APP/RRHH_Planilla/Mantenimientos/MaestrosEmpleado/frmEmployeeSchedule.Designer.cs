namespace JAGUAR_PRO.RRHH_Planilla.Mantenimientos.MaestrosEmpleado
{
    partial class frmEmployeeSchedule
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsMaestroEmpleados1 = new JAGUAR_PRO.RRHH_Planilla.Mantenimientos.MaestrosEmpleado.dsMaestroEmpleados();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_employee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldias_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_entrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_salida_lunch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_entrada_lunch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_salida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_user_create = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_created = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblNombreEmpleado = new DevExpress.XtraEditors.LabelControl();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tggMarcAlmuerzo = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaestroEmpleados1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggMarcAlmuerzo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "horario";
            this.gridControl1.DataSource = this.dsMaestroEmpleados1;
            this.gridControl1.Location = new System.Drawing.Point(3, 71);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(954, 365);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsMaestroEmpleados1
            // 
            this.dsMaestroEmpleados1.DataSetName = "dsMaestroEmpleados";
            this.dsMaestroEmpleados1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_employee,
            this.colenable,
            this.coldia,
            this.coldias_name,
            this.colhora_entrada,
            this.colhora_salida_lunch,
            this.colhora_entrada_lunch,
            this.colhora_salida,
            this.colid_user_create,
            this.colfecha_created});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colid_employee
            // 
            this.colid_employee.FieldName = "id_employee";
            this.colid_employee.Name = "colid_employee";
            this.colid_employee.OptionsColumn.AllowEdit = false;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.AllowEdit = false;
            // 
            // coldia
            // 
            this.coldia.FieldName = "dia";
            this.coldia.Name = "coldia";
            this.coldia.OptionsColumn.AllowEdit = false;
            // 
            // coldias_name
            // 
            this.coldias_name.Caption = "Dia de la Semana";
            this.coldias_name.FieldName = "dias_name";
            this.coldias_name.Name = "coldias_name";
            this.coldias_name.OptionsColumn.ReadOnly = true;
            this.coldias_name.Visible = true;
            this.coldias_name.VisibleIndex = 0;
            // 
            // colhora_entrada
            // 
            this.colhora_entrada.Caption = "Hora Entrada";
            this.colhora_entrada.FieldName = "hora_entrada";
            this.colhora_entrada.Name = "colhora_entrada";
            this.colhora_entrada.Visible = true;
            this.colhora_entrada.VisibleIndex = 1;
            // 
            // colhora_salida_lunch
            // 
            this.colhora_salida_lunch.Caption = "H. Salida Almuerzo";
            this.colhora_salida_lunch.FieldName = "hora_salida_lunch";
            this.colhora_salida_lunch.Name = "colhora_salida_lunch";
            this.colhora_salida_lunch.Visible = true;
            this.colhora_salida_lunch.VisibleIndex = 2;
            // 
            // colhora_entrada_lunch
            // 
            this.colhora_entrada_lunch.Caption = "H. Entrada Almuerzo";
            this.colhora_entrada_lunch.FieldName = "hora_entrada_lunch";
            this.colhora_entrada_lunch.Name = "colhora_entrada_lunch";
            this.colhora_entrada_lunch.Visible = true;
            this.colhora_entrada_lunch.VisibleIndex = 3;
            // 
            // colhora_salida
            // 
            this.colhora_salida.Caption = "Hora Salida";
            this.colhora_salida.FieldName = "hora_salida";
            this.colhora_salida.Name = "colhora_salida";
            this.colhora_salida.Visible = true;
            this.colhora_salida.VisibleIndex = 4;
            // 
            // colid_user_create
            // 
            this.colid_user_create.FieldName = "id_user_create";
            this.colid_user_create.Name = "colid_user_create";
            this.colid_user_create.OptionsColumn.AllowEdit = false;
            // 
            // colfecha_created
            // 
            this.colfecha_created.FieldName = "fecha_created";
            this.colfecha_created.Name = "colfecha_created";
            this.colfecha_created.OptionsColumn.AllowEdit = false;
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.Appearance.Options.UseFont = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(12, 39);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(119, 21);
            this.lblNombreEmpleado.TabIndex = 3;
            this.lblNombreEmpleado.Text = "Employee Name";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Appearance.Options.UseFont = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 12);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(50, 21);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "AQ000";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Image = global::JAGUAR_PRO.Properties.Resources.save_24x24;
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(734, 27);
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
            this.cmdCerrar.Location = new System.Drawing.Point(861, 27);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(86, 33);
            this.cmdCerrar.TabIndex = 11;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(520, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Marca Almuerzo";
            // 
            // tggMarcAlmuerzo
            // 
            this.tggMarcAlmuerzo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tggMarcAlmuerzo.EditValue = true;
            this.tggMarcAlmuerzo.Location = new System.Drawing.Point(615, 33);
            this.tggMarcAlmuerzo.Name = "tggMarcAlmuerzo";
            this.tggMarcAlmuerzo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tggMarcAlmuerzo.Properties.Appearance.Options.UseFont = true;
            this.tggMarcAlmuerzo.Properties.OffText = "No";
            this.tggMarcAlmuerzo.Properties.OnText = "Si";
            this.tggMarcAlmuerzo.Size = new System.Drawing.Size(95, 21);
            this.tggMarcAlmuerzo.TabIndex = 12;
            this.tggMarcAlmuerzo.Toggled += new System.EventHandler(this.tggMarcAlmuerzo_Toggled);
            // 
            // frmEmployeeSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tggMarcAlmuerzo);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Controls.Add(this.gridControl1);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmEmployeeSchedule";
            this.Text = "Gestion de Horario";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaestroEmpleados1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggMarcAlmuerzo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lblNombreEmpleado;
        private DevExpress.XtraEditors.LabelControl lblCodigo;
        private dsMaestroEmpleados dsMaestroEmpleados1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_employee;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn coldia;
        private DevExpress.XtraGrid.Columns.GridColumn coldias_name;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_entrada;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_salida_lunch;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_entrada_lunch;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_salida;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user_create;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_created;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ToggleSwitch tggMarcAlmuerzo;
    }
}