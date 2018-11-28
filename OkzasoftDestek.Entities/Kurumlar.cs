using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkzasoftDestek.Entities
{
    public class Kurumlar
    {
        public Guid kurumId { get; set; }
        public string kurumAd { get; set; }
        public string telefon { get; set; }
        public string ulke { get; set; }
        public string sehir { get; set; }
        public string adres { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", kurumAd, telefon, ulke, sehir);
        }

    }
}
