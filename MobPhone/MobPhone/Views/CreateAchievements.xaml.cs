using MobPhone.Model;
using MobPhone.Popups.PopupsCreateTask;
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
	public partial class CreateAchievements : ContentView
	{
        public CreateAchievements()
		{
			InitializeComponent ();
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
            Achievements achievements = new Achievements();
            frame.Content = achievements;

        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            var result = await Navigation.ShowPopupAsync(new PopupsNewTask());
            if (result == null) return;  
            taskName.LabelText = result.ToString();
            taskName.isRequired = false;
            taskName.iconVisible = false;
        }

        private async void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            var result = await Navigation.ShowPopupAsync(new PopupsDeadline());
            var resultTime = await Navigation.ShowPopupAsync(new PopupsTimePicker());
            var resultInterval = await Navigation.ShowPopupAsync(new PopupsInterval());
            if (result == null) return;
        }

        private async void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            var result = await Navigation.ShowPopupAsync(new PopupsNewDetail());
            if (result == null) return;
            detail.LabelText = result.ToString();
            detail.isRequired = false;
            detail.iconVisible = false;
        }

        private async void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            var result = await Navigation.ShowPopupAsync(new PopupCoin());
            if (result == null) return;
            coin.LabelText = "+ " + result.ToString() + " монет";
            coin.isRequired = false;
            coin.ImageSource = "small_coin";
        }

        private async void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            var result = await Navigation.ShowPopupAsync(new PopupKarma());
            if (result == null) return;
            karma.LabelText = "+ " + result.ToString() + " кармы";
            karma.isRequired = false;
            karma.ImageSource = "small_karma";
        }

        private async void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            var myCommand = App.ViewModel.ClickCommand;
            Device.BeginInvokeOnMainThread(() =>
            {
                myCommand.Execute("2");
            });
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
            CheckAchievements checkAchievements = new CheckAchievements();
            frame.Content = checkAchievements;
        }
    }
}