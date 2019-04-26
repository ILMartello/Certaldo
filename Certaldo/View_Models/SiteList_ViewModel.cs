using System;
using System.Collections.Generic;
using Certaldo.Models;
using Certaldo.ContentViews;
using Parallelo.Maps;
using Xamarin.Forms;
using System.Linq;

namespace Certaldo.View_Models
{
    public class Pinn : Pin
    {
        public Place ThisPlace { get; set; }
    }

    public class SiteList_ViewModel : BindableObject
    {
        public static readonly BindableProperty CurrentModeProperty =
            BindableProperty.Create("CurrentMode", typeof(ContentView), typeof(SiteList_ViewModel), new SiteList_ContentView());

        public ContentView CurrentMode
        {
            get { return (ContentView)GetValue(CurrentModeProperty); }
            set { SetValue(CurrentModeProperty, value); }
        }

        public List<Place> SiteList { get; set; }
        public List<Pinn> PinnList { get; set; }

        public SiteList_ViewModel()
        {
            SiteList = (Application.Current as App).Datasource.Data.Places.Select(place => {
                //site.Pinn = new Pinn() { Title = site.Title, Description = site.Description, Position = new Position(site.latitudine, site.longitudine), Site = site };
                return place;
            }).ToList();

            PinnList = new List<Pinn>();
            foreach (var _place in SiteList as List<Place>)
            {
                if (_place.Latitudine != null && _place.Longitudine != null)
                {
                    PinnList.Add(new Pinn() { ThisPlace = _place, Title = (_place.Translation as PlaceTranslation).Title, Description = (_place.Translation as PlaceTranslation).Description, Position = new Position(_place.Latitudine, _place.Longitudine) });
                }
            }
        }
    }
}