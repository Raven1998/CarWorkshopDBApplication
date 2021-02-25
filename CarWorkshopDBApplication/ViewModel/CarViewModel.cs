using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWorkshopDBDataAccess;
using CarWorkshopDBDataAccess.Repositories;
using CarWorkshopDBModels;
using Prism.Commands;

namespace CarWorkshopDBApplication.ViewModel
{
    public class CarViewModel : Base.VievModelBase
    {
        private readonly IDBRepository _clientRepository;
        private Car _car = new Car();
        private ObservableCollection<Car> cars = new ObservableCollection<Car>();

        public CarViewModel(IDBRepository clientRepository)
        {
            _clientRepository = clientRepository;
            cars = _clientRepository.GetCars();
        }

        public ObservableCollection<Car> Cars
        {
            get { return cars; }
            set 
            { 
                cars = value;
                NotifyPropertyChanged();
            }
        }

        public Car CurrentCar
        {
            get => _car;
            set
            {
                _car = value;
                NotifyPropertyChanged("Cars");
            }

        }
        public DelegateCommand SaveCommand { get; set; }
        protected override void RegisterCommands()
        {
            SaveCommand = new DelegateCommand(Save);
        }

        private void Save()
        {
            _clientRepository.AddCarToClient(CurrentCar, CurrentCar.ClientRefID);
            Cars = _clientRepository.GetCars();
        }

        private DelegateCommand<Car> _deleteRowCommand;
        public DelegateCommand<Car> DeleteRowCommand =>
            _deleteRowCommand ?? (_deleteRowCommand = new DelegateCommand<Car>(DeleteRow));

        private void DeleteRow(Car parameter)
        {
            _clientRepository.RemoveCar(parameter.ID);
            Cars = _clientRepository.GetCars();
        }
    }
}
