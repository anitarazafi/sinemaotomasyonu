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
    public partial class AnaPencere : Form
    {
        public AnaPencere()
        {
            InitializeComponent();
        }

        private void AnaPencere_closed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void yuklendi(object sender, EventArgs e)
        {
            DataTable kayitlar = Veritabani.kisiListele();

            grd_kisiler.DataSource = kayitlar;

            grd_kisiler.Columns[0].Visible = false;
        }

        private void btn_yenikayit_Click(object sender, EventArgs e)
        {
            YeniKayit yeniKayit =  new YeniKayit(this);

            this.Hide();
            yeniKayit.Show();
        }
    }
}
