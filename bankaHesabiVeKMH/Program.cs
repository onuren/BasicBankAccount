using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaHesabiVeKMH
{
    class Program
    {
        static void Main(string[] args)
        {
            hesap hsp = new hesap();

            for (; ; )
            {
                hsp.baslangic();
                string giris = Console.ReadLine();

                if(giris== "Yükle" || giris=="1")
                {
                    Console.WriteLine("Yatırmak istediğiniz miktarı giriniz.");
                    double i = Convert.ToDouble(Console.ReadLine());
                    hsp.Yukle(i);
                }
                if (giris == "Ödeme" || giris == "2")
                {
                    Console.WriteLine("Ödemek istediğiniz miktarı giriniz.");
                    double i = Convert.ToDouble(Console.ReadLine());
                    hsp.odeme(i);
                }
                if (giris == "Bakiye" || giris == "3")
                {
                    hsp.bakiyeGoster();
                }
                if (giris == "Çıkış" || giris == "4")
                {
                    break;
                }
            }
        }
    }
}
