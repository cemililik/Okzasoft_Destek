using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkzasoftDestek.data
{
    [Table("Baglanti")]
    public class baglanti
    {
        [StringLength(20)]
        public string uygulamaAdi { get; set; }
        [StringLength(20)]
        public string kullaniciAdi { get; set; }
        [StringLength(20)]
        public string sifre { get; set; }
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int baglantiId { get; set; }

    }
}
