using Microsoft.AppCenter.Analytics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCenterCICD
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LogMessage_Clicked(object sender, EventArgs e)
        {
            Analytics.TrackEvent(entMessage.Text);
        }

        private void CrashApp_Clicked(object sender, EventArgs e)
        {
            throw new Exception(entMessage.Text);
        }
    }
}
