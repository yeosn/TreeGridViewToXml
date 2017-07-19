using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TreeGridViewToXml;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml;
using System.IO;

namespace TreeGridViewToXmlTest
{
    public partial class Form1 : Form
    {
        private List<string> _tokenPathList;
        public Form1()
        {
            InitializeComponent();

            _tokenPathList = new List<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //创建根节点
            TgvXml tgvXml = new TgvXml();
            MindNode root = new MindNode("b2e32ca53b43", "1499742764", "For KM");
            tgvXml.SetRootMindNode(root);

            MindNode A = new MindNode("b2e32ca53b43", "1499742764", "A");
            root.AddChild(A);
            MindNode A1 = new MindNode("b2e32ca53b43", "1499742764", "A.1");
            A.AddChild(A1);
            MindNode A11 = new MindNode("b2e32ca53b43", "1499742764", "A.1.1");
            A1.AddChild(A11);
            MindNode A12 = new MindNode("b2e32ca53b43", "1499742764", "A.1.2");
            A1.AddChild(A12);
            MindNode A13 = new MindNode("b2e32ca53b43", "1499742764", "A.1.3");
            A1.AddChild(A13);
            MindNode A2 = new MindNode("b2e32ca53b43", "1499742764", "");
            A.AddChild(A2);

            MindNode B = new MindNode("b2e32ca53b43", "1499742764", "B");
            root.AddChild(B);
            MindNode B1 = new MindNode("b2e32ca53b43", "1499742764", "B.1");
            B.AddChild(B1);
            MindNode B11 = new MindNode("b2e32ca53b43", "1499742764", "B.1.1");
            B1.AddChild(B11);
            MindNode B12 = new MindNode("b2e32ca53b43", "1499742764", "");
            B1.AddChild(B12);
            MindNode B2 = new MindNode("b2e32ca53b43", "1499742764", "B.2");
            B.AddChild(B2);
            MindNode B21 = new MindNode("b2e32ca53b43", "1499742764", "B.2.1");
            B2.AddChild(B21);
            MindNode B22 = new MindNode("b2e32ca53b43", "1499742764", "B.2.2");
            B2.AddChild(B22);
            MindNode B3 = new MindNode("b2e32ca53b43", "1499742764", "B.3");
            B.AddChild(B3);

            MindNode C = new MindNode("b2e32ca53b43", "1499742764", "C");
            root.AddChild(C);

            MindNode D = new MindNode("b2e32ca53b43", "1499742764", "D");
            root.AddChild(D);

            tgvXml.Save(@"H:\aa.xml");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JosnConverter jConverter = new JosnConverter();
            jConverter.XmlToJson(@"H:\aa.xml", @"H:\aa.js");

            ////xml转换成json
            //XmlDocument doc = new XmlDocument();
            //doc.Load(@"H:\aa.xml");
            //XmlNodeConverter converter = new XmlNodeConverter();
            //string jsonText = JsonConvert.SerializeXmlNode(doc.GetElementsByTagName("root")[0], Newtonsoft.Json.Formatting.Indented);

            ////获取json中text为空的节点
            //JObject jo = JObject.Parse(jsonText);
            //JToken startToken = jo["root"];
            //GetNullTextChildren(startToken);

            ////删除json中text为空的节点
            ////JObject rss = JObject.Parse(jsonText);
            ////rss["root"]["children"][0]["children"][1].Remove();
            ////jsonText = rss.ToString();
            //jsonText = RemoveNode(jsonText);

            ////生成km文件
            //StreamWriter sw = new StreamWriter(@"H:\bb.km");
            //sw.Write(jsonText);
            //sw.Close();
        }
        
        
    }
}
