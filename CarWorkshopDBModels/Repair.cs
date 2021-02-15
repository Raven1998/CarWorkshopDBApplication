using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshopDBModels
{
    [Table("Repairs")]
    public class Repair
    {
        [Key]
        [Required]
        public int RepairID { get; set; }

        [Required]
        [ForeignKey("Car")]
        public int CarRefID { get; set; }
        public Car Car { get; set; }

        [Required]
        public decimal RepairPrize { get; set; }

        [Required]
        public DateTime BringingDate { get; set; }

        [Required]
        public DateTime CollectDate { get; set; }

        [StringLength(200)]
        public string RepairDescription { get; set; }

        [ForeignKey("Mechanic")]
        public int MechanicRefID { get; set; }
        public Mechanic Mechanic { get; set; }
    }
}
