using Mal.Xf.QrCode.Models;
using Mal.Xf.QrCode.Views.Scan;
using Mal.Xf.QrCode.Views.ScanDetail;
using System;
using Xamarin.Forms;

namespace Mal.Xf.QrCode.Views
{
    internal class HomePageFactory : IHomePageFactory
    {
        private readonly ScanPageFactory scanPageFactory = new ScanPageFactory(new ScanDetailPageFactory());

        public NavigationPage CreatePage(MenuItemType menuItemType)
        {
            switch (menuItemType)
            {
                case MenuItemType.Scan:
                   return new NavigationPage(this.scanPageFactory.CreatePage());

                case MenuItemType.About:
                    return new NavigationPage(new AboutPage());

                default:
                    throw new ArgumentOutOfRangeException($"{menuItemType} is not a supported MenuItemType.");
            }
        }
    }
}