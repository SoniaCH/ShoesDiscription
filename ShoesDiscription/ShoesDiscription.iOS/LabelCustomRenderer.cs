using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
[assembly: ExportRenderer(typeof(LabelCustom), typeof(LabelCustomRenderer))]
namespace ShoesDiscription.iOS
{
    class LabelCustomRenderer:LabelCustomRenderer
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