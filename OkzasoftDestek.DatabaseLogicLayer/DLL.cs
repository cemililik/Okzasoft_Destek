using OkzasoftDestek.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkzasoftDestek.DatabaseLogicLayer
{
    public class DLL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        int ReturnValues;

        public DLL()
        {
            con = new SqlConnection("Data Source=DESKTOP-04SEUSQ;Initial Catalog=destekDbSon;Integrated Security=True");
        }

        public void BaglantiAyarla()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else
                con.Close();
        }
        /*
        public int ekipmanEkle(Ekipmanlar e)
        {
            try
            {
                cmd = new SqlCommand("insert into Ekipmanlar ()");
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
            return ReturnValues;
        }
        */
        public int kurumEkle(Kurumlar kr)
        {
            try
            {
                cmd = new SqlCommand("insert into Kurumlar (kurumId,kurumAd,telefon,ulke,sehir,adres) values (@kurumId,@kurumAd,@telefon,@ulke,@sehir,@adres)", con);
                cmd.Parameters.Add("@kurumId", SqlDbType.UniqueIdentifier).Value = kr.kurumId;
                cmd.Parameters.Add("@kurumAd", SqlDbType.NVarChar).Value = kr.kurumAd;
                cmd.Parameters.Add("@telefon", SqlDbType.NVarChar).Value = kr.telefon;
                cmd.Parameters.Add("@ulke", SqlDbType.NVarChar).Value = kr.ulke;
                cmd.Parameters.Add("@sehir", SqlDbType.NVarChar).Value = kr.sehir;
                cmd.Parameters.Add("@adres", SqlDbType.NVarChar).Value = kr.adres;
                BaglantiAyarla();
                ReturnValues = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                
            }
            finally
            {
                BaglantiAyarla();
            }
            return ReturnValues;
        }
        public int kisiEkle(Kisiler k)
        {
            try
            {
                cmd = new SqlCommand("insert into Kisiler (kisiId,kisiAdSoyad,kisiTelefon,eposta,kurumId) values (@kisiId,@kisiAdSoyad,@kisiTelefon,@eposta,@kurumId)", con);
                cmd.Parameters.Add("@kisiId", SqlDbType.UniqueIdentifier).Value = k.kisiId;
                cmd.Parameters.Add("@kisiAdSoyad", SqlDbType.NVarChar).Value = k.kisiAdSoyad;
                cmd.Parameters.Add("@kisiTelefon", SqlDbType.NVarChar).Value = k.kisiTelefon;
                cmd.Parameters.Add("@eposta", SqlDbType.NVarChar).Value = k.eposta;
                cmd.Parameters.Add("@kurumId", SqlDbType.UniqueIdentifier).Value = k.kurumId;
                BaglantiAyarla();
                ReturnValues = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                BaglantiAyarla();
            }
            return ReturnValues;
        }

        public SqlDataReader kisileriListele()
        {
            cmd = new SqlCommand("select * from Kisiler", con);
            BaglantiAyarla();
            return cmd.ExecuteReader();
        }

        public SqlDataReader kurumlariListele()
        {
            cmd = new SqlCommand("select * from Kurumlar", con);
            BaglantiAyarla();
            return cmd.ExecuteReader();
        }
    }

}
