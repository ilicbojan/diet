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
    public partial class frmPocetna : Form
    {
        SqlConnection konekcija = new SqlConnection(Konekcija.konString);

        public frmPocetna()
        {
            InitializeComponent();
        }

        private void FrmPocetna_Load(object sender, EventArgs e)
        {
            PuniCheckBox();
            Reset();
        }

        private void PuniCheckBox()
        {
            try
            {
                if(panel1.Controls.Count > 0)
                {
                    panel1.Controls.Clear();
                }

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Obrok", konekcija);
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

        private void Reset()
        {
            try
            {
                konekcija.Open();

                SqlCommand kom = new SqlCommand();
                kom.Connection = konekcija;
                kom.CommandText = "select top 1 Datum from DnevniUnos order by Datum desc";
                tbDatum.Text = ((Convert.ToDateTime(kom.ExecuteScalar().ToString())).AddDays(1)).ToString("dd/MM/yyyy");

                kom.CommandText = "select top 1 DnevniUnosID from DnevniUnos order by DnevniUnosID desc";
                tbID.Text = (int.Parse(kom.ExecuteScalar().ToString()) + 1).ToString();
            }
            catch (Exception)
            {
                tbDatum.Text = DateTime.Now.ToString("dd/MM/yyyy");
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
            tbTezina.Clear();
            rtbOpis.Clear();

            foreach (CheckBox cb in panel1.Controls)
            {
                cb.Checked = false;
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                try
                {
                    konekcija.Open();

                    SqlCommand kom = new SqlCommand("select * from Obrok where Naziv=@naziv", konekcija);
                    kom.Parameters.Add(new SqlParameter("naziv", cb.Text));

                    SqlDataReader reader = kom.ExecuteReader();
                    while (reader.Read())
                    {
                        tbKalorije.Text = (float.Parse(tbKalorije.Text) + float.Parse(reader[2].ToString())).ToString();
                        tbHidrati.Text = (float.Parse(tbHidrati.Text) + float.Parse(reader[3].ToString())).ToString();
                        tbProteini.Text = (float.Parse(tbProteini.Text) + float.Parse(reader[4].ToString())).ToString();
                        tbMasti.Text = (float.Parse(tbMasti.Text) + float.Parse(reader[5].ToString())).ToString();
                        tbKolicina.Text = (int.Parse(tbKolicina.Text) + int.Parse(reader[6].ToString())).ToString();
                        tbCena.Text = (int.Parse(tbCena.Text) + int.Parse(reader[7].ToString())).ToString();
                        rtbOpis.AppendText(reader[1].ToString() +" || ");
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
        }

        private void BtnObrok_Click(object sender, EventArgs e)
        {
            frmObrok obrok = new frmObrok();
            if (obrok.ShowDialog() == DialogResult.Yes)
            {
                Reset();
                PuniCheckBox();
            }
        }

        private void BtnHrana_Click(object sender, EventArgs e)
        {
            frmHrana hrana = new frmHrana();
            if (hrana.ShowDialog() == DialogResult.Yes)
            {
                Reset();
                PuniCheckBox();
            }
        }

        private void BtnResetuj_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BtnUnesi_Click(object sender, EventArgs e)
        {
            if (tbTezina.Text == "")
            {
                MessageBox.Show("Popuni sve podatke");
            }
            else
            {
                try
                {
                    dnevniUnosTableAdapter1.Insert(int.Parse(tbID.Text),
                                            DateTime.Parse(tbDatum.Text),
                                            float.Parse(tbKalorije.Text),
                                            float.Parse(tbHidrati.Text),
                                            float.Parse(tbProteini.Text),
                                            float.Parse(tbMasti.Text),
                                            int.Parse(tbKolicina.Text),
                                            int.Parse(tbCena.Text),
                                            float.Parse(tbTezina.Text),
                                            rtbOpis.Text);
                    MessageBox.Show("Uspesno uneta dnevna ishrana");
                    dnevniUnosTableAdapter1.Fill(ishranaDataSet1.DnevniUnos);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska: " + ex.Message);
                }
            }
            Reset();
        }

        private void BtnKalkulator_Click(object sender, EventArgs e)
        {
            frmKalkulator kalkulator = new frmKalkulator();
            kalkulator.ShowDialog();
        }

        private void TbTezina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void BtnZatvori_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPocetna_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Da li zelite da zatvorite aplikaciju?", "Potvrda", 
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void BtnPregled_Click(object sender, EventArgs e)
        {
            frmPregled pregled = new frmPregled();
            pregled.ShowDialog();
        }
    }
}