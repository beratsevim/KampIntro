using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " Adlı Müşteri Eklendi..");
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " Adlı Müşteri Silindi.." );
            Console.WriteLine("-------------------------");
        }
        public void MusteriListeleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " Adlı Müşteriler Listelendi..");
            
        }
    }
}
