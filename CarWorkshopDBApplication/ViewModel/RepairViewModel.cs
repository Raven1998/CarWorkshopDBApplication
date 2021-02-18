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
    public class RepairViewModel : Base.VievModelBase
    {
        private readonly CarWorkshopDBContext _context;
        private Repair _repair;
        public RepairViewModel(CarWorkshopDBContext context)
        {
            _context = context;
            Repair = new Repair();
        }


        public string Title { get; set; } = "CarWorkshopDatabase";

        public Repair Repair
        {
            get => _repair;
            set
            {
                _repair = value;
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
            _context.Repairs.Add(Repair);
            _context.SaveChanges();
        }
    }
}
