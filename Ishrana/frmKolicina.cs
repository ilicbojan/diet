using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ishrana
{
    public partial class frmKolicina : Form
    {
        public Kolicina kolicina;

        public frmKolicina()
        {
            InitializeComponent();
            kolicina = new Kolicina();
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TbKolicina_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbKolicina.Text))
            {
                errorProvider1.SetError(tbKolicina, "Morate uneti kolicinu!");
            }
        }

        private void TbKolicina_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbKolicina.Text))
            {
                if (int.Parse(tbKolicina.Text) / 10 == 0)
                {
                    kolicina.Kol = float.Parse(tbKolicina.Text);
                }
                else
                {
                    kolicina.Kol = float.Parse(tbKolicina.Text) / 100;
                }
            }
        }

        private void FrmKolicina_Load(object sender, EventArgs e)
        {

        }

        private void TbKolicina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

    }
}
