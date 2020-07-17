using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Mal.Xf.QrCode.Models;
using Mal.Xf.QrCode.Views.Scan;
using Mal.Xf.QrCode.Views.ScanDetail;

namespace Mal.Xf.QrCode.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        private readonly IHomePageFactory homePageFactory = new HomePageFactory();

        private readonly Dictionary<MenuItemType, NavigationPage> MenuPages = new Dictionary<MenuItemType, NavigationPage>();

        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;
            this.Master = new MenuPage(this, new MenuItemsProvider());
        }

        public async Task NavigateFromMenu(MenuItemType id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                MenuPages.Add(id, this.homePageFactory.CreatePage(id));
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}