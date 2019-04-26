using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Certaldo.Pages
{
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DelayedSplashPage();
            Debug.WriteLine("apparsa splashpage");
        }

        public void DelayedSplashPage()
        {
            var t = Task.Run(async delegate
            {
                await Task.Delay(TimeSpan.FromSeconds(2.5));
            });
            t.Wait();
            Console.WriteLine("Task t Status: {0}", t.Status);
            OpenStartMenuPage();
        }

        public void OpenStartMenuPage()
        {
           Navigation.PushAsync(new StartMenu());
        }

        void Handle_OpenStartMenuPage(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new StartMenu());
        }
    }

}