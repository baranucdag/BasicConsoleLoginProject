using System;

namespace LoginApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //yazılan bu programda amaç basit bir konsol login uygulaması oluşturmaktır.;

            int sayac = 3;
            while (true)
            {
                Console.WriteLine("lutfen kullanici adinizi girniiz:");
                string kullaniciAdi = Console.ReadLine();

                Console.WriteLine("lutfen sifrenizi giriniz:");
                string sifre = Console.ReadLine();

                if (kullaniciAdi == "ahmet" && sifre == "yılmaz")
                {
                    Console.WriteLine("tekrikler giris basarili\n çıkış için herhangi bir tusa basınız ");
                    break;
                }



                else
                {
                    Console.WriteLine("kullanici adi ya da sifre yanlis tekrar deneyiniz..");
                    Console.WriteLine("kalan giris hakkı sayisi" + (sayac - 1));

                    if (sayac > 0)
                    {
                        sayac -= 1;
                    }

                    if (sayac == 0)
                    {
                        Console.WriteLine("kalan kullaici giris hakkiniz bitmistir.");
                        break;

                    }
                }

            }

            Console.ReadLine();

        }
    }
}

