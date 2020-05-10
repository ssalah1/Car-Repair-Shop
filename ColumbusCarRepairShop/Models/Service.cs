using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ColumbusCarRepairShop.Models
{
    public class Service
    {
        // Class Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ServiceId { get; set; }
        [Required]
        [MaxLength(50)]
        public string ServiceName { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        [Required]
        public double Cost { get; set; }

        public int Qty { get; set; } = 0;

        public byte[] ServiceImage { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
