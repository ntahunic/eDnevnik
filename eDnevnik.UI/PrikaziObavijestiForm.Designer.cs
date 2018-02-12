namespace eDnevnik.UI
{
    partial class PrikaziObavijestiForm
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
            this.obavijestiGridView = new System.Windows.Forms.DataGridView();
            this.ObavijestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sadrzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nastavnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obavijestUrediButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.obavijestiGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // obavijestiGridView
            // 
            this.obavijestiGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.obavijestiGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.obavijestiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.obavijestiGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ObavijestId,
            this.Naslov,
            this.Sadrzaj,
            this.Datum,
            this.Predmet,
            this.Nastavnik});
            this.obavijestiGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.obavijestiGridView.Location = new System.Drawing.Point(0, 64);
            this.obavijestiGridView.Name = "obavijestiGridView";
            this.obavijestiGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.obavijestiGridView.Size = new System.Drawing.Size(716, 345);
            this.obavijestiGridView.TabIndex = 0;
            this.obavijestiGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.obavijestiGridView_CellContentClick);
            // 
            // ObavijestId
            // 
            this.ObavijestId.DataPropertyName = "ObavijestId";
            this.ObavijestId.HeaderText = "ObavijestId";
            this.ObavijestId.Name = "ObavijestId";
            this.ObavijestId.ReadOnly = true;
            this.ObavijestId.Visible = false;
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            // 
            // Sadrzaj
            // 
            this.Sadrzaj.DataPropertyName = "Sadrzaj";
            this.Sadrzaj.HeaderText = "Sadrzaj";
            this.Sadrzaj.Name = "Sadrzaj";
            this.Sadrzaj.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Predmet
            // 
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // Nastavnik
            // 
            this.Nastavnik.DataPropertyName = "Nastavnik";
            this.Nastavnik.HeaderText = "Nastavnik";
            this.Nastavnik.Name = "Nastavnik";
            this.Nastavnik.ReadOnly = true;
            this.Nastavnik.Visible = false;
            // 
            // obavijestUrediButton
            // 
            this.obavijestUrediButton.Location = new System.Drawing.Point(616, 35);
            this.obavijestUrediButton.Name = "obavijestUrediButton";
            this.obavijestUrediButton.Size = new System.Drawing.Size(75, 23);
            this.obavijestUrediButton.TabIndex = 1;
            this.obavijestUrediButton.Text = "Uredi";
            this.obavijestUrediButton.UseVisualStyleBackColor = true;
            this.obavijestUrediButton.Click += new System.EventHandler(this.obavijestUrediButton_Click);
            // 
            // PrikaziObavijestiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 409);
            this.Controls.Add(this.obavijestUrediButton);
            this.Controls.Add(this.obavijestiGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrikaziObavijestiForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obavijesti";
            this.Load += new System.EventHandler(this.PrikaziObavijestiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.obavijestiGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView obavijestiGridView;
        private System.Windows.Forms.Button obavijestUrediButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObavijestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sadrzaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nastavnik;
    }
}