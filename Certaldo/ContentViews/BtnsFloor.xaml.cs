using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Certaldo.Models;
using Certaldo.Pages;

namespace Certaldo.ContentViews
{
    public partial class BtnsFloor : ContentView
    {
        public List<Room> ListRoom;
        public string Index;
        public BtnsFloor(KeyValuePair<int, List<Room>> ListRoomofFloor)
        {
            BindingContext = ListRoomofFloor;
            //int index = ListRoomofFloor.Key;
            Index = "btnss";
            ListRoom = ListRoomofFloor.Value;
            InitializeComponent();

        }
        public BoxView Line => LineBtn;
    }

}