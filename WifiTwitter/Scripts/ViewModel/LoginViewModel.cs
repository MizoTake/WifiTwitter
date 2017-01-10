using System;
using System.Threading.Tasks;

using Xamarin.Forms;
using CoreTweet;

namespace WifiTwitter
{
	public class LoginViewModel
	{
		private OAuth.OAuthSession session;

		public OAuth.OAuthSession Session { get { return session; } }

		public async Task<bool> CreateToken(string pinCode) 
		{
			return await TwitterTokenManager.Instance.CreateTokenForPinCode(session, pinCode);
		}

		public async Task<string> CreatePin() 
		{
			session = await OAuth.AuthorizeAsync(TwitterTokenManager.CONSUMER_KEY, TwitterTokenManager.CONSUMER_SECRET);
			//Device.OpenUri(new Uri(session.AuthorizeUri.AbsoluteUri));
			return session.AuthorizeUri.AbsoluteUri;
		}

		public void OpenTwitterBrowser()
		{
			Device.OpenUri(new Uri("https://twitter.com"));
		}
	}
}
