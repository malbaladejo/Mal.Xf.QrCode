using Mal.Xf.QrCode.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mal.Xf.QrCode.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        private readonly MainPage mainPage;
        IReadOnlyCollection<HomeMenuItem> menuItems;
        public MenuPage(MainPage mainPage, IMenuItemsProvider menuItemsProvider)
        {
            InitializeComponent();
            this.mainPage = mainPage;

            menuItems = menuItemsProvider.GetMenuItems();

            ListViewMenu.ItemsSource = menuItems;


            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = ((HomeMenuItem)e.SelectedItem).Id;
                await this.mainPage.NavigateFromMenu(id);
            };

            ListViewMenu.SelectedItem = menuItems.First();
        }
    }
}