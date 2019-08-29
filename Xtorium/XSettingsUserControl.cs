using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xtorium
{
    public partial class XSettingsUserControl : UserControl
    {
        public XSettingsUserControl()
        {
            InitializeComponent();
            panel6.BackColor = Properties.Settings.Default.FavColor;
            button8.Text = Properties.Settings.Default.NameID;

            if (Properties.Settings.Default.ThemeWorB == "White")
            {
                label9.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                ContentPanel.BackColor = Color.White;
                Menu1.BackColor = Color.FromArgb(246, 246, 246);

                button1.ForeColor = Color.Black;
                button1.BackColor = Color.FromArgb(246, 246, 246);
                button2.ForeColor = Color.Black;
                button2.BackColor = Color.FromArgb(246, 246, 246);
                button6.ForeColor = Color.Black;
                button6.BackColor = Color.FromArgb(246, 246, 246);
                button4.ForeColor = Color.Black;
                button4.BackColor = Color.FromArgb(246, 246, 246);
                button7.ForeColor = Color.Black;
                button7.BackColor = Color.FromArgb(246, 246, 246);
                button5.ForeColor = Color.Black;
                button5.BackColor = Color.FromArgb(246, 246, 246);
                button8.ForeColor = Color.Black;
                button8.BackColor = Color.FromArgb(246, 246, 246);

            }

            if (Properties.Settings.Default.ThemeWorB == "Dark")
            {
                label9.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                ContentPanel.BackColor = Color.FromArgb(33, 33, 33);
                Menu1.BackColor = Color.FromArgb(55, 53, 54);

                button1.ForeColor = Color.White;
                button1.BackColor = Color.FromArgb(55, 53, 54);
                button2.ForeColor = Color.White;
                button2.BackColor = Color.FromArgb(55, 53, 54);
                button6.ForeColor = Color.White;
                button6.BackColor = Color.FromArgb(55, 53, 54);
                button4.ForeColor = Color.White;
                button4.BackColor = Color.FromArgb(55, 53, 54);
                button7.ForeColor = Color.White;
                button7.BackColor = Color.FromArgb(55, 53, 54);
                button5.ForeColor = Color.White;
                button5.BackColor = Color.FromArgb(55, 53, 54);
                button8.ForeColor = Color.White;
                button8.BackColor = Color.FromArgb(55, 53, 54);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            BrowserSettings BrowserS = new BrowserSettings();
            ContentPanel.Controls.Add(BrowserS);
            ContentPanel.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            PersonalizationSettings PersonalizationS = new PersonalizationSettings();
            ContentPanel.Controls.Add(PersonalizationS);
            ContentPanel.Dock = DockStyle.Fill;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            HubSettings HubS = new HubSettings();
            ContentPanel.Controls.Add(HubS);
            ContentPanel.Dock = DockStyle.Fill;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            AboutSettings AboutS = new AboutSettings();
            ContentPanel.Controls.Add(AboutS);
            ContentPanel.Dock = DockStyle.Fill;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            AppsSettings AppsS = new AppsSettings();
            ContentPanel.Controls.Add(AppsS);
            ContentPanel.Dock = DockStyle.Fill;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            ForDevelopers ForDevs = new ForDevelopers();
            ContentPanel.Controls.Add(ForDevs);
            ContentPanel.Dock = DockStyle.Fill;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            UserAccountSettings AccountS = new UserAccountSettings();
            ContentPanel.Controls.Add(AccountS);
            ContentPanel.Dock = DockStyle.Fill;
        }
    }
}
