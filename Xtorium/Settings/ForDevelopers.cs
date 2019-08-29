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
    public partial class ForDevelopers : UserControl
    {
        public ForDevelopers()
        {
            InitializeComponent();

            if (Properties.Settings.Default.ThemeWorB == "White")
            {
                this.BackColor = Color.White;
                panel1.BackColor = Color.FromArgb(55, 53, 54);
                label8.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label10.ForeColor = Color.White;
                label12.ForeColor = Color.White;
                panel2.BackColor = Color.FromArgb(55, 53, 54);
                panel3.BackColor = Color.FromArgb(55, 53, 54);
                panel4.BackColor = Color.FromArgb(55, 53, 54);
                panel6.BackColor = Color.FromArgb(55, 53, 54);
                panel5.BackColor = Color.FromArgb(55, 53, 54);
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label7.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label9.ForeColor = Color.White;
                label11.ForeColor = Color.White;
                label13.ForeColor = Color.White;
                label14.ForeColor = Color.White;
                panel5.BackColor = Color.FromArgb(55, 53, 54);
                label15.ForeColor = Color.White;
                label16.ForeColor = Color.White;
                label17.ForeColor = Color.White;
                label18.ForeColor = Color.Black;

            }

            if (Properties.Settings.Default.ThemeWorB == "Dark")
            {
                this.BackColor = Color.FromArgb(33, 33, 33);
                panel1.BackColor = Color.FromArgb(246, 246, 246);
                label8.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;
                panel2.BackColor = Color.FromArgb(246, 246, 246);
                panel3.BackColor = Color.FromArgb(246, 246, 246);
                panel4.BackColor = Color.FromArgb(246, 246, 246);
                panel6.BackColor = Color.FromArgb(246, 246, 246);
                panel5.BackColor = Color.FromArgb(246, 246, 246);
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label7.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                label11.ForeColor = Color.Black;
                label13.ForeColor = Color.Black;
                label14.ForeColor = Color.Black;
                panel5.BackColor = panel5.BackColor = Color.FromArgb(246, 246, 246);
                label15.ForeColor = Color.Black;
                label16.ForeColor = Color.Black;
                label17.ForeColor = Color.Black;
                label18.ForeColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Welcome we = new Welcome();
            we.Show();
        }
    }
}
