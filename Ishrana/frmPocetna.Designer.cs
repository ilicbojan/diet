namespace Ishrana
{
    partial class frmPocetna
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResetuj = new System.Windows.Forms.Button();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.tbTezina = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDatum = new System.Windows.Forms.TextBox();
            this.tbKalorije = new System.Windows.Forms.TextBox();
            this.tbMasti = new System.Windows.Forms.TextBox();
            this.tbProteini = new System.Windows.Forms.TextBox();
            this.Cena = new System.Windows.Forms.Label();
            this.tbHidrati = new System.Windows.Forms.TextBox();
            this.Kolicina = new System.Windows.Forms.Label();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKolicina = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnObrok = new System.Windows.Forms.Button();
            this.btnHrana = new System.Windows.Forms.Button();
            this.btnKalkulator = new System.Windows.Forms.Button();
            this.btnPregled = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.dnevniUnosTableAdapter1 = new Ishrana.IshranaDataSetTableAdapters.DnevniUnosTableAdapter();
            this.ishranaDataSet1 = new Ishrana.IshranaDataSet();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ishranaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 389);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obroci";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(7, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 363);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnResetuj);
            this.groupBox2.Controls.Add(this.btnUnesi);
            this.groupBox2.Controls.Add(this.tbTezina);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbDatum);
            this.groupBox2.Controls.Add(this.tbKalorije);
            this.groupBox2.Controls.Add(this.tbMasti);
            this.groupBox2.Controls.Add(this.tbProteini);
            this.groupBox2.Controls.Add(this.Cena);
            this.groupBox2.Controls.Add(this.tbHidrati);
            this.groupBox2.Controls.Add(this.Kolicina);
            this.groupBox2.Controls.Add(this.tbCena);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbKolicina);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rtbOpis);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(228, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 389);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dnevni unos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(137, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(161, 29);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(36, 20);
            this.tbID.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "kg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tezina";
            // 
            // btnResetuj
            // 
            this.btnResetuj.Location = new System.Drawing.Point(222, 351);
            this.btnResetuj.Name = "btnResetuj";
            this.btnResetuj.Size = new System.Drawing.Size(75, 23);
            this.btnResetuj.TabIndex = 26;
            this.btnResetuj.Text = "Resetuj";
            this.btnResetuj.UseVisualStyleBackColor = true;
            this.btnResetuj.Click += new System.EventHandler(this.BtnResetuj_Click);
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(53, 351);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 23);
            this.btnUnesi.TabIndex = 25;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.BtnUnesi_Click);
            // 
            // tbTezina
            // 
            this.tbTezina.Location = new System.Drawing.Point(258, 29);
            this.tbTezina.Name = "tbTezina";
            this.tbTezina.Size = new System.Drawing.Size(57, 20);
            this.tbTezina.TabIndex = 24;
            this.tbTezina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTezina_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(161, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "DIN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "grama";
            // 
            // tbDatum
            // 
            this.tbDatum.Location = new System.Drawing.Point(51, 29);
            this.tbDatum.Name = "tbDatum";
            this.tbDatum.ReadOnly = true;
            this.tbDatum.Size = new System.Drawing.Size(67, 20);
            this.tbDatum.TabIndex = 5;
            this.tbDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbKalorije
            // 
            this.tbKalorije.Location = new System.Drawing.Point(12, 210);
            this.tbKalorije.Name = "tbKalorije";
            this.tbKalorije.ReadOnly = true;
            this.tbKalorije.Size = new System.Drawing.Size(57, 20);
            this.tbKalorije.TabIndex = 1;
            this.tbKalorije.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMasti
            // 
            this.tbMasti.Location = new System.Drawing.Point(286, 210);
            this.tbMasti.Name = "tbMasti";
            this.tbMasti.ReadOnly = true;
            this.tbMasti.Size = new System.Drawing.Size(57, 20);
            this.tbMasti.TabIndex = 2;
            this.tbMasti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbProteini
            // 
            this.tbProteini.Location = new System.Drawing.Point(191, 210);
            this.tbProteini.Name = "tbProteini";
            this.tbProteini.ReadOnly = true;
            this.tbProteini.Size = new System.Drawing.Size(57, 20);
            this.tbProteini.TabIndex = 3;
            this.tbProteini.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cena
            // 
            this.Cena.AutoSize = true;
            this.Cena.Location = new System.Drawing.Point(57, 305);
            this.Cena.Name = "Cena";
            this.Cena.Size = new System.Drawing.Size(32, 13);
            this.Cena.TabIndex = 18;
            this.Cena.Text = "Cena";
            // 
            // tbHidrati
            // 
            this.tbHidrati.Location = new System.Drawing.Point(98, 210);
            this.tbHidrati.Name = "tbHidrati";
            this.tbHidrati.ReadOnly = true;
            this.tbHidrati.Size = new System.Drawing.Size(57, 20);
            this.tbHidrati.TabIndex = 4;
            this.tbHidrati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Kolicina
            // 
            this.Kolicina.AutoSize = true;
            this.Kolicina.Location = new System.Drawing.Point(48, 260);
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.Size = new System.Drawing.Size(44, 13);
            this.Kolicina.TabIndex = 17;
            this.Kolicina.Text = "Kolicina";
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(98, 302);
            this.tbCena.Name = "tbCena";
            this.tbCena.ReadOnly = true;
            this.tbCena.Size = new System.Drawing.Size(57, 20);
            this.tbCena.TabIndex = 16;
            this.tbCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Datum";
            // 
            // tbKolicina
            // 
            this.tbKolicina.Location = new System.Drawing.Point(98, 257);
            this.tbKolicina.Name = "tbKolicina";
            this.tbKolicina.ReadOnly = true;
            this.tbKolicina.Size = new System.Drawing.Size(57, 20);
            this.tbKolicina.TabIndex = 15;
            this.tbKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Opis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kalorije";
            // 
            // rtbOpis
            // 
            this.rtbOpis.Location = new System.Drawing.Point(12, 81);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(331, 95);
            this.rtbOpis.TabIndex = 13;
            this.rtbOpis.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ugljeni hidrati";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Masti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Proteini";
            // 
            // btnObrok
            // 
            this.btnObrok.Location = new System.Drawing.Point(13, 433);
            this.btnObrok.Name = "btnObrok";
            this.btnObrok.Size = new System.Drawing.Size(75, 23);
            this.btnObrok.TabIndex = 2;
            this.btnObrok.Text = "Obrok";
            this.btnObrok.UseVisualStyleBackColor = true;
            this.btnObrok.Click += new System.EventHandler(this.BtnObrok_Click);
            // 
            // btnHrana
            // 
            this.btnHrana.Location = new System.Drawing.Point(132, 433);
            this.btnHrana.Name = "btnHrana";
            this.btnHrana.Size = new System.Drawing.Size(75, 23);
            this.btnHrana.TabIndex = 3;
            this.btnHrana.Text = "Hrana";
            this.btnHrana.UseVisualStyleBackColor = true;
            this.btnHrana.Click += new System.EventHandler(this.BtnHrana_Click);
            // 
            // btnKalkulator
            // 
            this.btnKalkulator.Location = new System.Drawing.Point(262, 433);
            this.btnKalkulator.Name = "btnKalkulator";
            this.btnKalkulator.Size = new System.Drawing.Size(75, 23);
            this.btnKalkulator.TabIndex = 4;
            this.btnKalkulator.Text = "Kalkulator";
            this.btnKalkulator.UseVisualStyleBackColor = true;
            this.btnKalkulator.Click += new System.EventHandler(this.BtnKalkulator_Click);
            // 
            // btnPregled
            // 
            this.btnPregled.Location = new System.Drawing.Point(387, 433);
            this.btnPregled.Name = "btnPregled";
            this.btnPregled.Size = new System.Drawing.Size(75, 23);
            this.btnPregled.TabIndex = 5;
            this.btnPregled.Text = "Pregled";
            this.btnPregled.UseVisualStyleBackColor = true;
            this.btnPregled.Click += new System.EventHandler(this.BtnPregled_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(510, 433);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 6;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.BtnZatvori_Click);
            // 
            // dnevniUnosTableAdapter1
            // 
            this.dnevniUnosTableAdapter1.ClearBeforeFill = true;
            // 
            // ishranaDataSet1
            // 
            this.ishranaDataSet1.DataSetName = "IshranaDataSet";
            this.ishranaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 475);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnPregled);
            this.Controls.Add(this.btnKalkulator);
            this.Controls.Add(this.btnHrana);
            this.Controls.Add(this.btnObrok);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPocetna";
            this.Text = "Ishrana";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPocetna_FormClosing);
            this.Load += new System.EventHandler(this.FrmPocetna_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ishranaDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDatum;
        private System.Windows.Forms.TextBox tbKalorije;
        private System.Windows.Forms.TextBox tbMasti;
        private System.Windows.Forms.TextBox tbProteini;
        private System.Windows.Forms.Label Cena;
        private System.Windows.Forms.TextBox tbHidrati;
        private System.Windows.Forms.Label Kolicina;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKolicina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTezina;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnObrok;
        private System.Windows.Forms.Button btnHrana;
        private System.Windows.Forms.Button btnResetuj;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKalkulator;
        private System.Windows.Forms.Button btnPregled;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbID;
        private IshranaDataSetTableAdapters.DnevniUnosTableAdapter dnevniUnosTableAdapter1;
        private IshranaDataSet ishranaDataSet1;
    }
}