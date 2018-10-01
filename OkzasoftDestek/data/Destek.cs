using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkzasoftDestek.data
{
    [Table("Destek")]
    public class Destek
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int islemId { get; set; }
        public DateTime tarih { get; set; }
        public string neden { get; set; }
        [Required]
        public Boolean durum { get; set; }
        //public virtual Kurumlar kurumId { get; set; }

    }
}
