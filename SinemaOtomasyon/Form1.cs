using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool result = Veritabani.connect();

            if(!result)
            {
                MessageBox.Show("Sql connection error!", "ex", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Unload(object sender, FormClosingEventArgs e)
        {
            Veritabani.disconnect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Veritabani.giris("test", "test"))
            {
                AnaPencere anaPencere = new AnaPencere();
                this.Hide();
                anaPencere.Show();
            } else
            {
                MessageBox.Show("Hatalı giriş");
            }
        }
    }
}
