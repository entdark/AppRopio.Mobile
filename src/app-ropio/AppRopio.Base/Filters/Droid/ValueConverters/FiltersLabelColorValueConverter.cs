﻿using System;
using Android.App;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Util;
using MvvmCross.Platform;
using MvvmCross.Platform.Converters;
using MvvmCross.Platform.Droid.Platform;
using Android.Widget;
using System.Globalization;
using MvvmCross.Platform.UI;

namespace AppRopio.Base.Filters.Droid.ValueConverters
{
    public class FiltersLabelColorValueConverter : MvxValueConverter<bool, Color>
    {
        protected override Color Convert(bool value, Type targetType, object parameter, CultureInfo culture)
        {
            var typedValue = new TypedValue();
            if (Mvx.Resolve<IMvxAndroidCurrentTopActivity>()?.Activity?.Theme.ResolveAttribute((value ? Resource.Attribute.app_color_filter_unactiveColor : Resource.Attribute.app_color_filter_activeColor), typedValue, true) ?? false)
                return new Color(typedValue.Data);

            return new Color(255, 0, 0);
        }
    }
}

