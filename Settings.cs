using System;
using System.IO;

namespace 艦これぶらうざぁ
{
    [Serializable()]
    public class Settings
    {
        //設定を保存するフィールド
        /*private string user;
        private string pass;*/
        private string save;

        //設定のプロパティ
        /*public string user_s
        {
            get { return user; }
            set { user = value; }
        }

        public string pass_s
        {
            get { return pass; }
            set { pass = value; }
        }*/

        public string save_s
        {
            get { return save; }
            set { save = value; }
        }

        //Settingsクラスのただ一つのインスタンス
        [NonSerialized()]
        private static Settings _instance;
        [System.Xml.Serialization.XmlIgnore]
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

        //設定をXMLファイルから読み込み復元する
        public static void LoadFromXmlFile()
        {
            string path = GetSettingPath();

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof(Settings));
            object obj = xs.Deserialize(fs);
            fs.Close();

            Instance = (Settings)obj;
        }

        //現在の設定をXMLファイルに保存する
        public static void SaveToXmlFile()
        {
            string path = GetSettingPath();

            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof(Settings));
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
