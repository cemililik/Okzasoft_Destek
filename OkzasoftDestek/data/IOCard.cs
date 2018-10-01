using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkzasoftDestek.data
{
    [Table("IOCard")]
    public class IOCard
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int iOCardId { get; set; }
        [StringLength(15), Required]
        public string iOCardIp { get; set; }
        [StringLength(15)]
        public string marka { get; set; }
        [StringLength(15)]
        public string model { get; set; }

    }
}
