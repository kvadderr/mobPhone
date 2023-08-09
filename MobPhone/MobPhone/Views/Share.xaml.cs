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
    public partial class Share : ContentView
    {
        public Share(bool isData)
        {
            InitializeComponent();
            var frame = shareFrame;
            ShareMenu shareMenu = new ShareMenu();
            shareMenu.ParentFrame = frame;
            ShareRaise shareRaise = new ShareRaise();

            if (isData == true)
            {
                shareFrame.Content = shareRaise;
            } else shareFrame.Content = shareMenu;

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
            Profile profile = new Profile();
            frame.Content = profile;
        }
    }
}