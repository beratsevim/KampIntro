using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi;
            int yasi;

            Futbolcu futbolcu1 = new Futbolcu();
            futbolcu1.Adi = "Halil Dervişoğlu";
            futbolcu1.Yasi = 22;
            futbolcu1.Kulübu = "Galatasaray";
            futbolcu1.Mevkisi = "Forvet";

            Futbolcu futbolcu2 = new Futbolcu();
            futbolcu2.Adi = "Fernando Muslera";
            futbolcu2.Yasi = 33;
            futbolcu2.Kulübu = "Galatasaray";
            futbolcu2.Mevkisi = "Kaleci";

            Futbolcu futbolcu3 = new Futbolcu();
            futbolcu3.Adi = "Sacha Boey";
            futbolcu3.Yasi = 24;
            futbolcu3.Kulübu = "Galatasaray";
            futbolcu3.Mevkisi = "Sağ bek";

            Futbolcu futbolcu4 = new Futbolcu();
            futbolcu4.Adi = "Kerem Aktürkoğlu";
            futbolcu4.Yasi = 11;
            futbolcu4.Kulübu = "Galatasaray";
            futbolcu4.Mevkisi = "Sağ kanat";

            Futbolcu[] futbolcular = new Futbolcu[] {futbolcu1, futbolcu2, futbolcu3, futbolcu4 };

            foreach (var futbolcu in futbolcular)
            {
                Console.WriteLine("Futbolcunun Adı : " + futbolcu.Adi + " " + "Futbolcunun Yaşı : " + futbolcu.Yasi + " " 
                    + " Futbolcunun Mevkisi : " + futbolcu.Mevkisi + " " + "Futbolcunun Kulübü : " + futbolcu.Kulübu);
            }
            

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;
            
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem";
            kurs2.IzlenmeOrani = 64;
            
            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Phyton";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " %" + kurs.IzlenmeOrani);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
    
    
    
    class Futbolcu
    {
        public int Yasi { get; set; }
        public string Mevkisi { get; set; }
        public string Kulübu { get; set; }
        public string Adi { get; set; }
    }
}
