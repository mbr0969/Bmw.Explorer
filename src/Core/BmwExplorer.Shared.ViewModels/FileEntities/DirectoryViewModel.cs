using System.IO;

namespace BmwExplorer.Shared.ViewModels
{
    public sealed class DirectoryViewModel : FileEntityViewModel {
      //  public DirectoryInfo Directory { get; }

        

        public DirectoryViewModel(string directoryName) : base(directoryName) {
            FullName = directoryName;
        }

        public DirectoryViewModel(DirectoryInfo directory) :base(directory.Name) {
            FullName = directory.FullName;
        }

       
    }
}
