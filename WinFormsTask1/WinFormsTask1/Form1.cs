using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label_clock.Text = DateTime.Now.ToShortTimeString();
        }

        private void button_baku_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Baku;
            BackgroundImageLayout = ImageLayout.Stretch;
            label_clock.Text = DateTime.Now.ToShortTimeString();
        }

        private void button_london_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.London;
            BackgroundImageLayout = ImageLayout.Stretch;
            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            DateTimeOffset currentTime = TimeZoneInfo.ConvertTime(DateTimeOffset.Now, tzi);
            label_clock.Text = currentTime.DateTime.ToShortTimeString();
        }

        private void button_donttouchme_MouseEnter(object sender, EventArgs e)
        {
            var rnd = new Random();

            button_donttouchme.Location = new Point(rnd.Next(1, 400), rnd.Next(1, 250));
        }
    }
}
