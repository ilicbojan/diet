using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ishrana
{
    public partial class frmHrana : Form
    {
        SqlConnection konekcija = new SqlConnection(Konekcija.konString);

        public frmHrana()
        {
            InitializeComponent();
        }

        private void Hrana_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ishranaDataSet.Hrana' table. You can move, or remove it, as needed.
            this.hranaTableAdapter1.Fill(this.ishranaDataSet1.Hrana);
            Reset();
        }

        private void Reset()
        {
            try
            {
                konekcija.Open();

                SqlCommand kom = new SqlCommand();
                kom.Connection = konekcija;
                kom.CommandText = "select top 1 HranaID from Hrana order by HranaID desc";
                tbID.Text = (int.Parse(kom.ExecuteScalar().ToString()) + 1).ToString();
            }
            catch (Exception)
            {
                tbID.Text = 1.ToString();
            }
            finally
            {
                konekcija.Close();
            }

            tbKalorije.Clear();
            tbHidrati.Clear();
            tbProteini.Clear();
            tbMasti.Clear();
            tbKolicina.Text = 100.ToString();
            tbCena.Clear();
            tbNaziv.Clear();
            tbIDObrisi.Clear();
        }

        private void BtnResetuj_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Vrednosti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNapravi_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(tbNaziv.Text) && !String.IsNullOrEmpty(tbKalorije.Text) &&
                !String.IsNullOrEmpty(tbProteini.Text) && !String.IsNullOrEmpty(tbHidrati.Text) &&
                !String.IsNullOrEmpty(tbMasti.Text) && !String.IsNullOrEmpty(tbCena.Text))
            {
                try
                {
                    hranaTableAdapter1.Insert(int.Parse(tbID.Text),
                                            tbNaziv.Text,
                                            float.Parse(tbKalorije.Text),
                                            float.Parse(tbHidrati.Text),
                                            float.Parse(tbProteini.Text),
                                            float.Parse(tbMasti.Text),
                                            int.Parse(tbKolicina.Text),
                                            int.Parse(tbCena.Text));

                    MessageBox.Show("Uspesno napravljena hrana");
                    hranaTableAdapter1.Fill(ishranaDataSet1.Hrana);
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Morate uneti sve podatke");
            }
        }

        private void TbCena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            if (tbIDObrisi.Text != "")
            {
                if (MessageBox.Show("Da li zelite da obrisete izabranu hranu?", "Potvrda", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        konekcija.Open();
                        using (SqlCommand komanda = new SqlCommand("delete from Hrana where HranaID=@id", konekcija))
                        {
                            komanda.Parameters.Add(new SqlParameter("id", int.Parse(tbIDObrisi.Text)));
                            komanda.ExecuteNonQuery();
                        }
                        hranaTableAdapter1.Fill(ishranaDataSet1.Hrana);
                        MessageBox.Show("Brisanje uspesno obavljeno");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Greska: " + ex.Message);
                    }
                    finally
                    {
                        konekcija.Close();
                    }
                    Reset();
                }
            }
            else
            {
                MessageBox.Show("Morate uneti ID hrane");
            }
        }

        private void BtnAzuriraj_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li zelite da izmenite podatke?", "Potvrda",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    hranaTableAdapter1.Update(ishranaDataSet1.Hrana);
                    MessageBox.Show("Uspesno izmenjeni podaci!", "Obavestenje");
                    hranaTableAdapter1.Fill(ishranaDataSet1.Hrana);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Reset();
            }
            else
            {
                hranaTableAdapter1.Fill(ishranaDataSet.Hrana);
            }
        }
    }
}
