namespace eDnevnik.UI
{
    partial class IzmijeniOcjenuForm
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
            this.ocjenaIdText = new System.Windows.Forms.TextBox();
            this.sacuvajOcjenuButton = new System.Windows.Forms.Button();
            this.ucenikLabel = new System.Windows.Forms.Label();
            this.ucenikInput = new System.Windows.Forms.ComboBox();
            this.ocjenaLabel = new System.Windows.Forms.Label();
            this.ocjenaInput = new System.Windows.Forms.TextBox();
            this.casIdText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ocjenaIdText
            // 
            this.ocjenaIdText.Location = new System.Drawing.Point(81, 7);
            this.ocjenaIdText.Name = "ocjenaIdText";
            this.ocjenaIdText.Size = new System.Drawing.Size(100, 20);
            this.ocjenaIdText.TabIndex = 26;
            this.ocjenaIdText.Visible = false;
            // 
            // sacuvajOcjenuButton
            // 
            this.sacuvajOcjenuButton.Location = new System.Drawing.Point(206, 70);
            this.sacuvajOcjenuButton.Name = "sacuvajOcjenuButton";
            this.sacuvajOcjenuButton.Size = new System.Drawing.Size(75, 23);
            this.sacuvajOcjenuButton.TabIndex = 25;
            this.sacuvajOcjenuButton.Text = "Sačuvaj";
            this.sacuvajOcjenuButton.UseVisualStyleBackColor = true;
            this.sacuvajOcjenuButton.Click += new System.EventHandler(this.sacuvajOcjenuButton_Click);
            // 
            // ucenikLabel
            // 
            this.ucenikLabel.AutoSize = true;
            this.ucenikLabel.Location = new System.Drawing.Point(13, 20);
            this.ucenikLabel.Name = "ucenikLabel";
            this.ucenikLabel.Size = new System.Drawing.Size(41, 13);
            this.ucenikLabel.TabIndex = 24;
            this.ucenikLabel.Text = "Ucenik";
            // 
            // ucenikInput
            // 
            this.ucenikInput.FormattingEnabled = true;
            this.ucenikInput.Location = new System.Drawing.Point(81, 17);
            this.ucenikInput.Name = "ucenikInput";
            this.ucenikInput.Size = new System.Drawing.Size(200, 21);
            this.ucenikInput.TabIndex = 23;
            // 
            // ocjenaLabel
            // 
            this.ocjenaLabel.AutoSize = true;
            this.ocjenaLabel.Location = new System.Drawing.Point(13, 47);
            this.ocjenaLabel.Name = "ocjenaLabel";
            this.ocjenaLabel.Size = new System.Drawing.Size(41, 13);
            this.ocjenaLabel.TabIndex = 22;
            this.ocjenaLabel.Text = "Ocjena";
            // 
            // ocjenaInput
            // 
            this.ocjenaInput.Location = new System.Drawing.Point(81, 44);
            this.ocjenaInput.Name = "ocjenaInput";
            this.ocjenaInput.Size = new System.Drawing.Size(200, 20);
            this.ocjenaInput.TabIndex = 21;
            // 
            // casIdText
            // 
            this.casIdText.Location = new System.Drawing.Point(188, 7);
            this.casIdText.Name = "casIdText";
            this.casIdText.Size = new System.Drawing.Size(100, 20);
            this.casIdText.TabIndex = 27;
            this.casIdText.Visible = false;
            // 
            // IzmijeniOcjenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 337);
            this.Controls.Add(this.casIdText);
            this.Controls.Add(this.ocjenaIdText);
            this.Controls.Add(this.sacuvajOcjenuButton);
            this.Controls.Add(this.ucenikLabel);
            this.Controls.Add(this.ucenikInput);
            this.Controls.Add(this.ocjenaLabel);
            this.Controls.Add(this.ocjenaInput);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IzmijeniOcjenuForm";
            this.ShowIcon = false;
            this.Text = "Izmijena ocjene";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ocjenaIdText;
        private System.Windows.Forms.Button sacuvajOcjenuButton;
        private System.Windows.Forms.Label ucenikLabel;
        private System.Windows.Forms.ComboBox ucenikInput;
        private System.Windows.Forms.Label ocjenaLabel;
        private System.Windows.Forms.TextBox ocjenaInput;
        private System.Windows.Forms.TextBox casIdText;
    }
}