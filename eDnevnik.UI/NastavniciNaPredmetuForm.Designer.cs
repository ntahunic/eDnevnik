namespace eDnevnik.UI
{
    partial class NastavniciNaPredmetuForm
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
            this.nastavniciNaPredmetuGridView = new System.Windows.Forms.DataGridView();
            this.NastavnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IsAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.nastavnikNaPredmetuiInput = new System.Windows.Forms.ComboBox();
            this.dodajNastavnikaNaPredmetButton = new System.Windows.Forms.Button();
            this.predmetIdText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nastavniciNaPredmetuGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nastavniciNaPredmetuGridView
            // 
            this.nastavniciNaPredmetuGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nastavniciNaPredmetuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nastavniciNaPredmetuGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NastavnikId,
            this.Titula,
            this.Ime,
            this.Prezime,
            this.Username,
            this.Password,
            this.ImePrezime,
            this.Obrisi,
            this.IsAdmin});
            this.nastavniciNaPredmetuGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nastavniciNaPredmetuGridView.Location = new System.Drawing.Point(0, 215);
            this.nastavniciNaPredmetuGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nastavniciNaPredmetuGridView.Name = "nastavniciNaPredmetuGridView";
            this.nastavniciNaPredmetuGridView.Size = new System.Drawing.Size(675, 190);
            this.nastavniciNaPredmetuGridView.TabIndex = 17;
            this.nastavniciNaPredmetuGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nastavniciNaPredmetuGridView_CellContentClick);
            // 
            // NastavnikId
            // 
            this.NastavnikId.DataPropertyName = "NastavnikId";
            this.NastavnikId.HeaderText = "NastavnikId";
            this.NastavnikId.Name = "NastavnikId";
            this.NastavnikId.ReadOnly = true;
            this.NastavnikId.Visible = false;
            // 
            // Titula
            // 
            this.Titula.DataPropertyName = "Titula";
            this.Titula.HeaderText = "Titula";
            this.Titula.Name = "Titula";
            this.Titula.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
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
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "ImePrezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            this.ImePrezime.Visible = false;
            // 
            // Obrisi
            // 
            this.Obrisi.HeaderText = "Obrisi";
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Obrisi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // IsAdmin
            // 
            this.IsAdmin.DataPropertyName = "IsAdmin";
            this.IsAdmin.HeaderText = "IsAdmin";
            this.IsAdmin.Name = "IsAdmin";
            this.IsAdmin.ReadOnly = true;
            this.IsAdmin.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nastavnik";
            // 
            // nastavnikNaPredmetuiInput
            // 
            this.nastavnikNaPredmetuiInput.FormattingEnabled = true;
            this.nastavnikNaPredmetuiInput.Location = new System.Drawing.Point(116, 28);
            this.nastavnikNaPredmetuiInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nastavnikNaPredmetuiInput.Name = "nastavnikNaPredmetuiInput";
            this.nastavnikNaPredmetuiInput.Size = new System.Drawing.Size(265, 24);
            this.nastavnikNaPredmetuiInput.TabIndex = 18;
            // 
            // dodajNastavnikaNaPredmetButton
            // 
            this.dodajNastavnikaNaPredmetButton.Location = new System.Drawing.Point(283, 62);
            this.dodajNastavnikaNaPredmetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dodajNastavnikaNaPredmetButton.Name = "dodajNastavnikaNaPredmetButton";
            this.dodajNastavnikaNaPredmetButton.Size = new System.Drawing.Size(100, 28);
            this.dodajNastavnikaNaPredmetButton.TabIndex = 20;
            this.dodajNastavnikaNaPredmetButton.Text = "Dodaj";
            this.dodajNastavnikaNaPredmetButton.UseVisualStyleBackColor = true;
            this.dodajNastavnikaNaPredmetButton.Click += new System.EventHandler(this.dodajNastavnikaNaPredmetButton_Click);
            // 
            // predmetIdText
            // 
            this.predmetIdText.Location = new System.Drawing.Point(116, 15);
            this.predmetIdText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.predmetIdText.Name = "predmetIdText";
            this.predmetIdText.Size = new System.Drawing.Size(132, 22);
            this.predmetIdText.TabIndex = 32;
            this.predmetIdText.Visible = false;
            // 
            // NastavniciNaPredmetuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 405);
            this.Controls.Add(this.predmetIdText);
            this.Controls.Add(this.dodajNastavnikaNaPredmetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nastavnikNaPredmetuiInput);
            this.Controls.Add(this.nastavniciNaPredmetuGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NastavniciNaPredmetuForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nastavnici na predmetu";
            this.Load += new System.EventHandler(this.NastavniciNaPredmetuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nastavniciNaPredmetuGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView nastavniciNaPredmetuGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nastavnikNaPredmetuiInput;
        private System.Windows.Forms.Button dodajNastavnikaNaPredmetButton;
        private System.Windows.Forms.TextBox predmetIdText;
        private System.Windows.Forms.DataGridViewTextBoxColumn NastavnikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewButtonColumn Obrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsAdmin;
    }
}