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
            this.brojSatiReadOnly = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PrisustvoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojSati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UcenikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prisutan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Opravdano = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IsOpravdano = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uceniciGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uceniciGridView
            // 
            this.uceniciGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uceniciGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uceniciGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrisustvoId,
            this.BrojSati,
            this.Datum,
            this.Predmet,
            this.ImePrezime,
            this.UcenikId,
            this.Ime,
            this.Prezime,
            this.Razred,
            this.Prisutan,
            this.Opravdano,
            this.IsOpravdano});
            this.uceniciGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uceniciGridView.Location = new System.Drawing.Point(0, 128);
            this.uceniciGridView.Name = "uceniciGridView";
            this.uceniciGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uceniciGridView.Size = new System.Drawing.Size(759, 338);
            this.uceniciGridView.TabIndex = 0;
            this.uceniciGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uceniciGridView_CellContentClick);
            // 
            // dodajIzostanakButton
            // 
            this.dodajIzostanakButton.Location = new System.Drawing.Point(641, 99);
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
            this.casIdTest.Location = new System.Drawing.Point(81, 88);
            this.casIdTest.Name = "casIdTest";
            this.casIdTest.ReadOnly = true;
            this.casIdTest.Size = new System.Drawing.Size(205, 20);
            this.casIdTest.TabIndex = 6;
            this.casIdTest.Visible = false;
            // 
            // brojSatiReadOnly
            // 
            this.brojSatiReadOnly.Location = new System.Drawing.Point(81, 62);
            this.brojSatiReadOnly.Name = "brojSatiReadOnly";
            this.brojSatiReadOnly.ReadOnly = true;
            this.brojSatiReadOnly.Size = new System.Drawing.Size(205, 20);
            this.brojSatiReadOnly.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Broj sati";
            // 
            // PrisustvoId
            // 
            this.PrisustvoId.DataPropertyName = "PrisustvoId";
            this.PrisustvoId.HeaderText = "PrisustvoId";
            this.PrisustvoId.Name = "PrisustvoId";
            this.PrisustvoId.ReadOnly = true;
            this.PrisustvoId.Visible = false;
            // 
            // BrojSati
            // 
            this.BrojSati.DataPropertyName = "BrojSati";
            this.BrojSati.HeaderText = "BrojSati";
            this.BrojSati.Name = "BrojSati";
            this.BrojSati.ReadOnly = true;
            this.BrojSati.Visible = false;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.Visible = false;
            // 
            // Predmet
            // 
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            this.Predmet.Visible = false;
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "ImePrezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            this.ImePrezime.Visible = false;
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
            // Prisutan
            // 
            this.Prisutan.DataPropertyName = "Prisutan";
            this.Prisutan.HeaderText = "Prisutan";
            this.Prisutan.Name = "Prisutan";
            this.Prisutan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Prisutan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Opravdano
            // 
            this.Opravdano.DataPropertyName = "Opravdano";
            this.Opravdano.HeaderText = "Opravdano";
            this.Opravdano.Name = "Opravdano";
            this.Opravdano.ReadOnly = true;
            this.Opravdano.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Opravdano.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Opravdano.Visible = false;
            // 
            // IsOpravdano
            // 
            this.IsOpravdano.DataPropertyName = "IsOpravdano";
            this.IsOpravdano.HeaderText = "Opravdano";
            this.IsOpravdano.Name = "IsOpravdano";
            this.IsOpravdano.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DodajIzostanakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 466);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.brojSatiReadOnly);
            this.Controls.Add(this.casIdTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datumReadOnly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.predmetReadOnly);
            this.Controls.Add(this.dodajIzostanakButton);
            this.Controls.Add(this.uceniciGridView);
            this.Name = "DodajIzostanakForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj izostanak";
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
        private System.Windows.Forms.TextBox brojSatiReadOnly;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrisustvoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojSati;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn UcenikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razred;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Prisutan;
        private System.Windows.Forms.DataGridViewButtonColumn Opravdano;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsOpravdano;
    }
}