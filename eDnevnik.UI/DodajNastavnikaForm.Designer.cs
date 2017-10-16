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
            this.label6 = new System.Windows.Forms.Label();
            this.lozinkaPotvrdaInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.NastavnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nastavniciGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nastavnikIdText
            // 
            this.nastavnikIdText.Location = new System.Drawing.Point(145, 5);
            this.nastavnikIdText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nastavnikIdText.Name = "nastavnikIdText";
            this.nastavnikIdText.Size = new System.Drawing.Size(132, 22);
            this.nastavnikIdText.TabIndex = 31;
            this.nastavnikIdText.Visible = false;
            // 
            // izmijeniNastavnikaButton
            // 
            this.izmijeniNastavnikaButton.Location = new System.Drawing.Point(492, 295);
            this.izmijeniNastavnikaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.izmijeniNastavnikaButton.Name = "izmijeniNastavnikaButton";
            this.izmijeniNastavnikaButton.Size = new System.Drawing.Size(100, 28);
            this.izmijeniNastavnikaButton.TabIndex = 30;
            this.izmijeniNastavnikaButton.Text = "Izmijeni";
            this.izmijeniNastavnikaButton.UseVisualStyleBackColor = true;
            this.izmijeniNastavnikaButton.Click += new System.EventHandler(this.izmijeniNastavnikaButton_Click_1);
            // 
            // dodajNastavnikaButton
            // 
            this.dodajNastavnikaButton.Location = new System.Drawing.Point(309, 236);
            this.dodajNastavnikaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dodajNastavnikaButton.Name = "dodajNastavnikaButton";
            this.dodajNastavnikaButton.Size = new System.Drawing.Size(100, 28);
            this.dodajNastavnikaButton.TabIndex = 29;
            this.dodajNastavnikaButton.Text = "Sačuvaj";
            this.dodajNastavnikaButton.UseVisualStyleBackColor = true;
            this.dodajNastavnikaButton.Click += new System.EventHandler(this.dodajNastavnikaButton_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 208);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Lozinka - potvrda";
            // 
            // lozinkaPotvrdaInput
            // 
            this.lozinkaPotvrdaInput.Location = new System.Drawing.Point(145, 204);
            this.lozinkaPotvrdaInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lozinkaPotvrdaInput.Name = "lozinkaPotvrdaInput";
            this.lozinkaPotvrdaInput.PasswordChar = '*';
            this.lozinkaPotvrdaInput.Size = new System.Drawing.Size(263, 22);
            this.lozinkaPotvrdaInput.TabIndex = 27;
            this.lozinkaPotvrdaInput.Validating += new System.ComponentModel.CancelEventHandler(this.lozinkaPotvrdaInput_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Lozinka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Korisnicko ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Titula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ime";
            // 
            // lozinkaInput
            // 
            this.lozinkaInput.Location = new System.Drawing.Point(145, 172);
            this.lozinkaInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lozinkaInput.Name = "lozinkaInput";
            this.lozinkaInput.PasswordChar = '*';
            this.lozinkaInput.Size = new System.Drawing.Size(263, 22);
            this.lozinkaInput.TabIndex = 21;
            this.lozinkaInput.Validating += new System.ComponentModel.CancelEventHandler(this.lozinkaInput_Validating);
            // 
            // korisnickoImeInput
            // 
            this.korisnickoImeInput.Location = new System.Drawing.Point(145, 140);
            this.korisnickoImeInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.korisnickoImeInput.Name = "korisnickoImeInput";
            this.korisnickoImeInput.Size = new System.Drawing.Size(263, 22);
            this.korisnickoImeInput.TabIndex = 20;
            this.korisnickoImeInput.Validating += new System.ComponentModel.CancelEventHandler(this.korisnickoImeInput_Validating);
            // 
            // titulaInput
            // 
            this.titulaInput.Location = new System.Drawing.Point(145, 74);
            this.titulaInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titulaInput.Name = "titulaInput";
            this.titulaInput.Size = new System.Drawing.Size(263, 22);
            this.titulaInput.TabIndex = 19;
            this.titulaInput.Validating += new System.ComponentModel.CancelEventHandler(this.titulaInput_Validating);
            // 
            // prezimeInput
            // 
            this.prezimeInput.Location = new System.Drawing.Point(145, 42);
            this.prezimeInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prezimeInput.Name = "prezimeInput";
            this.prezimeInput.Size = new System.Drawing.Size(263, 22);
            this.prezimeInput.TabIndex = 18;
            this.prezimeInput.Validating += new System.ComponentModel.CancelEventHandler(this.prezimeInput_Validating);
            // 
            // imeInput
            // 
            this.imeInput.Location = new System.Drawing.Point(145, 10);
            this.imeInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imeInput.Name = "imeInput";
            this.imeInput.Size = new System.Drawing.Size(263, 22);
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
            this.Password,
            this.ImePrezime,
            this.IsAdmin,
            this.Obrisi});
            this.nastavniciGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nastavniciGridView.Location = new System.Drawing.Point(0, 331);
            this.nastavniciGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nastavniciGridView.Name = "nastavniciGridView";
            this.nastavniciGridView.Size = new System.Drawing.Size(608, 249);
            this.nastavniciGridView.TabIndex = 16;
            this.nastavniciGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nastavniciGridView_CellContentClick_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // 
            // DodajNastavnikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 580);
            this.Controls.Add(this.nastavnikIdText);
            this.Controls.Add(this.izmijeniNastavnikaButton);
            this.Controls.Add(this.dodajNastavnikaButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lozinkaPotvrdaInput);
            this.Controls.Add(this.label5);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajNastavnikaForm";
            this.ShowIcon = false;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lozinkaPotvrdaInput;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn NastavnikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsAdmin;
        private System.Windows.Forms.DataGridViewButtonColumn Obrisi;
    }
}