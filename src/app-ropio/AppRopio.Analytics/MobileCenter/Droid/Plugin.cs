﻿using System;
using AppRopio.Analytics.MobileCenter.Core.Services;
using MvvmCross;
using MvvmCross.Plugin;

namespace AppRopio.Analytics.MobileCenter.Droid
{
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterSingleton<IMobileCenter>(new Services.MobileCenter());
        }
    }
}
