using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace WifiTwitter
{
	public class HomeViewModel : ContentPage
	{
		public ObservableCollection<TimeLineCell> TimeLine { get; set; }

		public HomeViewModel()
		{

		}
	}
}

