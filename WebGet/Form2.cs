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
    public partial class Form2 : Form
    {
        string URL;
        WebClient wc = new WebClient();
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            URL = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(URL == "")
            {

            }
            else
            {
                while (true)
                {
                    try
                    {
                        string text = wc.DownloadString(URL);
                    }
                    catch
                    {
                        this.Close();
                    }
                }
            }
        }
    }
}
