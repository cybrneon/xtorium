using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Xtorium
{
    public partial class AboutSettings : UserControl
    {
        public AboutSettings()
        {
            InitializeComponent();

            label2.ForeColor = Properties.Settings.Default.FavColor;
            label8.Text = Properties.Settings.Default.NameID;

            if (Properties.Settings.Default.ThemeWorB == "White")
            {
                this.BackColor = Color.White;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                label11.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;
                button2.BackColor = Color.FromArgb(55, 53, 54);

            }

            if (Properties.Settings.Default.ThemeWorB == "Dark")
            {
                this.BackColor = Color.FromArgb(33, 33, 33);
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label10.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label9.ForeColor = Color.White;
                label11.ForeColor = Color.White;
                label12.ForeColor = Color.White;
                button2.BackColor = Color.FromArgb(246, 246, 246);
                button2.ForeColor = Color.Black;

            }
        }

        private void label8_Paint(object sender, PaintEventArgs e)
        {
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            label10.Text = String.Format("Version {0}", version);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            var Ui = wc.DownloadString("http://adamclouderupdates.x10.bz/Xtorium_Updates/newupdate.txt");
            if (Ui.Contains(Application.ProductVersion))
            {
                MessageBox.Show("Congratulation! You are running the latest version of Xtorium!", "Xtorium Updater", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("A new update is available! Would you like to download it?", "Xtorium Updater - New Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Xtorium.Settings.UpdateAvailable NewUpdate = new Xtorium.Settings.UpdateAvailable();
                    NewUpdate.Show();
                }
            }
        }

        private void AboutSettings_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            XEE EasterEgg = new XEE();
            EasterEgg.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
