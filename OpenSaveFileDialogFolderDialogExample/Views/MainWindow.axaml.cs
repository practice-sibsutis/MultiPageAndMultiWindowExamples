using Avalonia.Controls;
using Avalonia.Interactivity;
using OpenSaveFileDialogFolderDialogExample.ViewModels;

namespace OpenSaveFileDialogFolderDialogExample.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void OpenFileDialogButtonClick(object sender, RoutedEventArgs routedEventArgs)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.AllowMultiple = true;
            string[]? result = await openFileDialog.ShowAsync(this);

            if (DataContext is MainWindowViewModel dataContext)
            {
                if (result != null)
                {
                    dataContext.Path = string.Join(';', result);
                }
                else
                {
                    dataContext.Path = "Dialog was canceled";
                }
            }
        }

        private async void SaveFileDialogButtonClick(object sender, RoutedEventArgs routedEventArgs)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string? result = await saveFileDialog.ShowAsync(this);

            if (DataContext is MainWindowViewModel dataContext)
            {
                if (result != null)
                {
                    dataContext.Path = result;
                }
                else
                {
                    dataContext.Path = "Dialog was canceled";
                }
            }
        }

        private async void OpenFolderDialogButtonClick(object sender, RoutedEventArgs routedEventArgs)
        {
            OpenFolderDialog openFolderDialog = new OpenFolderDialog();
            string? result = await openFolderDialog.ShowAsync(this);

            if (DataContext is MainWindowViewModel dataContext)
            {
                if (result != null)
                {
                    dataContext.Path = result;
                }
                else
                {
                    dataContext.Path = "Dialog was canceled";
                }
            }
        }
    }
}
