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
				if (await viewModel.SaveToken(pin.Text))
				{
					await Navigation.PushModalAsync(new HomePage());
				}
			};

			var signup = this.FindByName<ToolbarItem>("SignupButton");
			signup.Clicked += (sender, e) =>
			{
				viewModel.OpenTwitterBrowser();
			};
		}

		private async void SetupApp()
		{
			if (SaveDataUtility.CheckData("tokens"))
			{
				await Navigation.PushModalAsync(new HomePage());
			}
			else {
				viewModel.SetupLogin();
			}
		}
	}
}