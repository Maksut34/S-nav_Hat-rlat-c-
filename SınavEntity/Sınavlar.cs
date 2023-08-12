using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınavEntity
{
    public class Sınavlar
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string sınav_adı { get; set; }
        [Required]
        public string tarihi { get; set; }
        [Required]
        public string saati { get; set;}
        public string dakika { get; set; }
    }
}
