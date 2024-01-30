using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Uygulaması_3
{
    public partial class Form1 : Form
    {
        List<Musteri> Musteriler = new List<Musteri>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_sifre.Text = string.Empty;  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int girilensifre;

            girilensifre = Convert.ToInt32(txt_sifre.Text);

            foreach (Musteri musteri in Musteriler)
            {
                Musteri hedefmusteri;
                bool kontrol = false;

                if (girilensifre == musteri.getsifre())
                {
                    hedefmusteri= musteri;
                    string isim;
                    string soyisim;
                    int sifre;
                    int bakiye;

                    isim = hedefmusteri.getisim();
                    soyisim = hedefmusteri.getsoyisim();
                    sifre = hedefmusteri.getsifre();
                    bakiye = hedefmusteri.getbakiye();


                    GirisSayfasi girissayfasi = new GirisSayfasi(isim , soyisim , sifre , bakiye);
                    girissayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;


                }

                if(!kontrol)
                {
                    int haksayisi = 3;

                    MessageBox.Show("Girdiğiniz şifre yanlış , lütfen tekrar deneyiniz");

                    haksayisi--;

                    if( haksayisi == 0 )
                    {
                        MessageBox.Show("Deneme hakkınız bitmiştir , lütfen daha fazla denemeyiniz");
                    }
                    break;

                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Musteriler.Add(new Musteri("ibrahim", "dönmez", 3737, 10000));
            Musteriler.Add(new Musteri("baran", "nekiz", 3838, 5000));
            Musteriler.Add(new Musteri("irem", "dönmez", 2929, 2500));
            Musteriler.Add(new Musteri("yılmaz", "özsezik", 4040, 250));

        }
    }
}
