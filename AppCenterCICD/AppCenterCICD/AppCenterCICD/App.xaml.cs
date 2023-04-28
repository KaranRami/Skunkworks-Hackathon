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

        protected override async void OnStart()
        {
            AppCenter.Start("android=a876377b-ef81-471e-b431-de1dc93ba89f;" +
                  "ios=46293791-1e28-47f6-a050-c0e8a328b9a5;" +
                  typeof(Analytics), typeof(Crashes));
            Crashes.FailedToSendErrorReport += Crashes_FailedToSendErrorReport;
            Crashes.SendingErrorReport += Crashes_SendingErrorReport; ;
            Crashes.SentErrorReport += Crashes_SentErrorReport;

            if (!await Analytics.IsEnabledAsync())
                await Analytics.SetEnabledAsync(true);

            if (!await Crashes.IsEnabledAsync())
                await Crashes.SetEnabledAsync(true);
        }

        private void Crashes_SentErrorReport(object sender, SentErrorReportEventArgs e)
        {
        }

        private void Crashes_SendingErrorReport(object sender, SendingErrorReportEventArgs e)
        {
        }

        private void Crashes_FailedToSendErrorReport(object sender, FailedToSendErrorReportEventArgs e)
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
