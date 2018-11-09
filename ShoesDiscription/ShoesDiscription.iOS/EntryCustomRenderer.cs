using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using ShoesDiscription;
using ShoesDiscription.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(EntryCustom), typeof(EntryCustomRenderer))]
namespace ShoesDiscription.iOS
{
    class EntryCustomRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BorderStyle = UITextBorderStyle.None;
            }
        }
    }
}