using System;
using System.Collections.Generic;
using Certaldo.Models;
using Certaldo.Pages;
using Certaldo.View_Models;
using Xamarin.Forms;

namespace Certaldo.ContentViews
{
    public partial class SiteList_ContentView : ContentView
    {
        public SiteList_ContentView()
        {
            InitializeComponent();
            BindingContext = new SiteList_ViewModel();
        }

        private async void OnItemSelected(Object sender, ItemTappedEventArgs e)
        {
            var Mydetails = e.Item as Place;
            await Navigation.PushAsync(new SiteDetailPage(Mydetails));
        }
    }
}
