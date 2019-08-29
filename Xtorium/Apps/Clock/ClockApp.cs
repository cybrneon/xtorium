using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xtorium.Apps;

namespace Xtorium
{
    public partial class ClockApp : UserControl
    {
        public ClockApp()
        {
            InitializeComponent();

            panel6.BackColor = Properties.Settings.Default.FavColor;

            if (Properties.Settings.Default.ThemeWorB == "White")
            {
                this.BackColor = Color.FromArgb(246, 246, 246);

                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                infoButton.BackgroundImage = Properties.Resources.info_96px;
            }

            if (Properties.Settings.Default.ThemeWorB == "Dark")
            {
                this.BackColor = Color.FromArgb(55, 53, 54);

                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;

                infoButton.BackgroundImage = Properties.Resources.info_96px_w;
            }
        }

        private void ClockApp_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
            label3.Text = DateTime.Now.ToString("MMM dd");
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
