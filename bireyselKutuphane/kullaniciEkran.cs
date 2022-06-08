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
    public partial class kullaniciEkran : Form
    {
        public kullaniciEkran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void sıralamaBtn_Click(object sender, EventArgs e)
        {
  
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gfrafikBtn_Click(object sender, EventArgs e)
        {
            grafik grafik = new grafik();
            grafik.Show();
            this.Hide();
        }

        private void emanetKitpBtn_Click(object sender, EventArgs e)
        {
            emanetKitaplarımcs emanetKitaplarımcs = new emanetKitaplarımcs();
            emanetKitaplarımcs.Show();
            this.Hide();
        }
    }
}
