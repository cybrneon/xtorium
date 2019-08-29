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
    public partial class AppsSettings : UserControl
    {
        public AppsSettings()
        {
            InitializeComponent();

            ConfirmationLabel.Visible = false;
            ConfirmationPanel.Visible = false;

            if (Properties.Settings.Default.ThemeWorB == "White")
            {
                this.BackColor = Color.White;
                button1.BackColor = Color.FromArgb(55, 53, 54);
                button1.ForeColor = Color.White;
                button2.BackColor = Color.FromArgb(55, 53, 54);
                button2.ForeColor = Color.White;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                appListView.ForeColor = Color.Black;
                appListView.BackColor = Color.White;
                comboBox1.BackColor = Color.White;
                comboBox1.ForeColor = Color.Black;

            }

            if (Properties.Settings.Default.ThemeWorB == "Dark")
            {
                this.BackColor = Color.FromArgb(33, 33, 33);
                button1.BackColor = Color.FromArgb(246, 246, 246);
                button1.ForeColor = Color.Black;
                button2.BackColor = Color.FromArgb(246, 246, 246);
                button2.ForeColor = Color.Black;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                appListView.ForeColor = Color.White;
                appListView.BackColor = Color.FromArgb(33, 33, 33);
                comboBox1.BackColor = Color.White;
                comboBox1.ForeColor = Color.FromArgb(33, 33, 33);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            ConfirmationLabel.Visible = true;
            ConfirmationPanel.Visible = true;
        }
    }
}
