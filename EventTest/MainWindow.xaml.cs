using System;
using System.Windows;

namespace EventTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _mainViewModel = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = _mainViewModel;
        }

        private void RadioButtonCheckedChanged(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
