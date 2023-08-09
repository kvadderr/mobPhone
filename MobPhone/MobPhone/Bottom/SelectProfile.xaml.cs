using MobPhone.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobPhone.Bottom
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SelectProfile
	{
        public SelectProfile ()
		{
			InitializeComponent ();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            this.IsOpen = false;
        }
    }
}