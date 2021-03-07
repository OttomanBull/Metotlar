using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Acıklama = "Amasya Elmasi";
            urun1.adet = 20;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Acıklama = "Diyarbakır karpuzu";
            urun2.adet = 19;

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Acıklama);
                Console.WriteLine(urun.adet);
                Console.WriteLine("-----------------");
                
            }

            Console.WriteLine("------------------Metotlar------------------");

            //ensapsulation  
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut", 12, "Yeşil Armut",10);
            sepetManager.Ekle2("Elma", 50, "Kırmızı Elma",12);
            sepetManager.Ekle2("Karpuz", 80, "Diyerbakır Karpuz",14);

        }
    }
}
