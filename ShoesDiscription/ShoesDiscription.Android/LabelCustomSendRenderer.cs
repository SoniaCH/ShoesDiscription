using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ShoesDiscription;
using ShoesDiscription.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(LabelCustomSend), typeof(LabelCustomSendRenderer))]
namespace ShoesDiscription.Droid
{
    class LabelCustomSendRenderer : LabelRenderer
    {
        public LabelCustomSendRenderer(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                GradientDrawable gd = new GradientDrawable();
                float[] radi = { 0, 0, 100, 100, 100, 100, 100, 100 };
                gd.SetCornerRadii(radi);
                gd.SetColor(global::Android.Graphics.Color.Rgb(191, 182, 167));
                this.Control.SetBackgroundDrawable(gd);
                this.Control.SetPaddingRelative(30, 20, 30, 20);
            }

        }
    }
}