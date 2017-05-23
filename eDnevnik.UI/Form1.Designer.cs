namespace eDnevnik.UI
{
    partial class Form1
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
            this.ucitajUcenikeButton = new System.Windows.Forms.Button();
            this.uceniciGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uceniciGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ucitajUcenikeButton
            // 
            this.ucitajUcenikeButton.Location = new System.Drawing.Point(269, 12);
            this.ucitajUcenikeButton.Name = "ucitajUcenikeButton";
            this.ucitajUcenikeButton.Size = new System.Drawing.Size(75, 23);
            this.ucitajUcenikeButton.TabIndex = 0;
            this.ucitajUcenikeButton.Text = "Ucitaj ucenike";
            this.ucitajUcenikeButton.UseVisualStyleBackColor = true;
            this.ucitajUcenikeButton.Click += new System.EventHandler(this.ucitajUcenikeButton_Click);
            // 
            // uceniciGridView
            // 
            this.uceniciGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uceniciGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uceniciGridView.Location = new System.Drawing.Point(0, 121);
            this.uceniciGridView.Name = "uceniciGridView";
            this.uceniciGridView.Size = new System.Drawing.Size(600, 313);
            this.uceniciGridView.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 434);
            this.Controls.Add(this.uceniciGridView);
            this.Controls.Add(this.ucitajUcenikeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.uceniciGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ucitajUcenikeButton;
        private System.Windows.Forms.DataGridView uceniciGridView;
    }
}

