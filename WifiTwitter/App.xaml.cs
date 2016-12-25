using Xamarin.Forms;

namespace WifiTwitter
{
	public partial class App : Application
	{
		private HomePage home = new HomePage();
		private LoginPage login = new LoginPage();

		public App()
		{
			InitializeComponent();

			//var nextPage = home;
			var nextPage = login;

			MainPage = new NavigationPage(nextPage)
			{
				BarBackgroundColor = Color.FromRgba(0.2, 0.6, 0.86, 1),
				BarTextColor = Color.White
			};
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
