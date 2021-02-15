using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Prism.Ioc;

namespace CarWorkshopDBApplication.Startup
{
    public class Bootstrapper : Prism.Unity.PrismBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            // return Container.Resolve<Views.Shell>();
            return Container.Resolve<Views.MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void InitializeShell(DependencyObject shell)
        {
            Application.Current.MainWindow.Show();
        }
    }
}

