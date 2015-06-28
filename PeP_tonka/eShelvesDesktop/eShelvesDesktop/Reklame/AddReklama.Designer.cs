namespace eShelvesDesktop
{
    partial class AddReklama
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
			this.pocetakDate = new System.Windows.Forms.DateTimePicker();
			this.trajanjeNumber = new System.Windows.Forms.NumericUpDown();
			this.urlInput = new System.Windows.Forms.TextBox();
			this.ponistiButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dodajButton = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.trajanjeNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(12, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Pocetak prikazivanja:";
			// 
			// pocetakDate
			// 
			this.pocetakDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.pocetakDate.Location = new System.Drawing.Point(175, 20);
			this.pocetakDate.Name = "pocetakDate";
			this.pocetakDate.Size = new System.Drawing.Size(250, 26);
			this.pocetakDate.TabIndex = 1;
			// 
			// trajanjeNumber
			// 
			this.trajanjeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.trajanjeNumber.Location = new System.Drawing.Point(175, 61);
			this.trajanjeNumber.Name = "trajanjeNumber";
			this.trajanjeNumber.Size = new System.Drawing.Size(120, 26);
			this.trajanjeNumber.TabIndex = 2;
			this.trajanjeNumber.Validating += new System.ComponentModel.CancelEventHandler(this.trajanjeNumber_Validating);
			// 
			// urlInput
			// 
			this.urlInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.urlInput.Location = new System.Drawing.Point(175, 102);
			this.urlInput.Name = "urlInput";
			this.urlInput.Size = new System.Drawing.Size(250, 26);
			this.urlInput.TabIndex = 3;
			this.urlInput.Validating += new System.ComponentModel.CancelEventHandler(this.urlInput_Validating);
			// 
			// ponistiButton
			// 
			this.ponistiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ponistiButton.Location = new System.Drawing.Point(97, 161);
			this.ponistiButton.Name = "ponistiButton";
			this.ponistiButton.Size = new System.Drawing.Size(96, 41);
			this.ponistiButton.TabIndex = 5;
			this.ponistiButton.Text = "Poništi";
			this.ponistiButton.UseVisualStyleBackColor = true;
			this.ponistiButton.Click += new System.EventHandler(this.ponistiButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(54, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Trajanje(dana):";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(123, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "URL:";
			// 
			// dodajButton
			// 
			this.dodajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.dodajButton.Location = new System.Drawing.Point(219, 161);
			this.dodajButton.Name = "dodajButton";
			this.dodajButton.Size = new System.Drawing.Size(96, 41);
			this.dodajButton.TabIndex = 8;
			this.dodajButton.Text = "Dodaj";
			this.dodajButton.UseVisualStyleBackColor = true;
			this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
			// 
			// errorProvider
			// 
			this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			// 
			// AddReklama
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(437, 225);
			this.Controls.Add(this.dodajButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ponistiButton);
			this.Controls.Add(this.urlInput);
			this.Controls.Add(this.trajanjeNumber);
			this.Controls.Add(this.pocetakDate);
			this.Controls.Add(this.label1);
			this.Name = "AddReklama";
			this.Text = "Dodavanje reklame";
			((System.ComponentModel.ISupportInitialize)(this.trajanjeNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker pocetakDate;
        private System.Windows.Forms.NumericUpDown trajanjeNumber;
        private System.Windows.Forms.TextBox urlInput;
        private System.Windows.Forms.Button ponistiButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dodajButton;
		private System.Windows.Forms.ErrorProvider errorProvider;
    }
}