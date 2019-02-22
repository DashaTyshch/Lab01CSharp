using Lab01Tyshchenko.Views;
using Lab01Tyshchenko.Windows;
using System;

namespace Lab01Tyshchenko.Models
{
    public enum ModesEnum
    {
        Main,
        First
    }

    class NavigationModel
    {
        private ContentWindow _contentWindow;
        private MainView _mainView;
        private FirstView _firstView;

        public NavigationModel(ContentWindow contentWindow, Storage storage)
        {
            _contentWindow = contentWindow;
            _firstView = new FirstView(storage);
            _mainView = new MainView(storage);
        }

        public void Navigate(ModesEnum mode)
        {
            switch (mode)
            {
                case ModesEnum.Main:
                    _contentWindow.ContentControl.Content = _mainView;
                    break;
                case ModesEnum.First:
                    _contentWindow.ContentControl.Content = _firstView;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
        }
    }
}
