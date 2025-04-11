using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BenzinUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-UHPV4QF\SQLEXPRESS01;Initial Catalog=DbBenzin;Integrated Security=True");
        void Listele()
        {
            //Kurşunsuz95
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLBENZIN where PETROLTUR='Kurşunsuz95'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                lblKursunsuz95.Text = dr[3].ToString();
                progressBar1.Value = int.Parse(dr[4].ToString());
                lblKursunsun95L.Text = dr[4].ToString();
            }
            baglanti.Close();

            //Kurşunsuz97
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from TBLBENZIN where PETROLTUR='Kurşunsuz97'", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            if (dr2.Read())
            {
                lblKursunsuz97.Text = dr2[3].ToString();
                progressBar2.Value = int.Parse(dr2[4].ToString());
                lblKursunsuz97L.Text = dr2[4].ToString();
            }
            baglanti.Close();

            //EuroDisel10
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from TBLBENZIN where PETROLTUR='EuroDisel10'", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            if (dr3.Read())
            {
                lblEuroDisel.Text = dr3[3].ToString();
                progressBar3.Value = int.Parse(dr3[4].ToString());
                lblEuroDiselL.Text = dr3[4].ToString();
            }
            baglanti.Close();

            //YeniProDisel
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from TBLBENZIN where PETROLTUR='YeniProDisel'", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            if (dr4.Read())
            {
                lblYeniProDisel.Text = dr4[3].ToString();
                progressBar4.Value = int.Parse(dr4[4].ToString());
                lblYeniProDiselL.Text = dr4[4].ToString();
            }
            baglanti.Close();

            //Gas
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from TBLBENZIN where PETROLTUR='Gas'", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            if (dr5.Read())
            {
                lblGas.Text = dr5[3].ToString();
                progressBar5.Value = int.Parse(dr5[4].ToString());
                lblGasL.Text = dr5[4].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select * from TBLKASA", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            if (dr6.Read())
            {
                lblKasa.Text = (dr6[0].ToString());
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, litre, tutar;
            kursunsuz95 = Convert.ToDouble(lblKursunsuz95.Text);
            litre = Convert.ToDouble(numericUpDown1.Value);
            tutar = litre * kursunsuz95;
            txtKursunsuz95Fiyat.Text = tutar.ToString();
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz97, litre, tutar;
            kursunsuz97 = Convert.ToDouble(lblKursunsuz97.Text);
            litre = Convert.ToDouble(numericUpDown2.Value);
            tutar = litre * kursunsuz97;
            txtKursunsuz97Fiyat.Text = tutar.ToString();
        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double eurodisel, litre, tutar;
            eurodisel = Convert.ToDouble(lblEuroDisel.Text);
            litre = Convert.ToDouble(numericUpDown3.Value);
            tutar = eurodisel * litre;
            txtEuroDiselFiyat.Text = tutar.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double yeniprodisel, litre, tutar;
            yeniprodisel = Convert.ToDouble(lblYeniProDisel.Text);
            litre = Convert.ToDouble(numericUpDown4.Value);
            tutar = yeniprodisel * litre;
            txtYeniProDiselFiyat.Text = tutar.ToString();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            double gas, litre, tutar;
            gas = Convert.ToDouble(lblGas.Text);
            litre = Convert.ToDouble(numericUpDown5.Value);
            tutar = gas * litre;
            txtGazFiyat.Text = tutar.ToString();
        }

        private void btnDepoDoldur_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "Kurşunsuz95");
                komut.Parameters.AddWithValue("@p3", numericUpDown1.Value);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtKursunsuz95Fiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtKursunsuz95Fiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update TBLBENZIN set STOK=STOK-@p1 where PETROLTUR='Kurşunsuz95'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numericUpDown1.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış Yapıldı");
                Listele();
                numericUpDown1.Value = 0;
            }
            if (numericUpDown2.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "Kurşunsuz97");
                komut.Parameters.AddWithValue("@p3", numericUpDown2.Value);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtKursunsuz97Fiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtKursunsuz97Fiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update TBLBENZIN set STOK=STOK-@p1 where PETROLTUR='Kurşunsuz97'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numericUpDown2.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış Yapıldı");
                Listele();
                numericUpDown2.Value = 0;
            }
            if (numericUpDown3.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "EuroDisel10");
                komut.Parameters.AddWithValue("@p3", numericUpDown3.Value);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtEuroDiselFiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtEuroDiselFiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update TBLBENZIN set STOK=STOK-@p1 where PETROLTUR='EuroDisel10'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numericUpDown3.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış Yapıldı");
                Listele();
                numericUpDown3.Value = 0;
            }
            if (numericUpDown4.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "YeniProDisel");
                komut.Parameters.AddWithValue("@p3", numericUpDown4.Value);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtYeniProDiselFiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtYeniProDiselFiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update TBLBENZIN set STOK=STOK-@p1 where PETROLTUR='YeniProDisel'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numericUpDown4.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış Yapıldı");
                Listele();
                numericUpDown4.Value = 0;
            }
            if (numericUpDown5.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "Gas");
                komut.Parameters.AddWithValue("@p3", numericUpDown5.Value);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtGazFiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtGazFiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update TBLBENZIN set STOK=STOK-@p1 where PETROLTUR='Gas'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numericUpDown5.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış Yapıldı");
                Listele();
                numericUpDown5.Value = 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kontrol = new SqlCommand("Select * from tblkasa", baglanti);
            decimal kasaBakiye = (decimal)kontrol.ExecuteScalar();  // MIKTAR kolonunu al
            baglanti.Close();
            if (kasaBakiye <= 0)
            {
                MessageBox.Show("Yeterli paranız yok. Ekleme işlemi yapılamaz.");
            }
            else
            {
                if (!string.IsNullOrEmpty(txt95ekle.Text))
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Update TBLBENZIN set STOK=STOK+@p1 where PETROLTUR=@p2", baglanti);
                    komut.Parameters.AddWithValue("@p1", txt95ekle.Text);
                    komut.Parameters.AddWithValue("@p2", "Kurşunsuz95");
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR-@p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", decimal.Parse(txt95EklenenFiyat.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Benzin Stoğa Eklendi");

                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("insert into TBLHAREKET2 (BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3)", baglanti);
                    komut3.Parameters.AddWithValue("@p1", "Kurşunsuz95");
                    komut3.Parameters.AddWithValue("@p2",txt95ekle.Text);
                    komut3.Parameters.AddWithValue("@p3", decimal.Parse(txt95EklenenFiyat.Text));
                    komut3.ExecuteNonQuery();
                    baglanti.Close();
                    Listele();
                    txt95ekle.Clear();
                }

                if (!string.IsNullOrEmpty(txt97ekle.Text))
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Update TBLBENZIN set STOK=STOK+@p1 where PETROLTUR=@p2", baglanti);
                    komut.Parameters.AddWithValue("@p1", txt97ekle.Text);
                    komut.Parameters.AddWithValue("@p2", "Kurşunsuz97");
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR-@p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", decimal.Parse(txt97EklenenFiyat.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("insert into TBLHAREKET2 (BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3)", baglanti);
                    komut3.Parameters.AddWithValue("@p1", "Kurşunsuz97");
                    komut3.Parameters.AddWithValue("@p2", txt97ekle.Text);
                    komut3.Parameters.AddWithValue("@p3", decimal.Parse(txt97EklenenFiyat.Text));
                    komut3.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Benzin Stoğa Eklendi");
                    Listele();
                    txt97ekle.Clear();
                }

                if (!string.IsNullOrEmpty(txtEuroDiselekle.Text))
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Update TBLBENZIN set STOK=STOK+@p1 where PETROLTUR=@p2", baglanti);
                    komut.Parameters.AddWithValue("@p1", txtEuroDiselekle.Text);
                    komut.Parameters.AddWithValue("@p2", "EuroDisel10");
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR-@p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtEuroDiselEklenenFiyat.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("insert into TBLHAREKET2 (BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3)", baglanti);
                    komut3.Parameters.AddWithValue("@p1", "EuroDisel10");
                    komut3.Parameters.AddWithValue("@p2", txtEuroDiselekle.Text);
                    komut3.Parameters.AddWithValue("@p3", decimal.Parse(txtEuroDiselEklenenFiyat.Text));
                    komut3.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Benzin Stoğa Eklendi");
                    Listele();
                    txtEuroDiselekle.Clear();
                }

                if (!string.IsNullOrEmpty(txtYeniProekle.Text))
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Update TBLBENZIN set STOK=STOK+@p1 where PETROLTUR=@p2", baglanti);
                    komut.Parameters.AddWithValue("@p1", txtYeniProekle.Text);
                    komut.Parameters.AddWithValue("@p2", "YeniProDisel");
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR-@p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtYeniProEklenenFiyat.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Benzin Stoğa Eklendi");
                    Listele();
                    txtYeniProekle.Clear();
                }

                if (!string.IsNullOrEmpty(txtGasekle.Text))
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Update TBLBENZIN set STOK=STOK+@p1 where PETROLTUR=@p2", baglanti);
                    komut.Parameters.AddWithValue("@p1", txtGasekle.Text);
                    komut.Parameters.AddWithValue("@p2", "Gas");
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR-@p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtGasEklenenFiyat.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("insert into TBLHAREKET2 (BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3)", baglanti);
                    komut3.Parameters.AddWithValue("@p1", "Gas");
                    komut3.Parameters.AddWithValue("@p2", txtGasekle.Text);
                    komut3.Parameters.AddWithValue("@p3", decimal.Parse(txtGasEklenenFiyat.Text));
                    komut3.ExecuteNonQuery();
                    MessageBox.Show("Benzin Stoğa Eklendi");
                    Listele();
                    txtGasekle.Clear();
                }
            }
            baglanti.Close();
        }

        private void txt95ekle_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt95ekle.Text))
            {
                txt95EklenenFiyat.Text = (double.Parse(txt95ekle.Text) * 5.94).ToString();
            }
            else
            {
                txt95EklenenFiyat.Text = "0";
            }
        }

        private void txt97ekle_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt97ekle.Text))
            {
                txt97EklenenFiyat.Text = (double.Parse(txt97ekle.Text) * 5.98).ToString();
            }
            else
            {
                txt97EklenenFiyat.Text = "0";
            }
        }

        private void txtEuroDiselekle_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEuroDiselekle.Text))
            {
                txtEuroDiselEklenenFiyat.Text = (double.Parse(txtEuroDiselekle.Text) * 4.49).ToString();
            }
            else
            {
                txtEuroDiselEklenenFiyat.Text = "0";
            }
        }

        private void txtYeniProekle_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtYeniProekle.Text))
            {
                txtYeniProEklenenFiyat.Text = (double.Parse(txtYeniProekle.Text) * 5.51).ToString();
            }
            else
            {
                txtYeniProEklenenFiyat.Text = "0";
            }
        }

        private void txtGasekle_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGasekle.Text))
            {
                txtGasEklenenFiyat.Text = (double.Parse(txtGasekle.Text) * 3.28).ToString();
            }
            else
            {
                txtGasEklenenFiyat.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kontrol fr=new Kontrol();
            fr.Show();
        }
    }
}
