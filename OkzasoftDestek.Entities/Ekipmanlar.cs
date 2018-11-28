using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkzasoftDestek.Entities
{
    public class Ekipmanlar
    {
        public Guid ekipmanId { get; set; }
        public string ekipmanTur { get; set; }
        public string ekipmanIp { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
    }
}
