using Mal.Xf.QrCode.Models;
using System.Collections.Generic;

namespace Mal.Xf.QrCode.Views
{
    public interface IMenuItemsProvider
    {
        IReadOnlyCollection<HomeMenuItem> GetMenuItems();
    }
}