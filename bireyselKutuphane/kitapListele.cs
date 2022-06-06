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
    public partial class kitapListele : Form
    {
        public kitapListele()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server = 172.21.54.3; uid = BurcuNYP; pwd =Burcu12345.; database = BurcuNYP");
        public void verileriGoster(string veriler)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void cevirmeYiliTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand mySqlCommand = new MySqlCommand($"insert into kitap(kitap_id,kitap_adi,baski,cilt,isbn,kitap_dili,kategori_ad,yayinevi_id,cevirme_yili,sayfa_sayisi,raf_konumu,adet,yayin_yili,yazar_id,cevirmen_id) values ('{kitapIdTxt.Text}','{kitapAdTxt.Text}','{baskıTxt.Text}','{ciltTxt.Text}','{isbnTxt.Text}','{kitapDiliTxt.Text}','{kategoriCmb.Text}','{yayıneviIdTxt.Text}','{cevirmeYiliTxt.Text}','{sayfaSayTxt.Text}','{rafKonumTxt.Text}','{adetTxt.Text}','{yayınYiliTxt.Text}','{yazarIdTxt.Text}','{cevirmenIdTxt.Text}')",baglanti);
            mySqlCommand.ExecuteNonQuery();
            verileriGoster("select*from kitap");
            baglanti.Close();
            
            
        }

        private void listeleBtn_Click(object sender, EventArgs e)
        {
            verileriGoster("select* from kitap join yazar on kitap.yazar_id=yazar.yazar_id");

        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("delete from kitap where kitap_id=@kitap_id", baglanti);
            komut.Parameters.AddWithValue("@kitap_id", kitapIdTxt.Text);
            komut.ExecuteNonQuery();
            verileriGoster("select*from kitap");
            baglanti.Close();
            kitapIdTxt.Clear();
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("select*from kitap where kitap_id like '%" + idAraTxt.Text + "%'", baglanti);
            MySqlDataAdapter da = new MySqlDataAdapter(mySqlCommand);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("update kitap set kitap_adi='" + kitapAdTxt.Text + "',baski='" +baskıTxt.Text + "',cilt='" + ciltTxt.Text + "',isbn='" + isbnTxt.Text + "',kitap_dili='" + kitapDiliTxt.Text + "',kategori_ad='" + kategoriCmb.Text + "',yayinevi_id='" +yayıneviIdTxt.Text +"',cevirme_yili='"+cevirmeYiliTxt.Text+"',sayfa_sayisi='"+sayfaSayTxt.Text+"',raf_konumu='"+rafKonumTxt.Text+"',adet='"+adetTxt.Text+"',yayin_yili='"+yayınYiliTxt.Text+"',yazar_id='"+yazarIdTxt.Text+"',cevirmen_id='"+cevirmenIdTxt.Text+ "'where kitap_id='" + kitapIdTxt.Text + "'", baglanti);

            mySqlCommand.ExecuteNonQuery();
            verileriGoster("select*from kitap join yazar on kitap.yazar_id=yazar.yazar_id");
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliAlan = dataGridView1.SelectedCells[0].RowIndex;
            string kitapid = dataGridView1.Rows[seciliAlan].Cells[0].Value.ToString();
            string kitapad = dataGridView1.Rows[seciliAlan].Cells[1].Value.ToString();
            string baski = dataGridView1.Rows[seciliAlan].Cells[2].Value.ToString();
            string cilt = dataGridView1.Rows[seciliAlan].Cells[3].Value.ToString();
            string isbn = dataGridView1.Rows[seciliAlan].Cells[4].Value.ToString();
            string kitapdili = dataGridView1.Rows[seciliAlan].Cells[5].Value.ToString();
            string kategoriad = dataGridView1.Rows[seciliAlan].Cells[6].Value.ToString();
            string yayineviid = dataGridView1.Rows[seciliAlan].Cells[7].Value.ToString();
            string cevirmeyili = dataGridView1.Rows[seciliAlan].Cells[8].Value.ToString();
            string sayfasayisi = dataGridView1.Rows[seciliAlan].Cells[9].Value.ToString();
            string rafkonumu = dataGridView1.Rows[seciliAlan].Cells[10].Value.ToString();
            string adet = dataGridView1.Rows[seciliAlan].Cells[11].Value.ToString();
            string yayinyili = dataGridView1.Rows[seciliAlan].Cells[12].Value.ToString();
            string yazarid = dataGridView1.Rows[seciliAlan].Cells[13].Value.ToString();
            string cevirmenid = dataGridView1.Rows[seciliAlan].Cells[14].Value.ToString();

            kitapIdTxt.Text = kitapid;
            kitapAdTxt.Text = kitapad;
            baskıTxt.Text = baski;
            ciltTxt.Text = cilt;
            isbnTxt.Text = isbn;
            kitapDiliTxt.Text = kitapdili;
            kategoriCmb.Text = kategoriad;
            yayıneviIdTxt.Text = yayineviid;
            cevirmeYiliTxt.Text = cevirmeyili;
            sayfaSayTxt.Text = sayfasayisi;
            rafKonumTxt.Text = rafkonumu;
            adetTxt.Text = adet;
            yayınYiliTxt.Text = yayinyili;
            yazarIdTxt.Text = yazarid;
            cevirmenIdTxt.Text = cevirmenid;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            personelEkran personel = new personelEkran();
            personel.Show();
        }

        private void kitapIdTxt_TextChanged(object sender, EventArgs e)
        {
            if (kitapIdTxt.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";

                    }
                }
            }
        }
    }
}
