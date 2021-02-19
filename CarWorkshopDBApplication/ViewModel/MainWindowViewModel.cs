using CarWorkshopDBApplication.Views;
using Prism.Commands;
using CarWorkshopDBDataAccess;
using CarWorkshopDBDataAccess.Repositories;
using CarWorkshopDBModels;
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
            Repository clientRepository = new Repository(context);
            
            ShellViewModel viewModel = new ShellViewModel(clientRepository);
            Shell s1 = new Shell(viewModel);
            s1.Show();

            CarViewModel viewModel1 = new CarViewModel(clientRepository);
            CarsWindow c1 = new CarsWindow(viewModel1);
            c1.Show();

            RepairViewModel viewModel2 = new RepairViewModel(clientRepository);
            RepairsWindow r1 = new RepairsWindow(viewModel2);
            r1.Show();

            MechanicViewModel viewModel3 = new MechanicViewModel(clientRepository);
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
