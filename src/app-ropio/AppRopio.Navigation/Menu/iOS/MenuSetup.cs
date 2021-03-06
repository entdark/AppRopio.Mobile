using AppRopio.Base.Core.Services.ViewLookup;
using AppRopio.Base.iOS;
using AppRopio.Navigation.Menu.Core.ViewModels;
using AppRopio.Navigation.Menu.iOS.Services;
using AppRopio.Navigation.Menu.iOS.Services.Implementation;
using AppRopio.Navigation.Menu.iOS.Views;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform;
using UIKit;

namespace AppRopio.Navigation.Menu.iOS
{
    public class MenuSetup : BaseIosSetup
    {

        public MenuSetup(IMvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {

        }

        public MenuSetup(IMvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
            : base(applicationDelegate, presenter)
        {

        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();

            Mvx.RegisterSingleton<IMenuThemeConfigService>(() => new MenuThemeConfigService());

            Mvx.Resolve<IViewLookupService>().Register<IMenuViewModel, MenuViewController>();
        }
    }
}
