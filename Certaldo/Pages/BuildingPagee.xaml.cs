using System;
using System.Collections.Generic;
using Certaldo.Models;
using Certaldo.ContentViews;

using Xamarin.Forms;
using Certaldo.View_Models;
using System.Linq;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Certaldo.ContentViews.SVGMaps;
using System.IO;

namespace Certaldo.Pages
{
    public partial class BuildingPagee : ContentPage
    {
        public Room SelectedRoom;
        public string LayerBase;
        public BuildSVG CurrentPalazzo = new BuildSVG();
        PalazziSVG ListaPalazzi = new PalazziSVG();
        int CurrentPlane = new int();
        List<Place> AllPlaces = new SiteList_ViewModel().SiteList;


        public BuildingPagee(int CurrentID)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);


            Place ThisPlace = AllPlaces.FirstOrDefault(Place => Place.id == CurrentID);
            TitlePage.BindingContext = ThisPlace as Place;

            //start Init  0 for svg
            CurrentPalazzo = ListaPalazzi.Palazzi.FirstOrDefault(x => x.id == CurrentID);
            LayerBase = CurrentPalazzo.Piani[0].Path(0);
            CurrentPlane = 1;
            //end for svg


            foreach (var x in ThisPlace.Piani)
            {
                //Nome del piano:?

                var floor = new BtnsFloor(x);
                var gr = new TapGestureRecognizer();
                gr.Tapped += Gr_Tapped;
                floor.GestureRecognizers.Add(gr);
                Piani.Children.Add(floor);
            }

            Stanze.BindingContext = ThisPlace.Piani[ThisPlace.Piani.Keys.First()];
            var FirstBtn = Piani.Children[0] as BtnsFloor;
            FirstBtn.Line.BackgroundColor = Color.Red;
        }
        //start for svg
        private Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
        private void CanvasViewOnPaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            SKCanvas canvas = e.Surface.Canvas;
            canvas.Clear();

            string LayerA = LayerBase;

            using (Stream stream = GenerateStreamFromString(LayerA))
            {
                SkiaSharp.Extended.Svg.SKSvg svg = new SkiaSharp.Extended.Svg.SKSvg();
                svg.Load(stream);

                SKImageInfo info = e.Info;
                canvas.Translate(info.Width / 2f, info.Height / 2f);

                SKRect bounds = svg.ViewBox;
                float xRatio = info.Width / bounds.Width;
                float yRatio = info.Height / bounds.Height;

                float ratio = Math.Min(xRatio, yRatio);

                canvas.Scale(ratio);
                canvas.Translate(-bounds.MidX, -bounds.MidY);

                canvas.DrawPicture(svg.Picture);
            }
        }
        //end for svg


        void Gr_Tapped(object sender, EventArgs e)
        {
            Stanze.BindingContext = ((KeyValuePair<int, List<Room>>)((sender as BtnsFloor).BindingContext)).Value;

            //Setta il piano relativo al proprio Key, e setta con id 0 = nessuna.
            CurrentPlane = ((KeyValuePair<int, List<Room>>)((sender as BtnsFloor).BindingContext)).Key;
            LayerBase = CurrentPalazzo.Piani.FirstOrDefault(PianoSVG => PianoSVG.id == CurrentPlane).Path(0);
            canvasView.InvalidateSurface();


            var ThisBtn = sender as BtnsFloor;
            foreach (BtnsFloor btn in Piani.Children)
            {
                btn.Line.BackgroundColor = ThisBtn == btn ? Color.Red : Color.Transparent;
            }
        }

        //Stanze selected and color
        private void OnItemSelected(Object sender, ItemTappedEventArgs e)
        {
            if (SelectedRoom == null || e.Item as Room != SelectedRoom)
            {
                int index = (e.Item as Room).id;
                CurrentPlane = (e.Item as Room).plan;
                LayerBase = CurrentPalazzo.Piani.FirstOrDefault(PianoSVG => PianoSVG.id == CurrentPlane).Path(index);
                canvasView.InvalidateSurface();
                SelectedRoom = e.Item as Room;
            }

            else if (e.Item as Room == SelectedRoom)
            {
                Navigation.PushAsync(new RoomDetailPage(e.Item as Room));
            }
        }

    }

}