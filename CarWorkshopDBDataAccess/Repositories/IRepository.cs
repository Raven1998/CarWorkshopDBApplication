using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWorkshopDBModels;

namespace CarWorkshopDBDataAccess.Repositories
{
    public interface IDBRepository
    {

        ObservableCollection<Client> GetClients();
        void AddClient(Client client);
        ObservableCollection<Car> GetCars();
        void AddCarToClient(Car car, int clientId);
        void AddCarToRepair(Car car, int repairId);
        void AddMechanicToRepair(Mechanic mechanic, int repairId);
        ObservableCollection<Repair> GetRepairs();
        void AddRepair(Repair repair);
        ObservableCollection<Mechanic> GetMechanics();
        void AddMechanic(Mechanic mechanic);

    }
}
