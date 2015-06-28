namespace eShelvesDesktop.Autori
{
    partial class EvidencijaAutora
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.imeInput = new System.Windows.Forms.TextBox();
			this.rodjenPicker = new System.Windows.Forms.DateTimePicker();
			this.kategorijeListBox = new System.Windows.Forms.CheckedListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.opisInput = new System.Windows.Forms.RichTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.prezimeInput = new System.Windows.Forms.TextBox();
			this.gradInput = new System.Windows.Forms.TextBox();
			this.webInput = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.ponistiButton = new System.Windows.Forms.Button();
			this.dodajButton = new System.Windows.Forms.Button();
			this.autoriGrid = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rodjen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label8 = new System.Windows.Forms.Label();
			this.searchInput = new System.Windows.Forms.TextBox();
			this.traziButton = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.autoriGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(87, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ime:";
			// 
			// imeInput
			// 
			this.imeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.imeInput.Location = new System.Drawing.Point(133, 18);
			this.imeInput.Name = "imeInput";
			this.imeInput.Size = new System.Drawing.Size(204, 26);
			this.imeInput.TabIndex = 1;
			this.imeInput.Validating += new System.ComponentModel.CancelEventHandler(this.imeInput_Validating);
			// 
			// rodjenPicker
			// 
			this.rodjenPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.rodjenPicker.Location = new System.Drawing.Point(133, 100);
			this.rodjenPicker.Name = "rodjenPicker";
			this.rodjenPicker.Size = new System.Drawing.Size(204, 26);
			this.rodjenPicker.TabIndex = 2;
			// 
			// kategorijeListBox
			// 
			this.kategorijeListBox.CheckOnClick = true;
			this.kategorijeListBox.FormattingEnabled = true;
			this.kategorijeListBox.Location = new System.Drawing.Point(424, 18);
			this.kategorijeListBox.Name = "kategorijeListBox";
			this.kategorijeListBox.Size = new System.Drawing.Size(204, 94);
			this.kategorijeListBox.TabIndex = 3;
			this.kategorijeListBox.Validating += new System.ComponentModel.CancelEventHandler(this.kategorijeListBox_Validating);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(57, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Prezime:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(66, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Rođen:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(10, 144);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(117, 20);
			this.label5.TabIndex = 7;
			this.label5.Text = "Mjesto rođenja:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(21, 185);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Web stranica:";
			// 
			// opisInput
			// 
			this.opisInput.Location = new System.Drawing.Point(424, 118);
			this.opisInput.Name = "opisInput";
			this.opisInput.Size = new System.Drawing.Size(204, 96);
			this.opisInput.TabIndex = 9;
			this.opisInput.Text = "";
			this.opisInput.Validating += new System.ComponentModel.CancelEventHandler(this.opisInput_Validating);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.Location = new System.Drawing.Point(373, 118);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 20);
			this.label6.TabIndex = 10;
			this.label6.Text = "Opis:";
			// 
			// prezimeInput
			// 
			this.prezimeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.prezimeInput.Location = new System.Drawing.Point(133, 59);
			this.prezimeInput.Name = "prezimeInput";
			this.prezimeInput.Size = new System.Drawing.Size(204, 26);
			this.prezimeInput.TabIndex = 11;
			this.prezimeInput.Validating += new System.ComponentModel.CancelEventHandler(this.prezimeInput_Validating);
			// 
			// gradInput
			// 
			this.gradInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.gradInput.Location = new System.Drawing.Point(133, 141);
			this.gradInput.Name = "gradInput";
			this.gradInput.Size = new System.Drawing.Size(204, 26);
			this.gradInput.TabIndex = 12;
			this.gradInput.Validating += new System.ComponentModel.CancelEventHandler(this.gradInput_Validating);
			// 
			// webInput
			// 
			this.webInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.webInput.Location = new System.Drawing.Point(133, 182);
			this.webInput.Name = "webInput";
			this.webInput.Size = new System.Drawing.Size(204, 26);
			this.webInput.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label7.Location = new System.Drawing.Point(353, 21);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 20);
			this.label7.TabIndex = 14;
			this.label7.Text = "Žanrovi:";
			// 
			// ponistiButton
			// 
			this.ponistiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ponistiButton.Location = new System.Drawing.Point(492, 236);
			this.ponistiButton.Name = "ponistiButton";
			this.ponistiButton.Size = new System.Drawing.Size(78, 48);
			this.ponistiButton.TabIndex = 15;
			this.ponistiButton.Text = "Poništi";
			this.ponistiButton.UseVisualStyleBackColor = true;
			this.ponistiButton.Click += new System.EventHandler(this.ponistiButton_Click);
			// 
			// dodajButton
			// 
			this.dodajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.dodajButton.Location = new System.Drawing.Point(576, 236);
			this.dodajButton.Name = "dodajButton";
			this.dodajButton.Size = new System.Drawing.Size(78, 48);
			this.dodajButton.TabIndex = 16;
			this.dodajButton.Text = "Dodaj";
			this.dodajButton.UseVisualStyleBackColor = true;
			this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
			// 
			// autoriGrid
			// 
			this.autoriGrid.AllowUserToAddRows = false;
			this.autoriGrid.AllowUserToDeleteRows = false;
			this.autoriGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.autoriGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ime,
            this.prezime,
            this.rodjen,
            this.grad});
			this.autoriGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.autoriGrid.Location = new System.Drawing.Point(0, 310);
			this.autoriGrid.Name = "autoriGrid";
			this.autoriGrid.ReadOnly = true;
			this.autoriGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.autoriGrid.Size = new System.Drawing.Size(666, 228);
			this.autoriGrid.TabIndex = 17;
			this.autoriGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.autoriGrid_CellDoubleClick);
			this.autoriGrid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.autoriGrid_MouseUp);
			// 
			// id
			// 
			this.id.DataPropertyName = "Id";
			this.id.HeaderText = "";
			this.id.Name = "id";
			this.id.ReadOnly = true;
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
			// rodjen
			// 
			this.rodjen.DataPropertyName = "Rodjen";
			this.rodjen.HeaderText = "Rođen";
			this.rodjen.Name = "rodjen";
			this.rodjen.ReadOnly = true;
			// 
			// grad
			// 
			this.grad.DataPropertyName = "MjestoRodjenja";
			this.grad.HeaderText = "Grad";
			this.grad.Name = "grad";
			this.grad.ReadOnly = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label8.Location = new System.Drawing.Point(10, 250);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(107, 20);
			this.label8.TabIndex = 18;
			this.label8.Text = "Ime i prezime:";
			// 
			// searchInput
			// 
			this.searchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.searchInput.Location = new System.Drawing.Point(123, 247);
			this.searchInput.Name = "searchInput";
			this.searchInput.Size = new System.Drawing.Size(333, 26);
			this.searchInput.TabIndex = 19;
			// 
			// traziButton
			// 
			this.traziButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.traziButton.Location = new System.Drawing.Point(396, 279);
			this.traziButton.Name = "traziButton";
			this.traziButton.Size = new System.Drawing.Size(60, 25);
			this.traziButton.TabIndex = 20;
			this.traziButton.Text = "Traži";
			this.traziButton.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(13, 290);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(246, 13);
			this.label9.TabIndex = 21;
			this.label9.Text = "*Note: duplim klikom na autora mozete ga editovati";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(13, 276);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(287, 13);
			this.label10.TabIndex = 22;
			this.label10.Text = "*Note: desnim klikom na autora u gridu istog možete obrisati";
			// 
			// errorProvider
			// 
			this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			// 
			// EvidencijaAutora
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(666, 538);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.traziButton);
			this.Controls.Add(this.searchInput);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.autoriGrid);
			this.Controls.Add(this.dodajButton);
			this.Controls.Add(this.ponistiButton);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.webInput);
			this.Controls.Add(this.gradInput);
			this.Controls.Add(this.prezimeInput);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.opisInput);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.kategorijeListBox);
			this.Controls.Add(this.rodjenPicker);
			this.Controls.Add(this.imeInput);
			this.Controls.Add(this.label1);
			this.Name = "EvidencijaAutora";
			this.Text = "EvidencijaAutora";
			this.Load += new System.EventHandler(this.EvidencijaAutora_Load);
			((System.ComponentModel.ISupportInitialize)(this.autoriGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imeInput;
        private System.Windows.Forms.DateTimePicker rodjenPicker;
        private System.Windows.Forms.CheckedListBox kategorijeListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox opisInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox prezimeInput;
        private System.Windows.Forms.TextBox gradInput;
        private System.Windows.Forms.TextBox webInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ponistiButton;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.DataGridView autoriGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodjen;
        private System.Windows.Forms.DataGridViewTextBoxColumn grad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button traziButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ErrorProvider errorProvider;
    }
}