using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkzasoftDestek.data
{
    [Table("Kisiler")]
    public class Kisiler
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int kisiId { get; set; }
        [StringLength(25), Required]
        public string kisiAdSoyad { get; set; }
        [Required]
        public string telefon { get; set; }
        public string ePosta { get; set; }


        //public virtual Kurumlar Kurum { get; set; }
    }
}
