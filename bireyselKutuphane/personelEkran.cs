using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bireyselKutuphane
{
    public partial class personelEkran : Form
    {
        public personelEkran()
        {
            InitializeComponent();
        }

        private void kullanıcıIslemCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void emanetIslemleriCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (emanetIslemleriCmb.Text== "Emanet Kitap Alma")
            {
                emanetAlma emanetAlma = new emanetAlma();
                emanetAlma.Show();
                this.Hide();
            }
            else if(emanetIslemleriCmb.Text== "Emanet Kitap Listeleme")
            {
                emanetKitapListele emanet = new emanetKitapListele();
                emanet.Show();
                this.Hide();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kitapIslemleriCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullaniciListele kullaniciListele = new kullaniciListele();
            kullaniciListele.Show();
            this.Hide();
        }

        private void kitapBtn_Click(object sender, EventArgs e)
        {
            kitapListele kitapListele = new kitapListele();
            kitapListele.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz", "Evet", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
        }
    }
}
