using System;
using System.Collections.Generic;
using Certaldo.Models;
using Xamarin.Forms;

using Xamarin.Forms;

namespace Certaldo.Pages
{
    public partial class EventsOfOnePage : ContentPage
    {
        public EventsOfOnePage(Place PlacewithEvents)
        {
            BindingContext = PlacewithEvents as Place;
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void OnItemSelected(Object sender, ItemTappedEventArgs e)
        {
            var Mydetails = e.Item as Event;
            //  await Navigation.PushAsync(new Event_DetailPage(Mydetails));
        }
    }
}
