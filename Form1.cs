using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace N_DiscordStatus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setTitle("接続中...");
            setColor("offline");
            getStatus();

        }

        private void setTitle(string v)
        {
            this.Text = "N_DiscordStatus [" + v + "]";
        }

        public void getStatus()
        {
            try
            {
                setTitle("更新中...");
                WebClient wc = new WebClient() { Encoding = Encoding.GetEncoding("UTF-8") };
                string discordid = Properties.Settings.Default.Discord_ID;
                string json = wc.DownloadString("https://narikakun.ndns.xyz/v1/discord-status.php?id=" + discordid);
                var json_parse = JObject.Parse(json);
                this.label1.Text = (string)json_parse["name"];
                setColor((string)json_parse["status"]);
                setTitle("正常");
                
                Console.WriteLine(json_parse);
            } catch
            {
                setTitle("更新失敗");
            }
        }

        private void setColor(string v)
        {
            if (v == "online")
            {
                this.panel1.BackColor = Color.FromArgb(67, 181, 129);
            }
            else if (v == "idle")
            {
                this.panel1.BackColor = Color.FromArgb(250, 166, 26);
            }
            else if (v == "dnd")
            {
                this.panel1.BackColor = Color.FromArgb(240, 71, 71);
            }
            else
            {
                this.panel1.BackColor = Color.FromArgb(114, 125, 138);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getStatus();
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting stg = new Setting(this);
            stg.Show();
        }

        private void 大きさを戻すToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(816, 154);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void 位置を戻すToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

        private void 最前面にするToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void 最前面を解除するToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
        }
    }
}
