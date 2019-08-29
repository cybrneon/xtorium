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
    public partial class PersonalizationSettings : UserControl
    {
        public PersonalizationSettings()
        {
            InitializeComponent();

            ChoosedColor.BackColor = Properties.Settings.Default.FavColor;
            ConfirmationLabel.Visible = false;
            ConfirmationPanel.Visible = false;

            if (Properties.Settings.Default.ThemeWorB == "White")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;

                this.BackColor = Color.White;
                button1.BackColor = Color.FromArgb(55, 53, 54);
                button1.ForeColor = Color.White;
                label3.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                radioButton1.ForeColor = Color.Black;
                radioButton2.ForeColor = Color.Black;
            }

            if (Properties.Settings.Default.ThemeWorB == "Dark")
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;

                this.BackColor = Color.FromArgb(33, 33, 33);
                button1.BackColor = Color.FromArgb(246, 246, 246);
                button1.ForeColor = Color.Black;
                label3.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChoosedColor.BackColor = Color.DarkOrange;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChoosedColor.BackColor = Color.Firebrick;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChoosedColor.BackColor = Color.MediumVioletRed;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChoosedColor.BackColor = Color.DarkMagenta;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ChoosedColor.BackColor = Color.SeaGreen;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ChoosedColor.BackColor = Color.FromArgb(0, 183, 195);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ChoosedColor.BackColor = Color.Teal;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ChoosedColor.BackColor = Color.SteelBlue;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ChoosedColor.BackColor = Color.DodgerBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                Properties.Settings.Default.ThemeWorB = radioButton1.Text;
            }
            else if(radioButton2.Checked == true)
            {
                Properties.Settings.Default.ThemeWorB = radioButton2.Text;
            }
            Properties.Settings.Default.FavColor = ChoosedColor.BackColor;
            Properties.Settings.Default.Save();

            ConfirmationLabel.Visible = true;
            ConfirmationPanel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                button2.BackColor = colorDialog1.Color;
                ChoosedColor.BackColor = colorDialog1.Color;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ChoosedColor.BackColor = Color.OrangeRed;
        }
    }
}
