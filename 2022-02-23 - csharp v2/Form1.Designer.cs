
namespace _2022_02_23___csharp_v2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.tbDarab = new System.Windows.Forms.TextBox();
            this.tbAr = new System.Windows.Forms.TextBox();
            this.btnHozzaad = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnKimasol = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAtmasol = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEuro = new System.Windows.Forms.RadioButton();
            this.rbForint = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAtvalt = new System.Windows.Forms.TextBox();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFajlba = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Darab";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ár (Euro)";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(83, 24);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(100, 20);
            this.tbNev.TabIndex = 3;
            // 
            // tbDarab
            // 
            this.tbDarab.Location = new System.Drawing.Point(83, 61);
            this.tbDarab.Name = "tbDarab";
            this.tbDarab.Size = new System.Drawing.Size(100, 20);
            this.tbDarab.TabIndex = 4;
            // 
            // tbAr
            // 
            this.tbAr.Location = new System.Drawing.Point(83, 93);
            this.tbAr.Name = "tbAr";
            this.tbAr.Size = new System.Drawing.Size(100, 20);
            this.tbAr.TabIndex = 5;
            // 
            // btnHozzaad
            // 
            this.btnHozzaad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHozzaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHozzaad.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnHozzaad.Location = new System.Drawing.Point(200, 21);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(23, 23);
            this.btnHozzaad.TabIndex = 6;
            this.btnHozzaad.Text = ">";
            this.btnHozzaad.UseVisualStyleBackColor = false;
            this.btnHozzaad.Click += new System.EventHandler(this.btnHozzaad_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTorol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTorol.ForeColor = System.Drawing.Color.Red;
            this.btnTorol.Location = new System.Drawing.Point(200, 55);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(23, 23);
            this.btnTorol.TabIndex = 7;
            this.btnTorol.Text = "X";
            this.btnTorol.UseVisualStyleBackColor = false;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnKimasol
            // 
            this.btnKimasol.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnKimasol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKimasol.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnKimasol.Location = new System.Drawing.Point(200, 90);
            this.btnKimasol.Name = "btnKimasol";
            this.btnKimasol.Size = new System.Drawing.Size(23, 23);
            this.btnKimasol.TabIndex = 8;
            this.btnKimasol.Text = "<";
            this.btnKimasol.UseVisualStyleBackColor = false;
            this.btnKimasol.Click += new System.EventHandler(this.btnKimasol_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(246, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAtmasol
            // 
            this.btnAtmasol.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAtmasol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAtmasol.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnAtmasol.Location = new System.Drawing.Point(383, 21);
            this.btnAtmasol.Name = "btnAtmasol";
            this.btnAtmasol.Size = new System.Drawing.Size(37, 23);
            this.btnAtmasol.TabIndex = 10;
            this.btnAtmasol.Text = ">>";
            this.btnAtmasol.UseVisualStyleBackColor = false;
            this.btnAtmasol.Click += new System.EventHandler(this.btnAtmasol_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(436, 21);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 11;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEuro);
            this.groupBox1.Controls.Add(this.rbForint);
            this.groupBox1.Location = new System.Drawing.Point(13, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(82, 76);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbEuro
            // 
            this.rbEuro.AutoSize = true;
            this.rbEuro.Checked = true;
            this.rbEuro.Location = new System.Drawing.Point(7, 43);
            this.rbEuro.Name = "rbEuro";
            this.rbEuro.Size = new System.Drawing.Size(47, 17);
            this.rbEuro.TabIndex = 0;
            this.rbEuro.TabStop = true;
            this.rbEuro.Text = "Euro";
            this.rbEuro.UseVisualStyleBackColor = true;
            this.rbEuro.Click += new System.EventHandler(this.rbEuro_Click);
            // 
            // rbForint
            // 
            this.rbForint.AutoSize = true;
            this.rbForint.Location = new System.Drawing.Point(7, 20);
            this.rbForint.Name = "rbForint";
            this.rbForint.Size = new System.Drawing.Size(51, 17);
            this.rbForint.TabIndex = 0;
            this.rbForint.Text = "Forint";
            this.rbForint.UseVisualStyleBackColor = true;
            this.rbForint.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.rbForint.Click += new System.EventHandler(this.rbForint_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Érték:";
            // 
            // tbAtvalt
            // 
            this.tbAtvalt.Location = new System.Drawing.Point(171, 161);
            this.tbAtvalt.Name = "tbAtvalt";
            this.tbAtvalt.Size = new System.Drawing.Size(100, 20);
            this.tbAtvalt.TabIndex = 8;
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(291, 158);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(75, 23);
            this.btnSzamol.TabIndex = 9;
            this.btnSzamol.Text = "Számol";
            this.btnSzamol.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 228);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Árfolyam";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(85, 225);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "357";
            // 
            // btnFajlba
            // 
            this.btnFajlba.Location = new System.Drawing.Point(597, 92);
            this.btnFajlba.Name = "btnFajlba";
            this.btnFajlba.Size = new System.Drawing.Size(100, 23);
            this.btnFajlba.TabIndex = 14;
            this.btnFajlba.Text = "Fájlba írás";
            this.btnFajlba.UseVisualStyleBackColor = true;
            this.btnFajlba.Click += new System.EventHandler(this.btnFajlba_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Fájlból olvasás";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFajlba);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnSzamol);
            this.Controls.Add(this.tbAtvalt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnKimasol);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnAtmasol);
            this.Controls.Add(this.btnHozzaad);
            this.Controls.Add(this.tbAr);
            this.Controls.Add(this.tbDarab);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.TextBox tbDarab;
        private System.Windows.Forms.TextBox tbAr;
        private System.Windows.Forms.Button btnHozzaad;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnKimasol;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAtmasol;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEuro;
        private System.Windows.Forms.RadioButton rbForint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAtvalt;
        private System.Windows.Forms.Button btnSzamol;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFajlba;
        private System.Windows.Forms.Button button1;
    }
}

