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
    public partial class frmPregled : Form
    {
        SqlConnection konekcija = new SqlConnection(Konekcija.konString);

        public frmPregled()
        {
            InitializeComponent();
        }

        private void FrmPregled_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ishranaDataSet.DnevniUnos' table. You can move, or remove it, as needed.
            this.dnevniUnosTableAdapter.Fill(this.ishranaDataSet.DnevniUnos);
            // TODO: This line of code loads data into the 'ishranaDataSet.DnevniUnos' table. You can move, or remove it, as needed.
            this.dnevniUnosTableAdapter.Fill(this.ishranaDataSet.DnevniUnos);

            cmbIzbor.SelectedIndex = 0;
            PopuniTezine();
        }

        private void PopuniTezine()
        {
            try
            {
                konekcija.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = konekcija;
                com.CommandText = "select top 1 DnevniUnosID from DnevniUnos order by DnevniUnosID desc";
                int id = int.Parse(com.ExecuteScalar().ToString())-1;

                SqlCommand kom = new SqlCommand();
                kom.Connection = konekcija;

                kom.Parameters.Add(new SqlParameter("id", id));

                kom.CommandText = "select avg(Tezina) from DnevniUnos where DnevniUnosID > @id-(@id%7)" +
                                        " and DnevniUnosID <= @id+7-(@id%7)";
                tbTezina1.Text = Double.Parse(kom.ExecuteScalar().ToString()).ToString("n1");

                kom.CommandText = "select avg(Tezina) from DnevniUnos where DnevniUnosID > @id-(@id%7)-7" +
                                        " and DnevniUnosID <= @id+7-(@id%7)-7";
                tbTezina2.Text = Double.Parse(kom.ExecuteScalar().ToString()).ToString("n1");

                kom.CommandText = "select avg(Tezina) from DnevniUnos where DnevniUnosID > @id-(@id%7)-14" +
                                        " and DnevniUnosID <= @id+7-(@id%7)-14";
                tbTezina3.Text = Double.Parse(kom.ExecuteScalar().ToString()).ToString("n1");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void IspisiDnevnuStatistiku()
        {
            try
            {
                konekcija.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = konekcija;
                com.CommandText = "select top 1 DnevniUnosID from DnevniUnos order by DnevniUnosID desc";
                int id = int.Parse(com.ExecuteScalar().ToString()) - 1;

                SqlCommand kom = new SqlCommand();
                kom.Connection = konekcija;

                kom.Parameters.Add(new SqlParameter("id", id));

                kom.CommandText = "select avg(Kalorije) from DnevniUnos";
                tbKalorije.Text = Double.Parse(kom.ExecuteScalar().ToString()).ToString("n2");

                kom.CommandText = "select avg(UgljeniHidrati) from DnevniUnos";
                tbHidrati.Text = Double.Parse(kom.ExecuteScalar().ToString()).ToString("n2");

                kom.CommandText = "select avg(Proteini) from DnevniUnos";
                tbProteini.Text = Double.Parse(kom.ExecuteScalar().ToString()).ToString("n2");

                kom.CommandText = "select avg(Masti) from DnevniUnos";
                tbMasti.Text = Double.Parse(kom.ExecuteScalar().ToString()).ToString("n2");

                kom.CommandText = "select avg(Kolicina) from DnevniUnos";
                tbKolicina.Text = Double.Parse(kom.ExecuteScalar().ToString()).ToString("n2");

                kom.CommandText = "select avg(Cena) from DnevniUnos";
                tbCena.Text = Double.Parse(kom.ExecuteScalar().ToString()).ToString("n2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void IspisiStatistiku(int br)
        {
            try
            {
                konekcija.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = konekcija;
                com.CommandText = "select top 1 DnevniUnosID from DnevniUnos order by DnevniUnosID desc";
                int id = int.Parse(com.ExecuteScalar().ToString()) - 1;

                SqlCommand kom = new SqlCommand();
                kom.Connection = konekcija;

                kom.Parameters.Add(new SqlParameter("id", id));
                kom.Parameters.Add(new SqlParameter("br", br));

                kom.CommandText = "select avg(Kalorije) from DnevniUnos where DnevniUnosID > @id-(@id%7)-@br" +
                                        " and DnevniUnosID <= @id+7-(@id%7)-@br";
                tbKalorije.Text = Double.Parse(kom.ExecuteScalar().ToString()).ToString("n2");

                kom.CommandText = "select avg(UgljeniHidrati) from DnevniUnos where DnevniUnosID > @id-(@id%7)-@br" +
                                        " and DnevniUnosID <= @id+7-(@id%7)-@br";
                tbHidrati.Text = Double.Parse(kom.ExecuteScalar().ToString()).ToString("n2");

                kom.CommandText = "select avg(Proteini) from DnevniUnos where DnevniUnosID > @id-(@id%7)-@br" +
                                        " and DnevniUnosID <= @id+7-(@id%7)-@br";
                tbProteini.Text = Double.Parse(kom.ExecuteScalar().ToString()).ToString("n2");

                kom.CommandText = "select avg(Masti) from DnevniUnos where DnevniUnosID > @id-(@id%7)-@br" +
                                        " and DnevniUnosID <= @id+7-(@id%7)-@br";
                tbMasti.Text = Double.Parse(kom.ExecuteScalar().ToString()).ToString("n2");

                kom.CommandText = "select avg(Kolicina) from DnevniUnos where DnevniUnosID > @id-(@id%7)-@br" +
                                        " and DnevniUnosID <= @id+7-(@id%7)-@br";
                tbKolicina.Text = Double.Parse(kom.ExecuteScalar().ToString()).ToString("n2");

                kom.CommandText = "select avg(Cena) from DnevniUnos where DnevniUnosID > @id-(@id%7)-@br" +
                                        " and DnevniUnosID <= @id+7-(@id%7)-@br";
                tbCena.Text = Double.Parse(kom.ExecuteScalar().ToString()).ToString("n2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void CmbIzbor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIzbor.SelectedIndex != -1)
            {
                switch (cmbIzbor.SelectedIndex)
                {
                    case 0:
                        IspisiDnevnuStatistiku();
                        break;
                    case 1:
                        IspisiStatistiku(0);
                        break;
                    case 2:
                        IspisiStatistiku(7);
                        break;
                    case 3:
                        IspisiStatistiku(14);
                        break;
                }
            }   
        }

        private void BtnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            if (tbIDObrisi.Text != "")
            {
                if (MessageBox.Show("Da li zelite da obrisete izabrani dan?", "Potvrda",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        konekcija.Open();
                        using (SqlCommand komanda = new SqlCommand("delete from DnevniUnos where DnevniUnosID=@id", konekcija))
                        {
                            komanda.Parameters.Add(new SqlParameter("id", int.Parse(tbIDObrisi.Text)));
                            komanda.ExecuteNonQuery();
                        }
                        dnevniUnosTableAdapter.Fill(ishranaDataSet.DnevniUnos);
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
                    tbIDObrisi.Clear();
                }
            }
            else
            {
                MessageBox.Show("Morate uneti ID obroka");
            }
        }
    }
}
