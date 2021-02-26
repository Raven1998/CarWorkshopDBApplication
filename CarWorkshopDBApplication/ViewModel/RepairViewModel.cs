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
    /// <summary>
    /// Repair ViewModel class
    /// Contains biding commands for Repair Window
    /// </summary>
    public class RepairViewModel : Base.VievModelBase
    {
        private readonly IDBRepository _clientRepository;
        private Repair _repair = new Repair();
        private ObservableCollection<Repair> repairs = new ObservableCollection<Repair>();

        public RepairViewModel(IDBRepository clientRepository)
        {
            _clientRepository = clientRepository;
            repairs = _clientRepository.GetRepairs();
        }

        public ObservableCollection<Repair> Repairs
        {
            get { return repairs; }
            set
            {
                repairs = value;
                NotifyPropertyChanged("Repairs");
            }
        }

        public Repair CurrentRepair
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
            _clientRepository.AddRepair(CurrentRepair);
            Repairs = _clientRepository.GetRepairs();
        }

        private DelegateCommand<Repair> _deleteRowCommand;
        public DelegateCommand<Repair> DeleteRowCommand =>
            _deleteRowCommand ?? (_deleteRowCommand = new DelegateCommand<Repair>(DeleteRow));

        private void DeleteRow(Repair parameter)
        {
            _clientRepository.RemoveRepair(parameter.ID);
            Repairs = _clientRepository.GetRepairs();
        }
    }
}
