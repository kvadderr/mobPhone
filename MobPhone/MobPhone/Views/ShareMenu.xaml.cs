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
    public partial class ShareMenu : ContentView
    {
        public Frame ParentFrame { get; set; }
        public ShareMenu()
        {
            InitializeComponent();

            testBtn.PressedAction = () =>
            {
                ShareMenuSub shareMenuSub = new ShareMenuSub(false);
                ParentFrame.Content = shareMenuSub;
            };

            libraryBtn.PressedAction = () =>
            {
                ShareMenuSub shareMenuSub = new ShareMenuSub(true);
                ParentFrame.Content = shareMenuSub;
            };

            raiseBtn.PressedAction = () =>
            {
                ShareRaise raise = new ShareRaise();
                ParentFrame.Content = raise;
            };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
            Article article = new Article();
            frame.Content = article;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
            var innerframe = frame.FindByName<Frame>("shareFrame");
            ShareRaise raise = new ShareRaise();
            innerframe.Content = raise;
        }
    }
}