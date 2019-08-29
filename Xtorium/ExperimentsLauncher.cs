using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xtorium
{
    public partial class ExperimentsLauncher : Form
    {
        public ExperimentsLauncher()
        {
            InitializeComponent();

            label2.Visible = false;
            xtoriumGradientPanel1.Visible = false;
            label2.Visible = false;
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LaunchExperiment();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    LaunchExperiment();
                }
        }

        private void LaunchExperiment()
        {

            if (textBox1.Text == "restart")
            {
                Application.Restart();
            }

            if (textBox1.Text == "exitbox")
            {
                exitBox ExitDialog = new exitBox();
                ExitDialog.Show();
            }

            if (textBox1.Text == "newtab")
            {
                Form11 Form11NEWTAB = new Form11();
                Form11NEWTAB.Show();
            }

            else
            {
                xtoriumGradientPanel1.Visible = true;
                label2.Visible = true;
                label2.Text = "Incorrect Command. Please try another one.";
                xtoriumGradientPanel1.BackColor = Color.Red;
            }
        }

        private void ExperimentsLauncher_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
