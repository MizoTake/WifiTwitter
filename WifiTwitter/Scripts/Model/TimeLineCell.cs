using System;

using Xamarin.Forms;

namespace WifiTwitter
{
	public class TimeLineCell : ViewCell
	{
		public string CellNumber { get; set; }
		//image uri
		public string UserImageUri { get; set; }

		public string ViewName { get; set; }

		public string UserName { get; set; }

		public string TweetTime { get; set; }

		public string TweetText { get; set; }

		public string[] TweetImage { get; set; }

		public string TweetMovie { get; set; }

	}
}
