using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWorkshopDBApplication.Views;
using Prism.Commands;
using CarWorkshopDBDataAccess;

namespace CarWorkshopDBApplication.ViewModel
{
    public class MainWindowViewModel : Base.VievModelBase
    {
        public MainWindowViewModel()
        {
            OpenDatabaseExplorerCommand = new DelegateCommand(OpenDatabaseExplorer);
            OpenGitRepoCommand = new DelegateCommand(OpenGitRepo);
            ExitCommand = new DelegateCommand(Exit);
            
        }


        public string Title { get; set; } = "CarWorkshopDatabase";

        public DelegateCommand OpenDatabaseExplorerCommand { get; set; }
        public DelegateCommand OpenGitRepoCommand { get; set; }
        public DelegateCommand ExitCommand { get; set; }
       

        public void OpenDatabaseExplorer()
        {
            CarWorkshopDBContext context = new CarWorkshopDBContext();

            ShellViewModel viewModel = new ShellViewModel(context);
            Shell s1 = new Shell(viewModel);
            s1.Show();

            CarViewModel viewModel1 = new CarViewModel(context);
            CarsWindow c1 = new CarsWindow(viewModel1);
            c1.Show();

            RepairViewModel viewModel2 = new RepairViewModel(context);
            RepairsWindow r1 = new RepairsWindow(viewModel2);
            r1.Show();

            MechanicViewModel viewModel3 = new MechanicViewModel(context);
            MechanicsWindow m1 = new MechanicsWindow(viewModel3);
            m1.Show();

        }

        public void OpenGitRepo()
        {

            System.Diagnostics.Process.Start("https://github.com/Raven1998/CarWorkshopDBApplication");

        }

        public void Exit()
        {

            //TO DO CLOSE BUTTON IN MVVM

        }

      
    }
}
