namespace eDnevnik.UI
{
    partial class DodajUcenikaForm
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
            this.izmijeniUcenikaButton = new System.Windows.Forms.Button();
            this.noviUcenikButton = new System.Windows.Forms.Button();
            this.pretraziUcenikeButton = new System.Windows.Forms.Button();
            this.pretragaUcenikaInput = new System.Windows.Forms.TextBox();
            this.UcenikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazredId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojUDnevniku = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uceniciGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uceniciGridView
            // 
            this.uceniciGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uceniciGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uceniciGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UcenikId,
            this.Ime,
            this.Prezime,
            this.Razred,
            this.Aktivan,
            this.Username,
            this.Password,
            this.ImePrezime,
            this.RazredId,
            this.BrojUDnevniku});
            this.uceniciGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uceniciGridView.Location = new System.Drawing.Point(0, 51);
            this.uceniciGridView.Name = "uceniciGridView";
            this.uceniciGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uceniciGridView.Size = new System.Drawing.Size(787, 392);
            this.uceniciGridView.TabIndex = 9;
            this.uceniciGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uceniciGridView_CellContentClick);
            this.uceniciGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.uceniciGridView_CellValueChanged);
            // 
            // izmijeniUcenikaButton
            // 
            this.izmijeniUcenikaButton.Location = new System.Drawing.Point(700, 22);
            this.izmijeniUcenikaButton.Name = "izmijeniUcenikaButton";
            this.izmijeniUcenikaButton.Size = new System.Drawing.Size(75, 23);
            this.izmijeniUcenikaButton.TabIndex = 8;
            this.izmijeniUcenikaButton.Text = "Izmijeni";
            this.izmijeniUcenikaButton.UseVisualStyleBackColor = true;
            this.izmijeniUcenikaButton.Click += new System.EventHandler(this.izmijeniUcenikaButton_Click);
            // 
            // noviUcenikButton
            // 
            this.noviUcenikButton.Location = new System.Drawing.Point(619, 22);
            this.noviUcenikButton.Name = "noviUcenikButton";
            this.noviUcenikButton.Size = new System.Drawing.Size(75, 23);
            this.noviUcenikButton.TabIndex = 7;
            this.noviUcenikButton.Text = "Novi učenik";
            this.noviUcenikButton.UseVisualStyleBackColor = true;
            this.noviUcenikButton.Click += new System.EventHandler(this.noviUcenikButton_Click);
            // 
            // pretraziUcenikeButton
            // 
            this.pretraziUcenikeButton.Location = new System.Drawing.Point(239, 5);
            this.pretraziUcenikeButton.Name = "pretraziUcenikeButton";
            this.pretraziUcenikeButton.Size = new System.Drawing.Size(75, 23);
            this.pretraziUcenikeButton.TabIndex = 6;
            this.pretraziUcenikeButton.Text = "Pretrazi";
            this.pretraziUcenikeButton.UseVisualStyleBackColor = true;
            this.pretraziUcenikeButton.Click += new System.EventHandler(this.pretraziUcenikeButton_Click);
            // 
            // pretragaUcenikaInput
            // 
            this.pretragaUcenikaInput.Location = new System.Drawing.Point(6, 7);
            this.pretragaUcenikaInput.Name = "pretragaUcenikaInput";
            this.pretragaUcenikaInput.Size = new System.Drawing.Size(227, 20);
            this.pretragaUcenikaInput.TabIndex = 5;
            // 
            // UcenikId
            // 
            this.UcenikId.DataPropertyName = "UcenikId";
            this.UcenikId.HeaderText = "UcenikId";
            this.UcenikId.Name = "UcenikId";
            this.UcenikId.ReadOnly = true;
            this.UcenikId.Visible = false;
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
            // Razred
            // 
            this.Razred.DataPropertyName = "Razred";
            this.Razred.HeaderText = "Razred";
            this.Razred.Name = "Razred";
            this.Razred.ReadOnly = true;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.Name = "Aktivan";
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
            // RazredId
            // 
            this.RazredId.DataPropertyName = "RazredId";
            this.RazredId.HeaderText = "RazredId";
            this.RazredId.Name = "RazredId";
            this.RazredId.ReadOnly = true;
            this.RazredId.Visible = false;
            // 
            // BrojUDnevniku
            // 
            this.BrojUDnevniku.DataPropertyName = "BrojUDnevniku";
            this.BrojUDnevniku.HeaderText = "BrojUDnevniku";
            this.BrojUDnevniku.Name = "BrojUDnevniku";
            this.BrojUDnevniku.Visible = false;
            // 
            // DodajUcenikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 443);
            this.Controls.Add(this.uceniciGridView);
            this.Controls.Add(this.izmijeniUcenikaButton);
            this.Controls.Add(this.noviUcenikButton);
            this.Controls.Add(this.pretraziUcenikeButton);
            this.Controls.Add(this.pretragaUcenikaInput);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajUcenikaForm";
            this.ShowIcon = false;
            this.Text = "Dodaj učenika";
            this.Load += new System.EventHandler(this.DodajUcenikaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uceniciGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uceniciGridView;
        private System.Windows.Forms.Button izmijeniUcenikaButton;
        private System.Windows.Forms.Button noviUcenikButton;
        private System.Windows.Forms.Button pretraziUcenikeButton;
        private System.Windows.Forms.TextBox pretragaUcenikaInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn UcenikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razred;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazredId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BrojUDnevniku;
    }
}