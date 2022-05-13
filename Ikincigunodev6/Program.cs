using System;

namespace Ikincigunodev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Products urun1 = new Products();
            urun1.UrunFiyati = 55.99;
            urun1.UrunAdi = "V Yaka T-shirt";
            urun1.UrunYildizSayisi = 4.5;

            Products urun2 = new Products();
            urun2.UrunFiyati = 55.99;
            urun2.UrunAdi = "V Yaka T-shirt";
            urun2.UrunYildizSayisi = 4.5;

            Products urun3 = new Products();
            urun3.UrunFiyati = 55.99;
            urun3.UrunAdi = "V Yaka T-shirt";
            urun3.UrunYildizSayisi = 4.5;

            Products urun4 = new Products();
            urun4.UrunFiyati = 59.99;
            urun4.UrunAdi = "Kısa kollu T-shirt";
            urun4.UrunYildizSayisi = 4.5;

            Products[] urunler = new Products[] { urun1, urun2, urun3, urun4 };
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " " + urun.UrunFiyati + " " + urun.UrunYildizSayisi);
            }
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi + " " + urunler[i].UrunFiyati + " " + urunler[i].UrunYildizSayisi);
            }
            int a = 0;
            while (a < urunler.Length)
            {
                Console.WriteLine(urunler[a].UrunAdi + " " + urunler[a].UrunFiyati + " " + urunler[a].UrunYildizSayisi);
                a += 1;
            }
        }
    }
    class Products
    {
        public double UrunYildizSayisi { get; set; }
        public string UrunAdi { get; set; }
        public double UrunFiyati { get; set; }
    }
}
