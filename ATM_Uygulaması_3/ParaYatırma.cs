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
    public partial class ParaYatırma : Form
    {
        string isim;
        string soyisim;
        int sifre;
        int bakiye;
        public ParaYatırma(string isim, string soyisim, int sifre, int bakiye)
        {
            InitializeComponent();
            this.isim = isim;
            this.soyisim = soyisim;
            this.sifre = sifre;
            this.bakiye = bakiye;   
        }

        private void ParaYatırma_Load(object sender, EventArgs e)
        {
            lbl_isim.Text = isim;
            lbl_soyisim.Text = soyisim; 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_yatirilacak_para.Text = string.Empty;   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cikis cik = new Cikis();
            cik.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GirisSayfasi gir = new GirisSayfasi(isim , soyisim , sifre , bakiye);
            gir.Show();
            this.Hide();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int yatirilacak_tutar;
            yatirilacak_tutar = Convert.ToInt32(txt_yatirilacak_para.Text);

            int yenibakiye;

            yenibakiye = bakiye + yatirilacak_tutar;

            MessageBox.Show("Yeni bakiyeniz : " + yenibakiye);

        }
    }
}
