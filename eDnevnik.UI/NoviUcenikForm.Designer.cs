namespace eDnevnik.UI
{
    partial class NoviUcenikForm
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
            this.razredInput = new System.Windows.Forms.ComboBox();
            this.ucenikIdText = new System.Windows.Forms.TextBox();
            this.dodajUcenikaButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lozinkaPotvrdaInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lozinkaInput = new System.Windows.Forms.TextBox();
            this.korisnickoImeInput = new System.Windows.Forms.TextBox();
            this.imeInput = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.prezimeInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // razredInput
            // 
            this.razredInput.FormattingEnabled = true;
            this.razredInput.Location = new System.Drawing.Point(110, 68);
            this.razredInput.Name = "razredInput";
            this.razredInput.Size = new System.Drawing.Size(198, 21);
            this.razredInput.TabIndex = 44;
            this.razredInput.SelectedIndexChanged += new System.EventHandler(this.razredInput_SelectedIndexChanged);
            // 
            // ucenikIdText
            // 
            this.ucenikIdText.Location = new System.Drawing.Point(110, 12);
            this.ucenikIdText.Name = "ucenikIdText";
            this.ucenikIdText.Size = new System.Drawing.Size(100, 20);
            this.ucenikIdText.TabIndex = 43;
            this.ucenikIdText.Visible = false;
            // 
            // dodajUcenikaButton
            // 
            this.dodajUcenikaButton.Location = new System.Drawing.Point(233, 202);
            this.dodajUcenikaButton.Name = "dodajUcenikaButton";
            this.dodajUcenikaButton.Size = new System.Drawing.Size(75, 23);
            this.dodajUcenikaButton.TabIndex = 42;
            this.dodajUcenikaButton.Text = "Sačuvaj";
            this.dodajUcenikaButton.UseVisualStyleBackColor = true;
            this.dodajUcenikaButton.Click += new System.EventHandler(this.dodajUcenikaButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Lozinka - potvrda";
            // 
            // lozinkaPotvrdaInput
            // 
            this.lozinkaPotvrdaInput.Location = new System.Drawing.Point(110, 176);
            this.lozinkaPotvrdaInput.Name = "lozinkaPotvrdaInput";
            this.lozinkaPotvrdaInput.PasswordChar = '*';
            this.lozinkaPotvrdaInput.Size = new System.Drawing.Size(198, 20);
            this.lozinkaPotvrdaInput.TabIndex = 40;
            this.lozinkaPotvrdaInput.Validating += new System.ComponentModel.CancelEventHandler(this.lozinkaPotvrdaInput_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Lozinka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Korisnicko ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Razred";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ime";
            // 
            // lozinkaInput
            // 
            this.lozinkaInput.Location = new System.Drawing.Point(110, 150);
            this.lozinkaInput.Name = "lozinkaInput";
            this.lozinkaInput.PasswordChar = '*';
            this.lozinkaInput.Size = new System.Drawing.Size(198, 20);
            this.lozinkaInput.TabIndex = 34;
            this.lozinkaInput.Validating += new System.ComponentModel.CancelEventHandler(this.lozinkaInput_Validating);
            // 
            // korisnickoImeInput
            // 
            this.korisnickoImeInput.Location = new System.Drawing.Point(110, 124);
            this.korisnickoImeInput.Name = "korisnickoImeInput";
            this.korisnickoImeInput.Size = new System.Drawing.Size(198, 20);
            this.korisnickoImeInput.TabIndex = 33;
            this.korisnickoImeInput.Validating += new System.ComponentModel.CancelEventHandler(this.korisnickoImeInput_Validating);
            // 
            // imeInput
            // 
            this.imeInput.Location = new System.Drawing.Point(110, 16);
            this.imeInput.Name = "imeInput";
            this.imeInput.Size = new System.Drawing.Size(198, 20);
            this.imeInput.TabIndex = 31;
            this.imeInput.Validating += new System.ComponentModel.CancelEventHandler(this.imeInput_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // prezimeInput
            // 
            this.prezimeInput.Location = new System.Drawing.Point(110, 42);
            this.prezimeInput.Name = "prezimeInput";
            this.prezimeInput.Size = new System.Drawing.Size(198, 20);
            this.prezimeInput.TabIndex = 32;
            this.prezimeInput.Validating += new System.ComponentModel.CancelEventHandler(this.prezimeInput_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Prezime";
            // 
            // NoviUcenikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 286);
            this.Controls.Add(this.razredInput);
            this.Controls.Add(this.ucenikIdText);
            this.Controls.Add(this.dodajUcenikaButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lozinkaPotvrdaInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lozinkaInput);
            this.Controls.Add(this.korisnickoImeInput);
            this.Controls.Add(this.prezimeInput);
            this.Controls.Add(this.imeInput);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoviUcenikForm";
            this.ShowIcon = false;
            this.Text = "Novi učenik";
            this.Load += new System.EventHandler(this.NoviUcenikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox razredInput;
        private System.Windows.Forms.TextBox ucenikIdText;
        private System.Windows.Forms.Button dodajUcenikaButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lozinkaPotvrdaInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lozinkaInput;
        private System.Windows.Forms.TextBox korisnickoImeInput;
        private System.Windows.Forms.TextBox imeInput;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prezimeInput;
    }
}