﻿
namespace TP_PAV1
{
    partial class FormListados
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.LocalesXTipoComercioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LocalesXTipoComercio = new TP_PAV1.LocalesXTipoComercio();
            this.Agus1 = new System.Windows.Forms.TabControl();
            this.ArticulosPorRubro = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.articulosPorLocal = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Fede1 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Fede2 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.LocalesXTipoComercioTableAdapter = new TP_PAV1.LocalesXTipoComercioTableAdapters.LocalesXTipoComercioTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.tarjetasXCliente = new TP_PAV1.TarjetasXCliente();
            this.tarjetasXClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VehiculosXClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VehiculosXCliente = new TP_PAV1.VehiculosXCliente();
            ((System.ComponentModel.ISupportInitialize)(this.LocalesXTipoComercioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocalesXTipoComercio)).BeginInit();
            this.Agus1.SuspendLayout();
            this.ArticulosPorRubro.SuspendLayout();
            this.articulosPorLocal.SuspendLayout();
            this.Fede1.SuspendLayout();
            this.Fede2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetasXCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetasXClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosXClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosXCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // LocalesXTipoComercioBindingSource
            // 
            this.LocalesXTipoComercioBindingSource.DataMember = "LocalesXTipoComercio";
            this.LocalesXTipoComercioBindingSource.DataSource = this.LocalesXTipoComercio;
            // 
            // LocalesXTipoComercio
            // 
            this.LocalesXTipoComercio.DataSetName = "LocalesXTipoComercio";
            this.LocalesXTipoComercio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Agus1
            // 
            this.Agus1.Controls.Add(this.ArticulosPorRubro);
            this.Agus1.Controls.Add(this.articulosPorLocal);
            this.Agus1.Controls.Add(this.Fede1);
            this.Agus1.Controls.Add(this.Fede2);
            this.Agus1.Controls.Add(this.tabPage1);
            this.Agus1.Controls.Add(this.tabPage2);
            this.Agus1.Controls.Add(this.tabPage3);
            this.Agus1.Controls.Add(this.tabPage4);
            this.Agus1.Controls.Add(this.tabPage5);
            this.Agus1.Controls.Add(this.tabPage6);
            this.Agus1.ItemSize = new System.Drawing.Size(169, 18);
            this.Agus1.Location = new System.Drawing.Point(12, 54);
            this.Agus1.Name = "Agus1";
            this.Agus1.SelectedIndex = 0;
            this.Agus1.Size = new System.Drawing.Size(531, 574);
            this.Agus1.TabIndex = 0;
            // 
            // ArticulosPorRubro
            // 
            this.ArticulosPorRubro.Controls.Add(this.reportViewer1);
            this.ArticulosPorRubro.Location = new System.Drawing.Point(4, 22);
            this.ArticulosPorRubro.Name = "ArticulosPorRubro";
            this.ArticulosPorRubro.Padding = new System.Windows.Forms.Padding(3);
            this.ArticulosPorRubro.Size = new System.Drawing.Size(523, 548);
            this.ArticulosPorRubro.TabIndex = 0;
            this.ArticulosPorRubro.Text = "Miguel1";
            this.ArticulosPorRubro.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 32;
            reportDataSource1.Name = "TarjetasXCliente";
            reportDataSource1.Value = this.tarjetasXClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_PAV1.miguel1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(517, 542);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // articulosPorLocal
            // 
            this.articulosPorLocal.Controls.Add(this.reportViewer2);
            this.articulosPorLocal.Location = new System.Drawing.Point(4, 22);
            this.articulosPorLocal.Name = "articulosPorLocal";
            this.articulosPorLocal.Padding = new System.Windows.Forms.Padding(3);
            this.articulosPorLocal.Size = new System.Drawing.Size(523, 548);
            this.articulosPorLocal.TabIndex = 1;
            this.articulosPorLocal.Text = "Miguel2";
            this.articulosPorLocal.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "VehiculosXCliente";
            reportDataSource2.Value = this.VehiculosXClienteBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "TP_PAV1.miguel2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(517, 542);
            this.reportViewer2.TabIndex = 0;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // Fede1
            // 
            this.Fede1.Controls.Add(this.reportViewer3);
            this.Fede1.Location = new System.Drawing.Point(4, 22);
            this.Fede1.Name = "Fede1";
            this.Fede1.Padding = new System.Windows.Forms.Padding(3);
            this.Fede1.Size = new System.Drawing.Size(523, 548);
            this.Fede1.TabIndex = 2;
            this.Fede1.Text = "Agus1";
            this.Fede1.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "ArticulosXRubro";
            reportDataSource3.Value = this.LocalesXTipoComercioBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "TP_PAV1.ReporteArticulosPorRubro.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(3, 3);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(517, 542);
            this.reportViewer3.TabIndex = 0;
            this.reportViewer3.Load += new System.EventHandler(this.reportViewer3_Load);
            // 
            // Fede2
            // 
            this.Fede2.Controls.Add(this.reportViewer4);
            this.Fede2.Location = new System.Drawing.Point(4, 22);
            this.Fede2.Name = "Fede2";
            this.Fede2.Padding = new System.Windows.Forms.Padding(3);
            this.Fede2.Size = new System.Drawing.Size(523, 548);
            this.Fede2.TabIndex = 3;
            this.Fede2.Text = "Agus2";
            this.Fede2.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "TP_PAV1.ReporteArticulosPorLocal.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(3, 3);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(517, 542);
            this.reportViewer4.TabIndex = 0;
            this.reportViewer4.Load += new System.EventHandler(this.reportViewer4_Load_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(523, 548);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Geri1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(523, 548);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "Geri2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(523, 548);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "Pola1";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(523, 548);
            this.tabPage4.TabIndex = 7;
            this.tabPage4.Text = "Pola2";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(523, 548);
            this.tabPage5.TabIndex = 8;
            this.tabPage5.Text = "Fede1";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(523, 548);
            this.tabPage6.TabIndex = 9;
            this.tabPage6.Text = "Fede2";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // LocalesXTipoComercioTableAdapter
            // 
            this.LocalesXTipoComercioTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(233, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Listados";
            // 
            // tarjetasXCliente
            // 
            this.tarjetasXCliente.DataSetName = "TarjetasXCliente";
            this.tarjetasXCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tarjetasXClienteBindingSource
            // 
            this.tarjetasXClienteBindingSource.DataSource = this.tarjetasXCliente;
            this.tarjetasXClienteBindingSource.Position = 0;
            // 
            // VehiculosXClienteBindingSource
            // 
            this.VehiculosXClienteBindingSource.DataMember = "VehiculosXCliente";
            this.VehiculosXClienteBindingSource.DataSource = this.VehiculosXCliente;
            // 
            // VehiculosXCliente
            // 
            this.VehiculosXCliente.DataSetName = "VehiculosXCliente";
            this.VehiculosXCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormListados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(555, 640);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Agus1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(555, 590);
            this.Name = "FormListados";
            this.Text = "FormListados";
            this.Load += new System.EventHandler(this.FormListados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LocalesXTipoComercioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocalesXTipoComercio)).EndInit();
            this.Agus1.ResumeLayout(false);
            this.ArticulosPorRubro.ResumeLayout(false);
            this.articulosPorLocal.ResumeLayout(false);
            this.Fede1.ResumeLayout(false);
            this.Fede2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tarjetasXCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetasXClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosXClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosXCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Agus1;
        private System.Windows.Forms.TabPage ArticulosPorRubro;
        private System.Windows.Forms.TabPage articulosPorLocal;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.TabPage Fede1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.TabPage Fede2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource LocalesXTipoComercioBindingSource;
        private LocalesXTipoComercio LocalesXTipoComercio;
        private LocalesXTipoComercioTableAdapters.LocalesXTipoComercioTableAdapter LocalesXTipoComercioTableAdapter;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource tarjetasXClienteBindingSource;
        private TarjetasXCliente tarjetasXCliente;
        private System.Windows.Forms.BindingSource VehiculosXClienteBindingSource;
        private VehiculosXCliente VehiculosXCliente;
    }
}