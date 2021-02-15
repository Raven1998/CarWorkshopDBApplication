using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshopDBModels
{
    [Table("Mechanics")]
    public class Mechanic
    {
        [Key]
        [Required]
        public int MechanicID { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public DateTime DateOfEmployment { get; set; }


        public List<Repair> Repairs { get; set; }

    }
}
