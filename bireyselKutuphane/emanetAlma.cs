using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace bireyselKutuphane
{
    public partial class emanetAlma : Form
    {
        public emanetAlma()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server = 172.21.54.3; uid = BurcuNYP; pwd =Burcu12345.; database = BurcuNYP");
        DataSet dataSet = new DataSet();
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void telTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            
        }
        private void sepetListele()
        {
            baglanti.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select* from sepet",baglanti);
            adapter.Fill(dataSet,"sepet");
            
            dataGridView1.DataSource = dataSet.Tables["sepet"];
            baglanti.Close();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand($"insert into sepet (adet,isbn,baski,kitap_id,yazar_id,kitap_adi,yayin_yili,yayinevi_id,cevirmen_id,sayfa_sayisi,raf_konumu,cevirme_yili) values('{adetTxt.Text}','{isbnTxt.Text}','{baskıTxt.Text}','{kitapIdTxt.Text}','{yazarIdTxt.Text}','{kitapAdTxt.Text}','{yayınYiliTxt.Text}','{yayıneviIdTxt.Text}','{cevirmenIdTxt.Text}','{sayfaSayTxt.Text}','{rafKonumTxt.Text}','{cevirmeYiliTxt.Text}')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap(lar) sepete eklendi.");
            dataSet.Tables["sepet"].Clear();
            sepetListele();
            sayı2.Text = " ";
            kitapSayisi();
            foreach(Control item in groupBox2.Controls)
            {
                if(item is TextBox)
                {
                    if (item != adetTxt)
                    {
                        item.Text = " ";
                    }
                }
            }
        }
        private void kitapSayisi()
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select sum(adet) from sepet", baglanti);
            sayı1.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();

        }
        private void emanetAlma_Load(object sender, EventArgs e)
        {
            sepetListele();
            kitapSayisi();
        }

        private void idTxt_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select* from ogrenci where ogrenci_id like'"+idTxt.Text+"'",baglanti);
            MySqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                adTxt.Text = read["ogrenci_ad"].ToString();
                mailTxt.Text = read["mail"].ToString();
                soyadTxt.Text = read["ogrenci_soyad"].ToString();
                telTxt.Text = read["tel_no"].ToString();

            }
            baglanti.Close();
            baglanti.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("select sum(adet) from emanet",baglanti);
            sayı1.Text = mySqlCommand.ExecuteScalar().ToString();
            baglanti.Close();
            if (idTxt.Text == "")
            {
                foreach (Control item in groupBox1.Controls)
                {if (item is TextBox)
                    {
                        item.Text = " ";
                        kytlıktpsyLbl.Text = " ";
                    }
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void adetTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void kitapIdTxt_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select*from kitap where kitap_id like '"+kitapIdTxt.Text+"'", baglanti);
            MySqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                isbnTxt.Text = read["isbn"].ToString();
                baskıTxt.Text = read["baski"].ToString();
                adetTxt.Text = read["adet"].ToString();
                yazarIdTxt.Text = read["yazar_id"].ToString();
                kitapAdTxt.Text = read["kitap_adi"].ToString();
                yayınYiliTxt.Text = read["yayin_yili"].ToString();
                yayıneviIdTxt.Text = read["yayinevi_id"].ToString();
                cevirmenIdTxt.Text = read["cevirmen_id"].ToString();
                sayfaSayTxt.Text = read["sayfa_sayisi"].ToString();
                rafKonumTxt.Text = read["raf_konumu"].ToString();
                cevirmeYiliTxt.Text = read["cevirme_yili"].ToString();

            }
            baglanti.Close();
            if (kitapIdTxt.Text == "")
            {

                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {if (item != adetTxt)
                        { item.Text = ""; }
                    }
                }
            }
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("delete from sepet where kitap_id='"+dataGridView1.CurrentRow.Cells["kitap_id"].Value.ToString()+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi gerçekleşti");
            dataSet.Tables["sepet"].Clear();
            sepetListele();
            kitapSayisi();
        }

        private void teslimBtn_Click(object sender, EventArgs e)
        {
            if(sayı2.Text!="")
            {
                if (sayı1.Text==" "&&int.Parse(sayı2.Text)<=3||sayı2.Text!=""&&int.Parse(sayı1.Text)+int.Parse(sayı2.Text)<=3)
                {
                    if (idTxt.Text!=" "&&adTxt.Text!=" "&&mailTxt.Text!=" "&&soyadTxt.Text!=" "&&telTxt.Text!=" ")
                    {for(int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            baglanti.Open();
                            MySqlCommand komut = new MySqlCommand($"insert into emanet(alis_tarihi,veris_tarihi,id,ad,soyad,mail,telefon,adet,isbn,baski,kitap_id,yazar_id,kitap_adi,yayin_yili,yayinevi_id,cevirmen_id,sayfa_sayisi,raf_konumu,cevirme_yili)values('{dateTimePicker1.Value}','{dateTimePicker2.Value}','{idTxt.Text}','{adTxt.Text}','{soyadTxt.Text}','{mailTxt.Text}','{telTxt.Text}','{adetTxt.Text}','{isbnTxt.Text}','{baskıTxt.Text}','{kitapIdTxt.Text}','{yazarIdTxt.Text}','{kitapAdTxt.Text}','{yayınYiliTxt.Text}','{yayıneviIdTxt.Text}','{cevirmenIdTxt.Text}','{sayfaSayTxt.Text}','{rafKonumTxt.Text}','{cevirmeYiliTxt.Text}')",baglanti);

                            komut.ExecuteNonQuery();
                            MySqlCommand komut2 = new MySqlCommand("update kitap set adet=adet-'"+int.Parse(dataGridView1.Rows[i].Cells["adet"].Value.ToString())+"where kitap_id'"+dataGridView1.Rows[i].Cells["kitap_id"].Value.ToString()+"'", baglanti);
                            komut2.ExecuteNonQuery();
                            baglanti.Close();
                        }
                        baglanti.Open();
                        MySqlCommand mySqlCommand = new MySqlCommand("delete from sepet", baglanti);
                        mySqlCommand.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kitap(lar) emanet edildi");
                        dataSet.Tables["sepet"].Clear();
                        sepetListele();
                        idTxt.Text = "";
                        sayı2.Text = "";
                        sayı1.Text = " ";
                        kitapSayisi();
                    }
                    else
                    {
                        MessageBox.Show("Üye bilgilerini eksiksiz giriniz");
                    }
                }
                else
                {
                    MessageBox.Show("Emanet kitap sayısı 3'ten fazla olamaz.");
                }

            }
            else
            {
                MessageBox.Show("Önce sepete kitap eklenmelidir");
            }
            
        }
    }
}
