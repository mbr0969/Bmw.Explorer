using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmwExplorer.Shared.ViewModels
{
    public abstract class FileEntityViewModel : BaseViewModel {
        public string Name { get; }
        public string FullName { get; set; }
        protected FileEntityViewModel(string _name) {
            Name = _name;
        }
    }
}
