using MobPhone.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobPhone.Bottom
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SelectProfileWithIcons
	{
        List<Profile> selectProfiles = new List<Profile>()
        {
            new Profile {FIO = "ФИО", Position="Позиция", isVisibleChecked=false, isVisiblePosition =true},
            new Profile {FIO = "ФИО", Position="dsdsdd", isVisibleChecked=false, isVisiblePosition =true},
            new Profile {FIO = "asdasdasd", Position="dsdsdd", isVisibleChecked=false, isVisiblePosition =true},
            new Profile {FIO = "asdasdasd", Position="dsdsdd", isVisibleChecked=false, isVisiblePosition =true},
            new Profile {FIO = "ФАсмилия", Position="Курьер", isVisibleChecked=false, isVisiblePosition =true},
            new Profile {FIO = "asdasdasd", Position="dsdsdd", isVisibleChecked=false, isVisiblePosition =true},
            new Profile {FIO = "asdasdasd", Position="dsdsdd", isVisibleChecked=false, isVisiblePosition =true},
        };

        public SelectProfileWithIcons()
		{
			InitializeComponent ();
            MyListView.ItemsSource = selectProfiles;
            MyListView.Effects.Add(Effect.Resolve("MyEffects.ListViewHighlightEffect"));
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            this.IsOpen = false;
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            foreach (var profile in selectProfiles)
            {
                profile.isVisibleChecked = allCheckBox.IsChecked;
                profile.isVisiblePosition = !allCheckBox.IsChecked;
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            this.IsOpen = false;
        }
    }
}