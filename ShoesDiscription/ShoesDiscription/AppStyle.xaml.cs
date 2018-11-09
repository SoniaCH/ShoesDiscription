using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShoesDiscription
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppStyle : ResourceDictionary
    {
        public float SmallFont { get; set; }

        public AppStyle ()
		{
			InitializeComponent ();
            SmallFont = 80;

        }
	}
}