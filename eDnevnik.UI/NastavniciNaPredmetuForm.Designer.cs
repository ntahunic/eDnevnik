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
            this.label1 = new System.Windows.Forms.Label();
            this.nastavnikNaPredmetuiInput = new System.Windows.Forms.ComboBox();
            this.dodajNastavnikaNaPredmetButton = new System.Windows.Forms.Button();
            this.predmetIdText = new System.Windows.Forms.TextBox();
            this.NastavnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IsAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Telefon,
            this.ImePrezime,
            this.Obrisi,
            this.IsAdmin,
            this.Aktivan});
            this.nastavniciNaPredmetuGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nastavniciNaPredmetuGridView.Location = new System.Drawing.Point(0, 110);
            this.nastavniciNaPredmetuGridView.Name = "nastavniciNaPredmetuGridView";
            this.nastavniciNaPredmetuGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nastavniciNaPredmetuGridView.Size = new System.Drawing.Size(807, 355);
            this.nastavniciNaPredmetuGridView.TabIndex = 17;
            this.nastavniciNaPredmetuGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nastavniciNaPredmetuGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nastavnik";
            // 
            // nastavnikNaPredmetuiInput
            // 
            this.nastavnikNaPredmetuiInput.FormattingEnabled = true;
            this.nastavnikNaPredmetuiInput.Location = new System.Drawing.Point(87, 23);
            this.nastavnikNaPredmetuiInput.Name = "nastavnikNaPredmetuiInput";
            this.nastavnikNaPredmetuiInput.Size = new System.Drawing.Size(200, 21);
            this.nastavnikNaPredmetuiInput.TabIndex = 18;
            // 
            // dodajNastavnikaNaPredmetButton
            // 
            this.dodajNastavnikaNaPredmetButton.Location = new System.Drawing.Point(212, 50);
            this.dodajNastavnikaNaPredmetButton.Name = "dodajNastavnikaNaPredmetButton";
            this.dodajNastavnikaNaPredmetButton.Size = new System.Drawing.Size(75, 23);
            this.dodajNastavnikaNaPredmetButton.TabIndex = 20;
            this.dodajNastavnikaNaPredmetButton.Text = "Dodaj";
            this.dodajNastavnikaNaPredmetButton.UseVisualStyleBackColor = true;
            this.dodajNastavnikaNaPredmetButton.Click += new System.EventHandler(this.dodajNastavnikaNaPredmetButton_Click);
            // 
            // predmetIdText
            // 
            this.predmetIdText.Location = new System.Drawing.Point(87, 12);
            this.predmetIdText.Name = "predmetIdText";
            this.predmetIdText.Size = new System.Drawing.Size(100, 20);
            this.predmetIdText.TabIndex = 32;
            this.predmetIdText.Visible = false;
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
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.Visible = false;
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
            this.Obrisi.HeaderText = "Akcija";
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Obrisi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Obrisi.Text = "Ukloni";
            this.Obrisi.ToolTipText = "Ukloni";
            this.Obrisi.UseColumnTextForButtonValue = true;
            // 
            // IsAdmin
            // 
            this.IsAdmin.DataPropertyName = "IsAdmin";
            this.IsAdmin.HeaderText = "IsAdmin";
            this.IsAdmin.Name = "IsAdmin";
            this.IsAdmin.ReadOnly = true;
            this.IsAdmin.Visible = false;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.Visible = false;
            // 
            // NastavniciNaPredmetuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 465);
            this.Controls.Add(this.predmetIdText);
            this.Controls.Add(this.dodajNastavnikaNaPredmetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nastavnikNaPredmetuiInput);
            this.Controls.Add(this.nastavniciNaPredmetuGridView);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewButtonColumn Obrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aktivan;
    }
}