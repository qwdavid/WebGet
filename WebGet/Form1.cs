using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace WebGet
{
    public partial class Form1 : Form
    {
        string URL;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(URL);
            textBox1.Text = "";
            WebClient wc = new WebClient();
            try
            {
                wc.Encoding = Encoding.UTF8;
                if (textBox2.Text == "")
                {
                    textBox1.Text = "Please enter the URL.";
                }
                else
                {
                    string text = wc.DownloadString(URL);
                    textBox1.Text += text;
                }
            }
            catch (WebException exc)
            {
                textBox1.Text += exc.Message;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            URL = textBox2.Text;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            string URL;
            webBrowser1.ScriptErrorsSuppressed = false;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
