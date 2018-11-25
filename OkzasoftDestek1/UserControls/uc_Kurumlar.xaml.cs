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

namespace OkzasoftDestek1.UserControls
{
    /// <summary>
    /// Interaction logic for uc_Kurumlar.xaml
    /// </summary>
    public partial class uc_Kurumlar : UserControl
    {
        public uc_Kurumlar()
        {
            InitializeComponent();
            ListeOlustur();
        }

        private void btnKurumEkle_Click(object sender, RoutedEventArgs e)
        {
            OkzasoftDestek.BusinessLogicLayer.BLL BLL = new OkzasoftDestek.BusinessLogicLayer.BLL();
            int ReturnValues = BLL.kurumEkle(txt_kurum_ad.Text, txt_kurum_telefon.Text, txt_kurum_ulke.Text, txt_kurum_sehir.Text, txt_kurum_adres.Text);
            if (ReturnValues > 0)
            {
                MessageBox.Show("Kayıt Başarılı", "Bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
                ListeOlustur();

            }
            else
                MessageBox.Show("Bir sorun var ! ", "Bilgi", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        private void ListeOlustur()
        {
            OkzasoftDestek.BusinessLogicLayer.BLL BLL = new OkzasoftDestek.BusinessLogicLayer.BLL();
            List<OkzasoftDestek.Entities.Kurumlar> kurumListesi = BLL.kurumlariListele();
            if(kurumListesi != null && kurumListesi.Count>0)
            {
                //lst_kurumlar.DataSource = kurumListesi;
                lst_kurumlar.Items.Add(kurumListesi);
            }
        }
    }
}
