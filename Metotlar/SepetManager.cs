using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //Naming Convention
        //Syntax Yazım değişlikleri java - c#
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi! : " + urun.Adi);
        }
        public void Ekle2(string urunAdi, string Aciklama, double Fiyat, int StokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi! : " + urunAdi);
        }
    }
}
