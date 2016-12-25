using System;
using Xamarin.Forms;

namespace WifiTwitter
{
	public class SaveDataUtility
	{
		/// <summary>
		/// 型を指定してデータをセーブできる
		/// </summary>
		/// <typeparam name="T">セーブするデータ型</typeparam>
		/// <param name="dataKey">セーブデータのキー</param>
		/// <param name="variable">対象の変数</param>
		public static void Save<T>(string dataKey, T variable) where T : class
		{
			Application.Current.Properties[dataKey] = variable;
		}

		/// <summary>
		/// 型を指定してデータをロードする
		/// </summary>
		/// <typeparam name="T">ロードするデータ型</typeparam>
		/// <param name="dataKey">セーブされたデータのキー</param>
		/// <returns></returns>
		public static T Load<T>(string dataKey) where T : class
		{
			return (T)Application.Current.Properties[dataKey];
		}

		/// <summary>
		/// 型を指定してデータをセーブできる
		/// </summary>
		/// <typeparam name="T">セーブするデータ型</typeparam>
		/// <param name="dataKey">セーブデータのキー</param>
		/// <param name="variable">対象の変数</param>
		public static void SaveArray<T>(string dataKey, T variable) where T : class
		{
			Application.Current.Properties[dataKey] = variable;
		}

		/// <summary>
		/// 型を指定してデータをロードする
		/// </summary>
		/// <typeparam name="T">ロードするデータ型</typeparam>
		/// <param name="dataKey">セーブされたデータのキー</param>
		/// <returns></returns>
		public static T LoadArray<T>(string dataKey) where T : class
		{
			return (T)Application.Current.Properties[dataKey];
		}

		/// <summary>
		/// セーブデータがあるかチェックします
		/// </summary>
		/// <param name="dataKey">セーブされたデータのキー</param>
		/// <returns></returns>
		public static bool CheckData(string dataKey)
		{
			try
			{
				return Application.Current.Properties.ContainsKey(dataKey);
			}
			catch(Exception) {
				return false;
			}
		}

		/// <summary>
		/// セーブデータを全てクリアする
		/// </summary>
		public static void Clear()
		{
			Application.Current.Properties.Clear();
		}
	}
}
