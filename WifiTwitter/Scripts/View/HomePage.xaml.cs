using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WifiTwitter
{
	public partial class HomePage : TabbedPage
	{
		private HomeViewModel viewModel = new HomeViewModel();
		private TimeLinePage timeLine = new TimeLinePage();

		public HomePage()
		{
			InitializeComponent();

			Children.Add(timeLine);
		}
	}
}
