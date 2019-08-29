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
    public partial class BrowserSettings : UserControl
    {
        public BrowserSettings()
        {
            InitializeComponent();
            URLHome.Text = Properties.Settings.Default.Home;
            URLHomeButon.Text = Properties.Settings.Default.HomeButton;

            ConfirmationLabel.Visible = false;
            ConfirmationPanel.Visible = false;

            if (Properties.Settings.Default.ThemeWorB == "White")
            {
                this.BackColor = Color.White;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                button1.BackColor = Color.FromArgb(55, 53, 54);
                button1.ForeColor = Color.White;
                URLHome.BackColor = Color.White;
                URLHome.ForeColor = Color.Black;
                URLHomeButon.BackColor = Color.White;
                URLHomeButon.ForeColor = Color.Black;
                comboBox1.BackColor = Color.White;
                comboBox1.ForeColor = Color.Black;

            }

            if (Properties.Settings.Default.ThemeWorB == "Dark")
            {
                this.BackColor = Color.FromArgb(33, 33, 33);
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                button1.BackColor = Color.FromArgb(246, 246, 246);
                button1.ForeColor = Color.Black;
                URLHome.BackColor = Color.FromArgb(33, 33, 33);
                URLHome.ForeColor = Color.White;
                URLHomeButon.BackColor = Color.FromArgb(33, 33, 33);
                URLHomeButon.ForeColor = Color.White;
                comboBox1.BackColor = Color.FromArgb(33, 33, 33);
                comboBox1.ForeColor = Color.White;
            }
        }

        private void BrowserSettings_Load(object sender, EventArgs e)
        {
            comboBox1.Text = Properties.Settings.Default.DefaultSearchEngine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Home = URLHome.Text;
            Properties.Settings.Default.HomeButton = URLHomeButon.Text;
            Properties.Settings.Default.DefaultSearchEngine = comboBox1.Text;
            Properties.Settings.Default.Save();

            ConfirmationLabel.Visible = true;
            ConfirmationPanel.Visible = true;
        }
    }
}
