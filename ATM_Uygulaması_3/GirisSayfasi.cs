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
    public partial class GirisSayfasi : Form
    {
        string isim;
        string soyisim;
        int sifre;
        int bakiye;
        public GirisSayfasi(string isim, string soyisim, int sifre, int bakiye)
        {
            InitializeComponent();
            this.isim = isim;
            this.soyisim = soyisim;
            this.sifre = sifre;
            this.bakiye = bakiye;
        }

        private void GirisSayfasi_Load(object sender, EventArgs e)
        {

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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BakiyeGosterme bakiyegoster = new BakiyeGosterme(isim , soyisim , sifre , bakiye);
            bakiyegoster.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParaYatırma parayatirma = new ParaYatırma(isim , soyisim , sifre , bakiye);
            parayatirma.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ParaCekme paracekme = new ParaCekme(isim, soyisim, sifre, bakiye);
            paracekme.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cikis cik = new Cikis();
            cik.Show(); 
            this.Hide();    
          
        }
    }
}
