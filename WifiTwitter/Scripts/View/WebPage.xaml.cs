using System;
using System.Collections.Generic;

using Xamarin.Forms;
using CoreTweet;

namespace WifiTwitter
{
	public partial class WebPage : ContentPage
	{
		public WebPage(string uri)
		{
			InitializeComponent();

			var web = this.FindByName<WebView>("webView");
			web.Source = uri;
		}

		private async void ClosePage() 
		{
			await Navigation.PopAsync();
		}
	}
}
