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
            this.dodajCasButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.brojSatiInput = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.uceniciGridView = new System.Windows.Forms.DataGridView();
            this.PrisustvoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UcenikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prisutan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IsOpravdano = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.brojSatiReadOnly = new System.Windows.Forms.TextBox();
            this.casIdTest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.datumReadOnly = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.predmetReadOnly = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ocjenaIdText = new System.Windows.Forms.TextBox();
            this.sacuvajOcjenuButton = new System.Windows.Forms.Button();
            this.ucenikLabel = new System.Windows.Forms.Label();
            this.ucenikInput = new System.Windows.Forms.ComboBox();
            this.ocjenaLabel = new System.Windows.Forms.Label();
            this.ocjenaInput = new System.Windows.Forms.TextBox();
            this.ocjeneNaCasuGridView = new System.Windows.Forms.DataGridView();
            this.Ucenik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OcjenaVrijednost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.casoviGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uceniciGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ocjeneNaCasuGridView)).BeginInit();
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
            this.casoviGridView.Location = new System.Drawing.Point(3, 150);
            this.casoviGridView.Name = "casoviGridView";
            this.casoviGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.casoviGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.casoviGridView.Size = new System.Drawing.Size(704, 247);
            this.casoviGridView.TabIndex = 11;
            this.casoviGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.casoviGridView_CellContentClick);
            this.casoviGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.casoviGridView_RowStateChanged);
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
            this.predmetiInput.Location = new System.Drawing.Point(75, 9);
            this.predmetiInput.Name = "predmetiInput";
            this.predmetiInput.Size = new System.Drawing.Size(200, 21);
            this.predmetiInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Predmet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Broj sati";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // datumCasaInput
            // 
            this.datumCasaInput.Location = new System.Drawing.Point(75, 37);
            this.datumCasaInput.Name = "datumCasaInput";
            this.datumCasaInput.Size = new System.Drawing.Size(200, 20);
            this.datumCasaInput.TabIndex = 8;
            // 
            // dodajCasButton
            // 
            this.dodajCasButton.Location = new System.Drawing.Point(200, 89);
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
            this.brojSatiInput.Location = new System.Drawing.Point(75, 63);
            this.brojSatiInput.Name = "brojSatiInput";
            this.brojSatiInput.Size = new System.Drawing.Size(200, 20);
            this.brojSatiInput.TabIndex = 12;
            this.brojSatiInput.Validating += new System.ComponentModel.CancelEventHandler(this.brojSatiInput_Validating_2);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 426);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dodajCasButton);
            this.tabPage1.Controls.Add(this.casoviGridView);
            this.tabPage1.Controls.Add(this.brojSatiInput);
            this.tabPage1.Controls.Add(this.predmetiInput);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.datumCasaInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(710, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.uceniciGridView);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.brojSatiReadOnly);
            this.tabPage2.Controls.Add(this.casIdTest);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.datumReadOnly);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.predmetReadOnly);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(710, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Izostanci";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Sacuvaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uceniciGridView
            // 
            this.uceniciGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uceniciGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uceniciGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrisustvoId,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.UcenikId,
            this.Ime,
            this.Prezime,
            this.Razred,
            this.Prisutan,
            this.dataGridViewButtonColumn1,
            this.IsOpravdano});
            this.uceniciGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uceniciGridView.Location = new System.Drawing.Point(3, 152);
            this.uceniciGridView.Name = "uceniciGridView";
            this.uceniciGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uceniciGridView.Size = new System.Drawing.Size(704, 245);
            this.uceniciGridView.TabIndex = 16;
            // 
            // PrisustvoId
            // 
            this.PrisustvoId.DataPropertyName = "PrisustvoId";
            this.PrisustvoId.HeaderText = "PrisustvoId";
            this.PrisustvoId.Name = "PrisustvoId";
            this.PrisustvoId.ReadOnly = true;
            this.PrisustvoId.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BrojSati";
            this.dataGridViewTextBoxColumn1.HeaderText = "BrojSati";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Datum";
            this.dataGridViewTextBoxColumn2.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Predmet";
            this.dataGridViewTextBoxColumn3.HeaderText = "Predmet";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ImePrezime";
            this.dataGridViewTextBoxColumn4.HeaderText = "ImePrezime";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
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
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.DataPropertyName = "Opravdano";
            this.dataGridViewButtonColumn1.HeaderText = "Opravdano";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonColumn1.Visible = false;
            // 
            // IsOpravdano
            // 
            this.IsOpravdano.DataPropertyName = "IsOpravdano";
            this.IsOpravdano.HeaderText = "IsOpravdano";
            this.IsOpravdano.Name = "IsOpravdano";
            this.IsOpravdano.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsOpravdano.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Broj sati";
            // 
            // brojSatiReadOnly
            // 
            this.brojSatiReadOnly.Location = new System.Drawing.Point(76, 63);
            this.brojSatiReadOnly.Name = "brojSatiReadOnly";
            this.brojSatiReadOnly.ReadOnly = true;
            this.brojSatiReadOnly.Size = new System.Drawing.Size(205, 20);
            this.brojSatiReadOnly.TabIndex = 14;
            // 
            // casIdTest
            // 
            this.casIdTest.Location = new System.Drawing.Point(76, 89);
            this.casIdTest.Name = "casIdTest";
            this.casIdTest.ReadOnly = true;
            this.casIdTest.Size = new System.Drawing.Size(205, 20);
            this.casIdTest.TabIndex = 13;
            this.casIdTest.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Datum";
            // 
            // datumReadOnly
            // 
            this.datumReadOnly.Location = new System.Drawing.Point(76, 36);
            this.datumReadOnly.Name = "datumReadOnly";
            this.datumReadOnly.ReadOnly = true;
            this.datumReadOnly.Size = new System.Drawing.Size(205, 20);
            this.datumReadOnly.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Predmet";
            // 
            // predmetReadOnly
            // 
            this.predmetReadOnly.Location = new System.Drawing.Point(76, 10);
            this.predmetReadOnly.Name = "predmetReadOnly";
            this.predmetReadOnly.ReadOnly = true;
            this.predmetReadOnly.Size = new System.Drawing.Size(205, 20);
            this.predmetReadOnly.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ocjeneNaCasuGridView);
            this.tabPage3.Controls.Add(this.ocjenaIdText);
            this.tabPage3.Controls.Add(this.sacuvajOcjenuButton);
            this.tabPage3.Controls.Add(this.ucenikLabel);
            this.tabPage3.Controls.Add(this.ucenikInput);
            this.tabPage3.Controls.Add(this.ocjenaLabel);
            this.tabPage3.Controls.Add(this.ocjenaInput);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(710, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ocjene";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ocjenaIdText
            // 
            this.ocjenaIdText.Location = new System.Drawing.Point(75, 4);
            this.ocjenaIdText.Name = "ocjenaIdText";
            this.ocjenaIdText.Size = new System.Drawing.Size(100, 20);
            this.ocjenaIdText.TabIndex = 26;
            this.ocjenaIdText.Visible = false;
            // 
            // sacuvajOcjenuButton
            // 
            this.sacuvajOcjenuButton.Location = new System.Drawing.Point(200, 67);
            this.sacuvajOcjenuButton.Name = "sacuvajOcjenuButton";
            this.sacuvajOcjenuButton.Size = new System.Drawing.Size(75, 23);
            this.sacuvajOcjenuButton.TabIndex = 25;
            this.sacuvajOcjenuButton.Text = "Sačuvaj";
            this.sacuvajOcjenuButton.UseVisualStyleBackColor = true;
            this.sacuvajOcjenuButton.Click += new System.EventHandler(this.sacuvajOcjenuButton_Click);
            // 
            // ucenikLabel
            // 
            this.ucenikLabel.AutoSize = true;
            this.ucenikLabel.Location = new System.Drawing.Point(7, 17);
            this.ucenikLabel.Name = "ucenikLabel";
            this.ucenikLabel.Size = new System.Drawing.Size(41, 13);
            this.ucenikLabel.TabIndex = 24;
            this.ucenikLabel.Text = "Ucenik";
            // 
            // ucenikInput
            // 
            this.ucenikInput.FormattingEnabled = true;
            this.ucenikInput.Location = new System.Drawing.Point(75, 14);
            this.ucenikInput.Name = "ucenikInput";
            this.ucenikInput.Size = new System.Drawing.Size(200, 21);
            this.ucenikInput.TabIndex = 23;
            this.ucenikInput.Validating += new System.ComponentModel.CancelEventHandler(this.ucenikInput_Validating);
            // 
            // ocjenaLabel
            // 
            this.ocjenaLabel.AutoSize = true;
            this.ocjenaLabel.Location = new System.Drawing.Point(7, 44);
            this.ocjenaLabel.Name = "ocjenaLabel";
            this.ocjenaLabel.Size = new System.Drawing.Size(41, 13);
            this.ocjenaLabel.TabIndex = 22;
            this.ocjenaLabel.Text = "Ocjena";
            // 
            // ocjenaInput
            // 
            this.ocjenaInput.Location = new System.Drawing.Point(75, 41);
            this.ocjenaInput.Name = "ocjenaInput";
            this.ocjenaInput.Size = new System.Drawing.Size(200, 20);
            this.ocjenaInput.TabIndex = 21;
            this.ocjenaInput.Validating += new System.ComponentModel.CancelEventHandler(this.ocjenaInput_Validating);
            // 
            // ocjeneNaCasuGridView
            // 
            this.ocjeneNaCasuGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ocjeneNaCasuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ocjeneNaCasuGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ucenik,
            this.OcjenaVrijednost});
            this.ocjeneNaCasuGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ocjeneNaCasuGridView.Location = new System.Drawing.Point(0, 146);
            this.ocjeneNaCasuGridView.Name = "ocjeneNaCasuGridView";
            this.ocjeneNaCasuGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ocjeneNaCasuGridView.Size = new System.Drawing.Size(710, 254);
            this.ocjeneNaCasuGridView.TabIndex = 27;
            // 
            // Ucenik
            // 
            this.Ucenik.DataPropertyName = "Ucenik";
            this.Ucenik.HeaderText = "Ucenik";
            this.Ucenik.Name = "Ucenik";
            // 
            // OcjenaVrijednost
            // 
            this.OcjenaVrijednost.DataPropertyName = "OcjenaVrijednost";
            this.OcjenaVrijednost.HeaderText = "Ocjena";
            this.OcjenaVrijednost.Name = "OcjenaVrijednost";
            // 
            // DodajCasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajCasForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj čas";
            this.Load += new System.EventHandler(this.DodajCasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.casoviGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uceniciGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ocjeneNaCasuGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView casoviGridView;
        private System.Windows.Forms.ComboBox predmetiInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datumCasaInput;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox brojSatiReadOnly;
        private System.Windows.Forms.TextBox casIdTest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox datumReadOnly;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox predmetReadOnly;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView uceniciGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrisustvoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn UcenikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razred;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Prisutan;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsOpravdano;
        private System.Windows.Forms.TextBox ocjenaIdText;
        private System.Windows.Forms.Button sacuvajOcjenuButton;
        private System.Windows.Forms.Label ucenikLabel;
        private System.Windows.Forms.ComboBox ucenikInput;
        private System.Windows.Forms.Label ocjenaLabel;
        private System.Windows.Forms.TextBox ocjenaInput;
        private System.Windows.Forms.DataGridView ocjeneNaCasuGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ucenik;
        private System.Windows.Forms.DataGridViewTextBoxColumn OcjenaVrijednost;
    }
}

