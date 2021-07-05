using HtmlParserTest.Core;
using HtmlParserTest.Core.HTMLParser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HtmlParserTest
{
    public partial class Form1 : Form
    {
        ParserWorker<string[]> parser;
        public Form1()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(
                new HTMLParser()
                );
            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            ListTitles.Items.AddRange(arg2);
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("Done!");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            parser.ParserSettings = new HTMLParserSettings((int)NumStart.Value, (int)NumEnd.Value);
            parser.Start();
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }
    }
}
