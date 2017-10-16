namespace eDnevnik.UI
{
    partial class DodajOcjenuForm
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
            this.ocjenaLabel = new System.Windows.Forms.Label();
            this.ocjenaInput = new System.Windows.Forms.TextBox();
            this.casoviGridView = new System.Windows.Forms.DataGridView();
            this.CasId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nastavnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojSati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucenikInput = new System.Windows.Forms.ComboBox();
            this.ucenikLabel = new System.Windows.Forms.Label();
            this.preuzmiUcenikeButton = new System.Windows.Forms.Button();
            this.sacuvajOcjenuButton = new System.Windows.Forms.Button();
            this.ocjenaIdText = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.casoviGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ocjenaLabel
            // 
            this.ocjenaLabel.AutoSize = true;
            this.ocjenaLabel.Location = new System.Drawing.Point(16, 50);
            this.ocjenaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ocjenaLabel.Name = "ocjenaLabel";
            this.ocjenaLabel.Size = new System.Drawing.Size(53, 17);
            this.ocjenaLabel.TabIndex = 13;
            this.ocjenaLabel.Text = "Ocjena";
            // 
            // ocjenaInput
            // 
            this.ocjenaInput.Location = new System.Drawing.Point(107, 47);
            this.ocjenaInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ocjenaInput.Name = "ocjenaInput";
            this.ocjenaInput.Size = new System.Drawing.Size(265, 22);
            this.ocjenaInput.TabIndex = 10;
            this.ocjenaInput.Validating += new System.ComponentModel.CancelEventHandler(this.ocjenaInput_Validating);
            // 
            // casoviGridView
            // 
            this.casoviGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.casoviGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CasId,
            this.Datum,
            this.Nastavnik,
            this.Predmet,
            this.BrojSati});
            this.casoviGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.casoviGridView.Location = new System.Drawing.Point(0, 150);
            this.casoviGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.casoviGridView.Name = "casoviGridView";
            this.casoviGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.casoviGridView.Size = new System.Drawing.Size(664, 265);
            this.casoviGridView.TabIndex = 15;
            // 
            // CasId
            // 
            this.CasId.DataPropertyName = "CasId";
            this.CasId.HeaderText = "CasId";
            this.CasId.Name = "CasId";
            this.CasId.ReadOnly = true;
            this.CasId.Visible = false;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Nastavnik
            // 
            this.Nastavnik.DataPropertyName = "Nastavnik";
            this.Nastavnik.HeaderText = "Nastavnik";
            this.Nastavnik.Name = "Nastavnik";
            this.Nastavnik.ReadOnly = true;
            // 
            // Predmet
            // 
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // BrojSati
            // 
            this.BrojSati.DataPropertyName = "BrojSati";
            this.BrojSati.HeaderText = "Broj sati";
            this.BrojSati.Name = "BrojSati";
            this.BrojSati.ReadOnly = true;
            // 
            // ucenikInput
            // 
            this.ucenikInput.FormattingEnabled = true;
            this.ucenikInput.Location = new System.Drawing.Point(107, 14);
            this.ucenikInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucenikInput.Name = "ucenikInput";
            this.ucenikInput.Size = new System.Drawing.Size(265, 24);
            this.ucenikInput.TabIndex = 16;
            this.ucenikInput.Validating += new System.ComponentModel.CancelEventHandler(this.ucenikInput_Validating);
            // 
            // ucenikLabel
            // 
            this.ucenikLabel.AutoSize = true;
            this.ucenikLabel.Location = new System.Drawing.Point(16, 17);
            this.ucenikLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ucenikLabel.Name = "ucenikLabel";
            this.ucenikLabel.Size = new System.Drawing.Size(51, 17);
            this.ucenikLabel.TabIndex = 17;
            this.ucenikLabel.Text = "Ucenik";
            // 
            // preuzmiUcenikeButton
            // 
            this.preuzmiUcenikeButton.Location = new System.Drawing.Point(515, 114);
            this.preuzmiUcenikeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.preuzmiUcenikeButton.Name = "preuzmiUcenikeButton";
            this.preuzmiUcenikeButton.Size = new System.Drawing.Size(133, 28);
            this.preuzmiUcenikeButton.TabIndex = 18;
            this.preuzmiUcenikeButton.Text = "Preuzmi učenike";
            this.preuzmiUcenikeButton.UseVisualStyleBackColor = true;
            this.preuzmiUcenikeButton.Click += new System.EventHandler(this.preuzmiUcenikeButton_Click);
            // 
            // sacuvajOcjenuButton
            // 
            this.sacuvajOcjenuButton.Location = new System.Drawing.Point(273, 79);
            this.sacuvajOcjenuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sacuvajOcjenuButton.Name = "sacuvajOcjenuButton";
            this.sacuvajOcjenuButton.Size = new System.Drawing.Size(100, 28);
            this.sacuvajOcjenuButton.TabIndex = 19;
            this.sacuvajOcjenuButton.Text = "Sačuvaj";
            this.sacuvajOcjenuButton.UseVisualStyleBackColor = true;
            this.sacuvajOcjenuButton.Click += new System.EventHandler(this.sacuvajOcjenuButton_Click);
            // 
            // ocjenaIdText
            // 
            this.ocjenaIdText.Location = new System.Drawing.Point(107, 1);
            this.ocjenaIdText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ocjenaIdText.Name = "ocjenaIdText";
            this.ocjenaIdText.Size = new System.Drawing.Size(132, 22);
            this.ocjenaIdText.TabIndex = 20;
            this.ocjenaIdText.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DodajOcjenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 415);
            this.Controls.Add(this.ocjenaIdText);
            this.Controls.Add(this.sacuvajOcjenuButton);
            this.Controls.Add(this.preuzmiUcenikeButton);
            this.Controls.Add(this.ucenikLabel);
            this.Controls.Add(this.ucenikInput);
            this.Controls.Add(this.casoviGridView);
            this.Controls.Add(this.ocjenaLabel);
            this.Controls.Add(this.ocjenaInput);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajOcjenuForm";
            this.ShowIcon = false;
            this.Text = "Dodaj ocjenu";
            this.Load += new System.EventHandler(this.DodajOcjenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.casoviGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ocjenaLabel;
        private System.Windows.Forms.TextBox ocjenaInput;
        private System.Windows.Forms.DataGridView casoviGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CasId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nastavnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojSati;
        private System.Windows.Forms.ComboBox ucenikInput;
        private System.Windows.Forms.Label ucenikLabel;
        private System.Windows.Forms.Button preuzmiUcenikeButton;
        private System.Windows.Forms.Button sacuvajOcjenuButton;
        private System.Windows.Forms.TextBox ocjenaIdText;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}