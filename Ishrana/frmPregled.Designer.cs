namespace Ishrana
{
    partial class frmPregled
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTezina3 = new System.Windows.Forms.TextBox();
            this.tbTezina2 = new System.Windows.Forms.TextBox();
            this.tbTezina1 = new System.Windows.Forms.TextBox();
            this.tbKalorije = new System.Windows.Forms.TextBox();
            this.tbMasti = new System.Windows.Forms.TextBox();
            this.tbProteini = new System.Windows.Forms.TextBox();
            this.tbHidrati = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbIzbor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Cena = new System.Windows.Forms.Label();
            this.Kolicina = new System.Windows.Forms.Label();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.tbKolicina = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dnevniUnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ishranaDataSet = new Ishrana.IshranaDataSet();
            this.dnevniUnosTableAdapter = new Ishrana.IshranaDataSetTableAdapters.DnevniUnosTableAdapter();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbIDObrisi = new System.Windows.Forms.TextBox();
            this.dnevniUnosIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalorijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugljeniHidratiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proteiniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mastiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tezinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnevniUnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ishranaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTezina3);
            this.groupBox1.Controls.Add(this.tbTezina2);
            this.groupBox1.Controls.Add(this.tbTezina1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tezina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Prosecna tezina pretprosle nedelje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prosecna tezina prosle nedelje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prosecna tezina tekuce nedelje";
            // 
            // tbTezina3
            // 
            this.tbTezina3.Location = new System.Drawing.Point(178, 144);
            this.tbTezina3.Name = "tbTezina3";
            this.tbTezina3.ReadOnly = true;
            this.tbTezina3.Size = new System.Drawing.Size(57, 20);
            this.tbTezina3.TabIndex = 2;
            // 
            // tbTezina2
            // 
            this.tbTezina2.Location = new System.Drawing.Point(178, 97);
            this.tbTezina2.Name = "tbTezina2";
            this.tbTezina2.ReadOnly = true;
            this.tbTezina2.Size = new System.Drawing.Size(57, 20);
            this.tbTezina2.TabIndex = 1;
            // 
            // tbTezina1
            // 
            this.tbTezina1.Location = new System.Drawing.Point(178, 48);
            this.tbTezina1.Name = "tbTezina1";
            this.tbTezina1.ReadOnly = true;
            this.tbTezina1.Size = new System.Drawing.Size(57, 20);
            this.tbTezina1.TabIndex = 0;
            // 
            // tbKalorije
            // 
            this.tbKalorije.Location = new System.Drawing.Point(14, 85);
            this.tbKalorije.Name = "tbKalorije";
            this.tbKalorije.ReadOnly = true;
            this.tbKalorije.Size = new System.Drawing.Size(57, 20);
            this.tbKalorije.TabIndex = 13;
            this.tbKalorije.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMasti
            // 
            this.tbMasti.Location = new System.Drawing.Point(288, 85);
            this.tbMasti.Name = "tbMasti";
            this.tbMasti.ReadOnly = true;
            this.tbMasti.Size = new System.Drawing.Size(57, 20);
            this.tbMasti.TabIndex = 14;
            this.tbMasti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbProteini
            // 
            this.tbProteini.Location = new System.Drawing.Point(193, 85);
            this.tbProteini.Name = "tbProteini";
            this.tbProteini.ReadOnly = true;
            this.tbProteini.Size = new System.Drawing.Size(57, 20);
            this.tbProteini.TabIndex = 15;
            this.tbProteini.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbHidrati
            // 
            this.tbHidrati.Location = new System.Drawing.Point(100, 85);
            this.tbHidrati.Name = "tbHidrati";
            this.tbHidrati.ReadOnly = true;
            this.tbHidrati.Size = new System.Drawing.Size(57, 20);
            this.tbHidrati.TabIndex = 16;
            this.tbHidrati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kalorije";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ugljeni hidrati";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Masti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Proteini";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbIzbor);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Cena);
            this.groupBox2.Controls.Add(this.Kolicina);
            this.groupBox2.Controls.Add(this.tbCena);
            this.groupBox2.Controls.Add(this.tbKolicina);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbKalorije);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbMasti);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbProteini);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbHidrati);
            this.groupBox2.Location = new System.Drawing.Point(270, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 217);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistika";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Izaberi prikaz";
            // 
            // cmbIzbor
            // 
            this.cmbIzbor.FormattingEnabled = true;
            this.cmbIzbor.Items.AddRange(new object[] {
            "Dnevni prosek",
            "Prosek tekuce nedelje",
            "Prosek prosle nedelje",
            "Prosek pretprosle nedelje"});
            this.cmbIzbor.Location = new System.Drawing.Point(100, 30);
            this.cmbIzbor.Name = "cmbIzbor";
            this.cmbIzbor.Size = new System.Drawing.Size(150, 21);
            this.cmbIzbor.TabIndex = 30;
            this.cmbIzbor.SelectedIndexChanged += new System.EventHandler(this.CmbIzbor_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(163, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "DIN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(163, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "grama";
            // 
            // Cena
            // 
            this.Cena.AutoSize = true;
            this.Cena.Location = new System.Drawing.Point(59, 181);
            this.Cena.Name = "Cena";
            this.Cena.Size = new System.Drawing.Size(32, 13);
            this.Cena.TabIndex = 27;
            this.Cena.Text = "Cena";
            // 
            // Kolicina
            // 
            this.Kolicina.AutoSize = true;
            this.Kolicina.Location = new System.Drawing.Point(50, 134);
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.Size = new System.Drawing.Size(44, 13);
            this.Kolicina.TabIndex = 26;
            this.Kolicina.Text = "Kolicina";
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(100, 178);
            this.tbCena.Name = "tbCena";
            this.tbCena.ReadOnly = true;
            this.tbCena.Size = new System.Drawing.Size(57, 20);
            this.tbCena.TabIndex = 25;
            this.tbCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbKolicina
            // 
            this.tbKolicina.Location = new System.Drawing.Point(100, 131);
            this.tbKolicina.Name = "tbKolicina";
            this.tbKolicina.ReadOnly = true;
            this.tbKolicina.Size = new System.Drawing.Size(57, 20);
            this.tbKolicina.TabIndex = 24;
            this.tbKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dnevniUnosIDDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.kalorijeDataGridViewTextBoxColumn,
            this.ugljeniHidratiDataGridViewTextBoxColumn,
            this.proteiniDataGridViewTextBoxColumn,
            this.mastiDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.tezinaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dnevniUnosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(611, 177);
            this.dataGridView1.TabIndex = 22;
            // 
            // dnevniUnosBindingSource
            // 
            this.dnevniUnosBindingSource.DataMember = "DnevniUnos";
            this.dnevniUnosBindingSource.DataSource = this.ishranaDataSet;
            // 
            // ishranaDataSet
            // 
            this.ishranaDataSet.DataSetName = "IshranaDataSet";
            this.ishranaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dnevniUnosTableAdapter
            // 
            this.dnevniUnosTableAdapter.ClearBeforeFill = true;
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(548, 442);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(75, 23);
            this.btnIzadji.TabIndex = 24;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.BtnIzadji_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(232, 442);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 27;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 448);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "ID dana";
            // 
            // tbIDObrisi
            // 
            this.tbIDObrisi.Location = new System.Drawing.Point(118, 444);
            this.tbIDObrisi.Name = "tbIDObrisi";
            this.tbIDObrisi.Size = new System.Drawing.Size(75, 20);
            this.tbIDObrisi.TabIndex = 26;
            // 
            // dnevniUnosIDDataGridViewTextBoxColumn
            // 
            this.dnevniUnosIDDataGridViewTextBoxColumn.DataPropertyName = "DnevniUnosID";
            this.dnevniUnosIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.dnevniUnosIDDataGridViewTextBoxColumn.Name = "dnevniUnosIDDataGridViewTextBoxColumn";
            this.dnevniUnosIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.Width = 70;
            // 
            // kalorijeDataGridViewTextBoxColumn
            // 
            this.kalorijeDataGridViewTextBoxColumn.DataPropertyName = "Kalorije";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = null;
            this.kalorijeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.kalorijeDataGridViewTextBoxColumn.HeaderText = "kcal";
            this.kalorijeDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.kalorijeDataGridViewTextBoxColumn.Name = "kalorijeDataGridViewTextBoxColumn";
            this.kalorijeDataGridViewTextBoxColumn.Width = 50;
            // 
            // ugljeniHidratiDataGridViewTextBoxColumn
            // 
            this.ugljeniHidratiDataGridViewTextBoxColumn.DataPropertyName = "UgljeniHidrati";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "N2";
            dataGridViewCellStyle16.NullValue = null;
            this.ugljeniHidratiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.ugljeniHidratiDataGridViewTextBoxColumn.HeaderText = "UH";
            this.ugljeniHidratiDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.ugljeniHidratiDataGridViewTextBoxColumn.Name = "ugljeniHidratiDataGridViewTextBoxColumn";
            this.ugljeniHidratiDataGridViewTextBoxColumn.Width = 50;
            // 
            // proteiniDataGridViewTextBoxColumn
            // 
            this.proteiniDataGridViewTextBoxColumn.DataPropertyName = "Proteini";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N2";
            dataGridViewCellStyle17.NullValue = null;
            this.proteiniDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.proteiniDataGridViewTextBoxColumn.HeaderText = "Prot";
            this.proteiniDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.proteiniDataGridViewTextBoxColumn.Name = "proteiniDataGridViewTextBoxColumn";
            this.proteiniDataGridViewTextBoxColumn.Width = 50;
            // 
            // mastiDataGridViewTextBoxColumn
            // 
            this.mastiDataGridViewTextBoxColumn.DataPropertyName = "Masti";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N2";
            dataGridViewCellStyle18.NullValue = null;
            this.mastiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.mastiDataGridViewTextBoxColumn.HeaderText = "Masti";
            this.mastiDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.mastiDataGridViewTextBoxColumn.Name = "mastiDataGridViewTextBoxColumn";
            this.mastiDataGridViewTextBoxColumn.Width = 50;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.kolicinaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle19;
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "g";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.Width = 40;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cenaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle20;
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.Width = 40;
            // 
            // tezinaDataGridViewTextBoxColumn
            // 
            this.tezinaDataGridViewTextBoxColumn.DataPropertyName = "Tezina";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "N1";
            dataGridViewCellStyle21.NullValue = null;
            this.tezinaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle21;
            this.tezinaDataGridViewTextBoxColumn.HeaderText = "Tezina";
            this.tezinaDataGridViewTextBoxColumn.MaxInputLength = 5;
            this.tezinaDataGridViewTextBoxColumn.Name = "tezinaDataGridViewTextBoxColumn";
            this.tezinaDataGridViewTextBoxColumn.Width = 40;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.Width = 140;
            // 
            // frmPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 482);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbIDObrisi);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPregled";
            this.Text = "frmPregled";
            this.Load += new System.EventHandler(this.FrmPregled_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnevniUnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ishranaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbKalorije;
        private System.Windows.Forms.TextBox tbMasti;
        private System.Windows.Forms.TextBox tbProteini;
        private System.Windows.Forms.TextBox tbHidrati;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Cena;
        private System.Windows.Forms.Label Kolicina;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.TextBox tbKolicina;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTezina3;
        private System.Windows.Forms.TextBox tbTezina2;
        private System.Windows.Forms.TextBox tbTezina1;
        private IshranaDataSet ishranaDataSet;
        private System.Windows.Forms.BindingSource dnevniUnosBindingSource;
        private IshranaDataSetTableAdapters.DnevniUnosTableAdapter dnevniUnosTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbIzbor;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbIDObrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnevniUnosIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalorijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ugljeniHidratiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proteiniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mastiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tezinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
    }
}