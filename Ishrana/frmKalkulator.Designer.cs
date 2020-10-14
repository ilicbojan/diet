namespace Ishrana
{
    partial class frmKalkulator
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
            this.gb = new System.Windows.Forms.GroupBox();
            this.btnIzracunajSve = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTezina = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGodine = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnResetuj = new System.Windows.Forms.Button();
            this.tbVisina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAktivnost = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbMusko = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rbZensko = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRezultat = new System.Windows.Forms.TextBox();
            this.tbRezultat1 = new System.Windows.Forms.TextBox();
            this.tbRezultat2 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.gb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.Controls.Add(this.btnIzracunajSve);
            this.gb.Controls.Add(this.label9);
            this.gb.Controls.Add(this.tbTezina);
            this.gb.Controls.Add(this.label8);
            this.gb.Controls.Add(this.label4);
            this.gb.Controls.Add(this.tbGodine);
            this.gb.Controls.Add(this.label7);
            this.gb.Controls.Add(this.btnResetuj);
            this.gb.Controls.Add(this.tbVisina);
            this.gb.Controls.Add(this.label1);
            this.gb.Controls.Add(this.cmbAktivnost);
            this.gb.Controls.Add(this.label2);
            this.gb.Controls.Add(this.rbMusko);
            this.gb.Controls.Add(this.label5);
            this.gb.Controls.Add(this.rbZensko);
            this.gb.Controls.Add(this.label3);
            this.gb.Location = new System.Drawing.Point(13, 13);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(232, 289);
            this.gb.TabIndex = 0;
            this.gb.TabStop = false;
            this.gb.Text = "Podaci";
            // 
            // btnIzracunajSve
            // 
            this.btnIzracunajSve.Location = new System.Drawing.Point(25, 246);
            this.btnIzracunajSve.Name = "btnIzracunajSve";
            this.btnIzracunajSve.Size = new System.Drawing.Size(73, 23);
            this.btnIzracunajSve.TabIndex = 17;
            this.btnIzracunajSve.Text = "Izracunaj";
            this.btnIzracunajSve.UseVisualStyleBackColor = true;
            this.btnIzracunajSve.Click += new System.EventHandler(this.BtnIzracunaj_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "kg";
            // 
            // tbTezina
            // 
            this.tbTezina.Location = new System.Drawing.Point(64, 157);
            this.tbTezina.Name = "tbTezina";
            this.tbTezina.Size = new System.Drawing.Size(53, 20);
            this.tbTezina.TabIndex = 2;
            this.tbTezina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTezina_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "cm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Aktivnost";
            // 
            // tbGodine
            // 
            this.tbGodine.Location = new System.Drawing.Point(64, 31);
            this.tbGodine.Name = "tbGodine";
            this.tbGodine.Size = new System.Drawing.Size(53, 20);
            this.tbGodine.TabIndex = 0;
            this.tbGodine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbGodine_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "(15 - 80)";
            // 
            // btnResetuj
            // 
            this.btnResetuj.Location = new System.Drawing.Point(135, 246);
            this.btnResetuj.Name = "btnResetuj";
            this.btnResetuj.Size = new System.Drawing.Size(75, 23);
            this.btnResetuj.TabIndex = 5;
            this.btnResetuj.Text = "Resetuj";
            this.btnResetuj.UseVisualStyleBackColor = true;
            this.btnResetuj.Click += new System.EventHandler(this.BtnResetuj_Click);
            // 
            // tbVisina
            // 
            this.tbVisina.Location = new System.Drawing.Point(64, 111);
            this.tbVisina.Name = "tbVisina";
            this.tbVisina.Size = new System.Drawing.Size(53, 20);
            this.tbVisina.TabIndex = 1;
            this.tbVisina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbGodine_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Godine";
            // 
            // cmbAktivnost
            // 
            this.cmbAktivnost.FormattingEnabled = true;
            this.cmbAktivnost.Items.AddRange(new object[] {
            "Lezanje ceo dan",
            "Bez vezbanja ili malo vezbanja",
            "Vezbanje 1-3 puta nedeljno",
            "Vezbanje 4-5 puta nedeljno",
            "Vezbanje svaki dan",
            "Vezbanje u jakom ritmu svaki dan",
            "Fizicki posao"});
            this.cmbAktivnost.Location = new System.Drawing.Point(64, 200);
            this.cmbAktivnost.Name = "cmbAktivnost";
            this.cmbAktivnost.Size = new System.Drawing.Size(156, 21);
            this.cmbAktivnost.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Visina";
            // 
            // rbMusko
            // 
            this.rbMusko.AutoSize = true;
            this.rbMusko.Location = new System.Drawing.Point(64, 73);
            this.rbMusko.Name = "rbMusko";
            this.rbMusko.Size = new System.Drawing.Size(53, 17);
            this.rbMusko.TabIndex = 0;
            this.rbMusko.TabStop = true;
            this.rbMusko.Text = "Muski";
            this.rbMusko.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pol";
            // 
            // rbZensko
            // 
            this.rbZensko.AutoSize = true;
            this.rbZensko.Location = new System.Drawing.Point(123, 73);
            this.rbZensko.Name = "rbZensko";
            this.rbZensko.Size = new System.Drawing.Size(57, 17);
            this.rbZensko.TabIndex = 1;
            this.rbZensko.TabStop = true;
            this.rbZensko.Text = "Zenski";
            this.rbZensko.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tezina";
            // 
            // tbRezultat
            // 
            this.tbRezultat.Location = new System.Drawing.Point(40, 19);
            this.tbRezultat.Name = "tbRezultat";
            this.tbRezultat.ReadOnly = true;
            this.tbRezultat.Size = new System.Drawing.Size(53, 20);
            this.tbRezultat.TabIndex = 12;
            // 
            // tbRezultat1
            // 
            this.tbRezultat1.Location = new System.Drawing.Point(40, 19);
            this.tbRezultat1.Name = "tbRezultat1";
            this.tbRezultat1.ReadOnly = true;
            this.tbRezultat1.Size = new System.Drawing.Size(53, 20);
            this.tbRezultat1.TabIndex = 31;
            // 
            // tbRezultat2
            // 
            this.tbRezultat2.Location = new System.Drawing.Point(40, 27);
            this.tbRezultat2.Name = "tbRezultat2";
            this.tbRezultat2.ReadOnly = true;
            this.tbRezultat2.Size = new System.Drawing.Size(53, 20);
            this.tbRezultat2.TabIndex = 39;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 52);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(178, 13);
            this.label24.TabIndex = 33;
            this.label24.Text = "Normal BMI: 18.5 kg/m2 - 25 kg/m2";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(99, 22);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(27, 13);
            this.label25.TabIndex = 17;
            this.label25.Text = "kcal";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(99, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 13);
            this.label26.TabIndex = 34;
            this.label26.Text = "kg/m2";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(99, 30);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(19, 13);
            this.label27.TabIndex = 41;
            this.label27.Text = "kg";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIzadji);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(251, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 289);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezultati";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.tbRezultat2);
            this.groupBox6.Location = new System.Drawing.Point(6, 163);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(197, 67);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Idealna tezina";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.tbRezultat1);
            this.groupBox5.Location = new System.Drawing.Point(7, 80);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(197, 77);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "BMI";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbRezultat);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Location = new System.Drawing.Point(7, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(197, 54);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dnevni unos kalorija";
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(67, 246);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(75, 23);
            this.btnIzadji.TabIndex = 3;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.BtnIzadji_Click);
            // 
            // frmKalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 311);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb);
            this.Name = "frmKalkulator";
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.FrmKalkulator_Load);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.RadioButton rbZensko;
        private System.Windows.Forms.RadioButton rbMusko;
        private System.Windows.Forms.Button btnResetuj;
        private System.Windows.Forms.ComboBox cmbAktivnost;
        private System.Windows.Forms.TextBox tbTezina;
        private System.Windows.Forms.TextBox tbVisina;
        private System.Windows.Forms.TextBox tbGodine;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbRezultat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRezultat1;
        private System.Windows.Forms.TextBox tbRezultat2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnIzracunajSve;
        private System.Windows.Forms.Button btnIzadji;
    }
}