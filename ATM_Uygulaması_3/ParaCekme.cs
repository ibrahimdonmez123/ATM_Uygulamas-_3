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
    public partial class ParaCekme : Form
    {
        string isim;
        string soyisim;
        int sifre;
        int bakiye;
        public ParaCekme(string isim, string soyisim, int sifre, int bakiye)
        {
            InitializeComponent();
            this.isim = isim;
            this.soyisim = soyisim;
            this.sifre = sifre;
            this.bakiye = bakiye;   
        }

        private void ParaCekme_Load(object sender, EventArgs e)
        {
            lbl_isim.Text = isim;   
            lbl_soyisim.Text = soyisim; 

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cikis cik = new Cikis();
            cik.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GirisSayfasi gir = new GirisSayfasi(isim, soyisim, sifre, bakiye);
            gir.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_cekilecek_tutar.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cekilecek_tutar;
            cekilecek_tutar = Convert.ToInt32(txt_cekilecek_tutar.Text);

            if(cekilecek_tutar > bakiye)
            {
                MessageBox.Show("Bakiyenizden fazla para çekemezsiniz");
                
            }

            else
            {
                int kalacakbakiye;
                kalacakbakiye = bakiye - cekilecek_tutar;
                MessageBox.Show("kalacak bakiyeniz : " + kalacakbakiye);
            }
        }
    }
}
