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
    public partial class BakiyeGosterme : Form
    {
        string isim;
        string soyisim;
        int sifre;
        int bakiye;
        public BakiyeGosterme(string isim, string soyisim, int sifre ,  int bakiye)
        {
            InitializeComponent();
            this.isim = isim;
            this.soyisim = soyisim;
            this.bakiye = bakiye;   
        }

        private void BakiyeGosterme_Load(object sender, EventArgs e)
        {
            lbl_bakiye.Text = bakiye.ToString();    
            lbl_isim.Text = isim.ToString();
            lbl_soyisim.Text = soyisim.ToString();
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
    }
}
