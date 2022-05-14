using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir bankada müşteri takibi yapmak istiyorsunuz.
            //Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
            //MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme, silme gibi metotları simule ediniz.
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ahmet";
            musteri1.Soyad = "Kesek";
            musteri1.Yaşi = 21;
            musteri1.Id = 1;
            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Harun";
            musteri2.Soyad = "Demirel";
            musteri2.Yaşi = 25;
            musteri2.Id = 2;
            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Berat";
            musteri3.Soyad = "Sevim";
            musteri3.Yaşi = 23;
            musteri3.Id = 3;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkleme(musteri1);
            musteriManager.MusteriListeleme(musteri1);
            musteriManager.MusteriSilme(musteri1);

            musteriManager.MusteriEkleme(musteri2);
            musteriManager.MusteriListeleme(musteri2);
            musteriManager.MusteriSilme(musteri2);

            musteriManager.MusteriEkleme(musteri3);
            musteriManager.MusteriListeleme(musteri3);
            musteriManager.MusteriSilme(musteri3);


        }
    }
}
