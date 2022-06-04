﻿using System;
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
    public partial class kullaniciListele : Form
    {
        public kullaniciListele()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti =new MySqlConnection( "Server = 172.21.54.3; uid = BurcuNYP; pwd =Burcu12345.; database = BurcuNYP");
        public void verileriGoster(string veriler)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void uyeOlBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("update ogrenci set ogrenci_id='" + idTxt.Text + "',ogrenci_ad='" + adTxt.Text + "',mail='" + mailTxt.Text + "',ogrenci_soyad='" + soyadTxt.Text + "',adres='" + adresTxt.Text + "',parola='" + parola2Txt.Text + "',kart_id='" + kartIdTxt.Text + "',tel_no='" + telTxt.Text + "',bolum_id='" + bolumIdTxt.Text + "'where ogrenci_id='" + gnclleIdTxt.Text + "'", baglanti);
            mySqlCommand.ExecuteNonQuery();
            verileriGoster("select*from ogrenci");
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void idAraTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//search
        {
            if (radioButton3.Checked)
            {
                baglanti.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("select*from ogrenci where ogrenci_id like '%" + idAraTxt.Text + "%'", baglanti);
                MySqlDataAdapter da = new MySqlDataAdapter(mySqlCommand);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
            }
            else if (radioButton2.Checked)
            {
                baglanti.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("select*from ogretmen where ogretmen_id like '%" + idAraTxt.Text + "%'", baglanti);
                MySqlDataAdapter da = new MySqlDataAdapter(mySqlCommand);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();

            }
            else if (radioButton1.Checked)
            {
                baglanti.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("select*from personel where personel_id like '%" + idAraTxt.Text + "%'", baglanti);
                MySqlDataAdapter da = new MySqlDataAdapter(mySqlCommand);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Lütfen aramak istediğiniz kullanıcının tipini yukarıdaki bölümden seçiniz");
            }
        }

        private void listeleBtn_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                verileriGoster("select*from ogrenci");
            }
            else if (radioButton2.Checked)
            {
                verileriGoster("select*from ogretmen");
            }
            else if (radioButton1.Checked)
            {
                verileriGoster("select*from personel");
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı tipini seçiniz");
            }
        }

        private void silBtn_Click(object sender, EventArgs e)
        {if (radioButton6.Checked)
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("delete from ogrenci where ogrenci_id=@ogrenci_id", baglanti);
                komut.Parameters.AddWithValue("@ogrenci_id", gnclleIdTxt.Text);
                komut.ExecuteNonQuery();
                verileriGoster("select*from ogrenci");
                baglanti.Close();
            }
        else if (radioButton5.Checked)
            {
                DialogResult dialog;
                dialog = MessageBox.Show("Bu kaydı silmek istediğinizden emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    baglanti.Open();
                    MySqlCommand komut = new MySqlCommand("delete from ogretmen where ogretmen_id=@ogretmen_id", baglanti);
                    komut.Parameters.AddWithValue("@ogretmen_id", gnclleIdTxt.Text);
                    komut.ExecuteNonQuery();
                    verileriGoster("select*from ogretmen");
                    baglanti.Close();
                }

            }
        else if (radioButton4.Checked)
            {
                DialogResult dialog;
                dialog = MessageBox.Show("Bu kaydı silmek istediğinizden emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    baglanti.Open();
                    MySqlCommand komut = new MySqlCommand("delete from personel where personel_id=@personel_id", baglanti);
                    komut.Parameters.AddWithValue("@personel_id", gnclleIdTxt.Text);
                    komut.ExecuteNonQuery();
                    verileriGoster("select*from personel");
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz kullanıcı tipini seçiniz");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (radioButton6.Checked)
            {
                int seciliAlan = dataGridView1.SelectedCells[0].RowIndex;
                string id = dataGridView1.Rows[seciliAlan].Cells[0].Value.ToString();
                string ad = dataGridView1.Rows[seciliAlan].Cells[2].Value.ToString();
                string mail = dataGridView1.Rows[seciliAlan].Cells[5].Value.ToString();
                string soyad = dataGridView1.Rows[seciliAlan].Cells[3].Value.ToString();
                string adres = dataGridView1.Rows[seciliAlan].Cells[6].Value.ToString();
                string parola = dataGridView1.Rows[seciliAlan].Cells[8].Value.ToString();
                string kartId = dataGridView1.Rows[seciliAlan].Cells[4].Value.ToString();
                string telefon = dataGridView1.Rows[seciliAlan].Cells[7].Value.ToString();
                string bolumId = dataGridView1.Rows[seciliAlan].Cells[1].Value.ToString();

                idTxt.Text = id;
                adTxt.Text = ad;
                mailTxt.Text = mail;
                soyadTxt.Text = soyad;
                adresTxt.Text = adres;
                parola2Txt.Text = parola;
                kartIdTxt.Text = kartId;
                telTxt.Text = telefon;
                bolumIdTxt.Text = bolumId;
            }
            else if (radioButton5.Checked)
            {
                int seciliAlan = dataGridView1.SelectedCells[0].RowIndex;
                string id = dataGridView1.Rows[seciliAlan].Cells[0].Value.ToString();
                string ad = dataGridView1.Rows[seciliAlan].Cells[2].Value.ToString();
                string mail = dataGridView1.Rows[seciliAlan].Cells[6].Value.ToString();
                string soyad = dataGridView1.Rows[seciliAlan].Cells[3].Value.ToString();
                string adres = dataGridView1.Rows[seciliAlan].Cells[5].Value.ToString();
                string parola = dataGridView1.Rows[seciliAlan].Cells[7].Value.ToString();
                string kartId = dataGridView1.Rows[seciliAlan].Cells[1].Value.ToString();
                string telefon = dataGridView1.Rows[seciliAlan].Cells[4].Value.ToString();

                idTxt.Text = id;
                adTxt.Text = ad;
                mailTxt.Text = mail;
                soyadTxt.Text = soyad;
                adresTxt.Text = adres;
                parola2Txt.Text = parola;
                kartIdTxt.Text = kartId;
                telTxt.Text = telefon;    
            }
            else if (radioButton4.Checked)
            {
                int seciliAlan = dataGridView1.SelectedCells[0].RowIndex;
                string id = dataGridView1.Rows[seciliAlan].Cells[0].Value.ToString();
                string ad = dataGridView1.Rows[seciliAlan].Cells[4].Value.ToString();
                string mail = dataGridView1.Rows[seciliAlan].Cells[2].Value.ToString();
                string soyad = dataGridView1.Rows[seciliAlan].Cells[5].Value.ToString();
                string adres = dataGridView1.Rows[seciliAlan].Cells[6].Value.ToString();
                string parola = dataGridView1.Rows[seciliAlan].Cells[7].Value.ToString();
                string kartId = dataGridView1.Rows[seciliAlan].Cells[1].Value.ToString();
                string telefon = dataGridView1.Rows[seciliAlan].Cells[3].Value.ToString();
 
                idTxt.Text = id;
                adTxt.Text = ad;
                mailTxt.Text = mail;
                soyadTxt.Text = soyad;
                adresTxt.Text = adres;
                parola2Txt.Text = parola;
                kartIdTxt.Text = kartId;
                telTxt.Text = telefon;
            }
            else
            {
                MessageBox.Show("Seçtiğiniz kullanıcı tiplerinin eş değer olduğundan emin olun ");
            }
        }
    }
}
