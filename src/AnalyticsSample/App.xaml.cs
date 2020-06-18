using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace AnalyticsSample
{
    public partial class App : Application
    {
        const string AppCenteriOSKey = "<Your App Center iOS Key>";
        const string AppCenterAndroidKey = "<Your App Center Android Key>";

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start($"ios={AppCenteriOSKey};android={AppCenterAndroidKey}", typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
