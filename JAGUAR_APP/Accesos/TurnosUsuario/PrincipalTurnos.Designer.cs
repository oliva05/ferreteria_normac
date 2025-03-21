﻿
namespace JAGUAR_PRO.Accesos.TurnosUsuario
{
    partial class PrincipalTurnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalTurnos));
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlSistemas = new DevExpress.XtraGrid.GridControl();
            this.turnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAccesos = new JAGUAR_PRO.Accesos.dsAccesos();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Habilitado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSistemas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(99, 94);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(87, 28);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Editar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(5, 94);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(87, 28);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Crear";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControlSistemas
            // 
            this.gridControlSistemas.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridControlSistemas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlSistemas.DataSource = this.turnoBindingSource;
            this.gridControlSistemas.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlSistemas.Location = new System.Drawing.Point(1, 129);
            this.gridControlSistemas.MainView = this.gridView1;
            this.gridControlSistemas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlSistemas.Name = "gridControlSistemas";
            this.gridControlSistemas.Size = new System.Drawing.Size(961, 542);
            this.gridControlSistemas.TabIndex = 3;
            this.gridControlSistemas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // turnoBindingSource
            // 
            this.turnoBindingSource.DataMember = "Turno";
            this.turnoBindingSource.DataSource = this.dsAccesos;
            // 
            // dsAccesos
            // 
            this.dsAccesos.DataSetName = "dsAccesos";
            this.dsAccesos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Nombre,
            this.Habilitado,
            this.Codigo});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControlSistemas;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "id";
            this.Id.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Id.ImageOptions.Image")));
            this.Id.MinWidth = 23;
            this.Id.Name = "Id";
            this.Id.OptionsColumn.AllowEdit = false;
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            this.Id.Width = 112;
            // 
            // Nombre
            // 
            this.Nombre.Caption = "Turno";
            this.Nombre.FieldName = "descripcion";
            this.Nombre.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Nombre.ImageOptions.Image")));
            this.Nombre.MinWidth = 23;
            this.Nombre.Name = "Nombre";
            this.Nombre.OptionsColumn.AllowEdit = false;
            this.Nombre.Visible = true;
            this.Nombre.VisibleIndex = 1;
            this.Nombre.Width = 450;
            // 
            // Habilitado
            // 
            this.Habilitado.Caption = "Habilitado";
            this.Habilitado.FieldName = "enable";
            this.Habilitado.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Habilitado.ImageOptions.Image")));
            this.Habilitado.MinWidth = 23;
            this.Habilitado.Name = "Habilitado";
            this.Habilitado.OptionsColumn.AllowEdit = false;
            this.Habilitado.Visible = true;
            this.Habilitado.VisibleIndex = 2;
            this.Habilitado.Width = 231;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Codigo";
            this.Codigo.FieldName = "codigo";
            this.Codigo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Codigo.ImageOptions.Image")));
            this.Codigo.MinWidth = 23;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 147;
            // 
            // PrincipalTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 674);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControlSistemas);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PrincipalTurnos";
            this.Text = "Gestion Turnos";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSistemas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControlSistemas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn Habilitado;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private System.Windows.Forms.BindingSource turnoBindingSource;
        private dsAccesos dsAccesos;
    }
}