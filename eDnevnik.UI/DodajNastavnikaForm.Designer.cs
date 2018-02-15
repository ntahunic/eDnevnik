namespace eDnevnik.UI
{
    partial class DodajNastavnikaForm
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
            this.nastavnikIdText = new System.Windows.Forms.TextBox();
            this.izmijeniNastavnikaButton = new System.Windows.Forms.Button();
            this.dodajNastavnikaButton = new System.Windows.Forms.Button();
            this.lozinkaPotvrdaInputLabel = new System.Windows.Forms.Label();
            this.lozinkaPotvrdaInput = new System.Windows.Forms.TextBox();
            this.lozinkaInputLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lozinkaInput = new System.Windows.Forms.TextBox();
            this.korisnickoImeInput = new System.Windows.Forms.TextBox();
            this.titulaInput = new System.Windows.Forms.TextBox();
            this.prezimeInput = new System.Windows.Forms.TextBox();
            this.imeInput = new System.Windows.Forms.TextBox();
            this.nastavniciGridView = new System.Windows.Forms.DataGridView();
            this.NastavnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.telefonInput = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nastavniciGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nastavnikIdText
            // 
            this.nastavnikIdText.Location = new System.Drawing.Point(109, 4);
            this.nastavnikIdText.Name = "nastavnikIdText";
            this.nastavnikIdText.Size = new System.Drawing.Size(100, 20);
            this.nastavnikIdText.TabIndex = 31;
            this.nastavnikIdText.Visible = false;
            // 
            // izmijeniNastavnikaButton
            // 
            this.izmijeniNastavnikaButton.Location = new System.Drawing.Point(721, 240);
            this.izmijeniNastavnikaButton.Name = "izmijeniNastavnikaButton";
            this.izmijeniNastavnikaButton.Size = new System.Drawing.Size(75, 23);
            this.izmijeniNastavnikaButton.TabIndex = 30;
            this.izmijeniNastavnikaButton.Text = "Izmijeni";
            this.izmijeniNastavnikaButton.UseVisualStyleBackColor = true;
            this.izmijeniNastavnikaButton.Click += new System.EventHandler(this.izmijeniNastavnikaButton_Click_1);
            // 
            // dodajNastavnikaButton
            // 
            this.dodajNastavnikaButton.Location = new System.Drawing.Point(232, 211);
            this.dodajNastavnikaButton.Name = "dodajNastavnikaButton";
            this.dodajNastavnikaButton.Size = new System.Drawing.Size(75, 23);
            this.dodajNastavnikaButton.TabIndex = 29;
            this.dodajNastavnikaButton.Text = "Sačuvaj";
            this.dodajNastavnikaButton.UseVisualStyleBackColor = true;
            this.dodajNastavnikaButton.Click += new System.EventHandler(this.dodajNastavnikaButton_Click_1);
            // 
            // lozinkaPotvrdaInputLabel
            // 
            this.lozinkaPotvrdaInputLabel.AutoSize = true;
            this.lozinkaPotvrdaInputLabel.Location = new System.Drawing.Point(12, 188);
            this.lozinkaPotvrdaInputLabel.Name = "lozinkaPotvrdaInputLabel";
            this.lozinkaPotvrdaInputLabel.Size = new System.Drawing.Size(89, 13);
            this.lozinkaPotvrdaInputLabel.TabIndex = 28;
            this.lozinkaPotvrdaInputLabel.Text = "Lozinka - potvrda";
            // 
            // lozinkaPotvrdaInput
            // 
            this.lozinkaPotvrdaInput.Location = new System.Drawing.Point(109, 185);
            this.lozinkaPotvrdaInput.Name = "lozinkaPotvrdaInput";
            this.lozinkaPotvrdaInput.PasswordChar = '*';
            this.lozinkaPotvrdaInput.Size = new System.Drawing.Size(198, 20);
            this.lozinkaPotvrdaInput.TabIndex = 27;
            this.lozinkaPotvrdaInput.Validating += new System.ComponentModel.CancelEventHandler(this.lozinkaPotvrdaInput_Validating);
            // 
            // lozinkaInputLabel
            // 
            this.lozinkaInputLabel.AutoSize = true;
            this.lozinkaInputLabel.Location = new System.Drawing.Point(12, 159);
            this.lozinkaInputLabel.Name = "lozinkaInputLabel";
            this.lozinkaInputLabel.Size = new System.Drawing.Size(44, 13);
            this.lozinkaInputLabel.TabIndex = 26;
            this.lozinkaInputLabel.Text = "Lozinka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Korisnicko ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Titula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ime";
            // 
            // lozinkaInput
            // 
            this.lozinkaInput.Location = new System.Drawing.Point(109, 159);
            this.lozinkaInput.Name = "lozinkaInput";
            this.lozinkaInput.PasswordChar = '*';
            this.lozinkaInput.Size = new System.Drawing.Size(198, 20);
            this.lozinkaInput.TabIndex = 21;
            this.lozinkaInput.Validating += new System.ComponentModel.CancelEventHandler(this.lozinkaInput_Validating);
            // 
            // korisnickoImeInput
            // 
            this.korisnickoImeInput.Location = new System.Drawing.Point(109, 133);
            this.korisnickoImeInput.Name = "korisnickoImeInput";
            this.korisnickoImeInput.Size = new System.Drawing.Size(198, 20);
            this.korisnickoImeInput.TabIndex = 20;
            this.korisnickoImeInput.Validating += new System.ComponentModel.CancelEventHandler(this.korisnickoImeInput_Validating);
            // 
            // titulaInput
            // 
            this.titulaInput.Location = new System.Drawing.Point(109, 60);
            this.titulaInput.Name = "titulaInput";
            this.titulaInput.Size = new System.Drawing.Size(198, 20);
            this.titulaInput.TabIndex = 19;
            this.titulaInput.Validating += new System.ComponentModel.CancelEventHandler(this.titulaInput_Validating);
            // 
            // prezimeInput
            // 
            this.prezimeInput.Location = new System.Drawing.Point(109, 34);
            this.prezimeInput.Name = "prezimeInput";
            this.prezimeInput.Size = new System.Drawing.Size(198, 20);
            this.prezimeInput.TabIndex = 18;
            this.prezimeInput.Validating += new System.ComponentModel.CancelEventHandler(this.prezimeInput_Validating);
            // 
            // imeInput
            // 
            this.imeInput.Location = new System.Drawing.Point(109, 8);
            this.imeInput.Name = "imeInput";
            this.imeInput.Size = new System.Drawing.Size(198, 20);
            this.imeInput.TabIndex = 17;
            this.imeInput.Validating += new System.ComponentModel.CancelEventHandler(this.imeInput_Validating);
            // 
            // nastavniciGridView
            // 
            this.nastavniciGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nastavniciGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nastavniciGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NastavnikId,
            this.Titula,
            this.Ime,
            this.Prezime,
            this.Username,
            this.Telefon,
            this.Password,
            this.ImePrezime,
            this.IsAdmin,
            this.Obrisi,
            this.Aktivan});
            this.nastavniciGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nastavniciGridView.Location = new System.Drawing.Point(0, 269);
            this.nastavniciGridView.Name = "nastavniciGridView";
            this.nastavniciGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nastavniciGridView.Size = new System.Drawing.Size(808, 202);
            this.nastavniciGridView.TabIndex = 16;
            this.nastavniciGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nastavniciGridView_CellContentClick);
            this.nastavniciGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.nastavniciGridView_CellValueChanged_1);
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
            this.Username.HeaderText = "Korisnicko ime";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
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
            // IsAdmin
            // 
            this.IsAdmin.DataPropertyName = "IsAdmin";
            this.IsAdmin.HeaderText = "IsAdmin";
            this.IsAdmin.Name = "IsAdmin";
            this.IsAdmin.ReadOnly = true;
            this.IsAdmin.Visible = false;
            // 
            // Obrisi
            // 
            this.Obrisi.HeaderText = "Obrisi";
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.Text = "";
            this.Obrisi.Visible = false;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.Name = "Aktivan";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Telefon";
            // 
            // telefonInput
            // 
            this.telefonInput.Location = new System.Drawing.Point(109, 86);
            this.telefonInput.Mask = "(+999) 99/000-000";
            this.telefonInput.Name = "telefonInput";
            this.telefonInput.Size = new System.Drawing.Size(197, 20);
            this.telefonInput.TabIndex = 34;
            this.telefonInput.Validating += new System.ComponentModel.CancelEventHandler(this.telefonInput_Validating);
            // 
            // DodajNastavnikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 471);
            this.Controls.Add(this.telefonInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nastavnikIdText);
            this.Controls.Add(this.izmijeniNastavnikaButton);
            this.Controls.Add(this.dodajNastavnikaButton);
            this.Controls.Add(this.lozinkaPotvrdaInputLabel);
            this.Controls.Add(this.lozinkaPotvrdaInput);
            this.Controls.Add(this.lozinkaInputLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lozinkaInput);
            this.Controls.Add(this.korisnickoImeInput);
            this.Controls.Add(this.titulaInput);
            this.Controls.Add(this.prezimeInput);
            this.Controls.Add(this.imeInput);
            this.Controls.Add(this.nastavniciGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajNastavnikaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj nastavnika";
            this.Load += new System.EventHandler(this.DodajNastavnikaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nastavniciGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nastavnikIdText;
        private System.Windows.Forms.Button izmijeniNastavnikaButton;
        private System.Windows.Forms.Button dodajNastavnikaButton;
        private System.Windows.Forms.Label lozinkaPotvrdaInputLabel;
        private System.Windows.Forms.TextBox lozinkaPotvrdaInput;
        private System.Windows.Forms.Label lozinkaInputLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lozinkaInput;
        private System.Windows.Forms.TextBox korisnickoImeInput;
        private System.Windows.Forms.TextBox titulaInput;
        private System.Windows.Forms.TextBox prezimeInput;
        private System.Windows.Forms.TextBox imeInput;
        private System.Windows.Forms.DataGridView nastavniciGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox telefonInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn NastavnikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsAdmin;
        private System.Windows.Forms.DataGridViewButtonColumn Obrisi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
    }
}