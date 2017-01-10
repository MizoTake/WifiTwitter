using System;

using CoreTweet;

namespace WifiTwitter
{
	/*
	public static class AppStaticVariables
	{
		public const string API_KEY = "FzKhdsqL2lYyLDydKURCFhEVB";
		public const string API_SECRET = "ID2MbQTy5nuBJ1zQIJfazNzbQDgvkeZYdokMKB48D9Rfvu97p1";

		private static Tokens token;
		public static Tokens MyToken {
			get {
				//if(AccessToken != null && tokenSecret != null) token = Tokens.Create(API_KEY, API_SECRET, AccessToken, TokenSecret);
				return token;
			}
			set {
				token = value;
				SaveDataUtility.Save<string>(EnumToken.AccessToken.ToString(), token.AccessToken);
				SaveDataUtility.Save<string>(EnumToken.AccessTokenSecret.ToString(), token.AccessTokenSecret);
			}
		}

		private static string accessToken = "";
		public static string AccessToken {
			get {
				accessToken = SaveDataUtility.Load<string>(EnumToken.AccessToken.ToString());
				return accessToken;
			}
			set {
				accessToken = value;
				SaveDataUtility.Save<string>(EnumToken.AccessToken.ToString(), accessToken);
			}
		}

		private static string tokenSecret = "";
		public static string TokenSecret
		{
			get
			{
				tokenSecret = SaveDataUtility.Load<string>(EnumToken.AccessToken.ToString());
				return tokenSecret;
			}
			set
			{
				tokenSecret = value;
				SaveDataUtility.Save<string>(EnumToken.AccessTokenSecret.ToString(), tokenSecret);
			}
		}
	}
*/
}
