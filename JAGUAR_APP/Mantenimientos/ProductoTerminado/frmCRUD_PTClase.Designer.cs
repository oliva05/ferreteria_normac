﻿namespace JAGUAR_PRO.Mantenimientos.ProductoTerminado
{
    partial class frmCRUD_PTClase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCRUD_PTClase));
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitchEnablePT = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblTituloVentana = new DevExpress.XtraEditors.LabelControl();
            this.grdTipo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.familiaselectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProductoTerminado1 = new JAGUAR_PRO.Mantenimientos.ProductoTerminado.dsProductoTerminado();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colconcat_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.categoariaselectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchEnablePT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiaselectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductoTerminado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoariaselectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdGuardar.ImageOptions.SvgImage")));
            this.cmdGuardar.Location = new System.Drawing.Point(66, 242);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(132, 42);
            this.cmdGuardar.TabIndex = 45;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.Pink;
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdCerrar.ImageOptions.SvgImage")));
            this.cmdCerrar.Location = new System.Drawing.Point(243, 242);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(132, 42);
            this.cmdCerrar.TabIndex = 44;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodigo.Location = new System.Drawing.Point(201, 104);
            this.txtCodigo.MaxLength = 3;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(189, 23);
            this.txtCodigo.TabIndex = 43;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(29, 109);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(191, 15);
            this.labelControl5.TabIndex = 42;
            this.labelControl5.Text = "Código de Clase_____________________";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescripcion.Location = new System.Drawing.Point(201, 133);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(189, 23);
            this.txtDescripcion.TabIndex = 41;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(29, 138);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(184, 15);
            this.labelControl4.TabIndex = 40;
            this.labelControl4.Text = "Descripcion de Clase_______________";
            // 
            // toggleSwitchEnablePT
            // 
            this.toggleSwitchEnablePT.Location = new System.Drawing.Point(215, 167);
            this.toggleSwitchEnablePT.Name = "toggleSwitchEnablePT";
            this.toggleSwitchEnablePT.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toggleSwitchEnablePT.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitchEnablePT.Properties.OffText = "No";
            this.toggleSwitchEnablePT.Properties.OnText = "Si";
            this.toggleSwitchEnablePT.Size = new System.Drawing.Size(115, 20);
            this.toggleSwitchEnablePT.TabIndex = 39;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(120, 169);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(159, 15);
            this.labelControl2.TabIndex = 38;
            this.labelControl2.Text = "Activo_________________________";
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVentana.Appearance.Options.UseFont = true;
            this.lblTituloVentana.Location = new System.Drawing.Point(174, 18);
            this.lblTituloVentana.Name = "lblTituloVentana";
            this.lblTituloVentana.Size = new System.Drawing.Size(76, 20);
            this.lblTituloVentana.TabIndex = 37;
            this.lblTituloVentana.Text = "Crear Clase";
            // 
            // grdTipo
            // 
            this.grdTipo.Location = new System.Drawing.Point(201, 76);
            this.grdTipo.Name = "grdTipo";
            this.grdTipo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grdTipo.Properties.Appearance.Options.UseFont = true;
            this.grdTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdTipo.Properties.DataSource = this.categoariaselectBindingSource;
            this.grdTipo.Properties.DisplayMember = "concat_";
            this.grdTipo.Properties.NullText = "";
            this.grdTipo.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdTipo.Properties.ValueMember = "id";
            this.grdTipo.Size = new System.Drawing.Size(189, 22);
            this.grdTipo.TabIndex = 46;
            // 
            // familiaselectBindingSource
            // 
            this.familiaselectBindingSource.DataMember = "familia_select";
            this.familiaselectBindingSource.DataSource = this.dsProductoTerminado1;
            // 
            // dsProductoTerminado1
            // 
            this.dsProductoTerminado1.DataSetName = "dsProductoTerminado";
            this.dsProductoTerminado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colconcat_,
            this.colid});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colconcat_
            // 
            this.colconcat_.Caption = "Familia";
            this.colconcat_.FieldName = "concat_";
            this.colconcat_.Name = "colconcat_";
            this.colconcat_.Visible = true;
            this.colconcat_.VisibleIndex = 0;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(31, 80);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(209, 15);
            this.labelControl1.TabIndex = 47;
            this.labelControl1.Text = "Código de Categoria____________________";
            // 
            // categoariaselectBindingSource
            // 
            this.categoariaselectBindingSource.DataMember = "categoaria_select";
            this.categoariaselectBindingSource.DataSource = this.dsProductoTerminado1;
            // 
            // frmCRUD_PTClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 303);
            this.Controls.Add(this.grdTipo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.toggleSwitchEnablePT);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblTituloVentana);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmCRUD_PTClase";
            this.Text = "Gestion de Clases";
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchEnablePT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiaselectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductoTerminado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoariaselectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private System.Windows.Forms.TextBox txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchEnablePT;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblTituloVentana;
        private DevExpress.XtraEditors.GridLookUpEdit grdTipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dsProductoTerminado dsProductoTerminado1;
        private System.Windows.Forms.BindingSource familiaselectBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colconcat_;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private System.Windows.Forms.BindingSource categoariaselectBindingSource;
    }
}