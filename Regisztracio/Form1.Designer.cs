namespace Regisztracio
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Lakcim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Helyseg = new System.Windows.Forms.ComboBox();
            this.radioButton_No = new System.Windows.Forms.RadioButton();
            this.radioButton_Ferfi = new System.Windows.Forms.RadioButton();
            this.radioButton_egyeb = new System.Windows.Forms.RadioButton();
            this.Neme = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_Mobil = new System.Windows.Forms.CheckBox();
            this.checkBox_Kerekpar = new System.Windows.Forms.CheckBox();
            this.checkBox_TV = new System.Windows.Forms.CheckBox();
            this.button_Regisztracio = new System.Windows.Forms.Button();
            this.button_Torles = new System.Windows.Forms.Button();
            this.listBox_Adatok = new System.Windows.Forms.ListBox();
            this.Neme.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(139, 30);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(203, 31);
            this.textBox_Nev.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lakcím";
            // 
            // textBox_Lakcim
            // 
            this.textBox_Lakcim.Location = new System.Drawing.Point(139, 102);
            this.textBox_Lakcim.Name = "textBox_Lakcim";
            this.textBox_Lakcim.Size = new System.Drawing.Size(203, 31);
            this.textBox_Lakcim.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Helység";
            // 
            // comboBox_Helyseg
            // 
            this.comboBox_Helyseg.FormattingEnabled = true;
            this.comboBox_Helyseg.Items.AddRange(new object[] {
            "Debrecen",
            "Eger",
            "Kegykemét"});
            this.comboBox_Helyseg.Location = new System.Drawing.Point(139, 175);
            this.comboBox_Helyseg.Name = "comboBox_Helyseg";
            this.comboBox_Helyseg.Size = new System.Drawing.Size(203, 33);
            this.comboBox_Helyseg.TabIndex = 5;
            // 
            // radioButton_No
            // 
            this.radioButton_No.AutoSize = true;
            this.radioButton_No.Location = new System.Drawing.Point(48, 44);
            this.radioButton_No.Name = "radioButton_No";
            this.radioButton_No.Size = new System.Drawing.Size(57, 29);
            this.radioButton_No.TabIndex = 7;
            this.radioButton_No.TabStop = true;
            this.radioButton_No.Text = "Nő";
            this.radioButton_No.UseVisualStyleBackColor = true;
            // 
            // radioButton_Ferfi
            // 
            this.radioButton_Ferfi.AutoSize = true;
            this.radioButton_Ferfi.Location = new System.Drawing.Point(140, 44);
            this.radioButton_Ferfi.Name = "radioButton_Ferfi";
            this.radioButton_Ferfi.Size = new System.Drawing.Size(66, 29);
            this.radioButton_Ferfi.TabIndex = 8;
            this.radioButton_Ferfi.TabStop = true;
            this.radioButton_Ferfi.Text = "férfi";
            this.radioButton_Ferfi.UseVisualStyleBackColor = true;
            // 
            // radioButton_egyeb
            // 
            this.radioButton_egyeb.AutoSize = true;
            this.radioButton_egyeb.Location = new System.Drawing.Point(241, 44);
            this.radioButton_egyeb.Name = "radioButton_egyeb";
            this.radioButton_egyeb.Size = new System.Drawing.Size(89, 29);
            this.radioButton_egyeb.TabIndex = 9;
            this.radioButton_egyeb.TabStop = true;
            this.radioButton_egyeb.Text = "egyéb";
            this.radioButton_egyeb.UseVisualStyleBackColor = true;
            // 
            // Neme
            // 
            this.Neme.Controls.Add(this.radioButton_egyeb);
            this.Neme.Controls.Add(this.radioButton_No);
            this.Neme.Controls.Add(this.radioButton_Ferfi);
            this.Neme.Location = new System.Drawing.Point(42, 239);
            this.Neme.Name = "Neme";
            this.Neme.Size = new System.Drawing.Size(389, 100);
            this.Neme.TabIndex = 10;
            this.Neme.TabStop = false;
            this.Neme.Text = "Neme";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_TV);
            this.groupBox1.Controls.Add(this.checkBox_Kerekpar);
            this.groupBox1.Controls.Add(this.checkBox_Mobil);
            this.groupBox1.Location = new System.Drawing.Point(47, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 176);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hobby";
            // 
            // checkBox_Mobil
            // 
            this.checkBox_Mobil.AutoSize = true;
            this.checkBox_Mobil.Location = new System.Drawing.Point(25, 40);
            this.checkBox_Mobil.Name = "checkBox_Mobil";
            this.checkBox_Mobil.Size = new System.Drawing.Size(129, 29);
            this.checkBox_Mobil.TabIndex = 0;
            this.checkBox_Mobil.Text = "Mobilozás";
            this.checkBox_Mobil.UseVisualStyleBackColor = true;
            // 
            // checkBox_Kerekpar
            // 
            this.checkBox_Kerekpar.AutoSize = true;
            this.checkBox_Kerekpar.Location = new System.Drawing.Point(25, 119);
            this.checkBox_Kerekpar.Name = "checkBox_Kerekpar";
            this.checkBox_Kerekpar.Size = new System.Drawing.Size(164, 29);
            this.checkBox_Kerekpar.TabIndex = 0;
            this.checkBox_Kerekpar.Text = "Kerékpározás";
            this.checkBox_Kerekpar.UseVisualStyleBackColor = true;
            // 
            // checkBox_TV
            // 
            this.checkBox_TV.AutoSize = true;
            this.checkBox_TV.Location = new System.Drawing.Point(25, 75);
            this.checkBox_TV.Name = "checkBox_TV";
            this.checkBox_TV.Size = new System.Drawing.Size(122, 29);
            this.checkBox_TV.TabIndex = 0;
            this.checkBox_TV.Text = "TV nézés";
            this.checkBox_TV.UseVisualStyleBackColor = true;
            // 
            // button_Regisztracio
            // 
            this.button_Regisztracio.Location = new System.Drawing.Point(558, 33);
            this.button_Regisztracio.Name = "button_Regisztracio";
            this.button_Regisztracio.Size = new System.Drawing.Size(280, 50);
            this.button_Regisztracio.TabIndex = 12;
            this.button_Regisztracio.Text = "Regisztrálás";
            this.button_Regisztracio.UseVisualStyleBackColor = true;
            this.button_Regisztracio.Click += new System.EventHandler(this.Regisztracio);
            // 
            // button_Torles
            // 
            this.button_Torles.Location = new System.Drawing.Point(558, 120);
            this.button_Torles.Name = "button_Torles";
            this.button_Torles.Size = new System.Drawing.Size(280, 50);
            this.button_Torles.TabIndex = 12;
            this.button_Torles.Text = "Törlés";
            this.button_Torles.UseVisualStyleBackColor = true;
            // 
            // listBox_Adatok
            // 
            this.listBox_Adatok.FormattingEnabled = true;
            this.listBox_Adatok.ItemHeight = 25;
            this.listBox_Adatok.Location = new System.Drawing.Point(558, 239);
            this.listBox_Adatok.Name = "listBox_Adatok";
            this.listBox_Adatok.Size = new System.Drawing.Size(280, 354);
            this.listBox_Adatok.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 640);
            this.Controls.Add(this.listBox_Adatok);
            this.Controls.Add(this.button_Torles);
            this.Controls.Add(this.button_Regisztracio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Neme);
            this.Controls.Add(this.comboBox_Helyseg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Lakcim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Regisztráció";
            this.Neme.ResumeLayout(false);
            this.Neme.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Lakcim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Helyseg;
        private System.Windows.Forms.RadioButton radioButton_No;
        private System.Windows.Forms.RadioButton radioButton_Ferfi;
        private System.Windows.Forms.RadioButton radioButton_egyeb;
        private System.Windows.Forms.GroupBox Neme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_TV;
        private System.Windows.Forms.CheckBox checkBox_Kerekpar;
        private System.Windows.Forms.CheckBox checkBox_Mobil;
        private System.Windows.Forms.Button button_Regisztracio;
        private System.Windows.Forms.Button button_Torles;
        private System.Windows.Forms.ListBox listBox_Adatok;
    }
}

