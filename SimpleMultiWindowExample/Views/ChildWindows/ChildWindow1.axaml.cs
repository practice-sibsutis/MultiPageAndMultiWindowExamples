using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace SimpleMultiWindowExample.Views.ChildWindows
{
    public partial class ChildWindow1 : Window
    {
        public ChildWindow1()
        {
            InitializeComponent();
        }

        private void CloseButtonClick(object sender, RoutedEventArgs routedEventArgs)
        {
            this.Close();
        }
    }
}
