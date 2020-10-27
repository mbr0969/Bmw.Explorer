using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Input;

namespace BmwExplorer.Shared.ViewModels {
    public class MainViewModel : BaseViewModel {

        #region Public Propertes           
        public string FileePath { get; set; }
        public ObservableCollection<FileEntityViewModel> DirectoryAndFiles { get; set; } = new ObservableCollection<FileEntityViewModel>();
        public FileEntityViewModel SelectedFileEntity {get;set;}
        #endregion

        #region Commands
        public ICommand OpenCommand { get; }
        #endregion

        #region Constructor
        public MainViewModel() {

            OpenCommand = new DelegateCommand(Open);

            foreach (var logicalDrive in  Directory.GetLogicalDrives()) {                 
                DirectoryAndFiles.Add(new DirectoryViewModel(logicalDrive));
            }
        }
        #endregion

       

        #region Commads Methods
        private void Open(object parameter){ 
            if(parameter is DirectoryViewModel directoryViewModel) { 
                
                FileePath = directoryViewModel.FullName;  
                DirectoryAndFiles.Clear();

                var directoryInfo = new DirectoryInfo(FileePath);

                foreach (var directory in directoryInfo.GetDirectories()) {
                    DirectoryAndFiles.Add(new DirectoryViewModel(directory));
                }

                foreach (var fileInfo in directoryInfo.GetFiles()) {
                    DirectoryAndFiles.Add(new FileViewModel(fileInfo));
                }
            }
        }


            
        #endregion
    }
}
