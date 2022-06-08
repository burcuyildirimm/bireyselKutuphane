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
    public partial class grafik : Form
    {
        public grafik()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server = 172.21.54.3; uid = BurcuNYP; pwd =Burcu12345.; database = BurcuNYP");
        private void button1_Click(object sender, EventArgs e)
        {
            kullaniciEkran kullaniciEkran = new kullaniciEkran();
            kullaniciEkran.Show();
            this.Hide();
        }

        private void grafik_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                baglanti.Open();
                MySqlCommand sqlCommand = new MySqlCommand("select ogretmen_ad,okunan_kitap from ogretmen", baglanti);
                MySqlDataReader mySqlDataReader = sqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    chart1.Series["Okunan Kitap Sayısı"].Points.AddXY(mySqlDataReader["ogretmen_ad"].ToString(), mySqlDataReader["okunan_kitap"]);
                }
                baglanti.Close();
            }
            else if (radioButton6.Checked)
            {
                baglanti.Open();
                MySqlCommand sqlCommand = new MySqlCommand("select ogrenci_ad,okunan_kitap from ogrenci", baglanti);
                MySqlDataReader mySqlDataReader = sqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    chart1.Series["Okunan Kitap Sayısı"].Points.AddXY(mySqlDataReader["ogrenci_ad"].ToString(), mySqlDataReader["okunan_kitap"]);
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı tipini seçiniz");
            }
        }
    }
}
