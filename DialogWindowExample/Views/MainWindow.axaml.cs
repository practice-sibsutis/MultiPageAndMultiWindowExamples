using Avalonia.Controls;
using Avalonia.Interactivity;

namespace DialogWindowExample.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public async void ShowCustomDialogWindow(object sender, RoutedEventArgs routedEventArgs)
        {
            CustomDialogWindow customDialogWindow = new CustomDialogWindow();
            var result = await customDialogWindow.ShowDialog<string>(this);

            ((Button)sender).Content = result;
        }
    }
}
