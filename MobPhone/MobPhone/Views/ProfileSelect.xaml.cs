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
    public partial class ProfileSelect : ContentView
    {
        public ProfileSelect()
        {
            InitializeComponent();
            List<ProfileRaiting> profileRaitings = new List<ProfileRaiting>
            {
                new ProfileRaiting {FIO = "Мария Иванова", Position="Официант"},
                new ProfileRaiting {FIO = "Иван Сидоров", Position="Бариста"},
                new ProfileRaiting {FIO = "Женя Смирнова", Position = "Бариста"},
                new ProfileRaiting {FIO = "Мила Васильчук", Position = "Хостес"},
                new ProfileRaiting {FIO = "Мария Иванова", Position = "Официант"},
                new ProfileRaiting {FIO = "Мария Иванова", Position="Официант"},
                new ProfileRaiting {FIO = "Иван Сидоров", Position="Бариста"},
                new ProfileRaiting {FIO = "Женя Смирнова", Position = "Бариста"},
                new ProfileRaiting {FIO = "Мила Васильчук", Position = "Хостес"},
                new ProfileRaiting {FIO = "Мария Иванова", Position = "Официант"},
            };

            MyListView.ItemsSource = profileRaitings;
            MyListView.ItemTapped += MyListView_ItemTapped;
            MyListView.Effects.Add(Effect.Resolve("MyEffects.ListViewHighlightEffect"));
        }

        private void MyListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
            Profile profile = new Profile();
            frame.Content = profile;
        }
    }
}