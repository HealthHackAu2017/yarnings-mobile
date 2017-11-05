using System;

using Xamarin.Forms;

namespace Yarnings
{
    public class YarningsWebPage : ContentPage
    {
        public YarningsWebPage()
        {

            WebView webView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://yarnings.hometreelab.com/",
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    //header,
                    webView
                }
            };
        }
    }
}

