namespace eShelvesDesktop
{
    partial class AdministracijaPolicama
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
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.traziButton = new System.Windows.Forms.Button();
            this.korisniciGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.policeGrid = new System.Windows.Forms.DataGridView();
            this.PolicaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brKnjiga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime:";
            // 
            // usernameInput
            // 
            this.usernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameInput.Location = new System.Drawing.Point(171, 9);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(319, 26);
            this.usernameInput.TabIndex = 1;
            // 
            // traziButton
            // 
            this.traziButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.traziButton.Location = new System.Drawing.Point(496, 9);
            this.traziButton.Name = "traziButton";
            this.traziButton.Size = new System.Drawing.Size(75, 27);
            this.traziButton.TabIndex = 2;
            this.traziButton.Text = "Traži";
            this.traziButton.UseVisualStyleBackColor = true;
            this.traziButton.Click += new System.EventHandler(this.traziButton_Click);
            // 
            // korisniciGrid
            // 
            this.korisniciGrid.AllowUserToAddRows = false;
            this.korisniciGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.korisniciGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.username,
            this.Ime,
            this.Prezime,
            this.Email,
            this.created_at});
            this.korisniciGrid.Location = new System.Drawing.Point(12, 41);
            this.korisniciGrid.Name = "korisniciGrid";
            this.korisniciGrid.ReadOnly = true;
            this.korisniciGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.korisniciGrid.Size = new System.Drawing.Size(645, 255);
            this.korisniciGrid.TabIndex = 4;
            this.korisniciGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.korisniciGrid_CellClick);
            this.korisniciGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.korisniciGrid_CellContentClick);
            this.korisniciGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.korisniciGrid_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "e-mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // created_at
            // 
            this.created_at.DataPropertyName = "created_at";
            this.created_at.HeaderText = "created_at";
            this.created_at.Name = "created_at";
            this.created_at.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Police korisnika";
            // 
            // policeGrid
            // 
            this.policeGrid.AllowUserToAddRows = false;
            this.policeGrid.AllowUserToDeleteRows = false;
            this.policeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.policeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PolicaID,
            this.naziv,
            this.brKnjiga});
            this.policeGrid.Location = new System.Drawing.Point(16, 342);
            this.policeGrid.Name = "policeGrid";
            this.policeGrid.ReadOnly = true;
            this.policeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.policeGrid.Size = new System.Drawing.Size(345, 150);
            this.policeGrid.TabIndex = 6;
            this.policeGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.policeGrid_CellContentDoubleClick);
            this.policeGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.policeGrid_CellDoubleClick);
            // 
            // PolicaID
            // 
            this.PolicaID.DataPropertyName = "Id";
            this.PolicaID.HeaderText = "";
            this.PolicaID.Name = "PolicaID";
            this.PolicaID.ReadOnly = true;
            // 
            // naziv
            // 
            this.naziv.DataPropertyName = "Naziv";
            this.naziv.HeaderText = "Naziv";
            this.naziv.Name = "naziv";
            this.naziv.ReadOnly = true;
            // 
            // brKnjiga
            // 
            this.brKnjiga.DataPropertyName = "BookCount";
            this.brKnjiga.HeaderText = "br Knjiga";
            this.brKnjiga.Name = "brKnjiga";
            this.brKnjiga.ReadOnly = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(376, 342);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(230, 150);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "1. Odaberite korisnika lijevim klikom\n2. Dupli klik na policu ispod otvara novu f" +
    "ormu";
            // 
            // AdministracijaPolicama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 504);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.policeGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.korisniciGrid);
            this.Controls.Add(this.traziButton);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.label1);
            this.Name = "AdministracijaPolicama";
            this.Text = "Administracija policama";
            this.Load += new System.EventHandler(this.AdministracijaPolicama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.korisniciGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Button traziButton;
        private System.Windows.Forms.DataGridView korisniciGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView policeGrid;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolicaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn brKnjiga;
    }
}