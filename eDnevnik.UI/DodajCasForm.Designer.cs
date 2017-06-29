namespace eDnevnik.UI
{
    partial class DodajCasForm
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
            this.casoviGridView = new System.Windows.Forms.DataGridView();
            this.CasId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nastavnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojSati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opravdano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetiInput = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datumCasaInput = new System.Windows.Forms.DateTimePicker();
            this.dodajIzostanakButton = new System.Windows.Forms.Button();
            this.dodajCasButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.brojSatiInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.casoviGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // casoviGridView
            // 
            this.casoviGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.casoviGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CasId,
            this.Datum,
            this.Nastavnik,
            this.Predmet,
            this.BrojSati,
            this.ImePrezime,
            this.Opravdano});
            this.casoviGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.casoviGridView.Location = new System.Drawing.Point(0, 162);
            this.casoviGridView.Name = "casoviGridView";
            this.casoviGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.casoviGridView.Size = new System.Drawing.Size(516, 272);
            this.casoviGridView.TabIndex = 11;
            this.casoviGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.casoviGridView_CellContentClick);
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
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "ImePrezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            this.ImePrezime.Visible = false;
            // 
            // Opravdano
            // 
            this.Opravdano.HeaderText = "Opravdano";
            this.Opravdano.Name = "Opravdano";
            this.Opravdano.ReadOnly = true;
            this.Opravdano.Visible = false;
            // 
            // predmetiInput
            // 
            this.predmetiInput.FormattingEnabled = true;
            this.predmetiInput.Location = new System.Drawing.Point(81, 12);
            this.predmetiInput.Name = "predmetiInput";
            this.predmetiInput.Size = new System.Drawing.Size(200, 21);
            this.predmetiInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Predmet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Broj sati";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // datumCasaInput
            // 
            this.datumCasaInput.Location = new System.Drawing.Point(81, 40);
            this.datumCasaInput.Name = "datumCasaInput";
            this.datumCasaInput.Size = new System.Drawing.Size(200, 20);
            this.datumCasaInput.TabIndex = 8;
            // 
            // dodajIzostanakButton
            // 
            this.dodajIzostanakButton.Location = new System.Drawing.Point(398, 133);
            this.dodajIzostanakButton.Name = "dodajIzostanakButton";
            this.dodajIzostanakButton.Size = new System.Drawing.Size(106, 23);
            this.dodajIzostanakButton.TabIndex = 9;
            this.dodajIzostanakButton.Text = "Izostanci sa časa";
            this.dodajIzostanakButton.UseVisualStyleBackColor = true;
            this.dodajIzostanakButton.Click += new System.EventHandler(this.dodajIzostanakButton_Click);
            // 
            // dodajCasButton
            // 
            this.dodajCasButton.Location = new System.Drawing.Point(206, 92);
            this.dodajCasButton.Name = "dodajCasButton";
            this.dodajCasButton.Size = new System.Drawing.Size(75, 23);
            this.dodajCasButton.TabIndex = 10;
            this.dodajCasButton.Text = "Dodaj čas";
            this.dodajCasButton.UseVisualStyleBackColor = true;
            this.dodajCasButton.Click += new System.EventHandler(this.dodajCasButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // brojSatiInput
            // 
            this.brojSatiInput.Location = new System.Drawing.Point(81, 66);
            this.brojSatiInput.Name = "brojSatiInput";
            this.brojSatiInput.Size = new System.Drawing.Size(200, 20);
            this.brojSatiInput.TabIndex = 12;
            this.brojSatiInput.Validating += new System.ComponentModel.CancelEventHandler(this.brojSatiInput_Validating_2);
            // 
            // DodajCasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 434);
            this.Controls.Add(this.brojSatiInput);
            this.Controls.Add(this.dodajCasButton);
            this.Controls.Add(this.dodajIzostanakButton);
            this.Controls.Add(this.datumCasaInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.predmetiInput);
            this.Controls.Add(this.casoviGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajCasForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj čas";
            this.Load += new System.EventHandler(this.DodajCasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.casoviGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView casoviGridView;
        private System.Windows.Forms.ComboBox predmetiInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datumCasaInput;
        private System.Windows.Forms.Button dodajIzostanakButton;
        private System.Windows.Forms.Button dodajCasButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CasId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nastavnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojSati;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opravdano;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox brojSatiInput;
    }
}

