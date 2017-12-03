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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // materijalNazivInput
            // 
            this.materijalNazivInput.Location = new System.Drawing.Point(70, 15);
            this.materijalNazivInput.Name = "materijalNazivInput";
            this.materijalNazivInput.Size = new System.Drawing.Size(200, 20);
            this.materijalNazivInput.TabIndex = 0;
            this.materijalNazivInput.Validating += new System.ComponentModel.CancelEventHandler(this.materijalNazivInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum";
            // 
            // materijalPredmetId
            // 
            this.materijalPredmetId.Location = new System.Drawing.Point(70, 2);
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
            this.datumObjaveInput.Location = new System.Drawing.Point(70, 44);
            this.datumObjaveInput.Name = "datumObjaveInput";
            this.datumObjaveInput.Size = new System.Drawing.Size(200, 20);
            this.datumObjaveInput.TabIndex = 9;
            // 
            // sadrzajInput
            // 
            this.sadrzajInput.Location = new System.Drawing.Point(70, 82);
            this.sadrzajInput.Name = "sadrzajInput";
            this.sadrzajInput.Size = new System.Drawing.Size(556, 261);
            this.sadrzajInput.TabIndex = 10;
            this.sadrzajInput.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sadrzaj";
            // 
            // dodajMaterijalButton
            // 
            this.dodajMaterijalButton.Location = new System.Drawing.Point(528, 349);
            this.dodajMaterijalButton.Name = "dodajMaterijalButton";
            this.dodajMaterijalButton.Size = new System.Drawing.Size(98, 23);
            this.dodajMaterijalButton.TabIndex = 12;
            this.dodajMaterijalButton.Text = "Dodaj materijal";
            this.dodajMaterijalButton.UseVisualStyleBackColor = true;
            this.dodajMaterijalButton.Click += new System.EventHandler(this.dodajMaterijalButton_Click);
            // 
            // DodajMaterijalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 386);
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
    }
}