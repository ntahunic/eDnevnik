namespace eDnevnik.UI
{
    partial class UrediOcjenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.predmetiComboBox = new System.Windows.Forms.ComboBox();
            this.pretraziButton = new System.Windows.Forms.Button();
            this.ocjeneGridView = new System.Windows.Forms.DataGridView();
            this.OcjenaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UcenikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CasId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ucenik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urediOcjenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ocjeneGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Predmet";
            // 
            // predmetiComboBox
            // 
            this.predmetiComboBox.FormattingEnabled = true;
            this.predmetiComboBox.Location = new System.Drawing.Point(64, 12);
            this.predmetiComboBox.Name = "predmetiComboBox";
            this.predmetiComboBox.Size = new System.Drawing.Size(286, 21);
            this.predmetiComboBox.TabIndex = 6;
            // 
            // pretraziButton
            // 
            this.pretraziButton.Location = new System.Drawing.Point(275, 39);
            this.pretraziButton.Name = "pretraziButton";
            this.pretraziButton.Size = new System.Drawing.Size(75, 23);
            this.pretraziButton.TabIndex = 8;
            this.pretraziButton.Text = "Pretrazi";
            this.pretraziButton.UseVisualStyleBackColor = true;
            this.pretraziButton.Click += new System.EventHandler(this.pretraziButton_Click);
            // 
            // ocjeneGridView
            // 
            this.ocjeneGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ocjeneGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ocjeneGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OcjenaId,
            this.UcenikId,
            this.CasId,
            this.Ucenik,
            this.Ocjena});
            this.ocjeneGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ocjeneGridView.Location = new System.Drawing.Point(0, 109);
            this.ocjeneGridView.Name = "ocjeneGridView";
            this.ocjeneGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ocjeneGridView.Size = new System.Drawing.Size(373, 251);
            this.ocjeneGridView.TabIndex = 9;
            // 
            // OcjenaId
            // 
            this.OcjenaId.DataPropertyName = "OcjenaId";
            this.OcjenaId.HeaderText = "OcjenaId";
            this.OcjenaId.Name = "OcjenaId";
            this.OcjenaId.ReadOnly = true;
            this.OcjenaId.Visible = false;
            // 
            // UcenikId
            // 
            this.UcenikId.DataPropertyName = "UcenikId";
            this.UcenikId.HeaderText = "UcenikId";
            this.UcenikId.Name = "UcenikId";
            this.UcenikId.ReadOnly = true;
            this.UcenikId.Visible = false;
            // 
            // CasId
            // 
            this.CasId.DataPropertyName = "CasId";
            this.CasId.HeaderText = "CasId";
            this.CasId.Name = "CasId";
            this.CasId.ReadOnly = true;
            this.CasId.Visible = false;
            // 
            // Ucenik
            // 
            this.Ucenik.DataPropertyName = "Ucenik";
            this.Ucenik.HeaderText = "Ucenik";
            this.Ucenik.Name = "Ucenik";
            this.Ucenik.ReadOnly = true;
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "OcjenaVrijednost";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            // 
            // urediOcjenuButton
            // 
            this.urediOcjenuButton.Location = new System.Drawing.Point(275, 80);
            this.urediOcjenuButton.Name = "urediOcjenuButton";
            this.urediOcjenuButton.Size = new System.Drawing.Size(75, 23);
            this.urediOcjenuButton.TabIndex = 10;
            this.urediOcjenuButton.Text = "Uredi ocjenu";
            this.urediOcjenuButton.UseVisualStyleBackColor = true;
            this.urediOcjenuButton.Click += new System.EventHandler(this.urediOcjenuButton_Click);
            // 
            // UrediOcjenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 360);
            this.Controls.Add(this.urediOcjenuButton);
            this.Controls.Add(this.ocjeneGridView);
            this.Controls.Add(this.pretraziButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.predmetiComboBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UrediOcjenuForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi ocjenu";
            this.Load += new System.EventHandler(this.UrediOcjenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ocjeneGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox predmetiComboBox;
        private System.Windows.Forms.Button pretraziButton;
        private System.Windows.Forms.DataGridView ocjeneGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn OcjenaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UcenikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CasId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ucenik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.Button urediOcjenuButton;
    }
}