using Lab01Tyshchenko.Models;
using Lab01Tyshchenko.Tools;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace Lab01Tyshchenko.ViewModels
{
    class FirstViewModel : INotifyPropertyChanged
    {
        public FirstModel m_model { get; private set; }

        private DateTime _date;
        private ICommand _dateCommand;

        public FirstViewModel(Storage storage)
        {
            m_model = new FirstModel(storage);
            _date = DateTime.Today.Date;
        }

        public DateTime Date
        {
            get { return _date; }
            set
            {
                if (_date != value)
                {
                    _date = value;
                    InvokePropertyChanged("Date");
                }
            }
        }

        public ICommand DateCommand
        {
            get
            {
                if (_dateCommand == null)
                {
                    _dateCommand = new RelayCommand<object>(DateExecute, DateCanExecute);
                }
                return _dateCommand;
            }
            set
            {
                _dateCommand = value;
                InvokePropertyChanged("DateCommand");
            }
        }

        private void DateExecute(object obj)
        {
            m_model.CheckDate(Date);
        }

        private bool DateCanExecute(object obj)
        {
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void InvokePropertyChanged(string propertyName)
        {
            var e = new PropertyChangedEventArgs(propertyName);
            PropertyChanged?.Invoke(this, e);
        }
    }
}
