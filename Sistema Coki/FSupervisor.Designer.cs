namespace Sistema_Coki
{
    partial class FSupervisor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource32 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource31 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource33 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource34 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource35 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource36 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tabControlSuperadmin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dtProd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.producto_mas_vendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPrincipal = new Sistema_Coki.DataSetPrincipal();
            this.producto_proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mejores_vendedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mejores_clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mejores_fechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producto_mas_vendTableAdapter = new Sistema_Coki.DataSetPrincipalTableAdapters.producto_mas_vendTableAdapter();
            this.mejores_vendedoresTableAdapter = new Sistema_Coki.DataSetPrincipalTableAdapters.mejores_vendedoresTableAdapter();
            this.mejores_clientesTableAdapter = new Sistema_Coki.DataSetPrincipalTableAdapters.mejores_clientesTableAdapter();
            this.mejores_fechasTableAdapter = new Sistema_Coki.DataSetPrincipalTableAdapters.mejores_fechasTableAdapter();
            this.producto_proveedorTableAdapter = new Sistema_Coki.DataSetPrincipalTableAdapters.producto_proveedorTableAdapter();
            this.dataSetPrincipal1 = new Sistema_Coki.DataSetPrincipal();
            this.productofechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producto_fechaTableAdapter = new Sistema_Coki.DataSetPrincipalTableAdapters.producto_fechaTableAdapter();
            this.reportViewer6 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.producto_fechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControlSuperadmin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producto_mas_vendBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producto_proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mejores_vendedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mejores_clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mejores_fechasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productofechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producto_fechaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion ";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.CerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verManualToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // verManualToolStripMenuItem
            // 
            this.verManualToolStripMenuItem.Name = "verManualToolStripMenuItem";
            this.verManualToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.verManualToolStripMenuItem.Text = "Ver manual ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUser.Location = new System.Drawing.Point(794, 6);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(11, 15);
            this.lblUser.TabIndex = 41;
            this.lblUser.Text = "-";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsuario.Location = new System.Drawing.Point(739, 6);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 15);
            this.lblUsuario.TabIndex = 40;
            this.lblUsuario.Text = "Usuario: ";
            // 
            // tabControlSuperadmin
            // 
            this.tabControlSuperadmin.Controls.Add(this.tabPage1);
            this.tabControlSuperadmin.Controls.Add(this.tabPage2);
            this.tabControlSuperadmin.Controls.Add(this.tabPage3);
            this.tabControlSuperadmin.Controls.Add(this.tabPage4);
            this.tabControlSuperadmin.Controls.Add(this.tabPage5);
            this.tabControlSuperadmin.Controls.Add(this.tabPage6);
            this.tabControlSuperadmin.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSuperadmin.Location = new System.Drawing.Point(0, 41);
            this.tabControlSuperadmin.Name = "tabControlSuperadmin";
            this.tabControlSuperadmin.SelectedIndex = 0;
            this.tabControlSuperadmin.Size = new System.Drawing.Size(1084, 619);
            this.tabControlSuperadmin.TabIndex = 42;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1076, 590);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Productos mas vendidos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource32.Name = "DataSetFSProdMasVend";
            reportDataSource32.Value = this.producto_mas_vendBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource32);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Sistema_Coki.FSProdMasVend.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1070, 584);
            this.reportViewer2.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.cbProveedor);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.reportViewer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1076, 590);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Prod por Proveedor";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // cbProveedor
            // 
            this.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(41, 100);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(171, 24);
            this.cbProveedor.TabIndex = 2;
            this.cbProveedor.SelectedIndexChanged += new System.EventHandler(this.cbProveedor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proveedor:";
            // 
            // reportViewer1
            // 
            reportDataSource31.Name = "DataSetFSProdPorProveed";
            reportDataSource31.Value = this.producto_proveedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource31);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Coki.FSProdPorProveed.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(279, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(797, 590);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1076, 590);
            this.tabPage3.TabIndex = 7;
            this.tabPage3.Text = "Mejores Vendedores";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource33.Name = "DataSetFSMejoresVended";
            reportDataSource33.Value = this.mejores_vendedoresBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource33);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Sistema_Coki.FSMejoresVended.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(3, 3);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1070, 584);
            this.reportViewer3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1076, 590);
            this.tabPage4.TabIndex = 8;
            this.tabPage4.Text = "Mejores Clientes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource34.Name = "DataSetFSMejoresClien";
            reportDataSource34.Value = this.mejores_clientesBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource34);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "Sistema_Coki.FSMejoresClientes.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(3, 3);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(1070, 584);
            this.reportViewer4.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reportViewer5);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1076, 590);
            this.tabPage5.TabIndex = 9;
            this.tabPage5.Text = "Ventas por Fecha";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // reportViewer5
            // 
            this.reportViewer5.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource35.Name = "DataSetFSVentasPorFecha";
            reportDataSource35.Value = this.mejores_fechasBindingSource;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource35);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "Sistema_Coki.FSVentasPorFecha.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(3, 3);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.ServerReport.BearerToken = null;
            this.reportViewer5.Size = new System.Drawing.Size(1070, 584);
            this.reportViewer5.TabIndex = 0;
            this.reportViewer5.Load += new System.EventHandler(this.reportViewer5_Load);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.reportViewer6);
            this.tabPage6.Controls.Add(this.dtProd);
            this.tabPage6.Controls.Add(this.label2);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1076, 590);
            this.tabPage6.TabIndex = 10;
            this.tabPage6.Text = "Productos por Fecha";
            this.tabPage6.UseVisualStyleBackColor = true;
            this.tabPage6.Click += new System.EventHandler(this.tabPage6_Click);
            // 
            // dtProd
            // 
            this.dtProd.Location = new System.Drawing.Point(24, 99);
            this.dtProd.Name = "dtProd";
            this.dtProd.Size = new System.Drawing.Size(232, 24);
            this.dtProd.TabIndex = 5;
            this.dtProd.ValueChanged += new System.EventHandler(this.dtProd_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha:";
            // 
            // producto_mas_vendBindingSource
            // 
            this.producto_mas_vendBindingSource.DataMember = "producto_mas_vend";
            this.producto_mas_vendBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // DataSetPrincipal
            // 
            this.DataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.DataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // producto_proveedorBindingSource
            // 
            this.producto_proveedorBindingSource.DataMember = "producto_proveedor";
            this.producto_proveedorBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // mejores_vendedoresBindingSource
            // 
            this.mejores_vendedoresBindingSource.DataMember = "mejores_vendedores";
            this.mejores_vendedoresBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // mejores_clientesBindingSource
            // 
            this.mejores_clientesBindingSource.DataMember = "mejores_clientes";
            this.mejores_clientesBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // mejores_fechasBindingSource
            // 
            this.mejores_fechasBindingSource.DataMember = "mejores_fechas";
            this.mejores_fechasBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // producto_mas_vendTableAdapter
            // 
            this.producto_mas_vendTableAdapter.ClearBeforeFill = true;
            // 
            // mejores_vendedoresTableAdapter
            // 
            this.mejores_vendedoresTableAdapter.ClearBeforeFill = true;
            // 
            // mejores_clientesTableAdapter
            // 
            this.mejores_clientesTableAdapter.ClearBeforeFill = true;
            // 
            // mejores_fechasTableAdapter
            // 
            this.mejores_fechasTableAdapter.ClearBeforeFill = true;
            // 
            // producto_proveedorTableAdapter
            // 
            this.producto_proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetPrincipal1
            // 
            this.dataSetPrincipal1.DataSetName = "DataSetPrincipal";
            this.dataSetPrincipal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productofechaBindingSource
            // 
            this.productofechaBindingSource.DataMember = "producto_fecha";
            this.productofechaBindingSource.DataSource = this.dataSetPrincipal1;
            // 
            // producto_fechaTableAdapter
            // 
            this.producto_fechaTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer6
            // 
            reportDataSource36.Name = "DataSetFSProdPorFecha";
            reportDataSource36.Value = this.producto_fechaBindingSource;
            this.reportViewer6.LocalReport.DataSources.Add(reportDataSource36);
            this.reportViewer6.LocalReport.ReportEmbeddedResource = "Sistema_Coki.FSProdPorFecha.rdlc";
            this.reportViewer6.Location = new System.Drawing.Point(282, 0);
            this.reportViewer6.Name = "reportViewer6";
            this.reportViewer6.ServerReport.BearerToken = null;
            this.reportViewer6.Size = new System.Drawing.Size(794, 590);
            this.reportViewer6.TabIndex = 6;
            // 
            // producto_fechaBindingSource
            // 
            this.producto_fechaBindingSource.DataMember = "producto_fecha";
            this.producto_fechaBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.tabControlSuperadmin);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FSupervisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supervisor";
            this.Load += new System.EventHandler(this.FSupervisor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlSuperadmin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producto_mas_vendBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producto_proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mejores_vendedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mejores_clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mejores_fechasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productofechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producto_fechaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verManualToolStripMenuItem;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TabControl tabControlSuperadmin;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private System.Windows.Forms.BindingSource producto_mas_vendBindingSource;
        private DataSetPrincipal DataSetPrincipal;
        private DataSetPrincipalTableAdapters.producto_mas_vendTableAdapter producto_mas_vendTableAdapter;
        private System.Windows.Forms.BindingSource mejores_vendedoresBindingSource;
        private DataSetPrincipalTableAdapters.mejores_vendedoresTableAdapter mejores_vendedoresTableAdapter;
        private System.Windows.Forms.BindingSource mejores_clientesBindingSource;
        private DataSetPrincipalTableAdapters.mejores_clientesTableAdapter mejores_clientesTableAdapter;
        private System.Windows.Forms.BindingSource mejores_fechasBindingSource;
        private DataSetPrincipalTableAdapters.mejores_fechasTableAdapter mejores_fechasTableAdapter;
        private System.Windows.Forms.BindingSource producto_proveedorBindingSource;
        private DataSetPrincipalTableAdapters.producto_proveedorTableAdapter producto_proveedorTableAdapter;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DateTimePicker dtProd;
        private System.Windows.Forms.Label label2;
        private DataSetPrincipal dataSetPrincipal1;
        private System.Windows.Forms.BindingSource productofechaBindingSource;
        private DataSetPrincipalTableAdapters.producto_fechaTableAdapter producto_fechaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer6;
        private System.Windows.Forms.BindingSource producto_fechaBindingSource;
        private System.Windows.Forms.Button button1;
    }
}