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
	public partial class PopupKarma: Popup
	{
		public PopupKarma()
		{
			InitializeComponent ();
			
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
			Dismiss(taskText.Text);
        }
    }
}