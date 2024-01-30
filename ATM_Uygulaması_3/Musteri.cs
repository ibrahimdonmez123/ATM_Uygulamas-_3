using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Uygulaması_3
{
    public class Musteri
    {

        public string isim { get; set; }
        public string soyisim { get; set; }
        public int sifre { get; set; }
        public int bakiye { get; set; }

        public Musteri()
        {


        }


        public Musteri(string isim , string soyisim , int sifre , int bakiye)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.sifre= sifre;
            this.bakiye= bakiye;    
        }

        public void setisim()
        {
            this.isim = isim;   

        }

        public string getisim()
        {
            return this.isim;   
        }

        public void setsoyisim()
        {
            this.soyisim = soyisim;
        }
        public string getsoyisim()
        {
            return this.soyisim;
        }

        public void setsifre()
        {
            this.sifre = sifre;
        }

        public int getsifre()
        {
            return this.sifre;  
        }

        public void setbakiye()
        {
            this.bakiye = bakiye;
        }
        public int getbakiye()
        {
            return this.bakiye; 
        }
    }
}
