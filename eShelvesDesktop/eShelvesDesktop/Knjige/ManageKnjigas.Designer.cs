namespace eShelvesDesktop
{
    partial class ManageKnjigas
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
			this.traziButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.searchInput = new System.Windows.Forms.TextBox();
			this.novaknjigabutton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ocjeneGrid = new System.Windows.Forms.DataGridView();
			this.reviewerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ocjeneGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// traziButton
			// 
			this.traziButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.traziButton.Location = new System.Drawing.Point(609, 23);
			this.traziButton.Name = "traziButton";
			this.traziButton.Size = new System.Drawing.Size(75, 26);
			this.traziButton.TabIndex = 0;
			this.traziButton.Text = "traži";
			this.traziButton.UseVisualStyleBackColor = true;
			this.traziButton.Click += new System.EventHandler(this.traziButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(12, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Naslov ili autor:";
			// 
			// searchInput
			// 
			this.searchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.searchInput.Location = new System.Drawing.Point(132, 23);
			this.searchInput.Name = "searchInput";
			this.searchInput.Size = new System.Drawing.Size(471, 26);
			this.searchInput.TabIndex = 2;
			// 
			// novaknjigabutton
			// 
			this.novaknjigabutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.novaknjigabutton.Location = new System.Drawing.Point(701, 16);
			this.novaknjigabutton.Name = "novaknjigabutton";
			this.novaknjigabutton.Size = new System.Drawing.Size(100, 40);
			this.novaknjigabutton.TabIndex = 3;
			this.novaknjigabutton.Text = "Nova knjiga";
			this.novaknjigabutton.UseVisualStyleBackColor = true;
			this.novaknjigabutton.Click += new System.EventHandler(this.novaknjigabutton_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naslov,
            this.Autor,
            this.ISBN});
			this.dataGridView1.Location = new System.Drawing.Point(0, 92);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(544, 396);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			// 
			// Naslov
			// 
			this.Naslov.DataPropertyName = "Naslov";
			this.Naslov.HeaderText = "naslov";
			this.Naslov.Name = "Naslov";
			this.Naslov.ReadOnly = true;
			this.Naslov.Width = 200;
			// 
			// Autor
			// 
			this.Autor.DataPropertyName = "NazivAutora";
			this.Autor.HeaderText = "autor";
			this.Autor.Name = "Autor";
			this.Autor.ReadOnly = true;
			// 
			// ISBN
			// 
			this.ISBN.DataPropertyName = "ISBN";
			this.ISBN.HeaderText = "isbn";
			this.ISBN.Name = "ISBN";
			this.ISBN.ReadOnly = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(12, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Knjige";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(545, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Ocjene";
			// 
			// ocjeneGrid
			// 
			this.ocjeneGrid.AllowUserToAddRows = false;
			this.ocjeneGrid.AllowUserToDeleteRows = false;
			this.ocjeneGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ocjeneGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reviewerid,
            this.username,
            this.ocjena,
            this.opis});
			this.ocjeneGrid.Location = new System.Drawing.Point(549, 92);
			this.ocjeneGrid.Name = "ocjeneGrid";
			this.ocjeneGrid.ReadOnly = true;
			this.ocjeneGrid.RowHeadersVisible = false;
			this.ocjeneGrid.RowTemplate.Height = 60;
			this.ocjeneGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ocjeneGrid.Size = new System.Drawing.Size(265, 396);
			this.ocjeneGrid.TabIndex = 7;
			// 
			// reviewerid
			// 
			this.reviewerid.DataPropertyName = "KorisnikId";
			this.reviewerid.HeaderText = "";
			this.reviewerid.Name = "reviewerid";
			this.reviewerid.ReadOnly = true;
			this.reviewerid.Visible = false;
			// 
			// username
			// 
			this.username.DataPropertyName = "username";
			this.username.HeaderText = "Korisnik";
			this.username.Name = "username";
			this.username.ReadOnly = true;
			this.username.Width = 60;
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
			this.opis.Width = 140;
			// 
			// ManageKnjigas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(814, 488);
			this.Controls.Add(this.ocjeneGrid);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.novaknjigabutton);
			this.Controls.Add(this.searchInput);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.traziButton);
			this.Name = "ManageKnjigas";
			this.Text = "Upravljanje knjigama";
			this.Load += new System.EventHandler(this.ManageKnjigas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ocjeneGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button traziButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button novaknjigabutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ocjeneGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn opis;
    }
}