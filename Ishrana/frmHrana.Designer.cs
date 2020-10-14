namespace Ishrana
{
    partial class frmHrana
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hranaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNapravi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnResetuj = new System.Windows.Forms.Button();
            this.Cena = new System.Windows.Forms.Label();
            this.Kolicina = new System.Windows.Forms.Label();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.tbKolicina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbHidrati = new System.Windows.Forms.TextBox();
            this.tbProteini = new System.Windows.Forms.TextBox();
            this.tbMasti = new System.Windows.Forms.TextBox();
            this.tbKalorije = new System.Windows.Forms.TextBox();
            this.gbHrana = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbObrisi = new System.Windows.Forms.GroupBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIDObrisi = new System.Windows.Forms.TextBox();
            this.gbAzuriraj = new System.Windows.Forms.GroupBox();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hranaTableAdapter1 = new Ishrana.IshranaDataSetTableAdapters.HranaTableAdapter();
            this.ishranaDataSet1 = new Ishrana.IshranaDataSet();
            this.hranaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hranaBindingSource)).BeginInit();
            this.gbHrana.SuspendLayout();
            this.gbObrisi.SuspendLayout();
            this.gbAzuriraj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ishranaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hranaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView1.DataSource = this.hranaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(556, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // hranaBindingSource
            // 
            this.hranaBindingSource.DataMember = "Hrana";
            // 
            // btnNapravi
            // 
            this.btnNapravi.Location = new System.Drawing.Point(19, 240);
            this.btnNapravi.Name = "btnNapravi";
            this.btnNapravi.Size = new System.Drawing.Size(82, 23);
            this.btnNapravi.TabIndex = 1;
            this.btnNapravi.Text = "Napravi hranu";
            this.btnNapravi.UseVisualStyleBackColor = true;
            this.btnNapravi.Click += new System.EventHandler(this.BtnNapravi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(249, 240);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 42;
            this.btnOdustani.Text = "Izadji";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // btnResetuj
            // 
            this.btnResetuj.Location = new System.Drawing.Point(137, 240);
            this.btnResetuj.Name = "btnResetuj";
            this.btnResetuj.Size = new System.Drawing.Size(75, 23);
            this.btnResetuj.TabIndex = 41;
            this.btnResetuj.Text = "Resetuj";
            this.btnResetuj.UseVisualStyleBackColor = true;
            this.btnResetuj.Click += new System.EventHandler(this.BtnResetuj_Click);
            // 
            // Cena
            // 
            this.Cena.AutoSize = true;
            this.Cena.Location = new System.Drawing.Point(65, 191);
            this.Cena.Name = "Cena";
            this.Cena.Size = new System.Drawing.Size(32, 13);
            this.Cena.TabIndex = 39;
            this.Cena.Text = "Cena";
            // 
            // Kolicina
            // 
            this.Kolicina.AutoSize = true;
            this.Kolicina.Location = new System.Drawing.Point(53, 145);
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.Size = new System.Drawing.Size(44, 13);
            this.Kolicina.TabIndex = 38;
            this.Kolicina.Text = "Kolicina";
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(103, 188);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(57, 20);
            this.tbCena.TabIndex = 37;
            this.tbCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbCena_KeyPress);
            // 
            // tbKolicina
            // 
            this.tbKolicina.Location = new System.Drawing.Point(103, 142);
            this.tbKolicina.Name = "tbKolicina";
            this.tbKolicina.ReadOnly = true;
            this.tbKolicina.Size = new System.Drawing.Size(57, 20);
            this.tbKolicina.TabIndex = 36;
            this.tbKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Masti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Proteini";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Ugljeni hidrati";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Kalorije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Naziv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID";
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(137, 25);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(187, 20);
            this.tbNaziv.TabIndex = 27;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(38, 25);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(38, 20);
            this.tbID.TabIndex = 26;
            this.tbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbHidrati
            // 
            this.tbHidrati.Location = new System.Drawing.Point(103, 86);
            this.tbHidrati.Name = "tbHidrati";
            this.tbHidrati.Size = new System.Drawing.Size(57, 20);
            this.tbHidrati.TabIndex = 25;
            this.tbHidrati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbHidrati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Vrednosti_KeyPress);
            // 
            // tbProteini
            // 
            this.tbProteini.Location = new System.Drawing.Point(187, 86);
            this.tbProteini.Name = "tbProteini";
            this.tbProteini.Size = new System.Drawing.Size(57, 20);
            this.tbProteini.TabIndex = 24;
            this.tbProteini.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbProteini.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Vrednosti_KeyPress);
            // 
            // tbMasti
            // 
            this.tbMasti.Location = new System.Drawing.Point(267, 86);
            this.tbMasti.Name = "tbMasti";
            this.tbMasti.Size = new System.Drawing.Size(57, 20);
            this.tbMasti.TabIndex = 23;
            this.tbMasti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMasti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Vrednosti_KeyPress);
            // 
            // tbKalorije
            // 
            this.tbKalorije.Location = new System.Drawing.Point(19, 86);
            this.tbKalorije.Name = "tbKalorije";
            this.tbKalorije.Size = new System.Drawing.Size(57, 20);
            this.tbKalorije.TabIndex = 22;
            this.tbKalorije.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbKalorije.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Vrednosti_KeyPress);
            // 
            // gbHrana
            // 
            this.gbHrana.Controls.Add(this.label11);
            this.gbHrana.Controls.Add(this.label10);
            this.gbHrana.Controls.Add(this.btnOdustani);
            this.gbHrana.Controls.Add(this.btnNapravi);
            this.gbHrana.Controls.Add(this.btnResetuj);
            this.gbHrana.Controls.Add(this.tbKalorije);
            this.gbHrana.Controls.Add(this.Cena);
            this.gbHrana.Controls.Add(this.tbMasti);
            this.gbHrana.Controls.Add(this.Kolicina);
            this.gbHrana.Controls.Add(this.tbProteini);
            this.gbHrana.Controls.Add(this.tbCena);
            this.gbHrana.Controls.Add(this.tbHidrati);
            this.gbHrana.Controls.Add(this.tbKolicina);
            this.gbHrana.Controls.Add(this.tbID);
            this.gbHrana.Controls.Add(this.label6);
            this.gbHrana.Controls.Add(this.tbNaziv);
            this.gbHrana.Controls.Add(this.label5);
            this.gbHrana.Controls.Add(this.label1);
            this.gbHrana.Controls.Add(this.label4);
            this.gbHrana.Controls.Add(this.label2);
            this.gbHrana.Controls.Add(this.label3);
            this.gbHrana.Location = new System.Drawing.Point(12, 13);
            this.gbHrana.Name = "gbHrana";
            this.gbHrana.Size = new System.Drawing.Size(346, 277);
            this.gbHrana.TabIndex = 43;
            this.gbHrana.TabStop = false;
            this.gbHrana.Text = "Unos hrane";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(166, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "DIN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(166, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "grama";
            // 
            // gbObrisi
            // 
            this.gbObrisi.Controls.Add(this.btnObrisi);
            this.gbObrisi.Controls.Add(this.label7);
            this.gbObrisi.Controls.Add(this.tbIDObrisi);
            this.gbObrisi.Location = new System.Drawing.Point(369, 19);
            this.gbObrisi.Name = "gbObrisi";
            this.gbObrisi.Size = new System.Drawing.Size(200, 100);
            this.gbObrisi.TabIndex = 44;
            this.gbObrisi.TabStop = false;
            this.gbObrisi.Text = "Brisanje hrane";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(61, 60);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "ID hrane";
            // 
            // tbIDObrisi
            // 
            this.tbIDObrisi.Location = new System.Drawing.Point(61, 25);
            this.tbIDObrisi.Name = "tbIDObrisi";
            this.tbIDObrisi.Size = new System.Drawing.Size(100, 20);
            this.tbIDObrisi.TabIndex = 0;
            this.tbIDObrisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbCena_KeyPress);
            // 
            // gbAzuriraj
            // 
            this.gbAzuriraj.Controls.Add(this.btnAzuriraj);
            this.gbAzuriraj.Controls.Add(this.label9);
            this.gbAzuriraj.Controls.Add(this.label8);
            this.gbAzuriraj.Location = new System.Drawing.Point(369, 174);
            this.gbAzuriraj.Name = "gbAzuriraj";
            this.gbAzuriraj.Size = new System.Drawing.Size(200, 116);
            this.gbAzuriraj.TabIndex = 45;
            this.gbAzuriraj.TabStop = false;
            this.gbAzuriraj.Text = "Azuriranje hrane";
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(61, 79);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(75, 23);
            this.btnAzuriraj.TabIndex = 2;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.BtnAzuriraj_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "u tabeli i pritisni dugme \"Azuriraj\"";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Promeni podatke za postojecu hranu ";
            // 
            // hranaTableAdapter1
            // 
            this.hranaTableAdapter1.ClearBeforeFill = true;
            // 
            // ishranaDataSet1
            // 
            this.ishranaDataSet1.DataSetName = "IshranaDataSet";
            this.ishranaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hranaBindingSource1
            // 
            this.hranaBindingSource1.DataMember = "Hrana";
            this.hranaBindingSource1.DataSource = this.ishranaDataSet1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HranaID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Kalorije";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "kcal";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "UgljeniHidrati";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "UH";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Proteini";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn5.HeaderText = "Prot";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Masti";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn6.HeaderText = "Masti";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Kolicina";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn7.HeaderText = "g";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 40;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Cena";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn8.HeaderText = "Cena";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 40;
            // 
            // frmHrana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 601);
            this.Controls.Add(this.gbAzuriraj);
            this.Controls.Add(this.gbObrisi);
            this.Controls.Add(this.gbHrana);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmHrana";
            this.Text = "Hrana";
            this.Load += new System.EventHandler(this.Hrana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hranaBindingSource)).EndInit();
            this.gbHrana.ResumeLayout(false);
            this.gbHrana.PerformLayout();
            this.gbObrisi.ResumeLayout(false);
            this.gbObrisi.PerformLayout();
            this.gbAzuriraj.ResumeLayout(false);
            this.gbAzuriraj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ishranaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hranaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNapravi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnResetuj;
        private System.Windows.Forms.Label Cena;
        private System.Windows.Forms.Label Kolicina;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.TextBox tbKolicina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbHidrati;
        private System.Windows.Forms.TextBox tbProteini;
        private System.Windows.Forms.TextBox tbMasti;
        private System.Windows.Forms.TextBox tbKalorije;
        private System.Windows.Forms.GroupBox gbHrana;
        private IshranaDataSet ishranaDataSet;
        private System.Windows.Forms.BindingSource hranaBindingSource;
        private IshranaDataSetTableAdapters.HranaTableAdapter hranaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hranaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalorijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ugljeniHidratiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proteiniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mastiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbObrisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIDObrisi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.GroupBox gbAzuriraj;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private IshranaDataSetTableAdapters.HranaTableAdapter hranaTableAdapter1;
        private IshranaDataSet ishranaDataSet1;
        private System.Windows.Forms.BindingSource hranaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}