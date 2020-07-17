using Xamarin.Forms;

namespace Mal.Xf.QrCode.Views.ScanDetail
{
    internal class ScanDetailPageFactory : IScanDetailPageFactory
    {
        public Page CreatePage(string code)
        {
            var page = new ScanDetailPage();
            var viewModel = new ScanDetailViewModel(code);

            page.BindingContext = viewModel;
            viewModel.Navigation = page.Navigation;

            return page;
        }
    }
}
