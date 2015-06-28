namespace eShelvesDesktop.Knjige
{
    partial class UpravljanjeOcjenama
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
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.knjigaInput = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.knjigatraziButton = new System.Windows.Forms.Button();
			this.knjigeGrid = new System.Windows.Forms.DataGridView();
			this.knjigaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.korisniktraziButton = new System.Windows.Forms.Button();
			this.korisnikInput = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.korisniciGrid = new System.Windows.Forms.DataGridView();
			this.korisnikid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.ocjeneGrid = new System.Windows.Forms.DataGridView();
			this.ocjenaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ocjenio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label4 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.tabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.knjigeGrid)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.korisniciGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ocjeneGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.HotTrack = true;
			this.tabControl.ItemSize = new System.Drawing.Size(80, 30);
			this.tabControl.Location = new System.Drawing.Point(0, 35);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(549, 375);
			this.tabControl.TabIndex = 0;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
			this.tabControl.TabIndexChanged += new System.EventHandler(this.tabControl_TabIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.knjigaInput);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.knjigatraziButton);
			this.tabPage1.Controls.Add(this.knjigeGrid);
			this.tabPage1.Location = new System.Drawing.Point(4, 34);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(541, 337);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "po knjigama";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// knjigaInput
			// 
			this.knjigaInput.Location = new System.Drawing.Point(118, 8);
			this.knjigaInput.Name = "knjigaInput";
			this.knjigaInput.Size = new System.Drawing.Size(336, 20);
			this.knjigaInput.TabIndex = 3;
			this.knjigaInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Naziv knijge:";
			// 
			// knjigatraziButton
			// 
			this.knjigatraziButton.Location = new System.Drawing.Point(460, 6);
			this.knjigatraziButton.Name = "knjigatraziButton";
			this.knjigatraziButton.Size = new System.Drawing.Size(75, 23);
			this.knjigatraziButton.TabIndex = 1;
			this.knjigatraziButton.Text = "Traži";
			this.knjigatraziButton.UseVisualStyleBackColor = true;
			this.knjigatraziButton.Click += new System.EventHandler(this.knjigatraziButton_Click);
			// 
			// knjigeGrid
			// 
			this.knjigeGrid.AllowUserToAddRows = false;
			this.knjigeGrid.AllowUserToDeleteRows = false;
			this.knjigeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.knjigeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.knjigaid,
            this.naslov,
            this.isbn,
            this.autor});
			this.knjigeGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.knjigeGrid.Location = new System.Drawing.Point(3, 35);
			this.knjigeGrid.MultiSelect = false;
			this.knjigeGrid.Name = "knjigeGrid";
			this.knjigeGrid.ReadOnly = true;
			this.knjigeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.knjigeGrid.Size = new System.Drawing.Size(535, 299);
			this.knjigeGrid.TabIndex = 0;
			this.knjigeGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.knjigeGrid_CellClick);
			// 
			// knjigaid
			// 
			this.knjigaid.DataPropertyName = "Id";
			this.knjigaid.HeaderText = "";
			this.knjigaid.Name = "knjigaid";
			this.knjigaid.ReadOnly = true;
			this.knjigaid.Width = 50;
			// 
			// naslov
			// 
			this.naslov.DataPropertyName = "Naslov";
			this.naslov.HeaderText = "Naslov";
			this.naslov.Name = "naslov";
			this.naslov.ReadOnly = true;
			this.naslov.Width = 190;
			// 
			// isbn
			// 
			this.isbn.DataPropertyName = "ISBN";
			this.isbn.HeaderText = "ISBN";
			this.isbn.Name = "isbn";
			this.isbn.ReadOnly = true;
			// 
			// autor
			// 
			this.autor.DataPropertyName = "NazivAutora";
			this.autor.HeaderText = "Autor";
			this.autor.Name = "autor";
			this.autor.ReadOnly = true;
			this.autor.Width = 150;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.korisniktraziButton);
			this.tabPage2.Controls.Add(this.korisnikInput);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.korisniciGrid);
			this.tabPage2.Location = new System.Drawing.Point(4, 34);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(541, 337);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "po korisnicima";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// korisniktraziButton
			// 
			this.korisniktraziButton.Location = new System.Drawing.Point(460, 6);
			this.korisniktraziButton.Name = "korisniktraziButton";
			this.korisniktraziButton.Size = new System.Drawing.Size(75, 23);
			this.korisniktraziButton.TabIndex = 3;
			this.korisniktraziButton.Text = "Traži";
			this.korisniktraziButton.UseVisualStyleBackColor = true;
			this.korisniktraziButton.Click += new System.EventHandler(this.korisniktraziButton_Click);
			// 
			// korisnikInput
			// 
			this.korisnikInput.Location = new System.Drawing.Point(118, 8);
			this.korisnikInput.Name = "korisnikInput";
			this.korisnikInput.Size = new System.Drawing.Size(336, 20);
			this.korisnikInput.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 11);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "username korisnika:";
			// 
			// korisniciGrid
			// 
			this.korisniciGrid.AllowUserToAddRows = false;
			this.korisniciGrid.AllowUserToDeleteRows = false;
			this.korisniciGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.korisniciGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.korisnikid,
            this.ime,
            this.prezime,
            this.username,
            this.email});
			this.korisniciGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.korisniciGrid.Location = new System.Drawing.Point(3, 35);
			this.korisniciGrid.MultiSelect = false;
			this.korisniciGrid.Name = "korisniciGrid";
			this.korisniciGrid.ReadOnly = true;
			this.korisniciGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.korisniciGrid.Size = new System.Drawing.Size(535, 299);
			this.korisniciGrid.TabIndex = 0;
			this.korisniciGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.korisniciGrid_CellClick);
			// 
			// korisnikid
			// 
			this.korisnikid.DataPropertyName = "Id";
			this.korisnikid.HeaderText = "";
			this.korisnikid.Name = "korisnikid";
			this.korisnikid.ReadOnly = true;
			this.korisnikid.Width = 50;
			// 
			// ime
			// 
			this.ime.DataPropertyName = "Ime";
			this.ime.HeaderText = "Ime";
			this.ime.Name = "ime";
			this.ime.ReadOnly = true;
			// 
			// prezime
			// 
			this.prezime.DataPropertyName = "Prezime";
			this.prezime.HeaderText = "Prezime";
			this.prezime.Name = "prezime";
			this.prezime.ReadOnly = true;
			// 
			// username
			// 
			this.username.DataPropertyName = "username";
			this.username.HeaderText = "username";
			this.username.Name = "username";
			this.username.ReadOnly = true;
			this.username.Width = 110;
			// 
			// email
			// 
			this.email.DataPropertyName = "Email";
			this.email.HeaderText = "E-mail";
			this.email.Name = "email";
			this.email.ReadOnly = true;
			this.email.Width = 130;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(220, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "*Note: odaberite po čemu želite tražiti ocjene.";
			// 
			// ocjeneGrid
			// 
			this.ocjeneGrid.AllowUserToAddRows = false;
			this.ocjeneGrid.AllowUserToDeleteRows = false;
			this.ocjeneGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ocjeneGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ocjenaid,
            this.ocjenio,
            this.ocjena,
            this.opis});
			this.ocjeneGrid.Location = new System.Drawing.Point(555, 104);
			this.ocjeneGrid.Name = "ocjeneGrid";
			this.ocjeneGrid.ReadOnly = true;
			this.ocjeneGrid.RowHeadersVisible = false;
			this.ocjeneGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ocjeneGrid.Size = new System.Drawing.Size(272, 299);
			this.ocjeneGrid.TabIndex = 2;
			this.ocjeneGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ocjeneGrid_CellDoubleClick);
			// 
			// ocjenaid
			// 
			this.ocjenaid.DataPropertyName = "OcjenaID";
			this.ocjenaid.HeaderText = "";
			this.ocjenaid.Name = "ocjenaid";
			this.ocjenaid.ReadOnly = true;
			this.ocjenaid.Visible = false;
			// 
			// ocjenio
			// 
			this.ocjenio.DataPropertyName = "username";
			this.ocjenio.HeaderText = "Ocjenio";
			this.ocjenio.Name = "ocjenio";
			this.ocjenio.ReadOnly = true;
			this.ocjenio.Width = 80;
			// 
			// ocjena
			// 
			this.ocjena.DataPropertyName = "Ocjena";
			this.ocjena.HeaderText = "Ocjena";
			this.ocjena.Name = "ocjena";
			this.ocjena.ReadOnly = true;
			this.ocjena.Width = 60;
			// 
			// opis
			// 
			this.opis.DataPropertyName = "Opis";
			this.opis.HeaderText = "Opis";
			this.opis.Name = "opis";
			this.opis.ReadOnly = true;
			this.opis.Width = 127;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(555, 77);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Ocjene";
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button3.Location = new System.Drawing.Point(671, 35);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(151, 48);
			this.button3.TabIndex = 4;
			this.button3.Text = "Obriši odabrane ocjene";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(674, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(148, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "*Note: dupli klik otvara detalje";
			// 
			// UpravljanjeOcjenama
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 409);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.ocjeneGrid);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tabControl);
			this.Name = "UpravljanjeOcjenama";
			this.Text = "Upravljanje ocjenama";
			this.Load += new System.EventHandler(this.UpravljanjeOcjenama_Load);
			this.tabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.knjigeGrid)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.korisniciGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ocjeneGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox knjigaInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button knjigatraziButton;
        private System.Windows.Forms.DataGridView knjigeGrid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView korisniciGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button korisniktraziButton;
        private System.Windows.Forms.TextBox korisnikInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ocjeneGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn knjigaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocjenaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocjenio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn opis;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
    }
}