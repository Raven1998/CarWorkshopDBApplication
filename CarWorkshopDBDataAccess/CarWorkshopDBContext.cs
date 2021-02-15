using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWorkshopDBModels;

namespace CarWorkshopDBDataAccess
{
    public class CarWorkshopDBContext : DbContext
    {
        //TO DO: 
        //Add connection string inside app.config for local database and create a local database file - attach file to the project
        public CarWorkshopDBContext() : base("CarWorkshopDBContext")
        {

        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Repair> Repairs { get; set; }
        public DbSet<Mechanic> Mechanics { get; set; }

    }
}
