using System;
using System.Collections.Generic;
using Certaldo.Models;

using Xamarin.Forms;

namespace Certaldo.Pages
{
    public partial class RoomDetailPage : ContentPage
    {
        public RoomDetailPage(Room CurrentRoom)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = CurrentRoom;
        }
    }
}