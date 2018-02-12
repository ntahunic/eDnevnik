namespace eDnevnik.UI
{
    partial class PrikaziPredmeteForm
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
            this.predmetiGridView = new System.Windows.Forms.DataGridView();
            this.PredmetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetiDetaljiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.predmetiGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // predmetiGridView
            // 
            this.predmetiGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.predmetiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.predmetiGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PredmetId,
            this.Naziv});
            this.predmetiGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.predmetiGridView.Location = new System.Drawing.Point(0, 42);
            this.predmetiGridView.Name = "predmetiGridView";
            this.predmetiGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.predmetiGridView.Size = new System.Drawing.Size(389, 129);
            this.predmetiGridView.TabIndex = 0;
            // 
            // PredmetId
            // 
            this.PredmetId.DataPropertyName = "PredmetId";
            this.PredmetId.HeaderText = "PredmetId";
            this.PredmetId.Name = "PredmetId";
            this.PredmetId.ReadOnly = true;
            this.PredmetId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // predmetiDetaljiButton
            // 
            this.predmetiDetaljiButton.Location = new System.Drawing.Point(302, 13);
            this.predmetiDetaljiButton.Name = "predmetiDetaljiButton";
            this.predmetiDetaljiButton.Size = new System.Drawing.Size(75, 23);
            this.predmetiDetaljiButton.TabIndex = 1;
            this.predmetiDetaljiButton.Text = "Detalji";
            this.predmetiDetaljiButton.UseVisualStyleBackColor = true;
            // 
            // PrikaziPredmeteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 171);
            this.Controls.Add(this.predmetiDetaljiButton);
            this.Controls.Add(this.predmetiGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrikaziPredmeteForm";
            this.ShowIcon = false;
            this.Text = "Predmeti";
            this.Load += new System.EventHandler(this.PrikaziPredmeteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.predmetiGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView predmetiGridView;
        private System.Windows.Forms.Button predmetiDetaljiButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn PredmetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
    }
}