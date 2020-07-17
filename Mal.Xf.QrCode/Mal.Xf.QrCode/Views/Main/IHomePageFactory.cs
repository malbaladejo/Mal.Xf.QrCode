using Mal.Xf.QrCode.Models;
using Xamarin.Forms;

namespace Mal.Xf.QrCode.Views
{
    public interface IHomePageFactory
    {
        NavigationPage CreatePage(MenuItemType menuItemType);
    }
}