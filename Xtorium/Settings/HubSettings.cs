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
    public partial class HubSettings : UserControl
    {
        public HubSettings()
        {
            InitializeComponent();

            ConfirmationLabel.Visible = false;
            ConfirmationPanel.Visible = false;

            if (Properties.Settings.Default.ThemeWorB == "White")
            {
                this.BackColor = Color.White;
                button1.BackColor = Color.FromArgb(55, 53, 54);
                button1.ForeColor = Color.White;
                label1.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                checkBox1.ForeColor = Color.Black;
                checkBox2.ForeColor = Color.Black;
                checkBox4.ForeColor = Color.Black;
            }

            if (Properties.Settings.Default.ThemeWorB == "Dark")
            {
                this.BackColor = Color.FromArgb(33, 33, 33);
                button1.BackColor = Color.FromArgb(246, 246, 246);
                button1.ForeColor = Color.Black;
                label1.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                checkBox1.ForeColor = Color.White;
                checkBox2.ForeColor = Color.White;
                checkBox4.ForeColor = Color.White;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            ConfirmationLabel.Visible = false;
            ConfirmationPanel.Visible = false;
        }

        private void HubSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
