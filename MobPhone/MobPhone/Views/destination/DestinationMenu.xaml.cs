using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobPhone.Views.destination
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DestinationMenu : ContentView
	{
		public DestinationMenu ()
		{
			InitializeComponent ();
            App.isDestination = true;
            BindingContext = App.ViewModel;
            taskBtn.PressedAction = () =>
            {
                var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
                CreateTask profile = new CreateTask();
                frame.Content = profile;
            };

            profileBtn.PressedAction = () =>
            {
                var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
                Achievements achievements = new Achievements();
                frame.Content = achievements;
            };

            smsBtn.PressedAction = () => {
                var myCommand = App.ViewModel.ClickCommand;
                Device.BeginInvokeOnMainThread(() =>
                {
                    myCommand.Execute("2");
                });
                var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
                ShareRaise shareRaise = new ShareRaise();
                Share share = new Share(true);
                frame.Content = share;
            };

            testBtn.PressedAction = () =>
            {
                var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
                DestinationMenuSub destinationMenuSub = new DestinationMenuSub(false);
                frame.Content = destinationMenuSub;
            };
            notificationBtn.PressedAction = () =>
            {
                var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
                DestinationMenuSub destinationMenuSub = new DestinationMenuSub(true);
                frame.Content = destinationMenuSub;
            };

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Home home = new Home();
            var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
            frame.Content = home;
        }
    }
}