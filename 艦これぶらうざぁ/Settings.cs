using System;
using System.IO;
using System.Xml.Serialization;

namespace 艦これぶらうざぁ
{
	[Serializable()]
	public class Settings
	{
		//設定を保存するフィールド
		private string token;

		private string select;
		private string tokenurl;
		private string save;
		private string lastsave;
		private string hashtag;

		// 設定のプロパティ
		public string token_s
		{
			get { return token; }
			set { token = value; }
		}

		public string select_s
		{
			get { return select; }
			set { select = value; }
		}

		public string tokenurl_s
		{
			get { return tokenurl; }
			set { tokenurl = value; }
		}

		public string save_s
		{
			get { return save; }
			set { save = value; }
		}

		public string lastsave_s
		{
			get { return lastsave; }
			set { lastsave = value; }
		}

		public string hashtag_s
		{
			get { return hashtag; }
			set { hashtag = value; }
		}

		// Settingsクラスのただ一つのインスタンス
		[NonSerialized()]
		private static Settings _instance;

		[XmlIgnore]
		public static Settings Instance
		{
			get
			{
				if (_instance == null)
					_instance = new Settings();
				return _instance;
			}
			set { _instance = value; }
		}

		// 設定をXMLファイルから読み込み復元する
		public static void LoadFromXmlFile()
		{
			string path = GetSettingPath();

			FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
			XmlSerializer xs = new XmlSerializer(typeof(Settings));
			object obj = xs.Deserialize(fs);
			fs.Close();

			Instance = (Settings)obj;
		}

		// 現在の設定をXMLファイルに保存する
		public static void SaveToXmlFile()
		{
			string path = GetSettingPath();

			FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
			XmlSerializer xs = new XmlSerializer(typeof(Settings));
			xs.Serialize(fs, Instance);
			fs.Close();
		}

		private static string GetSettingPath()
		{
			string path = "艦これぶらうざぁ.config";
			return path;
		}
	}
}