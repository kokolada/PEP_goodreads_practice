namespace eShelvesDesktop.Kategorije
{
    partial class ManageKategorije
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
			this.kategorijeListBox = new System.Windows.Forms.CheckedListBox();
			this.obrisiButton = new System.Windows.Forms.Button();
			this.novaInput = new System.Windows.Forms.TextBox();
			this.dodajButton = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// kategorijeListBox
			// 
			this.kategorijeListBox.CheckOnClick = true;
			this.kategorijeListBox.FormattingEnabled = true;
			this.kategorijeListBox.Location = new System.Drawing.Point(12, 12);
			this.kategorijeListBox.Name = "kategorijeListBox";
			this.kategorijeListBox.Size = new System.Drawing.Size(140, 199);
			this.kategorijeListBox.TabIndex = 0;
			// 
			// obrisiButton
			// 
			this.obrisiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.obrisiButton.Location = new System.Drawing.Point(168, 12);
			this.obrisiButton.Name = "obrisiButton";
			this.obrisiButton.Size = new System.Drawing.Size(114, 54);
			this.obrisiButton.TabIndex = 1;
			this.obrisiButton.Text = "Obriši označene";
			this.obrisiButton.UseVisualStyleBackColor = true;
			this.obrisiButton.Click += new System.EventHandler(this.obrisiButton_Click);
			// 
			// novaInput
			// 
			this.novaInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.novaInput.Location = new System.Drawing.Point(12, 219);
			this.novaInput.Name = "novaInput";
			this.novaInput.Size = new System.Drawing.Size(270, 26);
			this.novaInput.TabIndex = 2;
			this.novaInput.Validating += new System.ComponentModel.CancelEventHandler(this.novaInput_Validating);
			// 
			// dodajButton
			// 
			this.dodajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.dodajButton.Location = new System.Drawing.Point(168, 178);
			this.dodajButton.Name = "dodajButton";
			this.dodajButton.Size = new System.Drawing.Size(114, 35);
			this.dodajButton.TabIndex = 3;
			this.dodajButton.Text = "Dodaj novu";
			this.dodajButton.UseVisualStyleBackColor = true;
			this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
			// 
			// errorProvider
			// 
			this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			// 
			// ManageKategorije
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(294, 257);
			this.Controls.Add(this.dodajButton);
			this.Controls.Add(this.novaInput);
			this.Controls.Add(this.obrisiButton);
			this.Controls.Add(this.kategorijeListBox);
			this.Name = "ManageKategorije";
			this.Text = "ManageKategorije";
			this.Load += new System.EventHandler(this.ManageKategorije_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox kategorijeListBox;
        private System.Windows.Forms.Button obrisiButton;
        private System.Windows.Forms.TextBox novaInput;
        private System.Windows.Forms.Button dodajButton;
		private System.Windows.Forms.ErrorProvider errorProvider;
    }
}