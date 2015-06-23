namespace eShelvesDesktop
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
            this.knjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaKnjigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageKnjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addKorisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageKorisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.knjigeToolStripMenuItem,
            this.korisniciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(916, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // knjigeToolStripMenuItem
            // 
            this.knjigeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaKnjigaToolStripMenuItem,
            this.manageKnjigeToolStripMenuItem});
            this.knjigeToolStripMenuItem.Name = "knjigeToolStripMenuItem";
            this.knjigeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.knjigeToolStripMenuItem.Text = "Knjige";
            // 
            // novaKnjigaToolStripMenuItem
            // 
            this.novaKnjigaToolStripMenuItem.Name = "novaKnjigaToolStripMenuItem";
            this.novaKnjigaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.novaKnjigaToolStripMenuItem.Text = "Nova knjiga";
            this.novaKnjigaToolStripMenuItem.Click += new System.EventHandler(this.novaKnjigaToolStripMenuItem_Click);
            // 
            // manageKnjigeToolStripMenuItem
            // 
            this.manageKnjigeToolStripMenuItem.Name = "manageKnjigeToolStripMenuItem";
            this.manageKnjigeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.manageKnjigeToolStripMenuItem.Text = "Manage knjige";
            this.manageKnjigeToolStripMenuItem.Click += new System.EventHandler(this.manageKnjigeToolStripMenuItem_Click);
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addKorisnikToolStripMenuItem,
            this.manageKorisniciToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // addKorisnikToolStripMenuItem
            // 
            this.addKorisnikToolStripMenuItem.Name = "addKorisnikToolStripMenuItem";
            this.addKorisnikToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addKorisnikToolStripMenuItem.Text = "Add korisnik";
            this.addKorisnikToolStripMenuItem.Click += new System.EventHandler(this.addKorisnikToolStripMenuItem_Click);
            // 
            // manageKorisniciToolStripMenuItem
            // 
            this.manageKorisniciToolStripMenuItem.Name = "manageKorisniciToolStripMenuItem";
            this.manageKorisniciToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.manageKorisniciToolStripMenuItem.Text = "Manage korisnici";
            this.manageKorisniciToolStripMenuItem.Click += new System.EventHandler(this.manageKorisniciToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 560);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem knjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaKnjigaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageKnjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addKorisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageKorisniciToolStripMenuItem;
    }
}