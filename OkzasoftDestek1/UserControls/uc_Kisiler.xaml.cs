using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OkzasoftDestek.BusinessLogicLayer;
using OkzasoftDestek.Entities;
using FakeData;

namespace OkzasoftDestek1.UserControls
{
    
    /// <summary>
    /// Interaction logic for uc_Kisiler.xaml
    /// </summary>
    public partial class uc_Kisiler : UserControl
        
    {
        int sayac1 = 0;
        public uc_Kisiler()
        {
            InitializeComponent();
            ListeOlustur();
        }

        private void btnKisiEkle_Click(object sender, RoutedEventArgs e)
        {
            
            Guid kurummId = Guid.NewGuid();
            OkzasoftDestek.BusinessLogicLayer.BLL BLL = new OkzasoftDestek.BusinessLogicLayer.BLL();
            
            int ReturnValues = BLL.kisiEkle(txt_kisi_adsoyad.Text,txt_kisi_tel.Text, txt_kisi_eposta.Text, kurummId);
            if (ReturnValues>0)
            {
                MessageBox.Show("Kayıt Başarılı", "Bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
                ListeOlustur();

            }
            else
                MessageBox.Show("Bir sorun var ! ", "Bilgi", MessageBoxButton.OK, MessageBoxImage.Error);
                

            /*//kisi doldur
            for (int i = 0; i < 20; i++)
            {
                BLL.kisiEkle(FakeData.NameData.GetFullName(), FakeData.PhoneNumberData.GetInternationalPhoneNumber(), FakeData.NetworkData.GetEmail(), kurummId);
            }*/
        }

        private void ListeOlustur()
        {
            OkzasoftDestek.BusinessLogicLayer.BLL BLL = new OkzasoftDestek.BusinessLogicLayer.BLL();
            List<Kisiler> KisiListesi = BLL.kisileriListele();
            if (KisiListesi != null && KisiListesi.Count > 0)
            {
                lst_kisilistesi.ItemsSource = KisiListesi;
                
                sayac1++;
                
            }
        }

        private void lst_kisilistesi_Loaded(object sender, RoutedEventArgs e)
        {
            ListeOlustur();
        }
    }
}
