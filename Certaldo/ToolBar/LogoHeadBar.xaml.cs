using System;
using System.Collections.Generic;
using System.Linq;
using Rg.Plugins.Popup.Pages;

using Xamarin.Forms;

namespace Certaldo.ToolBar
{
    public partial class LogoHeadBar : PopupPage
    {
        public LogoHeadBar()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {

            Navigation.PopAsync();
        }
    }
}
