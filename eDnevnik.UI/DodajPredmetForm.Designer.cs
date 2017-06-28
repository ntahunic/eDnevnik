﻿namespace eDnevnik.UI
{
    partial class DodajPredmetForm
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
            this.akademskaGodinaInput = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nazivPredmetaInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nastavnikInput = new System.Windows.Forms.ComboBox();
            this.razredInput = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.predmetiGridView = new System.Windows.Forms.DataGridView();
            this.sacuvajPredmetButton = new System.Windows.Forms.Button();
            this.izmijeniPredmetButton = new System.Windows.Forms.Button();
            this.predmetIdText = new System.Windows.Forms.TextBox();
            this.PredmetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AkademskaGodina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nastavnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NastavnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazredId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AkademskaGodinaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.predmetiGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Akademska godina";
            // 
            // akademskaGodinaInput
            // 
            this.akademskaGodinaInput.FormattingEnabled = true;
            this.akademskaGodinaInput.Location = new System.Drawing.Point(112, 46);
            this.akademskaGodinaInput.Name = "akademskaGodinaInput";
            this.akademskaGodinaInput.Size = new System.Drawing.Size(200, 21);
            this.akademskaGodinaInput.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Naziv";
            // 
            // nazivPredmetaInput
            // 
            this.nazivPredmetaInput.Location = new System.Drawing.Point(112, 20);
            this.nazivPredmetaInput.Name = "nazivPredmetaInput";
            this.nazivPredmetaInput.Size = new System.Drawing.Size(200, 20);
            this.nazivPredmetaInput.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nastavnik";
            // 
            // nastavnikInput
            // 
            this.nastavnikInput.FormattingEnabled = true;
            this.nastavnikInput.Location = new System.Drawing.Point(112, 73);
            this.nastavnikInput.Name = "nastavnikInput";
            this.nastavnikInput.Size = new System.Drawing.Size(200, 21);
            this.nastavnikInput.TabIndex = 11;
            // 
            // razredInput
            // 
            this.razredInput.FormattingEnabled = true;
            this.razredInput.Location = new System.Drawing.Point(112, 99);
            this.razredInput.Name = "razredInput";
            this.razredInput.Size = new System.Drawing.Size(200, 21);
            this.razredInput.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Razred";
            // 
            // predmetiGridView
            // 
            this.predmetiGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.predmetiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.predmetiGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PredmetId,
            this.Naziv,
            this.AkademskaGodina,
            this.Nastavnik,
            this.Razred,
            this.Obrisi,
            this.NastavnikId,
            this.RazredId,
            this.AkademskaGodinaId});
            this.predmetiGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.predmetiGridView.Location = new System.Drawing.Point(0, 217);
            this.predmetiGridView.Name = "predmetiGridView";
            this.predmetiGridView.Size = new System.Drawing.Size(781, 108);
            this.predmetiGridView.TabIndex = 14;
            this.predmetiGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.predmetiGridView_CellContentClick);
            // 
            // sacuvajPredmetButton
            // 
            this.sacuvajPredmetButton.Location = new System.Drawing.Point(237, 126);
            this.sacuvajPredmetButton.Name = "sacuvajPredmetButton";
            this.sacuvajPredmetButton.Size = new System.Drawing.Size(75, 23);
            this.sacuvajPredmetButton.TabIndex = 15;
            this.sacuvajPredmetButton.Text = "Sačuvaj";
            this.sacuvajPredmetButton.UseVisualStyleBackColor = true;
            this.sacuvajPredmetButton.Click += new System.EventHandler(this.sacuvajPredmetButton_Click);
            // 
            // izmijeniPredmetButton
            // 
            this.izmijeniPredmetButton.Location = new System.Drawing.Point(694, 188);
            this.izmijeniPredmetButton.Name = "izmijeniPredmetButton";
            this.izmijeniPredmetButton.Size = new System.Drawing.Size(75, 23);
            this.izmijeniPredmetButton.TabIndex = 16;
            this.izmijeniPredmetButton.Text = "Izmijeni";
            this.izmijeniPredmetButton.UseVisualStyleBackColor = true;
            this.izmijeniPredmetButton.Click += new System.EventHandler(this.izmijeniPredmetButton_Click);
            // 
            // predmetIdText
            // 
            this.predmetIdText.Location = new System.Drawing.Point(112, 3);
            this.predmetIdText.Name = "predmetIdText";
            this.predmetIdText.Size = new System.Drawing.Size(100, 20);
            this.predmetIdText.TabIndex = 17;
            this.predmetIdText.Visible = false;
            // 
            // PredmetId
            // 
            this.PredmetId.DataPropertyName = "PredmetId";
            this.PredmetId.HeaderText = "PredmetId";
            this.PredmetId.Name = "PredmetId";
            this.PredmetId.ReadOnly = true;
            this.PredmetId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // AkademskaGodina
            // 
            this.AkademskaGodina.DataPropertyName = "AkademskaGodina";
            this.AkademskaGodina.HeaderText = "AkademskaGodina";
            this.AkademskaGodina.Name = "AkademskaGodina";
            this.AkademskaGodina.ReadOnly = true;
            // 
            // Nastavnik
            // 
            this.Nastavnik.DataPropertyName = "Nastavnik";
            this.Nastavnik.HeaderText = "Nastavnik";
            this.Nastavnik.Name = "Nastavnik";
            // 
            // Razred
            // 
            this.Razred.DataPropertyName = "Razred";
            this.Razred.HeaderText = "Razred";
            this.Razred.Name = "Razred";
            this.Razred.ReadOnly = true;
            // 
            // Obrisi
            // 
            this.Obrisi.HeaderText = "Obrisi";
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Obrisi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NastavnikId
            // 
            this.NastavnikId.DataPropertyName = "NastavnikId";
            this.NastavnikId.HeaderText = "NastavnikId";
            this.NastavnikId.Name = "NastavnikId";
            this.NastavnikId.ReadOnly = true;
            this.NastavnikId.Visible = false;
            // 
            // RazredId
            // 
            this.RazredId.DataPropertyName = "RazredId";
            this.RazredId.HeaderText = "RazredId";
            this.RazredId.Name = "RazredId";
            this.RazredId.ReadOnly = true;
            this.RazredId.Visible = false;
            // 
            // AkademskaGodinaId
            // 
            this.AkademskaGodinaId.DataPropertyName = "AkademskaGodinaId";
            this.AkademskaGodinaId.HeaderText = "AkademskaGodinaId";
            this.AkademskaGodinaId.Name = "AkademskaGodinaId";
            this.AkademskaGodinaId.ReadOnly = true;
            this.AkademskaGodinaId.Visible = false;
            // 
            // DodajPredmetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 325);
            this.Controls.Add(this.predmetIdText);
            this.Controls.Add(this.izmijeniPredmetButton);
            this.Controls.Add(this.sacuvajPredmetButton);
            this.Controls.Add(this.predmetiGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.razredInput);
            this.Controls.Add(this.nastavnikInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nazivPredmetaInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.akademskaGodinaInput);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajPredmetForm";
            this.ShowIcon = false;
            this.Text = "Dodaj predmet";
            this.Load += new System.EventHandler(this.DodajPredmetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.predmetiGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox akademskaGodinaInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nazivPredmetaInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox nastavnikInput;
        private System.Windows.Forms.ComboBox razredInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView predmetiGridView;
        private System.Windows.Forms.Button sacuvajPredmetButton;
        private System.Windows.Forms.Button izmijeniPredmetButton;
        private System.Windows.Forms.TextBox predmetIdText;
        private System.Windows.Forms.DataGridViewTextBoxColumn PredmetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn AkademskaGodina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nastavnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razred;
        private System.Windows.Forms.DataGridViewButtonColumn Obrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NastavnikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazredId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AkademskaGodinaId;
    }
}