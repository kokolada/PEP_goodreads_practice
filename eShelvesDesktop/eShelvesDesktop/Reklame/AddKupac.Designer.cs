namespace eShelvesDesktop
{
    partial class AddKupac
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
			this.nazivInput = new System.Windows.Forms.TextBox();
			this.dodajButton = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(8, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Naziv kupca:";
			// 
			// nazivInput
			// 
			this.nazivInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.nazivInput.Location = new System.Drawing.Point(12, 49);
			this.nazivInput.Name = "nazivInput";
			this.nazivInput.Size = new System.Drawing.Size(347, 26);
			this.nazivInput.TabIndex = 1;
			this.nazivInput.Validating += new System.ComponentModel.CancelEventHandler(this.nazivInput_Validating);
			// 
			// dodajButton
			// 
			this.dodajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.dodajButton.Location = new System.Drawing.Point(12, 101);
			this.dodajButton.Name = "dodajButton";
			this.dodajButton.Size = new System.Drawing.Size(347, 51);
			this.dodajButton.TabIndex = 3;
			this.dodajButton.Text = "Dodaj";
			this.dodajButton.UseVisualStyleBackColor = true;
			this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
			// 
			// errorProvider
			// 
			this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			// 
			// AddKupac
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(371, 164);
			this.Controls.Add(this.dodajButton);
			this.Controls.Add(this.nazivInput);
			this.Controls.Add(this.label1);
			this.Name = "AddKupac";
			this.Text = "Dodavanje kupca";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.Button dodajButton;
		private System.Windows.Forms.ErrorProvider errorProvider;
    }
}