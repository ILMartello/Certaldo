using System;
using System.Collections.Generic;
using System.Linq;
using Certaldo.ContentViews;
using Certaldo.Models;
using Parallelo.Maps;
using Xamarin.Forms;

namespace Certaldo.View_Models
{
    public class EventList_ViewModel : BindableObject
    {
        public List<Place> AllPlaceList { get; set; }
        public List<Event> Events { get; set; }
        public List<Pinn> PinnList { get; set; }

        public static readonly BindableProperty CurrentModeProperty =
           BindableProperty.Create("CurrentMode", typeof(ContentView), typeof(EventList_ViewModel), new EventList_ContentView());

        public ContentView CurrentMode
        {
            get { return (ContentView)GetValue(CurrentModeProperty); }
            set { SetValue(CurrentModeProperty, value); }
        }

        public EventList_ViewModel()
        {
            AllPlaceList = (Application.Current as App).Datasource.Data.Places.Select(place => {
                return place;
            }).ToList();


            List<Place> PlaceWithEvents = new List<Place>();
            foreach (Place x in AllPlaceList)
            {
                if (x.calendars.Count != 0)
                {
                    PlaceWithEvents.Add(x);
                }
            }

            PinnList = new List<Pinn>();
            foreach (var _place in PlaceWithEvents as List<Place>)
            {
                if (_place.Latitudine != null && _place.Longitudine != null)
                {
                    PinnList.Add(new Pinn() { ThisPlace = _place, Title = (_place.Translation as PlaceTranslation).Title, Description = (_place.Translation as PlaceTranslation).Description, Position = new Position(_place.Latitudine, _place.Longitudine) });
                }
            }

            Events = new List<Event>();
            foreach (Place x in PlaceWithEvents)
            {
                foreach (Event e in x.calendars)
                {
                    Events.Add(e);
                    e.MyPlace = x;
                }
            }

        }

    }
}