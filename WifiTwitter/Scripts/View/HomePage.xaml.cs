using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WifiTwitter
{
	public partial class HomePage : TabbedPage
	{
		private HomeViewModel viewModel = new HomeViewModel();

		public HomePage()
		{
			InitializeComponent();

			//BindingContext = viewModel;
		}
	}
}
