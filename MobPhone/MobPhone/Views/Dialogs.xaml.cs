using MobPhone.Model;
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
    public partial class Dialogs : ContentView
    {
        bool isIdea = false;
        List<DialogsData> profileRaitings = new List<DialogsData>
            {
               new DialogsData { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=true, isUnread=false},
               new DialogsData { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=true, isUnread=false},
               new DialogsData{ FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=true, isUnread=false},
               new DialogsData{ FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=false, isUnread=true},
               new DialogsData{ FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=false, isUnread=false},
               new DialogsData{ FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=false, isUnread=false},
               new DialogsData{ FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=false, isUnread=false},
               new DialogsData{ FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=false, isUnread=false},
               new DialogsData { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=false, isUnread=false},
               new DialogsData { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=false, isUnread=false},
               new DialogsData { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=false, isUnread=false},
               new DialogsData { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=false, isUnread=false},
               new DialogsData { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=false, isUnread=false},
               new DialogsData { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=false, isUnread=false},
               new DialogsData { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=false, isUnread=false},
            };

        List<DialogsData> ideaList = new List<DialogsData>
            {
               new DialogsData { FIO = "Это идея", Message="Спасибо! Это приятно слышать", isIdea=true, isUnread=false},
               new DialogsData { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=true, isUnread=false},
            };

        public Dialogs()
        {
            InitializeComponent();

            
            BindingContext = App.ViewModel;
            MyListView.ItemsSource = profileRaitings;
            MyListView.ItemTapped += MyListView_ItemTapped;
        }


        private void MyListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
            Messanger home = new Messanger();
            frame.Content = home;
        }

        private void goHome(object sender, EventArgs e)
        {
            var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
            Home home = new Home();
            frame.Content = home;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            if (isIdea == false)
            {
                ideaBtn.Background = (Brush)App.Current.Resources["blueGradient"];
                MyListView.ItemsSource = ideaList;
            } else {
                ideaBtn.Background = null;
                ideaBtn.BackgroundColor = Color.FromHex("#dcd9fe");
                MyListView.ItemsSource = profileRaitings; 
            }

            isIdea = !isIdea;
        }

    }
}