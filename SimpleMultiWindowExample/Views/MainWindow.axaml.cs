using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using SimpleMultiWindowExample.Views.ChildWindows;
using System;

namespace SimpleMultiWindowExample.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowChildWindow(object sender, RoutedEventArgs arg)
        {
            ChildWindow1 childwindow = new ChildWindow1();

            childwindow.Show();
        }

        private void CloseButtonClick(object sender, RoutedEventArgs routedEventArgs)
        {
            this.Close();
        }
    }
}
