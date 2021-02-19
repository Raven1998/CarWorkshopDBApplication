using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshopDBModels
{
    [Table("Cars")]
    public class Car:ModelBase
    {
        [Required]
        [ForeignKey("Client")]
        public int ClientRefID { get; set; }
        public Client Client { get; set; }

        [Required]
        [StringLength(30)]
        public string Brand { get; set; }

        [Required]
        [StringLength(30)]
        public string Model { get; set; }

        [Required]
        [StringLength(15)]
        public string VIN { get; set; }

        [Required]
        [StringLength(8)]
        public string RegistrationNumber { get; set; }

        public List<Repair> Repairs = new List<Repair>();


    }
}
