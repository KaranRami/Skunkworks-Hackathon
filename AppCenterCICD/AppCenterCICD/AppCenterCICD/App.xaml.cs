using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCenterCICD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start("android={a876377b-ef81-471e-b431-de1dc93ba89f};" +
                  "ios={46293791-1e28-47f6-a050-c0e8a328b9a5};" +
                  typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
