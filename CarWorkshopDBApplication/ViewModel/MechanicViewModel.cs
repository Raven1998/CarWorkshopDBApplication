using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWorkshopDBModels;
using CarWorkshopDBDataAccess;
using Prism.Commands;

namespace CarWorkshopDBApplication.ViewModel
{
    public class MechanicViewModel : Base.VievModelBase
    {
        private readonly CarWorkshopDBContext _context;
        private Mechanic _mechanic;
        public MechanicViewModel(CarWorkshopDBContext context)
        {
            _context = context;
            Mechanic = new Mechanic();
        }


        public string Title { get; set; } = "CarWorkshopDatabase";

        public Mechanic Mechanic
        {
            get => _mechanic;
            set
            {
                _mechanic = value;
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
            _context.Mechanics.Add(Mechanic);
            _context.SaveChanges();
        }
    }
}
