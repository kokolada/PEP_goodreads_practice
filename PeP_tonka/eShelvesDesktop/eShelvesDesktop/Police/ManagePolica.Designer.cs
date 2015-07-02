namespace eShelvesDesktop.Police
{
    partial class ManagePolica
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.nazivLabel = new System.Windows.Forms.Label();
            this.knjigeGrid = new System.Windows.Forms.DataGridView();
            this.knjigaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objavljena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.ukloniButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.naslovInput = new System.Windows.Forms.TextBox();
            this.traziButton = new System.Windows.Forms.Button();
            this.pretragaGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slika2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.naslov2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objavljena2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodajButton = new System.Windows.Forms.Button();
            this.policaidLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.knjigeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretragaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Polica korisnika:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(219, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Naziv:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameLabel.Location = new System.Drawing.Point(139, 9);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(17, 20);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "k";
            // 
            // nazivLabel
            // 
            this.nazivLabel.AutoSize = true;
            this.nazivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazivLabel.Location = new System.Drawing.Point(276, 9);
            this.nazivLabel.Name = "nazivLabel";
            this.nazivLabel.Size = new System.Drawing.Size(18, 20);
            this.nazivLabel.TabIndex = 5;
            this.nazivLabel.Text = "n";
            // 
            // knjigeGrid
            // 
            this.knjigeGrid.AllowUserToAddRows = false;
            this.knjigeGrid.AllowUserToDeleteRows = false;
            this.knjigeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.knjigeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.knjigaid,
            this.slika,
            this.naslov,
            this.isbn,
            this.objavljena,
            this.autor});
            this.knjigeGrid.Location = new System.Drawing.Point(12, 69);
            this.knjigeGrid.Name = "knjigeGrid";
            this.knjigeGrid.ReadOnly = true;
            this.knjigeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.knjigeGrid.Size = new System.Drawing.Size(669, 279);
            this.knjigeGrid.TabIndex = 6;
            // 
            // knjigaid
            // 
            this.knjigaid.DataPropertyName = "Id";
            this.knjigaid.HeaderText = "";
            this.knjigaid.Name = "knjigaid";
            this.knjigaid.ReadOnly = true;
            // 
            // slika
            // 
            this.slika.DataPropertyName = "Slika";
            this.slika.HeaderText = "Slika";
            this.slika.Name = "slika";
            this.slika.ReadOnly = true;
            this.slika.Width = 102;
            // 
            // naslov
            // 
            this.naslov.DataPropertyName = "Naslov";
            this.naslov.HeaderText = "Naslov";
            this.naslov.Name = "naslov";
            this.naslov.ReadOnly = true;
            // 
            // isbn
            // 
            this.isbn.DataPropertyName = "ISBN";
            this.isbn.HeaderText = "ISBN";
            this.isbn.Name = "isbn";
            this.isbn.ReadOnly = true;
            // 
            // objavljena
            // 
            this.objavljena.DataPropertyName = "Objavljena";
            this.objavljena.HeaderText = "Objavljena";
            this.objavljena.Name = "objavljena";
            this.objavljena.ReadOnly = true;
            // 
            // autor
            // 
            this.autor.DataPropertyName = "AutorID";
            this.autor.HeaderText = "Autor";
            this.autor.Name = "autor";
            this.autor.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Knjige u polici";
            // 
            // ukloniButton
            // 
            this.ukloniButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ukloniButton.Location = new System.Drawing.Point(687, 69);
            this.ukloniButton.Name = "ukloniButton";
            this.ukloniButton.Size = new System.Drawing.Size(150, 70);
            this.ukloniButton.TabIndex = 8;
            this.ukloniButton.Text = "Ukloni označenu knjigu";
            this.ukloniButton.UseVisualStyleBackColor = true;
            this.ukloniButton.Click += new System.EventHandler(this.ukloniButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pretraga knjiga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Naslov ili autor:";
            // 
            // naslovInput
            // 
            this.naslovInput.Location = new System.Drawing.Point(98, 391);
            this.naslovInput.Name = "naslovInput";
            this.naslovInput.Size = new System.Drawing.Size(334, 20);
            this.naslovInput.TabIndex = 11;
            // 
            // traziButton
            // 
            this.traziButton.Location = new System.Drawing.Point(438, 389);
            this.traziButton.Name = "traziButton";
            this.traziButton.Size = new System.Drawing.Size(75, 23);
            this.traziButton.TabIndex = 12;
            this.traziButton.Text = "Traži";
            this.traziButton.UseVisualStyleBackColor = true;
            this.traziButton.Click += new System.EventHandler(this.traziButton_Click);
            // 
            // pretragaGrid
            // 
            this.pretragaGrid.AllowUserToAddRows = false;
            this.pretragaGrid.AllowUserToDeleteRows = false;
            this.pretragaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pretragaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.slika2,
            this.naslov2,
            this.isbn2,
            this.objavljena2,
            this.autor2});
            this.pretragaGrid.Location = new System.Drawing.Point(12, 417);
            this.pretragaGrid.Name = "pretragaGrid";
            this.pretragaGrid.ReadOnly = true;
            this.pretragaGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pretragaGrid.Size = new System.Drawing.Size(669, 203);
            this.pretragaGrid.TabIndex = 13;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // slika2
            // 
            this.slika2.DataPropertyName = "Slika";
            this.slika2.HeaderText = "Slika";
            this.slika2.Name = "slika2";
            this.slika2.ReadOnly = true;
            // 
            // naslov2
            // 
            this.naslov2.DataPropertyName = "Naslov";
            this.naslov2.HeaderText = "Naslov";
            this.naslov2.Name = "naslov2";
            this.naslov2.ReadOnly = true;
            // 
            // isbn2
            // 
            this.isbn2.DataPropertyName = "ISBN";
            this.isbn2.HeaderText = "ISBN";
            this.isbn2.Name = "isbn2";
            this.isbn2.ReadOnly = true;
            // 
            // objavljena2
            // 
            this.objavljena2.DataPropertyName = "Objavljena";
            this.objavljena2.HeaderText = "Objavljena";
            this.objavljena2.Name = "objavljena2";
            this.objavljena2.ReadOnly = true;
            // 
            // autor2
            // 
            this.autor2.DataPropertyName = "NazivAutora";
            this.autor2.HeaderText = "Autor";
            this.autor2.Name = "autor2";
            this.autor2.ReadOnly = true;
            // 
            // dodajButton
            // 
            this.dodajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajButton.Location = new System.Drawing.Point(687, 417);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(150, 70);
            this.dodajButton.TabIndex = 14;
            this.dodajButton.Text = "Dodaj označenu knjigu";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // policaidLabel
            // 
            this.policaidLabel.AutoSize = true;
            this.policaidLabel.Location = new System.Drawing.Point(344, 13);
            this.policaidLabel.Name = "policaidLabel";
            this.policaidLabel.Size = new System.Drawing.Size(0, 13);
            this.policaidLabel.TabIndex = 15;
            this.policaidLabel.Visible = false;
            // 
            // ManagePolica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 632);
            this.Controls.Add(this.policaidLabel);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.pretragaGrid);
            this.Controls.Add(this.traziButton);
            this.Controls.Add(this.naslovInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ukloniButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.knjigeGrid);
            this.Controls.Add(this.nazivLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ManagePolica";
            this.Text = "Upravljanje policama";
            this.Load += new System.EventHandler(this.ManagePolica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.knjigeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretragaGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label nazivLabel;
        private System.Windows.Forms.DataGridView knjigeGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn knjigaid;
        private System.Windows.Forms.DataGridViewImageColumn slika;
        private System.Windows.Forms.DataGridViewTextBoxColumn naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objavljena;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
        private System.Windows.Forms.Button ukloniButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox naslovInput;
        private System.Windows.Forms.Button traziButton;
        private System.Windows.Forms.DataGridView pretragaGrid;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewImageColumn slika2;
        private System.Windows.Forms.DataGridViewTextBoxColumn naslov2;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn objavljena2;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor2;
        private System.Windows.Forms.Label policaidLabel;
    }
}