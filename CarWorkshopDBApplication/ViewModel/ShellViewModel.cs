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


namespace CarWorkshopDBApplication.ViewModel
{
    public class ShellViewModel : Base.VievModelBase
    {
        private readonly CarWorkshopDBContext _context;
        private Client _client;
        public ShellViewModel(CarWorkshopDBContext context)
        {
            _context = context;
            Client = new Client();
        }


        public string Title { get; set; } = "CarWorkshopDatabase";

        public Client Client
        {
            get => _client;
            set
            {
                _client = value;
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
            _context.Clients.Add(Client);
            _context.SaveChanges();
        }
    }
}
