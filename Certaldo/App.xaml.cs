using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//using Certaldo.Views;
using Certaldo.Pages;
using Rg.Plugins.Popup.Services;
using Parallelo.Data;
using Certaldo.Models;
using Parallelo;
using System.Collections.Generic;
using System.Linq;
using System.IO;

//[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Certaldo
{
    public partial class App : Application
    {

        public Datasource<DatasourceModel, BaseSettingsModel> Datasource = new Datasource<DatasourceModel, BaseSettingsModel>
        {
            Database = new Uri("http://certaldo.parallelo.it/get/all"),
            Version = new Uri("http://certaldo.parallelo.it/version"),

            ImageFinders = new List<Func<DatasourceModel, ImageFileInfo[]>>()
              {
                  {
                      model => model.Places.Select(site => site.photos.Select(photo => photo.File)).SelectMany(i => i).Select(file => new ImageFileInfo() {
                         Name = file,
                         Path = "Photos",
                         Bytes = 0,
                         Uri = new Uri(Path.Combine("http://certaldo.parallelo.it/uploads/photos/thumbs/", "thumb." + file))

                      }).ToArray()
                  }
              }
        };


        public App()
        {
            InitializeComponent();

            Localization.Current.Init("it", false, "en", "it");
            MainPage = Datasource.UpdaterPage;
            Datasource.OnInitialized += Datasource_OnInitialized;
        }

        void Datasource_OnInitialized(object sender, EventArgs e)
        {
            MainPage = new NavigationPage(new SplashPage());
        }


        protected override void OnStart()
        {
            Datasource.Update();
        }

        protected override void OnSleep()
        {

        }

        protected override void OnResume()
        {

        }
    }
}