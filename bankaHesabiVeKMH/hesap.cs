using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaHesabiVeKMH
{
    class hesap
    {
        private double bankaHesabi;
        private double KMHHesabi = 2000;
        private double KMHHesabiLimiti = 2000;
        private double KMHHesabiFaiz = 1.02;

        public void bakiyeGoster()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Hesap Bakiyesi: " + bankaHesabi);
            Console.WriteLine("Kredi Hesabı Bakiyesi: "+KMHHesabi);
        }

        public void Yukle(double miktar)
        {
            if(KMHHesabi==KMHHesabiLimiti)
            {
                bankaHesabi += miktar;
            }
            else
            {
                double KMHBorc = KMHHesabiLimiti - KMHHesabi;
                KMHBorc *= KMHHesabiFaiz;
                if(KMHBorc>=miktar)
                {
                    KMHHesabi += (miktar*=(1-(KMHHesabiFaiz-1)));
                }
                if(KMHBorc<miktar)
                {
                    bankaHesabi += (miktar - KMHBorc);
                    KMHHesabi = KMHHesabiLimiti;
                }
            }
            bakiyeGoster();
        }
        public void odeme(double miktar)
        {
            if (bankaHesabi>=miktar)
            {
                bankaHesabi -= miktar;
            }
            else if(bankaHesabi<=miktar && miktar<=(KMHHesabi+bankaHesabi))
            {
                KMHHesabi -= (miktar - bankaHesabi);
                bankaHesabi = 0;
            }
            else
            {
                Console.WriteLine("Bakiye Yetersizdir.");
            }
            bakiyeGoster();
        }
        public void baslangic()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Yapmak istediğiniz işlemi giriniz: ");
            Console.WriteLine("     1* Yükle");
            Console.WriteLine("     2* Ödeme");
            Console.WriteLine("     3* Bakiye");
            Console.WriteLine("     4* Çıkış");
            Console.WriteLine("--------------------------------------");
        }
    }
}
