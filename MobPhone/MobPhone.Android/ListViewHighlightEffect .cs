using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MobPhone.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("MyEffects")]
[assembly: ExportEffect(typeof(ListViewHighlightEffect), nameof(ListViewHighlightEffect))]
namespace MobPhone.Droid
{
    public class ListViewHighlightEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var listView = (Android.Widget.ListView)Control;

            listView.ChoiceMode = ChoiceMode.None; // !!!
            listView.SetSelector(Android.Resource.Color.Transparent); // !!!
        }

        protected override void OnDetached()
        {

        }
    }
}