using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobPhone.Popups.PopupsCreateTask
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PopupsInterval : Popup
	{
		public PopupsInterval()
		{
			InitializeComponent ();
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
			SingleItem.Background = (Brush)App.Current.Resources["blueGradient"];
            SingleLabel.TextColor = Color.White;
            EveryMonthLabel.TextColor = Color.Black;
            EveryDayLabel.TextColor = Color.Black;

            EveryDay.Background = null;
			EveryMonth.Background = null;
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            SingleItem.Background = null;
            EveryDay.Background = (Brush)App.Current.Resources["blueGradient"];
            EveryMonth.Background = null;

            SingleLabel.TextColor = Color.Black;
            EveryMonthLabel.TextColor = Color.Black;
            EveryDayLabel.TextColor = Color.White;
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            SingleItem.Background = null;
            EveryDay.Background = null;
            EveryMonth.Background = (Brush)App.Current.Resources["blueGradient"];

            SingleLabel.TextColor = Color.Black;
            EveryMonthLabel.TextColor = Color.White;
            EveryDayLabel.TextColor = Color.Black;
        }
    }
}