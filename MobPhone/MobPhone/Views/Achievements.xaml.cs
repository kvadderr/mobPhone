using MobPhone.Popups;
using MobPhone.Views.destination;
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
            
            var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
            if (App.isDestination == true)
            {
                DestinationMenu destinationMenu = new DestinationMenu();
                frame.Content = destinationMenu;
            } else
            {
                Profile profile = new Profile();
                frame.Content = profile;
            }
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            if (App.isDestination == true)
            {
                var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
                CreateAchievements destinationMenu = new CreateAchievements();
                frame.Content = destinationMenu;
            } else
            {
                Navigation.ShowPopup(new PopupOpenAchievements());
                Navigation.ShowPopup(new PopupAchievementsConfirm());
                Navigation.ShowPopup(new PopupSendAchievements());
            }
                
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            if (App.isDestination == true)
            {
                Navigation.ShowPopup(new PopupSendSimpleAchievements());
                Navigation.ShowPopup(new PopupSendSimpleAchievementsDouble());
                Navigation.ShowPopup(new PopupSendSimpleAchievementsThree());
                Navigation.ShowPopup(new PopupAchievementsConfirm());
                var myCommand = App.ViewModel.ClickCommand;
                Device.BeginInvokeOnMainThread(() =>
                {
                    myCommand.Execute("2");
                });
            }
        }
    }
}