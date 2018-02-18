namespace eDnevnik.UI
{
    partial class ReportViewFormUcenici
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
            this.UcenikVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.razredInput = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.generisiIzvjestajButton = new System.Windows.Forms.Button();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.UcenikVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UcenikVMBindingSource
            // 
            this.UcenikVMBindingSource.DataSource = typeof(eDnevnik.API.Models.UcenikVM);
            // 
            // razredInput
            // 
            this.razredInput.FormattingEnabled = true;
            this.razredInput.Location = new System.Drawing.Point(59, 12);
            this.razredInput.Name = "razredInput";
            this.razredInput.Size = new System.Drawing.Size(198, 21);
            this.razredInput.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Razred";
            // 
            // generisiIzvjestajButton
            // 
            this.generisiIzvjestajButton.Location = new System.Drawing.Point(145, 37);
            this.generisiIzvjestajButton.Name = "generisiIzvjestajButton";
            this.generisiIzvjestajButton.Size = new System.Drawing.Size(112, 23);
            this.generisiIzvjestajButton.TabIndex = 47;
            this.generisiIzvjestajButton.Text = "Generisi izvjestaj";
            this.generisiIzvjestajButton.UseVisualStyleBackColor = true;
            this.generisiIzvjestajButton.Click += new System.EventHandler(this.generisiIzvjestajButton_Click);
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "UcenikVM";
            reportDataSource1.Value = this.UcenikVMBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "eDnevnik.UI.Reports.UceniciURazredu.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 66);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(606, 570);
            this.reportViewer3.TabIndex = 48;
            // 
            // ReportViewFormUcenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 636);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.generisiIzvjestajButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.razredInput);
            this.Name = "ReportViewFormUcenici";
            this.Text = "Ucenici Report";
            this.Load += new System.EventHandler(this.ReportViewFormUcenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UcenikVMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox razredInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button generisiIzvjestajButton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource UcenikVMBindingSource;
    }
}