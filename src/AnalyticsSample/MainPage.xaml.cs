using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace AnalyticsSample
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private string _color;
        private string _city;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCityClicked(object sender, EventArgs e)
        {
            var imageButton = sender as ImageButton;

            if (imageButton == parisBtn)
                _city = "Paris";
            else if (imageButton == beijingBtn)
                _city = "Beijing";
            else if (imageButton == seattleBtn)
                _city = "Seattle";
        }

        private void OnColorButtonClicked(object sender, EventArgs e)
        {
            var btn = sender as Button;

            _color = btn?.Text;
        }

        private void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            if (_color == null || _city == null)
                return;

            var parameters = new Dictionary<string, string>
            {
                { "Color", _color },
                { "City", _city }
            };
            Analytics.TrackEvent("MyEvent", parameters);
        }
    }
}
