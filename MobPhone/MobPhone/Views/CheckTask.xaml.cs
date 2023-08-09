using MobPhone.Popups;
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
    public partial class CheckTask : ContentView
    {
        public CheckTask()
        {
            InitializeComponent();
            if (App.isDestination == true)
            {
                selectProfile.IsVisible = true;
                selectProfileLine.IsVisible = true;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new PopupTaskConfirm());
            Navigation.ShowPopup(new PopupSendTask());
        }
    }
}