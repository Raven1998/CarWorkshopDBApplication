using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CarWorkshopDBApplication.ViewModel.Base
{
    /// <summary>
    /// Class includes ViewModel methods required in all ViewModels
    /// </summary>
    public abstract class VievModelBase : INotifyPropertyChanged
    {
        protected VievModelBase()
        {
            RegisterCommands();
            RegisterCollections();
        }
        protected virtual void RegisterCommands()
        {

        }

        protected virtual void RegisterCollections() { }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
