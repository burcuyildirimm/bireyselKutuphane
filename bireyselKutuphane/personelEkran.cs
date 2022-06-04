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

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kitapIslemleriCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kitapIslemleriCmb.SelectedIndex==0)
            {
                kitapListele kitapListele = new kitapListele();
                kitapListele.Show();
                this.Hide();
            }
            else if (kitapIslemleriCmb.SelectedIndex == 1)
            {
                kitapEkle kitapEkle = new kitapEkle();
                kitapEkle.Show();
                this.Hide();
            }
            else if (kitapIslemleriCmb.SelectedIndex == 2)
            {
                kitapSil kitapSil = new kitapSil();
                kitapSil.Show();
                this.Hide();
            }
            else if (kitapIslemleriCmb.SelectedIndex == 3)
            {
                kitapAra kitapAra = new kitapAra();
                kitapAra.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullaniciListele kullaniciListele = new kullaniciListele();
            kullaniciListele.Show();
            this.Hide();
        }
    }
}
