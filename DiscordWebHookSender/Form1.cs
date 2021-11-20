using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Net;

namespace DiscordWebHookSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sendWebHook(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        public static void sendWebHook(string url, string msg, string username)
        { 
            WebClient wc = new WebClient();

            try
            {
                wc.UploadValues(url, new NameValueCollection
                {
                    {
                        "content", msg
                    },
                    {
                        "username", username
                    }
                });
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "디스코드 웹훅 전송기 (제작자: x64#5913)";
        }
    }
}
