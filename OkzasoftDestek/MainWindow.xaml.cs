using OkzasoftDestek.Kontroller;
using OkzasoftDestek.sinif;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace OkzasoftDestek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void brdRightTop_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //this.DragMove();
        }

        private void hizmetOzeti_Click(object sender, RoutedEventArgs e)
        {
            uc_Cagir.ucEkle(masterGrid, new uc_Ozet());
        }

        private void btnKurumlar_Click(object sender, RoutedEventArgs e)
        {
            uc_Cagir.ucEkle(masterGrid, new uc_Kurumlar());
        }

        private void btnKisi_Click(object sender, RoutedEventArgs e)
        {
            uc_Cagir.ucEkle(masterGrid, new uc_Kisiler());
        }

        private void btnEkipman_Click(object sender, RoutedEventArgs e)
        {
            uc_Cagir.ucEkle(masterGrid, new uc_Ekipman());
        }
    }
}
