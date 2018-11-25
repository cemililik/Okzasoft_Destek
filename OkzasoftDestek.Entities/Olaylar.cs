using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkzasoftDestek.Entities
{
    public class Olaylar
    {
        public Guid olayId { get; set; }
        public Guid kisiId { get; set; }
        public Guid kurumId { get; set; }
        public string olayAyrinti { get; set; }
        public DateTime tarih { get; set; }
        public string durum { get; set; }
        public Guid ekipmanId { get; set; }
    }
}
