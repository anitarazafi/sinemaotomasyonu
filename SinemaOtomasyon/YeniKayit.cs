using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyon
{
    public partial class YeniKayit : Form
    {
        public Form geriDonulecekPencere;
        public YeniKayit(Form donulecekPencere)
        {
            InitializeComponent();
            geriDonulecekPencere = donulecekPencere;
        }

        private void YeniKayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            geriDonulecekPencere.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grd_telefonlar.Rows.Add(1);
            grd_telefonlar.Rows[0].Cells[0].Value = txt_telefon.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
