using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkzasoftDestek.Entities
{
    public class Kisiler
    {
        public Guid kisiId { get; set; }
        public string kisiAdSoyad { get; set; }
        public string kisiTelefon { get; set; }
        public string eposta { get; set; }
        public Guid kurumId { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", kisiAdSoyad, kisiTelefon, eposta);
        }
    }
}
