using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using TODOListApplicationExample.Models;
using System.Reactive;
using ReactiveUI;
using System.Reactive.Linq;

namespace TODOListApplicationExample.ViewModels.Pages
{
    public class TODOListViewModel : ViewModelBase
    {
        private ObservableCollection<TodoItem> todoItemCollection;

        public TODOListViewModel()
        {
            TodoItemCollection = new ObservableCollection<TodoItem>();
        }

        public ObservableCollection<TodoItem> TodoItemCollection
        {
            get => todoItemCollection;
            set
            {
                this.RaiseAndSetIfChanged(ref todoItemCollection, value);
            }
        }
    }
}
