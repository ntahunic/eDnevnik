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
            this.evidencijaČasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajČasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajIzostanakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.evidencijaČasaToolStripMenuItem,
            this.obavijestiToolStripMenuItem,
            this.predmetiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(538, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // evidencijaČasaToolStripMenuItem
            // 
            this.evidencijaČasaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajČasToolStripMenuItem,
            this.dodajIzostanakToolStripMenuItem});
            this.evidencijaČasaToolStripMenuItem.Name = "evidencijaČasaToolStripMenuItem";
            this.evidencijaČasaToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.evidencijaČasaToolStripMenuItem.Text = "Evidencija časa";
            // 
            // dodajČasToolStripMenuItem
            // 
            this.dodajČasToolStripMenuItem.Name = "dodajČasToolStripMenuItem";
            this.dodajČasToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.dodajČasToolStripMenuItem.Text = "Dodaj čas";
            this.dodajČasToolStripMenuItem.Click += new System.EventHandler(this.dodajČasToolStripMenuItem_Click);
            // 
            // dodajIzostanakToolStripMenuItem
            // 
            this.dodajIzostanakToolStripMenuItem.Name = "dodajIzostanakToolStripMenuItem";
            this.dodajIzostanakToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.dodajIzostanakToolStripMenuItem.Text = "Dodaj izostanak";
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
            // 
            // dodajObavijestToolStripMenuItem
            // 
            this.dodajObavijestToolStripMenuItem.Name = "dodajObavijestToolStripMenuItem";
            this.dodajObavijestToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.dodajObavijestToolStripMenuItem.Text = "Dodaj obavijest";
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
        private System.Windows.Forms.ToolStripMenuItem dodajIzostanakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obavijestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledObavijestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajObavijestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predmetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mojiPredmetiToolStripMenuItem;
    }
}