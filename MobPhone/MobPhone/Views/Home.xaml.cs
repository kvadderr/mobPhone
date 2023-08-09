using MobPhone.Views.destination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobPhone.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Home : ContentView
	{
        public Home()
        {
            InitializeComponent();
            App.isDestination = false;

            raitingBtn.PressedAction = () =>
            {
                var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
                Raiting raiting = new Raiting();
                frame.Content = raiting;
            };

            profileBtn.PressedAction = () =>
            {
                var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
                ProfileSelect profile = new ProfileSelect();
                frame.Content = profile;
            };

            notificationBtn.PressedAction = () =>
            {
                var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
                News news = new News();
                frame.Content = news;
            };

            smsBtn.PressedAction = () =>
            {
                var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
                Dialogs dialogs = new Dialogs();
                frame.Content = dialogs;
            };

            destinationBtn.PressedAction = () =>
            {
                var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
                DestinationMenu destinationMenu = new DestinationMenu();
                frame.Content = destinationMenu;
            };

            smsAdminBtn.PressedAction = () =>
            {
                var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
                DialogsAdmin dialogs = new DialogsAdmin();
                frame.Content = dialogs;
            };

        }
    }
}