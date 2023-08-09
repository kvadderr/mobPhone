using MobPhone.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobPhone.Views.destination
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DestinationMenuSub : ContentView
    {
        private bool isLibrary;
        private bool isSub = false;

        List<ShareSub> library = new List<ShareSub>()
        {
            new ShareSub {Name = "Про кофе"},
            new ShareSub {Name = "О компании"},
            new ShareSub {Name = "Онбординг"},
        };

        List<ShareSub> test = new List<ShareSub>()
        {
            new ShareSub {Name = "Психологическое"},
            new ShareSub {Name = "Корпоративное"},
            new ShareSub {Name = "Аттестация"},
        };

        List<ShareSub> items = new List<ShareSub>()
        {
            new ShareSub {Name = "Итем 1"},
            new ShareSub {Name = "Итем 2"},
            new ShareSub {Name = "Итем 3"},
            new ShareSub {Name = "Итем 1"},
            new ShareSub {Name = "Итем 2"},
            new ShareSub {Name = "Итем 3"},
            new ShareSub {Name = "Итем 1"},
            new ShareSub {Name = "Итем 2"},
            new ShareSub {Name = "Итем 3"},
        };

        public DestinationMenuSub(bool isLibrary)
        {
            InitializeComponent();
            MyListView.Effects.Add(Effect.Resolve("MyEffects.ListViewHighlightEffect"));
            this.isLibrary = isLibrary;

            if(isLibrary)
            {
                MyListView.ItemsSource = library;
                menuTitle.Text = "Библиотека";
            } else
            {
                MyListView.ItemsSource = test;
                menuTitle.Text = "Тестирование";
            }

            MyListView.ItemTapped += MyListView_ItemTapped;

        }

        private void MyListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (isSub != true)
            {
                if (e.Item is ShareSub selectedItem)
                {
                    subMenuTitle.Text = selectedItem.Name;
                }
                MyListView.ItemsSource = items;
                subMenuTitle.IsVisible = true;
                isSub = true;
            } else
            {
                var frame = App.Current.MainPage.FindByName<Frame>("myFrame");
                Article article = new Article();
                frame.Content = article;
            }
        }
    }
}