using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BmwExplorer.Shared.ViewModels {
    public class MainViewModel : INotifyPropertyChanged {
        #region Public Propertes
        public string MainDiskName { get;set;}
        #endregion

        #region event
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Constructor
        public MainViewModel() {
            MainDiskName = Environment.SystemDirectory;
        }
        #endregion

        #region Protected Methods
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyname = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
        #endregion
    }
}
