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
    public partial class Form1 : Form

    {
        
        girismetot girismetot = new girismetot();
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            label11.Visible = false;
            bolumIdTxt.Visible = false;
            MySqlConnection mySqlConnection = new MySqlConnection();
            MySqlConnection baglan = mySqlConnection;
            baglan.ConnectionString = "Server = 172.21.54.3; uid = BurcuNYP; pwd =Burcu12345.; database = BurcuNYP";

            baglan.Open();
            baglan.Close();
            
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection();
            MySqlConnection baglan = mySqlConnection;
            baglan.ConnectionString = "Server = 172.21.54.3; uid = BurcuNYP; pwd =Burcu12345.; database = BurcuNYP";
            baglan.Open();
            if (radioButton1.Checked)
            {  
                if (girismetot.kullaniciKontrolOgrenci(Convert.ToInt32(kullaniciKartIdTxt.Text),(parolaTxt.Text).ToString())==1)
                {   
                    kullaniciEkran kullaniciEkran = new kullaniciEkran();
                    kullaniciEkran.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı kart id veya parola");
                }
            }
            else if (radioButton2.Checked)
            {
                if (girismetot.kullaniciKontrolOgretmen(Convert.ToInt32(kullaniciKartIdTxt.Text), parolaTxt.Text) == 1)
                {
                    kullaniciEkran kullaniciEkran = new kullaniciEkran();
                    kullaniciEkran.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı kart id veya parola");
                }


            }
            else if (radioButton3.Checked)
            {
                if (girismetot.kullaniciKontrolPersonel(Convert.ToInt32(kullaniciKartIdTxt.Text), (parolaTxt.Text)) == 1)
                {
                    personelEkran personelEkran = new personelEkran();
                    personelEkran.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı kart id veya parola");
                }
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı tipini seçiniz.");
            }
            baglan.Close();

        }
        void Temizle()
        {
            foreach (Control item in Controls)
            {
                if(item is TextBox)
                {
                    item.Text = " ";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = "Server = 172.21.54.3; uid = BurcuNYP; pwd =Burcu12345.; database = BurcuNYP";
            if (radioButton6.Checked)
            {
                using (var baglan = new MySqlConnection(con))
                {
                    using (var komut = new MySqlCommand($"INSERT INTO ogrenci(ogrenci_id,bolum_id,ogrenci_ad,ogrenci_soyad,kart_id,mail,adres,tel_no,parola)VALUES('{idTxt.Text}','{bolumIdTxt.Text}','{adTxt.Text}','{soyadTxt.Text}','{kartIdTxt.Text}','{mailTxt.Text}','{adresTxt.Text}','{telTxt.Text}','{parola2Txt.Text}')", baglan))
                    {
                        try
                        {
                            komut.Connection.Open();
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Kayıt işlemi başarıyla gerçekleşti");
                        }
                        catch (Exception hata)
                        {
                            MessageBox.Show(hata.Message);
                        }
                    }
                }
            }
            else if (radioButton5.Checked)
            {
                using (var baglan = new MySqlConnection(con))
                {
                    using (var komut = new MySqlCommand($"INSERT INTO ogretmen(ogretmen_id,kart_id,ogretmen_ad,ogretmen_soyad,tel_no,adres,mail,parola)VALUES('{idTxt.Text}','{kartIdTxt.Text}','{adTxt.Text}','{soyadTxt.Text}','{telTxt.Text}','{adresTxt.Text}','{mailTxt.Text}','{parola2Txt.Text}')", baglan))
                    {
                        try
                        {
                            komut.Connection.Open();
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Kayıt işlemi başarıyla gerçekleşti");
                        }
                        catch (Exception hata)
                        {
                            MessageBox.Show(hata.Message);
                        }
                    }
                }

            }
            else if (radioButton4.Checked)
            {
                using (var baglan = new MySqlConnection(con))
                {
                    using (var komut = new MySqlCommand($"INSERT INTO personel(personel_id,kart_id,mail,tel_no,personel_ad,personel_soyad,adres,parola)VALUES('{idTxt.Text}','{kartIdTxt.Text}','{mailTxt.Text}','{telTxt.Text}','{adTxt.Text}','{soyadTxt.Text}','{adresTxt.Text}','{parola2Txt.Text}')", baglan))
                    {
                        try
                        {
                            komut.Connection.Open();
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Kayıt işlemi başarıyla gerçekleşti");
                        }
                        catch (Exception hata)
                        {
                            MessageBox.Show(hata.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı tipini seçiniz.");
            }
           

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label11.Visible = true;
            bolumIdTxt.Visible = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label11.Visible = false;
            bolumIdTxt.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label11.Visible = false;
            bolumIdTxt.Visible =false;
        }

        private void kullaniciKartIdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void kullaniciKartIdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void idTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void kartIdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
