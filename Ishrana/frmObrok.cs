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
    public partial class frmObrok : Form
    {
        SqlConnection konekcija = new SqlConnection(Konekcija.konString);

        public frmObrok()
        {
            InitializeComponent();
        }

        private void FrmObrok_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ishranaDataSet.Obrok' table. You can move, or remove it, as needed.
            this.obrokTableAdapter.Fill(this.ishranaDataSet.Obrok);
            PuniCheckBox();
            Reset();
        }

        private void Reset()
        {
            try
            {
                konekcija.Open();

                SqlCommand kom = new SqlCommand();
                kom.Connection = konekcija;
                kom.CommandText = "select top 1 ObrokID from Obrok order by ObrokID desc";
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

            tbKalorije.Text = 0.ToString();
            tbHidrati.Text = 0.ToString();
            tbProteini.Text = 0.ToString();
            tbMasti.Text = 0.ToString();
            tbKolicina.Text = 0.ToString();
            tbCena.Text = 0.ToString();
            tbNaziv.Clear();
            rtbOpis.Clear();

            foreach (CheckBox cb in panel1.Controls)
            {
                cb.Checked = false;
            }
        }

        private void PuniCheckBox()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hrana", konekcija);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataView dv = dt.DefaultView;
                dv.Sort = "Naziv asc";
                DataTable sortedDT = dv.ToTable();

                CheckBox[] cb = new CheckBox[100];
                int i = 0;
                int height = 1;
                int padding = 10;
                foreach (DataRow row in sortedDT.Rows)
                {
                    cb[i] = new CheckBox();
                    cb[i].Name = i.ToString();
                    cb[i].Text = row[1].ToString();
                    cb[i].TabIndex = i;
                    cb[i].CheckedChanged += CheckBox_CheckedChanged;
                    cb[i].AutoCheck = true;
                    cb[i].Bounds = new Rectangle(10, 20 + padding + height, 150, 22);
                    panel1.Controls.Add(cb[i]);
                    height += 22;
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
        }

        private bool CekiranCheckBox()
        {
            bool pom = false;
            foreach(CheckBox cb in panel1.Controls)
            {
                if (cb.Checked)
                {
                    pom = true;
                    break;
                }
            }
            return pom;
        }

        private float Racunaj(List<float> elementi)
        {
            float sum = 0;
            foreach(float f in elementi)
            {
                sum += f;
            }
            return sum;
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                frmKolicina kolicina = new frmKolicina();
                if (kolicina.ShowDialog() == DialogResult.Yes && kolicina.kolicina.Kol>0)
                {
                    try
                    {
                        konekcija.Open();

                        SqlCommand kom = new SqlCommand("select * from Hrana where Naziv=@naziv", konekcija);
                        kom.Parameters.Add(new SqlParameter("naziv", cb.Text));

                        SqlDataReader reader = kom.ExecuteReader();
                        while (reader.Read())
                        {
                            tbKalorije.Text = (float.Parse(tbKalorije.Text) + (float.Parse(reader[2].ToString()) * kolicina.kolicina.Kol)).ToString();
                            tbHidrati.Text = (float.Parse(tbHidrati.Text) + (float.Parse(reader[3].ToString()) * kolicina.kolicina.Kol)).ToString();
                            tbProteini.Text = (float.Parse(tbProteini.Text) + (float.Parse(reader[4].ToString()) * kolicina.kolicina.Kol)).ToString();
                            tbMasti.Text = (float.Parse(tbMasti.Text) + (float.Parse(reader[5].ToString()) * kolicina.kolicina.Kol)).ToString();
                            tbKolicina.Text = (float.Parse(tbKolicina.Text) + (float.Parse(reader[6].ToString()) * kolicina.kolicina.Kol)).ToString();
                            tbCena.Text = (float.Parse(tbCena.Text) + (float.Parse(reader[7].ToString()) * kolicina.kolicina.Kol)).ToString();
                        }
                        reader.Close();
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
                else
                {
                    cb.Checked = false;
                }
            }
        }

        private void BtnResetuj_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNapravi_Click(object sender, EventArgs e)
        {
            if(tbNaziv.Text == "" || !CekiranCheckBox())
            {
                MessageBox.Show("Unesi naziv obroka");
            }
            else
            {
                try
                {
                    obrokTableAdapter.Insert(int.Parse(tbID.Text),
                                            tbNaziv.Text,
                                            float.Parse(tbKalorije.Text),
                                            float.Parse(tbHidrati.Text),
                                            float.Parse(tbProteini.Text),
                                            float.Parse(tbMasti.Text),
                                            int.Parse(tbKolicina.Text),
                                            int.Parse(tbCena.Text),
                                            rtbOpis.Text);

                    MessageBox.Show("Uspesno napravljen obrok");
                    obrokTableAdapter.Fill(ishranaDataSet.Obrok);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska: " + ex.Message);
                }
                Reset();
            }
        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            if (tbIDObrisi.Text != "")
            {
                if (MessageBox.Show("Da li zelite da obrisete izabrani obrok?", "Potvrda",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        konekcija.Open();
                        using (SqlCommand komanda = new SqlCommand("delete from Obrok where ObrokID=@id", konekcija))
                        {
                            komanda.Parameters.Add(new SqlParameter("id", int.Parse(tbIDObrisi.Text)));
                            komanda.ExecuteNonQuery();
                        }
                        obrokTableAdapter.Fill(ishranaDataSet.Obrok);
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
                MessageBox.Show("Morate uneti ID obroka");
            }
        }
    }
}
