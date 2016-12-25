using System;
using System.Threading.Tasks;

using Xamarin.Forms;
using CoreTweet;

namespace WifiTwitter
{
	public class LoginViewModel
	{
		private const string API_KEY = "FzKhdsqL2lYyLDydKURCFhEVB";
		private const string API_SECRET = "ID2MbQTy5nuBJ1zQIJfazNzbQDgvkeZYdokMKB48D9Rfvu97p1";
		private OAuth.OAuthSession session;

		public OAuth.OAuthSession Session { get { return session; } }

		public LoginViewModel() { }

		public async Task<bool> SaveToken(string pinCode) 
		{
			try
			{
				AppStaticVariables.Tokens = await session.GetTokensAsync(pinCode);
				return true;
			}
			catch(Exception) {
				return false;
			}
		}

		public async void SetupLogin() 
		{
			session = await OAuth.AuthorizeAsync(API_KEY, API_SECRET);
			Device.OpenUri(new Uri(session.AuthorizeUri.AbsoluteUri));
		}

		public void OpenTwitterBrowser()
		{
			Device.OpenUri(new Uri("https://twitter.com"));
		}
	}
}
