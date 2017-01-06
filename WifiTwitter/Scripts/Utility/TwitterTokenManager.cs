using System;
using System.Threading.Tasks;

using CoreTweet;

namespace WifiTwitter
{
	public class TwitterTokenManager
	{
		private static TwitterTokenManager instance;
		public static TwitterTokenManager Instance
		{
			get {
				if (instance != null)
				{
					return instance;
				}
				else {
					instance = new TwitterTokenManager();
					if (SaveDataUtility.CheckData(TwitterTokenManager.ACCESS_TOKEN_KEY)
					   && SaveDataUtility.CheckData(TwitterTokenManager.TOKEN_SECRET_KEY))
					{
						instance.LoadToken();
						instance.CreateToken();
					}
					return instance;
				}
			}
		}

		public const string CONSUMER_KEY = "FzKhdsqL2lYyLDydKURCFhEVB";
		public const string CONSUMER_SECRET = "ID2MbQTy5nuBJ1zQIJfazNzbQDgvkeZYdokMKB48D9Rfvu97p1";
		public const string ACCESS_TOKEN_KEY = "ACCESS_TOKEN_KEY";
		public const string TOKEN_SECRET_KEY = "TOKEN_SECRET_KEY";

		private Tokens token;
		private string accessToken;
		private string tokenSecret;

		public Tokens MyToken
		{
			get {
				return token;
			}
		}

		public string AccessToken 
		{
			get {
				return accessToken;
			}
			set {
				accessToken = value;
			}
		}

		public string TokenSecret
		{
			get {
				return tokenSecret;
			}
			set {
				tokenSecret = value;
			}
		}

		public async Task<bool> CreateTokenForPinCode(OAuth.OAuthSession session, string pinCode)
		{
			try
			{
				token = await session.GetTokensAsync(pinCode);
				accessToken = token.AccessToken;
				tokenSecret = token.AccessTokenSecret;
				SaveToken();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public void CreateToken()
		{
			token = Tokens.Create(CONSUMER_KEY, CONSUMER_SECRET, accessToken, tokenSecret);
			accessToken = token.AccessToken;
			tokenSecret = token.AccessTokenSecret;
			SaveToken();
		}

		public void SaveToken() 
		{
			SaveDataUtility.Save(ACCESS_TOKEN_KEY, accessToken);
			SaveDataUtility.Save(TOKEN_SECRET_KEY, tokenSecret);
		}

		public void LoadToken() 
		{
			accessToken = SaveDataUtility.Load<string>(ACCESS_TOKEN_KEY);
			tokenSecret = SaveDataUtility.Load<string>(TOKEN_SECRET_KEY);
		}

	}
}
