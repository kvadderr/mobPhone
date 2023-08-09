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
	public partial class PopupsTimePicker : Popup
	{
		public PopupsTimePicker()
		{
			InitializeComponent();
			Size = new Size(335, timeGrid.Height + timeGrid.Height);
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
			timePicker.IsVisible = !timePicker.IsVisible;
			if (timePicker.IsVisible)
			{
                endPicker.IsVisible = false;
                allPicker.IsVisible = false;
            } else
			{

			}
        }

        private void Switch_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
			endPicker.IsVisible = !endPicker.IsVisible;
			timePicker.IsVisible = false;
			startPicker.IsVisible = !startPicker.IsVisible;
        }
    }
}