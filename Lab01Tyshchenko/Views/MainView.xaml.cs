using Lab01Tyshchenko.Models;
using Lab01Tyshchenko.ViewModels;
using System.Windows.Controls;

namespace Lab01Tyshchenko.Views
{
    /// <summary>
    /// Логика взаимодействия для MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView(Storage storage)
        {
            InitializeComponent();
            MainViewModel viewModel = new MainViewModel(storage);
            DataContext = viewModel;
        }
    }
}
