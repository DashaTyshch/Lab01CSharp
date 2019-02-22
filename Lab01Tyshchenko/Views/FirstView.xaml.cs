using Lab01Tyshchenko.Models;
using Lab01Tyshchenko.ViewModels;
using System.Windows.Controls;

namespace Lab01Tyshchenko.Views
{
    /// <summary>
    /// Логика взаимодействия для FirstView.xaml
    /// </summary>
    public partial class FirstView : UserControl
    {
        public FirstView(Storage storage)
        {
            InitializeComponent();
            FirstViewModel viewModel = new FirstViewModel(storage);
            DataContext = viewModel;
        }
    }
}
