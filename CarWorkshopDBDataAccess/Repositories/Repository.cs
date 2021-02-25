using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWorkshopDBModels;

namespace CarWorkshopDBDataAccess.Repositories
{
    public class Repository : IDBRepository
    {
        private readonly CarWorkshopDBContext _context;

        public Repository(CarWorkshopDBContext context)
        {
            _context = context;
        }
        
        public ObservableCollection<Client> GetClients()
        {
            var result = new ObservableCollection<Client>();
            foreach (var client in _context.Clients.ToList())
            {
                result.Add(client);
            }
            return result;
        }

        public void AddClient(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
        }

        public void RemoveClient(int clientId)
        {
            var client = _context.Clients.FirstOrDefault(c => c.ID == clientId);
            if(client != null)
            {
                _context.Clients.Remove(client);
                _context.SaveChanges();
            }
        }

        public ObservableCollection<Car> GetCars()
        {
            var result = new ObservableCollection<Car>();
            foreach (var car in _context.Cars.ToList())
            {
                result.Add(car);
            }
            return result;
        }

        public void AddCarToClient(Car car, int clientId)
        {
            var client = _context.Clients.FirstOrDefault(c => c.ID == clientId);
            if (client != null)
            {
                car.Client = client;
                _context.Cars.Add(car);
                _context.SaveChanges();
            }
        }

        public void AddCarToRepair(Car car, int repairId)
        {
            var repair = _context.Repairs.FirstOrDefault(r => r.ID == repairId);
            if (repair != null && repair.Car == null)
            {
                repair.Car = car;
                repair.CarRefID = car.ID;
                _context.Repairs.Add(repair);
                _context.SaveChanges();
            }
        }

        public void RemoveCar(int carId)
        {
            var car = _context.Cars.FirstOrDefault(c => c.ID == carId);
            if (car != null)
            {
                _context.Cars.Remove(car);
                _context.SaveChanges();
            }
        }

        public void AddMechanicToRepair(Mechanic mechanic, int repairId)
        {
            var repair = _context.Repairs.FirstOrDefault(r => r.ID == repairId);
            if (repair != null && repair.Mechanic == null)
            {
                repair.Mechanic = mechanic;
                _context.SaveChanges();
            }
        }

        public ObservableCollection<Repair> GetRepairs()
        {
            var result = new ObservableCollection<Repair>();
            foreach(var repair in _context.Repairs.ToList())
            {
                result.Add(repair);
            }
            return result;
        }

        public void AddRepair(Repair repair)
        {
            _context.Repairs.Add(repair) 
            _context.SaveChanges();
        }

        public void RemoveRepair(int repairId)
        {
            var repair = _context.Repairs.FirstOrDefault(r => r.ID == repairId);
            if (repair != null)
            {
                _context.Repairs.Remove(repair);
                _context.SaveChanges();
            }
        }

        public ObservableCollection<Mechanic> GetMechanics()
        {
            var result = new ObservableCollection<Mechanic>();
            foreach (var mechanic in _context.Mechanics.ToList())
            {
                result.Add(mechanic);
            }
            return result;
        }

        public void AddMechanic(Mechanic mechanic)
        {
            _context.Mechanics.Add(mechanic);
            _context.SaveChanges();
        }

        public void RemoveMechanic(int mechanicId)
        {
            var mechanic = _context.Mechanics.FirstOrDefault(m => m.ID == mechanicId);
            if (mechanic != null)
            {
                _context.Mechanics.Remove(mechanic);
                _context.SaveChanges();
            }
        }
    }
    
}
