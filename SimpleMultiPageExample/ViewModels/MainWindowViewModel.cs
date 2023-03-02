using ReactiveUI;
using SimpleMultiPageExample.ViewModels.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SimpleMultiPageExample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private object content;
        private ObservableCollection<ViewModelBase> vmbaseCollection;

        public MainWindowViewModel()
        {
            vmbaseCollection = new ObservableCollection<ViewModelBase>();
            vmbaseCollection.Add(new WelcomeViewModel());
            vmbaseCollection.Add(new AuthorizationViewModel());

            Content = vmbaseCollection[0];

        }

        public object Content
        {
            get => content;
            set
            {
                this.RaiseAndSetIfChanged(ref content, value);
            }
        }

        public ObservableCollection<ViewModelBase> VmbaseCollection
        {
            get => vmbaseCollection;
            set
            {
                this.RaiseAndSetIfChanged(ref vmbaseCollection, value);
            }
        }

    }
}
