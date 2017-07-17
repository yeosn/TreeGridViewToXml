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

namespace TreeGridViewToXmlTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            MindNode B = new MindNode("b2e32ca53b43", "1499742764", "B");
            root.AddChild(B);
            MindNode B1 = new MindNode("b2e32ca53b43", "1499742764", "B.1");
            B.AddChild(B1);
            MindNode B11 = new MindNode("b2e32ca53b43", "1499742764", "B.1.1");
            B1.AddChild(B11);
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
    }
}
