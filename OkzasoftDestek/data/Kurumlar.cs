using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkzasoftDestek.data
{
    [Table("Kurumlar")]
    public class Kurumlar
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int kurumId { get; set; }
        [StringLength(25), Required]
        public string kurumAdi { get; set; }
        [MaxLength(20)]
        public string telefon { get; set; }
        [StringLength(20), Required]
        public string ulke { get; set; }
        [StringLength(25), Required]
        public string sehir { get; set; }
        [StringLength(300)]
        public string adres { get; set; }

        //public virtual Kisiler kisi { get; set; }
    }
}
