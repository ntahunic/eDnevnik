namespace eDnevnik.UI
{
    partial class DodajMaterijalForm
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
            this.materijalNazivInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materijalPredmetId = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.datumObjaveInput = new System.Windows.Forms.DateTimePicker();
            this.sadrzajInput = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dodajMaterijalButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.uploadFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileUploadInput = new System.Windows.Forms.TextBox();
            this.fileNameInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // materijalNazivInput
            // 
            this.materijalNazivInput.Location = new System.Drawing.Point(55, 15);
            this.materijalNazivInput.Name = "materijalNazivInput";
            this.materijalNazivInput.Size = new System.Drawing.Size(200, 20);
            this.materijalNazivInput.TabIndex = 0;
            this.materijalNazivInput.Validating += new System.ComponentModel.CancelEventHandler(this.materijalNazivInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum";
            // 
            // materijalPredmetId
            // 
            this.materijalPredmetId.Location = new System.Drawing.Point(55, 2);
            this.materijalPredmetId.Name = "materijalPredmetId";
            this.materijalPredmetId.Size = new System.Drawing.Size(100, 20);
            this.materijalPredmetId.TabIndex = 4;
            this.materijalPredmetId.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // datumObjaveInput
            // 
            this.datumObjaveInput.Location = new System.Drawing.Point(55, 44);
            this.datumObjaveInput.Name = "datumObjaveInput";
            this.datumObjaveInput.Size = new System.Drawing.Size(200, 20);
            this.datumObjaveInput.TabIndex = 9;
            // 
            // sadrzajInput
            // 
            this.sadrzajInput.Location = new System.Drawing.Point(55, 82);
            this.sadrzajInput.Name = "sadrzajInput";
            this.sadrzajInput.Size = new System.Drawing.Size(376, 143);
            this.sadrzajInput.TabIndex = 10;
            this.sadrzajInput.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Opis";
            // 
            // dodajMaterijalButton
            // 
            this.dodajMaterijalButton.Location = new System.Drawing.Point(333, 266);
            this.dodajMaterijalButton.Name = "dodajMaterijalButton";
            this.dodajMaterijalButton.Size = new System.Drawing.Size(98, 23);
            this.dodajMaterijalButton.TabIndex = 12;
            this.dodajMaterijalButton.Text = "Dodaj materijal";
            this.dodajMaterijalButton.UseVisualStyleBackColor = true;
            this.dodajMaterijalButton.Click += new System.EventHandler(this.dodajMaterijalButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "File";
            // 
            // uploadFileButton
            // 
            this.uploadFileButton.Location = new System.Drawing.Point(289, 226);
            this.uploadFileButton.Name = "uploadFileButton";
            this.uploadFileButton.Size = new System.Drawing.Size(32, 23);
            this.uploadFileButton.TabIndex = 14;
            this.uploadFileButton.Text = "...";
            this.uploadFileButton.UseVisualStyleBackColor = true;
            this.uploadFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileUploadInput
            // 
            this.fileUploadInput.Location = new System.Drawing.Point(55, 254);
            this.fileUploadInput.Name = "fileUploadInput";
            this.fileUploadInput.Size = new System.Drawing.Size(38, 20);
            this.fileUploadInput.TabIndex = 15;
            this.fileUploadInput.Visible = false;
            this.fileUploadInput.Validating += new System.ComponentModel.CancelEventHandler(this.fileUploadInput_Validating);
            // 
            // fileNameInput
            // 
            this.fileNameInput.Location = new System.Drawing.Point(55, 228);
            this.fileNameInput.Name = "fileNameInput";
            this.fileNameInput.Size = new System.Drawing.Size(200, 20);
            this.fileNameInput.TabIndex = 16;
            this.fileNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.fileNameInput_Validating);
            // 
            // DodajMaterijalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 304);
            this.Controls.Add(this.fileNameInput);
            this.Controls.Add(this.fileUploadInput);
            this.Controls.Add(this.uploadFileButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dodajMaterijalButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sadrzajInput);
            this.Controls.Add(this.datumObjaveInput);
            this.Controls.Add(this.materijalPredmetId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materijalNazivInput);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajMaterijalForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj materijal";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox materijalNazivInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox materijalPredmetId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker datumObjaveInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox sadrzajInput;
        private System.Windows.Forms.Button dodajMaterijalButton;
        private System.Windows.Forms.Button uploadFileButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox fileUploadInput;
        private System.Windows.Forms.TextBox fileNameInput;
    }
}