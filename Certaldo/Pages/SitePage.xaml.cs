using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Services;
using Certaldo.ContentViews;
using Certaldo.View_Models;
using Xamarin.Forms;
using System.Windows.Input;

namespace Certaldo.Pages
{
    public partial class SitePage : ContentPage
    {
        public BoxView ListLine => ListLineBtn;
        public BoxView MapLine => MapLineBtn;

        public SitePage(SiteList_ViewModel sSite)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = sSite;
            ListLine.BackgroundColor = Color.Red;
        }

        void Get_ListMode(object sender, System.EventArgs e)
        {
            (BindingContext as SiteList_ViewModel).CurrentMode = new SiteList_ContentView() as ContentView;
            ListLine.BackgroundColor = Color.Red;
            MapLine.BackgroundColor = Color.Transparent;
        }

        void Get_MapsMode(object sender, System.EventArgs e)
        {
            (BindingContext as SiteList_ViewModel).CurrentMode = new SiteMap_ContentView() as ContentView;
            ListLine.BackgroundColor = Color.Transparent;
            MapLine.BackgroundColor = Color.Red;
        }
    }
}