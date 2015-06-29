namespace eShelvesDesktop
{
    partial class AddKorisnik
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
            this.zenskoRB = new System.Windows.Forms.RadioButton();
            this.muskoRB = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.prezimeInput = new System.Windows.Forms.TextBox();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.gradInput = new System.Windows.Forms.TextBox();
            this.potvrdiButton = new System.Windows.Forms.Button();
            this.ponistiButton = new System.Windows.Forms.Button();
            this.spolPanel = new System.Windows.Forms.Panel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.spolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(88, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // imeInput
            // 
            this.imeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imeInput.Location = new System.Drawing.Point(134, 17);
            this.imeInput.Name = "imeInput";
            this.imeInput.Size = new System.Drawing.Size(162, 26);
            this.imeInput.TabIndex = 1;
            this.imeInput.Validating += new System.ComponentModel.CancelEventHandler(this.imeInput_Validating);
            // 
            // zenskoRB
            // 
            this.zenskoRB.AutoSize = true;
            this.zenskoRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zenskoRB.Location = new System.Drawing.Point(90, 9);
            this.zenskoRB.Name = "zenskoRB";
            this.zenskoRB.Size = new System.Drawing.Size(80, 24);
            this.zenskoRB.TabIndex = 2;
            this.zenskoRB.TabStop = true;
            this.zenskoRB.Text = "Žensko";
            this.zenskoRB.UseVisualStyleBackColor = true;
            this.zenskoRB.Validating += new System.ComponentModel.CancelEventHandler(this.zenskoRB_Validating);
            // 
            // muskoRB
            // 
            this.muskoRB.AutoSize = true;
            this.muskoRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.muskoRB.Location = new System.Drawing.Point(10, 9);
            this.muskoRB.Name = "muskoRB";
            this.muskoRB.Size = new System.Drawing.Size(74, 24);
            this.muskoRB.TabIndex = 3;
            this.muskoRB.TabStop = true;
            this.muskoRB.Text = "Muško";
            this.muskoRB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(58, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(14, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Korisničko ime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(47, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lozinka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(71, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(83, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Spol:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(79, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Grad:";
            // 
            // prezimeInput
            // 
            this.prezimeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prezimeInput.Location = new System.Drawing.Point(134, 58);
            this.prezimeInput.Name = "prezimeInput";
            this.prezimeInput.Size = new System.Drawing.Size(162, 26);
            this.prezimeInput.TabIndex = 10;
            this.prezimeInput.Validating += new System.ComponentModel.CancelEventHandler(this.prezimeInput_Validating);
            // 
            // usernameInput
            // 
            this.usernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameInput.Location = new System.Drawing.Point(134, 99);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(162, 26);
            this.usernameInput.TabIndex = 11;
            this.usernameInput.Validating += new System.ComponentModel.CancelEventHandler(this.usernameInput_Validating);
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordInput.Location = new System.Drawing.Point(134, 141);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(162, 26);
            this.passwordInput.TabIndex = 12;
            this.passwordInput.Validating += new System.ComponentModel.CancelEventHandler(this.passwordInput_Validating);
            // 
            // emailInput
            // 
            this.emailInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailInput.Location = new System.Drawing.Point(134, 183);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(162, 26);
            this.emailInput.TabIndex = 13;
            this.emailInput.Validating += new System.ComponentModel.CancelEventHandler(this.emailInput_Validating);
            // 
            // gradInput
            // 
            this.gradInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gradInput.Location = new System.Drawing.Point(134, 264);
            this.gradInput.Name = "gradInput";
            this.gradInput.Size = new System.Drawing.Size(162, 26);
            this.gradInput.TabIndex = 14;
            this.gradInput.Validating += new System.ComponentModel.CancelEventHandler(this.gradInput_Validating);
            // 
            // potvrdiButton
            // 
            this.potvrdiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.potvrdiButton.Location = new System.Drawing.Point(193, 327);
            this.potvrdiButton.Name = "potvrdiButton";
            this.potvrdiButton.Size = new System.Drawing.Size(92, 55);
            this.potvrdiButton.TabIndex = 15;
            this.potvrdiButton.Text = "Potvrdi";
            this.potvrdiButton.UseVisualStyleBackColor = true;
            this.potvrdiButton.Click += new System.EventHandler(this.potvrdiButton_Click);
            // 
            // ponistiButton
            // 
            this.ponistiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ponistiButton.Location = new System.Drawing.Point(83, 327);
            this.ponistiButton.Name = "ponistiButton";
            this.ponistiButton.Size = new System.Drawing.Size(92, 55);
            this.ponistiButton.TabIndex = 16;
            this.ponistiButton.Text = "Poništi";
            this.ponistiButton.UseVisualStyleBackColor = true;
            this.ponistiButton.Click += new System.EventHandler(this.ponistiButton_Click);
            // 
            // spolPanel
            // 
            this.spolPanel.Controls.Add(this.muskoRB);
            this.spolPanel.Controls.Add(this.zenskoRB);
            this.spolPanel.Location = new System.Drawing.Point(124, 215);
            this.spolPanel.Name = "spolPanel";
            this.spolPanel.Size = new System.Drawing.Size(197, 43);
            this.spolPanel.TabIndex = 17;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // AddKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 403);
            this.Controls.Add(this.spolPanel);
            this.Controls.Add(this.ponistiButton);
            this.Controls.Add(this.potvrdiButton);
            this.Controls.Add(this.gradInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.prezimeInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imeInput);
            this.Controls.Add(this.label1);
            this.Name = "AddKorisnik";
            this.Text = "Dodavanje korisnika";
            this.spolPanel.ResumeLayout(false);
            this.spolPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imeInput;
        private System.Windows.Forms.RadioButton zenskoRB;
        private System.Windows.Forms.RadioButton muskoRB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox prezimeInput;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox gradInput;
        private System.Windows.Forms.Button potvrdiButton;
        private System.Windows.Forms.Button ponistiButton;
        private System.Windows.Forms.Panel spolPanel;
		private System.Windows.Forms.ErrorProvider errorProvider;
    }
}