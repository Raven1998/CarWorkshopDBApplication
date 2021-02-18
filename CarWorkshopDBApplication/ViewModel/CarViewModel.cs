using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWorkshopDBDataAccess;
using CarWorkshopDBModels;
using Prism.Commands;

namespace CarWorkshopDBApplication.ViewModel
{
    public class CarViewModel : Base.VievModelBase
    {
        private readonly CarWorkshopDBContext _context;
        private Car _car;
        public CarViewModel(CarWorkshopDBContext context)
        {
            _context = context;
            Car = new Car();
        }


        public string Title { get; set; } = "CarWorkshopDatabase";

        public Car Car
        {
            get => _car;
            set
            {
                _car = value;
                NotifyPropertyChanged();
            }

        }
        public DelegateCommand SaveCommand { get; set; }
        protected override void RegisterCommands()
        {
            SaveCommand = new DelegateCommand(Save);
        }

        private void Save()
        {
            _context.Cars.Add(Car);
            _context.SaveChanges();
        }
    }
}
