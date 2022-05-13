using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Aciklama = "Elma";
            urun1.Fiyati = 15;
            urun1.Adi = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Aciklama = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Adi = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {urun1, urun2};

            foreach (Product urun in products)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");
            }
            Console.WriteLine("---------Metotlar----------");
            //instance -- örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);
        }
    }
}


// Don't repeat yourself -- DRY - Clean Code - Best Practise