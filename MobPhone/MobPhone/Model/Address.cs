using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobPhone.Model
{

    class Address : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
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
            isVisibleChecked = !isVisibleChecked;
        }

        public Address()
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
