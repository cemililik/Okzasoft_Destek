﻿using System;
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
    /// Interaction logic for uc_Ekipman.xaml
    /// </summary>
    public partial class uc_Ekipman : UserControl
    {
        public uc_Ekipman()
        {
            InitializeComponent();
        }

        private void btnIoCardEkle_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(txt_ekipman_tur.Text);
        }
    }
}
