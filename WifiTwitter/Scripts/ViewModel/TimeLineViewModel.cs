using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WifiTwitter
{
	public class TimeLineViewModel : INotifyPropertyChanged
	{

		private ObservableCollection<TimeLineCell> cells = new ObservableCollection<TimeLineCell>();

		public event PropertyChangedEventHandler PropertyChanged;
		void OnPropertyChanged([CallerMemberName] string name = null) =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

		public ObservableCollection<TimeLineCell> TimeLineCells 
		{
			set {
				cells = value;
				PropertyChanged(this, new PropertyChangedEventArgs("TimeLineCells"));
			}
			get { return cells; }
		}

		public TimeLineViewModel()
		{
			GetTimeLine();
		}

		public async Task<bool> RefreshTimeLine()
		{
			var cnt = 0;
			foreach (var t in await TwitterTokenManager.Instance.MyToken.Statuses.HomeTimelineAsync(count => cells.Count))
			{
				Debug.WriteLine(cnt + " : " + t.Text);
				//TimeLineCells[cnt].CellNumber = cnt.ToString();
				TimeLineCells[cnt].UserName = t.User.Name;
				TimeLineCells[cnt].TweetText = t.Text;
				cnt += 1;
			}
			return true;
		}

		private async void GetTimeLine()
		{
			foreach (var t in await TwitterTokenManager.Instance.MyToken.Statuses.HomeTimelineAsync(count => 50))
			{
				Debug.WriteLine(t.Text);
				var cell = new TimeLineCell();
				cell.UserName = t.User.Name;
				cell.TweetText = t.Text;
				TimeLineCells.Add(cell);
			}
		}
	}
}
