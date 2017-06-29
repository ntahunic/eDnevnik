namespace eDnevnik.UI
{
    partial class DodajRazredForm
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
            this.razredIdText = new System.Windows.Forms.TextBox();
            this.razrediGridView = new System.Windows.Forms.DataGridView();
            this.RazredId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odjeljenje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AkademskaGodina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AkademskaGodinaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazredOdjeljenje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izmijeniRazredButton = new System.Windows.Forms.Button();
            this.dodajRazredButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.odjeljenjeInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.razredInput = new System.Windows.Forms.TextBox();
            this.akademskaGodinaInput = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.razrediGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // razredIdText
            // 
            this.razredIdText.Location = new System.Drawing.Point(116, 4);
            this.razredIdText.Name = "razredIdText";
            this.razredIdText.Size = new System.Drawing.Size(100, 20);
            this.razredIdText.TabIndex = 28;
            this.razredIdText.Visible = false;
            // 
            // razrediGridView
            // 
            this.razrediGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.razrediGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.razrediGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RazredId,
            this.Naziv,
            this.Odjeljenje,
            this.AkademskaGodina,
            this.AkademskaGodinaId,
            this.RazredOdjeljenje});
            this.razrediGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.razrediGridView.Location = new System.Drawing.Point(0, 207);
            this.razrediGridView.Name = "razrediGridView";
            this.razrediGridView.Size = new System.Drawing.Size(529, 150);
            this.razrediGridView.TabIndex = 19;
            // 
            // RazredId
            // 
            this.RazredId.DataPropertyName = "RazredId";
            this.RazredId.HeaderText = "RazredId";
            this.RazredId.Name = "RazredId";
            this.RazredId.ReadOnly = true;
            this.RazredId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Odjeljenje
            // 
            this.Odjeljenje.DataPropertyName = "Odjeljenje";
            this.Odjeljenje.HeaderText = "Odjeljenje";
            this.Odjeljenje.Name = "Odjeljenje";
            this.Odjeljenje.ReadOnly = true;
            // 
            // AkademskaGodina
            // 
            this.AkademskaGodina.DataPropertyName = "AkademskaGodina";
            this.AkademskaGodina.HeaderText = "AkademskaGodina";
            this.AkademskaGodina.Name = "AkademskaGodina";
            this.AkademskaGodina.ReadOnly = true;
            // 
            // AkademskaGodinaId
            // 
            this.AkademskaGodinaId.DataPropertyName = "AkademskaGodinaId";
            this.AkademskaGodinaId.HeaderText = "AkademskaGodinaId";
            this.AkademskaGodinaId.Name = "AkademskaGodinaId";
            this.AkademskaGodinaId.ReadOnly = true;
            this.AkademskaGodinaId.Visible = false;
            // 
            // RazredOdjeljenje
            // 
            this.RazredOdjeljenje.DataPropertyName = "RazredOdjeljenje";
            this.RazredOdjeljenje.HeaderText = "RazredOdjeljenje";
            this.RazredOdjeljenje.Name = "RazredOdjeljenje";
            this.RazredOdjeljenje.ReadOnly = true;
            this.RazredOdjeljenje.Visible = false;
            // 
            // izmijeniRazredButton
            // 
            this.izmijeniRazredButton.Location = new System.Drawing.Point(442, 178);
            this.izmijeniRazredButton.Name = "izmijeniRazredButton";
            this.izmijeniRazredButton.Size = new System.Drawing.Size(75, 23);
            this.izmijeniRazredButton.TabIndex = 27;
            this.izmijeniRazredButton.Text = "Izmijeni";
            this.izmijeniRazredButton.UseVisualStyleBackColor = true;
            this.izmijeniRazredButton.Click += new System.EventHandler(this.izmijeniRazredButton_Click);
            // 
            // dodajRazredButton
            // 
            this.dodajRazredButton.Location = new System.Drawing.Point(241, 88);
            this.dodajRazredButton.Name = "dodajRazredButton";
            this.dodajRazredButton.Size = new System.Drawing.Size(75, 23);
            this.dodajRazredButton.TabIndex = 26;
            this.dodajRazredButton.Text = "Sačuvaj";
            this.dodajRazredButton.UseVisualStyleBackColor = true;
            this.dodajRazredButton.Click += new System.EventHandler(this.dodajRazredButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Akademska godina";
            // 
            // odjeljenjeInput
            // 
            this.odjeljenjeInput.Location = new System.Drawing.Point(116, 34);
            this.odjeljenjeInput.Name = "odjeljenjeInput";
            this.odjeljenjeInput.Size = new System.Drawing.Size(200, 20);
            this.odjeljenjeInput.TabIndex = 24;
            this.odjeljenjeInput.Validating += new System.ComponentModel.CancelEventHandler(this.odjeljenjeInput_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Odjeljenje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Razred";
            // 
            // razredInput
            // 
            this.razredInput.Location = new System.Drawing.Point(116, 8);
            this.razredInput.Name = "razredInput";
            this.razredInput.Size = new System.Drawing.Size(200, 20);
            this.razredInput.TabIndex = 21;
            this.razredInput.Validating += new System.ComponentModel.CancelEventHandler(this.razredInput_Validating);
            // 
            // akademskaGodinaInput
            // 
            this.akademskaGodinaInput.FormattingEnabled = true;
            this.akademskaGodinaInput.Location = new System.Drawing.Point(116, 61);
            this.akademskaGodinaInput.Name = "akademskaGodinaInput";
            this.akademskaGodinaInput.Size = new System.Drawing.Size(200, 21);
            this.akademskaGodinaInput.TabIndex = 20;
            this.akademskaGodinaInput.Validating += new System.ComponentModel.CancelEventHandler(this.akademskaGodinaInput_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DodajRazredForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 357);
            this.Controls.Add(this.razredIdText);
            this.Controls.Add(this.razrediGridView);
            this.Controls.Add(this.izmijeniRazredButton);
            this.Controls.Add(this.dodajRazredButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odjeljenjeInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.razredInput);
            this.Controls.Add(this.akademskaGodinaInput);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajRazredForm";
            this.ShowIcon = false;
            this.Text = "Dodaj razred";
            this.Load += new System.EventHandler(this.DodajRazredForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.razrediGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox razredIdText;
        private System.Windows.Forms.DataGridView razrediGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazredId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odjeljenje;
        private System.Windows.Forms.DataGridViewTextBoxColumn AkademskaGodina;
        private System.Windows.Forms.DataGridViewTextBoxColumn AkademskaGodinaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazredOdjeljenje;
        private System.Windows.Forms.Button izmijeniRazredButton;
        private System.Windows.Forms.Button dodajRazredButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox odjeljenjeInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox razredInput;
        private System.Windows.Forms.ComboBox akademskaGodinaInput;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}