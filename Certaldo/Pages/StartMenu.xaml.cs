using System;
using System.Collections.Generic;
using Certaldo.ToolBar;
using Certaldo.View_Models;
//using Certaldo.Views;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;


namespace Certaldo.Pages
{
    public partial class StartMenu : ContentPage
    {
        public StartMenu()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            PopupNavigation.Instance.PushAsync(new LogoHeadBar());
        }

        void OpenPPretorio(object sender, System.EventArgs e)
        {
            //TO INSERT NAVIGATION
            // Navigation.PushAsync(new BuildingPagee(new Building_ViewModel().PalazzoPretorio));
        }

        void OpenBoccaccio(object sender, System.EventArgs e)
        {
            //TO INSERT NAVIGATION
            int IDBoccaccio = 40;
            Navigation.PushAsync(new BuildingPagee(IDBoccaccio));
        }

        void OpenLuoghi(object sender, System.EventArgs e)
        {
            SiteList_ViewModel List = new SiteList_ViewModel();
            Navigation.PushAsync(new SitePage(List));
        }

        void OpenEvents(object sender, System.EventArgs e)
        {
            //EventList_ViewModel EventsList = new EventList_ViewModel();
            //Navigation.PushAsync(new EventsPage(EventsList));
            Navigation.PushAsync(new EventsPage());
        }

        void OpenCredits(object sender, System.EventArgs e)
        {
            //TO INSERT NAVIGATION
        }

        void OpenTurismo(object sender, System.EventArgs e)
        {
            //TO INSERT NAVIGATION
        }


        //Responsive Height:
        /*
        public struct Constant
        {
            public static double ScreenWidth = Application.Current.MainPage.Width;
            public static double ScreenHeight = Application.Current.MainPage.Height;

            public static double HeightBigItem = (ScreenHeight / 4);
        }
    

        public class GetPixels
        {
            public int HeightX = 120;
        }

        //In Xaml:
        //  xmlns:local="clr-namespace:Basic.Pages.StartMenu"
        //  <StackLayout BackgroundColor = "Silver" HeightRequest="{Binding Source={x:Static local:GetPixels.HeightX}}">
            */
    }
}