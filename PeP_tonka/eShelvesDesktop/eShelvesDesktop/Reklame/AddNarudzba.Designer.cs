namespace eShelvesDesktop
{
    partial class AddNarudzba
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
            this.cijenaNumber = new System.Windows.Forms.NumericUpDown();
            this.prikaziNumber = new System.Windows.Forms.NumericUpDown();
            this.kupacCombo = new System.Windows.Forms.ComboBox();
            this.reklamaCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addkupacButton = new System.Windows.Forms.Button();
            this.addreklamaButton = new System.Windows.Forms.Button();
            this.ponistiButton = new System.Windows.Forms.Button();
            this.dodajButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.od = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.do2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.danaZ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cijenaNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prikaziNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(478, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dana zakupljeno:";
            // 
            // cijenaNumber
            // 
            this.cijenaNumber.DecimalPlaces = 2;
            this.cijenaNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cijenaNumber.Location = new System.Drawing.Point(150, 104);
            this.cijenaNumber.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.cijenaNumber.Name = "cijenaNumber";
            this.cijenaNumber.Size = new System.Drawing.Size(107, 26);
            this.cijenaNumber.TabIndex = 2;
            this.cijenaNumber.ThousandsSeparator = true;
            this.cijenaNumber.Validating += new System.ComponentModel.CancelEventHandler(this.cijenaNumber_Validating);
            // 
            // prikaziNumber
            // 
            this.prikaziNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prikaziNumber.Location = new System.Drawing.Point(150, 61);
            this.prikaziNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.prikaziNumber.Name = "prikaziNumber";
            this.prikaziNumber.Size = new System.Drawing.Size(107, 26);
            this.prikaziNumber.TabIndex = 3;
            this.prikaziNumber.Validating += new System.ComponentModel.CancelEventHandler(this.prikaziNumber_Validating);
            // 
            // kupacCombo
            // 
            this.kupacCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kupacCombo.FormattingEnabled = true;
            this.kupacCombo.Location = new System.Drawing.Point(370, 62);
            this.kupacCombo.Name = "kupacCombo";
            this.kupacCombo.Size = new System.Drawing.Size(211, 28);
            this.kupacCombo.TabIndex = 4;
            this.kupacCombo.Validating += new System.ComponentModel.CancelEventHandler(this.kupacCombo_Validating);
            // 
            // reklamaCombo
            // 
            this.reklamaCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reklamaCombo.FormattingEnabled = true;
            this.reklamaCombo.Location = new System.Drawing.Point(370, 104);
            this.reklamaCombo.Name = "reklamaCombo";
            this.reklamaCombo.Size = new System.Drawing.Size(211, 28);
            this.reklamaCombo.TabIndex = 5;
            this.reklamaCombo.Validating += new System.ComponentModel.CancelEventHandler(this.reklamaCombo_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(48, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Broj prikaza:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(87, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cijena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(306, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kupac:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(288, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Reklama:";
            // 
            // addkupacButton
            // 
            this.addkupacButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addkupacButton.Location = new System.Drawing.Point(587, 60);
            this.addkupacButton.Name = "addkupacButton";
            this.addkupacButton.Size = new System.Drawing.Size(109, 31);
            this.addkupacButton.TabIndex = 10;
            this.addkupacButton.Text = "Novi kupac";
            this.addkupacButton.UseVisualStyleBackColor = true;
            this.addkupacButton.Click += new System.EventHandler(this.addkupacButton_Click);
            // 
            // addreklamaButton
            // 
            this.addreklamaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addreklamaButton.Location = new System.Drawing.Point(587, 102);
            this.addreklamaButton.Name = "addreklamaButton";
            this.addreklamaButton.Size = new System.Drawing.Size(118, 31);
            this.addreklamaButton.TabIndex = 11;
            this.addreklamaButton.Text = "Nova reklama";
            this.addreklamaButton.UseVisualStyleBackColor = true;
            this.addreklamaButton.Click += new System.EventHandler(this.addreklamaButton_Click);
            // 
            // ponistiButton
            // 
            this.ponistiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ponistiButton.Location = new System.Drawing.Point(310, 161);
            this.ponistiButton.Name = "ponistiButton";
            this.ponistiButton.Size = new System.Drawing.Size(109, 52);
            this.ponistiButton.TabIndex = 12;
            this.ponistiButton.Text = "Poništi";
            this.ponistiButton.UseVisualStyleBackColor = true;
            this.ponistiButton.Click += new System.EventHandler(this.ponistiButton_Click);
            // 
            // dodajButton
            // 
            this.dodajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajButton.Location = new System.Drawing.Point(451, 161);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(109, 52);
            this.dodajButton.TabIndex = 13;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // od
            // 
            this.od.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.od.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.od.Location = new System.Drawing.Point(150, 18);
            this.od.Name = "od";
            this.od.Size = new System.Drawing.Size(123, 26);
            this.od.TabIndex = 14;
            this.od.ValueChanged += new System.EventHandler(this.od_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(31, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Zakupljeno od:";
            // 
            // do2
            // 
            this.do2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.do2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.do2.Location = new System.Drawing.Point(325, 18);
            this.do2.Name = "do2";
            this.do2.Size = new System.Drawing.Size(123, 26);
            this.do2.TabIndex = 16;
            this.do2.ValueChanged += new System.EventHandler(this.do2_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(288, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "do:";
            // 
            // danaZ
            // 
            this.danaZ.AutoSize = true;
            this.danaZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.danaZ.Location = new System.Drawing.Point(616, 23);
            this.danaZ.Name = "danaZ";
            this.danaZ.Size = new System.Drawing.Size(57, 20);
            this.danaZ.TabIndex = 18;
            this.danaZ.Text = "label8";
            // 
            // AddNarudzba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 226);
            this.Controls.Add(this.danaZ);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.do2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.od);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.ponistiButton);
            this.Controls.Add(this.addreklamaButton);
            this.Controls.Add(this.addkupacButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reklamaCombo);
            this.Controls.Add(this.kupacCombo);
            this.Controls.Add(this.prikaziNumber);
            this.Controls.Add(this.cijenaNumber);
            this.Controls.Add(this.label1);
            this.Name = "AddNarudzba";
            this.Text = "Dodavanje narudžbe";
            this.Load += new System.EventHandler(this.AddNarudzba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cijenaNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prikaziNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cijenaNumber;
        private System.Windows.Forms.NumericUpDown prikaziNumber;
        private System.Windows.Forms.ComboBox kupacCombo;
        private System.Windows.Forms.ComboBox reklamaCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addkupacButton;
        private System.Windows.Forms.Button addreklamaButton;
        private System.Windows.Forms.Button ponistiButton;
        private System.Windows.Forms.Button dodajButton;
		private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label danaZ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker do2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker od;
    }
}