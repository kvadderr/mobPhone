using MobPhone.Popups;
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
    public partial class Profile : ContentView
    {

        bool isHidden = false;

        public Profile()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Achievements achievements = new Achievements();
            var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
            frame.Content = achievements;
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            Raiting raiting = new Raiting();
            var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
            frame.Content = raiting;
        }

        private void viewHiddenLayout(object sender, EventArgs e)
        {
            if (isHidden)
            {
                hidden_layout.IsVisible = true;
                viewAll.Text = "Свернуть";
            } else
            {
                hidden_layout.IsVisible = false;
                viewAll.Text = "Показать больше";
            }
            isHidden = !isHidden;
        }

        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new PopupFilter());
        }

        private void goHome(object sender, EventArgs e)
        {
            var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
            Home home = new Home();
            frame.Content = home;
        }
    }
}