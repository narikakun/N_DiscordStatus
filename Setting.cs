using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N_DiscordStatus
{
    public partial class Setting : Form
    {
        Form1 form1;
        public Setting(Form1 __form1)
        {
            InitializeComponent();
            form1 = __form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Discord_ID = textBox1.Text;
            Properties.Settings.Default.Save();
            form1.getStatus();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.Discord_ID;
        }
    }
}
