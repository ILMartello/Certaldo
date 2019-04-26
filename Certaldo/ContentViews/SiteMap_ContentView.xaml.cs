using System;
using System.Collections.Generic;
using System.Windows.Input;
using Certaldo.Models;
using Certaldo.Pages;
using Certaldo.View_Models;
using Xamarin.Forms;

namespace Certaldo.ContentViews
{
    public partial class SiteMap_ContentView : ContentView
    {
        public SiteMap_ContentView()
        {
            InitializeComponent();
            BindingContextChanged += MyMap_BindingContextChanged;

            SiteList_ViewModel SiteViewModel = new SiteList_ViewModel();
            BindingContext = SiteViewModel;
        }

        void MyMap_BindingContextChanged(object sender, EventArgs e)
        {
            Mappa.Pins.Clear();
            List<Pinn> PlaceList = (BindingContext as SiteList_ViewModel).PinnList;
            foreach (var x in PlaceList as List<Pinn>)
            {
                Mappa.Pins.Add(x);
            }
        }

        void Handle_InfoWindowClicked(object sender, Parallelo.Maps.Pin e)
        {
            Place site = (e as Pinn).ThisPlace;
            Navigation.PushAsync(new SiteDetailPage(site));

        }
    }
}