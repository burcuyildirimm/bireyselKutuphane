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
            this.Hide();
            personelEkran personel = new personelEkran();
            personel.Show();
        }
    }
}
