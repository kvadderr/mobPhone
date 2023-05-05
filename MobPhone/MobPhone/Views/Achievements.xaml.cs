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
    public partial class Achievements : ContentView
    {
        public Achievements()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
            frame.Content = profile;
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new PopupOpenAchievements());
            Navigation.ShowPopup(new PopupAchievementsConfirm());
            Navigation.ShowPopup(new PopupSendAchievements());
        }
    }
}