using System;
using System.Collections.Generic;

using Xamarin.Forms;
using CoreTweet;

namespace WifiTwitter
{
	public partial class TimeLinePage : ContentPage
	{
		private ListView listView;
		private TimeLineViewModel viewModel = new TimeLineViewModel();

		public TimeLinePage()
		{
			InitializeComponent();

			BindingContext = viewModel;

			listView = this.FindByName<ListView>("list");
			listView.Refreshing += async (sender, e) =>
			{
				listView.IsRefreshing = true;
				if (await viewModel.RefreshTimeLine())
				{
					listView.IsRefreshing = false;
				}
			};
		}
	}
}
