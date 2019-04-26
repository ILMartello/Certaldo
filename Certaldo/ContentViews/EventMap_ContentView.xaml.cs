using System;
using System.Collections.Generic;
using Certaldo.Models;
using Certaldo.Pages;
using Certaldo.View_Models;
using Xamarin.Forms;

namespace Certaldo.ContentViews
{
    public partial class EventMap_ContentView : ContentView
    {
        public EventMap_ContentView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContextChanged += MyMap_BindingContextChanged;

            EventList_ViewModel EventViewModel = new EventList_ViewModel();
            BindingContext = EventViewModel;

        }

        void MyMap_BindingContextChanged(object sender, EventArgs e)
        {
            Mappa.Pins.Clear();
            List<Pinn> EventPinList = (BindingContext as EventList_ViewModel).PinnList;
            foreach (var x in EventPinList as List<Pinn>)
            {
                Mappa.Pins.Add(x);
            }
        }

        void Handle_InfoWindowClicked(object sender, Parallelo.Maps.Pin e)
        {
            Place PlacewithEvents = (e as Pinn).ThisPlace;
            Navigation.PushAsync(new EventsOfOnePage(PlacewithEvents));
        }
    }
}
