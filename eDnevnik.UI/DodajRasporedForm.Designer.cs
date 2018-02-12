namespace eDnevnik.UI
{
    partial class DodajRasporedForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.razredInput = new System.Windows.Forms.ComboBox();
            this.Petak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cetvrtak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Srijeda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utorak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ponedjeljak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rasporedCasovaGridView = new System.Windows.Forms.DataGridView();
            this.sacuvajRasporedButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rasporedCasovaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Razred";
            // 
            // razredInput
            // 
            this.razredInput.FormattingEnabled = true;
            this.razredInput.Location = new System.Drawing.Point(86, 11);
            this.razredInput.Name = "razredInput";
            this.razredInput.Size = new System.Drawing.Size(200, 21);
            this.razredInput.TabIndex = 26;
            // 
            // Petak
            // 
            this.Petak.HeaderText = "Petak";
            this.Petak.Name = "Petak";
            // 
            // Cetvrtak
            // 
            this.Cetvrtak.HeaderText = "Cetvrtak";
            this.Cetvrtak.Name = "Cetvrtak";
            // 
            // Srijeda
            // 
            this.Srijeda.HeaderText = "Srijeda";
            this.Srijeda.Name = "Srijeda";
            // 
            // Utorak
            // 
            this.Utorak.HeaderText = "Utorak";
            this.Utorak.Name = "Utorak";
            // 
            // Ponedjeljak
            // 
            this.Ponedjeljak.HeaderText = "Ponedjeljak";
            this.Ponedjeljak.Name = "Ponedjeljak";
            // 
            // rasporedCasovaGridView
            // 
            this.rasporedCasovaGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rasporedCasovaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rasporedCasovaGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ponedjeljak,
            this.Utorak,
            this.Srijeda,
            this.Cetvrtak,
            this.Petak});
            this.rasporedCasovaGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rasporedCasovaGridView.Location = new System.Drawing.Point(0, 82);
            this.rasporedCasovaGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rasporedCasovaGridView.Name = "rasporedCasovaGridView";
            this.rasporedCasovaGridView.RowTemplate.Height = 24;
            this.rasporedCasovaGridView.Size = new System.Drawing.Size(757, 366);
            this.rasporedCasovaGridView.TabIndex = 63;
            this.rasporedCasovaGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rasporedCasovaGridView_CellContentClick);
            // 
            // sacuvajRasporedButton
            // 
            this.sacuvajRasporedButton.Location = new System.Drawing.Point(690, 50);
            this.sacuvajRasporedButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sacuvajRasporedButton.Name = "sacuvajRasporedButton";
            this.sacuvajRasporedButton.Size = new System.Drawing.Size(56, 28);
            this.sacuvajRasporedButton.TabIndex = 64;
            this.sacuvajRasporedButton.Text = "Sačuvaj";
            this.sacuvajRasporedButton.UseVisualStyleBackColor = true;
            this.sacuvajRasporedButton.Click += new System.EventHandler(this.sacuvajRasporedButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 21);
            this.button1.TabIndex = 65;
            this.button1.Text = "Popuni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DodajRasporedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sacuvajRasporedButton);
            this.Controls.Add(this.rasporedCasovaGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.razredInput);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajRasporedForm";
            this.ShowIcon = false;
            this.Text = "Dodaj raspored";
            this.Load += new System.EventHandler(this.DodajRasporedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rasporedCasovaGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox razredInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Petak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cetvrtak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Srijeda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utorak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ponedjeljak;
        private System.Windows.Forms.DataGridView rasporedCasovaGridView;
        private System.Windows.Forms.Button sacuvajRasporedButton;
        private System.Windows.Forms.Button button1;
    }
}