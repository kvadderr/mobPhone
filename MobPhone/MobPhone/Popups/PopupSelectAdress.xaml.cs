using MobPhone.Bottom;
using MobPhone.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobPhone.Popups
{
	public partial class PopupSelectAdress : Popup
	{

        List<Address> address = new List<Address>()
        {
            new Address {Name = "Koffein, г. Нальчик, ул. Ленина 145", isVisibleChecked = false},
            new Address {Name = "Koffein, г. Нальчик, ул. Ленина 145", isVisibleChecked = false},
            new Address {Name = "Koffein, г. Нальчик, ул. Ленина 145", isVisibleChecked = false},
            new Address {Name = "Koffein, г. Нальчик, ул. Ленина 145", isVisibleChecked = false},
            new Address {Name = "Koffein, г. Нальчик, ул. Ленина 145", isVisibleChecked = false},
            new Address {Name = "Koffein, г. Нальчик, ул. Ленина 145", isVisibleChecked = false},
            new Address {Name = "Koffein, г. Нальчик, ул. Ленина 145", isVisibleChecked = false},
        };

        public PopupSelectAdress()
        {
			InitializeComponent (); 
            MyListView.ItemsSource = address;
            MyListView.Effects.Add(Effect.Resolve("MyEffects.ListViewHighlightEffect"));
        }


    }
}