using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkzasoftDestek.data
{
    [Table("Kameralar")]
    public class Kamera
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int kameraId { get; set; }
        [StringLength(15),Required]
        public string kameraIp { get; set; }
        [StringLength(12),Required]
        public string kullaniciAdi { get; set; }
        [StringLength(12),Required]
        public string sifre { get; set; }

    }
}
