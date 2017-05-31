namespace eDnevnik.UI
{
    partial class DodajIzostanakForm
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
            this.uceniciGridView = new System.Windows.Forms.DataGridView();
            this.dodajIzostanakButton = new System.Windows.Forms.Button();
            this.predmetReadOnly = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datumReadOnly = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.casIdTest = new System.Windows.Forms.TextBox();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UcenikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uceniciGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uceniciGridView
            // 
            this.uceniciGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uceniciGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Username,
            this.Password,
            this.Prezime,
            this.Razred,
            this.UcenikId});
            this.uceniciGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uceniciGridView.Location = new System.Drawing.Point(0, 98);
            this.uceniciGridView.Name = "uceniciGridView";
            this.uceniciGridView.Size = new System.Drawing.Size(495, 368);
            this.uceniciGridView.TabIndex = 0;
            // 
            // dodajIzostanakButton
            // 
            this.dodajIzostanakButton.Location = new System.Drawing.Point(377, 69);
            this.dodajIzostanakButton.Name = "dodajIzostanakButton";
            this.dodajIzostanakButton.Size = new System.Drawing.Size(106, 23);
            this.dodajIzostanakButton.TabIndex = 1;
            this.dodajIzostanakButton.Text = "Dodaj izostanak";
            this.dodajIzostanakButton.UseVisualStyleBackColor = true;
            this.dodajIzostanakButton.Click += new System.EventHandler(this.dodajIzostanakButton_Click);
            // 
            // predmetReadOnly
            // 
            this.predmetReadOnly.Location = new System.Drawing.Point(81, 9);
            this.predmetReadOnly.Name = "predmetReadOnly";
            this.predmetReadOnly.ReadOnly = true;
            this.predmetReadOnly.Size = new System.Drawing.Size(205, 20);
            this.predmetReadOnly.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Predmet";
            // 
            // datumReadOnly
            // 
            this.datumReadOnly.Location = new System.Drawing.Point(81, 35);
            this.datumReadOnly.Name = "datumReadOnly";
            this.datumReadOnly.ReadOnly = true;
            this.datumReadOnly.Size = new System.Drawing.Size(205, 20);
            this.datumReadOnly.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum";
            // 
            // casIdTest
            // 
            this.casIdTest.Location = new System.Drawing.Point(81, 61);
            this.casIdTest.Name = "casIdTest";
            this.casIdTest.ReadOnly = true;
            this.casIdTest.Size = new System.Drawing.Size(205, 20);
            this.casIdTest.TabIndex = 6;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Visible = false;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Razred
            // 
            this.Razred.DataPropertyName = "Razred";
            this.Razred.HeaderText = "Razred";
            this.Razred.Name = "Razred";
            this.Razred.ReadOnly = true;
            // 
            // UcenikId
            // 
            this.UcenikId.DataPropertyName = "UcenikId";
            this.UcenikId.HeaderText = "UcenikId";
            this.UcenikId.Name = "UcenikId";
            this.UcenikId.ReadOnly = true;
            this.UcenikId.Visible = false;
            // 
            // DodajIzostanakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 466);
            this.Controls.Add(this.casIdTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datumReadOnly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.predmetReadOnly);
            this.Controls.Add(this.dodajIzostanakButton);
            this.Controls.Add(this.uceniciGridView);
            this.Name = "DodajIzostanakForm";
            this.Text = "DodajIzostanakForm";
            this.Load += new System.EventHandler(this.DodajIzostanakForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uceniciGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uceniciGridView;
        private System.Windows.Forms.Button dodajIzostanakButton;
        private System.Windows.Forms.TextBox predmetReadOnly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox datumReadOnly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox casIdTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razred;
        private System.Windows.Forms.DataGridViewTextBoxColumn UcenikId;
    }
}