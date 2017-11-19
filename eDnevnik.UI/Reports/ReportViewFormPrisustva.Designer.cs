namespace eDnevnik.UI.Reports
{
    partial class ReportViewFormPrisustva
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
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.generisiIzvjestajButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.predmetiInput = new System.Windows.Forms.ComboBox();
            this.prisustvoVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.prisustvoVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "eDnevnik.UI.Reports.IzostanciPoUceniku.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 68);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(732, 381);
            this.reportViewer2.TabIndex = 0;
            // 
            // generisiIzvjestajButton
            // 
            this.generisiIzvjestajButton.Location = new System.Drawing.Point(160, 38);
            this.generisiIzvjestajButton.Name = "generisiIzvjestajButton";
            this.generisiIzvjestajButton.Size = new System.Drawing.Size(112, 23);
            this.generisiIzvjestajButton.TabIndex = 16;
            this.generisiIzvjestajButton.Text = "Generisi izvjestaj";
            this.generisiIzvjestajButton.UseVisualStyleBackColor = true;
            this.generisiIzvjestajButton.Click += new System.EventHandler(this.generisiIzvjestajButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Predmet";
            // 
            // predmetiInput
            // 
            this.predmetiInput.FormattingEnabled = true;
            this.predmetiInput.Location = new System.Drawing.Point(72, 12);
            this.predmetiInput.Name = "predmetiInput";
            this.predmetiInput.Size = new System.Drawing.Size(200, 21);
            this.predmetiInput.TabIndex = 14;
            // 
            // prisustvoVMBindingSource
            // 
            this.prisustvoVMBindingSource.DataSource = typeof(eDnevnik.API.Models.PrisustvoVM);
            // 
            // ReportViewFormPrisustva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 449);
            this.Controls.Add(this.generisiIzvjestajButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.predmetiInput);
            this.Controls.Add(this.reportViewer2);
            this.Name = "ReportViewFormPrisustva";
            this.Text = "Prisustva Report";
            this.Load += new System.EventHandler(this.ReportViewFormPrisustva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prisustvoVMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource prisustvoVMBindingSource;
        private System.Windows.Forms.Button generisiIzvjestajButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox predmetiInput;
    }
}