using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobPhone.Model
{

    class Profile : INotifyPropertyChanged
    {
        private string fio;
        public string FIO
        {
            get => fio;
            set
            {
                if (fio != value)
                {
                    fio = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Position { get; set; }

        private bool visiblePosition;
        public bool isVisiblePosition
        {
            get => visiblePosition;
            set
            {
                if (visiblePosition != value)
                {
                    visiblePosition = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool visibleChecked;
        public bool isVisibleChecked {
            get => visibleChecked;
            set
            {
                if (visibleChecked != value)
                {
                    visibleChecked = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand ItemSelectedCommand { get; set; }

        private void OnItemSelected()
        {
            isVisiblePosition = !isVisiblePosition;
            isVisibleChecked = !isVisibleChecked;
        }

        public Profile()
        {
            ItemSelectedCommand = new Command(OnItemSelected);
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
