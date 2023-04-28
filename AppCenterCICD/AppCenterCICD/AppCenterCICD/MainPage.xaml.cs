using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
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

        private void CrashApp_Clicked(object sender, EventArgs e)
        {
            throw new Exception(entMessage.Text);
        }

        private void HandledCrashApp_Clicked(object sender, EventArgs e)
        {
            try
            {
                throw new Exception(entMessage.Text);
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
            }
            DisplayAlert("Success", "Crash Exception Logged", "OK");
        }

        private void LogMessage_Clicked(object sender, EventArgs e)
        {
            Analytics.TrackEvent(entMessage.Text);
            DisplayAlert("Success", "Log Message Successed", "OK");
        }
    }
}
