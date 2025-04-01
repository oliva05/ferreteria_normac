namespace PRININ.Gestion_de_Usuarios
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSAve = new DevExpress.XtraEditors.SimpleButton();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.lueGrupo = new DevExpress.XtraEditors.LookUpEdit();
            this.accesoGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAccesos1 = new JAGUAR_PRO.Accesos.dsAccesos();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.turnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lueTurno = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.tsIsVendedor = new DevExpress.XtraEditors.ToggleSwitch();
            this.chkUsuarioHabilitado = new DevExpress.XtraEditors.ToggleSwitch();
            this.chkSuperUsuario = new DevExpress.XtraEditors.ToggleSwitch();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gridControlAccesos = new DevExpress.XtraGrid.GridControl();
            this.gridViewAccesos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colselected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.lueGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accesoGrupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccesos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTurno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsIsVendedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUsuarioHabilitado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSuperUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAccesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmar.Location = new System.Drawing.Point(110, 69);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.PasswordChar = '●';
            this.txtConfirmar.Size = new System.Drawing.Size(176, 22);
            this.txtConfirmar.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Confirmar:";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(110, 41);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(176, 22);
            this.txtPass.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Contraseña:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(85, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(201, 22);
            this.txtNombre.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre";
            // 
            // txtAlias
            // 
            this.txtAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlias.Location = new System.Drawing.Point(85, 13);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(201, 22);
            this.txtAlias.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Alias";
            // 
            // cmdSAve
            // 
            this.cmdSAve.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmdSAve.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSAve.Appearance.Options.UseBackColor = true;
            this.cmdSAve.Appearance.Options.UseFont = true;
            this.cmdSAve.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSAve.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdSAve.ImageOptions.Image")));
            this.cmdSAve.Location = new System.Drawing.Point(20, 345);
            this.cmdSAve.Name = "cmdSAve";
            this.cmdSAve.Size = new System.Drawing.Size(109, 40);
            this.cmdSAve.TabIndex = 38;
            this.cmdSAve.Text = "Guardar";
            this.cmdSAve.Click += new System.EventHandler(this.cmdSAve_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Appearance.BackColor = System.Drawing.Color.SandyBrown;
            this.cmdClose.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Appearance.Options.UseBackColor = true;
            this.cmdClose.Appearance.Options.UseFont = true;
            this.cmdClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdClose.ImageOptions.Image")));
            this.cmdClose.Location = new System.Drawing.Point(166, 345);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(109, 40);
            this.cmdClose.TabIndex = 39;
            this.cmdClose.Text = "Cerrar";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // lueGrupo
            // 
            this.lueGrupo.Location = new System.Drawing.Point(85, 124);
            this.lueGrupo.Name = "lueGrupo";
            this.lueGrupo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lueGrupo.Properties.Appearance.Options.UseFont = true;
            this.lueGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueGrupo.Properties.DataSource = this.accesoGrupoBindingSource;
            this.lueGrupo.Properties.DisplayMember = "grupo";
            this.lueGrupo.Properties.NullText = "";
            this.lueGrupo.Properties.ValueMember = "id";
            this.lueGrupo.Size = new System.Drawing.Size(201, 22);
            this.lueGrupo.TabIndex = 40;
            // 
            // accesoGrupoBindingSource
            // 
            this.accesoGrupoBindingSource.DataMember = "Acceso_Grupo";
            this.accesoGrupoBindingSource.DataSource = this.dsAccesos1;
            // 
            // dsAccesos1
            // 
            this.dsAccesos1.DataSetName = "dsAccesos";
            this.dsAccesos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Grupo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "Turno:";
            // 
            // turnoBindingSource
            // 
            this.turnoBindingSource.DataMember = "Turno";
            this.turnoBindingSource.DataSource = this.dsAccesos1;
            // 
            // lueTurno
            // 
            this.lueTurno.Location = new System.Drawing.Point(85, 155);
            this.lueTurno.Name = "lueTurno";
            this.lueTurno.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lueTurno.Properties.Appearance.Options.UseFont = true;
            this.lueTurno.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTurno.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 32, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "descripcion", 77, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueTurno.Properties.DataSource = this.turnoBindingSource;
            this.lueTurno.Properties.DisplayMember = "descripcion";
            this.lueTurno.Properties.NullText = "";
            this.lueTurno.Properties.ValueMember = "Id";
            this.lueTurno.Size = new System.Drawing.Size(201, 22);
            this.lueTurno.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(85, 185);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(201, 22);
            this.txtCodigo.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "PIN:";
            // 
            // txtPIN
            // 
            this.txtPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPIN.Location = new System.Drawing.Point(85, 213);
            this.txtPIN.MaxLength = 6;
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.PasswordChar = '●';
            this.txtPIN.Size = new System.Drawing.Size(201, 22);
            this.txtPIN.TabIndex = 48;
            // 
            // tsIsVendedor
            // 
            this.tsIsVendedor.Location = new System.Drawing.Point(154, 250);
            this.tsIsVendedor.Name = "tsIsVendedor";
            this.tsIsVendedor.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tsIsVendedor.Properties.Appearance.Options.UseFont = true;
            this.tsIsVendedor.Properties.OffText = "No";
            this.tsIsVendedor.Properties.OnText = "Si";
            this.tsIsVendedor.Size = new System.Drawing.Size(95, 21);
            this.tsIsVendedor.TabIndex = 49;
            // 
            // chkUsuarioHabilitado
            // 
            this.chkUsuarioHabilitado.EditValue = true;
            this.chkUsuarioHabilitado.Location = new System.Drawing.Point(154, 277);
            this.chkUsuarioHabilitado.Name = "chkUsuarioHabilitado";
            this.chkUsuarioHabilitado.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkUsuarioHabilitado.Properties.Appearance.Options.UseFont = true;
            this.chkUsuarioHabilitado.Properties.OffText = "No";
            this.chkUsuarioHabilitado.Properties.OnText = "Si";
            this.chkUsuarioHabilitado.Size = new System.Drawing.Size(95, 21);
            this.chkUsuarioHabilitado.TabIndex = 50;
            // 
            // chkSuperUsuario
            // 
            this.chkSuperUsuario.Location = new System.Drawing.Point(154, 304);
            this.chkSuperUsuario.Name = "chkSuperUsuario";
            this.chkSuperUsuario.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkSuperUsuario.Properties.Appearance.Options.UseFont = true;
            this.chkSuperUsuario.Properties.OffText = "No";
            this.chkSuperUsuario.Properties.OnText = "Si";
            this.chkSuperUsuario.Size = new System.Drawing.Size(95, 21);
            this.chkSuperUsuario.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 52;
            this.label9.Text = "Vendedor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 53;
            this.label10.Text = "Habilitado:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 16);
            this.label11.TabIndex = 54;
            this.label11.Text = "Super Usuario:";
            // 
            // gridControlAccesos
            // 
            this.gridControlAccesos.DataMember = "niveles_acceso";
            this.gridControlAccesos.DataSource = this.dsAccesos1;
            this.gridControlAccesos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAccesos.Location = new System.Drawing.Point(2, 27);
            this.gridControlAccesos.MainView = this.gridViewAccesos;
            this.gridControlAccesos.Name = "gridControlAccesos";
            this.gridControlAccesos.Size = new System.Drawing.Size(534, 379);
            this.gridControlAccesos.TabIndex = 55;
            this.gridControlAccesos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAccesos});
            // 
            // gridViewAccesos
            // 
            this.gridViewAccesos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnivel,
            this.colcodigo,
            this.colselected});
            this.gridViewAccesos.GridControl = this.gridControlAccesos;
            this.gridViewAccesos.Name = "gridViewAccesos";
            this.gridViewAccesos.OptionsView.AllowHtmlDrawGroups = false;
            this.gridViewAccesos.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gridViewAccesos.OptionsView.ShowGroupPanel = false;
            this.gridViewAccesos.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewAccesos_CellValueChanging);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colnivel
            // 
            this.colnivel.Caption = "Nivel";
            this.colnivel.FieldName = "nivel";
            this.colnivel.Name = "colnivel";
            this.colnivel.OptionsColumn.AllowEdit = false;
            this.colnivel.Visible = true;
            this.colnivel.VisibleIndex = 1;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            // 
            // colselected
            // 
            this.colselected.Caption = "Seleccion";
            this.colselected.FieldName = "selected";
            this.colselected.Name = "colselected";
            this.colselected.Visible = true;
            this.colselected.VisibleIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gridControlAccesos);
            this.groupControl1.Location = new System.Drawing.Point(292, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(538, 408);
            this.groupControl1.TabIndex = 56;
            this.groupControl1.Text = "Nivel de Acceso";
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 409);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chkSuperUsuario);
            this.Controls.Add(this.chkUsuarioHabilitado);
            this.Controls.Add(this.tsIsVendedor);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lueTurno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lueGrupo);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdSAve);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.label1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmUser.IconOptions.Icon")));
            this.Name = "frmUser";
            ((System.ComponentModel.ISupportInitialize)(this.lueGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accesoGrupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccesos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTurno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsIsVendedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUsuarioHabilitado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSuperUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAccesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton cmdSAve;
        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraEditors.LookUpEdit lueGrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource accesoGrupoBindingSource;
        private JAGUAR_PRO.Accesos.dsAccesos dsAccesos1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource turnoBindingSource;
        private DevExpress.XtraEditors.LookUpEdit lueTurno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPIN;
        private DevExpress.XtraEditors.ToggleSwitch tsIsVendedor;
        private DevExpress.XtraEditors.ToggleSwitch chkUsuarioHabilitado;
        private DevExpress.XtraEditors.ToggleSwitch chkSuperUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraGrid.GridControl gridControlAccesos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAccesos;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnivel;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colselected;
    }
}