using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Center
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(KullaniciTb.Text==""||SifreTb.Text=="")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else if(KullaniciTb.Text=="Admin"&&SifreTb.Text=="1234")
            {
                AnaSayfa anasayfa = new AnaSayfa();
                anasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı ya da Şifre");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullaniciTb.Text = "";
            SifreTb.Text = "";
        }
    }
}
