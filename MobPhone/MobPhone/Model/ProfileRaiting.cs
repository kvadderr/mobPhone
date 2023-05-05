using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobPhone.Model
{
    public class ProfileRaiting
    {
        public ImageSource notifi { get; set; }
        public int avatar { get; set; }
        public string FIO { get; set; }
        public string Position { get; set; }
        public string Address{ get; set; }
        public int level { get; set; }
        public int Coin { get; set; }
        public int Karma { get; set; }
        public int Karma_Total { get; set; }
    }
}
