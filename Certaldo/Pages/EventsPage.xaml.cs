using System;
using System.Collections.Generic;
using Certaldo.ContentViews;
using Certaldo.View_Models;
using Xamarin.Forms;

using Xamarin.Forms;

namespace Certaldo.Pages
{
    public partial class EventsPage : ContentPage
    {
        public BoxView ListLine => ListLineBtn;
        public BoxView MapLine => MapLineBtn;


        public EventsPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            //
            EventList_ViewModel Eventss = new EventList_ViewModel();
            //
            BindingContext = Eventss as EventList_ViewModel;
            ListLine.BackgroundColor = Color.Red;
        }

        void Get_ListMode(object sender, System.EventArgs e)
        {
            (BindingContext as EventList_ViewModel).CurrentMode = new EventList_ContentView() as ContentView;

            ListLine.BackgroundColor = Color.Red;
            MapLine.BackgroundColor = Color.Transparent;

        }

        void Get_MapsMode(object sender, System.EventArgs e)
        {
            (BindingContext as EventList_ViewModel).CurrentMode = new EventMap_ContentView() as ContentView;

            ListLine.BackgroundColor = Color.Transparent;
            MapLine.BackgroundColor = Color.Red;

        }
    }
}
