using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace OkzasoftDestek.data.DBManager
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Kisiler> Kisiler { get; set; }
        public DbSet<Kurumlar> Kurumlar { get; set; }
        public DbSet<Kamera> Kamera { get; set; }
        public DbSet<IOCard> IOCard { get; set; }
        public DbSet<baglanti> baglanti { get; set; }
       // public DbSet<Destek> Destek { get; set; }

        public DatabaseContext()
        {
            Database.SetInitializer(new DbCreator());
        }
    }

    public class DbCreator : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            for (int i = 0; i < 19; i++)
            {
                Kisiler kisi = new Kisiler();
                kisi.kisiAdSoyad = FakeData.NameData.GetFullName();
                kisi.telefon = (FakeData.PhoneNumberData.GetUsPhoneNumber()).ToString(); ;
                kisi.ePosta = FakeData.NetworkData.GetEmail();

                context.Kisiler.Add(kisi);
            }

            context.SaveChanges();

            List<Kisiler> tumKisiler = context.Kisiler.ToList();

            foreach (Kisiler kisi in tumKisiler)
            {
                Kurumlar kurum = new Kurumlar();
                kurum.kurumAdi = FakeData.NameData.GetCompanyName();
                kurum.ulke = FakeData.PlaceData.GetCountry();
                kurum.sehir = FakeData.PlaceData.GetCity();
                kurum.adres = FakeData.PlaceData.GetAddress();
                kurum.telefon = (FakeData.PhoneNumberData.GetUsPhoneNumber()).ToString();
                //kurum.kisi = kisi;

                context.Kurumlar.Add(kurum);
            }

            context.SaveChanges();

            for (int i = 0; i < 19; i++)
            {
                Kamera cam = new Kamera();
                cam.kameraIp = FakeData.NetworkData.GetIpAddress();
                cam.kullaniciAdi = FakeData.PlaceData.GetCity();
                cam.sifre = FakeData.NameData.GetFirstName();

                context.Kamera.Add(cam);
            }

            for (int i = 0; i < 19; i++)
            {
                IOCard iocard = new IOCard();
                iocard.iOCardIp = FakeData.NetworkData.GetIpAddress();
                iocard.marka = FakeData.PlaceData.GetCity();
                iocard.model = FakeData.NameData.GetFirstName();

                context.IOCard.Add(iocard);
            }

            for (int i = 0; i < 19; i++)
            {
                Boolean temp = FakeData.BooleanData.GetBoolean();
                baglanti bglnti = new baglanti();
                if (temp == false)
                {
                    bglnti.uygulamaAdi = "Teamwiever";
                }
                else bglnti.uygulamaAdi = "AnyDesk";
                
                bglnti.kullaniciAdi = FakeData.PlaceData.GetCity();
                bglnti.sifre = FakeData.NameData.GetFirstName();

                context.baglanti.Add(bglnti);
            }

            //for (int i = 0; i < 19; i++)
            //{
            //    Destek destek = new Destek();
            //    destek.tarih = FakeData.DateTimeData.GetDatetime();
            //    destek.neden = FakeData.TextData.GetSentence();
            //    destek.durum = FakeData.BooleanData.GetBoolean();

            //    context.Destek.Add(destek);
            //}

            //context.SaveChanges();
            //List<Destek> Destekler = context.Destek.ToList();

            //foreach (Destek destek in Destekler)
            //{
            //    Kurumlar kurum = new Kurumlar();
            //    //kurum.kurumId
            //}
            
        }
    }
}
