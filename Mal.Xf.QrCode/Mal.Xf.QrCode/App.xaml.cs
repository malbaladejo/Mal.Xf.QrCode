using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Mal.Xf.QrCode.Services;
using Mal.Xf.QrCode.Views;

namespace Mal.Xf.QrCode
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
