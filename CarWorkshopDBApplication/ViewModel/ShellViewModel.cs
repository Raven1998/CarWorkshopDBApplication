using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismMVVMLibrary;
using CarWorkshopDBApplication.ViewModel.Base;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CarWorkshopDBApplication.Views;
using Prism.Commands;
using CarWorkshopDBDataAccess;
using CarWorkshopDBModels;
using System.Collections.ObjectModel;
using CarWorkshopDBDataAccess.Repositories;

namespace CarWorkshopDBApplication.ViewModel
{
    /// <summary>
    /// Client ViewModel class
    /// Contains biding commands for Client Window
    /// </summary>
    public class ShellViewModel : Base.VievModelBase
    {
        private readonly IDBRepository _clientRepository;
        private Client _client = new Client();
        private ObservableCollection<Client> clients = new ObservableCollection<Client>();

        public ShellViewModel(IDBRepository  clientRepository)
        {
            _clientRepository = clientRepository;
            clients = _clientRepository.GetClients();
        }


        public string Title { get; set; } = "CarWorkshopDatabase";

        public ObservableCollection<Client> Clients
        {
            get { return clients; }
            set 
            {
                clients = value;
                NotifyPropertyChanged("Clients");
            }
        }

        public Client CurrentClient
        {
            get => _client;
            set
            {
                _client = value;
                NotifyPropertyChanged("Clients");
            }
        
        }
        public DelegateCommand SaveCommand { get; set; }
        protected override void RegisterCommands()
        {
            SaveCommand = new DelegateCommand(Save);
        }

        private void Save()
        {
            _clientRepository.AddClient(CurrentClient);
            Clients = _clientRepository.GetClients();
        }

        private DelegateCommand<Client> _deleteRowCommand;
        public DelegateCommand<Client> DeleteRowCommand =>
            _deleteRowCommand ?? (_deleteRowCommand = new DelegateCommand<Client>(DeleteRow));

        private void DeleteRow(Client parameter)
        {
            _clientRepository.RemoveClient(parameter.ID);
            Clients = _clientRepository.GetClients();
        }
    }
}
