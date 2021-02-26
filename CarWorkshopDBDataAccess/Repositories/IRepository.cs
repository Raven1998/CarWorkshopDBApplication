using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWorkshopDBModels;

namespace CarWorkshopDBDataAccess.Repositories
{
    /// <summary>
    /// This interface includes declaration of all used repository methods in Database
    /// </summary>
    public interface IDBRepository
    {

        ObservableCollection<Client> GetClients();
        void AddClient(Client client);
        void RemoveClient(int clientId);
        ObservableCollection<Car> GetCars();
        void AddCarToClient(Car car, int clientId);
        void AddCarToRepair(Car car, int repairId);
        void RemoveCar(int carId);
        void AddMechanicToRepair(Mechanic mechanic, int repairId);
        ObservableCollection<Repair> GetRepairs();
        void AddRepair(Repair repair);
        void RemoveRepair(int repairId);
        ObservableCollection<Mechanic> GetMechanics();
        void AddMechanic(Mechanic mechanic);
        void RemoveMechanic(int mechanicId);

    }
}
