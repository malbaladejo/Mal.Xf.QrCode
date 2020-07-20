using Xamarin.Forms;

namespace Mal.Xf.QrCode.Views.ScanDetail
{
    public interface IScanDetailPageFactory
    {
        Page CreatePage(string code);
    }
}
