using Mal.Xf.QrCode.Views.ScanDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing;
using ZXing.Net.Mobile.Forms;

namespace Mal.Xf.QrCode.Views.Scan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScanPage : ContentPage
    {
        private readonly IScanDetailPageFactory scanDetailPageFactory;

        public ScanPage(IScanDetailPageFactory scanDetailPageFactory)
        {
            InitializeComponent();
            zxing.Options.PossibleFormats = new List<BarcodeFormat> {
                BarcodeFormat.QR_CODE, 
                BarcodeFormat.EAN_13
            };
            this.scanDetailPageFactory = scanDetailPageFactory;
        }

        public void OnScanResult(Result result)
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                // Stop analysis until we navigate away so we don't keep reading barcodes
                zxing.IsAnalyzing = false;

                await this.Navigation.PushAsync(this.scanDetailPageFactory.CreatePage(result.Text));
            });
        }

        public void OnFlashButtonClicked(Button sender, EventArgs e)
        {
            zxing.IsTorchOn = !zxing.IsTorchOn;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            zxing.IsAnalyzing = true;
            zxing.IsScanning = true;
        }

        protected override void OnDisappearing()
        {
            zxing.IsScanning = false;

            base.OnDisappearing();
        }
    }
}