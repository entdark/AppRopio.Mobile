﻿using System;
using AppRopio.Payments.ApplePay.Services;
using MvvmCross.ViewModels;
using MvvmCross;

namespace AppRopio.Payments.ApplePay
{
    public class App : MvxApplication
	{
		public override void Initialize()
		{
			Mvx.RegisterSingleton<IApplePayConfigService>(() => new ApplePayConfigService());
		}
	}
}