using System;
using System.Collections.Generic;

using Xamarin.Forms;
using CoreTweet;

namespace WifiTwitter
{
	public partial class LoginPage : ContentPage
	{
		private LoginViewModel viewModel = new LoginViewModel();

		public LoginPage()
		{
			InitializeComponent();

			Bind();

			SetupApp();
		}

		private void Bind()
		{
			var pin = this.FindByName<Entry>("pinCode");
			var ok = this.FindByName<Button>("okButton");
			ok.Clicked += async (sender, e) => 
			{
				var check = await viewModel.CreateToken(pin.Text);
				if (check)
				{
					await Navigation.PushModalAsync(new HomePage());
				}
				else {
					await DisplayAlert("Your PinCode is incorrect.", "Please Retry", "OK");
				}
			};

			var webView = this.FindByName<WebView>("web");
			var cPin = this.FindByName<Button>("createPin");
			cPin.Clicked += async (sender, e) => 
			{
				webView.Source = await viewModel.CreatePin();
			};

			var signup = this.FindByName<ToolbarItem>("SignupButton");
			signup.Clicked += (sender, e) =>
			{
				viewModel.OpenTwitterBrowser();
			};
		}

		private async void SetupApp()
		{
			if (TwitterTokenManager.Instance.MyToken != null)
			{
				await Navigation.PushModalAsync(new HomePage());
			}
		}
	}
}