namespace Ishrana
{
    partial class frmKolicina
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
            this.tbKolicina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPotrvdi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KOLICINA: ";
            // 
            // tbKolicina
            // 
            this.tbKolicina.Location = new System.Drawing.Point(80, 58);
            this.tbKolicina.Name = "tbKolicina";
            this.tbKolicina.Size = new System.Drawing.Size(63, 20);
            this.tbKolicina.TabIndex = 1;
            this.tbKolicina.TextChanged += new System.EventHandler(this.TbKolicina_TextChanged);
            this.tbKolicina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbKolicina_KeyPress);
            this.tbKolicina.Validating += new System.ComponentModel.CancelEventHandler(this.TbKolicina_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "grama";
            // 
            // btnPotrvdi
            // 
            this.btnPotrvdi.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnPotrvdi.Location = new System.Drawing.Point(15, 120);
            this.btnPotrvdi.Name = "btnPotrvdi";
            this.btnPotrvdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotrvdi.TabIndex = 3;
            this.btnPotrvdi.Text = "Potvrdi";
            this.btnPotrvdi.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(150, 120);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 4;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmKolicina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 155);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotrvdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKolicina);
            this.Controls.Add(this.label1);
            this.Name = "frmKolicina";
            this.Text = "Provera kolicine";
            this.Load += new System.EventHandler(this.FrmKolicina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKolicina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPotrvdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}