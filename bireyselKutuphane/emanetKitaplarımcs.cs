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
    public partial class emanetKitaplarımcs : Form
    {
        public emanetKitaplarımcs()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server = 172.21.54.3; uid = BurcuNYP; pwd =Burcu12345.; database = BurcuNYP");
        DataSet dataSet = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            kullaniciEkran kullanici = new kullaniciEkran();

            kullanici.Show();
        }

        private void emanetKitaplarımcs_Load(object sender, EventArgs e)
        {
           
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
           
                baglanti.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("select*from emanet where id ='" + idAraTxt.Text + "'", baglanti);
                adapter.Fill(dataSet, "emanet");
                adLbl.Text = "";
                emanetLbl.Text = "";
                adLbl.Text = dataSet.Tables["emanet"].Rows[0]["ad"].ToString();
                emanetLbl.Text = dataSet.Tables["emanet"].Rows[0]["kitap_adi"].ToString();
                baglanti.Close();

        }

        private void emanetLbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adLbl_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void idAraTxt_TextChanged(object sender, EventArgs e)
        {
            if (idAraTxt.Text == "")
            {
                emanetLbl.Text = "";
                adLbl.Text = "";
            }

        }
    }
}
