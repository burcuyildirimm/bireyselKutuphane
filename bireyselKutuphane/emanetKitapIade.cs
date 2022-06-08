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
    public partial class emanetKitapIade : Form
    {
        public emanetKitapIade()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server = 172.21.54.3; uid = BurcuNYP; pwd =Burcu12345.; database = BurcuNYP");
        DataSet dataSet = new DataSet();
        private void button2_Click(object sender, EventArgs e)
        {
            personelEkran personelEkran = new personelEkran();
            personelEkran.Show();
            this.Hide();
        }
        private void EmanetListele()
        {
            baglanti.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select*from emanet", baglanti);
            adapter.Fill(dataSet, "emanet");
            dataGridView1.DataSource = dataSet.Tables["emanet"];
            baglanti.Close();
        }

        private void emanetKitapIade_Load(object sender, EventArgs e)
        {
            EmanetListele();
        }

        private void idTxt_TextChanged(object sender, EventArgs e)
        {
            dataSet.Tables["emanet"].Clear();
            baglanti.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select*from emanet where id like'%" + idTxt.Text+"%'",baglanti);
            adapter.Fill(dataSet, "emanet");
            baglanti.Close();
            if (idTxt.Text=="")
            {
                dataSet.Tables["emanet"].Clear();
                EmanetListele();
            }

        }

        private void kitapIdTxt_TextChanged(object sender, EventArgs e)
        {
            dataSet.Tables["emanet"].Clear();
            baglanti.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select*from emanet where kitap_id like'%" + kitapIdTxt.Text + "%'", baglanti);
            adapter.Fill(dataSet, "emanet");
            baglanti.Close();
            if (kitapIdTxt.Text == "")
            {
                dataSet.Tables["emanet"].Clear();
                EmanetListele();
            }
        }

        private void iadeBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand command = new MySqlCommand("delete from emanet where id=@id and kitap_id=@kitap_id", baglanti);
            command.Parameters.AddWithValue("@id",dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            command.Parameters.AddWithValue("@kitap_id", dataGridView1.CurrentRow.Cells["kitap_id"].Value.ToString());
            command.ExecuteNonQuery();
            MySqlCommand mySqlCommand = new MySqlCommand("update kitap set adet=adet+'"+dataGridView1.CurrentRow.Cells["adet"].Value.ToString()+"'where kitap_id=@kitap_id",baglanti);
            mySqlCommand.Parameters.AddWithValue("@kitap_id", dataGridView1.CurrentRow.Cells["kitap_id"].Value.ToString());
            mySqlCommand.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap(lar) iade edildi");
            dataSet.Tables["emanet"].Clear();
            EmanetListele();
        }
    }
}
