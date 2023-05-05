﻿using MobPhone.Popups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobPhone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class News : ContentView
    {
        public News()
        {
            InitializeComponent();
        }

        private void goHome(object sender, EventArgs e)
        {
            var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
            Home home = new Home();
            frame.Content = home;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new PopupNews());
        }
    }
}