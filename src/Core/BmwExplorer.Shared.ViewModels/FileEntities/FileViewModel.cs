﻿using System.IO;

namespace BmwExplorer.Shared.ViewModels
{
    public sealed class FileViewModel : FileEntityViewModel {


        public FileViewModel(string name) :base(name) {}
        public FileViewModel(FileInfo fileInfo) :base(fileInfo.Name) {
            FullName = fileInfo.FullName;
        }
    }
}
