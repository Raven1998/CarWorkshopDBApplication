using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarWorkshopDBModels
{
    /// <summary>
    /// Entity Framework Clients Table creation logic
    /// </summary>
    [Table("Clients")]
    public class Client :ModelBase
    {
        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(15)]
        public string PhoneNumber { get; set; }

        public List<Car> Cars = new List<Car>();

    }
}
