using System;
using System.Collections.Generic;
using Certaldo.Models;

using Xamarin.Forms;

namespace Certaldo.Pages
{
    public partial class EventDetailPage : ContentPage
    {
        public EventDetailPage(Event ThisEvent)
        {
            InitializeComponent();
            BindingContext = ThisEvent;
            //var img = ThisEvent.Immagine;
        }
    }
}
