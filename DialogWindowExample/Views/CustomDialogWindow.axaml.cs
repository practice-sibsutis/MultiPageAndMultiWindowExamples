using Avalonia.Controls;
using Avalonia.Interactivity;

namespace DialogWindowExample.Views
{
    public partial class CustomDialogWindow : Window
    {
        public CustomDialogWindow()
        {
            InitializeComponent();
        }

        private void OkBittonClick(object sender, RoutedEventArgs routedEventArgs)
        {
            Close("Ok!");
        }
    }
}
