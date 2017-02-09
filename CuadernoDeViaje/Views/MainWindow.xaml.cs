using System.Windows;
using CuadernoDeViaje.ViewModels;

namespace CuadernoDeViaje.Views
{
     public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
