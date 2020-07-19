using Mal.Xf.QrCode.Assets.Fonts;
using Mal.Xf.QrCode.Models;
using System.Collections.Generic;

namespace Mal.Xf.QrCode.Views
{
    internal class MenuItemsProvider : IMenuItemsProvider
    {
        public MenuItemsProvider()
        {
        }

        public IReadOnlyCollection<HomeMenuItem> GetMenuItems()
        => new[]
        {
            new HomeMenuItem {Id = MenuItemType.Scan, Title="Scan", Icon=FontAwesomeIcons.Qrcode },
            new HomeMenuItem {Id = MenuItemType.About, Title="About", Icon =FontAwesomeIcons.Question}
        };
    }
}