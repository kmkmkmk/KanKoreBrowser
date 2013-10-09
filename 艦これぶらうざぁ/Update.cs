using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace 艦これぶらうざぁ
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
            check();
        }

        private void Recheck_Click(object sender, EventArgs e)
        {
            check();
        }

        private void Download_Click(object sender, EventArgs e)
        {
            Process.Start("http://info.iesaba.com/kankore/download.htm");
        }

        private void check()
        {
            // Assembly取得
            Assembly asm = Assembly.GetExecutingAssembly();
            Version ver = asm.GetName().Version;

            // label2にバージョン表示
            label2.Text = ver.ToString();

            try
            {
                // xmlを外部から読み込み
                XmlTextReader reader = new XmlTextReader("http://files.iesaba.com/update/kankore.xml");

                //XMLファイルを1ノードずつ読み込む
                // *memo <tag>value</tag>の形式で
                while (reader.Read())
                {
                    reader.MoveToContent();
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.LocalName.Equals("version"))
                        {
                            // バージョンを追加
                            label4.Text = reader.ReadString();
                        }
                        if (reader.LocalName.Equals("date"))
                        {
                            // 日時を追加
                            NewsText.Text = "最終更新日時: " + reader.ReadString();
                        }
                        if (reader.LocalName.Equals("text"))
                        {
                            // 本文を追加
                            // *memo 改行はXML側でacceptsreturn="True"にした上でコード内でリプレースする
                            string line = reader.ReadString().Replace("\n", "\r\n");
                            NewsText.AppendText("\r\n\r\n更新内容: " + line);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("インターネットに接続されていない、又は更新サーバーがダウンしています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
