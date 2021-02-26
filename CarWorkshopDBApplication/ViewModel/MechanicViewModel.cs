using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWorkshopDBModels;
using CarWorkshopDBDataAccess;
using Prism.Commands;
using System.Collections.ObjectModel;
using CarWorkshopDBDataAccess.Repositories;

namespace CarWorkshopDBApplication.ViewModel
{
    /// <summary>
    /// Mechanic ViewModel class
    /// Contains biding commands for Mechanic Window
    /// </summary>
    public class MechanicViewModel : Base.VievModelBase
    {
        private readonly IDBRepository _clientRepository;
        private Mechanic _mechanic = new Mechanic();
        private ObservableCollection<Mechanic> mechanics = new ObservableCollection<Mechanic>();

        public MechanicViewModel(IDBRepository clientRepository)
        {
            _clientRepository = clientRepository;
            mechanics = _clientRepository.GetMechanics();
        }

        public ObservableCollection<Mechanic> Mechanics
        {
            get { return mechanics; }
            set
            {
                mechanics = value;
                NotifyPropertyChanged("Mechanics");
            }
        }

        public Mechanic CurrentMechanic
        {
            get => _mechanic;
            set
            {
                _mechanic = value;
                NotifyPropertyChanged("Mechanics");
            }

        }
        public DelegateCommand SaveCommand { get; set; }


        private void Save()
        {
            _clientRepository.AddMechanic(CurrentMechanic);
            Mechanics = _clientRepository.GetMechanics();
        }

        protected override void RegisterCommands()
        {
            SaveCommand = new DelegateCommand(Save);
        }

        private DelegateCommand<Mechanic> _deleteRowCommand;
        public DelegateCommand<Mechanic> DeleteRowCommand =>
            _deleteRowCommand ?? (_deleteRowCommand = new DelegateCommand<Mechanic>(DeleteRow));

        private void DeleteRow(Mechanic parameter)
        {
            _clientRepository.RemoveMechanic(parameter.ID);
            Mechanics = _clientRepository.GetMechanics();
        }
    }
}
