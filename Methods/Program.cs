using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.UrunAdi = "Elma";
            urun1.UrunFiyati = 15;
            urun1.UrunAciklamasi = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Karpuz";
            urun2.UrunFiyati = 80;
            urun2.UrunAciklamasi = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi);
                Console.WriteLine(urun.UrunFiyati);
                Console.WriteLine(urun.UrunAciklamasi);
                Console.WriteLine("-----------");
            }

            Console.WriteLine("------- METHODS---------");

            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            // (yanlış) sepetManager.Ekle2("Muz", "İthal Muz", 20);


        }
    }
}
