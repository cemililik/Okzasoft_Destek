using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OkzasoftDestek.sinif
{
    public class uc_Cagir
    {
        public static void ucEkle(Grid grd, UserControl uc)
        {
            if (grd.Children.Count > 0)
            {
                grd.Children.Clear();
                grd.Children.Add(uc);
            }
            else
            {
                grd.Children.Add(uc);
            }
        }
    }
}
