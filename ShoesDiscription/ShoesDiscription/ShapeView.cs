﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ShoesDiscription
{
    public class ShapeView : BoxView
    {
        public static readonly BindableProperty ShapeTypeProperty = BindableProperty.Create<ShapeView, ShapeType>(s => s.ShapeType, ShapeType.Box);

        public static readonly BindableProperty StrokeColorProperty = BindableProperty.Create<ShapeView, Color>(s => s.StrokeColor, Color.Default);

        public static readonly BindableProperty StrokeWidthProperty = BindableProperty.Create<ShapeView, float>(s => s.StrokeWidth, 1f);

        public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create<ShapeView, float>(s => s.CornerRadius, 0f);

        public static readonly BindableProperty PaddingProperty = BindableProperty.Create<ShapeView, Thickness>(s => s.Padding, default(Thickness));

        public ShapeType ShapeType
        {
            get { return (ShapeType)GetValue(ShapeTypeProperty); }
            set { SetValue(ShapeTypeProperty, value); }
        }

        public Color StrokeColor
        {
            get { return (Color)GetValue(StrokeColorProperty); }
            set { SetValue(StrokeColorProperty, value); }
        }

        public float StrokeWidth
        {
            get { return (float)GetValue(StrokeWidthProperty); }
            set { SetValue(StrokeWidthProperty, value); }
        }

        public float CornerRadius
        {
            get { return (float)GetValue(CornerRadiusProperty); }
            set
            {
                if (ShapeType != ShapeType.Box)
                    throw new ArgumentException("Can only specify this property with Box");
                SetValue(CornerRadiusProperty, value);
            }
        }

        public Thickness Padding
        {
            get { return (Thickness)GetValue(PaddingProperty); }
            set { SetValue(PaddingProperty, value); }
        }

        public ShapeView()
        {
        }
    }

    public enum ShapeType
    {
        Box,
        Circle
    }
}
