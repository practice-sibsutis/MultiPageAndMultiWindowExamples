using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using TODOListApplicationExample.Models;
using TODOListApplicationExample.ViewModels.Pages;

namespace TODOListApplicationExample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private TODOListViewModel todoListViewModel;
        private ViewModelBase content;


        public MainWindowViewModel()
        {
            Content = todoListViewModel = new TODOListViewModel();

            AddCommand = ReactiveCommand.Create(() =>
            {
                AddItemViewModel viewModel = new AddItemViewModel();



                Observable.Merge(
                    viewModel.OkCommand,
                    viewModel.CancelCommand.Select(_ => (TodoItem)null))
                .Take(1)
                .Subscribe(todoItem =>
                {
                    if (todoItem != null)
                    {
                        todoListViewModel.TodoItemCollection.Add(todoItem);
                    }

                    Content = todoListViewModel;
                });

                Content = viewModel;
            });

            

            
        }

        public ReactiveCommand<Unit, Unit> AddCommand { get; }

        public ViewModelBase Content
        {
            get => content;
            set
            {
                this.RaiseAndSetIfChanged(ref content, value);
            }
        }
    }
}
