namespace eShelvesDesktop
{
    partial class AddKnjiga
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
			this.objavljenaDatePicker = new System.Windows.Forms.DateTimePicker();
			this.autorComboBox = new System.Windows.Forms.ComboBox();
			this.naslovInput = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.ISBNInput = new System.Windows.Forms.TextBox();
			this.opisInput = new System.Windows.Forms.TextBox();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.slikaInput = new System.Windows.Forms.TextBox();
			this.dodajButton = new System.Windows.Forms.Button();
			this.sacuvajButton = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.kategorijeListBox = new System.Windows.Forms.CheckedListBox();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(37, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Naslov:";
			// 
			// objavljenaDatePicker
			// 
			this.objavljenaDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.objavljenaDatePicker.Location = new System.Drawing.Point(103, 107);
			this.objavljenaDatePicker.Name = "objavljenaDatePicker";
			this.objavljenaDatePicker.Size = new System.Drawing.Size(200, 26);
			this.objavljenaDatePicker.TabIndex = 1;
			// 
			// autorComboBox
			// 
			this.autorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.autorComboBox.FormattingEnabled = true;
			this.autorComboBox.Location = new System.Drawing.Point(103, 148);
			this.autorComboBox.Name = "autorComboBox";
			this.autorComboBox.Size = new System.Drawing.Size(200, 28);
			this.autorComboBox.TabIndex = 2;
			this.autorComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.autorComboBox_Validating);
			// 
			// naslovInput
			// 
			this.naslovInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.naslovInput.Location = new System.Drawing.Point(103, 25);
			this.naslovInput.Name = "naslovInput";
			this.naslovInput.Size = new System.Drawing.Size(200, 26);
			this.naslovInput.TabIndex = 3;
			this.naslovInput.Validating += new System.ComponentModel.CancelEventHandler(this.naslovInput_Validating);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(11, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Objavljena:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(46, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "ISBN:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(52, 196);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Opis:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(45, 151);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 20);
			this.label5.TabIndex = 7;
			this.label5.Text = "Autor:";
			// 
			// ISBNInput
			// 
			this.ISBNInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ISBNInput.Location = new System.Drawing.Point(103, 66);
			this.ISBNInput.Name = "ISBNInput";
			this.ISBNInput.Size = new System.Drawing.Size(200, 26);
			this.ISBNInput.TabIndex = 8;
			this.ISBNInput.Validating += new System.ComponentModel.CancelEventHandler(this.ISBNInput_Validating);
			// 
			// opisInput
			// 
			this.opisInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.opisInput.Location = new System.Drawing.Point(103, 193);
			this.opisInput.Multiline = true;
			this.opisInput.Name = "opisInput";
			this.opisInput.Size = new System.Drawing.Size(540, 169);
			this.opisInput.TabIndex = 9;
			this.opisInput.Validating += new System.ComponentModel.CancelEventHandler(this.opisInput_Validating);
			// 
			// pictureBox
			// 
			this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox.Location = new System.Drawing.Point(523, 28);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(120, 120);
			this.pictureBox.TabIndex = 10;
			this.pictureBox.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.Location = new System.Drawing.Point(50, 381);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 20);
			this.label6.TabIndex = 11;
			this.label6.Text = "Slika:";
			// 
			// slikaInput
			// 
			this.slikaInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.slikaInput.Location = new System.Drawing.Point(103, 378);
			this.slikaInput.Name = "slikaInput";
			this.slikaInput.Size = new System.Drawing.Size(200, 26);
			this.slikaInput.TabIndex = 12;
			// 
			// dodajButton
			// 
			this.dodajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.dodajButton.Location = new System.Drawing.Point(309, 378);
			this.dodajButton.Name = "dodajButton";
			this.dodajButton.Size = new System.Drawing.Size(75, 26);
			this.dodajButton.TabIndex = 13;
			this.dodajButton.Text = "Dodaj";
			this.dodajButton.UseVisualStyleBackColor = true;
			this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
			// 
			// sacuvajButton
			// 
			this.sacuvajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.sacuvajButton.Location = new System.Drawing.Point(523, 422);
			this.sacuvajButton.Name = "sacuvajButton";
			this.sacuvajButton.Size = new System.Drawing.Size(120, 53);
			this.sacuvajButton.TabIndex = 14;
			this.sacuvajButton.Text = "Sačuvaj";
			this.sacuvajButton.UseVisualStyleBackColor = true;
			this.sacuvajButton.Click += new System.EventHandler(this.sacuvajButton_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			// 
			// kategorijeListBox
			// 
			this.kategorijeListBox.CheckOnClick = true;
			this.kategorijeListBox.FormattingEnabled = true;
			this.kategorijeListBox.Location = new System.Drawing.Point(325, 25);
			this.kategorijeListBox.Name = "kategorijeListBox";
			this.kategorijeListBox.Size = new System.Drawing.Size(159, 154);
			this.kategorijeListBox.TabIndex = 15;
			this.kategorijeListBox.Validating += new System.ComponentModel.CancelEventHandler(this.kategorijeListBox_Validating);
			// 
			// errorProvider
			// 
			this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			// 
			// AddKnjiga
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(665, 487);
			this.Controls.Add(this.kategorijeListBox);
			this.Controls.Add(this.sacuvajButton);
			this.Controls.Add(this.dodajButton);
			this.Controls.Add(this.slikaInput);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.opisInput);
			this.Controls.Add(this.ISBNInput);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.naslovInput);
			this.Controls.Add(this.autorComboBox);
			this.Controls.Add(this.objavljenaDatePicker);
			this.Controls.Add(this.label1);
			this.Name = "AddKnjiga";
			this.Text = "Dodavanje knjige";
			this.Load += new System.EventHandler(this.AddKnjiga_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker objavljenaDatePicker;
        private System.Windows.Forms.ComboBox autorComboBox;
        private System.Windows.Forms.TextBox naslovInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ISBNInput;
        private System.Windows.Forms.TextBox opisInput;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox slikaInput;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button sacuvajButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.CheckedListBox kategorijeListBox;
		private System.Windows.Forms.ErrorProvider errorProvider;
    }
}