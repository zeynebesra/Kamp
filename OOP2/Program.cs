using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Engin";
            //musteri1.Soyadi = "Demiroğ";
            //musteri1.Id = 1;
            //musteri1.TcNo = "22222222";
            //musteri1.MusteriNo = "12345";

            //Gerçek -Tüzel Müşteri

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "1234556";
            musteri1.Adi = "Zeyneb";
            musteri1.Soyadi = "Öztürk";
            musteri1.TcNo = "7854508059";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "1234557";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "895749487045";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);













            //SOLID

        }
    }
}
