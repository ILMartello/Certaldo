using System;
using System.Collections.Generic;
using Certaldo.Models;
using Certaldo.Pages;
using Certaldo.View_Models;
using Xamarin.Forms;

namespace Certaldo.ContentViews
{
    public partial class EventList_ContentView : ContentView
    {
        public EventList_ContentView()
        {
            InitializeComponent();
            BindingContext = new EventList_ViewModel();
        }

        private async void OnItemSelected(Object sender, ItemTappedEventArgs e)
        {
            var Mydetails = e.Item as Event;
            await Navigation.PushAsync(new EventDetailPage(Mydetails));
        }
    }
}
