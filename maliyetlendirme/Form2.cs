using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maliyetlendirme
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            const string KayitliKullaniciAdi = "emre can";
            const string KayitliSifre = "221903553";
            string GirilenKullaniciAdi = txtName.Text;
            string GirilenSifre = txtPassword.Text;

            if (KayitliKullaniciAdi == GirilenKullaniciAdi && KayitliSifre == GirilenSifre)
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            else if(KayitliKullaniciAdi == GirilenKullaniciAdi && KayitliSifre != GirilenSifre)
            {
                MessageBox.Show("Şifre yanlış");
            }
            else if(KayitliKullaniciAdi != GirilenKullaniciAdi && KayitliSifre == GirilenSifre)
            {
                MessageBox.Show("kullanıcı adınız yanlış");
            }
            else
            {
                MessageBox.Show("bilgiler yanlış tekrar deneyin...");
            }








        }
    }
}
