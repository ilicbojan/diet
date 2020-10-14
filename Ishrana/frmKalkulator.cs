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
    public partial class frmKalkulator : Form
    {
        public frmKalkulator()
        {
            InitializeComponent();
        }

        private void FrmKalkulator_Load(object sender, EventArgs e)
        {
            rbMusko.Checked = true;
            cmbAktivnost.SelectedIndex = 0;
        }

        private float Kalorije(int br)
        {
            float rezultat = 0;
            rezultat = (float)(10 * float.Parse(tbTezina.Text)) + (float)(6.25 * float.Parse(tbVisina.Text))
                            - (float)(5 * float.Parse(tbGodine.Text)) + br;

            switch (cmbAktivnost.SelectedIndex)
            {
                case 1:
                    rezultat *= (float)1.2;
                    break;
                case 2:
                    rezultat *= (float)1.3755;
                    break;
                case 3:
                    rezultat *= (float)1.4651;
                    break;
                case 4:
                    rezultat *= (float)1.5506;
                    break;
                case 5:
                    rezultat *= (float)1.7252;
                    break;
                case 6:
                    rezultat *= (float)1.9004;
                    break;
                default:
                    rezultat *= 1;
                    break;
            }

            return rezultat;
        }

        private void BtnIzracunaj_Click(object sender, EventArgs e)
        {
            if(tbGodine.Text != "" && tbVisina.Text != "" && tbTezina.Text != ""
                    && int.Parse(tbGodine.Text) > 14 && int.Parse(tbGodine.Text) < 81)
            {
                float rezultat = 0;
                float rezultat1 = 0;
                int rezultat2 = 0;

                rezultat1 = float.Parse(tbTezina.Text) / ((float.Parse(tbVisina.Text) / 100) *
                            (float.Parse(tbVisina.Text) / 100));
                if (rbMusko.Checked)
                {
                    rezultat = Kalorije(5);
                    rezultat2 = int.Parse(tbVisina.Text) - 105;
                }
                else
                {
                    rezultat = Kalorije(-161);
                    rezultat2 = int.Parse(tbVisina.Text) - 110;
                }
                tbRezultat.Text = ((int)rezultat).ToString();
                tbRezultat1.Text = rezultat1.ToString();
                tbRezultat2.Text = rezultat2.ToString();
            }
            else
            {
                MessageBox.Show("Morate popuniti sva polja");
            }
        }

        private void BtnResetuj_Click(object sender, EventArgs e)
        {
            tbGodine.Clear();
            tbVisina.Clear();
            tbTezina.Clear();
            tbRezultat.Clear();
            tbRezultat1.Clear();
            tbRezultat2.Clear();
            rbMusko.Checked = true;
            cmbAktivnost.SelectedIndex = 0;
        }

        private void TbGodine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void TbTezina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void BtnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
