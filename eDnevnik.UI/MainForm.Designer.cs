namespace eDnevnik.UI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administracijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nastavničkiKadarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predmetiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.razrediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.učeniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidencijaČasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajČasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidencijaOcjenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajOcjenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmijeniOcjenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obavijestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledObavijestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajObavijestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predmetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mojiPredmetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracijaToolStripMenuItem,
            this.evidencijaČasaToolStripMenuItem,
            this.evidencijaOcjenaToolStripMenuItem,
            this.obavijestiToolStripMenuItem,
            this.predmetiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(538, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administracijaToolStripMenuItem
            // 
            this.administracijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nastavničkiKadarToolStripMenuItem,
            this.predmetiToolStripMenuItem1,
            this.razrediToolStripMenuItem,
            this.učeniciToolStripMenuItem});
            this.administracijaToolStripMenuItem.Name = "administracijaToolStripMenuItem";
            this.administracijaToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administracijaToolStripMenuItem.Text = "Administracija";
            // 
            // nastavničkiKadarToolStripMenuItem
            // 
            this.nastavničkiKadarToolStripMenuItem.Name = "nastavničkiKadarToolStripMenuItem";
            this.nastavničkiKadarToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.nastavničkiKadarToolStripMenuItem.Text = "Nastavnički kadar";
            this.nastavničkiKadarToolStripMenuItem.Click += new System.EventHandler(this.nastavničkiKadarToolStripMenuItem_Click);
            // 
            // predmetiToolStripMenuItem1
            // 
            this.predmetiToolStripMenuItem1.Name = "predmetiToolStripMenuItem1";
            this.predmetiToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.predmetiToolStripMenuItem1.Text = "Predmeti";
            this.predmetiToolStripMenuItem1.Click += new System.EventHandler(this.predmetiToolStripMenuItem1_Click);
            // 
            // razrediToolStripMenuItem
            // 
            this.razrediToolStripMenuItem.Name = "razrediToolStripMenuItem";
            this.razrediToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.razrediToolStripMenuItem.Text = "Razredi";
            this.razrediToolStripMenuItem.Click += new System.EventHandler(this.razrediToolStripMenuItem_Click);
            // 
            // učeniciToolStripMenuItem
            // 
            this.učeniciToolStripMenuItem.Name = "učeniciToolStripMenuItem";
            this.učeniciToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.učeniciToolStripMenuItem.Text = "Učenici";
            // 
            // evidencijaČasaToolStripMenuItem
            // 
            this.evidencijaČasaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajČasToolStripMenuItem});
            this.evidencijaČasaToolStripMenuItem.Name = "evidencijaČasaToolStripMenuItem";
            this.evidencijaČasaToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.evidencijaČasaToolStripMenuItem.Text = "Evidencija časa";
            // 
            // dodajČasToolStripMenuItem
            // 
            this.dodajČasToolStripMenuItem.Name = "dodajČasToolStripMenuItem";
            this.dodajČasToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.dodajČasToolStripMenuItem.Text = "Dodaj čas";
            this.dodajČasToolStripMenuItem.Click += new System.EventHandler(this.dodajČasToolStripMenuItem_Click);
            // 
            // evidencijaOcjenaToolStripMenuItem
            // 
            this.evidencijaOcjenaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajOcjenuToolStripMenuItem,
            this.izmijeniOcjenuToolStripMenuItem});
            this.evidencijaOcjenaToolStripMenuItem.Name = "evidencijaOcjenaToolStripMenuItem";
            this.evidencijaOcjenaToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.evidencijaOcjenaToolStripMenuItem.Text = "Evidencija ocjena";
            // 
            // dodajOcjenuToolStripMenuItem
            // 
            this.dodajOcjenuToolStripMenuItem.Name = "dodajOcjenuToolStripMenuItem";
            this.dodajOcjenuToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.dodajOcjenuToolStripMenuItem.Text = "Dodaj ocjenu";
            this.dodajOcjenuToolStripMenuItem.Click += new System.EventHandler(this.dodajOcjenuToolStripMenuItem_Click);
            // 
            // izmijeniOcjenuToolStripMenuItem
            // 
            this.izmijeniOcjenuToolStripMenuItem.Name = "izmijeniOcjenuToolStripMenuItem";
            this.izmijeniOcjenuToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.izmijeniOcjenuToolStripMenuItem.Text = "Izmijeni ocjenu";
            this.izmijeniOcjenuToolStripMenuItem.Click += new System.EventHandler(this.izmijeniOcjenuToolStripMenuItem_Click);
            // 
            // obavijestiToolStripMenuItem
            // 
            this.obavijestiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledObavijestiToolStripMenuItem,
            this.dodajObavijestToolStripMenuItem});
            this.obavijestiToolStripMenuItem.Name = "obavijestiToolStripMenuItem";
            this.obavijestiToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.obavijestiToolStripMenuItem.Text = "Obavijesti";
            // 
            // pregledObavijestiToolStripMenuItem
            // 
            this.pregledObavijestiToolStripMenuItem.Name = "pregledObavijestiToolStripMenuItem";
            this.pregledObavijestiToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pregledObavijestiToolStripMenuItem.Text = "Pregled obavijesti";
            this.pregledObavijestiToolStripMenuItem.Click += new System.EventHandler(this.pregledObavijestiToolStripMenuItem_Click);
            // 
            // dodajObavijestToolStripMenuItem
            // 
            this.dodajObavijestToolStripMenuItem.Name = "dodajObavijestToolStripMenuItem";
            this.dodajObavijestToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.dodajObavijestToolStripMenuItem.Text = "Dodaj obavijest";
            this.dodajObavijestToolStripMenuItem.Click += new System.EventHandler(this.dodajObavijestToolStripMenuItem_Click);
            // 
            // predmetiToolStripMenuItem
            // 
            this.predmetiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mojiPredmetiToolStripMenuItem});
            this.predmetiToolStripMenuItem.Name = "predmetiToolStripMenuItem";
            this.predmetiToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.predmetiToolStripMenuItem.Text = "Predmeti";
            // 
            // mojiPredmetiToolStripMenuItem
            // 
            this.mojiPredmetiToolStripMenuItem.Name = "mojiPredmetiToolStripMenuItem";
            this.mojiPredmetiToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.mojiPredmetiToolStripMenuItem.Text = "Moji predmeti";
            this.mojiPredmetiToolStripMenuItem.Click += new System.EventHandler(this.mojiPredmetiToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 467);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "eDnevnik";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem evidencijaČasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajČasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obavijestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledObavijestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajObavijestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predmetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mojiPredmetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evidencijaOcjenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajOcjenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmijeniOcjenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nastavničkiKadarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predmetiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem razrediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem učeniciToolStripMenuItem;
    }
}