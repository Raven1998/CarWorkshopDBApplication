using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWorkshopDBModels;

namespace CarWorkshopDBDataAccess
{
    /// <summary>
    /// Entity Framework DbContext class
    /// </summary>
    public class CarWorkshopDBContext : DbContext
    {
       
        public CarWorkshopDBContext() : base("CarWorkshopDBContext")
        {

        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Repair> Repairs { get; set; }
        public DbSet<Mechanic> Mechanics { get; set; }

    }
}
