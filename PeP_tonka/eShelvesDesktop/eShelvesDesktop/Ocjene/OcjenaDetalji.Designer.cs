namespace eShelvesDesktop.Ocjene
{
    partial class OcjenaDetalji
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
            this.obrisiButton = new System.Windows.Forms.Button();
            this.opisInput = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ocjenaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ocjenio:";
            // 
            // obrisiButton
            // 
            this.obrisiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.obrisiButton.Location = new System.Drawing.Point(249, 9);
            this.obrisiButton.Name = "obrisiButton";
            this.obrisiButton.Size = new System.Drawing.Size(105, 52);
            this.obrisiButton.TabIndex = 1;
            this.obrisiButton.Text = "Obriši ocjenu";
            this.obrisiButton.UseVisualStyleBackColor = true;
            this.obrisiButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // opisInput
            // 
            this.opisInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opisInput.Location = new System.Drawing.Point(12, 85);
            this.opisInput.Multiline = true;
            this.opisInput.Name = "opisInput";
            this.opisInput.ReadOnly = true;
            this.opisInput.Size = new System.Drawing.Size(342, 140);
            this.opisInput.TabIndex = 2;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userLabel.Location = new System.Drawing.Point(84, 9);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(51, 20);
            this.userLabel.TabIndex = 3;
            this.userLabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(15, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ocjena:";
            // 
            // ocjenaLabel
            // 
            this.ocjenaLabel.AutoSize = true;
            this.ocjenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ocjenaLabel.Location = new System.Drawing.Point(84, 41);
            this.ocjenaLabel.Name = "ocjenaLabel";
            this.ocjenaLabel.Size = new System.Drawing.Size(51, 20);
            this.ocjenaLabel.TabIndex = 5;
            this.ocjenaLabel.Text = "label4";
            // 
            // OcjenaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 237);
            this.Controls.Add(this.ocjenaLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.opisInput);
            this.Controls.Add(this.obrisiButton);
            this.Controls.Add(this.label1);
            this.Name = "OcjenaDetalji";
            this.Text = "Detalji ocjena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button obrisiButton;
        private System.Windows.Forms.TextBox opisInput;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ocjenaLabel;
    }
}