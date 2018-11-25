using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OkzasoftDestek.DatabaseLogicLayer;

namespace OkzasoftDestek.BusinessLogicLayer
{
    public class BLL
    {
        DatabaseLogicLayer.DLL dll;
        public BLL()
        {
            dll = new DatabaseLogicLayer.DLL();
        }

        public int kisiEkle(string kisiAdSoyad,string kisiTelefon, string eposta, Guid kurumId)
        {
            if (!string.IsNullOrEmpty(kisiAdSoyad) && !string.IsNullOrEmpty(eposta))
            {
                return dll.kisiEkle(new Entities.Kisiler()
                {
                    kisiId = Guid.NewGuid(),
                    kisiAdSoyad = kisiAdSoyad,
                    kisiTelefon = kisiTelefon,
                    eposta = eposta,
                    kurumId = Guid.NewGuid()
                });

            }
            else
                return -1;
        }
        public int kurumEkle(string kurumAd,string telefon, string ulke, string sehir, string adres)
        {
            if (!string.IsNullOrEmpty(kurumAd))
            {
                return dll.kurumEkle(new Entities.Kurumlar()
                {
                    kurumId = Guid.NewGuid(),
                    kurumAd = kurumAd,
                    telefon = telefon,
                    ulke = ulke,
                    sehir = sehir,
                    adres = adres
                });

            }
            else
                return -1;
        }
           

        public List<Entities.Kisiler> kisileriListele()
        {
            List<Entities.Kisiler> kisiListesi = new List<Entities.Kisiler>();
            try
            {
                SqlDataReader reader = dll.kisileriListele();
                while (reader.Read())
                {
                    kisiListesi.Add(new Entities.Kisiler()
                    {
                        kisiId = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        kisiAdSoyad = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        kisiTelefon = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        eposta = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        kurumId = reader.IsDBNull(4) ? Guid.Empty : reader.GetGuid(4)
                    });
                    reader.Close();
                }
            }
            catch (Exception ex)
            {

                
            }
            finally
            {
                dll.BaglantiAyarla();
            }
            return kisiListesi;
        }

        public List<Entities.Kurumlar> kurumlariListele()
        {
            List<Entities.Kurumlar> kurumListesi = new List<Entities.Kurumlar>();
            try
            {
                SqlDataReader reader = dll.kurumlariListele();
                while(reader.Read())
                {
                    kurumListesi.Add(new Entities.Kurumlar()
                    {
                        kurumId = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        kurumAd = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        telefon = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        ulke = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        sehir = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        adres = reader.IsDBNull(5) ? string.Empty : reader.GetString(5)
                    });
                    reader.Close();
                }
            }
            catch (Exception ex)
            {

                
            }
            finally
            {
                dll.BaglantiAyarla();
            }
            return kurumListesi;
        }
    }
}
