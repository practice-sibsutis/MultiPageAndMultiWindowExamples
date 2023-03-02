using Microsoft.CodeAnalysis.CSharp.Syntax;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using TODOListApplicationExample.Models;

namespace TODOListApplicationExample.ViewModels.Pages
{
    public class AddItemViewModel : ViewModelBase
    {
        private string header;
        public string Header
        {
            get => header; set
            {
                this.RaiseAndSetIfChanged(ref header, value);
            }
        }
        public string Body { get; set; }

        public AddItemViewModel()
        {
            Header = string.Empty;
            Body = string.Empty;

            IObservable<bool> isOkEnable = this.WhenAnyValue(
                addItemViewModel => addItemViewModel.Header,
                addItemViewModel => !string.IsNullOrWhiteSpace(addItemViewModel));

            OkCommand = ReactiveCommand.Create<Unit, TodoItem>(
                _ => new TodoItem { Header = Header, Body = Body, IsChecked = false },
                isOkEnable);

            CancelCommand = ReactiveCommand.Create(() => { });
        }

        public ReactiveCommand<Unit, TodoItem> OkCommand { get; }

        public ReactiveCommand<Unit, Unit> CancelCommand { get; }
    }
}
