﻿using System;
using AppRopio.Geofencing.Core.Service;
using AppRopio.Geofencing.Droid.Services;
using MvvmCross;
using MvvmCross.Plugin;

namespace AppRopio.Geofencing.Droid
{
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterSingleton<IGeofencingService>(() => new GeofencingService());

            Mvx.Resolve<IGeofencingService>().Start();
        }
    }
}
