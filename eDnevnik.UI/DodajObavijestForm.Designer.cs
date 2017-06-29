namespace eDnevnik.UI
{
    partial class DodajObavijestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.predmetiInput = new System.Windows.Forms.ComboBox();
            this.datumObavijestiInput = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.sadrzajObavijestiInput = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dodajObavijestButton = new System.Windows.Forms.Button();
            this.naslovObavijestiInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.obavijestId = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Predmet";
            // 
            // predmetiInput
            // 
            this.predmetiInput.FormattingEnabled = true;
            this.predmetiInput.Location = new System.Drawing.Point(79, 12);
            this.predmetiInput.Name = "predmetiInput";
            this.predmetiInput.Size = new System.Drawing.Size(200, 21);
            this.predmetiInput.TabIndex = 6;
            // 
            // datumObavijestiInput
            // 
            this.datumObavijestiInput.Location = new System.Drawing.Point(79, 39);
            this.datumObavijestiInput.Name = "datumObavijestiInput";
            this.datumObavijestiInput.Size = new System.Drawing.Size(200, 20);
            this.datumObavijestiInput.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Datum";
            // 
            // sadrzajObavijestiInput
            // 
            this.sadrzajObavijestiInput.Location = new System.Drawing.Point(79, 119);
            this.sadrzajObavijestiInput.Name = "sadrzajObavijestiInput";
            this.sadrzajObavijestiInput.Size = new System.Drawing.Size(313, 134);
            this.sadrzajObavijestiInput.TabIndex = 11;
            this.sadrzajObavijestiInput.Text = "";
            this.sadrzajObavijestiInput.Validating += new System.ComponentModel.CancelEventHandler(this.sadrzajObavijestiInput_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sadržaj";
            // 
            // dodajObavijestButton
            // 
            this.dodajObavijestButton.Location = new System.Drawing.Point(304, 259);
            this.dodajObavijestButton.Name = "dodajObavijestButton";
            this.dodajObavijestButton.Size = new System.Drawing.Size(88, 23);
            this.dodajObavijestButton.TabIndex = 13;
            this.dodajObavijestButton.Text = "Dodaj obavijest";
            this.dodajObavijestButton.UseVisualStyleBackColor = true;
            this.dodajObavijestButton.Click += new System.EventHandler(this.dodajObavijestButton_Click);
            // 
            // naslovObavijestiInput
            // 
            this.naslovObavijestiInput.Location = new System.Drawing.Point(79, 93);
            this.naslovObavijestiInput.Name = "naslovObavijestiInput";
            this.naslovObavijestiInput.Size = new System.Drawing.Size(200, 20);
            this.naslovObavijestiInput.TabIndex = 14;
            this.naslovObavijestiInput.Validating += new System.ComponentModel.CancelEventHandler(this.naslovObavijestiInput_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Naslov";
            // 
            // obavijestId
            // 
            this.obavijestId.Location = new System.Drawing.Point(79, 8);
            this.obavijestId.Name = "obavijestId";
            this.obavijestId.Size = new System.Drawing.Size(100, 20);
            this.obavijestId.TabIndex = 16;
            this.obavijestId.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DodajObavijestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 299);
            this.Controls.Add(this.obavijestId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.naslovObavijestiInput);
            this.Controls.Add(this.dodajObavijestButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sadrzajObavijestiInput);
            this.Controls.Add(this.datumObavijestiInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.predmetiInput);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajObavijestForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj obavijest";
            this.Load += new System.EventHandler(this.DodajObavijestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox predmetiInput;
        private System.Windows.Forms.DateTimePicker datumObavijestiInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox sadrzajObavijestiInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dodajObavijestButton;
        private System.Windows.Forms.TextBox naslovObavijestiInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox obavijestId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}