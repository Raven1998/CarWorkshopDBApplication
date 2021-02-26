using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshopDBModels
{
    /// <summary>
    /// This class include an entity property for all tables
    /// </summary>
    public class ModelBase : IEntity
    {
        [Key]
        [Required]
        public int ID { get; set; }
    }
}
