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
    public partial class emanetKitapListele : Form
    {
        public emanetKitapListele()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server = 172.21.54.3; uid = BurcuNYP; pwd =Burcu12345.; database = BurcuNYP");
        DataSet dataSet = new DataSet();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            personelEkran personelEkran = new personelEkran();
            personelEkran.Show();
        }

        private void emanetKitapListele_Load(object sender, EventArgs e)
        {
            EmanetListele();
            filtreleCmb.SelectedIndex = 0;
        }

        private void EmanetListele()
        {
            baglanti.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select*from emanet", baglanti);
            adapter.Fill(dataSet, "emanet");
            dataGridView1.DataSource = dataSet.Tables["emanet"];
            baglanti.Close();
        }

        private void filtreleCmb_SelectedIndexChanged(object sender, EventArgs e)
        {  dataSet.Tables["emanet"].Clear();
            if (filtreleCmb.SelectedIndex==0)
            {
                EmanetListele();
            }
            else if (filtreleCmb.Text==("Geciken Kitaplar"))
            {
                baglanti.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("select*from emanet where'"+DateTime.Now.ToShortDateString()+"'>veris_tarihi", baglanti);
                adapter.Fill(dataSet, "emanet");
                dataGridView1.DataSource = dataSet.Tables["emanet"];
                baglanti.Close();

            }
            else if (filtreleCmb.Text==("Gecikmeyen Kitaplar"))
            {
                baglanti.Open();
               
                MySqlDataAdapter adapter = new MySqlDataAdapter("select*from emanet where'"+DateTime.Now.ToShortDateString()+"'<=veris_tarihi", baglanti);
                adapter.Fill(dataSet,"emanet");
                dataGridView1.DataSource = dataSet.Tables["emanet"];
                baglanti.Close();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
