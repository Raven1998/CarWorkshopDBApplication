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

            ShellViewModel viewModel = new ShellViewModel();
            Shell s1 = new Shell(viewModel);
            s1.Show();

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
