using Lab01Tyshchenko.Manager;
using System;

namespace Lab01Tyshchenko.Models
{
    class MainModel
    {
        private readonly Storage _storage;

        public event Action<Info> UIInfoChanged;

        public MainModel(Storage storage)
        {
            _storage = storage;
            storage.InfoChanged += OnInfoChanged;
        }

        private void OnInfoChanged(Info info)
        {
            UIInfoChanged?.Invoke(info);
        }

        public void ShowFirstWindow()
        {
            NavigationManager.Instance.Navigate(ModesEnum.First);
        }

    }
}
