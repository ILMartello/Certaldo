using System;
using System.Collections.Generic;
using Certaldo.Models;
using Xamarin.Forms;

namespace Certaldo.Pages
{
    public partial class SiteDetailPage : ContentPage
    {
        public SiteDetailPage(Place CurrentSite)
        {
            InitializeComponent();
            BindingContext = CurrentSite;
            var img = CurrentSite.Immagine;
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
