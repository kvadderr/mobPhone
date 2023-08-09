using MobPhone.Popups;
using MobPhone.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MobPhone
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            App.ViewModel = new MainViewModel();
            BindingContext = App.ViewModel;
            Home home = new Home();
            myFrame.Content = home;
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (!CustomBottomSheet.IsInitiated)
            {
                CustomBottomSheet.Init(height, width);
            }
            if (!SelectProfileSheet.IsInitiated)
            {
                SelectProfileSheet.Init(height, width);
            }

        }


        private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            App.ViewModel.IsOpenCustom = false;
            App.ViewModel.IsOpenSelect = false;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new PopupSelectAdress());
        }
    }
}
