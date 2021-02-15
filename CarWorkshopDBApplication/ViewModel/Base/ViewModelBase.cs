using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CarWorkshopDBApplication.ViewModel.Base
{
    public abstract class VievModelBase : INotifyPropertyChanged
    {
        protected VievModelBase()
        {
            RegisterCommands();
        }
        protected virtual void RegisterCommands()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
