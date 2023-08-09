using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobPhone
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private bool isOpenCustom;
        private bool isOpenSelect;
        public ICommand ClickCommand => new Command<string>(ClickCommandExecute);

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsOpenCustom
        {
            get => isOpenCustom;
            set => SetAndRaisePropertyChanged(ref isOpenCustom, value);
        }
        public bool IsOpenSelect
        {
            get => isOpenSelect;
            set => SetAndRaisePropertyChanged(ref isOpenSelect, value);
        }
        private void ClickCommandExecute(string parameter)
        {
            switch (parameter)
            {
                case "2":
                    IsOpenSelect = true;
                    break;
                case "3":
                    IsOpenCustom = true;
                    break;

            }
        }

        protected void SetAndRaisePropertyChanged<TRef>(
           ref TRef field, TRef value, [CallerMemberName] string propertyName = null)
                {
                    field = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                }

        protected void SetAndRaisePropertyChangedIfDifferentValues<TRef>(
            ref TRef field, TRef value, [CallerMemberName] string propertyName = null)
            where TRef : class
        {
            if (field == null || !field.Equals(value))
            {
                SetAndRaisePropertyChanged(ref field, value, propertyName);
            }
        }
    }
}
