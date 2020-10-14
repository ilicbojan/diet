namespace Ishrana
{
    partial class frmObrok
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbHrana = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbKalorije = new System.Windows.Forms.TextBox();
            this.tbMasti = new System.Windows.Forms.TextBox();
            this.tbProteini = new System.Windows.Forms.TextBox();
            this.tbHidrati = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbKolicina = new System.Windows.Forms.TextBox();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.Kolicina = new System.Windows.Forms.Label();
            this.Cena = new System.Windows.Forms.Label();
            this.btnNapravi = new System.Windows.Forms.Button();
            this.btnResetuj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.obrokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ishranaDataSet = new Ishrana.IshranaDataSet();
            this.obrokTableAdapter = new Ishrana.IshranaDataSetTableAdapters.ObrokTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbIDObrisi = new System.Windows.Forms.TextBox();
            this.obrokIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalorijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugljeniHidratiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proteiniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mastiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbHrana.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ishranaDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbHrana
            // 
            this.gbHrana.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbHrana.Controls.Add(this.panel1);
            this.gbHrana.Location = new System.Drawing.Point(12, 12);
            this.gbHrana.Name = "gbHrana";
            this.gbHrana.Size = new System.Drawing.Size(212, 424);
            this.gbHrana.TabIndex = 0;
            this.gbHrana.TabStop = false;
            this.gbHrana.Text = "Hrana";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(6, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 405);
            this.panel1.TabIndex = 0;
            // 
            // tbKalorije
            // 
            this.tbKalorije.Location = new System.Drawing.Point(12, 189);
            this.tbKalorije.Name = "tbKalorije";
            this.tbKalorije.ReadOnly = true;
            this.tbKalorije.Size = new System.Drawing.Size(57, 20);
            this.tbKalorije.TabIndex = 22;
            this.tbKalorije.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMasti
            // 
            this.tbMasti.Location = new System.Drawing.Point(286, 189);
            this.tbMasti.Name = "tbMasti";
            this.tbMasti.ReadOnly = true;
            this.tbMasti.Size = new System.Drawing.Size(57, 20);
            this.tbMasti.TabIndex = 0;
            this.tbMasti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbProteini
            // 
            this.tbProteini.Location = new System.Drawing.Point(191, 189);
            this.tbProteini.Name = "tbProteini";
            this.tbProteini.ReadOnly = true;
            this.tbProteini.Size = new System.Drawing.Size(57, 20);
            this.tbProteini.TabIndex = 0;
            this.tbProteini.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbHidrati
            // 
            this.tbHidrati.Location = new System.Drawing.Point(98, 189);
            this.tbHidrati.Name = "tbHidrati";
            this.tbHidrati.ReadOnly = true;
            this.tbHidrati.Size = new System.Drawing.Size(57, 20);
            this.tbHidrati.TabIndex = 0;
            this.tbHidrati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(33, 19);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(38, 20);
            this.tbID.TabIndex = 0;
            this.tbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(135, 19);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(208, 20);
            this.tbNaziv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kalorije";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ugljeni hidrati";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Proteini";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Masti";
            // 
            // rtbOpis
            // 
            this.rtbOpis.Location = new System.Drawing.Point(12, 64);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(331, 95);
            this.rtbOpis.TabIndex = 1;
            this.rtbOpis.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Opis:";
            // 
            // tbKolicina
            // 
            this.tbKolicina.Location = new System.Drawing.Point(98, 234);
            this.tbKolicina.Name = "tbKolicina";
            this.tbKolicina.ReadOnly = true;
            this.tbKolicina.Size = new System.Drawing.Size(57, 20);
            this.tbKolicina.TabIndex = 0;
            this.tbKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(98, 280);
            this.tbCena.Name = "tbCena";
            this.tbCena.ReadOnly = true;
            this.tbCena.Size = new System.Drawing.Size(57, 20);
            this.tbCena.TabIndex = 0;
            this.tbCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Kolicina
            // 
            this.Kolicina.AutoSize = true;
            this.Kolicina.Location = new System.Drawing.Point(48, 237);
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.Size = new System.Drawing.Size(44, 13);
            this.Kolicina.TabIndex = 17;
            this.Kolicina.Text = "Kolicina";
            // 
            // Cena
            // 
            this.Cena.AutoSize = true;
            this.Cena.Location = new System.Drawing.Point(57, 283);
            this.Cena.Name = "Cena";
            this.Cena.Size = new System.Drawing.Size(32, 13);
            this.Cena.TabIndex = 18;
            this.Cena.Text = "Cena";
            // 
            // btnNapravi
            // 
            this.btnNapravi.Location = new System.Drawing.Point(12, 322);
            this.btnNapravi.Name = "btnNapravi";
            this.btnNapravi.Size = new System.Drawing.Size(88, 23);
            this.btnNapravi.TabIndex = 2;
            this.btnNapravi.Text = "Napravi obrok";
            this.btnNapravi.UseVisualStyleBackColor = true;
            this.btnNapravi.Click += new System.EventHandler(this.BtnNapravi_Click);
            // 
            // btnResetuj
            // 
            this.btnResetuj.Location = new System.Drawing.Point(145, 322);
            this.btnResetuj.Name = "btnResetuj";
            this.btnResetuj.Size = new System.Drawing.Size(75, 23);
            this.btnResetuj.TabIndex = 3;
            this.btnResetuj.Text = "Resetuj";
            this.btnResetuj.UseVisualStyleBackColor = true;
            this.btnResetuj.Click += new System.EventHandler(this.BtnResetuj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnOdustani.Location = new System.Drawing.Point(268, 322);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 4;
            this.btnOdustani.Text = "Izadji";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.btnOdustani);
            this.groupBox1.Controls.Add(this.tbKalorije);
            this.groupBox1.Controls.Add(this.btnResetuj);
            this.groupBox1.Controls.Add(this.tbMasti);
            this.groupBox1.Controls.Add(this.btnNapravi);
            this.groupBox1.Controls.Add(this.tbProteini);
            this.groupBox1.Controls.Add(this.Cena);
            this.groupBox1.Controls.Add(this.tbHidrati);
            this.groupBox1.Controls.Add(this.Kolicina);
            this.groupBox1.Controls.Add(this.tbNaziv);
            this.groupBox1.Controls.Add(this.tbCena);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbKolicina);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rtbOpis);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(246, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos obroka";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(161, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "DIN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "grama";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.obrokIDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.kalorijeDataGridViewTextBoxColumn,
            this.ugljeniHidratiDataGridViewTextBoxColumn,
            this.proteiniDataGridViewTextBoxColumn,
            this.mastiDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.obrokBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 442);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 180);
            this.dataGridView1.TabIndex = 1;
            // 
            // obrokBindingSource
            // 
            this.obrokBindingSource.DataMember = "Obrok";
            this.obrokBindingSource.DataSource = this.ishranaDataSet;
            // 
            // ishranaDataSet
            // 
            this.ishranaDataSet.DataSetName = "IshranaDataSet";
            this.ishranaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obrokTableAdapter
            // 
            this.obrokTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnObrisi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbIDObrisi);
            this.groupBox2.Location = new System.Drawing.Point(246, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 65);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brisanje obroka";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(268, 19);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "ID obroka";
            // 
            // tbIDObrisi
            // 
            this.tbIDObrisi.Location = new System.Drawing.Point(145, 21);
            this.tbIDObrisi.Name = "tbIDObrisi";
            this.tbIDObrisi.Size = new System.Drawing.Size(75, 20);
            this.tbIDObrisi.TabIndex = 5;
            // 
            // obrokIDDataGridViewTextBoxColumn
            // 
            this.obrokIDDataGridViewTextBoxColumn.DataPropertyName = "ObrokID";
            this.obrokIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.obrokIDDataGridViewTextBoxColumn.Name = "obrokIDDataGridViewTextBoxColumn";
            this.obrokIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // kalorijeDataGridViewTextBoxColumn
            // 
            this.kalorijeDataGridViewTextBoxColumn.DataPropertyName = "Kalorije";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.kalorijeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.kalorijeDataGridViewTextBoxColumn.HeaderText = "kcal";
            this.kalorijeDataGridViewTextBoxColumn.Name = "kalorijeDataGridViewTextBoxColumn";
            this.kalorijeDataGridViewTextBoxColumn.Width = 50;
            // 
            // ugljeniHidratiDataGridViewTextBoxColumn
            // 
            this.ugljeniHidratiDataGridViewTextBoxColumn.DataPropertyName = "UgljeniHidrati";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.ugljeniHidratiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.ugljeniHidratiDataGridViewTextBoxColumn.HeaderText = "UH";
            this.ugljeniHidratiDataGridViewTextBoxColumn.Name = "ugljeniHidratiDataGridViewTextBoxColumn";
            this.ugljeniHidratiDataGridViewTextBoxColumn.Width = 50;
            // 
            // proteiniDataGridViewTextBoxColumn
            // 
            this.proteiniDataGridViewTextBoxColumn.DataPropertyName = "Proteini";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.proteiniDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.proteiniDataGridViewTextBoxColumn.HeaderText = "Prot";
            this.proteiniDataGridViewTextBoxColumn.Name = "proteiniDataGridViewTextBoxColumn";
            this.proteiniDataGridViewTextBoxColumn.Width = 50;
            // 
            // mastiDataGridViewTextBoxColumn
            // 
            this.mastiDataGridViewTextBoxColumn.DataPropertyName = "Masti";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.mastiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.mastiDataGridViewTextBoxColumn.HeaderText = "Masti";
            this.mastiDataGridViewTextBoxColumn.Name = "mastiDataGridViewTextBoxColumn";
            this.mastiDataGridViewTextBoxColumn.Width = 50;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.kolicinaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "g";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.Width = 30;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cenaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.Width = 40;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.Width = 140;
            // 
            // frmObrok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 630);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbHrana);
            this.Name = "frmObrok";
            this.Text = "Kreiraj obrok";
            this.Load += new System.EventHandler(this.FrmObrok_Load);
            this.gbHrana.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ishranaDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHrana;
        private System.Windows.Forms.TextBox tbKalorije;
        private System.Windows.Forms.TextBox tbMasti;
        private System.Windows.Forms.TextBox tbProteini;
        private System.Windows.Forms.TextBox tbHidrati;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbKolicina;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.Label Kolicina;
        private System.Windows.Forms.Label Cena;
        private System.Windows.Forms.Button btnNapravi;
        private System.Windows.Forms.Button btnResetuj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private IshranaDataSet ishranaDataSet;
        private System.Windows.Forms.BindingSource obrokBindingSource;
        private IshranaDataSetTableAdapters.ObrokTableAdapter obrokTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbIDObrisi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn obrokIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalorijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ugljeniHidratiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proteiniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mastiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
    }
}