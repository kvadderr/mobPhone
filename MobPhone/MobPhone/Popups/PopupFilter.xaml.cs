using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobPhone.Popups
{
	public partial class PopupFilter : Popup
	{
		public PopupFilter ()
		{
			InitializeComponent ();
            Size = new Size(335, timeGrid.Height + timeGrid.Height);
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            option_first.IsVisible = check_first.IsChecked;
        }

        private void check_second_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            option_second.IsVisible = check_second.IsChecked;
        }
    }
}