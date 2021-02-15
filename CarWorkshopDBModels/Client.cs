using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarWorkshopDBModels
{
    [Table("Clients")]
    public class Client
    {
        [Key]
        [Required]
        public int ClientID { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(15)]
        public string PhoneNumer { get; set; }

        public List<Car> Cars { get; set; }

    }
}
