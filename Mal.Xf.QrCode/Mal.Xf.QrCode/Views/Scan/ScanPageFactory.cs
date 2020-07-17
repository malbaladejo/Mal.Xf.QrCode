using Mal.Xf.QrCode.Views.ScanDetail;
using Xamarin.Forms;

namespace Mal.Xf.QrCode.Views.Scan
{
    internal class ScanPageFactory
    {
        private readonly IScanDetailPageFactory scanDetailPageFactory;

        public ScanPageFactory(IScanDetailPageFactory scanDetailPageFactory)
        {
            this.scanDetailPageFactory = scanDetailPageFactory;
        }

        public Page CreatePage()
        {
            var page = new ScanPage(this.scanDetailPageFactory);
            var viewModel = new ScanViewModel();

            page.BindingContext = viewModel;
            viewModel.Navigation = page.Navigation;

            return page;
        }
    }
}
