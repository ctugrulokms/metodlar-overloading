using System;

namespace metodlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // out parametreler
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);

            if(sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız!");
            }

            Metodlar instance = new Metodlar();
            instance.Topla(2, 3, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            //Metod Aşırı Yükleme - Overloading

            int ifade = 999;

            instance.EkranaYazdir(ifade);

            // Metod imzası
            // Metod adı + parametre sayısı + parametre

            instance.EkranaYazdir("Tugrul", "Okumus");
        }
    }

    class Metodlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
