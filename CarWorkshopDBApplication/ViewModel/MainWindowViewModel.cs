using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWorkshopDBApplication.Views;
using Prism.Commands;
namespace CarWorkshopDBApplication.ViewModel
{
    public class MainWindowViewModel : Base.VievModelBase
    {
        public MainWindowViewModel()
        {
            OpenClientsCommand = new DelegateCommand(OpenClients);
            OpenCarsCommand = new DelegateCommand(OpenCars);
            OpenRepairsCommand = new DelegateCommand(OpenRepairs);
            OpenMechanicsCommand = new DelegateCommand(OpenMechanics);
        }


        public string Title { get; set; } = "CarWorkshopDatabase";

        public DelegateCommand OpenClientsCommand { get; set; }
        public DelegateCommand OpenCarsCommand { get; set; }
        public DelegateCommand OpenRepairsCommand { get; set; }
        public DelegateCommand OpenMechanicsCommand { get; set; }

        public void OpenClients()
        {

            ShellViewModel viewModel = new ShellViewModel();
            Shell s1 = new Shell(viewModel);
            s1.Show();

        }

        public void OpenCars()
        {

            ShellViewModel viewModel = new ShellViewModel();
            Shell s1 = new Shell(viewModel);
            s1.Show();

        }

        public void OpenRepairs()
        {

            ShellViewModel viewModel = new ShellViewModel();
            Shell s1 = new Shell(viewModel);
            s1.Show();

        }

        public void OpenMechanics()
        {

            ShellViewModel viewModel = new ShellViewModel();
            Shell s1 = new Shell(viewModel);
            s1.Show();

        }
    }
}
