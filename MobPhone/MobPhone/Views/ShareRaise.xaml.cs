using MobPhone.Model;
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
    public partial class ShareRaise : ContentView
    {
        public ShareRaise()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new PopupRiseConfirm());
            Navigation.ShowPopup(new PopupRiseSuccess());
            Navigation.ShowPopup(new PopupRiseError());
        }
    }
}