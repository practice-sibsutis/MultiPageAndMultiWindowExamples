using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSaveFileDialogFolderDialogExample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string path;
        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref path, value);
            }
        }
    }
}
