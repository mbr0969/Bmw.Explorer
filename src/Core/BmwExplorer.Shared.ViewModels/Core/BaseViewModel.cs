using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BmwExplorer.Shared.ViewModels {

    public class BaseViewModel : INotifyPropertyChanged {
            #region event
            public event PropertyChangedEventHandler PropertyChanged;
            #endregion

            #region Protected Methods
            protected virtual void OnPropertyChanged([CallerMemberName] string propertyname = null) {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
            }
            #endregion

        }

    
}
