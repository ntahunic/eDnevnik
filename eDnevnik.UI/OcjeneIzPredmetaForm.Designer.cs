namespace eDnevnik.UI
{
    partial class OcjeneIzPredmetaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.predmetiInput = new System.Windows.Forms.ComboBox();
            this.generisiIzvjestajButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Predmet";
            // 
            // predmetiInput
            // 
            this.predmetiInput.FormattingEnabled = true;
            this.predmetiInput.Location = new System.Drawing.Point(123, 26);
            this.predmetiInput.Name = "predmetiInput";
            this.predmetiInput.Size = new System.Drawing.Size(200, 21);
            this.predmetiInput.TabIndex = 8;
            // 
            // generisiIzvjestajButton
            // 
            this.generisiIzvjestajButton.Location = new System.Drawing.Point(211, 53);
            this.generisiIzvjestajButton.Name = "generisiIzvjestajButton";
            this.generisiIzvjestajButton.Size = new System.Drawing.Size(112, 23);
            this.generisiIzvjestajButton.TabIndex = 10;
            this.generisiIzvjestajButton.Text = "Generisi izvjestaj";
            this.generisiIzvjestajButton.UseVisualStyleBackColor = true;
            this.generisiIzvjestajButton.Click += new System.EventHandler(this.generisiIzvjestajButton_Click);
            // 
            // OcjeneIzPredmetaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 110);
            this.Controls.Add(this.generisiIzvjestajButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.predmetiInput);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OcjeneIzPredmetaForm";
            this.ShowIcon = false;
            this.Text = "Ocjene Iz Predmeta";
            this.Load += new System.EventHandler(this.OcjeneIzPredmetaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox predmetiInput;
        private System.Windows.Forms.Button generisiIzvjestajButton;
    }
}