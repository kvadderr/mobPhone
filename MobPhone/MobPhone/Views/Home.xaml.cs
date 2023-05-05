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
		public Home ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
            Raiting raiting = new Raiting();
            frame.Content = raiting;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
            Profile profile = new Profile();
            frame.Content = profile;
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
            News news = new News();
            frame.Content = news;
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
            Dialogs dialogs = new Dialogs();
            frame.Content = dialogs;
        }
    }
}