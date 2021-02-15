using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismMVVMLibrary;

namespace CarWorkshopDBApplication.ViewModel
{
    public class ShellViewModel : ViewModelBase
    {
        public ShellViewModel()
        {

        }


        public string Title { get; set; } = "CarWorkshopDatabase";

    }
}
