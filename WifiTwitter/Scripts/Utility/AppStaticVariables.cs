using System;

using CoreTweet;

namespace WifiTwitter
{
	public static class AppStaticVariables
	{
		private static Tokens tokens;
		public static Tokens Tokens {
			get {
				tokens = SaveDataUtility.Load<Tokens>("tokens");
				return tokens;
			}
			set {
				tokens = value;
				SaveDataUtility.Save<Tokens>("tokens", tokens);
				/*
				SaveDataUtility.Save<string>(EnumToken.AccessToken.ToString(), tokens.AccessToken);
				SaveDataUtility.Save<string>(EnumToken.AccessTokenSecret.ToString(), tokens.AccessTokenSecret);
				*/
			}
		}
	}
}
