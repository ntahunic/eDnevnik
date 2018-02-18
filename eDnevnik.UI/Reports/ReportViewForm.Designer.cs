namespace eDnevnik.UI.Reports
{
    partial class ReportViewForm
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
            this.OcjenaVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.generisiIzvjestajButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.predmetiInput = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.OcjenaVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OcjenaVMBindingSource
            // 
            this.OcjenaVMBindingSource.DataSource = typeof(eDnevnik.API.Models.OcjenaVM);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eDnevnik.UI.Reports.OcjenePoPredmetuReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 68);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(700, 644);
            this.reportViewer1.TabIndex = 0;
            // 
            // generisiIzvjestajButton
            // 
            this.generisiIzvjestajButton.Location = new System.Drawing.Point(157, 39);
            this.generisiIzvjestajButton.Name = "generisiIzvjestajButton";
            this.generisiIzvjestajButton.Size = new System.Drawing.Size(112, 23);
            this.generisiIzvjestajButton.TabIndex = 13;
            this.generisiIzvjestajButton.Text = "Generisi izvjestaj";
            this.generisiIzvjestajButton.UseVisualStyleBackColor = true;
            this.generisiIzvjestajButton.Click += new System.EventHandler(this.generisiIzvjestajButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Predmet";
            // 
            // predmetiInput
            // 
            this.predmetiInput.FormattingEnabled = true;
            this.predmetiInput.Location = new System.Drawing.Point(69, 12);
            this.predmetiInput.Name = "predmetiInput";
            this.predmetiInput.Size = new System.Drawing.Size(200, 21);
            this.predmetiInput.TabIndex = 11;
            // 
            // ReportViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 712);
            this.Controls.Add(this.generisiIzvjestajButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.predmetiInput);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportViewForm";
            this.ShowIcon = false;
            this.Text = "Ocjene Report";
            this.Load += new System.EventHandler(this.ReportViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OcjenaVMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OcjenaVMBindingSource;
        private System.Windows.Forms.Button generisiIzvjestajButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox predmetiInput;
    }
}