﻿using AppRopio.Base.Core.Services.ViewLookup;
using AppRopio.Payments.YandexKassa.Core;
using AppRopio.Payments.YandexKassa.Core.ViewModels.YandexKassa;
using MvvmCross;
using MvvmCross.Plugin;

namespace AppRopio.Payments.YandexKassa.iOS
{
    [MvxPlugin]
    [Preserve(AllMembers = true)]
    public class Plugin : BasePlugin
    {
        public override void Load()
        {
            base.Load();

            var viewLookupService = Mvx.IoCProvider.Resolve<IViewLookupService>();

            viewLookupService.Register<IYandexKassaViewModel, YandexKassaViewController>();
        }
    }
}